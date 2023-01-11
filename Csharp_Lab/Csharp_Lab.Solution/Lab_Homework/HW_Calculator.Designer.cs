namespace Lab_Homework
{
    partial class HW_Calculator
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
            this.textBoxNum1 = new System.Windows.Forms.TextBox();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.labelNum1 = new System.Windows.Forms.Label();
            this.labelDivisionLine = new System.Windows.Forms.Label();
            this.labelNum2 = new System.Windows.Forms.Label();
            this.textBoxNum2 = new System.Windows.Forms.TextBox();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNum1
            // 
            this.textBoxNum1.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxNum1.Location = new System.Drawing.Point(146, 63);
            this.textBoxNum1.Name = "textBoxNum1";
            this.textBoxNum1.Size = new System.Drawing.Size(187, 37);
            this.textBoxNum1.TabIndex = 0;
            // 
            // buttonPlus
            // 
            this.buttonPlus.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonPlus.Location = new System.Drawing.Point(372, 39);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(79, 43);
            this.buttonPlus.TabIndex = 2;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // labelNum1
            // 
            this.labelNum1.AutoSize = true;
            this.labelNum1.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelNum1.Location = new System.Drawing.Point(59, 66);
            this.labelNum1.Name = "labelNum1";
            this.labelNum1.Size = new System.Drawing.Size(81, 28);
            this.labelNum1.TabIndex = 6;
            this.labelNum1.Text = "Num1:";
            // 
            // labelDivisionLine
            // 
            this.labelDivisionLine.AutoSize = true;
            this.labelDivisionLine.Location = new System.Drawing.Point(40, 159);
            this.labelDivisionLine.Name = "labelDivisionLine";
            this.labelDivisionLine.Size = new System.Drawing.Size(318, 18);
            this.labelDivisionLine.TabIndex = 8;
            this.labelDivisionLine.Text = "===============================";
            // 
            // labelNum2
            // 
            this.labelNum2.AutoSize = true;
            this.labelNum2.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelNum2.Location = new System.Drawing.Point(59, 116);
            this.labelNum2.Name = "labelNum2";
            this.labelNum2.Size = new System.Drawing.Size(81, 28);
            this.labelNum2.TabIndex = 7;
            this.labelNum2.Text = "Num2:";
            // 
            // textBoxNum2
            // 
            this.textBoxNum2.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxNum2.Location = new System.Drawing.Point(146, 113);
            this.textBoxNum2.Name = "textBoxNum2";
            this.textBoxNum2.Size = new System.Drawing.Size(187, 37);
            this.textBoxNum2.TabIndex = 1;
            // 
            // labelAnswer
            // 
            this.labelAnswer.AutoSize = true;
            this.labelAnswer.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelAnswer.Location = new System.Drawing.Point(48, 189);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(92, 28);
            this.labelAnswer.TabIndex = 9;
            this.labelAnswer.Text = "Answer:";
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxAnswer.ForeColor = System.Drawing.Color.Black;
            this.textBoxAnswer.Location = new System.Drawing.Point(146, 186);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.ReadOnly = true;
            this.textBoxAnswer.Size = new System.Drawing.Size(187, 37);
            this.textBoxAnswer.TabIndex = 10;
            this.textBoxAnswer.TabStop = false;
            // 
            // buttonMinus
            // 
            this.buttonMinus.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonMinus.Location = new System.Drawing.Point(372, 88);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(79, 43);
            this.buttonMinus.TabIndex = 3;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonMultiply.Location = new System.Drawing.Point(372, 137);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(79, 43);
            this.buttonMultiply.TabIndex = 4;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonMultiply_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonDivide.Location = new System.Drawing.Point(372, 186);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(79, 43);
            this.buttonDivide.TabIndex = 5;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.buttonDivide_Click);
            // 
            // HW_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 315);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.labelAnswer);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.labelNum2);
            this.Controls.Add(this.textBoxNum2);
            this.Controls.Add(this.labelDivisionLine);
            this.Controls.Add(this.labelNum1);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.textBoxNum1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(557, 371);
            this.MinimumSize = new System.Drawing.Size(557, 371);
            this.Name = "HW_Calculator";
            this.Text = "HW_Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNum1;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Label labelNum1;
        private System.Windows.Forms.Label labelDivisionLine;
        private System.Windows.Forms.Label labelNum2;
        private System.Windows.Forms.TextBox textBoxNum2;
        private System.Windows.Forms.Label labelAnswer;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonDivide;
    }
}