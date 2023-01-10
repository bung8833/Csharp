namespace MyHomework_張佑晨
{
	// Token: 0x02000005 RID: 5
	public partial class Myhomework_0704_LoanReport : global::System.Windows.Forms.Form
	{
		// Token: 0x06000018 RID: 24 RVA: 0x000046A8 File Offset: 0x000028A8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000046E0 File Offset: 0x000028E0
		private void InitializeComponent()
		{
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelloan = new System.Windows.Forms.Label();
            this.labeldeadline = new System.Windows.Forms.Label();
            this.labelrate = new System.Windows.Forms.Label();
            this.labelmonths = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.labeltotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(179, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 38);
            this.label4.TabIndex = 13;
            this.label4.Text = "月付款：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(179, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 38);
            this.label3.TabIndex = 12;
            this.label3.Text = "利率(%)：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 38);
            this.label2.TabIndex = 11;
            this.label2.Text = "期限(年)：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 38);
            this.label1.TabIndex = 10;
            this.label1.Text = "貸款金額：";
            // 
            // labelloan
            // 
            this.labelloan.AutoSize = true;
            this.labelloan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelloan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelloan.Location = new System.Drawing.Point(342, 74);
            this.labelloan.Name = "labelloan";
            this.labelloan.Size = new System.Drawing.Size(151, 40);
            this.labelloan.TabIndex = 14;
            this.labelloan.Text = "貸款金額";
            // 
            // labeldeadline
            // 
            this.labeldeadline.AutoSize = true;
            this.labeldeadline.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labeldeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labeldeadline.Location = new System.Drawing.Point(342, 143);
            this.labeldeadline.Name = "labeldeadline";
            this.labeldeadline.Size = new System.Drawing.Size(140, 40);
            this.labeldeadline.TabIndex = 15;
            this.labeldeadline.Text = "期限(年)";
            // 
            // labelrate
            // 
            this.labelrate.AutoSize = true;
            this.labelrate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelrate.Location = new System.Drawing.Point(342, 217);
            this.labelrate.Name = "labelrate";
            this.labelrate.Size = new System.Drawing.Size(136, 40);
            this.labelrate.TabIndex = 16;
            this.labelrate.Text = "利率(%)";
            // 
            // labelmonths
            // 
            this.labelmonths.AutoSize = true;
            this.labelmonths.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelmonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelmonths.Location = new System.Drawing.Point(342, 294);
            this.labelmonths.Name = "labelmonths";
            this.labelmonths.Size = new System.Drawing.Size(118, 40);
            this.labelmonths.TabIndex = 17;
            this.labelmonths.Text = "月付款";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(611, 413);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(186, 68);
            this.button3.TabIndex = 18;
            this.button3.Text = "Email";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // labeltotal
            // 
            this.labeltotal.AutoSize = true;
            this.labeltotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labeltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labeltotal.Location = new System.Drawing.Point(340, 370);
            this.labeltotal.Name = "labeltotal";
            this.labeltotal.Size = new System.Drawing.Size(118, 40);
            this.labeltotal.TabIndex = 20;
            this.labeltotal.Text = "總付款";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(177, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 38);
            this.label6.TabIndex = 19;
            this.label6.Text = "總付款：";
            // 
            // Myhomework_0704_LoanReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 540);
            this.Controls.Add(this.labeltotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.labelmonths);
            this.Controls.Add(this.labelrate);
            this.Controls.Add(this.labeldeadline);
            this.Controls.Add(this.labelloan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Myhomework_0704_LoanReport";
            this.Text = "Myhomework_0704_LoanReport";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x04000038 RID: 56
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000039 RID: 57
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400003A RID: 58
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400003B RID: 59
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400003C RID: 60
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400003D RID: 61
		internal global::System.Windows.Forms.Label labelloan;

		// Token: 0x0400003E RID: 62
		internal global::System.Windows.Forms.Label labeldeadline;

		// Token: 0x0400003F RID: 63
		internal global::System.Windows.Forms.Label labelrate;

		// Token: 0x04000040 RID: 64
		internal global::System.Windows.Forms.Label labelmonths;

		// Token: 0x04000041 RID: 65
		private global::System.Windows.Forms.Button button3;

		// Token: 0x04000042 RID: 66
		internal global::System.Windows.Forms.Label labeltotal;

		// Token: 0x04000043 RID: 67
		private global::System.Windows.Forms.Label label6;
	}
}
