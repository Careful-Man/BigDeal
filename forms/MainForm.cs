using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigDeal.forms {
	public partial class MainForm : Form {

		private List<Panel> panelList;

		public MainForm() {
			InitializeComponent();
			hidePanels();
		}

		//my methods
		private void hidePanels() {
			try {
				if(panelList == null) {
					panelList = new List<Panel>();
					panelList.Add(panelSubMenuProionta);
					panelList.Add(panelSubMenuPromitheftes);
					panelList.Add(panelSubMenuSimfonies);
				}
			} catch (Exception ex) {

			}

			foreach (Panel panel in panelList) {
				panel.Visible = false;
			}
		}




		//event handling
		private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
			DialogResult drYesNo = MessageBox.Show(
					"Είστε βέβαιοι ότι θέλετε να κλείσετε το πρόγραμμα;",
					"Big Deal - Κλείσιμο",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Warning);
			if(drYesNo == DialogResult.No) 
				e.Cancel = true;
		}

		private void buttonProducts_Click(object sender, EventArgs e) {
			panelSubMenuProionta.Visible = !panelSubMenuProionta.Visible;

		}

		private void buttonMenuPromitheftes_Click(object sender, EventArgs e) {
			panelSubMenuPromitheftes.Visible = !panelSubMenuPromitheftes.Visible;
		}

		private void buttonMenuSimfonies_Click(object sender, EventArgs e) {
			panelSubMenuSimfonies.Visible = !panelSubMenuSimfonies.Visible;
		}

        private void buttonMenuItemEidi_Click(object sender, EventArgs e) {
			if (!tabController.TabPages.ContainsKey("Είδη")) {
                tabController.TabPages.Add(buttonMenuItemEidi.Text);
            }
        }

    }
}
