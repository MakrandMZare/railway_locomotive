using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Railway;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Cls_Outage_Cum
/// </summary>
public class Cls_Outage_Cum : Cls_DBConnection
{
    public string LocoType;
    public string tar;
    public string act;
    public string dead;
    public string Id_Outage;
    public string Id_Outage_Cum;

    public Cls_Outage_Cum()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public Int64 Insert_Data()
    {
        cmd = new SqlCommand("INSERT INTO Outage_Cum(LocoType,tar,act,dead,Id_Outage)VALUES(@LocoType,@tar,@act,@dead,@Id_Outage)", cnn);
        cmd.Parameters.AddWithValue("@Id_Outage", this.Id_Outage);
        cmd.Parameters.AddWithValue("@act", this.act);
        cmd.Parameters.AddWithValue("@LocoType", this.LocoType);
        cmd.Parameters.AddWithValue("@tar", this.tar);
        cmd.Parameters.AddWithValue("@dead",this.dead);
        cmd.Connection.Open();
        Int64 n = Convert.ToInt64(cmd.ExecuteNonQuery());
        cmd.Connection.Close();
        if (n == 1)
        {
            cmd = new SqlCommand("SELECT MAX(Id_Outage_Cum) FROM Outage_Cum", cnn);
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
    public DataTable Select_DataById(string LocoType)
    {
        cmd = new SqlCommand("SELECT * FROM Outage_Cum WHERE Id_Outage=@Id_Outage", cnn);
        
        cmd.Parameters.AddWithValue("@Id_Outage", this.Id_Outage);
        cmd.Parameters.AddWithValue("@LocoType",LocoType);
        da = new SqlDataAdapter();
        da.SelectCommand = cmd;
        dt = new DataTable();
        da.Fill(dt);
        return dt;
    }
    public DataTable Select_DataById_1(string LocoType)
    {
       cmd = new SqlCommand("SELECT * FROM Outage_Cum WHERE Id_Outage=@Id_Outage", cnn);
       // cmd = new SqlCommand("SELECT * FROM Outage_Cum ", cnn);
        cmd.Parameters.AddWithValue("@Id_Outage", this.Id_Outage);
        cmd.Parameters.AddWithValue("@LocoType", LocoType);
        da = new SqlDataAdapter();
        da.SelectCommand = cmd;
        dt = new DataTable();
        da.Fill(dt);
        return dt;
    }

}
