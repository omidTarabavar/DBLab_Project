using System;
using System.Windows.Forms;

namespace LMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (emTB.Text.Equals("") || pwTB.Text.Equals(""))
                MessageBox.Show("Please Complete the form!");
            else
            {
                string email = emTB.Text;
                string password = pwTB.Text;
                int res = User.Login(email, password);
                if (res == 0)
                {
                    Professor professor = Professor.GetProf(email, password);
                    ProfessorMenu professorMenu = new ProfessorMenu(professor);
                    this.Hide();
                    professorMenu.ShowDialog();
                    this.Dispose();
                }
                else if (res == 1)
                {
                    Student student = Student.GetStd(email, password);
                    StudentMenu studentMenu = new StudentMenu(student);
                    this.Hide();
                    studentMenu.ShowDialog();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Wrong information!");
                }
            }

        }
    }
}
