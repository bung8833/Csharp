using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace iSpan.EStore.SqlDataLayer
{
    public class CategoryRepository
    {
        private readonly string _tableName = "Categories";
        public Func<SqlConnection> funcConn = SqlDB.GetConnection;
        public Func<SqlDataReader, Category> funcAssembler = Category.GetInstance;

        public Category GetCategory(int categoryId)
        {
            string sql = $"SELECT * FROM {_tableName} WHERE Id={categoryId}";
            return SqlDB.Get(funcConn, funcAssembler, sql);

            //using (var conn = SqlDB.GetConnection())
            //{
            //    Category category = null;
            //    string sql = $"SELECT * FROM Categories WHERE Id={categoryId}";
            //    using (var command = new SqlCommand(sql, conn))
            //    {
            //        conn.Open();
            //        var reader = command.ExecuteReader();

            //        if (reader.Read())
            //        {
            //            return Category.GetInstance(reader);
            //        }
            //        return category;
            //    }
            //}
        }

        public int Create(Category entity)
        {
            string sql = $@"INSERT INTO {_tableName} 
(Name, DisplayOrder) 
VALUES 
(@Name, @DisplayOrder)";

            var parameters = SqlParameterBuilder.Create()
                .AddNVarchar("@Name", entity.Name, 30)
                .AddInt("@DisplayOrder", entity.DisplayOrder)
                .Build();

            int newId = 0;
            try { newId = SqlDB.Create(funcConn, sql, parameters); }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("IX_Users"))
                    throw new Exception("輸入了重複的帳號");
            }

            return newId;
        }

        public int Delete(int categoryId)
        {
            var sql = $@"DELETE {_tableName} WHERE Id={categoryId}";

            int affectedRows = SqlDB.UpdateOrDelete(funcConn, sql);
            return affectedRows;
        }

        public int Update(Category entity)
        {
            string sql = $@"UPDATE {_tableName} SET 
Name=@Name,
DisplayOrder=@DisplayOrder
WHERE Id={entity.Id}";

            var parameters = SqlParameterBuilder.Create()
                .AddNVarchar("@Name", entity.Name, 30)
                .AddInt("@DisplayOrder", entity.DisplayOrder)
                .Build();

            int affectedRows = SqlDB.UpdateOrDelete(funcConn, sql, parameters);
            return affectedRows;
        }

        public IEnumerable<Category> Search(string name, int? displayOrder)
        {
            #region 生成 sql statement
            string sql = $@"SELECT * 
FROM {_tableName}";

            #region 生成 WHERE子句
            string where = string.Empty;

            var parameters = new List<SqlParameter>();

            if (!string.IsNullOrEmpty(name))
            {
                where += $" AND Name LIKE '%' + @Name + '%'";
                parameters.Add(new SqlParameter("@Name", System.Data.SqlDbType.NVarChar, 50) { Value = name });
            }
            if (displayOrder.HasValue)
            {
                where += $" AND DisplayOrder = @DisplayOrder";
                parameters.Add(new SqlParameter("@DisplayOrder", System.Data.SqlDbType.Int) { Value = displayOrder });
            }

            where = where == string.Empty ? where : " WHERE " + where.Substring(5);
            sql += where;
            #endregion
            sql += $" ORDER BY Id";
            #endregion

            return SqlDB.Search(funcConn, funcAssembler, sql, parameters.ToArray());
        }

        public int GetProductCount(int categoryId)
        {
            using (var conn = SqlDB.GetConnection())
            {

                string sql = $"SELECT Count(*) FROM Products WHERE CategoryId={categoryId}";
                using (var command = new SqlCommand(sql, conn))
                {
                    conn.Open();

                    object result = command.ExecuteScalar();
                    return Convert.ToInt32(result);
                }
            }
        }
    }
    
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public static Category GetInstance(SqlDataReader reader)
        {
            return new Category
            {
                Id = reader.GetFieldValue<int>("Id"),
                Name = reader.GetFieldValue<string>("Name"),
                DisplayOrder = reader.GetFieldValue<int>("DisplayOrder")
                //Name = reader["Name"].ToString(),
                //DisplayOrder = int.Parse(reader["DisplayOrder"].ToString())
            };
        }
    }
}
