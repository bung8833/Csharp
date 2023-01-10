using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.EStore.SqlDataLayer
{
    public class CategoryRepository
    {
		private readonly string _tableName = "Categories";
		public Func<SqlConnection> funcConn = SqlDb.GetConnection;
		public Func<SqlDataReader, Category> funcAssembler = Category.GetInstance;
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
                        //category = new Category
                        //{
                        //    Id = categoryId,
                        //    Name = reader.GetFieldValue<string>("Name"),
                        //    DisplayOrder = reader.GetFieldValue<int>("DisplayOrder")
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
		public IEnumerable<Category> Search(string name, string displayOrder)
		{
			#region 生成 sql statement
			string sql = $@"SELECT *
FROM {_tableName}";

			#region 生成where子句
			string where = string.Empty;

			var parameters = new List<SqlParameter>();

			if (string.IsNullOrEmpty(name) == false)
			{
				where += $" AND Name LIKE '%' + @Name + '%'";
				parameters.Add(new SqlParameter("@Name", System.Data.SqlDbType.NVarChar, 50) { Value = name });
			}
			if (string.IsNullOrEmpty(displayOrder) == false)
			{
				where += $" AND Account= @DisplayOrder";
				parameters.Add(new SqlParameter("@DisplayOrder", System.Data.SqlDbType.NVarChar, 50) { Value = displayOrder });
			}

			where = where == string.Empty ? where : where = " WHERE " + where.Substring(5);
			sql += where;

			#endregion
			#endregion
			return SqlDb.Search(funcConn, funcAssembler, sql, parameters.ToArray());
		}
		public int Create(Category entity)
		{
			string sql = $@"INSERT INTO {_tableName}
(Name,DisplayOrder)
VALUES
(@Name,@DisplayOrder)";

			var parameters = SqlParameterBuilder.Create()
				.AddNVarchar("Name", entity.Name, 50)
				.AddInt("DisplayOrder", entity.DisplayOrder)
				.Build();

			int categoryId = 0;
			categoryId = SqlDb.Create(funcConn, sql, parameters);
			//try
			//{
			//	categoryId = SqlDb.Create(funcConn, sql, parameters);

			//}
			//catch (SqlException ex)
			//{
			//	if (ex.Message.Contains("IX_Users"))
			//	{
			//		throw new Exception("您新增的帳號已存在, 請修改之後再試一次", ex);
			//	}
			//}
			return categoryId;
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
            };
        }
    }

	public static class SqlDataReaderExtensions
    {
        public static T GetFieldValue<T>(this SqlDataReader source, string columnName)
            => source[columnName].Equals(DBNull.Value)
                ? default(T)
                : (T)source[columnName];

    }

}
