namespace iSpan.EStore.WinApp
{
    partial class FormEditCategory
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
            this.label_Name = new System.Windows.Forms.Label();
            this.label_DisplayOrder = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_DisplayOrder = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("新細明體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Name.Location = new System.Drawing.Point(34, 48);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(64, 20);
            this.label_Name.TabIndex = 2;
            this.label_Name.Text = "Name: ";
            // 
            // label_DisplayOrder
            // 
            this.label_DisplayOrder.AutoSize = true;
            this.label_DisplayOrder.Font = new System.Drawing.Font("新細明體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_DisplayOrder.Location = new System.Drawing.Point(34, 96);
            this.label_DisplayOrder.Name = "label_DisplayOrder";
            this.label_DisplayOrder.Size = new System.Drawing.Size(124, 20);
            this.label_DisplayOrder.TabIndex = 3;
            this.label_DisplayOrder.Text = "Display Order: ";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(156, 45);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(247, 29);
            this.textBox_Name.TabIndex = 0;
            // 
            // textBox_DisplayOrder
            // 
            this.textBox_DisplayOrder.Location = new System.Drawing.Point(156, 93);
            this.textBox_DisplayOrder.Name = "textBox_DisplayOrder";
            this.textBox_DisplayOrder.Size = new System.Drawing.Size(247, 29);
            this.textBox_DisplayOrder.TabIndex = 1;
            // 
            // FormEditCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_DisplayOrder);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label_DisplayOrder);
            this.Controls.Add(this.label_Name);
            this.Name = "FormEditCategory";
            this.Text = "FormEditCategory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_DisplayOrder;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_DisplayOrder;
    }
}