namespace ISpan2023.EStore.WinApp
{
	partial class FormBatchUpdateCategory
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
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.buttonUpdate2 = new System.Windows.Forms.Button();
			this.buttonReload = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(61, 56);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(471, 209);
			this.dataGridView1.TabIndex = 0;
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(457, 271);
			this.buttonUpdate.Name = "buttonUpdate";
			this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
			this.buttonUpdate.TabIndex = 1;
			this.buttonUpdate.Text = "Update";
			this.buttonUpdate.UseVisualStyleBackColor = true;
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// buttonUpdate2
			// 
			this.buttonUpdate2.Location = new System.Drawing.Point(457, 300);
			this.buttonUpdate2.Name = "buttonUpdate2";
			this.buttonUpdate2.Size = new System.Drawing.Size(75, 23);
			this.buttonUpdate2.TabIndex = 2;
			this.buttonUpdate2.Text = "Update2";
			this.buttonUpdate2.UseVisualStyleBackColor = true;
			this.buttonUpdate2.Click += new System.EventHandler(this.buttonUpdate2_Click);
			// 
			// buttonReload
			// 
			this.buttonReload.Location = new System.Drawing.Point(376, 300);
			this.buttonReload.Name = "buttonReload";
			this.buttonReload.Size = new System.Drawing.Size(75, 23);
			this.buttonReload.TabIndex = 3;
			this.buttonReload.Text = "重新整理";
			this.buttonReload.UseVisualStyleBackColor = true;
			this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
			// 
			// FormBatchUpdateCategory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonReload);
			this.Controls.Add(this.buttonUpdate2);
			this.Controls.Add(this.buttonUpdate);
			this.Controls.Add(this.dataGridView1);
			this.Name = "FormBatchUpdateCategory";
			this.Text = "FormBatchUpdateCategory";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button buttonUpdate;
		private System.Windows.Forms.Button buttonUpdate2;
		private System.Windows.Forms.Button buttonReload;
	}
}