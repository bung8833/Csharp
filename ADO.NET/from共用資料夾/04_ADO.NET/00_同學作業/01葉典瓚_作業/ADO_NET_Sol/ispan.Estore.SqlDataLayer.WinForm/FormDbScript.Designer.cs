namespace ispan.Estore.SqlDataLayer.WinForm
{
    partial class FormDbScript
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
            this.buttonCreateRepo = new System.Windows.Forms.Button();
            this.buttonGetDistTable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(730, 295);
            this.dataGridView1.TabIndex = 1;
            // 
            // buttonCreateRepo
            // 
            this.buttonCreateRepo.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonCreateRepo.Location = new System.Drawing.Point(12, 26);
            this.buttonCreateRepo.Name = "buttonCreateRepo";
            this.buttonCreateRepo.Size = new System.Drawing.Size(136, 69);
            this.buttonCreateRepo.TabIndex = 0;
            this.buttonCreateRepo.Text = "CreateRepo";
            this.buttonCreateRepo.UseVisualStyleBackColor = true;
            this.buttonCreateRepo.Click += new System.EventHandler(this.buttonCreateRepo_Click);
            // 
            // buttonGetDistTable
            // 
            this.buttonGetDistTable.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonGetDistTable.Location = new System.Drawing.Point(167, 26);
            this.buttonGetDistTable.Name = "buttonGetDistTable";
            this.buttonGetDistTable.Size = new System.Drawing.Size(136, 69);
            this.buttonGetDistTable.TabIndex = 2;
            this.buttonGetDistTable.Text = "GetDistTable";
            this.buttonGetDistTable.UseVisualStyleBackColor = true;
            this.buttonGetDistTable.Click += new System.EventHandler(this.buttonGetDistTable_Click);
            // 
            // FormDbScript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGetDistTable);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonCreateRepo);
            this.Name = "FormDbScript";
            this.Text = "FormDbScript";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonCreateRepo;
        private System.Windows.Forms.Button buttonGetDistTable;
    }
}