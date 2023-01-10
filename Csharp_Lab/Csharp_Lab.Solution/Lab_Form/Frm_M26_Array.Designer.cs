namespace Lab_Form
{
    partial class Frm_M26_Array
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
            this.btn_Array = new System.Windows.Forms.Button();
            this.btn_RetArray = new System.Windows.Forms.Button();
            this.btn_Swap = new System.Windows.Forms.Button();
            this.btn_GenericSwap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Array
            // 
            this.btn_Array.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Array.Location = new System.Drawing.Point(35, 33);
            this.btn_Array.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Array.Name = "btn_Array";
            this.btn_Array.Size = new System.Drawing.Size(189, 67);
            this.btn_Array.TabIndex = 5;
            this.btn_Array.Text = "建立陣列";
            this.btn_Array.UseVisualStyleBackColor = true;
            this.btn_Array.Click += new System.EventHandler(this.btn_Array_Click);
            // 
            // btn_RetArray
            // 
            this.btn_RetArray.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_RetArray.Location = new System.Drawing.Point(35, 119);
            this.btn_RetArray.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_RetArray.Name = "btn_RetArray";
            this.btn_RetArray.Size = new System.Drawing.Size(189, 67);
            this.btn_RetArray.TabIndex = 6;
            this.btn_RetArray.Text = "回傳陣列";
            this.btn_RetArray.UseVisualStyleBackColor = true;
            this.btn_RetArray.Click += new System.EventHandler(this.btn_RetArray_Click);
            // 
            // btn_Swap
            // 
            this.btn_Swap.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Swap.Location = new System.Drawing.Point(35, 210);
            this.btn_Swap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Swap.Name = "btn_Swap";
            this.btn_Swap.Size = new System.Drawing.Size(189, 67);
            this.btn_Swap.TabIndex = 7;
            this.btn_Swap.Text = "Overloading";
            this.btn_Swap.UseVisualStyleBackColor = true;
            this.btn_Swap.Click += new System.EventHandler(this.btn_Swap_Click);
            // 
            // btn_GenericSwap
            // 
            this.btn_GenericSwap.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_GenericSwap.Location = new System.Drawing.Point(35, 302);
            this.btn_GenericSwap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_GenericSwap.Name = "btn_GenericSwap";
            this.btn_GenericSwap.Size = new System.Drawing.Size(189, 67);
            this.btn_GenericSwap.TabIndex = 8;
            this.btn_GenericSwap.Text = "Generic";
            this.btn_GenericSwap.UseVisualStyleBackColor = true;
            this.btn_GenericSwap.Click += new System.EventHandler(this.btn_GenericSwap_Click);
            // 
            // Frm_M26_Array
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_GenericSwap);
            this.Controls.Add(this.btn_Swap);
            this.Controls.Add(this.btn_RetArray);
            this.Controls.Add(this.btn_Array);
            this.Name = "Frm_M26_Array";
            this.Text = "Frm_M26_Array";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Array;
        private System.Windows.Forms.Button btn_RetArray;
        private System.Windows.Forms.Button btn_Swap;
        private System.Windows.Forms.Button btn_GenericSwap;
    }
}