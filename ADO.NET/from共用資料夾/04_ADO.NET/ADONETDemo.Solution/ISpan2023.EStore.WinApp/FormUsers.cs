using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ISpan2023.EStore.BLL.Core;
using ISpan2023.EStore.SqlDataLayer;

namespace ISpan2023.EStore.WinApp
{
	public partial class FormUsers : Form, IGridContainer
	{
		public FormUsers()
		{
			InitializeComponent();

			this.dataGridView1.AllowUserToAddRows = dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ReadOnly = true;

			this.Load += FormUsers_Load;
			this.dataGridView1.CellClick += DataGridView1_CellClick;
		}
		private void FormUsers_Load(object sender, EventArgs e)
		{
			Display();
		}
		public void Display()
		{
			var sql = "SELECT * FROM Users";
			SqlParameter[] parameters = Array.Empty<SqlParameter>();

			if (string.IsNullOrEmpty(textBoxAccount.Text) == false)
			{
				sql += " WHERE Account LIKE N'%' + @Account + '%'";
				parameters = SqlParameterBuilder.Create()
					.AddNVarchar("Account", 50, textBoxAccount.Text)
					.Build();
			}

			this._users = new UserRepository().Search(UserRepository._funcAssembler, sql, parameters).ToList();

			dataGridView1.DataSource = _users;

		}

		private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;

			int userId = _users[e.RowIndex].Id;
			var frm = new FormEditUser(userId);
			frm.Owner = this;
			frm.ShowDialog();
		}
		private void buttonAddNew_Click(object sender, EventArgs e)
		{
			var frm = new FormCreateUser();
			frm.Owner = this;
			frm.ShowDialog();
		}


		private void buttonSearch_Click(object sender, EventArgs e)
		{
			Display();
		}

		private List<UserEntity> _users;


	}

	public interface IGridContainer
	{
		void Display();
	}
}
