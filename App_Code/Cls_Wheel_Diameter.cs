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
/// Summary description for Cls_Wheel_Diameter
/// </summary>
public class Cls_Wheel_Diameter : Cls_DBConnection
{
    public Cls_Wheel_Diameter()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public string id_wheel_diameter;
    public string id_mst_loco;
    public string doc;
    public string id_schedule;
    public string w_date;
    public string dia;
    public string r1;
    public string p1;
    public string h1;
    public string r2;
    public string p2;
    public string h2;
    public string r3;
    public string p3;
    public string h3;
    public string r4;
    public string p4;
    public string h4;
    public string r5;
    public string p5;
    public string h5;
    public string r6;
    public string p6;
    public string h6;
    public string r7;
    public string p7;
    public string h7;
    public string r8;
    public string p8;
    public string h8;
    public string r9;
    public string p9;
    public string h9;
    public string r10;
    public string p10;
    public string h10;
    public string r11;
    public string p11;
    public string h11;
    public string r12;
    public string p12;
    public string h12;

    //  public Int64 Insert_Data()
    //  {
    //      try
    //      {
    //          cmd = new SqlCommand("INSERT INTO table_hsd_oil  (id_mst_loco, h_date, sch, sample_collect, water_conts, sediments, color, remarks, testedby) VALUES (@id_mst_loco, @h_date, @sch, @sample_collect, @water_conts, @sediments, @color, @remarks, @testedby)", cnn);
    //          cmd.Parameters.AddWithValue("@id_mst_loco", this.id_mst_loco);
    //          cmd.Parameters.AddWithValue("@h_date", this.h_date);
    //          cmd.Parameters.AddWithValue("@sch", this.sch);
    //          cmd.Parameters.AddWithValue("@sample_collect", this.sample_collect);
    //          cmd.Parameters.AddWithValue("@water_conts", this.water_conts);
    //          cmd.Parameters.AddWithValue("@sediments", this.sediments);
    //          cmd.Parameters.AddWithValue("@color", this.color);
    //          cmd.Parameters.AddWithValue("@remarks", this.remarks);
    //          cmd.Parameters.AddWithValue("@testedby", this.testedby);
    //          cmd.Connection.Open();
    //          Int16 n = Convert.ToInt16(cmd.ExecuteNonQuery());
    //          cmd.Connection.Close();
    //          if (n == 1)
    //          {
    //              cmd = new SqlCommand("SELECT MAX(hsd_id) FROM  table_hsd_oil", cnn);
    //              cmd.Connection.Open();
    //              Int64 m = Convert.ToInt64(cmd.ExecuteScalar());
    //              cmd.Connection.Close();
    //              return m;
    //          }
    //          else
    //          {
    //              return 0;
    //          }
    //      }
    //      catch { throw; }
    //  }

