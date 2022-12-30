namespace Lab_Homework
{
    partial class HW_Loan
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
            this.lbl_financed = new System.Windows.Forms.Label();
            this.lbl_years = new System.Windows.Forms.Label();
            this.lbl_rate = new System.Windows.Forms.Label();
            this.btn_PMT = new System.Windows.Forms.Button();
            this.btn_total = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
            this.txtBox_financed = new System.Windows.Forms.TextBox();
            this.txtBox_years = new System.Windows.Forms.TextBox();
            this.txtBox_rate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_financed
            // 
            this.lbl_financed.AutoSize = true;
            this.lbl_financed.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_financed.Location = new System.Drawing.Point(50, 44);
            this.lbl_financed.Name = "lbl_financed";
            this.lbl_financed.Size = new System.Drawing.Size(155, 35);
            this.lbl_financed.TabIndex = 0;
            this.lbl_financed.Text = "貸款金額：";
            // 
            // lbl_years
            // 
            this.lbl_years.AutoSize = true;
            this.lbl_years.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_years.Location = new System.Drawing.Point(50, 114);
            this.lbl_years.Name = "lbl_years";
            this.lbl_years.Size = new System.Drawing.Size(124, 35);
            this.lbl_years.TabIndex = 1;
            this.lbl_years.Text = "期限 (年)";
            // 
            // lbl_rate
            // 
            this.lbl_rate.AutoSize = true;
            this.lbl_rate.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_rate.Location = new System.Drawing.Point(50, 184);
            this.lbl_rate.Name = "lbl_rate";
            this.lbl_rate.Size = new System.Drawing.Size(121, 35);
            this.lbl_rate.TabIndex = 2;
            this.lbl_rate.Text = "利率 (%)";
            // 
            // btn_PMT
            // 
            this.btn_PMT.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_PMT.Location = new System.Drawing.Point(89, 354);
            this.btn_PMT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_PMT.Name = "btn_PMT";
            this.btn_PMT.Size = new System.Drawing.Size(175, 75);
            this.btn_PMT.TabIndex = 4;
            this.btn_PMT.Text = "PMT (月付)";
            this.btn_PMT.UseVisualStyleBackColor = true;
            this.btn_PMT.Click += new System.EventHandler(this.btn_PMT_Click);
            // 
            // btn_total
            // 
            this.btn_total.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_total.Location = new System.Drawing.Point(287, 354);
            this.btn_total.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_total.Name = "btn_total";
            this.btn_total.Size = new System.Drawing.Size(175, 75);
            this.btn_total.TabIndex = 5;
            this.btn_total.Text = "Total";
            this.btn_total.UseVisualStyleBackColor = true;
            this.btn_total.Click += new System.EventHandler(this.btn_total_Click);
            // 
            // btn_report
            // 
            this.btn_report.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_report.Location = new System.Drawing.Point(525, 354);
            this.btn_report.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(175, 75);
            this.btn_report.TabIndex = 6;
            this.btn_report.Text = "Report";
            this.btn_report.UseVisualStyleBackColor = true;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // txtBox_financed
            // 
            this.txtBox_financed.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBox_financed.Location = new System.Drawing.Point(270, 40);
            this.txtBox_financed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBox_financed.Name = "txtBox_financed";
            this.txtBox_financed.Size = new System.Drawing.Size(192, 39);
            this.txtBox_financed.TabIndex = 7;
            this.txtBox_financed.Text = "240000";
            // 
            // txtBox_years
            // 
            this.txtBox_years.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBox_years.Location = new System.Drawing.Point(270, 110);
            this.txtBox_years.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBox_years.Name = "txtBox_years";
            this.txtBox_years.Size = new System.Drawing.Size(192, 39);
            this.txtBox_years.TabIndex = 8;
            this.txtBox_years.Text = "2";
            // 
            // txtBox_rate
            // 
            this.txtBox_rate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBox_rate.Location = new System.Drawing.Point(270, 180);
            this.txtBox_rate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBox_rate.Name = "txtBox_rate";
            this.txtBox_rate.Size = new System.Drawing.Size(192, 39);
            this.txtBox_rate.TabIndex = 9;
            this.txtBox_rate.Text = "2.4";
            // 
            // HW_Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 540);
            this.Controls.Add(this.txtBox_rate);
            this.Controls.Add(this.txtBox_years);
            this.Controls.Add(this.txtBox_financed);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.btn_total);
            this.Controls.Add(this.btn_PMT);
            this.Controls.Add(this.lbl_rate);
            this.Controls.Add(this.lbl_years);
            this.Controls.Add(this.lbl_financed);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HW_Loan";
            this.Text = "HW_Loan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_financed;
        private System.Windows.Forms.Label lbl_years;
        private System.Windows.Forms.Label lbl_rate;
        private System.Windows.Forms.Button btn_PMT;
        private System.Windows.Forms.Button btn_total;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.TextBox txtBox_financed;
        private System.Windows.Forms.TextBox txtBox_years;
        private System.Windows.Forms.TextBox txtBox_rate;
    }
}