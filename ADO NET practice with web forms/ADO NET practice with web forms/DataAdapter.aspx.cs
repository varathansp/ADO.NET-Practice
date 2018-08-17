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
    public partial class DataAdapter : System.Web.UI.Page
    {
        string CS = ConfigurationManager.ConnectionStrings["connection1"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(CS))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("select * from Employee",connection);
                DataSet db = new DataSet();
                adapter.Fill(db);
                GridView1.DataSource = db;
                GridView1.DataBind();
            }

        }
    }
}