using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TF_TEST1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataSet ds = new DataSet();

        public void showdata()
        {
            cmd.CommandText = "select * from Academic_Info where Academic_Id=" + Session["username"] + "";
            cmd.Connection = con;
            sda.SelectCommand = cmd;
            sda.Fill(ds);
            Label2.Text = ds.Tables[0].Rows[0]["Name_Academic"].ToString();
            Label3.Text = ds.Tables[0].Rows[0]["Academic_Id"].ToString();

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("WebForm1.aspx");
            }
            else
            {
                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                con.Open();
                showdata();
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}