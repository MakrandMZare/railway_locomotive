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
/// Summary description for Cls_sub_head
/// </summary>
public class Cls_sub_head:Cls_DBConnection
{
	public Cls_sub_head()
	{
		//
		// TODO: Add constructor logic here
		//
	}
   public string  id_sch_card,id_loco_sch,sub_head;

    public Int64 Insert_data()
    {
        try
        {
            cmd = new SqlCommand("INSERT INTO sch_card_sub_head(id_sch_card,id_loco_sch,sub_head)VALUES(@id_sch_card,@id_loco_sch,@sub_head)", cnn);

            cmd.Parameters.AddWithValue("@id_sch_card", this.id_sch_card); 
            cmd.Parameters.AddWithValue("@id_loco_sch", this.id_loco_sch);
            cmd.Parameters.AddWithValue("@sub_head", this.sub_head);
            cmd.Connection.Open();
            Int16 n = Convert.ToInt16(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            if (n == 1)
            {
                cmd = new SqlCommand("SELECT MAX(id_sc_para) FROM sch_card_sub_head ", cnn);
                cmd.Connection.Open();

                Int16 m = Convert.ToInt16(cmd.ExecuteNonQuery());
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

    public DataTable Select_Schedule_Card()
    {
        try
        {
            cmd = new SqlCommand("SELECT * FROM schedule_card", cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        catch { throw; }

    }
    public DataTable Select_Schedule()
    {
        try
        {
            cmd = new SqlCommand("SELECT * FROM jos_railway_loco_type_schedule", cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        catch { throw; }

    }
}
