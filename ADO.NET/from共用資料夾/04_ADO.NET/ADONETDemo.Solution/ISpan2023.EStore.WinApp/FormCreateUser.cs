using ISpan2023.EStore.SqlDataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ISpan2023.EStore.BLL;
using ISpan2023.EStore.WinApp.Models.ViewModels;

namespace ISpan2023.EStore.WinApp
{
	public partial class FormCreateUser : Form
	{
		public FormCreateUser()
		{
			InitializeComponent();
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			var vm = new UserVm
			{
				Name = textBoxName.Text,
				Account = textBoxAccount.Text,
				Password = textBoxPassword.Text,
				ConfirmPassword = textBoxConfirmPassword.Text,
				DateOfBirth = string.IsNullOrEmpty(textBoxDateOfBirth.Text) ? (DateTime?)null : DateTime.Parse(textBoxDateOfBirth.Text),
				Height = string.IsNullOrEmpty(textBoxHeight.Text) ? (int?)null : int.Parse(textBoxHeight.Text),
				Email = textBoxEmail.Text
			};

			// todo 欄位驗證

			// 若通過,轉型為 UserDto,傳給UserService
			var dto = vm.ToDto();
			try
			{
				var rowsAffected = new UserService(new UserRepository()).Create(dto);
			}
			catch (Exception ex)
			{
				MessageBox.Show("新增失敗, 原因: " + ex.Message);
				return;
			}

			IGridContainer container = this.Owner as IGridContainer;
			container.Display();

			this.DialogResult = DialogResult.OK;
		}
	}
}
