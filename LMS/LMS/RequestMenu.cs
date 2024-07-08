using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LMS
{
    public partial class RequestMenu : Form
    {
        private int cid;
        public RequestMenu(int cid)
        {
            InitializeComponent();
            this.cid = cid;
            reqLV.View = View.Details;
            reqLV.Columns.Add("sId", 50, HorizontalAlignment.Center);
            reqLV.Columns.Add("Name", 120, HorizontalAlignment.Center);
            reqLV.Columns.Add("Family", 120, HorizontalAlignment.Center);
            reqLV.Columns.Add("Email", 150, HorizontalAlignment.Center);
        }

        private void RequestMenu_Load(object sender, EventArgs e)
        {
            loadRequests();

        }

        private void loadRequests()
        {
            reqLV.Items.Clear();
            string query = "SELECT s.sId as sId, s.Name as Name, s.Family as Family, s.Email as Email FROM Registration_Request as r JOIN Student as s ON r.sId = s.sId WHERE r.cId = @cId";
            SqlParameter[] sqlParameters = {
                new SqlParameter("@cId", SqlDbType.Int) {Value = cid}
            };
            DataTable dt = DBHelper.ExecuteQuery(query, sqlParameters);
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem(dr["sId"].ToString());
                item.SubItems.Add(dr["Name"].ToString());
                item.SubItems.Add(dr["Family"].ToString());
                item.SubItems.Add(dr["Email"].ToString());
                reqLV.Items.Add(item);
            }
        }

        private void accBT_Click(object sender, EventArgs e)
        {
            if (reqLV.SelectedItems.Count > 0)
            {
                ListViewItem slcItem = reqLV.SelectedItems[0];
                int sId = int.Parse(slcItem.SubItems[0].Text);
                SqlParameter[] sqlParameters = {
                new SqlParameter("@sId", SqlDbType.Int) {Value = sId},
                };
                string query = "DELETE FROM Registration_Request WHERE sId = @sId";
                DBHelper.ExecuteNonQuery(query, sqlParameters);
                sqlParameters = new SqlParameter[] {
                new SqlParameter("@sId", SqlDbType.Int) {Value = sId},
                new SqlParameter("@cId", SqlDbType.Int) {Value = cid}
                };
                query = "INSERT INTO Registration (sId, cId) VALUES (@sId, @cId)";
                DBHelper.ExecuteNonQuery(query, sqlParameters);
                RequestMenu_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Please select a request!");
            }
        }

        private void rejBT_Click(object sender, EventArgs e)
        {
            if (reqLV.SelectedItems.Count > 0)
            {
                ListViewItem slcItem = reqLV.SelectedItems[0];
                int sId = int.Parse(slcItem.SubItems[0].Text);
                SqlParameter[] sqlParameters = {
                new SqlParameter("@sId", SqlDbType.Int) {Value = sId},
                };
                string query = "DELETE FROM Registration_Request WHERE sId = @sId";
                DBHelper.ExecuteNonQuery(query, sqlParameters);
                RequestMenu_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Please select a request!");
            }
        }
    }
}
