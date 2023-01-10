using System;
using System.Data;
using System.Data.SqlClient;

namespace ISpan2023.EStore.SqlDataLayer
{
	public class NewsRepository
	{
		/// <summary>
		/// 新增一筆 News記錄
		/// </summary>
		/// <param name="entity"></param>
		/// <returns>傳回剛新增資料的自動編號</returns>
		public int Create(News entity)
		{
			// 取得剛新增資料的自動編號
			string sql = @"SET NOCOUNT ON;
INSERT INTO News
(Title, Description, CreatedTime, ModifiedTime)
VALUES
(@Title, @Description, DEFAULT, DEFAULT);
SET @newId = SCOPE_IDENTITY()";

			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@Title", SqlDbType.NVarChar, 50){Value = entity.Title},
				new SqlParameter("@Description", SqlDbType.NVarChar, 3000){Value = entity.Description},
				new SqlParameter("@newId", SqlDbType.Int){Direction = ParameterDirection.Output}
			};

			SqlDataLayer.SqlDb.ApplicationName = "demo: add new News";
			using (var conn = SqlDb.GetConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = sql;
					cmd.Parameters.AddRange(parameters);// 除了一次加入多個SqlParameter, 也可以分成多行, 一次加入一個SqlParameter
					cmd.ExecuteNonQuery();
					return (int)cmd.Parameters["@newId"].Value;
				}
			}
		}

		/// <summary>
		/// 使用ExecuteScalar
		/// </summary>
		/// <param name="entity"></param>
		/// <returns></returns>
		public int Create_2(News entity)
		{
			// 取得剛新增資料的自動編號
			string sql = @"SET NOCOUNT OFF;
INSERT INTO News
(Title, Description, CreatedTime, ModifiedTime)
VALUES
(@Title, @Description, DEFAULT, DEFAULT);
SELECT SCOPE_IDENTITY()";

			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@Title", SqlDbType.NVarChar, 50){Value = entity.Title},
				new SqlParameter("@Description", SqlDbType.NVarChar, 3000){Value = entity.Description}
			};

			SqlDataLayer.SqlDb.ApplicationName = "demo: add new News";
			using (var conn = SqlDb.GetConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = sql;
					cmd.Parameters.AddRange(parameters);
					return Convert.ToInt32(cmd.ExecuteScalar());
				}
			}
		}

		public News GetNews(int newsId)
		{
			var sql = $"SELECT * FROM News WHERE Id={newsId}";

			using (var conn = SqlDb.GetConnection())
			{
				conn.Open();

				using (var cmd = new SqlCommand(sql, conn))
				{
					var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
					return reader.Read()
					? News.GetInstance(reader)
					: null;
				}
			}
		}

		public int Update(News entity)
		{
			string sql = @"UPDATE News SET
Title =@Title,
Description =@Description,
ModifiedTime=@ModifiedTime
WHERE
	Id=@Id";

			SqlParameter[] parameters = SqlParameterBuilder.Create()
				.AddNVarchar("@Title", 50, entity.Title)
				.AddNVarchar("@Description", 3000, entity.Description)
				.AddDateTime("@ModifiedTime", entity.ModifiedTime)
				.AddInt("@Id", entity.Id)
				.Build();

			using (var conn = SqlDb.GetConnection())
			{
				conn.Open();
				using (var cmd = new SqlCommand(sql, conn))
				{
					cmd.Parameters.AddRange(parameters);
					return cmd.ExecuteNonQuery(); // 傳回被異動的筆數,若為零,表示沒有異動記錄
				}
			}
		}

		public int Delete(int newsId)
		{
			string sql = @"DELETE News WHERE Id=@Id";

			SqlParameter[] parameters = SqlParameterBuilder.Create()
				.AddInt("@Id", newsId)
				.Build();

			using (var conn = SqlDb.GetConnection())
			{
				conn.Open();
				using (var cmd = new SqlCommand(sql, conn))
				{
					cmd.Parameters.AddRange(parameters);
					return cmd.ExecuteNonQuery(); // 傳回被異動的筆數
				}
			}
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
			news.Id = reader.GetInt32("Id", 0);
			news.Title = reader.GetString("Title");
			news.Description = reader.GetString("Description");
			news.CreatedTime = reader.GetDateTime("CreatedTime", DateTime.MinValue);
			news.ModifiedTime = reader.GetDateTime("ModifiedTime", DateTime.MinValue);

			return news;
		}
	}
}