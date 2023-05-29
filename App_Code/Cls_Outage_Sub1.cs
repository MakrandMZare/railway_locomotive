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
/// Summary description for Cls_Outage_Sub1
/// </summary>
public class Cls_Outage_Sub1 : Cls_DBConnection
{
    public string SBIHR;
    public string SBILR;
    public string SBIUR;
    public string Dead;
    public string OtherDiv;
    public string LieOver;
    public string Id_Outage;
    public string Id_Outage_Sub1;
    public string guage;
    public Cls_Outage_Sub1()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public Int64 Insert_Data()
    {
        cmd = new SqlCommand("INSERT INTO Outage_Sub1(SBIHR,SBILR,SBIUR,Dead,OtherDiv,LieOver,Id_Outage,guage) VALUES(@SBIHR,@SBILR,@SBIUR,@Dead,@OtherDiv,@LieOver,@Id_Outage,@guage)", cnn);
        cmd.Parameters.AddWithValue("@SBIHR", this.SBIHR);
        cmd.Parameters.AddWithValue("@SBILR", this.SBILR);
        cmd.Parameters.AddWithValue("@SBIUR", this.SBIUR);
        cmd.Parameters.AddWithValue("@Dead", this.Dead);
        cmd.Parameters.AddWithValue("@OtherDiv", this.OtherDiv);
        cmd.Parameters.AddWithValue("@LieOver", this.LieOver);
        cmd.Parameters.AddWithValue("@guage", this.guage);
        cmd.Parameters.AddWithValue("@Id_Outage", this.Id_Outage);
        cmd.Connection.Open();
        Int64 n = cmd.ExecuteNonQuery();
        cmd.Connection.Close();
        if (n == 1)
        {
            cmd = new SqlCommand("SELECT MAX(Id_Outage_Sub1) FROM Outage_Sub1", cnn);
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
        cmd = new SqlCommand("UPDATE Outage_Sub1 SET SBIHR=@SBIHR,SBILR=@SBILR,SBIUR=@SBIUR,Dead=@Dead,OtherDiv=@OtherDiv,LieOver=@LieOver WHERE Id_Outage_Sub1=@Id_Outage_Sub1", cnn);
        cmd.Parameters.AddWithValue("@SBIHR", this.SBIHR);
        cmd.Parameters.AddWithValue("@SBILR", this.SBILR);
        cmd.Parameters.AddWithValue("@SBIUR", this.SBIUR);
        cmd.Parameters.AddWithValue("@Dead", this.Dead);
        cmd.Parameters.AddWithValue("@OtherDiv", this.OtherDiv);
        cmd.Parameters.AddWithValue("@LieOver", this.LieOver);
        cmd.Parameters.AddWithValue("@Id_Outage_Sub1", this.Id_Outage_Sub1);
        cmd.Connection.Open();
        Int64 m = cmd.ExecuteNonQuery();
        cmd.Connection.Close();
    }
    public void Delete_Data()
    {
        cmd = new SqlCommand("DELTE FROM Outage_Sub1 WHERE Id_Outage=@Id_Outage", cnn);
        cmd.Parameters.AddWithValue("@Id_Outage", this.Id_Outage);
        cmd.Connection.Open();
        Int64 m = cmd.ExecuteNonQuery();
        cmd.Connection.Close();
    }
    public DataTable Select_DataById(string guage)
    {
        cmd = new SqlCommand("SELECT * FROM Outage_Sub1 WHERE Id_Outage=@Id_Outage", cnn);
       
        cmd.Parameters.AddWithValue("@Id_Outage", this.Id_Outage);
        cmd.Parameters.AddWithValue("@guage", guage);
        da = new SqlDataAdapter();
        dt = new DataTable();
        da.SelectCommand = cmd;
        da.Fill(dt);
        return dt;
    }
    public DataTable Select_DataById_1(string guage)
    {
        cmd = new SqlCommand("SELECT * FROM Outage_Sub1 WHERE Id_Outage=@Id_Outage", cnn);
      //  cmd = new SqlCommand("SELECT * FROM Outage_Sub1 ", cnn);
        cmd.Parameters.AddWithValue("@Id_Outage", this.Id_Outage);
        cmd.Parameters.AddWithValue("@guage", guage);
        da = new SqlDataAdapter();
        dt = new DataTable();
        da.SelectCommand = cmd;
        da.Fill(dt);
        return dt;
    }


}