﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaJaMa.Utilities
{
	public partial class frmBytesToBase64 : Form
	{
		public frmBytesToBase64()
		{
			InitializeComponent();
		}

		private List<string> _files = new List<string>();

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			if (this.dlgFiles.ShowDialog() != DialogResult.OK)
				return;
			this._files = ((IEnumerable<string>)this.dlgFiles.FileNames).ToList<string>();
			this.txtFiles.Text = string.Join(", ", this._files.Select<string, string>((Func<string, string>)(f => new FileInfo(f).Name)).ToArray<string>());
		}

		private void btnConvert_Click(object sender, EventArgs e)
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (string file in this._files)
			{
				FileInfo fileInfo = new FileInfo(file);
				string base64String = Convert.ToBase64String(File.ReadAllBytes(file));
				if (!string.IsNullOrEmpty(this.txtFormatString.Text))
					stringBuilder.AppendLine(string.Format(this.txtFormatString.Text, (object)fileInfo.Name.Substring(0, fileInfo.Name.Length - fileInfo.Extension.Length), (object)fileInfo.Extension.Substring(1), (object)base64String));
				else
					stringBuilder.AppendLine(base64String);
			}
			this.txtOutput.Text = stringBuilder.ToString();
		}
	}
}
