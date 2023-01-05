namespace iSpan.EStore.WinApp
{
    partial class FormEditNews
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
            this.textBox_Description = new System.Windows.Forms.TextBox();
            this.textBox_Title = new System.Windows.Forms.TextBox();
            this.label_Description = new System.Windows.Forms.Label();
            this.label_Title = new System.Windows.Forms.Label();
            this.button_Update = new System.Windows.Forms.Button();
            this.label_InstructionModifiedTime = new System.Windows.Forms.Label();
            this.label_ModifiedTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Description
            // 
            this.textBox_Description.Font = new System.Drawing.Font("新細明體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_Description.Location = new System.Drawing.Point(126, 86);
            this.textBox_Description.Multiline = true;
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.Size = new System.Drawing.Size(452, 190);
            this.textBox_Description.TabIndex = 6;
            // 
            // textBox_Title
            // 
            this.textBox_Title.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_Title.Location = new System.Drawing.Point(126, 25);
            this.textBox_Title.Name = "textBox_Title";
            this.textBox_Title.Size = new System.Drawing.Size(452, 36);
            this.textBox_Title.TabIndex = 5;
            // 
            // label_Description
            // 
            this.label_Description.AutoSize = true;
            this.label_Description.Location = new System.Drawing.Point(29, 89);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(93, 18);
            this.label_Description.TabIndex = 9;
            this.label_Description.Text = "Description:";
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Location = new System.Drawing.Point(29, 28);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(46, 18);
            this.label_Title.TabIndex = 8;
            this.label_Title.Text = "Title:";
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(503, 301);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(75, 36);
            this.button_Update.TabIndex = 7;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // label_InstructionModifiedTime
            // 
            this.label_InstructionModifiedTime.AutoSize = true;
            this.label_InstructionModifiedTime.Location = new System.Drawing.Point(12, 310);
            this.label_InstructionModifiedTime.Name = "label_InstructionModifiedTime";
            this.label_InstructionModifiedTime.Size = new System.Drawing.Size(85, 18);
            this.label_InstructionModifiedTime.TabIndex = 10;
            this.label_InstructionModifiedTime.Text = "異動時間:";
            // 
            // label_ModifiedTime
            // 
            this.label_ModifiedTime.AutoSize = true;
            this.label_ModifiedTime.Location = new System.Drawing.Point(103, 310);
            this.label_ModifiedTime.Name = "label_ModifiedTime";
            this.label_ModifiedTime.Size = new System.Drawing.Size(105, 18);
            this.label_ModifiedTime.TabIndex = 11;
            this.label_ModifiedTime.Text = "modifiedTime";
            // 
            // FormEditNews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 360);
            this.Controls.Add(this.label_ModifiedTime);
            this.Controls.Add(this.label_InstructionModifiedTime);
            this.Controls.Add(this.textBox_Description);
            this.Controls.Add(this.textBox_Title);
            this.Controls.Add(this.label_Description);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.button_Update);
            this.Name = "FormEditNews";
            this.Text = "FormEditNews";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Description;
        private System.Windows.Forms.TextBox textBox_Title;
        private System.Windows.Forms.Label label_Description;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Label label_InstructionModifiedTime;
        private System.Windows.Forms.Label label_ModifiedTime;
    }
}