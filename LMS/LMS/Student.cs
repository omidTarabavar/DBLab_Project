using System.Data;
using System.Data.SqlClient;

namespace LMS
{
    public class Student : User
    {
        public Student(string name, string family, string email, string pass, string pn) : base(name, family, email, pass, pn)
        {

        }
        public static Student GetStd(string email, string password)
        {
            SqlParameter[] sqlParameters = {
                new SqlParameter("@Email", SqlDbType.VarChar) { Value = email },
                new SqlParameter("@Password", SqlDbType.VarChar) { Value = password }
            };

            string query = "SELECT Name, Family, Email, Password, Phonenumber FROM Student WHERE Email = @Email AND Password = @Password";
            DataRow res = DBHelper.ExecuteQuery(query, sqlParameters).Rows[0];
            return new Student(res["Name"].ToString(), res["Family"].ToString(), res["Email"].ToString(), res["Password"].ToString(), res["Phonenumber"].ToString());
        }
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
