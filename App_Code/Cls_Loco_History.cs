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
/// <summary>
/// Summary description for Cls_Loco_History
/// </summary>
public class Cls_Loco_History : Cls_DBConnection
{
    public Cls_Loco_History()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    // TABLE NAME :- bg_loco_history
    public string id_loco_his;   //  primary key
    public string h_date;
    public string id_loco_sch;
    public string reason;


    public Int64 Insert_Data()
    {
        try
        {
            cmd = new SqlCommand("INSERT INTO bg_loco_history(h_date,id_loco_sch,reason) VALUES(@h_date,@id_loco_sch,@reason)", cnn);
            cmd.Parameters.AddWithValue("@h_date", this.h_date);
            cmd.Parameters.AddWithValue("@id_loco_sch", this.id_loco_sch);
            cmd.Parameters.AddWithValue("@reason", this.reason);
            cmd.Connection.Open();
            Int16 n = Convert.ToInt16(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            if (n == 1)
            {
                cmd = new SqlCommand("SELECT MAX(id_loco_his) FROM  bg_loco_history", cnn);
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
    public string loco_id;
    public DataTable Select_LocoScheduleData()
    {
        try
        {
            cmd = new SqlCommand("SELECT REPLACE(CONVERT(VARCHAR(10),jos_railway_loco_in.a_date,105),'-','/') as arrivaldate " +
                            ",jos_railway_loco_type_schedule.s_type as scheduletype  " +
                            ",jos_railway_loco_in.\"action\" as Remarks " +
                            "from jos_railway_loco_in  " +
                            "INNER JOIN jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = jos_railway_loco_in.sid  " +
                            "WHERE jos_railway_loco_in.loco_id=@loco_id AND datepart(\"yy\",a_date)=datepart(\"YY\",getdate())", cnn);
            cmd.Parameters.AddWithValue("@loco_id", this.loco_id);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            return dt;

        }
        catch { throw; }
    }
}
