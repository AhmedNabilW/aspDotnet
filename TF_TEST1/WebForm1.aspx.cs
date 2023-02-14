using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TF_TEST1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            WebForm2 wf2 = new WebForm2();



            if (true)
            {
                Response.Redirect("WebForm3.aspx");
            }
            if (true)
            {
                Response.Redirect("WebForm3.aspx");
                

            }
            else
            {
                e.Authenticated = false;
            }
            if (e.Authenticated)
            {
                Response.Redirect("WebForm2.aspx");
            }
            if (ValidateAcademic(Login1.UserName, Login1.Password))
            {
                Response.Redirect("WebForm3.aspx");
            }
            else
            {
                e.Authenticated = false;
            }
            if (e.Authenticated)
            {
                Response.Redirect("WebForm2.aspx");
            }
            if (ValidateTraining(Login1.UserName, Login1.Password))
            {
                Response.Redirect("WebForm4.aspx");
            }
            else
            {
                e.Authenticated = false;
            }
            if (e.Authenticated)
            {
                Response.Redirect("WebForm2.aspx");
            }
            if (ValidateAdmin(Login1.UserName, Login1.Password))
            {
                Response.Redirect("WebForm4.aspx");
            }
            else
            {
                e.Authenticated = false;
            }

            
            

        }


        private bool ValidateStudent(String username, String password)
        {
            bool status;
            String mycon = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection scon = new SqlConnection(mycon);
            SqlDataAdapter SQLAdapter = new SqlDataAdapter("SELECT * From Student_Info WHERE Student_Id=" + Login1.UserName + " And Password_Student= " + Login1.Password,mycon);
            DataTable DT =new DataTable();
            SQLAdapter.Fill(DT);
            if (DT.Rows.Count > 0)
            {
                Session["username"] = Login1.UserName;
                status= true;
            }
            else
            {
                status= false;
            }
            return status;

            /*String mycon = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection scon = new SqlConnection(mycon);
            String myquery = "select * from Student_Info";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = myquery;
            cmd.Connection = scon;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            String uname;
            String pass;
            uname = ds.Tables[0].Rows[0]["Student_Id"].ToString();
            
            pass = ds.Tables[0].Rows[0]["Password_Student"].ToString();
            scon.Close();
            if (uname == username && pass == password)
            {
                Session["username"] = uname;
                status = true;
            }
            else
            {
                status = false;
            }
            
            return status;
            */
            



        }
        private bool ValidateAcademic(string username, String password)
        {
            bool status;

            
            String mycon = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection scon = new SqlConnection(mycon);
            SqlDataAdapter SQLAdapter = new SqlDataAdapter("SELECT * From Academic_Info WHERE Academic_Id=" + Login1.UserName + " And Password_Academic= " + Login1.Password, mycon);
            DataTable DT = new DataTable();
            SQLAdapter.Fill(DT);
            if (DT.Rows.Count > 0)
            {
                Session["username"] = Login1.UserName;
                status = true;
            }
            else
            {
                status = false;
            }
            return status;
        }
        private bool ValidateTraining(string username, String password)
        {
            bool status;


            String mycon = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection scon = new SqlConnection(mycon);
            SqlDataAdapter SQLAdapter = new SqlDataAdapter("SELECT * From Training_Info WHERE Training_Id=" + Login1.UserName + " And Password_Training= " + Login1.Password, mycon);
            DataTable DT = new DataTable();
            SQLAdapter.Fill(DT);
            if (DT.Rows.Count > 0)
            {
                Session["username"] = Login1.UserName;
                status = true;
            }
            else
            {
                status = false;
            }
            return status;
        }
        private bool ValidateAdmin(string username, String password)
        {
            bool status;


            String mycon = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection scon = new SqlConnection(mycon);
            SqlDataAdapter SQLAdapter = new SqlDataAdapter("SELECT * From Admin_Info WHERE Admin_Id=" + Login1.Text + " And Password_Admin= " + Login2.Text, mycon);
            DataTable DT = new DataTable();
            SQLAdapter.Fill(DT);
            if (DT.Rows.Count > 0)
            {
                Session["username"] = Login1.Text;
                status = true;
            }
            else
            {
                status = false;
            }
            return status;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
        }
    }
}