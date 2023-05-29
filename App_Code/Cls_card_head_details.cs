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
/// Summary description for Cls_card_head_details
/// </summary>
public class Cls_card_head_details : Cls_DBConnection
{
    public Cls_card_head_details()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public string id_sd_con, id_sc_para, sub_head_details;

    public Int64 Insert_Data()
    {
        try
        {
            cmd = new SqlCommand("INSERT INTO sch_card_head_deatils(id_sc_para,sub_head_details) VALUES(@id_sc_para,@sub_head_details) ", cnn);
            cmd.Parameters.AddWithValue("@id_sc_para", this.id_sc_para);
            cmd.Parameters.AddWithValue("@sub_head_details", this.sub_head_details);
            cmd.Connection.Open();
            Int16 n = Convert.ToInt16(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            if (n == 1)
            {
                cmd = new SqlCommand("SELECT MAX(id_sd_con) FROM sch_card_head_deatils", cnn);
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


    public DataTable select_sch_card_sub_head()
    {
        try
        {
            cmd = new SqlCommand("SELECT * FROM sch_card_sub_head", cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        catch { throw; }
    }
}
