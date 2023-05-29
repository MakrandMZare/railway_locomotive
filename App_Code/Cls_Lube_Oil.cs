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
/// Summary description for Cls_Lube_Oil
/// </summary>
public class Cls_Lube_Oil : Cls_DBConnection
{
    public Cls_Lube_Oil()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public string lube_oil_id;
    public string id_mst_loco;
    public string l_date;
    public string schedule;
    public string water;
    public string flashpoint;
    public string viscosity;
    public string ph;
    public string tbne;
    public string hi;
    public string ti;
    public string resin;
    public string oil_date_change;
    public string remarks;


    public Int64 Insert_Data()
    {
        try
        {
            cmd = new SqlCommand("INSERT INTO table_lube_oil (id_mst_loco, l_date, schedule, water, flashpoint, viscosity, ph, tbne, hi, ti, resin, oil_date_change, remarks) VALUES  (@id_mst_loco,@l_date,@schedule,@water,@flashpoint,@viscosity,@ph,@tbne,@hi,@ti,@resin,@oil_date_change,@remarks)", cnn);

            // cmd.Parameters.AddWithValue("@lube_oil_id",this.lube_oil_id);
            cmd.Parameters.AddWithValue("@id_mst_loco", this.id_mst_loco);
            cmd.Parameters.AddWithValue("@l_date", this.l_date);
            cmd.Parameters.AddWithValue("@schedule", this.schedule);
            cmd.Parameters.AddWithValue("@water", this.water);
            cmd.Parameters.AddWithValue("@flashpoint", this.flashpoint);
            cmd.Parameters.AddWithValue("@viscosity", this.viscosity);
            cmd.Parameters.AddWithValue("@ph", this.ph);
            cmd.Parameters.AddWithValue("@tbne", this.tbne);
            cmd.Parameters.AddWithValue("@hi", this.hi);
            cmd.Parameters.AddWithValue("@ti", this.ti);
            cmd.Parameters.AddWithValue("@resin", this.resin);
            cmd.Parameters.AddWithValue("@oil_date_change", this.oil_date_change);
            cmd.Parameters.AddWithValue("@remarks", this.remarks);

            cmd.Connection.Open();
            Int16 n = Convert.ToInt16(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            if (n == 1)
            {
                cmd = new SqlCommand("SELECT MAX(lube_oil_id) FROM  table_lube_oil", cnn);
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
            cmd = new SqlCommand("UPDATE    table_lube_oil SET  id_mst_loco =@id_mst_loco, l_date =@l_date , schedule =@schedule , water =@water , flashpoint =@flashpoint , viscosity =@viscosity , ph =@ph , tbne =@tbne , hi =@hi , ti =@ti , resin =@resin , oil_date_change =@oil_date_change , remarks =@remarks   WHERE lube_oil_id=@lube_oil_id", cnn);
            cmd.Parameters.AddWithValue("@lube_oil_id", this.lube_oil_id);
            cmd.Parameters.AddWithValue("@id_mst_loco", this.id_mst_loco);
            cmd.Parameters.AddWithValue("@l_date", this.l_date);
            cmd.Parameters.AddWithValue("@schedule", this.schedule);
            cmd.Parameters.AddWithValue("@water", this.water);
            cmd.Parameters.AddWithValue("@flashpoint", this.flashpoint);
            cmd.Parameters.AddWithValue("@viscosity", this.viscosity);
            cmd.Parameters.AddWithValue("@ph", this.ph);
            cmd.Parameters.AddWithValue("@tbne", this.tbne);
            cmd.Parameters.AddWithValue("@hi", this.hi);
            cmd.Parameters.AddWithValue("@ti", this.ti);
            cmd.Parameters.AddWithValue("@resin", this.resin);
            cmd.Parameters.AddWithValue("@oil_date_change", this.oil_date_change);
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
            cmd = new SqlCommand("DELETE FROM table_lube_oil WHERE lube_oil_id=@lube_oil_id", cnn);
            cmd.Parameters.AddWithValue("@lube_oil_id", this.lube_oil_id);
            cmd.Connection.Open();
            Int16 n = Convert.ToInt16(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            return n == 1 ? true : false;
        }
        catch { throw; }
    }
    //public DataTable Select_DataByLoco_n_Date()
    //{
    //    try
    //    {
    //        //cmd = new SqlCommand("SELECT * FROM Loco_CompressorOil WHERE Id_Loco=@Id_Loco AND Loco_Date=@Loco_Date", cnn);
    //        //cmd = new SqlCommand("SELECT * FROM Loco_CompressorOil WHERE Id_Loco=@Id_Loco", cnn);
    //        cmd = new SqlCommand("SELECT table_lube_oil.lube_oil_id" +
    //  ",table_lube_oil.id_mst_loco " +
    //  ",jos_railway_mst_loco.locono as Locono" +
    //  ",REPLACE(CONVERT(VARCHAR(10),table_lube_oil.l_date,105),'-','/') as  Loco_Date" +
    //  ",table_lube_oil.schedule as Id_Schedule1 " +
    //  ",jos_railway_loco_type_schedule.s_type as Id_Schedule " +
    //  ",table_lube_oil.water " +
    //  ",table_lube_oil.flashpoint " +
    //  ",table_lube_oil.viscosity" +
    //  ",table_lube_oil.ph " +
    //  ",table_lube_oil.tbne" +
    //  ",table_lube_oil.hi" +
    //  ",table_lube_oil.ti" +
    //  ",table_lube_oil.resin" +
    //  ",table_lube_oil.oil_date_change" +
    //  ",table_lube_oil.remarks"  +
    //  "INNER JOIN  jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = table_lube_oil.schedule " +
    //  "INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = table_lube_oil.id_mst_loco WHERE id_mst_loco=@id_mst_loco", cnn);
    //        cmd.Parameters.AddWithValue("@id_mst_loco", this.id_mst_loco);
    //        da = new SqlDataAdapter();
    //        da.SelectCommand = cmd;
    //        dt = new DataTable();
    //        da.Fill(dt);
    //        return dt;
    //    }
    //    catch { throw; }
    //}


    public DataTable Select_DataByLoco_n_Date()
    {
        try
        {
            //cmd = new SqlCommand("SELECT * FROM Loco_CompressorOil WHERE Id_Loco=@Id_Loco AND Loco_Date=@Loco_Date", cnn);
            //cmd = new SqlCommand("SELECT * FROM Loco_CompressorOil WHERE Id_Loco=@Id_Loco", cnn);
            // cmd = new SqlCommand("SELECT table_lube_oil.lube_oil_id,table_lube_oil.id_mst_loco ,jos_railway_mst_loco.locono as Locono,REPLACE(CONVERT(VARCHAR(10),table_lube_oil.l_date,105),'-','/') as  Loco_Date,table_lube_oil.schedule as Id_Schedule1,jos_railway_loco_type_schedule.s_type as Id_Schedule,table_lube_oil.water,table_lube_oil.flashpoint,table_lube_oil.viscosity,table_lube_oil.ph,table_lube_oil.tbne,table_lube_oil.hi,table_lube_oil.ti,table_lube_oil.resin,table_lube_oil.oil_date_change,table_lube_oil.remarks INNER JOIN  jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = table_lube_oil.schedule INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = table_lube_oil.id_mst_loco WHERE id_mst_loco=@id_mst_loco", cnn);
            cmd = new SqlCommand("SELECT table_lube_oil.lube_oil_id " +
      ",table_lube_oil.id_mst_loco " +
      ",jos_railway_mst_loco.locono as Locono" +
      ",REPLACE(CONVERT(VARCHAR(10),table_lube_oil.l_date,105),'-','/') as  Loco_Date" +
      ",table_lube_oil.schedule as schedule " +
      ",jos_railway_loco_type_schedule.s_type as Id_Schedule " +
      ",table_lube_oil.water " +
      ",table_lube_oil.flashpoint " +
      ",table_lube_oil.viscosity " +
      ",table_lube_oil.hi " +
      ",table_lube_oil.ti " +
      ",table_lube_oil.resin " +
         ",table_lube_oil.oil_date_change " +
      ",table_lube_oil.remarks " +
      ",table_lube_oil.ph " +
      ",table_lube_oil.tbne " +
      "FROM table_lube_oil " +
      "INNER JOIN  jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = table_lube_oil.schedule " +
      "INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = table_lube_oil.id_mst_loco WHERE table_lube_oil.id_mst_loco=@id_mst_loco", cnn);


            cmd.Parameters.AddWithValue("@id_mst_loco", this.id_mst_loco);
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
            cmd = new SqlCommand("SELECT * FROM table_lube_oil WHERE  id_mst_loco=@id_mst_loco", cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        catch { throw; }
    }
    public DataTable Select_Databyloco(string locono)
    {

        //cmd = new SqlCommand("select * from table_compo_during_failure  ", cnn);
        cmd = new SqlCommand("SELECT     table_lube_oil.lube_oil_id, table_lube_oil.id_mst_loco, CONVERT(VARCHAR(10),table_lube_oil.l_date,105)as l_date, table_lube_oil.schedule as Id_Schedule, table_lube_oil.water as water, table_lube_oil.flashpoint as flashpoint,  table_lube_oil.viscosity as viscosity, table_lube_oil.ph as ph, table_lube_oil.tbne as tbne, table_lube_oil.hi as hi, table_lube_oil.ti, table_lube_oil.resin,         table_lube_oil.oil_date_change as oil_date_change, table_lube_oil.remarks as remarks, jos_railway_loco_type_schedule.id_loco_sch, jos_railway_loco_type_schedule.loco_id, jos_railway_mst_loco.id_mst_loco AS Expr1, jos_railway_mst_loco.locono, jos_railway_loco_type_schedule.s_type FROM         table_lube_oil INNER JOIN jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch=table_lube_oil.schedule INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco=table_lube_oil.id_mst_loco where table_lube_oil.id_mst_loco='" + locono + "' ", cnn);
        //cmd.Parameters.AddWithValue("@comp_id", this.comp_id);
        dt = new DataTable();
        da = new SqlDataAdapter();
        da.SelectCommand = cmd;
        dt.Clear();
        da.Fill(dt);
        return dt;
    }
    public DataTable Select_Data()
    {
        try
        {
            cmd = new SqlCommand("SELECT * FROM table_lube_oil ", cnn);
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

        //cmd = new SqlCommand("select * from table_compo_during_failure  ", cnn);
        cmd = new SqlCommand("SELECT     table_lube_oil.lube_oil_id, table_lube_oil.id_mst_loco, CONVERT(VARCHAR(10),table_lube_oil.l_date,105)as l_date, table_lube_oil.schedule as Id_Schedule, table_lube_oil.water as water, table_lube_oil.flashpoint as flashpoint,  table_lube_oil.viscosity as viscosity, table_lube_oil.ph as ph, table_lube_oil.tbne as tbne, table_lube_oil.hi as hi, table_lube_oil.ti, table_lube_oil.resin,         table_lube_oil.oil_date_change as oil_date_change, table_lube_oil.remarks as remarks, jos_railway_loco_type_schedule.id_loco_sch, jos_railway_loco_type_schedule.loco_id, jos_railway_mst_loco.id_mst_loco AS Expr1, jos_railway_mst_loco.locono, jos_railway_loco_type_schedule.s_type FROM         table_lube_oil INNER JOIN jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch=table_lube_oil.schedule INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco=table_lube_oil.id_mst_loco", cnn);
        //cmd.Parameters.AddWithValue("@comp_id", this.comp_id);
        dt = new DataTable();
        da = new SqlDataAdapter();
        da.SelectCommand = cmd;
        dt.Clear();
        da.Fill(dt);
        return dt;
    }

    public DataTable Select_Data1()
    {
     
        try
        {
            //cmd = new SqlCommand("SELECT * FROM Loco_CompressorOil WHERE Id_Loco=@Id_Loco AND Loco_Date=@Loco_Date", cnn);
            //cmd = new SqlCommand("SELECT * FROM Loco_CompressorOil WHERE Id_Loco=@Id_Loco", cnn);
            // cmd = new SqlCommand("SELECT table_lube_oil.lube_oil_id,table_lube_oil.id_mst_loco ,jos_railway_mst_loco.locono as Locono,REPLACE(CONVERT(VARCHAR(10),table_lube_oil.l_date,105),'-','/') as  Loco_Date,table_lube_oil.schedule as Id_Schedule1,jos_railway_loco_type_schedule.s_type as Id_Schedule,table_lube_oil.water,table_lube_oil.flashpoint,table_lube_oil.viscosity,table_lube_oil.ph,table_lube_oil.tbne,table_lube_oil.hi,table_lube_oil.ti,table_lube_oil.resin,table_lube_oil.oil_date_change,table_lube_oil.remarks INNER JOIN  jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = table_lube_oil.schedule INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = table_lube_oil.id_mst_loco WHERE id_mst_loco=@id_mst_loco", cnn);
            cmd = new SqlCommand("SELECT table_lube_oil.lube_oil_id " +
      ",table_lube_oil.id_mst_loco " +
      ",jos_railway_mst_loco.locono as Locono" +
      ",REPLACE(CONVERT(VARCHAR(10),table_lube_oil.l_date,105),'-','/') as  Loco_Date" +
      ",table_lube_oil.schedule as schedule " +
      ",jos_railway_loco_type_schedule.s_type as Id_Schedule " +
      ",table_lube_oil.water " +
      ",table_lube_oil.flashpoint " +
      ",table_lube_oil.viscosity " +
      ",table_lube_oil.hi " +
      ",table_lube_oil.ti " +
      ",table_lube_oil.resin " +
         ",table_lube_oil.oil_date_change " +
      ",table_lube_oil.remarks " +
      ",table_lube_oil.ph " +
      ",table_lube_oil.tbne " +
      "FROM table_lube_oil " +
      "INNER JOIN  jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = table_lube_oil.schedule " +
      "INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = table_lube_oil.id_mst_loco ", cnn);


         //   cmd.Parameters.AddWithValue("@id_mst_loco", this.id_mst_loco);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        catch { throw; }
    }
}
