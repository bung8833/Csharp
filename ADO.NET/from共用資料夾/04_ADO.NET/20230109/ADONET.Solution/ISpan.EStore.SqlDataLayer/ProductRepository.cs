using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.EStore.SqlDataLayer
{
	public class ProductRepository
	{
		public static Func<SqlConnection> _funcConn = () => SqlDb.GetConnection("default");
		public static Func<SqlDataReader, ProductEntity> _funcAssembler = ProductEntity.GetInstance;
		private const string TableName = "Products";

		public int Create(ProductEntity entity)
		{
			string sql = $@"INSERT INTO {TableName}
(CategoryId , Name, Description, Price, Status , ProductImage, Stock)
VALUES
(@CategoryId , @Name, @Description, @Price, @Status , @ProductImage, @Stock)";

			var parameters = SqlParameterBuilder.Create()
				.AddInt("CategoryId", entity.CategoryId)
				.AddNVarchar("Name", entity.Name, 50)
				.AddNVarchar("Description", entity.Description, 3000)
				.AddInt("Price", entity.Price)
				.AddBool("Status", entity.Status)
				.AddNVarchar("ProductImage", entity.ProductImage, 70)
				.AddInt("Stock", entity.Stock)
				.Build();

			int newId = SqlDb.Create(_funcConn, sql, parameters);
			return newId;
		}

		public int Delete(int productId)
		{
			var sql = $"DELETE FROM {TableName} WHERE Id={productId}";
			int rowsAffected = SqlDb.UpdateOrDelete(_funcConn, sql);
			return rowsAffected;
		}

		public int Update(ProductEntity entity)
		{
			var sql = $@"UPDATE {TableName} SET
CategoryId=@CategoryId
,Name=@Name
,Description=@Description
,Price=@Price
,Status=@Status
,ProductImage=@ProductImage
,Stock=@Stock
WHERE Id={entity.Id}";

			var parameters = SqlParameterBuilder.Create()
				.AddInt("CategoryId", entity.CategoryId)
				.AddNVarchar("Name", entity.Name, 50)
				.AddNVarchar("Description", entity.Description, 3000)
				.AddInt("Price", entity.Price)
				.AddBool("Status", entity.Status)
				.AddNVarchar("ProductImage", entity.ProductImage, 70)
				.AddInt("Stock", entity.Stock)
				.Build();

			int rowsAffected = SqlDb.UpdateOrDelete(_funcConn, sql, parameters);
			return rowsAffected;
		}

		public IEnumerable<ProductDto> Search(int? categoryId = null, string productName = null)
		{
			SqlDb.ApplicationName = "demo:search Products";

			#region 生成 sql statement

			var sql = $@"SELECT P.*, C.Name as CategoryName
FROM Products as P
INNER JOIN Categories as C ON P.CategoryId = C.Id";
			#region generate where


			var whereObj = WhereBuilder.Create()
				.Append("CategoryId", categoryId, "P.CategoryId={0}",
					(v, name) => new SqlParameter(name, SqlDbType.Int) { Value = categoryId.Value })
				.Append("ProductName", productName,
						"P.Name LIKE '%' + {0} + '%'",
					(v, name) => new SqlParameter(name, SqlDbType.NVarChar, 50) { Value = productName })
				.Build(" WHERE ");
			#endregion

			sql += whereObj.WhereString;
			sql += " ORDER BY C.DisplayOrder"; // 最前面要加空白

			#endregion

			return SqlDb.Search(_funcConn, ProductDto.GetInstance, sql, whereObj.Parameters);

		}
		public ProductEntity GetProduct(int productId)
		{
			string sql = $"SELECT * FROM {TableName} WHERE Id={productId}";

			return SqlDb.Get(_funcConn, _funcAssembler, sql);
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

	public class ProductEntity
	{
		public int Id { get; set; }
		public int CategoryId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public int Price { get; set; }
		public bool Status { get; set; }

		public string ProductImage { get; set; }

		public int Stock { get; set; }

		public static ProductEntity GetInstance(SqlDataReader reader)
		{
			var entity = new ProductEntity
			{
				Id = reader.GetFieldValue<int>("Id"),
				CategoryId = reader.GetFieldValue<int>("CategoryId"),
				Name = reader.GetFieldValue<string>("Name"),
				Description = reader.GetFieldValue<string>("Description"),
				Price = reader.GetFieldValue<int>("Price"),
				Status = reader.GetFieldValue<bool>("status"),
				ProductImage = reader.GetFieldValue<string>("ProductImage"),
				Stock = reader.GetFieldValue<int>("Stock")
			};

			return entity;

		}
	}
}
