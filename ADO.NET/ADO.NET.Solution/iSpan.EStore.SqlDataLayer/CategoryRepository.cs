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
