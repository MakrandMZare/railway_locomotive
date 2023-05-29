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
/// Summary description for gear_case_oil
/// </summary>
public class gear_case_oil : Cls_DBConnection
{
    public string gear_case_id;
    public string id_mst_loco;
    public string g_date;
    public string sch;
    public string lg1;
    public string lg2;
    public string lg3;
    public string rg4;
    public string rg5;
    public string rg6;
    public string remarks;
    public string testedby;


    public gear_case_oil()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public Int64 Insert_Data()
    {
        try
        {
            cmd = new SqlCommand("INSERT INTO table_gear_case_oil   (id_mst_loco, g_date, sch, lg1, lg2, lg3, rg4, rg5, rg6, remarks, testedby) VALUES (@id_mst_loco, @g_date, @sch, @lg1, @lg2, @lg3, @rg4, @rg5, @rg6, @remarks, @testedby)", cnn);
            cmd.Parameters.AddWithValue("@id_mst_loco", this.id_mst_loco);
            cmd.Parameters.AddWithValue("@g_date", this.g_date);
            cmd.Parameters.AddWithValue("@sch", this.sch);
            cmd.Parameters.AddWithValue("@lg1", this.lg1);
            cmd.Parameters.AddWithValue("@lg2", this.lg2);
            cmd.Parameters.AddWithValue("@lg3", this.lg3);
            cmd.Parameters.AddWithValue("@rg4", this.rg4);
            cmd.Parameters.AddWithValue("@rg5", this.rg5);

            cmd.Parameters.AddWithValue("@rg6", this.rg6);
            cmd.Parameters.AddWithValue("@remarks", this.remarks);
            cmd.Parameters.AddWithValue("@testedby", this.testedby);
            cmd.Connection.Open();
            Int16 n = Convert.ToInt16(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            if (n == 1)
            {
                cmd = new SqlCommand("SELECT MAX(gear_case_id) FROM  table_gear_case_oil", cnn);
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
            cmd = new SqlCommand("UPDATE table_gear_case_oil  SET id_mst_loco =@id_mst_loco, g_date =@g_date , sch =@sch , lg1 =@lg1 , lg2 =@lg2 , lg3 =@lg3 , rg4 =@rg4 , rg5 =@rg5 , rg6 =@rg6 , remarks =@remarks , testedby =@testedby  WHERE gear_case_id=@gear_case_id", cnn);
            cmd.Parameters.AddWithValue("@gear_case_id", this.gear_case_id);
            cmd.Parameters.AddWithValue("@id_mst_loco", this.id_mst_loco);
            cmd.Parameters.AddWithValue("@g_date", this.g_date);
            cmd.Parameters.AddWithValue("@sch", this.sch);
            cmd.Parameters.AddWithValue("@lg1", this.lg1);
            cmd.Parameters.AddWithValue("@lg2", this.lg2);
            cmd.Parameters.AddWithValue("@lg3", this.lg3);
            cmd.Parameters.AddWithValue("@rg4", this.rg4);
            cmd.Parameters.AddWithValue("@rg5", this.rg5);

            cmd.Parameters.AddWithValue("@rg6", this.rg6);
            cmd.Parameters.AddWithValue("@remarks", this.remarks);
            cmd.Parameters.AddWithValue("@testedby", this.testedby);
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
            cmd = new SqlCommand("DELETE FROM table_gear_case_oil WHERE gear_case_id=@gear_case_id", cnn);
            cmd.Parameters.AddWithValue("@gear_case_id", this.gear_case_id);
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
            //cmd = new SqlCommand("SELECT * FROM Loco_CompressorOil WHERE Id_Loco=@Id_Loco AND Loco_Date=@Loco_Date", cnn);
            //cmd = new SqlCommand("SELECT * FROM Loco_CompressorOil WHERE Id_Loco=@Id_Loco", cnn);
            cmd = new SqlCommand("SELECT table_gear_case_oil.gear_case_id " +
      ",table_gear_case_oil.id_mst_loco " +
      ",jos_railway_mst_loco.locono as Locono" +
      ",REPLACE(CONVERT(VARCHAR(10),table_gear_case_oil.g_date,105),'-','/') as  Loco_Date" +
      ",table_gear_case_oil.sch as Id_Schedule1 " +
      ",jos_railway_loco_type_schedule.s_type as Id_Schedule " +
      ",table_gear_case_oil.lg1 " +
      ",table_gear_case_oil.lg2 " +
      ",table_gear_case_oil.lg3 " +
      ",table_gear_case_oil.rg4 " +
      ",table_gear_case_oil.rg5 " +


      ",table_gear_case_oil.rg6 " +
      ",table_gear_case_oil.remarks " +
      ",table_gear_case_oil.testedby " +

      "FROM table_gear_case_oil " +
      "INNER JOIN  jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = table_gear_case_oil.sch " +
      "INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = table_gear_case_oil.id_mst_loco WHERE table_gear_case_oil.id_mst_loco=@id_mst_loco", cnn);
            cmd.Parameters.AddWithValue("@id_mst_loco", this.id_mst_loco);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        catch { throw; }
    }

    public DataTable Select_DataByLOCO(string locono)
    {
        try
        {
            //cmd = new SqlCommand("SELECT * FROM Loco_CompressorOil WHERE Id_Loco=@Id_Loco AND Loco_Date=@Loco_Date", cnn);
            //cmd = new SqlCommand("SELECT * FROM Loco_CompressorOil WHERE Id_Loco=@Id_Loco", cnn);
            cmd = new SqlCommand("SELECT table_gear_case_oil.gear_case_id " +
      ",table_gear_case_oil.id_mst_loco " +
      ",jos_railway_mst_loco.locono as Locono" +
      ",REPLACE(CONVERT(VARCHAR(10),table_gear_case_oil.g_date,105),'-','/') as  Loco_Date" +
      ",table_gear_case_oil.sch as Id_Schedule1 " +
      ",jos_railway_loco_type_schedule.s_type as Id_Schedule " +
      ",table_gear_case_oil.lg1 " +
      ",table_gear_case_oil.lg2 " +
      ",table_gear_case_oil.lg3 " +
      ",table_gear_case_oil.rg4 " +
      ",table_gear_case_oil.rg5 " +


      ",table_gear_case_oil.rg6 " +
      ",table_gear_case_oil.remarks " +
      ",table_gear_case_oil.testedby " +

      "FROM table_gear_case_oil " +
      "INNER JOIN  jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = table_gear_case_oil.sch " +
      "INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = table_gear_case_oil.id_mst_loco WHERE table_gear_case_oil.id_mst_loco='" + locono + "'", cnn);
           // cmd.Parameters.AddWithValue("@id_mst_loco", this.id_mst_loco);
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
        try
        {
            cmd = new SqlCommand("SELECT table_gear_case_oil.gear_case_id " +
     ",table_gear_case_oil.id_mst_loco " +
     ",jos_railway_mst_loco.locono as Locono" +
     ",REPLACE(CONVERT(VARCHAR(10),table_gear_case_oil.g_date,105),'-','/') as  Loco_Date" +
     ",table_gear_case_oil.sch as Id_Schedule1 " +
     ",jos_railway_loco_type_schedule.s_type as Id_Schedule " +
     ",table_gear_case_oil.lg1 " +
     ",table_gear_case_oil.lg2 " +
     ",table_gear_case_oil.lg3 " +
     ",table_gear_case_oil.rg4 " +
     ",table_gear_case_oil.rg5 " +


     ",table_gear_case_oil.rg6 " +
     ",table_gear_case_oil.remarks " +
     ",table_gear_case_oil.testedby " +

     "FROM table_gear_case_oil " +
     "INNER JOIN  jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = table_gear_case_oil.sch " +
     "INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = table_gear_case_oil.id_mst_loco ", cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        catch { throw; }
    }
    
    public DataTable Select_DataById()
    {
        try
        {
            cmd = new SqlCommand("SELECT * FROM table_gear_case_oil WHERE Id_Loco=@Id_Loco", cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        catch { throw; }
    }

}


