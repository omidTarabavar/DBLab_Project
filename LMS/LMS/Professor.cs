using System.Data;
using System.Data.SqlClient;

namespace LMS
{
    public class Professor : User
    {
        public Professor(int id, string name, string family, string email, string pass, string pn) : base(id, name, family, email, pass, pn)
        {

        }
        public static Professor GetProf(string email, string password)
        {
            SqlParameter[] sqlParameters = {
                new SqlParameter("@Email", SqlDbType.VarChar) { Value = email },
                new SqlParameter("@Password", SqlDbType.VarChar) { Value = password }
            };
            string query = "SELECT pId, Name, Family, Email, Password, Phonenumber FROM Professor WHERE Email = @Email AND Password = @Password";
            DataRow res = DBHelper.ExecuteQuery(query, sqlParameters).Rows[0];
            return new Professor(int.Parse(res["pId"].ToString()), res["Name"].ToString(), res["Family"].ToString(), res["Email"].ToString(), res["Password"].ToString(), res["Phonenumber"].ToString());
        }

        public static DataTable getCoursesForProf(int pId)
        {
            string query = "SELECT * FROM Course WHERE pId = @pId";
            SqlParameter[] sqlParameters = {
                new SqlParameter("@pId", SqlDbType.Int) { Value = pId }
            };
            return DBHelper.ExecuteQuery(query, sqlParameters);
        }

        public static int AddCourse(string title, int semester, string department, int pId)
        {
            string query;
            SqlParameter[] sqlParameters;
            query = "INSERT INTO Course (Title, Semester, Department, pId) VALUES (@Title, @Semester, @Department, @pId);";
            sqlParameters = new SqlParameter[] {
                    new SqlParameter("@Title", SqlDbType.VarChar) {Value = title},
                    new SqlParameter("@Semester", SqlDbType.Int) {Value = semester},
                    new SqlParameter("@Department", SqlDbType.VarChar) {Value = department},
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

        public static int Reject_Request(int sId, int cId)
        {
            string query;
            SqlParameter[] sqlParameters;
            sqlParameters = new SqlParameter[] {
                    new SqlParameter("@sId", SqlDbType.Int) {Value = sId},
                    new SqlParameter("@cId", SqlDbType.Int) {Value = cId}
            };
            query = "DELETE FROM Registration_Request WHERE sId = @sId AND cId = @cId;";
            int res = DBHelper.ExecuteNonQuery(query, sqlParameters);
            if (res == 0) return -1;
            else return 1;
        }
    }
}
