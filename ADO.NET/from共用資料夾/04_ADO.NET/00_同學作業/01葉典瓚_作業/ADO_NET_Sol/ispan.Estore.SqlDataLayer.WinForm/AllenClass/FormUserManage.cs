using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ispan.Estore.SqlDataLayer.WinForm
{
    public interface IGridContainer {
        void Display();
        
    }
    public partial class FormUserManage : Form, IGridContainer
    {
        public FormUserManage()
        {
            InitializeComponent();
            repo = new UserRepository();
            this.Load += FormUserManage_Load;
        }
        private UserRepository repo;
        private List<UserEntity> _users;
        public string SName => textBoxName.Text;
        public string SAccount => textBoxAccount.Text;
        public string SEmail => textBoxEmail.Text;



        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void FormUserManage_Load(object sender, EventArgs e)
        {
            Display();
        }

        public void Display()
        {
            _users = repo.Search(SName, SAccount, SEmail).ToList();
            dataGridViewUser.DataSource = _users;

        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            var frm = new FormCreateUser();
            frm.Owner = this;
            frm.ShowDialog();

        }

        private void dataGridViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int userId = _users[e.RowIndex].Id;
            var frm = new FormEditUser(userId);
            frm.Owner = this;
            frm.ShowDialog();
        }
    }
}
