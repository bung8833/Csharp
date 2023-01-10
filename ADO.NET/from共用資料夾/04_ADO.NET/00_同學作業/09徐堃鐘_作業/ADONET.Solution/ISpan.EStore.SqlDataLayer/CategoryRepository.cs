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
				string sql = $"SELECT COUNT(*) FROM Products WHERE CategoryId={categoryId}";
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
            };
        }
    }
    public static class SqlDataReaderExtensions
    {
        public static T GetFieldValue<T>(this SqlDataReader source, string columnName)
            => source[columnName].Equals(DBNull.Value)
                ? default(T)
                : (T) source[columnName];

        //public static T GetFieldValue<T>(this SqlDataReader source, string columnName)
        //{
        //    T defalutValue = default;

        //    return source[columnName].Equals(DBNull.Value)
        //        ? defalutValue
        //        : (T)source[columnName];

        //    //if (source[columnName].Equals(DBNull.Value))
        //    //{
        //    //    return defalutValue;
        //    //}

        //    //return (T)source[columnName];

        //}
    }
}
