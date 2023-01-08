using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace iSpan.EStore.SqlDataLayer
{
    public class CategoryRepository
    {
        private readonly string _tableName = "Categories";
        public Func<SqlConnection> funcConn = SqlDb.GetConnection;
        public Func<SqlDataReader, Category> funcAssembler = Category.GetInstance;


        // undone int Create(Category entity)
        public int Create(Category entity)
        {
            string sql = $@"
INSERT INTO {_tableName}
(Name, DisplayOrder)
VALUES
(@Name, @DisplayOrder)";

            var parameters = SqlParameterBuilder.Create()
                .AddNVarChar("Name", entity.Name, 30)
                .AddInt("DisplayOrder", entity.DisplayOrder)
                .Build();

            int newId = 0;
            newId = SqlDb.Create(funcConn, sql, parameters);
            return newId;
        }

        // undone int Delete(int categoryId)
        public int Delete(int categoryId)
        {
            string sql = $"DELETE FROM {_tableName} WHERE Id = {categoryId}";
            int rowsAffected = SqlDb.UpdateOrDelete(funcConn, sql);
            return rowsAffected;
        }

        // undone int Update(Category entity)
        public int Update(Category entity)
        {
            string sql = $@"
UPDATE {_tableName} SET
Name = @Name,
DisplayOrder = @DisplayOrder
WHERE Id = {entity.Id}";


            var parameters = SqlParameterBuilder.Create()
                .AddNVarChar("Name", entity.Name, 30)
                .AddInt("DisplayOrder", entity.DisplayOrder)
                .Build();

            int rowsAffected = SqlDb.UpdateOrDelete(funcConn, sql, parameters);
            return rowsAffected;
        }

        // undone IEnumerable<Category> Search(string name)
        public IEnumerable<Category> Search(string name)
        {
            #region 生成 SQL Statement
            string sql = $@"
SELECT *
FROM {_tableName} ";

            #region 生成 WHERE 子句
            string where = String.Empty;

            var parameters = new List<SqlParameter>();

            if (string.IsNullOrEmpty(name) == false)
            {
                where += $" AND Name LIKE '%' + @Name + '%'";
                parameters.Add(new SqlParameter("Name", System.Data.SqlDbType.NVarChar, 30) { Value = name });
            }

            where = where == String.Empty ? where : where = " WHERE " + where.Substring(5);
            sql += where;
            #endregion
            #endregion

            return SqlDb.Search(funcConn, funcAssembler, sql, parameters.ToArray());
        }


        /// <summary>
        /// 回傳一個Category物件, 其屬性包含Table Categories的欄位
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public Category GetCategory(int categoryId)
        {
            Category category = null;

            using (var conn = SqlDb.GetConnection())
            {
                string sql = $"SELECT * FROM Categories WHERE Id={categoryId}";

                using (var command = new SqlCommand(sql, conn))
                {
                    conn.Open();

                    var reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        return Category.GetInstance(reader);
                        
                        //category = new Category()
                        //{
                        //    Id = categoryId,
                        //    Name = reader["Name"].ToString(),
                        //    DisplayOrder = int.Parse(reader["DisplayOrder"].ToString())
                        //};
                    }
                }
            }

            return category;
        }


        public int GetProductCount(int categoryId)
        {
            using (var conn = SqlDb.GetConnection())
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

    /// <summary>
    /// 屬性包含Table Categories的欄位
    /// </summary>
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DisplayOrder { get; set; }

        public static Category GetInstance(SqlDataReader reader)
        {
            return new Category()
            {
                Id = reader.GetFieldValue<int>("Id"),
                Name = reader.GetFieldValue<string>("Name"),
                DisplayOrder = reader.GetFieldValue<int>("DisplayOrder")
            };
        }
    }



    public static class SqlDataReaderExtensions
    {
        //public static T GetFieldValue<T>(this SqlDataReader source, string columnName)
        //    =>source[columnName].Equals(DBNull.Value)
        //        ? default(T)
        //        : (T)source[columnName];


        public static T GetFieldValue<T>(this SqlDataReader source, string columnName)
        {
            T defaultValue = default;

            if (source[columnName].Equals(DBNull.Value))
            {
                return defaultValue;
            }

            return (T)source[columnName];
        }
    }
}
