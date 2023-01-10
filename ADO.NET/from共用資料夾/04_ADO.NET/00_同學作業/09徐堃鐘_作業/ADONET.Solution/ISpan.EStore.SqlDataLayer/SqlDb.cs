using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.EStore.SqlDataLayer
{
    public class SqlDb
    {
        public static string ApplicationName { get; set; }
        public static int ConnectionTimeOut { get; set; } // def=0
        public static bool? Pooling { get; set; }
        public static string GetConnectionString(string KeyOfConnString)
        {
            var node = System.Configuration.ConfigurationManager
                                .ConnectionStrings[KeyOfConnString];

            if (node == null) throw new Exception($"找不到節點{KeyOfConnString}，請確認後再試一次");

            string connStr = node.ToString();

            var sb = new SqlConnectionStringBuilder(connStr);
            if (string.IsNullOrEmpty(ApplicationName) == false) sb.ApplicationName = ApplicationName;
            if (ConnectionTimeOut > 0) sb.ConnectTimeout = ConnectionTimeOut; // 預設是15秒
            if (Pooling.HasValue) sb.Pooling = Pooling.Value; // 預設是true,表示要不要使用連線池

            return sb.ToString();
        }
        public static SqlConnection GetConnection() { return GetConnection("default"); }

		public static SqlConnection GetConnection(string KeyOfConnString = "default")
        {
            string connStr = GetConnectionString(KeyOfConnString);
            return new SqlConnection(connStr); // 建立一個SqlConnection 物件並傳回
        }

        public static int UpdateOrDelete(Func<SqlConnection> funcConnection , string sql, params SqlParameter[] parameters)
        {
            using (var conn = funcConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand(sql, conn))
                {
                    if(parameters!=null) cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteNonQuery(); // 回傳被異動的筆數
                }
            }
        }

        public static int Create(Func<SqlConnection> funcConnection, string sql, params SqlParameter[] parameters)
        {
            sql += ";SELECT SCOPE_IDENTITY();";

			using (var conn = funcConnection())
			{
				using (var cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.CommandText = sql;
					if (parameters != null) cmd.Parameters.AddRange(parameters);

					return Convert.ToInt32(cmd.ExecuteScalar());
				}
			}
		}

        public static T Get<T>(Func<SqlConnection> funcConnection, Func<SqlDataReader, T> funcAssembler, string sql, params SqlParameter[] parameters)
        {
			using (var conn = funcConnection())
			{
				using (var cmd = new SqlCommand(sql, conn))
				{
					conn.Open();

					if (parameters != null) cmd.Parameters.AddRange(parameters);
					var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                    return reader.Read()
                    ? funcAssembler(reader)
                    : default(T);
				}
			}
		}

        public static IEnumerable<T> Search<T>(Func<SqlConnection> funcConnection, Func<SqlDataReader, T> funcAssembler,
                                                string sql, params SqlParameter[] parameters)
        {
            using (var conn = funcConnection())
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = sql;
					if (parameters != null) cmd.Parameters.AddRange(parameters);

					var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                    while (reader.Read())
                    {
                        yield return funcAssembler(reader);
                    }
				}
            }
        }
    }
}
