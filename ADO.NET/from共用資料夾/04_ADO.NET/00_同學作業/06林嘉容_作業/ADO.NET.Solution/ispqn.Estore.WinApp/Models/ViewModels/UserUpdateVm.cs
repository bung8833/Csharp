using Ispan.Estore.BLL.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ispqn.Estore.WinApp.Models.ViewModels
{
	public class UserUpdateVm
	{
		public int Id { get; set; }

		[Display(Name = "姓名")]
		[Required(ErrorMessage = "{0}必填")] //必填一定要寫
		[StringLength(50, ErrorMessage = "{0}長度不可超過{1}")]
		public string Name { get; set; }

		[Display(Name = "帳號")]
		[Required(ErrorMessage = "{0}必填")]
		[StringLength(50, ErrorMessage = "{0}長度不可超過{1}")]
		public string Account { get; set; }

		[Display(Name = "密碼")]
		[Required(ErrorMessage = "{0}必填")]
		[StringLength(50, ErrorMessage = "{0}長度不可超過{1}")]
		public string Password { get; set; }

		
		[DataType(DataType.Date, ErrorMessage = "生日必須是合法日期，例如1990/01/09")]
		public DateTime? DateOfBirth { get; set; }

		[Range(1, int.MaxValue, ErrorMessage = "身高必須大於零")]
		public int? Height { get; set; }

		[EmailAddress(ErrorMessage = "Eamil格式有誤")]
		public string Email { get; set; }
	}

	public static class UserUpdateVmExtensions
	{
		public static UserUpdateDto ToUpdateDto(this UserUpdateVm source)
		{
			return new UserUpdateDto
			{
				Id = source.Id,
				Name = source.Name,
				Account = source.Account,
				Password = source.Password,
				Email = source.Email,
				DateOfBirth = source.DateOfBirth,
				Height = source.Height,
			};
		}
	}
}
