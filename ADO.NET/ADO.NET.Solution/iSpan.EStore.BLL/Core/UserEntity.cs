using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSpan.EStore.BLL.Core
{

    /// <summary>
    /// 為三層式架構中BLL層 其中的重心
    /// </summary>
    public class UserEntity
    {
        public int Id { get; set; }
        public string Name { get; }
        public string Account { get; }
        public string Password { get; }
        public DateTime? DateOfBirth { get; set; } // nullable
        public int? Height { get; set; } // nullable
        public string Email { get; set; }

        /// <summary>
        /// 建構函式 要傳入必填欄位
        /// 要確保Entity必填欄位不會是null值
        /// </summary>
        /// <param name="name"></param>
        /// <param name="account"></param>
        /// <param name="password"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public UserEntity(string name, string account, string password)
        {
            //pre conditions
            if (String.IsNullOrEmpty(name)) 
                throw new ArgumentNullException(nameof(name));
            if (String.IsNullOrEmpty(account)) 
                throw new ArgumentNullException(nameof(account));
            if (String.IsNullOrEmpty(password)) 
                throw new ArgumentNullException(nameof(password));

            this.Name = name;
            this.Account = account;
            this.Password = password;
        }
    }
}
