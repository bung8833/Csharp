namespace Linq_Lab_Form
{
	partial class Lab_員工群組
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
			this.dgvEmployeeGroup = new System.Windows.Forms.DataGridView();
			this.dgvEmployees = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeGroup)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 21);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(125, 44);
			this.button1.TabIndex = 0;
			this.button1.Text = "Employee Group";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dgvEmployeeGroup
			// 
			this.dgvEmployeeGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvEmployeeGroup.Location = new System.Drawing.Point(12, 82);
			this.dgvEmployeeGroup.Name = "dgvEmployeeGroup";
			this.dgvEmployeeGroup.RowTemplate.Height = 24;
			this.dgvEmployeeGroup.Size = new System.Drawing.Size(206, 301);
			this.dgvEmployeeGroup.TabIndex = 1;
			this.dgvEmployeeGroup.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployeeGroup_CellClick);
			// 
			// dgvEmployees
			// 
			this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvEmployees.Location = new System.Drawing.Point(224, 82);
			this.dgvEmployees.Name = "dgvEmployees";
			this.dgvEmployees.RowTemplate.Height = 24;
			this.dgvEmployees.Size = new System.Drawing.Size(564, 356);
			this.dgvEmployees.TabIndex = 2;
			// 
			// Lab_員工群組
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dgvEmployees);
			this.Controls.Add(this.dgvEmployeeGroup);
			this.Controls.Add(this.button1);
			this.Name = "Lab_員工群組";
			this.Text = "Lab_員工群組";
			((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeGroup)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridView dgvEmployeeGroup;
		private System.Windows.Forms.DataGridView dgvEmployees;
	}
}