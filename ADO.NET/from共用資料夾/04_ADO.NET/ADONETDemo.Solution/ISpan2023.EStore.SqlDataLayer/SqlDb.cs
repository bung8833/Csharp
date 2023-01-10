using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan2023.EStore.SqlDataLayer
{
	public class SqlDb
	{
		public static string ApplicationName { get; set; }
		public static int ConnectionTimeout { get; set; } // 預設 15 秒
		public static bool? Pooling { get; set; }
		public static string InitialCatalog { get; set; }
		public static string UserId { get; set; }
		public static string Password { get; set; }

		public static string GetConnectionString(string keyOfConnString)
		{
			string connStr = System.Configuration.ConfigurationManager.ConnectionStrings[keyOfConnString].ToString();

			if (string.IsNullOrEmpty(connStr)) throw new Exception($"找不到連線字串, key={keyOfConnString}");

			SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder(connStr);

			#region 允許 client 微調Timeout, ApplicationName
			// sb.DataSource // 指定Server
			// sb.UserID // 指定user id
			// sb.Password // 指定 password
			// sb.InitialCatalog // 指定 database
			// sb.MaxPoolSize // 指定 max pool size, 預設 100
			// sb.MultipleActiveResultSets = true;

			if (ApplicationName != null) sb.ApplicationName = ApplicationName;
			if (ConnectionTimeout > 0) sb.ConnectTimeout = ConnectionTimeout;
			if (Pooling.HasValue) sb.Pooling= Pooling.Value;
			if (string.IsNullOrEmpty(InitialCatalog)==false) sb.InitialCatalog=InitialCatalog;
			if (string.IsNullOrEmpty(UserId) == false) sb.UserID = UserId;
			if (string.IsNullOrEmpty(Password) == false) sb.Password = Password;

			#endregion

			return sb.ToString();
		}

		public static SqlConnection GetConnection()
			=> GetConnection("default");

		public static SqlConnection GetConnection(string keyOfConnString)
		=> new SqlConnection(GetConnectionString(keyOfConnString));

		public static int UpdateOrDelete(Func<SqlConnection> funcConn, string sql, params SqlParameter[] parameters)
		{
			using (var conn = funcConn())
			{
				conn.Open();
				using (var cmd = new SqlCommand(sql, conn))
				{
					if (parameters != null) cmd.Parameters.AddRange(parameters);
					return cmd.ExecuteNonQuery(); // 傳回被異動的筆數,若為零,表示沒有異動記錄
				}
			}
		}

		public static int Create(Func<SqlConnection> funcConn, string sql, params SqlParameter[] parameters)
		{
			// 取得剛新增資料的自動編號
			sql += ";SELECT SCOPE_IDENTITY()";

			using (var conn = funcConn())
			{
				conn.Open();
				using (var cmd = new SqlCommand(sql, conn))
				{
					if (parameters != null) cmd.Parameters.AddRange(parameters);
					return Convert.ToInt32(cmd.ExecuteScalar());
				}
			}
		}

		public static T Get<T>(Func<SqlConnection> funcConn, Func<SqlDataReader, T> funcAssembler, string sql, params SqlParameter[] parameters)
		{
			using (var conn = funcConn())
			{
				conn.Open();

				using (var cmd = new SqlCommand(sql, conn))
				{
					if (parameters != null) cmd.Parameters.AddRange(parameters);

					var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
					return reader.Read()
						? funcAssembler(reader)
						: default(T);
				}
			}
		}

		public static IEnumerable<T> Search<T>(Func<SqlConnection> funcConn, Func<SqlDataReader, T> funcAssembler, string sql, params SqlParameter[] parameters)
		{
			using (var conn = funcConn())
			{
				conn.Open();
				using (var cmd = new SqlCommand(sql, conn))
				{
					if (parameters != null) cmd.Parameters.AddRange(parameters);

					var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

					while (reader.Read())
					{
						T entity = funcAssembler(reader);
						yield return entity;
					}
				}


			}
		}
	}
}
