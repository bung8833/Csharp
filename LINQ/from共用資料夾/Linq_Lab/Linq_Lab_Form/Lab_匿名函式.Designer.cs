namespace Linq_Lab_Form
{
	partial class Lab_匿名函式
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.txtAmount = new System.Windows.Forms.TextBox();
			this.cmbDiscount = new System.Windows.Forms.ComboBox();
			this.button2 = new System.Windows.Forms.Button();
			this.txtButtonsNumber = new System.Windows.Forms.TextBox();
			this.flpButtons = new System.Windows.Forms.FlowLayoutPanel();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(40, 108);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(128, 52);
			this.button1.TabIndex = 0;
			this.button1.Text = "匿名方法";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// txtAmount
			// 
			this.txtAmount.Location = new System.Drawing.Point(40, 66);
			this.txtAmount.Name = "txtAmount";
			this.txtAmount.Size = new System.Drawing.Size(121, 22);
			this.txtAmount.TabIndex = 7;
			// 
			// cmbDiscount
			// 
			this.cmbDiscount.FormattingEnabled = true;
			this.cmbDiscount.Items.AddRange(new object[] {
            "50%off",
            "20%off"});
			this.cmbDiscount.Location = new System.Drawing.Point(40, 25);
			this.cmbDiscount.Name = "cmbDiscount";
			this.cmbDiscount.Size = new System.Drawing.Size(122, 20);
			this.cmbDiscount.TabIndex = 6;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(38, 263);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(123, 43);
			this.button2.TabIndex = 8;
			this.button2.Text = "Show All Buttons";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// txtButtonsNumber
			// 
			this.txtButtonsNumber.Location = new System.Drawing.Point(38, 217);
			this.txtButtonsNumber.Name = "txtButtonsNumber";
			this.txtButtonsNumber.Size = new System.Drawing.Size(123, 22);
			this.txtButtonsNumber.TabIndex = 9;
			// 
			// flpButtons
			// 
			this.flpButtons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.flpButtons.Location = new System.Drawing.Point(182, 16);
			this.flpButtons.Name = "flpButtons";
			this.flpButtons.Size = new System.Drawing.Size(612, 426);
			this.flpButtons.TabIndex = 10;
			// 
			// Lab_匿名函式
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.flpButtons);
			this.Controls.Add(this.txtButtonsNumber);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.txtAmount);
			this.Controls.Add(this.cmbDiscount);
			this.Controls.Add(this.button1);
			this.Name = "Lab_匿名函式";
			this.Text = "Lab_匿名函式";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtAmount;
		private System.Windows.Forms.ComboBox cmbDiscount;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtButtonsNumber;
        private System.Windows.Forms.FlowLayoutPanel flpButtons;
    }
}