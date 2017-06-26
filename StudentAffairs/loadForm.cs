using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

//Using formAuth and formData
using StudentAffairs.formAuth;
using StudentAffairs.formData;
using System.Threading;

namespace StudentAffairs {
    class loadForm {
        static frmWait frmWait;

        public static void showWaitForm(Form formCreator) {
            //Show Wait Form
           frmWait = new frmWait();
            if (frmWait != null) {
                Thread splashThread = new Thread(new ThreadStart(
                    () => { Application.Run(frmWait); }));
                splashThread.SetApartmentState(ApartmentState.STA);
                splashThread.Start();
            }

            formCreator.Load += frm_LoadCompleted;
            formCreator.Show();
            formCreator.Activate();
        }

        public static void frm_LoadCompleted(object sender, EventArgs e) {
            if (frmWait == null || frmWait.Disposing || frmWait.IsDisposed)
                return;
            frmWait.Invoke(new Action(() => { frmWait.Close(); }));
            frmWait.Dispose();
            frmWait = null;
            //frmWait.Activate();
        }
    }
}
