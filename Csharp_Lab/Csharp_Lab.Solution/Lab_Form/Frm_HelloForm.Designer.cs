namespace Lab_Form
{
    partial class Frm_HelloForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_HelloForm));
            this.txtBox_name = new System.Windows.Forms.TextBox();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.label_instruction = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBox_name
            // 
            this.txtBox_name.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_name.Location = new System.Drawing.Point(278, 98);
            this.txtBox_name.Name = "txtBox_name";
            this.txtBox_name.Size = new System.Drawing.Size(417, 26);
            this.txtBox_name.TabIndex = 0;
            // 
            // btn_Enter
            // 
            this.btn_Enter.AccessibleDescription = "";
            this.btn_Enter.BackColor = System.Drawing.Color.Transparent;
            this.btn_Enter.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Enter.Location = new System.Drawing.Point(550, 135);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(145, 38);
            this.btn_Enter.TabIndex = 1;
            this.btn_Enter.Text = "Enter";
            this.btn_Enter.UseVisualStyleBackColor = false;
            this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
            // 
            // label_instruction
            // 
            this.label_instruction.AutoSize = true;
            this.label_instruction.BackColor = System.Drawing.Color.Transparent;
            this.label_instruction.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_instruction.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_instruction.Location = new System.Drawing.Point(273, 68);
            this.label_instruction.Name = "label_instruction";
            this.label_instruction.Size = new System.Drawing.Size(250, 22);
            this.label_instruction.TabIndex = 2;
            this.label_instruction.Text = "Enter your name please: \r\n";
            this.label_instruction.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Frm_HelloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(861, 540);
            this.Controls.Add(this.label_instruction);
            this.Controls.Add(this.btn_Enter);
            this.Controls.Add(this.txtBox_name);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frm_HelloForm";
            this.Text = "SayHello";
            this.Load += new System.EventHandler(this.Frm_HelloForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_name;
        private System.Windows.Forms.Button btn_Enter;
        private System.Windows.Forms.Label label_instruction;
    }
}

