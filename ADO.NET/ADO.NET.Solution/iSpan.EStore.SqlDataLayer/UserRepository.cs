﻿using iSpan.EStore.BLL.Core;
using iSpan.EStore.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace iSpan.EStore.SqlDataLayer
{
    public class UserRepository : IUserRepository
    {
        private readonly string _tableName = "Users";
        public Func<SqlConnection> funcConn = SqlDb.GetConnection;
        public Func<SqlDataReader, UserEntity> funcAssembler = GetInstance;

        public static UserEntity GetInstance(SqlDataReader reader)
        {
            var id = reader.GetFieldValue<int>("Id");
            var name = reader.GetFieldValue<string>("Name");
            var account = reader.GetFieldValue<string>("Account");
            var password = reader.GetFieldValue<string>("Password");

            var entity = new UserEntity(name, account, password);
            entity.DateOfBirth = reader.GetFieldValue<DateTime?>("DateOfBirth");
            entity.Height = reader.GetFieldValue<int?>("Height");
            entity.Email = reader.GetFieldValue<string>("Email");

            return entity;
        }


        public int Create(UserEntity entity)
        {
            string sql = $@"
INSERT INTO {_tableName}
(Name, Account, Password, DateOfBirth, Height, 
Email)
VALUES
(@Name, @Account, @Password, @DateOfBirth, @Height, 
@Email)";


            var parameters = SqlParameterBuilder.Create()
                .AddNVarChar("Name", entity.Name, 50)
                .AddNVarChar("Account", entity.Account, 50)
                .AddNVarChar("Password", entity.Password, 50)
                .AddInt("Height", entity.Height)
                .AddDateTime("DateOfBirth", entity.DateOfBirth)
                .AddNVarChar("Email", entity.Email, 256)
                .Build();

            //int newId = SqlDb.Create(funcConn, sql, parameters);

            int newId = 0;
            try
            {
                newId = SqlDb.Create(funcConn, sql, parameters);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("IX_Users"))
                {
                    throw new Exception("您新增的帳號已存在, 請修改後再試一次", ex);
                }
            }
            return newId;
        }

        public int Delete(int userId)
        {
            string sql = $"DELETE FROM {_tableName} WHERE Id = {userId}";
            int rowsAffected = SqlDb.UpdateOrDelete(funcConn, sql);
            return rowsAffected;

            //var sql = $"DELETE FROM {_tableName} WHERE Id = @Id";
            //var parameters = SqlParameterBuilder.Create()
            //    .AddInt("Id", userId)
            //    .Build();

            //int rowsAffected = SqlDb.UpdateOrDelete(funcConn, sql, parameters);
            //return rowsAffected;
        }

        public int Update(UserEntity entity)
        {
            string sql = $@"
UPDATE {_tableName} SET
Name = @Name,
Account = @Account,
Password = @Password,
DateOfBirth = @DateOfBirth,
Height = @Height,
Email = @Email
WHERE Id = {entity.Id}";


            var parameters = SqlParameterBuilder.Create()
                .AddNVarChar("Name", entity.Name, 50)
                .AddNVarChar("Account", entity.Account, 50)
                .AddNVarChar("Password", entity.Password, 50)
                .AddInt("Height", entity.Height)
                .AddDateTime("DateOfBirth", entity.DateOfBirth)
                .AddNVarChar("Email", entity.Email, 256)
                .Build();

            int rowsAffected = SqlDb.UpdateOrDelete(funcConn, sql, parameters);
            return rowsAffected;
        }

        public IEnumerable<UserEntity> Search(string name, string account, string email)
        {
            #region 生成 SQL Statement
            string sql = $@"
SELECT *
FROM {_tableName} ";

            #region 生成 WHERE 子句
            string where = String.Empty;

            var parameters = new List<SqlParameter>();

            if (string.IsNullOrEmpty(name) == false)
            {
                where += $" AND Name LIKE '%' + @Name + '%'";
                parameters.Add(new SqlParameter("Name", System.Data.SqlDbType.NVarChar, 50) { Value = name });
            }
            if (string.IsNullOrEmpty(account) == false)
            {
                where += $" AND Account LIKE '%' + @Account + '%'";
                parameters.Add(new SqlParameter("Account", System.Data.SqlDbType.NVarChar, 50) { Value = account });
            }
            if (string.IsNullOrEmpty(email) == false)
            {
                where += $" AND Email LIKE '%' + @Email + '%'";
                parameters.Add(new SqlParameter("Email", System.Data.SqlDbType.NVarChar, 256) { Value = email });
            }
            //todo bug found
            where = where == String.Empty ? where : where = " WHERE " + where.Substring(5);
            sql += where;
            #endregion
            #endregion

            return SqlDb.Search(funcConn, funcAssembler, sql, parameters.ToArray());
        }

        public UserEntity GetUser(int userId)
        {
            string sql = $"SELECT * FROM {_tableName} WHERE Id = {userId}";

            return SqlDb.Get(funcConn, funcAssembler, sql);
        }

        public UserEntity GetByAccount(string account)
        {
            string sql = $"SELECT * FROM {_tableName} WHERE Account=@Account";


            SqlParameter[] parameters1 = new SqlParameter[]
            {
                new SqlParameter("@Account", System.Data.SqlDbType.NVarChar, 50) { Value = account },
            };


            var parameters2 = SqlParameterBuilder.Create()
                .AddNVarChar("Account", account, 50)
                .Build();


            var parameters3 = new List<SqlParameter>();
            parameters3.Add(new SqlParameter("Account", System.Data.SqlDbType.NVarChar, 50) { Value = account });


            return SqlDb.Get(funcConn, funcAssembler, sql, parameters1);
        }
    }
}
