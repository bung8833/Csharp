namespace WA.Games.WinApp
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
			this.textBoxMoney = new System.Windows.Forms.TextBox();
			this.buttonPutMoney = new System.Windows.Forms.Button();
			this.buttonRefund = new System.Windows.Forms.Button();
			this.buttonShip = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBoxMoney
			// 
			this.textBoxMoney.Location = new System.Drawing.Point(35, 13);
			this.textBoxMoney.Name = "textBoxMoney";
			this.textBoxMoney.Size = new System.Drawing.Size(100, 22);
			this.textBoxMoney.TabIndex = 0;
			// 
			// buttonPutMoney
			// 
			this.buttonPutMoney.Location = new System.Drawing.Point(151, 11);
			this.buttonPutMoney.Name = "buttonPutMoney";
			this.buttonPutMoney.Size = new System.Drawing.Size(75, 23);
			this.buttonPutMoney.TabIndex = 1;
			this.buttonPutMoney.Text = "投幣";
			this.buttonPutMoney.UseVisualStyleBackColor = true;
			this.buttonPutMoney.Click += new System.EventHandler(this.buttonPutMoney_Click);
			// 
			// buttonRefund
			// 
			this.buttonRefund.Location = new System.Drawing.Point(281, 13);
			this.buttonRefund.Name = "buttonRefund";
			this.buttonRefund.Size = new System.Drawing.Size(75, 23);
			this.buttonRefund.TabIndex = 2;
			this.buttonRefund.Text = "退幣";
			this.buttonRefund.UseVisualStyleBackColor = true;
			this.buttonRefund.Click += new System.EventHandler(this.buttonRefund_Click);
			// 
			// buttonShip
			// 
			this.buttonShip.Location = new System.Drawing.Point(389, 13);
			this.buttonShip.Name = "buttonShip";
			this.buttonShip.Size = new System.Drawing.Size(75, 23);
			this.buttonShip.TabIndex = 3;
			this.buttonShip.Text = "出貨";
			this.buttonShip.UseVisualStyleBackColor = true;
			this.buttonShip.Click += new System.EventHandler(this.buttonShip_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonShip);
			this.Controls.Add(this.buttonRefund);
			this.Controls.Add(this.buttonPutMoney);
			this.Controls.Add(this.textBoxMoney);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxMoney;
		private System.Windows.Forms.Button buttonPutMoney;
		private System.Windows.Forms.Button buttonRefund;
		private System.Windows.Forms.Button buttonShip;
	}
}

