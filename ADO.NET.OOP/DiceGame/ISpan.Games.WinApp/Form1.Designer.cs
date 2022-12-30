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
            this.btn_YcdGame = new System.Windows.Forms.Button();
            this.txtBox_history = new System.Windows.Forms.TextBox();
            this.btn_YcdNtimes = new System.Windows.Forms.Button();
            this.lbl_AveragePoint = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_YcdGame
            // 
            this.btn_YcdGame.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_YcdGame.Location = new System.Drawing.Point(445, 480);
            this.btn_YcdGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_YcdGame.Name = "btn_YcdGame";
            this.btn_YcdGame.Size = new System.Drawing.Size(143, 34);
            this.btn_YcdGame.TabIndex = 0;
            this.btn_YcdGame.Text = "Ycd Game";
            this.btn_YcdGame.UseVisualStyleBackColor = true;
            this.btn_YcdGame.Click += new System.EventHandler(this.btn_YcdGame_Click);
            // 
            // txtBox_history
            // 
            this.txtBox_history.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBox_history.Location = new System.Drawing.Point(11, 10);
            this.txtBox_history.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBox_history.Multiline = true;
            this.txtBox_history.Name = "txtBox_history";
            this.txtBox_history.Size = new System.Drawing.Size(577, 454);
            this.txtBox_history.TabIndex = 1;
            // 
            // btn_YcdNtimes
            // 
            this.btn_YcdNtimes.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_YcdNtimes.Location = new System.Drawing.Point(11, 480);
            this.btn_YcdNtimes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_YcdNtimes.Name = "btn_YcdNtimes";
            this.btn_YcdNtimes.Size = new System.Drawing.Size(148, 34);
            this.btn_YcdNtimes.TabIndex = 2;
            this.btn_YcdNtimes.Text = "N Games";
            this.btn_YcdNtimes.UseVisualStyleBackColor = true;
            this.btn_YcdNtimes.Click += new System.EventHandler(this.btn_YcdNtimes_Click);
            // 
            // lbl_AveragePoint
            // 
            this.lbl_AveragePoint.AutoSize = true;
            this.lbl_AveragePoint.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_AveragePoint.Location = new System.Drawing.Point(165, 486);
            this.lbl_AveragePoint.Name = "lbl_AveragePoint";
            this.lbl_AveragePoint.Size = new System.Drawing.Size(136, 22);
            this.lbl_AveragePoint.TabIndex = 3;
            this.lbl_AveragePoint.Text = "Average point: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 532);
            this.Controls.Add(this.lbl_AveragePoint);
            this.Controls.Add(this.btn_YcdNtimes);
            this.Controls.Add(this.txtBox_history);
            this.Controls.Add(this.btn_YcdGame);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_YcdGame;
        private System.Windows.Forms.TextBox txtBox_history;
        private System.Windows.Forms.Button btn_YcdNtimes;
        private System.Windows.Forms.Label lbl_AveragePoint;
    }
}

