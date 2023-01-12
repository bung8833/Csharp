using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    internal partial class MyClass
    {
        //
        // Also see Method06() in PartialClass.cs
        //
        void Method01()
        {
            MessageBox.Show("Method01: Initially private.");
        }

        private void Method02()
        {
            MessageBox.Show("Method02: Is private.");
        }

        internal void Method03()
        {
            MessageBox.Show("Method03: Is internal.");
        }

        public void Method04()
        {
            MessageBox.Show("Method04: Is public.");
        }

        public void Method05()
        {
            MessageBox.Show("Method05: Calls Method01 & 02");
            Method01();
            Method02();
        }
    }

    // 一個Class本身 預設為internal

    public class Member
    {
        // Class裡面的東西 預設為private
        public string Name;
        public int Age;
        internal string Nickname;
    }

    public enum UserRole // public enum myEnum: long
    {
        Admin, // == 0
        User = 2,
        User1,
    }

    public struct Product
    {
        //public string Name;
        //public decimal Price;
        public string Name { get; set; }
        public decimal Price { get; set; }

        // 自己寫建構函式
        // 實值型別不可有Null值
        public Product(string ProductName, decimal ProductPrice)
        {
            Name = ProductName;
            Price = ProductPrice;
        }
    }

    public struct Employee
    {
        public string Name;
        public int Age;
    }
}
