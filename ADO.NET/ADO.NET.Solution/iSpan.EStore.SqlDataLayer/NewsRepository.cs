using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using iSpan.EStore.SqlDataLayer;

namespace iSpan.EStore.SqlDataLayer
{
    public class NewsRepository
    {
        private readonly string _tableName = "News";
        public Func<SqlConnection> funcConn = SqlDb.GetConnection;
        public Func<SqlDataReader, News> funcAssembler = News.GetInstance;


        public int Create(News entity)
        {
            string sql = $@"
INSERT INTO {_tableName}
(Title, Description, CreatedTime, ModifiedTime)
VALUES
(@Title, @Description, @CreatedTime, @ModifiedTime)";

            var parameters = SqlParameterBuilder.Create()
                .AddNVarChar("@Title", entity.Title, 50)
                .AddNVarChar("@Description", entity.Description, 3000)
                .AddDateTime("@CreatedTime", entity.CreatedTime)
                .AddDateTime("@ModifiedTime", entity.ModifiedTime)
                // .AddInt("@newId", null, System.Data.ParameterDirection.Output)
                .Build();

            return SqlDb.Create(funcConn, sql, parameters);

            //SqlParameter[] parameters = new SqlParameter[]
            //{
            //    new SqlParameter("@Title", System.Data.SqlDbType.NVarChar, 50){ Value=entity.Title },
            //    new SqlParameter("@Description", System.Data.SqlDbType.NVarChar, 3000){ Value=entity.Description },
            //    new SqlParameter("@CreatedTime", System.Data.SqlDbType.DateTime){ Value=entity.CreatedTime },
            //    new SqlParameter("@ModifiedTime", System.Data.SqlDbType.DateTime){ Value=entity.ModifiedTime },

            //    new SqlParameter("@newId", System.Data.SqlDbType.Int){ Direction = System.Data.ParameterDirection.Output },
            //};
        }

        public int Delete(int newsId)
        {
            string sql = $@"DELETE FROM {_tableName} WHERE Id = @Id";

            SqlParameter[] parameters = SqlParameterBuilder.Create()
                .AddInt("@Id", newsId)
                .Build();

            return SqlDb.UpdateOrDelete(SqlDb.GetConnection, sql, parameters);

            //using (var conn = SqlDb.GetConnection())
            //{
            //    using (var cmd = new SqlCommand(sql, conn))
            //    {
            //        conn.Open();

            //        //cmd.Parameters.AddRange(parameters);
            //        cmd.Parameters.AddWithValue("@Id", newsId);

            //        return cmd.ExecuteNonQuery(); // 傳回被異動的筆數
            //    }
            //}
        }

        public int Update(News entity)
        {
            string sql = $@"UPDATE {_tableName} SET
Title = @Title,
Description = @Description,
ModifiedTime = @ModifiedTime
WHERE 
Id = @Id";

            SqlParameter[] parameters = SqlParameterBuilder.Create()
                .AddNVarChar("@Title", entity.Title, 50)
                .AddNVarChar("@Description", entity.Description, 3000)
                .AddDateTime("@ModifiedTime", entity.ModifiedTime)
                .AddInt("@Id", entity.Id)
                .Build();

            return SqlDb.UpdateOrDelete(SqlDb.GetConnection, sql, parameters);

            //using (var conn = SqlDb.GetConnection())
            //{
            //    using (var cmd = new SqlCommand(sql, conn))
            //    {
            //        conn.Open();

            //        cmd.Parameters.AddRange(parameters);
            //        return cmd.ExecuteNonQuery(); // 傳回被異動的筆數, 若為零, 表示沒有異動紀錄
            //    }
            //}
        }

        //undone IEnumerable<News> Search(string title, string description)
        public IEnumerable<News> Search(string title, string description)
        {
            #region 生成 SQL Statement
            string sql = $@"
SELECT *
FROM {_tableName} ";

            #region 生成 WHERE 子句
            string where = String.Empty;

            var parameters = new List<SqlParameter>();

            if (string.IsNullOrEmpty(title) == false)
            {
                where += " AND Title LIKE '%' + @Title + '%'";
                parameters.Add(new SqlParameter("Title", System.Data.SqlDbType.NVarChar, 50) { Value = title });
            }
            if (string.IsNullOrEmpty(description) == false)
            {
                where += " AND Description LIKE '%' + @Description + '%'";
                parameters.Add(new SqlParameter("Description", System.Data.SqlDbType.NVarChar, 3000) { Value = description });
            }


            where = where == String.Empty ? where : where = " WHERE " + where.Substring(5);
            sql += where;
            #endregion
            #endregion

            return SqlDb.Search(funcConn, funcAssembler, sql, parameters.ToArray());
        }

        public News GetNews(int newsId)
        {
            string sql = $"SELECT * FROM {_tableName} WHERE Id = {newsId}";

            return SqlDb.Get(SqlDb.GetConnection, News.GetInstance, sql);

            //using (var conn = SqlDb.GetConnection())
            //{
            //    using (var cmd = new SqlCommand(sql, conn))
            //    {
            //        conn.Open();

            //        var reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                    
            //        return reader.Read() 
            //        ? News.GetInstance(reader)
            //        : null;
            //    }
            //}
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
