namespace Lab_Form
{
    partial class Frm_M17_enum
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
            this.btn_Verify = new System.Windows.Forms.Button();
            this.btn_Product = new System.Windows.Forms.Button();
            this.btn_enum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Verify
            // 
            this.btn_Verify.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Verify.Location = new System.Drawing.Point(12, 12);
            this.btn_Verify.Name = "btn_Verify";
            this.btn_Verify.Size = new System.Drawing.Size(162, 61);
            this.btn_Verify.TabIndex = 0;
            this.btn_Verify.Text = "驗證";
            this.btn_Verify.UseVisualStyleBackColor = true;
            this.btn_Verify.Click += new System.EventHandler(this.btn_Verify_Click);
            // 
            // btn_Product
            // 
            this.btn_Product.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_Product.Enabled = false;
            this.btn_Product.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Product.Location = new System.Drawing.Point(225, 12);
            this.btn_Product.Name = "btn_Product";
            this.btn_Product.Size = new System.Drawing.Size(162, 61);
            this.btn_Product.TabIndex = 1;
            this.btn_Product.Text = "Product";
            this.btn_Product.UseVisualStyleBackColor = false;
            this.btn_Product.Click += new System.EventHandler(this.btn_Product_Click);
            // 
            // btn_enum
            // 
            this.btn_enum.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_enum.Location = new System.Drawing.Point(12, 148);
            this.btn_enum.Name = "btn_enum";
            this.btn_enum.Size = new System.Drawing.Size(162, 61);
            this.btn_enum.TabIndex = 2;
            this.btn_enum.Text = "列舉";
            this.btn_enum.UseVisualStyleBackColor = true;
            this.btn_enum.Click += new System.EventHandler(this.btn_enum_Click);
            // 
            // Frm_M17_enum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_enum);
            this.Controls.Add(this.btn_Product);
            this.Controls.Add(this.btn_Verify);
            this.Name = "Frm_M17_enum";
            this.Text = "Frm_M17_enum";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Verify;
        private System.Windows.Forms.Button btn_Product;
        private System.Windows.Forms.Button btn_enum;
    }
}