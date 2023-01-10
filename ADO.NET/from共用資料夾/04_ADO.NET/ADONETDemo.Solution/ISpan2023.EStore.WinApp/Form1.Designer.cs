namespace ISpan2023.EStore.WinApp
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
			this.buttonGetConnStr = new System.Windows.Forms.Button();
			this.labelConnStr = new System.Windows.Forms.Label();
			this.buttonGetConn = new System.Windows.Forms.Button();
			this.checkBoxPooling = new System.Windows.Forms.CheckBox();
			this.buttonUsingConn = new System.Windows.Forms.Button();
			this.buttonEditCategory = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxCategoryId = new System.Windows.Forms.TextBox();
			this.buttonGetProducts = new System.Windows.Forms.Button();
			this.buttonAddNews = new System.Windows.Forms.Button();
			this.buttonEditNews = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxNewsId = new System.Windows.Forms.TextBox();
			this.buttonDeleteNews = new System.Windows.Forms.Button();
			this.buttonMaintainUsers = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.buttonFKFail = new System.Windows.Forms.Button();
			this.buttonConnectFail = new System.Windows.Forms.Button();
			this.buttonMissRequiredValue = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.buttonBatchUpdateCategory = new System.Windows.Forms.Button();
			this.buttonCreateDataTable = new System.Windows.Forms.Button();
			this.buttonMaintainProducts = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonGetConnStr
			// 
			this.buttonGetConnStr.Location = new System.Drawing.Point(13, 13);
			this.buttonGetConnStr.Name = "buttonGetConnStr";
			this.buttonGetConnStr.Size = new System.Drawing.Size(154, 23);
			this.buttonGetConnStr.TabIndex = 0;
			this.buttonGetConnStr.Text = "Get Connection String";
			this.buttonGetConnStr.UseVisualStyleBackColor = true;
			this.buttonGetConnStr.Click += new System.EventHandler(this.buttonGetConnStr_Click);
			// 
			// labelConnStr
			// 
			this.labelConnStr.Location = new System.Drawing.Point(48, 41);
			this.labelConnStr.Name = "labelConnStr";
			this.labelConnStr.Size = new System.Drawing.Size(482, 44);
			this.labelConnStr.TabIndex = 1;
			this.labelConnStr.Text = "labelConnStr";
			// 
			// buttonGetConn
			// 
			this.buttonGetConn.Location = new System.Drawing.Point(15, 88);
			this.buttonGetConn.Name = "buttonGetConn";
			this.buttonGetConn.Size = new System.Drawing.Size(152, 23);
			this.buttonGetConn.TabIndex = 2;
			this.buttonGetConn.Text = "Get SqlConnection";
			this.buttonGetConn.UseVisualStyleBackColor = true;
			this.buttonGetConn.Click += new System.EventHandler(this.buttonGetConn_Click);
			// 
			// checkBoxPooling
			// 
			this.checkBoxPooling.AutoSize = true;
			this.checkBoxPooling.Location = new System.Drawing.Point(186, 94);
			this.checkBoxPooling.Name = "checkBoxPooling";
			this.checkBoxPooling.Size = new System.Drawing.Size(60, 16);
			this.checkBoxPooling.TabIndex = 3;
			this.checkBoxPooling.Text = "Pooling";
			this.checkBoxPooling.UseVisualStyleBackColor = true;
			// 
			// buttonUsingConn
			// 
			this.buttonUsingConn.Location = new System.Drawing.Point(15, 117);
			this.buttonUsingConn.Name = "buttonUsingConn";
			this.buttonUsingConn.Size = new System.Drawing.Size(152, 23);
			this.buttonUsingConn.TabIndex = 4;
			this.buttonUsingConn.Text = "使用 using";
			this.buttonUsingConn.UseVisualStyleBackColor = true;
			this.buttonUsingConn.Click += new System.EventHandler(this.buttonUsingConn_Click);
			// 
			// buttonEditCategory
			// 
			this.buttonEditCategory.Location = new System.Drawing.Point(15, 173);
			this.buttonEditCategory.Name = "buttonEditCategory";
			this.buttonEditCategory.Size = new System.Drawing.Size(152, 23);
			this.buttonEditCategory.TabIndex = 5;
			this.buttonEditCategory.Text = "讀取一筆Category記錄";
			this.buttonEditCategory.UseVisualStyleBackColor = true;
			this.buttonEditCategory.Click += new System.EventHandler(this.buttonEditCategory_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(50, 203);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 12);
			this.label1.TabIndex = 6;
			this.label1.Text = "Category Id:";
			// 
			// textBoxCategoryId
			// 
			this.textBoxCategoryId.Location = new System.Drawing.Point(120, 200);
			this.textBoxCategoryId.Name = "textBoxCategoryId";
			this.textBoxCategoryId.Size = new System.Drawing.Size(47, 22);
			this.textBoxCategoryId.TabIndex = 7;
			// 
			// buttonGetProducts
			// 
			this.buttonGetProducts.Location = new System.Drawing.Point(15, 244);
			this.buttonGetProducts.Name = "buttonGetProducts";
			this.buttonGetProducts.Size = new System.Drawing.Size(152, 23);
			this.buttonGetProducts.TabIndex = 8;
			this.buttonGetProducts.Text = "讀取多筆Product記錄";
			this.buttonGetProducts.UseVisualStyleBackColor = true;
			this.buttonGetProducts.Click += new System.EventHandler(this.buttonGetProducts_Click);
			// 
			// buttonAddNews
			// 
			this.buttonAddNews.Location = new System.Drawing.Point(15, 294);
			this.buttonAddNews.Name = "buttonAddNews";
			this.buttonAddNews.Size = new System.Drawing.Size(152, 23);
			this.buttonAddNews.TabIndex = 9;
			this.buttonAddNews.Text = "新增News";
			this.buttonAddNews.UseVisualStyleBackColor = true;
			this.buttonAddNews.Click += new System.EventHandler(this.buttonAddNews_Click);
			// 
			// buttonEditNews
			// 
			this.buttonEditNews.Location = new System.Drawing.Point(15, 336);
			this.buttonEditNews.Name = "buttonEditNews";
			this.buttonEditNews.Size = new System.Drawing.Size(73, 23);
			this.buttonEditNews.TabIndex = 10;
			this.buttonEditNews.Text = "編輯 News";
			this.buttonEditNews.UseVisualStyleBackColor = true;
			this.buttonEditNews.Click += new System.EventHandler(this.buttonEditNews_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(50, 373);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 12);
			this.label2.TabIndex = 11;
			this.label2.Text = "News Id:";
			// 
			// textBoxNewsId
			// 
			this.textBoxNewsId.Location = new System.Drawing.Point(102, 370);
			this.textBoxNewsId.Name = "textBoxNewsId";
			this.textBoxNewsId.Size = new System.Drawing.Size(65, 22);
			this.textBoxNewsId.TabIndex = 12;
			// 
			// buttonDeleteNews
			// 
			this.buttonDeleteNews.Location = new System.Drawing.Point(94, 336);
			this.buttonDeleteNews.Name = "buttonDeleteNews";
			this.buttonDeleteNews.Size = new System.Drawing.Size(73, 23);
			this.buttonDeleteNews.TabIndex = 13;
			this.buttonDeleteNews.Text = "刪除News";
			this.buttonDeleteNews.UseVisualStyleBackColor = true;
			this.buttonDeleteNews.Click += new System.EventHandler(this.buttonDeleteNews_Click);
			// 
			// buttonMaintainUsers
			// 
			this.buttonMaintainUsers.Location = new System.Drawing.Point(13, 421);
			this.buttonMaintainUsers.Name = "buttonMaintainUsers";
			this.buttonMaintainUsers.Size = new System.Drawing.Size(154, 23);
			this.buttonMaintainUsers.TabIndex = 14;
			this.buttonMaintainUsers.Text = "Maintain Users";
			this.buttonMaintainUsers.UseVisualStyleBackColor = true;
			this.buttonMaintainUsers.Click += new System.EventHandler(this.buttonMaintainUsers_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.buttonFKFail);
			this.groupBox1.Controls.Add(this.buttonConnectFail);
			this.groupBox1.Controls.Add(this.buttonMissRequiredValue);
			this.groupBox1.Location = new System.Drawing.Point(312, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(327, 127);
			this.groupBox1.TabIndex = 15;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "ADO.NET Errors";
			// 
			// buttonFKFail
			// 
			this.buttonFKFail.Location = new System.Drawing.Point(17, 79);
			this.buttonFKFail.Name = "buttonFKFail";
			this.buttonFKFail.Size = new System.Drawing.Size(150, 23);
			this.buttonFKFail.TabIndex = 2;
			this.buttonFKFail.Text = "FK 錯誤";
			this.buttonFKFail.UseVisualStyleBackColor = true;
			this.buttonFKFail.Click += new System.EventHandler(this.buttonFKFail_Click);
			// 
			// buttonConnectFail
			// 
			this.buttonConnectFail.Location = new System.Drawing.Point(17, 49);
			this.buttonConnectFail.Name = "buttonConnectFail";
			this.buttonConnectFail.Size = new System.Drawing.Size(150, 23);
			this.buttonConnectFail.TabIndex = 1;
			this.buttonConnectFail.Text = "無法連結資料庫";
			this.buttonConnectFail.UseVisualStyleBackColor = true;
			this.buttonConnectFail.Click += new System.EventHandler(this.buttonConnectFail_Click);
			// 
			// buttonMissRequiredValue
			// 
			this.buttonMissRequiredValue.Location = new System.Drawing.Point(17, 22);
			this.buttonMissRequiredValue.Name = "buttonMissRequiredValue";
			this.buttonMissRequiredValue.Size = new System.Drawing.Size(150, 23);
			this.buttonMissRequiredValue.TabIndex = 0;
			this.buttonMissRequiredValue.Text = "缺少必填欄位值";
			this.buttonMissRequiredValue.UseVisualStyleBackColor = true;
			this.buttonMissRequiredValue.Click += new System.EventHandler(this.buttonMissRequiredValue_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.buttonBatchUpdateCategory);
			this.groupBox2.Controls.Add(this.buttonCreateDataTable);
			this.groupBox2.Location = new System.Drawing.Point(312, 167);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(327, 100);
			this.groupBox2.TabIndex = 16;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "離線記錄";
			// 
			// buttonBatchUpdateCategory
			// 
			this.buttonBatchUpdateCategory.Location = new System.Drawing.Point(17, 51);
			this.buttonBatchUpdateCategory.Name = "buttonBatchUpdateCategory";
			this.buttonBatchUpdateCategory.Size = new System.Drawing.Size(185, 23);
			this.buttonBatchUpdateCategory.TabIndex = 1;
			this.buttonBatchUpdateCategory.Text = "批次更新 Category";
			this.buttonBatchUpdateCategory.UseVisualStyleBackColor = true;
			this.buttonBatchUpdateCategory.Click += new System.EventHandler(this.buttonBatchUpdateCategory_Click);
			// 
			// buttonCreateDataTable
			// 
			this.buttonCreateDataTable.Location = new System.Drawing.Point(17, 21);
			this.buttonCreateDataTable.Name = "buttonCreateDataTable";
			this.buttonCreateDataTable.Size = new System.Drawing.Size(185, 23);
			this.buttonCreateDataTable.TabIndex = 0;
			this.buttonCreateDataTable.Text = "純手工建立 DataTable";
			this.buttonCreateDataTable.UseVisualStyleBackColor = true;
			this.buttonCreateDataTable.Click += new System.EventHandler(this.buttonCreateDataTable_Click);
			// 
			// buttonMaintainProducts
			// 
			this.buttonMaintainProducts.Location = new System.Drawing.Point(312, 273);
			this.buttonMaintainProducts.Name = "buttonMaintainProducts";
			this.buttonMaintainProducts.Size = new System.Drawing.Size(152, 23);
			this.buttonMaintainProducts.TabIndex = 17;
			this.buttonMaintainProducts.Text = "Maintain Products";
			this.buttonMaintainProducts.UseVisualStyleBackColor = true;
			this.buttonMaintainProducts.Click += new System.EventHandler(this.buttonMaintainProducts_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(672, 506);
			this.Controls.Add(this.buttonMaintainProducts);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.buttonMaintainUsers);
			this.Controls.Add(this.buttonDeleteNews);
			this.Controls.Add(this.textBoxNewsId);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.buttonEditNews);
			this.Controls.Add(this.buttonAddNews);
			this.Controls.Add(this.buttonGetProducts);
			this.Controls.Add(this.textBoxCategoryId);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonEditCategory);
			this.Controls.Add(this.buttonUsingConn);
			this.Controls.Add(this.checkBoxPooling);
			this.Controls.Add(this.buttonGetConn);
			this.Controls.Add(this.labelConnStr);
			this.Controls.Add(this.buttonGetConnStr);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonGetConnStr;
		private System.Windows.Forms.Label labelConnStr;
		private System.Windows.Forms.Button buttonGetConn;
		private System.Windows.Forms.CheckBox checkBoxPooling;
		private System.Windows.Forms.Button buttonUsingConn;
		private System.Windows.Forms.Button buttonEditCategory;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxCategoryId;
		private System.Windows.Forms.Button buttonGetProducts;
		private System.Windows.Forms.Button buttonAddNews;
		private System.Windows.Forms.Button buttonEditNews;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxNewsId;
		private System.Windows.Forms.Button buttonDeleteNews;
		private System.Windows.Forms.Button buttonMaintainUsers;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button buttonMissRequiredValue;
		private System.Windows.Forms.Button buttonConnectFail;
		private System.Windows.Forms.Button buttonFKFail;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button buttonCreateDataTable;
		private System.Windows.Forms.Button buttonBatchUpdateCategory;
		private System.Windows.Forms.Button buttonMaintainProducts;
	}
}

