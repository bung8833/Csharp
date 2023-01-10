using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class Frm_TicTacToe : Form
    {
        public Frm_TicTacToe()
        {
            InitializeComponent();
            //List<Button> list_btn = this.Controls.OfType<Button>().ToList();
        }

        //static Color newColor = SystemColors.GradientActiveCaption;
        static Color newColor = SystemColors.GradientInactiveCaption;

        private void Reset()
        {
            List<Button> list_btn = Controls.OfType<Button>().ToList();
            foreach (var b in list_btn)
            {
                if (b != btn_Reset && b != btn_Exit)
                {
                    b.Text = "";
                    b.BackColor = SystemColors.GradientInactiveCaption;
                    b.Enabled = true;
                }
            }
        }

        private void place_O()
        {
            if (O_Winning())
            {
                return;
            }

            if (X_Winning())
            {
                return;
            }
            
            if (!center_O())
            {
                if (!Case_L()) // Special Case Handler
                {
                    if (!corners_O())
                    {
                        if (!edges_O())
                        {
                            MessageBox.Show("Tie!", "Game Over");
                            Reset();
                        }
                    }
                }
                
            }
            //rand_place_O();
            //O_Won();

            // check for tie (if no button available)
            //List<Button> list_btn = Controls.OfType<Button>().ToList();
            //bool available = false;
            //foreach (var b in list_btn)
            //{
            //    if (b.Text.Any() == false)
            //    {
            //        available = true;
            //        break;
            //    }
            //}
            //if (!available)
            //{
            //    MessageBox.Show("Tie!", "Game Over");
            //    Reset();
            //}
        }

        private bool O_Winning()
        {
            List<Button> b = new List<Button>()
            {
                btn_11, btn_12, btn_13,
                btn_21, btn_22, btn_23,
                btn_31, btn_32, btn_33
            };
            // if placed an O to win, then return true
            // cannot win immediately, then return false

            int[,] array = new int[,]
            {
                { 0, 0, 0 },
                { 0, 0, 0 },
                { 0, 0, 0 }
            };

            int bIdx = 0;
            // "O" = 100, "X" = 1
            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= array.GetUpperBound(1); j++)
                {
                    if (b[bIdx].Text == "O")
                    {
                        array[i, j] = 100;
                    }
                    else if (b[bIdx].Text == "X")
                    {
                        array[i, j] = 1;
                    }
                    bIdx++;
                }
            }

            // rows
            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {
                if (array[i, 0] + array[i, 1] + array[i, 2] == 200)
                {
                    if (place_O_here(row: i)) 
                    {
                        return true;
                    }
                }
            }

            // columns
            for (int j = 0; j <= array.GetUpperBound(1); j++)
            {
                if (array[0, j] + array[1, j] + array[2, j] == 200)
                {
                    if (place_O_here(column: j)) 
                    {
                        return true;
                    }
                }
            }

            // diagonals
            if (array[0, 0] + array[1, 1] + array[2, 2] == 200)
            {
                if (place_O_here(diagonal: "n")) 
                {
                    return true;
                }
            }
            if (array[0, 2] + array[1, 1] + array[2, 0] == 200)
            {
                if (place_O_here(diagonal: "p")) 
                {
                    return true;
                }
            }

            return false;
        }

        private bool X_Winning()
        {
            List<Button> b = new List<Button>()
            {
                btn_11, btn_12, btn_13,
                btn_21, btn_22, btn_23,
                btn_31, btn_32, btn_33
            };
            // if placed an O to deny opponent's win, then return true
            // no need to do defend immediately, then return false

            int[,] array = new int[,]
            {
                { 0, 0, 0 },
                { 0, 0, 0 },
                { 0, 0, 0 }
            };

            int bIdx = 0;
            // "O" = 100, "X" = 1
            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= array.GetUpperBound(1); j++)
                {
                    
                    if (b[bIdx].Text == "X")
                    {
                        array[i, j] = 1;
                    }
                    else if (b[bIdx].Text == "O")
                    {
                        array[i, j] = 100;
                    }

                    bIdx++;
                }
            }

            // rows
            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {
                if (array[i, 0] + array[i, 1] + array[i, 2] == 2)
                {
                    if (place_O_here(row: i))
                    {
                        return true;
                    }
                }
            }

            // columns
            for (int j = 0; j <= array.GetUpperBound(1); j++)
            {
                if (array[0, j] + array[1, j] + array[2, j] == 2)
                {
                    if (place_O_here(column: j))
                    {
                        return true;
                    }
                }
            }

            // diagonals
            if (array[0, 0] + array[1, 1] + array[2, 2] == 2)
            {
                if (place_O_here(diagonal: "n"))
                {
                    return true;
                }
            }
            if (array[0, 2] + array[1, 1] + array[2, 0] == 2)
            {
                if (place_O_here(diagonal: "p"))
                {
                    return true;
                }
            }

            return false;
        }

        private bool Case_L()
        {
            List<Button> bLst = new List<Button>()
            {          btn_12,
               btn_21,         btn_23,
                       btn_32
            };

            if (btn_22.Text == "O"
               && (btn_11.Text == "X" && btn_33.Text == "X"
                  || btn_13.Text == "X" && btn_31.Text == "X")
               && bLst[0].Text.Any() == false
               && bLst[1].Text.Any() == false
               && bLst[2].Text.Any() == false
               && bLst[3].Text.Any() == false
               )
            {
                edges_O();

                return true;
            }

            return false;
        }

        private bool O_Won(bool won = false)
        {
            //go thru rows, columns, and diagonals

            List<Button> b = new List<Button>()
            {
                btn_11, btn_12, btn_13,
                btn_21, btn_22, btn_23,
                btn_31, btn_32, btn_33
            };

             // rows
            if (b[0].Text == "O" && b[1].Text == "O" && b[2].Text == "O"
             || b[3].Text == "O" && b[4].Text == "O" && b[5].Text == "O"
             || b[6].Text == "O" && b[7].Text == "O" && b[8].Text == "O"
             // columns
             || b[0].Text == "O" && b[3].Text == "O" && b[6].Text == "O"
             || b[1].Text == "O" && b[4].Text == "O" && b[7].Text == "O"
             || b[2].Text == "O" && b[5].Text == "O" && b[8].Text == "O"
             // diagonals
             || b[0].Text == "O" && b[4].Text == "O" && b[8].Text == "O"
             || b[2].Text == "O" && b[4].Text == "O" && b[6].Text == "O")
            {
                won = true;
            }


            if (won)
            {
                MessageBox.Show("O won. Try again!\n電腦贏了。再接再厲！", "Game Over");
                Reset();
            }
            return won;
        }

        private bool X_Won(bool won = false)
        {
            //go thru rows, columns, and diagonals

            List<Button> b = new List<Button>()
            {
                btn_11, btn_12, btn_13,
                btn_21, btn_22, btn_23,
                btn_31, btn_32, btn_33
            };

             // rows
            if (b[0].Text == "X" && b[1].Text == "X" && b[2].Text == "X"
             || b[3].Text == "X" && b[4].Text == "X" && b[5].Text == "X"
             || b[6].Text == "X" && b[7].Text == "X" && b[8].Text == "X"
             // columns
             || b[0].Text == "X" && b[3].Text == "X" && b[6].Text == "X"
             || b[1].Text == "X" && b[4].Text == "X" && b[7].Text == "X"
             || b[2].Text == "X" && b[5].Text == "X" && b[8].Text == "X"
             // diagonals
             || b[0].Text == "X" && b[4].Text == "X" && b[8].Text == "X"
             || b[2].Text == "X" && b[4].Text == "X" && b[6].Text == "X")
            {
                won = true;
            }


            if (won)
            {
                MessageBox.Show("X won. Congratulations!\n你贏了！恭喜", "Game Over");
                Reset();
            }
            return won;
        }


        
        //////////    Placing Os    //////////
        //////////    Placing Os    //////////
        //////////    Placing Os    //////////

        private void rand_place_O()
        {
            Random seed = new Random();
            
            List<Button> b = new List<Button>()
            {
                btn_11, btn_12, btn_13,
                btn_21, btn_22, btn_23,
                btn_31, btn_32, btn_33
            };

            while (true)
            {
                int idx = seed.Next(b.Count);
                if (b[idx].Text.Any() == false)
                {
                    b[idx].Text = "O";
                    b[idx].Enabled= false;
                    break;
                }
            }

            //foreach (var b in list_btn)
            //{
            //    if (b.Text.Any() == false)
            //    {
            //        b.Text = "O";
            //        break;
            //    }
            //}
        }

        private bool center_O()
        {
            bool available = false;

            if (btn_22.Text.Any() == false)
            {
                available = true;
                btn_22.Text = "O";
                btn_22.Enabled = false;
            }

            return available;
        }

        private bool corners_O()
        {
            bool available = false;

            List<Button> b = new List<Button>()
            {
                btn_11, btn_13,
                
                btn_31, btn_33
            };

            List<int> DB = new List<int>()
            {
                0,1,2,3
            };
            List<int> idxes = new List<int>()
            {
                
            };
            while (DB.Count() != 0)
            {
                Random seed = new Random();
                int pos = seed.Next(DB.Count);
                idxes.Add(DB[pos]);
                DB.RemoveAt(pos);
            }

            foreach (var idx in idxes)
            {
                if (b[idx].Text.Any() == false)
                {
                    available = true;
                    b[idx].Text = "O";
                    b[idx].Enabled = false;
                    break;
                }
            }

            //while (true)
            //{
            //    int idx = seed.Next(b.Count());
            //    if (b[idx].Text.Any() == false)
            //    {
            //        b[idx].Text = "O";
            //        break;
            //    }
            //}

            return available;
        }

        private bool edges_O()
        {
            bool available = false;

            List<Button> b = new List<Button>()
            {
                        btn_12,
                btn_21,         btn_23,
                        btn_32
            };

            List<int> DB = new List<int>()
            {
                0,1,2,3
            };
            List<int> idxes = new List<int>()
            {

            };
            while (DB.Count() != 0)
            {
                Random seed = new Random();
                int pos = seed.Next(DB.Count);
                idxes.Add(DB[pos]);
                DB.RemoveAt(pos);
            }

            foreach (var idx in idxes)
            {
                if (b[idx].Text.Any() == false)
                {
                    available = true;
                    b[idx].Text = "O";
                    b[idx].Enabled = false;
                    break;
                }
            }

            return available;
        }

        private bool place_O_here(int row = -1, int column = -1, string diagonal = "")
        {
            // if placed, then return true

            Button[,] bAry = new Button[,]
            {
                { btn_11, btn_12, btn_13 },
                { btn_21, btn_22, btn_23 },
                { btn_31, btn_32, btn_33 }
            };

            // rows
            if (row == 0 || row == 1 || row == 2)
            {
                for (int j = 0; j <= bAry.GetUpperBound(1); j++)
                {
                    if (bAry[row, j].Text.Any() == false)
                    {
                        bAry[row, j].Text = "O";
                        bAry[row, j].BackColor = newColor;
                        bAry[row, j].Enabled = false;
                        return true;
                    }
                }
            }

            // columns
            if (column == 0 || column == 1 || column == 2)
            {
                for (int i = 0; i <= bAry.GetUpperBound(0); i++)
                {
                    if (bAry[i, column].Text.Any() == false)
                    {
                        bAry[i, column].Text = "O";
                        bAry[i, column].BackColor = newColor;
                        bAry[i, column].Enabled = false;
                        return true;
                    }
                }
            }

            // diagonals
            if (diagonal == "n" || diagonal == "N")
            {
                if (bAry[0, 0].Text.Any() == false)
                {
                    bAry[0, 0].Text = "O";
                    bAry[0, 0].BackColor = newColor;
                    bAry[0, 0].Enabled = false;
                    return true;
                }
                if (bAry[1, 1].Text.Any() == false)
                {
                    bAry[1, 1].Text = "O";
                    bAry[1, 1].BackColor = newColor;
                    bAry[1, 1].Enabled = false;
                    return true;
                }
                if (bAry[2, 2].Text.Any() == false)
                {
                    bAry[2, 2].Text = "O";
                    bAry[2, 2].BackColor = newColor;
                    bAry[2, 2].Enabled = false;
                    return true;
                }
            }

            if (diagonal == "p" || diagonal == "P")
            {
                if (bAry[0, 2].Text.Any() == false)
                {
                    bAry[0, 2].Text = "O";
                    bAry[0, 2].BackColor = newColor;
                    bAry[0, 2].Enabled = false;
                    return true;
                }
                if (bAry[1, 1].Text.Any() == false)
                {
                    bAry[1, 1].Text = "O";
                    bAry[1, 1].BackColor = newColor;
                    bAry[1, 1].Enabled = false;
                    return true;
                }
                if (bAry[2, 0].Text.Any() == false)
                {
                    bAry[2, 0].Text = "O";
                    bAry[2, 0].BackColor = newColor;
                    bAry[2, 0].Enabled = false;
                    return true;
                }
            }

            return false;
        }



        //////////   Click Events   //////////
        //////////   Click Events   //////////
        //////////   Click Events   //////////

        private void btn_11_Click(object sender, EventArgs e)
        {
            if (btn_11.Text.Any() == false)
            {
                btn_11.Text = "X";
                btn_11.Enabled = false;
                if (!X_Won())
                {
                    place_O();
                    O_Won();
                }
            }
        }

        private void btn_12_Click(object sender, EventArgs e)
        {
            if (btn_12.Text.Any() == false)
            {
                btn_12.Text = "X";
                btn_12.Enabled = false;
                if (!X_Won())
                {
                    place_O();
                    O_Won();
                }
            }
        }

        private void btn_13_Click(object sender, EventArgs e)
        {
            if (btn_13.Text.Any() == false)
            {
                btn_13.Text = "X";
                btn_13.Enabled = false;
                if (!X_Won())
                {
                    place_O();
                    O_Won();
                }
            }
        }

        private void btn_21_Click(object sender, EventArgs e)
        {
            if (btn_21.Text.Any() == false)
            {
                btn_21.Text = "X";
                btn_21.Enabled = false;
                if (!X_Won())
                {
                    place_O();
                    O_Won();
                }
            }
        }

        private void btn_22_Click(object sender, EventArgs e)
        {
            if (btn_22.Text.Any() == false)
            {
                btn_22.Text = "X";
                btn_22.Enabled = false;
                if (!X_Won())
                {
                    place_O();
                    O_Won();
                }
            }
        }

        private void btn_23_Click(object sender, EventArgs e)
        {
            if (btn_23.Text.Any() == false)
            {
                btn_23.Text = "X";
                btn_23.Enabled = false;
                if (!X_Won())
                {
                    place_O();
                    O_Won();
                }
            }
        }

        private void btn_31_Click(object sender, EventArgs e)
        {
            if (btn_31.Text.Any() == false)
            {
                btn_31.Text = "X";
                btn_31.Enabled = false;
                if (!X_Won())
                {
                    place_O();
                    O_Won();
                }
            }
        }

        private void btn_32_Click(object sender, EventArgs e)
        {
            if (btn_32.Text.Any() == false)
            {
                btn_32.Text = "X";
                btn_32.Enabled = false;
                if (!X_Won())
                {
                    place_O();
                    O_Won();
                }
            }
        }

        private void btn_33_Click(object sender, EventArgs e)
        {
            if (btn_33.Text.Any() == false)
            {
                btn_33.Text = "X";
                btn_33.Enabled = false;
                if (!X_Won())
                {
                    place_O();
                    O_Won();
                }
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }



        //////////     KeyDown     //////////
        //////////     KeyDown     //////////
        //////////     KeyDown     //////////

        private void btn_11_KeyDown(object sender, KeyEventArgs e)
        {
            //string key = e.KeyChar.ToString().ToUpper();
            if (e.KeyCode == Keys.R)
            {
                Reset();
            }

            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void btn_12_KeyDown(object sender, KeyEventArgs e)
        {
            //string key = e.KeyChar.ToString().ToUpper();
            if (e.KeyCode == Keys.R)
            {
                Reset();
            }

            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void btn_13_KeyDown(object sender, KeyEventArgs e)
        {
            //string key = e.KeyChar.ToString().ToUpper();
            if (e.KeyCode == Keys.R)
            {
                Reset();
            }

            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void btn_21_KeyDown(object sender, KeyEventArgs e)
        {
            //string key = e.KeyChar.ToString().ToUpper();
            if (e.KeyCode == Keys.R)
            {
                Reset();
            }

            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void btn_22_KeyDown(object sender, KeyEventArgs e)
        {
            //string key = e.KeyChar.ToString().ToUpper();
            if (e.KeyCode == Keys.R)
            {
                Reset();
            }

            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void btn_23_KeyDown(object sender, KeyEventArgs e)
        {
            //string key = e.KeyChar.ToString().ToUpper();
            if (e.KeyCode == Keys.R)
            {
                Reset();
            }

            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void btn_31_KeyDown(object sender, KeyEventArgs e)
        {
            //string key = e.KeyChar.ToString().ToUpper();
            if (e.KeyCode == Keys.R)
            {
                Reset();
            }

            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void btn_32_KeyDown(object sender, KeyEventArgs e)
        {
            //string key = e.KeyChar.ToString().ToUpper();
            if (e.KeyCode == Keys.R)
            {
                Reset();
            }

            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void btn_33_KeyDown(object sender, KeyEventArgs e)
        {
            //string key = e.KeyChar.ToString().ToUpper();
            if (e.KeyCode == Keys.R)
            {
                Reset();
            }

            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void btn_Reset_KeyDown(object sender, KeyEventArgs e)
        {
            //string key = e.KeyChar.ToString().ToUpper();
            if (e.KeyCode == Keys.R)
            {
                Reset();
            }

            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void btn_Exit_KeyDown(object sender, KeyEventArgs e)
        {
            //string key = e.KeyChar.ToString().ToUpper();
            if (e.KeyCode == Keys.R)
            {
                Reset();
            }

            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
