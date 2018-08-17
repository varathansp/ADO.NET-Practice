using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ADO_NET_practice_with_web_forms
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnLoadData_Click(object sender, EventArgs e)
        {
            string cs = "data source=.;database=SampleDB;integrated security=true";
            using (SqlConnection connection = new SqlConnection(cs))
            {
                SqlCommand selectquery = new SqlCommand("select * from Employee", connection);
                connection.Open();
                GridView1.DataSource = selectquery.ExecuteReader();
                GridView1.DataBind();
                connection.Close();
            }

        }
    }
}