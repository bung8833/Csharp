using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ispan.Estore.SqlDataLayer
{
    public class CategoryRepository
    {
        private readonly string _tableName = "Categories";
        public Func<SqlConnection> funConn = SqlDB.GetConnection;
        public Func<SqlDataReader, CategoryEntity> funcAssembler = CategoryEntity.GetInstance;


        public int Create(CategoryEntity entity) {
            SqlDB.ApplicationName = "有尊嚴的_create";
            // SQL參數化
            string sql = $@"insert into {_tableName}
(Name, DisplayOrder)
VALUES
(@Name, @DisplayOrder)";

            var parameters = SqlParameterBuilder.Create()
            .AddNVarchar("@Name", entity.Name, 50)
            .AddInt("@DisplayOrder", entity.DisplayOrder)
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


        public int Update(CategoryEntity entity)
        {
            //string sql = $@"DELETE FROM {_tableName} Where Id = {userId}";
            //int rowAffected = SqlDB.UpdateOrDelete(funConn, sql);
            //return rowAffected;

            string sql = $@"Update {_tableName} Set
Name=@Name,
DisplayOrder=@DisplayOrder,
Where Id = {entity.Id}";

            var parameters = SqlParameterBuilder.Create()
            .AddNVarchar("@Name", entity.Name, 50)
            .AddInt("@DisplayOrder", entity.DisplayOrder)
            .Build();
            int rowAffected = SqlDB.UpdateOrDelete(funConn, sql, parameters);
            return rowAffected;

        }

        public IEnumerable<CategoryEntity> Search(string name, string account, string email) {
            var data = new CategoryEntity();

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

        public CategoryEntity GetUser(int userId) {
            string sql = $"SELECT * FROM {_tableName} " +
                $"WHERE Id={userId}";
            return SqlDB.Get(funConn, funcAssembler, sql);
        }
    }

    public class CategoryEntity
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public int? DisplayOrder { get; set; }
        public static CategoryEntity GetInstance(SqlDataReader reader)
        {
            var entity = new CategoryEntity();
            entity.Id = reader.GetFieldValue<int>("Id");
            entity.Name = reader.GetFieldValue<string>("Name");
            entity.DisplayOrder = reader.GetFieldValue<int?>("DisplayOrder");

            return entity;
        }
    }


}
