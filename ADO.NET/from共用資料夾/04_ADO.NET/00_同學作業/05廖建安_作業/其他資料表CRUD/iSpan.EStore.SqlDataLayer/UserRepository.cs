using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static iSpan.EStore.SqlDataLayer.ProductRepository;

namespace iSpan.EStore.SqlDataLayer
{
    public class UserRepository
    {
        private readonly string _tableName = "Users";
        public Func<SqlConnection> funcConn = SqlDB.GetConnection;
        public Func<SqlDataReader, UserEntity> funcAssembler = UserEntity.GetInstance;


        public int Create(UserEntity entity)
        {
            string sql = $@"INSERT INTO {_tableName} 
(Name, Account, Password, DateOfBirth, Height, 
Email) 
VALUES 
(@Name, @Account, @Password, @DateOfBirth, @Height, 
@Email)";

            var parameters = SqlParameterBuilder.Create()
                .AddNVarchar("@Name", entity.Name, 50)
                .AddNVarchar("@Account", entity.Account, 50)
                .AddNVarchar("@Password", entity.Password, 50)
                .AddDateTime("@DateOfBirth", entity.DateOfBirth)
                .AddInt("@Height", entity.Height)
                .AddNVarchar("@Email", entity.Email, 256)
                .Build();

            int newId = 0;
            try { newId = SqlDB.Create(funcConn, sql, parameters); }
            catch(SqlException ex)
            {
                if (ex.Message.Contains("IX_Users")) 
                    throw new Exception("輸入了重複的帳號");
            }
            
            return newId;
        }

        public int Delete(int userId)
        {
            var sql = $@"DELETE {_tableName} WHERE Id={userId}";

            int affectedRows = SqlDB.UpdateOrDelete(funcConn, sql);
            return affectedRows;
        }

        public int Update(UserEntity entity)
        {
            string sql = $@"UPDATE {_tableName} SET 
Name=@Name,
Account=@Account,
Password=@Password,
DateOfBirth=@DateOfBirth,
Height=@Height,
Email=@Email
WHERE Id={entity.Id}";

            var parameters = SqlParameterBuilder.Create()
                .AddNVarchar("@Name", entity.Name, 50)
                .AddNVarchar("@Account", entity.Account, 50)
                .AddNVarchar("@Password", entity.Password, 50)
                .AddDateTime("@DateOfBirth", entity.DateOfBirth)
                .AddInt("@Height", entity.Height)
                .AddNVarchar("@Email", entity.Email, 256)
                .Build();

            int affectedRows = SqlDB.UpdateOrDelete(funcConn, sql, parameters);
            return affectedRows;
        }

        public IEnumerable<UserEntity> Search(string name,string account,string email)
        {
            #region 生成 sql statement
            string sql = $@"SELECT * 
FROM {_tableName}";

            #region 生成 WHERE子句
            string where = string.Empty;

            var parameters = new List<SqlParameter>();

            if (!string.IsNullOrEmpty(name))
            {
                where += $" AND Name LIKE '%' + @Name + '%'";
                parameters.Add(new SqlParameter("@Name", System.Data.SqlDbType.NVarChar, 50) { Value = name });
            }
            if (!string.IsNullOrEmpty(account))
            {
                where += $" AND Account = @Account";
                parameters.Add(new SqlParameter("@Account", System.Data.SqlDbType.NVarChar, 50) { Value = account });
            }
            if (!string.IsNullOrEmpty(email))
            {
                where += $" AND Email LIKE '%' + @Email + '%'";
                parameters.Add(new SqlParameter("@Email", System.Data.SqlDbType.NVarChar, 256) { Value = email });
            }

            where = where == string.Empty ? where : " WHERE " + where.Substring(5);
            sql += where;
            #endregion
            sql += $" ORDER BY Id";
            #endregion

            return SqlDB.Search(funcConn, funcAssembler, sql, parameters.ToArray());
        }

        public UserEntity GetUser(int userId)
        {
            string sql = $"SELECT * FROM {_tableName} WHERE Id={userId}";
            return SqlDB.Get(funcConn, funcAssembler, sql);
        }
    }

    public class UserEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int? Height { get; set; }
        public string Email { get; set; }

        public static UserEntity GetInstance(SqlDataReader reader)
        {
            return new UserEntity
            {
                Id = reader.GetFieldValue<int>("Id"),
                Name = reader.GetFieldValue<string>("Name"),
                Account = reader.GetFieldValue<string>("Account"),
                Password = reader.GetFieldValue<string>("Password"),
                DateOfBirth = reader.GetFieldValue<DateTime?>("DateOfBirth"),
                Height = reader.GetFieldValue<int?>("Height"),
                Email = reader.GetFieldValue<string>("Email")
            };
        }
    }
}
