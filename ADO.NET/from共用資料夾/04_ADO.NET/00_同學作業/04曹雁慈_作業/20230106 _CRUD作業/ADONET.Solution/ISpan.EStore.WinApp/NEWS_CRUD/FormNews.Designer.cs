namespace ISpan.EStore.WinApp.NEWS_CRUD
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
			this.buttonAddNew = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.textBoxTitle = new System.Windows.Forms.TextBox();
			this.textBoxId = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxDescription = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonAddNew
			// 
			this.buttonAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonAddNew.Location = new System.Drawing.Point(722, 232);
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
			this.dataGridView1.Location = new System.Drawing.Point(12, 70);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(785, 145);
			this.dataGridView1.TabIndex = 13;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// buttonSearch
			// 
			this.buttonSearch.Location = new System.Drawing.Point(496, 26);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(75, 23);
			this.buttonSearch.TabIndex = 12;
			this.buttonSearch.Text = "Search";
			this.buttonSearch.UseVisualStyleBackColor = true;
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// textBoxTitle
			// 
			this.textBoxTitle.Location = new System.Drawing.Point(183, 28);
			this.textBoxTitle.Name = "textBoxTitle";
			this.textBoxTitle.Size = new System.Drawing.Size(86, 22);
			this.textBoxTitle.TabIndex = 10;
			// 
			// textBoxId
			// 
			this.textBoxId.Location = new System.Drawing.Point(38, 28);
			this.textBoxId.Name = "textBoxId";
			this.textBoxId.Size = new System.Drawing.Size(86, 22);
			this.textBoxId.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(151, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(26, 12);
			this.label2.TabIndex = 8;
			this.label2.Text = "Title";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(18, 12);
			this.label1.TabIndex = 9;
			this.label1.Text = "Id:";
			// 
			// textBoxDescription
			// 
			this.textBoxDescription.Location = new System.Drawing.Point(369, 28);
			this.textBoxDescription.Name = "textBoxDescription";
			this.textBoxDescription.Size = new System.Drawing.Size(86, 22);
			this.textBoxDescription.TabIndex = 16;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(305, 31);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 12);
			this.label3.TabIndex = 15;
			this.label3.Text = "Description:";
			// 
			// FormNews
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(809, 267);
			this.Controls.Add(this.textBoxDescription);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.buttonAddNew);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.buttonSearch);
			this.Controls.Add(this.textBoxTitle);
			this.Controls.Add(this.textBoxId);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FormNews";
			this.Text = "FormNews";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonAddNew;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button buttonSearch;
		private System.Windows.Forms.TextBox textBoxTitle;
		private System.Windows.Forms.TextBox textBoxId;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxDescription;
		private System.Windows.Forms.Label label3;
	}
}