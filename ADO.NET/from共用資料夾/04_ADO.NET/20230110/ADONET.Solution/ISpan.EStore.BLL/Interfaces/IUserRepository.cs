using ISpan.EStore.BLL.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.EStore.BLL.Interfaces
{
	public interface IUserRepository
	{
		int Create(UserEntity entity);

		UserEntity GetByAccount(string account);

		int Update(UserEntity entity);

		UserEntity GetUser(int userId);
	}
}
