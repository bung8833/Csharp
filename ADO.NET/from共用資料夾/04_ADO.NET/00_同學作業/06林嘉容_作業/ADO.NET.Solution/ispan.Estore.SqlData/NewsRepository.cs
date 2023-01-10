using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace ispan.Estore.SqlData
{
	public class NewsRepository
	{
		private readonly string _tableName = "news";
		private Func<SqlConnection> funConnection = SQLDb.GetConnection;
		public Func<SqlDataReader, News> funcAssembler = News.GetInstance;
		public int Create(News entity)
		{
			string sql = @"
Insert into news
(Title, Description , CreatedTime, ModifiedTime)
values
(@Title, @Description , @CreatedTime, @ModifiedTime);";  //取得ID

			SqlParameter[] parameters = SqlParameterBuilder.Create()
				.AddNVarChar("@Title", entity.Title, 50)
				.AddNVarChar("@Description", entity.Description, 3000)
				.AddDateTime("@CreatedTime", entity.CreatedTime)
				.AddDateTime("@ModifiedTime", entity.ModifiedTime)
				.AddInt("@newId", null, ParameterDirection.Output)

				.Build();
			int result;
			try
			{
				result = SQLDb.Create(SQLDb.GetConnection, sql, parameters);
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			} 


			return result;
			//SqlParameter[] parameters = new SqlParameter[]
			//{
			//	new SqlParameter("@Title",System.Data.SqlDbType.NVarChar,50){ Value=entity.Title},
			//	new SqlParameter("@Description",System.Data.SqlDbType.NVarChar,3000){Value=entity.Description},
			//	new SqlParameter("@CreatedTime",System.Data.SqlDbType.DateTime){ Value=entity.CreatedTime},
			//	new SqlParameter("@ModifiedTime",System.Data.SqlDbType.DateTime){Value=entity.ModifiedTime},

			//	new SqlParameter("@newId",System.Data.SqlDbType.Int){ Direction =System.Data.ParameterDirection.Output},
			//};

			//using (var conn = SQLDb.GetConnection())
			//{
			//	using (var cmd = conn.CreateCommand())
			//	{
			//		conn.Open();
			//		cmd.CommandText = sql;
			//		cmd.Parameters.AddRange(parameters);

			//		cmd.ExecuteNonQuery();   //ExecuteReader讀資料ExecuteScalar擷取單一值 ExecuteNonQuery用來執行INSERT、UPDATE、DELETE和其他沒有返回值得SQL命令

			//		return (int)cmd.Parameters["@newId"].Value;
			//	}
			//}
		}

		public int Delete(int newsId)
		{
			string sql = @"Delete from News where Id =@Id";

			SqlParameter[] parameters = SqlParameterBuilder.Create()
				.AddInt("@Id",newsId)
				.Build();

			return SQLDb.UpdateOrDelete(SQLDb.GetConnection, sql, parameters);
			//using (var conn = SQLDb.GetConnection())
			//{
			//	conn.Open();
			//	using (var cmd =new SqlCommand(sql, conn))
			//	{
			//		cmd.Parameters.AddRange(parameters);
			//		return cmd.ExecuteNonQuery();
			//	}
			//}
			//return SQLDb.UpdateOrDelete(()=>SQLDb.GetConnection(), sql, parameters);
		}

		public News GetNews(int newsId)
		{
			var sql = $"Select * from News Where Id ={newsId}";

			return SQLDb.Get(SQLDb.GetConnection,News.GetInstance, sql);
			//return SQLDb.Get<News>(SQLDb.GetConnection,News.GetInstance, sql);
			//using (var conn = SQLDb.GetConnection())
			//{
			//	using (var cmd = new SqlCommand(sql, conn))
			//	{
			//		conn.Open();

			//		var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
			//		return reader.Read()
			//			? News.GetInstance(reader)
			//			: null;
			//	}
			//}
		}
		public int Update(News entity)
		{
			string sql = @"
Update News
set Title = @Title, Description = @Description,ModifiedTime =@ModifiedTime
where id =@Id;";  


			SqlParameter[] parameters = SqlParameterBuilder.Create()
				.AddNVarChar("@Title", entity.Title, 50)
				.AddNVarChar("@Description", entity.Description, 3000)
				.AddDateTime("@ModifiedTime", entity.ModifiedTime)
				.AddInt("@Id", entity.ID)
				.Build();

			return SQLDb.UpdateOrDelete(SQLDb.GetConnection, sql, parameters);
			//using (var conn = SQLDb.GetConnection())
			//{
			//	conn.Open();
			//	using (var cmd =new SqlCommand(sql,conn))
			//	{

			//		cmd.Parameters.AddRange(parameters);

			//		return cmd.ExecuteNonQuery();

			//	}
			//}
		}
		public IEnumerable<News> Search(string Title)
		{
			//生成sql statement
			string sql = $@"
SELECT * 
FROM {_tableName}";

			#region 生成where子句
			string where = string.Empty;

			var parameters = new List<SqlParameter>();


			if (string.IsNullOrEmpty(Title) == false)
			{
				where += $" AND Title LIKE '%'+ @Title +'%'";
				parameters.Add(new SqlParameter("@Title", System.Data.SqlDbType.NVarChar, 50) { Value = Title });
			}

			where = where == string.Empty ? where : where = " WHERE " + where.Substring(5);
			sql += where;
			#endregion

			return SQLDb.Search(funConnection, funcAssembler, sql, parameters.ToArray());
		}
	}

	public class News
	{
		public int ID { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public DateTime CreatedTime { get; set; }
		public DateTime ModifiedTime { get; set; }

		public static News GetInstance(SqlDataReader reader)
		{
			var news = new News();
			news.ID = reader.GetFieldValue<int>("Id");
			news.Title = reader.GetFieldValue<string>("Title");
			news.Description = reader.GetFieldValue<string>("Description");
			news.CreatedTime = reader.GetFieldValue<DateTime>("CreatedTime");
			news.ModifiedTime = reader.GetFieldValue<DateTime>("ModifiedTime");

			return news;
		}
	}
}
