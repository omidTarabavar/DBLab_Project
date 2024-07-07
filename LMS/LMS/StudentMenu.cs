using System;
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

        }
    }
}
