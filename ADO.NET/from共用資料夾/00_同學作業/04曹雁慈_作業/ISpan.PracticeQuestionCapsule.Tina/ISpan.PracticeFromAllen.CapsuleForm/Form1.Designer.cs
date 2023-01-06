namespace ISpan.PracticeFromAllan.CapsuleForm
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
			this.textBoxCoin = new System.Windows.Forms.TextBox();
			this.textBoxMessage = new System.Windows.Forms.TextBox();
			this.buttonCoin = new System.Windows.Forms.Button();
			this.buttonRefund = new System.Windows.Forms.Button();
			this.buttonShip = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBoxCoin
			// 
			this.textBoxCoin.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBoxCoin.Location = new System.Drawing.Point(51, 61);
			this.textBoxCoin.Name = "textBoxCoin";
			this.textBoxCoin.Size = new System.Drawing.Size(361, 29);
			this.textBoxCoin.TabIndex = 0;
			// 
			// textBoxMessage
			// 
			this.textBoxMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxMessage.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBoxMessage.Location = new System.Drawing.Point(51, 115);
			this.textBoxMessage.Multiline = true;
			this.textBoxMessage.Name = "textBoxMessage";
			this.textBoxMessage.Size = new System.Drawing.Size(495, 204);
			this.textBoxMessage.TabIndex = 1;
			// 
			// buttonCoin
			// 
			this.buttonCoin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCoin.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonCoin.Location = new System.Drawing.Point(430, 61);
			this.buttonCoin.Name = "buttonCoin";
			this.buttonCoin.Size = new System.Drawing.Size(116, 30);
			this.buttonCoin.TabIndex = 2;
			this.buttonCoin.Text = "投幣";
			this.buttonCoin.UseVisualStyleBackColor = true;
			this.buttonCoin.Click += new System.EventHandler(this.buttonCoin_Click);
			// 
			// buttonRefund
			// 
			this.buttonRefund.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonRefund.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonRefund.Location = new System.Drawing.Point(296, 350);
			this.buttonRefund.Name = "buttonRefund";
			this.buttonRefund.Size = new System.Drawing.Size(116, 30);
			this.buttonRefund.TabIndex = 3;
			this.buttonRefund.Text = "退幣";
			this.buttonRefund.UseVisualStyleBackColor = true;
			this.buttonRefund.Click += new System.EventHandler(this.buttonRefund_Click);
			// 
			// buttonShip
			// 
			this.buttonShip.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonShip.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonShip.Location = new System.Drawing.Point(430, 350);
			this.buttonShip.Name = "buttonShip";
			this.buttonShip.Size = new System.Drawing.Size(116, 30);
			this.buttonShip.TabIndex = 4;
			this.buttonShip.Text = "出貨";
			this.buttonShip.UseVisualStyleBackColor = true;
			this.buttonShip.Click += new System.EventHandler(this.buttonShip_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(596, 432);
			this.Controls.Add(this.buttonShip);
			this.Controls.Add(this.buttonRefund);
			this.Controls.Add(this.buttonCoin);
			this.Controls.Add(this.textBoxMessage);
			this.Controls.Add(this.textBoxCoin);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxCoin;
		private System.Windows.Forms.TextBox textBoxMessage;
		private System.Windows.Forms.Button buttonCoin;
		private System.Windows.Forms.Button buttonRefund;
		private System.Windows.Forms.Button buttonShip;
	}
}

