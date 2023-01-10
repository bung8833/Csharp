using iSpan.EStore.SqlDataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iSpan.EStore.WinApp
{
    public partial class FrmUsers : Form, IGridContainer
    {
        private UserRepository repo;
        public string sName => txtName.Text;
        public string sAccount => txtAccount.Text;
        public string sEmail => txtEmail.Text;
        private List<UserEntity> _user;

        public FrmUsers()
        {
            InitializeComponent();
            repo = new UserRepository();
            this.Load += FrmEditUser_Load;
        }

        private void FrmEditUser_Load(object sender, EventArgs e)
        {
            Display();
        }

        public void Display()
        {
            _user = repo.Search(sName, sAccount, sEmail).ToList();
            dataGridViewUser.DataSource = _user;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            var frm = new FrmAddNewUser();
            frm.Owner = this;
            frm.ShowDialog();

            //if (frm.DialogResult == DialogResult.OK) Display();
        }

        private void dataGridViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int userId=_user[e.RowIndex].Id;
            var frm = new FrmEditUser(userId);
            frm.Owner = this;
            frm.ShowDialog();
        }
    }
}
