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
using Syncfusion.Windows.Forms;
using System.Text;
using System.Windows.Forms;
using StudentAffairs.Module;
using System.Data.OleDb;
using System.Threading;

namespace StudentAffairs.formData {
    public partial class frmUserDetail : Syncfusion.Windows.Forms.MetroForm {
        private Boolean resetPwd = false;

        public static string TeacherID { get; set; }

        public frmUserDetail() {
            frmWait frmWait = new frmWait();
            Thread splashThread = new Thread(new ThreadStart(
                    () => { Application.Run(frmWait); }));
            splashThread.SetApartmentState(ApartmentState.MTA);
            splashThread.Start();
            InitializeComponent();
            RetrieveUserRole();
            RetrieveDetail();
            splashThread.Abort();
        }

        private void btnReset_Click(object sender, EventArgs e) {
            DialogResult result = MessageBoxAdv.Show("ท่านต้องการรีเซ็ทรหัสผ่านใช่หรือไม่", "ยืนยันการทำรายการ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes) {
                resetPwd = true;
                txtPassword.Text = "";
                txtPassword.Enabled = true;
                ckbGeneratePwd.Visible = true;
                ckbShowPwd.Visible = true;
            }

        }

        private void frmUserDetail_Load(object sender, EventArgs e) {
            
        }

        public void RetrieveUserRole() {
            database.Conn = database.ConnectDB();

            database.strSQL = "SELECT tblRole.* FROM tblRole  ORDER BY tblRole.RoleID";
            try {
                database.Cmd = new OleDbCommand();
                if ((database.Conn.State == ConnectionState.Closed)) {
                    database.Conn.Open();
                }

                database.Cmd.Connection = database.Conn;
                database.Cmd.CommandText = database.strSQL;
                database.DR = database.Cmd.ExecuteReader();
                while (database.DR.Read()) {
                    //Add RoleDescription to items in cbUserRole
                    cbUserRole.Items.Add(database.DR["RoleDescription"].ToString());
                }

            } catch (Exception ex) {
                MessageBoxAdv.Show(ex.Message);
            }

            database.DR.Close();
        }

        private void RetrieveDetail() {
            database.Conn = database.ConnectDB();
            database.strSQL =
                " SELECT tblTeacher.TeacherID, tblTeacher.TeacherFirstName, "+
                " tblTeacher.TeacherLastName, tblTeacher.TeacherRole, " +
                " tblUser.Username, tblUser.Password, tblUserRole.RoleID"+
                " FROM(tblRole INNER JOIN(tblTeacher INNER JOIN tblUserRole " +
                " ON tblTeacher.TeacherID = tblUserRole.TeacherID) " +
                " ON tblRole.RoleID = tblUserRole.RoleID) INNER JOIN tblUser " +
                " ON(tblUser.TeacherID = tblUserRole.TeacherID) " +
                " AND(tblTeacher.TeacherID = tblUser.TeacherID)"+
                " WHERE tblUser.TeacherID = "+TeacherID;

            try {
                database.Cmd = new OleDbCommand();
                if ((database.Conn.State == ConnectionState.Closed)) database.Conn.Open();

                database.Cmd.Connection = database.Conn;
                database.Cmd.CommandText = database.strSQL;
                database.DR = database.Cmd.ExecuteReader();
                while (database.DR.Read()) {
                    txtTeacherID.Text = database.DR["TeacherID"].ToString();
                    txtTRole.Text = database.DR["TeacherRole"].ToString();
                    txtFirstName.Text = database.DR["TeacherFirstName"].ToString();
                    txtLastName.Text = database.DR["TeacherLastName"].ToString();
                    txtUsername.Text = database.DR["Username"].ToString();
                    txtPassword.Text = "00000000";
                    cbUserRole.SelectedIndex = ((int)database.DR["RoleID"]) - 1;
                }
                database.DR.Close();
            } catch (Exception ex) {
                MessageBoxAdv.Show("Error : "+ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (modFunction.validNullTxt(txtTeacherID, errorProvider) || modFunction.validNullTxt(txtTRole, errorProvider)
               || modFunction.validNullTxt(txtFirstName, errorProvider) || modFunction.validNullTxt(txtLastName, errorProvider)
               || modFunction.validNullTxt(txtUsername, errorProvider) || modFunction.validNullTxt(txtPassword, errorProvider)
               || modFunction.validNotSelectCB(cbUserRole, errorProvider)) {
                MessageBoxAdv.Show("กรุณากรอกข้อมูลให้เรียบร้อยก่อนทำรายการ.", "รายงานความผิดพลาด",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } else {

                string pwd = "";
                if (resetPwd) pwd = " Password='" + authentication.Hash512(txtPassword.Text, txtUsername.Text) + "',";

                // UPDATE User Data
                string strSQL1 = "UPDATE tblUser " +
                        "SET  Username='" + txtUsername.Text + "', "
                            + pwd + /*if password has reset*/
                            " UpdateBy=" + Properties.Settings.Default["UserID"] +","+
                            " UpdateAt=" + DateTime.Now +
                            " WHERE TeacherID=" + txtTeacherID.Text;

                // UPDATE Teacher Data
                string strSQL2 = "UPDATE tblTeacher " +
                        "SET  TeacherFirstName='" + txtFirstName.Text + "', " +
                              " TeacherLastName='" + txtLastName.Text + "', " +
                              " TeacherRole='" + txtTRole.Text + "' " +
                              " WHERE TeacherID=" + txtTeacherID.Text;

                // UPDATE User Role Data
                string strSQL3 = "UPDATE tblUserRole " +
                        " SET  RoleID=" + (cbUserRole.SelectedIndex + 1) +
                        " WHERE TeacherID=" + txtTeacherID.Text;

                if (database.DoSQL(strSQL1) && database.DoSQL(strSQL2) && database.DoSQL(strSQL3, "แก้ไขข้อมูลเรียบร้อย", true)) {
                    Close();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            deleteData();
        }

        public void deleteData() {
            deleteData(txtFirstName.Text, txtLastName.Text, txtTeacherID.Text);
        }

        public void deleteData(string txt1, string txt2, string TeacherID) {
            DialogResult Result = MessageBoxAdv.Show("คุณต้องการการลบข้อมูลของ " + txt1 + " "
                    + txt2 + " ใช่หรือไม่ ?", "ยืนยันการลบข้อมูล",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (Result == DialogResult.Yes) {
                string strSQL1 = "DELETE FROM tblUser WHERE TeacherID = " + TeacherID;
                string strSQL2 = "DELETE FROM tblUser WHERE TeacherID = " + TeacherID;

                if (database.DoSQL(strSQL1) && database.DoSQL(strSQL2, "ลบข้อมูลเรียบร้อย", true)) {
                    var frmBehaviorList = new frmBehaviorList();
                    frmBehaviorList.RetrieveData();
                    Close();
                }
            }
        }

        private void frmUserDetail_Shown(object sender, EventArgs e) {
            this.Activate();
        }

        private void ckbGeneratePwd_CheckStateChanged(object sender, EventArgs e) {
            if (ckbGeneratePwd.Checked == true) {
                txtPassword.Text = modFunction.passwordGen();
            }
        }

        private void ckbShowPwd_CheckStateChanged(object sender, EventArgs e) {
            if (ckbShowPwd.Checked == true) {
                txtPassword.PasswordChar = char.Parse("•");
            }
        }
    }
}
