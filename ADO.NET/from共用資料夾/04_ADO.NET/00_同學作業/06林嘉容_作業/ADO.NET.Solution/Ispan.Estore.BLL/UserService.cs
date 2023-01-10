using Ispan.Estore.BLL.DTOs;
using Ispan.Estore.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispan.Estore.BLL
{
	public class UserService
	{
		public readonly IUserRepository repo;
		
		public UserService(IUserRepository repo)
		{
			this.repo = repo;
		}

		public int Create(UserCreateDto dto)
		{
			var entity = dto.ToEntity();
			//驗證Account是否唯一
			var entityInDb = repo.GetByAccount(entity.Account);
			if (entityInDb != null) throw new Exception("帳號已存在");

			//若通過,建檔
			return repo.Create(entity);
		}

		public int Update(UserUpdateDto dto)
		{
			var entity = dto.ToEntity();

			//驗證Account是否唯一
			var entityInDb = repo.GetByAccount(entity.Account);
			if (entityInDb != null && entityInDb.Id !=entity.Id) throw new Exception("您更新的帳號已存在，請修改後再試一次");

			return repo.Update(entity);

		}
	}
}
