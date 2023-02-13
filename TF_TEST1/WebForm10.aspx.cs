using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO.Ports;
using System.Reflection.Emit;

namespace TF_TEST1
{
    public partial class WebForm10 : System.Web.UI.Page
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        


        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedIndex == 0)
            {
                if (CheckBox1.Checked == true && CheckBox41.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }

                }
                if (CheckBox2.Checked == true && CheckBox42.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox3.Checked == true && CheckBox43.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox4.Checked == true && CheckBox44.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox5.Checked == true && CheckBox45.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox6.Checked == true && CheckBox46.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox7.Checked == true && CheckBox47.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox8.Checked == true && CheckBox48.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox9.Checked == true && CheckBox49.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox10.Checked == true && CheckBox50.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox11.Checked == true && CheckBox51.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox12.Checked == true && CheckBox52.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox13.Checked == true && CheckBox53.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox14.Checked == true && CheckBox54.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox15.Checked == true && CheckBox55.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox16.Checked == true && CheckBox56.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox17.Checked == true && CheckBox57.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox18.Checked == true && CheckBox58.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox19.Checked == true && CheckBox59.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox20.Checked == true && CheckBox60.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox21.Checked == true && CheckBox61.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox22.Checked == true && CheckBox62.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox23.Checked == true && CheckBox63.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox24.Checked == true && CheckBox64.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox25.Checked == true && CheckBox65.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox26.Checked == true && CheckBox66.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox27.Checked == true && CheckBox67.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox28.Checked == true && CheckBox68.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox29.Checked == true && CheckBox69.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox30.Checked == true && CheckBox70.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox31.Checked == true && CheckBox71.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox32.Checked == true && CheckBox72.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox33.Checked == true && CheckBox73.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox34.Checked == true && CheckBox74.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox35.Checked == true && CheckBox75.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox36.Checked == true && CheckBox76.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox37.Checked == true && CheckBox77.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox38.Checked == true && CheckBox78.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox39.Checked == true && CheckBox79.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox40.Checked == true && CheckBox80.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox1.Checked == false && CheckBox41.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }

                }
                if (CheckBox2.Checked == false && CheckBox42.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox3.Checked == false && CheckBox43.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox4.Checked == false && CheckBox44.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox5.Checked == false && CheckBox45.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox6.Checked == false && CheckBox46.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox7.Checked == false && CheckBox47.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox8.Checked == false && CheckBox48.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox9.Checked == false && CheckBox49.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox10.Checked == false && CheckBox50.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox11.Checked == false && CheckBox51.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox12.Checked == false && CheckBox52.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox13.Checked == false && CheckBox53.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox14.Checked == false && CheckBox54.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox15.Checked == false && CheckBox55.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox16.Checked == false && CheckBox56.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox17.Checked == false && CheckBox57.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox18.Checked == false && CheckBox58.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox19.Checked == false && CheckBox59.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox20.Checked == false && CheckBox60.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox21.Checked == false && CheckBox61.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox22.Checked == false && CheckBox62.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox23.Checked == false && CheckBox63.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox24.Checked == false && CheckBox64.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox25.Checked == false && CheckBox65.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox26.Checked == false && CheckBox66.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox27.Checked == false && CheckBox67.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox28.Checked == false && CheckBox68.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox29.Checked == false && CheckBox69.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox30.Checked == false && CheckBox70.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox31.Checked == false && CheckBox71.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox32.Checked == false && CheckBox72.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox33.Checked == false && CheckBox73.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox34.Checked == false && CheckBox74.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox35.Checked == false && CheckBox75.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox36.Checked == false && CheckBox76.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox37.Checked == false && CheckBox77.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox38.Checked == false && CheckBox78.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox39.Checked == false && CheckBox79.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox40.Checked == false && CheckBox80.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }

            }
            if (DropDownList1.SelectedIndex == 1)
            {
                if (CheckBox1.Checked == true && CheckBox41.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }

                }
                if (CheckBox2.Checked == true && CheckBox42.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox3.Checked == true && CheckBox43.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox4.Checked == true && CheckBox44.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox5.Checked == true && CheckBox45.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox6.Checked == true && CheckBox46.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox7.Checked == true && CheckBox47.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox8.Checked == true && CheckBox48.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox9.Checked == true && CheckBox49.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox10.Checked == true && CheckBox50.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox11.Checked == true && CheckBox51.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox12.Checked == true && CheckBox52.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox13.Checked == true && CheckBox53.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox14.Checked == true && CheckBox54.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox15.Checked == true && CheckBox55.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox16.Checked == true && CheckBox56.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox17.Checked == true && CheckBox57.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox18.Checked == true && CheckBox58.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox19.Checked == true && CheckBox59.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox20.Checked == true && CheckBox60.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox21.Checked == true && CheckBox61.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox22.Checked == true && CheckBox62.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox23.Checked == true && CheckBox63.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox24.Checked == true && CheckBox64.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox25.Checked == true && CheckBox65.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox26.Checked == true && CheckBox66.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox27.Checked == true && CheckBox67.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox28.Checked == true && CheckBox68.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox29.Checked == true && CheckBox69.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox30.Checked == true && CheckBox70.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox31.Checked == true && CheckBox71.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox32.Checked == true && CheckBox72.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox33.Checked == true && CheckBox73.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox34.Checked == true && CheckBox74.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox35.Checked == true && CheckBox75.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox36.Checked == true && CheckBox76.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox37.Checked == true && CheckBox77.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox38.Checked == true && CheckBox78.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox39.Checked == true && CheckBox79.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox40.Checked == true && CheckBox80.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox1.Checked == false && CheckBox41.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }

                }
                if (CheckBox2.Checked == false && CheckBox42.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox3.Checked == false && CheckBox43.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox4.Checked == false && CheckBox44.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox5.Checked == false && CheckBox45.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox6.Checked == false && CheckBox46.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox7.Checked == false && CheckBox47.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox8.Checked == false && CheckBox48.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox9.Checked == false && CheckBox49.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox10.Checked == false && CheckBox50.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox11.Checked == false && CheckBox51.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox12.Checked == false && CheckBox52.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox13.Checked == false && CheckBox53.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox14.Checked == false && CheckBox54.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox15.Checked == false && CheckBox55.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox16.Checked == false && CheckBox56.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox17.Checked == false && CheckBox57.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox18.Checked == false && CheckBox58.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox19.Checked == false && CheckBox59.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox20.Checked == false && CheckBox60.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox21.Checked == false && CheckBox61.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox22.Checked == false && CheckBox62.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox23.Checked == false && CheckBox63.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox24.Checked == false && CheckBox64.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox25.Checked == false && CheckBox65.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox26.Checked == false && CheckBox66.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox27.Checked == false && CheckBox67.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox28.Checked == false && CheckBox68.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox29.Checked == false && CheckBox69.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox30.Checked == false && CheckBox70.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox31.Checked == false && CheckBox71.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox32.Checked == false && CheckBox72.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox33.Checked == false && CheckBox73.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox34.Checked == false && CheckBox74.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox35.Checked == false && CheckBox75.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox36.Checked == false && CheckBox76.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox37.Checked == false && CheckBox77.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox38.Checked == false && CheckBox78.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox39.Checked == false && CheckBox79.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox40.Checked == false && CheckBox80.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }

            }
            if (DropDownList1.SelectedIndex == 2)
            {
                if (CheckBox1.Checked == true && CheckBox41.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }

                }
                if (CheckBox2.Checked == true && CheckBox42.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox3.Checked == true && CheckBox43.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox4.Checked == true && CheckBox44.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox5.Checked == true && CheckBox45.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox6.Checked == true && CheckBox46.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox7.Checked == true && CheckBox47.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox8.Checked == true && CheckBox48.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox9.Checked == true && CheckBox49.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox10.Checked == true && CheckBox50.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox11.Checked == true && CheckBox51.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox12.Checked == true && CheckBox52.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox13.Checked == true && CheckBox53.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox14.Checked == true && CheckBox54.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox15.Checked == true && CheckBox55.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox16.Checked == true && CheckBox56.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox17.Checked == true && CheckBox57.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox18.Checked == true && CheckBox58.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox19.Checked == true && CheckBox59.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox20.Checked == true && CheckBox60.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox21.Checked == true && CheckBox61.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox22.Checked == true && CheckBox62.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox23.Checked == true && CheckBox63.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox24.Checked == true && CheckBox64.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox25.Checked == true && CheckBox65.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox26.Checked == true && CheckBox66.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox27.Checked == true && CheckBox67.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox28.Checked == true && CheckBox68.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox29.Checked == true && CheckBox69.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox30.Checked == true && CheckBox70.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox31.Checked == true && CheckBox71.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox32.Checked == true && CheckBox72.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox33.Checked == true && CheckBox73.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox34.Checked == true && CheckBox74.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox35.Checked == true && CheckBox75.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox36.Checked == true && CheckBox76.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox37.Checked == true && CheckBox77.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox38.Checked == true && CheckBox78.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox39.Checked == true && CheckBox79.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox40.Checked == true && CheckBox80.Checked == false)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Absent"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox1.Checked == false && CheckBox41.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }

                }
                if (CheckBox2.Checked == false && CheckBox42.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox3.Checked == false && CheckBox43.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox4.Checked == false && CheckBox44.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox5.Checked == false && CheckBox45.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox6.Checked == false && CheckBox46.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox7.Checked == false && CheckBox47.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox8.Checked == false && CheckBox48.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox9.Checked == false && CheckBox49.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox10.Checked == false && CheckBox50.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox11.Checked == false && CheckBox51.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox12.Checked == false && CheckBox52.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox13.Checked == false && CheckBox53.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox14.Checked == false && CheckBox54.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox15.Checked == false && CheckBox55.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox16.Checked == false && CheckBox56.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox17.Checked == false && CheckBox57.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox18.Checked == false && CheckBox58.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox19.Checked == false && CheckBox59.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox20.Checked == false && CheckBox60.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox21.Checked == false && CheckBox61.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox22.Checked == false && CheckBox62.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox23.Checked == false && CheckBox63.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox24.Checked == false && CheckBox64.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox25.Checked == false && CheckBox65.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox26.Checked == false && CheckBox66.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox27.Checked == false && CheckBox67.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox28.Checked == false && CheckBox68.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox29.Checked == false && CheckBox69.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox30.Checked == false && CheckBox70.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox31.Checked == false && CheckBox71.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox32.Checked == false && CheckBox72.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox33.Checked == false && CheckBox73.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox34.Checked == false && CheckBox74.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox35.Checked == false && CheckBox75.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox36.Checked == false && CheckBox76.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox37.Checked == false && CheckBox77.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox38.Checked == false && CheckBox78.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox39.Checked == false && CheckBox79.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (CheckBox40.Checked == false && CheckBox80.Checked == true)
                {
                    int value;
                    string value1;
                    con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    con.Open();
                    cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        value1 = reader1["Late"].ToString();
                    }
                    else
                    {
                        value1 = null;
                    }
                    value = Convert.ToInt32(value1);
                    //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                    string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                    int rows = DataAccess.InsertUPdateDelete(sql);
                    if (rows != 0)
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                    else
                    {
                        Response.Redirect("WebForm10.aspx");
                    }
                }
                if (DropDownList1.SelectedIndex == 3)
                {
                    if (CheckBox1.Checked == true && CheckBox41.Checked == false)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Absent"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }

                    }
                    if (CheckBox2.Checked == true && CheckBox42.Checked == false)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Absent"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox3.Checked == true && CheckBox43.Checked == false)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Absent"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox4.Checked == true && CheckBox44.Checked == false)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Absent"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox5.Checked == true && CheckBox45.Checked == false)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Absent"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox6.Checked == true && CheckBox46.Checked == false)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Absent"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox7.Checked == true && CheckBox47.Checked == false)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Absent"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox8.Checked == true && CheckBox48.Checked == false)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Absent"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox9.Checked == true && CheckBox49.Checked == false)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Absent"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox10.Checked == true && CheckBox50.Checked == false)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Absent"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox11.Checked == true && CheckBox51.Checked == false)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Absent"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox12.Checked == true && CheckBox52.Checked == false)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Absent"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox13.Checked == true && CheckBox53.Checked == false)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Absent"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox14.Checked == true && CheckBox54.Checked == false)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Absent"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox15.Checked == true && CheckBox55.Checked == false)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Absent"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox16.Checked == true && CheckBox56.Checked == false)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Absent"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox17.Checked == true && CheckBox57.Checked == false)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Absent"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox18.Checked == true && CheckBox58.Checked == false)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Absent"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox19.Checked == true && CheckBox59.Checked == false)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Absent"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox20.Checked == true && CheckBox60.Checked == false)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Absent"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox21.Checked == true && CheckBox61.Checked == false)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Absent"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox22.Checked == true && CheckBox62.Checked == false)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Absent"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox23.Checked == true && CheckBox63.Checked == false)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Absent"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox24.Checked == true && CheckBox64.Checked == false)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Absent"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox25.Checked == true && CheckBox65.Checked == false)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Absent"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox26.Checked == true && CheckBox66.Checked == false)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Absent"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox27.Checked == true && CheckBox67.Checked == false)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Absent"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox28.Checked == true && CheckBox68.Checked == false)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Absent"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox29.Checked == true && CheckBox69.Checked == false)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Absent"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox30.Checked == true && CheckBox70.Checked == false)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Absent"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox31.Checked == true && CheckBox71.Checked == false)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Absent"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox32.Checked == true && CheckBox72.Checked == false)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Absent"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox33.Checked == true && CheckBox73.Checked == false)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Absent"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox34.Checked == true && CheckBox74.Checked == false)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Absent"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox35.Checked == true && CheckBox75.Checked == false)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Absent"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox36.Checked == true && CheckBox76.Checked == false)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Absent"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox37.Checked == true && CheckBox77.Checked == false)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Absent"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox38.Checked == true && CheckBox78.Checked == false)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Absent"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox39.Checked == true && CheckBox79.Checked == false)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Absent"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox40.Checked == true && CheckBox80.Checked == false)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Absent"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox1.Checked == false && CheckBox41.Checked == true)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Late"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }

                    }
                    if (CheckBox2.Checked == false && CheckBox42.Checked == true)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Late"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox3.Checked == false && CheckBox43.Checked == true)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Late"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox4.Checked == false && CheckBox44.Checked == true)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Late"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox5.Checked == false && CheckBox45.Checked == true)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Late"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox6.Checked == false && CheckBox46.Checked == true)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Late"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox7.Checked == false && CheckBox47.Checked == true)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Late"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox8.Checked == false && CheckBox48.Checked == true)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Late"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox9.Checked == false && CheckBox49.Checked == true)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Late"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox10.Checked == false && CheckBox50.Checked == true)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Late"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox11.Checked == false && CheckBox51.Checked == true)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Late"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox12.Checked == false && CheckBox52.Checked == true)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Late"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox13.Checked == false && CheckBox53.Checked == true)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Late"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox14.Checked == false && CheckBox54.Checked == true)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Late"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox15.Checked == false && CheckBox55.Checked == true)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Late"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox16.Checked == false && CheckBox56.Checked == true)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Late"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox17.Checked == false && CheckBox57.Checked == true)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Late"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox18.Checked == false && CheckBox58.Checked == true)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Late"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox19.Checked == false && CheckBox59.Checked == true)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Late"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox20.Checked == false && CheckBox60.Checked == true)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Late"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox21.Checked == false && CheckBox61.Checked == true)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Late"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox22.Checked == false && CheckBox62.Checked == true)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Late"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox23.Checked == false && CheckBox63.Checked == true)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Late"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox24.Checked == false && CheckBox64.Checked == true)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Late"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox25.Checked == false && CheckBox65.Checked == true)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Late"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox26.Checked == false && CheckBox66.Checked == true)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Late"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox27.Checked == false && CheckBox67.Checked == true)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Late"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox28.Checked == false && CheckBox68.Checked == true)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Late"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox29.Checked == false && CheckBox69.Checked == true)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Late"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox30.Checked == false && CheckBox70.Checked == true)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Late"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox31.Checked == false && CheckBox71.Checked == true)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Late"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox32.Checked == false && CheckBox72.Checked == true)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Late"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox33.Checked == false && CheckBox73.Checked == true)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Late"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox34.Checked == false && CheckBox74.Checked == true)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Late"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox35.Checked == false && CheckBox75.Checked == true)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Late"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox36.Checked == false && CheckBox76.Checked == true)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Late"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox37.Checked == false && CheckBox77.Checked == true)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Late"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox38.Checked == false && CheckBox78.Checked == true)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Late"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox39.Checked == false && CheckBox79.Checked == true)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Late"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (CheckBox40.Checked == false && CheckBox80.Checked == true)
                    {
                        int value;
                        string value1;
                        con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        con.Open();
                        cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            value1 = reader1["Late"].ToString();
                        }
                        else
                        {
                            value1 = null;
                        }
                        value = Convert.ToInt32(value1);
                        //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                        string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                        int rows = DataAccess.InsertUPdateDelete(sql);
                        if (rows != 0)
                        {
                            Response.Redirect("WebForm4.aspx");
                        }
                        else
                        {
                            Response.Redirect("WebForm10.aspx");
                        }
                    }
                    if (DropDownList1.SelectedIndex == 4)
                    {
                        if (CheckBox1.Checked == true && CheckBox41.Checked == false)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Absent"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }

                        }
                        if (CheckBox2.Checked == true && CheckBox42.Checked == false)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Absent"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox3.Checked == true && CheckBox43.Checked == false)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Absent"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox4.Checked == true && CheckBox44.Checked == false)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Absent"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox5.Checked == true && CheckBox45.Checked == false)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Absent"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox6.Checked == true && CheckBox46.Checked == false)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Absent"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox7.Checked == true && CheckBox47.Checked == false)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Absent"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox8.Checked == true && CheckBox48.Checked == false)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Absent"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox9.Checked == true && CheckBox49.Checked == false)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Absent"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox10.Checked == true && CheckBox50.Checked == false)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Absent"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox11.Checked == true && CheckBox51.Checked == false)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Absent"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox12.Checked == true && CheckBox52.Checked == false)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Absent"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox13.Checked == true && CheckBox53.Checked == false)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Absent"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox14.Checked == true && CheckBox54.Checked == false)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Absent"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox15.Checked == true && CheckBox55.Checked == false)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Absent"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox16.Checked == true && CheckBox56.Checked == false)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Absent"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox17.Checked == true && CheckBox57.Checked == false)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Absent"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox18.Checked == true && CheckBox58.Checked == false)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Absent"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox19.Checked == true && CheckBox59.Checked == false)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Absent"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox20.Checked == true && CheckBox60.Checked == false)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Absent"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox21.Checked == true && CheckBox61.Checked == false)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Absent"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox22.Checked == true && CheckBox62.Checked == false)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Absent"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox23.Checked == true && CheckBox63.Checked == false)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Absent"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox24.Checked == true && CheckBox64.Checked == false)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Absent"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox25.Checked == true && CheckBox65.Checked == false)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Absent"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox26.Checked == true && CheckBox66.Checked == false)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Absent"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox27.Checked == true && CheckBox67.Checked == false)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Absent"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox28.Checked == true && CheckBox68.Checked == false)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Absent"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox29.Checked == true && CheckBox69.Checked == false)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Absent"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox30.Checked == true && CheckBox70.Checked == false)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Absent"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox31.Checked == true && CheckBox71.Checked == false)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Absent"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox32.Checked == true && CheckBox72.Checked == false)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Absent"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox33.Checked == true && CheckBox73.Checked == false)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Absent"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox34.Checked == true && CheckBox74.Checked == false)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Absent"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox35.Checked == true && CheckBox75.Checked == false)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Absent"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox36.Checked == true && CheckBox76.Checked == false)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Absent"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox37.Checked == true && CheckBox77.Checked == false)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Absent"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox38.Checked == true && CheckBox78.Checked == false)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Absent"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox39.Checked == true && CheckBox79.Checked == false)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Absent"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox40.Checked == true && CheckBox80.Checked == false)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Absent"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox1.Checked == false && CheckBox41.Checked == true)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Late"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }

                        }
                        if (CheckBox2.Checked == false && CheckBox42.Checked == true)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Late"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox3.Checked == false && CheckBox43.Checked == true)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Late"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox4.Checked == false && CheckBox44.Checked == true)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Late"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox5.Checked == false && CheckBox45.Checked == true)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Late"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox6.Checked == false && CheckBox46.Checked == true)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Late"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox7.Checked == false && CheckBox47.Checked == true)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Late"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox8.Checked == false && CheckBox48.Checked == true)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Late"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox9.Checked == false && CheckBox49.Checked == true)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Late"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox10.Checked == false && CheckBox50.Checked == true)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Late"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox11.Checked == false && CheckBox51.Checked == true)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Late"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox12.Checked == false && CheckBox52.Checked == true)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Late"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox13.Checked == false && CheckBox53.Checked == true)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Late"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox14.Checked == false && CheckBox54.Checked == true)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Late"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox15.Checked == false && CheckBox55.Checked == true)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Late"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox16.Checked == false && CheckBox56.Checked == true)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Late"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox17.Checked == false && CheckBox57.Checked == true)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Late"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox18.Checked == false && CheckBox58.Checked == true)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Late"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox19.Checked == false && CheckBox59.Checked == true)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Late"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox20.Checked == false && CheckBox60.Checked == true)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Late"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox21.Checked == false && CheckBox61.Checked == true)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Late"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox22.Checked == false && CheckBox62.Checked == true)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Late"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox23.Checked == false && CheckBox63.Checked == true)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Late"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox24.Checked == false && CheckBox64.Checked == true)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Late"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox25.Checked == false && CheckBox65.Checked == true)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Late"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox26.Checked == false && CheckBox66.Checked == true)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Late"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox27.Checked == false && CheckBox67.Checked == true)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Late"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox28.Checked == false && CheckBox68.Checked == true)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Late"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox29.Checked == false && CheckBox69.Checked == true)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Late"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox30.Checked == false && CheckBox70.Checked == true)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Late"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox31.Checked == false && CheckBox71.Checked == true)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Late"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox32.Checked == false && CheckBox72.Checked == true)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Late"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox33.Checked == false && CheckBox73.Checked == true)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Late"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox34.Checked == false && CheckBox74.Checked == true)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Late"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox35.Checked == false && CheckBox75.Checked == true)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Late"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox36.Checked == false && CheckBox76.Checked == true)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Late"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox37.Checked == false && CheckBox77.Checked == true)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Late"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox38.Checked == false && CheckBox78.Checked == true)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Late"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox39.Checked == false && CheckBox79.Checked == true)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Late"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (CheckBox40.Checked == false && CheckBox80.Checked == true)
                        {
                            int value;
                            string value1;
                            con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                            con.Open();
                            cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(ds);
                            SqlDataReader reader1;
                            reader1 = cmd.ExecuteReader();
                            if (reader1.Read())
                            {
                                value1 = reader1["Late"].ToString();
                            }
                            else
                            {
                                value1 = null;
                            }
                            value = Convert.ToInt32(value1);
                            //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                            string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                            int rows = DataAccess.InsertUPdateDelete(sql);
                            if (rows != 0)
                            {
                                Response.Redirect("WebForm4.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm10.aspx");
                            }
                        }
                        if (DropDownList1.SelectedIndex == 5)
                        {
                            if (CheckBox1.Checked == true && CheckBox41.Checked == false)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Absent"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }

                            }
                            if (CheckBox2.Checked == true && CheckBox42.Checked == false)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Absent"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox3.Checked == true && CheckBox43.Checked == false)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Absent"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox4.Checked == true && CheckBox44.Checked == false)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Absent"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox5.Checked == true && CheckBox45.Checked == false)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Absent"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox6.Checked == true && CheckBox46.Checked == false)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Absent"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox7.Checked == true && CheckBox47.Checked == false)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Absent"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox8.Checked == true && CheckBox48.Checked == false)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Absent"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox9.Checked == true && CheckBox49.Checked == false)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Absent"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox10.Checked == true && CheckBox50.Checked == false)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Absent"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox11.Checked == true && CheckBox51.Checked == false)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Absent"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox12.Checked == true && CheckBox52.Checked == false)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Absent"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox13.Checked == true && CheckBox53.Checked == false)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Absent"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox14.Checked == true && CheckBox54.Checked == false)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Absent"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox15.Checked == true && CheckBox55.Checked == false)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Absent"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox16.Checked == true && CheckBox56.Checked == false)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Absent"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox17.Checked == true && CheckBox57.Checked == false)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Absent"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox18.Checked == true && CheckBox58.Checked == false)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Absent"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox19.Checked == true && CheckBox59.Checked == false)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Absent"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox20.Checked == true && CheckBox60.Checked == false)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Absent"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox21.Checked == true && CheckBox61.Checked == false)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Absent"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox22.Checked == true && CheckBox62.Checked == false)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Absent"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox23.Checked == true && CheckBox63.Checked == false)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Absent"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox24.Checked == true && CheckBox64.Checked == false)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Absent"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox25.Checked == true && CheckBox65.Checked == false)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Absent"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox26.Checked == true && CheckBox66.Checked == false)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Absent"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox27.Checked == true && CheckBox67.Checked == false)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Absent"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox28.Checked == true && CheckBox68.Checked == false)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Absent"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox29.Checked == true && CheckBox69.Checked == false)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Absent"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox30.Checked == true && CheckBox70.Checked == false)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Absent"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox31.Checked == true && CheckBox71.Checked == false)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Absent"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox32.Checked == true && CheckBox72.Checked == false)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Absent"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox33.Checked == true && CheckBox73.Checked == false)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Absent"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox34.Checked == true && CheckBox74.Checked == false)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Absent"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox35.Checked == true && CheckBox75.Checked == false)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Absent"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox36.Checked == true && CheckBox76.Checked == false)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Absent"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox37.Checked == true && CheckBox77.Checked == false)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Absent"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox38.Checked == true && CheckBox78.Checked == false)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Absent"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox39.Checked == true && CheckBox79.Checked == false)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Absent"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox40.Checked == true && CheckBox80.Checked == false)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Absent"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Absent=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox1.Checked == false && CheckBox41.Checked == true)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Late"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }

                            }
                            if (CheckBox2.Checked == false && CheckBox42.Checked == true)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Late"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox3.Checked == false && CheckBox43.Checked == true)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Late"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox4.Checked == false && CheckBox44.Checked == true)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Late"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox5.Checked == false && CheckBox45.Checked == true)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Late"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox6.Checked == false && CheckBox46.Checked == true)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Late"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox7.Checked == false && CheckBox47.Checked == true)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Late"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox8.Checked == false && CheckBox48.Checked == true)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Late"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox9.Checked == false && CheckBox49.Checked == true)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Late"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox10.Checked == false && CheckBox50.Checked == true)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Late"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox11.Checked == false && CheckBox51.Checked == true)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Late"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox12.Checked == false && CheckBox52.Checked == true)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Late"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox13.Checked == false && CheckBox53.Checked == true)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Late"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox14.Checked == false && CheckBox54.Checked == true)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Late"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox15.Checked == false && CheckBox55.Checked == true)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Late"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox16.Checked == false && CheckBox56.Checked == true)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Late"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox17.Checked == false && CheckBox57.Checked == true)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Late"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox18.Checked == false && CheckBox58.Checked == true)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Late"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox19.Checked == false && CheckBox59.Checked == true)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Late"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox20.Checked == false && CheckBox60.Checked == true)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Late"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox21.Checked == false && CheckBox61.Checked == true)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Late"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox22.Checked == false && CheckBox62.Checked == true)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Late"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox23.Checked == false && CheckBox63.Checked == true)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Late"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox24.Checked == false && CheckBox64.Checked == true)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Late"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox25.Checked == false && CheckBox65.Checked == true)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Late"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox26.Checked == false && CheckBox66.Checked == true)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Late"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox27.Checked == false && CheckBox67.Checked == true)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Late"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox28.Checked == false && CheckBox68.Checked == true)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Late"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox29.Checked == false && CheckBox69.Checked == true)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Late"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox30.Checked == false && CheckBox70.Checked == true)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Late"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox31.Checked == false && CheckBox71.Checked == true)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Late"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox32.Checked == false && CheckBox72.Checked == true)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Late"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox33.Checked == false && CheckBox73.Checked == true)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Late"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox34.Checked == false && CheckBox74.Checked == true)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Late"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox35.Checked == false && CheckBox75.Checked == true)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Late"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox36.Checked == false && CheckBox76.Checked == true)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Late"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox37.Checked == false && CheckBox77.Checked == true)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Late"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox38.Checked == false && CheckBox78.Checked == true)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Late"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox39.Checked == false && CheckBox79.Checked == true)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Late"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }
                            if (CheckBox40.Checked == false && CheckBox80.Checked == true)
                            {
                                int value;
                                string value1;
                                con.ConnectionString = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                con.Open();
                                cmd.CommandText = "select * from Attendance_Student where Name_Student='" + DropDownList1.SelectedValue + "'";
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                sda.Fill(ds);
                                SqlDataReader reader1;
                                reader1 = cmd.ExecuteReader();
                                if (reader1.Read())
                                {
                                    value1 = reader1["Late"].ToString();
                                }
                                else
                                {
                                    value1 = null;
                                }
                                value = Convert.ToInt32(value1);
                                //value = Convert.ToInt32(ds.Tables[0].Rows[0]["Absent"].ToString());
                                string sql = ("UPDATE Attendance_Student SET Late=" + value + 1 + "WHERE Name_Student='" + DropDownList1.SelectedValue + "'");
                                int rows = DataAccess.InsertUPdateDelete(sql);
                                if (rows != 0)
                                {
                                    Response.Redirect("WebForm4.aspx");
                                }
                                else
                                {
                                    Response.Redirect("WebForm10.aspx");
                                }
                            }

                        }
                    }
                }
            }
        }
    }
}