using System.Data.SqlClient;
using System;

namespace ISpan2023.EStore.BLL.Core
{
	public class UserEntity
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Account { get; set; }
		public string Password { get; set; }
		public DateTime? DateOfBirth { get; set; }
		public int? Height { get; set; }
		public string Email { get; set; }


	}
}