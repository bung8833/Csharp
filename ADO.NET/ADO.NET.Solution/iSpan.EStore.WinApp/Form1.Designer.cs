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
            this.btn_GetConnectionString = new System.Windows.Forms.Button();
            this.btn_GetConnection = new System.Windows.Forms.Button();
            this.checkBox_Pooling = new System.Windows.Forms.CheckBox();
            this.button_EditCategory = new System.Windows.Forms.Button();
            this.label_id = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.button_ExecuteScalar = new System.Windows.Forms.Button();
            this.button_GetProducts = new System.Windows.Forms.Button();
            this.label_ProductName = new System.Windows.Forms.Label();
            this.textBox_ProductName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_GetConnectionString
            // 
            this.btn_GetConnectionString.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_GetConnectionString.Location = new System.Drawing.Point(13, 13);
            this.btn_GetConnectionString.Name = "btn_GetConnectionString";
            this.btn_GetConnectionString.Size = new System.Drawing.Size(260, 46);
            this.btn_GetConnectionString.TabIndex = 0;
            this.btn_GetConnectionString.Text = "GetConnectionString";
            this.btn_GetConnectionString.UseVisualStyleBackColor = true;
            this.btn_GetConnectionString.Click += new System.EventHandler(this.btn_GetConnectionString_Click);
            // 
            // btn_GetConnection
            // 
            this.btn_GetConnection.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_GetConnection.Location = new System.Drawing.Point(13, 65);
            this.btn_GetConnection.Name = "btn_GetConnection";
            this.btn_GetConnection.Size = new System.Drawing.Size(260, 46);
            this.btn_GetConnection.TabIndex = 1;
            this.btn_GetConnection.Text = "GetConnection";
            this.btn_GetConnection.UseVisualStyleBackColor = true;
            this.btn_GetConnection.Click += new System.EventHandler(this.btn_GetConnection_Click);
            // 
            // checkBox_Pooling
            // 
            this.checkBox_Pooling.AutoSize = true;
            this.checkBox_Pooling.Location = new System.Drawing.Point(297, 79);
            this.checkBox_Pooling.Name = "checkBox_Pooling";
            this.checkBox_Pooling.Size = new System.Drawing.Size(91, 24);
            this.checkBox_Pooling.TabIndex = 2;
            this.checkBox_Pooling.Text = "Pooling";
            this.checkBox_Pooling.UseVisualStyleBackColor = true;
            // 
            // button_EditCategory
            // 
            this.button_EditCategory.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_EditCategory.Location = new System.Drawing.Point(13, 125);
            this.button_EditCategory.Name = "button_EditCategory";
            this.button_EditCategory.Size = new System.Drawing.Size(260, 46);
            this.button_EditCategory.TabIndex = 3;
            this.button_EditCategory.Text = "讀取一筆Category";
            this.button_EditCategory.UseVisualStyleBackColor = true;
            this.button_EditCategory.Click += new System.EventHandler(this.button_EditCategory_Click);
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(293, 161);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(33, 20);
            this.label_id.TabIndex = 4;
            this.label_id.Text = "id: ";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(332, 158);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(86, 31);
            this.textBox_id.TabIndex = 5;
            // 
            // button_ExecuteScalar
            // 
            this.button_ExecuteScalar.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_ExecuteScalar.Location = new System.Drawing.Point(13, 177);
            this.button_ExecuteScalar.Name = "button_ExecuteScalar";
            this.button_ExecuteScalar.Size = new System.Drawing.Size(260, 46);
            this.button_ExecuteScalar.TabIndex = 6;
            this.button_ExecuteScalar.Text = "ExecuteScalar";
            this.button_ExecuteScalar.UseVisualStyleBackColor = true;
            this.button_ExecuteScalar.Click += new System.EventHandler(this.button_ExecuteScalar_Click);
            // 
            // button_GetProducts
            // 
            this.button_GetProducts.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_GetProducts.Location = new System.Drawing.Point(13, 256);
            this.button_GetProducts.Name = "button_GetProducts";
            this.button_GetProducts.Size = new System.Drawing.Size(260, 46);
            this.button_GetProducts.TabIndex = 7;
            this.button_GetProducts.Text = "顯示多筆Products";
            this.button_GetProducts.UseVisualStyleBackColor = true;
            this.button_GetProducts.Click += new System.EventHandler(this.button_GetProducts_Click);
            // 
            // label_ProductName
            // 
            this.label_ProductName.AutoSize = true;
            this.label_ProductName.Location = new System.Drawing.Point(293, 271);
            this.label_ProductName.Name = "label_ProductName";
            this.label_ProductName.Size = new System.Drawing.Size(125, 20);
            this.label_ProductName.TabIndex = 4;
            this.label_ProductName.Text = "Product Name: ";
            // 
            // textBox_ProductName
            // 
            this.textBox_ProductName.Location = new System.Drawing.Point(434, 268);
            this.textBox_ProductName.Name = "textBox_ProductName";
            this.textBox_ProductName.Size = new System.Drawing.Size(132, 31);
            this.textBox_ProductName.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 500);
            this.Controls.Add(this.button_GetProducts);
            this.Controls.Add(this.button_ExecuteScalar);
            this.Controls.Add(this.textBox_ProductName);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label_ProductName);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.button_EditCategory);
            this.Controls.Add(this.checkBox_Pooling);
            this.Controls.Add(this.btn_GetConnection);
            this.Controls.Add(this.btn_GetConnectionString);
            this.Font = new System.Drawing.Font("新細明體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_GetConnectionString;
        private System.Windows.Forms.Button btn_GetConnection;
        private System.Windows.Forms.CheckBox checkBox_Pooling;
        private System.Windows.Forms.Button button_EditCategory;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Button button_ExecuteScalar;
        private System.Windows.Forms.Button button_GetProducts;
        private System.Windows.Forms.Label label_ProductName;
        private System.Windows.Forms.TextBox textBox_ProductName;
    }
}

