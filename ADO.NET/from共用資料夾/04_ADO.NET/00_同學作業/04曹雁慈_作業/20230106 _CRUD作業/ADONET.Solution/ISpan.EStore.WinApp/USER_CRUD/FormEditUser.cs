using ISpan.EStore.SqlDataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.EStore.WinApp
{
	public partial class FormEditUser : Form
	{
		private readonly int userId;

		public FormEditUser(int userId)
		{
			InitializeComponent();
			this.userId = userId;
			this.Load += FormEditUser_Load;
		}

		private void FormEditUser_Load(object sender, EventArgs e)
		{
			var user = new UserRepository().GetUser(userId);
			BindForm(user);
		}

		private void BindForm(UserEntity user)
		{
			textBoxAccount.Text = user.Account;
			textBoxName.Text = user.Name;
			textBoxPassword.Text = user.Password;
			textBoxEmail.Text = user.Email;
			textBoxDateOfBirth.Text = user.DateOfBirth.HasValue 
										? user.DateOfBirth.Value.ToString("yyyy/MM/dd") 
										: String.Empty;
			textBoxHeight.Text = user.Height.HasValue ? user.Height.Value.ToString() : String.Empty;
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
			 Id = this.userId,
			 Account = textBoxAccount.Text,
			 Password = textBoxPassword.Text,
			 Name = textBoxName.Text,
			 Email = textBoxEmail.Text,
			 DateOfBirth = this.DateOfBirth,
			 Height = this.UserHeight
		 };
				
		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			var model = GetModel();
			new UserRepository().Update(model);
			NotifyOwner();
		}

		private void NotifyOwner()
		{
			IGridContainer container = this.Owner as IGridContainer;
			if (container != null) container.Display();

			this.DialogResult = DialogResult.OK;
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			new UserRepository().Delete(this.userId);
			NotifyOwner();
		}
	}
}
