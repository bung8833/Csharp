using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ispan.Estore.SqlData
{
    public class SQLDb
    {
        public static string ApplicationName { get; set; }
        public static int ConnectTimeout { get; set; }
        public static bool? Pooling { get; set; }

        public static string GetConnectionString(string keyOfConnString)
        {
			//dll參考config
            var node =System.Configuration.ConfigurationManager
                               .ConnectionStrings[keyOfConnString];
            if (node == null) throw new Exception($"找不到節點{keyOfConnString},請再確認一次");
            string connStr = node.ToString();

            var sb = new SqlConnectionStringBuilder(connStr);
            if (string.IsNullOrEmpty(ApplicationName)==false) sb.ApplicationName = ApplicationName;
            if (ConnectTimeout>0) sb.ConnectTimeout = ConnectTimeout;
            if (Pooling.HasValue)sb.Pooling = Pooling.Value;
            
            return sb.ToString();
        }
        public static SqlConnection GetConnection() { return GetConnection("default"); }
		public static SqlConnection GetConnection(string keyOfConnString = "default")
        {
            string connStr = GetConnectionString(keyOfConnString);
            return new SqlConnection(connStr); //建立一個SqlConnection物件並傳回
        }

        public static int UpdateOrDelete(Func<SqlConnection>funConnection,string sql,params SqlParameter[]parameters)
        {
            using (var conn = funConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand(sql, conn))
                {
                    if (parameters != null) cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteNonQuery();
                }
            }
        }

		public static int Create(Func<SqlConnection> funConnection, string sql, params SqlParameter[] parameters)
		{
            sql += ";select SCOPE_IDENTITY()";
			using (var conn = funConnection())
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
		public static T Get<T>(Func<SqlConnection> funConnection,Func<SqlDataReader,T>funcAssembler, string sql, params SqlParameter[] parameters)
		{
			using (var conn = funConnection())
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
		public static IEnumerable<T> Search<T>(Func<SqlConnection> funConnection, Func<SqlDataReader, T> funcAssembler, string sql, params SqlParameter[] parameters)
		{
			
			using (var conn = funConnection())
			{
				using (var cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.CommandText = sql;
					if (parameters != null) cmd.Parameters.AddRange(parameters);//Add一個參數 AddRange多個參數
					var reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

					while (reader.Read())
					{
						yield return funcAssembler(reader);
					}
				}
			}
		}

	}
}
