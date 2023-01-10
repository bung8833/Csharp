using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan2023.EStore.SqlDataLayer
{
	public static partial class SqlDataReaderExtensions
	{
		public static T GetFieldValue<T>(this SqlDataReader source, string columnName)
			=> source[columnName].Equals(DBNull.Value)
				? default(T)
				: (T)source[columnName];

		public static string GetString(this SqlDataReader reader, string columnName)
		{
			// todo 如果欄位名稱不存在,會引發異常, ref https://stackoverflow.com/questions/681653/can-you-get-the-column-names-from-a-sqldatareader

			int colIndex = reader.GetOrdinal(columnName); // 取得它在第幾欄
			return reader.IsDBNull(colIndex)
				? null
				: reader.GetString(colIndex);
		}

		public static int? GetInt32(this SqlDataReader reader, string columnName)
		{
			int colIndex = reader.GetOrdinal(columnName);
			return reader.IsDBNull(colIndex)
				? (int?)null
				: reader.GetInt32(colIndex);
		}
		public static int GetInt32(this SqlDataReader reader, string columnName, int defaultValue)
		{
			int? result = reader.GetInt32(columnName);
			return result.HasValue ? result.Value : defaultValue;
		}

		public static DateTime? GetDateTime(this SqlDataReader reader, string columnName)
		{
			int colIndex = reader.GetOrdinal(columnName);
			return reader.IsDBNull(colIndex)
				? (DateTime?)null
				: reader.GetDateTime(colIndex);
		}
		public static DateTime GetDateTime(this SqlDataReader reader, string columnName, DateTime defaultValue)
		{
			DateTime? result = reader.GetDateTime(columnName);
			return result.HasValue ? result.Value : defaultValue;
		}
	}
}
