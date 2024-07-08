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
            crsLV.View = View.Details;
            crsLV.Columns.Add("cId", 39, HorizontalAlignment.Center);
            crsLV.Columns.Add("Title", 50, HorizontalAlignment.Center);
            crsLV.Columns.Add("Semester", 70, HorizontalAlignment.Center);
            crsLV.Columns.Add("Department", 80, HorizontalAlignment.Center);
            crsLV.Columns.Add("pId", 40, HorizontalAlignment.Center);
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
            crsLV.Items.Clear();
            DataTable dt = Professor.getCoursesForProf(professor.id);
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem(dr["cId"].ToString());
                item.SubItems.Add(dr["Title"].ToString());
                item.SubItems.Add(dr["Semester"].ToString());
                item.SubItems.Add(dr["Department"].ToString());
                item.SubItems.Add(dr["pId"].ToString());
                crsLV.Items.Add(item);
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
                MessageBox.Show("Couldn't save this new information!");
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (crsLV.SelectedItems.Count > 0)
            {
                ListViewItem slcItem = crsLV.SelectedItems[0];
                int cid = int.Parse(slcItem.SubItems[0].Text);
                string title = slcItem.SubItems[1].Text;
                int sem = int.Parse(slcItem.SubItems[2].Text);
                string dep = slcItem.SubItems[3].Text;
                int pid = int.Parse(slcItem.SubItems[4].Text);
                Course slcCrs = new Course(cid, title, sem, dep, pid);
                CourseMenuProf courseMenuProf = new CourseMenuProf(slcCrs);
                this.Hide();
                courseMenuProf.ShowDialog();
                ProfessorMenu_Load(sender, e);
                this.Show();
            }
            else
            {
                MessageBox.Show("Please Select an item!");
            }
        }
    }
}
