using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iSpan.EStore.WinApp
{
    public partial class FormMain : Form
    {
        private readonly bool isMdi = false;

        public FormMain(bool isMdi)
        {
            InitializeComponent();

            this.isMdi = isMdi;

            if (isMdi) this.IsMdiContainer = true;
        }


        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //undone 進入點為Login時 FormMain_FormClosing要show Login
            //this.Owner.Show();
        }




        ////////// Maintain tables //////////
        ////////// Maintain tables //////////
        ////////// Maintain tables //////////

        private static FormProducts _formProducts;

        /// <summary>
        /// 判斷已開啟的表單中 有沒有指定名稱的表單
        /// </summary>
        /// <param name="formName"></param>
        /// <returns></returns>
        private bool IsClosed(string formName)
        {
            return !Application.OpenForms.Cast<Form>().Any(f => f.Name == formName);
        }

        private void maintainProductsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (_formProducts == null || IsClosed("FormProducts"))
            {
                _formProducts = new FormProducts(null, null);
                if (isMdi) _formProducts.MdiParent = this;
            }
            
            var frm = _formProducts;

            frm.Show();
        }
        
        

        private void maintainNewsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frm = new FormNews();
            if (isMdi) frm.MdiParent = this;
            frm.Show();
        }


        private void maintainCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormCategories();
            if (isMdi) frm.MdiParent = this;
            frm.Show();
        }


        private void maintainUsersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frm = new FormUsers();
            if (isMdi) frm.MdiParent = this;
            frm.Show();
        }




        private void form1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Form1();
            if (isMdi) frm.MdiParent = this;
            frm.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
