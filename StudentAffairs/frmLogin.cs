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

namespace StudentAffairs {
    public partial class frmLogin : Syncfusion.Windows.Forms.MetroForm {
        public frmLogin() {
            InitializeComponent();
            authentication authen = new authentication();
        }

        private void frmLogin_Load(object sender, EventArgs e) {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnSignin_Click(object sender, EventArgs e) {
            if (authentication.checkUser(txtUsername.Text, txtPassword.Text)) {
                MessageBox.Show("Login Complete");
            } else {
                MessageBox.Show("Login failed!");
            }
        }
    }
}
