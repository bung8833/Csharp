using ISpan.EStore.BLL.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.EStore.WinApp.Models.ViewModels
{
	public class UserCreateVm // : IValidatableObject
	{
		public int Id { get; set; }

		[Display(Name="姓名")]
		[Required(ErrorMessage ="{0} 必填")]
		[StringLength(50, ErrorMessage ="{0} 長度不可超過 {1}")]
		public string Name { get; set; }

		[Display(Name = "帳號")]
		[Required(ErrorMessage = "{0} 必填")]
		[StringLength(50, ErrorMessage = "{0} 長度不可超過 {1}")]
		public string Account { get; set; }

		[Display(Name = "密碼")]
		[Required(ErrorMessage = "{0} 必填")]
		[StringLength(50, ErrorMessage = "{0} 長度不可超過 {1}")]
		public string Password { get; set; }

		[Display(Name = "確認密碼")]
		[Required(ErrorMessage = "{0} 必填")]
		[StringLength(50, ErrorMessage = "{0} 長度不可超過 {1}")]
		// [Compare("Password", ErrorMessage ="兩次密碼必需相同")]
		public string ConfirmPassword { get; set; }

		[DataType(DataType.Date, ErrorMessage ="生日必需是合法的日期,例如1900/2/15")]
		public DateTime? DateOfBirth { get; set; }

		[Range(1, 250, ErrorMessage ="身高必需大於零")]
		public int? Height { get; set; }

		[EmailAddress(ErrorMessage ="Email格式有誤")]
		public string Email { get; set; }

		//public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
		//{
		//	if (Password != ConfirmPassword) yield return new ValidationResult("密碼必需相同", new string[] { "ConfirmPassword" });
		//}
	}

	public static class UserCreateVmExtensions
	{
		public static UserCreateDto ToCreateDto(this UserCreateVm source)
		{
			return new UserCreateDto { 
				Id = source.Id,
				Name = source.Name,
				Account = source.Account,
				Password = source.Password,
				Email = source.Email,
				DateOfBirth = source.DateOfBirth,
				Height = source.Height
			};
		}
	}
}
