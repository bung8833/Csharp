using System.Data.SqlClient;
using System.Linq;

namespace ISpan2023.EStore.SqlDataLayer
{
	public static partial class SqlExceptionExtensions
	{
		/// <summary>
		/// 擷取 SqlError.class>10的錯誤,合併成一個字串,用換行符號區隔
		/// </summary>
		/// <param name="source"></param>
		/// <returns></returns>
		public static string GetErrorMessage(this SqlException source)
		{
			return source==null
				? string.Empty
				: source.Errors.Cast<SqlError>()
					.Where(err => err.Class > 10)
					.Select(err => err.Message)
					.Aggregate((acc, next) => acc + "\r\n" + next);
			
		}
	}
}