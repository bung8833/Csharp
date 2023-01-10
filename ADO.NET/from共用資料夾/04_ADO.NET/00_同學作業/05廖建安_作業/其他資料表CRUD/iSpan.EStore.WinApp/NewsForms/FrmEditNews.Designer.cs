namespace iSpan.EStore.WinApp
{
    partial class FrmEditNews
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtModifiedTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDeleteNews = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "Title:";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(485, 296);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(95, 38);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "修改";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(74, 35);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(506, 257);
            this.txtDescription.TabIndex = 6;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(74, 10);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(506, 22);
            this.txtTitle.TabIndex = 5;
            // 
            // txtModifiedTime
            // 
            this.txtModifiedTime.AutoSize = true;
            this.txtModifiedTime.Location = new System.Drawing.Point(91, 310);
            this.txtModifiedTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtModifiedTime.Name = "txtModifiedTime";
            this.txtModifiedTime.Size = new System.Drawing.Size(33, 12);
            this.txtModifiedTime.TabIndex = 10;
            this.txtModifiedTime.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 310);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "Modified Time:";
            // 
            // btnDeleteNews
            // 
            this.btnDeleteNews.Location = new System.Drawing.Point(386, 296);
            this.btnDeleteNews.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteNews.Name = "btnDeleteNews";
            this.btnDeleteNews.Size = new System.Drawing.Size(95, 38);
            this.btnDeleteNews.TabIndex = 12;
            this.btnDeleteNews.Text = "刪除";
            this.btnDeleteNews.UseVisualStyleBackColor = true;
            this.btnDeleteNews.Click += new System.EventHandler(this.btnDeleteNews_Click);
            // 
            // FrmEditNews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 347);
            this.Controls.Add(this.btnDeleteNews);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtModifiedTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTitle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmEditNews";
            this.Text = "FrmEditNews";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label txtModifiedTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDeleteNews;
    }
}