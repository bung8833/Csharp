using Ispan.Estore.BLL.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispan.Estore.BLL.DTOs
{
	public class UserCreateDto
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Account { get; set; }
		public string Password { get; set; }
		public DateTime? DateOfBirth { get; set; }
		public int? Height { get; set; }
		public string Email { get; set; }
	}

	public static class UserCreateDtoExtensions
	{
		public static UserEntity ToEntity(this UserCreateDto dto)
		{
			return new UserEntity(dto.Name, dto.Account, dto.Password) //必填
			{
				DateOfBirth = dto.DateOfBirth,   //非必填
				Height = dto.Height,
				Email = dto.Email
			};
		}
	}
}
