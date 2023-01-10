namespace ispqn.Estore.WinApp
{
	partial class FormProducts
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
			this.label2 = new System.Windows.Forms.Label();
			this.labelId = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtId = new System.Windows.Forms.TextBox();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.buttonAdd = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(174, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 19);
			this.label2.TabIndex = 18;
			this.label2.Text = "Id:";
			// 
			// labelId
			// 
			this.labelId.AutoSize = true;
			this.labelId.Location = new System.Drawing.Point(467, 30);
			this.labelId.Name = "labelId";
			this.labelId.Size = new System.Drawing.Size(57, 19);
			this.labelId.TabIndex = 17;
			this.labelId.Text = "Name:";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(544, 30);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(127, 30);
			this.txtName.TabIndex = 15;
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(221, 30);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(127, 30);
			this.txtId.TabIndex = 14;
			// 
			// buttonSearch
			// 
			this.buttonSearch.Location = new System.Drawing.Point(830, 21);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(105, 43);
			this.buttonSearch.TabIndex = 16;
			this.buttonSearch.Text = "Search";
			this.buttonSearch.UseVisualStyleBackColor = true;
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// dataGridView2
			// 
			this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(55, 71);
			this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.RowHeadersWidth = 51;
			this.dataGridView2.RowTemplate.Height = 27;
			this.dataGridView2.Size = new System.Drawing.Size(991, 336);
			this.dataGridView2.TabIndex = 13;
			this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(55, 71);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 27;
			this.dataGridView1.Size = new System.Drawing.Size(991, 336);
			this.dataGridView1.TabIndex = 19;
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(866, 434);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(105, 43);
			this.buttonAdd.TabIndex = 20;
			this.buttonAdd.Text = "Add New..";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// FormProducts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1088, 552);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.labelId);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.buttonSearch);
			this.Controls.Add(this.dataGridView2);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FormProducts";
			this.Text = "FormProducts";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labelId;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.Button buttonSearch;
		public System.Windows.Forms.DataGridView dataGridView2;
		public System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button buttonAdd;
	}
}