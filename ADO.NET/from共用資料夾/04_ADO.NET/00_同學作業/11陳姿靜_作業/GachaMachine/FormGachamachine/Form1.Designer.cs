namespace FormGachamachine
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
            this.tb_dollar = new System.Windows.Forms.TextBox();
            this.But_Dollar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.but_RefundMoney = new System.Windows.Forms.Button();
            this.but_ship = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_dollar
            // 
            this.tb_dollar.Location = new System.Drawing.Point(93, 55);
            this.tb_dollar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_dollar.Name = "tb_dollar";
            this.tb_dollar.Size = new System.Drawing.Size(443, 25);
            this.tb_dollar.TabIndex = 0;
            // 
            // But_Dollar
            // 
            this.But_Dollar.Location = new System.Drawing.Point(593, 55);
            this.But_Dollar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.But_Dollar.Name = "But_Dollar";
            this.But_Dollar.Size = new System.Drawing.Size(153, 26);
            this.But_Dollar.TabIndex = 1;
            this.But_Dollar.Text = "投幣";
            this.But_Dollar.UseVisualStyleBackColor = true;
            this.But_Dollar.Click += new System.EventHandler(this.But_Dollar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 134);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(652, 296);
            this.textBox1.TabIndex = 0;
            // 
            // but_RefundMoney
            // 
            this.but_RefundMoney.Enabled = false;
            this.but_RefundMoney.Location = new System.Drawing.Point(384, 474);
            this.but_RefundMoney.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.but_RefundMoney.Name = "but_RefundMoney";
            this.but_RefundMoney.Size = new System.Drawing.Size(153, 26);
            this.but_RefundMoney.TabIndex = 1;
            this.but_RefundMoney.Text = "退幣";
            this.but_RefundMoney.UseVisualStyleBackColor = true;
            this.but_RefundMoney.Click += new System.EventHandler(this.But_RefundMoney_Click);
            // 
            // but_ship
            // 
            this.but_ship.Enabled = false;
            this.but_ship.Location = new System.Drawing.Point(593, 474);
            this.but_ship.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.but_ship.Name = "but_ship";
            this.but_ship.Size = new System.Drawing.Size(153, 26);
            this.but_ship.TabIndex = 1;
            this.but_ship.Text = "出貨";
            this.but_ship.UseVisualStyleBackColor = true;
            this.but_ship.Click += new System.EventHandler(this.But_Ship_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 547);
            this.Controls.Add(this.but_ship);
            this.Controls.Add(this.but_RefundMoney);
            this.Controls.Add(this.But_Dollar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tb_dollar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_dollar;
        private System.Windows.Forms.Button But_Dollar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button but_RefundMoney;
        private System.Windows.Forms.Button but_ship;
    }
}

