using iSpan.EStore.BLL.DTOs;
using iSpan.EStore.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSpan.EStore.BLL
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

            // 驗證account是否唯一
            var entityInDb = repo.GetByAccount(entity.Account);
            if (entityInDb != null) throw new Exception("帳號已存在");

            // 若通過 建檔
            return repo.Create(entity);
        }
    }
}
