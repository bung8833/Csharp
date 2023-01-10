namespace VendingMachine.WinApp
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
            this.textBoxCoinInput = new System.Windows.Forms.TextBox();
            this.buttonCoinInput = new System.Windows.Forms.Button();
            this.textBoxInstruction = new System.Windows.Forms.TextBox();
            this.buttonRefund = new System.Windows.Forms.Button();
            this.buttonVend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxCoinInput
            // 
            this.textBoxCoinInput.Location = new System.Drawing.Point(55, 40);
            this.textBoxCoinInput.Name = "textBoxCoinInput";
            this.textBoxCoinInput.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxCoinInput.Size = new System.Drawing.Size(406, 29);
            this.textBoxCoinInput.TabIndex = 0;
            // 
            // buttonCoinInput
            // 
            this.buttonCoinInput.Location = new System.Drawing.Point(481, 40);
            this.buttonCoinInput.Name = "buttonCoinInput";
            this.buttonCoinInput.Size = new System.Drawing.Size(75, 29);
            this.buttonCoinInput.TabIndex = 1;
            this.buttonCoinInput.Text = "投幣";
            this.buttonCoinInput.UseVisualStyleBackColor = true;
            this.buttonCoinInput.Click += new System.EventHandler(this.buttonCoinInput_Click);
            // 
            // textBoxInstruction
            // 
            this.textBoxInstruction.Location = new System.Drawing.Point(55, 102);
            this.textBoxInstruction.Multiline = true;
            this.textBoxInstruction.Name = "textBoxInstruction";
            this.textBoxInstruction.Size = new System.Drawing.Size(501, 145);
            this.textBoxInstruction.TabIndex = 2;
            this.textBoxInstruction.Text = "State: \r\nMoney: ";
            // 
            // buttonRefund
            // 
            this.buttonRefund.Location = new System.Drawing.Point(373, 268);
            this.buttonRefund.Name = "buttonRefund";
            this.buttonRefund.Size = new System.Drawing.Size(75, 29);
            this.buttonRefund.TabIndex = 3;
            this.buttonRefund.Text = "退幣";
            this.buttonRefund.UseVisualStyleBackColor = true;
            this.buttonRefund.Click += new System.EventHandler(this.buttonRefund_Click);
            // 
            // buttonVend
            // 
            this.buttonVend.Location = new System.Drawing.Point(481, 268);
            this.buttonVend.Name = "buttonVend";
            this.buttonVend.Size = new System.Drawing.Size(75, 29);
            this.buttonVend.TabIndex = 4;
            this.buttonVend.Text = "出貨";
            this.buttonVend.UseVisualStyleBackColor = true;
            this.buttonVend.Click += new System.EventHandler(this.buttonVend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 346);
            this.Controls.Add(this.buttonVend);
            this.Controls.Add(this.buttonRefund);
            this.Controls.Add(this.textBoxInstruction);
            this.Controls.Add(this.buttonCoinInput);
            this.Controls.Add(this.textBoxCoinInput);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(647, 402);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCoinInput;
        private System.Windows.Forms.Button buttonCoinInput;
        private System.Windows.Forms.TextBox textBoxInstruction;
        private System.Windows.Forms.Button buttonRefund;
        private System.Windows.Forms.Button buttonVend;
    }
}

