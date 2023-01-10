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
            this.splitContainer_Full = new System.Windows.Forms.SplitContainer();
            this.splitContainer_Inside = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Full)).BeginInit();
            this.splitContainer_Full.Panel2.SuspendLayout();
            this.splitContainer_Full.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Inside)).BeginInit();
            this.splitContainer_Inside.Panel1.SuspendLayout();
            this.splitContainer_Inside.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Hello
            // 
            this.btn_Hello.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Hello.Location = new System.Drawing.Point(15, 4);
            this.btn_Hello.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Hello.Name = "btn_Hello";
            this.btn_Hello.Size = new System.Drawing.Size(268, 52);
            this.btn_Hello.TabIndex = 5;
            this.btn_Hello.Text = "Hello";
            this.btn_Hello.UseVisualStyleBackColor = true;
            this.btn_Hello.Click += new System.EventHandler(this.btn_Hello_Click);
            // 
            // btn_Loan
            // 
            this.btn_Loan.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Loan.Location = new System.Drawing.Point(15, 64);
            this.btn_Loan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Loan.Name = "btn_Loan";
            this.btn_Loan.Size = new System.Drawing.Size(268, 52);
            this.btn_Loan.TabIndex = 6;
            this.btn_Loan.Text = "Loan";
            this.btn_Loan.UseVisualStyleBackColor = true;
            this.btn_Loan.Click += new System.EventHandler(this.btn_Loan_Click);
            // 
            // btn_TicTacToe
            // 
            this.btn_TicTacToe.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_TicTacToe.Location = new System.Drawing.Point(15, 184);
            this.btn_TicTacToe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_TicTacToe.Name = "btn_TicTacToe";
            this.btn_TicTacToe.Size = new System.Drawing.Size(268, 52);
            this.btn_TicTacToe.TabIndex = 7;
            this.btn_TicTacToe.Text = "TicTacToe";
            this.btn_TicTacToe.UseVisualStyleBackColor = true;
            this.btn_TicTacToe.Click += new System.EventHandler(this.btn_TicTacToe_Click);
            // 
            // btn_POS
            // 
            this.btn_POS.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_POS.Location = new System.Drawing.Point(15, 124);
            this.btn_POS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_POS.Name = "btn_POS";
            this.btn_POS.Size = new System.Drawing.Size(268, 52);
            this.btn_POS.TabIndex = 8;
            this.btn_POS.Text = "POS";
            this.btn_POS.UseVisualStyleBackColor = true;
            this.btn_POS.Click += new System.EventHandler(this.btn_POS_Click);
            // 
            // splitContainer_Full
            // 
            this.splitContainer_Full.Location = new System.Drawing.Point(12, 12);
            this.splitContainer_Full.Name = "splitContainer_Full";
            this.splitContainer_Full.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_Full.Panel2
            // 
            this.splitContainer_Full.Panel2.Controls.Add(this.splitContainer_Inside);
            this.splitContainer_Full.Size = new System.Drawing.Size(1900, 1026);
            this.splitContainer_Full.SplitterDistance = 183;
            this.splitContainer_Full.TabIndex = 9;
            // 
            // splitContainer_Inside
            // 
            this.splitContainer_Inside.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Inside.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_Inside.Name = "splitContainer_Inside";
            // 
            // splitContainer_Inside.Panel1
            // 
            this.splitContainer_Inside.Panel1.Controls.Add(this.btn_Hello);
            this.splitContainer_Inside.Panel1.Controls.Add(this.btn_POS);
            this.splitContainer_Inside.Panel1.Controls.Add(this.btn_Loan);
            this.splitContainer_Inside.Panel1.Controls.Add(this.btn_TicTacToe);
            this.splitContainer_Inside.Size = new System.Drawing.Size(1900, 839);
            this.splitContainer_Inside.SplitterDistance = 295;
            this.splitContainer_Inside.TabIndex = 0;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.splitContainer_Full);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.splitContainer_Full.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Full)).EndInit();
            this.splitContainer_Full.ResumeLayout(false);
            this.splitContainer_Inside.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Inside)).EndInit();
            this.splitContainer_Inside.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Hello;
        private System.Windows.Forms.Button btn_Loan;
        private System.Windows.Forms.Button btn_TicTacToe;
        private System.Windows.Forms.Button btn_POS;
        private System.Windows.Forms.SplitContainer splitContainer_Full;
        private System.Windows.Forms.SplitContainer splitContainer_Inside;
    }
}