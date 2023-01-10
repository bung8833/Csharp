namespace Lab_Homework
{
    partial class HW_POS
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
            this.btn_Bourbon = new System.Windows.Forms.Button();
            this.btn_Rum = new System.Windows.Forms.Button();
            this.btn_Vodka = new System.Windows.Forms.Button();
            this.tbox_TotalPrice = new System.Windows.Forms.TextBox();
            this.btn_ByCard = new System.Windows.Forms.Button();
            this.btn_ByCash = new System.Windows.Forms.Button();
            this.tBox_Cart = new System.Windows.Forms.TextBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.btn_GinTonic = new System.Windows.Forms.Button();
            this.lbl_Menu = new System.Windows.Forms.Label();
            this.panel_TotalPrice = new System.Windows.Forms.Panel();
            this.lbl_InstructionTotalPrice = new System.Windows.Forms.Label();
            this.panel_PayBy = new System.Windows.Forms.Panel();
            this.btn_JKoPay = new System.Windows.Forms.Button();
            this.btn_LinePay = new System.Windows.Forms.Button();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.lbl_PayBy = new System.Windows.Forms.Label();
            this.panel_Cart = new System.Windows.Forms.Panel();
            this.lbl_Cart = new System.Windows.Forms.Label();
            this.panel_Menu.SuspendLayout();
            this.panel_TotalPrice.SuspendLayout();
            this.panel_PayBy.SuspendLayout();
            this.panel_Cart.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Bourbon
            // 
            this.btn_Bourbon.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Bourbon.Location = new System.Drawing.Point(12, 260);
            this.btn_Bourbon.Name = "btn_Bourbon";
            this.btn_Bourbon.Size = new System.Drawing.Size(130, 170);
            this.btn_Bourbon.TabIndex = 2;
            this.btn_Bourbon.Text = "波本Bourbon NT$ 400";
            this.btn_Bourbon.UseVisualStyleBackColor = true;
            this.btn_Bourbon.Click += new System.EventHandler(this.btn_Bourbon_Click);
            // 
            // btn_Rum
            // 
            this.btn_Rum.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Rum.Location = new System.Drawing.Point(148, 67);
            this.btn_Rum.Name = "btn_Rum";
            this.btn_Rum.Size = new System.Drawing.Size(130, 170);
            this.btn_Rum.TabIndex = 1;
            this.btn_Rum.Text = "蘭姆酒Rum  NT$ 380\r\n";
            this.btn_Rum.UseVisualStyleBackColor = true;
            this.btn_Rum.Click += new System.EventHandler(this.btn_Rum_Click);
            // 
            // btn_Vodka
            // 
            this.btn_Vodka.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Vodka.Location = new System.Drawing.Point(12, 67);
            this.btn_Vodka.Name = "btn_Vodka";
            this.btn_Vodka.Size = new System.Drawing.Size(130, 170);
            this.btn_Vodka.TabIndex = 0;
            this.btn_Vodka.Text = "伏特加Vodka NT$ 300";
            this.btn_Vodka.UseVisualStyleBackColor = true;
            this.btn_Vodka.Click += new System.EventHandler(this.btn_Vodka_Click);
            // 
            // tbox_TotalPrice
            // 
            this.tbox_TotalPrice.BackColor = System.Drawing.SystemColors.ControlText;
            this.tbox_TotalPrice.Enabled = false;
            this.tbox_TotalPrice.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbox_TotalPrice.ForeColor = System.Drawing.Color.White;
            this.tbox_TotalPrice.Location = new System.Drawing.Point(50, 67);
            this.tbox_TotalPrice.Name = "tbox_TotalPrice";
            this.tbox_TotalPrice.ReadOnly = true;
            this.tbox_TotalPrice.Size = new System.Drawing.Size(257, 45);
            this.tbox_TotalPrice.TabIndex = 11;
            this.tbox_TotalPrice.TabStop = false;
            this.tbox_TotalPrice.Text = "NT$ 0 ";
            this.tbox_TotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_ByCard
            // 
            this.btn_ByCard.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_ByCard.Location = new System.Drawing.Point(167, 61);
            this.btn_ByCard.Name = "btn_ByCard";
            this.btn_ByCard.Size = new System.Drawing.Size(140, 50);
            this.btn_ByCard.TabIndex = 5;
            this.btn_ByCard.Text = "信用卡";
            this.btn_ByCard.UseVisualStyleBackColor = true;
            this.btn_ByCard.Click += new System.EventHandler(this.btn_ByCard_Click);
            // 
            // btn_ByCash
            // 
            this.btn_ByCash.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_ByCash.Location = new System.Drawing.Point(19, 61);
            this.btn_ByCash.Name = "btn_ByCash";
            this.btn_ByCash.Size = new System.Drawing.Size(140, 50);
            this.btn_ByCash.TabIndex = 4;
            this.btn_ByCash.Text = "現金";
            this.btn_ByCash.UseVisualStyleBackColor = true;
            this.btn_ByCash.Click += new System.EventHandler(this.btn_ByCash_Click);
            // 
            // tBox_Cart
            // 
            this.tBox_Cart.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tBox_Cart.Location = new System.Drawing.Point(19, 47);
            this.tBox_Cart.Multiline = true;
            this.tBox_Cart.Name = "tBox_Cart";
            this.tBox_Cart.Size = new System.Drawing.Size(375, 318);
            this.tBox_Cart.TabIndex = 15;
            this.tBox_Cart.TabStop = false;
            this.tBox_Cart.Text = "尚未點餐";
            this.tBox_Cart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Clear.Location = new System.Drawing.Point(239, 395);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(155, 49);
            this.btn_Clear.TabIndex = 8;
            this.btn_Clear.Text = "清除清單";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // panel_Menu
            // 
            this.panel_Menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Menu.Controls.Add(this.btn_GinTonic);
            this.panel_Menu.Controls.Add(this.lbl_Menu);
            this.panel_Menu.Controls.Add(this.btn_Bourbon);
            this.panel_Menu.Controls.Add(this.btn_Rum);
            this.panel_Menu.Controls.Add(this.btn_Vodka);
            this.panel_Menu.Location = new System.Drawing.Point(42, 48);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(297, 459);
            this.panel_Menu.TabIndex = 16;
            // 
            // btn_GinTonic
            // 
            this.btn_GinTonic.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_GinTonic.Location = new System.Drawing.Point(148, 260);
            this.btn_GinTonic.Name = "btn_GinTonic";
            this.btn_GinTonic.Size = new System.Drawing.Size(130, 170);
            this.btn_GinTonic.TabIndex = 3;
            this.btn_GinTonic.Text = "琴通寧 Gin Tonic NT$ 320";
            this.btn_GinTonic.UseVisualStyleBackColor = true;
            this.btn_GinTonic.Click += new System.EventHandler(this.btn_GinTonic_Click);
            // 
            // lbl_Menu
            // 
            this.lbl_Menu.AutoSize = true;
            this.lbl_Menu.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Menu.Location = new System.Drawing.Point(6, 9);
            this.lbl_Menu.Name = "lbl_Menu";
            this.lbl_Menu.Size = new System.Drawing.Size(155, 35);
            this.lbl_Menu.TabIndex = 9;
            this.lbl_Menu.Text = "菜單 Menu";
            // 
            // panel_TotalPrice
            // 
            this.panel_TotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_TotalPrice.Controls.Add(this.tbox_TotalPrice);
            this.panel_TotalPrice.Controls.Add(this.lbl_InstructionTotalPrice);
            this.panel_TotalPrice.Location = new System.Drawing.Point(368, 48);
            this.panel_TotalPrice.Name = "panel_TotalPrice";
            this.panel_TotalPrice.Size = new System.Drawing.Size(323, 127);
            this.panel_TotalPrice.TabIndex = 17;
            // 
            // lbl_InstructionTotalPrice
            // 
            this.lbl_InstructionTotalPrice.AutoSize = true;
            this.lbl_InstructionTotalPrice.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_InstructionTotalPrice.Location = new System.Drawing.Point(13, 9);
            this.lbl_InstructionTotalPrice.Name = "lbl_InstructionTotalPrice";
            this.lbl_InstructionTotalPrice.Size = new System.Drawing.Size(243, 35);
            this.lbl_InstructionTotalPrice.TabIndex = 10;
            this.lbl_InstructionTotalPrice.Text = "總金額 Total Price";
            // 
            // panel_PayBy
            // 
            this.panel_PayBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_PayBy.Controls.Add(this.btn_JKoPay);
            this.panel_PayBy.Controls.Add(this.btn_LinePay);
            this.panel_PayBy.Controls.Add(this.lbl_ad);
            this.panel_PayBy.Controls.Add(this.lbl_PayBy);
            this.panel_PayBy.Controls.Add(this.btn_ByCard);
            this.panel_PayBy.Controls.Add(this.btn_ByCash);
            this.panel_PayBy.Location = new System.Drawing.Point(368, 211);
            this.panel_PayBy.Name = "panel_PayBy";
            this.panel_PayBy.Size = new System.Drawing.Size(323, 221);
            this.panel_PayBy.TabIndex = 18;
            // 
            // btn_JKoPay
            // 
            this.btn_JKoPay.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_JKoPay.Location = new System.Drawing.Point(19, 151);
            this.btn_JKoPay.Name = "btn_JKoPay";
            this.btn_JKoPay.Size = new System.Drawing.Size(140, 50);
            this.btn_JKoPay.TabIndex = 6;
            this.btn_JKoPay.Text = "街口";
            this.btn_JKoPay.UseVisualStyleBackColor = true;
            this.btn_JKoPay.Click += new System.EventHandler(this.btn_JKoPay_Click);
            // 
            // btn_LinePay
            // 
            this.btn_LinePay.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_LinePay.Location = new System.Drawing.Point(167, 152);
            this.btn_LinePay.Name = "btn_LinePay";
            this.btn_LinePay.Size = new System.Drawing.Size(140, 50);
            this.btn_LinePay.TabIndex = 7;
            this.btn_LinePay.Text = "LINE Pay";
            this.btn_LinePay.UseVisualStyleBackColor = true;
            this.btn_LinePay.Click += new System.EventHandler(this.btn_LinePay_Click);
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_ad.Location = new System.Drawing.Point(111, 114);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(207, 25);
            this.lbl_ad.TabIndex = 13;
            this.lbl_ad.Text = "信用卡結帳 享3%折扣";
            // 
            // lbl_PayBy
            // 
            this.lbl_PayBy.AutoSize = true;
            this.lbl_PayBy.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_PayBy.Location = new System.Drawing.Point(13, 12);
            this.lbl_PayBy.Name = "lbl_PayBy";
            this.lbl_PayBy.Size = new System.Drawing.Size(127, 35);
            this.lbl_PayBy.TabIndex = 12;
            this.lbl_PayBy.Text = "付款方式";
            // 
            // panel_Cart
            // 
            this.panel_Cart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Cart.Controls.Add(this.lbl_Cart);
            this.panel_Cart.Controls.Add(this.btn_Clear);
            this.panel_Cart.Controls.Add(this.tBox_Cart);
            this.panel_Cart.Location = new System.Drawing.Point(717, 48);
            this.panel_Cart.Name = "panel_Cart";
            this.panel_Cart.Size = new System.Drawing.Size(416, 459);
            this.panel_Cart.TabIndex = 19;
            // 
            // lbl_Cart
            // 
            this.lbl_Cart.AutoSize = true;
            this.lbl_Cart.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Cart.Location = new System.Drawing.Point(13, 9);
            this.lbl_Cart.Name = "lbl_Cart";
            this.lbl_Cart.Size = new System.Drawing.Size(178, 35);
            this.lbl_Cart.TabIndex = 14;
            this.lbl_Cart.Text = "購物清單 List";
            // 
            // HW_POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.panel_Cart);
            this.Controls.Add(this.panel_PayBy);
            this.Controls.Add(this.panel_TotalPrice);
            this.Controls.Add(this.panel_Menu);
            this.Name = "HW_POS";
            this.Text = "HW_POS";
            this.panel_Menu.ResumeLayout(false);
            this.panel_Menu.PerformLayout();
            this.panel_TotalPrice.ResumeLayout(false);
            this.panel_TotalPrice.PerformLayout();
            this.panel_PayBy.ResumeLayout(false);
            this.panel_PayBy.PerformLayout();
            this.panel_Cart.ResumeLayout(false);
            this.panel_Cart.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Bourbon;
        private System.Windows.Forms.Button btn_Rum;
        private System.Windows.Forms.Button btn_Vodka;
        private System.Windows.Forms.TextBox tbox_TotalPrice;
        private System.Windows.Forms.Button btn_ByCard;
        private System.Windows.Forms.Button btn_ByCash;
        private System.Windows.Forms.TextBox tBox_Cart;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Label lbl_Menu;
        private System.Windows.Forms.Panel panel_TotalPrice;
        private System.Windows.Forms.Label lbl_InstructionTotalPrice;
        private System.Windows.Forms.Panel panel_PayBy;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.Label lbl_PayBy;
        private System.Windows.Forms.Panel panel_Cart;
        private System.Windows.Forms.Label lbl_Cart;
        private System.Windows.Forms.Button btn_JKoPay;
        private System.Windows.Forms.Button btn_LinePay;
        private System.Windows.Forms.Button btn_GinTonic;
    }
}