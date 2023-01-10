using Ispan.Estore.BLL.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispan.Estore.BLL.Interfaces
{
	public interface IUserRepository
	{
		int Create(UserEntity entity);
		int Update(UserEntity entity);

		UserEntity GetByAccount(string account);
	}
}
