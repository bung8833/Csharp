namespace Lab_Form
{
    partial class Frm_M21
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
            this.btn_Reverse = new System.Windows.Forms.Button();
            this.btn_Case = new System.Windows.Forms.Button();
            this.btn_foreach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Reverse
            // 
            this.btn_Reverse.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Reverse.Location = new System.Drawing.Point(30, 28);
            this.btn_Reverse.Name = "btn_Reverse";
            this.btn_Reverse.Size = new System.Drawing.Size(166, 86);
            this.btn_Reverse.TabIndex = 0;
            this.btn_Reverse.Text = "Click!";
            this.btn_Reverse.UseVisualStyleBackColor = true;
            this.btn_Reverse.Click += new System.EventHandler(this.btn_Reverse_Click);
            // 
            // btn_Case
            // 
            this.btn_Case.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Case.Location = new System.Drawing.Point(239, 28);
            this.btn_Case.Name = "btn_Case";
            this.btn_Case.Size = new System.Drawing.Size(166, 86);
            this.btn_Case.TabIndex = 1;
            this.btn_Case.Text = "Case";
            this.btn_Case.UseVisualStyleBackColor = true;
            this.btn_Case.Click += new System.EventHandler(this.btn_Case_Click);
            // 
            // btn_foreach
            // 
            this.btn_foreach.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_foreach.Location = new System.Drawing.Point(485, 28);
            this.btn_foreach.Name = "btn_foreach";
            this.btn_foreach.Size = new System.Drawing.Size(166, 86);
            this.btn_foreach.TabIndex = 2;
            this.btn_foreach.Text = "Foreach";
            this.btn_foreach.UseVisualStyleBackColor = true;
            this.btn_foreach.Click += new System.EventHandler(this.btn_foreach_Click);
            // 
            // Frm_M21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_foreach);
            this.Controls.Add(this.btn_Case);
            this.Controls.Add(this.btn_Reverse);
            this.Name = "Frm_M21";
            this.Text = "Frm_M21";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Reverse;
        private System.Windows.Forms.Button btn_Case;
        private System.Windows.Forms.Button btn_foreach;
    }
}