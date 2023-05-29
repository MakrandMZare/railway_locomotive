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
/// Summary description for Cls_OutAge_Sub2
/// </summary>
public class Cls_OutAge_Sub2 : Cls_DBConnection
{
    public string Id_Outage_Sub2;
    public string Failures;
    public string AvgLOC;
    public string AvgGear;
    public string AvgCompressor;
    public string SpecificFuel;
    public string AvgRunniung;
    public string Id_Outage;

    public Int64 Insert_Data()
    {
        cmd = new SqlCommand("INSERT INTO Outage_Sub2(Failures,AvgLOC,AvgGear,AvgCompressor,SpecificFuel,AvgRunniung,Id_Outage) VALUES(@Failures,@AvgLOC,@AvgGear,@AvgCompressor,@SpecificFuel,@AvgRunniung,@Id_Outage)", cnn);
        cmd.Parameters.AddWithValue("@Failures", this.Failures);
        cmd.Parameters.AddWithValue("@AvgLOC", this.AvgLOC);
        cmd.Parameters.AddWithValue("@AvgGear", this.AvgGear);
        cmd.Parameters.AddWithValue("@AvgCompressor", this.AvgCompressor);
        cmd.Parameters.AddWithValue("@SpecificFuel", this.SpecificFuel);
        cmd.Parameters.AddWithValue("@AvgRunniung", this.AvgRunniung);
        cmd.Parameters.AddWithValue("@Id_Outage", this.Id_Outage);
        cmd.Connection.Open();
        Int64 n = cmd.ExecuteNonQuery();
        cmd.Connection.Close();
        if (n == 1)
        {
            cmd = new SqlCommand("SELECT MAX(Id_Outage_Sub2) FROM Outage_Sub2", cnn);
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
        cmd = new SqlCommand("UPDATE Outage_Sub2 SET Failures=@Failures,AvgLOC=@AvgLOC,AvgGear=@AvgGear,AvgCompressor=@AvgCompressor,SpecificFuel=@SpecificFuel,AvgRunniung=@AvgRunniung,Id_Outage=@Id_Outage WHERE Id_Outage_Sub2=@Id_Outage_Sub2", cnn);
        cmd.Parameters.AddWithValue("@Failures", this.Failures);
        cmd.Parameters.AddWithValue("@AvgLOC", this.AvgLOC);
        cmd.Parameters.AddWithValue("@AvgGear", this.AvgGear);
        cmd.Parameters.AddWithValue("@AvgCompressor", this.AvgCompressor);
        cmd.Parameters.AddWithValue("@SpecificFuel", this.SpecificFuel);
        cmd.Parameters.AddWithValue("@AvgRunniung", this.AvgRunniung);
        cmd.Parameters.AddWithValue("@Id_Outage", this.Id_Outage);
        cmd.Parameters.AddWithValue("@Id_Outage_Sub2", this.Id_Outage_Sub2);
        cmd.Connection.Open();
        Int64 m = cmd.ExecuteNonQuery();
        cmd.Connection.Close();
    }
    public void Delete_Data()
    {
        cmd = new SqlCommand("DELTE FROM Outage_Sub2 WHERE Id_OutAge=@Id_OutAge", cnn);
        cmd.Parameters.AddWithValue("@Id_OutAge", this.Id_Outage);
        cmd.Connection.Open();
        Int64 m = cmd.ExecuteNonQuery();
        cmd.Connection.Close();
    }
    public DataTable Select_DataById()
    {
        cmd = new SqlCommand("SELECT * FROM Outage_Sub2 WHERE Id_OutAge=@Id_OutAge", cnn);

        
        cmd.Parameters.AddWithValue("@Id_OutAge", this.Id_Outage);
        da = new SqlDataAdapter();
        dt = new DataTable();
        da.SelectCommand = cmd;
        da.Fill(dt);
        return dt;
    }
    public DataTable Select_DataById_1()
    {
           cmd = new SqlCommand("SELECT * FROM Outage_Sub2 WHERE Id_OutAge=@Id_OutAge", cnn);

     //   cmd = new SqlCommand("SELECT * FROM Outage_Sub2 ", cnn);
        cmd.Parameters.AddWithValue("@Id_OutAge", this.Id_Outage);
        da = new SqlDataAdapter();
        dt = new DataTable();
        da.SelectCommand = cmd;
        da.Fill(dt);
        return dt;
    }
    public Cls_OutAge_Sub2()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}
