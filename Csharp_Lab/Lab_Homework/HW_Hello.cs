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
    public partial class HW_Hello : Form
    {
        public HW_Hello()
        {
            InitializeComponent();
        }

        private void btn_Hello_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Hello, 我是" + txtBox_Name.Text
                + ",\n英文名字是" + txtBox_EngName.Text
                + ",\n性別是" + txtBox_Gender.Text
                + ",\n星座是" + txtBox_Zodiac.Text
                + ",\n很高興認識你。"
            );
        }

        private void btn_Hi_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Hi, 我是" + txtBox_Name.Text
                + ",\n英文名字是" + txtBox_EngName.Text
                + ",\n性別是" + txtBox_Gender.Text
                + ",\n星座是" + txtBox_Zodiac.Text
                + ",\n很高興認識你。"
            );
        }
    }
}
