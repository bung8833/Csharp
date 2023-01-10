namespace ISpan.EStore.WinApp.Category_CRUD
{
	partial class FormCreateCategory
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
			this.textboxDisplayOrder = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textboxName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonSave = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textboxDisplayOrder
			// 
			this.textboxDisplayOrder.Location = new System.Drawing.Point(124, 59);
			this.textboxDisplayOrder.Name = "textboxDisplayOrder";
			this.textboxDisplayOrder.Size = new System.Drawing.Size(173, 22);
			this.textboxDisplayOrder.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(45, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 12);
			this.label2.TabIndex = 2;
			this.label2.Text = "Display Order:";
			// 
			// textboxName
			// 
			this.textboxName.AcceptsTab = true;
			this.textboxName.Location = new System.Drawing.Point(124, 31);
			this.textboxName.Name = "textboxName";
			this.textboxName.Size = new System.Drawing.Size(173, 22);
			this.textboxName.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(45, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 12);
			this.label1.TabIndex = 3;
			this.label1.Text = "Name:";
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(283, 119);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(75, 23);
			this.buttonSave.TabIndex = 6;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// FormCreateCategory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(382, 163);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.textboxDisplayOrder);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textboxName);
			this.Controls.Add(this.label1);
			this.Name = "FormCreateCategory";
			this.Text = "FormCreateCategory";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textboxDisplayOrder;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textboxName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonSave;
	}
}