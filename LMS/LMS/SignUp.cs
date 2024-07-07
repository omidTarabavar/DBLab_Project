using System;
using System.Windows.Forms;

namespace LMS
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = nameTB.Text;
            string family = familyTB.Text;
            string email = EmailTB.Text;
            string password = PassTB.Text;
            string phoneNumber = PNTB.Text;
            if (profRB.Checked)
            {
                int res = User.SignUp(name, family, email, password, phoneNumber, 0);
                if (res == 1)
                {
                    Professor professor = Professor.GetProf(email, password);
                    ProfessorMenu professorMenu = new ProfessorMenu(professor);
                    this.Hide();
                    professorMenu.ShowDialog();
                    this.Dispose();
                }
            }
            else if (stdRB.Checked)
            {
                int res = User.SignUp(name, family, email, password, phoneNumber, 1);
                if (res == 1)
                {
                    Student student = Student.GetStd(email, password);
                    StudentMenu studentMenu = new StudentMenu(student);
                    this.Hide();
                    studentMenu.ShowDialog();
                    this.Dispose();
                }
            }


        }
    }
}
