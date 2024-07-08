using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LMS
{
    public partial class AddCourseStd : Form
    {
        private Student student;
        public AddCourseStd(Student student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void AddCourseStd_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cId = int.Parse(textBox1.Text);
            string query = "INSERT INTO Registration_Request (sId, cId) VALUES (@sId, @cId);";
            SqlParameter[] sqlParameters = {
                new SqlParameter("@sId", SqlDbType.VarChar) {Value = student.id},
                    new SqlParameter("@cId", SqlDbType.Int) {Value = cId}
            };
            int res = DBHelper.ExecuteNonQuery(query, sqlParameters);
            if (res > 0)
            {
                this.Dispose();
            }
            else
            {

            }
        }
    }
}
