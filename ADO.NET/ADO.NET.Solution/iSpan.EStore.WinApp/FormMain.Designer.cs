namespace iSpan.EStore.WinApp
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
            this.maintainProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintainNewsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.form1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintainProductsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.maintainUsersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.maintainCategoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maintainProductsToolStripMenuItem,
            this.form1ToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1027, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // maintainProductsToolStripMenuItem
            // 
            this.maintainProductsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maintainUsersToolStripMenuItem1,
            this.maintainNewsToolStripMenuItem1,
            this.maintainProductsToolStripMenuItem1,
            this.maintainCategoriesToolStripMenuItem});
            this.maintainProductsToolStripMenuItem.Name = "maintainProductsToolStripMenuItem";
            this.maintainProductsToolStripMenuItem.Size = new System.Drawing.Size(102, 28);
            this.maintainProductsToolStripMenuItem.Text = "Maintain";
            // 
            // maintainNewsToolStripMenuItem1
            // 
            this.maintainNewsToolStripMenuItem1.Name = "maintainNewsToolStripMenuItem1";
            this.maintainNewsToolStripMenuItem1.Size = new System.Drawing.Size(282, 34);
            this.maintainNewsToolStripMenuItem1.Text = "Maintain News";
            this.maintainNewsToolStripMenuItem1.Click += new System.EventHandler(this.maintainNewsToolStripMenuItem1_Click);
            // 
            // form1ToolStripMenuItem
            // 
            this.form1ToolStripMenuItem.Name = "form1ToolStripMenuItem";
            this.form1ToolStripMenuItem.Size = new System.Drawing.Size(80, 28);
            this.form1ToolStripMenuItem.Text = "Form1";
            this.form1ToolStripMenuItem.Click += new System.EventHandler(this.form1ToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(95, 28);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // maintainProductsToolStripMenuItem1
            // 
            this.maintainProductsToolStripMenuItem1.Name = "maintainProductsToolStripMenuItem1";
            this.maintainProductsToolStripMenuItem1.Size = new System.Drawing.Size(282, 34);
            this.maintainProductsToolStripMenuItem1.Text = "Maintain Products";
            this.maintainProductsToolStripMenuItem1.Click += new System.EventHandler(this.maintainProductsToolStripMenuItem1_Click);
            // 
            // maintainUsersToolStripMenuItem1
            // 
            this.maintainUsersToolStripMenuItem1.Name = "maintainUsersToolStripMenuItem1";
            this.maintainUsersToolStripMenuItem1.Size = new System.Drawing.Size(282, 34);
            this.maintainUsersToolStripMenuItem1.Text = "Maintain Users";
            this.maintainUsersToolStripMenuItem1.Click += new System.EventHandler(this.maintainUsersToolStripMenuItem1_Click);
            // 
            // maintainCategoriesToolStripMenuItem
            // 
            this.maintainCategoriesToolStripMenuItem.Name = "maintainCategoriesToolStripMenuItem";
            this.maintainCategoriesToolStripMenuItem.Size = new System.Drawing.Size(282, 34);
            this.maintainCategoriesToolStripMenuItem.Text = "Maintain Categories";
            this.maintainCategoriesToolStripMenuItem.Click += new System.EventHandler(this.maintainCategoriesToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 537);
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
        private System.Windows.Forms.ToolStripMenuItem maintainProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintainUsersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem maintainNewsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem maintainProductsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem form1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintainCategoriesToolStripMenuItem;
    }
}