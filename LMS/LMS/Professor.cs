using System.Data;
using System.Data.SqlClient;

namespace LMS
{
    public class Professor : User
    {
        public Professor(string name, string family, string email, string pass, string pn) : base(name, family, email, pass, pn)
        {

        }
        public static Professor GetProf(string email, string password)
        {
            SqlParameter[] sqlParameters = {
                new SqlParameter("@Email", SqlDbType.VarChar) { Value = email },
                new SqlParameter("@Password", SqlDbType.VarChar) { Value = password }
            };

            string query = "SELECT Name, Family, Email, Password, Phonenumber FROM Professor WHERE Email = @Email AND Password = @Password";
            DataRow res = DBHelper.ExecuteQuery(query, sqlParameters).Rows[0];
            return new Professor(res["Name"].ToString(), res["Family"].ToString(), res["Email"].ToString(), res["Password"].ToString(), res["Phonenumber"].ToString());
        }
        public static int CreateClass(string title, int semester, string department, int pId)
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

        public static int Create_Exam(string title, string due, string questions, string answers, int cId)
        {
            string query;
            SqlParameter[] sqlParameters;
            query = "INSERT INTO Exams (Title, Due, Questions, Answers, cId) VALUES (@Title, @Due, @Questions, @Answers, @cId);";
            sqlParameters = new SqlParameter[] {
                    new SqlParameter("@Title", SqlDbType.VarChar) {Value = title},
                    new SqlParameter("@Due", SqlDbType.DateTime) {Value = due},
                    new SqlParameter("@Questions", SqlDbType.VarChar) {Value = questions},
                    new SqlParameter("@Answers", SqlDbType.VarChar) {Value = answers},
                    new SqlParameter("@cId", SqlDbType.Int) {Value = cId},
            };
            int res = DBHelper.ExecuteNonQuery(query, sqlParameters);
            if (res == 0)
                return -1;
            else
                return 1;
        }

        public static int ChangeCourseInfo(string title, string semester, string department, int pId, int cId)
        {
            string query;
            SqlParameter[] sqlParameters;
            query = "UPDATE Course SET Title = @Title, Semester = @Semester, Department = @Department, pId = @pId WHERE cId = @cId;";
            sqlParameters = new SqlParameter[] {
                    new SqlParameter("@Title", SqlDbType.VarChar) {Value = title},
                    new SqlParameter("@Semester", SqlDbType.Int) {Value = semester},
                    new SqlParameter("@Department", SqlDbType.VarChar) {Value = department},
                    new SqlParameter("@pId", SqlDbType.Int) {Value = pId},
                    new SqlParameter("@cId", SqlDbType.Int) {Value = cId}
            };
            int res = DBHelper.ExecuteNonQuery(query, sqlParameters);
            if (res == 0)
                return -1;
            else
                return 1;
        }
    }
}
