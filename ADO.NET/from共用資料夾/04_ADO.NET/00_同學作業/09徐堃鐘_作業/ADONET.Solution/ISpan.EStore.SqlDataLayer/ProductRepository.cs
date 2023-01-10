using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.EStore.SqlDataLayer
{
	public class ProductRepository
	{
        private readonly string _tableName = "Products";
        public Func<SqlConnection> funcConn = SqlDb.GetConnection;
        public Func<SqlDataReader, ProductEntity> funcAssembler = ProductEntity.GetInstance;

        public int Create(ProductEntity entity)
        {
            string sql = $@"INSERT INTO {_tableName}
(CategoryId, Name, Description, Price, Status, ProductImage, Stock)
VALUES
(@CategoryId, @Name, @Description, @Price, @Status, @ProductImage, @Stock)";

            var parameters = SqlParameterBuilder.Create()
                .AddInt("CategoryId", entity.CategoryId)
                .AddNVarchar("Name", entity.Name, 50)
                .AddNVarchar("Description", entity.Description, 3000)
                .AddInt("Price", entity.Price)
                .AddInt("Status", entity.Status)
                .AddNVarchar("ProductImage", entity.ProductImage, 70)
                .AddInt("Stock", entity.Stock)
                .Build();

            int newId = 0;

            try
            {
                newId = SqlDb.Create(funcConn, sql, parameters);
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("IX_Products"))
                {
                    throw new Exception("您新增的產品已存在，請修改後再試一次", ex);
                }

            }

            return newId;
        }

        public IEnumerable<ProductDto> Search(int? categoryId=null, string productName=null)
		{
			// 方便日後在 SQL Profiler查看
			SqlDb.ApplicationName = "demo:search products";

			#region 生成SQL statement
			string sql = $@"
SELECT P.*, C.Name as CategoryName
FROM Products as P
INNER JOIN Categories C ON P.CategoryId = C.Id";
			
			#region 生成where子句
			string where = string.Empty;
			// 用來存放不特定數量的 SqlParameter
			var parameters = new List<SqlParameter>();

			if (categoryId.HasValue)
			{
				// 最前面要加空白，才不會跟上面的黏在一起
				where += $" AND P.CategoryId={categoryId.Value}";
			}
			if (string.IsNullOrEmpty(productName) == false)
			{
				//where += $" AND P.Name LIKE '%{productName}%'";
				where += $" AND P.Name LIKE '%' + @productName + '%'";
				parameters.Add(new SqlParameter("@productName", System.Data.SqlDbType.NVarChar, 50) { Value = productName });
			}

			where = where == string.Empty ? where : where =" WHERE " + where.Substring(5);
			sql += where;

			#endregion

			// 最前面要加空白，才不會跟上面的黏在一起
			sql += " ORDER BY C.DisplayOrder";
			#endregion
			return SqlDb.Search(SqlDb.GetConnection, ProductDto.GetInstence, sql, parameters.ToArray());
			//using (var conn = SqlDb.GetConnection()) {
			//	using (var cmd = conn.CreateCommand())
			//	{
			//		conn.Open();
			//		cmd.CommandText = sql;
			//		// 加入參數
			//		cmd.Parameters.AddRange(parameters.ToArray());

			//		var reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

			//		while (reader.Read()) {
			//			var dto = ProductDto.GetInstence(reader);
			//			yield return dto;
			//		}
			//	}
			//}
		}

		public class ProductDto
		{
			public int Id { get; set; }
			public string CategoryName { get; set; }
			public string Name { get; set; }
			public int price { get; set; }
			public static ProductDto GetInstence(SqlDataReader reader)
			{
				return new ProductDto {
					Id = reader.GetFieldValue<int>("Id"),
					CategoryName = reader.GetFieldValue<string>("CategoryName"),
					Name = reader.GetFieldValue<string>("Name"),
					price = reader.GetFieldValue<int>("Price")
				};
			}
		}

        public class ProductEntity
        {
            public int Id { get; set; }
            public int CategoryId { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public int Price { get; set; }
            public int Status { get; set; }
            public string ProductImage { get; set; }
			public int Stock { get; set; }

			public static ProductEntity GetInstance(SqlDataReader reader)
            {
                var entity = new ProductEntity();
                entity.Id = reader.GetFieldValue<int>("Id");
                entity.CategoryId = reader.GetFieldValue<int>("CategoryId");
                entity.Name = reader.GetFieldValue<string>("Name");
                entity.Description = reader.GetFieldValue<string>("Description");
                entity.Price = reader.GetFieldValue<int>("Price");
                entity.Status = reader.GetFieldValue<int>("Status");
                entity.ProductImage = reader.GetFieldValue<string>("ProductImage");
                entity.Stock = reader.GetFieldValue<int>("Stock");

                return entity;
            }

        }
    }
}
