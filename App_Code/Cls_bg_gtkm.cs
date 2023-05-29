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
/// Summary description for Cls_bg_gtkm
/// </summary>
public class Cls_bg_gtkm : Cls_DBConnection
{
    public Cls_bg_gtkm()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public string id_station;
    //---------------------------
    public string id_bg_gtkm;
    public string id_mst_loco;
    public string gtkm_date;
    public string from1;
    public string to1;
    public string ekm;
    public string FuelOilCons;
    public string lubeoil;
    public string TrainLoad;
    public string sfc;
    public string lfr;
    public string loc;
    public string gtkm;

    public DataTable SelectLocoType()
    {
        cmd = new SqlCommand("SELECT Distinct jos_railway_loco_type.id_ltype,jos_railway_loco_type.loco_type from jos_railway_loco_type INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.tid = jos_railway_loco_type.id_ltype", cnn);

        da = new SqlDataAdapter();
        dt = new DataTable();
        da.SelectCommand = cmd;
        da.Fill(dt);
        return dt;

    }
    public DataTable Select_Station()
    {
        cmd = new SqlCommand("SELECT * FROM mst_distance_rly_station", cnn);
        da = new SqlDataAdapter();
        dt = new DataTable();
        da.SelectCommand = cmd;
        da.Fill(dt);
        return dt;
    }

    public Int64 Insert_Data()
    {
        try
        {
            cmd = new SqlCommand("INSERT INTO bg_gtkm (id_mst_loco, gtkm_date, from1, to1, ekm, FuelOilCons, lubeoil, TrainLoad, sfc, lfr, loc, gtkm) VALUES (@id_mst_loco, @gtkm_date, @from1, @to1, @ekm, @FuelOilCons, @lubeoil, @TrainLoad, @sfc, @lfr, @loc, @gtkm)", cnn);
            cmd.Parameters.AddWithValue("@id_mst_loco", this.id_mst_loco);
            cmd.Parameters.AddWithValue("@gtkm_date", this.gtkm_date);
            cmd.Parameters.AddWithValue("@from1", this.from1);
            cmd.Parameters.AddWithValue("@to1", this.to1);
            cmd.Parameters.AddWithValue("@ekm", this.ekm);
            cmd.Parameters.AddWithValue("@FuelOilCons", this.FuelOilCons);
            cmd.Parameters.AddWithValue("@lubeoil", this.lubeoil);
            cmd.Parameters.AddWithValue("@TrainLoad", this.TrainLoad);

            cmd.Parameters.AddWithValue("@sfc", this.sfc);
            cmd.Parameters.AddWithValue("@lfr", this.lfr);
            cmd.Parameters.AddWithValue("@loc", this.loc);
            cmd.Parameters.AddWithValue("@gtkm", this.gtkm);
            cmd.Connection.Open();
            Int16 n = Convert.ToInt16(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            if (n == 1)
            {
                cmd = new SqlCommand("SELECT MAX(id_bg_gtkm) FROM  bg_gtkm", cnn);
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

    public DataTable Select_Data1(string id_station)
    {
        try
        {
            cmd = new SqlCommand("SELECT * FROM mst_distance_rly_station WHERE id_station='" + id_station + " '", cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        catch { throw; }
    }

}
