namespace iSpan.EStore.WinApp
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
            this.btnGetConnString = new System.Windows.Forms.Button();
            this.btnGetConnection = new System.Windows.Forms.Button();
            this.chkPooling = new System.Windows.Forms.CheckBox();
            this.btnReadOneCategory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnExcuteScalar = new System.Windows.Forms.Button();
            this.btnGetProducts = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreateNews = new System.Windows.Forms.Button();
            this.txtNewsId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEditNews = new System.Windows.Forms.Button();
            this.btnDeleteNews = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.groupBoxNews = new System.Windows.Forms.GroupBox();
            this.btnCategories = new System.Windows.Forms.Button();
            this.btnNews = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.groupBoxNews.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetConnString
            // 
            this.btnGetConnString.Location = new System.Drawing.Point(29, 24);
            this.btnGetConnString.Margin = new System.Windows.Forms.Padding(2);
            this.btnGetConnString.Name = "btnGetConnString";
            this.btnGetConnString.Size = new System.Drawing.Size(185, 30);
            this.btnGetConnString.TabIndex = 0;
            this.btnGetConnString.Text = "GetConnectionString";
            this.btnGetConnString.UseVisualStyleBackColor = true;
            this.btnGetConnString.Click += new System.EventHandler(this.btnGetConnString_Click);
            // 
            // btnGetConnection
            // 
            this.btnGetConnection.Location = new System.Drawing.Point(29, 69);
            this.btnGetConnection.Margin = new System.Windows.Forms.Padding(2);
            this.btnGetConnection.Name = "btnGetConnection";
            this.btnGetConnection.Size = new System.Drawing.Size(185, 30);
            this.btnGetConnection.TabIndex = 1;
            this.btnGetConnection.Text = "GetConnection";
            this.btnGetConnection.UseVisualStyleBackColor = true;
            this.btnGetConnection.Click += new System.EventHandler(this.btnGetConnection_Click);
            // 
            // chkPooling
            // 
            this.chkPooling.AutoSize = true;
            this.chkPooling.Location = new System.Drawing.Point(219, 78);
            this.chkPooling.Margin = new System.Windows.Forms.Padding(2);
            this.chkPooling.Name = "chkPooling";
            this.chkPooling.Size = new System.Drawing.Size(60, 16);
            this.chkPooling.TabIndex = 2;
            this.chkPooling.Text = "Pooling";
            this.chkPooling.UseVisualStyleBackColor = true;
            // 
            // btnReadOneCategory
            // 
            this.btnReadOneCategory.Location = new System.Drawing.Point(29, 120);
            this.btnReadOneCategory.Margin = new System.Windows.Forms.Padding(2);
            this.btnReadOneCategory.Name = "btnReadOneCategory";
            this.btnReadOneCategory.Size = new System.Drawing.Size(185, 30);
            this.btnReadOneCategory.TabIndex = 3;
            this.btnReadOneCategory.Text = "讀取一筆Category";
            this.btnReadOneCategory.UseVisualStyleBackColor = true;
            this.btnReadOneCategory.Click += new System.EventHandler(this.btnReadOneCategory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(241, 127);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(125, 22);
            this.txtID.TabIndex = 5;
            // 
            // btnExcuteScalar
            // 
            this.btnExcuteScalar.Location = new System.Drawing.Point(29, 173);
            this.btnExcuteScalar.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcuteScalar.Name = "btnExcuteScalar";
            this.btnExcuteScalar.Size = new System.Drawing.Size(185, 30);
            this.btnExcuteScalar.TabIndex = 6;
            this.btnExcuteScalar.Text = "ExcuteScalar";
            this.btnExcuteScalar.UseVisualStyleBackColor = true;
            this.btnExcuteScalar.Click += new System.EventHandler(this.btnExcuteScalar_Click);
            // 
            // btnGetProducts
            // 
            this.btnGetProducts.Location = new System.Drawing.Point(29, 228);
            this.btnGetProducts.Margin = new System.Windows.Forms.Padding(2);
            this.btnGetProducts.Name = "btnGetProducts";
            this.btnGetProducts.Size = new System.Drawing.Size(185, 30);
            this.btnGetProducts.TabIndex = 7;
            this.btnGetProducts.Text = "顯示多筆Products";
            this.btnGetProducts.UseVisualStyleBackColor = true;
            this.btnGetProducts.Click += new System.EventHandler(this.btnGetProducts_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(290, 235);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(2);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(76, 22);
            this.txtProductName.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 238);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "ProductName:";
            // 
            // btnCreateNews
            // 
            this.btnCreateNews.Location = new System.Drawing.Point(5, 20);
            this.btnCreateNews.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateNews.Name = "btnCreateNews";
            this.btnCreateNews.Size = new System.Drawing.Size(185, 30);
            this.btnCreateNews.TabIndex = 10;
            this.btnCreateNews.Text = "新增News";
            this.btnCreateNews.UseVisualStyleBackColor = true;
            this.btnCreateNews.Click += new System.EventHandler(this.btnCreateNews_Click);
            // 
            // txtNewsId
            // 
            this.txtNewsId.Location = new System.Drawing.Point(54, 122);
            this.txtNewsId.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewsId.Name = "txtNewsId";
            this.txtNewsId.Size = new System.Drawing.Size(136, 22);
            this.txtNewsId.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "NewsID:";
            // 
            // btnEditNews
            // 
            this.btnEditNews.Location = new System.Drawing.Point(5, 54);
            this.btnEditNews.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditNews.Name = "btnEditNews";
            this.btnEditNews.Size = new System.Drawing.Size(185, 30);
            this.btnEditNews.TabIndex = 13;
            this.btnEditNews.Text = "編輯News";
            this.btnEditNews.UseVisualStyleBackColor = true;
            this.btnEditNews.Click += new System.EventHandler(this.btnEditNews_Click);
            // 
            // btnDeleteNews
            // 
            this.btnDeleteNews.Location = new System.Drawing.Point(5, 88);
            this.btnDeleteNews.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteNews.Name = "btnDeleteNews";
            this.btnDeleteNews.Size = new System.Drawing.Size(185, 30);
            this.btnDeleteNews.TabIndex = 14;
            this.btnDeleteNews.Text = "刪除News";
            this.btnDeleteNews.UseVisualStyleBackColor = true;
            this.btnDeleteNews.Click += new System.EventHandler(this.btnDeleteNews_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Location = new System.Drawing.Point(29, 286);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(185, 30);
            this.btnUsers.TabIndex = 15;
            this.btnUsers.Text = "編輯Users";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // groupBoxNews
            // 
            this.groupBoxNews.Controls.Add(this.btnCreateNews);
            this.groupBoxNews.Controls.Add(this.btnEditNews);
            this.groupBoxNews.Controls.Add(this.txtNewsId);
            this.groupBoxNews.Controls.Add(this.btnDeleteNews);
            this.groupBoxNews.Controls.Add(this.label3);
            this.groupBoxNews.Location = new System.Drawing.Point(371, 24);
            this.groupBoxNews.Name = "groupBoxNews";
            this.groupBoxNews.Size = new System.Drawing.Size(197, 158);
            this.groupBoxNews.TabIndex = 16;
            this.groupBoxNews.TabStop = false;
            this.groupBoxNews.Text = "News";
            // 
            // btnCategories
            // 
            this.btnCategories.Location = new System.Drawing.Point(29, 391);
            this.btnCategories.Margin = new System.Windows.Forms.Padding(2);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(185, 30);
            this.btnCategories.TabIndex = 17;
            this.btnCategories.Text = "編輯Categories";
            this.btnCategories.UseVisualStyleBackColor = true;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // btnNews
            // 
            this.btnNews.Location = new System.Drawing.Point(29, 339);
            this.btnNews.Margin = new System.Windows.Forms.Padding(2);
            this.btnNews.Name = "btnNews";
            this.btnNews.Size = new System.Drawing.Size(185, 30);
            this.btnNews.TabIndex = 18;
            this.btnNews.Text = "編輯News";
            this.btnNews.UseVisualStyleBackColor = true;
            this.btnNews.Click += new System.EventHandler(this.btnNews_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(29, 450);
            this.btnProducts.Margin = new System.Windows.Forms.Padding(2);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(185, 30);
            this.btnProducts.TabIndex = 19;
            this.btnProducts.Text = "編輯Products";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 505);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.btnNews);
            this.Controls.Add(this.btnCategories);
            this.Controls.Add(this.groupBoxNews);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGetProducts);
            this.Controls.Add(this.btnExcuteScalar);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReadOneCategory);
            this.Controls.Add(this.chkPooling);
            this.Controls.Add(this.btnGetConnection);
            this.Controls.Add(this.btnGetConnString);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxNews.ResumeLayout(false);
            this.groupBoxNews.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetConnString;
        private System.Windows.Forms.Button btnGetConnection;
        private System.Windows.Forms.CheckBox chkPooling;
        private System.Windows.Forms.Button btnReadOneCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnExcuteScalar;
        private System.Windows.Forms.Button btnGetProducts;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreateNews;
        private System.Windows.Forms.TextBox txtNewsId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEditNews;
        private System.Windows.Forms.Button btnDeleteNews;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.GroupBox groupBoxNews;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button btnNews;
        private System.Windows.Forms.Button btnProducts;
    }
}

