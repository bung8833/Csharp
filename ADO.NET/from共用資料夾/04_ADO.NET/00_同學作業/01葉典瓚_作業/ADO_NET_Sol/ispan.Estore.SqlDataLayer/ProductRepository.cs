using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ispan.Estore.SqlDataLayer
{
    public class ProductRepository
    {
        private readonly string _tableName = "Products";
        public Func<SqlConnection> funConn = SqlDB.GetConnection;
        public Func<SqlDataReader, ProductEntity> funcAssembler = ProductEntity.GetInstance;


        public int Create(ProductEntity entity) {
            SqlDB.ApplicationName = "有尊嚴的_create";
            // SQL參數化
            string sql = $@"insert into {_tableName}
(CategoryId, Name, Description, Price, Status ,ProductImage,Stock )
VALUES
(@CategoryId, @Name, @Description, @Price,@Status ,@ProductImage, @Stock)";

            var parameters = SqlParameterBuilder.Create()
            .AddInt("@CategoryId", entity.CategoryId)
            .AddNVarchar("@Name", entity.Name, 50)
            .AddNVarchar("@Description", entity.Description, 50)
            .AddInt("@Price", entity.Price)
            .AddBool("@Status", entity.Status)
            .AddNVarchar("@ProductImage", entity.ProductImage, 256)
            .AddInt("@Stock", entity.Stock)
            .Build();
            int newId = 0;
            try { 
                SqlDB.Create(SqlDB.GetConnection, sql, parameters);
            }
            catch(SqlException ex)
            {
                if (ex.Message.Contains("Ix_Users"))
                {
                    throw new Exception("您新增的帳號已存在，請修改後再試一次", ex);
                }
                
            }


            return newId;
        }


        public int Delete(int userId)
        {
            //string sql = $@"DELETE FROM {_tableName} Where Id = {userId}";
            //int rowAffected = SqlDB.UpdateOrDelete(funConn, sql);
            //return rowAffected;

            string sql = $@"DELETE FROM {_tableName} Where Id = @Id";
            var parameters = SqlParameterBuilder.Create()
            .AddInt("@Id", userId)
            .Build();
            int rowAffected = SqlDB.UpdateOrDelete(funConn, sql, parameters);
            return rowAffected;

        }


        public int Update(ProductEntity entity)
        {
            //string sql = $@"DELETE FROM {_tableName} Where Id = {userId}";
            //int rowAffected = SqlDB.UpdateOrDelete(funConn, sql);
            //return rowAffected;

            string sql = $@"Update {_tableName} Set
CategoryId=@CategoryId,
Name=@Name,
Description=@Description,
Price=@Price,
Status=@Status,
ProductImage=@ProductImage
Stock=@Stock
Where Id = {entity.Id}";

            var parameters = SqlParameterBuilder.Create()
            .AddInt("@CategoryId", entity.CategoryId)
            .AddNVarchar("@Name", entity.Name, 50)
            .AddNVarchar("@Description", entity.Description, 50)
            .AddInt("@Price", entity.Price)
            .AddBool("@Status", entity.Status)
            .AddNVarchar("@ProductImage", entity.ProductImage, 256)
            .AddInt("@Stock", entity.Stock)
            .Build();
            int rowAffected = SqlDB.UpdateOrDelete(funConn, sql, parameters);
            return rowAffected;
        }

        public IEnumerable<ProductEntity> Search(string name, string account, string email) {
            var data = new ProductEntity();

            #region 生成 sql statement
            string sql = $@"
SELECT *
FROM {_tableName}";

            #region 生成 where
            string where = string.Empty;
            var parameters = new List<SqlParameter>();

            if (string.IsNullOrEmpty(name) == false)
            {
                where += $" AND Name LIKE '%' +@Name +'%'";
                parameters.Add(new SqlParameter("@Name", System.Data.SqlDbType.NVarChar, 50) { Value = name });
            }
            if (string.IsNullOrEmpty(account) == false)
            {
                where += $" AND Account LIKE '%' +@Account +'%'";
                parameters.Add(new SqlParameter("@Account", System.Data.SqlDbType.NVarChar, 50) { Value = account });
            }
            if (string.IsNullOrEmpty(email) == false)
            {
                where += $" AND Email LIKE '%' +@Email +'%'";
                parameters.Add(new SqlParameter("@Email", System.Data.SqlDbType.NVarChar, 50) { Value = email });
            }
            where = where == string.Empty ? where : " WHERE " + where.Substring(5);
            sql += where;
            #endregion
            #endregion
            return SqlDB.Search(funConn, funcAssembler, sql, parameters.ToArray());
        }

        public ProductEntity GetUser(int userId) {
            string sql = $"SELECT * FROM {_tableName} " +
                $"WHERE Id={userId}";
            return SqlDB.Get(funConn, funcAssembler, sql);
        }
    }

    public class ProductEntity
    { 
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description     { get; set; }
        public int Price { get; set; }
        public bool Status { get;set; }
        public string ProductImage { get;  set; }
        public int Stock { get; set; }

        public static ProductEntity GetInstance(SqlDataReader reader)
        {
            var entity = new ProductEntity();
            entity.Id = reader.GetFieldValue<int>("Id");
            entity.CategoryId = reader.GetFieldValue<int>("CategoryId");
            entity.Name = reader.GetFieldValue<string>("Name");
            entity.Description = reader.GetFieldValue<string>("Description");
            entity.Price = reader.GetFieldValue<int>("Price");
            entity.Status = reader.GetFieldValue<bool>("Status");
            entity.ProductImage = reader.GetFieldValue<string>("ProductImage");
            entity.Stock = reader.GetFieldValue<int>("Stock");

            return entity;
        }
    }


}
