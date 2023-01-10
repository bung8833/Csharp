namespace ISpan.EStore.WinApp
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
			this.textboxName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textboxDisplayOrder = new System.Windows.Forms.TextBox();
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(48, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name:";
			// 
			// textboxName
			// 
			this.textboxName.AcceptsTab = true;
			this.textboxName.Location = new System.Drawing.Point(127, 30);
			this.textboxName.Name = "textboxName";
			this.textboxName.Size = new System.Drawing.Size(173, 22);
			this.textboxName.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(48, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 12);
			this.label2.TabIndex = 0;
			this.label2.Text = "Display Order:";
			// 
			// textboxDisplayOrder
			// 
			this.textboxDisplayOrder.Location = new System.Drawing.Point(127, 58);
			this.textboxDisplayOrder.Name = "textboxDisplayOrder";
			this.textboxDisplayOrder.Size = new System.Drawing.Size(173, 22);
			this.textboxDisplayOrder.TabIndex = 1;
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(210, 101);
			this.buttonUpdate.Name = "buttonUpdate";
			this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
			this.buttonUpdate.TabIndex = 3;
			this.buttonUpdate.Text = "Update";
			this.buttonUpdate.UseVisualStyleBackColor = true;
			this.buttonUpdate.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// buttonDelete
			// 
			this.buttonDelete.Location = new System.Drawing.Point(291, 101);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(75, 23);
			this.buttonDelete.TabIndex = 4;
			this.buttonDelete.Text = "Delete";
			this.buttonDelete.UseVisualStyleBackColor = true;
			// 
			// FormEditCategory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(393, 136);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonUpdate);
			this.Controls.Add(this.textboxDisplayOrder);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textboxName);
			this.Controls.Add(this.label1);
			this.Name = "FormEditCategory";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "FormEditCategory";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textboxDisplayOrder;
		private System.Windows.Forms.Button buttonUpdate;
		private System.Windows.Forms.Button buttonDelete;
	}
}