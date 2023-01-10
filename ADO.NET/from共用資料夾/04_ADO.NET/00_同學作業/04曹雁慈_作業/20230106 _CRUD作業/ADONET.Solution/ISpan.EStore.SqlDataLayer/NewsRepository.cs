using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ISpan.EStore.SqlDataLayer
{
	public class NewsRepository
	{
		private readonly string _tableName = "News";
		public Func<SqlConnection> funcConn = SqlDb.GetConnection;
		public Func<SqlDataReader, News> funcAssembler = News.GetInstance;
		public int Create(News entity)
		{
			string sql = @"INSERT INTO NEWS
(Title, Description, CreatedTime, ModifiedTime)
VALUES
(@Title, @Description, @CreatedTime, @ModifiedTime)";

			var parameters = SqlParameterBuilder.Create()
				.AddNVarchar("@Title", entity.Title, 50)
				.AddNVarchar("@Description", entity.Description, 3000)
				.AddDateTime("@CreatedTime", entity.CreatedTime)
				.AddDateTime("@ModifiedTime", entity.ModifiedTime)
				// .AddInt("@newId", null, System.Data.ParameterDirection.Output)
				.Build();
			return SqlDb.Create(SqlDb.GetConnection, sql, parameters);
			
		}

		public News GetNews(int newsId)
		{
			var sql = $"SELECT * FROM News WHERE Id={newsId}";
			return SqlDb.Get(SqlDb.GetConnection, News.GetInstance, sql);
			
			//using (var conn = SqlDb.GetConnection())
			//{
			//	using (var cmd = new SqlCommand(sql, conn))
			//	{
			//		conn.Open();

			//		var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
			//		return reader.Read()
			//		? News.GetInstance(reader)
			//		: null;
			//	}

			//}
		}

		public int Update(News entity)
		{	// 在此, 並不更新CreatedTime
			string sql = @"UPDATE News SET
Title =@Title,
Description =@Description,
ModifiedTime=@ModifiedTime
WHERE
	Id=@Id";

			SqlParameter[] parameters = SqlParameterBuilder.Create()
				.AddNVarchar("@Title", entity.Title, 50)
				.AddNVarchar("@Description", entity.Description, 3000)
				.AddDateTime("@ModifiedTime", entity.ModifiedTime)
				.AddInt("@Id", entity.Id)
				.Build();

			return SqlDb.UpdateOrDelete(SqlDb.GetConnection, sql, parameters);
		}
		public int Delete(int newsId)
		{
			string sql = @"DELETE News WHERE Id=@Id";

			SqlParameter[] parameters = SqlParameterBuilder.Create()
				.AddInt("@Id", newsId)
				.Build();

			return SqlDb.UpdateOrDelete(SqlDb.GetConnection, sql, parameters);
		}
		public IEnumerable<News> Search(string id, string title, string description)
		{
			#region 生成 sql statement
			string sql = $@"SELECT *
FROM {_tableName}";

			#region 生成where子句
			string where = string.Empty;

			var parameters = new List<SqlParameter>();

			if (string.IsNullOrEmpty(id) == false)
			{
				where += $" AND Id LIKE '%' + @Id + '%'";
				parameters.Add(new SqlParameter("@Id", System.Data.SqlDbType.NVarChar, 50) { Value = id });
			}
			if (string.IsNullOrEmpty(title) == false)
			{
				where += $" AND Title= @Title";
				parameters.Add(new SqlParameter("@Title", System.Data.SqlDbType.NVarChar, 50) { Value = title });
			}
			if (string.IsNullOrEmpty(description) == false)
			{
				where += $" AND Description LIKE '%' + @Description + '%'";
				parameters.Add(new SqlParameter("@Description", System.Data.SqlDbType.NVarChar, 256) { Value = description });
			}

			where = where == string.Empty ? where : where = " WHERE " + where.Substring(5);
			sql += where;

			#endregion
			#endregion
			return SqlDb.Search(funcConn, funcAssembler, sql, parameters.ToArray());
		}
	}
	

	public class News
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public DateTime CreatedTime { get; set; }

		public DateTime ModifiedTime { get; set; }

		public static News GetInstance(SqlDataReader reader)
		{
			var news = new News();
			news.Id = reader.GetFieldValue<int>("Id");
			news.Title = reader.GetFieldValue<string>("Title");
			news.Description = reader.GetFieldValue<string>("Description");
			news.CreatedTime = reader.GetFieldValue<DateTime>("CreatedTime");
			news.ModifiedTime = reader.GetFieldValue<DateTime>("ModifiedTime");

			return news;
		}
	}
}
