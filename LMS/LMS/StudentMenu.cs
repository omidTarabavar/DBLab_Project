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
            crsLVStd.View = View.Details;
            crsLVStd.Columns.Add("cId", 39, HorizontalAlignment.Center);
            crsLVStd.Columns.Add("Title", 50, HorizontalAlignment.Center);
            crsLVStd.Columns.Add("Semester", 70, HorizontalAlignment.Center);
            crsLVStd.Columns.Add("Department", 80, HorizontalAlignment.Center);
            crsLVStd.Columns.Add("pId", 40, HorizontalAlignment.Center);
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
            crsLVStd.Items.Clear();
            DataTable dt = Student.getCoursesForStd(student.id);
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem(dr["cId"].ToString());
                item.SubItems.Add(dr["Title"].ToString());
                item.SubItems.Add(dr["Semester"].ToString());
                item.SubItems.Add(dr["Department"].ToString());
                item.SubItems.Add(dr["pId"].ToString());
                crsLVStd.Items.Add(item);
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

        private void chngProf_Click_1(object sender, EventArgs e)
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

        private void saveBT_Click_1(object sender, EventArgs e)
        {
            int res = User.ChangeProfile(student.id, nameTB.Text, familyTB.Text, emailTB.Text, pwTB.Text, pnTB.Text, 1);
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

        private void button2_Click(object sender, EventArgs e)
        {
            ListViewItem slcItem = crsLVStd.SelectedItems[0];
            int cid = int.Parse(slcItem.SubItems[0].Text);
            string title = slcItem.SubItems[1].Text;
            int sem = int.Parse(slcItem.SubItems[2].Text);
            string dep = slcItem.SubItems[3].Text;
            int pid = int.Parse(slcItem.SubItems[4].Text);
            Course slcCrs = new Course(cid, title, sem, dep, pid);
            CourseMenuStd courseMenuStd = new CourseMenuStd(slcCrs);
            this.Hide();
            courseMenuStd.ShowDialog();
            StudentMenu_Load(sender, e);
            this.Show();
        }
    }
}
