using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentAffairs.formAuth;
using Syncfusion.Windows.Forms;
using StudentAffairs.Properties;

namespace StudentAffairs.Module {
    class register : database {
        public static string[] RetrieveUserRole() {
            List<string> RoleDescList = new List<string>();
            
            Conn = ConnectDB();
            
            strSQL = "SELECT tblRole.* FROM tblRole  ORDER BY tblRole.RoleID";
            try {
                Cmd = new OleDbCommand();
                if ((Conn.State == ConnectionState.Closed)) {
                    Conn.Open();
                }

                Cmd.Connection = Conn;
                Cmd.CommandText = strSQL;
                DR = Cmd.ExecuteReader();
                while (DR.Read()) {
                    //MessageBoxAdv.Show(DR["RoleDescription"].ToString());
                    RoleDescList.Add(DR["RoleDescription"].ToString());
                }

            } catch (Exception ex) {
                MessageBoxAdv.Show(ex.Message);
            }

            DR.Close();
            string[] RoleDesc = RoleDescList.ToArray();
            
            return RoleDesc;
        }

        public static Boolean registerNewUser(string TeacherID, string TRole, string FirstName, string LastName, string Username, string Password, int UserRole) {
            frmRegister frmReg = new frmRegister();
            int RoleID = (UserRole+1);
            Boolean str1,str2,str3;

            //Check Exist User
            if (!checkExistUser(Username, TeacherID)) {
                //----------------- Insert Teacher Data -----------------
                strSQL = "INSERT INTO tblTeacher(" +
                        "TeacherID, TeacherFirstName, TeacherLastName, TeacherRole) " +
                        " VALUES(" +
                        " " + TeacherID + " ," +
                        "'" + FirstName + "'," +
                        "'" + LastName + "'," +
                        "'" + TRole + "'" +
                        ")";
                str1 = DoSQL(strSQL);

        //----------------- Insert User Data -----------------
        strSQL = "INSERT INTO tblUser(TeacherID, [Username], [Password], CreateByID) " +
                " VALUES(" + TeacherID + ",'" + Username + "'," +
                "'" + authentication.Hash512(Password, Username) + "'," + Settings.Default["UserID"] + ")";
                str2 = DoSQL(strSQL);

        //----------------- Insert User Role -----------------
        strSQL = "INSERT INTO tblUserRole(" +
                " TeacherID, RoleID) " +
                " VALUES( " + TeacherID + "," + RoleID + " )";
        str3 = DoSQL(strSQL);

                if (str1 && str2 && str3) {
                    MessageBoxAdv.Show("ลงทะเบียนเรียบร้อย.", "รายงานสถานะ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        private static Boolean checkExistUser(string username, string teacherID) {
            // the query:
            string strSQL = " SELECT tblUser.Username, tblTeacher.TeacherID " + 
                            " FROM tblTeacher INNER JOIN tblUser ON tblTeacher.TeacherID = tblUser.TeacherID "+
                            " WHERE tblUser.Username = '" + username + "' Or tblTeacher.TeacherID = " + teacherID;
            if ((Conn.State == ConnectionState.Closed)) {
                Conn.Open();
            }

            Cmd = new OleDbCommand(strSQL, Conn);
            DR = Cmd.ExecuteReader();
            Boolean userFound = false;
            while (DR.Read()) {
                userFound = true;
            }

            // checking the result
            if ((userFound == true)) {
                MessageBoxAdv.Show("พบผู้ใช้ในระบบ!", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Conn.Close();
            return userFound;
        }
    }
}
