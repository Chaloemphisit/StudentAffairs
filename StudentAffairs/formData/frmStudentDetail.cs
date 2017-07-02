#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using StudentAffairs.Module;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace StudentAffairs.formData {
    public partial class frmStudentDetail : Syncfusion.Windows.Forms.MetroForm {

        public static event EventHandler LoadCompleted;

        private static Boolean newData = true;
        public static int stdID { get; set; }

        public frmStudentDetail() {
            InitializeComponent();
            ClearTextBoxes(this.Controls);
            RetrieveGender();
            RetrievePrefix();
        }


        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            this.OnLoadCompleted(EventArgs.Empty);
        }
        protected virtual void OnLoadCompleted(EventArgs e) {
            var handler = LoadCompleted;
            if (handler != null)
                handler(this, e);
        }

        //Set View mode
        public void viewMode() {
            foreach (Control Control in this.Controls) {
                if (!(Control is Button)) {
                    Control.Enabled = false;
                    if (Control is TextBoxExt) {
                        Control.BackColor = Color.SeaShell;
                    }

                }
            }

            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            RetrieveData();
        }

        //Set New mode
        public void newMode() {
            newData = true;
            btnSave.Enabled=true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        //Set Edit mode
        public void editMode() {
            newData = false;
            RetrieveData();
            foreach (Control Control in this.Controls) {
                if (!(Control is Button)) {
                    Control.Enabled = true;
                    if (Control is TextBoxExt) {
                        Control.BackColor = Color.White;
                    }
                }
            }
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
        }

        //Clear text in textbox in this form
        private void ClearTextBoxes(Control.ControlCollection cc) {
            foreach (Control ctrl in cc) {
                if ((ctrl as TextBox) != null)
                    (ctrl as TextBox).Text = "";
                else
                    ClearTextBoxes(ctrl.Controls);
            }
        }

        //Add prefix to Combobox prefix
        private void RetrievePrefix() {
            database.Conn = database.ConnectDB();
            database.strSQL = "SELECT tblPrefix.* FROM tblPrefix ORDER BY tblPrefix.PrefixPK";
            try {
                database.Cmd = new OleDbCommand();
                if ((database.Conn.State == ConnectionState.Closed)) database.Conn.Open();
                database.Cmd.Connection = database.Conn;
                database.Cmd.CommandText = database.strSQL;
                database.DR = database.Cmd.ExecuteReader();
                while (database.DR.Read()) {
                    cbStdPrefix.Items.Add(database.DR["Prefix"].ToString());
                }
                database.DR.Close();
            } catch (Exception ex) { MessageBoxAdv.Show(ex.Message); }
        }

        //Add Gender To Combobox Gender
        private void RetrieveGender() {
            database.Conn = database.ConnectDB();
            database.strSQL = "SELECT tblGender.* FROM tblGender ORDER BY tblGender.Gender";
            try {
                database.Cmd = new OleDbCommand();
                if ((database.Conn.State == ConnectionState.Closed)) database.Conn.Open();
                database.Cmd.Connection = database.Conn;
                database.Cmd.CommandText = database.strSQL;
                database.DR = database.Cmd.ExecuteReader();
                while (database.DR.Read()) {
                    cbStdGender.Items.Add(database.DR["Gender"].ToString());
                }
                database.DR.Close();
            } catch (Exception ex) { MessageBoxAdv.Show(ex.Message); }
        }

        //Add data to textbox
        private void RetrieveData(Boolean blnSearch = false) {
            database.Conn = database.ConnectDB();

            database.strSQL =
                " SELECT tblStudent.std_ID, tblStudent.std_IDCard, tblStudent.std_Prefix, " +
                " tblStudent.std_FirstName, tblStudent.std_LastName, tblStudent.std_FirstNameE,  " +
                " tblStudent.std_LastNameE, tblStudent.std_Gender, tblStudent.std_Class,  " +
                " tblStudent.std_Room, tblStudent.std_Birthday, tblStudent.std_AgeY,  " +
                " tblStudent.std_AgeM, tblStudent.std_Blood, tblStudent.std_ethnicity,  " +
                " tblStudent.std_Nationality, tblStudent.std_Religion " +
                " FROM tblStudent " +
                " WHERE  [std_ID]=" + stdID;
            try {
                database.Cmd = new OleDbCommand();
                if ((database.Conn.State == ConnectionState.Closed)) database.Conn.Open();
                database.Cmd.Connection = database.Conn;
                database.Cmd.CommandText = database.strSQL;
                database.DR = database.Cmd.ExecuteReader();
                while (database.DR.Read()) {
                    txtStdID.Text = database.DR["std_ID"].ToString();
                    txtStdIdCard.Text = database.DR["std_IDCard"].ToString();
                    txtStdClass.Text = database.DR["std_Class"].ToString();
                    txtStdRoom.Text = database.DR["std_Room"].ToString();
                    cbStdPrefix.SelectedIndex = (int)database.DR["std_Prefix"] - 1;
                    txtStdFirstName.Text = database.DR["std_FirstName"].ToString();
                    txtStdLastName.Text = database.DR["std_LastName"].ToString();
                    cbStdGender.SelectedIndex = (int)database.DR["std_Gender"] - 1;
                    txtStdFirstNameEn.Text = database.DR["std_FirstNameE"].ToString();
                    txtStdLastNameEn.Text = database.DR["std_LastNameE"].ToString();
                    dtpBirthday.BindableValue = database.DR["std_Birthday"];
                    txtStdAgeY.Text = database.DR["std_AgeY"].ToString();
                    txtStdAgeM.Text = database.DR["std_AgeM"].ToString();
                    txtStdBlood.Text = database.DR["std_Blood"].ToString();
                    txtStdEthnicity.Text = database.DR["std_ethnicity"].ToString();
                    txtStdNationality.Text = database.DR["std_Nationality"].ToString();
                    txtSTdReligion.Text = database.DR["std_Religion"].ToString();
                }
                database.DR.Close();
            } catch (Exception ex) { MessageBoxAdv.Show(ex.Message); }
        }

        private void frmStudentDetail_Load(object sender, EventArgs e) {

        }

        private void btnSave_Click(object sender, EventArgs e) {
            saveData();
        }

        private void saveData() {
            if (modFunction.validNullTxt(txtStdID, errorProvider)
                || modFunction.validNullTxt(txtStdIdCard, errorProvider)
                || modFunction.validNullTxt(txtStdClass, errorProvider)
                || modFunction.validNullTxt(txtStdRoom, errorProvider)
                || modFunction.validNotSelectCB(cbStdPrefix, errorProvider)
                || modFunction.validNullTxt(txtStdFirstName, errorProvider)
                || modFunction.validNullTxt(txtStdLastName, errorProvider)
                || modFunction.validNotSelectCB(cbStdGender, errorProvider)
                || modFunction.validNullTxt(txtStdFirstNameEn, errorProvider)
                || modFunction.validNullTxt(txtStdLastNameEn, errorProvider)
                || modFunction.validNullTxt(txtStdAgeY, errorProvider)
                || modFunction.validNullTxt(txtStdAgeM, errorProvider)
                || modFunction.validNullTxt(txtStdBlood, errorProvider)
                || modFunction.validNullTxt(txtStdEthnicity, errorProvider)
                || modFunction.validNullTxt(txtStdNationality, errorProvider)
                || modFunction.validNullTxt(txtSTdReligion, errorProvider)
                ) {
                MessageBoxAdv.Show("กรุณากรอกข้อมูลให้เรียบร้อยก่อนทำรายการ.", "รายงานความผิดพลาด",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnSave.Text = "บันทึก";
                return;
            } else {

                //Save New Data
                if (newData) {
                    database.strSQL = "INSERT INTO tblStudent(" +
                                        "std_ID, std_IDCard, std_Prefix, std_FirstName, std_LastName, " +
                                        "std_FirstNameE, std_LastNameE, std_Gender, std_Class, " +
                                        "std_Room, std_Birthday, std_AgeY, std_AgeM, std_Blood, " +
                                        "std_ethnicity, std_Nationality, std_Religion" +
                                        ") " +
                                        "VALUES(" +
                                        "  " + txtStdID.Text + " ," +
                                        "  " + txtStdIdCard.Text + " ," +
                                        "  " + (cbStdPrefix.SelectedIndex + 1) + " ," +
                                        " '" + txtStdFirstName.Text + "', " +
                                        " '" + txtStdLastName.Text + "', " +
                                        " '" + txtStdFirstNameEn.Text + "', " +
                                        " '" + txtStdLastNameEn.Text + "', " +
                                        "  " + (cbStdGender.SelectedIndex + 1) + " ," +
                                        "  " + txtStdClass.Text + " ," +
                                        "  " + txtStdRoom.Text + " ," +
                                        "  '" + dtpBirthday.Value + "' ," +
                                        "  " + txtStdAgeY.Text + " ," +
                                        "  " + txtStdAgeM.Text + " ," +
                                        " '" + txtStdBlood.Text + "', " +
                                        " '" + txtStdEthnicity.Text + "', " +
                                        " '" + txtStdNationality.Text + "', " +
                                        " '" + txtSTdReligion.Text + "'"+
                                        ")";
                                        
                    //Do Sql
                    if (database.DoSQL(database.strSQL, "บันทึกข้อมูลเรียบร้อย", true)) ClearTextBoxes(this.Controls);

                    //Update Data
                } else {
                    //                  "std_ID, std_IDCard, std_Prefix, std_FirstName, std_LastName, " +
                    //                    "std_FirstNameE, std_LastNameE, std_Gender, std_Class, " +
                    //                    "std_Room, std_Birthday, std_AgeY, std_AgeM, std_Blood, " +
                    //                    "std_ethnicity, std_Nationality, std_Religion"
                    // START UPDATE
                    database.strSQL = "UPDATE tblStudent SET " +
                                        "std_IDCard =  " + txtStdIdCard.Text + " ," +
                                        "std_Prefix =  " + (cbStdPrefix.SelectedIndex + 1) + " ," +
                                        "std_FirstName = '" + txtStdFirstName.Text + "', " +
                                        "std_LastName = '" + txtStdLastName.Text + "', " +
                                        "std_FirstNameE = '" + txtStdFirstNameEn.Text + "', " +
                                        "std_LastNameE = '" + txtStdLastNameEn.Text + "', " +
                                        "std_Gender = " + (cbStdGender.SelectedIndex + 1) + " ," +
                                        "std_Class = " + txtStdClass.Text + " ," +
                                        "std_Room = " + txtStdRoom.Text + " ," +
                                        "std_Birthday =  '" + dtpBirthday.Value + "' ," +
                                        "std_AgeY = " + txtStdAgeY.Text + " ," +
                                        "std_AgeM = " + txtStdAgeM.Text + " ," +
                                        "std_Blood = '" + txtStdBlood.Text + "', " +
                                        "std_ethnicity = '" + txtStdEthnicity.Text + "', " +
                                        "std_Nationality = '" + txtStdNationality.Text + "', " +
                                        "std_Religion = '" + txtSTdReligion.Text + "'" +
                                        " WHERE tblStudent.std_ID = " + stdID;

                    if (database.DoSQL(database.strSQL, "แก้ไขข้อมูลเรียบร้อย", true)) Close();
                }

            }
        }

        private void btnCalAge_Click(object sender, EventArgs e) {
            DialogResult Result = MessageBoxAdv.Show("คุณแน่ใจว่าวันที่ปัจจุบันของคอมพิวเตอร์ของคุณถูกต้องแล้วใช่หรือไม่ ?", "ยืนยันการตรวจสอบวันที่",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (Result == DialogResult.Yes) {
                calculateAge calculateAge = new calculateAge();
                var Age = calculateAge.calAge(dtpBirthday.Value);
                txtStdAgeY.Text = Age.Year.ToString();
                txtStdAgeM.Text = Age.Month.ToString();
                database.strSQL = "UPDATE tblStudent SET " +
                        " std_AgeY=" + txtStdAgeY.Text + ", " +
                        " std_AgeM=" + txtStdAgeM.Text +
                        " WHERE std_ID=" + txtStdID.Text;
                database.DoSQL(database.strSQL);
            }
        }

        public void deleteData() {
            if (btnDelete.Enabled == true) {
                DialogResult Result = MessageBoxAdv.Show("คุณต้องการการลบข้อมูลของ " + txtStdID.Text + " "
                        + txtStdFirstName.Text + " " + txtStdLastName.Text + " ใช่หรือไม่ ?", "ยืนยันการลบข้อมูล",
                                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (Result == DialogResult.Yes) {
                    database.strSQL = "DELETE FROM tblStudent WHERE std_ID = " + stdID;
                    if (database.DoSQL(database.strSQL, "ลบข้อมูลเรียบร้อย", true)) {
                        var frmBehaviorList = new frmBehaviorList();
                        frmBehaviorList.RetrieveData();
                        Close();
                    }
                }
            }
            return;
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            deleteData();
        }

        private void btnEdit_Click(object sender, EventArgs e) {
                DialogResult Result = MessageBoxAdv.Show("คุณต้องการการแก้ไขข้อมูลของ " + txtStdFirstName.Text + " " +
                                                  txtStdLastName.Text + " ใช่หรือไม่ ?", "ยืนยันการแก้ไขข้อมูล",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (Result == DialogResult.Yes) {
                editMode();
            }
        }
    }
}
