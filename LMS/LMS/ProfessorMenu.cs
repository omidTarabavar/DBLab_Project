using System;
using System.Data;
using System.Windows.Forms;

namespace LMS
{
    public partial class ProfessorMenu : Form
    {
        private Professor professor;
        public ProfessorMenu(Professor professor)
        {
            InitializeComponent();
            this.professor = professor;
        }

        private void ProfessorMenu_Load(object sender, EventArgs e)
        {
            saveBT.Visible = false;
            chngProf.Visible = true;
            nameTB.ReadOnly = true;
            familyTB.ReadOnly = true;
            emailTB.ReadOnly = true;
            pwTB.ReadOnly = true;
            pnTB.ReadOnly = true;
            nameTB.Text = professor.name;
            familyTB.Text = professor.family;
            emailTB.Text = professor.email;
            pwTB.Text = "********";
            pnTB.Text = professor.phoneNumber;
            loadCourses();
        }

        private void loadCourses()
        {
            courseBox.Items.Clear();
            DataTable dt = Professor.getCoursesForProf(professor.id);
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
            pwTB.Text = professor.password;
            pnTB.ReadOnly = false;
            saveBT.Visible = true;
            chngProf.Visible = false;
        }

        private void saveBT_Click(object sender, EventArgs e)
        {
            int res = User.ChangeProfile(professor.id, nameTB.Text, familyTB.Text, emailTB.Text, pwTB.Text, pnTB.Text, 0);
            if (res == 1)
            {
                professor.name = nameTB.Text;
                professor.family = familyTB.Text;
                professor.email = emailTB.Text;
                professor.password = pwTB.Text;
                professor.phoneNumber = pnTB.Text;
                ProfessorMenu_Load(sender, EventArgs.Empty);
            }
            else
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCourse addCourse = new AddCourse(professor.id);
            addCourse.ShowDialog();
            ProfessorMenu_Load(sender, e);
            this.Show();
        }
    }
}
