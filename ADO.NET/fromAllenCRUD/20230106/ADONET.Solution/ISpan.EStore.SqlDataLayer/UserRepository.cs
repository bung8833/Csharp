﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ISpan.EStore.SqlDataLayer
{
	public class UserRepository
	{
		private readonly string _tableName = "Users";
		public Func<SqlConnection> funcConn = SqlDb.GetConnection;
		public Func<SqlDataReader, UserEntity> funcAssembler = UserEntity.GetInstance;

		public int Create(UserEntity entity) {
			string sql = $@"INSERT INTO {_tableName}
(Name,Account, Password, DateOfBirth, Height, Email)
VALUES
(@Name,@Account, @Password, @DateOfBirth, @Height, @Email)";

			var parameters = SqlParameterBuilder.Create()
				.AddNVarchar("Name", entity.Name, 50)
				.AddNVarchar("Account", entity.Account, 50)
				.AddNVarchar("Password", entity.Password, 50)
				.AddInt("Height", entity.Height)
				.AddDateTime("DateOfBirth", entity.DateOfBirth)
				.AddNVarchar("Email", entity.Email, 256)
				.Build();

			int newId = 0;
			try
			{
				newId = SqlDb.Create(funcConn, sql, parameters);
				
			}catch(SqlException ex)
			{
				if (ex.Message.Contains("IX_Users"))
				{
					throw new Exception("您新增的帳號已存在, 請修改之後再試一次", ex);
				}
			}
			return newId;
		}

		public int Delete(int userId)
		{
			//var sql = $"DELETE FROM {_tableName} WHERE Id={userId}";
			//int rowsAffected = SqlDb.UpdateOrDelete(funcConn, sql);
			//return rowsAffected;

			var sql = $"DELETE FROM {_tableName} WHERE Id=@Id";
			var parameters = SqlParameterBuilder.Create()
				.AddInt("Id", userId)
				.Build();

			return SqlDb.UpdateOrDelete(funcConn, sql, parameters);
		}

		public int Update(UserEntity entity)
		{
			var sql = $@"UPDATE {_tableName} SET
Name=@Name,
Account = @Account,
Password = @Password,
DateOfBirth = @DateOfBirth,
Height = @Height,
Email=@Email
WHERE Id={entity.Id}";

			var parameters = SqlParameterBuilder.Create()
					.AddNVarchar("Name", entity.Name, 50)
					.AddNVarchar("Account", entity.Account, 50)
					.AddNVarchar("Password", entity.Password, 50)
					.AddInt("Height", entity.Height)
					.AddDateTime("DateOfBirth", entity.DateOfBirth)
					.AddNVarchar("Email", entity.Email, 256)
					.Build();

			int rowsAffected = SqlDb.UpdateOrDelete(funcConn, sql, parameters);
			return rowsAffected;
		}

		public IEnumerable<UserEntity> Search(string name, string account, string email)
		{
			#region 生成 sql statement
			string sql = $@"SELECT *
FROM {_tableName}";

			#region 生成where子句
			string where = string.Empty;

			var parameters = new List<SqlParameter>();

			if (string.IsNullOrEmpty(name)==false)
			{
				where += $" AND Name LIKE '%' + @Name + '%'";
				parameters.Add(new SqlParameter("@Name", System.Data.SqlDbType.NVarChar, 50) { Value = name });
			}
			if (string.IsNullOrEmpty(account) == false)
			{
				where += $" AND Account= @Account";
				parameters.Add(new SqlParameter("@Account", System.Data.SqlDbType.NVarChar, 50) { Value = account });
			}
			if (string.IsNullOrEmpty(email) == false)
			{
				where += $" AND Email LIKE '%' + @Email + '%'";
				parameters.Add(new SqlParameter("@Email", System.Data.SqlDbType.NVarChar, 256) { Value = email });
			}

			where = where == string.Empty ? where : where = " WHERE " + where.Substring(5);
			sql += where;

			#endregion
			#endregion
			return SqlDb.Search(funcConn, funcAssembler, sql, parameters.ToArray());
		}

		public UserEntity GetUser(int userId)
		{
			string sql = $"SELECT * FROM {_tableName} WHERE Id={userId}";
			
			return SqlDb.Get(funcConn, funcAssembler, sql);
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
			var entity = new UserEntity();
			entity.Id = reader.GetFieldValue<int>("Id");
			entity.Name = reader.GetFieldValue<string>("Name");
			entity.Account = reader.GetFieldValue<string>("Account");
			entity.Password = reader.GetFieldValue<string>("Password");
			entity.DateOfBirth = reader.GetFieldValue<DateTime?>("DateOfBirth");
			entity.Height = reader.GetFieldValue<int?>("Height");
			entity.Email = reader.GetFieldValue<string>("Email");

			return entity;
		}
	}

	
}