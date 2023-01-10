namespace ISpan2023.EStore.WinApp
{
	partial class FormLogin
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
			this.textBoxAccount = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.buttonLogin = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(40, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "Account:";
			// 
			// textBoxAccount
			// 
			this.textBoxAccount.Location = new System.Drawing.Point(95, 39);
			this.textBoxAccount.Name = "textBoxAccount";
			this.textBoxAccount.Size = new System.Drawing.Size(163, 22);
			this.textBoxAccount.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(40, 90);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 12);
			this.label2.TabIndex = 0;
			this.label2.Text = "Password:";
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Location = new System.Drawing.Point(95, 87);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.Size = new System.Drawing.Size(163, 22);
			this.textBoxPassword.TabIndex = 1;
			// 
			// buttonLogin
			// 
			this.buttonLogin.Location = new System.Drawing.Point(95, 146);
			this.buttonLogin.Name = "buttonLogin";
			this.buttonLogin.Size = new System.Drawing.Size(163, 23);
			this.buttonLogin.TabIndex = 2;
			this.buttonLogin.Text = "Login";
			this.buttonLogin.UseVisualStyleBackColor = true;
			this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
			// 
			// FormLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(333, 239);
			this.Controls.Add(this.buttonLogin);
			this.Controls.Add(this.textBoxPassword);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxAccount);
			this.Controls.Add(this.label1);
			this.Name = "FormLogin";
			this.Text = "FormLogin";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxAccount;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.Button buttonLogin;
	}
}