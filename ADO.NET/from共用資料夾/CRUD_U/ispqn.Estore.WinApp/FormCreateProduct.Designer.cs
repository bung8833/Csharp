namespace ispqn.Estore.WinApp
{
	partial class FormCreateProduct
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
			this.buttonSave = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtImage = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtStock = new System.Windows.Forms.TextBox();
			this.comboBoxId = new System.Windows.Forms.ComboBox();
			this.comboBoxstatus = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(32, 32);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "CategoryId";
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(208, 259);
			this.buttonSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(81, 36);
			this.buttonSave.TabIndex = 7;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(32, 61);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 15);
			this.label2.TabIndex = 0;
			this.label2.Text = "Name";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(126, 61);
			this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(164, 25);
			this.txtName.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(32, 89);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 15);
			this.label3.TabIndex = 0;
			this.label3.Text = "Description";
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(126, 89);
			this.txtDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(164, 25);
			this.txtDescription.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(32, 118);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(36, 15);
			this.label4.TabIndex = 0;
			this.label4.Text = "Price";
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(126, 118);
			this.txtPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(164, 25);
			this.txtPrice.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(32, 146);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(41, 15);
			this.label5.TabIndex = 0;
			this.label5.Text = "Status";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(32, 174);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(86, 15);
			this.label6.TabIndex = 0;
			this.label6.Text = "ProductImage";
			// 
			// txtImage
			// 
			this.txtImage.Location = new System.Drawing.Point(126, 174);
			this.txtImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtImage.Name = "txtImage";
			this.txtImage.Size = new System.Drawing.Size(164, 25);
			this.txtImage.TabIndex = 5;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(32, 203);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(39, 15);
			this.label7.TabIndex = 0;
			this.label7.Text = "Stock";
			// 
			// txtStock
			// 
			this.txtStock.Location = new System.Drawing.Point(126, 203);
			this.txtStock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtStock.Name = "txtStock";
			this.txtStock.Size = new System.Drawing.Size(164, 25);
			this.txtStock.TabIndex = 6;
			// 
			// comboBoxId
			// 
			this.comboBoxId.FormattingEnabled = true;
			this.comboBoxId.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
			this.comboBoxId.Location = new System.Drawing.Point(126, 29);
			this.comboBoxId.Name = "comboBoxId";
			this.comboBoxId.Size = new System.Drawing.Size(164, 23);
			this.comboBoxId.TabIndex = 8;
			// 
			// comboBoxstatus
			// 
			this.comboBoxstatus.FormattingEnabled = true;
			this.comboBoxstatus.Items.AddRange(new object[] {
            "True",
            "False"});
			this.comboBoxstatus.Location = new System.Drawing.Point(126, 148);
			this.comboBoxstatus.Name = "comboBoxstatus";
			this.comboBoxstatus.Size = new System.Drawing.Size(164, 23);
			this.comboBoxstatus.TabIndex = 9;
			// 
			// FormCreateProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(322, 310);
			this.Controls.Add(this.comboBoxstatus);
			this.Controls.Add(this.comboBoxId);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.txtStock);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtImage);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtPrice);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "FormCreateProduct";
			this.Text = "FormCreateProduct";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtImage;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtStock;
		private System.Windows.Forms.ComboBox comboBoxId;
		private System.Windows.Forms.ComboBox comboBoxstatus;
	}
}