using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ispan.Estore.SqlDataLayer
{
    public class ProductRepository_old
    {
        public IEnumerable<ProductDto> Search(int? categoryId=null, string prodName= null) {
            // 方便debug用的
            SqlDB.ApplicationName = "Demo:search products"; 
            // return null;

            #region 生成 sql statement
            string sql = $@"
SELECT P.*, C.Name as CategoryName
FROM Products as P
INNER JOIN Categories C ON P.CategoryId = C.Id";

            #region 生成 where
            string where = string.Empty;
            //防止sql injection
            var parameters = new List<SqlParameter>();

            if (categoryId.HasValue)
            {
                where += $" AND P.CategoryId = {categoryId.Value}";
            }
            if (string.IsNullOrEmpty(prodName) == false) {
                // 防止sql injection
                //  where += $" AND P.Name LIKE '%{prodName}%'";
                where += $" AND P.Name LIKE '%' +@prodName +'%'";
                parameters.Add(new SqlParameter("@prodName", System.Data.SqlDbType.NVarChar, 50) { Value = prodName});
            }
            where = where == string.Empty ? where : " WHERE " + where.Substring(5);
            sql += where;
            #endregion
            // 最前面加空白才不會跟上面的黏在一起。
            sql += " ORDER BY C.DisplayOrder";
            #endregion
            return SqlDB.Search(SqlDB.GetConnection, ProductDto.GetInstance, sql, parameters.ToArray());

            //using (var conn = SqlDB.GetConnection()) {
            //    using (var cmd = conn.CreateCommand())
            //    {
            //        conn.Open();
            //        cmd.CommandText = sql;

            //        //防止SQL Injection
            //        cmd.Parameters.AddRange(parameters.ToArray());
            //        // 希望Reader結束自動關掉
            //        var reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            //        while (reader.Read())
            //        {
            //            var dto = ProductDto.GetInstance(reader);
            //            yield return dto; //惰性求值
            //        }

            //    }
            
            //}
        }
    }

    public class ProductDto {

        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Name { get; set; }
        public int Price {get; set; }
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
