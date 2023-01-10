using System;
using System.Data.SqlClient;

namespace ISpan.EStore.SqlDataLayer
{
	public static class SqlDataReaderExtensions
	{
		public static T GetFieldValue<T>(this SqlDataReader source, string columnName)
			=> source[columnName].Equals(DBNull.Value)
				? default(T)
				: (T)source[columnName];

	}
}