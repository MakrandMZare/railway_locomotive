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

public partial class ElectronicChekSheet_irc_frc : System.Web.UI.Page
{
    Cls_IRC_FRC c = new Cls_IRC_FRC();
    Cls_Card_Form cc = new Cls_Card_Form();

    public void Fill_Class()
    {
        Cls_jos_railway_loco_in obj = new Cls_jos_railway_loco_in();
        ddlClass.DataSource = obj.SelectLocoType();
        ddlClass.DataTextField = "loco_type";
        ddlClass.DataValueField = "id_ltype";
        ddlClass.DataBind();
        ddlClass.Items.Insert(0, "SELECT");
    }

    public void Fill_Super()
    {
        ddlSuper.DataSource = c.select_employee();
        ddlSuper.DataTextField = "fullname";
        ddlSuper.DataValueField = "id_hr";
        ddlSuper.DataBind();
        ddlSuper.Items.Insert(0, "SELECT");
    }

    public void Fill_Tech()
    {
        ddlTech.DataSource = c.select_employee();
        ddlTech.DataTextField = "fullname";
        ddlTech.DataValueField = "id_hr";
        ddlTech.DataBind();
        ddlTech.Items.Insert(0, "SELECT");
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
    //public void Fill_Schedule()
    //{
    //    ddlSchedule.Items.Clear();
    //    Cls_jos_railway_loco_type_schedule c = new Cls_jos_railway_loco_type_schedule();
    //    //c.loco_id = ddlClass.SelectedValue.ToString();
    //    ddlSchedule.DataSource = c.Select_Data_schedule();
    //    ddlSchedule.DataTextField = "Schedule_Type";
    //    ddlSchedule.DataValueField = "id_loco_sch";
    //    ddlSchedule.DataBind();
    //    ddlSchedule.Items.Insert(0=TextBox1.Text; "SELECT");
    //}
    public void Fill_Schedule()
    {
        ddlSchedule.DataSource = cc.Select_Schedule();
        ddlSchedule.DataTextField = "s_type";
        ddlSchedule.DataValueField = "id_loco_sch";
        ddlSchedule.DataBind();
        ddlSchedule.Items.Insert(0, "SELECT");
    }
    public void Fill_section()
    {
        ddlSection.DataSource = cc.Select_section();
        ddlSection.DataTextField = "f_name";
        ddlSection.DataValueField = "id_section";
        ddlSection.DataBind();
        ddlSection.Items.Insert(0, "SELECT");
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Fill_Schedule();
            Fill_Super();
            Fill_Tech();
            Fill_Class();
            Fill_section();
        }
    }
    protected void btnInsert_Click(object sender, EventArgs e)
    {
        cc.id_section = ddlSection.SelectedValue.ToString();
        cc.id_schedule = ddlSchedule.SelectedValue.ToString();
        cc.id_loco = ddlLocono.SelectedValue.ToString();
        cc.id_technician = ddlTech.SelectedValue.ToString();
        cc.id_supervisor = ddlSuper.SelectedValue.ToString();
        cc.w_s_time = txtstart.Text;
        cc.w_end_time = txtfinish.Text;
        cc.date1 = txtdate.Text;
        cc.id_sch_card = ddlSection.SelectedValue.ToString();

        cc.status = TextBox437.Text;
        cc.action_tak = TextBox437.Text;
        string m = Convert.ToString(cc.Insert_Data());

        c.id_sc_format = m;
        c.long_wkg_1 = TextBox1.Text;
        c.long_wkg_2 = TextBox6.Text;
        c.long_wkg_3 = TextBox11.Text;
        c.long_wkg_4 = TextBox16.Text;
        c.long_wkg_5 = TextBox21.Text;
        c.long_wkg_6 = TextBox33.Text;
        c.long_wkg_7 = TextBox38.Text;
        c.long_wkg_8 = TextBox43.Text;
        c.long_wkg_9 = TextBox48.Text;

        c.long_nw_1 = TextBox2.Text;
        c.long_nw_2 = TextBox7.Text;
        c.long_nw_3 = TextBox12.Text;
        c.long_nw_4 = TextBox17.Text;
        c.long_nw_5 = TextBox22.Text;
        c.long_nw_6 = TextBox34.Text;
        c.long_nw_7 = TextBox39.Text;
        c.long_nw_8 = TextBox44.Text;
        c.long_nw_9 = TextBox49.Text;

        c.short_wkg_1 = TextBox3.Text;
        c.short_wkg_2 = TextBox8.Text;
        c.short_wkg_3 = TextBox13.Text;
        c.short_wkg_4 = TextBox18.Text;
        c.short_wkg_5 = TextBox23.Text;
        c.short_wkg_6 = TextBox35.Text;
        c.short_wkg_7 = TextBox40.Text;
        c.short_wkg_8 = TextBox45.Text;
        c.short_wkg_9 = TextBox50.Text;

        c.short_nw_1 = TextBox4.Text;
        c.short_nw_2 = TextBox9.Text;
        c.short_nw_3 = TextBox14.Text;
        c.short_nw_4 = TextBox19.Text;
        c.short_nw_5 = TextBox24.Text;
        c.short_nw_6 = TextBox36.Text;
        c.short_nw_7 = TextBox41.Text;
        c.short_nw_8 = TextBox46.Text;
        c.short_nw_9 = TextBox51.Text;

        c.remark1 = TextBox5.Text;
        c.remark2 = TextBox10.Text;
        c.remark3 = TextBox15.Text;
        c.remark4 = TextBox20.Text;
        c.remark5 = TextBox25.Text;
        c.remark6 = TextBox37.Text;
        c.remark7 = TextBox42.Text;
        c.remark8 = TextBox47.Text;
        c.remark9 = TextBox52.Text;
        c.remark10 = TextBox53.Text;
        c.remark11 = TextBox54.Text;
        c.remark12 = TextBox55.Text;
        c.remark13 = TextBox56.Text;

        c.rg10 = TextBox26.Text;
        c.indication1 = TextBox27.Text;
        c.indication2 = TextBox28.Text;
        c.attendant1 = TextBox29.Text;
        c.attendant2 = TextBox30.Text;
        c.cab1 = TextBox31.Text;
        c.cab2 = TextBox32.Text;

        c.ridel1 = TextBox57.Text;
        c.ridel2 = TextBox63.Text;
        c.ridel3 = TextBox69.Text;
        c.ridel4 = TextBox75.Text;
        c.ridel5 = TextBox81.Text;

        c.r8th1 = TextBox62.Text;
        c.r8th2 = TextBox66.Text;
        c.r8th3 = TextBox72.Text;
        c.r8th4 = TextBox78.Text;
        c.r8th5 = TextBox82.Text;

        c.sidle1 = TextBox58.Text;
        c.sidle2 = TextBox64.Text;
        c.sidle3 = TextBox70.Text;
        c.sidle4 = TextBox74.Text;

        c.s8th1 = TextBox61.Text;
        c.s8th2 = TextBox67.Text;
        c.s8th3 = TextBox73.Text;
        c.s8th4 = TextBox79.Text;

        c.tidle1 = TextBox59.Text;
        c.tidle2 = TextBox65.Text;
        c.tidle3 = TextBox71.Text;
        c.tidle4 = TextBox77.Text;

        c.t8th1 = TextBox60.Text;
        c.t8th2 = TextBox68.Text;
        c.t8th3 = TextBox74.Text;
        c.t8th4 = TextBox80.Text;

        c.opMode = TextBox329.Text;
        c.dclv = TextBox330.Text;
        c.dcla = TextBox331.Text;
        c.gridkw = TextBox332.Text;
        c.grid1a = TextBox333.Text;
        c.grid2a = TextBox334.Text;
        c.grid_blw1A = TextBox335.Text;
        c.grid_blw2A = TextBox336.Text;
        c.eng_rpm_db = TextBox337.Text;

        c.db_post_s1 = TextBox338.Text;
        c.db_post_s2 = TextBox340.Text;
        c.db_post_s3 = TextBox341.Text;
        c.db_post_s4 = TextBox342.Text;
        c.db_post_s5 = TextBox343.Text;
        c.db_post_s6 = TextBox344.Text;
        c.db_post_s7 = TextBox345.Text;
        c.db_post_s8 = TextBox346.Text;

        c.db_post_l1 = TextBox339.Text;
        c.db_post_l2 = TextBox352.Text;
        c.db_post_l3 = TextBox433.Text;
        c.db_post_l4 = TextBox351.Text;
        c.db_post_l5 = TextBox350.Text;
        c.db_post_l6 = TextBox349.Text;
        c.db_post_l7 = TextBox348.Text;
        c.db_post_l8 = TextBox347.Text;

        c.th_pos = TextBox353.Text;
        c.th_idl = TextBox358.Text;
        c.dbntco = TextBox434.Text;
        c.db17t = TextBox354.Text;
        c.db21t = TextBox357.Text;
        c.tl24t = TextBox435.Text;
        c.rhsf = TextBox355.Text;
        c.rhsr = TextBox356.Text;
        c.ldunit = TextBox436.Text;

        c.dvr_bcp1 = TextBox359.Text;
        c.dvr_8th = TextBox370.Text;
        c.dvr_bp1 = TextBox360.Text;
        c.dvr_bp2 = TextBox369.Text;
        c.dvr_aux1 = TextBox361.Text;
        c.dvr_aux2 = TextBox368.Text;
        c.dvr_ph_ab1 = TextBox362.Text;
        c.dvr_ph_bc1 = TextBox363.Text;
        c.dvr_ph_ca1 = TextBox364.Text;

        c.dvr_ph_ab2 = TextBox367.Text;
        c.dvr_ph_bc2 = TextBox366.Text;
        c.dvr_ph_ca2 = TextBox365.Text;

        c.radi1_bp1 = TextBox372.Text;
        c.radi1_bp2 = TextBox381.Text;
        c.radi1_aux1 = TextBox373.Text;
        c.radi1_aux2 = TextBox380.Text;
        c.radi1_ph_ab1 = TextBox374.Text;
        c.radi1_ph_bc1 = TextBox375.Text;
        c.radi1_ph_ca1 = TextBox376.Text;
        c.radi1_ph_ab2 = TextBox379.Text;
        c.radi1_ph_bc2 = TextBox378.Text;
        c.radi1_ph_ca2 = TextBox377.Text;
        c.radi2_bp1 = TextBox384.Text;
        c.radi2_bp2 = TextBox393.Text;
        c.radi2_aux1 = TextBox385.Text;
        c.radi2_aux2 = TextBox392.Text;
        c.radi2_pf_ab1 = TextBox386.Text;
        c.radi2_pf_bc1 = TextBox387.Text;
        c.radi2_pf_ca1 = TextBox388.Text;
        c.radi2_pf_ab2 = TextBox391.Text;
        c.radi2_pf_bc2 = TextBox390.Text;
        c.radi2_pf_ca2 = TextBox389.Text;

        c.test_mu_s1 = TextBox395.Text;
        c.test_mu_s2 = TextBox397.Text;
        c.test_mu_s3 = TextBox398.Text;
        c.test_mu_s4 = TextBox399.Text;
        c.test_mu_s5 = TextBox400.Text;
        c.test_mu_s6 = TextBox401.Text;
        c.test_mu_s7 = TextBox402.Text;
        c.test_mu_s8 = TextBox409.Text;
        c.test_mu_s9 = TextBox410.Text;
        c.test_mu_s10 = TextBox411.Text;
        c.test_mu_s12 = TextBox412.Text;
        c.test_mu_s13 = TextBox413.Text;
        c.test_mu_s14 = TextBox414.Text;
        c.test_mu_s15 = TextBox415.Text;
        c.test_mu_s16 = TextBox423.Text;
        c.test_mu_s17 = TextBox424.Text;
        c.test_mu_s18 = TextBox425.Text;
        c.test_mu_s19 = TextBox426.Text;

        c.test_mu_l1 = TextBox396.Text;
        c.test_mu_l2 = TextBox408.Text;
        c.test_mu_l3 = TextBox407.Text;
        c.test_mu_l4 = TextBox406.Text;
        c.test_mu_l5 = TextBox405.Text;
        c.test_mu_l6 = TextBox404.Text;
        c.test_mu_l7 = TextBox403.Text;
        c.test_mu_l8 = TextBox416.Text;
        c.test_mu_l9 = TextBox417.Text;
        c.test_mu_l0 = TextBox418.Text;
        c.test_mu_l11 = TextBox419.Text;
        c.test_mu_l12 = TextBox420.Text;
        c.test_mu_l13 = TextBox421.Text;
        c.test_mu_l14 = TextBox422.Text;
        c.test_mu_l15 = TextBox428.Text;
        c.test_mu_l16 = TextBox429.Text;
        c.test_mu_l17 = TextBox430.Text;
        c.test_mu_l18 = TextBox431.Text;
        c.test_mu_l19 = TextBox432.Text;
        c.Insert_Data_IRC_FRC_1();
        //-------------------------------------------------------------------
        c.p_i_1_1 = TextBox83.Text;
        c.p_i_1_2 = TextBox84.Text;
        c.p_i_1_3 = TextBox101.Text;
        c.p300_i_1 = TextBox87.Text;
        c.p300_i_2 = TextBox88.Text;
        c.p300_i_3 = TextBox103.Text;
        c.p310_i_1 = TextBox91.Text;
        c.p310_i_2 = TextBox92.Text;
        c.p310_i_3 = TextBox105.Text;
        c.p320_i_1 = TextBox95.Text;
        c.p320_i_2 = TextBox96.Text;
        c.p320_i_3 = TextBox107.Text;
        c.p_8_1 = TextBox86.Text;
        c.p_8_2 = TextBox85.Text;
        c.p_8_3 = TextBox102.Text;
        c.p300_8_1 = TextBox90.Text;
        c.p300_8_2 = TextBox89.Text;
        c.p300_8_3 = TextBox104.Text;
        c.p310_8_1 = TextBox94.Text;
        c.p310_8_2 = TextBox93.Text;
        c.p310_8_3 = TextBox106.Text;
        c.p320_8_1 = TextBox98.Text;
        c.p320_8_2 = TextBox97.Text;
        c.p320_8_3 = TextBox108.Text;
        c.sh1 = TextBox99.Text;
        c.lh1 = TextBox100.Text;
        c.eng_rpm = TextBox109.Text;

        c.eng_rpm1 = TextBox131.Text;
        c.eng_rp2 = TextBox174.Text;
        c.eng_rp3 = TextBox175.Text;
        c.eng_rp4 = TextBox197.Text;
        c.eng_rp5 = TextBox240.Text;
        c.eng_rp6 = TextBox262.Text;
        c.eng_rp7 = TextBox263.Text;
        c.eng_rp8 = TextBox306.Text;
        c.eng_rp9 = TextBox307.Text;

        c.lr = TextBox110.Text;
        c.lr1 = TextBox132.Text;
        c.lr2 = TextBox173.Text;
        c.lr3 = TextBox176.Text;
        c.lr4 = TextBox198.Text;
        c.lr5 = TextBox239.Text;
        c.lr6 = TextBox261.Text;
        c.lr7 = TextBox264.Text;
        c.lr8 = TextBox305.Text;
        c.lr9 = TextBox308.Text;
        c.eng_hp = TextBox111.Text;
        c.eng_hp1 = TextBox133.Text;
        c.eng_hp2 = TextBox172.Text;
        c.eng_hp3 = TextBox177.Text;
        c.eng_hp4 = TextBox199.Text;
        c.eng_hp5 = TextBox238.Text;
        c.eng_hp6 = TextBox260.Text;
        c.eng_hp7 = TextBox265.Text;
        c.eng_hp8 = TextBox304.Text;
        c.eng_hp9 = TextBox309.Text;

        c.tpu = TextBox112.Text;
        c.tpu1 = TextBox134.Text;
        c.tpu2 = TextBox171.Text;
        c.tpu3 = TextBox178.Text;
        c.tpu4 = TextBox200.Text;
        c.tpu5 = TextBox237.Text;
        c.tpu6 = TextBox259.Text;
        c.tpu7 = TextBox266.Text;
        c.tpu8 = TextBox303.Text;
        c.tpu9 = TextBox310.Text;

        c.kwref = TextBox113.Text;
        c.kwref1 = TextBox135.Text;
        c.kwref2 = TextBox170.Text;
        c.kwref3 = TextBox179.Text;
        c.kwref4 = TextBox201.Text;
        c.kwref5 = TextBox236.Text;
        c.kwref6 = TextBox258.Text;
        c.kwref7 = TextBox267.Text;
        c.kwref8 = TextBox302.Text;
        c.kwref9 = TextBox311.Text;

        c.kwfbk = TextBox114.Text;
        c.kwfbk1 = TextBox136.Text;
        c.kwfbk2 = TextBox169.Text;
        c.kwfbk3 = TextBox180.Text;
        c.kwfbk4 = TextBox202.Text;
        c.kwfbk5 = TextBox235.Text;
        c.kwfbk6 = TextBox257.Text;
        c.kwfbk7 = TextBox268.Text;
        c.kwfbk8 = TextBox301.Text;
        c.kwfbk9 = TextBox312.Text;

        c.mga = TextBox115.Text;
        c.mga1 = TextBox137.Text;
        c.mga2 = TextBox168.Text;
        c.mga3 = TextBox181.Text;
        c.mga4 = TextBox203.Text;
        c.mga5 = TextBox234.Text;
        c.mga6 = TextBox256.Text;
        c.mga7 = TextBox269.Text;
        c.mga8 = TextBox300.Text;
        c.mga9 = TextBox313.Text;
        c.mgv = TextBox116.Text;
        c.mgv1 = TextBox138.Text;
        c.mgv2 = TextBox167.Text;
        c.mgv3 = TextBox182.Text;
        c.mgv4 = TextBox204.Text;
        c.mgv5 = TextBox233.Text;
        c.mgv6 = TextBox255.Text;
        c.mgv7 = TextBox270.Text;
        c.mgv8 = TextBox299.Text;
        c.mgv9 = TextBox314.Text;
        c.bar_pres = TextBox117.Text;
        c.bar_pres1 = TextBox139.Text;
        c.bar_pres2 = TextBox166.Text;
        c.bar_pres3 = TextBox183.Text;
        c.bar_pres4 = TextBox205.Text;
        c.bar_pres5 = TextBox232.Text;
        c.bar_pres6 = TextBox254.Text;
        c.bar_pres7 = TextBox271.Text;
        c.bar_pres8 = TextBox298.Text;
        c.bar_pres9 = TextBox315.Text;

        c.tm_air = TextBox118.Text;
        c.tm_air1 = TextBox140.Text;
        c.tm_air2 = TextBox165.Text;
        c.tm_air3 = TextBox184.Text;
        c.tm_air4 = TextBox206.Text;
        c.tm_air5 = TextBox231.Text;
        c.tm_air6 = TextBox253.Text;
        c.tm_air7 = TextBox272.Text;
        c.tm_air8 = TextBox297.Text;
        c.tm_air9 = TextBox316.Text;
        c.mg_field = TextBox119.Text;
        c.mg_field1 = TextBox141.Text;
        c.mg_field2 = TextBox164.Text;
        c.mg_field3 = TextBox185.Text;
        c.mg_field4 = TextBox207.Text;
        c.mg_field5 = TextBox230.Text;
        c.mg_field6 = TextBox252.Text;
        c.mg_field7 = TextBox273.Text;
        c.mg_field8 = TextBox296.Text;
        c.mg_field9 = TextBox317.Text;
        c.mg_ct = TextBox120.Text;
        c.mg_ct1 = TextBox142.Text;
        c.mg_ct2 = TextBox163.Text;
        c.mg_ct3 = TextBox186.Text;
        c.mg_ct4 = TextBox208.Text;
        c.mg_ct5 = TextBox229.Text;
        c.mg_ct6 = TextBox251.Text;
        c.mg_ct7 = TextBox274.Text;
        c.mg_ct8 = TextBox295.Text;
        c.mg_ct9 = TextBox318.Text;

        c.grid1 = TextBox130.Text;
        c.grid1_1 = TextBox143.Text;
        c.grid1_2 = TextBox162.Text;
        c.grid1_3 = TextBox187.Text;
        c.grid1_4 = TextBox209.Text;
        c.grid1_5 = TextBox228.Text;
        c.grid1_6 = TextBox250.Text;
        c.grid1_7 = TextBox275.Text;
        c.grid1_8 = TextBox294.Text;
        c.grid1_9 = TextBox319.Text;

        c.grid2 = TextBox129.Text;
        c.grid2_1 = TextBox144.Text;
        c.grid2_2 = TextBox161.Text;
        c.grid2_3 = TextBox188.Text;
        c.grid2_4 = TextBox210.Text;
        c.grid2_5 = TextBox227.Text;
        c.grid2_6 = TextBox249.Text;
        c.grid2_7 = TextBox276.Text;
        c.grid2_8 = TextBox293.Text;
        c.grid2_9 = TextBox320.Text;

        c.grid_blw1 = TextBox128.Text;
        c.grid_blw1_1 = TextBox145.Text;
        c.grid_blw1_2 = TextBox160.Text;
        c.grid_blw1_3 = TextBox189.Text;
        c.grid_blw1_4 = TextBox211.Text;
        c.grid_blw1_5 = TextBox226.Text;
        c.grid_blw1_6 = TextBox248.Text;
        c.grid_blw1_7 = TextBox277.Text;
        c.grid_blw1_8 = TextBox292.Text;
        c.grid_blw1_9 = TextBox321.Text;

        c.grid_blw2 = TextBox127.Text;
        c.grid_blw2_1 = TextBox146.Text;
        c.grid_blw2_2 = TextBox159.Text;
        c.grid_blw2_3 = TextBox190.Text;
        c.grid_blw2_4 = TextBox212.Text;
        c.grid_blw2_5 = TextBox225.Text;
        c.grid_blw2_6 = TextBox247.Text;
        c.grid_blw2_7 = TextBox278.Text;
        c.grid_blw2_8 = TextBox291.Text;
        c.grid_blw2_9 = TextBox322.Text;
        c.cav = TextBox126.Text;
        c.cav1 = TextBox147.Text;
        c.cav2 = TextBox158.Text;
        c.cav3 = TextBox191.Text;
        c.cav4 = TextBox213.Text;
        c.cav5 = TextBox224.Text;
        c.cav6 = TextBox246.Text;
        c.cav7 = TextBox279.Text;
        c.cav8 = TextBox290.Text;
        c.cav9 = TextBox323.Text;
        c.etp1 = TextBox125.Text;
        c.etp1_1 = TextBox148.Text;
        c.etp1_2 = TextBox157.Text;
        c.etp1_3 = TextBox192.Text;
        c.etp1_4 = TextBox214.Text;
        c.etp1_5 = TextBox223.Text;
        c.etp1_6 = TextBox245.Text;
        c.etp1_7 = TextBox280.Text;
        c.etp1_8 = TextBox289.Text;
        c.etp1_9 = TextBox324.Text;

        c.etp2 = TextBox124.Text;
        c.etp2_1 = TextBox149.Text;
        c.etp2_2 = TextBox156.Text;
        c.etp2_3 = TextBox193.Text;
        c.etp2_4 = TextBox215.Text;
        c.etp2_5 = TextBox222.Text;
        c.etp2_6 = TextBox244.Text;
        c.etp2_7 = TextBox281.Text;
        c.etp2_8 = TextBox288.Text;
        c.etp2_9 = TextBox325.Text;

        c.rad1 = TextBox123.Text;
        c.rad1_1 = TextBox150.Text;
        c.rad1_2 = TextBox155.Text;
        c.rad1_3 = TextBox194.Text;
        c.rad1_4 = TextBox216.Text;
        c.rad1_5 = TextBox221.Text;
        c.rad1_6 = TextBox243.Text;
        c.rad1_7 = TextBox282.Text;
        c.rad1_8 = TextBox287.Text;
        c.rad1_9 = TextBox326.Text;
        c.rad2 = TextBox122.Text;
        c.rad2_1 = TextBox151.Text;
        c.rad2_2 = TextBox154.Text;
        c.rad2_3 = TextBox195.Text;
        c.rad2_4 = TextBox217.Text;
        c.rad2_5 = TextBox220.Text;
        c.rad2_6 = TextBox242.Text;
        c.rad2_7 = TextBox283.Text;
        c.rad2_8 = TextBox286.Text;
        c.rad2_9 = TextBox327.Text;
        c.ecc1 = TextBox121.Text;
        c.ecc11 = TextBox152.Text;
        c.ecc12 = TextBox153.Text;
        c.ecc13 = TextBox196.Text;
        c.ecc14 = TextBox218.Text;
        c.ecc15 = TextBox219.Text;
        c.ecc16 = TextBox241.Text;
        c.ecc17 = TextBox284.Text;
        c.ecc18 = TextBox285.Text;
        c.ecc19 = TextBox328.Text;
        c.Insert_Data_IRC_FRC_2();
    }
    protected void ddlClass_SelectedIndexChanged(object sender, EventArgs e)
    {
        Fill_LocoNo();
    }
    protected void ddlSchedule_SelectedIndexChanged(object sender, EventArgs e)
    {
        gv1.DataSource = c.Select_Data_gv1(ddlSchedule.SelectedValue.ToString());

        gv1.DataBind();
       gv2.DataSource = c.Select_Data_gv2(ddlSchedule.SelectedValue.ToString());

        gv2.DataBind();
    }
}
