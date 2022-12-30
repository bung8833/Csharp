using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class Frm_M32_String : Form
    {
        public Frm_M32_String()
        {
            InitializeComponent();
        }

        private void btn_String_Click(object sender, EventArgs e)
        {
            // string為不可被修改的ref type
            string A = "AAA";

            string B = A; // 另找記憶體存B的"AAA"
            A = "BBB";

            MessageBox.Show($"A: {A}, B: {B}");
        }

        private void btn_StrBuilder_Click(object sender, EventArgs e)
        {
            // StringBuilder 為普通的Class
            StringBuilder strB1 = new StringBuilder();
            strB1.Append("AAA");
            MessageBox.Show($"strB1: {strB1}");

            StringBuilder strB2 = new StringBuilder();
            strB2 = strB1;
            strB2.Append("BBB"); // B1 B2 指向同一個實體
            MessageBox.Show($"strB1: {strB1}");
        }

        private void btn_addr_Click(object sender, EventArgs e)
        {
            string dir = "C:\\Users\\User\\OneDrive\\lab_Csharp\\Csharp_Lab\\圖庫\\#$&@.jpg";
            //string dir = @"C:\Users\User\OneDrive\lab_Csharp\Csharp_Lab\圖庫\#$&@.jpg";

            string result = "";
            result += Path.GetFullPath(dir) + "\n";
            result += Path.GetFileName(dir) + "\n";
            result += Path.GetExtension(dir) + "\n";
            result += Path.GetFileNameWithoutExtension(dir) + "\n";

            MessageBox.Show(result);
            // Path只是字串處理 不會抓檔
        }
    }
}
