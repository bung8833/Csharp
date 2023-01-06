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
		public IEnumerable<ProductDto> Search(int? categoryId=null, string productName=null)
		{
			// 這一行可以不必寫,只是日後方便在 sql profiler查看而已
			SqlDb.ApplicationName = "demo:search products";

			#region 生成 sql statement
			string sql = $@"
SELECT P.*, C.Name as CategoryName
FROM Products as P
INNER JOIN Categories C ON P.CategoryId = C.Id";

			#region 生成where子句
			string where = string.Empty;

			// Allen 用來存放不特定數量的 SqlParameter
			var parameters = new List<SqlParameter>();

			if (categoryId.HasValue)
			{
				// 最前面要加空白,才不會跟上面的黏在一起
				where += $" AND P.CategoryId={categoryId.Value}";
			}
			if (string.IsNullOrEmpty(productName) == false)
			{
				// Allen where += $" AND P.Name LIKE '%{productName}%'";
				where += $" AND P.Name LIKE '%' + @productName + '%'";
				parameters.Add(new SqlParameter("@ProductName", System.Data.SqlDbType.NVarChar, 50) { Value=productName});
			}

			where = where == string.Empty ? where : where =" WHERE " + where.Substring(5);
			sql += where;

			#endregion

			// 最前面要加空白,才不會跟上面的黏在一起
			sql += " ORDER BY C.DisplayOrder";
			#endregion
			return SqlDb.Search(SqlDb.GetConnection, ProductDto.GetInstance, sql, parameters.ToArray());
			//using (var conn = SqlDb.GetConnection()) {
			//	using (var cmd = conn.CreateCommand())
			//	{
			//		conn.Open();
			//		cmd.CommandText = sql;
			//		// Allen 加入參數
			//		cmd.Parameters.AddRange(parameters.ToArray());

			//		var reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

			//		while (reader.Read()) {
			//			var dto = ProductDto.GetInstance(reader);
			//			yield return dto;
			//		}
			//	}
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
			return new ProductDto {
				Id = reader.GetFieldValue<int>("Id"),
				CategoryName = reader.GetFieldValue<string>("CategoryName"),
				Name = reader.GetFieldValue<string>("Name"),
				Price = reader.GetFieldValue<int>("Price")
			};
		}
	}
}
