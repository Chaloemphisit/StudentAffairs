using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//Using formAuth and formData
using StudentAffairs.formAuth;
using StudentAffairs.formData;
using System.Threading;
using Syncfusion.Windows.Forms;
using System.Drawing;

namespace StudentAffairs
{
    static class Program
    {
        static frmSplash frmSplash;
        //static frmTest frmTest;
        static frmMain frmMain;
        static frmStudentList frmStudentList;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Apply Style to MessageBoxAdv
            msgbAdv();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Show Splash Form
            frmSplash = new frmSplash();
            if (frmSplash != null) {
                Thread splashThread = new Thread(new ThreadStart(
                    () => { Application.Run(frmSplash); }));
                splashThread.SetApartmentState(ApartmentState.MTA);
                splashThread.Start();
            }
            //Create and Show Main Form
            frmMain = new frmMain();
            frmMain.LoadCompleted += MainForm_LoadCompleted;
            frmMain.TopMost = true;
            Application.Run(frmMain);
            frmMain.Focus();
            frmMain.Activate();
        }

        private static void MainForm_LoadCompleted(object sender, EventArgs e) {
            
            if (frmSplash == null || frmSplash.Disposing || frmSplash.IsDisposed)
                return;
            frmSplash.Invoke(new Action(() => { frmSplash.Close(); }));
            frmMain.TopMost = false;
            frmSplash.Dispose();
            frmSplash = null;
            if (Module.authentication.checkStatus()) {
                frmStudentList = new frmStudentList();
                frmStudentList.MdiParent = frmMain;
                frmStudentList.Show();
            }

            frmMain.Activate();
            frmMain.Focus();

        }

        public static void msgbAdv() {
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;

            MessageBoxAdv.MetroColorTable.BorderColor = System.Drawing.Color.FromArgb(27, 161, 226);
            MessageBoxAdv.MetroColorTable.ForeColor = Color.Black;
            MessageBoxAdv.MetroColorTable.BackColor = Color.White;

            MessageBoxAdv.MetroColorTable.CaptionBarColor = System.Drawing.Color.FromArgb(27, 161, 226);
            MessageBoxAdv.MetroColorTable.CaptionForeColor = Color.White;

            //-----------//
            /*   Button  */
            //-----------//
                
                MessageBoxAdv.MetroColorTable.OKButtonBackColor = System.Drawing.Color.FromArgb(27, 161, 226);
                MessageBoxAdv.MetroColorTable.OKButtonForeColor = Color.White;

                MessageBoxAdv.MetroColorTable.YesButtonBackColor = System.Drawing.Color.FromArgb(27, 161, 226);
                MessageBoxAdv.MetroColorTable.YesButtonForeColor = Color.White;

                MessageBoxAdv.MetroColorTable.NoButtonBackColor = System.Drawing.Color.FromArgb(27, 161, 226);
                MessageBoxAdv.MetroColorTable.NoButtonForeColor = Color.White;

                MessageBoxAdv.MetroColorTable.CancelButtonBackColor = System.Drawing.Color.FromArgb(27, 161, 226);
                MessageBoxAdv.MetroColorTable.CancelButtonBackColor = Color.White;
            //-----------//
        }

    }
}
