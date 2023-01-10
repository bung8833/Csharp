using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using static ispan.Estore.SqlData.CategoryRepository;

namespace ispan.Estore.SqlData
{
    public class CategoryRepository
    {
		private readonly string _tableName = "Categories";
		private Func<SqlConnection> funConnection = SQLDb.GetConnection;
		public Func<SqlDataReader, Category> funcAssembler = Category.GetInstance;

		public int Create(Category category)
		{
			string sql = $@"
INSERT INTO {_tableName}
(Name , DisplayOrder)
VALUES
(@Name , @DisplayOrder);";

			var parameters = SqlParameterBuilder.Create()
				.AddNVarChar("@Name",category.Name,30)
				.AddInt("@DisplayOrder",category.DisplayOrder)
				.Build();
			int newId = 0;
			try
			{
				newId = SQLDb.Create(funConnection, sql, parameters);
			}
			catch (SqlException ex)
			{
				throw new Exception(ex.Message);
			}
			return newId;
		}

		public int Delete(int CategoryId)
		{
			string sql = $@"DELETE FROM {_tableName} WHERE Id ={CategoryId}";

			return SQLDb.UpdateOrDelete(funConnection, sql);			
		}

		public int Update(Category category)
		{
			string sql = $@"
UPDATE {_tableName}
SET Name = @Name , DisplayOrder = @DisplayOrder
WHERE Id ={category.Id};";

			var parameters = SqlParameterBuilder.Create()
				.AddNVarChar("@Name", category.Name, 30)
				.AddInt("@DisplayOrder", category.DisplayOrder)
				.Build();

			return SQLDb.UpdateOrDelete(funConnection, sql, parameters);
		}

		public IEnumerable<Category> Search(int? Id ,string name)
		{
			//生成sql statement
			string sql = $@"
SELECT * 
FROM {_tableName}";

			#region 生成where子句
			string where = string.Empty;

			var parameters = new List<SqlParameter>();


			if (string.IsNullOrEmpty(name) == false)
			{
				where += $" AND Name LIKE '%'+ @Name +'%'";
				parameters.Add(new SqlParameter("@Name", System.Data.SqlDbType.NVarChar, 30) { Value = name });
			}
			if (Id.HasValue)
			{
				where += $" AND Id = @Id";
				parameters.Add(new SqlParameter("@Id", System.Data.SqlDbType.Int) { Value = Id });
			}

			where = where == string.Empty ? where : where = " WHERE " + where.Substring(5);
			sql += where;
			#endregion

			return SQLDb.Search(funConnection, funcAssembler, sql, parameters.ToArray());
		}

		public Category GetCategory(int categoryId)
        {
            using (var conn = SQLDb.GetConnection())
            {
                Category category = null;
                string sql = $"select * from Categories where id ={categoryId}";
                using (var commad = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    var reader = commad.ExecuteReader();
                    if (reader.Read())
                    {
                        return Category.GetInstance(reader);
                        //category = new Category
                        //{
                        //    Id = categoryId,
                        //    Name = reader.GetFieldValue<string>("Name"),
                        //    DisplayOrder = reader.GetFieldValue<int>("DisplayOrder")
                        //    //Id = categoryId,
                        //    //Name = reader.["Name"].ToString(),
                        //    //DisplayOrder = int.Parse(reader["DisplayOrder"].ToString())
                        //};
                    }
                }
                return category;
            }
        }

        public int GetProductCount(int categoryId)
        {
            using (var conn = SQLDb.GetConnection())
            {
                string sql = $"select count(*) from Products where Categoryid ={categoryId}";
                using (var commad = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    object result = commad.ExecuteScalar();
                    return Convert.ToInt32(result);
                }
            }
        }
    }
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? DisplayOrder { get; set; }

        public static Category GetInstance(SqlDataReader reader)
        {
            var category = new Category();
            category.Id = reader.GetFieldValue<int>("Id");
            category.Name = reader.GetFieldValue<string>("Name");
            category.DisplayOrder = reader.GetFieldValue<int?>("DisplayOrder");
           
            return category;
        }
    }
    public static class SqlDataReaderExtensions
    {
        public static T GetFieldValue<T>(this SqlDataReader source,string columnName)
           =>source[columnName].Equals(DBNull.Value)
                 ? default(T): (T)source[columnName];
        //{
        //T defaultValue = default;
        //if (source[columnName].Equals(DBNull.Value))
        //{
        //    return defaultValue;
        //}

        //return (T)source[columnName];
        //}
    }
}
