using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace TF_TEST1
{
    public class DataAccess
    {
        // create a shared connection string variable 
        // if the name of the serevr has a backslash, you should put 2 backslashes 
        public static string CONNSTR = "Data Source=DESKTOP-1HIT6UB\\SQLEXPRESS;Initial Catalog=\"project database\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        // First approach: retreive a single answer
        // the function takes sql statement and return an an object
        //single value
        public static object GetScalar(string sql)
        {
            object obj = null;
            SqlConnection conn = new SqlConnection(CONNSTR);

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                obj = cmd.ExecuteScalar();

            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally

            {
                conn.Close();
            }

            return obj;
        }

        // Second approach: retreive many rows and many columns
        // the function takes sql statement and return a dataTable 
        //many rows or row
        public static DataTable GetDataTable(string sql)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(CONNSTR);

            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(dt);

            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {
                conn.Close();
            }

            return dt;
        }
        public static int InsertUPdateDelete(string sql)
        {
            int rows = 0;
            SqlConnection conn = new SqlConnection(CONNSTR);

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                rows = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally

            {
                conn.Close();
            }

            return rows;

        }

    }
}
