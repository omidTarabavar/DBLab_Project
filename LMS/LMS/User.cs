using System.Data;
using System.Data.SqlClient;

namespace LMS
{
    public class User
    {
        string name, family, password, email, phoneNumber;
        public User(string name, string family, string email, string password, string phoneNumber)
        {
            this.name = name;
            this.family = family;
            this.email = email;
            this.password = password;
            this.phoneNumber = phoneNumber;
        }
        public static int SignUp(string name, string family, string password, string email, string phoneNumber, int type)
        {
            string query;
            SqlParameter[] sqlParameters;
            if (type == 0) // type 0 = professor
            {
                query = "INSERT INTO Professor (Name, Family, Email, Password, Phonenumber) VALUES (@Name, @Family, @Email, @Password, @Phonenumber);";
                sqlParameters = new SqlParameter[] {
                    new SqlParameter("@Name", SqlDbType.VarChar) {Value = name},
                    new SqlParameter("@Family", SqlDbType.VarChar) {Value = family},
                    new SqlParameter("@Email", SqlDbType.VarChar) {Value = email},
                    new SqlParameter("@Password", SqlDbType.VarChar) {Value = password},
                    new SqlParameter("@Phonenumber", SqlDbType.VarChar) {Value = phoneNumber}
                };

            }
            else // type 1 = student
            {
                query = "INSERT INTO Student (Name, Family, Email, Password, Phonenumber) VALUES (@Name, @Family, @Email, @Password, @Phonenumber);";
                sqlParameters = new SqlParameter[] {
                    new SqlParameter("@Name", SqlDbType.VarChar) {Value = name},
                    new SqlParameter("@Family", SqlDbType.VarChar) {Value = family},
                    new SqlParameter("@Email", SqlDbType.VarChar) {Value = email},
                    new SqlParameter("@Password", SqlDbType.VarChar) {Value = password},
                    new SqlParameter("@Phonenumber", SqlDbType.VarChar) {Value = phoneNumber}
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
                new SqlParameter("@Email", SqlDbType.VarChar) { Value = email },
                new SqlParameter("@Password", SqlDbType.VarChar) { Value = password }
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

        public static int ChangeProfile(string name, string family, string password, string email, string phoneNumber, int type, int id)
        {
            string query;
            SqlParameter[] sqlParameters = {
                new SqlParameter("@Name", SqlDbType.VarChar) {Value = name},
                    new SqlParameter("@Family", SqlDbType.VarChar) {Value = family},
                    new SqlParameter("@Email", SqlDbType.VarChar) {Value = email},
                    new SqlParameter("@Password", SqlDbType.VarChar) {Value = password},
                    new SqlParameter("@Phonenumber", SqlDbType.VarChar) {Value = phoneNumber},
                    new SqlParameter("@Id", SqlDbType.Int) {Value = id}
            };
            if (type == 0) // type 0 = professor
            {
                query = "UPDATE Professor SET Name = @Name, Family = @Family, Email = @Email, Password = @Password, Phonenumber = @Phonenumber WHERE pId = @Id;";
            }
            else // type 1 = student
            {
                query = "UPDATE Student SET Name = @Name, Family = @Family, Email = @Email, Password = @Password, Phonenumber = @Phonenumber WHERE sId = @Id;";
            }
            int res = DBHelper.ExecuteNonQuery(query, sqlParameters);
            if (res == 0)
                return -1;
            else
                return 1;

        }
    }
}
