using System.Data;
using System.Data.SqlClient;

namespace LMS
{
    internal class Professor : User
    {
        public static int CreateClass(string title, int semester, string department, int pId)
        {
            string query;
            SqlParameter[] sqlParameters;
            query = "INSERT INTO Course (Title, Semester, Department, pId) VALUES (@Title, @Semester, @Department, @pId);";
            sqlParameters = new SqlParameter[] {
                    new SqlParameter("@Title", SqlDbType.NVarChar) {Value = title},
                    new SqlParameter("@Semester", SqlDbType.Int) {Value = semester},
                    new SqlParameter("@Department", SqlDbType.NVarChar) {Value = department},
                    new SqlParameter("@pId", SqlDbType.Int) {Value = pId},
            };
            int res = DBHelper.ExecuteNonQuery(query, sqlParameters);
            if (res == 0)
                return -1;
            else
                return 1;
        }

        public static int Accept_Request(int sId, int cId)
        {
            string query;
            SqlParameter[] sqlParameters;
            sqlParameters = new SqlParameter[] {
                    new SqlParameter("@sId", SqlDbType.Int) {Value = sId},
                    new SqlParameter("@cId", SqlDbType.Int) {Value = cId}
            };
            query = "DELETE FROM Registration_Request WHERE sId = @sId AND cId = @cId;";
            DBHelper.ExecuteNonQuery(query, sqlParameters);
            query = "INSERT INTO Registration (sId, cId, grade) VALUES (@sId, @cId, NULL);";
            int res = DBHelper.ExecuteNonQuery(query, sqlParameters);
            if (res == 0) return -1;
            else return 1;
        }
    }
}
