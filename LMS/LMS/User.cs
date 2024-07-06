using System.Data;
using System.Data.SqlClient;

namespace LMS
{
    internal class User
    {
        public static int SignUp(string name, string family, string password, string email, string phoneNumber, int type)
        {
            string query;
            SqlParameter[] sqlParameters;
            if (type == 0) // type 0 = professor
            {
                query = "INSERT INTO Professor (Name, Family, Email, Password, Phonenumber) VALUES (@Name, @Family, @Email, @Password, @Phonenumber);";
                sqlParameters = new SqlParameter[] {
                    new SqlParameter("@Name", SqlDbType.NVarChar) {Value = name},
                    new SqlParameter("@Family", SqlDbType.NVarChar) {Value = family},
                    new SqlParameter("@Email", SqlDbType.NVarChar) {Value = email},
                    new SqlParameter("@Password", SqlDbType.NVarChar) {Value = password},
                    new SqlParameter("@Phonenumber", SqlDbType.NVarChar) {Value = phoneNumber}
                };

            }
            else // type 1 = student
            {
                query = "INSERT INTO Student (Name, Family, Email, Password, Phonenumber) VALUES (@Name, @Family, @Email, @Password, @Phonenumber);";
                sqlParameters = new SqlParameter[] {
                    new SqlParameter("@Name", SqlDbType.NVarChar) {Value = name},
                    new SqlParameter("@Family", SqlDbType.NVarChar) {Value = family},
                    new SqlParameter("@Email", SqlDbType.NVarChar) {Value = email},
                    new SqlParameter("@Password", SqlDbType.NVarChar) {Value = password},
                    new SqlParameter("@Phonenumber", SqlDbType.NVarChar) {Value = phoneNumber}
                };
            }
            int res = DBHelper.ExecuteNonQuery(query, sqlParameters);
            if (res == 0)
                return -1;
            else
                return 1;
        }

        public static int Login(string email, string password)
        {
            SqlParameter[] sqlParameters = {
                new SqlParameter("@Email", SqlDbType.NVarChar) { Value = email },
                new SqlParameter("@Password", SqlDbType.NVarChar) { Value = password }
            };

            string query = "SELECT pId FROM Professor WHERE Email = @Email AND Password = @Password";
            DataTable res = DBHelper.ExecuteQuery(query, sqlParameters);
            if (res.Rows.Count > 0)
                return 0;

            query = "SELECT sId FROM Student WHERE Email = @Email AND Password = @Password";
            res = DBHelper.ExecuteQuery(query, sqlParameters);
            if (res.Rows.Count > 0)
                return 1;
            return -1;
        }
    }
}
