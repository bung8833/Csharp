﻿namespace Linq_Lab_Form
{
	partial class Lab_彙總運算
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
			((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvShow
			// 
			this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvShow.Location = new System.Drawing.Point(162, 26);
			this.dgvShow.Name = "dgvShow";
			this.dgvShow.RowTemplate.Height = 24;
			this.dgvShow.Size = new System.Drawing.Size(626, 402);
			this.dgvShow.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(14, 41);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(125, 55);
			this.button1.TabIndex = 3;
			this.button1.Text = "Group By Products";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Lab_彙總運算
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dgvShow);
			this.Name = "Lab_彙總運算";
			this.Text = "Lab_彙總運算";
			((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvShow;
		private System.Windows.Forms.Button button1;
	}
}