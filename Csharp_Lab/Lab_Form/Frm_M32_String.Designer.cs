namespace Lab_Form
{
    partial class Frm_M32_String
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
            this.btn_String = new System.Windows.Forms.Button();
            this.btn_StrBuilder = new System.Windows.Forms.Button();
            this.btn_addr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_String
            // 
            this.btn_String.Font = new System.Drawing.Font("UD Digi Kyokasho N-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_String.Location = new System.Drawing.Point(33, 34);
            this.btn_String.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_String.Name = "btn_String";
            this.btn_String.Size = new System.Drawing.Size(146, 53);
            this.btn_String.TabIndex = 1;
            this.btn_String.Text = "String";
            this.btn_String.UseVisualStyleBackColor = true;
            this.btn_String.Click += new System.EventHandler(this.btn_String_Click);
            // 
            // btn_StrBuilder
            // 
            this.btn_StrBuilder.Font = new System.Drawing.Font("UD Digi Kyokasho N-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_StrBuilder.Location = new System.Drawing.Point(33, 126);
            this.btn_StrBuilder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_StrBuilder.Name = "btn_StrBuilder";
            this.btn_StrBuilder.Size = new System.Drawing.Size(198, 53);
            this.btn_StrBuilder.TabIndex = 2;
            this.btn_StrBuilder.Text = "String Builder";
            this.btn_StrBuilder.UseVisualStyleBackColor = true;
            this.btn_StrBuilder.Click += new System.EventHandler(this.btn_StrBuilder_Click);
            // 
            // btn_addr
            // 
            this.btn_addr.Font = new System.Drawing.Font("UD Digi Kyokasho N-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_addr.Location = new System.Drawing.Point(33, 227);
            this.btn_addr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_addr.Name = "btn_addr";
            this.btn_addr.Size = new System.Drawing.Size(146, 53);
            this.btn_addr.TabIndex = 3;
            this.btn_addr.Text = "路徑";
            this.btn_addr.UseVisualStyleBackColor = true;
            this.btn_addr.Click += new System.EventHandler(this.btn_addr_Click);
            // 
            // Frm_M32_String
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_addr);
            this.Controls.Add(this.btn_StrBuilder);
            this.Controls.Add(this.btn_String);
            this.Name = "Frm_M32_String";
            this.Text = "Frm_M32_String";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_String;
        private System.Windows.Forms.Button btn_StrBuilder;
        private System.Windows.Forms.Button btn_addr;
    }
}