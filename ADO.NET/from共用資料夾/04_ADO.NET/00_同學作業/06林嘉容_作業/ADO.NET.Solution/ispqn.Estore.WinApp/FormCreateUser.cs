﻿using ispan.Estore.SqlData;
using Ispan.Estore.BLL.Interfaces;
using Ispan.Estore.BLL;
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
	public partial class FormCreateUser : Form
	{
		public FormCreateUser()
		{
			InitializeComponent();
		}
		private DateTime? DateOfBirth
			=> DateTime.TryParse(txtBirth.Text, out DateTime dt) ? dt : (DateTime?)null;

		private int? UserHeight
			=> int.TryParse (txtHeight.Text,out int height)? height:(int?)null;

		private string Email
			=> string.IsNullOrEmpty(txtEmail.Text)? null:txtEmail.Text;
		private UserCreateVm GetModel()
		   => new UserCreateVm
		   {
			   Name = txtName.Text,
			   Account =txtAccount.Text,
			   Password =txtPassword.Text,
			   ConfirmPassword = txtconfirm.Text,
			   DateOfBirth =this.DateOfBirth,
			   Height =this.UserHeight,
			   Email = this.Email,
		   };

		private (bool isValid, List<ValidationResult> errors) Validate(UserCreateVm vm)
		{
			// 得知要驗證規則
			ValidationContext context = new ValidationContext(vm, null, null);

			// 用來存放錯誤的集合,因為可能有零到多個錯誤
			List<ValidationResult> errors = new List<ValidationResult>();

			// 驗證 model
			bool validateAllProperties = true; // 是否驗證所有規則,而非只驗證Required規則
			bool isValid = Validator.TryValidateObject(vm, context, errors, validateAllProperties);

			//加上自訂驗證，兩個密碼必須相同
			if(vm.Password != vm.ConfirmPassword)
			{
				errors.Add(new ValidationResult("密碼必須相同", new string[] { "ConfirmPassword" }));
			}

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
				{"ConfirmPassword", txtconfirm},
				{"DateOfBirth", txtBirth},
				{"Height", txtHeight},
				{"Email", txtEmail}

			};

			this.errorProvider1.Clear();

			foreach (ValidationResult error in errors)
			{
				string propName = error.MemberNames.FirstOrDefault();
				if (propName != null && map.TryGetValue(propName, out Control ctrl))
				{
					this.errorProvider1.SetError(ctrl, error.ErrorMessage);
				}
			}
		}
		private void buttonsave_Click(object sender, EventArgs e)
		{
			// 繫結表單控制項到 UserCreateVm
			var vm = GetModel();

			// 針對view model 進行欄位驗證, 如果有錯誤就顯示錯誤訊息
			(bool isValid, List<ValidationResult> errors) validationResult = Validate(vm);

			if (validationResult.isValid == false)
			{
				this.errorProvider1.Clear();
				DisplayErrors(validationResult.errors);
				return;
			}

			// 如果通過驗證,轉型為UserCreateDto
			var dto = vm.ToCreateDto();

			// 傳給 UserService
			IUserRepository repo = new UserRepository();
			UserService service = new UserService(repo);

			try
			{
				service.Create(dto);
			}
			catch(Exception ex)
			{
				MessageBox.Show("新增失敗喔!!!" + ex.Message);
			}
			

			IGridContainer container = this.Owner as IGridContainer;
			if (container != null) container.Display();

			this.DialogResult = DialogResult.OK;
		}
	}
}
