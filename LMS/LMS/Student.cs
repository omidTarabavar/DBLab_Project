using System.Data;
using System.Data.SqlClient;

namespace LMS
{
    internal class Student : User
    {
        public static int RegisterInCourse(int cId, int sId)
        {
            string query;
            SqlParameter[] sqlParameters;
            query = "INSERT INTO Registration_Request (sId, cId) VALUES (@sId, @cId);";
            sqlParameters = new SqlParameter[] {
                    new SqlParameter("@sId", SqlDbType.Int) {Value = sId},
                    new SqlParameter("@cId", SqlDbType.Int) {Value = cId},
            };
            int res = DBHelper.ExecuteNonQuery(query, sqlParameters);
            if (res == 0)
                return -1;
            else
                return 1;
        }

        public static DataTable ViewFiles(int cId)
        {
            string query;
            SqlParameter[] sqlParameters;
            query = "SELECT FROM Files WHERE cId = @cId;";
            sqlParameters = new SqlParameter[] {
                    new SqlParameter("@cId", SqlDbType.Int) {Value = cId},
            };
            return DBHelper.ExecuteQuery(query, sqlParameters);
        }

        public static DataTable ViewExams(int cId)
        {
            string query;
            SqlParameter[] sqlParameters;
            query = "SELECT FROM Exams WHERE cId = @cId;";
            sqlParameters = new SqlParameter[] {
                    new SqlParameter("@cId", SqlDbType.Int) {Value = cId},
            };
            return DBHelper.ExecuteQuery(query, sqlParameters);
        }
    }
}
