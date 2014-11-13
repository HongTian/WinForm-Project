using System;
using System.Collections.Generic;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for SqlHelper
/// </summary>
public class SqlHelper
{
    private static string connStr = "data source=127.0.0.1;initial catalog=MyLog;user id=sa;password=P@ssw0rd";

    public static DataTable GetDataTable(string sql, SqlParameter[] parameters)
    {
        using (SqlConnection conn = new SqlConnection(connStr))
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.Parameters.AddRange(parameters);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            DataTable dt = ds.Tables[0];
            return dt;
        }
    }

    public static DataSet GetDataSet(string sql, SqlParameter[] parameters)
    {
        using (SqlConnection conn = new SqlConnection(connStr))
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            if (parameters != null)
                cmd.Parameters.AddRange(parameters);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }
    }

    public static void Execute(string sql, SqlParameter[] parameters)
    {
        using (SqlConnection conn = new SqlConnection(connStr))
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            if (parameters != null)
                cmd.Parameters.AddRange(parameters);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}