using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSpan.EStore.SqlDataLayer
{
    

    public class ProductRepository
    {
        private readonly string _tableName = "Products";
        public Func<SqlConnection> funcConn = SqlDB.GetConnection;
        public Func<SqlDataReader, ProductDto> funcAssembler = ProductDto.GetInstance;
        public Func<SqlDataReader, ProductDetail> funcAssemblerD = ProductDetail.GetInstance;

        public int Create(ProductDetail entity)
        {
            string sql = $@"INSERT INTO {_tableName} 
(Name, CategoryId, Description, Price, Status, 
ProductImage, Stock) 
VALUES 
(@Name, @CategoryId, @Description, @Price, @Status, 
@ProductImage, @Stock)";

            var parameters = SqlParameterBuilder.Create()
                .AddNVarchar("@Name", entity.Name, 50)
                .AddInt("@CategoryName", entity.CategoryId)
                .AddNVarchar("@Description", entity.Description, 3000)
                .AddInt("@Price", entity.Price)
                .AddBool("@Status", entity.Status)
                .AddNVarchar("@ProductImage", entity.ProductImage, 70)
                .AddInt("@Stock", entity.Stock)
                .Build();

            int newId = SqlDB.Create(funcConn, sql, parameters);
            return newId;
        }

        public int Delete(int productId)
        {
            var sql = $@"DELETE {_tableName} WHERE Id={productId}";

            int affectedRows = SqlDB.UpdateOrDelete(funcConn, sql);
            return affectedRows;
        }

        public int Update(ProductDetail entity)
        {
            string sql = $@"UPDATE {_tableName} SET 
Name=@Name,
CategoryId=@CategoryId,
Description=@Description,
Price=@Price,
Status=@Status,
ProductImage=@ProductImage,
Stock=@Stock
WHERE Id={entity.Id}";

            var parameters = SqlParameterBuilder.Create()
                .AddNVarchar("@Name", entity.Name, 50)
                .AddInt("@CategoryName", entity.CategoryId)
                .AddNVarchar("@Description", entity.Description, 3000)
                .AddInt("@Price", entity.Price)
                .AddBool("@Status", entity.Status)
                .AddNVarchar("@ProductImage", entity.ProductImage, 70)
                .AddInt("@Stock", entity.Stock)
                .Build();

            int affectedRows = SqlDB.UpdateOrDelete(funcConn, sql, parameters);
            return affectedRows;
        }

        public IEnumerable<ProductDto> Search(int? categoryId = null,string productName= null,string categoryName = null)
        {
            SqlDB.Application = "demo:search products"; //可不寫，方便在SQL Profiler檢查

            #region 生成 sql statement
            string sql = $@"SELECT 
P.*,C.Name as CategoryName 
FROM Products as P INNER JOIN Categories as C ON P.CategoryId=C.Id";

            #region 生成 WHERE子句
            string where = string.Empty;

            var parameters = new List<SqlParameter>();

            if (categoryId.HasValue)
            {
                where += $" AND P.CategoryId={categoryId.Value}";
            }
            if (!string.IsNullOrEmpty(categoryName))
            {
                where += $" AND C.Name LIKE '%'+@categoryName+'%'";
                parameters.Add(new SqlParameter("@categoryName", System.Data.SqlDbType.NVarChar, 30) { Value = categoryName });
            }
            if (!string.IsNullOrEmpty(productName))
            {
                where += $" AND P.Name LIKE '%'+@productName+'%'";
                parameters.Add(new SqlParameter("@ProductName", System.Data.SqlDbType.NVarChar, 50) { Value = productName });
            }

            where = where == string.Empty ? where : " WHERE " + where.Substring(5);
            sql += where;
            #endregion

            sql += $" ORDER BY C.DisplayOrder";
            #endregion

            return SqlDB.Search(SqlDB.GetConnection, ProductDto.GetInstance, sql, parameters.ToArray());

            //using (var conn = SqlDB.GetConnection())
            //{
            //    using (var command = conn.CreateCommand())
            //    {
            //        conn.Open();
            //        command.CommandText = sql;

            //        command.Parameters.AddRange(parameter.ToArray());

            //        var reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            //        while (reader.Read())
            //        {
            //            var dto = ProductDto.GetInstance(reader);
            //            yield return dto;
            //        }
            //    }
            //}
        }

        public IEnumerable<ProductDetail> SearchDetail(int? categoryId = null, string categoryName = null, string name = null, bool? status = null)
        {
            #region 生成 sql statement
            string sql = $@"SELECT 
P.*,C.Name as CategoryName 
FROM Products as P INNER JOIN Categories as C ON P.CategoryId=C.Id";

            #region 生成 WHERE子句
            string where = string.Empty;

            var parameters = new List<SqlParameter>();

            if (categoryId.HasValue)
            {
                where += $" AND P.CategoryId={categoryId.Value}";
            }
            if (!string.IsNullOrEmpty(categoryName))
            {
                where += $" AND C.Name LIKE '%'+@categoryName+'%'";
                parameters.Add(new SqlParameter("@categoryName", System.Data.SqlDbType.NVarChar, 30) { Value = categoryName });
            }
            if (!string.IsNullOrEmpty(name))
            {
                where += $" AND P.Name LIKE '%'+@productName+'%'";
                parameters.Add(new SqlParameter("@ProductName", System.Data.SqlDbType.NVarChar, 50) { Value = name });
            }
            if (status.HasValue)
            {
                where += $" AND P.Status={status.Value}";
            }

            where = where == string.Empty ? where : " WHERE " + where.Substring(5);
            sql += where;
            #endregion

            sql += $" ORDER BY C.DisplayOrder";
            #endregion

            return SqlDB.Search(SqlDB.GetConnection, ProductDetail.GetInstance, sql, parameters.ToArray());
        }

        public ProductDetail GetProduct(int productId)
        {
            string sql = $"SELECT * FROM Products WHERE Id={productId}";
//            string sql = $@"SELECT 
//P.*,C.Name as CategoryName
//FROM 
//Products as P 
//INNER JOIN 
//Categories as C 
//ON P.CategoryId = C.Id 
//WHERE Id={productId}";
            return SqlDB.Get(funcConn, funcAssemblerD, sql);
        }



        public class ProductDto
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string CategoryName { get; set; }
            public int Price { get; set; }

            public static ProductDto GetInstance(SqlDataReader reader)
            {
                return new ProductDto
                {
                    Id = reader.GetFieldValue<int>("Id"),
                    Name = reader.GetFieldValue<string>("Name"),
                    CategoryName = reader.GetFieldValue<string>("CategoryName"),
                    Price = reader.GetFieldValue<int>("Price")
                };
            }
        }

        public class ProductDetail
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int CategoryId { get; set; }
            public string Description { get; set; }
            public int Price { get; set; }
            public bool Status { get; set; }
            public string ProductImage { get; set; }
            public int Stock { get; set; }

            public static ProductDetail GetInstance(SqlDataReader reader)
            {
                return new ProductDetail
                {
                    Id = reader.GetFieldValue<int>("Id"),
                    Name = reader.GetFieldValue<string>("Name"),
                    CategoryId = reader.GetFieldValue<int>("CategoryId"),
                    Description=reader.GetFieldValue<string>("Description"),
                    Price = reader.GetFieldValue<int>("Price"),
                    Status=reader.GetFieldValue<bool>("Status"),
                    ProductImage=reader.GetFieldValue<string>("ProductImage"),
                    Stock=reader.GetFieldValue<int>("Stock")
                };
            }
        }
    }
}
