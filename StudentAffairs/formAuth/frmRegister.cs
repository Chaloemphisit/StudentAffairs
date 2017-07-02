using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentAffairs.Module;
using Syncfusion.Windows.Forms;
using System.Threading;

namespace StudentAffairs.formAuth {
    public partial class frmRegister : Syncfusion.Windows.Forms.MetroForm{
        database database = new database();
        public frmRegister() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            database.ConnectDB();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            //Clear all textbox
            clsForm();

            //Get array value from register.RetrieveUserRole() then foreach loop to add item to cbUserRole
            foreach (var userRole in register.RetrieveUserRole()){
                cbUserRole.Items.Add(userRole);
            }

        }
       void clsForm()
        {
            txtTeacherID.Text = "";
            txtTRole.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void btnRegister_Click(object sender, EventArgs e) {
            if(modFunction.validNullTxt(txtTeacherID, errorProvider) 
              || modFunction.validNullTxt(txtTRole, errorProvider)
              || modFunction.validNullTxt(txtFirstName, errorProvider)
              || modFunction.validNullTxt(txtLastName, errorProvider)
              || modFunction.validNullTxt(txtUsername, errorProvider)
              || modFunction.validNullTxt(txtPassword, errorProvider)
              || modFunction.validNotSelectCB(cbUserRole, errorProvider)) {
                MessageBoxAdv.Show("กรุณากรอกข้อมูลให้เรียบร้อยก่อนทำรายการ!","รายงานความผิดพลาด",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            } else {
                if (register.registerNewUser(txtTeacherID.Text, txtTRole.Text, txtFirstName.Text, txtLastName.Text, txtUsername.Text, txtPassword.Text, cbUserRole.SelectedIndex)) {
                    Close();
                }
            }
        }

        private void btnCancle_Click(object sender, EventArgs e) {
            this.Dispose();
        }

        private void ckbGeneratePwd_CheckStateChanged(object sender, EventArgs e) {
            if (ckbGeneratePwd.Checked == true) {
                txtPassword.Text = modFunction.passwordGen();
            }
        }

        private void ckbShowPwd_CheckStateChanged(object sender, EventArgs e) {
            if (ckbShowPwd.Checked == true) {
                txtPassword.PasswordChar = '\0';
            } else {
                txtPassword.PasswordChar = '•';
            }
        }

        private void txtTeacherID_Validating(object sender, CancelEventArgs e) {
            //Check Validateing IsNullText
            modFunction.validNullTxt(txtTeacherID, errorProvider);
        }

        private void txtTRole_Validating(object sender, CancelEventArgs e) {
            //Check Validateing IsNullText
            modFunction.validNullTxt(txtTRole, errorProvider);
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e) {
            //Check Validateing IsNullText
            modFunction.validNullTxt(txtFirstName, errorProvider);
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e) {
            //Check Validateing IsNullText
            modFunction.validNullTxt(txtLastName, errorProvider);
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e) {
            //Check Validateing IsNullText
            modFunction.validNullTxt(txtUsername, errorProvider,10);
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e) {
            //Check Validateing IsNullText
            modFunction.validNullTxt(txtPassword, errorProvider,8);
        }

        private void cbUserRole_Validating(object sender, CancelEventArgs e) {
            //Check Validateing IsNullText
            modFunction.validNotSelectCB(cbUserRole, errorProvider);
        }
    }
}
