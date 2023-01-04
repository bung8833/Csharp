namespace iSpan.EStore.WinApp
{
    partial class FormCreateNews
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
            this.button_Save = new System.Windows.Forms.Button();
            this.label_Title = new System.Windows.Forms.Label();
            this.textBox_Title = new System.Windows.Forms.TextBox();
            this.label_Description = new System.Windows.Forms.Label();
            this.textBox_Description = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(503, 302);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 36);
            this.button_Save.TabIndex = 2;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Location = new System.Drawing.Point(29, 29);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(46, 18);
            this.label_Title.TabIndex = 3;
            this.label_Title.Text = "Title:";
            // 
            // textBox_Title
            // 
            this.textBox_Title.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_Title.Location = new System.Drawing.Point(126, 26);
            this.textBox_Title.Name = "textBox_Title";
            this.textBox_Title.Size = new System.Drawing.Size(452, 36);
            this.textBox_Title.TabIndex = 0;
            // 
            // label_Description
            // 
            this.label_Description.AutoSize = true;
            this.label_Description.Location = new System.Drawing.Point(29, 90);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(93, 18);
            this.label_Description.TabIndex = 4;
            this.label_Description.Text = "Description:";
            // 
            // textBox_Description
            // 
            this.textBox_Description.Font = new System.Drawing.Font("新細明體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_Description.Location = new System.Drawing.Point(126, 87);
            this.textBox_Description.Multiline = true;
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.Size = new System.Drawing.Size(452, 190);
            this.textBox_Description.TabIndex = 1;
            // 
            // FormCreateNews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 371);
            this.Controls.Add(this.textBox_Description);
            this.Controls.Add(this.textBox_Title);
            this.Controls.Add(this.label_Description);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.button_Save);
            this.Name = "FormCreateNews";
            this.Text = "FormCreateNews";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.TextBox textBox_Title;
        private System.Windows.Forms.Label label_Description;
        private System.Windows.Forms.TextBox textBox_Description;
    }
}