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
using System.Data;
using Railway;

/// <summary>
/// Summary description for Cls_failure_component
/// </summary>
public class Cls_failure_component : Cls_DBConnection
{
    public Cls_failure_component()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public string comp_id;
    public string l_date;
    public string comp_name;
    public string test_type;
    public string suitable;
    public string rejected;
    public string remarks;
    public string testedby;
    public string id_mst_loco;

    public Int64 Insert_Data()
    {
        Int64 n = 0;
        try
        {

            cmd = new SqlCommand("INSERT INTO table_compo_during_failure(l_date, comp_name, test_type, suitable, rejected, remarks, testedby, id_mst_loco) VALUES (@l_date,@comp_name,@test_type,@suitable,@rejected,@remarks,@testedby,@id_mst_loco)", cnn);
            cmd.Parameters.AddWithValue("@l_date", this.l_date);
            cmd.Parameters.AddWithValue("@comp_name", this.comp_name);
            cmd.Parameters.AddWithValue("@test_type", this.test_type);
            cmd.Parameters.AddWithValue("@suitable", this.suitable);
            cmd.Parameters.AddWithValue("@rejected", this.rejected);
            cmd.Parameters.AddWithValue("@remarks", this.remarks);
            cmd.Parameters.AddWithValue("@testedby", this.testedby);
            cmd.Parameters.AddWithValue("@id_mst_loco", this.id_mst_loco);
            cmd.Connection.Open();
            int m = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            if (m == 1)
            {
                cmd = new SqlCommand("SELECT MAX(comp_id) FROM table_compo_during_failure", cnn);
                cmd.Connection.Open();
                n = Convert.ToInt64(cmd.ExecuteScalar());
                cmd.Connection.Close();
                return n;
            }
            else
            {
                return 0;
            }
        }
        catch { throw; }
    }

