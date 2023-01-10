using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ISpan2023.EStore.BLL.Core;
using ISpan2023.EStore.SqlDataLayer;

namespace ISpan2023.EStore.WinApp
{
	public partial class FormEditUser : Form
	{
		private readonly int _userId;

		public FormEditUser(int userId)
		{
			_userId = userId;
			InitializeComponent();

			this.Load += FormEditUser_Load;
		}

		private void FormEditUser_Load(object sender, EventArgs e)
		{
			var entity = new UserRepository().GetUser(this._userId);
			if (entity == null)
			{
				MessageBox.Show("record not found");
				this.DialogResult = DialogResult.Cancel;
				return;
			}

			BindData(entity);
		}

		private void BindData(UserEntity entity)
		{
			textBoxAccount.Text = entity.Account;
			textBoxPassword.Text = entity.Password;
			textBoxName.Text= entity.Name;

			textBoxDateOfBirth.Text = (entity.DateOfBirth.HasValue)
				? entity.DateOfBirth.Value.ToString("yyyy/MM/dd")
				: string.Empty;

			textBoxHeight.Text = (entity.Height.HasValue)
				? entity.Height.Value.ToString()
				: string.Empty;
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			new UserRepository().Update(GetModel());
			NotifyOwner();
		}
		private DateTime? DateOfBirth
			=> DateTime.TryParse(textBoxDateOfBirth.Text, out DateTime dt)
					? dt
					: (DateTime?)null;

		private int? UserHeight
			=> int.TryParse(textBoxHeight.Text, out int height)
					? height
					: (int?)null;

		private UserEntity GetModel()
		 => new UserEntity
		 {
			 Id = this._userId,
			 Account = textBoxAccount.Text,
			 Password = textBoxPassword.Text,
			 Name = textBoxName.Text,
			 Email = textBoxEmail.Text,
			 DateOfBirth = this.DateOfBirth,
			 Height = this.UserHeight
		 };

		private void NotifyOwner()
		{
			IGridContainer container = this.Owner as IGridContainer;
			if (container != null) container.Display();

			this.DialogResult = DialogResult.OK;
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			new UserRepository().Delete(this._userId);
			NotifyOwner();
		}
	}
}
