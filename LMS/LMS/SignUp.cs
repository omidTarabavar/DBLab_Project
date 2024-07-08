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
            if (nameTB.Text.Equals("") || familyTB.Text.Equals("") || EmailTB.Text.Equals("") || PassTB.Text.Equals("") || PNTB.Text.Equals("") || (!profRB.Checked && !stdRB.Checked))
            {
                MessageBox.Show("Please Complete the form!");
            }
            else
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
                    else
                    {
                        MessageBox.Show("Wrong info! Maybe duplicate email.");
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
                    else
                    {
                        MessageBox.Show("Wrong info! Maybe duplicate email.");
                    }
                }
            }
        }
    }
}
