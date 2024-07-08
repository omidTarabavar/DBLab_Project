using System.Windows.Forms;

namespace LMS
{
    public partial class AddFileMenu : Form
    {
        int cid;
        public AddFileMenu(int cid)
        {
            InitializeComponent();
            this.cid = cid;
        }

        private void addFBT_Click(object sender, System.EventArgs e)
        {
            string title = titleTB.Text;
            string link = linkTB.Text;
            File.Upload_File(title, link, cid);
            this.Close();
        }
    }
}
