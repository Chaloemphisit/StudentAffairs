using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//Using formAuth and formData
using StudentAffairs.formAuth;
using StudentAffairs.formData;
using System.Threading;

namespace StudentAffairs
{
    static class Program
    {
        static frmSplash frmSplash;
        static frmMain frmMain;
        static frmLogin frmLogin;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Show Splash Form
            frmSplash = new frmSplash();
            if (frmSplash != null) {
                Thread splashThread = new Thread(new ThreadStart(
                    () => { Application.Run(frmSplash); }));
                splashThread.SetApartmentState(ApartmentState.STA);
                splashThread.Start();
            }
            //Thread.Sleep(2000);
            //Create and Show Main Form
            frmMain = new frmMain();
            frmMain.LoadCompleted += MainForm_LoadCompleted;
            Application.Run(frmMain);
            frmMain.Focus();
        }

        private static void MainForm_LoadCompleted(object sender, EventArgs e) {
            
            if (frmSplash == null || frmSplash.Disposing || frmSplash.IsDisposed)
                return;
            frmSplash.Invoke(new Action(() => { frmSplash.Close(); }));
            frmSplash.Dispose();
            frmSplash = null;
            frmMain.Activate();
           // frmLogin.Focus();
           // Module.authentication.checkStatus();
        }

    }
}
