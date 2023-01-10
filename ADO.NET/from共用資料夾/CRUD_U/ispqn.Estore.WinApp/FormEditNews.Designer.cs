namespace ispqn.Estore.WinApp
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
			this.textDescription = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textTitle = new System.Windows.Forms.TextBox();
			this.btn_Update = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.labelModified = new System.Windows.Forms.Label();
			this.buttondelete = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(66, 114);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Description";
			// 
			// textDescription
			// 
			this.textDescription.Location = new System.Drawing.Point(175, 110);
			this.textDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textDescription.Multiline = true;
			this.textDescription.Name = "textDescription";
			this.textDescription.Size = new System.Drawing.Size(460, 357);
			this.textDescription.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(66, 47);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 19);
			this.label2.TabIndex = 0;
			this.label2.Text = "Title";
			// 
			// textTitle
			// 
			this.textTitle.Location = new System.Drawing.Point(175, 43);
			this.textTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textTitle.Name = "textTitle";
			this.textTitle.Size = new System.Drawing.Size(460, 30);
			this.textTitle.TabIndex = 1;
			// 
			// btn_Update
			// 
			this.btn_Update.Location = new System.Drawing.Point(662, 475);
			this.btn_Update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btn_Update.Name = "btn_Update";
			this.btn_Update.Size = new System.Drawing.Size(110, 39);
			this.btn_Update.TabIndex = 2;
			this.btn_Update.Text = "UpDate";
			this.btn_Update.UseVisualStyleBackColor = true;
			this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(21, 495);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 19);
			this.label3.TabIndex = 3;
			this.label3.Text = "異動時間:";
			// 
			// labelModified
			// 
			this.labelModified.AutoSize = true;
			this.labelModified.Location = new System.Drawing.Point(118, 495);
			this.labelModified.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelModified.Name = "labelModified";
			this.labelModified.Size = new System.Drawing.Size(98, 19);
			this.labelModified.TabIndex = 3;
			this.labelModified.Text = "labModified";
			// 
			// buttondelete
			// 
			this.buttondelete.Location = new System.Drawing.Point(798, 475);
			this.buttondelete.Margin = new System.Windows.Forms.Padding(4);
			this.buttondelete.Name = "buttondelete";
			this.buttondelete.Size = new System.Drawing.Size(110, 39);
			this.buttondelete.TabIndex = 4;
			this.buttondelete.Text = "Delete";
			this.buttondelete.UseVisualStyleBackColor = true;
			this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
			// 
			// FormEditNews
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1000, 570);
			this.Controls.Add(this.buttondelete);
			this.Controls.Add(this.labelModified);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btn_Update);
			this.Controls.Add(this.textTitle);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textDescription);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "FormEditNews";
			this.Text = "FormEditNews";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textDescription;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textTitle;
		private System.Windows.Forms.Button btn_Update;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label labelModified;
		private System.Windows.Forms.Button buttondelete;
	}
}