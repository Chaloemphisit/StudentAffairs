#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using StudentAffairs.Module;
using StudentAffairs.Properties;
using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace StudentAffairs.formData {
    public partial class frmBehaviorDetail : Syncfusion.Windows.Forms.MetroForm {
        public event EventHandler LoadCompleted;
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            this.OnLoadCompleted(EventArgs.Empty);
        }
        protected virtual void OnLoadCompleted(EventArgs e) {
            var handler = LoadCompleted;
            if (handler != null)
                handler(this, e);
        }

        private static Boolean newData = true;
        public static int PK;

        public frmBehaviorDetail() {
            InitializeComponent();
            if (!newData) btnRefresh.Visible = false;
            RetrieveRCName();
            RetrieveType();
            newMode();
        }

        private void frmBehaviorDetail_Load(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(txtStudentID.Text) || string.IsNullOrWhiteSpace(txtStudentFirstName.Text)) {
                btnSave.Enabled = false;
            } else {
                btnSave.Enabled = true;
            }
        }

        private void RetrieveType() {
            database.Conn = database.ConnectDB();

            database.strSQL = "SELECT tblBehaviorType.Type FROM tblBehaviorType  ORDER BY tblBehaviorType.BehaviorTypePK";

            try {
                database.Cmd = new OleDbCommand();
                if ((database.Conn.State == ConnectionState.Closed)) database.Conn.Open();

                database.Cmd.Connection = database.Conn;
                database.Cmd.CommandText = database.strSQL;
                database.DR = database.Cmd.ExecuteReader();
                while (database.DR.Read()) {
                    cbType.Items.Add(database.DR["Type"].ToString());
                    // MessageBox(database.DR["Type"].ToString());
                }
                database.DR.Close();
            } catch (Exception ex) {
                MessageBoxAdv.Show(ex.Message);
            }
        }

        public void newMode() {
            clsForm();
            DateTimePicker.Value = DateTime.Now;
            cbType.Refresh();
            txtStudentID.Select();
            newData = true;
            btnDelete.Enabled = false;
            txtStudentID.Focus();
            txtStudentID.ReadOnly = false;
            btnRefresh.Visible = true;

        }

        public void editMode() {
            newData = false;
            RetrieveDetail();
            btnDelete.Enabled = true;
            txtStudentID.BackColor = Color.SeaShell;
            txtStudentID.ReadOnly = true;
            btnRefresh.Visible = false;
        }

        private void clsForm() {
            txtStudentID.Text = "";
            txtStudentFirstName.Text = "";
            txtStudentLastName.Text = "";
            txtClass.Text = "";
            txtRoom.Text = "";
            txtDetail.Text = "";
            txtImplementation.Text = "";
            txtRealization.Text = "";
        }

        private void RetrieveDetail() {
            if (newData) return; //Check newData if newData=true then exit method

            database.Conn = database.ConnectDB();

            database.strSQL = "SELECT tblBehavior.PK, tblStudent.std_ID, tblStudent.std_FirstName, " +
                "tblStudent.std_LastName, tblStudent.std_Class, tblStudent.std_Room, " +
                "tblBehavior.BehaviorDetail, tblBehavior.Implementation, " +
                "tblBehavior.Realization, tblBehavior.CreateAt, " +
                "[tblTeacher].[TeacherFirstName] + ' ' + [TeacherLastName] AS TeacherName, " +
                "tblBehavior.TeacherID, tblBehavior.BehaviorType, tblBehavior.UpdateAt " +
                "FROM tblTeacher INNER JOIN (tblStudent INNER JOIN tblBehavior " +
                "ON tblStudent.std_ID = tblBehavior.std_ID) " +
                "ON tblTeacher.TeacherID = tblBehavior.TeacherID " +
                "WHERE (((tblBehavior.PK)=" + PK + "))";

            try {
                database.Cmd = new OleDbCommand();
                if ((database.Conn.State == ConnectionState.Closed)) database.Conn.Open();

                database.Cmd.Connection = database.Conn;
                database.Cmd.CommandText = database.strSQL;
                database.DR = database.Cmd.ExecuteReader();
                while (database.DR.Read()) {
                    txtStudentID.Text = database.DR["std_ID"].ToString();
                    txtStudentFirstName.Text = database.DR["std_FirstName"].ToString();
                    txtStudentLastName.Text = database.DR["std_LastName"].ToString();
                    txtClass.Text = database.DR["std_Class"].ToString();
                    txtRoom.Text = database.DR["std_Room"].ToString();
                    txtDetail.Text = database.DR["BehaviorDetail"].ToString();
                    txtImplementation.Text = database.DR["Implementation"].ToString();
                    txtRealization.Text = database.DR["Realization"].ToString();
                    cbType.SelectedIndex = ((int) database.DR["BehaviorType"])-1;
                    DateTimePicker.BindableValue = database.DR["UpdateAt"];
                    txtRecorderName.Text = database.DR["TeacherID"].ToString();

                }
                database.DR.Close();
            } catch (Exception ex) {
                MessageBoxAdv.Show(ex.Message);
            }
        }

        //Retrieve Recorder Name to txtRecorderName
        private void RetrieveRCName() {
            database.Conn = database.ConnectDB();

            database.strSQL = "SELECT [tblTeacher].[TeacherFirstName] & ' ' & [TeacherLastName] AS TeacherName, " +
                    "tblUser.TeacherID FROM tblTeacher INNER JOIN tblUser ON tblTeacher.TeacherID = tblUser.TeacherID " +
                    "WHERE tblUser.TeacherID = " + Settings.Default["UserID"];

            try {
                database.Cmd = new OleDbCommand();
                if ((database.Conn.State == ConnectionState.Closed)) database.Conn.Open();

                database.Cmd.Connection = database.Conn;
                database.Cmd.CommandText = database.strSQL;
                database.DR = database.Cmd.ExecuteReader();
                while (database.DR.Read()) {
                    txtRecorderName.Text = database.DR["TeacherName"].ToString();
                }
                database.DR.Close();
            } catch (Exception ex) {
                MessageBoxAdv.Show(ex.Message);
            }
        }

        private void RetrieveStdData(string id) {
            database.Conn = database.ConnectDB();

            database.strSQL = "SELECT tblStudent.std_ID, tblStudent.std_FirstName, tblStudent.std_LastName, " +
                              "tblStudent.std_Class, tblStudent.std_Room FROM tblStudent " +
                              " WHERE  [std_ID] = "+id; //Like '%" + txtStudentID.Text + "%' ";

            try {
                database.Cmd = new OleDbCommand();
                if ((database.Conn.State == ConnectionState.Closed)) database.Conn.Open();

                database.Cmd.Connection = database.Conn;
                database.Cmd.CommandText = database.strSQL;
                database.DR = database.Cmd.ExecuteReader();

                Boolean result = false;
                while (database.DR.Read()) {
                    result = true;
                    txtStudentFirstName.Text = database.DR["std_FirstName"].ToString();
                    txtStudentLastName.Text = database.DR["std_LastName"].ToString();
                    txtClass.Text = database.DR["std_Class"].ToString();
                    txtRoom.Text = database.DR["std_Room"].ToString();
                }
                if (!result) MessageBoxAdv.Show("ไม่พบรายชื่อนี้ กรุณาลองใหม่อีกครั้ง", "รายงานสถานะ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else {
                    btnSave.Enabled = true;
                    txtDetail.Select();
                }
               database.DR.Close();
            } catch (Exception ex) {
                MessageBoxAdv.Show(ex.Message);
            }

            
        }

        private void txtStudentID_KeyPress(object sender, KeyPressEventArgs e) {
            if (string.IsNullOrWhiteSpace(txtStudentID.Text)) { return; }
            // Undesirable characters for the database ex.  ', *or %
            txtStudentID.Text = txtStudentID.Text.Trim().Replace("\'", "");
            txtStudentID.Text = txtStudentID.Text.Trim().Replace("%", "");
            txtStudentID.Text = txtStudentID.Text.Trim().Replace("*", "");

            // RetrieveData(True) It means searching for information.
            if (e.KeyChar == (char)13) {
                // No beep.
                e.Handled = true;
                RetrieveStdData(txtStudentID.Text);
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (modFunction.validNullTxt(txtStudentID, errorProvider) || modFunction.validNullTxt(txtDetail, errorProvider)
                || modFunction.validNullTxt(txtImplementation, errorProvider) || modFunction.validNullTxt(txtRealization, errorProvider)
                || modFunction.validNotSelectCB(cbType, errorProvider)) {
                MessageBoxAdv.Show("กรุณากรอกข้อมูลให้เรียบร้อยก่อนทำรายการ.", "รายงานความผิดพลาด",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } else {

                //Save New Data
                if (newData) {
                    database.strSQL = "INSERT INTO tblBehavior(" +
                "std_ID, BehaviorDetail, Implementation, Realization, " +
                "BehaviorType, TeacherID, CreateAt,UpdateAt) " +
                "VALUES(" +
                " " + txtStudentID.Text + "," +
                "'" + txtDetail.Text + "'," +
                "'" + txtImplementation.Text + "'," +
                "'" + txtRealization.Text + "'," +
                " " + (cbType.SelectedIndex+1) + "," +
                " " + Settings.Default["UserID"] + "," +
                "'" + DateTimePicker.Value + "'," +
                "'" + DateTimePicker.Value + "')";

                    //Do Sql
                    if (database.DoSQL(database.strSQL, "บันทึกข้อมูลเรียบร้อย", true)) clsForm();

                //Update Data
                } else {
                    // START UPDATE
                    database.strSQL = "UPDATE tblBehavior SET " +
                        " std_ID=" + txtStudentID.Text + ", " +
                        " BehaviorDetail='" + txtDetail.Text + "', " +
                        " Implementation='" + txtImplementation.Text + "', " +
                        " Realization='" + txtRealization.Text + "', " +
                        " BehaviorType=" + (cbType.SelectedIndex + 1) + ", " +
                        " TeacherID=" + Settings.Default["UserID"] + ", " +
                        " UpdateAt='" + DateTimePicker.Value + "' " +
                        " WHERE PK=" + PK + "";    // ค่า PK จะได้มาจากการดับเบิ้ลคลิ๊กเลือกรายการแก้ไขเอาไว้แล้วล่วงหน้า
                if (database.DoSQL(database.strSQL, "แก้ไขข้อมูลเรียบร้อย", true)) Close();
                }

            }
        }

        public void deleteData() {
            DialogResult Result = MessageBoxAdv.Show("คุณต้องการการลบข้อมูลของ " + txtStudentID.Text + " "
                    + txtStudentFirstName.Text + " " + txtStudentLastName.Text + " ใช่หรือไม่ ?", "ยืนยันการลบข้อมูล",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (Result == DialogResult.Yes) {
                database.strSQL = "DELETE FROM tblBehavior WHERE PK = " + PK;
                if (database.DoSQL(database.strSQL, "ลบข้อมูลเรียบร้อย", true)) {
                    var frmBehaviorList = new frmBehaviorList();
                    frmBehaviorList.RetrieveData();
                    Close();
                }
            }
        }

        private void txtStudentID_TextChanged(object sender, EventArgs e) {

        }

        private void btnCancle_Click(object sender, EventArgs e) {
            database.Conn.Close();
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            deleteData();
        }

        private void btnRefresh_Click(object sender, EventArgs e) {
            RetrieveStdData(txtStudentID.Text);
        }

        private void txtStudentID_Validating(object sender, CancelEventArgs e) {
            //Check Validateing IsNullText
            modFunction.validNullTxt(txtStudentID, errorProvider);
        }

        private void txtDetail_Validating(object sender, CancelEventArgs e) {
            //Check Validateing IsNullText
            modFunction.validNullTxt(txtDetail, errorProvider);
        }

        private void txtImplementation_Validating(object sender, CancelEventArgs e) {
            //Check Validateing IsNullText
            modFunction.validNullTxt(txtImplementation, errorProvider);
        }

        private void txtRealization_Validating(object sender, CancelEventArgs e) {
            //Check Validateing IsNullText
            modFunction.validNullTxt(txtRealization, errorProvider);
        }

        private void cbType_Validating(object sender, CancelEventArgs e) {
            //Check Validateing IsNullText
            modFunction.validNotSelectCB(cbType, errorProvider);
        }
    }
}