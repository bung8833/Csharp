namespace ispqn.Estore.WinApp
{
	partial class FormCreateNews
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
			this.tex_title = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tex_Description = new System.Windows.Forms.TextBox();
			this.btn_save = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(44, 85);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Title";
			// 
			// tex_title
			// 
			this.tex_title.Location = new System.Drawing.Point(142, 75);
			this.tex_title.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tex_title.Name = "tex_title";
			this.tex_title.Size = new System.Drawing.Size(668, 30);
			this.tex_title.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(44, 162);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(93, 19);
			this.label2.TabIndex = 0;
			this.label2.Text = "Description";
			// 
			// tex_Description
			// 
			this.tex_Description.Location = new System.Drawing.Point(142, 158);
			this.tex_Description.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tex_Description.Multiline = true;
			this.tex_Description.Name = "tex_Description";
			this.tex_Description.Size = new System.Drawing.Size(668, 308);
			this.tex_Description.TabIndex = 1;
			// 
			// btn_save
			// 
			this.btn_save.Location = new System.Drawing.Point(830, 481);
			this.btn_save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btn_save.Name = "btn_save";
			this.btn_save.Size = new System.Drawing.Size(138, 54);
			this.btn_save.TabIndex = 2;
			this.btn_save.Text = "Save";
			this.btn_save.UseVisualStyleBackColor = true;
			this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
			// 
			// FormCreateNews
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1000, 570);
			this.Controls.Add(this.btn_save);
			this.Controls.Add(this.tex_Description);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tex_title);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "FormCreateNews";
			this.Text = "FormCreateNews";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tex_title;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tex_Description;
		private System.Windows.Forms.Button btn_save;
	}
}