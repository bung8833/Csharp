namespace Lab_Homework
{
    partial class HomePage
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
            this.btn_Hello = new System.Windows.Forms.Button();
            this.btn_Loan = new System.Windows.Forms.Button();
            this.btn_TicTacToe = new System.Windows.Forms.Button();
            this.btn_POS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Hello
            // 
            this.btn_Hello.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Hello.Location = new System.Drawing.Point(14, 14);
            this.btn_Hello.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Hello.Name = "btn_Hello";
            this.btn_Hello.Size = new System.Drawing.Size(287, 74);
            this.btn_Hello.TabIndex = 5;
            this.btn_Hello.Text = "Hello";
            this.btn_Hello.UseVisualStyleBackColor = true;
            this.btn_Hello.Click += new System.EventHandler(this.btn_Hello_Click);
            // 
            // btn_Loan
            // 
            this.btn_Loan.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Loan.Location = new System.Drawing.Point(14, 96);
            this.btn_Loan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Loan.Name = "btn_Loan";
            this.btn_Loan.Size = new System.Drawing.Size(287, 74);
            this.btn_Loan.TabIndex = 6;
            this.btn_Loan.Text = "Loan";
            this.btn_Loan.UseVisualStyleBackColor = true;
            this.btn_Loan.Click += new System.EventHandler(this.btn_Loan_Click);
            // 
            // btn_TicTacToe
            // 
            this.btn_TicTacToe.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_TicTacToe.Location = new System.Drawing.Point(14, 178);
            this.btn_TicTacToe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_TicTacToe.Name = "btn_TicTacToe";
            this.btn_TicTacToe.Size = new System.Drawing.Size(287, 74);
            this.btn_TicTacToe.TabIndex = 7;
            this.btn_TicTacToe.Text = "TicTacToe";
            this.btn_TicTacToe.UseVisualStyleBackColor = true;
            this.btn_TicTacToe.Click += new System.EventHandler(this.btn_TicTacToe_Click);
            // 
            // btn_POS
            // 
            this.btn_POS.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_POS.Location = new System.Drawing.Point(14, 260);
            this.btn_POS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_POS.Name = "btn_POS";
            this.btn_POS.Size = new System.Drawing.Size(287, 74);
            this.btn_POS.TabIndex = 8;
            this.btn_POS.Text = "POS";
            this.btn_POS.UseVisualStyleBackColor = true;
            this.btn_POS.Click += new System.EventHandler(this.btn_POS_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 828);
            this.Controls.Add(this.btn_POS);
            this.Controls.Add(this.btn_TicTacToe);
            this.Controls.Add(this.btn_Loan);
            this.Controls.Add(this.btn_Hello);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Hello;
        private System.Windows.Forms.Button btn_Loan;
        private System.Windows.Forms.Button btn_TicTacToe;
        private System.Windows.Forms.Button btn_POS;
    }
}