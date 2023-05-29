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
using Railway;
/// <summary>
/// Summary description for Cls_Master_Outage
/// </summary>
public class Cls_Master_Outage : Cls_DBConnection
{
    public string Id_Outage;
    public string Locotype;
    public string guage;
    public string OutageDate;
    public string tar;
    public string net;
    public string fois;
    public string Id_Outage_Sub3;

    public Cls_Master_Outage()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public Int64 returnmaxMonthlyOutage()
    {
        cmd = new SqlCommand("SELECT MAX(Id_Outage) FROM Master_Outage", cnn);
        cmd.Connection.Open();
        Int64 m = Convert.ToInt64(cmd.ExecuteScalar());
        cmd.Connection.Close();
        return m;
    }

    public Int64 Insert_Data()
    {
        cmd = new SqlCommand("INSERT INTO Master_Outage(OutageDate,Locotype) VALUES(@OutageDate,@Locotype)", cnn);
        cmd.Parameters.AddWithValue("@OutageDate", this.OutageDate);
        cmd.Parameters.AddWithValue("@Locotype", this.Locotype);
        cmd.Connection.Open();
        Int64 n = cmd.ExecuteNonQuery();
        cmd.Connection.Close();
        if (n == 1)
        {
            cmd = new SqlCommand("SELECT MAX(Id_Outage) FROM Master_Outage", cnn);
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
    public void Update_Data()
    {
        cmd = new SqlCommand("UPDATE Master_Outage SET Locotype=@Locotype,OutageDate=@OutageDate WHERE Id_Outage=@Id_Outage", cnn);
        cmd.Parameters.AddWithValue("@Id_Outage", this.Id_Outage);
        cmd.Parameters.AddWithValue("@Locotype", this.Locotype);
        cmd.Parameters.AddWithValue("@OutageDate", this.OutageDate);

        cmd.Connection.Open();
        Int64 m = cmd.ExecuteNonQuery();
        cmd.Connection.Close();
    }
    public void Delete_Data()
    {
        cmd = new SqlCommand("DELETE FROM Master_Outage WHERE Id_OutAge=@Id_OutAge", cnn);
        cmd.Parameters.AddWithValue("@Id_OutAge", this.Id_Outage);
        cmd.Connection.Open();
        Int64 m = cmd.ExecuteNonQuery();
        cmd.Connection.Close();
    }
    public DataTable Select_DataById()
    {
     cmd = new SqlCommand("SELECT * FROM Master_Outage WHERE Locotype=@Locotype AND OutageDate=@OutageDate", cnn);
    
        cmd.Parameters.AddWithValue("@Locotype", this.Locotype);
        cmd.Parameters.AddWithValue("@OutageDate", this.OutageDate);
        da = new SqlDataAdapter();
        dt = new DataTable();
        da.SelectCommand = cmd;
        da.Fill(dt);
        return dt;
    }
    public DataTable Select_DataById_1()
    {
         cmd = new SqlCommand("SELECT * FROM Master_Outage WHERE Locotype=@Locotype AND OutageDate=@OutageDate", cnn);
       // cmd = new SqlCommand("SELECT * FROM Master_Outage", cnn);
        cmd.Parameters.AddWithValue("@Locotype", this.Locotype);
        cmd.Parameters.AddWithValue("@OutageDate", this.OutageDate);
        da = new SqlDataAdapter();
        dt = new DataTable();
        da.SelectCommand = cmd; 
        da.Fill(dt);
        return dt;
    }
    public Int64 Insert_Outage()
    {
        cmd = new SqlCommand("INSERT INTO Outage_Sub3(Tar,net,fois,Id_Outage,guage) VALUES(@Tar,@net,@fois,@Id_Outage,@guage)", cnn);
        cmd.Parameters.AddWithValue("@Tar", this.tar);
        cmd.Parameters.AddWithValue("@net", this.net);
        cmd.Parameters.AddWithValue("@fois", this.fois);
        cmd.Parameters.AddWithValue("@Id_Outage", this.Id_Outage);
        cmd.Parameters.AddWithValue("@guage",this.guage);
        cmd.Connection.Open();
        Int64 n = cmd.ExecuteNonQuery();
        cmd.Connection.Close();
        if (n == 1)
        {
            cmd = new SqlCommand("SELECT MAX(Id_Outage) FROM Master_Outage", cnn);
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
    public DataTable Select_DataById_Sub3(string guage)
    {
        cmd = new SqlCommand("SELECT * FROM Outage_Sub3 WHERE Id_Outage=@Id_Outage", cnn);
        
        cmd.Parameters.AddWithValue("@Id_Outage", this.Id_Outage);
        cmd.Parameters.AddWithValue("@guage",guage);
        da = new SqlDataAdapter();
        dt = new DataTable();
        dt.Clear();
        da.SelectCommand = cmd;
        da.Fill(dt);
        return dt;
    }
   public DataTable Select_DataById_Sub3_1(string guage)
    
    {
        cmd = new SqlCommand("SELECT * FROM Outage_Sub3 WHERE Id_Outage=@Id_Outage", cnn);
       // cmd = new SqlCommand("SELECT * FROM Outage_Sub3", cnn);
        cmd.Parameters.AddWithValue("@Id_Outage", this.Id_Outage);
        cmd.Parameters.AddWithValue("@guage", guage);
        da = new SqlDataAdapter();
        dt = new DataTable();
        dt.Clear();
        da.SelectCommand = cmd;
        da.Fill(dt);
        return dt;
    }
}

