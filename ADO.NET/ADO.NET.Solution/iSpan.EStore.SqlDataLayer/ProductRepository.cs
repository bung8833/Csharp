using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace iSpan.EStore.SqlDataLayer
{
    public class ProductRepository
    {
        public IEnumerable<ProductDto> Search(int? categoryId=null, string productName=null)
        {
            // 這一行是方便在 profiler 查看
            SqlDb.ApplicationName = "demo: search products";

            #region SQL statement
            // += 開頭要加空白 用以分段
            
            string sql = $@"
SELECT P.*, C.Name as CategoryName
FROM Products as P
INNER JOIN Categories as C ON P.CategoryId = C.Id";

            #region WHERE子句
            string where = String.Empty;

            // Allen Jan 5 用來存放不特定數量的 SqlParameter
            var parameters = new List<SqlParameter>();

            if (categoryId.HasValue)
            {
                where += $" AND P.CategoryId = {categoryId.Value}";
            }
            if (String.IsNullOrEmpty(productName) == false)
            {
                // Allen Jan 5
                //where += $" AND P.Name LIKE '%{productName}%'";
                where += $" AND P.Name LIKE '%' + @productName + '%'";
                parameters.Add(new SqlParameter("@productName", System.Data.SqlDbType.NVarChar, 50) { Value = productName });
            }

            where = where == String.Empty ? where : where = " WHERE " + where.Substring(5);
            //where = where == String.Empty ? where : " WHERE " + where.Substring(5);
            sql += '\n' + where;
            #endregion

            sql += " ORDER BY C.DisplayOrder";

            #endregion

            using (SqlConnection conn = SqlDb.GetConnection())
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = sql;

                    // Allen Jan 5 加入參數
                    cmd.Parameters.AddRange(parameters.ToArray());

                    var reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                    while (reader.Read())
                    {
                        var dto = ProductDto.GetInstance(reader);
                        yield return dto;
                    }
                }
            }

            //using (SqlConnection conn = SqlDb.GetConnection("default"))
            //{
            //    using (var command = new SqlCommand("SELECT * FROM Categories", conn))
            //    {
            //        conn.Open();

            //        var reader = command.ExecuteReader();
            //        reader.Close();
            //    }
            //}
        }
    }

    public class ProductDto
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public static ProductDto GetInstance(SqlDataReader reader)
        {
            return new ProductDto
            {
                Id = reader.GetFieldValue<int>("Id"),
                CategoryName = reader.GetFieldValue<string>("CategoryName"),
                Name = reader.GetFieldValue<string>("Name"),
                Price = reader.GetFieldValue<int>("Price")
            };
        }
    }
}
