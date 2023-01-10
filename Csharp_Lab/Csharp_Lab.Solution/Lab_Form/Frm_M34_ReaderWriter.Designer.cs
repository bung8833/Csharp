namespace Lab_Form
{
    partial class Frm_M34_ReaderWriter
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
            this.txtBox_RW = new System.Windows.Forms.TextBox();
            this.btn_Reader = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBox_RW
            // 
            this.txtBox_RW.Location = new System.Drawing.Point(255, 12);
            this.txtBox_RW.Multiline = true;
            this.txtBox_RW.Name = "txtBox_RW";
            this.txtBox_RW.Size = new System.Drawing.Size(624, 477);
            this.txtBox_RW.TabIndex = 0;
            // 
            // btn_Reader
            // 
            this.btn_Reader.Font = new System.Drawing.Font("UD Digi Kyokasho N-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_Reader.Location = new System.Drawing.Point(12, 13);
            this.btn_Reader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Reader.Name = "btn_Reader";
            this.btn_Reader.Size = new System.Drawing.Size(146, 53);
            this.btn_Reader.TabIndex = 1;
            this.btn_Reader.Text = "Reader";
            this.btn_Reader.UseVisualStyleBackColor = true;
            this.btn_Reader.Click += new System.EventHandler(this.btn_Reader_Click);
            // 
            // Frm_M34_ReaderWriter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 501);
            this.Controls.Add(this.btn_Reader);
            this.Controls.Add(this.txtBox_RW);
            this.Name = "Frm_M34_ReaderWriter";
            this.Text = "Frm_M34_ReaderWriter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_RW;
        private System.Windows.Forms.Button btn_Reader;
    }
}