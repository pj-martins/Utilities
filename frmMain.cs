using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaJaMa.Utilities
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		private void bytesToBase64ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			showForm<frmBytesToBase64>();
		}

		private void encryptDecryptToolStripMenuItem_Click(object sender, EventArgs e)
		{
			showForm<frmEncryptDecrypt>(false);
		}

		private void processMonitorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			showForm<frmProcessMonitor>();
		}

		private void showForm<TForm>(bool maximize = true) where TForm : Form
		{
			var frm = Activator.CreateInstance<TForm>();
			if (maximize)
				frm.WindowState = FormWindowState.Maximized;
			frm.MdiParent = this;
			frm.Show();
		}
	}
}
