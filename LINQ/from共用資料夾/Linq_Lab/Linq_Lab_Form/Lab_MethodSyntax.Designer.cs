namespace Linq_Lab_Form
{
	partial class Lab_MethodSyntax
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
			this.button1 = new System.Windows.Forms.Button();
			this.dgvShow = new System.Windows.Forms.DataGridView();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.cmbCategory = new System.Windows.Forms.ComboBox();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(135, 54);
			this.button1.TabIndex = 6;
			this.button1.Text = "Employees";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dgvShow
			// 
			this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvShow.Location = new System.Drawing.Point(12, 170);
			this.dgvShow.Name = "dgvShow";
			this.dgvShow.RowTemplate.Height = 24;
			this.dgvShow.Size = new System.Drawing.Size(776, 348);
			this.dgvShow.TabIndex = 5;
			// 
			// button2
			// 
			this.button2.Cursor = System.Windows.Forms.Cursors.Default;
			this.button2.Location = new System.Drawing.Point(162, 12);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(135, 54);
			this.button2.TabIndex = 7;
			this.button2.Text = "GroupBy";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Cursor = System.Windows.Forms.Cursors.Default;
			this.button3.Location = new System.Drawing.Point(303, 12);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(135, 54);
			this.button3.TabIndex = 8;
			this.button3.Text = "join";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Cursor = System.Windows.Forms.Cursors.Default;
			this.button4.Location = new System.Drawing.Point(444, 12);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(135, 54);
			this.button4.TabIndex = 9;
			this.button4.Text = "OrderyBy";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Cursor = System.Windows.Forms.Cursors.Default;
			this.button5.Location = new System.Drawing.Point(585, 12);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(135, 54);
			this.button5.TabIndex = 10;
			this.button5.Text = "ThenBy";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button6
			// 
			this.button6.Cursor = System.Windows.Forms.Cursors.Default;
			this.button6.Location = new System.Drawing.Point(12, 72);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(135, 54);
			this.button6.TabIndex = 11;
			this.button6.Text = "SelectMany";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button7
			// 
			this.button7.Cursor = System.Windows.Forms.Cursors.Default;
			this.button7.Location = new System.Drawing.Point(162, 110);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(135, 54);
			this.button7.TabIndex = 12;
			this.button7.Text = "Product By Beer";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// cmbCategory
			// 
			this.cmbCategory.FormattingEnabled = true;
			this.cmbCategory.Location = new System.Drawing.Point(162, 84);
			this.cmbCategory.Name = "cmbCategory";
			this.cmbCategory.Size = new System.Drawing.Size(137, 20);
			this.cmbCategory.TabIndex = 13;
			// 
			// button8
			// 
			this.button8.Cursor = System.Windows.Forms.Cursors.Default;
			this.button8.Location = new System.Drawing.Point(305, 78);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(135, 42);
			this.button8.TabIndex = 14;
			this.button8.Text = "All";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// button9
			// 
			this.button9.Cursor = System.Windows.Forms.Cursors.Default;
			this.button9.Location = new System.Drawing.Point(305, 126);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(135, 42);
			this.button9.TabIndex = 15;
			this.button9.Text = "所有種類都有圖片(All)";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.button9_Click);
			// 
			// button10
			// 
			this.button10.Cursor = System.Windows.Forms.Cursors.Default;
			this.button10.Location = new System.Drawing.Point(446, 78);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(135, 42);
			this.button10.TabIndex = 16;
			this.button10.Text = "Func";
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Click += new System.EventHandler(this.button10_Click);
			// 
			// button11
			// 
			this.button11.Cursor = System.Windows.Forms.Cursors.Default;
			this.button11.Location = new System.Drawing.Point(444, 126);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(135, 42);
			this.button11.TabIndex = 17;
			this.button11.Text = "Func lab";
			this.button11.UseVisualStyleBackColor = true;
			this.button11.Click += new System.EventHandler(this.button11_Click);
			// 
			// Lab_MethodSyntax
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 530);
			this.Controls.Add(this.button11);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.cmbCategory);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dgvShow);
			this.Name = "Lab_MethodSyntax";
			this.Text = "Lab_MethodSyntax";
			this.Load += new System.EventHandler(this.Lab_MethodSyntax_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridView dgvShow;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.ComboBox cmbCategory;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button11;
	}
}