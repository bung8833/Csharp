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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btn_Calculator = new System.Windows.Forms.Button();
            this.panelRight = new System.Windows.Forms.Panel();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.buttonGuessTheNumber = new System.Windows.Forms.Button();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Hello
            // 
            this.btn_Hello.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Hello.Location = new System.Drawing.Point(5, 4);
            this.btn_Hello.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Hello.Name = "btn_Hello";
            this.btn_Hello.Size = new System.Drawing.Size(199, 35);
            this.btn_Hello.TabIndex = 0;
            this.btn_Hello.Text = "Hello";
            this.btn_Hello.UseVisualStyleBackColor = true;
            this.btn_Hello.Click += new System.EventHandler(this.btn_Hello_Click);
            // 
            // btn_Loan
            // 
            this.btn_Loan.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Loan.Location = new System.Drawing.Point(5, 47);
            this.btn_Loan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Loan.Name = "btn_Loan";
            this.btn_Loan.Size = new System.Drawing.Size(199, 35);
            this.btn_Loan.TabIndex = 1;
            this.btn_Loan.Text = "Loan";
            this.btn_Loan.UseVisualStyleBackColor = true;
            this.btn_Loan.Click += new System.EventHandler(this.btn_Loan_Click);
            // 
            // btn_TicTacToe
            // 
            this.btn_TicTacToe.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_TicTacToe.Location = new System.Drawing.Point(5, 176);
            this.btn_TicTacToe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_TicTacToe.Name = "btn_TicTacToe";
            this.btn_TicTacToe.Size = new System.Drawing.Size(199, 35);
            this.btn_TicTacToe.TabIndex = 3;
            this.btn_TicTacToe.Text = "TicTacToe";
            this.btn_TicTacToe.UseVisualStyleBackColor = true;
            this.btn_TicTacToe.Click += new System.EventHandler(this.btn_TicTacToe_Click);
            // 
            // btn_POS
            // 
            this.btn_POS.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_POS.Location = new System.Drawing.Point(5, 90);
            this.btn_POS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_POS.Name = "btn_POS";
            this.btn_POS.Size = new System.Drawing.Size(199, 35);
            this.btn_POS.TabIndex = 2;
            this.btn_POS.Text = "POS";
            this.btn_POS.UseVisualStyleBackColor = true;
            this.btn_POS.Click += new System.EventHandler(this.btn_POS_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelLeft.Controls.Add(this.buttonGuessTheNumber);
            this.panelLeft.Controls.Add(this.btn_Calculator);
            this.panelLeft.Controls.Add(this.btn_Hello);
            this.panelLeft.Controls.Add(this.btn_TicTacToe);
            this.panelLeft.Controls.Add(this.btn_Loan);
            this.panelLeft.Controls.Add(this.btn_POS);
            this.panelLeft.Location = new System.Drawing.Point(12, 12);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(215, 583);
            this.panelLeft.TabIndex = 0;
            // 
            // btn_Calculator
            // 
            this.btn_Calculator.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Calculator.Location = new System.Drawing.Point(5, 133);
            this.btn_Calculator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Calculator.Name = "btn_Calculator";
            this.btn_Calculator.Size = new System.Drawing.Size(199, 35);
            this.btn_Calculator.TabIndex = 4;
            this.btn_Calculator.Text = "Calculator";
            this.btn_Calculator.UseVisualStyleBackColor = true;
            this.btn_Calculator.Click += new System.EventHandler(this.btn_Calculator_Click);
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelRight.Controls.Add(this.splitter2);
            this.panelRight.Location = new System.Drawing.Point(233, 12);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(898, 583);
            this.panelRight.TabIndex = 0;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(0, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 579);
            this.splitter2.TabIndex = 0;
            this.splitter2.TabStop = false;
            // 
            // buttonGuessTheNumber
            // 
            this.buttonGuessTheNumber.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonGuessTheNumber.Location = new System.Drawing.Point(5, 219);
            this.buttonGuessTheNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonGuessTheNumber.Name = "buttonGuessTheNumber";
            this.buttonGuessTheNumber.Size = new System.Drawing.Size(199, 35);
            this.buttonGuessTheNumber.TabIndex = 5;
            this.buttonGuessTheNumber.Text = "GuessTheNumber";
            this.buttonGuessTheNumber.UseVisualStyleBackColor = true;
            this.buttonGuessTheNumber.Click += new System.EventHandler(this.buttonGuessTheNumber_Click);
            // 
            // HomePage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1143, 607);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.panelLeft.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Hello;
        private System.Windows.Forms.Button btn_Loan;
        private System.Windows.Forms.Button btn_TicTacToe;
        private System.Windows.Forms.Button btn_POS;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Button btn_Calculator;
        private System.Windows.Forms.Button buttonGuessTheNumber;
    }
}