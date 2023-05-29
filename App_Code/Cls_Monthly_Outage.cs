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
/// Summary description for Cls_Monthly_Outage
/// </summary>
public class Cls_Monthly_Outage : Cls_DBConnection
{

    public string Id_Monthly_OutAge;
    public string Mnth;
    public string year;
    public string target;
    public string actual;
    public string Id_Outage;
    public Cls_Monthly_Outage()
    {
        //
        // TODO: Add constructor logic here
        //
    }


    public Int64 Insert_Data()
    {
        cmd = new SqlCommand("INSERT INTO Monthly_OutAge(Mnth,year,target,actual,Id_Outage) VALUES(@Mnth,@year,@target,@actual,@Id_Outage)", cnn);
        cmd.Parameters.AddWithValue("@Mnth", this.Mnth);
        cmd.Parameters.AddWithValue("@year", this.year);
        cmd.Parameters.AddWithValue("@target", this.target);
        cmd.Parameters.AddWithValue("@actual", this.actual);
        cmd.Parameters.AddWithValue("@Id_Outage", this.Id_Outage);
        cmd.Connection.Open();
        Int64 n = cmd.ExecuteNonQuery();
        cmd.Connection.Close();
        if (n == 1)
        {
            cmd = new SqlCommand("SELECT MAX(Id_Monthly_OutAge) FROM Monthly_OutAge", cnn);
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
        cmd = new SqlCommand("UPDATE Monthly_OutAge SET Mnth=@Mnth,year=@year,target=@target,actual=@actual,Id_Outage=@Id_Outage WHERE Id_Monthly_OutAge=@Id_Monthly_OutAge", cnn);
        cmd.Parameters.AddWithValue("@Mnth", this.Mnth);
        cmd.Parameters.AddWithValue("@year", this.year);
        cmd.Parameters.AddWithValue("@target", this.target);
        cmd.Parameters.AddWithValue("@actual", this.actual);
        cmd.Parameters.AddWithValue("@Id_Outage", this.Id_Outage);
        cmd.Parameters.AddWithValue("@Id_Monthly_OutAge", this.Id_Monthly_OutAge);
        cmd.Connection.Open();
        Int64 m = cmd.ExecuteNonQuery();
        cmd.Connection.Close();
    }
    public void Delete_Data()
    {
        cmd = new SqlCommand("DELTE FROM Monthly_OutAge WHERE Id_Monthly_OutAge=@Id_Monthly_OutAge", cnn);
        cmd.Parameters.AddWithValue("@Id_Monthly_OutAge", this.Id_Monthly_OutAge);
        cmd.Connection.Open();
        Int64 m = cmd.ExecuteNonQuery();
        cmd.Connection.Close();
    }
    public DataTable Select_DataById()
    {
        cmd = new SqlCommand("SELECT Monthly_OutAge.Mnth as \"Month\",Monthly_OutAge.year as \"Year\",Monthly_OutAge.target as \"Target\",Monthly_OutAge.actual as \"Actual\" FROM Monthly_OutAge WHERE Id_OutAge=@Id_OutAge", cnn);
        cmd.Parameters.AddWithValue("@Id_OutAge", this.Id_Outage);
        da = new SqlDataAdapter();
        dt = new DataTable();
        da.SelectCommand = cmd;
        da.Fill(dt);
        return dt;
    }
    public DataTable Select_DataById_1()
    {
   //     cmd = new SqlCommand("SELECT Monthly_OutAge.Mnth as \"Month\",Monthly_OutAge.year as \"Year\",Monthly_OutAge.target as \"Target\",Monthly_OutAge.actual as \"Actual\" FROM Monthly_OutAge WHERE Id_OutAge=@Id_OutAge", cnn);
        cmd = new SqlCommand("SELECT DISTINCT (Monthly_OutAge.Mnth) as \"Month\",Monthly_OutAge.year as \"Year\",Monthly_OutAge.target as \"Target\",Monthly_OutAge.actual as \"Actual\" FROM Monthly_OutAge  WHERE Id_OutAge=@Id_OutAge", cnn);
        //cmd = new SqlCommand("SELECT * FROM Monthly_OutAge ", cnn);
        cmd.Parameters.AddWithValue("@Id_OutAge", this.Id_Outage);
        da = new SqlDataAdapter();
        dt = new DataTable();
        da.SelectCommand = cmd;
        da.Fill(dt);
        return dt;
    }
    public bool Check_Existance()
    {
        cmd = new SqlCommand("SELECT COUNT(*) FROM Monthly_OutAge WHERE Mnth=@Mnth AND year=@year", cnn);
        cmd.Parameters.AddWithValue("@Mnth", this.Mnth);
        cmd.Parameters.AddWithValue("@year", this.year);
        cmd.Connection.Open();
        Int16 n = Convert.ToInt16(cmd.ExecuteScalar());
        cmd.Connection.Close();
        return n == 1 ? true : false;
    }
    public Int64 Get_IdByMonth_n_Year()
    {
        cmd = new SqlCommand("SELECT Id_Monthly_OutAge FROM Monthly_OutAge WHERE Mnth=@Mnth AND year=@year", cnn);
        cmd.Parameters.AddWithValue("@Mnth", this.Mnth);
        cmd.Parameters.AddWithValue("@year", this.year);
        cmd.Connection.Open();
        Int16 n = Convert.ToInt16(cmd.ExecuteScalar());
        cmd.Connection.Close();
        return n;
    }
}
