using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAffairs.Module {
    class modFunction {

        public static string passwordGen(int n=8) {
            String ch = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            string result = "";
            Random rnd = new Random();
            StringBuilder sb = new StringBuilder();
            for(int i=1; i <= n; i++) {
                int x = rnd.Next(0, ch.Length - 1);
                result += ch.Substring(x, 1);
            }

            return result;

        }

        public static string UsernameGen(string id) {

            return "T" + id;
        }
        
        public static Boolean validNullTxt(System.Windows.Forms.Control txtCtl, 
                            System.Windows.Forms.ErrorProvider errorProvider,
                           int minLength = 0,string type=null,string msg = "This field is required") {

            switch (type) {

                case "Number": {
                        break;
                    }
                case "strEnglishOnly": {
                        break;
                    }
                default: {
                        if ((!String.IsNullOrWhiteSpace(txtCtl.Text))) {
                            errorProvider.SetError(txtCtl, "");
                            return false;
                        } else {
                            if (txtCtl.Text.Length < minLength) msg += " and Length must be greater than " + minLength;
                            errorProvider.SetError(txtCtl, msg);
                            return true;
                        }
                    }
            }
            return false;
            
        }

        public static Boolean validNotSelectCB(Syncfusion.Windows.Forms.Tools.ComboBoxAdv cbCtl, 
                           System.Windows.Forms.ErrorProvider errorProvider, string msg = "This field is required") {

            if (cbCtl.SelectedIndex==-1) {
                errorProvider.SetError(cbCtl, msg);
                return true;
            } else {
                errorProvider.SetError(cbCtl, "");
                return false;
            }
        }
    }
}
