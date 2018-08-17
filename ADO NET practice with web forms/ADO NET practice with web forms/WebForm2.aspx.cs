using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace ADO_NET_practice_with_web_forms
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        string CS = ConfigurationManager.ConnectionStrings["connection1"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLoadData_Click(object sender, EventArgs e)
        {
           
            using (SqlConnection connection = new SqlConnection(CS))
            {
                SqlCommand selectquery = new SqlCommand("select * from Employee", connection);
                connection.Open();
                GridView1.DataSource = selectquery.ExecuteReader();
                GridView1.DataBind();
                connection.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(CS))
            {
                SqlCommand countQuery = new SqlCommand();
                countQuery.CommandText = "select count(EmployeeID) from Employee";
                countQuery.Connection = connection;
                connection.Open();
                int RowsCount = (int)countQuery.ExecuteScalar();
                Response.Write("Number of rows =" +RowsCount.ToString());
                connection.Close();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(CS))
            {
                SqlCommand countQuery = new SqlCommand();
                countQuery.CommandText = "delete from Employee where EmployeeID='"+Convert.ToInt32(txtID.Text)+"'";
                countQuery.Connection = connection;
                connection.Open();
                int RowsAffected = countQuery.ExecuteNonQuery();
                Response.Write("Number of rows deleted or affected =" + RowsAffected.ToString());
                connection.Close();
            }
        }
    }
}