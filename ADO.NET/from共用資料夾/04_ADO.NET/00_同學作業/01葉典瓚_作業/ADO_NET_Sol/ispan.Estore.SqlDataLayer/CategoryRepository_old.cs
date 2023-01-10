using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ispan.Estore.SqlDataLayer
{
    public class CategoryRepository_old
    {
        public Category GetCategory(int categoryId)
        {
            Category category = null;
            SqlDB.ApplicationName = "getCategory test";
            // SQL連線會忘記斷資源所以用using
            using (SqlConnection conn = SqlDB.GetConnection("default"))
            {
                string sql = $"select * from Categories where Id = {categoryId}";
                var command = new SqlCommand(sql, conn);
                conn.Open();
                // 空一行看起來舒服,{System.Data.SqlClient.SqlDataReader} reader
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        category = Category.GetInstance(reader);
                    }
                }
                  
                }
            return category;
        }

        public static int GetCountOfTable(string tableName, int categoryId)
        {
            SqlDB.ApplicationName = "getCategory test";
            // SQL連線會忘記斷資源所以用using
            using (SqlConnection conn = SqlDB.GetConnection("default"))
            {
                string sql = $"select * from {tableName} where Id = {categoryId}";
                // 某個SQL command的連線
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

        public static Category GetInstance(SqlDataReader reader) { 
            return new Category
            {
                Id = reader.GetFieldValue<int>("Id"),
                Name = reader.GetFieldValue<string>("Name"),
                DisplayOrder = reader.GetFieldValue<int>("DisplayOrder")
                //Name = reader["Name"].ToString(),
                //DisplayOrder = int.Parse(reader["DisplayOrder"].ToString())
                // DisplayOrder = Convert.ToInt16(reader["DisplayOrder"].ToString())
            };

        }

    }

    public static class SqlDataReaderExtension
    {
        public static T GetFieldValue<T>(this SqlDataReader source, string columnName)
        { 
            // 每個泛型資料型態的預設值，例如int的預設值=0，bool的預設值是false
            // T defaultValue = default;

            // DBNull是看看db的值是不是null，
            return source[columnName].Equals(DBNull.Value)
                ? default(T)
                : (T)source[columnName];
        }
    }
}
