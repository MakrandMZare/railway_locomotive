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
/// Summary description for Cls_Card_Form
/// </summary>
public class Cls_Card_Form : Cls_DBConnection
{
    public Cls_Card_Form()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public string id_sc_format, id_section, id_schedule, id_loco, id_technician, id_supervisor, w_s_time, w_end_time, date1, id_sch_card, id_sc_para, id_sd_con, status, action_tak;
    public Int64 Insert_Data()
    {
        try
        {
            cmd = new SqlCommand("INSERT INTO schedule_card_form ( id_section, id_schedule, id_loco, id_technician, id_supervisor, w_s_time, w_end_time, date1, id_sch_card , status, action_tak) VALUES  (@id_section, @id_schedule, @id_loco, @id_technician, @id_supervisor, @w_s_time, @w_end_time, @date1, @id_sch_card, @status, @action_tak)", cnn);
            cmd.Parameters.AddWithValue("@id_section", this.id_section);
            cmd.Parameters.AddWithValue("@id_schedule", this.id_schedule);
            cmd.Parameters.AddWithValue("@id_loco", this.id_loco);
            cmd.Parameters.AddWithValue("@id_technician", this.id_technician);
            cmd.Parameters.AddWithValue("@id_supervisor", this.id_supervisor);
            cmd.Parameters.AddWithValue("@w_s_time", this.w_s_time);

            cmd.Parameters.AddWithValue("@w_end_time", this.w_end_time);
            cmd.Parameters.AddWithValue("@date1", this.date1);
            cmd.Parameters.AddWithValue("@id_sch_card", this.id_sch_card);
            //cmd.Parameters.AddWithValue("@id_sc_para", this.id_sc_para);


            //cmd.Parameters.AddWithValue("@id_sd_con", this.id_sd_con);
            cmd.Parameters.AddWithValue("@status", this.status);
            cmd.Parameters.AddWithValue("@action_tak", this.action_tak);


            cmd.Connection.Open();
            int n = Convert.ToInt16(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            //if (n == 1)
            //{
            //    cmd = new SqlCommand("SELECT MAX(id_sc_format) FROM schedule_card_form", cnn);
            //    cmd.Connection.Open();
            //    Int64 m = Convert.ToInt64(cmd.ExecuteScalar());
            //    cmd.Connection.Close();
            //    return m;
            //}
            //else
            //{
            //    return 0;
            //}
            return n;
        }
        catch
        {
            throw;
        }
    }
    public Int64 Insert_sta_act()
    {
        try
        {
            cmd = new SqlCommand("INSERT INTO schedule_card_form(status, action_tak)VALUES(@status, @action_tak) WHERE id_sc_format=@id_sc_format", cnn);
            cmd.Parameters.AddWithValue("@id_sc_format", this.id_sc_format);
            cmd.Parameters.AddWithValue("@status", this.status);
            cmd.Parameters.AddWithValue("@action_tak", this.action_tak);
            cmd.Connection.Open();
            int k = Convert.ToInt16(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            return k;
        }
        catch
        {
            throw;
        }
    }
    public Int64 Select_MaxID()
    {
        try
        {
            cmd = new SqlCommand("SELECT MAX(id_sc_format) FROM schedule_card_form", cnn);
            cmd.Connection.Open();
            Int64 m = Convert.ToInt64(cmd.ExecuteScalar());
            cmd.Connection.Close();
            return m;
        }

        catch { throw; }
    }
    public DataTable Select_Schedule()
    {
        try
        {
            cmd = new SqlCommand("SELECT id_loco_sch,s_type FROM jos_railway_loco_type_schedule", cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        catch { throw; }
    }

    public DataTable Select_section()
    {
        try
        {
            cmd = new SqlCommand("SELECT id_section,f_name FROM jos_railway_section", cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        catch { throw; }
    }


    public DataTable Select_loco()
    {
        try
        {
            cmd = new SqlCommand("SELECT id_mst_loco,locono FROM jos_railway_mst_loco", cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        catch { throw; }
    }

    public DataTable Select_hr()
    {
        try
        {
            cmd = new SqlCommand("SELECT id_hr,surname FROM jos_railway_Hr", cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        catch { throw; }
    }

    public DataTable Select_ScheduleCard(string id_section)
    {
        try
        {
           // cmd = new SqlCommand("SELECT id_sch_card,name_sub_section FROM schedule_card ", cnn);
            cmd = new SqlCommand("SELECT     jos_railway_section.id_section, jos_railway_section.f_name, jos_railway_section.s_type, schedule_card.id_sch_card,  schedule_card.id_section AS Expr1, schedule_card.name_sub_section FROM         jos_railway_section INNER JOIN schedule_card ON jos_railway_section.id_section = schedule_card.id_section WHERE  jos_railway_section.id_section='" + id_section + "' ", cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        catch { throw; }
    }
    public DataTable Select_sub_head(string id_sch_card)
    {
        try
        {
            //cmd = new SqlCommand("SELECT id_sc_para,sub_head FROM sch_card_sub_head", cnn);
            cmd = new SqlCommand("SELECT     sch_card_sub_head.id_sc_para, sch_card_sub_head.id_sch_card, sch_card_sub_head.id_loco_sch, sch_card_sub_head.sub_head,  schedule_card.id_sch_card AS Expr1, schedule_card.id_section, schedule_card.name_sub_section FROM         sch_card_sub_head INNER JOIN schedule_card ON sch_card_sub_head.id_sch_card = schedule_card.id_sch_card where schedule_card.id_sch_card='" + id_sch_card + "'", cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        catch { throw; }
    }

    public DataTable Select_sub_head_Deatil()
    {
        try
        {
            cmd = new SqlCommand("SELECT id_sd_con,sub_head_details FROM sch_card_head_deatils", cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        catch { throw; }
    }

    public DataTable Select_SubHead_Detail_Control_Stand(string id_loco_sch)
    {
        try
        {
           // cmd = new SqlCommand("SELECT sch_card_head_deatils.status,sch_card_head_deatils.action_taken,    jos_railway_loco_type_schedule.id_loco_sch, jos_railway_loco_type_schedule.loco_id, jos_railway_loco_type_schedule.s_type,                       jos_railway_loco_type_schedule.duration, sch_card_head_deatils.id_sd_con, sch_card_head_deatils.id_sc_para,                       sch_card_head_deatils.sub_head_details as sub_head_details , sch_card_sub_head.id_sc_para AS Expr1, sch_card_sub_head.id_sch_card,                       sch_card_sub_head.id_loco_sch AS Expr2, sch_card_sub_head.sub_head, schedule_card.id_sch_card AS Expr3, schedule_card.id_section,                       schedule_card.name_sub_section FROM         jos_railway_loco_type_schedule INNER JOIN                       sch_card_sub_head ON jos_railway_loco_type_schedule.id_loco_sch = sch_card_sub_head.id_loco_sch INNER JOIN                      sch_card_head_deatils ON sch_card_sub_head.id_sc_para = sch_card_head_deatils.id_sc_para INNER JOIN                      schedule_card ON sch_card_sub_head.id_sch_card = schedule_card.id_sch_card where jos_railway_loco_type_schedule.id_loco_sch='" + id_loco_sch + "'", cnn);
            cmd = new SqlCommand("SELECT    jos_railway_loco_type_schedule.id_loco_sch, jos_railway_loco_type_schedule.loco_id, jos_railway_loco_type_schedule.s_type,                       jos_railway_loco_type_schedule.duration, sch_card_head_deatils.id_sd_con, sch_card_head_deatils.id_sc_para,                       sch_card_head_deatils.sub_head_details as sub_head_details , sch_card_sub_head.id_sc_para AS Expr1, sch_card_sub_head.id_sch_card,                       sch_card_sub_head.id_loco_sch AS Expr2, sch_card_sub_head.sub_head, schedule_card.id_sch_card AS Expr3, schedule_card.id_section,                       schedule_card.name_sub_section FROM         jos_railway_loco_type_schedule INNER JOIN                       sch_card_sub_head ON jos_railway_loco_type_schedule.id_loco_sch = sch_card_sub_head.id_loco_sch INNER JOIN                      sch_card_head_deatils ON sch_card_sub_head.id_sc_para = sch_card_head_deatils.id_sc_para INNER JOIN                      schedule_card ON sch_card_sub_head.id_sch_card = schedule_card.id_sch_card where jos_railway_loco_type_schedule.id_loco_sch='" + id_loco_sch + "' and sch_card_sub_head.id_sc_para='1'", cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        catch
        { throw; }
    }
    public DataTable Select_SubHead_Detail_ECC1(string id_loco_sch)
    {
        try
        {
            // cmd = new SqlCommand("SELECT sch_card_head_deatils.status,sch_card_head_deatils.action_taken,    jos_railway_loco_type_schedule.id_loco_sch, jos_railway_loco_type_schedule.loco_id, jos_railway_loco_type_schedule.s_type,                       jos_railway_loco_type_schedule.duration, sch_card_head_deatils.id_sd_con, sch_card_head_deatils.id_sc_para,                       sch_card_head_deatils.sub_head_details as sub_head_details , sch_card_sub_head.id_sc_para AS Expr1, sch_card_sub_head.id_sch_card,                       sch_card_sub_head.id_loco_sch AS Expr2, sch_card_sub_head.sub_head, schedule_card.id_sch_card AS Expr3, schedule_card.id_section,                       schedule_card.name_sub_section FROM         jos_railway_loco_type_schedule INNER JOIN                       sch_card_sub_head ON jos_railway_loco_type_schedule.id_loco_sch = sch_card_sub_head.id_loco_sch INNER JOIN                      sch_card_head_deatils ON sch_card_sub_head.id_sc_para = sch_card_head_deatils.id_sc_para INNER JOIN                      schedule_card ON sch_card_sub_head.id_sch_card = schedule_card.id_sch_card where jos_railway_loco_type_schedule.id_loco_sch='" + id_loco_sch + "'", cnn);
            cmd = new SqlCommand("SELECT    jos_railway_loco_type_schedule.id_loco_sch, jos_railway_loco_type_schedule.loco_id, jos_railway_loco_type_schedule.s_type,                       jos_railway_loco_type_schedule.duration, sch_card_head_deatils.id_sd_con, sch_card_head_deatils.id_sc_para,                       sch_card_head_deatils.sub_head_details as sub_head_details , sch_card_sub_head.id_sc_para AS Expr1, sch_card_sub_head.id_sch_card,                       sch_card_sub_head.id_loco_sch AS Expr2, sch_card_sub_head.sub_head, schedule_card.id_sch_card AS Expr3, schedule_card.id_section,                       schedule_card.name_sub_section FROM         jos_railway_loco_type_schedule INNER JOIN                       sch_card_sub_head ON jos_railway_loco_type_schedule.id_loco_sch = sch_card_sub_head.id_loco_sch INNER JOIN                      sch_card_head_deatils ON sch_card_sub_head.id_sc_para = sch_card_head_deatils.id_sc_para INNER JOIN                      schedule_card ON sch_card_sub_head.id_sch_card = schedule_card.id_sch_card where jos_railway_loco_type_schedule.id_loco_sch='" + id_loco_sch + "' and sch_card_sub_head.id_sc_para='2'", cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        catch
        { throw; }
    }
    public DataTable Select_SubHead_Detail_ECC2(string id_loco_sch)
    {
        try
        {
            // cmd = new SqlCommand("SELECT sch_card_head_deatils.status,sch_card_head_deatils.action_taken,    jos_railway_loco_type_schedule.id_loco_sch, jos_railway_loco_type_schedule.loco_id, jos_railway_loco_type_schedule.s_type,                       jos_railway_loco_type_schedule.duration, sch_card_head_deatils.id_sd_con, sch_card_head_deatils.id_sc_para,                       sch_card_head_deatils.sub_head_details as sub_head_details , sch_card_sub_head.id_sc_para AS Expr1, sch_card_sub_head.id_sch_card,                       sch_card_sub_head.id_loco_sch AS Expr2, sch_card_sub_head.sub_head, schedule_card.id_sch_card AS Expr3, schedule_card.id_section,                       schedule_card.name_sub_section FROM         jos_railway_loco_type_schedule INNER JOIN                       sch_card_sub_head ON jos_railway_loco_type_schedule.id_loco_sch = sch_card_sub_head.id_loco_sch INNER JOIN                      sch_card_head_deatils ON sch_card_sub_head.id_sc_para = sch_card_head_deatils.id_sc_para INNER JOIN                      schedule_card ON sch_card_sub_head.id_sch_card = schedule_card.id_sch_card where jos_railway_loco_type_schedule.id_loco_sch='" + id_loco_sch + "'", cnn);
            cmd = new SqlCommand("SELECT    jos_railway_loco_type_schedule.id_loco_sch, jos_railway_loco_type_schedule.loco_id, jos_railway_loco_type_schedule.s_type,                       jos_railway_loco_type_schedule.duration, sch_card_head_deatils.id_sd_con, sch_card_head_deatils.id_sc_para,                       sch_card_head_deatils.sub_head_details as sub_head_details , sch_card_sub_head.id_sc_para AS Expr1, sch_card_sub_head.id_sch_card,                       sch_card_sub_head.id_loco_sch AS Expr2, sch_card_sub_head.sub_head, schedule_card.id_sch_card AS Expr3, schedule_card.id_section,                       schedule_card.name_sub_section FROM         jos_railway_loco_type_schedule INNER JOIN                       sch_card_sub_head ON jos_railway_loco_type_schedule.id_loco_sch = sch_card_sub_head.id_loco_sch INNER JOIN                      sch_card_head_deatils ON sch_card_sub_head.id_sc_para = sch_card_head_deatils.id_sc_para INNER JOIN                      schedule_card ON sch_card_sub_head.id_sch_card = schedule_card.id_sch_card where jos_railway_loco_type_schedule.id_loco_sch='" + id_loco_sch + "' and sch_card_sub_head.id_sc_para='3'", cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        catch
        { throw; }
    }
    public DataTable Select_SubHead_Detail_ECC3(string id_loco_sch)
    {
        try
        {
            // cmd = new SqlCommand("SELECT sch_card_head_deatils.status,sch_card_head_deatils.action_taken,    jos_railway_loco_type_schedule.id_loco_sch, jos_railway_loco_type_schedule.loco_id, jos_railway_loco_type_schedule.s_type,                       jos_railway_loco_type_schedule.duration, sch_card_head_deatils.id_sd_con, sch_card_head_deatils.id_sc_para,                       sch_card_head_deatils.sub_head_details as sub_head_details , sch_card_sub_head.id_sc_para AS Expr1, sch_card_sub_head.id_sch_card,                       sch_card_sub_head.id_loco_sch AS Expr2, sch_card_sub_head.sub_head, schedule_card.id_sch_card AS Expr3, schedule_card.id_section,                       schedule_card.name_sub_section FROM         jos_railway_loco_type_schedule INNER JOIN                       sch_card_sub_head ON jos_railway_loco_type_schedule.id_loco_sch = sch_card_sub_head.id_loco_sch INNER JOIN                      sch_card_head_deatils ON sch_card_sub_head.id_sc_para = sch_card_head_deatils.id_sc_para INNER JOIN                      schedule_card ON sch_card_sub_head.id_sch_card = schedule_card.id_sch_card where jos_railway_loco_type_schedule.id_loco_sch='" + id_loco_sch + "'", cnn);
            cmd = new SqlCommand("SELECT    jos_railway_loco_type_schedule.id_loco_sch, jos_railway_loco_type_schedule.loco_id, jos_railway_loco_type_schedule.s_type,                       jos_railway_loco_type_schedule.duration, sch_card_head_deatils.id_sd_con, sch_card_head_deatils.id_sc_para,                       sch_card_head_deatils.sub_head_details as sub_head_details , sch_card_sub_head.id_sc_para AS Expr1, sch_card_sub_head.id_sch_card,                       sch_card_sub_head.id_loco_sch AS Expr2, sch_card_sub_head.sub_head, schedule_card.id_sch_card AS Expr3, schedule_card.id_section,                       schedule_card.name_sub_section FROM         jos_railway_loco_type_schedule INNER JOIN                       sch_card_sub_head ON jos_railway_loco_type_schedule.id_loco_sch = sch_card_sub_head.id_loco_sch INNER JOIN                      sch_card_head_deatils ON sch_card_sub_head.id_sc_para = sch_card_head_deatils.id_sc_para INNER JOIN                      schedule_card ON sch_card_sub_head.id_sch_card = schedule_card.id_sch_card where jos_railway_loco_type_schedule.id_loco_sch='" + id_loco_sch + "' and sch_card_sub_head.id_sc_para='4'", cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        catch
        { throw; }
    }
    public DataTable Select_SubHead_Detail_Miscell(string id_loco_sch)
    {
        try
        {
            // cmd = new SqlCommand("SELECT sch_card_head_deatils.status,sch_card_head_deatils.action_taken,    jos_railway_loco_type_schedule.id_loco_sch, jos_railway_loco_type_schedule.loco_id, jos_railway_loco_type_schedule.s_type,                       jos_railway_loco_type_schedule.duration, sch_card_head_deatils.id_sd_con, sch_card_head_deatils.id_sc_para,                       sch_card_head_deatils.sub_head_details as sub_head_details , sch_card_sub_head.id_sc_para AS Expr1, sch_card_sub_head.id_sch_card,                       sch_card_sub_head.id_loco_sch AS Expr2, sch_card_sub_head.sub_head, schedule_card.id_sch_card AS Expr3, schedule_card.id_section,                       schedule_card.name_sub_section FROM         jos_railway_loco_type_schedule INNER JOIN                       sch_card_sub_head ON jos_railway_loco_type_schedule.id_loco_sch = sch_card_sub_head.id_loco_sch INNER JOIN                      sch_card_head_deatils ON sch_card_sub_head.id_sc_para = sch_card_head_deatils.id_sc_para INNER JOIN                      schedule_card ON sch_card_sub_head.id_sch_card = schedule_card.id_sch_card where jos_railway_loco_type_schedule.id_loco_sch='" + id_loco_sch + "'", cnn);
            cmd = new SqlCommand("SELECT    jos_railway_loco_type_schedule.id_loco_sch, jos_railway_loco_type_schedule.loco_id, jos_railway_loco_type_schedule.s_type,                       jos_railway_loco_type_schedule.duration, sch_card_head_deatils.id_sd_con, sch_card_head_deatils.id_sc_para,                       sch_card_head_deatils.sub_head_details as sub_head_details , sch_card_sub_head.id_sc_para AS Expr1, sch_card_sub_head.id_sch_card,                       sch_card_sub_head.id_loco_sch AS Expr2, sch_card_sub_head.sub_head, schedule_card.id_sch_card AS Expr3, schedule_card.id_section,                       schedule_card.name_sub_section FROM         jos_railway_loco_type_schedule INNER JOIN                       sch_card_sub_head ON jos_railway_loco_type_schedule.id_loco_sch = sch_card_sub_head.id_loco_sch INNER JOIN                      sch_card_head_deatils ON sch_card_sub_head.id_sc_para = sch_card_head_deatils.id_sc_para INNER JOIN                      schedule_card ON sch_card_sub_head.id_sch_card = schedule_card.id_sch_card where jos_railway_loco_type_schedule.id_loco_sch='" + id_loco_sch + "' and sch_card_sub_head.id_sc_para='5'", cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        catch
        { throw; }
    }
   
    
}
