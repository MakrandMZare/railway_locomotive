using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data.SqlClient;
/// <summary>
/// Summary description for Cls_Assembly_NonNonStock_Master
/// </summary>
public class Cls_Assembly_NonStock_Master:Cls_DBConnection
{
    public string Id_NonStock;
    public string NameOfAssembly;

    public Cls_Assembly_NonStock_Master()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public Int64 Insert_Data()
    {
        try
        {
            cmd = new SqlCommand("INSERT INTO Assembly_NonStock_Master(NameOfAssembly)VALUES(@NameOfAssembly)", cnn);
            cmd.Parameters.AddWithValue("@NameOfAssembly", this.NameOfAssembly);
            cmd.Connection.Open();
            Int16 n = Convert.ToInt16(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            if (n == 1)
            {
                cmd = new SqlCommand("SELECT MAX(Id_NonStock) FROM Assembly_NonStock_Master", cnn);
                cmd.Connection.Open();
                Int64 m = Convert.ToInt64(cmd.ExecuteScalar());
                cmd.Connection.Close();
                return m;
            }
            else
            {
                return 0;
            }
        }
        catch { throw; }
    }
    public bool Update_Data()
    {
        try
        {
            cmd = new SqlCommand("UPDATE Assembly_NonStock_Master SET NameOfAssembly=@NameOfAssembly WHERE Id_NonStock=@Id_NonStock", cnn);
            cmd.Parameters.AddWithValue("@NameOfAssembly", this.NameOfAssembly);
            cmd.Parameters.AddWithValue("@Id_NonStock", this.Id_NonStock);
            cmd.Connection.Open();
            Int16 n = Convert.ToInt16(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            return n == 1 ? true : false;
        }
        catch { throw; }
    }
    public bool Delete_Data()
    {
        try
        {
            cmd = new SqlCommand("DELETE FROM Assembly_NonStock_Master WHERE Id_NonStock=@Id_NonStock", cnn);
            cmd.Parameters.AddWithValue("@Id_NonStock", this.Id_NonStock);
            cmd.Connection.Open();
            Int16 n = Convert.ToInt16(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            return n == 1 ? true : false;
        }
        catch { throw; }
    }
    public DataTable Select_DataById()
    {
        try
        {
            cmd = new SqlCommand("SELECT * FROM Assembly_NonStock_Master WHERE Id_NonStock=@Id_NonStock", cnn);
            cmd.Parameters.AddWithValue("@Id_NonStock", this.Id_NonStock);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        catch { throw; }
    }
    public DataTable Select_Data()
    {
        try
        {
            cmd = new SqlCommand("SELECT * FROM Assembly_NonStock_Master", cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        catch { throw; }
    }
}
