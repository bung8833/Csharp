namespace ISpan.ReadBooks.win
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
            this.txtBox_Book = new System.Windows.Forms.TextBox();
            this.btn_CheckIn = new System.Windows.Forms.Button();
            this.btn_Display = new System.Windows.Forms.Button();
            this.txtBox_PageIndex = new System.Windows.Forms.TextBox();
            this.txtBox_PageLength = new System.Windows.Forms.TextBox();
            this.lbl_PageIndex = new System.Windows.Forms.Label();
            this.lbl_PageLength = new System.Windows.Forms.Label();
            this.ListBox_Library = new System.Windows.Forms.ListBox();
            this.lbl_Library = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBox_Book
            // 
            this.txtBox_Book.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBox_Book.Location = new System.Drawing.Point(388, 46);
            this.txtBox_Book.Multiline = true;
            this.txtBox_Book.Name = "txtBox_Book";
            this.txtBox_Book.Size = new System.Drawing.Size(572, 404);
            this.txtBox_Book.TabIndex = 0;
            // 
            // btn_CheckIn
            // 
            this.btn_CheckIn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_CheckIn.Location = new System.Drawing.Point(26, 488);
            this.btn_CheckIn.Name = "btn_CheckIn";
            this.btn_CheckIn.Size = new System.Drawing.Size(190, 43);
            this.btn_CheckIn.TabIndex = 2;
            this.btn_CheckIn.Text = "Check In Book";
            this.btn_CheckIn.UseVisualStyleBackColor = true;
            // 
            // btn_Display
            // 
            this.btn_Display.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Display.Location = new System.Drawing.Point(830, 481);
            this.btn_Display.Name = "btn_Display";
            this.btn_Display.Size = new System.Drawing.Size(130, 50);
            this.btn_Display.TabIndex = 3;
            this.btn_Display.Text = "Display";
            this.btn_Display.UseVisualStyleBackColor = true;
            // 
            // txtBox_PageIndex
            // 
            this.txtBox_PageIndex.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBox_PageIndex.Location = new System.Drawing.Point(388, 497);
            this.txtBox_PageIndex.Name = "txtBox_PageIndex";
            this.txtBox_PageIndex.Size = new System.Drawing.Size(115, 31);
            this.txtBox_PageIndex.TabIndex = 4;
            this.txtBox_PageIndex.Text = "0";
            // 
            // txtBox_PageLength
            // 
            this.txtBox_PageLength.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBox_PageLength.Location = new System.Drawing.Point(651, 497);
            this.txtBox_PageLength.Name = "txtBox_PageLength";
            this.txtBox_PageLength.Size = new System.Drawing.Size(115, 31);
            this.txtBox_PageLength.TabIndex = 5;
            this.txtBox_PageLength.Text = "1";
            // 
            // lbl_PageIndex
            // 
            this.lbl_PageIndex.AutoSize = true;
            this.lbl_PageIndex.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_PageIndex.Location = new System.Drawing.Point(256, 498);
            this.lbl_PageIndex.Name = "lbl_PageIndex";
            this.lbl_PageIndex.Size = new System.Drawing.Size(121, 25);
            this.lbl_PageIndex.TabIndex = 6;
            this.lbl_PageIndex.Text = "page index:";
            // 
            // lbl_PageLength
            // 
            this.lbl_PageLength.AutoSize = true;
            this.lbl_PageLength.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_PageLength.Location = new System.Drawing.Point(555, 498);
            this.lbl_PageLength.Name = "lbl_PageLength";
            this.lbl_PageLength.Size = new System.Drawing.Size(87, 25);
            this.lbl_PageLength.TabIndex = 7;
            this.lbl_PageLength.Text = "Length: ";
            // 
            // ListBox_Library
            // 
            this.ListBox_Library.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ListBox_Library.FormattingEnabled = true;
            this.ListBox_Library.ItemHeight = 25;
            this.ListBox_Library.Location = new System.Drawing.Point(26, 46);
            this.ListBox_Library.Name = "ListBox_Library";
            this.ListBox_Library.Size = new System.Drawing.Size(251, 404);
            this.ListBox_Library.TabIndex = 8;
            // 
            // lbl_Library
            // 
            this.lbl_Library.AutoSize = true;
            this.lbl_Library.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Library.Location = new System.Drawing.Point(21, 9);
            this.lbl_Library.Name = "lbl_Library";
            this.lbl_Library.Size = new System.Drawing.Size(75, 25);
            this.lbl_Library.TabIndex = 9;
            this.lbl_Library.Text = "Library";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Title.Location = new System.Drawing.Point(383, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(97, 25);
            this.lbl_Title.TabIndex = 10;
            this.lbl_Title.Text = "titleLabel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 552);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.lbl_Library);
            this.Controls.Add(this.ListBox_Library);
            this.Controls.Add(this.lbl_PageLength);
            this.Controls.Add(this.lbl_PageIndex);
            this.Controls.Add(this.txtBox_PageLength);
            this.Controls.Add(this.txtBox_PageIndex);
            this.Controls.Add(this.btn_Display);
            this.Controls.Add(this.btn_CheckIn);
            this.Controls.Add(this.txtBox_Book);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_Book;
        private System.Windows.Forms.Button btn_CheckIn;
        private System.Windows.Forms.Button btn_Display;
        private System.Windows.Forms.TextBox txtBox_PageIndex;
        private System.Windows.Forms.TextBox txtBox_PageLength;
        private System.Windows.Forms.Label lbl_PageIndex;
        private System.Windows.Forms.Label lbl_PageLength;
        private System.Windows.Forms.ListBox ListBox_Library;
        private System.Windows.Forms.Label lbl_Library;
        private System.Windows.Forms.Label lbl_Title;
    }
}

