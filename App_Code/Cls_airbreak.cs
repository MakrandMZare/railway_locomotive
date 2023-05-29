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
/// Summary description for Cls_airbreak
/// </summary>
public class Cls_airbreak:Cls_DBConnection
{
	public Cls_airbreak()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public string id_card_form_detail,action_taken, staff, id_sc_format, id_section, id_schedule, id_loco, id_technician, id_supervisor, w_s_time, w_end_time, date1, id_sch_card, id_sc_para, id_sd_con, status, action_tak;
    public Int64 Insert_Data()
    {
        try
        {
            cmd = new SqlCommand("INSERT INTO schedule_card_form ( id_section, id_schedule, id_loco, id_technician, id_supervisor, w_s_time, w_end_time, date1, id_sch_card ) VALUES  (@id_section, @id_schedule, @id_loco, @id_technician, @id_supervisor, @w_s_time, @w_end_time, @date1, @id_sch_card)", cnn);
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
            //cmd.Parameters.AddWithValue("@status", this.status);
            //cmd.Parameters.AddWithValue("@action_tak", this.action_tak);


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

    //UNDERTRUCK 
    public string  loc_rt1, loc_rt2, loc_rt3, loc_rt4, loc_lt1, loc_lt2, loc_lt3, loc_lt4, oil_level1, oil_level2, oil_level3, oil_level4, oil_level5, oil_level6, total_oilAdded, hl1, hr1, hl2, hr2, ll1, lr1, ll2, lr2, rl1, rr1, cl2, cr2, lh1, lh2, lh3, lh4, lh5, lh6, rh1, rh2, rh3, rh4, rh5, rh6, thrust1, thrust2, thrust3, thrust4, thrust5, thrust6, TestedInLab;    
    public Int64 Insert_unsertruk()
    {
        try
        {
            cmd = new SqlCommand("INSERT INTO Sch_mech_truck                      (id_sc_format, loc_rt1, loc_rt2, loc_rt3, loc_rt4, loc_lt1, loc_lt2, loc_lt3, loc_lt4, oil_level1, oil_level2, oil_level3, oil_level4, oil_level5, oil_level6,                       total_oilAdded, hl1, hr1, hl2, hr2, ll1, lr1, ll2, lr2, rl1, rr1, cl2, cr2, lh1, lh2, lh3, lh4, lh5, lh6, rh1, rh2, rh3, rh4, rh5, rh6, thrust1, thrust2, thrust3, thrust4,thrust5, thrust6, TestedInLab) VALUES (@id_sc_format, @loc_rt1, @loc_rt2, @loc_rt3, @loc_rt4, @loc_lt1, @loc_lt2, @loc_lt3, @loc_lt4, @oil_level1, @oil_level2, @oil_level3, @oil_level4, @oil_level5, @oil_level6,                      @total_oilAdded, @hl1, @hr1, @hl2, @hr2, @ll1, @lr1, @ll2, @lr2, @rl1, @rr1, @cl2, @cr2, @lh1, @lh2, @lh3, @lh4, @lh5, @lh6, @rh1, @rh2, @rh3, @rh4, @rh5, @rh6, @thrust1, @thrust2, @thrust3, @thrust4,                       @thrust5, @thrust6, @TestedInLab)", cnn);
            cmd.Parameters.AddWithValue("@id_sc_format", this.id_sc_format);
            cmd.Parameters.AddWithValue("@loc_rt1", this.loc_rt1);
            cmd.Parameters.AddWithValue("@loc_rt2", this.loc_rt2);
            cmd.Parameters.AddWithValue("@loc_rt3", this.loc_rt3);
            cmd.Parameters.AddWithValue("@loc_rt4", this.loc_rt4);
            cmd.Parameters.AddWithValue("@loc_lt1", this.loc_lt1);
            cmd.Parameters.AddWithValue("@loc_lt2", this.loc_lt2);
            cmd.Parameters.AddWithValue("@loc_lt3", this.loc_lt3);
            cmd.Parameters.AddWithValue("@loc_lt4", this.loc_lt4);
            cmd.Parameters.AddWithValue("@oil_level1", this.oil_level1);
            cmd.Parameters.AddWithValue("@oil_level2", this.oil_level2);
            cmd.Parameters.AddWithValue("@oil_level3", this.oil_level3);
            cmd.Parameters.AddWithValue("@oil_level4", this.oil_level4);
            cmd.Parameters.AddWithValue("@oil_level5", this.oil_level5);
            cmd.Parameters.AddWithValue("@oil_level6", this.oil_level6);
            cmd.Parameters.AddWithValue("@total_oilAdded", this.total_oilAdded);
            cmd.Parameters.AddWithValue("@hl1", this.hl1);
            cmd.Parameters.AddWithValue("@hr1", this.hr1);
            cmd.Parameters.AddWithValue("@hl2", this.hl2);
            cmd.Parameters.AddWithValue("@hr2", this.hr2);
            cmd.Parameters.AddWithValue("@ll1", this.ll1);
            cmd.Parameters.AddWithValue("@lr1", this.lr1);
            cmd.Parameters.AddWithValue("@ll2", this.ll2);
            cmd.Parameters.AddWithValue("@lr2", this.lr2);
            cmd.Parameters.AddWithValue("@rl1", this.rl1);
            cmd.Parameters.AddWithValue("@rr1", this.rr1);
            cmd.Parameters.AddWithValue("@cl2", this.cl2);
            cmd.Parameters.AddWithValue("@cr2", this.cr2);
            cmd.Parameters.AddWithValue("@lh1", this.lh1);
            cmd.Parameters.AddWithValue("@lh2", this.lh2);
            cmd.Parameters.AddWithValue("@lh3", this.lh3);
            cmd.Parameters.AddWithValue("@lh4", this.lh4);
            cmd.Parameters.AddWithValue("@lh5", this.lh5);
            cmd.Parameters.AddWithValue("@lh6", this.lh6);
            cmd.Parameters.AddWithValue("@rh1", this.rh1);
            cmd.Parameters.AddWithValue("@rh2", this.rh2);
            cmd.Parameters.AddWithValue("@rh3", this.rh3);
            cmd.Parameters.AddWithValue("@rh4", this.rh4);
            cmd.Parameters.AddWithValue("@rh5", this.rh5);
            cmd.Parameters.AddWithValue("@rh6", this.rh6);
            cmd.Parameters.AddWithValue("@thrust1", this.thrust1);
            cmd.Parameters.AddWithValue("@thrust2", this.thrust2);
            cmd.Parameters.AddWithValue("@thrust3", this.thrust3);
            cmd.Parameters.AddWithValue("@thrust4", this.thrust4);
            cmd.Parameters.AddWithValue("@thrust5", this.thrust5);
            cmd.Parameters.AddWithValue("@thrust6", this.thrust6);
            cmd.Parameters.AddWithValue("@TestedInLab", this.TestedInLab);
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



    //id_card_form_detail
    public Int64 Insert_sta_act()
    {
        try
        {
            cmd = new SqlCommand("INSERT INTO sch_card_form_detail  (id_sc_format, status, action_taken,staff)VALUES  ( @id_sc_format, @status, @action_taken,@staff)", cnn);
            cmd.Parameters.AddWithValue("@id_sc_format", this.id_sc_format);
            cmd.Parameters.AddWithValue("@status", this.status);
            cmd.Parameters.AddWithValue("@action_taken", this.action_taken);
            cmd.Parameters.AddWithValue("@staff", this.staff);
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


    public DataTable Select_SubHead_Detail_fuelsystem(string id_loco_sch)
    {
        try
        {
           cmd = new SqlCommand("SELECT jos_railway_loco_type_schedule.id_loco_sch, jos_railway_loco_type_schedule.loco_id, jos_railway_loco_type_schedule.s_type,                       jos_railway_loco_type_schedule.duration, sch_card_head_deatils.id_sd_con, sch_card_head_deatils.id_sc_para,                       sch_card_head_deatils.sub_head_details as sub_head_details , sch_card_sub_head.id_sc_para AS Expr1, sch_card_sub_head.id_sch_card,                       sch_card_sub_head.id_loco_sch AS Expr2, sch_card_sub_head.sub_head, schedule_card.id_sch_card AS Expr3, schedule_card.id_section,                       schedule_card.name_sub_section FROM         jos_railway_loco_type_schedule INNER JOIN                       sch_card_sub_head ON jos_railway_loco_type_schedule.id_loco_sch = sch_card_sub_head.id_loco_sch INNER JOIN                      sch_card_head_deatils ON sch_card_sub_head.id_sc_para = sch_card_head_deatils.id_sc_para INNER JOIN                      schedule_card ON sch_card_sub_head.id_sch_card = schedule_card.id_sch_card where jos_railway_loco_type_schedule.id_loco_sch='" + id_loco_sch + "' and sch_card_sub_head.id_sc_para='15'  ", cnn);
           // cmd = new SqlCommand("SELECT distinct (sch_card_sub_head.id_sc_para), sch_card_head_deatils.sub_head_details,sch_card_sub_head.sub_head,schedule_card_form.id_sc_format ,jos_railway_loco_type_schedule.id_loco_sch, jos_railway_loco_type_schedule.loco_id, jos_railway_loco_type_schedule.s_type,                       jos_railway_loco_type_schedule.duration, sch_card_sub_head.id_sch_card,                       sch_card_sub_head.id_loco_sch AS Expr1,   schedule_card_form.id_section,                       schedule_card_form.id_schedule, schedule_card_form.id_loco, schedule_card_form.id_technician, schedule_card_form.id_supervisor,                       schedule_card_form.w_s_time, schedule_card_form.w_end_time, schedule_card_form.date1, schedule_card_form.id_sch_card AS Expr2,                       schedule_card_form.status, schedule_card_form.action_tak, jos_railway_mst_loco.id_mst_loco, jos_railway_mst_loco.locono,                      jos_railway_mst_loco.tid, jos_railway_mst_loco.shed_id, jos_railway_mst_loco.doc_date, jos_railway_mst_loco.a_time,                       jos_railway_mst_loco.poh_date, jos_railway_mst_loco.native, jos_railway_mst_loco.rfrom, sch_card_head_deatils.id_sd_con,                       sch_card_head_deatils.id_sc_para AS Expr3,  sch_card_form_detail.id_card_form_detail,                       sch_card_form_detail.id_sc_format AS Expr4, sch_card_form_detail.status AS Expr5, sch_card_form_detail.action_taken,                      sch_card_form_detail.staff,schedule_card.id_sch_card,schedule_card.name_sub_section FROM   schedule_card_form   INNER JOIN jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = schedule_card_form.id_schedule INNER JOIN   jos_railway_mst_loco   ON schedule_card_form.id_loco = jos_railway_mst_loco.id_mst_loco INNER JOIN  sch_card_sub_head ON jos_railway_loco_type_schedule.id_loco_sch = sch_card_sub_head.id_loco_sch INNER JOIN  sch_card_head_deatils ON sch_card_sub_head.id_sc_para = sch_card_head_deatils.id_sc_para INNER JOIN  sch_card_form_detail ON sch_card_form_detail.id_sc_format=schedule_card_form.id_sc_format INNER JOIN jos_railway_section ON jos_railway_section.id_section = schedule_card_form.id_section INNER JOIN schedule_card ON schedule_card.id_sch_card=sch_card_sub_head.id_sch_card  where jos_railway_section.id_section='2'and  schedule_card.id_sch_card ='3'and jos_railway_loco_type_schedule.id_loco_sch='" + id_loco_sch + "' ", cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        catch
        { throw; }
    }
    public DataTable Select_SubHead_Detail_heatExchanger(string id_loco_sch)
    {
        try
        {
            cmd = new SqlCommand("SELECT jos_railway_loco_type_schedule.id_loco_sch, jos_railway_loco_type_schedule.loco_id, jos_railway_loco_type_schedule.s_type,                       jos_railway_loco_type_schedule.duration, sch_card_head_deatils.id_sd_con, sch_card_head_deatils.id_sc_para,                       sch_card_head_deatils.sub_head_details as sub_head_details , sch_card_sub_head.id_sc_para AS Expr1, sch_card_sub_head.id_sch_card,                       sch_card_sub_head.id_loco_sch AS Expr2, sch_card_sub_head.sub_head, schedule_card.id_sch_card AS Expr3, schedule_card.id_section,                       schedule_card.name_sub_section FROM         jos_railway_loco_type_schedule INNER JOIN                       sch_card_sub_head ON jos_railway_loco_type_schedule.id_loco_sch = sch_card_sub_head.id_loco_sch INNER JOIN                      sch_card_head_deatils ON sch_card_sub_head.id_sc_para = sch_card_head_deatils.id_sc_para INNER JOIN                      schedule_card ON sch_card_sub_head.id_sch_card = schedule_card.id_sch_card where jos_railway_loco_type_schedule.id_loco_sch='" + id_loco_sch + "' and sch_card_sub_head.id_sc_para='19'  ", cnn);
            // cmd = new SqlCommand("SELECT distinct (sch_card_sub_head.id_sc_para), sch_card_head_deatils.sub_head_details,sch_card_sub_head.sub_head,schedule_card_form.id_sc_format ,jos_railway_loco_type_schedule.id_loco_sch, jos_railway_loco_type_schedule.loco_id, jos_railway_loco_type_schedule.s_type,                       jos_railway_loco_type_schedule.duration, sch_card_sub_head.id_sch_card,                       sch_card_sub_head.id_loco_sch AS Expr1,   schedule_card_form.id_section,                       schedule_card_form.id_schedule, schedule_card_form.id_loco, schedule_card_form.id_technician, schedule_card_form.id_supervisor,                       schedule_card_form.w_s_time, schedule_card_form.w_end_time, schedule_card_form.date1, schedule_card_form.id_sch_card AS Expr2,                       schedule_card_form.status, schedule_card_form.action_tak, jos_railway_mst_loco.id_mst_loco, jos_railway_mst_loco.locono,                      jos_railway_mst_loco.tid, jos_railway_mst_loco.shed_id, jos_railway_mst_loco.doc_date, jos_railway_mst_loco.a_time,                       jos_railway_mst_loco.poh_date, jos_railway_mst_loco.native, jos_railway_mst_loco.rfrom, sch_card_head_deatils.id_sd_con,                       sch_card_head_deatils.id_sc_para AS Expr3,  sch_card_form_detail.id_card_form_detail,                       sch_card_form_detail.id_sc_format AS Expr4, sch_card_form_detail.status AS Expr5, sch_card_form_detail.action_taken,                      sch_card_form_detail.staff,schedule_card.id_sch_card,schedule_card.name_sub_section FROM   schedule_card_form   INNER JOIN jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = schedule_card_form.id_schedule INNER JOIN   jos_railway_mst_loco   ON schedule_card_form.id_loco = jos_railway_mst_loco.id_mst_loco INNER JOIN  sch_card_sub_head ON jos_railway_loco_type_schedule.id_loco_sch = sch_card_sub_head.id_loco_sch INNER JOIN  sch_card_head_deatils ON sch_card_sub_head.id_sc_para = sch_card_head_deatils.id_sc_para INNER JOIN  sch_card_form_detail ON sch_card_form_detail.id_sc_format=schedule_card_form.id_sc_format INNER JOIN jos_railway_section ON jos_railway_section.id_section = schedule_card_form.id_section INNER JOIN schedule_card ON schedule_card.id_sch_card=sch_card_sub_head.id_sch_card  where jos_railway_section.id_section='2'and  schedule_card.id_sch_card ='3'and jos_railway_loco_type_schedule.id_loco_sch='" + id_loco_sch + "' ", cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        catch
        { throw; }
    }

    public DataTable Select_SubHead_Detail_undertruk20(string id_loco_sch)
    {
        try
        {
            cmd = new SqlCommand("SELECT jos_railway_loco_type_schedule.id_loco_sch, jos_railway_loco_type_schedule.loco_id, jos_railway_loco_type_schedule.s_type,                       jos_railway_loco_type_schedule.duration, sch_card_head_deatils.id_sd_con, sch_card_head_deatils.id_sc_para,                       sch_card_head_deatils.sub_head_details as sub_head_details , sch_card_sub_head.id_sc_para AS Expr1, sch_card_sub_head.id_sch_card,                       sch_card_sub_head.id_loco_sch AS Expr2, sch_card_sub_head.sub_head, schedule_card.id_sch_card AS Expr3, schedule_card.id_section,                       schedule_card.name_sub_section FROM         jos_railway_loco_type_schedule INNER JOIN                       sch_card_sub_head ON jos_railway_loco_type_schedule.id_loco_sch = sch_card_sub_head.id_loco_sch INNER JOIN                      sch_card_head_deatils ON sch_card_sub_head.id_sc_para = sch_card_head_deatils.id_sc_para INNER JOIN                      schedule_card ON sch_card_sub_head.id_sch_card = schedule_card.id_sch_card where jos_railway_loco_type_schedule.id_loco_sch='" + id_loco_sch + "' and sch_card_sub_head.id_sc_para='20'  ", cnn);
            // cmd = new SqlCommand("SELECT distinct (sch_card_sub_head.id_sc_para), sch_card_head_deatils.sub_head_details,sch_card_sub_head.sub_head,schedule_card_form.id_sc_format ,jos_railway_loco_type_schedule.id_loco_sch, jos_railway_loco_type_schedule.loco_id, jos_railway_loco_type_schedule.s_type,                       jos_railway_loco_type_schedule.duration, sch_card_sub_head.id_sch_card,                       sch_card_sub_head.id_loco_sch AS Expr1,   schedule_card_form.id_section,                       schedule_card_form.id_schedule, schedule_card_form.id_loco, schedule_card_form.id_technician, schedule_card_form.id_supervisor,                       schedule_card_form.w_s_time, schedule_card_form.w_end_time, schedule_card_form.date1, schedule_card_form.id_sch_card AS Expr2,                       schedule_card_form.status, schedule_card_form.action_tak, jos_railway_mst_loco.id_mst_loco, jos_railway_mst_loco.locono,                      jos_railway_mst_loco.tid, jos_railway_mst_loco.shed_id, jos_railway_mst_loco.doc_date, jos_railway_mst_loco.a_time,                       jos_railway_mst_loco.poh_date, jos_railway_mst_loco.native, jos_railway_mst_loco.rfrom, sch_card_head_deatils.id_sd_con,                       sch_card_head_deatils.id_sc_para AS Expr3,  sch_card_form_detail.id_card_form_detail,                       sch_card_form_detail.id_sc_format AS Expr4, sch_card_form_detail.status AS Expr5, sch_card_form_detail.action_taken,                      sch_card_form_detail.staff,schedule_card.id_sch_card,schedule_card.name_sub_section FROM   schedule_card_form   INNER JOIN jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = schedule_card_form.id_schedule INNER JOIN   jos_railway_mst_loco   ON schedule_card_form.id_loco = jos_railway_mst_loco.id_mst_loco INNER JOIN  sch_card_sub_head ON jos_railway_loco_type_schedule.id_loco_sch = sch_card_sub_head.id_loco_sch INNER JOIN  sch_card_head_deatils ON sch_card_sub_head.id_sc_para = sch_card_head_deatils.id_sc_para INNER JOIN  sch_card_form_detail ON sch_card_form_detail.id_sc_format=schedule_card_form.id_sc_format INNER JOIN jos_railway_section ON jos_railway_section.id_section = schedule_card_form.id_section INNER JOIN schedule_card ON schedule_card.id_sch_card=sch_card_sub_head.id_sch_card  where jos_railway_section.id_section='2'and  schedule_card.id_sch_card ='3'and jos_railway_loco_type_schedule.id_loco_sch='" + id_loco_sch + "' ", cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        catch
        { throw; }
    }
    public DataTable Select_SubHead_Detail_undertruk21(string id_loco_sch)
    {
        try
        {
            cmd = new SqlCommand("SELECT jos_railway_loco_type_schedule.id_loco_sch, jos_railway_loco_type_schedule.loco_id, jos_railway_loco_type_schedule.s_type,                       jos_railway_loco_type_schedule.duration, sch_card_head_deatils.id_sd_con, sch_card_head_deatils.id_sc_para,                       sch_card_head_deatils.sub_head_details as sub_head_details , sch_card_sub_head.id_sc_para AS Expr1, sch_card_sub_head.id_sch_card,                       sch_card_sub_head.id_loco_sch AS Expr2, sch_card_sub_head.sub_head, schedule_card.id_sch_card AS Expr3, schedule_card.id_section,                       schedule_card.name_sub_section FROM         jos_railway_loco_type_schedule INNER JOIN                       sch_card_sub_head ON jos_railway_loco_type_schedule.id_loco_sch = sch_card_sub_head.id_loco_sch INNER JOIN                      sch_card_head_deatils ON sch_card_sub_head.id_sc_para = sch_card_head_deatils.id_sc_para INNER JOIN                      schedule_card ON sch_card_sub_head.id_sch_card = schedule_card.id_sch_card where jos_railway_loco_type_schedule.id_loco_sch='" + id_loco_sch + "' and sch_card_sub_head.id_sc_para='21'  ", cnn);
            // cmd = new SqlCommand("SELECT distinct (sch_card_sub_head.id_sc_para), sch_card_head_deatils.sub_head_details,sch_card_sub_head.sub_head,schedule_card_form.id_sc_format ,jos_railway_loco_type_schedule.id_loco_sch, jos_railway_loco_type_schedule.loco_id, jos_railway_loco_type_schedule.s_type,                       jos_railway_loco_type_schedule.duration, sch_card_sub_head.id_sch_card,                       sch_card_sub_head.id_loco_sch AS Expr1,   schedule_card_form.id_section,                       schedule_card_form.id_schedule, schedule_card_form.id_loco, schedule_card_form.id_technician, schedule_card_form.id_supervisor,                       schedule_card_form.w_s_time, schedule_card_form.w_end_time, schedule_card_form.date1, schedule_card_form.id_sch_card AS Expr2,                       schedule_card_form.status, schedule_card_form.action_tak, jos_railway_mst_loco.id_mst_loco, jos_railway_mst_loco.locono,                      jos_railway_mst_loco.tid, jos_railway_mst_loco.shed_id, jos_railway_mst_loco.doc_date, jos_railway_mst_loco.a_time,                       jos_railway_mst_loco.poh_date, jos_railway_mst_loco.native, jos_railway_mst_loco.rfrom, sch_card_head_deatils.id_sd_con,                       sch_card_head_deatils.id_sc_para AS Expr3,  sch_card_form_detail.id_card_form_detail,                       sch_card_form_detail.id_sc_format AS Expr4, sch_card_form_detail.status AS Expr5, sch_card_form_detail.action_taken,                      sch_card_form_detail.staff,schedule_card.id_sch_card,schedule_card.name_sub_section FROM   schedule_card_form   INNER JOIN jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = schedule_card_form.id_schedule INNER JOIN   jos_railway_mst_loco   ON schedule_card_form.id_loco = jos_railway_mst_loco.id_mst_loco INNER JOIN  sch_card_sub_head ON jos_railway_loco_type_schedule.id_loco_sch = sch_card_sub_head.id_loco_sch INNER JOIN  sch_card_head_deatils ON sch_card_sub_head.id_sc_para = sch_card_head_deatils.id_sc_para INNER JOIN  sch_card_form_detail ON sch_card_form_detail.id_sc_format=schedule_card_form.id_sc_format INNER JOIN jos_railway_section ON jos_railway_section.id_section = schedule_card_form.id_section INNER JOIN schedule_card ON schedule_card.id_sch_card=sch_card_sub_head.id_sch_card  where jos_railway_section.id_section='2'and  schedule_card.id_sch_card ='3'and jos_railway_loco_type_schedule.id_loco_sch='" + id_loco_sch + "' ", cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        catch
        { throw; }
    }

    public DataTable Select_SubHead_Detail_undertruk22(string id_loco_sch)
    {
        try
        {
            cmd = new SqlCommand("SELECT jos_railway_loco_type_schedule.id_loco_sch, jos_railway_loco_type_schedule.loco_id, jos_railway_loco_type_schedule.s_type,                       jos_railway_loco_type_schedule.duration, sch_card_head_deatils.id_sd_con, sch_card_head_deatils.id_sc_para,                       sch_card_head_deatils.sub_head_details as sub_head_details , sch_card_sub_head.id_sc_para AS Expr1, sch_card_sub_head.id_sch_card,                       sch_card_sub_head.id_loco_sch AS Expr2, sch_card_sub_head.sub_head, schedule_card.id_sch_card AS Expr3, schedule_card.id_section,                       schedule_card.name_sub_section FROM         jos_railway_loco_type_schedule INNER JOIN                       sch_card_sub_head ON jos_railway_loco_type_schedule.id_loco_sch = sch_card_sub_head.id_loco_sch INNER JOIN                      sch_card_head_deatils ON sch_card_sub_head.id_sc_para = sch_card_head_deatils.id_sc_para INNER JOIN                      schedule_card ON sch_card_sub_head.id_sch_card = schedule_card.id_sch_card where jos_railway_loco_type_schedule.id_loco_sch='" + id_loco_sch + "' and sch_card_sub_head.id_sc_para='22'  ", cnn);
            // cmd = new SqlCommand("SELECT distinct (sch_card_sub_head.id_sc_para), sch_card_head_deatils.sub_head_details,sch_card_sub_head.sub_head,schedule_card_form.id_sc_format ,jos_railway_loco_type_schedule.id_loco_sch, jos_railway_loco_type_schedule.loco_id, jos_railway_loco_type_schedule.s_type,                       jos_railway_loco_type_schedule.duration, sch_card_sub_head.id_sch_card,                       sch_card_sub_head.id_loco_sch AS Expr1,   schedule_card_form.id_section,                       schedule_card_form.id_schedule, schedule_card_form.id_loco, schedule_card_form.id_technician, schedule_card_form.id_supervisor,                       schedule_card_form.w_s_time, schedule_card_form.w_end_time, schedule_card_form.date1, schedule_card_form.id_sch_card AS Expr2,                       schedule_card_form.status, schedule_card_form.action_tak, jos_railway_mst_loco.id_mst_loco, jos_railway_mst_loco.locono,                      jos_railway_mst_loco.tid, jos_railway_mst_loco.shed_id, jos_railway_mst_loco.doc_date, jos_railway_mst_loco.a_time,                       jos_railway_mst_loco.poh_date, jos_railway_mst_loco.native, jos_railway_mst_loco.rfrom, sch_card_head_deatils.id_sd_con,                       sch_card_head_deatils.id_sc_para AS Expr3,  sch_card_form_detail.id_card_form_detail,                       sch_card_form_detail.id_sc_format AS Expr4, sch_card_form_detail.status AS Expr5, sch_card_form_detail.action_taken,                      sch_card_form_detail.staff,schedule_card.id_sch_card,schedule_card.name_sub_section FROM   schedule_card_form   INNER JOIN jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = schedule_card_form.id_schedule INNER JOIN   jos_railway_mst_loco   ON schedule_card_form.id_loco = jos_railway_mst_loco.id_mst_loco INNER JOIN  sch_card_sub_head ON jos_railway_loco_type_schedule.id_loco_sch = sch_card_sub_head.id_loco_sch INNER JOIN  sch_card_head_deatils ON sch_card_sub_head.id_sc_para = sch_card_head_deatils.id_sc_para INNER JOIN  sch_card_form_detail ON sch_card_form_detail.id_sc_format=schedule_card_form.id_sc_format INNER JOIN jos_railway_section ON jos_railway_section.id_section = schedule_card_form.id_section INNER JOIN schedule_card ON schedule_card.id_sch_card=sch_card_sub_head.id_sch_card  where jos_railway_section.id_section='2'and  schedule_card.id_sch_card ='3'and jos_railway_loco_type_schedule.id_loco_sch='" + id_loco_sch + "' ", cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        catch
        { throw; }
    }
    public DataTable Select_SubHead_Detail_undertruk23(string id_loco_sch)
    {
        try
        {
            cmd = new SqlCommand("SELECT jos_railway_loco_type_schedule.id_loco_sch, jos_railway_loco_type_schedule.loco_id, jos_railway_loco_type_schedule.s_type,                       jos_railway_loco_type_schedule.duration, sch_card_head_deatils.id_sd_con, sch_card_head_deatils.id_sc_para,                       sch_card_head_deatils.sub_head_details as sub_head_details , sch_card_sub_head.id_sc_para AS Expr1, sch_card_sub_head.id_sch_card,                       sch_card_sub_head.id_loco_sch AS Expr2, sch_card_sub_head.sub_head, schedule_card.id_sch_card AS Expr3, schedule_card.id_section,                       schedule_card.name_sub_section FROM         jos_railway_loco_type_schedule INNER JOIN                       sch_card_sub_head ON jos_railway_loco_type_schedule.id_loco_sch = sch_card_sub_head.id_loco_sch INNER JOIN                      sch_card_head_deatils ON sch_card_sub_head.id_sc_para = sch_card_head_deatils.id_sc_para INNER JOIN                      schedule_card ON sch_card_sub_head.id_sch_card = schedule_card.id_sch_card where jos_railway_loco_type_schedule.id_loco_sch='" + id_loco_sch + "' and sch_card_sub_head.id_sc_para='23'  ", cnn);
            // cmd = new SqlCommand("SELECT distinct (sch_card_sub_head.id_sc_para), sch_card_head_deatils.sub_head_details,sch_card_sub_head.sub_head,schedule_card_form.id_sc_format ,jos_railway_loco_type_schedule.id_loco_sch, jos_railway_loco_type_schedule.loco_id, jos_railway_loco_type_schedule.s_type,                       jos_railway_loco_type_schedule.duration, sch_card_sub_head.id_sch_card,                       sch_card_sub_head.id_loco_sch AS Expr1,   schedule_card_form.id_section,                       schedule_card_form.id_schedule, schedule_card_form.id_loco, schedule_card_form.id_technician, schedule_card_form.id_supervisor,                       schedule_card_form.w_s_time, schedule_card_form.w_end_time, schedule_card_form.date1, schedule_card_form.id_sch_card AS Expr2,                       schedule_card_form.status, schedule_card_form.action_tak, jos_railway_mst_loco.id_mst_loco, jos_railway_mst_loco.locono,                      jos_railway_mst_loco.tid, jos_railway_mst_loco.shed_id, jos_railway_mst_loco.doc_date, jos_railway_mst_loco.a_time,                       jos_railway_mst_loco.poh_date, jos_railway_mst_loco.native, jos_railway_mst_loco.rfrom, sch_card_head_deatils.id_sd_con,                       sch_card_head_deatils.id_sc_para AS Expr3,  sch_card_form_detail.id_card_form_detail,                       sch_card_form_detail.id_sc_format AS Expr4, sch_card_form_detail.status AS Expr5, sch_card_form_detail.action_taken,                      sch_card_form_detail.staff,schedule_card.id_sch_card,schedule_card.name_sub_section FROM   schedule_card_form   INNER JOIN jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = schedule_card_form.id_schedule INNER JOIN   jos_railway_mst_loco   ON schedule_card_form.id_loco = jos_railway_mst_loco.id_mst_loco INNER JOIN  sch_card_sub_head ON jos_railway_loco_type_schedule.id_loco_sch = sch_card_sub_head.id_loco_sch INNER JOIN  sch_card_head_deatils ON sch_card_sub_head.id_sc_para = sch_card_head_deatils.id_sc_para INNER JOIN  sch_card_form_detail ON sch_card_form_detail.id_sc_format=schedule_card_form.id_sc_format INNER JOIN jos_railway_section ON jos_railway_section.id_section = schedule_card_form.id_section INNER JOIN schedule_card ON schedule_card.id_sch_card=sch_card_sub_head.id_sch_card  where jos_railway_section.id_section='2'and  schedule_card.id_sch_card ='3'and jos_railway_loco_type_schedule.id_loco_sch='" + id_loco_sch + "' ", cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        catch
        { throw; }
    }

    public DataTable Select_SubHead_Detail_undertruk24(string id_loco_sch)
    {
        try
        {
            cmd = new SqlCommand("SELECT jos_railway_loco_type_schedule.id_loco_sch, jos_railway_loco_type_schedule.loco_id, jos_railway_loco_type_schedule.s_type,                       jos_railway_loco_type_schedule.duration, sch_card_head_deatils.id_sd_con, sch_card_head_deatils.id_sc_para,                       sch_card_head_deatils.sub_head_details as sub_head_details , sch_card_sub_head.id_sc_para AS Expr1, sch_card_sub_head.id_sch_card,                       sch_card_sub_head.id_loco_sch AS Expr2, sch_card_sub_head.sub_head, schedule_card.id_sch_card AS Expr3, schedule_card.id_section,                       schedule_card.name_sub_section FROM         jos_railway_loco_type_schedule INNER JOIN                       sch_card_sub_head ON jos_railway_loco_type_schedule.id_loco_sch = sch_card_sub_head.id_loco_sch INNER JOIN                      sch_card_head_deatils ON sch_card_sub_head.id_sc_para = sch_card_head_deatils.id_sc_para INNER JOIN                      schedule_card ON sch_card_sub_head.id_sch_card = schedule_card.id_sch_card where jos_railway_loco_type_schedule.id_loco_sch='" + id_loco_sch + "' and sch_card_sub_head.id_sc_para='24'  ", cnn);
            // cmd = new SqlCommand("SELECT distinct (sch_card_sub_head.id_sc_para), sch_card_head_deatils.sub_head_details,sch_card_sub_head.sub_head,schedule_card_form.id_sc_format ,jos_railway_loco_type_schedule.id_loco_sch, jos_railway_loco_type_schedule.loco_id, jos_railway_loco_type_schedule.s_type,                       jos_railway_loco_type_schedule.duration, sch_card_sub_head.id_sch_card,                       sch_card_sub_head.id_loco_sch AS Expr1,   schedule_card_form.id_section,                       schedule_card_form.id_schedule, schedule_card_form.id_loco, schedule_card_form.id_technician, schedule_card_form.id_supervisor,                       schedule_card_form.w_s_time, schedule_card_form.w_end_time, schedule_card_form.date1, schedule_card_form.id_sch_card AS Expr2,                       schedule_card_form.status, schedule_card_form.action_tak, jos_railway_mst_loco.id_mst_loco, jos_railway_mst_loco.locono,                      jos_railway_mst_loco.tid, jos_railway_mst_loco.shed_id, jos_railway_mst_loco.doc_date, jos_railway_mst_loco.a_time,                       jos_railway_mst_loco.poh_date, jos_railway_mst_loco.native, jos_railway_mst_loco.rfrom, sch_card_head_deatils.id_sd_con,                       sch_card_head_deatils.id_sc_para AS Expr3,  sch_card_form_detail.id_card_form_detail,                       sch_card_form_detail.id_sc_format AS Expr4, sch_card_form_detail.status AS Expr5, sch_card_form_detail.action_taken,                      sch_card_form_detail.staff,schedule_card.id_sch_card,schedule_card.name_sub_section FROM   schedule_card_form   INNER JOIN jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = schedule_card_form.id_schedule INNER JOIN   jos_railway_mst_loco   ON schedule_card_form.id_loco = jos_railway_mst_loco.id_mst_loco INNER JOIN  sch_card_sub_head ON jos_railway_loco_type_schedule.id_loco_sch = sch_card_sub_head.id_loco_sch INNER JOIN  sch_card_head_deatils ON sch_card_sub_head.id_sc_para = sch_card_head_deatils.id_sc_para INNER JOIN  sch_card_form_detail ON sch_card_form_detail.id_sc_format=schedule_card_form.id_sc_format INNER JOIN jos_railway_section ON jos_railway_section.id_section = schedule_card_form.id_section INNER JOIN schedule_card ON schedule_card.id_sch_card=sch_card_sub_head.id_sch_card  where jos_railway_section.id_section='2'and  schedule_card.id_sch_card ='3'and jos_railway_loco_type_schedule.id_loco_sch='" + id_loco_sch + "' ", cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        catch
        { throw; }
    }
    public DataTable Select_SubHead_Detail_undertruk25(string id_loco_sch)
    {
        try
        {
            cmd = new SqlCommand("SELECT jos_railway_loco_type_schedule.id_loco_sch, jos_railway_loco_type_schedule.loco_id, jos_railway_loco_type_schedule.s_type,                       jos_railway_loco_type_schedule.duration, sch_card_head_deatils.id_sd_con, sch_card_head_deatils.id_sc_para,                       sch_card_head_deatils.sub_head_details as sub_head_details , sch_card_sub_head.id_sc_para AS Expr1, sch_card_sub_head.id_sch_card,                       sch_card_sub_head.id_loco_sch AS Expr2, sch_card_sub_head.sub_head, schedule_card.id_sch_card AS Expr3, schedule_card.id_section,                       schedule_card.name_sub_section FROM         jos_railway_loco_type_schedule INNER JOIN                       sch_card_sub_head ON jos_railway_loco_type_schedule.id_loco_sch = sch_card_sub_head.id_loco_sch INNER JOIN                      sch_card_head_deatils ON sch_card_sub_head.id_sc_para = sch_card_head_deatils.id_sc_para INNER JOIN                      schedule_card ON sch_card_sub_head.id_sch_card = schedule_card.id_sch_card where jos_railway_loco_type_schedule.id_loco_sch='" + id_loco_sch + "' and sch_card_sub_head.id_sc_para='25'  ", cnn);
            // cmd = new SqlCommand("SELECT distinct (sch_card_sub_head.id_sc_para), sch_card_head_deatils.sub_head_details,sch_card_sub_head.sub_head,schedule_card_form.id_sc_format ,jos_railway_loco_type_schedule.id_loco_sch, jos_railway_loco_type_schedule.loco_id, jos_railway_loco_type_schedule.s_type,                       jos_railway_loco_type_schedule.duration, sch_card_sub_head.id_sch_card,                       sch_card_sub_head.id_loco_sch AS Expr1,   schedule_card_form.id_section,                       schedule_card_form.id_schedule, schedule_card_form.id_loco, schedule_card_form.id_technician, schedule_card_form.id_supervisor,                       schedule_card_form.w_s_time, schedule_card_form.w_end_time, schedule_card_form.date1, schedule_card_form.id_sch_card AS Expr2,                       schedule_card_form.status, schedule_card_form.action_tak, jos_railway_mst_loco.id_mst_loco, jos_railway_mst_loco.locono,                      jos_railway_mst_loco.tid, jos_railway_mst_loco.shed_id, jos_railway_mst_loco.doc_date, jos_railway_mst_loco.a_time,                       jos_railway_mst_loco.poh_date, jos_railway_mst_loco.native, jos_railway_mst_loco.rfrom, sch_card_head_deatils.id_sd_con,                       sch_card_head_deatils.id_sc_para AS Expr3,  sch_card_form_detail.id_card_form_detail,                       sch_card_form_detail.id_sc_format AS Expr4, sch_card_form_detail.status AS Expr5, sch_card_form_detail.action_taken,                      sch_card_form_detail.staff,schedule_card.id_sch_card,schedule_card.name_sub_section FROM   schedule_card_form   INNER JOIN jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = schedule_card_form.id_schedule INNER JOIN   jos_railway_mst_loco   ON schedule_card_form.id_loco = jos_railway_mst_loco.id_mst_loco INNER JOIN  sch_card_sub_head ON jos_railway_loco_type_schedule.id_loco_sch = sch_card_sub_head.id_loco_sch INNER JOIN  sch_card_head_deatils ON sch_card_sub_head.id_sc_para = sch_card_head_deatils.id_sc_para INNER JOIN  sch_card_form_detail ON sch_card_form_detail.id_sc_format=schedule_card_form.id_sc_format INNER JOIN jos_railway_section ON jos_railway_section.id_section = schedule_card_form.id_section INNER JOIN schedule_card ON schedule_card.id_sch_card=sch_card_sub_head.id_sch_card  where jos_railway_section.id_section='2'and  schedule_card.id_sch_card ='3'and jos_railway_loco_type_schedule.id_loco_sch='" + id_loco_sch + "' ", cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        catch
        { throw; }
    }
    public DataTable Select_SubHead_Detail_undertruk26(string id_loco_sch)
    {
        try
        {
            cmd = new SqlCommand("SELECT jos_railway_loco_type_schedule.id_loco_sch, jos_railway_loco_type_schedule.loco_id, jos_railway_loco_type_schedule.s_type,                       jos_railway_loco_type_schedule.duration, sch_card_head_deatils.id_sd_con, sch_card_head_deatils.id_sc_para,                       sch_card_head_deatils.sub_head_details as sub_head_details , sch_card_sub_head.id_sc_para AS Expr1, sch_card_sub_head.id_sch_card,                       sch_card_sub_head.id_loco_sch AS Expr2, sch_card_sub_head.sub_head, schedule_card.id_sch_card AS Expr3, schedule_card.id_section,                       schedule_card.name_sub_section FROM         jos_railway_loco_type_schedule INNER JOIN                       sch_card_sub_head ON jos_railway_loco_type_schedule.id_loco_sch = sch_card_sub_head.id_loco_sch INNER JOIN                      sch_card_head_deatils ON sch_card_sub_head.id_sc_para = sch_card_head_deatils.id_sc_para INNER JOIN                      schedule_card ON sch_card_sub_head.id_sch_card = schedule_card.id_sch_card where jos_railway_loco_type_schedule.id_loco_sch='" + id_loco_sch + "' and sch_card_sub_head.id_sc_para='26'  ", cnn);
            // cmd = new SqlCommand("SELECT distinct (sch_card_sub_head.id_sc_para), sch_card_head_deatils.sub_head_details,sch_card_sub_head.sub_head,schedule_card_form.id_sc_format ,jos_railway_loco_type_schedule.id_loco_sch, jos_railway_loco_type_schedule.loco_id, jos_railway_loco_type_schedule.s_type,                       jos_railway_loco_type_schedule.duration, sch_card_sub_head.id_sch_card,                       sch_card_sub_head.id_loco_sch AS Expr1,   schedule_card_form.id_section,                       schedule_card_form.id_schedule, schedule_card_form.id_loco, schedule_card_form.id_technician, schedule_card_form.id_supervisor,                       schedule_card_form.w_s_time, schedule_card_form.w_end_time, schedule_card_form.date1, schedule_card_form.id_sch_card AS Expr2,                       schedule_card_form.status, schedule_card_form.action_tak, jos_railway_mst_loco.id_mst_loco, jos_railway_mst_loco.locono,                      jos_railway_mst_loco.tid, jos_railway_mst_loco.shed_id, jos_railway_mst_loco.doc_date, jos_railway_mst_loco.a_time,                       jos_railway_mst_loco.poh_date, jos_railway_mst_loco.native, jos_railway_mst_loco.rfrom, sch_card_head_deatils.id_sd_con,                       sch_card_head_deatils.id_sc_para AS Expr3,  sch_card_form_detail.id_card_form_detail,                       sch_card_form_detail.id_sc_format AS Expr4, sch_card_form_detail.status AS Expr5, sch_card_form_detail.action_taken,                      sch_card_form_detail.staff,schedule_card.id_sch_card,schedule_card.name_sub_section FROM   schedule_card_form   INNER JOIN jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = schedule_card_form.id_schedule INNER JOIN   jos_railway_mst_loco   ON schedule_card_form.id_loco = jos_railway_mst_loco.id_mst_loco INNER JOIN  sch_card_sub_head ON jos_railway_loco_type_schedule.id_loco_sch = sch_card_sub_head.id_loco_sch INNER JOIN  sch_card_head_deatils ON sch_card_sub_head.id_sc_para = sch_card_head_deatils.id_sc_para INNER JOIN  sch_card_form_detail ON sch_card_form_detail.id_sc_format=schedule_card_form.id_sc_format INNER JOIN jos_railway_section ON jos_railway_section.id_section = schedule_card_form.id_section INNER JOIN schedule_card ON schedule_card.id_sch_card=sch_card_sub_head.id_sch_card  where jos_railway_section.id_section='2'and  schedule_card.id_sch_card ='3'and jos_railway_loco_type_schedule.id_loco_sch='" + id_loco_sch + "' ", cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        catch
        { throw; }
    }
    public DataTable Select_SubHead_Detail_undertruk27(string id_loco_sch)
    {
        try
        {
            cmd = new SqlCommand("SELECT jos_railway_loco_type_schedule.id_loco_sch, jos_railway_loco_type_schedule.loco_id, jos_railway_loco_type_schedule.s_type,                       jos_railway_loco_type_schedule.duration, sch_card_head_deatils.id_sd_con, sch_card_head_deatils.id_sc_para,                       sch_card_head_deatils.sub_head_details as sub_head_details , sch_card_sub_head.id_sc_para AS Expr1, sch_card_sub_head.id_sch_card,                       sch_card_sub_head.id_loco_sch AS Expr2, sch_card_sub_head.sub_head, schedule_card.id_sch_card AS Expr3, schedule_card.id_section,                       schedule_card.name_sub_section FROM         jos_railway_loco_type_schedule INNER JOIN                       sch_card_sub_head ON jos_railway_loco_type_schedule.id_loco_sch = sch_card_sub_head.id_loco_sch INNER JOIN                      sch_card_head_deatils ON sch_card_sub_head.id_sc_para = sch_card_head_deatils.id_sc_para INNER JOIN                      schedule_card ON sch_card_sub_head.id_sch_card = schedule_card.id_sch_card where jos_railway_loco_type_schedule.id_loco_sch='" + id_loco_sch + "' and sch_card_sub_head.id_sc_para='27'  ", cnn);
            // cmd = new SqlCommand("SELECT distinct (sch_card_sub_head.id_sc_para), sch_card_head_deatils.sub_head_details,sch_card_sub_head.sub_head,schedule_card_form.id_sc_format ,jos_railway_loco_type_schedule.id_loco_sch, jos_railway_loco_type_schedule.loco_id, jos_railway_loco_type_schedule.s_type,                       jos_railway_loco_type_schedule.duration, sch_card_sub_head.id_sch_card,                       sch_card_sub_head.id_loco_sch AS Expr1,   schedule_card_form.id_section,                       schedule_card_form.id_schedule, schedule_card_form.id_loco, schedule_card_form.id_technician, schedule_card_form.id_supervisor,                       schedule_card_form.w_s_time, schedule_card_form.w_end_time, schedule_card_form.date1, schedule_card_form.id_sch_card AS Expr2,                       schedule_card_form.status, schedule_card_form.action_tak, jos_railway_mst_loco.id_mst_loco, jos_railway_mst_loco.locono,                      jos_railway_mst_loco.tid, jos_railway_mst_loco.shed_id, jos_railway_mst_loco.doc_date, jos_railway_mst_loco.a_time,                       jos_railway_mst_loco.poh_date, jos_railway_mst_loco.native, jos_railway_mst_loco.rfrom, sch_card_head_deatils.id_sd_con,                       sch_card_head_deatils.id_sc_para AS Expr3,  sch_card_form_detail.id_card_form_detail,                       sch_card_form_detail.id_sc_format AS Expr4, sch_card_form_detail.status AS Expr5, sch_card_form_detail.action_taken,                      sch_card_form_detail.staff,schedule_card.id_sch_card,schedule_card.name_sub_section FROM   schedule_card_form   INNER JOIN jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = schedule_card_form.id_schedule INNER JOIN   jos_railway_mst_loco   ON schedule_card_form.id_loco = jos_railway_mst_loco.id_mst_loco INNER JOIN  sch_card_sub_head ON jos_railway_loco_type_schedule.id_loco_sch = sch_card_sub_head.id_loco_sch INNER JOIN  sch_card_head_deatils ON sch_card_sub_head.id_sc_para = sch_card_head_deatils.id_sc_para INNER JOIN  sch_card_form_detail ON sch_card_form_detail.id_sc_format=schedule_card_form.id_sc_format INNER JOIN jos_railway_section ON jos_railway_section.id_section = schedule_card_form.id_section INNER JOIN schedule_card ON schedule_card.id_sch_card=sch_card_sub_head.id_sch_card  where jos_railway_section.id_section='2'and  schedule_card.id_sch_card ='3'and jos_railway_loco_type_schedule.id_loco_sch='" + id_loco_sch + "' ", cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        catch
        { throw; }
    }
    public DataTable Select_SubHead_Detail_undertruk28(string id_loco_sch)
    {
        try
        {
            cmd = new SqlCommand("SELECT jos_railway_loco_type_schedule.id_loco_sch, jos_railway_loco_type_schedule.loco_id, jos_railway_loco_type_schedule.s_type,                       jos_railway_loco_type_schedule.duration, sch_card_head_deatils.id_sd_con, sch_card_head_deatils.id_sc_para,                       sch_card_head_deatils.sub_head_details as sub_head_details , sch_card_sub_head.id_sc_para AS Expr1, sch_card_sub_head.id_sch_card,                       sch_card_sub_head.id_loco_sch AS Expr2, sch_card_sub_head.sub_head, schedule_card.id_sch_card AS Expr3, schedule_card.id_section,                       schedule_card.name_sub_section FROM         jos_railway_loco_type_schedule INNER JOIN                       sch_card_sub_head ON jos_railway_loco_type_schedule.id_loco_sch = sch_card_sub_head.id_loco_sch INNER JOIN                      sch_card_head_deatils ON sch_card_sub_head.id_sc_para = sch_card_head_deatils.id_sc_para INNER JOIN                      schedule_card ON sch_card_sub_head.id_sch_card = schedule_card.id_sch_card where jos_railway_loco_type_schedule.id_loco_sch='" + id_loco_sch + "' and sch_card_sub_head.id_sc_para='28'  ", cnn);
            // cmd = new SqlCommand("SELECT distinct (sch_card_sub_head.id_sc_para), sch_card_head_deatils.sub_head_details,sch_card_sub_head.sub_head,schedule_card_form.id_sc_format ,jos_railway_loco_type_schedule.id_loco_sch, jos_railway_loco_type_schedule.loco_id, jos_railway_loco_type_schedule.s_type,                       jos_railway_loco_type_schedule.duration, sch_card_sub_head.id_sch_card,                       sch_card_sub_head.id_loco_sch AS Expr1,   schedule_card_form.id_section,                       schedule_card_form.id_schedule, schedule_card_form.id_loco, schedule_card_form.id_technician, schedule_card_form.id_supervisor,                       schedule_card_form.w_s_time, schedule_card_form.w_end_time, schedule_card_form.date1, schedule_card_form.id_sch_card AS Expr2,                       schedule_card_form.status, schedule_card_form.action_tak, jos_railway_mst_loco.id_mst_loco, jos_railway_mst_loco.locono,                      jos_railway_mst_loco.tid, jos_railway_mst_loco.shed_id, jos_railway_mst_loco.doc_date, jos_railway_mst_loco.a_time,                       jos_railway_mst_loco.poh_date, jos_railway_mst_loco.native, jos_railway_mst_loco.rfrom, sch_card_head_deatils.id_sd_con,                       sch_card_head_deatils.id_sc_para AS Expr3,  sch_card_form_detail.id_card_form_detail,                       sch_card_form_detail.id_sc_format AS Expr4, sch_card_form_detail.status AS Expr5, sch_card_form_detail.action_taken,                      sch_card_form_detail.staff,schedule_card.id_sch_card,schedule_card.name_sub_section FROM   schedule_card_form   INNER JOIN jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = schedule_card_form.id_schedule INNER JOIN   jos_railway_mst_loco   ON schedule_card_form.id_loco = jos_railway_mst_loco.id_mst_loco INNER JOIN  sch_card_sub_head ON jos_railway_loco_type_schedule.id_loco_sch = sch_card_sub_head.id_loco_sch INNER JOIN  sch_card_head_deatils ON sch_card_sub_head.id_sc_para = sch_card_head_deatils.id_sc_para INNER JOIN  sch_card_form_detail ON sch_card_form_detail.id_sc_format=schedule_card_form.id_sc_format INNER JOIN jos_railway_section ON jos_railway_section.id_section = schedule_card_form.id_section INNER JOIN schedule_card ON schedule_card.id_sch_card=sch_card_sub_head.id_sch_card  where jos_railway_section.id_section='2'and  schedule_card.id_sch_card ='3'and jos_railway_loco_type_schedule.id_loco_sch='" + id_loco_sch + "' ", cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        catch
        { throw; }
    }
    public DataTable Select_SubHead_Detail_undertruk29(string id_loco_sch)
    {
        try
        {
            cmd = new SqlCommand("SELECT jos_railway_loco_type_schedule.id_loco_sch, jos_railway_loco_type_schedule.loco_id, jos_railway_loco_type_schedule.s_type,                       jos_railway_loco_type_schedule.duration, sch_card_head_deatils.id_sd_con, sch_card_head_deatils.id_sc_para,                       sch_card_head_deatils.sub_head_details as sub_head_details , sch_card_sub_head.id_sc_para AS Expr1, sch_card_sub_head.id_sch_card,                       sch_card_sub_head.id_loco_sch AS Expr2, sch_card_sub_head.sub_head, schedule_card.id_sch_card AS Expr3, schedule_card.id_section,                       schedule_card.name_sub_section FROM         jos_railway_loco_type_schedule INNER JOIN                       sch_card_sub_head ON jos_railway_loco_type_schedule.id_loco_sch = sch_card_sub_head.id_loco_sch INNER JOIN                      sch_card_head_deatils ON sch_card_sub_head.id_sc_para = sch_card_head_deatils.id_sc_para INNER JOIN                      schedule_card ON sch_card_sub_head.id_sch_card = schedule_card.id_sch_card where jos_railway_loco_type_schedule.id_loco_sch='" + id_loco_sch + "' and sch_card_sub_head.id_sc_para='29'  ", cnn);
            // cmd = new SqlCommand("SELECT distinct (sch_card_sub_head.id_sc_para), sch_card_head_deatils.sub_head_details,sch_card_sub_head.sub_head,schedule_card_form.id_sc_format ,jos_railway_loco_type_schedule.id_loco_sch, jos_railway_loco_type_schedule.loco_id, jos_railway_loco_type_schedule.s_type,                       jos_railway_loco_type_schedule.duration, sch_card_sub_head.id_sch_card,                       sch_card_sub_head.id_loco_sch AS Expr1,   schedule_card_form.id_section,                       schedule_card_form.id_schedule, schedule_card_form.id_loco, schedule_card_form.id_technician, schedule_card_form.id_supervisor,                       schedule_card_form.w_s_time, schedule_card_form.w_end_time, schedule_card_form.date1, schedule_card_form.id_sch_card AS Expr2,                       schedule_card_form.status, schedule_card_form.action_tak, jos_railway_mst_loco.id_mst_loco, jos_railway_mst_loco.locono,                      jos_railway_mst_loco.tid, jos_railway_mst_loco.shed_id, jos_railway_mst_loco.doc_date, jos_railway_mst_loco.a_time,                       jos_railway_mst_loco.poh_date, jos_railway_mst_loco.native, jos_railway_mst_loco.rfrom, sch_card_head_deatils.id_sd_con,                       sch_card_head_deatils.id_sc_para AS Expr3,  sch_card_form_detail.id_card_form_detail,                       sch_card_form_detail.id_sc_format AS Expr4, sch_card_form_detail.status AS Expr5, sch_card_form_detail.action_taken,                      sch_card_form_detail.staff,schedule_card.id_sch_card,schedule_card.name_sub_section FROM   schedule_card_form   INNER JOIN jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = schedule_card_form.id_schedule INNER JOIN   jos_railway_mst_loco   ON schedule_card_form.id_loco = jos_railway_mst_loco.id_mst_loco INNER JOIN  sch_card_sub_head ON jos_railway_loco_type_schedule.id_loco_sch = sch_card_sub_head.id_loco_sch INNER JOIN  sch_card_head_deatils ON sch_card_sub_head.id_sc_para = sch_card_head_deatils.id_sc_para INNER JOIN  sch_card_form_detail ON sch_card_form_detail.id_sc_format=schedule_card_form.id_sc_format INNER JOIN jos_railway_section ON jos_railway_section.id_section = schedule_card_form.id_section INNER JOIN schedule_card ON schedule_card.id_sch_card=sch_card_sub_head.id_sch_card  where jos_railway_section.id_section='2'and  schedule_card.id_sch_card ='3'and jos_railway_loco_type_schedule.id_loco_sch='" + id_loco_sch + "' ", cnn);
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
