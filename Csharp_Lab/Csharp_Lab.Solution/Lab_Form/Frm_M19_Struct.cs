using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class Frm_M19_Struct : Form
    {
        public Frm_M19_Struct()
        {
            InitializeComponent();
        }

        string Result = "產品";
        int ProductCount = 0;
        decimal TotalPrice = 0;

        //todo 固定(名稱-單價)之間間隔、金額置右對齊
        private bool AddProduct()
        {
            // 普通struct 不用建立實體
            //Product product;
            //product.Name = txtBox_ProductName.Text;
            //product.Price = decimal.Parse(txtBox_ProductPrice.Text);

            // struct中有屬性 要用new建立實體
            //Product product = new Product();
            //product.Name = txtBox_ProductName.Text;
            //product.Price = decimal.Parse(txtBox_ProductPrice.Text);

            if (txtBox_ProductName.Text.Any() == false)
            {
                MessageBox.Show("請輸入產品名稱");
                txtBox_ProductName.Focus();

                return false;
            }

            decimal price = 0;
            bool isNum = decimal.TryParse(txtBox_ProductPrice.Text, out price);
            if (!isNum)
            {
                MessageBox.Show("請在價格欄位輸入正確的數字");
                txtBox_ProductPrice.Clear();
                //txtBox_ProductPrice.Text = "";
                txtBox_ProductPrice.Focus();

                return false;
            }

            // 呼叫struct的建構函式
            Product product = new Product(txtBox_ProductName.Text, price);


            //Result += "\n名稱：" + product.Name + "    單價：" + product.Price;
            Result += $"\n名稱：{product.Name}  單價：{product.Price:C0}";
            //Result += $"\n名稱：{product.Name,-12} 單價：{product.Price:C0}";
            ProductCount += 1;
            TotalPrice += product.Price;

            return true;
        }

        private void ShowProduct()
        {
            if (ProductCount == 0)
            {
                MessageBox.Show("目前沒有產品！");
                return;
            }

            lbl_Show.Text = Result
                          + $"\n\n產品數量：{ProductCount}"
                          + $"\n產品平均單價：{TotalPrice / ProductCount:C1}";
        }



        ///  Click Events  ///
        ///  Click Events  ///
        ///  Click Events  ///

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddProduct();
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            ShowProduct();
        }

        private void btn_AddShow_Click(object sender, EventArgs e)
        {
            if (AddProduct())
            {
                ShowProduct();
            }
        }
    }
}
