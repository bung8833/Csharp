using ISpan2023.EStore.BLL.Core;
using System.Data.SqlClient;
using System;

namespace ISpan2023.EStore.SqlDataLayer.Extensions
{
	public static class UserEntityExtensions
	{
		public static UserEntity GetInstance(SqlDataReader reader)
		{
			var entity = new UserEntity();
			entity.Id = reader.GetFieldValue<int>("Id");
			entity.Name = reader.GetFieldValue<string>("Name");
			entity.Account = reader.GetFieldValue<string>("Account");
			entity.Password = reader.GetFieldValue<string>("Password");
			entity.DateOfBirth = reader.GetFieldValue<DateTime?>("DateOfBirth");
			entity.Height = reader.GetFieldValue<int?>("Height");
			entity.Email = reader.GetFieldValue<string>("Email");

			return entity;
		}
	}
}