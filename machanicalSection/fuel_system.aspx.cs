using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Railway;
using System.Data.SqlClient;

public partial class machanicalSection_fuel_system : System.Web.UI.Page
{
    Cls_airbreak c = new Cls_airbreak();
    public void Fill_Schedule()
    {
        ddlSchedule.DataSource = c.Select_Schedule();
        ddlSchedule.DataTextField = "s_type";
        ddlSchedule.DataValueField = "id_loco_sch";
        ddlSchedule.DataBind();
        ddlSchedule.Items.Insert(0, "SELECT");
    }
    public void Fill_Card()
    {
        if (ddlSection.SelectedIndex != 0)
        {


            ddlCard.DataSource = c.Select_ScheduleCard(ddlSection.SelectedValue.ToString());
            ddlCard.DataTextField = "name_sub_section";
            ddlCard.DataValueField = "id_sch_card";
            ddlCard.DataBind();
            ddlCard.Items.Insert(0, "SELECT");
        }
    }
    //public void Fill_SubHead()
    //{
    //    if (ddlCard.SelectedIndex != 0)
    //    {
    //        ddlSubHead.DataSource = c.Select_sub_head(ddlCard.SelectedValue.ToString());
    //        ddlSubHead.DataTextField = "sub_head";
    //        ddlSubHead.DataValueField = "id_sc_para";
    //        ddlSubHead.DataBind();
    //        ddlSubHead.Items.Insert(0, "SELECT");
    //    }
    //}
    //public void Fill_SubCard_detail()
    //{
    //    ddlHeadDetail.DataSource = c.Select_sub_head_Deatil();
    //    ddlHeadDetail.DataTextField = "sub_head_details";
    //    ddlHeadDetail.DataValueField = "id_sd_con";
    //    ddlHeadDetail.DataBind();
    //    ddlHeadDetail.Items.Insert(0, "SELECT");
    //}
    public void Fill_HR()
    {
        ddlHr.DataSource = c.Select_hr();
        ddlHr.DataTextField = "surname";
        ddlHr.DataValueField = "id_hr";
        ddlHr.DataBind();
        ddlHr.Items.Insert(0, "SELECT");
    }
    public void Fill_HR2()
    {
        ddlhr2.DataSource = c.Select_hr();
        ddlhr2.DataTextField = "surname";
        ddlhr2.DataValueField = "id_hr";
        ddlhr2.DataBind();
        ddlhr2.Items.Insert(0, "SELECT");
    }
    public void Fill_section()
    {
        ddlSection.DataSource = c.Select_section();
        ddlSection.DataTextField = "f_name";
        ddlSection.DataValueField = "id_section";
        ddlSection.DataBind();
        ddlSection.Items.Insert(0, "SELECT");
    }
    public void Fill_Class()
    {
        Cls_jos_railway_loco_in obj = new Cls_jos_railway_loco_in();
        ddlClass.DataSource = obj.SelectLocoType();
        ddlClass.DataTextField = "loco_type";
        ddlClass.DataValueField = "id_ltype";
        ddlClass.DataBind();
        ddlClass.Items.Insert(0, "SELECT");
    }
    public void Fill_LocoNo()
    {
        if (ddlClass.SelectedIndex != 0)
        {
            Cls_jos_railway_loco_in obj = new Cls_jos_railway_loco_in();
            ddlLocono.DataSource = obj.Select_LocoNo(ddlClass.SelectedValue.ToString());
            ddlLocono.DataTextField = "locono";
            ddlLocono.DataValueField = "id_mst_loco";
            ddlLocono.DataBind();
            ddlLocono.Items.Insert(0, "SELECT");
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Fill_Schedule();


            //   Fill_SubCard_detail();
            Fill_section();
            Fill_Class();
            Fill_HR();
            Fill_HR2();


        }
    }
    protected void ddlClass_SelectedIndexChanged(object sender, EventArgs e)
    {
        Fill_LocoNo();
    }
    protected void btnInsert_Click(object sender, EventArgs e)
    {
        c.id_section = ddlSection.SelectedValue.ToString();
        c.id_schedule = ddlSchedule.SelectedValue.ToString();
        c.id_loco = ddlLocono.SelectedValue.ToString();
        c.id_technician = ddlHr.SelectedValue.ToString();
        c.id_supervisor = ddlhr2.SelectedValue.ToString();
        c.w_s_time = txtstart.Text;
        c.w_end_time = txtfinish.Text;
        c.date1 = txtdate.Text;
        c.id_sch_card = ddlCard.SelectedValue.ToString();
        //c.id_sc_para=ddlSubHead.SelectedValue.ToString();
        //c.id_sd_con=ddlHeadDetail.SelectedValue.ToString();



        Int64 m = c.Select_MaxID();
        //-----------------------------------------------------------------------------------1
        foreach (GridViewRow gr in gv1.Rows)
        {

            TextBox t1 = new TextBox();
            TextBox t2 = new TextBox();
            t1 = (TextBox)gr.FindControl("txt1");
            t2 = (TextBox)gr.FindControl("txt2");

            if (t1 != null && t2 != null)
            {
                string str1 = t1.Text.ToString();
                string str2 = t2.Text.ToString();



                //    Cls_Sch_card_form_detail c. = new Cls_Sch_card_form_detail();
                c.id_sc_format = m.ToString();
                c.status = t1.Text;
                c.action_tak = t2.Text;
                c.Insert_Data();

            }
        }



        c.Insert_Data();

        clear_data();
        Label1.Visible = true;
        //Response.Redirect("~/machanicalSection/fuel_system.aspx");
        
    }

