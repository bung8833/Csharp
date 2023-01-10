namespace Lab_Homework
{
    partial class HW_Hello
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HW_Hello));
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_EngName = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Zodiac = new System.Windows.Forms.Label();
            this.txtBox_Name = new System.Windows.Forms.TextBox();
            this.txtBox_EngName = new System.Windows.Forms.TextBox();
            this.txtBox_Gender = new System.Windows.Forms.TextBox();
            this.txtBox_Zodiac = new System.Windows.Forms.TextBox();
            this.btn_Hello = new System.Windows.Forms.Button();
            this.btn_Hi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Name.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Name.Location = new System.Drawing.Point(80, 80);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(99, 36);
            this.lbl_Name.TabIndex = 2;
            this.lbl_Name.Text = "姓名：";
            // 
            // lbl_EngName
            // 
            this.lbl_EngName.AutoSize = true;
            this.lbl_EngName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_EngName.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_EngName.Location = new System.Drawing.Point(80, 152);
            this.lbl_EngName.Name = "lbl_EngName";
            this.lbl_EngName.Size = new System.Drawing.Size(217, 36);
            this.lbl_EngName.TabIndex = 3;
            this.lbl_EngName.Text = "English Name: ";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Gender.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Gender.Location = new System.Drawing.Point(80, 221);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(99, 36);
            this.lbl_Gender.TabIndex = 4;
            this.lbl_Gender.Text = "性別：";
            // 
            // lbl_Zodiac
            // 
            this.lbl_Zodiac.AutoSize = true;
            this.lbl_Zodiac.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Zodiac.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Zodiac.Location = new System.Drawing.Point(80, 292);
            this.lbl_Zodiac.Name = "lbl_Zodiac";
            this.lbl_Zodiac.Size = new System.Drawing.Size(99, 36);
            this.lbl_Zodiac.TabIndex = 5;
            this.lbl_Zodiac.Text = "星座：";
            // 
            // txtBox_Name
            // 
            this.txtBox_Name.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Name.Location = new System.Drawing.Point(363, 80);
            this.txtBox_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBox_Name.Name = "txtBox_Name";
            this.txtBox_Name.Size = new System.Drawing.Size(139, 36);
            this.txtBox_Name.TabIndex = 6;
            // 
            // txtBox_EngName
            // 
            this.txtBox_EngName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_EngName.Location = new System.Drawing.Point(363, 152);
            this.txtBox_EngName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBox_EngName.Name = "txtBox_EngName";
            this.txtBox_EngName.Size = new System.Drawing.Size(139, 36);
            this.txtBox_EngName.TabIndex = 7;
            // 
            // txtBox_Gender
            // 
            this.txtBox_Gender.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Gender.Location = new System.Drawing.Point(363, 221);
            this.txtBox_Gender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBox_Gender.Name = "txtBox_Gender";
            this.txtBox_Gender.Size = new System.Drawing.Size(139, 36);
            this.txtBox_Gender.TabIndex = 8;
            // 
            // txtBox_Zodiac
            // 
            this.txtBox_Zodiac.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Zodiac.Location = new System.Drawing.Point(363, 292);
            this.txtBox_Zodiac.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBox_Zodiac.Name = "txtBox_Zodiac";
            this.txtBox_Zodiac.Size = new System.Drawing.Size(139, 36);
            this.txtBox_Zodiac.TabIndex = 9;
            // 
            // btn_Hello
            // 
            this.btn_Hello.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Hello.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Hello.Location = new System.Drawing.Point(87, 370);
            this.btn_Hello.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Hello.Name = "btn_Hello";
            this.btn_Hello.Size = new System.Drawing.Size(169, 54);
            this.btn_Hello.TabIndex = 10;
            this.btn_Hello.Text = "Say HELLO!";
            this.btn_Hello.UseVisualStyleBackColor = true;
            this.btn_Hello.Click += new System.EventHandler(this.btn_Hello_Click);
            // 
            // btn_Hi
            // 
            this.btn_Hi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Hi.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Hi.Location = new System.Drawing.Point(334, 370);
            this.btn_Hi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Hi.Name = "btn_Hi";
            this.btn_Hi.Size = new System.Drawing.Size(169, 54);
            this.btn_Hi.TabIndex = 11;
            this.btn_Hi.Text = "Say Hi!";
            this.btn_Hi.UseVisualStyleBackColor = true;
            this.btn_Hi.Click += new System.EventHandler(this.btn_Hi_Click);
            // 
            // HW_Hello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1017, 594);
            this.Controls.Add(this.btn_Hi);
            this.Controls.Add(this.btn_Hello);
            this.Controls.Add(this.txtBox_Zodiac);
            this.Controls.Add(this.txtBox_Gender);
            this.Controls.Add(this.txtBox_EngName);
            this.Controls.Add(this.txtBox_Name);
            this.Controls.Add(this.lbl_Zodiac);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.lbl_EngName);
            this.Controls.Add(this.lbl_Name);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HW_Hello";
            this.Text = "HW_Hello";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_EngName;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_Zodiac;
        private System.Windows.Forms.TextBox txtBox_Name;
        private System.Windows.Forms.TextBox txtBox_EngName;
        private System.Windows.Forms.TextBox txtBox_Gender;
        private System.Windows.Forms.TextBox txtBox_Zodiac;
        private System.Windows.Forms.Button btn_Hello;
        private System.Windows.Forms.Button btn_Hi;
    }
}