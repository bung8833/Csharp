
namespace Gacha.WinApp
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
            this.txtInsertCoin = new System.Windows.Forms.TextBox();
            this.txtStatement = new System.Windows.Forms.TextBox();
            this.btnRefund = new System.Windows.Forms.Button();
            this.btnInsertCoin = new System.Windows.Forms.Button();
            this.btnShip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInsertCoin
            // 
            this.txtInsertCoin.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtInsertCoin.Location = new System.Drawing.Point(12, 25);
            this.txtInsertCoin.Name = "txtInsertCoin";
            this.txtInsertCoin.Size = new System.Drawing.Size(404, 27);
            this.txtInsertCoin.TabIndex = 0;
            // 
            // txtStatement
            // 
            this.txtStatement.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtStatement.Location = new System.Drawing.Point(12, 69);
            this.txtStatement.Multiline = true;
            this.txtStatement.Name = "txtStatement";
            this.txtStatement.ReadOnly = true;
            this.txtStatement.Size = new System.Drawing.Size(527, 255);
            this.txtStatement.TabIndex = 1;
            // 
            // btnRefund
            // 
            this.btnRefund.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRefund.Location = new System.Drawing.Point(299, 330);
            this.btnRefund.Name = "btnRefund";
            this.btnRefund.Size = new System.Drawing.Size(117, 54);
            this.btnRefund.TabIndex = 2;
            this.btnRefund.Text = "退幣";
            this.btnRefund.UseVisualStyleBackColor = true;
            this.btnRefund.Click += new System.EventHandler(this.btnRefund_Click);
            // 
            // btnInsertCoin
            // 
            this.btnInsertCoin.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInsertCoin.Location = new System.Drawing.Point(422, 9);
            this.btnInsertCoin.Name = "btnInsertCoin";
            this.btnInsertCoin.Size = new System.Drawing.Size(117, 54);
            this.btnInsertCoin.TabIndex = 3;
            this.btnInsertCoin.Text = "投幣";
            this.btnInsertCoin.UseVisualStyleBackColor = true;
            this.btnInsertCoin.Click += new System.EventHandler(this.btnInsertCoin_Click);
            // 
            // btnShip
            // 
            this.btnShip.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShip.Location = new System.Drawing.Point(422, 330);
            this.btnShip.Name = "btnShip";
            this.btnShip.Size = new System.Drawing.Size(117, 54);
            this.btnShip.TabIndex = 4;
            this.btnShip.Text = "出貨";
            this.btnShip.UseVisualStyleBackColor = true;
            this.btnShip.Click += new System.EventHandler(this.btnShip_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 394);
            this.Controls.Add(this.btnShip);
            this.Controls.Add(this.btnInsertCoin);
            this.Controls.Add(this.btnRefund);
            this.Controls.Add(this.txtStatement);
            this.Controls.Add(this.txtInsertCoin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInsertCoin;
        private System.Windows.Forms.TextBox txtStatement;
        private System.Windows.Forms.Button btnRefund;
        private System.Windows.Forms.Button btnInsertCoin;
        private System.Windows.Forms.Button btnShip;
    }
}

