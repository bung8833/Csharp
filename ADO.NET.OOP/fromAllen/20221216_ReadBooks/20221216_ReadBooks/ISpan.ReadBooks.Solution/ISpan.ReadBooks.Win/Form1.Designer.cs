using System.IO;
using System.Windows.Forms;
using System;

namespace ISpan.ReadBooks.Win
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.libraryListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.contentTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pageIndexTextBox = new System.Windows.Forms.TextBox();
            this.pageLengthTextBox = new System.Windows.Forms.TextBox();
            this.checkinButton = new System.Windows.Forms.Button();
            this.displayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // libraryListBox
            // 
            this.libraryListBox.FormattingEnabled = true;
            this.libraryListBox.ItemHeight = 12;
            this.libraryListBox.Location = new System.Drawing.Point(33, 40);
            this.libraryListBox.Name = "libraryListBox";
            this.libraryListBox.Size = new System.Drawing.Size(162, 268);
            this.libraryListBox.TabIndex = 0;
            this.libraryListBox.SelectedIndexChanged += new System.EventHandler(this.libraryListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Library";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(217, 13);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(48, 12);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "titleLabel";
            // 
            // contentTextBox
            // 
            this.contentTextBox.Location = new System.Drawing.Point(219, 40);
            this.contentTextBox.Multiline = true;
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.contentTextBox.Size = new System.Drawing.Size(395, 268);
            this.contentTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "page index:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "Length:";
            // 
            // pageIndexTextBox
            // 
            this.pageIndexTextBox.Location = new System.Drawing.Point(289, 316);
            this.pageIndexTextBox.Name = "pageIndexTextBox";
            this.pageIndexTextBox.Size = new System.Drawing.Size(75, 22);
            this.pageIndexTextBox.TabIndex = 3;
            this.pageIndexTextBox.Text = "0";
            this.pageIndexTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pageLengthTextBox
            // 
            this.pageLengthTextBox.Location = new System.Drawing.Point(431, 316);
            this.pageLengthTextBox.Name = "pageLengthTextBox";
            this.pageLengthTextBox.Size = new System.Drawing.Size(75, 22);
            this.pageLengthTextBox.TabIndex = 4;
            this.pageLengthTextBox.Text = "1";
            this.pageLengthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // checkinButton
            // 
            this.checkinButton.Location = new System.Drawing.Point(65, 314);
            this.checkinButton.Name = "checkinButton";
            this.checkinButton.Size = new System.Drawing.Size(130, 23);
            this.checkinButton.TabIndex = 1;
            this.checkinButton.Text = "Checkin Book...";
            this.checkinButton.UseVisualStyleBackColor = true;
            this.checkinButton.Click += new System.EventHandler(this.checkinButton_Click);
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(539, 314);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(75, 23);
            this.displayButton.TabIndex = 5;
            this.displayButton.Text = "Display";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.displayButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 364);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.checkinButton);
            this.Controls.Add(this.pageLengthTextBox);
            this.Controls.Add(this.pageIndexTextBox);
            this.Controls.Add(this.contentTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.libraryListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReadBooks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox libraryListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox contentTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pageIndexTextBox;
        private System.Windows.Forms.TextBox pageLengthTextBox;
        private System.Windows.Forms.Button checkinButton;
        private System.Windows.Forms.Button displayButton;
    }
}

