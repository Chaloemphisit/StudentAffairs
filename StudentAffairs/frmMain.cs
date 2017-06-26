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

namespace StudentAffairs {
    public partial class frmMain : Syncfusion.Windows.Forms.MetroForm {

        public frmMain() {
            InitializeComponent();
        }

        private void StudentList_Click(object sender, EventArgs e) {
            var frmStudentList = new formData.frmStudentList();
            loadForm.showWaitForm(frmStudentList);

            ////Create and Show Main Form
            //frmStudentList.LoadCompleted += loadForm.frm_LoadCompleted;
            //frmStudentList.Show();
            //frmStudentList.Activate();
        }

        private void StudentDetail_Click(object sender, EventArgs e) {
            var frmStudentDetail = new formData.frmStudentDetail();

            //Show Wait form
            //loadForm.showWaitForm();
            //Create and Show Main Form
            frmStudentDetail.LoadCompleted += loadForm.frm_LoadCompleted;
            frmStudentDetail.Show();
        }

        private void BehaviorList_Click(object sender, EventArgs e) {
            var frmBehaviorList = new formData.frmBehaviorList();
            //Show Wait form
            //loadForm.showWaitForm();
            //Create and Show Main Form
            frmBehaviorList.LoadCompleted += loadForm.frm_LoadCompleted;
            frmBehaviorList.ShowDialog();
        }

        private void BehaviorDetail_Click(object sender, EventArgs e) {
            var frmBehaviorDetail = new formData.frmBehaviorDetail();
            //Show Wait form
           // loadForm.showWaitForm();
            //Create and Show Main Form
            frmBehaviorDetail.LoadCompleted += loadForm.frm_LoadCompleted;
            frmBehaviorDetail.Show();
        }

        private void TeacherList_Click(object sender, EventArgs e) {
            var frmTeacherList = new frmTeacherList();
            frmTeacherList.Show();
        }

        private void TeacherDetail_Click(object sender, EventArgs e) {
            var frmTeacherDetail = new frmTeacherDetail();
            frmTeacherDetail.Show();
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
            
            MessageBox.Show(Properties.Resources.strTest.ToString());
            MessageBox.Show(Properties.Resources.strTest.ToString());
        }

        private void btnOptions_Click(object sender, EventArgs e) {
            var frmOptions = new frmOptions();
            frmOptions.Show();
        }
    }
}

