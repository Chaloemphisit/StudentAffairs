using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//Using formAuth and formData
using StudentAffairs.formAuth;
using StudentAffairs.formData;

namespace StudentAffairs
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmLogin());
            //Application.Run(new frmRegister());
            Application.Run(new formData.frmBehaviorList());
        }
    }
}
