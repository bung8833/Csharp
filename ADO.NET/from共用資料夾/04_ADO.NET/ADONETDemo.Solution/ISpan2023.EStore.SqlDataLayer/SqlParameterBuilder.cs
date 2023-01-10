using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System;

namespace ISpan2023.EStore.SqlDataLayer
{
	public class SqlParameterBuilder
	{
		private List<SqlParameter> _parameters;

		public SqlParameterBuilder()
		{
			_parameters = new List<SqlParameter>();
		}

		public static SqlParameterBuilder Create()
		{
			return new SqlParameterBuilder();
		}

		//public SqlParameterBuilder AddNullableInt(string name, int? value)
		//{
		//	return value == null
		//		? AddNullInt(name)
		//		: AddInt(name, value.Value);
		//}

		public SqlParameterBuilder AddInt(string name, int? value)
		{
			var parameter = value.HasValue
				? new SqlParameter(name, SqlDbType.Int) { Value = value }
				: new SqlParameter(name, SqlDbType.Int) { Value = DBNull.Value };
			_parameters.Add(parameter);

			return this;
		}
		//public SqlParameterBuilder AddNullInt(string name)
		//{
		//	var parameter = new SqlParameter(name, SqlDbType.Int) { Value = DBNull.Value };
		//	_parameters.Add(parameter);

		//	return this;
		//}

		//public SqlParameterBuilder AddNullableBool(string name, bool? value)
		//{
		//	return value == null
		//		? AddNullBool(name)
		//		: AddBool(name, value.Value);
		//}

		public SqlParameterBuilder AddBool(string name, bool? value)
		{
			var parameter = value.HasValue
			? new SqlParameter(name, SqlDbType.Bit) { Value = value }
			: new SqlParameter(name, SqlDbType.Bit) { Value = DBNull.Value };
			_parameters.Add(parameter);

			return this;
		}
		//public SqlParameterBuilder AddNullBool(string name)
		//{
		//	var parameter = new SqlParameter(name, SqlDbType.Bit) { Value = DBNull.Value };
		//	_parameters.Add(parameter);

		//	return this;
		//}

		public SqlParameterBuilder AddNVarchar(string name, int length, string value)
		{
			var parameter = string.IsNullOrEmpty(value)
				? new SqlParameter(name, SqlDbType.NVarChar, length) { Value = DBNull.Value }
				: new SqlParameter(name, SqlDbType.NVarChar, length) { Value = value };
			_parameters.Add(parameter);

			return this;
		}
		public SqlParameterBuilder AddVarchar(string name, int length, string value)
		{
			var parameter = string.IsNullOrEmpty(value)
				? new SqlParameter(name, SqlDbType.VarChar, length) { Value = DBNull.Value }
				: new SqlParameter(name, SqlDbType.VarChar, length) { Value = value };
			_parameters.Add(parameter);

			return this;
		}

		public SqlParameterBuilder AddDateTime(string name, DateTime? value)
		{
			var parameter = value.HasValue
			? new SqlParameter(name, SqlDbType.DateTime) { Value = value }
			: new SqlParameter(name, SqlDbType.DateTime) { Value = DBNull.Value };
			_parameters.Add(parameter);

			return this;
		}

		public SqlParameter[] Build()
		{
			return this._parameters.ToArray();
		}

		// 以下給學生實作
		//private SqlParameterBuilder AddNullDateTime(string name)
		//{
		//	var parameter = new SqlParameter(name, SqlDbType.DateTime){Value = DBNull.Value};
		//	_parameters.Add(parameter);

		//	return this;
		//}

		//public SqlParameterBuilder AddNullableDateTime(string name, DateTime? value)
		//{
		//	return value == null
		//		? AddNullDateTime(name)
		//		: AddDateTime(name, value.Value);
		//}
	}
}