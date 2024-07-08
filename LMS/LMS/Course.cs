using System.Data;
using System.Data.SqlClient;

namespace LMS
{
    public class Course
    {
        public int semester, pid, id;
        public string title, department;

        public Course(int id, string title, int semester, string department, int pid)
        {
            this.id = id;
            this.title = title;
            this.semester = semester;
            this.department = department;
            this.pid = pid;
        }

        public static DataTable getStudents(int cid)
        {
            string query = "SELECT s.sId as sId, s.Name as Name, s.Family as Family FROM Registration as r JOIN Student as s ON r.sId = s.sId WHERE r.cId = @cId";
            SqlParameter[] sqlParameters = {
                new SqlParameter("@cId", SqlDbType.Int) { Value = cid }
            };
            return DBHelper.ExecuteQuery(query, sqlParameters);
        }

        public static int ChangeCourseInfo(string title, int semester, string department, int pId, int cId)
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
