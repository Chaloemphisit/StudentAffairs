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

namespace StudentAffairs.formAuth {
    public partial class frmLogin : Syncfusion.Windows.Forms.MetroForm {
        public frmLogin() {
            InitializeComponent();
            authentication authen = new authentication();
        }

        private void frmLogin_Load(object sender, EventArgs e) {
            //MessageBox.Show("User ID : " + Settings.Default["UserID"] + ", Role ID : " + Settings.Default["UserRole"]);
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnSignin_Click(object sender, EventArgs e) {
            if (authentication.checkUser(txtUsername.Text, txtPassword.Text)) {
                MessageBox.Show("Login Complete "+Settings.Default["UserID"]+" "+ Settings.Default["UserRole"]);

            } else {
                MessageBox.Show("Login failed!");
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
    }
}
