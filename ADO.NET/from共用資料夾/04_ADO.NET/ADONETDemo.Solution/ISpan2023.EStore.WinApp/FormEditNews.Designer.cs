namespace ISpan2023.EStore.WinApp
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
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.textBoxDescription = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxTitle = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.labelModifiedTime = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(443, 243);
			this.buttonUpdate.Name = "buttonUpdate";
			this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
			this.buttonUpdate.TabIndex = 7;
			this.buttonUpdate.Text = "Update";
			this.buttonUpdate.UseVisualStyleBackColor = true;
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// textBoxDescription
			// 
			this.textBoxDescription.Location = new System.Drawing.Point(100, 58);
			this.textBoxDescription.Multiline = true;
			this.textBoxDescription.Name = "textBoxDescription";
			this.textBoxDescription.Size = new System.Drawing.Size(418, 179);
			this.textBoxDescription.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(23, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 12);
			this.label2.TabIndex = 3;
			this.label2.Text = "Description:";
			// 
			// textBoxTitle
			// 
			this.textBoxTitle.Location = new System.Drawing.Point(100, 30);
			this.textBoxTitle.Name = "textBoxTitle";
			this.textBoxTitle.Size = new System.Drawing.Size(418, 22);
			this.textBoxTitle.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(23, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 12);
			this.label1.TabIndex = 4;
			this.label1.Text = "Title:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 254);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 12);
			this.label3.TabIndex = 3;
			this.label3.Text = "最後異動時間:";
			// 
			// labelModifiedTime
			// 
			this.labelModifiedTime.AutoSize = true;
			this.labelModifiedTime.Location = new System.Drawing.Point(98, 254);
			this.labelModifiedTime.Name = "labelModifiedTime";
			this.labelModifiedTime.Size = new System.Drawing.Size(94, 12);
			this.labelModifiedTime.TabIndex = 3;
			this.labelModifiedTime.Text = "labelModifiedTime";
			// 
			// FormEditNews
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(544, 289);
			this.Controls.Add(this.buttonUpdate);
			this.Controls.Add(this.textBoxDescription);
			this.Controls.Add(this.labelModifiedTime);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxTitle);
			this.Controls.Add(this.label1);
			this.Name = "FormEditNews";
			this.Text = "FormEditNews";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonUpdate;
		private System.Windows.Forms.TextBox textBoxDescription;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxTitle;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label labelModifiedTime;
	}
}