using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.EStore.SqlDataLayer
{
	public class CategoryRepository
	{
		public static Func<SqlConnection> _funcConn = () => SqlDb.GetConnection("default");
		public static Func<SqlDataReader, Category> _funcAssembler = Category.GetInstance;
		private const string TableName = "Categories";
		public IEnumerable<Category> Search()
		{
			var sql = $@"SELECT * FROM {TableName} ORDER BY DisplayOrder";

			return SqlDb.Search(_funcConn, _funcAssembler, sql);
		}

		public Category GetCategory(int categoryId)
		{
			using (var conn = SqlDb.GetConnection())
			{
				var sql = $"SELECT * FROM Categories WHERE Id={categoryId}";
				using (var cmd = conn.CreateCommand())
				{
					conn.Open();

					cmd.CommandText = sql;
					var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection); // 在reader不再使用時,自動關閉connection
					if (reader.Read())
					{
						return Category.GetInstance_3(reader);
					}
					else
					{
						return null;
					}
				}
			}
		}

		public DataTable Update(DataTable dt)
		{
			SqlDataAdapter da = new SqlDataAdapter();
			using (var conn = SqlDb.GetConnection())
			{
				// 得知 dt 異動內容, 可以從changed.Rows看得到哪些記錄被異動
				var changed = dt.GetChanges();

				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = "SELECT * FROM Categories";
					da.SelectCommand = cmd;

					// CommandBuilder 用來協助產生 Insert, Update ,Delete Command
					SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(da);
					// 以下測試程式,可以看到SqlCommandBuilder可以協助生成 Update Command
					var updateCommand = cmdBuilder.GetUpdateCommand();

					int rowAffected = da.Update(dt); // 傳回受影響的筆數

					// 更新完畢之後, 就找不到異動內容
					var changed2 = dt.GetChanges(); // null
				}
			}

			return dt;
		}

		/// <summary>
		/// 使用 conn.BeginTrans, 將記錄異動包在一個交易裡
		/// </summary>
		/// <param name="dt"></param>
		/// <returns></returns>
		public void Update2(DataTable dt)
		{
			SqlDataAdapter da = new SqlDataAdapter();
			using (var conn = SqlDb.GetConnection())
			{
				conn.Open();
				SqlTransaction tx = conn.BeginTransaction();
				try
				{
					using (var cmd = conn.CreateCommand())
					{
						cmd.Transaction = tx;
						// 得知 dt 異動內容, 可以從changed.Rows看得到哪些記錄被異動
						var changed = dt.GetChanges();
						foreach (DataRow changedRow in changed.Rows)
						{
							cmd.Parameters.Clear();

							switch (changedRow.RowState)
							{
								case DataRowState.Added:
									// add record
									//string sql = "INSERT INTO Categories(Name,DisplayOrder)VALUES(@Name,@DisplayOrder)";
									//var parameters = SqlParameterBuilder.Create()
									//	.AddNVarchar("Name", 50, changedRow.Field<string>("Name"))
									//	.AddInt("DisplayOrder", changedRow.Field<int>("DisplayOrder"))
									//	.Build();
									//cmd.Parameters.AddRange(parameters);
									//cmd.CommandText = sql;
									//cmd.ExecuteNonQuery();
									AddRow(cmd, changedRow);
									break;
								case DataRowState.Modified:
									//update record
									//string sqlUpd = "UPDATE Categories SET Name=@Name,DisplayOrder=@DisplayOrder WHERE Id=@Id";
									//var updParameters = SqlParameterBuilder.Create()
									//	.AddNVarchar("Name", 50, changedRow.Field<string>("Name"))
									//	.AddInt("DisplayOrder", changedRow.Field<int>("DisplayOrder"))
									//	.AddInt("Id", changedRow.Field<int>("Id"))
									//	.Build();
									//cmd.Parameters.AddRange(updParameters);
									//cmd.CommandText = sqlUpd;
									//cmd.ExecuteNonQuery();
									UpdateRow(cmd, changedRow);
									break;
								case DataRowState.Deleted:
									//delete record
									//int delId = (int)changedRow["ID", DataRowVersion.Original];
									//string sqlDel = $"DELETE FROM Categories WHERE ID={delId}";
									//cmd.CommandText=sqlDel;
									//cmd.ExecuteNonQuery();
									DelRow(cmd, changedRow);
									break;
							}
						}
					}

					tx.Commit();
				}
				catch (Exception ex)
				{
					tx.Rollback();
					throw; // 繼續向外丟出異常
				}
			}


		}

		private void UpdateRow(SqlCommand cmd, DataRow changedRow)
		{
			string sql = "UPDATE Categories SET Name=@Name,DisplayOrder=@DisplayOrder WHERE Id=@Id";
			var updParameters = SqlParameterBuilder.Create()
				.AddNVarchar("Name", changedRow.Field<string>("Name"), 50)
				.AddInt("DisplayOrder", changedRow.Field<int>("DisplayOrder"))
				.AddInt("Id", changedRow.Field<int>("Id"))
				.Build();
			cmd.Parameters.AddRange(updParameters);
			cmd.CommandText = sql;
			cmd.ExecuteNonQuery();
		}

		private void AddRow(SqlCommand cmd, DataRow changedRow)
		{
			string sql = "INSERT INTO Categories(Name,DisplayOrder)VALUES(@Name,@DisplayOrder)";
			var parameters = SqlParameterBuilder.Create()
				.AddNVarchar("Name", changedRow.Field<string>("Name"), 50)
				.AddInt("DisplayOrder", changedRow.Field<int>("DisplayOrder"))
				.Build();
			cmd.Parameters.AddRange(parameters);
			cmd.CommandText = sql;
			cmd.ExecuteNonQuery();
		}

		private void DelRow(SqlCommand cmd, DataRow changedRow)
		{
			// 這是取得被刪除記錄 id 的寫法
			int delId = (int)changedRow["ID", DataRowVersion.Original];
			string sql = $"DELETE FROM Categories WHERE ID={delId}";
			cmd.CommandText=sql;
			cmd.ExecuteNonQuery();
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

	public class Category
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int DisplayOrder { get; set; }

		public static Category GetInstance(SqlDataReader reader)
		{
			var category = new Category();
			category.Id = int.Parse(reader["Id"].ToString());
			category.Name = reader["Name"].ToString();
			category.DisplayOrder = int.Parse(reader["DisplayOrder"].ToString());

			return category;

		}

		/// <summary>
		/// 針對欄位值是否為null,進行比較精緻的處理
		/// </summary>
		/// <param name="reader"></param>
		/// <returns></returns>
		public static Category GetInstance_2(SqlDataReader reader)
		{
			var category = new Category();
			category.Id = int.Parse(reader["Id"].ToString());

			int colIndex = reader.GetOrdinal("Name"); // 取得它在第幾欄
			if (reader.IsDBNull(colIndex) == false)
			{
				category.Name = reader.GetString(colIndex);
			}

			colIndex = reader.GetOrdinal("DisplayOrder");
			if (reader.IsDBNull(colIndex) == false)
			{
				category.DisplayOrder = reader.GetInt32(colIndex);
			}

			return category;

		}

		/// <summary>
		/// 針對欄位值是否為null,進行比較精緻的處理
		/// </summary>
		/// <param name="reader"></param>
		/// <returns></returns>
		public static Category GetInstance_3(SqlDataReader reader)
		{
			var category = new Category();

			category.Id = reader.GetFieldValue<int>("Id");
			category.Name = reader.GetFieldValue<string>("Name");
			category.DisplayOrder = reader.GetFieldValue<int>("DisplayOrder");

			return category;
		}

	}
}
