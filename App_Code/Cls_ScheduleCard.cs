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
/// Summary description for Cls_ScheduleCard
/// </summary>
public class Cls_ScheduleCard : Cls_DBConnection
{
    public Cls_ScheduleCard()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public string id_sch_card,id_section, name_sub_section;
    public DataTable Select_section()
    {
        try
        {
            cmd = new SqlCommand("SELECT * FROM jos_railway_section", cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        catch { throw; }
    }

    public Int64 Insert_SectionCard()
    {
        try
        {
            cmd = new SqlCommand("INSERT INTO schedule_card(id_section,name_sub_section)VALUES(@id_section,@name_sub_section)", cnn);

            cmd.Parameters.AddWithValue("@id_section", this.id_section);
            cmd.Parameters.AddWithValue("@name_sub_section",this.name_sub_section);
            cmd.Connection.Open();
            Int16 n = Convert.ToInt16(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            if (n == 1)
            {
                cmd = new SqlCommand("SELECT MAX(id_sch_card) FROM schedule_card", cnn);
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
}
