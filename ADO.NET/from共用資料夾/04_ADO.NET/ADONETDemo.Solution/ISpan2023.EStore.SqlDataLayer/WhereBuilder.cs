using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;

namespace ISpan2023.EStore.SqlDataLayer
{
	public class WhereBuilder
	{
		public static WhereBuilder Create() => new WhereBuilder();
		string where = string.Empty;
		List<SqlParameter> parameters = new List<SqlParameter>();

		public WhereBuilder()
		{

		}

		public WhereBuilder Append(string parameterName, object value, string template, Func<object, string, SqlParameter> parameterCreater)
		{
			if (value == null) return this;
			string criteria = string.Format(template, "@" + parameterName);
			where += $" AND {criteria}";

			parameters.Add(parameterCreater(value, parameterName));

			return this;
		}

		public (string WhereString, SqlParameter[] Parameters) Build(string prefix)
		{
			var parameters = this.parameters.ToArray();
			string whereString = string.IsNullOrEmpty(where) ? string.Empty : prefix + where.Substring(5);

			return (whereString, parameters);
		}
	}
}