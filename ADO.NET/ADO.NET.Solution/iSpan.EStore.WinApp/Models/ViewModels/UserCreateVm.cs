using iSpan.EStore.BLL.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSpan.EStore.WinApp.Models.ViewModels
{
    public class UserCreateVm
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "必填")]
        [StringLength(50, ErrorMessage = "長度不可超過 {1}")]
        public string Name { get; set; }


        [Required(ErrorMessage = "必填")]
        [StringLength(50, ErrorMessage = "長度不可超過 {1}")]
        public string Account { get; set; }


        [Required(ErrorMessage = "必填")]
        [StringLength(50, ErrorMessage = "長度不可超過 {1}")]
        public string Password { get; set; }


        [Required(ErrorMessage = "必填")]
        [StringLength(50, ErrorMessage = "長度不可超過 {1}")]
        [Compare("Password", ErrorMessage = "兩次密碼必須相同")]
        public string ConfirmPassword { get; set; }


        [DataType(DataType.Date, ErrorMessage = "日期格式有誤")]
        public DateTime? DateOfBirth { get; set; } // nullable


        [Range(1, 273, ErrorMessage = "身高必須大於零")]
        public int? Height { get; set; } // nullable


        [EmailAddress(ErrorMessage = "Email格式有誤")]
        public string Email { get; set; }
    }

    public static class UserCreateVmExtensions
    {
        public static UserCreateDto ToCreateDto(this UserCreateVm source)
        {
            return new UserCreateDto
            {
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
