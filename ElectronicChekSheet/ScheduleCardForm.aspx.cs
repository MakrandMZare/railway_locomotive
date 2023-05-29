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
using System.Data.SqlClient;
using Railway;


public partial class ElectronicChekSheet_ScheduleCardForm : System.Web.UI.Page
{

    Cls_Card_Form c = new Cls_Card_Form();
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
        foreach (GridViewRow gr in gvControlStand.Rows)
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


        //-----------------------------------------------------------------------------------2
        foreach (GridViewRow gr in gvECC1.Rows)
        {

            TextBox t3 = new TextBox();
            TextBox t4 = new TextBox();
            t3 = (TextBox)gr.FindControl("txt1");
            t4 = (TextBox)gr.FindControl("txt2");

            //if (t3 != null && t4 != null)
            //{
                string str3 = t3.Text.ToString();
                string str4 = t4.Text.ToString();



                //Cls_Sch_card_form_detail c. = new Cls_Sch_card_form_detail();
                c.id_sc_format= m.ToString();
                c.status = t3.Text;
                c.action_tak = t4.Text;
                c.Insert_Data();
                //c.Insert_Sch_card_form_detail();

            //}
        }



        //-----------------------------------------------------------------------------------3
        foreach (GridViewRow gr in gvECC2.Rows)
        {

            TextBox t5 = new TextBox();
            TextBox t6 = new TextBox();
            t5 = (TextBox)gr.FindControl("txt1");
            t6 = (TextBox)gr.FindControl("txt2");

            //if (t5 != null && t6 != null)
            //{
                string str5 = t5.Text.ToString();
                string str6 = t6.Text.ToString();



                //  Cls_Sch_card_form_detail c. = new Cls_Sch_card_form_detail();
              c.id_sc_format = m.ToString();
                c.status = t5.Text;
                c.action_tak = t6.Text;
                c.Insert_Data();

            //}
        }



        //-----------------------------------------------------------------------------------4
        foreach (GridViewRow gr in gvECC3.Rows)
        {

            TextBox t7 = new TextBox();
            TextBox t8 = new TextBox();
            t7 = (TextBox)gr.FindControl("txt1");
            t8 = (TextBox)gr.FindControl("txt2");

            //if (t7 != null && t8 != null)
            //{
                string str1 = t7.Text.ToString();
                string str2 = t8.Text.ToString();



                //  Cls_Sch_card_form_detail c. = new Cls_Sch_card_form_detail();
           c.id_sc_format = m.ToString();
                c.status = t7.Text;
                c.action_tak = t8.Text;
                c.Insert_Data();

            //}
        }



        //-----------------------------------------------------------------------------------5
        foreach (GridViewRow gr in gvMiscell.Rows)
        {

            TextBox t9 = new TextBox();
            TextBox t10 = new TextBox();
            t9 = (TextBox)gr.FindControl("txt1");
            t10 = (TextBox)gr.FindControl("txt2");

            //if (t9 != null && t10 != null)
            //{
                string str9 = t9.Text.ToString();
                string str10 = t10.Text.ToString();



                //   Cls_Sch_card_form_detail c. = new Cls_Sch_card_form_detail();
                c.id_sc_format = m.ToString();
                c.status = t9.Text;
                c.action_tak = t10.Text;
                c.Insert_Data();
            //}
        }


        c.Insert_Data();

        clear_data();
        Response.Redirect("~\\ElectronicChekSheet\\ScheduleCardForm.aspx");
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
        gvControlStand.DataSource = c.Select_SubHead_Detail_Control_Stand(ddlSchedule.SelectedValue.ToString());
        gvControlStand.DataBind();
        //----------------------------------------------------------------------
        gvECC1.DataSource = c.Select_SubHead_Detail_ECC1(ddlSchedule.SelectedValue.ToString());
        gvECC1.DataBind();
        //----------------------------------------------------------------------
        gvECC2.DataSource = c.Select_SubHead_Detail_ECC2(ddlSchedule.SelectedValue.ToString());
        gvECC2.DataBind();
        //----------------------------------------------------------------------
        gvECC3.DataSource = c.Select_SubHead_Detail_ECC3(ddlSchedule.SelectedValue.ToString());
        gvECC3.DataBind();
        //----------------------------------------------------------------------
        gvMiscell.DataSource = c.Select_SubHead_Detail_Miscell(ddlSchedule.SelectedValue.ToString());
        gvMiscell.DataBind();
        //----------------------------------------------------------------------


    }


    protected void gv1_OnRowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {

        }
    }

}
