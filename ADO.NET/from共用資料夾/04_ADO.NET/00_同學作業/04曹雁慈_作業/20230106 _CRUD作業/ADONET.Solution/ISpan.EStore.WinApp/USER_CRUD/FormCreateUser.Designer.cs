namespace ISpan.EStore.WinApp
{
	partial class FormCreateUser
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
			this.buttonSave = new System.Windows.Forms.Button();
			this.textBoxHeight = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxDateOfBirth = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxAccount = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxEmail = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(248, 201);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(75, 23);
			this.buttonSave.TabIndex = 6;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// textBoxHeight
			// 
			this.textBoxHeight.Location = new System.Drawing.Point(110, 162);
			this.textBoxHeight.Name = "textBoxHeight";
			this.textBoxHeight.Size = new System.Drawing.Size(213, 22);
			this.textBoxHeight.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(34, 165);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(39, 12);
			this.label5.TabIndex = 11;
			this.label5.Text = "Height:";
			// 
			// textBoxDateOfBirth
			// 
			this.textBoxDateOfBirth.Location = new System.Drawing.Point(110, 134);
			this.textBoxDateOfBirth.Name = "textBoxDateOfBirth";
			this.textBoxDateOfBirth.Size = new System.Drawing.Size(213, 22);
			this.textBoxDateOfBirth.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(34, 137);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(69, 12);
			this.label4.TabIndex = 14;
			this.label4.Text = "Date of Birth:";
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Location = new System.Drawing.Point(110, 51);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.PasswordChar = '*';
			this.textBoxPassword.Size = new System.Drawing.Size(213, 22);
			this.textBoxPassword.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(34, 54);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 12);
			this.label3.TabIndex = 16;
			this.label3.Text = "Password:";
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(110, 79);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(213, 22);
			this.textBoxName.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(34, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 12);
			this.label2.TabIndex = 17;
			this.label2.Text = "Name:";
			// 
			// textBoxAccount
			// 
			this.textBoxAccount.Location = new System.Drawing.Point(110, 23);
			this.textBoxAccount.Name = "textBoxAccount";
			this.textBoxAccount.Size = new System.Drawing.Size(213, 22);
			this.textBoxAccount.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(34, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 12);
			this.label1.TabIndex = 18;
			this.label1.Text = "Account:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(34, 109);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(35, 12);
			this.label6.TabIndex = 17;
			this.label6.Text = "Email:";
			// 
			// textBoxEmail
			// 
			this.textBoxEmail.Location = new System.Drawing.Point(110, 106);
			this.textBoxEmail.Name = "textBoxEmail";
			this.textBoxEmail.Size = new System.Drawing.Size(213, 22);
			this.textBoxEmail.TabIndex = 3;
			// 
			// FormCreateUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(372, 256);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.textBoxHeight);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBoxDateOfBirth);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBoxPassword);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxEmail);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxAccount);
			this.Controls.Add(this.label1);
			this.Name = "FormCreateUser";
			this.Text = "FormCreateUser";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.TextBox textBoxHeight;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxDateOfBirth;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxAccount;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxEmail;
	}
}