using System;
using System.Data;
using System.Windows.Forms;

namespace LMS
{
    public partial class CourseMenuStd : Form
    {
        Course course;
        public CourseMenuStd(Course course)
        {
            InitializeComponent();
            this.course = course;
            fileLV.View = View.Details;
            fileLV.Columns.Add("fId", 39, HorizontalAlignment.Center);
            fileLV.Columns.Add("Title", 70, HorizontalAlignment.Center);
            fileLV.Columns.Add("Link", 150, HorizontalAlignment.Center);
        }

        private void CourseMenuStd_Load(object sender, EventArgs e)
        {
            fileLV.Items.Clear();
            loadFiles();
            titleTB.ReadOnly = true;
            semTB.ReadOnly = true;
            depTB.ReadOnly = true;
            pidTB.ReadOnly = true;
            titleTB.Text = course.title;
            semTB.Text = course.semester.ToString();
            depTB.Text = course.department;
            pidTB.Text = course.pid.ToString();
        }

        private void loadFiles()
        {
            DataTable dt = File.GetFiles(course.id);
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem(dr["fId"].ToString());
                item.SubItems.Add(dr["Title"].ToString());
                item.SubItems.Add(dr["Link"].ToString());
                fileLV.Items.Add(item);
            }
        }

        private void viewFileBT_Click(object sender, EventArgs e)
        {
            ListViewItem slcItem = fileLV.SelectedItems[0];
            int fid = int.Parse(slcItem.SubItems[0].Text);
            string title = slcItem.SubItems[1].Text;
            string link = slcItem.SubItems[2].Text;
            int cid = course.id;
            File slcFile = new File(fid, title, link, cid);
            FileMenuStd fileMenuStd = new FileMenuStd(slcFile);
            this.Hide();
            fileMenuStd.ShowDialog();
            CourseMenuStd_Load(sender, e);
            this.Show();
        }
    }
}
