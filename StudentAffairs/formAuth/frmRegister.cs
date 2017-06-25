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
            register.registerNewUser(txtTeacherID.Text, txtTRole.Text, txtFirstName.Text, txtLastName.Text,txtUsername.Text,txtPassword.Text,cbUserRole.SelectedIndex);
        }
    }
}
