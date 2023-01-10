using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSpan.EStore.SqlDataLayer
{
    public class NewsRepository
    {
        private readonly string _tableName = "News";
        public Func<SqlConnection> funcConn = SqlDB.GetConnection;
        public Func<SqlDataReader, News> funcAssembler = News.GetInstance;

        public int Create(News entity)
        {
            string sql = $@"INSERT INTO {_tableName} 
(Title, Description, CreatedTime, ModifiedTime) 
VALUES 
(@Title, @Description, @CreatedTime, @ModifiedTime)";

            //SqlParameter[] parameters = new SqlParameter[] {
            //    new SqlParameter("@Title",System.Data.SqlDbType.NVarChar, 50){ Value=entity.Title },
            //    new SqlParameter("@Description",System.Data.SqlDbType.NVarChar, 3000){ Value=entity.Description },
            //    new SqlParameter("@CreatedTime",System.Data.SqlDbType.DateTime){ Value=entity.CreatedTime },
            //    new SqlParameter("@ModifiedTime",System.Data.SqlDbType.DateTime){ Value=entity.ModifiedTime },

            //    new SqlParameter("@newId",System.Data.SqlDbType.Int){ Direction=System.Data.ParameterDirection.Output }
            //};

            var parameters = SqlParameterBuilder.Create()
                .AddNVarchar("@Title", entity.Title, 50)
                .AddNVarchar("@Description", entity.Description, 3000)
                .AddDateTime("@CreatedTime", entity.CreatedTime)
                .AddDateTime("@ModifiedTime", entity.ModifiedTime)
                //.AddInt("@newId", null, System.Data.ParameterDirection.Output)
                .Build();

            int newId = SqlDB.Create(funcConn, sql, parameters);
            return newId;
        }

        public int Delete(int newsId)
        {
            var sql = $@"DELETE {_tableName} WHERE Id={newsId}";

            int affectedRows = SqlDB.UpdateOrDelete(funcConn, sql);
            return affectedRows;
            //string sql = $@"DELETE News WHERE Id=@newsId";

            ////SqlParameter parameters = new SqlParameter("@newsId", System.Data.SqlDbType.Int) { Value = newsId };
            //var parameters = SqlParameterBuilder.Create()
            //    .AddInt("@newsId", newsId)
            //    .Build();

            //return SqlDB.UpdateOrDelete(SqlDB.GetConnection, sql, parameters);

            //using (var conn = SqlDB.GetConnection())
            //{
            //    conn.Open();
            //    using (var command = new SqlCommand(sql, conn))
            //    {
            //        command.Parameters.Add(parameters);
            //        return command.ExecuteNonQuery();
            //    }
            //}
        }

        public int Update(News entity)
        {
            string sql = $@"UPDATE {_tableName} SET 
Title=@Title, 
Description=@Description, 
ModifiedTime=@ModifiedTime 
WHERE Id={entity.Id}";

            var parameters = SqlParameterBuilder.Create()
                .AddNVarchar("@Title", entity.Title, 50)
                .AddNVarchar("@Description", entity.Description, 3000)
                .AddDateTime("@ModifiedTime", entity.ModifiedTime)
                .Build();

            int affectedRows = SqlDB.UpdateOrDelete(funcConn, sql, parameters);
            return affectedRows;
            //using (var conn = SqlDB.GetConnection())
            //{
            //    conn.Open();
            //    using (var command = new SqlCommand(sql,conn))
            //    {
            //        command.Parameters.AddRange(parameters);
            //        return command.ExecuteNonQuery();
            //    }
            //}
        }

        public IEnumerable<News> Search(string title, string description)
        {
            #region 生成 sql statement
            string sql = $@"SELECT * 
FROM {_tableName}";

            #region 生成 WHERE子句
            string where = string.Empty;

            var parameters = new List<SqlParameter>();

            if (!string.IsNullOrEmpty(title))
            {
                where += $" AND Title LIKE '%' + @Title + '%'";
                parameters.Add(new SqlParameter("@Title", System.Data.SqlDbType.NVarChar, 50) { Value = title });
            }
            if (!string.IsNullOrEmpty(description))
            {
                where += $" AND Description LIKE '%' + @Description + '%'";
                parameters.Add(new SqlParameter("@Description", System.Data.SqlDbType.NVarChar, 3000) { Value = description });
            }

            where = where == string.Empty ? where : " WHERE " + where.Substring(5);
            sql += where;
            #endregion
            sql += $" ORDER BY Id";
            #endregion

            return SqlDB.Search(funcConn, funcAssembler, sql, parameters.ToArray());
        }

        public News GetNews(int newsId)
        {
            string sql = $"SELECT * FROM {_tableName} WHERE Id={newsId}";
            return SqlDB.Get(SqlDB.GetConnection, News.GetInstance, sql);

            //using (var conn = SqlDB.GetConnection())
            //{
            //    News news = null;
            //    string sql = $"SELECT * FROM News WHERE Id={newsId}";
            //    using (var command = new SqlCommand(sql, conn))
            //    {
            //        conn.Open();
            //        var reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            //        return reader.Read() ? News.GetInstance(reader) : news;
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
            return new News
            {
                Id = reader.GetFieldValue<int>("Id"),
                Title = reader.GetFieldValue<string>("Title"),
                Description = reader.GetFieldValue<string>("Description"),
                CreatedTime = reader.GetFieldValue<DateTime>("CreatedTime"),
                ModifiedTime = reader.GetFieldValue<DateTime>("ModifiedTime")
            };
        }
    }
}