    public DataTable Select_DataByLoco_n_Date()
    {
        try
        {
            //cmd = new SqlCommand("SELECT * FROM Loco_CompressorOil WHERE Id_Loco=@Id_Loco AND Loco_Date=@Loco_Date", cnn);
            //cmd = new SqlCommand("SELECT * FROM Loco_CompressorOil WHERE Id_Loco=@Id_Loco", cnn);
            // cmd = new SqlCommand("SELECT table_compo_during_failure.comp_id,table_compo_during_failure.id_mst_loco ,jos_railway_mst_loco.locono as Locono,REPLACE(CONVERT(VARCHAR(10),table_compo_during_failure.l_date,105),'-','/') as  Loco_Date,table_compo_during_failure.schedule as Id_Schedule1,jos_railway_loco_type_schedule.s_type as Id_Schedule,table_compo_during_failure.water,table_compo_during_failure.flashpoint,table_compo_during_failure.viscosity,table_compo_during_failure.ph,table_compo_during_failure.tbne,table_compo_during_failure.hi,table_compo_during_failure.ti,table_compo_during_failure.resin,table_compo_during_failure.oil_date_change,table_compo_during_failure.remarks INNER JOIN  jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = table_compo_during_failure.schedule INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = table_compo_during_failure.id_mst_loco WHERE id_mst_loco=@id_mst_loco", cnn);
            cmd = new SqlCommand("SELECT table_compo_during_failure.comp_id " +
      ",table_compo_during_failure.id_mst_loco " +
      ",jos_railway_mst_loco.locono as Locono" +
      ",REPLACE(CONVERT(VARCHAR(10),table_compo_during_failure.l_date,105),'-','/') as  Loco_Date" +
      ",table_compo_during_failure.comp_name as comp_name " +
      
      ",table_compo_during_failure.test_type " +
      ",table_compo_during_failure.suitable " +
      ",table_compo_during_failure.rejected " +
      ",table_compo_during_failure.remarks " +
      ",table_compo_during_failure.testedby " +
      
      "FROM table_compo_during_failure " +
      
      "INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = table_compo_during_failure.id_mst_loco WHERE table_compo_during_failure.id_mst_loco=@id_mst_loco", cnn);


            cmd.Parameters.AddWithValue("@id_mst_loco", this.id_mst_loco);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        catch { throw; }
    }
    public bool Check_Loco_Existance()
    {
        cmd = new SqlCommand("SELECT COUNT(*) FROM jos_railway_mst_loco WHERE id_mst_loco='" + this.id_mst_loco + "' ", cnn);
        cmd.Parameters.AddWithValue("@id_mst_loco", this.id_mst_loco);
        cmd.Connection.Open();
        int n = Convert.ToInt16(cmd.ExecuteScalar());
        cmd.Connection.Close();
        if (n == 0)
        {
            return false;
        }
        else
        {
            return true;
        }

    }
    public int Delete_Data()
    {
        try
        {
            cmd = new SqlCommand("DELETE FROM table_compo_during_failure  WHERE (comp_id=@comp_id)", cnn);
            cmd.Parameters.AddWithValue("@comp_id", this.comp_id);
            cmd.Connection.Open();
            int n = Convert.ToInt16(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            return n;
        }
        catch { throw; }
    }
    public int Update_Data()
    {
        try
        {
            cmd = new SqlCommand(" UPDATE    table_compo_during_failure SET l_date =@l_date, comp_name =@comp_name , test_type =@test_type , suitable =@suitable , rejected =@rejected , remarks =@remarks , testedby =@testedby , id_mst_loco =@id_mst_loco  WHERE comp_id=@comp_id ", cnn);
            cmd.Parameters.AddWithValue("@comp_id", this.comp_id);
            cmd.Parameters.AddWithValue("@l_date", this.l_date);
            cmd.Parameters.AddWithValue("@comp_name", this.comp_name);
            cmd.Parameters.AddWithValue("@test_type", this.test_type);
            cmd.Parameters.AddWithValue("@suitable", this.suitable);
            cmd.Parameters.AddWithValue("@rejected", this.rejected);
            cmd.Parameters.AddWithValue("@remarks", this.remarks);
            cmd.Parameters.AddWithValue("@testedby", this.testedby);
            cmd.Parameters.AddWithValue("@id_mst_loco", this.id_mst_loco);
            cmd.Connection.Open();
            int n = Convert.ToInt16(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            return n;
        }
        catch { throw; }
    }
    public DataTable Select_Databyid()
    {

        cmd = new SqlCommand("select * from table_compo_during_failure where comp_id=@comp_id ", cnn);
        cmd.Parameters.AddWithValue("@comp_id", this.comp_id);
        dt = new DataTable();
        da = new SqlDataAdapter();
        da.SelectCommand = cmd;
        dt.Clear();
        da.Fill(dt);
        return dt;
    }

    public DataTable Select_Data()
    {

        //cmd = new SqlCommand("select * from table_compo_during_failure  ", cnn);
        cmd = new SqlCommand("SELECT table_compo_during_failure.comp_id,CONVERT(VARCHAR(10),table_compo_during_failure.l_date,105)as l_date , table_compo_during_failure.comp_name, table_compo_during_failure.test_type, table_compo_during_failure.suitable, table_compo_during_failure.rejected, table_compo_during_failure.remarks, table_compo_during_failure.testedby, table_compo_during_failure.id_mst_loco, jos_railway_mst_loco.id_mst_loco AS Expr1, jos_railway_mst_loco.locono FROM         table_compo_during_failure INNER JOIN  jos_railway_mst_loco ON  table_compo_during_failure.id_mst_loco=jos_railway_mst_loco.id_mst_loco ", cnn);
        //cmd.Parameters.AddWithValue("@comp_id", this.comp_id);
        dt = new DataTable();
        da = new SqlDataAdapter();
        da.SelectCommand = cmd;
        dt.Clear();
        da.Fill(dt);
        return dt;
    }

    public DataTable Select_Databyloco( string locono)
    {

        //cmd = new SqlCommand("select * from table_compo_during_failure  ", cnn);
        cmd = new SqlCommand("SELECT table_compo_during_failure.comp_id,CONVERT(VARCHAR(10),table_compo_during_failure.l_date,105)as l_date , table_compo_during_failure.comp_name, table_compo_during_failure.test_type, table_compo_during_failure.suitable, table_compo_during_failure.rejected, table_compo_during_failure.remarks, table_compo_during_failure.testedby, table_compo_during_failure.id_mst_loco, jos_railway_mst_loco.id_mst_loco AS Expr1, jos_railway_mst_loco.locono FROM         table_compo_during_failure INNER JOIN  jos_railway_mst_loco ON  table_compo_during_failure.id_mst_loco=jos_railway_mst_loco.id_mst_loco  where table_compo_during_failure.id_mst_loco='"+locono+"' ", cnn);
        //cmd.Parameters.AddWithValue("@comp_id", this.comp_id);
        dt = new DataTable();
        da = new SqlDataAdapter();
        da.SelectCommand = cmd;
        dt.Clear();
        da.Fill(dt);
        return dt;
    }
    public DataTable Selectloco()
    {

        cmd = new SqlCommand("select * from jos_railway_mst_loco ", cnn);
        //cmd.Parameters.AddWithValue("@comp_id", this.comp_id);
        dt = new DataTable();
        da = new SqlDataAdapter();
        da.SelectCommand = cmd;
        dt.Clear();
        da.Fill(dt);
        return dt;
    }
}
