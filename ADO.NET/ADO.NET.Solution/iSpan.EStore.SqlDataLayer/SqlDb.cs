using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSpan.EStore.SqlDataLayer
{
    public class SqlDb
    {
        public static string ApplicationName { get; set; }
        public static int ConnectionTimeout { get; set; }
        public static bool? Pooling { get; set; }
        
        
        /// <summary>
        /// 取得連線字串
        /// </summary>
        /// <param name="keyOfConnString"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static string GetConnectionString(String keyOfConnString)
        {
            var node = System.Configuration.ConfigurationManager
                                .ConnectionStrings[keyOfConnString];

            if (node == null)
            {
                throw new Exception($"找不到節點{keyOfConnString}");
            }

            string connStr = node.ToString();

            var sb = new SqlConnectionStringBuilder(connStr);

            if (String.IsNullOrEmpty(ApplicationName) == false)
            {
                sb.ApplicationName = ApplicationName;
            }
            if (ConnectionTimeout > 0) // 預設為15秒
            {
                sb.ConnectTimeout = ConnectionTimeout;
            }
            if (Pooling.HasValue) // 要不要使用連線池 預設是true
            {
                sb.Pooling = Pooling.Value;
            }

            return sb.ToString();
        }

        public static SqlConnection GetConnection(string keyOfConnString = "default")
        {
            string connStr = GetConnectionString(keyOfConnString);
            return new SqlConnection(connStr); // 建立一個SqlConnection物件並傳回
        }
    }
}
