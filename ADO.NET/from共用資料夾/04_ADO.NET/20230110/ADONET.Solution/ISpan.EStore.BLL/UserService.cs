using ISpan.EStore.BLL.Core;
using ISpan.EStore.BLL.DTOs;
using ISpan.EStore.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.EStore.BLL
{
	public class UserService
	{
		private readonly IUserRepository repo;

		public UserService(IUserRepository repo)
		{
			this.repo = repo;
		}

		public int Create(UserCreateDto dto)
		{
			var entity = dto.ToEntity();

			// 驗證Account 是否唯一
			var entityInDb = repo.GetByAccount(entity.Account);
			if (entityInDb != null) throw new Exception("帳號已存在");

			// 若通過,建檔
			return repo.Create(entity);
		}

		public int Update(UserUpdateDto dto)
		{
			var currentUser = repo.GetUser(dto.Id);

			var entity = dto.ToEntity(currentUser.Password);
			
			//驗證Account是否唯一
			var entityInDb = repo.GetByAccount(entity.Account);
			if (entityInDb != null && entityInDb.Id != entity.Id) throw new Exception("您更新的帳號已存在，請修改後再試一次");

			return repo.Update(entity);

		}

		public UserUpdateDto GetUser(int userId)
		{
			var entity = repo.GetUser(userId);
			return entity.ToDto();
		}
	}
}
