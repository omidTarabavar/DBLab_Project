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
            string email = emTB.Text;
            string password = pwTB.Text;
            int res = User.Login(email, password);
            if (res == 0)
            {
                Professor
            }

        }
    }
}
