
using StudentAffairs.Properties;
using Syncfusion.Windows.Forms;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace StudentAffairs.Module {
    class database {
        private static OleDbConnection OConn;
        private static OleDbCommand OCmd;
        private static DataSet ODS;
        private static OleDbDataReader ODR;
        private static OleDbDataAdapter ODA;
        private static string strgSQL;

        public static OleDbConnection Conn {
            get { return OConn; }
            set { OConn = value; }
        }

        public static OleDbCommand Cmd {
            get { return OCmd; }
            set { OCmd = value; }
        }

        public static DataSet DS {
            get { return ODS; }
            set { ODS = value; }
        }

        public static OleDbDataReader DR {
            get { return ODR; }
            set { ODR = value; }
        }
        public static OleDbDataAdapter DA {
            get { return ODA; }
            set { ODA = value; }
        }
        
        public static string strSQL {
            get { return strgSQL; }
            set { strgSQL = value; }
        }


        public static OleDbConnection ConnectDB() {

            String strPath = MyPath(Application.StartupPath);
            //MessageBoxAdv.Show(MyPath(Application.StartupPath));

            //ให้ต่อท้ายด้วยโฟลเดอร์ตำแหน่งของข้อมูลที่ต้องการ คือ  \Data\ไฟล์ข้อมูล MS Access
            String strConn = "Provider = Microsoft.ACE.OLEDB.12.0; ";
            strConn += "Data Source = " + strPath + @"Database\Student.accdb; ";
            strConn += @"Jet OLEDB:Database Password=" + Settings.Default["dbPassword"] +"; ";

            OleDbConnection ConnDB = new OleDbConnection(strConn);
            //Create Connection
            ConnDB.ConnectionString = strConn;

            return ConnDB;
        }


        // --------------------------------------------------------------------------------
        // Get my project path
        // AppPath = C:\My Project\bin\debug
        // Replace "\bin\debug" with "\"
        // Return : C:\My Project\
        private static String MyPath(String AppPath) {
            AppPath = AppPath.ToLower();

            AppPath = AppPath.Replace(@"\bin\debug", @"\").Replace(@"\bin\release", @"\");

            // กรณีที่หาโฟลเดอร์ไม่เจอ จะทำให้ขาดเครื่องหมาย \ ต่อท้าย
            if (!AppPath.Substring(AppPath.Length - 1).Equals(@"\")) {
                AppPath += @"\";
            }

            return AppPath;
        }

        public static Boolean DoSQL(string sql, string msg= "Records Update Completed", Boolean showMsg = false) {
            Conn = ConnectDB();

            Cmd = new OleDbCommand();
            if (Conn.State == ConnectionState.Closed) Conn.Open();

            try {
                Cmd.Connection = Conn;
                Cmd.CommandType = CommandType.Text;
                Cmd.CommandText = sql;
                Cmd.ExecuteNonQuery();
                if (showMsg) MessageBoxAdv.Show(msg, "รายงานสถานะ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cmd.Dispose();
                return true;
            } catch (Exception e) {
                MessageBoxAdv.Show("Error Update: " + e.Message,"ผิดพลาด");
                return false;
            }

        }
    }
}
