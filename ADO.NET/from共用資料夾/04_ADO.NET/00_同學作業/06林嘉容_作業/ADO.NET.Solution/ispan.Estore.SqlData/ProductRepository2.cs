using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ispan.Estore.SqlData
{
	public class ProductRepository2
	{
		private readonly string _tableName = "Products";
		private Func<SqlConnection> funConnection = SQLDb.GetConnection;
		public Func<SqlDataReader, ProductEntity> funcAssembler = ProductEntity.GetInstance;

		public int Create(ProductEntity entity)
		{
			string sql = $@"
INSERT INTO {_tableName}
(CategoryId,Name,Description,Price,Status,ProductImage,Stock)
VALUES
(@CategoryId,@Name,@Description,@Price,@Status,@ProductImage,@Stock);";

			var parameters = SqlParameterBuilder.Create()

				.AddInt("@CategoryId",entity.CategoryId)
				.AddNVarChar("@Name", entity.Name, 50)
				.AddNVarChar("@Description", entity.Description, 3000)
				.AddInt("@Price", entity.Price)
				.AddBool("@Status", entity.Status)
				.AddNVarChar("@ProductImage", entity.ProductImage, 70)
				.AddInt("@Stock",entity.Stock)

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

		public int Delete(int productId)
		{
			string sql = $@"DELETE FROM {_tableName} WHERE Id ={productId}";

			return SQLDb.UpdateOrDelete(funConnection, sql);
		}

		public int Update(ProductEntity entity)
		{
			string sql = $@"
UPDATE {_tableName}
SET CategoryId = @CategoryId, Name = @Name, Description = @Description, Price = @Price , Status = @Status, ProductImage = @ProductImage, Stock = @Stock
WHERE Id ={entity.Id};";

			var parameters = SqlParameterBuilder.Create()
				.AddInt("@CategoryId", entity.CategoryId)
				.AddNVarChar("@Name", entity.Name, 50)
				.AddNVarChar("@Description", entity.Description, 3000)
				.AddInt("@Price", entity.Price)
				.AddBool("@Status", entity.Status)
				.AddNVarChar("@ProductImage", entity.ProductImage, 70)
				.AddInt("@Stock", entity.Stock)
				.Build();

			return SQLDb.UpdateOrDelete(funConnection, sql, parameters);
		}

		public IEnumerable<ProductEntity> Search(int? Id , string name)
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
				parameters.Add(new SqlParameter("@Name", System.Data.SqlDbType.NVarChar, 50) { Value = name });
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

		public ProductEntity GetProduct(int productId)
		{
			string sql = $"SELECT * FROM {_tableName} WHERE Id ={productId}";

			return SQLDb.Get(funConnection, funcAssembler, sql);
		}
	}
	public class ProductEntity
	{
		public int Id { get; set; }
		public int? CategoryId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public int? Price { get; set; }
		public bool? Status { get; set; }
		public string ProductImage { get; set; }
		public int? Stock { get; set; }

		public static ProductEntity GetInstance(SqlDataReader reader) 
		{
			var entity = new ProductEntity();

			entity.Id = reader.GetFieldValue<int>("Id");
			entity.CategoryId= reader.GetFieldValue<int?>("CategoryId");
			entity.Name= reader.GetFieldValue<string>("Name");
			entity.Description= reader.GetFieldValue<string>("Description");
			entity.Price = reader.GetFieldValue<int?>("Price");
			entity.Status = reader.GetFieldValue<bool?>("Status");
			entity.ProductImage = reader.GetFieldValue<string>("ProductImage");
			entity.Stock = reader.GetFieldValue<int?>("Stock");

			return entity;
		}
	}
}
