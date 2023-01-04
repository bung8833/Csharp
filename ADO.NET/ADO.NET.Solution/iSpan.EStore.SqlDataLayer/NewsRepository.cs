using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSpan.EStore.SqlDataLayer
{
    public class NewsRepository
    {
        public int Create(News entity)
        {
            string sql = @"
INSERT INTO News
(Title, Description, CreatedTime, ModifiedTime)
VALUES
(@Title, @Description, @CreatedTime, @ModifiedTime);

SET @newId = SCOPE_IDENTITY();";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Title", System.Data.SqlDbType.NVarChar, 50){ Value=entity.Title },
                new SqlParameter("@Description", System.Data.SqlDbType.NVarChar, 3000){ Value=entity.Description },
                new SqlParameter("@CreatedTime", System.Data.SqlDbType.DateTime){ Value=entity.CreatedTime },
                new SqlParameter("@ModifiedTime", System.Data.SqlDbType.DateTime){ Value=entity.ModifiedTime },

                new SqlParameter("@newId", System.Data.SqlDbType.Int){ Direction = System.Data.ParameterDirection.Output },
            };

            using (var conn = SqlDb.GetConnection())
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = sql;
                    cmd.Parameters.AddRange(parameters);

                    cmd.ExecuteNonQuery();

                    return (int)cmd.Parameters["@newId"].Value;
                }
            }
        }
    }

    public class News
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime ModifiedTime { get; set; }
    }
}
