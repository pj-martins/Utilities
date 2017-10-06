namespace PaJaMa.Utilities
{
	partial class frmMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.bytesToBase64ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.encryptDecryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.processMonitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bytesToBase64ToolStripMenuItem,
            this.encryptDecryptToolStripMenuItem,
            this.processMonitorToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(557, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// bytesToBase64ToolStripMenuItem
			// 
			this.bytesToBase64ToolStripMenuItem.Name = "bytesToBase64ToolStripMenuItem";
			this.bytesToBase64ToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
			this.bytesToBase64ToolStripMenuItem.Text = "Bytes to Base 64";
			this.bytesToBase64ToolStripMenuItem.Click += new System.EventHandler(this.bytesToBase64ToolStripMenuItem_Click);
			// 
			// encryptDecryptToolStripMenuItem
			// 
			this.encryptDecryptToolStripMenuItem.Name = "encryptDecryptToolStripMenuItem";
			this.encryptDecryptToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
			this.encryptDecryptToolStripMenuItem.Text = "Encrypt Decrypt";
			this.encryptDecryptToolStripMenuItem.Click += new System.EventHandler(this.encryptDecryptToolStripMenuItem_Click);
			// 
			// processMonitorToolStripMenuItem
			// 
			this.processMonitorToolStripMenuItem.Name = "processMonitorToolStripMenuItem";
			this.processMonitorToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
			this.processMonitorToolStripMenuItem.Text = "Process Monitor";
			this.processMonitorToolStripMenuItem.Click += new System.EventHandler(this.processMonitorToolStripMenuItem_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(557, 379);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Utilities";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem bytesToBase64ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem encryptDecryptToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem processMonitorToolStripMenuItem;
	}
}

