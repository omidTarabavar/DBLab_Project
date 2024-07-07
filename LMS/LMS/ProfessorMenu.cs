using System;
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

        }
    }
}
