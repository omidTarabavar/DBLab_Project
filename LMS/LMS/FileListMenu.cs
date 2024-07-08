using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LMS
{
    public partial class FileListMenu : Form
    {
        int cid;
        public FileListMenu(int cid)
        {
            InitializeComponent();
            this.cid = cid;
            fileListLV.View = View.Details;
            fileListLV.Columns.Add("fId", 40, HorizontalAlignment.Center);
            fileListLV.Columns.Add("Title", 70, HorizontalAlignment.Center);
            fileListLV.Columns.Add("Link", 150, HorizontalAlignment.Center);
            fileListLV.Columns.Add("cId", 40, HorizontalAlignment.Center);
        }

        private void FileListMenu_Load(object sender, EventArgs e)
        {
            fileListLV.Items.Clear();
            DataTable dt = File.GetFiles(cid);
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem(dr["fId"].ToString());
                item.SubItems.Add(dr["Title"].ToString());
                item.SubItems.Add(dr["Link"].ToString());
                item.SubItems.Add(dr["cId"].ToString());
                fileListLV.Items.Add(item);
            }
        }

        private void addFileBT_Click(object sender, EventArgs e)
        {
            AddFileMenu addFileMenu = new AddFileMenu(cid);
            this.Hide();
            addFileMenu.ShowDialog();
            this.Show();
            FileListMenu_Load(sender, e);
        }

        private void removeFileBT_Click(object sender, EventArgs e)
        {
            ListViewItem slcItem = fileListLV.SelectedItems[0];
            int fId = int.Parse(slcItem.SubItems[0].Text);
            SqlParameter[] sqlParameters = {
                new SqlParameter("@fId", SqlDbType.Int) {Value = fId},
            };
            string query = "DELETE FROM Files WHERE fId = @fId";
            DBHelper.ExecuteNonQuery(query, sqlParameters);
            FileListMenu_Load(sender, e);
        }
    }
}
