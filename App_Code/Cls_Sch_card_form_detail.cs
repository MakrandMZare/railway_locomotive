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
/// Summary description for Cls_Sch_card_form_detail
/// </summary>
public class Cls_Sch_card_form_detail:Cls_DBConnection
{
	public Cls_Sch_card_form_detail()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public string id_card_form_detail, id_sc_format,  status, action_taken;
   

    public Int64 Insert_Sch_card_form_detail()
    {
        try
        {
            cmd = new SqlCommand("INSERT INTO sch_card_form_detail ( id_sc_format, status, action_taken) VALUES ( @id_sc_format, @status, @action_taken)", cnn);
            //cmd.Parameters.AddWithValue("@id_sc_format", this.id_sc_format);
            cmd.Parameters.AddWithValue("@id_sc_format", this.id_sc_format);
            cmd.Parameters.AddWithValue("@status", this.status);
            cmd.Parameters.AddWithValue("@action_taken", this.action_taken);
            cmd.Connection.Open();
            int n = Convert.ToInt16(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            if (n == 1)
            {
                cmd = new SqlCommand("SELECT MAX(id_card_form_detail) FROM sch_card_form_detail", cnn);
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
        catch
        {
            throw;
        }
    }
}
