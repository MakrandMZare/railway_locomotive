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

public partial class battery_section_battery_yearly : System.Web.UI.Page
{
    Cls_Battery_section c = new Cls_Battery_section();
    Cls_Card_Form cc = new Cls_Card_Form();
    public void Fill_section()
    {
        ddlSection.DataSource = cc.Select_section();
        ddlSection.DataTextField = "f_name";
        ddlSection.DataValueField = "id_section";
        ddlSection.DataBind();
        ddlSection.Items.Insert(0, "SELECT");
    }
    public void Fill_Card()
    {
        if (ddlSection.SelectedIndex != 0)
        {


            ddlCard.DataSource = cc.Select_ScheduleCard(ddlSection.SelectedValue.ToString());
            ddlCard.DataTextField = "name_sub_section";
            ddlCard.DataValueField = "id_sch_card";
            ddlCard.DataBind();
            ddlCard.Items.Insert(0, "SELECT");
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Fill_Class();
            Fill_section();
        }
    }
    protected void ddlClass_SelectedIndexChanged(object sender, EventArgs e)
    {
        Fill_LocoNo();
    }
    protected void ddlLocono_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        Fill_Schedule();
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {

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
    public void Fill_Schedule()
    {
        ddlSchedule.Items.Clear();
        Cls_jos_railway_loco_type_schedule c = new Cls_jos_railway_loco_type_schedule();
        c.loco_id = ddlClass.SelectedValue.ToString();
        ddlSchedule.DataSource = c.Select_Data();
        ddlSchedule.DataTextField = "Schedule_Type";
        ddlSchedule.DataValueField = "id_loco_sch";
        ddlSchedule.DataBind();
        ddlSchedule.Items.Insert(0, "SELECT");
    }
    protected void btnInsert_Click(object sender, EventArgs e)
    {
        c.id_loco_sch = ddlSchedule.SelectedValue.ToString();
        c.id_mst_loco = ddlLocono.SelectedValue.ToString();
        c.date1 = txtdate.Text.Substring(3,2)+"/"+txtdate.Text.Substring(0,2)+"/"+txtdate.Text.Substring(6,4);
        c.techni = txtTech.Text;
        c.wkstart = txtstart.Text;
        c.wkend = txtfinish.Text;
        c.super = txtSuper.Text;
        c.r8 = TextBox6.Text;
        c.r9 = TextBox7.Text;
        c.r10 = TextBox8.Text;
        c.r11 = TextBox9.Text;
        c.r12 = TextBox10.Text;
        c.r13 = TextBox11.Text;
        c.r14 = TextBox12.Text;
        c.r15 = TextBox13.Text;
        c.r16 = TextBox14.Text;
        c.r17 = TextBox15.Text;

        c.r18_11 = TextBox16.Text;
        c.r18_12 = TextBox17.Text;
        c.r18_13 = TextBox18.Text;
        c.r18_14 = TextBox19.Text;
        c.r18_15 = TextBox20.Text;
        c.r18_16 = TextBox21.Text;
        c.r18_17 = TextBox22.Text;
        c.r18_18 = TextBox23.Text;
        c.r18_19 = TextBox24.Text;
        c.r18_110 = TextBox25.Text;

        c.r18_21 = TextBox26.Text;
        c.r18_22 = TextBox27.Text;
        c.r18_23 = TextBox28.Text;
        c.r18_24 = TextBox29.Text;
        c.r18_25 = TextBox30.Text;
        c.r18_26 = TextBox31.Text;
        c.r18_27 = TextBox32.Text;
        c.r18_28 = TextBox33.Text;
        c.r18_29 = TextBox34.Text;
        c.r18_210 = TextBox35.Text;

        c.r18_31 = TextBox36.Text;
        c.r18_32 = TextBox37.Text;
        c.r18_33 = TextBox38.Text;
        c.r18_34 = TextBox39.Text;
        c.r18_35 = TextBox40.Text;
        c.r18_36 = TextBox41.Text;
        c.r18_37 = TextBox42.Text;
        c.r18_38 = TextBox43.Text;
        c.r18_39 = TextBox44.Text;
        c.r18_310 = TextBox45.Text;

        c.r18_41 = TextBox46.Text;
        c.r18_42 = TextBox47.Text;
        c.r18_43 = TextBox48.Text;
        c.r18_44 = TextBox49.Text;
        c.r18_45 = TextBox50.Text;
        c.r18_46 = TextBox51.Text;
        c.r18_47 = TextBox52.Text;
        c.r18_48 = TextBox53.Text;
        c.r18_49 = TextBox54.Text;
        c.r18_410 = TextBox55.Text;

        c.r18_51 = TextBox56.Text;
        c.r18_52 = TextBox57.Text;
        c.r18_53 = TextBox58.Text;
        c.r18_54 = TextBox59.Text;
        c.r18_55 = TextBox60.Text;
        c.r18_56 = TextBox61.Text;
        c.r18_57 = TextBox62.Text;
        c.r18_58 = TextBox63.Text;
        c.r18_59 = TextBox64.Text;
        c.r18_510 = TextBox65.Text;

        c.r19_11 = TextBox66.Text;
        c.r19_12 = TextBox67.Text;
        c.r19_13 = TextBox68.Text;
        c.r19_14 = TextBox69.Text;
        c.r19_15 = TextBox70.Text;
        c.r19_16 = TextBox71.Text;
        c.r19_17 = TextBox72.Text;
        c.r19_18 = TextBox73.Text;
        c.r19_19 = TextBox74.Text;
        c.r19_110 = TextBox75.Text;

        c.r19_21 = TextBox76.Text;
        c.r19_22 = TextBox77.Text;
        c.r19_23 = TextBox78.Text;
        c.r19_24 = TextBox79.Text;
        c.r19_25 = TextBox80.Text;
        c.r19_26 = TextBox81.Text;
        c.r19_27 = TextBox82.Text;
        c.r19_28 = TextBox83.Text;
        c.r19_29 = TextBox84.Text;
        c.r19_210 = TextBox85.Text;

        c.r19_31 = TextBox86.Text;
        c.r19_32 = TextBox87.Text;
        c.r19_33 = TextBox88.Text;
        c.r19_34 = TextBox89.Text;
        c.r19_35 = TextBox90.Text;
        c.r19_36 = TextBox91.Text;
        c.r19_37 = TextBox92.Text;
        c.r19_38 = TextBox93.Text;
        c.r19_39 = TextBox94.Text;
        c.r19_310 = TextBox95.Text;

        c.r19_41 = TextBox96.Text;
        c.r19_42 = TextBox97.Text;
        c.r19_43 = TextBox98.Text;
        c.r19_44 = TextBox99.Text;
        c.r19_45 = TextBox100.Text;
        c.r19_46 = TextBox101.Text;
        c.r19_47 = TextBox102.Text;
        c.r19_48 = TextBox103.Text;
        c.r19_49 = TextBox104.Text;
        c.r19_410 = TextBox105.Text;

        c.r19_51 = TextBox106.Text;
        c.r19_52 = TextBox107.Text;
        c.r19_53 = TextBox108.Text;
        c.r19_54 = TextBox109.Text;
        c.r19_55 = TextBox110.Text;
        c.r19_56 = TextBox111.Text;
        c.r19_57 = TextBox112.Text;
        c.r19_58 = TextBox113.Text;
        c.r19_59 = TextBox114.Text;
        c.r19_510 = TextBox115.Text;

        c.r20_11 = TextBox116.Text;
        c.r20_12 = TextBox117.Text;
        c.r20_13 = TextBox118.Text;
        c.r20_14 = TextBox119.Text;
        c.r20_15 = TextBox120.Text;
        c.r20_16 = TextBox121.Text;
        c.r20_17 = TextBox122.Text;
        c.r20_18 = TextBox123.Text;
        c.r20_19 = TextBox124.Text;
        c.r20_110 = TextBox125.Text;

        c.r20_21 = TextBox126.Text;
        c.r20_22 = TextBox127.Text;
        c.r20_23 = TextBox128.Text;
        c.r20_24 = TextBox129.Text;
        c.r20_25 = TextBox130.Text;
        c.r20_26 = TextBox131.Text;
        c.r20_27 = TextBox132.Text;
        c.r20_28 = TextBox133.Text;
        c.r20_29 = TextBox134.Text;
        c.r20_210 = TextBox135.Text;

        c.r20_31 = TextBox136.Text;
        c.r20_32 = TextBox137.Text;
        c.r20_33 = TextBox138.Text;
        c.r20_34 = TextBox139.Text;
        c.r20_35 = TextBox140.Text;
        c.r20_36 = TextBox141.Text;
        c.r20_37 = TextBox142.Text;
        c.r20_38 = TextBox143.Text;
        c.r20_39 = TextBox144.Text;
        c.r20_310 = TextBox145.Text;

        c.r20_41 = TextBox146.Text;
        c.r20_42 = TextBox147.Text;
        c.r20_43 = TextBox148.Text;
        c.r20_44 = TextBox149.Text;
        c.r20_45 = TextBox150.Text;
        c.r20_46 = TextBox151.Text;
        c.r20_47 = TextBox152.Text;
        c.r20_48 = TextBox153.Text;
        c.r20_49 = TextBox154.Text;
        c.r20_410 = TextBox155.Text;

        c.r20_51 = TextBox156.Text;
        c.r20_52 = TextBox157.Text;
        c.r20_53 = TextBox158.Text;
        c.r20_54 = TextBox159.Text;
        c.r20_55 = TextBox160.Text;
        c.r20_56 = TextBox161.Text;
        c.r20_57 = TextBox162.Text;
        c.r20_58 = TextBox163.Text;
        c.r20_59 = TextBox164.Text;
        c.r20_510 = TextBox165.Text;


        c.r21_1 = TextBox166.Text;
        c.r21_2 = TextBox167.Text;
        c.Insert_data();
        Cear_Data();

    }
    protected void Cear_Data()
    {

        ddlClass.SelectedIndex = 0;
        ddlLocono.SelectedIndex = 0;
        ddlSchedule.SelectedIndex = 0;

        txtdate.Text = "";
        txtTech.Text = "";
        txtstart.Text = "";
        txtfinish.Text = "";
        txtSuper.Text = "";
        TextBox6.Text = "";
        TextBox7.Text = "";
        TextBox8.Text = "";
        TextBox9.Text = "";
        TextBox10.Text = "";
        TextBox11.Text = "";
        TextBox12.Text = "";
        TextBox13.Text = "";
        TextBox14.Text = "";

        TextBox15.Text = "";
        TextBox16.Text = "";
        TextBox17.Text = "";
        TextBox18.Text = "";
        TextBox19.Text = "";
        TextBox20.Text = "";
        TextBox21.Text = "";
        TextBox22.Text = "";
        TextBox23.Text = "";
        TextBox24.Text = "";
        TextBox25.Text = "";
        TextBox26.Text = "";
        TextBox27.Text = "";
        TextBox28.Text = "";
        TextBox29.Text = "";
        TextBox30.Text = "";
        TextBox31.Text = "";
        TextBox32.Text = "";
        TextBox33.Text = "";
        TextBox34.Text = "";

        TextBox35.Text = "";
        TextBox36.Text = "";
        TextBox37.Text = "";
        TextBox38.Text = "";
        TextBox39.Text = "";
        TextBox30.Text = "";
        TextBox41.Text = "";
        TextBox42.Text = "";
        TextBox43.Text = "";
        TextBox44.Text = "";

        TextBox45.Text = "";
        TextBox46.Text = "";
        TextBox47.Text = "";
        TextBox48.Text = "";
        TextBox49.Text = "";
        TextBox50.Text = "";
        TextBox51.Text = "";
        TextBox52.Text = "";
        TextBox53.Text = "";
        TextBox54.Text = "";

        TextBox55.Text = "";
        TextBox56.Text = "";
        TextBox57.Text = "";
        TextBox58.Text = "";
        TextBox59.Text = "";
        TextBox60.Text = "";
        TextBox61.Text = "";
        TextBox62.Text = "";
        TextBox63.Text = "";
        TextBox64.Text = "";

        TextBox65.Text = "";
        TextBox66.Text = "";
        TextBox67.Text = "";
        TextBox68.Text = "";
        TextBox69.Text = "";
        TextBox70.Text = "";
        TextBox71.Text = "";
        TextBox72.Text = "";
        TextBox73.Text = "";
        TextBox74.Text = "";

        TextBox75.Text = "";
        TextBox76.Text = "";
        TextBox77.Text = "";
        TextBox78.Text = "";
        TextBox79.Text = "";
        TextBox80.Text = "";
        TextBox81.Text = "";
        TextBox82.Text = "";
        TextBox83.Text = "";
        TextBox84.Text = "";

        TextBox85.Text = "";
        TextBox86.Text = "";
        TextBox87.Text = "";
        TextBox88.Text = "";
        TextBox89.Text = "";
        TextBox90.Text = "";
        TextBox91.Text = "";
        TextBox92.Text = "";
        TextBox93.Text = "";
        TextBox94.Text = "";

        TextBox95.Text = "";
        TextBox96.Text = "";
        TextBox97.Text = "";
        TextBox98.Text = "";
        TextBox99.Text = "";
        TextBox100.Text = "";
        TextBox101.Text = "";
        TextBox102.Text = "";
        TextBox103.Text = "";
        TextBox104.Text = "";

        TextBox105.Text = "";
        TextBox106.Text = "";
        TextBox107.Text = "";
        TextBox108.Text = "";
        TextBox109.Text = "";
        TextBox110.Text = "";
        TextBox111.Text = "";
        TextBox112.Text = "";
        TextBox113.Text = "";
        TextBox114.Text = "";

        TextBox115.Text = "";
        TextBox116.Text = "";
        TextBox117.Text = "";
        TextBox118.Text = "";
        TextBox119.Text = "";
        TextBox120.Text = "";
        TextBox121.Text = "";
        TextBox122.Text = "";
        TextBox123.Text = "";
        TextBox124.Text = "";

        TextBox125.Text = "";
        TextBox126.Text = "";
        TextBox127.Text = "";
        TextBox128.Text = "";
        TextBox129.Text = "";
        TextBox130.Text = "";
        TextBox131.Text = "";
        TextBox132.Text = "";
        TextBox133.Text = "";
        TextBox134.Text = "";

        TextBox135.Text = "";
        TextBox136.Text = "";
        TextBox137.Text = "";
        TextBox138.Text = "";
        TextBox139.Text = "";
        TextBox140.Text = "";
        TextBox141.Text = "";
        TextBox142.Text = "";
        TextBox143.Text = "";
        TextBox144.Text = "";

        TextBox145.Text = "";
        TextBox146.Text = "";
        TextBox147.Text = "";
        TextBox148.Text = "";
        TextBox149.Text = "";
        TextBox150.Text = "";
        TextBox151.Text = "";
        TextBox152.Text = "";
        TextBox153.Text = "";
        TextBox154.Text = "";
        TextBox155.Text = "";
        TextBox156.Text = "";
        TextBox157.Text = "";
        TextBox158.Text = "";
        TextBox159.Text = "";
        TextBox160.Text = "";
        TextBox161.Text = "";
        TextBox162.Text = "";
        TextBox163.Text = "";
        TextBox164.Text = "";

        TextBox165.Text = "";
        TextBox166.Text = "";
    }
    protected void ddlSection_SelectedIndexChanged(object sender, EventArgs e)
    {
        Fill_Card();
    }
    protected void ddlCard_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlCard.SelectedIndex !='0')
        {

            p1.Visible = true;
        }

        else

        {
            p1.Visible = false;
        }
    }
}
