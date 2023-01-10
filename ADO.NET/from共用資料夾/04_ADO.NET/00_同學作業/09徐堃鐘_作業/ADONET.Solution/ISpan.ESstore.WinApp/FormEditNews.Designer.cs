namespace ISpan.ESstore.WinApp
{
	partial class FormEditNews
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
			this.textBoxTitle = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxDescription = new System.Windows.Forms.TextBox();
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.labelModifiedTime = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(35, 63);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Title:";
			// 
			// textBoxTitle
			// 
			this.textBoxTitle.Location = new System.Drawing.Point(118, 60);
			this.textBoxTitle.Name = "textBoxTitle";
			this.textBoxTitle.Size = new System.Drawing.Size(460, 25);
			this.textBoxTitle.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(35, 94);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 15);
			this.label2.TabIndex = 0;
			this.label2.Text = "Description:";
			// 
			// textBoxDescription
			// 
			this.textBoxDescription.Location = new System.Drawing.Point(118, 91);
			this.textBoxDescription.Multiline = true;
			this.textBoxDescription.Name = "textBoxDescription";
			this.textBoxDescription.Size = new System.Drawing.Size(460, 223);
			this.textBoxDescription.TabIndex = 1;
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(480, 335);
			this.buttonUpdate.Name = "buttonUpdate";
			this.buttonUpdate.Size = new System.Drawing.Size(98, 40);
			this.buttonUpdate.TabIndex = 2;
			this.buttonUpdate.Text = "Update";
			this.buttonUpdate.UseVisualStyleBackColor = true;
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(35, 348);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 15);
			this.label3.TabIndex = 3;
			this.label3.Text = "異動時間：";
			// 
			// labelModifiedTime
			// 
			this.labelModifiedTime.AutoSize = true;
			this.labelModifiedTime.Location = new System.Drawing.Point(123, 348);
			this.labelModifiedTime.Name = "labelModifiedTime";
			this.labelModifiedTime.Size = new System.Drawing.Size(117, 15);
			this.labelModifiedTime.TabIndex = 4;
			this.labelModifiedTime.Text = "labelModifiedTime";
			// 
			// FormEditNews
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(609, 402);
			this.Controls.Add(this.labelModifiedTime);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.buttonUpdate);
			this.Controls.Add(this.textBoxDescription);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxTitle);
			this.Controls.Add(this.label1);
			this.Name = "FormEditNews";
			this.Text = "FormEditNews";
			this.Load += new System.EventHandler(this.FormEditNews_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxTitle;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxDescription;
		private System.Windows.Forms.Button buttonUpdate;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label labelModifiedTime;
	}
}