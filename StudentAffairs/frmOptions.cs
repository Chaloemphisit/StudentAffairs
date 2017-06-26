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
using System.Windows.Forms;

namespace StudentAffairs {
    public partial class frmOptions : Syncfusion.Windows.Forms.MetroForm {
        public frmOptions() {
            InitializeComponent();
        }

        List<Panel> Panels = new List<Panel>();
        Panel VisiblePanel = null;

        private void frmOptions_Load(object sender, EventArgs e) {
            // Move the Panels out of the TabControl.
            tabControl1.Visible = false;
            foreach (TabPage page in tabControl1.TabPages) {
                // Add the Panel to the list.
                Panel panel = page.Controls[0] as Panel;
                Panels.Add(panel);

                // Reparent and move the Panel.
                panel.Parent = tabControl1.Parent;
                panel.Location = tabControl1.Location;
                panel.Visible = false;
            }

            // Display the first panel.
            DisplayPanel(0);
        }

        // Display the appropriate Panel.
        private void DisplayPanel(int index) {
            if (Panels.Count < 1) return;

            // If this is the same Panel, do nothing.
            if (VisiblePanel == Panels[index]) return;

            // Hide the previously visible Panel.
            if (VisiblePanel != null) VisiblePanel.Visible = false;

            // Display the appropriate Panel.
            Panels[index].Visible = true;
            VisiblePanel = Panels[index];
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e) {
            int index = int.Parse(e.Node.Tag.ToString());
            DisplayPanel(index);
        }
    }
}
