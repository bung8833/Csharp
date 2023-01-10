namespace ispqn.Estore.WinApp
{
    partial class FormEditCategory
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtDisplayOrder = new System.Windows.Forms.TextBox();
			this.buttonupdate = new System.Windows.Forms.Button();
			this.buttondelete = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 32);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 19);
			this.label1.TabIndex = 1;
			this.label1.Text = "Name";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 80);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 19);
			this.label2.TabIndex = 2;
			this.label2.Text = "Display Order";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(129, 28);
			this.txtName.Margin = new System.Windows.Forms.Padding(4);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(367, 30);
			this.txtName.TabIndex = 3;
			// 
			// txtDisplayOrder
			// 
			this.txtDisplayOrder.Location = new System.Drawing.Point(129, 67);
			this.txtDisplayOrder.Margin = new System.Windows.Forms.Padding(4);
			this.txtDisplayOrder.Name = "txtDisplayOrder";
			this.txtDisplayOrder.Size = new System.Drawing.Size(367, 30);
			this.txtDisplayOrder.TabIndex = 4;
			// 
			// buttonupdate
			// 
			this.buttonupdate.Location = new System.Drawing.Point(265, 127);
			this.buttonupdate.Name = "buttonupdate";
			this.buttonupdate.Size = new System.Drawing.Size(117, 36);
			this.buttonupdate.TabIndex = 5;
			this.buttonupdate.Text = "Update";
			this.buttonupdate.UseVisualStyleBackColor = true;
			this.buttonupdate.Click += new System.EventHandler(this.buttonupdate_Click);
			// 
			// buttondelete
			// 
			this.buttondelete.Location = new System.Drawing.Point(393, 127);
			this.buttondelete.Name = "buttondelete";
			this.buttondelete.Size = new System.Drawing.Size(117, 36);
			this.buttondelete.TabIndex = 6;
			this.buttondelete.Text = "Delete";
			this.buttondelete.UseVisualStyleBackColor = true;
			this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
			// 
			// FormEditCategory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(522, 175);
			this.Controls.Add(this.buttondelete);
			this.Controls.Add(this.buttonupdate);
			this.Controls.Add(this.txtDisplayOrder);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FormEditCategory";
			this.Text = "FormEditCategory";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDisplayOrder;
		private System.Windows.Forms.Button buttonupdate;
		private System.Windows.Forms.Button buttondelete;
	}
}