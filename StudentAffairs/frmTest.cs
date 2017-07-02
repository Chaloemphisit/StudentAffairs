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
using StudentAffairs.formData;
using StudentAffairs.formAuth;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using StudentAffairs.Module;

namespace StudentAffairs {
    public partial class frmTest : Syncfusion.Windows.Forms.MetroForm {
        loadForm loadForm;

        public static event EventHandler LoadCompleted;

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            this.OnLoadCompleted(EventArgs.Empty);
        }
        protected virtual void OnLoadCompleted(EventArgs e) {
            var handler = LoadCompleted;
            if (handler != null) handler(this, e);
            loadForm.eventCompleted = true;
        }

        public frmTest() {
            loadForm = new loadForm();
            InitializeComponent();
        }

        private void StudentList_Click(object sender, EventArgs e) {
            var frmStudentList = new frmStudentList();
            //loadForm.showWaitForm(frmStudentList);
            frmStudentList.Show();
        }

        private void StudentDetail_Click(object sender, EventArgs e) {
            var frmStudentDetail = new frmStudentDetail();
            loadForm.showWaitForm(frmStudentDetail);
        }

        private void BehaviorList_Click(object sender, EventArgs e) {
            var frmBehaviorList = new formData.frmBehaviorList();
            loadForm.showWaitForm(frmBehaviorList);
        }

        private void BehaviorDetail_Click(object sender, EventArgs e) {
            var frmBehaviorDetail = new formData.frmBehaviorDetail();
            loadForm.showWaitForm(frmBehaviorDetail);
        }

        private void UserList_Click(object sender, EventArgs e) {
            var frmUserList = new frmUserList();
            frmUserList.Show();
        }

        private void frmMain_Load(object sender, EventArgs e) {

        }

        private void UserDetail_Click(object sender, EventArgs e) {
            var frmUserDetail = new frmUserDetail();
            frmUserDetail.Show();
        }

        private void Login_Click(object sender, EventArgs e) {
            var frmLogin = new frmLogin();
            frmLogin.Show();
        }

        private void Logout_Click(object sender, EventArgs e) {
            authentication authentication = new authentication();
            authentication.signOut();
        }

        private void btnOptions_Click(object sender, EventArgs e) {
            var frmOptions = new frmOptions();
            frmOptions.Show();
        }
    }
}

