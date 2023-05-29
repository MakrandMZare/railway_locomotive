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

public partial class machanicalSection_powerpack : System.Web.UI.Page
{
    Cls_Mech_Power_pack c = new Cls_Mech_Power_pack();
    public void Fill_Schedule()
    {
        ddlSchedule.Items.Clear();
        Cls_jos_railway_loco_type_schedule c = new Cls_jos_railway_loco_type_schedule();
        c.loco_id = ddlClass.SelectedValue.ToString();
        ddlSchedule.DataSource = c.Select_Data_schedule();
        ddlSchedule.DataTextField = "s_type";
        ddlSchedule.DataValueField = "id_loco_sch";
        ddlSchedule.DataBind();
        ddlSchedule.Items.Insert(0, "SELECT");
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Fill_Class();
            Fill_Schedule();
            Fill_HR2();
            Fill_HR();
        }
    }
    public void Clean_Data()
    {

        c.id_mst_loco = ddlLocono.SelectedValue.ToString();
        c.id_hr_tech = ddlhr.SelectedValue.ToString();
        c.id_hr_super = ddlhr2.SelectedValue.ToString();
        c.id_loco_sch = ddlSchedule.SelectedValue.ToString();
        c.date1 = txtdate.Text;
        c.w_start = txtstart.Text;
        c.w_end = txtfinish.Text;
        c.idle1 = TextBox1.Text;
        c.i11 = TextBox2.Text;
        c.i12 = TextBox3.Text;
        c.i13 = TextBox4.Text;
        c.i14 = TextBox5.Text;
        c.i15 = TextBox6.Text;

        c.i16 = TextBox7.Text;
        c.i17 = TextBox8.Text;
        c.i18 = TextBox9.Text;
        c.lt2_1 = TextBox10.Text;

        c.idle2 = TextBox11.Text;
        c.i21 = TextBox12.Text;
        c.i22 = TextBox13.Text;
        c.i23 = TextBox14.Text;
        c.i24 = TextBox15.Text;
        c.i25 = TextBox16.Text;
        c.i26 = TextBox17.Text;
        c.i27 = TextBox18.Text;
        c.i28 = TextBox19.Text;
        c.lt2_2 = TextBox2.Text;
        c.idle3 = TextBox21.Text;
        c.i31 = TextBox22.Text;
        c.i32 = TextBox23.Text;
        c.i33 = TextBox24.Text;
        c.i34 = TextBox25.Text;
        c.i35 = TextBox26.Text;
        c.i36 = TextBox27.Text;
        c.i37 = TextBox28.Text;
        c.i38 = TextBox29.Text;
        c.lt2_3 = TextBox30.Text;
        c.idle4 = TextBox31.Text;
        c.i41 = TextBox32.Text;
        c.i42 = TextBox33.Text;
        c.i43 = TextBox34.Text;
        c.i44 = TextBox35.Text;
        c.i45 = TextBox36.Text;
        c.i46 = TextBox37.Text;
        c.i47 = TextBox38.Text;
        c.i48 = TextBox39.Text;
        c.lt2_4 = TextBox40.Text;
        c.idle5 = TextBox41.Text;
        c.i51 = TextBox42.Text;
        c.i52 = TextBox43.Text;
        c.i53 = TextBox44.Text;
        c.i54 = TextBox45.Text;
        c.i55 = TextBox46.Text;
        c.i56 = TextBox47.Text;
        c.i57 = TextBox48.Text;
        c.i58 = TextBox49.Text;
        c.lt2_5 = TextBox50.Text;
        c.idle6 = TextBox51.Text;
        c.i61 = TextBox52.Text;
        c.i62 = TextBox53.Text;
        c.i63 = TextBox54.Text;
        c.i64 = TextBox55.Text;
        c.i65 = TextBox56.Text;
        c.i66 = TextBox57.Text;
        c.i67 = TextBox58.Text;
        c.i68 = TextBox59.Text;
        c.lt2_6 = TextBox60.Text;
        c.idle7 = TextBox61.Text;
        c.i71 = TextBox62.Text;
        c.i72 = TextBox63.Text;
        c.i73 = TextBox64.Text;
        c.i74 = TextBox65.Text;
        c.i75 = TextBox66.Text;
        c.i76 = TextBox67.Text;
        c.i77 = TextBox68.Text;
        c.i78 = TextBox69.Text;
        c.lt2_7 = TextBox70.Text;
        c.idle8 = TextBox71.Text;
        c.i81 = TextBox72.Text;
        c.i82 = TextBox73.Text;
        c.i83 = TextBox74.Text;
        c.i84 = TextBox75.Text;
        c.i85 = TextBox76.Text;
        c.i86 = TextBox77.Text;
        c.i87 = TextBox78.Text;
        c.i88 = TextBox79.Text;
        c.lt2_8 = TextBox80.Text;
        c.idle9 = TextBox81.Text;
        c.i91 = TextBox82.Text;
        c.i92 = TextBox83.Text;
        c.i93 = TextBox84.Text;
        c.i94 = TextBox85.Text;
        c.i95 = TextBox86.Text;
        c.i96 = TextBox87.Text;
        c.i97 = TextBox88.Text;
        c.i98 = TextBox89.Text;
        c.lt2_9 = TextBox90.Text;
        c.idle10 = TextBox91.Text;
        c.i101 = TextBox92.Text;
        c.i102 = TextBox93.Text;
        c.i103 = TextBox94.Text;
        c.i104 = TextBox95.Text;
        c.i105 = TextBox96.Text;
        c.i106 = TextBox97.Text;
        c.i107 = TextBox98.Text;
        c.i108 = TextBox99.Text;
        c.lt2_10 = TextBox100.Text;
        c.idle11 = TextBox101.Text;
        c.i111 = TextBox102.Text;
        c.i112 = TextBox103.Text;
        c.i113 = TextBox104.Text;
        c.i114 = TextBox105.Text;
        c.i115 = TextBox106.Text;
        c.i116 = TextBox107.Text;
        c.i117 = TextBox108.Text;
        c.i118 = TextBox109.Text;
        c.lt2_11 = TextBox110.Text;
        c.idle12 = TextBox111.Text;
        c.i121 = TextBox112.Text;
        c.i122 = TextBox113.Text;
        c.i123 = TextBox114.Text;
        c.i124 = TextBox115.Text;
        c.i125 = TextBox116.Text;
        c.i126 = TextBox117.Text;

        c.i127 = TextBox118.Text;
        c.i128 = TextBox119.Text;
        c.lt2_12 = TextBox120.Text;
        c.s1 = TextBox121.Text;
        c.s2 = TextBox122.Text;
        c.s3 = TextBox123.Text;
        c.s4 = TextBox124.Text;
        c.s5 = TextBox125.Text;
        c.s6 = TextBox126.Text;
        c.s7 = TextBox127.Text;
        c.s8 = TextBox128.Text;
        c.s9 = TextBox129.Text;
        c.s10 = TextBox130.Text;
        c.a1 = TextBox131.Text;
        c.a2 = TextBox132.Text;
        c.a3 = TextBox133.Text;
        c.a4 = TextBox134.Text;
        c.a5 = TextBox135.Text;
        c.a6 = TextBox136.Text;
        c.a7 = TextBox137.Text;
        c.a8 = TextBox138.Text;
        c.a9 = TextBox139.Text;
        c.a10 = TextBox140.Text;


        c.l1 = TextBox141.Text;
        c.l2 = TextBox142.Text;

        c.l3 = TextBox143.Text;
        c.l4 = TextBox144.Text;
        c.l5 = TextBox145.Text;
        c.l6 = TextBox146.Text;
        c.l7 = TextBox147.Text;
        c.l8 = TextBox148.Text;
        c.l9 = TextBox149.Text;
        c.l10 = TextBox150.Text;
        c.l11 = TextBox151.Text;
        c.l12 = TextBox152.Text;
        c.l13 = TextBox153.Text;
        c.l14 = TextBox154.Text;
        c.l15 = TextBox155.Text;
        c.l16 = TextBox156.Text;
        c.l17 = TextBox157.Text;

        c.Insert_Data();
        Clean_Data();
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        ddlLocono.SelectedIndex = 0;
        ddlhr.SelectedIndex = 0;
        ddlhr2.SelectedIndex = 0;
        ddlSchedule.SelectedIndex = 0;
        txtstart.Text = "";
        txtfinish.Text = "";
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
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
        TextBox2.Text = "";
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
        TextBox40.Text = "";
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
        txtdate.Text = "";

    }
    protected void btnInsert_Click(object sender, EventArgs e)
    {
        Clean_Data();
    }
    protected void ddlClass_SelectedIndexChanged(object sender, EventArgs e)
    {
        Fill_LocoNo();
    }
    public void Fill_HR()
    {
        ddlhr.DataSource = c.select_employee();
        ddlhr.DataTextField = "surname";
        ddlhr.DataValueField = "id_hr";
        ddlhr.DataBind();
        ddlhr.Items.Insert(0, "SELECT");
    }
    public void Fill_HR2()
    {
        ddlhr2.DataSource = c.select_employee();
        ddlhr2.DataTextField = "surname";
        ddlhr2.DataValueField = "id_hr";
        ddlhr2.DataBind();
        ddlhr2.Items.Insert(0, "SELECT");
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

}
