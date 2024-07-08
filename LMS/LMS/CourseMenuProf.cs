using System;
using System.Data;
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
            loadStudents();
        }

        private void loadStudents()
        {
            stdListBox.Items.Clear();
            DataTable dt = Course.getStudents(course.id);
            foreach (DataRow dr in dt.Rows)
            {
                stdListBox.Items.Add(dr["Name"]);
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
    }
}
