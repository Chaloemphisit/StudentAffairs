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

namespace StudentAffairs.Module {
    class authentication : database {


        public static Boolean checkUser(String username,String password) {
            Conn = ConnectDB();

            strSQL = "SELECT tblUser.UserID, tblUser.Username, tblUser.Password," +
                " tblUserRole.RoleID, tblRole.RoleDescription " +
                "FROM tblUser INNER JOIN(tblRole INNER JOIN tblUserRole " +
                "ON tblRole.[RoleID] = tblUserRole.[RoleID]) " +
                "ON tblUser.[UserID] = tblUserRole.[UserID]";
            strSQL = strSQL + " WHERE [Username] = '" + username + "' AND " + "[Password] = '" + Hash512(password, username) + "'";

            if (Conn.State == ConnectionState.Closed) Conn.Open();

            Cmd = new OleDbCommand(strSQL, Conn);
            DR = Cmd.ExecuteReader();

            Boolean userFound=false;
            while (DR.Read()) {
                userFound = true;
                //UserID = DR["UserID"].ToString();
                Settings.Default["UserID"] = DR["UserID"].ToString();
                Settings.Default["UserRole"] = DR["RoleID"].ToString();
                Settings.Default.Save();
            }
            if (userFound) addLog();

            return userFound;
        }

        public static string Hash512(string password,string salt) {
            var convertedToBytes = Encoding.UTF8.GetBytes(password+salt);
            HashAlgorithm hashType = new SHA512Managed();
            var hashBytes = hashType.ComputeHash(convertedToBytes);
            return Convert.ToBase64String(hashBytes);
        }

        private static void addLog() {
            strSQL = "INSERT INTO tblLog(UserID) " +
                    "VALUES(" + Settings.Default["UserID"] + ")";
            DoSQL(strSQL);
        }

        public static void signOut() {
            Settings.Default["UserID"] = "";
            Settings.Default["UserRole"] = "";
        }

        public static Boolean checkStatus() {
            if (!(bool)Settings.Default["LoginStatus"]) {
                
                MessageBox.Show("กรุณาล็อกอินก่อนทำรายการ!", "ผิดพลาด",
                                                   MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    var frmLogin = new formAuth.frmLogin();
                    Application.OpenForms.Cast<Form>().Where(x => !(x is formAuth.frmLogin)).ToList().ForEach(x => x.Close());
                    frmLogin.ShowDialog();
                return false;
            } else return true;

            
        }
    }
}
