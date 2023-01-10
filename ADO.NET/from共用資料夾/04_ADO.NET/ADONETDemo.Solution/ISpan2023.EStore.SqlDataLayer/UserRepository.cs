using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using ISpan2023.EStore.BLL;
using ISpan2023.EStore.BLL.Core;
using ISpan2023.EStore.SqlDataLayer.Extensions;

namespace ISpan2023.EStore.SqlDataLayer
{
	public class UserRepository : IUserRepository
	{
		public static Func<SqlConnection> _funcConn = () => SqlDb.GetConnection("default");
		public static Func<SqlDataReader, UserEntity> _funcAssembler = UserEntityExtensions.GetInstance;
		private const string TableName = "Users";

		public int Create(UserDto entity)
		{
			string sql = $@"INSERT INTO {TableName}
(Name,Account, Password, DateOfBirth, Height,Email)
VALUES
(@Name,@Account, @Password, @DateOfBirth, @Height, @Email)";

			var parameters = SqlParameterBuilder.Create()
				.AddNVarchar("Name", 50, entity.Name)
				.AddNVarchar("Account", 50, entity.Account)
				.AddNVarchar("Password", 50, entity.Password)
				.AddInt("Height", entity.Height)
				.AddDateTime("DateOfBirth", entity.DateOfBirth)
				.AddNVarchar("Email", 256, entity.Email)
				.Build();

			int newId = SqlDb.Create(_funcConn, sql, parameters);
			return newId;
		}

		public int Delete(int userId)
		{
			//var sql = $"DELETE FROM {_tableName} WHERE Id={userId}";
			//int rowsAffected = SqlDb.UpdateOrDelete(funcConn, sql);
			//return rowsAffected;

			var sql = $"DELETE FROM {TableName} WHERE Id=@Id";
			var parameters = SqlParameterBuilder.Create()
				.AddInt("Id", userId)
				.Build();

			return SqlDb.UpdateOrDelete(_funcConn, sql, parameters);
		}

		public int Update(UserEntity entity)
		{
			var sql = $@"UPDATE {TableName} SET
Name=@Name,
Account = @Account,
Password = @Password,
DateOfBirth = @DateOfBirth,
Height = @Height,
Email=@Email
WHERE Id={entity.Id}";

			var parameters = SqlParameterBuilder.Create()
					.AddNVarchar("Name", 50, entity.Name)
					.AddNVarchar("Account", 50, entity.Account)
					.AddNVarchar("Password", 50, entity.Password)
					.AddInt("Height", entity.Height)
					.AddDateTime("DateOfBirth", entity.DateOfBirth)
					.AddNVarchar("Email", 256, entity.Email)
					.Build();

			int rowsAffected = SqlDb.UpdateOrDelete(_funcConn, sql, parameters);
			return rowsAffected;
		}

		public IEnumerable<T> Search<T>(Func<SqlDataReader, T> funcAssembler, string sql,
			params SqlParameter[] parameters)
		=> SqlDb.Search(_funcConn, funcAssembler, sql, parameters);

		public IEnumerable<UserEntity> Search(string sql,
			params SqlParameter[] parameters)
			=> SqlDb.Search(_funcConn, _funcAssembler, sql, parameters);

		public IEnumerable<UserEntity> Search(string name, string account, string email)
		{
			#region 生成 sql statement
			string sql = $@"SELECT *
FROM {TableName}";

			#region 生成where子句
			string where = string.Empty;

			var parameters = new List<SqlParameter>();

			if (string.IsNullOrEmpty(name) == false)
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
			return SqlDb.Search(_funcConn, _funcAssembler, sql, parameters.ToArray());
		}

		public UserEntity GetUser(int userId)
		{
			string sql = $"SELECT * FROM {TableName} WHERE Id={userId}";

			return SqlDb.Get(_funcConn, _funcAssembler, sql);
		}

		public T Get<T>(Func<SqlDataReader, T> funcAssembler, string sql, params SqlParameter[] parameters)
		{
			return SqlDb.Get(_funcConn, funcAssembler, sql, parameters);
		}
	}


}