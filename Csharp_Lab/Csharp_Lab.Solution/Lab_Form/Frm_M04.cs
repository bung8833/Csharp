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
    public partial class Frm_M04 : Form
    {
        //
        // Also see Frm_M04.Designer.cs
        // This file defines Class Initialazer, events, and methods.
        //
        public Frm_M04()
        {
            InitializeComponent();
        }

        private void btn_OpenHelloForm_Click(object sender, EventArgs e)
        {
            Frm_HelloForm frm_Hello04 = new Frm_HelloForm();
            frm_Hello04.Show();
        }

        private void btn_Method_Click(object sender, EventArgs e)
        {
            FirstMethod();
        }

        void FirstMethod()
        {
            string Msg = "This is our first method.";
            MessageBox.Show(Msg);
            return;
        }

        private void btn_birth_Click(object sender, EventArgs e)
        {
            string birthYear = birthYear_msg(26);
            MessageBox.Show(birthYear);
        }

        string birthYear_msg(int age)
        {
            int birth_year = DateTime.Now.Year - age;
            string msg = "Your birth year is " + birth_year;
            return msg;
        }

        private void btn_MyClass_Click(object sender, EventArgs e)
        {
            MyClass Class_demo = new MyClass();
            Class_demo.Method03();
            Class_demo.Method04();
            //demo_class.Method01();
            //demo_class.Method02();
        }

        private void btn_Encap_Click(object sender, EventArgs e)
        {
            MyClass Class_demo = new MyClass();
            Class_demo.Method05();
            // Encapsulation
        }

        private void btn_Partial_Click(object sender, EventArgs e)
        {
            MyClass Class_demo = new MyClass();
            Class_demo.Method06();
            // Partial class
        }

        private void btn_NewMember_Click(object sender, EventArgs e)
        {
            Member mbr1 = new Member();
            mbr1.Name = "John";
            mbr1.Age = 40;
            mbr1.Nickname = "Johnny"; // internal variable

            MessageBox.Show("Name: " + mbr1.Name);
            MessageBox.Show("Age: " + mbr1.Age);
            MessageBox.Show("Nickname: " + mbr1.Nickname);

            Member mbr2 = new Member
            {
                Name = "Richard",
                Age = 26
            };

            MessageBox.Show("Name: " + mbr2.Name + ", Age = " + mbr2.Age);
            
        }
    }
}
