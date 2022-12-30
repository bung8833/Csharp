namespace Lab_Form
{
    partial class Frm_M19_Struct
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
            this.lbl_ProductName = new System.Windows.Forms.Label();
            this.txtBox_ProductName = new System.Windows.Forms.TextBox();
            this.txtBox_ProductPrice = new System.Windows.Forms.TextBox();
            this.lbl_ProductPrice = new System.Windows.Forms.Label();
            this.lbl_Show = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Show = new System.Windows.Forms.Button();
            this.btn_AddShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_ProductName
            // 
            this.lbl_ProductName.AutoSize = true;
            this.lbl_ProductName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_ProductName.Location = new System.Drawing.Point(43, 40);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Size = new System.Drawing.Size(134, 31);
            this.lbl_ProductName.TabIndex = 0;
            this.lbl_ProductName.Text = "產品名稱：";
            // 
            // txtBox_ProductName
            // 
            this.txtBox_ProductName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBox_ProductName.Location = new System.Drawing.Point(183, 37);
            this.txtBox_ProductName.Name = "txtBox_ProductName";
            this.txtBox_ProductName.Size = new System.Drawing.Size(171, 39);
            this.txtBox_ProductName.TabIndex = 1;
            // 
            // txtBox_ProductPrice
            // 
            this.txtBox_ProductPrice.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBox_ProductPrice.Location = new System.Drawing.Point(183, 98);
            this.txtBox_ProductPrice.Name = "txtBox_ProductPrice";
            this.txtBox_ProductPrice.Size = new System.Drawing.Size(171, 39);
            this.txtBox_ProductPrice.TabIndex = 3;
            // 
            // lbl_ProductPrice
            // 
            this.lbl_ProductPrice.AutoSize = true;
            this.lbl_ProductPrice.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_ProductPrice.Location = new System.Drawing.Point(43, 101);
            this.lbl_ProductPrice.Name = "lbl_ProductPrice";
            this.lbl_ProductPrice.Size = new System.Drawing.Size(134, 31);
            this.lbl_ProductPrice.TabIndex = 2;
            this.lbl_ProductPrice.Text = "產品單價：";
            // 
            // lbl_Show
            // 
            this.lbl_Show.AutoSize = true;
            this.lbl_Show.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_Show.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Show.Location = new System.Drawing.Point(405, 40);
            this.lbl_Show.Name = "lbl_Show";
            this.lbl_Show.Size = new System.Drawing.Size(62, 31);
            this.lbl_Show.TabIndex = 4;
            this.lbl_Show.Text = "產品";
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Add.Location = new System.Drawing.Point(49, 236);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(154, 57);
            this.btn_Add.TabIndex = 5;
            this.btn_Add.Text = "加入產品";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Show
            // 
            this.btn_Show.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Show.Location = new System.Drawing.Point(49, 299);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(154, 57);
            this.btn_Show.TabIndex = 6;
            this.btn_Show.Text = "顯示產品";
            this.btn_Show.UseVisualStyleBackColor = true;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // btn_AddShow
            // 
            this.btn_AddShow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_AddShow.Location = new System.Drawing.Point(209, 236);
            this.btn_AddShow.Name = "btn_AddShow";
            this.btn_AddShow.Size = new System.Drawing.Size(154, 57);
            this.btn_AddShow.TabIndex = 7;
            this.btn_AddShow.Text = "加入並顯示";
            this.btn_AddShow.UseVisualStyleBackColor = true;
            this.btn_AddShow.Click += new System.EventHandler(this.btn_AddShow_Click);
            // 
            // Frm_M19_Struct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 664);
            this.Controls.Add(this.btn_AddShow);
            this.Controls.Add(this.btn_Show);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbl_Show);
            this.Controls.Add(this.txtBox_ProductPrice);
            this.Controls.Add(this.lbl_ProductPrice);
            this.Controls.Add(this.txtBox_ProductName);
            this.Controls.Add(this.lbl_ProductName);
            this.Name = "Frm_M19_Struct";
            this.Text = "Frm_M19_Struct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ProductName;
        private System.Windows.Forms.TextBox txtBox_ProductName;
        private System.Windows.Forms.TextBox txtBox_ProductPrice;
        private System.Windows.Forms.Label lbl_ProductPrice;
        private System.Windows.Forms.Label lbl_Show;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.Button btn_AddShow;
    }
}