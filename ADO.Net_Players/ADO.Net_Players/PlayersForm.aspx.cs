using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace ADO.Net_Players
{
    public partial class PlayersForm : System.Web.UI.Page
    {
        string strconnection = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;

        public object sqlDbType { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                SqlConnection connection = new SqlConnection(strconnection);
                SqlCommand selectQuery = new SqlCommand("select * from players", connection);
                //SqlDataAdapter adapter = new SqlDataAdapter(selectQuery);
                //DataTable dt = new DataTable();
                //adapter.Fill(dt);
                //ddlName.DataSource = dt;
                //ddlName.DataBind();
                connection.Open();
                SqlDataReader reader = selectQuery.ExecuteReader();
                ddlName.DataSource = reader;
                ddlName.DataTextField = "Name";
                ddlName.DataValueField = "Name";
                ddlName.DataBind();
                connection.Close();
            }
        }

        protected void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(strconnection);
                connection.Open();
                lblCheck.Text = "Connection opened";
                connection.Close();
            }
            catch(Exception ex) {
                Console.WriteLine(ex);

            }
        }

        protected void btnAddPlayer_Click(object sender, EventArgs e)
        {
            try
            {
                int ans = 0;
                SqlConnection connection = new SqlConnection(strconnection);
                SqlCommand addQuery = new SqlCommand("insert into players values('"+txtName.Text+"','"+Convert.ToDateTime(txtDOB.Text)+"','"+txtClub.Text+"',"+Convert.ToInt32(txtSalary.Text)+")", connection);
                connection.Open();
                 ans = addQuery.ExecuteNonQuery();
                connection.Close();
                if (ans >=1) { lblResult.Text = "Player Added"; }
                else { lblResult.Text = "Player Not Added"; }
            }
            catch(Exception ex) { lblResult.Text = "Error"; }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int ans = 0;
                SqlConnection connection = new SqlConnection(strconnection);
                SqlCommand updateQuery = new SqlCommand("update players set Club='" + txtUpdateClub.Text + "',Salary='" + Convert.ToInt32(txtUpdateSalary.Text) + "' where Name='" + ddlName.SelectedValue + "'", connection);
                connection.Open();
                ans = updateQuery.ExecuteNonQuery();
                if (ans > 0) { lblUpdate.Text = "Player updated"; }
                else { lblUpdate.Text = "Player Not updated"; }
            }
            catch (Exception ex) { lblUpdate.Text = "Error"; }
        }

        protected void btnReader_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(strconnection);
            SqlCommand selectQuery = new SqlCommand("select * from players", connection);
            connection.Open();
            SqlDataReader reader = selectQuery.ExecuteReader();
            GridView1.DataSource = reader;
            GridView1.DataBind();
            connection.Close();
        }

        protected void btnAdapter_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(strconnection);
            SqlCommand selectQuery = new SqlCommand("select * from players", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(selectQuery);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();

        }

        protected void btnParaAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(strconnection);
                SqlCommand paraAdd = new SqlCommand("insert into players values(@Name,@DOB,@Club,@Salary)", connection);
                paraAdd.Parameters.AddWithValue("@Name", txtName.Text);
                paraAdd.Parameters.AddWithValue("@DOB", Convert.ToDateTime(txtDOB.Text));
                //paraAdd.Parameters.AddWithValue("@Club", txtClub.Text);
                paraAdd.Parameters.Add("@Club", SqlDbType.Char);
                paraAdd.Parameters["@Club"].Value = txtClub.Text;
                paraAdd.Parameters.Add("@Salary",SqlDbType.Int);
                paraAdd.Parameters["@Salary"].Value = txtSalary.Text;
                connection.Open();
                int ans = paraAdd.ExecuteNonQuery();
                connection.Close();
                if (ans >= 1) { lblResult.Text = "Player Added"; }
                else { lblResult.Text = "Player Not Added"; }
            }
            catch (Exception ex) {
                lblResult.Text =Convert.ToString(ex);
            }
        }
    }
}