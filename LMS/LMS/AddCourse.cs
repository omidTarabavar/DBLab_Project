using System;
using System.Windows.Forms;

namespace LMS
{
    public partial class AddCourse : Form
    {
        private int pid;
        public AddCourse(int pid)
        {
            InitializeComponent();
            this.pid = pid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (titleTB.Text.Equals("") || semTB.Text.Equals("") || depTB.Text.Equals("") || pidTB.Text.Equals(""))
            {
                MessageBox.Show("Please Complete the form!");
            }

            else
            {
                string title = titleTB.Text;
                int semester = int.Parse(semTB.Text);
                string department = depTB.Text;
                int pId = int.Parse(pidTB.Text);
                Professor.AddCourse(title, semester, department, pId);
                this.Close();
            }
        }

        private void AddCourse_Load(object sender, EventArgs e)
        {
            pidTB.Text = pid.ToString();
        }
    }
}
