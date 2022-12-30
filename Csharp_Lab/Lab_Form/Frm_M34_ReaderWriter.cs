using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class Frm_M34_ReaderWriter : Form
    {
        public Frm_M34_ReaderWriter()
        {
            InitializeComponent();
        }

        private void btn_Reader_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("86―エイティシックス―.txt", Encoding.UTF8);
            // 也可另存新文字檔改編碼

            txtBox_RW.Text = sr.ReadToEnd();
            sr.Close();
        }

        // 練習 File Mode
        // 練習中斷點
    }
}
