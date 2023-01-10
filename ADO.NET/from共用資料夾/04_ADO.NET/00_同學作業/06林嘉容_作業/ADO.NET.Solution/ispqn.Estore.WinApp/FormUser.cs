using ispan.Estore.SqlData;
using Ispan.Estore.BLL.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ispqn.Estore.WinApp
{
	public interface IGridContainer
	{
		void Display();
	}
	public partial class FormUser : Form, IGridContainer
	{
		private UserRepository repo;
		private List<UserEntity> _user;
		//public string Name
		//{
		//	get { return txtName.Text; }
		//}
		public string SName => txtName.Text;
		public string SAccount => txtAccount.Text;
		public string SEmail => txtEmail.Text;

		public FormUser()
		{
			InitializeComponent();
			repo = new UserRepository();
			this.Load += FormUser_Load;
		}

		private void FormUser_Load(object sender, EventArgs e)
		{
			Display();
		}
		/// <summary>
		/// 顯示紀錄
		/// </summary>
		public void Display()
		{
			_user = repo.Search(SName, SAccount, SEmail).ToList();
			dataGridView1.DataSource =_user;
		}

		private void buttonSearch_Click(object sender, EventArgs e)
		{
			Display();
			
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			var frm = new FormCreateUser();
			frm.Owner=this;
			frm.ShowDialog();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;

			int userId = _user[e.RowIndex].Id;

			var frm = new FormEditUser(userId);
			frm.Owner = this;
			frm.ShowDialog();
		}
	}
}
