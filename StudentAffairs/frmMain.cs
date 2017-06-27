#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using StudentAffairs.formData;
namespace StudentAffairs {
    public partial class frmMain : RibbonForm {
        public static event EventHandler LoadCompleted;

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            this.OnLoadCompleted(EventArgs.Empty);
        }
        protected virtual void OnLoadCompleted(EventArgs e) {
            var handler = LoadCompleted;
            if (handler != null) handler(this, e);
            loadForm.eventCompleted = true;
        }

        public frmMain() {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e) {
            frmStudentList frmStudentList = new frmStudentList();
            frmStudentList.MdiParent = this;
            frmStudentList.Show();
            //loadForm.showWaitForm(frmStudentList);
            //loadForm.showWaitForm()



        }

        private void toolStripButton1_Click(object sender, EventArgs e) {

        }
    }
}
 