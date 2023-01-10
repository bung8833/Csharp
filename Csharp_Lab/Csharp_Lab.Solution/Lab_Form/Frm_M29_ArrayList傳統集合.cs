using System;
using System.Collections;
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
    public partial class Frm_M29_ArrayList傳統集合 : Form
    {
        public Frm_M29_ArrayList傳統集合()
        {
            InitializeComponent();
        }

        
        // 在方法外宣告傳統集合
        ArrayList isEmp = new ArrayList();


        void ShowEmployee()
        {
            lbl_Employee.Text = "員工\n";
            
            for (int i = 0; i < isEmp.Count; i++)
            {
                Employee emp = (Employee)isEmp[i]; // 將object轉回struct
                lbl_Employee.Text += $"\n姓名：{emp.Name} 年齡：{emp.Age}";
            }
        }


        private void btn_AddEmployee_Click(object sender, EventArgs e)
        {
            // ArrayList 傳統集合 其元素為原始型態(?) "object"
            
            Employee employee; // Employee為struct，有Name和Age
            employee.Name = txtBox_Name.Text;
            employee.Age = int.Parse(txtBox_Age.Text);

            //ArrayList isEmp = new ArrayList(); // <-- 每次呼叫將重置 應放在方法外
            isEmp.Add(employee); // 從struct轉型成object
            // isEmp.Add(123); // 可以compile 但會出錯

            ShowEmployee(); // 負責轉型回struct
        }
    }
}
