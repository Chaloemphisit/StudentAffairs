using StudentAffairs.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentAffairs.formData;
namespace StudentAffairs.Module {
    class authentication : database {
        protected static Boolean status = false;
        public static Boolean loginStatus {
            get { return status; }
            set { status = value; }
        }
        
        public static Boolean checkUser(String username, String password) {
            Conn = ConnectDB();

            strSQL = "SELECT tblUser.TeacherID, tblUser.Username, tblUser.Password, " +
                "tblUserRole.RoleID, tblRole.RoleDescription " +
                "FROM tblUser INNER JOIN(tblRole INNER JOIN tblUserRole " +
                "ON tblRole.[RoleID] = tblUserRole.[RoleID]) ON tblUser.[TeacherID] = tblUserRole.[TeacherID]";
            strSQL = strSQL + " WHERE [Username] = '" + username + "' AND " + "[Password] = '" + Hash512(password, username) + "'";

            if (Conn.State == ConnectionState.Closed) Conn.Open();

            Cmd = new OleDbCommand(strSQL, Conn);
            DR = Cmd.ExecuteReader();

            Boolean userFound = false;
            string teacherID = null;
            while (DR.Read()) {
                userFound = true;
                //UserID = DR["UserID"].ToString();
                teacherID= DR["TeacherID"].ToString();
                Settings.Default["UserID"] = DR["TeacherID"].ToString();
                Settings.Default["UserRole"] = DR["RoleID"].ToString();
                Settings.Default.Save();
            }

            if (userFound) {
                addLog(teacherID);
            }
            authentication.loginStatus = userFound;
            Settings.Default.Save();

            return userFound;
        }

        public static string Hash512(string password, string salt) {
            var convertedToBytes = Encoding.UTF8.GetBytes(password + salt);
            HashAlgorithm hashType = new SHA512Managed();
            var hashBytes = hashType.ComputeHash(convertedToBytes);
            return Convert.ToBase64String(hashBytes);
        }

        private static void addLog(string TeacherID = null) {
            strSQL = "INSERT INTO tblLog(UserID) " +
                    "VALUES(" + TeacherID + ")";
            DoSQL(strSQL);
        }

        public void signOut() {
            Settings.Default["UserID"] = "";
            Settings.Default["UserRole"] = "";
            authentication.loginStatus = false;
            Settings.Default.Save();
            Application.OpenForms.Cast<Form>().Where(x => !(x is frmMain)).ToList().ForEach(x => x.Close());
            formAuth.frmLogin frmLogin = new formAuth.frmLogin();
            frmLogin.ShowDialog();
        }

        public static Boolean checkStatus() {
            //MessageBoxAdv.Show(authentication.loginStatus.ToString());
            if (!authentication.loginStatus) {

                //MessageBoxAdv.Show("กรุณาล็อกอินก่อนทำรายการ!", "ผิดพลาด",
                //                                 MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                var frmLogin = new formAuth.frmLogin();
                //Application.OpenForms.Cast<Form>().Where(x => !(x is formAuth.frmLogin)).ToList().ForEach(x => x.Close());
                frmLogin.ShowDialog();
                if (authentication.loginStatus) {
                    return true;
                }
                Application.Exit();
                return false;
            }

            return true;
        }
    }
}
