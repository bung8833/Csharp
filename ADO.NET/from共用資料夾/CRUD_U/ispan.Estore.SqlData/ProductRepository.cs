using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ispan.Estore.SqlData
{
	public class ProductRepository
	{
		public IEnumerable<ProductDto>Search(int? categoryId=null,string productName=null)
		{
			//這一行可以不必寫,只是方便日後在sql profiler查看
			SQLDb.ApplicationName = "demo:search";

			#region 生成sql statement
			string sql = $@"
select P.*,C.Name as CategoryName
from Products as P inner join Categories as C on(P.CategoryId =C.Id)";

			#region 生成where子句
			string where =string.Empty;

			var parameters = new List<SqlParameter>();
			if (categoryId.HasValue)
			{
				//最前面要加空白,才不會跟上面連一起
				where += $" and P.CategoryId={categoryId.Value}";
			}
			if (string.IsNullOrEmpty(productName) == false)
			{
				//where += $" and P.Name Like '%{productName}%'";
				where += $" And P.Name Like '%'+ @productName +'%'";
				parameters.Add(new SqlParameter("@productName", System.Data.SqlDbType.NVarChar, 50) { Value = productName });
			}
			where = where == string.Empty ? where : where = " where " + where.Substring(5);
			sql += where;
			#endregion
			//最前面要加空白,才不會跟上面連一起
			sql += " Order By C.DisplayOrder";
			#endregion

			return SQLDb.Search(SQLDb.GetConnection, ProductDto.GetInstance, sql, parameters.ToArray());
			//using (var conn = SQLDb.GetConnection())
			//{
			//	using(var cmd = conn.CreateCommand())
			//	{
			//		conn.Open();
			//		cmd.CommandText = sql;
			//		cmd.Parameters.AddRange(parameters.ToArray()); //Add一個參數 AddRange多個參數
			//		var reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

			//		while (reader.Read())
			//		{
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
