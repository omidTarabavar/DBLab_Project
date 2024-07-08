using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LMS
{
    public partial class CourseMenuProf : Form
    {
        private Course course;
        public CourseMenuProf(Course course)
        {
            InitializeComponent();
            this.course = course;
            stdLV.View = View.Details;
            stdLV.Columns.Add("sId", 40, HorizontalAlignment.Center);
            stdLV.Columns.Add("Name", 60, HorizontalAlignment.Center);
            stdLV.Columns.Add("Family", 70, HorizontalAlignment.Center);
            stdLV.Columns.Add("Email", 100, HorizontalAlignment.Center);
        }

        private void CourseMenuProf_Load(object sender, EventArgs e)
        {
            titleTB.Text = course.title;
            semTB.Text = course.semester.ToString();
            depTB.Text = course.department;
            pidTB.Text = course.pid.ToString();
            titleTB.ReadOnly = true;
            depTB.ReadOnly = true;
            semTB.ReadOnly = true;
            pidTB.ReadOnly = true;
            saveBT.Visible = false;
            chngDetBT.Visible = true;
            loadStudents();
        }

        private void loadStudents()
        {
            stdLV.Items.Clear();
            DataTable dt = Course.getStudents(course.id);
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem(dr["sId"].ToString());
                item.SubItems.Add(dr["Name"].ToString());
                item.SubItems.Add(dr["Family"].ToString());
                item.SubItems.Add(dr["Email"].ToString());
                stdLV.Items.Add(item);
            }
        }

        private void chngDetBT_Click(object sender, EventArgs e)
        {
            titleTB.ReadOnly = false;
            depTB.ReadOnly = false;
            semTB.ReadOnly = false;
            pidTB.ReadOnly = false;
            saveBT.Visible = true;
            chngDetBT.Visible = false;
        }

        private void saveBT_Click(object sender, EventArgs e)
        {
            string title = titleTB.Text;
            string dep = depTB.Text;
            int sem = int.Parse(semTB.Text);
            int pid = int.Parse(pidTB.Text);
            int res = Course.ChangeCourseInfo(title, sem, dep, pid, course.id);
            if (res == 1)
            {
                course.title = title;
                course.semester = sem;
                course.pid = pid;
                course.department = dep;
                CourseMenuProf_Load(sender, e);
            }
        }

        private void reqBT_Click(object sender, EventArgs e)
        {
            RequestMenu reqMenu = new RequestMenu(course.id);
            this.Hide();
            reqMenu.ShowDialog();
            CourseMenuProf_Load(sender, e);
            this.Show();
        }

        private void rmvStdBT_Click(object sender, EventArgs e)
        {
            if (stdLV.SelectedItems.Count > 0)
            {
                ListViewItem slcItem = stdLV.SelectedItems[0];
                int sId = int.Parse(slcItem.SubItems[0].Text);
                SqlParameter[] sqlParameters = {
                new SqlParameter("@sId", SqlDbType.Int) {Value = sId},
                };
                string query = "DELETE FROM Registration WHERE sId = @sId";
                DBHelper.ExecuteNonQuery(query, sqlParameters);
                CourseMenuProf_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Please select a student!");
            }
        }

        private void fileBT_Click(object sender, EventArgs e)
        {
            FileListMenu fileListMenu = new FileListMenu(course.id);
            this.Hide();
            fileListMenu.ShowDialog();
            this.Show();
        }
    }
}
