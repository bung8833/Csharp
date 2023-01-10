using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ispan.Estore.SqlDataLayer
{
    public class NewsRepository_old
    {
        /*
        public static int Create(News entityNews)
        {
            SqlDB.ApplicationName = "save_createNew";
            // SQL參數化
                string sql = $@"insert into News
(title, Description, CreateTime, ModifiedTime)
VALUES(@title, @Description, @CreateTime, @ModifiedTime)
SET @newId = SCOPE_IDENTITY()";
                //SqlParameter[] parameters = new SqlParameter[] {
                //    new SqlParameter("@title",System.Data.SqlDbType.NVarChar, 58 ){ Value = entityNews.title },
                //    new SqlParameter("@Description", System.Data.SqlDbType.NVarChar, 3000) { Value = entityNews.description },
                //    new SqlParameter("@CreateTime", System.Data.SqlDbType.DateTime) { Value = entityNews.createdTime },
                //    new SqlParameter("@ModifiedTime", System.Data.SqlDbType.DateTime) { Value = entityNews.updatedTime },

                //    new SqlParameter("@newId", System.Data.SqlDbType.Int) { Direction = System.Data.ParameterDirection.Output},
                //};
                var parameters = SqlParameterBuilder.Create()
                .AddNVarchar("@title", entityNews.Title, 58)
                .AddNVarchar("@Description", entityNews.Description, 58)
                .AddDateTime("@CreateTime", entityNews.CreatedTime)
                .AddDateTime("@ModifiedTime", entityNews.UpdatedTime)
                .AddInt("@newId", null,System.Data.ParameterDirection.Output)
                .Build();
            using (SqlConnection conn = SqlDB.GetConnection("default"))
            {
                using (var command = conn.CreateCommand()) {
                    conn.Open();
                    command.CommandText = sql;
                    command.Parameters.AddRange(parameters);
                    command.ExecuteNonQuery();

                    return (int)command.Parameters["@newId"].Value;
                }
            }
            
        }
        */

        public static int Create(News entityNews)
        {
            SqlDB.ApplicationName = "有尊嚴的_create";
            // SQL參數化
            string sql = $@"insert into News
(title, Description, CreateTime, ModifiedTime)
VALUES
(@title, @Description, @CreateTime, @ModifiedTime)";

            var parameters = SqlParameterBuilder.Create()
            .AddNVarchar("@title", entityNews.Title, 58)
            .AddNVarchar("@Description", entityNews.Description, 58)
            .AddDateTime("@CreateTime", entityNews.CreatedTime)
            .AddDateTime("@ModifiedTime", entityNews.UpdatedTime)
            .Build();
            return SqlDB.Create(SqlDB.GetConnection, sql, parameters);
        }

        public static News GetNews(int newsId)
        {
            string sql = $"select * from News where Id = {newsId}";

            // return SqlDB.Get(SqlDB.GetConnection, News.GetInstance, sql);
            return SqlDB.Get<News>(SqlDB.GetConnection, News.GetInstance, sql);

            // SQL連線會忘記斷資源所以用using
            //using (SqlConnection conn = SqlDB.GetConnection("default"))
            //{
            //    string sql = $"select * from News where Id = {newsId}";
            //    var command = new SqlCommand(sql, conn);
            //    conn.Open();
            //    // 空一行看起來舒服,{System.Data.SqlClient.SqlDataReader} reader
            //    using (var reader = command.ExecuteReader())
            //    {
            //        if (reader.Read())
            //        {
            //            news = News.GetInstance(reader);
            //        }
            //    }

            //}
            //return news;
        }

        public int Update(News entityNews)
        {
            SqlDB.ApplicationName = "save_createNew";
            // SQL參數化
            string sql = $@"update News set 
title = @title,
Description = @Description,
ModifiedTime = @ModifiedTime
Where Id = @Id";

            var parameters = SqlParameterBuilder.Create()
            .AddNVarchar("@title", entityNews.Title, 58)
            .AddNVarchar("@Description", entityNews.Description, 58)
            .AddDateTime("@ModifiedTime", entityNews.UpdatedTime)
            .AddInt("@Id", entityNews.Id)
            .Build();
            using (SqlConnection conn = SqlDB.GetConnection("default"))
            {
                conn.Open();
                using (var command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddRange(parameters);
                    return command.ExecuteNonQuery();
                }
            }
        }

        public int Delete(int newsId)
        {
            SqlDB.ApplicationName = "save_createNew";
            // SQL參數化
            string sql = $@"
DELETE FROM News 
Where Id = @Id";

            var parameters = SqlParameterBuilder.Create()
            .AddInt("@Id", newsId)
            .Build();
            return SqlDB.UpdateOrDelete(SqlDB.GetConnection, sql, parameters);
            //using (SqlConnection conn = SqlDB.GetConnection("default"))
            //{
            //    conn.Open();
            //    using (var command = new SqlCommand(sql, conn))
            //    {
            //        command.Parameters.AddRange(parameters);
            //        return command.ExecuteNonQuery();
            //    }
            //}
        }
    }
    

    public class News {
        public int Id;
        public string Title;
        public string Description;
        public DateTime CreatedTime;
        public DateTime UpdatedTime;

        public static News GetInstance(SqlDataReader reader)
        {
            var news = new News();
            news.Id = reader.GetFieldValue<int>("Id");
            news.Title = reader.GetFieldValue<string>("title");
            news.Description = reader.GetFieldValue<string>("Description");
            news.CreatedTime = reader.GetFieldValue<DateTime>("CreateTime");
            news.UpdatedTime = reader.GetFieldValue<DateTime>("ModifiedTime");
            return news;
        }
    }
}