    public Int64 Insert_Data()
    {
        try
        {
            cmd = new SqlCommand("INSERT INTO bg_wheel_diameter (id_mst_loco, doc, id_schedule, w_date, dia, r1, p1, h1, r2, p2, h2, r3, p3, h3, r4, p4, h4, r5, p5, h5, r6, p6, h6, r7, p7, h7, r8, p8, h8, r9, p9, h9, r10, p10, h10, r11, p11, h11, r12, p12, h12) VALUES  (@id_mst_loco, @doc, @id_schedule, @w_date, @dia, @r1, @p1, @h1, @r2, @p2, @h2, @r3, @p3, @h3, @r4, @p4, @h4, @r5, @p5, @h5, @r6, @p6, @h6, @r7, @p7, @h7, @r8, @p8, @h8, @r9, @p9, @h9, @r10, @p10, @h10, @r11, @p11, @h11, @r12, @p12, @h12)", cnn);
           // cmd.Parameters.AddWithValue("@id_wheel_diameter", this.id_wheel_diameter);

            cmd.Parameters.AddWithValue("@id_mst_loco", this.id_mst_loco);
            cmd.Parameters.AddWithValue("@doc", this.doc);
            cmd.Parameters.AddWithValue("@id_schedule", this.id_schedule);
            cmd.Parameters.AddWithValue("@w_date", this.w_date);
            cmd.Parameters.AddWithValue("@dia", this.dia);

            cmd.Parameters.AddWithValue("@r1", this.r1);
            cmd.Parameters.AddWithValue("@p1", this.p1);
            cmd.Parameters.AddWithValue("@h1", this.h1);
            cmd.Parameters.AddWithValue("@r2", this.r2);
            cmd.Parameters.AddWithValue("@p2", this.p2);
            cmd.Parameters.AddWithValue("@h2", this.h2);
            cmd.Parameters.AddWithValue("@r3", this.r3);
            cmd.Parameters.AddWithValue("@p3", this.p3);
            cmd.Parameters.AddWithValue("@h3", this.h3);
            cmd.Parameters.AddWithValue("@r4", this.r4);
            cmd.Parameters.AddWithValue("@p4", this.p4);
            cmd.Parameters.AddWithValue("@h4", this.h4);
            cmd.Parameters.AddWithValue("@r5", this.r5);
            cmd.Parameters.AddWithValue("@p5", this.p5);
            cmd.Parameters.AddWithValue("@h5", this.h5);
            cmd.Parameters.AddWithValue("@r6", this.r6);
            cmd.Parameters.AddWithValue("@p6", this.p6);
            cmd.Parameters.AddWithValue("@h6", this.h6);
            cmd.Parameters.AddWithValue("@r7", this.r7);
            cmd.Parameters.AddWithValue("@p7", this.p7);
            cmd.Parameters.AddWithValue("@h7", this.h7);
            cmd.Parameters.AddWithValue("@r8", this.r8);
            cmd.Parameters.AddWithValue("@p8", this.p8);
            cmd.Parameters.AddWithValue("@h8", this.h8);
            cmd.Parameters.AddWithValue("@r9", this.r9);
            cmd.Parameters.AddWithValue("@p9", this.p9);
            cmd.Parameters.AddWithValue("@h9", this.h9);
            cmd.Parameters.AddWithValue("@r10", this.r10);
            cmd.Parameters.AddWithValue("@p10", this.p10);
            cmd.Parameters.AddWithValue("@h10", this.h10);
            cmd.Parameters.AddWithValue("@r11", this.r11);
            cmd.Parameters.AddWithValue("@p11", this.p11);
            cmd.Parameters.AddWithValue("@h11", this.h11);
            cmd.Parameters.AddWithValue("@r12", this.r12);
            cmd.Parameters.AddWithValue("@p12", this.p12);
            cmd.Parameters.AddWithValue("@h12", this.h12);
            cmd.Connection.Open();
            Int16 n = Convert.ToInt16(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            if (n == 1)
            {
                cmd = new SqlCommand("SELECT MAX(id_wheel_diameter)FROM bg_wheel_diameter", cnn);
                cmd.Connection.Open();
                Int64 m = Convert.ToInt16(cmd.ExecuteScalar());
                cmd.Connection.Close();
                return m;
            }
            else
            {
                return 0;
            }
        }
        catch
        {
            throw;
        }

    }



    //  public bool Update_Data()
    //  {
    //      try
    //      {
    //          cmd = new SqlCommand("UPDATE    table_hsd_oil  SET id_mst_loco =@id_mst_loco, h_date =@h_date, sch =@sch , sample_collect =@sample_collect , water_conts =@water_conts, sediments =@sediments , color =@color , remarks =@remarks , testedby =@testedby  WHERE hsd_id=@hsd_id", cnn);
    //          cmd.Parameters.AddWithValue("@hsd_id", this.hsd_id);
    //          cmd.Parameters.AddWithValue("@id_mst_loco", this.id_mst_loco);
    //          cmd.Parameters.AddWithValue("@h_date", this.h_date);
    //          cmd.Parameters.AddWithValue("@sch", this.sch);
    //          cmd.Parameters.AddWithValue("@sample_collect", this.sample_collect);
    //          cmd.Parameters.AddWithValue("@water_conts", this.water_conts);
    //          cmd.Parameters.AddWithValue("@sediments", this.sediments);
    //          cmd.Parameters.AddWithValue("@color", this.color);
    //          cmd.Parameters.AddWithValue("@remarks", this.remarks);
    //          cmd.Parameters.AddWithValue("@testedby", this.testedby);

    //          cmd.Connection.Open();
    //          Int16 n = Convert.ToInt16(cmd.ExecuteNonQuery());
    //          cmd.Connection.Close();
    //          return n == 1 ? true : false;
    //      }
    //      catch { throw; }
    //  }

    


    public bool Update_Data()
    {
        try
        {
            cmd = new SqlCommand("UPDATE    bg_wheel_diameter SET id_mst_loco =, doc =, id_schedule =, w_date =, dia =, r1 =, p1 =, h1 =, r2 =, p2 =, h2 =, r3 =, p3 =, h3 =, r4 =, p4 =, h4 =, r5 =, p5 =, h5 =, r6 =, p6 =, h6 =, r7 =, p7 =, h7 =, r8 =, p8 =, h8 =, r9 =, p9 =, h9 =, r10 =, p10 =, h10 =, r11 =, p11 =, h11 =, r12 =, p12 =, h12 = WHERE id_wheel_diameter=@id_wheel_diameter ", cnn);
            cmd.Parameters.AddWithValue("@id_wheel_diameter", this.id_wheel_diameter);

            cmd.Parameters.AddWithValue("@id_mst_loco", this.id_mst_loco);
            cmd.Parameters.AddWithValue("@doc", this.doc);
            cmd.Parameters.AddWithValue("@id_schedule", this.id_schedule);
            cmd.Parameters.AddWithValue("@w_date", this.w_date);
            cmd.Parameters.AddWithValue("@dia", this.dia);

            cmd.Parameters.AddWithValue("@r1", this.r1);
            cmd.Parameters.AddWithValue("@p1", this.p1);
            cmd.Parameters.AddWithValue("@h1", this.h1);
            cmd.Parameters.AddWithValue("@r2", this.r2);
            cmd.Parameters.AddWithValue("@p2", this.p2);
            cmd.Parameters.AddWithValue("@h2", this.h2);
            cmd.Parameters.AddWithValue("@r3", this.r3);
            cmd.Parameters.AddWithValue("@p3", this.p3);
            cmd.Parameters.AddWithValue("@h3", this.h3);
            cmd.Parameters.AddWithValue("@r4", this.r4);
            cmd.Parameters.AddWithValue("@p4", this.p4);
            cmd.Parameters.AddWithValue("@h4", this.h4);
            cmd.Parameters.AddWithValue("@r5", this.r5);
            cmd.Parameters.AddWithValue("@p5", this.p5);
            cmd.Parameters.AddWithValue("@h5", this.h5);
            cmd.Parameters.AddWithValue("@r6", this.r6);
            cmd.Parameters.AddWithValue("@p6", this.p6);
            cmd.Parameters.AddWithValue("@h6", this.h6);
            cmd.Parameters.AddWithValue("@r7", this.r7);
            cmd.Parameters.AddWithValue("@p7", this.p7);
            cmd.Parameters.AddWithValue("@h7", this.h7);
            cmd.Parameters.AddWithValue("@r8", this.r8);
            cmd.Parameters.AddWithValue("@p8", this.p8);
            cmd.Parameters.AddWithValue("@h8", this.h8);
            cmd.Parameters.AddWithValue("@r9", this.r9);
            cmd.Parameters.AddWithValue("@p9", this.p9);
            cmd.Parameters.AddWithValue("@h9", this.h9);
            cmd.Parameters.AddWithValue("@r10", this.r10);
            cmd.Parameters.AddWithValue("@p10", this.p10);
            cmd.Parameters.AddWithValue("@h10", this.h10);
            cmd.Parameters.AddWithValue("@r11", this.r11);
            cmd.Parameters.AddWithValue("@p11", this.p11);
            cmd.Parameters.AddWithValue("@h11", this.h11);
            cmd.Parameters.AddWithValue("@r12", this.r12);
            cmd.Parameters.AddWithValue("@p12", this.p12);
            cmd.Parameters.AddWithValue("@h12", this.h12);
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
            cmd = new SqlCommand("DELETE FROM bg_wheel_diameter WHERE id_wheel_diameter=@id_wheel_diameter", cnn);
            cmd.Parameters.AddWithValue("@id_wheel_diameter", this.id_wheel_diameter);
            cmd.Connection.Open();
            Int16 n = Convert.ToInt16(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            return n == 1 ? true : false;
        }
        catch { throw; }
    }
    //  public DataTable Select_DataByLoco_n_Date()
    //  {
    //      try
    //      {
    //          //cmd = new SqlCommand("SELECT * FROM Loco_CompressorOil WHERE Id_Loco=@Id_Loco AND Loco_Date=@Loco_Date", cnn);
    //          //cmd = new SqlCommand("SELECT * FROM Loco_CompressorOil WHERE Id_Loco=@Id_Loco", cnn);
    //          cmd = new SqlCommand("SELECT table_hsd_oil.hsd_id " +
    //    ",table_hsd_oil.id_mst_loco " +
    //    ",jos_railway_mst_loco.locono as Locono" +
    //    ",REPLACE(CONVERT(VARCHAR(10),table_hsd_oil.h_date,105),'-','/') as  Loco_Date" +
    //    ",table_hsd_oil.sch as Id_Schedule1 " +
    //    ",jos_railway_loco_type_schedule.s_type as Id_Schedule " +
    //    ",table_hsd_oil.sample_collect " +
    //    ",table_hsd_oil.water_conts " +
    //    ",table_hsd_oil.sediments " +
    //    ",table_hsd_oil.color " +
    //    ",table_hsd_oil.remarks " +


    //    ",table_hsd_oil.testedby " +

    //    "FROM table_hsd_oil " +
    //    "INNER JOIN  jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = table_hsd_oil.sch " +
    //    "INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = table_hsd_oil.id_mst_loco WHERE table_hsd_oil.id_mst_loco=@id_mst_loco", cnn);
    //          cmd.Parameters.AddWithValue("@id_mst_loco", this.id_mst_loco);
    //          da = new SqlDataAdapter();
    //          da.SelectCommand = cmd;
    //          dt = new DataTable();
    //          da.Fill(dt);
    //          return dt;
    //      }
    //      catch { throw; }
    //  }


    public DataTable Select_Data()
    {
        try
        {
            cmd = new SqlCommand("SELECT  jos_railway_loco_type_schedule.id_loco_sch, jos_railway_loco_type_schedule.loco_id, jos_railway_loco_type_schedule.s_type as s_type, jos_railway_loco_type_schedule.duration, bg_wheel_diameter.id_wheel_diameter, bg_wheel_diameter.id_mst_loco,CONVERT(VARCHAR(10),bg_wheel_diameter.doc,105)as doc, bg_wheel_diameter.id_schedule,CONVERT(VARCHAR(10),bg_wheel_diameter.w_date,105) as w_date, bg_wheel_diameter.dia as dia, bg_wheel_diameter.r1 as r1, bg_wheel_diameter.p1 as p1, bg_wheel_diameter.h1 as h1, bg_wheel_diameter.r2 as r2, bg_wheel_diameter.p2 as p2, bg_wheel_diameter.h2 as h2, bg_wheel_diameter.r3 as r3, bg_wheel_diameter.p3 as p3, bg_wheel_diameter.h3 as h3, bg_wheel_diameter.r4 as r4, bg_wheel_diameter.p4 as p4, bg_wheel_diameter.h4 as h4, bg_wheel_diameter.r5 as r5, bg_wheel_diameter.p5 as p5, bg_wheel_diameter.h5 as h5, bg_wheel_diameter.r6 as r6, bg_wheel_diameter.p6 as p6, bg_wheel_diameter.h6 as h6, bg_wheel_diameter.r7 as r7, bg_wheel_diameter.p7 as p7, bg_wheel_diameter.h7 as h7, bg_wheel_diameter.r8 as r8, bg_wheel_diameter.p8 as p8, bg_wheel_diameter.h8 as h8, bg_wheel_diameter.r9 as r9, bg_wheel_diameter.p9 as p9, bg_wheel_diameter.h9 as h9, bg_wheel_diameter.r10 as r10, bg_wheel_diameter.p10 as p10, bg_wheel_diameter.h10 as h10, bg_wheel_diameter.r11 as r11, bg_wheel_diameter.p11 as p11, bg_wheel_diameter.h11 as h11, bg_wheel_diameter.r12 as r12, bg_wheel_diameter.p12 as p12, bg_wheel_diameter.h12 as h12, jos_railway_mst_loco.id_mst_loco AS Expr1, jos_railway_mst_loco.locono as locono FROM         bg_wheel_diameter INNER JOIN  jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch =  bg_wheel_diameter.id_schedule INNER JOIN   jos_railway_mst_loco ON  jos_railway_mst_loco.id_mst_loco=bg_wheel_diameter.id_mst_loco", cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        catch { throw; }
    }
    //  //-------------------------------------------
    //   public DataTable Select_Data_All()
    //  {


    //      cmd = new SqlCommand("SELECT table_hsd_oil.hsd_id " +
    //    ",table_hsd_oil.id_mst_loco " +
    //    ",jos_railway_mst_loco.locono as Locono" +
    //    ",REPLACE(CONVERT(VARCHAR(10),table_hsd_oil.h_date,105),'-','/') as  Loco_Date" +
    //    ",table_hsd_oil.sch as Id_Schedule1 " +
    //    ",jos_railway_loco_type_schedule.s_type as Id_Schedule " +
    //    ",table_hsd_oil.sample_collect " +
    //    ",table_hsd_oil.water_conts " +
    //    ",table_hsd_oil.sediments " +
    //    ",table_hsd_oil.color " +
    //    ",table_hsd_oil.remarks " +


    //    ",table_hsd_oil.testedby " +

    //    "FROM table_hsd_oil " +
    //    "INNER JOIN  jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = table_hsd_oil.sch " +
    //    "INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = table_hsd_oil.id_mst_loco ", cnn);

    //      dt = new DataTable();
    //      da = new SqlDataAdapter();
    //      da.SelectCommand = cmd;
    //      dt.Clear();
    //      da.Fill(dt);
    //      return dt;
    //  }






    //public DataTable Select_DataByLOCO( string locono)
    //  {


    //      cmd = new SqlCommand(" SELECT table_hsd_oil.hsd_id " +
    //    ",table_hsd_oil.id_mst_loco " +
    //    ",jos_railway_mst_loco.locono as Locono" +
    //    ",REPLACE(CONVERT(VARCHAR(10),table_hsd_oil.h_date,105),'-','/') as  Loco_Date" +
    //    ",table_hsd_oil.sch as Id_Schedule1 " +
    //    ",jos_railway_loco_type_schedule.s_type as Id_Schedule " +
    //    ",table_hsd_oil.sample_collect " +
    //    ",table_hsd_oil.water_conts " +
    //    ",table_hsd_oil.sediments " +
    //    ",table_hsd_oil.color " +
    //    ",table_hsd_oil.remarks " +


    //    ",table_hsd_oil.testedby " +

    //    "FROM table_hsd_oil " +
    //    "INNER JOIN  jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = table_hsd_oil.sch " +
    //    "INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = table_hsd_oil.id_mst_loco where table_hsd_oil.id_mst_loco='"+locono+"' ", cnn);

    //      dt = new DataTable();
    //      da = new SqlDataAdapter();
    //      da.SelectCommand = cmd;
    //      dt.Clear();
    //      da.Fill(dt);
    //      return dt;
    //  }

    //  //---------------------------------------------
    //  public DataTable Select_DataById()
    //  {
    //      try
    //      {
    //          cmd = new SqlCommand("SELECT * FROM table_hsd_oil WHERE id_mst_loco=@id_mst_loco", cnn);
    //          da = new SqlDataAdapter();
    //          da.SelectCommand = cmd;
    //          da.Fill(dt);
    //          return dt;
    //      }
    //      catch { throw; }
    //  }

}
