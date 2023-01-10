namespace AllenHw_GachaMachine_WinApp
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
            this.buttonAddMoney = new System.Windows.Forms.Button();
            this.buttonRefundMoney = new System.Windows.Forms.Button();
            this.buttonToShip = new System.Windows.Forms.Button();
            this.textBoxInsertMoney = new System.Windows.Forms.TextBox();
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAddMoney
            // 
            this.buttonAddMoney.Location = new System.Drawing.Point(462, 64);
            this.buttonAddMoney.Name = "buttonAddMoney";
            this.buttonAddMoney.Size = new System.Drawing.Size(161, 58);
            this.buttonAddMoney.TabIndex = 0;
            this.buttonAddMoney.Text = "投幣";
            this.buttonAddMoney.UseVisualStyleBackColor = true;
            this.buttonAddMoney.Click += new System.EventHandler(this.buttonAddMoney_Click);
            // 
            // buttonRefundMoney
            // 
            this.buttonRefundMoney.Location = new System.Drawing.Point(295, 314);
            this.buttonRefundMoney.Name = "buttonRefundMoney";
            this.buttonRefundMoney.Size = new System.Drawing.Size(161, 58);
            this.buttonRefundMoney.TabIndex = 1;
            this.buttonRefundMoney.Text = "退幣";
            this.buttonRefundMoney.UseVisualStyleBackColor = true;
            this.buttonRefundMoney.Click += new System.EventHandler(this.buttonRefundMoney_Click);
            // 
            // buttonToShip
            // 
            this.buttonToShip.Location = new System.Drawing.Point(462, 314);
            this.buttonToShip.Name = "buttonToShip";
            this.buttonToShip.Size = new System.Drawing.Size(161, 58);
            this.buttonToShip.TabIndex = 2;
            this.buttonToShip.Text = "出貨";
            this.buttonToShip.UseVisualStyleBackColor = true;
            this.buttonToShip.Click += new System.EventHandler(this.buttonToShip_Click);
            // 
            // textBoxInsertMoney
            // 
            this.textBoxInsertMoney.Location = new System.Drawing.Point(119, 64);
            this.textBoxInsertMoney.Multiline = true;
            this.textBoxInsertMoney.Name = "textBoxInsertMoney";
            this.textBoxInsertMoney.Size = new System.Drawing.Size(337, 58);
            this.textBoxInsertMoney.TabIndex = 3;
            // 
            // textBoxState
            // 
            this.textBoxState.Location = new System.Drawing.Point(119, 142);
            this.textBoxState.Multiline = true;
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.Size = new System.Drawing.Size(504, 165);
            this.textBoxState.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 450);
            this.Controls.Add(this.textBoxState);
            this.Controls.Add(this.textBoxInsertMoney);
            this.Controls.Add(this.buttonToShip);
            this.Controls.Add(this.buttonRefundMoney);
            this.Controls.Add(this.buttonAddMoney);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddMoney;
        private System.Windows.Forms.Button buttonRefundMoney;
        private System.Windows.Forms.Button buttonToShip;
        private System.Windows.Forms.TextBox textBoxInsertMoney;
        private System.Windows.Forms.TextBox textBoxState;
    }
}

