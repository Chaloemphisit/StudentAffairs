#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace StudentAffairs {
    public partial class frmWait : Syncfusion.Windows.Forms.MetroForm {

        public frmWait() {
            InitializeComponent();
        }
        private void frmWait_Load(object sender, EventArgs e) {
            timer1.Enabled = true;
            timer1.Start();
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void timer1_Tick(object sender, EventArgs e) {
            if (progressBarAdv1.Value != 100) {
                progressBarAdv1.Value+=2;
            } else {
                timer1.Stop();
            }
        }
    }
}
