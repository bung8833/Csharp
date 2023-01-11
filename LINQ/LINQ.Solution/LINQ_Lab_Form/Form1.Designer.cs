namespace LINQ_Lab_Form
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
            this.dataGridViewShow = new System.Windows.Forms.DataGridView();
            this.buttonQuery = new System.Windows.Forms.Button();
            this.radioButtonDefault = new System.Windows.Forms.RadioButton();
            this.radioButtonSqlExpress = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShow)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewShow
            // 
            this.dataGridViewShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShow.Location = new System.Drawing.Point(31, 24);
            this.dataGridViewShow.Name = "dataGridViewShow";
            this.dataGridViewShow.RowHeadersWidth = 62;
            this.dataGridViewShow.RowTemplate.Height = 31;
            this.dataGridViewShow.Size = new System.Drawing.Size(560, 327);
            this.dataGridViewShow.TabIndex = 0;
            // 
            // buttonQuery
            // 
            this.buttonQuery.Location = new System.Drawing.Point(477, 371);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(114, 42);
            this.buttonQuery.TabIndex = 2;
            this.buttonQuery.Text = "Query";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // radioButtonDefault
            // 
            this.radioButtonDefault.AutoSize = true;
            this.radioButtonDefault.Checked = true;
            this.radioButtonDefault.Location = new System.Drawing.Point(890, 24);
            this.radioButtonDefault.Name = "radioButtonDefault";
            this.radioButtonDefault.Size = new System.Drawing.Size(114, 22);
            this.radioButtonDefault.TabIndex = 3;
            this.radioButtonDefault.TabStop = true;
            this.radioButtonDefault.Text = "SQL Server";
            this.radioButtonDefault.UseVisualStyleBackColor = true;
            // 
            // radioButtonSqlExpress
            // 
            this.radioButtonSqlExpress.AutoSize = true;
            this.radioButtonSqlExpress.Location = new System.Drawing.Point(890, 60);
            this.radioButtonSqlExpress.Name = "radioButtonSqlExpress";
            this.radioButtonSqlExpress.Size = new System.Drawing.Size(173, 22);
            this.radioButtonSqlExpress.TabIndex = 4;
            this.radioButtonSqlExpress.Text = "SQL Server Express";
            this.radioButtonSqlExpress.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 557);
            this.Controls.Add(this.radioButtonSqlExpress);
            this.Controls.Add(this.radioButtonDefault);
            this.Controls.Add(this.buttonQuery);
            this.Controls.Add(this.dataGridViewShow);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewShow;
        private System.Windows.Forms.Button buttonQuery;
        private System.Windows.Forms.RadioButton radioButtonDefault;
        private System.Windows.Forms.RadioButton radioButtonSqlExpress;
    }
}

