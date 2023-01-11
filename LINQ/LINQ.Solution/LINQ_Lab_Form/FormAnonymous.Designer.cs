namespace LINQ_Lab_Form
{
    partial class FormAnonymous
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonPayment = new System.Windows.Forms.Button();
            this.labelLambda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "20% off",
            "50% off"});
            this.comboBox1.Location = new System.Drawing.Point(68, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 26);
            this.comboBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 29);
            this.textBox1.TabIndex = 1;
            // 
            // buttonPayment
            // 
            this.buttonPayment.Location = new System.Drawing.Point(68, 153);
            this.buttonPayment.Name = "buttonPayment";
            this.buttonPayment.Size = new System.Drawing.Size(121, 40);
            this.buttonPayment.TabIndex = 2;
            this.buttonPayment.Text = "Payment";
            this.buttonPayment.UseVisualStyleBackColor = true;
            this.buttonPayment.Click += new System.EventHandler(this.buttonPayment_Click);
            // 
            // labelLambda
            // 
            this.labelLambda.AutoSize = true;
            this.labelLambda.Font = new System.Drawing.Font("微軟正黑體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelLambda.Location = new System.Drawing.Point(372, 321);
            this.labelLambda.Name = "labelLambda";
            this.labelLambda.Size = new System.Drawing.Size(416, 120);
            this.labelLambda.TabIndex = 3;
            this.labelLambda.Text = "Lambda";
            // 
            // FormAnonymous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelLambda);
            this.Controls.Add(this.buttonPayment);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Name = "FormAnonymous";
            this.Text = "FormAnonymous";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonPayment;
        private System.Windows.Forms.Label labelLambda;
    }
}