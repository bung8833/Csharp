namespace ispan.Estore.SqlDataLayer.WinForm
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
            this.button_getConnString = new System.Windows.Forms.Button();
            this.button1_getConnection = new System.Windows.Forms.Button();
            this.PoolingCheckBox = new System.Windows.Forms.CheckBox();
            this.btnEditData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.buttonExecuteScalar = new System.Windows.Forms.Button();
            this.buttonGetProducts = new System.Windows.Forms.Button();
            this.buttonGetProducts2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.buttonAddNews = new System.Windows.Forms.Button();
            this.buttonUpdateNews = new System.Windows.Forms.Button();
            this.buttonDelNews = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNewsId = new System.Windows.Forms.TextBox();
            this.buttonCallUserForm = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_getConnString
            // 
            this.button_getConnString.Font = new System.Drawing.Font("新細明體", 15F);
            this.button_getConnString.Location = new System.Drawing.Point(45, 34);
            this.button_getConnString.Name = "button_getConnString";
            this.button_getConnString.Size = new System.Drawing.Size(172, 53);
            this.button_getConnString.TabIndex = 0;
            this.button_getConnString.Text = "getConnString";
            this.button_getConnString.UseVisualStyleBackColor = true;
            this.button_getConnString.Click += new System.EventHandler(this.button_getConnString_Click);
            // 
            // button1_getConnection
            // 
            this.button1_getConnection.Font = new System.Drawing.Font("新細明體", 15F);
            this.button1_getConnection.Location = new System.Drawing.Point(45, 104);
            this.button1_getConnection.Name = "button1_getConnection";
            this.button1_getConnection.Size = new System.Drawing.Size(172, 53);
            this.button1_getConnection.TabIndex = 1;
            this.button1_getConnection.Text = "getConnection";
            this.button1_getConnection.UseVisualStyleBackColor = true;
            this.button1_getConnection.Click += new System.EventHandler(this.button1_getConnection_Click);
            // 
            // PoolingCheckBox
            // 
            this.PoolingCheckBox.AutoSize = true;
            this.PoolingCheckBox.Location = new System.Drawing.Point(224, 137);
            this.PoolingCheckBox.Name = "PoolingCheckBox";
            this.PoolingCheckBox.Size = new System.Drawing.Size(131, 19);
            this.PoolingCheckBox.TabIndex = 2;
            this.PoolingCheckBox.Text = "PoolingCheckBox";
            this.PoolingCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnEditData
            // 
            this.btnEditData.Font = new System.Drawing.Font("新細明體", 15F);
            this.btnEditData.Location = new System.Drawing.Point(45, 174);
            this.btnEditData.Name = "btnEditData";
            this.btnEditData.Size = new System.Drawing.Size(172, 53);
            this.btnEditData.TabIndex = 3;
            this.btnEditData.Text = "讀取一筆資料";
            this.btnEditData.UseVisualStyleBackColor = true;
            this.btnEditData.Click += new System.EventHandler(this.btnReadDataOnce_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Id";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(266, 193);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(236, 25);
            this.textBoxId.TabIndex = 4;
            // 
            // buttonExecuteScalar
            // 
            this.buttonExecuteScalar.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonExecuteScalar.Location = new System.Drawing.Point(45, 242);
            this.buttonExecuteScalar.Name = "buttonExecuteScalar";
            this.buttonExecuteScalar.Size = new System.Drawing.Size(172, 62);
            this.buttonExecuteScalar.TabIndex = 6;
            this.buttonExecuteScalar.Text = "ExecuteScalar";
            this.buttonExecuteScalar.UseVisualStyleBackColor = true;
            this.buttonExecuteScalar.Click += new System.EventHandler(this.buttonExecuteScalar_Click);
            // 
            // buttonGetProducts
            // 
            this.buttonGetProducts.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonGetProducts.Location = new System.Drawing.Point(45, 310);
            this.buttonGetProducts.Name = "buttonGetProducts";
            this.buttonGetProducts.Size = new System.Drawing.Size(172, 62);
            this.buttonGetProducts.TabIndex = 7;
            this.buttonGetProducts.Text = "GetProducts";
            this.buttonGetProducts.UseVisualStyleBackColor = true;
            this.buttonGetProducts.Click += new System.EventHandler(this.buttonGetProducts_Click);
            // 
            // buttonGetProducts2
            // 
            this.buttonGetProducts2.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonGetProducts2.Location = new System.Drawing.Point(45, 378);
            this.buttonGetProducts2.Name = "buttonGetProducts2";
            this.buttonGetProducts2.Size = new System.Drawing.Size(172, 62);
            this.buttonGetProducts2.TabIndex = 8;
            this.buttonGetProducts2.Text = "GetProducts2";
            this.buttonGetProducts2.UseVisualStyleBackColor = true;
            this.buttonGetProducts2.Click += new System.EventHandler(this.buttonGetProducts2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "productName";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(312, 403);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(236, 25);
            this.textBoxProductName.TabIndex = 9;
            // 
            // buttonAddNews
            // 
            this.buttonAddNews.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonAddNews.Location = new System.Drawing.Point(531, 28);
            this.buttonAddNews.Name = "buttonAddNews";
            this.buttonAddNews.Size = new System.Drawing.Size(172, 62);
            this.buttonAddNews.TabIndex = 11;
            this.buttonAddNews.Text = "AddNews";
            this.buttonAddNews.UseVisualStyleBackColor = true;
            this.buttonAddNews.Click += new System.EventHandler(this.buttonAddNews_Click);
            // 
            // buttonUpdateNews
            // 
            this.buttonUpdateNews.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonUpdateNews.Location = new System.Drawing.Point(7, 9);
            this.buttonUpdateNews.Name = "buttonUpdateNews";
            this.buttonUpdateNews.Size = new System.Drawing.Size(159, 56);
            this.buttonUpdateNews.TabIndex = 12;
            this.buttonUpdateNews.Text = "UpdateNews";
            this.buttonUpdateNews.UseVisualStyleBackColor = true;
            this.buttonUpdateNews.Click += new System.EventHandler(this.buttonUpdateNews_Click);
            // 
            // buttonDelNews
            // 
            this.buttonDelNews.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonDelNews.Location = new System.Drawing.Point(172, 9);
            this.buttonDelNews.Name = "buttonDelNews";
            this.buttonDelNews.Size = new System.Drawing.Size(161, 56);
            this.buttonDelNews.TabIndex = 13;
            this.buttonDelNews.Text = "DelNews";
            this.buttonDelNews.UseVisualStyleBackColor = true;
            this.buttonDelNews.Click += new System.EventHandler(this.buttonDelNews_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.buttonUpdateNews);
            this.panel1.Controls.Add(this.textBoxNewsId);
            this.panel1.Controls.Add(this.buttonDelNews);
            this.panel1.Location = new System.Drawing.Point(531, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 159);
            this.panel1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "NewsId";
            // 
            // textBoxNewsId
            // 
            this.textBoxNewsId.Location = new System.Drawing.Point(74, 90);
            this.textBoxNewsId.Name = "textBoxNewsId";
            this.textBoxNewsId.Size = new System.Drawing.Size(236, 25);
            this.textBoxNewsId.TabIndex = 15;
            // 
            // buttonCallUserForm
            // 
            this.buttonCallUserForm.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonCallUserForm.Location = new System.Drawing.Point(531, 279);
            this.buttonCallUserForm.Name = "buttonCallUserForm";
            this.buttonCallUserForm.Size = new System.Drawing.Size(172, 62);
            this.buttonCallUserForm.TabIndex = 15;
            this.buttonCallUserForm.Text = "CallUserForm";
            this.buttonCallUserForm.UseVisualStyleBackColor = true;
            this.buttonCallUserForm.Click += new System.EventHandler(this.buttonCallUserForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 546);
            this.Controls.Add(this.buttonCallUserForm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonAddNews);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.buttonGetProducts2);
            this.Controls.Add(this.buttonGetProducts);
            this.Controls.Add(this.buttonExecuteScalar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.btnEditData);
            this.Controls.Add(this.PoolingCheckBox);
            this.Controls.Add(this.button1_getConnection);
            this.Controls.Add(this.button_getConnString);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_getConnString;
        private System.Windows.Forms.Button button1_getConnection;
        private System.Windows.Forms.CheckBox PoolingCheckBox;
        private System.Windows.Forms.Button btnEditData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Button buttonExecuteScalar;
        private System.Windows.Forms.Button buttonGetProducts;
        private System.Windows.Forms.Button buttonGetProducts2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Button buttonAddNews;
        private System.Windows.Forms.Button buttonUpdateNews;
        private System.Windows.Forms.Button buttonDelNews;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNewsId;
        private System.Windows.Forms.Button buttonCallUserForm;
    }
}

