using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace ADO_NET_practice_with_web_forms
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string CS = ConfigurationManager.ConnectionStrings["connection1"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(CS))
            {
                DataTable table = new DataTable();
                table.Columns.Add("EmployeeName");
                table.Columns.Add("Salary");
                table.Columns.Add("RevisedSalary");
                SqlCommand selectquery = new SqlCommand("select * from Employee", connection);
                connection.Open();
                using (SqlDataReader reader = selectquery.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DataRow row = table.NewRow();
                        int salary = Convert.ToInt32(reader["Salary"]);
                        double revised = salary * 1.5;
                        row["EmployeeName"] = reader["EmployeeName"];
                        row["Salary"] = salary;
                        row["RevisedSalary"] = revised;
                        table.Rows.Add(row);
                    }
                    //GridView1.DataSource = reader;
                    GridView1.DataSource = table;
                    GridView1.DataBind();
                   
                }
            }
        }

    }
}