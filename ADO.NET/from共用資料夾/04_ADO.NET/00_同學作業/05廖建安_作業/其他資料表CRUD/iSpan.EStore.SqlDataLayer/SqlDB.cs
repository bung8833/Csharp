using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static iSpan.EStore.SqlDataLayer.ProductRepository;

namespace iSpan.EStore.SqlDataLayer
{
    public class SqlDB
    {
        public static string Application { get; set; }
        public static int ConnectTimeout { get; set; }
        public static bool? Pooling { get; set; }

        /// <summary>
        /// 取得連結字串
        /// </summary>
        /// <param name="keyOfConnection"></param>
        /// <returns></returns>
        public static string GetConnectionString(string keyOfConnString)
        {
            var node = System.Configuration.ConfigurationManager.ConnectionStrings[keyOfConnString];
            if (node == null) throw new Exception($"找不到節點{keyOfConnString}");

            string connStr = node.ToString();

            var sb = new SqlConnectionStringBuilder(connStr);
            if(!string.IsNullOrEmpty(Application)) sb.ApplicationName = Application;
            if(ConnectTimeout > 0) sb.ConnectTimeout = ConnectTimeout;
            if(Pooling.HasValue) sb.Pooling = Pooling.Value;

            return sb.ToString();
        }

        public static SqlConnection GetConnection(string keyOfConnString = "default")
        {
            string connStr = GetConnectionString(keyOfConnString);
            return new SqlConnection(connStr);
        }
        public static SqlConnection GetConnection() => GetConnection("default");
        public static int UpdateOrDelete(Func<SqlConnection> funcConnection,string sql, params SqlParameter[] parameters)
        {
            using (var conn= funcConnection())
            {
                conn.Open();
                using (var command = new SqlCommand(sql, conn))
                {
                    if (parameters != null) command.Parameters.AddRange(parameters);
                    return command.ExecuteNonQuery();
                }
            }
        }

        public static int Create(Func<SqlConnection> funcConnection, string sql, params SqlParameter[] parameters)
        {
            sql += ";SELECT SCOPE_IDENTITY()";

            using (var conn = funcConnection())
            {
                using (var command = conn.CreateCommand())
                {
                    conn.Open();
                    command.CommandText = sql;
                    if (parameters != null) command.Parameters.AddRange(parameters);

                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }

        public static T Get<T>(
            Func<SqlConnection> funcConnection,
            Func<SqlDataReader,T> funcAssembler, 
            string sql, 
            params SqlParameter[] parameters)
        {
            using (var conn = SqlDB.GetConnection())
            {
                using (var command = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    var reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                    return reader.Read() ? 
                        funcAssembler(reader) : 
                        default(T);
                }
            }
        }

        public static IEnumerable<T> Search<T>(
            Func<SqlConnection> funcConnection, 
            Func<SqlDataReader, T> funcAssembler, 
            string sql, 
            params SqlParameter[] parameters)
        {
            using (var conn = SqlDB.GetConnection())
            {
                using (var command = conn.CreateCommand())
                {
                    conn.Open();
                    command.CommandText = sql;
                    if (parameters != null) command.Parameters.AddRange(parameters.ToArray());
                    var reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        yield return funcAssembler(reader);
                    }
                }
            }
        }
    }

    public static class SqlDataReaderExtensions
    {
        public static T GetFieldValue<T>(this SqlDataReader source, string columnName)
            => source[columnName].Equals(DBNull.Value) ? default(T) : (T)source[columnName];

        //public static T GetFieldValue<T>(this SqlDataReader source,string columnName)
        //{
        //    //T defaultValue = default;

        //    return source[columnName].Equals(DBNull.Value) ? default(T) : (T)source[columnName];
        //    //if (source[columnName].Equals(DBNull.Value)) return defaultValue;
        //    //return (T)source[columnName];
        //}
    }
}
