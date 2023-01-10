using Ispan.Estore.BLL.Core;
using Ispan.Estore.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ispan.Estore.SqlData
{
	public class UserRepository:IUserRepository
	{
		private readonly string _tableName = "Users";
		private Func<SqlConnection> funConnection = SQLDb.GetConnection;
		public Func<SqlDataReader, UserEntity> funcAssembler = GetInstance;


		public static UserEntity GetInstance(SqlDataReader reader)
		{
			//從原本的UserEntity移到UserRepository
			var id = reader.GetFieldValue<int>("Id");
			var name = reader.GetFieldValue<string>("Name");
			var account = reader.GetFieldValue<string>("Account");
			var password = reader.GetFieldValue<string>("Password");

			var entity = new UserEntity(name,account,password);
			entity.Id = id;
			entity.DateOfBirth = reader.GetFieldValue<DateTime?>("DateOfBirth");
			entity.Height = reader.GetFieldValue<int?>("Height");
			entity.Email = reader.GetFieldValue<string>("Email");

			return entity;
		}

		public int Create(UserEntity entity)
		{
			string sql = $@"
INSERT INTO {_tableName}
(Name, Account , Password, DateOfBirth, Height, Email)
VALUES
(@Name, @Account , @Password, @DateOfBirth, @Height, @Email);";

			var parameters = SqlParameterBuilder.Create()
				.AddNVarChar("@Name", entity.Name, 50)
				.AddNVarChar("@Account", entity.Account, 50)
				.AddNVarChar("@Password", entity.Password, 50)
				.AddDateTime("@DateOfBirth", entity.DateOfBirth)
				.AddInt("@Height", entity.Height)
				.AddNVarChar("@Email", entity.Email, 256)
				.Build();

			return SQLDb.Create(funConnection, sql, parameters);
		}

		public int Delete(int userId)
		{
			string sql = $@"DELETE FROM {_tableName} WHERE Id ={userId}";

			return SQLDb.UpdateOrDelete(funConnection, sql);

			//string sql = $@"DELETE FROM {_tableName} WHERE ID =@Id";

			//var parameters = SqlParameterBuilder.Create()
			//	.AddInt("@Id", userId)
			//	.Build();
			//return SQLDb.UpdateOrDelete(funConnection, sql, parameters );
		}

		public int Update(UserEntity entity)
		{
			string sql = $@"
UPDATE {_tableName}
SET Name = @Name, Account = @Account, Password = @Password, DateOfBirth = @DateOfBirth, Height = @Height, Email = @Email
WHERE Id ={entity.Id};";

			var parameters = SqlParameterBuilder.Create()
				.AddNVarChar("@Name", entity.Name, 50)
				.AddNVarChar("@Account", entity.Account, 50)
				.AddNVarChar("@Password", entity.Password, 50)
				.AddDateTime("@DateOfBirth", entity.DateOfBirth)
				.AddInt("@Height", entity.Height)
				.AddNVarChar("@Email", entity.Email, 256)
				.Build();

			int newId =0;
			try 
			{ 
				newId = SQLDb.UpdateOrDelete(funConnection, sql, parameters); 
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
				//if (ex.Message.Contains("IX_Users"))
				//{
				//	throw new Exception("您更新的帳號已存在，請修改後再試一次", ex);
				//}
			}
				
			return newId;
		}

		public IEnumerable<UserEntity> Search(string name,string account,string email)
		{
			//生成sql statement
			string sql = $@"
SELECT * 
FROM {_tableName}";

			#region 生成where子句
			string where = string.Empty;

			var parameters = new List<SqlParameter>();

			
			if (string.IsNullOrEmpty(name) == false)
			{
				where += $" AND Name LIKE '%'+ @Name +'%'";
				parameters.Add(new SqlParameter("@Name", System.Data.SqlDbType.NVarChar, 50) { Value = name });
			}
			if (string.IsNullOrEmpty(account) == false)
			{
				where += $" AND Account =@Account ";
				parameters.Add(new SqlParameter("@Account", System.Data.SqlDbType.NVarChar, 50) { Value = account });
			}
			if (string.IsNullOrEmpty(email) == false)
			{
				where += $" AND Email LIKE '%'+ @Email +'%'";
				parameters.Add(new SqlParameter("@Email", System.Data.SqlDbType.NVarChar, 256) { Value = email });
			}

			where = where == string.Empty ? where : where = " WHERE " + where.Substring(5);
			sql += where;
			#endregion

			return SQLDb.Search(funConnection, funcAssembler, sql, parameters.ToArray());
		}

		public UserEntity GetUser(int userId)
		{
			string sql = $"SELECT * FROM {_tableName} WHERE Id ={userId}";

			return SQLDb.Get(funConnection, funcAssembler, sql);
		}

		public UserEntity GetByAccount(string account)
		{
			string sql = $"SELECT * FROM {_tableName} WHERE Account = @Account";
			SqlParameter[] parameters = new SqlParameter[] { new SqlParameter("@Account", System.Data.SqlDbType.NVarChar, 50) { Value = account } };

			return SQLDb.Get(funConnection, funcAssembler, sql,parameters);
		} 
	}
	
}