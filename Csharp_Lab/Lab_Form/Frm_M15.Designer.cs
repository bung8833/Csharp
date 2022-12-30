namespace Lab_Form
{
    partial class Frm_M15
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
            this.btn_ValueType = new System.Windows.Forms.Button();
            this.btn_ReferenceType = new System.Windows.Forms.Button();
            this.txtBox_ReferenceType = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_ValueType
            // 
            this.btn_ValueType.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ValueType.Location = new System.Drawing.Point(12, 12);
            this.btn_ValueType.Name = "btn_ValueType";
            this.btn_ValueType.Size = new System.Drawing.Size(180, 88);
            this.btn_ValueType.TabIndex = 0;
            this.btn_ValueType.Text = "Value Type";
            this.btn_ValueType.UseVisualStyleBackColor = true;
            this.btn_ValueType.Click += new System.EventHandler(this.btn_ValueType_Click);
            // 
            // btn_ReferenceType
            // 
            this.btn_ReferenceType.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ReferenceType.Location = new System.Drawing.Point(12, 106);
            this.btn_ReferenceType.Name = "btn_ReferenceType";
            this.btn_ReferenceType.Size = new System.Drawing.Size(180, 88);
            this.btn_ReferenceType.TabIndex = 1;
            this.btn_ReferenceType.Text = "Reference Type";
            this.btn_ReferenceType.UseVisualStyleBackColor = true;
            this.btn_ReferenceType.Click += new System.EventHandler(this.btn_ReferenceType_Click);
            // 
            // txtBox_ReferenceType
            // 
            this.txtBox_ReferenceType.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_ReferenceType.Location = new System.Drawing.Point(12, 213);
            this.txtBox_ReferenceType.Name = "txtBox_ReferenceType";
            this.txtBox_ReferenceType.Size = new System.Drawing.Size(180, 25);
            this.txtBox_ReferenceType.TabIndex = 2;
            this.txtBox_ReferenceType.Text = "txtBox_ReferenceType";
            // 
            // Frm_M15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBox_ReferenceType);
            this.Controls.Add(this.btn_ReferenceType);
            this.Controls.Add(this.btn_ValueType);
            this.Name = "Frm_M15";
            this.Text = "Frm_M15";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ValueType;
        private System.Windows.Forms.Button btn_ReferenceType;
        private System.Windows.Forms.TextBox txtBox_ReferenceType;
    }
}