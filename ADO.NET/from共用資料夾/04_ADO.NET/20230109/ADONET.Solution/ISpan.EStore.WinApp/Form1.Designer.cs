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
			this.buttonEditNews = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxNewsId = new System.Windows.Forms.TextBox();
			this.buttonDeleteNews = new System.Windows.Forms.Button();
			this.buttonMaintainUsers = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonGetConnectionString
			// 
			this.buttonGetConnectionString.Location = new System.Drawing.Point(23, 13);
			this.buttonGetConnectionString.Name = "buttonGetConnectionString";
			this.buttonGetConnectionString.Size = new System.Drawing.Size(172, 23);
			this.buttonGetConnectionString.TabIndex = 0;
			this.buttonGetConnectionString.Text = "GetConnectionString";
			this.buttonGetConnectionString.UseVisualStyleBackColor = true;
			this.buttonGetConnectionString.Click += new System.EventHandler(this.buttonGetConnectionString_Click);
			// 
			// buttonGetConnection
			// 
			this.buttonGetConnection.Location = new System.Drawing.Point(23, 55);
			this.buttonGetConnection.Name = "buttonGetConnection";
			this.buttonGetConnection.Size = new System.Drawing.Size(172, 23);
			this.buttonGetConnection.TabIndex = 1;
			this.buttonGetConnection.Text = "GetConnection";
			this.buttonGetConnection.UseVisualStyleBackColor = true;
			this.buttonGetConnection.Click += new System.EventHandler(this.buttonGetConnection_Click);
			// 
			// checkBoxPooling
			// 
			this.checkBoxPooling.AutoSize = true;
			this.checkBoxPooling.Location = new System.Drawing.Point(211, 61);
			this.checkBoxPooling.Name = "checkBoxPooling";
			this.checkBoxPooling.Size = new System.Drawing.Size(60, 16);
			this.checkBoxPooling.TabIndex = 2;
			this.checkBoxPooling.Text = "Pooling";
			this.checkBoxPooling.UseVisualStyleBackColor = true;
			// 
			// buttonEditCategory
			// 
			this.buttonEditCategory.Location = new System.Drawing.Point(23, 101);
			this.buttonEditCategory.Name = "buttonEditCategory";
			this.buttonEditCategory.Size = new System.Drawing.Size(172, 23);
			this.buttonEditCategory.TabIndex = 3;
			this.buttonEditCategory.Text = "讀取一筆Category";
			this.buttonEditCategory.UseVisualStyleBackColor = true;
			this.buttonEditCategory.Click += new System.EventHandler(this.buttonEditCategory_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(207, 106);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(17, 12);
			this.label1.TabIndex = 4;
			this.label1.Text = "id:";
			// 
			// textboxCategoryId
			// 
			this.textboxCategoryId.Location = new System.Drawing.Point(230, 103);
			this.textboxCategoryId.Name = "textboxCategoryId";
			this.textboxCategoryId.Size = new System.Drawing.Size(100, 22);
			this.textboxCategoryId.TabIndex = 5;
			// 
			// buttonExecuteScalar
			// 
			this.buttonExecuteScalar.Location = new System.Drawing.Point(23, 147);
			this.buttonExecuteScalar.Name = "buttonExecuteScalar";
			this.buttonExecuteScalar.Size = new System.Drawing.Size(172, 23);
			this.buttonExecuteScalar.TabIndex = 6;
			this.buttonExecuteScalar.Text = "ExecuteScalar";
			this.buttonExecuteScalar.UseVisualStyleBackColor = true;
			this.buttonExecuteScalar.Click += new System.EventHandler(this.buttonExecuteScalar_Click);
			// 
			// buttonGetProducts
			// 
			this.buttonGetProducts.Location = new System.Drawing.Point(23, 187);
			this.buttonGetProducts.Name = "buttonGetProducts";
			this.buttonGetProducts.Size = new System.Drawing.Size(172, 23);
			this.buttonGetProducts.TabIndex = 7;
			this.buttonGetProducts.Text = "顯示多筆Products";
			this.buttonGetProducts.UseVisualStyleBackColor = true;
			this.buttonGetProducts.Click += new System.EventHandler(this.buttonGetProducts_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(201, 190);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 12);
			this.label2.TabIndex = 8;
			this.label2.Text = "Product Name:";
			// 
			// textBoxProductName
			// 
			this.textBoxProductName.Location = new System.Drawing.Point(281, 187);
			this.textBoxProductName.Name = "textBoxProductName";
			this.textBoxProductName.Size = new System.Drawing.Size(100, 22);
			this.textBoxProductName.TabIndex = 9;
			// 
			// buttonCreateNews
			// 
			this.buttonCreateNews.Location = new System.Drawing.Point(23, 227);
			this.buttonCreateNews.Name = "buttonCreateNews";
			this.buttonCreateNews.Size = new System.Drawing.Size(172, 23);
			this.buttonCreateNews.TabIndex = 10;
			this.buttonCreateNews.Text = "Create News";
			this.buttonCreateNews.UseVisualStyleBackColor = true;
			this.buttonCreateNews.Click += new System.EventHandler(this.buttonCreateNews_Click);
			// 
			// buttonEditNews
			// 
			this.buttonEditNews.Location = new System.Drawing.Point(23, 269);
			this.buttonEditNews.Name = "buttonEditNews";
			this.buttonEditNews.Size = new System.Drawing.Size(75, 23);
			this.buttonEditNews.TabIndex = 11;
			this.buttonEditNews.Text = "編輯News";
			this.buttonEditNews.UseVisualStyleBackColor = true;
			this.buttonEditNews.Click += new System.EventHandler(this.buttonEditNews_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(23, 301);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 12);
			this.label3.TabIndex = 12;
			this.label3.Text = "News Id:";
			// 
			// textBoxNewsId
			// 
			this.textBoxNewsId.Location = new System.Drawing.Point(75, 298);
			this.textBoxNewsId.Name = "textBoxNewsId";
			this.textBoxNewsId.Size = new System.Drawing.Size(120, 22);
			this.textBoxNewsId.TabIndex = 13;
			// 
			// buttonDeleteNews
			// 
			this.buttonDeleteNews.Location = new System.Drawing.Point(120, 269);
			this.buttonDeleteNews.Name = "buttonDeleteNews";
			this.buttonDeleteNews.Size = new System.Drawing.Size(75, 23);
			this.buttonDeleteNews.TabIndex = 14;
			this.buttonDeleteNews.Text = "刪除 News";
			this.buttonDeleteNews.UseVisualStyleBackColor = true;
			this.buttonDeleteNews.Click += new System.EventHandler(this.buttonDeleteNews_Click);
			// 
			// buttonMaintainUsers
			// 
			this.buttonMaintainUsers.Location = new System.Drawing.Point(23, 351);
			this.buttonMaintainUsers.Name = "buttonMaintainUsers";
			this.buttonMaintainUsers.Size = new System.Drawing.Size(172, 23);
			this.buttonMaintainUsers.TabIndex = 11;
			this.buttonMaintainUsers.Text = "Maintain Users";
			this.buttonMaintainUsers.UseVisualStyleBackColor = true;
			this.buttonMaintainUsers.Click += new System.EventHandler(this.buttonMaintainUsers_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(133, 393);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 15;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.buttonDeleteNews);
			this.Controls.Add(this.textBoxNewsId);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.buttonMaintainUsers);
			this.Controls.Add(this.buttonEditNews);
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
		private System.Windows.Forms.Button buttonEditNews;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxNewsId;
		private System.Windows.Forms.Button buttonDeleteNews;
		private System.Windows.Forms.Button buttonMaintainUsers;
		private System.Windows.Forms.Button button1;
	}
}

