namespace ISpan.EStore.WinApp
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
			this.maintainNewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.maintainUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.maintainProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.maintainCategoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.form1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.maintainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.categoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maintainNewsToolStripMenuItem,
            this.maintainUsersToolStripMenuItem,
            this.maintainProductsToolStripMenuItem,
            this.maintainCategoriesToolStripMenuItem,
            this.form1ToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.maintainToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(761, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// maintainNewsToolStripMenuItem
			// 
			this.maintainNewsToolStripMenuItem.Name = "maintainNewsToolStripMenuItem";
			this.maintainNewsToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
			this.maintainNewsToolStripMenuItem.Text = "Maintain News (&N)";
			this.maintainNewsToolStripMenuItem.Click += new System.EventHandler(this.maintainNewsToolStripMenuItem_Click);
			// 
			// maintainUsersToolStripMenuItem
			// 
			this.maintainUsersToolStripMenuItem.Name = "maintainUsersToolStripMenuItem";
			this.maintainUsersToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
			this.maintainUsersToolStripMenuItem.Text = "Maintain Users";
			this.maintainUsersToolStripMenuItem.Click += new System.EventHandler(this.maintainUsersToolStripMenuItem_Click);
			// 
			// maintainProductsToolStripMenuItem
			// 
			this.maintainProductsToolStripMenuItem.Name = "maintainProductsToolStripMenuItem";
			this.maintainProductsToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
			this.maintainProductsToolStripMenuItem.Text = "Maintain Products";
			this.maintainProductsToolStripMenuItem.Click += new System.EventHandler(this.maintainProductsToolStripMenuItem_Click);
			// 
			// maintainCategoriesToolStripMenuItem
			// 
			this.maintainCategoriesToolStripMenuItem.Name = "maintainCategoriesToolStripMenuItem";
			this.maintainCategoriesToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
			this.maintainCategoriesToolStripMenuItem.Text = "Maintain Categories";
			// 
			// form1ToolStripMenuItem
			// 
			this.form1ToolStripMenuItem.Name = "form1ToolStripMenuItem";
			this.form1ToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
			this.form1ToolStripMenuItem.Text = "Form 1";
			// 
			// logOutToolStripMenuItem
			// 
			this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
			this.logOutToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
			this.logOutToolStripMenuItem.Text = "Log Out";
			this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
			// 
			// maintainToolStripMenuItem
			// 
			this.maintainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.newsToolStripMenuItem,
            this.categoriesToolStripMenuItem});
			this.maintainToolStripMenuItem.Name = "maintainToolStripMenuItem";
			this.maintainToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
			this.maintainToolStripMenuItem.Text = "Maintain";
			// 
			// usersToolStripMenuItem
			// 
			this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
			this.usersToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
			this.usersToolStripMenuItem.Text = "Users";
			// 
			// productsToolStripMenuItem
			// 
			this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
			this.productsToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
			this.productsToolStripMenuItem.Text = "Products";
			// 
			// newsToolStripMenuItem
			// 
			this.newsToolStripMenuItem.Name = "newsToolStripMenuItem";
			this.newsToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
			this.newsToolStripMenuItem.Text = "News";
			// 
			// categoriesToolStripMenuItem
			// 
			this.categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
			this.categoriesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
			this.categoriesToolStripMenuItem.Text = "Categories";
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(761, 342);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(732, 257);
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
		private System.Windows.Forms.ToolStripMenuItem maintainNewsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem maintainUsersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem maintainProductsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem maintainCategoriesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem form1ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem maintainToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem categoriesToolStripMenuItem;
	}
}