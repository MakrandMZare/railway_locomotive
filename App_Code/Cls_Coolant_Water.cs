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
/// Summary description for Cls_Coolant_Water
/// </summary>
public class Cls_Coolant_Water:Cls_DBConnection
{
	public Cls_Coolant_Water()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public string coolantwater_id;
    public string id_mst_loco;
    public string c_date;
    public string after_water_chage;
    public string ph;
    public string hardness;
    public string chloride;
    public string nitrate;
    public string remarks;
    public string testedby;

    
    public Int64 Insert_Data()
    {
        try
        {
            cmd = new SqlCommand("INSERT INTO table_coolant_water (id_mst_loco, c_date, after_water_chage, ph, hardness, chloride, nitrate, remarks, testedby) VALUES(@id_mst_loco, @c_date, @after_water_chage, @ph, @hardness, @chloride, @nitrate, @remarks, @testedby) ", cnn);
            cmd.Parameters.AddWithValue("@id_mst_loco", this.id_mst_loco);
            cmd.Parameters.AddWithValue("@c_date", this.c_date);
            cmd.Parameters.AddWithValue("@after_water_chage", this.after_water_chage);
            cmd.Parameters.AddWithValue("@ph", this.ph);
            cmd.Parameters.AddWithValue("@hardness", this.hardness);
            cmd.Parameters.AddWithValue("@chloride", this.chloride);
            cmd.Parameters.AddWithValue("@nitrate", this.nitrate);
            cmd.Parameters.AddWithValue("@remarks", this.remarks);
            cmd.Parameters.AddWithValue("@testedby", this.testedby);
            cmd.Connection.Open();
            Int16 n = Convert.ToInt16(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            if (n == 1)
            {
                cmd = new SqlCommand("SELECT MAX(coolantwater_id) FROM  table_coolant_water", cnn);
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
            cmd = new SqlCommand("UPDATE    table_coolant_water SET    id_mst_loco =@id_mst_loco, c_date =@c_date, after_water_chage =@after_water_chage, ph =@ph, hardness =@hardness, chloride =@chloride, nitrate =@nitrate, remarks =@remarks, testedby =@testedby where coolantwater_id=@coolantwater_id", cnn);
            cmd.Parameters.AddWithValue("@coolantwater_id", this.coolantwater_id);
           cmd.Parameters.AddWithValue("@id_mst_loco", this.id_mst_loco);
            cmd.Parameters.AddWithValue("@c_date", this.c_date);
            cmd.Parameters.AddWithValue("@after_water_chage", this.after_water_chage);
            cmd.Parameters.AddWithValue("@ph", this.ph);
            cmd.Parameters.AddWithValue("@hardness", this.hardness);
            cmd.Parameters.AddWithValue("@chloride", this.chloride);
            cmd.Parameters.AddWithValue("@nitrate", this.nitrate);
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
            cmd = new SqlCommand("DELETE FROM table_coolant_water WHERE coolantwater_id=@coolantwater_id",cnn);
            cmd.Parameters.AddWithValue("@coolantwater_id", this.coolantwater_id);
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
            //cmd = new SqlCommand("SELECT * FROM Loco_CompressorOil WHERE id_mst_loco=@id_mst_loco AND Loco_Date=@Loco_Date", cnn);
            //cmd = new SqlCommand("SELECT * FROM Loco_CompressorOil WHERE id_mst_loco=@id_mst_loco", cnn);
            cmd = new SqlCommand("SELECT table_coolant_water.coolantwater_id " +
      ",table_coolant_water.id_mst_loco " +
      ",jos_railway_mst_loco.locono as Locono" +
      ",REPLACE(CONVERT(VARCHAR(10),table_coolant_water.c_date,105),'-','/') as  Loco_Date" +

            ",table_coolant_water.after_water_chage " +
      ",table_coolant_water.ph " +
      ",table_coolant_water.hardness " +
      ",table_coolant_water.chloride " +
      ",table_coolant_water.nitrate " +
      ",table_coolant_water.remarks " +
      ",table_coolant_water.testedby " +
      "FROM table_coolant_water " +

      "INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = table_coolant_water.id_mst_loco WHERE table_coolant_water.id_mst_loco=@id_mst_loco", cnn);
            cmd.Parameters.AddWithValue("@id_mst_loco", this.id_mst_loco);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        catch { throw; }
    }

    public DataTable Select_DataByLoco()
    {
        try
        {
            //cmd = new SqlCommand("SELECT * FROM Loco_CompressorOil WHERE id_mst_loco=@id_mst_loco AND Loco_Date=@Loco_Date", cnn);
            //cmd = new SqlCommand("SELECT * FROM Loco_CompressorOil WHERE id_mst_loco=@id_mst_loco", cnn);
            cmd = new SqlCommand("SELECT table_coolant_water.coolantwater_id " +
      ",table_coolant_water.id_mst_loco " +
      ",jos_railway_mst_loco.locono as Locono" +
      ",REPLACE(CONVERT(VARCHAR(10),table_coolant_water.c_date,105),'-','/') as  Loco_Date" +

            ",table_coolant_water.after_water_chage " +
      ",table_coolant_water.ph " +
      ",table_coolant_water.hardness " +
      ",table_coolant_water.chloride " +
      ",table_coolant_water.nitrate " +
      ",table_coolant_water.remarks " +
      ",table_coolant_water.testedby " +
      "FROM table_coolant_water " +

      "INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = table_coolant_water.id_mst_loco ", cnn);
        //    cmd.Parameters.AddWithValue("@id_mst_loco", this.id_mst_loco);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        catch { throw; }
    }


    public DataTable Select_DataByLoco_All(string locono)
    {
        try
        {
            //cmd = new SqlCommand("SELECT * FROM Loco_CompressorOil WHERE id_mst_loco=@id_mst_loco AND Loco_Date=@Loco_Date", cnn);
            //cmd = new SqlCommand("SELECT * FROM Loco_CompressorOil WHERE id_mst_loco=@id_mst_loco", cnn);
            cmd = new SqlCommand("SELECT table_coolant_water.coolantwater_id " +
      ",table_coolant_water.id_mst_loco " +
      ",jos_railway_mst_loco.locono as Locono" +
      ",REPLACE(CONVERT(VARCHAR(10),table_coolant_water.c_date,105),'-','/') as  Loco_Date" +

            ",table_coolant_water.after_water_chage " +
      ",table_coolant_water.ph " +
      ",table_coolant_water.hardness " +
      ",table_coolant_water.chloride " +
      ",table_coolant_water.nitrate " +
      ",table_coolant_water.remarks " +
      ",table_coolant_water.testedby " +
      "FROM table_coolant_water " +

      "INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = table_coolant_water.id_mst_loco  where table_coolant_water.id_mst_loco='" + locono + "'", cnn);
            //    cmd.Parameters.AddWithValue("@id_mst_loco", this.id_mst_loco);
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
            cmd = new SqlCommand("SELECT * FROM table_coolant_water WHERE id_mst_loco=@id_mst_loco", cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        catch { throw; }
    }

}

