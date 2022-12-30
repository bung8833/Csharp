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

        private void ycdGameButton_Click(object sender, EventArgs e)
        {
            var game = new YcdDiceGame();
            var gameInfo = game.ToString();

            historyTextBox.Text += gameInfo + "\r\n";
        }
    }
}
