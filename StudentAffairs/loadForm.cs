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
        frmWait frmWait;
        Thread splashThread;

        private static Boolean eventComplt = false;

        public static Boolean eventCompleted {
            get { return eventComplt; }
            set { eventComplt = value; }
        }
        


        public void showWaitForm(Form formCreator) {
            //check Login Status
            if (Module.authentication.checkStatus()) {
                //Show Wait Form
                frmWait = new frmWait();
                if (frmWait != null) {
                     splashThread = new Thread(new ThreadStart(
                        () => { frmWait.ShowDialog(); }));//Application.Run(frmWait);
                    splashThread.SetApartmentState(ApartmentState.STA);
                    splashThread.Start();
                }

                formCreator.Load += frm_LoadCompleted;
                //Application.Run(formCreator);
                formCreator.Show();

            } else {
                Application.OpenForms.Cast<Form>().Where(x => !(x is formAuth.frmLogin)).ToList().ForEach(x => x.Close());
            }
        }

        public void frm_LoadCompleted(object sender, EventArgs e) {
            if (frmWait == null || frmWait.Disposing || frmWait.IsDisposed) return;
            frmWait.Invoke(new Action(() => { frmWait.Close(); }));
            frmWait.Dispose();
            //frmWait.Close();
            frmWait = null;
            //splashThread.Abort();
            //frmWait.Activate();
        }
    }
}
