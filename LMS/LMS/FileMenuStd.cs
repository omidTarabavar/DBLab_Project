using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace LMS
{
    public partial class FileMenuStd : Form
    {
        File file;
        public FileMenuStd(File file)
        {
            InitializeComponent();
            this.file = file;
        }

        private void downBT_Click(object sender, EventArgs e)
        {
            string url = linkTB.Text;
            if (!url.StartsWith("http://") && !url.StartsWith("https://"))
            {
                url = "http://" + url;
            }

            if (Uri.IsWellFormedUriString(url, UriKind.Absolute))
            {
                try
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = url,
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid Link!");
                }
            }
        }

        private void FileMenuStd_Load(object sender, EventArgs e)
        {
            titleTB.Text = file.title;
            linkTB.Text = file.link;
            titleTB.ReadOnly = true;
            linkTB.ReadOnly = true;
        }
    }
}
