namespace ISpan.Games.WinApp
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
            this.historyTextBox = new System.Windows.Forms.TextBox();
            this.ycdGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // historyTextBox
            // 
            this.historyTextBox.Location = new System.Drawing.Point(25, 23);
            this.historyTextBox.Multiline = true;
            this.historyTextBox.Name = "historyTextBox";
            this.historyTextBox.Size = new System.Drawing.Size(361, 287);
            this.historyTextBox.TabIndex = 0;
            // 
            // ycdGameButton
            // 
            this.ycdGameButton.Location = new System.Drawing.Point(290, 325);
            this.ycdGameButton.Name = "ycdGameButton";
            this.ycdGameButton.Size = new System.Drawing.Size(96, 23);
            this.ycdGameButton.TabIndex = 1;
            this.ycdGameButton.Text = "Ycd Game";
            this.ycdGameButton.UseVisualStyleBackColor = true;
            this.ycdGameButton.Click += new System.EventHandler(this.ycdGameButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 363);
            this.Controls.Add(this.ycdGameButton);
            this.Controls.Add(this.historyTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox historyTextBox;
        private System.Windows.Forms.Button ycdGameButton;
    }
}

