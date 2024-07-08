using System;
using System.Data;
using System.Windows.Forms;

namespace LMS
{
    public partial class StudentMenu : Form
    {
        private Student student;
        public StudentMenu(Student student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void StudentMenu_Load(object sender, EventArgs e)
        {
            saveBT.Visible = false;
            chngProf.Visible = true;
            nameTB.ReadOnly = true;
            familyTB.ReadOnly = true;
            emailTB.ReadOnly = true;
            pwTB.ReadOnly = true;
            pnTB.ReadOnly = true;
            nameTB.Text = student.name;
            familyTB.Text = student.family;
            emailTB.Text = student.email;
            pwTB.Text = "********";
            pnTB.Text = student.phoneNumber;
            loadCourses();
        }

        private void loadCourses()
        {
            courseBox.Items.Clear();
            DataTable dt = Student.getCoursesForStd(student.id);
            foreach (DataRow dr in dt.Rows)
            {
                courseBox.Items.Add(dr["Title"]);
            }
        }

        private void chngProf_Click(object sender, EventArgs e)
        {
            nameTB.ReadOnly = false;
            familyTB.ReadOnly = false;
            emailTB.ReadOnly = false;
            pwTB.ReadOnly = false;
            pwTB.Text = student.password;
            pnTB.ReadOnly = false;
            saveBT.Visible = true;
            chngProf.Visible = false;
        }

        private void saveBT_Click(object sender, EventArgs e)
        {
            int res = User.ChangeProfile(student.id, nameTB.Text, familyTB.Text, emailTB.Text, pwTB.Text, pnTB.Text, 0);
            if (res == 1)
            {
                student.name = nameTB.Text;
                student.family = familyTB.Text;
                student.email = emailTB.Text;
                student.password = pwTB.Text;
                student.phoneNumber = pnTB.Text;
                StudentMenu_Load(sender, EventArgs.Empty);
            }
            else
            {

            }
        }

        private void addCrsBT_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCourseStd addCourse = new AddCourseStd(student);
            addCourse.ShowDialog();
            StudentMenu_Load(sender, e);
            this.Show();
        }
    }
}
