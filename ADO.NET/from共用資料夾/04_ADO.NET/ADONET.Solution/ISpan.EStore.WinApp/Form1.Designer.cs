namespace ISpan.EStore.WinApp
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
            this.buttonGetConnectionString = new System.Windows.Forms.Button();
            this.buttonGetConnection = new System.Windows.Forms.Button();
            this.checkBoxPooling = new System.Windows.Forms.CheckBox();
            this.buttonEditCategory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxCategoryId = new System.Windows.Forms.TextBox();
            this.buttonExecuteScalar = new System.Windows.Forms.Button();
            this.buttonGetProducts = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.buttonCreateNews = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonGetConnectionString
            // 
            this.buttonGetConnectionString.Location = new System.Drawing.Point(31, 16);
            this.buttonGetConnectionString.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonGetConnectionString.Name = "buttonGetConnectionString";
            this.buttonGetConnectionString.Size = new System.Drawing.Size(229, 29);
            this.buttonGetConnectionString.TabIndex = 0;
            this.buttonGetConnectionString.Text = "GetConnectionString";
            this.buttonGetConnectionString.UseVisualStyleBackColor = true;
            this.buttonGetConnectionString.Click += new System.EventHandler(this.buttonGetConnectionString_Click);
            // 
            // buttonGetConnection
            // 
            this.buttonGetConnection.Location = new System.Drawing.Point(31, 69);
            this.buttonGetConnection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonGetConnection.Name = "buttonGetConnection";
            this.buttonGetConnection.Size = new System.Drawing.Size(229, 29);
            this.buttonGetConnection.TabIndex = 1;
            this.buttonGetConnection.Text = "GetConnection";
            this.buttonGetConnection.UseVisualStyleBackColor = true;
            this.buttonGetConnection.Click += new System.EventHandler(this.buttonGetConnection_Click);
            // 
            // checkBoxPooling
            // 
            this.checkBoxPooling.AutoSize = true;
            this.checkBoxPooling.Location = new System.Drawing.Point(281, 76);
            this.checkBoxPooling.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxPooling.Name = "checkBoxPooling";
            this.checkBoxPooling.Size = new System.Drawing.Size(73, 19);
            this.checkBoxPooling.TabIndex = 2;
            this.checkBoxPooling.Text = "Pooling";
            this.checkBoxPooling.UseVisualStyleBackColor = true;
            // 
            // buttonEditCategory
            // 
            this.buttonEditCategory.Location = new System.Drawing.Point(31, 126);
            this.buttonEditCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEditCategory.Name = "buttonEditCategory";
            this.buttonEditCategory.Size = new System.Drawing.Size(229, 29);
            this.buttonEditCategory.TabIndex = 3;
            this.buttonEditCategory.Text = "讀取一筆Category";
            this.buttonEditCategory.UseVisualStyleBackColor = true;
            this.buttonEditCategory.Click += new System.EventHandler(this.buttonEditCategory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "id:";
            // 
            // textboxCategoryId
            // 
            this.textboxCategoryId.Location = new System.Drawing.Point(307, 129);
            this.textboxCategoryId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textboxCategoryId.Name = "textboxCategoryId";
            this.textboxCategoryId.Size = new System.Drawing.Size(132, 25);
            this.textboxCategoryId.TabIndex = 5;
            // 
            // buttonExecuteScalar
            // 
            this.buttonExecuteScalar.Location = new System.Drawing.Point(31, 184);
            this.buttonExecuteScalar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonExecuteScalar.Name = "buttonExecuteScalar";
            this.buttonExecuteScalar.Size = new System.Drawing.Size(229, 29);
            this.buttonExecuteScalar.TabIndex = 6;
            this.buttonExecuteScalar.Text = "ExecuteScalar";
            this.buttonExecuteScalar.UseVisualStyleBackColor = true;
            this.buttonExecuteScalar.Click += new System.EventHandler(this.buttonExecuteScalar_Click);
            // 
            // buttonGetProducts
            // 
            this.buttonGetProducts.Location = new System.Drawing.Point(31, 234);
            this.buttonGetProducts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonGetProducts.Name = "buttonGetProducts";
            this.buttonGetProducts.Size = new System.Drawing.Size(229, 29);
            this.buttonGetProducts.TabIndex = 7;
            this.buttonGetProducts.Text = "顯示多筆Products";
            this.buttonGetProducts.UseVisualStyleBackColor = true;
            this.buttonGetProducts.Click += new System.EventHandler(this.buttonGetProducts_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 238);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Product Name:";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(375, 234);
            this.textBoxProductName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(132, 25);
            this.textBoxProductName.TabIndex = 9;
            // 
            // buttonCreateNews
            // 
            this.buttonCreateNews.Location = new System.Drawing.Point(31, 284);
            this.buttonCreateNews.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCreateNews.Name = "buttonCreateNews";
            this.buttonCreateNews.Size = new System.Drawing.Size(229, 29);
            this.buttonCreateNews.TabIndex = 10;
            this.buttonCreateNews.Text = "Create News";
            this.buttonCreateNews.UseVisualStyleBackColor = true;
            this.buttonCreateNews.Click += new System.EventHandler(this.buttonCreateNews_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "編輯News";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "News Id:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 378);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonCreateNews);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonGetProducts);
            this.Controls.Add(this.buttonExecuteScalar);
            this.Controls.Add(this.textboxCategoryId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEditCategory);
            this.Controls.Add(this.checkBoxPooling);
            this.Controls.Add(this.buttonGetConnection);
            this.Controls.Add(this.buttonGetConnectionString);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGetConnectionString;
        private System.Windows.Forms.Button buttonGetConnection;
        private System.Windows.Forms.CheckBox checkBoxPooling;
        private System.Windows.Forms.Button buttonEditCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxCategoryId;
        private System.Windows.Forms.Button buttonExecuteScalar;
		private System.Windows.Forms.Button buttonGetProducts;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxProductName;
		private System.Windows.Forms.Button buttonCreateNews;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
	}
}

