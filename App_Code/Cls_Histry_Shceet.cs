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
/// Summary description for Cls_Histry_Shceet
/// </summary>
public class Cls_Histry_Shceet : Cls_DBConnection
{
    public Cls_Histry_Shceet()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public string id_histrysheet;
    public string id_mst_loco;
    public string h_date;
    public string id_loco_sch;
    public string reason;

    public Int64 Insert_Data()
    {
        try
        {
            cmd = new SqlCommand("INSERT INTO Histry_Sheet (id_mst_loco, h_date, id_loco_sch, reason) VALUES (@id_mst_loco, @h_date, @id_loco_sch, @reason)", cnn);
            cmd.Parameters.AddWithValue("@id_mst_loco", this.id_mst_loco);
            cmd.Parameters.AddWithValue("@h_date", this.h_date);
            cmd.Parameters.AddWithValue("@id_loco_sch", this.id_loco_sch);
            cmd.Parameters.AddWithValue("@reason", this.reason);
            cmd.Connection.Open();
            Int16 n = Convert.ToInt16(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            if (n == 1)
            {
                cmd = new SqlCommand("SELECT MAX(id_histrysheet) FROM  Histry_Sheet", cnn);
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


    public DataTable Select_LocoHistry()
    {
        cmd = new SqlCommand("SELECT Histry_Sheet.id_histrysheet, Histry_Sheet.id_mst_loco, CONVERT(VARCHAR(10),Histry_Sheet.h_date,105) as h_date, Histry_Sheet.id_loco_sch, Histry_Sheet.reason as reason, jos_railway_mst_loco.locono as locono, jos_railway_mst_loco.id_mst_loco AS Expr1, jos_railway_loco_type_schedule.s_type as s_type,  jos_railway_loco_type_schedule.id_loco_sch AS Expr2 FROM  Histry_Sheet  INNER JOIN  jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco=Histry_Sheet.id_mst_loco INNER JOIN  jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch=Histry_Sheet.id_loco_sch ", cnn);
        da = new SqlDataAdapter();
        dt = new DataTable();
        da.SelectCommand = cmd;
        da.Fill(dt);
        return dt;
    }
}
