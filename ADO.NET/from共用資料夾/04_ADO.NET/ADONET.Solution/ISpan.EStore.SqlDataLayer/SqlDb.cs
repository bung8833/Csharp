using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.EStore.SqlDataLayer
{
    public class SqlDb
    {
        public static string ApplicationName { get; set; }
        public static int ConnectTimeout { get; set; } // def=0
        public static bool? Pooling { get; set; }

        /// <summary>
        /// 取得連線字串
        /// </summary>
        /// <param name="keyOfConnString"></param>
        /// <returns></returns>
        public static string GetConnectionString(string keyOfConnString)
        {
            var node = System.Configuration.ConfigurationManager
                                .ConnectionStrings[keyOfConnString];
            
            if (node == null) throw new Exception($"找不到節點{keyOfConnString} , 請確認後再次一次");

            string connStr = node.ToString();

            var sb = new SqlConnectionStringBuilder(connStr);
            if(string.IsNullOrEmpty(ApplicationName)==false) sb.ApplicationName = ApplicationName;
            if(ConnectTimeout > 0) sb.ConnectTimeout = ConnectTimeout; // 預設是15秒
            if(Pooling.HasValue) sb.Pooling = Pooling.Value; // 預設是true,表示要不要使用連線池

            return sb.ToString();
        }

        public static SqlConnection GetConnection(string keyOfConnString="default")
        {
            string connStr = GetConnectionString(keyOfConnString);
            return new SqlConnection(connStr); // 建立一個SqlConnection 物件並傳回
        }
    }
}
