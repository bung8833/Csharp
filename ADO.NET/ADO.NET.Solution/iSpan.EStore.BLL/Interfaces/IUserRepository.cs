using iSpan.EStore.BLL.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSpan.EStore.BLL.Interfaces
{
    public interface IUserRepository
    {
        // Create 和 GetByAccount 在UserRepo中實作

        int Create(UserEntity entity);

        UserEntity GetByAccount(string account);
    }
}
