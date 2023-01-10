namespace ispqn.Estore.WinApp
{
	partial class FormUser
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
			this.txtName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtAccount = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(33, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name:";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(82, 32);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(110, 25);
			this.txtName.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(209, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 15);
			this.label2.TabIndex = 0;
			this.label2.Text = "Account:";
			// 
			// txtAccount
			// 
			this.txtAccount.Location = new System.Drawing.Point(269, 32);
			this.txtAccount.Name = "txtAccount";
			this.txtAccount.Size = new System.Drawing.Size(110, 25);
			this.txtAccount.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(407, 32);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 15);
			this.label3.TabIndex = 0;
			this.label3.Text = "Email:";
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(456, 32);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(110, 25);
			this.txtEmail.TabIndex = 2;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(36, 81);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 27;
			this.dataGridView1.Size = new System.Drawing.Size(735, 326);
			this.dataGridView1.TabIndex = 5;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// buttonSearch
			// 
			this.buttonSearch.Location = new System.Drawing.Point(681, 32);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(90, 25);
			this.buttonSearch.TabIndex = 3;
			this.buttonSearch.Text = "Search";
			this.buttonSearch.UseVisualStyleBackColor = true;
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(681, 451);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(90, 25);
			this.buttonAdd.TabIndex = 4;
			this.buttonAdd.Text = "Add New...";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// FormUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(812, 508);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.buttonSearch);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtAccount);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label1);
			this.Name = "FormUser";
			this.Text = "FormUser";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtAccount;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button buttonSearch;
		private System.Windows.Forms.Button buttonAdd;
	}
}