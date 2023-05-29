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
/// Summary description for Cls_spectro_analysis
/// </summary>
public class Cls_spectro_analysis : Cls_DBConnection
{
    public string spectro_id;
    public string id_mst_loco;
    public string date_of_collection;
    public string dateof;
    public string schedule;
    public string A1;
    public string B;
    public string Cr;
    public string Cu;
    public string Fe;
    public string Na;
    public string Pb;
    public string Si;
    public string Sn;
    public string remarks;

    public Cls_spectro_analysis()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public Int64 Insert_Data()
    {
        try
        {
            cmd = new SqlCommand("INSERT INTO table_spectro_analysis  (id_mst_loco, date_of_collection, dateof, schedule, A1, B, Cr, Cu, Fe, Na, Pb, Si, Sn, remarks) VALUES (@id_mst_loco, @date_of_collection, @dateof, @schedule, @A1, @B, @Cr, @Cu, @Fe, @Na, @Pb, @Si, @Sn, @remarks)", cnn);
            cmd.Parameters.AddWithValue("@id_mst_loco", this.id_mst_loco);
            cmd.Parameters.AddWithValue("@date_of_collection", this.date_of_collection);
            cmd.Parameters.AddWithValue("@dateof", this.dateof);
            cmd.Parameters.AddWithValue("@schedule", this.schedule);
            cmd.Parameters.AddWithValue("@A1", this.A1);
            cmd.Parameters.AddWithValue("@B", this.B);
            cmd.Parameters.AddWithValue("@Cr", this.Cr);
            cmd.Parameters.AddWithValue("@Cu", this.Cu);

            cmd.Parameters.AddWithValue("@Fe", this.Fe);
            cmd.Parameters.AddWithValue("@Na", this.Na);
            cmd.Parameters.AddWithValue("@Pb", this.Pb);


            cmd.Parameters.AddWithValue("@Si", this.Si);
            cmd.Parameters.AddWithValue("@Sn", this.Sn);
            cmd.Parameters.AddWithValue("@remarks", this.remarks);
            cmd.Connection.Open();
            Int16 n = Convert.ToInt16(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            if (n == 1)
            {
                cmd = new SqlCommand("SELECT MAX(spectro_id) FROM  table_spectro_analysis", cnn);
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
            cmd = new SqlCommand("UPDATE    table_spectro_analysis SET id_mst_loco =@id_mst_loco, date_of_collection =@date_of_collection , dateof =@dateof , schedule =@schedule , A1 =@A1 , B =@B, Cr =@Cr, Cu =@Cu , Fe =@Fe , Na =@Na , Pb =@Pb , Si =@Si , Sn =@Sn , remarks =@remarks WHERE spectro_id=@spectro_id", cnn);
            cmd.Parameters.AddWithValue("@spectro_id", this.spectro_id);
            cmd.Parameters.AddWithValue("@id_mst_loco", this.id_mst_loco);
            cmd.Parameters.AddWithValue("@date_of_collection", this.date_of_collection);
            cmd.Parameters.AddWithValue("@dateof", this.dateof);
            cmd.Parameters.AddWithValue("@schedule", this.schedule);
            cmd.Parameters.AddWithValue("@A1", this.A1);
            cmd.Parameters.AddWithValue("@B", this.B);
            cmd.Parameters.AddWithValue("@Cr", this.Cr);
            cmd.Parameters.AddWithValue("@Cu", this.Cu);

            cmd.Parameters.AddWithValue("@Fe", this.Fe);
            cmd.Parameters.AddWithValue("@Na", this.Na);
            cmd.Parameters.AddWithValue("@Pb", this.Pb);


            cmd.Parameters.AddWithValue("@Si", this.Si);
            cmd.Parameters.AddWithValue("@Sn", this.Sn);
            cmd.Parameters.AddWithValue("@remarks", this.remarks);
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
            cmd = new SqlCommand("DELETE FROM table_spectro_analysis WHERE spectro_id=@spectro_id", cnn);
            cmd.Parameters.AddWithValue("@spectro_id", this.spectro_id);
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
            cmd = new SqlCommand("SELECT table_spectro_analysis.spectro_id " +
      ",table_spectro_analysis.id_mst_loco " +
      ",jos_railway_mst_loco.locono as Locono" +
      ",REPLACE(CONVERT(VARCHAR(10),table_spectro_analysis.date_of_collection,105),'-','/') as  date_of_collection" +
      ",REPLACE(CONVERT(VARCHAR(10),table_spectro_analysis.dateof,105),'-','/') as  Loco_Date" +
      ",table_spectro_analysis.schedule as Id_Schedule1 " +
      ",jos_railway_loco_type_schedule.s_type as Id_Schedule " +
      ",table_spectro_analysis.A1 " +
      ",table_spectro_analysis.B " +
      ",table_spectro_analysis.Cr " +
      ",table_spectro_analysis.Cu " +
      ",table_spectro_analysis.Fe " +
      ",table_spectro_analysis.Na" +
      ",table_spectro_analysis.Pb " +
      ",table_spectro_analysis.Si " +
      ",table_spectro_analysis.Sn " +
      ",table_spectro_analysis.remarks " +

      "FROM table_spectro_analysis " +
      "INNER JOIN  jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = table_spectro_analysis.schedule " +
      "INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = table_spectro_analysis.id_mst_loco WHERE table_spectro_analysis.id_mst_loco=@id_mst_loco", cnn);
            cmd.Parameters.AddWithValue("@id_mst_loco", this.id_mst_loco);
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


        cmd = new SqlCommand("SELECT table_spectro_analysis.spectro_id " +
      ",table_spectro_analysis.id_mst_loco " +
      ",jos_railway_mst_loco.locono as Locono" +
      ",REPLACE(CONVERT(VARCHAR(10),table_spectro_analysis.date_of_collection,105),'-','/') as  date_of_collection" +
      ",REPLACE(CONVERT(VARCHAR(10),table_spectro_analysis.dateof,105),'-','/') as  Loco_Date" +
      ",table_spectro_analysis.schedule as Id_Schedule1 " +
      ",jos_railway_loco_type_schedule.s_type as Id_Schedule " +
      ",table_spectro_analysis.A1 " +
      ",table_spectro_analysis.B " +
      ",table_spectro_analysis.Cr " +
      ",table_spectro_analysis.Cu " +
      ",table_spectro_analysis.Fe " +
      ",table_spectro_analysis.Na" +
      ",table_spectro_analysis.Pb " +
      ",table_spectro_analysis.Si " +
      ",table_spectro_analysis.Sn " +
      ",table_spectro_analysis.remarks " +

      "FROM table_spectro_analysis " +
      "INNER JOIN  jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = table_spectro_analysis.schedule " +
      "INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = table_spectro_analysis.id_mst_loco ", cnn);
       
        dt = new DataTable();
        da = new SqlDataAdapter();
        da.SelectCommand = cmd;
        dt.Clear();
        da.Fill(dt);
        return dt;
    }






  public DataTable Select_DataByLOCO( string locono)
    {


        cmd = new SqlCommand("SELECT table_spectro_analysis.spectro_id " +
      ",table_spectro_analysis.id_mst_loco " +
      ",jos_railway_mst_loco.locono as Locono" +
      ",REPLACE(CONVERT(VARCHAR(10),table_spectro_analysis.date_of_collection,105),'-','/') as  date_of_collection" +
      ",REPLACE(CONVERT(VARCHAR(10),table_spectro_analysis.dateof,105),'-','/') as  Loco_Date" +
      ",table_spectro_analysis.schedule as Id_Schedule1 " +
      ",jos_railway_loco_type_schedule.s_type as Id_Schedule " +
      ",table_spectro_analysis.A1 " +
      ",table_spectro_analysis.B " +
      ",table_spectro_analysis.Cr " +
      ",table_spectro_analysis.Cu " +
      ",table_spectro_analysis.Fe " +
      ",table_spectro_analysis.Na" +
      ",table_spectro_analysis.Pb " +
      ",table_spectro_analysis.Si " +
      ",table_spectro_analysis.Sn " +
      ",table_spectro_analysis.remarks " +

      "FROM table_spectro_analysis " +
      "INNER JOIN  jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = table_spectro_analysis.schedule " +
      "INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = table_spectro_analysis.id_mst_loco where table_spectro_analysis.id_mst_loco='" + locono + "' ", cnn);
       
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
            cmd = new SqlCommand("SELECT * FROM table_spectro_analysis WHERE id_mst_loco=@id_mst_loco", cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        catch { throw; }
    }

}


