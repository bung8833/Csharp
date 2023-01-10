namespace ISpan2023.EStore.WinApp
{
	partial class FormCrreateProduct
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
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBoxCategoryId = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxDescription = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxPrice = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.radioButtonStatus0 = new System.Windows.Forms.RadioButton();
			this.radioButtonStatus1 = new System.Windows.Forms.RadioButton();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxStock = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBoxImage = new System.Windows.Forms.TextBox();
			this.buttonSave = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(56, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "Category:";
			// 
			// comboBoxCategoryId
			// 
			this.comboBoxCategoryId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxCategoryId.FormattingEnabled = true;
			this.comboBoxCategoryId.Location = new System.Drawing.Point(123, 26);
			this.comboBoxCategoryId.Name = "comboBoxCategoryId";
			this.comboBoxCategoryId.Size = new System.Drawing.Size(213, 20);
			this.comboBoxCategoryId.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(56, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 12);
			this.label2.TabIndex = 2;
			this.label2.Text = "Name:";
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(123, 52);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(213, 22);
			this.textBoxName.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(56, 83);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 12);
			this.label3.TabIndex = 2;
			this.label3.Text = "Description:";
			// 
			// textBoxDescription
			// 
			this.textBoxDescription.Location = new System.Drawing.Point(123, 80);
			this.textBoxDescription.Multiline = true;
			this.textBoxDescription.Name = "textBoxDescription";
			this.textBoxDescription.Size = new System.Drawing.Size(213, 86);
			this.textBoxDescription.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(56, 175);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(31, 12);
			this.label4.TabIndex = 2;
			this.label4.Text = "Price:";
			// 
			// textBoxPrice
			// 
			this.textBoxPrice.Location = new System.Drawing.Point(123, 172);
			this.textBoxPrice.Name = "textBoxPrice";
			this.textBoxPrice.Size = new System.Drawing.Size(213, 22);
			this.textBoxPrice.TabIndex = 3;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.radioButtonStatus0);
			this.panel1.Controls.Add(this.radioButtonStatus1);
			this.panel1.Location = new System.Drawing.Point(123, 201);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(213, 35);
			this.panel1.TabIndex = 4;
			// 
			// radioButtonStatus0
			// 
			this.radioButtonStatus0.AutoSize = true;
			this.radioButtonStatus0.Location = new System.Drawing.Point(79, 12);
			this.radioButtonStatus0.Name = "radioButtonStatus0";
			this.radioButtonStatus0.Size = new System.Drawing.Size(47, 16);
			this.radioButtonStatus0.TabIndex = 1;
			this.radioButtonStatus0.TabStop = true;
			this.radioButtonStatus0.Text = "下架";
			this.radioButtonStatus0.UseVisualStyleBackColor = true;
			// 
			// radioButtonStatus1
			// 
			this.radioButtonStatus1.AutoSize = true;
			this.radioButtonStatus1.Location = new System.Drawing.Point(12, 12);
			this.radioButtonStatus1.Name = "radioButtonStatus1";
			this.radioButtonStatus1.Size = new System.Drawing.Size(47, 16);
			this.radioButtonStatus1.TabIndex = 0;
			this.radioButtonStatus1.TabStop = true;
			this.radioButtonStatus1.Text = "上架";
			this.radioButtonStatus1.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(56, 213);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(35, 12);
			this.label5.TabIndex = 2;
			this.label5.Text = "Status:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(56, 245);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(34, 12);
			this.label6.TabIndex = 2;
			this.label6.Text = "Stock:";
			// 
			// textBoxStock
			// 
			this.textBoxStock.Location = new System.Drawing.Point(123, 242);
			this.textBoxStock.Name = "textBoxStock";
			this.textBoxStock.Size = new System.Drawing.Size(213, 22);
			this.textBoxStock.TabIndex = 4;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(56, 273);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(37, 12);
			this.label7.TabIndex = 2;
			this.label7.Text = "Image:";
			// 
			// textBoxImage
			// 
			this.textBoxImage.Location = new System.Drawing.Point(123, 270);
			this.textBoxImage.Name = "textBoxImage";
			this.textBoxImage.Size = new System.Drawing.Size(213, 22);
			this.textBoxImage.TabIndex = 5;
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(261, 307);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(75, 23);
			this.buttonSave.TabIndex = 6;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// FormCrreateProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(411, 363);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.textBoxDescription);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxImage);
			this.Controls.Add(this.textBoxStock);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBoxPrice);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.comboBoxCategoryId);
			this.Controls.Add(this.label1);
			this.Name = "FormCrreateProduct";
			this.Text = "FormCrreateProduct";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBoxCategoryId;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxDescription;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxPrice;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton radioButtonStatus0;
		private System.Windows.Forms.RadioButton radioButtonStatus1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxStock;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBoxImage;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}