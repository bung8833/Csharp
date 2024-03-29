﻿using ISpan.EStore.BLL.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.EStore.BLL.DTOs
{
	public class UserUpdateDto
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Account { get; set; }
		public DateTime? DateOfBirth { get; set; }
		public int? Height { get; set; }
		public string Email { get; set; }
	}

	public static class UserUpdateDtoExtensions
	{
		public static UserEntity ToEntity(this UserUpdateDto dto, string password)
		{
			return new UserEntity(dto.Name, dto.Account, password)
			{
				Id = dto.Id,
				DateOfBirth = dto.DateOfBirth,
				Height = dto.Height,
				Email = dto.Email
			};
		}
	}
}
