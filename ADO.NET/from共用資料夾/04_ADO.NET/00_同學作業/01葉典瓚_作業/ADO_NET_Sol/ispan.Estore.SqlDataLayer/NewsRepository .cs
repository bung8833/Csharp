using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ispan.Estore.SqlDataLayer
{
    public class NewsRepository
    {
        private readonly string _tableName = "Users";
        public Func<SqlConnection> funConn = SqlDB.GetConnection;
        public Func<SqlDataReader, NewsEntity> funcAssembler = NewsEntity.GetInstance;


        public int Create(NewsEntity entity) {
            SqlDB.ApplicationName = "有尊嚴的_create";
            // SQL參數化
            string sql = $@"insert into {_tableName}
(Title, Description, CreateTime, ModifiedTime )
VALUES
(@Title, @Description, @CreateTime, @ModifiedTime)";

            var parameters = SqlParameterBuilder.Create()
            .AddNVarchar("@Title", entity.Title, 50)
            .AddNVarchar("@Description", entity.Description, 50)
            .AddDateTime("@CreateTime", entity.CreateTime)
            .AddDateTime("@ModifiedTime", entity.ModifiedTime)
            .Build();
            int newId = 0;
            try { 
                SqlDB.Create(SqlDB.GetConnection, sql, parameters);
            }
            catch(SqlException ex)
            {
                if (ex.Message.Contains("Ix_Users"))
                {
                    throw new Exception("您新增的帳號已存在，請修改後再試一次", ex);
                }
                
            }


            return newId;
        }


        public int Delete(int userId)
        {
            //string sql = $@"DELETE FROM {_tableName} Where Id = {userId}";
            //int rowAffected = SqlDB.UpdateOrDelete(funConn, sql);
            //return rowAffected;

            string sql = $@"DELETE FROM {_tableName} Where Id = @Id";
            var parameters = SqlParameterBuilder.Create()
            .AddInt("@Id", userId)
            .Build();
            int rowAffected = SqlDB.UpdateOrDelete(funConn, sql, parameters);
            return rowAffected;

        }


        public int Update(NewsEntity entity)
        {
            //string sql = $@"DELETE FROM {_tableName} Where Id = {userId}";
            //int rowAffected = SqlDB.UpdateOrDelete(funConn, sql);
            //return rowAffected;

            string sql = $@"Update {_tableName} Set
Title=@Title,
Description=@Description,
ModifiedTime=@ModifiedTime,
Where Id = {entity.Id}";

            var parameters = SqlParameterBuilder.Create()
            .AddNVarchar("@Title", entity.Title, 50)
            .AddNVarchar("@Description", entity.Description, 50)
            .AddDateTime("@ModifiedTime", entity.ModifiedTime)
            .Build();
            int rowAffected = SqlDB.UpdateOrDelete(funConn, sql, parameters);
            return rowAffected;
        }

        public IEnumerable<NewsEntity> Search(string name, string account, string email) {
            var data = new NewsEntity();

            #region 生成 sql statement
            string sql = $@"
SELECT *
FROM {_tableName}";

            #region 生成 where
            string where = string.Empty;
            var parameters = new List<SqlParameter>();

            if (string.IsNullOrEmpty(name) == false)
            {
                where += $" AND Name LIKE '%' +@Name +'%'";
                parameters.Add(new SqlParameter("@Name", System.Data.SqlDbType.NVarChar, 50) { Value = name });
            }
            if (string.IsNullOrEmpty(account) == false)
            {
                where += $" AND Account LIKE '%' +@Account +'%'";
                parameters.Add(new SqlParameter("@Account", System.Data.SqlDbType.NVarChar, 50) { Value = account });
            }
            if (string.IsNullOrEmpty(email) == false)
            {
                where += $" AND Email LIKE '%' +@Email +'%'";
                parameters.Add(new SqlParameter("@Email", System.Data.SqlDbType.NVarChar, 50) { Value = email });
            }
            where = where == string.Empty ? where : " WHERE " + where.Substring(5);
            sql += where;
            #endregion
            #endregion
            return SqlDB.Search(funConn, funcAssembler, sql, parameters.ToArray());
        }

        public NewsEntity GetUser(int userId) {
            string sql = $"SELECT * FROM {_tableName} " +
                $"WHERE Id={userId}";
            return SqlDB.Get(funConn, funcAssembler, sql);
        }
    }

    public class NewsEntity
    { 
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description     { get; set; }
        public DateTime CreateTime{ get; set; }
        public DateTime ModifiedTime { get; set; }
        public static NewsEntity GetInstance(SqlDataReader reader)
        {
            var entity = new NewsEntity();
            entity.Id = reader.GetFieldValue<int>("Id");
            entity.Title = reader.GetFieldValue<string>("title");
            entity.Description = reader.GetFieldValue<string>("Description");
            entity.CreateTime = reader.GetFieldValue<DateTime>("CreateTime");
            entity.ModifiedTime = reader.GetFieldValue<DateTime>("ModifiedTime");

            return entity;
        }
    }


}
