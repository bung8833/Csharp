using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan2023.EStore.BLL
{
	public class UserService
	{
		private readonly IUserRepository _repo;

		public UserService(IUserRepository repo)
		{
			_repo = repo;
		}

		public int Create(UserDto dto)
		{
			// 驗證account 必需唯一
			var entity = _repo.Search(null, dto.Account, null).FirstOrDefault();
			if (entity != null) throw new Exception("帳號已有人使用, 請修改後再試一次");

			return _repo.Create(dto);
		}
	}
}
