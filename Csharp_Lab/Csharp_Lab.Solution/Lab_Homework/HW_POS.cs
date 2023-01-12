using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Homework
{
    public partial class HW_POS : Form
    {
        public HW_POS()
        {
            InitializeComponent();
        }

        public class Wine
        {
            public readonly string Name;
            public readonly int Price;

            public Wine(string name, int price)
            {
                Name = name;
                Price = price;
            }

            private int _qty;
            public int Qty
            {
                get { return _qty; }
                set
                {
                    if (value >= 0)
                    {
                        _qty = value;
                    }
                    else
                    {
                        _qty = 0;
                    }
                }
            }
        }



        Wine Vodka = new Wine("伏特加 Vodka", 300)
        {
            Qty = 0,
        };

        Wine Rum = new Wine("蘭姆酒 Rum", 380)
        {
            Qty = 0,
        };

        Wine Bourbon = new Wine("波本 Bourbon", 400)
        {
            Qty = 0,
        };

        Wine GinTonic = new Wine("琴通寧 Gin Tonic", 320)
        {
            Qty = 0,
        };

        static int TotalPrice = 0;

        

        private void btn_Vodka_Click(object sender, EventArgs e)
        {
            Vodka.Qty += 1;
            TotalPrice += Vodka.Price;

            DisplayTotalPrice();
            DisplayCart();
        }

        private void btn_Rum_Click(object sender, EventArgs e)
        {
            Rum.Qty += 1;
            TotalPrice += Rum.Price;

            DisplayTotalPrice();
            DisplayCart();
        }

        private void btn_Bourbon_Click(object sender, EventArgs e)
        {
            Bourbon.Qty += 1;
            TotalPrice += Bourbon.Price;

            DisplayTotalPrice();
            DisplayCart();
        }

        private void btn_GinTonic_Click(object sender, EventArgs e)
        {
            GinTonic.Qty += 1;
            TotalPrice += GinTonic.Price;

            DisplayTotalPrice();
            DisplayCart();
        }



        ////// Methods //////
        ////// Methods //////
        ////// Methods //////

        /// <summary>
        /// 更新並顯示總金額
        /// </summary>
        private void DisplayTotalPrice()
        {
            tbox_TotalPrice.Text = $"NT$ {TotalPrice} ";
        }

        /// <summary>
        /// 更新並顯示購物清單的內容
        /// </summary>
        private void DisplayCart()
        {
            if (Vodka.Qty + Rum.Qty + Bourbon.Qty + GinTonic.Qty == 0)
            {
                tBox_Cart.Text = "尚未點餐";
                return;
            }
            
            string CartResult = String.Empty;

            if (Vodka.Qty > 0)
            {
                CartResult += $"{Vodka.Name} x{Vodka.Qty}, 共{Vodka.Price*Vodka.Qty}元\r\n";
            }

            if (Rum.Qty > 0)
            {
                CartResult += $"{Rum.Name} x{Rum.Qty}, 共{Rum.Price * Rum.Qty}元\r\n";
            }

            if (Bourbon.Qty > 0)
            {
                CartResult += $"{Bourbon.Name} x{Bourbon.Qty}, 共{Bourbon.Price * Bourbon.Qty}元\r\n";
            }

            if (GinTonic.Qty > 0)
            {
                CartResult += $"{GinTonic.Name} x{GinTonic.Qty}, 共{GinTonic.Price * GinTonic.Qty}元\r\n";
            }

            tBox_Cart.Text = CartResult;
        }



        ////// Buttons //////
        ////// Buttons //////
        ////// Buttons //////

        /// <summary>
        /// 原價
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ByCash_Click(object sender, EventArgs e)
        {
            if (Vodka.Qty + Rum.Qty + Bourbon.Qty + GinTonic.Qty == 0)
            {
                MessageBox.Show($"尚未點餐！", "付款", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"總金額：NT${TotalPrice}", "付款", MessageBoxButtons.OKCancel);
            }
        }

        /// <summary>
        /// 3%回饋
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ByCard_Click(object sender, EventArgs e)
        {
            if (Vodka.Qty + Rum.Qty + Bourbon.Qty + GinTonic.Qty == 0)
            {
                MessageBox.Show($"尚未點餐！", "付款", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int DiscountedPrice = (int)Math.Ceiling(TotalPrice * 0.97);

                MessageBox.Show($"總金額：NT${TotalPrice}\n" +
                                $"折扣後金額：NT${DiscountedPrice}", "付款", MessageBoxButtons.OKCancel);
            }
        }

        /// <summary>
        /// 原價
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_JKoPay_Click(object sender, EventArgs e)
        {
            if (Vodka.Qty + Rum.Qty + Bourbon.Qty + GinTonic.Qty == 0)
            {
                MessageBox.Show($"尚未點餐！", "付款", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"總金額：NT${TotalPrice}", "付款", MessageBoxButtons.OKCancel);
            }
        }

        /// <summary>
        /// 原價
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_LinePay_Click(object sender, EventArgs e)
        {
            if (Vodka.Qty + Rum.Qty + Bourbon.Qty + GinTonic.Qty == 0)
            {
                MessageBox.Show($"尚未點餐！", "付款", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"總金額：NT${TotalPrice}", "付款", MessageBoxButtons.OKCancel);
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Vodka.Qty = Rum.Qty = Bourbon.Qty = GinTonic.Qty = 0;
            TotalPrice = 0;

            DisplayTotalPrice();
            DisplayCart();
        }
    }
}
