using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ADO_NET_practice_with_web_forms
{
    public partial class CachingDataSet : System.Web.UI.Page
    {
        string CS = ConfigurationManager.ConnectionStrings["connection1"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLoadData_Click(object sender, EventArgs e)
        {
            if (Cache["data"] == null)
            {
                using (SqlConnection connection = new SqlConnection(CS))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter("select * from Employee", connection);
                    DataSet db = new DataSet();
                    adapter.Fill(db);
                    Cache["data"] = db;
                    GridView1.DataSource = db;
                    GridView1.DataBind();
                }
                lblMessage.Text = "data loaded from the database";
            }
            else
            {
                GridView1.DataSource = (DataSet)Cache["data"];
                GridView1.DataBind();
                lblMessage.Text = "data loaded from the Cache";
            }
        }

        protected void btnClearCache_Click(object sender, EventArgs e)
        {
            if (Cache["data"] != null)
            {
                Cache.Remove("data");
                lblMessage.Text = "dataset removed from cache";
            }
            else
            {
                lblMessage.Text = "cache already empty ";
            }
        }
    }
}