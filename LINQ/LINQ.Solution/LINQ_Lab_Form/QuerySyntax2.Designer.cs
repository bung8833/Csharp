namespace LINQ_Lab_Form
{
    partial class QuerySyntax2
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
            this.buttonSieve = new System.Windows.Forms.Button();
            this.buttonGroup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(287, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(303, 351);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonSieve
            // 
            this.buttonSieve.Location = new System.Drawing.Point(12, 12);
            this.buttonSieve.Name = "buttonSieve";
            this.buttonSieve.Size = new System.Drawing.Size(220, 62);
            this.buttonSieve.TabIndex = 1;
            this.buttonSieve.Text = "查詢 int[] 篩選偶數資料";
            this.buttonSieve.UseVisualStyleBackColor = true;
            this.buttonSieve.Click += new System.EventHandler(this.buttonSieve_Click);
            // 
            // buttonGroup
            // 
            this.buttonGroup.Location = new System.Drawing.Point(12, 98);
            this.buttonGroup.Name = "buttonGroup";
            this.buttonGroup.Size = new System.Drawing.Size(220, 62);
            this.buttonGroup.TabIndex = 2;
            this.buttonGroup.Text = "查詢 int[] 奇偶數群組";
            this.buttonGroup.UseVisualStyleBackColor = true;
            // 
            // QuerySyntax2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGroup);
            this.Controls.Add(this.buttonSieve);
            this.Controls.Add(this.dataGridView1);
            this.Name = "QuerySyntax2";
            this.Text = "QuerySyntax2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSieve;
        private System.Windows.Forms.Button buttonGroup;
    }
}