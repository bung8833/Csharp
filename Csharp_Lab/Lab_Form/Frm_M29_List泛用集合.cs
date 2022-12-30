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
    public partial class Frm_M29_List泛用集合 : Form
    {
        public Frm_M29_List泛用集合()
        {
            InitializeComponent();
        }


        List<Employee> isEmp = new List<Employee>();


        void ShowEmployee()
        {
            lbl_Employee.Text = "員工\n";

            //for (int i = 0; i < isEmp.Count; i++)
            //{
            //    Employee emp = isEmp[i]; // 不須轉型
            //    lbl_Employee.Text += $"\n姓名：{emp.Name} 年齡：{emp.Age}";
            //}

            // foreach loop 好處為不會產生超出索引範圍的錯誤
            foreach (Employee e in isEmp)
            {
                lbl_Employee.Text += $"\n姓名：{e.Name} 年齡：{e.Age}";
            }
        }


        private void btn_AddEmployee_Click(object sender, EventArgs e)
        {
            Employee employee; // Employee為struct，有Name和Age
            employee.Name = txtBox_Name.Text;
            employee.Age = int.Parse(txtBox_Age.Text);

            isEmp.Add(employee);
            //isEmp.Add(123); // 泛用集合無法存我們指定的Employee以外的資料

            ShowEmployee();
        }
    }
}
