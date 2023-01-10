using ISpan.EStore.BLL.Core;
using ISpan.EStore.SqlDataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.EStore.WinApp
{
	public interface IGridContainer
	{
		void Display();
	}

	public partial class FormUsers : Form, IGridContainer
	{
		private UserRepository repo;
		private List<UserEntity> _users;
		public string SName => textBoxName.Text;
		public string SAccount => textBoxAccount.Text;
		public string SEmail => textBoxEmail.Text;

		public FormUsers()
		{
			InitializeComponent();
			repo = new UserRepository();
			this.Load += FormUsers_Load;
		}

		private void FormUsers_Load(object sender, EventArgs e)
		{
			Display();
		}

		/// <summary>
		/// 顯示記錄
		/// </summary>
		/// <exception cref="NotImplementedException"></exception>
		public void Display()
		{
			_users = repo.Search(SName, SAccount, SEmail).ToList();
			dataGridView1.DataSource = _users;
		}

		private void buttonSearch_Click(object sender, EventArgs e)
		{
			Display();
		}

		private void buttonAddNew_Click(object sender, EventArgs e)
		{
			var frm = new FormCreateUser();
			frm.Owner = this;
			frm.ShowDialog();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			//if (e.RowIndex < 0) return;

			//int userId = _users[e.RowIndex].Id;
			//var frm = new FormEditUser(userId);
			//frm.Owner = this;
			//frm.ShowDialog();
		}
	}
}
