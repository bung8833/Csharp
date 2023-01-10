using ispan.Estore.SqlData;
using Ispan.Estore.BLL;
using Ispan.Estore.BLL.Core;
using Ispan.Estore.BLL.DTOs;
using Ispan.Estore.BLL.Interfaces;
using ispqn.Estore.WinApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ispqn.Estore.WinApp
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
			txtName.Text = user.Name;
			txtAccount.Text = user.Account;
			txtPassword.Text = user.Password;
			txtEmail.Text = user.Email;
			txtBirth.Text = user.DateOfBirth.HasValue
							? user.DateOfBirth.Value.ToString("yyyy/MM/dd") : String.Empty;
			txtHeight.Text = user.Height.HasValue ? user.Height.Value.ToString() : String.Empty;
		}
		private DateTime? DateOfBirth
			=> DateTime.TryParse(txtBirth.Text, out DateTime dt) ? dt : (DateTime?)null;

		private int? UserHeight
			=> int.TryParse(txtHeight.Text, out int height) ? height : (int?)null;

		//判斷email是否有輸入 空字串視為null
		private string Email
			=> string.IsNullOrEmpty(txtEmail.Text) ? null : txtEmail.Text;
		private UserUpdateVm GetModel()
		   => new UserUpdateVm
		   {
			   Id = this.userId,
			   Name = txtName.Text,
			   Account = txtAccount.Text,
			   Password = txtPassword.Text,
			   DateOfBirth = this.DateOfBirth,
			   Height = this.UserHeight,
			   Email = this.Email,
		   };
		private (bool isValid, List<ValidationResult> errors) Validate(UserUpdateVm vm)
		{
			// 得知要驗證規則
			ValidationContext context = new ValidationContext(vm, null, null);

			// 用來存放錯誤的集合,因為可能有零到多個錯誤
			List<ValidationResult> errors = new List<ValidationResult>();

			// 驗證 model
			bool validateAllProperties = true; // 是否驗證所有規則,而非只驗證Required規則
			bool isValid = Validator.TryValidateObject(vm, context, errors, validateAllProperties);

			return (isValid, errors);
		}

		private void DisplayErrors(List<ValidationResult> errors)
		{
			// 大小寫不同仍視為相同的key
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"Name", txtName},
				{"Account", txtAccount},
				{"Password", txtPassword},
				{"DateOfBirth", txtBirth},
				{"Height", txtHeight},
				{"Email", txtEmail}

			};

			this.errorProvider1.Clear();

			foreach (ValidationResult error in errors)
			{
				string propName = error.MemberNames.FirstOrDefault();
				if (map.TryGetValue(propName, out Control ctrl))
				{
					this.errorProvider1.SetError(ctrl, error.ErrorMessage);
				}
			}
		}

		private void buttonupdate_Click(object sender, EventArgs e)
		{
			var vm = GetModel();

			(bool isValid, List<ValidationResult> errors) validationResult = Validate(vm);

			if (validationResult.isValid == false)
			{
				this.errorProvider1.Clear();
				DisplayErrors(validationResult.errors);
				return;
			}

			var dto = vm.ToUpdateDto();

			IUserRepository repo = new UserRepository();
			UserService service = new UserService(repo);

			try
			{
				service.Update(dto);
			}
			catch(Exception ex)
			{
				MessageBox.Show("更新錯誤 " + ex.Message);
			}
			NotifyOwner();
		}
		private void NotifyOwner()
		{
			IGridContainer container = this.Owner as IGridContainer;
			if (container != null) container.Display();

			this.DialogResult = DialogResult.OK;
		}

		private void buttonDdelete_Click(object sender, EventArgs e)
		{
			new UserRepository().Delete(this.userId);
			NotifyOwner();
		}
	}
}
