﻿namespace ispqn.Estore.WinApp
{
	partial class FormNews
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonadd = new System.Windows.Forms.Button();
			this.buttonsearch = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(34, 78);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 66;
			this.dataGridView1.RowTemplate.Height = 32;
			this.dataGridView1.Size = new System.Drawing.Size(724, 331);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// txtTitle
			// 
			this.txtTitle.Location = new System.Drawing.Point(143, 22);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(152, 30);
			this.txtTitle.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(75, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 19);
			this.label1.TabIndex = 2;
			this.label1.Text = "Title";
			// 
			// buttonadd
			// 
			this.buttonadd.Location = new System.Drawing.Point(655, 415);
			this.buttonadd.Name = "buttonadd";
			this.buttonadd.Size = new System.Drawing.Size(103, 41);
			this.buttonadd.TabIndex = 3;
			this.buttonadd.Text = "Add New..";
			this.buttonadd.UseVisualStyleBackColor = true;
			this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
			// 
			// buttonsearch
			// 
			this.buttonsearch.Location = new System.Drawing.Point(655, 14);
			this.buttonsearch.Name = "buttonsearch";
			this.buttonsearch.Size = new System.Drawing.Size(103, 41);
			this.buttonsearch.TabIndex = 4;
			this.buttonsearch.Text = "Search";
			this.buttonsearch.UseVisualStyleBackColor = true;
			this.buttonsearch.Click += new System.EventHandler(this.buttonsearch_Click);
			// 
			// FormNews
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 468);
			this.Controls.Add(this.buttonsearch);
			this.Controls.Add(this.buttonadd);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtTitle);
			this.Controls.Add(this.dataGridView1);
			this.Name = "FormNews";
			this.Text = "FormNews";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonadd;
		private System.Windows.Forms.Button buttonsearch;
	}
}