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
/// Summary description for hsd_oil
/// </summary>
public class hsd_oil:Cls_DBConnection
{
    public string hsd_id;
    public string id_mst_loco;
    public string h_date;
    public string sch;
    public string sample_collect;
    public string water_conts;
    public string sediments;
    public string color;
    public string remarks;
    public string testedby;

    public hsd_oil()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public Int64 Insert_Data()
    {
        try
        {
            cmd = new SqlCommand("INSERT INTO table_hsd_oil  (id_mst_loco, h_date, sch, sample_collect, water_conts, sediments, color, remarks, testedby) VALUES (@id_mst_loco, @h_date, @sch, @sample_collect, @water_conts, @sediments, @color, @remarks, @testedby)", cnn);
            cmd.Parameters.AddWithValue("@id_mst_loco", this.id_mst_loco);
            cmd.Parameters.AddWithValue("@h_date", this.h_date);
            cmd.Parameters.AddWithValue("@sch", this.sch);
            cmd.Parameters.AddWithValue("@sample_collect", this.sample_collect);
            cmd.Parameters.AddWithValue("@water_conts", this.water_conts);
            cmd.Parameters.AddWithValue("@sediments", this.sediments);
            cmd.Parameters.AddWithValue("@color", this.color);
            cmd.Parameters.AddWithValue("@remarks", this.remarks);
            cmd.Parameters.AddWithValue("@testedby", this.testedby);
            cmd.Connection.Open();
            Int16 n = Convert.ToInt16(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            if (n == 1)
            {
                cmd = new SqlCommand("SELECT MAX(hsd_id) FROM  table_hsd_oil", cnn);
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
            cmd = new SqlCommand("UPDATE    table_hsd_oil  SET id_mst_loco =@id_mst_loco, h_date =@h_date, sch =@sch , sample_collect =@sample_collect , water_conts =@water_conts, sediments =@sediments , color =@color , remarks =@remarks , testedby =@testedby  WHERE hsd_id=@hsd_id", cnn);
            cmd.Parameters.AddWithValue("@hsd_id", this.hsd_id);
            cmd.Parameters.AddWithValue("@id_mst_loco", this.id_mst_loco);
            cmd.Parameters.AddWithValue("@h_date", this.h_date);
            cmd.Parameters.AddWithValue("@sch", this.sch);
            cmd.Parameters.AddWithValue("@sample_collect", this.sample_collect);
            cmd.Parameters.AddWithValue("@water_conts", this.water_conts);
            cmd.Parameters.AddWithValue("@sediments", this.sediments);
            cmd.Parameters.AddWithValue("@color", this.color);
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
            cmd = new SqlCommand("DELETE FROM table_hsd_oil WHERE hsd_id=@hsd_id", cnn);
            cmd.Parameters.AddWithValue("@hsd_id", this.hsd_id);
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
            cmd = new SqlCommand("SELECT table_hsd_oil.hsd_id " +
      ",table_hsd_oil.id_mst_loco " +
      ",jos_railway_mst_loco.locono as Locono" +
      ",REPLACE(CONVERT(VARCHAR(10),table_hsd_oil.h_date,105),'-','/') as  Loco_Date" +
      ",table_hsd_oil.sch as Id_Schedule1 " +
      ",jos_railway_loco_type_schedule.s_type as Id_Schedule " +
      ",table_hsd_oil.sample_collect " +
      ",table_hsd_oil.water_conts " +
      ",table_hsd_oil.sediments " +
      ",table_hsd_oil.color " +
      ",table_hsd_oil.remarks " +


      ",table_hsd_oil.testedby " +

      "FROM table_hsd_oil " +
      "INNER JOIN  jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = table_hsd_oil.sch " +
      "INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = table_hsd_oil.id_mst_loco WHERE table_hsd_oil.id_mst_loco=@id_mst_loco", cnn);
            cmd.Parameters.AddWithValue("@id_mst_loco", this.id_mst_loco);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        catch { throw; }
    }


    //-------------------------------------------
     public DataTable Select_Data_All()
    {

       
        cmd = new SqlCommand("SELECT table_hsd_oil.hsd_id " +
      ",table_hsd_oil.id_mst_loco " +
      ",jos_railway_mst_loco.locono as Locono" +
      ",REPLACE(CONVERT(VARCHAR(10),table_hsd_oil.h_date,105),'-','/') as  Loco_Date" +
      ",table_hsd_oil.sch as Id_Schedule1 " +
      ",jos_railway_loco_type_schedule.s_type as Id_Schedule " +
      ",table_hsd_oil.sample_collect " +
      ",table_hsd_oil.water_conts " +
      ",table_hsd_oil.sediments " +
      ",table_hsd_oil.color " +
      ",table_hsd_oil.remarks " +


      ",table_hsd_oil.testedby " +

      "FROM table_hsd_oil " +
      "INNER JOIN  jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = table_hsd_oil.sch " +
      "INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = table_hsd_oil.id_mst_loco ", cnn);
       
        dt = new DataTable();
        da = new SqlDataAdapter();
        da.SelectCommand = cmd;
        dt.Clear();
        da.Fill(dt);
        return dt;
    }






  public DataTable Select_DataByLOCO( string locono)
    {

       
        cmd = new SqlCommand(" SELECT table_hsd_oil.hsd_id " +
      ",table_hsd_oil.id_mst_loco " +
      ",jos_railway_mst_loco.locono as Locono" +
      ",REPLACE(CONVERT(VARCHAR(10),table_hsd_oil.h_date,105),'-','/') as  Loco_Date" +
      ",table_hsd_oil.sch as Id_Schedule1 " +
      ",jos_railway_loco_type_schedule.s_type as Id_Schedule " +
      ",table_hsd_oil.sample_collect " +
      ",table_hsd_oil.water_conts " +
      ",table_hsd_oil.sediments " +
      ",table_hsd_oil.color " +
      ",table_hsd_oil.remarks " +


      ",table_hsd_oil.testedby " +

      "FROM table_hsd_oil " +
      "INNER JOIN  jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = table_hsd_oil.sch " +
      "INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = table_hsd_oil.id_mst_loco where table_hsd_oil.id_mst_loco='"+locono+"' ", cnn);
       
        dt = new DataTable();
        da = new SqlDataAdapter();
        da.SelectCommand = cmd;
        dt.Clear();
        da.Fill(dt);
        return dt;
    }

    //---------------------------------------------
    public DataTable Select_DataById()
    {
        try
        {
            cmd = new SqlCommand("SELECT * FROM table_hsd_oil WHERE id_mst_loco=@id_mst_loco", cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        catch { throw; }
    }

}


