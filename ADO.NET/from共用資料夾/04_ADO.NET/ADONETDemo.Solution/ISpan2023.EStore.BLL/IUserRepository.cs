using System.Collections.Generic;
using System.Data.SqlClient;
using System;
using ISpan2023.EStore.BLL.Core;

namespace ISpan2023.EStore.BLL
{
	public interface IUserRepository
	{
		int Create(UserDto dto);

		IEnumerable<UserEntity> Search(string name, string account, string email);
	}
}