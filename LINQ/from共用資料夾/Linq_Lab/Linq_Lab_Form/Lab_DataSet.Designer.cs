namespace Linq_Lab_Form
{
	partial class Lab_DataSet
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
			this.dgvShow = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvShow
			// 
			this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvShow.Location = new System.Drawing.Point(12, 86);
			this.dgvShow.Name = "dgvShow";
			this.dgvShow.RowTemplate.Height = 24;
			this.dgvShow.Size = new System.Drawing.Size(776, 352);
			this.dgvShow.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(32, 30);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(133, 40);
			this.button1.TabIndex = 1;
			this.button1.Text = "Query";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(183, 30);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(133, 40);
			this.button2.TabIndex = 2;
			this.button2.Text = "Query by USA";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(339, 30);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(133, 40);
			this.button3.TabIndex = 3;
			this.button3.Text = "Query by USA Employees1";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// Lab_DataSet
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dgvShow);
			this.Name = "Lab_DataSet";
			this.Text = "Lab_DataSet";
			((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvShow;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
	}
}