namespace Lab_Form
{
    partial class Frm_M16_Parameter
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
            this.btn_ByValue = new System.Windows.Forms.Button();
            this.btn_ByRef = new System.Windows.Forms.Button();
            this.btn_ByRef2 = new System.Windows.Forms.Button();
            this.btn_ByOut = new System.Windows.Forms.Button();
            this.btn_MyParams = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ByValue
            // 
            this.btn_ByValue.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ByValue.Location = new System.Drawing.Point(12, 12);
            this.btn_ByValue.Name = "btn_ByValue";
            this.btn_ByValue.Size = new System.Drawing.Size(143, 55);
            this.btn_ByValue.TabIndex = 0;
            this.btn_ByValue.Text = "by Value";
            this.btn_ByValue.UseVisualStyleBackColor = true;
            this.btn_ByValue.Click += new System.EventHandler(this.btn_ByValue_Click);
            // 
            // btn_ByRef
            // 
            this.btn_ByRef.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ByRef.Location = new System.Drawing.Point(12, 73);
            this.btn_ByRef.Name = "btn_ByRef";
            this.btn_ByRef.Size = new System.Drawing.Size(143, 55);
            this.btn_ByRef.TabIndex = 1;
            this.btn_ByRef.Text = "by Ref";
            this.btn_ByRef.UseVisualStyleBackColor = true;
            this.btn_ByRef.Click += new System.EventHandler(this.btn_ByRef_Click);
            // 
            // btn_ByRef2
            // 
            this.btn_ByRef2.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ByRef2.Location = new System.Drawing.Point(12, 134);
            this.btn_ByRef2.Name = "btn_ByRef2";
            this.btn_ByRef2.Size = new System.Drawing.Size(143, 55);
            this.btn_ByRef2.TabIndex = 2;
            this.btn_ByRef2.Text = "by Ref 2";
            this.btn_ByRef2.UseVisualStyleBackColor = true;
            this.btn_ByRef2.Click += new System.EventHandler(this.btn_ByRef2_Click);
            // 
            // btn_ByOut
            // 
            this.btn_ByOut.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ByOut.Location = new System.Drawing.Point(12, 245);
            this.btn_ByOut.Name = "btn_ByOut";
            this.btn_ByOut.Size = new System.Drawing.Size(143, 55);
            this.btn_ByOut.TabIndex = 3;
            this.btn_ByOut.Text = "by Out";
            this.btn_ByOut.UseVisualStyleBackColor = true;
            this.btn_ByOut.Click += new System.EventHandler(this.btn_ByOut_Click);
            // 
            // btn_MyParams
            // 
            this.btn_MyParams.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MyParams.Location = new System.Drawing.Point(12, 306);
            this.btn_MyParams.Name = "btn_MyParams";
            this.btn_MyParams.Size = new System.Drawing.Size(143, 55);
            this.btn_MyParams.TabIndex = 4;
            this.btn_MyParams.Text = "Params";
            this.btn_MyParams.UseVisualStyleBackColor = true;
            this.btn_MyParams.Click += new System.EventHandler(this.btn_MyParams_Click);
            // 
            // Frm_M16_Parameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_MyParams);
            this.Controls.Add(this.btn_ByOut);
            this.Controls.Add(this.btn_ByRef2);
            this.Controls.Add(this.btn_ByRef);
            this.Controls.Add(this.btn_ByValue);
            this.Name = "Frm_M16_Parameter";
            this.Text = "Frm_M16_Parameter";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ByValue;
        private System.Windows.Forms.Button btn_ByRef;
        private System.Windows.Forms.Button btn_ByRef2;
        private System.Windows.Forms.Button btn_ByOut;
        private System.Windows.Forms.Button btn_MyParams;
    }
}