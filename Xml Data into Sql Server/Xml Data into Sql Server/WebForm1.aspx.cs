﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Xml_Data_into_Sql_Server
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["SourceCS"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                DataSet ds = new DataSet();
                ds.ReadXml(Server.MapPath("~/Data.xml"));
                
                DataTable dtDept = ds.Tables["Department"];
                DataTable dtEmp = ds.Tables["Employee"];
                con.Open();
                using (SqlBulkCopy bc = new SqlBulkCopy(con))
                {
                    bc.DestinationTableName = "Departments";
                    bc.ColumnMappings.Add("ID", "ID");
                    bc.ColumnMappings.Add("Name", "Name");
                    bc.ColumnMappings.Add("Location", "Location");
                    bc.WriteToServer(dtDept);
                }

                using (SqlBulkCopy bc = new SqlBulkCopy(con))
                {
                    bc.DestinationTableName = "Employees";
                    bc.ColumnMappings.Add("ID", "ID");
                    bc.ColumnMappings.Add("Name", "Name");
                    bc.ColumnMappings.Add("Gender", "Gender");
                    bc.ColumnMappings.Add("DepartmentId", "DepartmentId");
                    bc.WriteToServer(dtEmp);
                }
            }
        }
    }
}