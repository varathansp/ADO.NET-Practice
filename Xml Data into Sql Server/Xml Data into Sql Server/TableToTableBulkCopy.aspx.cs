using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Xml_Data_into_Sql_Server
{
    public partial class TableToTableBulkCopy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            string SourceCS = ConfigurationManager.ConnectionStrings["SourceCS"].ConnectionString;
            string DestinationCS = ConfigurationManager.ConnectionStrings["DestinationCS"].ConnectionString;
            using (SqlConnection SCS=new SqlConnection(SourceCS))
            {
                SqlCommand cmd = new SqlCommand("select * from Departments", SCS);
                SCS.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                using (SqlConnection DCS = new SqlConnection(DestinationCS))
                {
                    DCS.Open();
                    using (SqlBulkCopy bc = new SqlBulkCopy(DCS))
                    {
                        bc.DestinationTableName = "Departments";
                        bc.WriteToServer(reader);
                    }
                }
            }
        }
    }
}