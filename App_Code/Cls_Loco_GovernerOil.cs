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
/// Summary description for Cls_Loco_GovernerOil
/// </summary>
/// 

public class Cls_Loco_GovernerOil : Cls_DBConnection
{

    public string Id_GovernerOil;
    public string Id_Loco;
    public string Loco_Date;
    public string Id_Schedule;
    public string WaterContent;
    public string FalshPoint;
    public string Viscosity;
    public string Result_Remarks;
    public string Tested_By;
    public Cls_Loco_GovernerOil()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public Int64 Insert_Data()
    {
        try
        {
            cmd = new SqlCommand("INSERT INTO Loco_GovernerOil(Id_Loco,Loco_Date,Id_Schedule,WaterContent,FalshPoint,Viscosity,Result_Remarks,Tested_By) VALUES(@Id_Loco,@Loco_Date,@Id_Schedule,@WaterContent,@FalshPoint,@Viscosity,@Result_Remarks,@Tested_By)", cnn);
            cmd.Parameters.AddWithValue("@FalshPoint", this.FalshPoint);
            cmd.Parameters.AddWithValue("@Id_Loco", this.Id_Loco);
            cmd.Parameters.AddWithValue("@Id_Schedule", this.Id_Schedule);
            cmd.Parameters.AddWithValue("@Loco_Date", this.Loco_Date);
            cmd.Parameters.AddWithValue("@Result_Remarks", this.Result_Remarks);
            cmd.Parameters.AddWithValue("@Tested_By", this.Tested_By);
            cmd.Parameters.AddWithValue("@Viscosity", this.Viscosity);
            cmd.Parameters.AddWithValue("@WaterContent", this.WaterContent);
            cmd.Connection.Open();
            Int16 n = Convert.ToInt16(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            if (n == 1)
            {
                cmd = new SqlCommand("SELECT MAX(Id_GovernerOil) FROM  Loco_GovernerOil", cnn);
                cmd.Connection.Open();
                Int64 m = Convert.ToInt64(cmd.ExecuteNonQuery());
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
            cmd = new SqlCommand("UPDATE Loco_GovernerOil SET Id_Loco=@Id_Loco,Loco_Date=@Loco_Date,Id_Schedule=@Id_Schedule,WaterContent=@WaterContent,FalshPoint=@FalshPoint,Viscosity=@Viscosity,Result_Remarks=@Result_Remarks,Tested_By=@Tested_By WHERE Id_GovernerOil=@Id_GovernerOil", cnn);
            cmd.Parameters.AddWithValue("@Id_GovernerOil", this.Id_GovernerOil);
            cmd.Parameters.AddWithValue("@FalshPoint", this.FalshPoint);
            cmd.Parameters.AddWithValue("@Id_Loco", this.Id_Loco);
            cmd.Parameters.AddWithValue("@Id_Schedule", this.Id_Schedule);
            cmd.Parameters.AddWithValue("@Loco_Date", this.Loco_Date);
            cmd.Parameters.AddWithValue("@Result_Remarks", this.Result_Remarks);
            cmd.Parameters.AddWithValue("@Tested_By", this.Tested_By);
            cmd.Parameters.AddWithValue("@Viscosity", this.Viscosity);
            cmd.Parameters.AddWithValue("@WaterContent", this.WaterContent);
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
            cmd = new SqlCommand("DELETE FROM Loco_GovernerOil WHERE Id_GovernerOil=@Id_GovernerOil",cnn);
            cmd.Parameters.AddWithValue("@Id_GovernerOil", this.Id_GovernerOil);
            cmd.Connection.Open();
            Int16 n = Convert.ToInt16(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            return n == 1 ? true : false;
        }
        catch { throw; }
    }
    public DataTable Select_DataByLoco_n_Date()
    {
        try
        {
            //cmd = new SqlCommand("SELECT * FROM Loco_GovernerOil WHERE Id_Loco=@Id_Loco AND Loco_Date=@Loco_Date", cnn);
            //cmd = new SqlCommand("SELECT * FROM Loco_GovernerOil WHERE Id_Loco=@Id_Loco", cnn);
            cmd = new SqlCommand("SELECT Loco_GovernerOil.Id_GovernerOil " +
      ",Loco_GovernerOil.Id_Loco " +
      ",jos_railway_mst_loco.locono as Locono" +
      ",REPLACE(CONVERT(VARCHAR(10),Loco_GovernerOil.Loco_Date,105),'-','/') as  Loco_Date" +
      ",Loco_GovernerOil.Id_Schedule as Id_Schedule1 " +
      ",jos_railway_loco_type_schedule.s_type as Id_Schedule " +
      ",Loco_GovernerOil.WaterContent " +
      ",Loco_GovernerOil.FalshPoint " +
      ",Loco_GovernerOil.Viscosity " +
      ",Loco_GovernerOil.Result_Remarks " +
      ",Loco_GovernerOil.Tested_By " +
      "FROM Loco_GovernerOil " +
      "INNER JOIN  jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = Loco_GovernerOil.Id_Schedule " +
      "INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = Loco_GovernerOil.Id_Loco WHERE Id_Loco=@Id_Loco", cnn);
            cmd.Parameters.AddWithValue("@Id_Loco", this.Id_Loco);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        catch { throw; }
    }


     public DataTable Select_Data_All()
    {


        cmd = new SqlCommand("SELECT Loco_GovernerOil.Id_GovernerOil " +
      ",Loco_GovernerOil.Id_Loco " +
      ",jos_railway_mst_loco.locono as Locono" +
      ",REPLACE(CONVERT(VARCHAR(10),Loco_GovernerOil.Loco_Date,105),'-','/') as  Loco_Date" +
      ",Loco_GovernerOil.Id_Schedule as Id_Schedule1 " +
      ",jos_railway_loco_type_schedule.s_type as Id_Schedule " +
      ",Loco_GovernerOil.WaterContent " +
      ",Loco_GovernerOil.FalshPoint " +
      ",Loco_GovernerOil.Viscosity " +
      ",Loco_GovernerOil.Result_Remarks " +
      ",Loco_GovernerOil.Tested_By " +
      "FROM Loco_GovernerOil " +
      "INNER JOIN  jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = Loco_GovernerOil.Id_Schedule " +
      "INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = Loco_GovernerOil.Id_Loco ", cnn);
       
        dt = new DataTable();
        da = new SqlDataAdapter();
        da.SelectCommand = cmd;
        dt.Clear();
        da.Fill(dt);
        return dt;
    }

  public DataTable Select_DataByLOCO( string locono)
    {


        cmd = new SqlCommand("SELECT Loco_GovernerOil.Id_GovernerOil " +
      ",Loco_GovernerOil.Id_Loco " +
      ",jos_railway_mst_loco.locono as Locono" +
      ",REPLACE(CONVERT(VARCHAR(10),Loco_GovernerOil.Loco_Date,105),'-','/') as  Loco_Date" +
      ",Loco_GovernerOil.Id_Schedule as Id_Schedule1 " +
      ",jos_railway_loco_type_schedule.s_type as Id_Schedule " +
      ",Loco_GovernerOil.WaterContent " +
      ",Loco_GovernerOil.FalshPoint " +
      ",Loco_GovernerOil.Viscosity " +
      ",Loco_GovernerOil.Result_Remarks " +
      ",Loco_GovernerOil.Tested_By " +
      "FROM Loco_GovernerOil " +
      "INNER JOIN  jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = Loco_GovernerOil.Id_Schedule " +
      "INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = Loco_GovernerOil.Id_Loco  where Loco_GovernerOil.Id_Loco='" + locono + "' ", cnn);
       
        dt = new DataTable();
        da = new SqlDataAdapter();
        da.SelectCommand = cmd;
        dt.Clear();
        da.Fill(dt);
        return dt;
    }



    public DataTable Select_DataById()
    {
        try
        {
            cmd = new SqlCommand("SELECT * FROM Loco_GovernerOil WHERE Id_Loco=@Id_Loco", cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        catch { throw; }
    }
}
