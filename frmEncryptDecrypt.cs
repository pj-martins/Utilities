using PaJaMa.Common;
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
	public partial class frmEncryptDecrypt : Form
	{
		public frmEncryptDecrypt()
		{
			InitializeComponent();
		}

		private void btnEncrypt_Click(object sender, EventArgs e)
		{
			try
			{
				txtOutput.Text = EncrypterDecrypter.Instance.Encrypt(txtInput.Text, txtPassword.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnDecrypt_Click(object sender, EventArgs e)
		{
			try
			{
				txtOutput.Text = EncrypterDecrypter.Instance.Decrypt(txtInput.Text, txtPassword.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
