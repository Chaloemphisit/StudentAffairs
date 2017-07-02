#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using StudentAffairs.Module;
using System.Text;
using System.Windows.Forms;
using StudentAffairs.Properties;
using System.Threading;
using Syncfusion.Windows.Forms;

namespace StudentAffairs.formAuth {
    public partial class frmLogin : Syncfusion.Windows.Forms.MetroForm {
        public frmLogin() {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e) {
            this.Focus();
            this.Activate();
            //MessageBoxAdv.Show("User ID : " + Settings.Default["UserID"] + ", Role ID : " + Settings.Default["UserRole"]);
            txtUsername.Text = "admin";
            txtPassword.Text = "password";
        }

        private void btnSignin_Click(object sender, EventArgs e) {
            frmWait frmWait = new frmWait();
            Thread cl = new Thread(new ThreadStart(
                () => { frmWait.captionLoad("กำลังตรวจสอบ..."); frmWait.ShowDialog(); }
                ));
            cl.Start();
            if (authentication.checkUser(txtUsername.Text, txtPassword.Text)) {
                cl.Abort();
                this.Hide();
            } else {
                cl.Abort();
                this.Activate();
                MessageBoxAdv.Show("ชื่อผู้ใช้หรือรหัสผ่านไม่ถูกต้อง กรุณาทำรายการใหม่อีกครั้ง", "รายงานความผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)13) {
                // No beep.
                e.Handled = true;
                txtPassword.Select();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)13) {
                // No beep.
                e.Handled = true;
                btnSignin.PerformClick();
            }
        }

        private void buttonAdv1_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e) {
            //Check Validateing IsNullText
            modFunction.validNullTxt(txtUsername, errorProvider1,0,"", "Username is required");
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e) {
            //Check Validateing IsNullText
            modFunction.validNullTxt(txtPassword, errorProvider1,0,"", "Password is required");
        }
    }

    }