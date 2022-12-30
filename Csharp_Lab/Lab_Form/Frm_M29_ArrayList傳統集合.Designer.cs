namespace Lab_Form
{
    partial class Frm_M29_ArrayList傳統集合
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
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Age = new System.Windows.Forms.Label();
            this.btn_AddEmployee = new System.Windows.Forms.Button();
            this.lbl_Employee = new System.Windows.Forms.Label();
            this.txtBox_Name = new System.Windows.Forms.TextBox();
            this.txtBox_Age = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_Name.Location = new System.Drawing.Point(55, 66);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(87, 33);
            this.lbl_Name.TabIndex = 12;
            this.lbl_Name.Text = "姓名：";
            // 
            // lbl_Age
            // 
            this.lbl_Age.AutoSize = true;
            this.lbl_Age.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_Age.Location = new System.Drawing.Point(55, 149);
            this.lbl_Age.Name = "lbl_Age";
            this.lbl_Age.Size = new System.Drawing.Size(87, 33);
            this.lbl_Age.TabIndex = 13;
            this.lbl_Age.Text = "年齡：";
            // 
            // btn_AddEmployee
            // 
            this.btn_AddEmployee.Font = new System.Drawing.Font("UD Digi Kyokasho N-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_AddEmployee.Location = new System.Drawing.Point(159, 247);
            this.btn_AddEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_AddEmployee.Name = "btn_AddEmployee";
            this.btn_AddEmployee.Size = new System.Drawing.Size(192, 59);
            this.btn_AddEmployee.TabIndex = 14;
            this.btn_AddEmployee.Text = "Add Employee";
            this.btn_AddEmployee.UseVisualStyleBackColor = true;
            this.btn_AddEmployee.Click += new System.EventHandler(this.btn_AddEmployee_Click);
            // 
            // lbl_Employee
            // 
            this.lbl_Employee.AutoSize = true;
            this.lbl_Employee.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_Employee.Location = new System.Drawing.Point(514, 22);
            this.lbl_Employee.Name = "lbl_Employee";
            this.lbl_Employee.Size = new System.Drawing.Size(71, 33);
            this.lbl_Employee.TabIndex = 15;
            this.lbl_Employee.Text = "員工";
            // 
            // txtBox_Name
            // 
            this.txtBox_Name.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBox_Name.Location = new System.Drawing.Point(159, 60);
            this.txtBox_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBox_Name.Name = "txtBox_Name";
            this.txtBox_Name.Size = new System.Drawing.Size(192, 39);
            this.txtBox_Name.TabIndex = 16;
            // 
            // txtBox_Age
            // 
            this.txtBox_Age.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBox_Age.Location = new System.Drawing.Point(159, 147);
            this.txtBox_Age.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBox_Age.Name = "txtBox_Age";
            this.txtBox_Age.Size = new System.Drawing.Size(192, 39);
            this.txtBox_Age.TabIndex = 17;
            // 
            // Frm_M29_ArrayList傳統集合
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 551);
            this.Controls.Add(this.txtBox_Age);
            this.Controls.Add(this.txtBox_Name);
            this.Controls.Add(this.lbl_Employee);
            this.Controls.Add(this.btn_AddEmployee);
            this.Controls.Add(this.lbl_Age);
            this.Controls.Add(this.lbl_Name);
            this.Name = "Frm_M29_ArrayList傳統集合";
            this.Text = "Frm_M29_ArrayList傳統集合";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Age;
        private System.Windows.Forms.Button btn_AddEmployee;
        private System.Windows.Forms.Label lbl_Employee;
        private System.Windows.Forms.TextBox txtBox_Name;
        private System.Windows.Forms.TextBox txtBox_Age;
    }
}