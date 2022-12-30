using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.Games.WinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_YcdGame_Click(object sender, EventArgs e)
        {
            var game = new YcdDiceGame();
            var gameInfo = game.ToString();
            
            MessageBox.Show(sender.ToString());
            MessageBox.Show(e.ToString());

            txtBox_history.Text += gameInfo + "\r\n";
        }

        private int Rounds = 0;
        private int TotalPoints = 0;

        private void btn_YcdNtimes_Click(object sender, EventArgs e)
        {
            int N = 10000;
            
            for (int i = 0; i < N; i++)
            {
                var game = new YcdDiceGame();
                Rounds += 1;
                TotalPoints += game.ComputePoints();
            }

            decimal AveragePoint = decimal.Round( (decimal)TotalPoints/Rounds, 4);

            txtBox_history.Text += $"{N}次遊戲的平均分數：{AveragePoint}\r\n";
            lbl_AveragePoint.Text = $"Average point: {AveragePoint}";
        }
    }
}
