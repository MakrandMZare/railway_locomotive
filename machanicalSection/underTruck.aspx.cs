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

public partial class machanicalSection_underTruck : System.Web.UI.Page
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
        c.id_sc_format = m.ToString();
        c.loc_rt1 = TextBox36.Text;
        c.loc_rt2 = TextBox37.Text;
        c.loc_rt3 = TextBox38.Text;
        c.loc_rt4 = TextBox39.Text;
        c.loc_lt1 = TextBox40.Text;
        c.loc_lt2 = TextBox41.Text;
        c.loc_lt3 = TextBox42.Text;
        c.loc_lt4 = TextBox43.Text;
        c.oil_level1 = TextBox44.Text;
        c.oil_level2 = TextBox45.Text;
        c.oil_level3 = TextBox46.Text;
        c.oil_level4 = TextBox47.Text;
        c.oil_level5 = TextBox48.Text;
        c.oil_level6 = TextBox49.Text;
        c.total_oilAdded = TextBox50.Text;
        c.hl1 = TextBox1.Text;
        c.hr1 = TextBox2.Text;
        c.hl2 = TextBox3.Text;
        c.hr2 = TextBox4.Text;
        c.ll1 = TextBox5.Text;
        c.lr1 = TextBox6.Text;
        c.ll2 = TextBox7.Text;
        c.lr2 = TextBox8.Text;


        c.rl1 = TextBox9.Text;
        c.rr1 = TextBox14.Text;
        c.cl2 = TextBox15.Text;
        c.cr2 = TextBox16.Text;
        c.lh1 = TextBox17.Text;
        c.lh2 = TextBox18.Text;
        c.lh3 = TextBox19.Text;
        c.lh4 = TextBox20.Text;
        c.lh5 = TextBox21.Text;
        c.lh6 = TextBox22.Text;
        c.rh1 = TextBox23.Text;
        c.rh2 = TextBox24.Text;
        c.rh3 = TextBox25.Text;
        c.rh4 = TextBox26.Text;
        c.rh5 = TextBox27.Text;
        c.rh6 = TextBox28.Text;
        c.thrust1 = TextBox29.Text;
        c.thrust2 = TextBox30.Text;
        c.thrust3 = TextBox31.Text;
        c.thrust4 = TextBox32.Text;
        c.thrust5 = TextBox33.Text;
        c.thrust6 = TextBox34.Text;
        c.TestedInLab = TextBox35.Text;
        c.Insert_unsertruk();
        //-----------------------------------------------------------------------------------20
        foreach (GridViewRow gr in gv20.Rows)
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

        //-----------------------------------------------------------------------------------21
        foreach (GridViewRow gr in gv21.Rows)
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
        }//-----------------------------------------------------------------------------------22
        foreach (GridViewRow gr in gv22.Rows)
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
        }//-----------------------------------------------------------------------------------23
        foreach (GridViewRow gr in gv23.Rows)
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
        }//----------------------------------------------------------------------------------24
        foreach (GridViewRow gr in gv24.Rows)
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
        }//-----------------------------------------------------------------------------------25
        foreach (GridViewRow gr in gv25.Rows)
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
        }//-----------------------------------------------------------------------------------26
        foreach (GridViewRow gr in gv26.Rows)
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
        }//-----------------------------------------------------------------------------------27
        foreach (GridViewRow gr in gv27.Rows)
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
        }//-----------------------------------------------------------------------------------28
        foreach (GridViewRow gr in gv28.Rows)
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
        }//-----------------------------------------------------------------------------------29
        foreach (GridViewRow gr in gv29.Rows)
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
        //----------------------------------------------------------------------20
        gv20.DataSource = c.Select_SubHead_Detail_undertruk20(ddlSchedule.SelectedValue.ToString());
        gv20.DataBind();
        //----------------------------------------------------------------------21
        gv21.DataSource = c.Select_SubHead_Detail_undertruk21(ddlSchedule.SelectedValue.ToString());
        gv21.DataBind();
        //----------------------------------------------------------------------22
        gv22.DataSource = c.Select_SubHead_Detail_undertruk22(ddlSchedule.SelectedValue.ToString());
        gv22.DataBind();
        //----------------------------------------------------------------------23
        gv23.DataSource = c.Select_SubHead_Detail_undertruk23(ddlSchedule.SelectedValue.ToString());
        gv23.DataBind();
        //----------------------------------------------------------------------24
        gv24.DataSource = c.Select_SubHead_Detail_undertruk24(ddlSchedule.SelectedValue.ToString());
        gv24.DataBind();
        //----------------------------------------------------------------------25
        gv25.DataSource = c.Select_SubHead_Detail_undertruk25(ddlSchedule.SelectedValue.ToString());
        gv25.DataBind();
        //----------------------------------------------------------------------26
        gv26.DataSource = c.Select_SubHead_Detail_undertruk26(ddlSchedule.SelectedValue.ToString());
        gv26.DataBind();
        //----------------------------------------------------------------------27
        gv27.DataSource = c.Select_SubHead_Detail_undertruk27(ddlSchedule.SelectedValue.ToString());
        gv27.DataBind();
        //----------------------------------------------------------------------28
        gv28.DataSource = c.Select_SubHead_Detail_undertruk28(ddlSchedule.SelectedValue.ToString());
        gv28.DataBind();
        //----------------------------------------------------------------------29
        gv29.DataSource = c.Select_SubHead_Detail_undertruk29(ddlSchedule.SelectedValue.ToString());
        gv29.DataBind();

    }

    protected void gv1_OnRowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {

        }
    }

}