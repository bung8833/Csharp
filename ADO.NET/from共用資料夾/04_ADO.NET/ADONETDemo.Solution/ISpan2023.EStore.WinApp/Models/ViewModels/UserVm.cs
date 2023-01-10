using ISpan2023.EStore.BLL;
using System;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace ISpan2023.EStore.WinApp.Models.ViewModels
{
	public class UserVm
	{
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]
		public string Account { get; set; }

		[Required]
		public string Password { get; set; }

		[Compare("Password", ErrorMessage = "兩次密碼必需相同")]
		public string ConfirmPassword { get; set; }

		public DateTime? DateOfBirth { get; set; }
		public int? Height { get; set; }

		[EmailAddress]
		public string Email { get; set; }
	}

	public static class UserVmExtensions
	{
		public static UserDto ToDto(this UserVm source)
		{
			return new UserDto
			{
				Id = source.Id,
				Name = source.Name,
				Account = source.Account,
				Password = source.Password,
				DateOfBirth = source.DateOfBirth,
				Height = source.Height,
				Email = source.Email
			};
		}
	}
}