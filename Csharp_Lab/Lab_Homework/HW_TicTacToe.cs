using Microsoft.VisualBasic;
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
    public partial class HW_TicTacToe : Form
    {
        public HW_TicTacToe()
        {
            InitializeComponent();
        }


        // will not change color:
        //static Color NewColor = SystemColors.GradientInactiveCaption;

        // will change color:
        static Color NewColor = SystemColors.GradientActiveCaption;


        /// <summary>
        /// 代表盤面上的Button狀況:
        /// Button文字為O, BoardValue = 100,
        /// Button文字為X, BoardValue = 1
        /// </summary>
        static int[,] BoardValue = new int[,]
            {
                { 0, 0, 0 },
                { 0, 0, 0 },
                { 0, 0, 0 }
            };

        /// <summary>
        /// 調整BoardValue值:
        /// Button文字為O, BoardValue = 100,
        /// Button文字為X, BoardValue = 1
        /// </summary>
        private void EvaluateBoard()
        {
            Button[,] Buttons = new Button[,]
            {
                { btn_11, btn_12, btn_13 },
                { btn_21, btn_22, btn_23 },
                { btn_31, btn_32, btn_33 }
            };

            // "O" = 100, "X" = 1
            for (int i = 0; i < Buttons.GetLength(0); i++)
            {
                for (int j = 0; j < Buttons.GetLength(1); j++)
                {
                    //BoardValue[i, j] = 0;
                    
                    if (Buttons[i, j].Text == "O")
                    {
                        BoardValue[i, j] = 100;
                    }
                    else if (Buttons[i, j].Text == "X")
                    {
                        BoardValue[i, j] = 1;
                    }
                }
            }
        }

        private void ResetBoard()
        {
            BoardValue = new int[,]
            {
                { 0, 0, 0 },
                { 0, 0, 0 },
                { 0, 0, 0 }
            };

            Button[,] Buttons = new Button[,]
            {
                { btn_11, btn_12, btn_13 },
                { btn_21, btn_22, btn_23 },
                { btn_31, btn_32, btn_33 }
            };

            foreach (var b in Buttons)
            {
                b.Text = "";
                b.BackColor = SystemColors.GradientInactiveCaption;
                b.Enabled = true;
            }
        }



        private void Counter()
        {
            EvaluateBoard();

            //string result = String.Empty;
            //foreach (var num in BoardValue)
            //{
            //    result += num.ToString() + " ";
            //}
            //MessageBox.Show(result);

            if (OisGoingToWin())
            {
                return;
            }

            if (XisGoingToWin())
            {
                return;
            }

            // Determining where to place O

            if (!Center_O())
            {
                if (!SpecialCases()) // Special Case Handler
                {
                    if (!Corners_O())
                    {
                        if (!Edges_O())
                        {
                            MessageBox.Show("Tie!\n平手！再接再厲！", "Game Over");
                            ResetBoard();
                        }
                    }
                }
            }

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

        /// <summary>
        /// if placed an O to win, then return true
        /// cannot win immediately, then return false
        /// </summary>
        /// <returns></returns>
        private bool OisGoingToWin()
        {
            //EvaluateBoard();

            //List<Button> b = new List<Button>()
            //{
            //    btn_11, btn_12, btn_13,
            //    btn_21, btn_22, btn_23,
            //    btn_31, btn_32, btn_33
            //};

            //int[,] array = new int[,]
            //{
            //    { 0, 0, 0 },
            //    { 0, 0, 0 },
            //    { 0, 0, 0 }
            //};

            //int bIdx = 0;
            //// "O" = 100, "X" = 1
            //for (int i = 0; i <= array.GetUpperBound(0); i++)
            //{
            //    for (int j = 0; j <= array.GetUpperBound(1); j++)
            //    {
            //        if (b[bIdx].Text == "O")
            //        {
            //            array[i, j] = 100;
            //        }
            //        else if (b[bIdx].Text == "X")
            //        {
            //            array[i, j] = 1;
            //        }
            //        bIdx++;
            //    }
            //}

            // rows
            for (int i = 0; i <= BoardValue.GetUpperBound(0); i++)
            {
                if (BoardValue[i, 0] + BoardValue[i, 1] + BoardValue[i, 2] == 200)
                {
                    if (Place_O_here(row: i))
                    {
                        return true;
                    }
                }
            }

            // columns
            for (int j = 0; j <= BoardValue.GetUpperBound(1); j++)
            {
                if (BoardValue[0, j] + BoardValue[1, j] + BoardValue[2, j] == 200)
                {
                    if (Place_O_here(column: j))
                    {
                        return true;
                    }
                }
            }

            // diagonals
            if (BoardValue[0, 0] + BoardValue[1, 1] + BoardValue[2, 2] == 200)
            {
                if (Place_O_here(diagonal: -1))
                {
                    return true;
                }
            }
            if (BoardValue[0, 2] + BoardValue[1, 1] + BoardValue[2, 0] == 200)
            {
                if (Place_O_here(diagonal: 1))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// if placed an O to deny opponent's win, then return true
        /// no need to do defend immediately, then return false
        /// </summary>
        /// <returns></returns>
        private bool XisGoingToWin()
        {
            //EvaluateBoard();

            //List<Button> b = new List<Button>()
            //{
            //    btn_11, btn_12, btn_13,
            //    btn_21, btn_22, btn_23,
            //    btn_31, btn_32, btn_33
            //};

            //int[,] array = new int[,]
            //{
            //    { 0, 0, 0 },
            //    { 0, 0, 0 },
            //    { 0, 0, 0 }
            //};

            //int bIdx = 0;
            //// "O" = 100, "X" = 1
            //for (int i = 0; i <= array.GetUpperBound(0); i++)
            //{
            //    for (int j = 0; j <= array.GetUpperBound(1); j++)
            //    {

            //        if (b[bIdx].Text == "X")
            //        {
            //            array[i, j] = 1;
            //        }
            //        else if (b[bIdx].Text == "O")
            //        {
            //            array[i, j] = 100;
            //        }

            //        bIdx++;
            //    }
            //}

            // rows
            for (int i = 0; i <= BoardValue.GetUpperBound(0); i++)
            {
                if (BoardValue[i, 0] + BoardValue[i, 1] + BoardValue[i, 2] == 2)
                {
                    if (Place_O_here(row: i))
                    {
                        return true;
                    }
                }
            }

            // columns
            for (int j = 0; j <= BoardValue.GetUpperBound(1); j++)
            {
                if (BoardValue[0, j] + BoardValue[1, j] + BoardValue[2, j] == 2)
                {
                    if (Place_O_here(column: j))
                    {
                        return true;
                    }
                }
            }

            // diagonals
            if (BoardValue[0, 0] + BoardValue[1, 1] + BoardValue[2, 2] == 2)
            {
                if (Place_O_here(diagonal: -1))
                {
                    return true;
                }
            }
            if (BoardValue[0, 2] + BoardValue[1, 1] + BoardValue[2, 0] == 2)
            {
                if (Place_O_here(diagonal: 1))
                {
                    return true;
                }
            }

            return false;
        }

        private bool CheckIfOWon()
        {
            bool Won = false;
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
                Won = true;
            }


            if (Won)
            {
                MessageBox.Show("O won. Try again!\n電腦贏了。再接再厲！", "Game Over");
                ResetBoard();
            }
            return Won;
        }

        private bool CheckIfXWon()
        {
            bool Won = false;
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
                Won = true;
            }


            if (Won)
            {
                MessageBox.Show("X won. Congratulations!\n你贏了！恭喜", "Game Over");
                ResetBoard();
            }
            return Won;
        }






        //////////    Placing Os    //////////
        //////////    Placing Os    //////////
        //////////    Placing Os    //////////

        /// <summary>
        /// 可傳入選擇性參數:
        ///   row, column, diagonal
        ///   來指定O要放哪裡
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <param name="diagonal"></param>
        /// <returns></returns>
        private bool Place_O_here(int row = -1, int column = -1, int diagonal = 0)
        {
            // if placed O, then return true

            List<int> validValue = new List<int> // for row & column
            {
                -1, 0, 1, 2,
            };

            if (validValue.Contains(row) && validValue.Contains(column))
                ; // Great!
            else
                return false;
            

            Button[,] Buttons = new Button[,]
            {
                { btn_11, btn_12, btn_13 },
                { btn_21, btn_22, btn_23 },
                { btn_31, btn_32, btn_33 }
            };

            // 指定某格
            if (row > -1 && column > -1 && diagonal == 0)
            {
                if (Buttons[row, column].Text.Any() == false)
                {
                    Buttons[row, column].Text = "O";
                    Buttons[row, column].BackColor = NewColor;
                    Buttons[row, column].Enabled = false;
                    return true;
                }
                else
                {
                    return false;
                }
            }

            // rows
            if (row == 0 || row == 1 || row == 2)
            {
                for (int j = 0; j <= Buttons.GetUpperBound(1); j++)
                {
                    if (Buttons[row, j].Text.Any() == false)
                    {
                        Buttons[row, j].Text = "O";
                        Buttons[row, j].BackColor = NewColor;
                        Buttons[row, j].Enabled = false;
                        return true;
                    }
                }
            }

            // columns
            if (column == 0 || column == 1 || column == 2)
            {
                for (int i = 0; i <= Buttons.GetUpperBound(0); i++)
                {
                    if (Buttons[i, column].Text.Any() == false)
                    {
                        Buttons[i, column].Text = "O";
                        Buttons[i, column].BackColor = NewColor;
                        Buttons[i, column].Enabled = false;
                        return true;
                    }
                }
            }

            // diagonals
            if (diagonal < 0)
            {
                if (Buttons[0, 0].Text.Any() == false)
                {
                    Buttons[0, 0].Text = "O";
                    Buttons[0, 0].BackColor = NewColor;
                    Buttons[0, 0].Enabled = false;
                    return true;
                }
                if (Buttons[1, 1].Text.Any() == false)
                {
                    Buttons[1, 1].Text = "O";
                    Buttons[1, 1].BackColor = NewColor;
                    Buttons[1, 1].Enabled = false;
                    return true;
                }
                if (Buttons[2, 2].Text.Any() == false)
                {
                    Buttons[2, 2].Text = "O";
                    Buttons[2, 2].BackColor = NewColor;
                    Buttons[2, 2].Enabled = false;
                    return true;
                }
            }

            if (diagonal > 0)
            {
                if (Buttons[0, 2].Text.Any() == false)
                {
                    Buttons[0, 2].Text = "O";
                    Buttons[0, 2].BackColor = NewColor;
                    Buttons[0, 2].Enabled = false;
                    return true;
                }
                if (Buttons[1, 1].Text.Any() == false)
                {
                    Buttons[1, 1].Text = "O";
                    Buttons[1, 1].BackColor = NewColor;
                    Buttons[1, 1].Enabled = false;
                    return true;
                }
                if (Buttons[2, 0].Text.Any() == false)
                {
                    Buttons[2, 0].Text = "O";
                    Buttons[2, 0].BackColor = NewColor;
                    Buttons[2, 0].Enabled = false;
                    return true;
                }
            }

            return false;
        }

        private bool SpecialCases()
        {
            if (Case_TwoOpposingConers()) 
                return true;

            if (Case_SingleCornerSingleEdge())
                return true;

            if (Case_TwoNearEdges())
                return true;

            return false;
        }
        
        private bool Case_TwoOpposingConers()
        {
            // An O in center, two Xs in opposing corners

            if (BoardValue[1, 1] != 100)
                return false;

            if (BoardValue[0, 0] + BoardValue[2, 2] == 2
             || BoardValue[0, 2] + BoardValue[2, 0] == 2)
            {
                if (BoardValue[0, 1] + BoardValue[1, 0]
                  + BoardValue[1, 2] + BoardValue[2, 1] == 0)
                {
                    Random seed = new Random();
                    int caseNumber = seed.Next(1, 5); // [1, 5)
                    switch(caseNumber)
                    {
                        case 1:     if (Place_O_here(row: 0, column: 1)) return true; break;
                        case 2:     if (Place_O_here(row: 1, column: 0)) return true; break;
                        case 3:     if (Place_O_here(row: 1, column: 2)) return true; break;
                        case 4:     if (Place_O_here(row: 2, column: 1)) return true; break;

                        default:    if (Place_O_here(row: 0, column: 1)) return true; break;
                    }
                }
            }

            return false;

            //List<Button> bLst = new List<Button>()
            //{          btn_12,
            //   btn_21,         btn_23,
            //           btn_32
            //};

            //if (btn_22.Text == "O"
            //   && (btn_11.Text == "X" && btn_33.Text == "X"
            //      || btn_13.Text == "X" && btn_31.Text == "X")
            //   && bLst[0].Text.Any() == false
            //   && bLst[1].Text.Any() == false
            //   && bLst[2].Text.Any() == false
            //   && bLst[3].Text.Any() == false
            //   )
            //{
            //    Edges_O();

            //    return true;
            //}
        }

        private bool Case_SingleCornerSingleEdge()
        {
            // An O in center, two Xs, in corner and edge respectively

            //Button[,] bAry = new Button[,]
            //{
            //    { btn_11, btn_12, btn_13 },
            //    { btn_21, btn_22, btn_23 },
            //    { btn_31, btn_32, btn_33 }
            //};

            //int[,] ary = new int[,]
            //{
            //    { 0, 0, 0 },
            //    { 0, 0, 0 },
            //    { 0, 0, 0 }
            //};

            //// "O" = 100, "X" = 1
            //for (int i = 0; i <= bAry.GetUpperBound(0); i++)
            //{
            //    for (int j = 0; j <= bAry.GetUpperBound(1); j++)
            //    {
            //        if (bAry[i, j].Text == "O")
            //        {
            //            ary[i, j] = 100;
            //        }
            //        else if (bAry[i, j].Text == "X")
            //        {
            //            ary[i, j] = 1;
            //        }
            //    }
            //}

            if (BoardValue[1, 1] != 100)
                return false;

            if (BoardValue[0, 1] + BoardValue[1, 0] + BoardValue[1, 2] + BoardValue[2, 1] == 1
             && BoardValue[0, 0] + BoardValue[0, 2] + BoardValue[2, 0] + BoardValue[2, 2] == 1
                )
            {
                // 下在和 edge上的X 同row/column
                // Place_O_here(選擇性參數row/column/diagonal)
                if (BoardValue[0, 1] == 1)
                {
                    if (Place_O_here(row: 0)) return true;
                }
                if (BoardValue[1, 0] == 1)
                {
                    if (Place_O_here(column: 0)) return true;
                }
                if (BoardValue[1, 2] == 1)
                {
                    if (Place_O_here(column: 2)) return true;
                }
                if (BoardValue[2, 1] == 1)
                {
                    if (Place_O_here(row: 2)) return true;
                }
            }

            return false;
        }

        private bool Case_TwoNearEdges()
        {
            // An O in center, two Xs in near corners

            //Button[,] Buttons = new Button[,]
            //{
            //    { btn_11, btn_12, btn_13 },
            //    { btn_21, btn_22, btn_23 },
            //    { btn_31, btn_32, btn_33 }
            //};

            //int[,] ary = new int[,]
            //{
            //    { 0, 0, 0 },
            //    { 0, 0, 0 },
            //    { 0, 0, 0 }
            //};

            //// "O" = 100, "X" = 1
            //for (int i = 0; i <= bAry.GetUpperBound(0); i++)
            //{
            //    for (int j = 0; j <= bAry.GetUpperBound(1); j++)
            //    {
            //        if (bAry[i, j].Text == "O")
            //        {
            //            ary[i, j] = 100;
            //        }
            //        else if (bAry[i, j].Text == "X")
            //        {
            //            ary[i, j] = 1;
            //        }
            //    }
            //}

            if (BoardValue[1, 1] != 100)
                return false;
            
            if (BoardValue[0, 0] + BoardValue[0, 2] + BoardValue[2, 0] == 0
                                && BoardValue[0, 1] + BoardValue[1, 0] == 2)
            {
                if (Place_O_here(row: 0, column: 0)) return true;
            }

            if (BoardValue[0, 2] + BoardValue[0, 0] + BoardValue[2, 2] == 0
                                && BoardValue[0, 1] + BoardValue[1, 2] == 2)
            {
                if (Place_O_here(row: 0, column: 2)) return true;
            }

            if (BoardValue[2, 0] + BoardValue[0, 2] + BoardValue[2, 2] == 0
                                && BoardValue[1, 0] + BoardValue[2, 1] == 2)
            {
                if (Place_O_here(row: 2, column: 0)) return true;
            }

            if (BoardValue[2, 2] + BoardValue[0, 2] + BoardValue[2, 0] == 0
                                && BoardValue[1, 2] + BoardValue[2, 1] == 2)
            {
                if (Place_O_here(row: 2, column: 2)) return true;
            }
            
            return false;
        }

        private bool Center_O()
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

        private bool Corners_O()
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

        private bool Edges_O()
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

        private bool Random_O()
        {
            List<Button> b = new List<Button>()
            {
                btn_11, btn_12, btn_13,
                btn_21, btn_22, btn_23,
                btn_31, btn_32, btn_33
            };

            List<int> DB = new List<int>()
            {
                0,1,2,3,4,5,6,7,8
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
                    b[idx].Text = "O";
                    b[idx].Enabled = false;
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
                if (!CheckIfXWon())
                {
                    Counter();
                    CheckIfOWon();
                }
            }

        }

        private void btn_12_Click(object sender, EventArgs e)
        {
            if (btn_12.Text.Any() == false)
            {
                btn_12.Text = "X";
                btn_12.Enabled = false;
                if (!CheckIfXWon())
                {
                    Counter();
                    CheckIfOWon();
                }
            }
        }

        private void btn_13_Click(object sender, EventArgs e)
        {
            if (btn_13.Text.Any() == false)
            {
                btn_13.Text = "X";
                btn_13.Enabled = false;
                if (!CheckIfXWon())
                {
                    Counter();
                    CheckIfOWon();
                }
            }
        }

        private void btn_21_Click(object sender, EventArgs e)
        {
            if (btn_21.Text.Any() == false)
            {
                btn_21.Text = "X";
                btn_21.Enabled = false;
                if (!CheckIfXWon())
                {
                    Counter();
                    CheckIfOWon();
                }
            }
        }

        private void btn_22_Click(object sender, EventArgs e)
        {
            if (btn_22.Text.Any() == false)
            {
                btn_22.Text = "X";
                btn_22.Enabled = false;
                if (!CheckIfXWon())
                {
                    Counter();
                    CheckIfOWon();
                }
            }
        }

        private void btn_23_Click(object sender, EventArgs e)
        {
            if (btn_23.Text.Any() == false)
            {
                btn_23.Text = "X";
                btn_23.Enabled = false;
                if (!CheckIfXWon())
                {
                    Counter();
                    CheckIfOWon();
                }
            }
        }

        private void btn_31_Click(object sender, EventArgs e)
        {
            if (btn_31.Text.Any() == false)
            {
                btn_31.Text = "X";
                btn_31.Enabled = false;
                if (!CheckIfXWon())
                {
                    Counter();
                    CheckIfOWon();
                }
            }
        }

        private void btn_32_Click(object sender, EventArgs e)
        {
            if (btn_32.Text.Any() == false)
            {
                btn_32.Text = "X";
                btn_32.Enabled = false;
                if (!CheckIfXWon())
                {
                    Counter();
                    CheckIfOWon();
                }
            }
        }

        private void btn_33_Click(object sender, EventArgs e)
        {
            if (btn_33.Text.Any() == false)
            {
                btn_33.Text = "X";
                btn_33.Enabled = false;
                if (!CheckIfXWon())
                {
                    Counter();
                    CheckIfOWon();
                }
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            ResetBoard();
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
                ResetBoard();
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
                ResetBoard();
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
                ResetBoard();
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
                ResetBoard();
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
                ResetBoard();
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
                ResetBoard();
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
                ResetBoard();
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
                ResetBoard();
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
                ResetBoard();
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
                ResetBoard();
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
                ResetBoard();
            }

            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
