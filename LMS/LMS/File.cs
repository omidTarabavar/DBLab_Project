using System.Data;
using System.Data.SqlClient;

namespace LMS
{
    public class File
    {
        public int id, cId;
        public string title, link;

        public File(int id, string title, string link, int cId)
        {
            this.id = id;
            this.cId = cId;
            this.title = title;
            this.link = link;
        }

        public static DataTable GetFiles(int cid)
        {
            string query = "SELECT * FROM Files WHERE cId = @cId";
            SqlParameter[] sqlParameters = {
                new SqlParameter("@cId", SqlDbType.Int) { Value = cid }
            };
            return DBHelper.ExecuteQuery(query, sqlParameters);
        }

        public static int Upload_File(string title, string link, int cId)
        {
            string query;
            SqlParameter[] sqlParameters;
            query = "INSERT INTO Files (Title, Link, cId) VALUES (@Title, @Link, @cId);";
            sqlParameters = new SqlParameter[] {
                    new SqlParameter("@Title", SqlDbType.VarChar) {Value = title},
                    new SqlParameter("@Link", SqlDbType.VarChar) {Value = link},
                    new SqlParameter("@cId", SqlDbType.Int) {Value = cId},
            };
            int res = DBHelper.ExecuteNonQuery(query, sqlParameters);
            if (res == 0)
                return -1;
            else
                return 1;
        }
    }
}
