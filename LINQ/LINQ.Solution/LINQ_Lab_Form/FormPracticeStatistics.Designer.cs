namespace LINQ_Lab_Form
{
    partial class FormPracticeStatistics
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
            this.dataGridViewCountry = new System.Windows.Forms.DataGridView();
            this.dataGridViewEmp = new System.Windows.Forms.DataGridView();
            this.buttonGruopByCountry = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCountry
            // 
            this.dataGridViewCountry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCountry.Location = new System.Drawing.Point(35, 124);
            this.dataGridViewCountry.Name = "dataGridViewCountry";
            this.dataGridViewCountry.RowHeadersWidth = 62;
            this.dataGridViewCountry.RowTemplate.Height = 31;
            this.dataGridViewCountry.Size = new System.Drawing.Size(228, 330);
            this.dataGridViewCountry.TabIndex = 0;
            this.dataGridViewCountry.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCountry_CellClick);
            // 
            // dataGridViewEmp
            // 
            this.dataGridViewEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmp.Location = new System.Drawing.Point(282, 27);
            this.dataGridViewEmp.Name = "dataGridViewEmp";
            this.dataGridViewEmp.RowHeadersWidth = 62;
            this.dataGridViewEmp.RowTemplate.Height = 31;
            this.dataGridViewEmp.Size = new System.Drawing.Size(697, 427);
            this.dataGridViewEmp.TabIndex = 1;
            // 
            // buttonGruopByCountry
            // 
            this.buttonGruopByCountry.Location = new System.Drawing.Point(35, 27);
            this.buttonGruopByCountry.Name = "buttonGruopByCountry";
            this.buttonGruopByCountry.Size = new System.Drawing.Size(228, 69);
            this.buttonGruopByCountry.TabIndex = 2;
            this.buttonGruopByCountry.Text = "Gruop By Country";
            this.buttonGruopByCountry.UseVisualStyleBackColor = true;
            this.buttonGruopByCountry.Click += new System.EventHandler(this.buttonGruopByCountry_Click);
            // 
            // FormPracticeStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 498);
            this.Controls.Add(this.buttonGruopByCountry);
            this.Controls.Add(this.dataGridViewEmp);
            this.Controls.Add(this.dataGridViewCountry);
            this.Name = "FormPracticeStatistics";
            this.Text = "FormPracticeStatistics";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCountry;
        private System.Windows.Forms.DataGridView dataGridViewEmp;
        private System.Windows.Forms.Button buttonGruopByCountry;
    }
}