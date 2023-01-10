namespace ISpan2023.EStore.WinApp
{
	partial class FormMain
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
			this.維護NewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.維護商品ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.維護商品分類CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.form1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.登出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.維護NewsToolStripMenuItem,
            this.維護商品ToolStripMenuItem,
            this.維護商品分類CToolStripMenuItem,
            this.form1ToolStripMenuItem,
            this.登出ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 維護NewsToolStripMenuItem
			// 
			this.維護NewsToolStripMenuItem.Name = "維護NewsToolStripMenuItem";
			this.維護NewsToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
			this.維護NewsToolStripMenuItem.Text = "維護 News";
			this.維護NewsToolStripMenuItem.Click += new System.EventHandler(this.維護NewsToolStripMenuItem_Click);
			// 
			// 維護商品ToolStripMenuItem
			// 
			this.維護商品ToolStripMenuItem.Name = "維護商品ToolStripMenuItem";
			this.維護商品ToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
			this.維護商品ToolStripMenuItem.Text = "維護商品_singleton";
			this.維護商品ToolStripMenuItem.Click += new System.EventHandler(this.維護商品ToolStripMenuItem_Click);
			// 
			// 維護商品分類CToolStripMenuItem
			// 
			this.維護商品分類CToolStripMenuItem.Name = "維護商品分類CToolStripMenuItem";
			this.維護商品分類CToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
			this.維護商品分類CToolStripMenuItem.Text = "維護商品分類&C";
			this.維護商品分類CToolStripMenuItem.Click += new System.EventHandler(this.維護商品分類CToolStripMenuItem_Click);
			// 
			// form1ToolStripMenuItem
			// 
			this.form1ToolStripMenuItem.Name = "form1ToolStripMenuItem";
			this.form1ToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
			this.form1ToolStripMenuItem.Text = "Form 1";
			this.form1ToolStripMenuItem.Click += new System.EventHandler(this.form1ToolStripMenuItem_Click);
			// 
			// 登出ToolStripMenuItem
			// 
			this.登出ToolStripMenuItem.Name = "登出ToolStripMenuItem";
			this.登出ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.登出ToolStripMenuItem.Text = "登出";
			this.登出ToolStripMenuItem.Click += new System.EventHandler(this.登出ToolStripMenuItem_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FormMain";
			this.Text = "FormMain";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 維護NewsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 維護商品ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 維護商品分類CToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 登出ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem form1ToolStripMenuItem;
	}
}