    public void clear_data()
    {
        ddlSection.SelectedIndex = 0;
        ddlSchedule.SelectedIndex = 0;
        ddlLocono.SelectedIndex = 0;
        ddlHr.SelectedIndex = 0;
        ddlhr2.SelectedIndex = 0;
        txtstart.Text = "";
        txtfinish.Text = "";
        txtdate.Text = "";
        ddlCard.SelectedIndex = 0;
        //ddlSubHead.SelectedIndex = 0;
        //ddlHeadDetail.SelectedIndex = 0;

    }
    protected void ddlHeadDetail_SelectedIndexChanged(object sender, EventArgs e)
    {
        //    gv1.DataSource = c.Select_sub_head_Deatil();
        //    gv1.DataBind();
    }
    protected void ddlSection_SelectedIndexChanged(object sender, EventArgs e)
    {
        Fill_Card();
    }
    protected void ddlSubHead_SelectedIndexChanged(object sender, EventArgs e)
    {
        // Fill_SubHead();
    }
    protected void ddlCard_SelectedIndexChanged(object sender, EventArgs e)
    {
        // Fill_SubHead();
    }
    protected void ddlSchedule_SelectedIndexChanged(object sender, EventArgs e)
    {
        //gv1.DataSource = c.Select_section();
        //----------------------------------------------------------------------
        gv1.DataSource = c.Select_SubHead_Detail_fuelsystem(ddlSchedule.SelectedValue.ToString());

        gv1.DataBind();

    }


    protected void gv1_OnRowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {

        }
    }

//SELECT distinct (sch_card_sub_head.id_sc_para), sch_card_head_deatils.sub_head_details,sch_card_sub_head.sub_head,schedule_card_form.id_sc_format ,jos_railway_loco_type_schedule.id_loco_sch, jos_railway_loco_type_schedule.loco_id, jos_railway_loco_type_schedule.s_type, 
//                      jos_railway_loco_type_schedule.duration, sch_card_sub_head.id_sch_card, 
//                      sch_card_sub_head.id_loco_sch AS Expr1,   schedule_card_form.id_section, 
//                      schedule_card_form.id_schedule, schedule_card_form.id_loco, schedule_card_form.id_technician, schedule_card_form.id_supervisor, 
//                      schedule_card_form.w_s_time, schedule_card_form.w_end_time, schedule_card_form.date1, schedule_card_form.id_sch_card AS Expr2, 
//                      schedule_card_form.status, schedule_card_form.action_tak, jos_railway_mst_loco.id_mst_loco, jos_railway_mst_loco.locono, 
//                      jos_railway_mst_loco.tid, jos_railway_mst_loco.shed_id, jos_railway_mst_loco.doc_date, jos_railway_mst_loco.a_time, 
//                      jos_railway_mst_loco.poh_date, jos_railway_mst_loco.native, jos_railway_mst_loco.rfrom, sch_card_head_deatils.id_sd_con, 
//                      sch_card_head_deatils.id_sc_para AS Expr3,  sch_card_form_detail.id_card_form_detail, 
//                      sch_card_form_detail.id_sc_format AS Expr4, sch_card_form_detail.status AS Expr5, sch_card_form_detail.action_taken, 
//                      sch_card_form_detail.staff,
//schedule_card.id_sch_card,schedule_card.name_sub_section
//FROM   schedule_card_form   
//INNER JOIN jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = schedule_card_form.id_schedule 
//INNER JOIN   jos_railway_mst_loco   ON schedule_card_form.id_loco = jos_railway_mst_loco.id_mst_loco 
//INNER JOIN  sch_card_sub_head ON jos_railway_loco_type_schedule.id_loco_sch = sch_card_sub_head.id_loco_sch 
//INNER JOIN  sch_card_head_deatils ON sch_card_sub_head.id_sc_para = sch_card_head_deatils.id_sc_para 
//INNER JOIN  sch_card_form_detail ON sch_card_form_detail.id_sc_format=schedule_card_form.id_sc_format
//INNER JOIN jos_railway_section ON jos_railway_section.id_section = schedule_card_form.id_section
//INNER JOIN schedule_card ON schedule_card.id_sch_card=sch_card_sub_head.id_sch_card
// where jos_railway_section.id_section='2'and jos_railway_loco_type_schedule.id_loco_sch='15'
//and schedule_card.id_sch_card ='3'


//----------------------------------

// 1 true
//select 
//schedule_card_form.id_sc_format,schedule_card_form.id_section,
//schedule_card_form.id_schedule,schedule_card_form.id_loco,
//schedule_card_form.id_technician,schedule_card_form.id_supervisor,
//schedule_card_form.w_s_time,schedule_card_form.w_end_time,
//schedule_card_form.date1,schedule_card_form.id_sch_card,
//sch_card_form_detail.id_card_form_detail,sch_card_form_detail.id_sc_format,
//sch_card_form_detail.status,sch_card_form_detail.action_taken,sch_card_form_detail.staff,
//schedule_card.name_sub_section
//from schedule_card_form
//INNER JOIN sch_card_form_detail ON sch_card_form_detail.id_sc_format=schedule_card_form.id_sc_format
//INNER JOIN jos_railway_section ON jos_railway_section.id_section=schedule_card_form.id_section
//INNER JOIN jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch= schedule_card_form.id_schedule
//INNER JOIN schedule_card ON schedule_card.id_sch_card=schedule_card_form.id_sch_card
//INNER JOIN sch_card_sub_head ON sch_card_sub_head.id_sc_para=schedule_card_form.id_sch_card
//where schedule_card_form.id_schedule='15' and jos_railway_section.id_section='2' and
//schedule_card.name_sub_section='3'
}
