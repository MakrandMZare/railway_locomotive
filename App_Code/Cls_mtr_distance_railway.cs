using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using Railway;
/// <summary>
/// Summary description for Cls_mtr_distance_railway
/// </summary>
public class Cls_mtr_distance_railway : Cls_DBConnection
{
    //mst_distance_rly_station  table name
    public Cls_mtr_distance_railway()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public string id_station;
    public string station_one;
    public string station_two;
    public string km;


    public Int64 Insert_data()
    {
    try
    {
        cmd = new SqlCommand("INSERT INTO mst_distance_rly_station (station_one, station_two, km) VALUES (@station_one,@station_two,@km)", cnn);
        cmd.Parameters.AddWithValue("@station_one", this.station_one);
        cmd.Parameters.AddWithValue("@station_two", this.station_two);
        cmd.Parameters.AddWithValue("@km",this.km);
        cmd.Connection.Open();
        Int16 n = Convert.ToInt16(cmd.ExecuteNonQuery());
        cmd.Connection.Close();
        if (n == 1)
        {
            cmd = new SqlCommand("SELECT MAX(id_station) FROM mst_distance_rly_station", cnn);
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

        catch{throw;}
    }
    


    public bool Update_Data()
    {
        try
        {
            cmd = new SqlCommand("UPDATE mst_distance_rly_station SET  station_one =@station_one, station_two =@station_two , km =@km  WHERE id_station=@id_station", cnn);
            cmd.Parameters.AddWithValue("@id_station", this.id_station); 
            cmd.Parameters.AddWithValue("@station_one", this.station_one);
            cmd.Parameters.AddWithValue("@station_two", this.station_two);
            cmd.Parameters.AddWithValue("@km", this.km);

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
            cmd = new SqlCommand("DELETE FROM mst_distance_rly_station WHERE id_station=@id_station", cnn);
            cmd.Parameters.AddWithValue("@id_station", this.id_station);
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
            cmd = new SqlCommand("SELECT * FROM mst_distance_rly_station WHERE  id_station=@id_station", cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        catch { throw; }
    }
   
    public DataTable Select_Data1(string id)
    {
        try
        {
            cmd = new SqlCommand("SELECT * FROM mst_distance_rly_station WHERE id_station="+this.id_station+"  ", cnn);
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
            cmd = new SqlCommand("SELECT * FROM mst_distance_rly_station   ", cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        catch { throw; }
    }

    
}