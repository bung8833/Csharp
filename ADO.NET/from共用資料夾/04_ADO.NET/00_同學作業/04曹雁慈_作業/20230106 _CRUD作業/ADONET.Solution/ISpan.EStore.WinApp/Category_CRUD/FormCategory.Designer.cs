namespace ISpan.EStore.WinApp.Category_CRUD
{
	partial class FormCategory
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
			this.buttonAddNew = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.textBoxDisplayOrder = new System.Windows.Forms.TextBox();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonAddNew
			// 
			this.buttonAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonAddNew.Location = new System.Drawing.Point(713, 383);
			this.buttonAddNew.Name = "buttonAddNew";
			this.buttonAddNew.Size = new System.Drawing.Size(75, 23);
			this.buttonAddNew.TabIndex = 14;
			this.buttonAddNew.Text = "Add New...";
			this.buttonAddNew.UseVisualStyleBackColor = true;
			this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(11, 69);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(777, 308);
			this.dataGridView1.TabIndex = 13;
			// 
			// buttonSearch
			// 
			this.buttonSearch.Location = new System.Drawing.Point(419, 28);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(75, 23);
			this.buttonSearch.TabIndex = 12;
			this.buttonSearch.Text = "Search";
			this.buttonSearch.UseVisualStyleBackColor = true;
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// textBoxDisplayOrder
			// 
			this.textBoxDisplayOrder.Location = new System.Drawing.Point(244, 28);
			this.textBoxDisplayOrder.Name = "textBoxDisplayOrder";
			this.textBoxDisplayOrder.Size = new System.Drawing.Size(125, 22);
			this.textBoxDisplayOrder.TabIndex = 10;
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(48, 27);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(98, 22);
			this.textBoxName.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(168, 30);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 12);
			this.label2.TabIndex = 8;
			this.label2.Text = "DisplayOrder:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 12);
			this.label1.TabIndex = 9;
			this.label1.Text = "Name:";
			// 
			// FormCategory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 418);
			this.Controls.Add(this.buttonAddNew);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.buttonSearch);
			this.Controls.Add(this.textBoxDisplayOrder);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FormCategory";
			this.Text = "FormCategory";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonAddNew;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button buttonSearch;
		private System.Windows.Forms.TextBox textBoxDisplayOrder;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}