namespace Lab_Form
{
    partial class Frm_M08_RegisterEvent
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
            this.btn_RegisterEvent = new System.Windows.Forms.Button();
            this.btn_Register01 = new System.Windows.Forms.Button();
            this.btn_Register02 = new System.Windows.Forms.Button();
            this.btn_DeRegisterEvent = new System.Windows.Forms.Button();
            this.btn_target = new System.Windows.Forms.Button();
            this.btn_invisible = new System.Windows.Forms.Button();
            this.btn_foo = new System.Windows.Forms.Button();
            this.btn_undo_invisible = new System.Windows.Forms.Button();
            this.btn_undo_foo = new System.Windows.Forms.Button();
            this.btn_CallMethod = new System.Windows.Forms.Button();
            this.btn_CallMethod2 = new System.Windows.Forms.Button();
            this.btn_MsgBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_RegisterEvent
            // 
            this.btn_RegisterEvent.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RegisterEvent.Location = new System.Drawing.Point(12, 12);
            this.btn_RegisterEvent.Name = "btn_RegisterEvent";
            this.btn_RegisterEvent.Size = new System.Drawing.Size(157, 73);
            this.btn_RegisterEvent.TabIndex = 0;
            this.btn_RegisterEvent.Text = "Register Event 5x";
            this.btn_RegisterEvent.UseVisualStyleBackColor = true;
            this.btn_RegisterEvent.Click += new System.EventHandler(this.Btn_RegisterEvent_Click);
            // 
            // btn_Register01
            // 
            this.btn_Register01.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Register01.Location = new System.Drawing.Point(12, 91);
            this.btn_Register01.Name = "btn_Register01";
            this.btn_Register01.Size = new System.Drawing.Size(157, 73);
            this.btn_Register01.TabIndex = 1;
            this.btn_Register01.Text = "Register01";
            this.btn_Register01.UseVisualStyleBackColor = true;
            // 
            // btn_Register02
            // 
            this.btn_Register02.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Register02.Location = new System.Drawing.Point(12, 170);
            this.btn_Register02.Name = "btn_Register02";
            this.btn_Register02.Size = new System.Drawing.Size(157, 73);
            this.btn_Register02.TabIndex = 2;
            this.btn_Register02.Text = "Register02";
            this.btn_Register02.UseVisualStyleBackColor = true;
            // 
            // btn_DeRegisterEvent
            // 
            this.btn_DeRegisterEvent.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeRegisterEvent.Location = new System.Drawing.Point(175, 12);
            this.btn_DeRegisterEvent.Name = "btn_DeRegisterEvent";
            this.btn_DeRegisterEvent.Size = new System.Drawing.Size(157, 73);
            this.btn_DeRegisterEvent.TabIndex = 3;
            this.btn_DeRegisterEvent.Text = "解除 \"-=\"";
            this.btn_DeRegisterEvent.UseVisualStyleBackColor = true;
            this.btn_DeRegisterEvent.Click += new System.EventHandler(this.btn_DeRegisterEvent_Click);
            // 
            // btn_target
            // 
            this.btn_target.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_target.Location = new System.Drawing.Point(12, 319);
            this.btn_target.Name = "btn_target";
            this.btn_target.Size = new System.Drawing.Size(157, 73);
            this.btn_target.TabIndex = 5;
            this.btn_target.Text = "Target";
            this.btn_target.UseVisualStyleBackColor = true;
            // 
            // btn_invisible
            // 
            this.btn_invisible.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_invisible.Location = new System.Drawing.Point(12, 407);
            this.btn_invisible.Name = "btn_invisible";
            this.btn_invisible.Size = new System.Drawing.Size(157, 73);
            this.btn_invisible.TabIndex = 6;
            this.btn_invisible.Text = "invisible";
            this.btn_invisible.UseVisualStyleBackColor = true;
            this.btn_invisible.Click += new System.EventHandler(this.btn_invisible_Click);
            // 
            // btn_foo
            // 
            this.btn_foo.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_foo.Location = new System.Drawing.Point(12, 486);
            this.btn_foo.Name = "btn_foo";
            this.btn_foo.Size = new System.Drawing.Size(157, 73);
            this.btn_foo.TabIndex = 7;
            this.btn_foo.Text = "foo";
            this.btn_foo.UseVisualStyleBackColor = true;
            this.btn_foo.Click += new System.EventHandler(this.btn_foo_Click);
            // 
            // btn_undo_invisible
            // 
            this.btn_undo_invisible.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_undo_invisible.Location = new System.Drawing.Point(175, 407);
            this.btn_undo_invisible.Name = "btn_undo_invisible";
            this.btn_undo_invisible.Size = new System.Drawing.Size(157, 73);
            this.btn_undo_invisible.TabIndex = 9;
            this.btn_undo_invisible.Text = "undo";
            this.btn_undo_invisible.UseVisualStyleBackColor = true;
            this.btn_undo_invisible.Click += new System.EventHandler(this.btn_undo_invisible_Click);
            // 
            // btn_undo_foo
            // 
            this.btn_undo_foo.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_undo_foo.Location = new System.Drawing.Point(175, 486);
            this.btn_undo_foo.Name = "btn_undo_foo";
            this.btn_undo_foo.Size = new System.Drawing.Size(157, 73);
            this.btn_undo_foo.TabIndex = 10;
            this.btn_undo_foo.Text = "undo";
            this.btn_undo_foo.UseVisualStyleBackColor = true;
            this.btn_undo_foo.Click += new System.EventHandler(this.btn_undo_foo_Click);
            // 
            // btn_CallMethod
            // 
            this.btn_CallMethod.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CallMethod.Location = new System.Drawing.Point(338, 407);
            this.btn_CallMethod.Name = "btn_CallMethod";
            this.btn_CallMethod.Size = new System.Drawing.Size(157, 73);
            this.btn_CallMethod.TabIndex = 11;
            this.btn_CallMethod.Text = "Call Method";
            this.btn_CallMethod.UseVisualStyleBackColor = true;
            this.btn_CallMethod.Click += new System.EventHandler(this.btn_CallMethod_Click);
            // 
            // btn_CallMethod2
            // 
            this.btn_CallMethod2.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CallMethod2.Location = new System.Drawing.Point(338, 486);
            this.btn_CallMethod2.Name = "btn_CallMethod2";
            this.btn_CallMethod2.Size = new System.Drawing.Size(157, 73);
            this.btn_CallMethod2.TabIndex = 12;
            this.btn_CallMethod2.Text = "Call Method2";
            this.btn_CallMethod2.UseVisualStyleBackColor = true;
            this.btn_CallMethod2.Click += new System.EventHandler(this.btn_CallMethod2_Click);
            // 
            // btn_MsgBox
            // 
            this.btn_MsgBox.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MsgBox.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_MsgBox.Location = new System.Drawing.Point(501, 12);
            this.btn_MsgBox.Name = "btn_MsgBox";
            this.btn_MsgBox.Size = new System.Drawing.Size(157, 73);
            this.btn_MsgBox.TabIndex = 13;
            this.btn_MsgBox.Text = "Message Box";
            this.btn_MsgBox.UseVisualStyleBackColor = true;
            this.btn_MsgBox.Click += new System.EventHandler(this.btn_MsgBox_Click);
            // 
            // Frm_M08_RegisterEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 571);
            this.Controls.Add(this.btn_MsgBox);
            this.Controls.Add(this.btn_CallMethod2);
            this.Controls.Add(this.btn_CallMethod);
            this.Controls.Add(this.btn_undo_foo);
            this.Controls.Add(this.btn_undo_invisible);
            this.Controls.Add(this.btn_foo);
            this.Controls.Add(this.btn_invisible);
            this.Controls.Add(this.btn_target);
            this.Controls.Add(this.btn_DeRegisterEvent);
            this.Controls.Add(this.btn_Register02);
            this.Controls.Add(this.btn_Register01);
            this.Controls.Add(this.btn_RegisterEvent);
            this.Name = "Frm_M08_RegisterEvent";
            this.Text = "Frm_M08_RegisterEvent";
            this.Load += new System.EventHandler(this.Frm_M08_RegisterEvent_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_RegisterEvent;
        private System.Windows.Forms.Button btn_Register01;
        private System.Windows.Forms.Button btn_Register02;
        private System.Windows.Forms.Button btn_DeRegisterEvent;
        private System.Windows.Forms.Button btn_target;
        private System.Windows.Forms.Button btn_invisible;
        private System.Windows.Forms.Button btn_foo;
        private System.Windows.Forms.Button btn_undo_invisible;
        private System.Windows.Forms.Button btn_undo_foo;
        private System.Windows.Forms.Button btn_CallMethod;
        private System.Windows.Forms.Button btn_CallMethod2;
        private System.Windows.Forms.Button btn_MsgBox;
    }
}