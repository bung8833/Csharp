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
    public partial class Frm_M26_Array : Form //M26繼承Form
    {
        public Frm_M26_Array()
        {
            InitializeComponent();
        }

        private void btn_Array_Click(object sender, EventArgs e)
        {
            //int[] ary = new int[3] { 1, 2, 100 };
            //int[] ary = { 1, 2, 100 };
            twoDimArray();
        }

        private void twoDimArray()
        {
            int[,] ary2 = new int[,] 
            {
                { 1, 2, 3,  4,  5,  6, },
                { 7, 8, 9, 10, 11, 12, }
            };

            String Result = "";
            for (int i = 0; i < ary2.GetLength(0); i++)
            {
                for (int j = 0; j < ary2.GetLength(1); j++)
                {
                    Result += $"ary2[ {i}, {j} ] = {ary2[i, j]}\n";
                }
            }

            MessageBox.Show(Result);
        }

        private void btn_RetArray_Click(object sender, EventArgs e)
        {
            int[] NewArray = CreateArray(5);

            string Result = "";
            for (int i = 0; i < NewArray.Length; i++)
            {
                Result += NewArray[i] + "\n";
            }

            MessageBox.Show(Result);
        }

        int[] CreateArray(int length)
        {
            int[] ary = new int[length];

            for (int i = 0; i < ary.Length; i++)
            {
                ary[i] = i*i;
            }

            return ary;
        }

        private void btn_Swap_Click(object sender, EventArgs e)
        {
            int x = 100, y = 200;
            MessageBox.Show($"x: {x} y: {y}");
            Swap(ref x, ref y);
            MessageBox.Show($"x: {x} y: {y}");

            string P = "Penguin", Q = "Queen";
            MessageBox.Show($"P: {P} Q: {Q}");
            Swap(ref P, ref Q);
            MessageBox.Show($"P: {P} Q: {Q}");
        }

        // Overloading
        void Swap(ref int A, ref int B)
        {
            int tmp = A;
            A = B;
            B = tmp;
        }

        void Swap(ref string A, ref string B)
        {
            string tmp = A;
            A = B;
            B = tmp;
        }

        // Generic
        private void btn_GenericSwap_Click(object sender, EventArgs e)
        {
            string P = "Penguin", Q = "Queen";
            MessageBox.Show($"P: {P} Q: {Q}");

            MyGenericSwap<string>(ref P, ref Q);
            //MyGenericSwap(ref P, ref Q);

            MessageBox.Show($"P: {P} Q: {Q}");
        }

        void MyGenericSwap<Type>(ref Type A, ref Type B)
        {
            Type tmp = A;
            A = B;
            B = tmp;
        }
    }
}
