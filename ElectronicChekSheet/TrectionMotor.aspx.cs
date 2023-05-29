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

public partial class ElectronicChekSheet_TrectionMotor : System.Web.UI.Page
{
    Cls_traction_motor c = new Cls_traction_motor();
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
    public void Fill_Schedule()
    {
        ddlSchedule.Items.Clear();
        Cls_jos_railway_loco_type_schedule c = new Cls_jos_railway_loco_type_schedule();
        //c.loco_id = ddlClass.SelectedValue.ToString();
        ddlSchedule.DataSource = c.Select_Data_schedule();
        ddlSchedule.DataTextField = "Schedule_Type";
        ddlSchedule.DataValueField = "id_loco_sch";
        ddlSchedule.DataBind();
        ddlSchedule.Items.Insert(0, "SELECT");
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Fill_section();
            Fill_Super();
            Fill_Tech();
            Fill_Class();
        }
    }
    protected void btnInsert_Click(object sender, EventArgs e)
    {
        c.id_mst_loco = ddlLocono.SelectedValue.ToString();
        c.id_loco_sch = ddlSchedule.SelectedValue.ToString();
        c.date1 = txtdate.Text;
        c.id_hr_tech = ddlTech.SelectedValue.ToString();
        c.w_start = txtstart.Text;
        c.w_finish = txtfinish.Text;
        c.id_hr_super = ddlSuper.SelectedValue.ToString();
        c.r11 = TextBox1.Text;
        c.r12 = TextBox2.Text;
        c.r13 = TextBox3.Text;
        c.r14 = TextBox4.Text;
        c.r15 = TextBox5.Text;
        c.r16 = TextBox6.Text;
        c.r21 = TextBox7.Text;
        c.r22 = TextBox8.Text;
        c.r23 = TextBox9.Text;
        c.r24 = TextBox10.Text;
        c.r25 = TextBox11.Text;
        c.r26 = TextBox12.Text;
        c.rb1 = TextBox13.Text;
        c.rb2 = TextBox14.Text;
        c.rb3 = TextBox15.Text;
        c.rb4 = TextBox16.Text;
        c.rb5 = TextBox17.Text;
        c.rb6 = TextBox18.Text;
        //---------------------------
        c.rc1 = TextBox19.Text;
        c.rc2 = TextBox20.Text;
        c.rc3 = TextBox21.Text;
        c.rc4 = TextBox22.Text;
        c.rc5 = TextBox23.Text;
        c.rc6 = TextBox24.Text;
        c.r31 = TextBox25.Text;
        c.r32 = TextBox26.Text;
        c.r33 = TextBox27.Text;
        c.r34 = TextBox28.Text;
        c.r35 = TextBox29.Text;
        c.r36 = TextBox30.Text;
        c.r41 = TextBox31.Text;
        c.r42 = TextBox32.Text;
        c.r43 = TextBox33.Text;
        c.r44 = TextBox34.Text;
        c.r45 = TextBox35.Text;
        c.r46 = TextBox36.Text;
        c.r51 = TextBox37.Text;
        c.r52 = TextBox38.Text;
        c.r53 = TextBox39.Text;
        c.r54 = TextBox40.Text;
        c.r55 = TextBox41.Text;
        c.r56 = TextBox42.Text;
        //----------------------------
        c.r61 = TextBox43.Text;
        c.r62 = TextBox44.Text;
        c.r63 = TextBox45.Text;
        c.r64 = TextBox46.Text;
        c.r65 = TextBox47.Text;
        c.r66 = TextBox48.Text;

        c.r71 = TextBox49.Text;
        c.r72 = TextBox50.Text;
        c.r73 = TextBox51.Text;
        c.r74 = TextBox52.Text;
        c.r75 = TextBox53.Text;
        c.r76 = TextBox54.Text;

        c.r81 = TextBox55.Text;
        c.r82 = TextBox56.Text;
        c.r83 = TextBox57.Text;
        c.r84 = TextBox58.Text;
        c.r85 = TextBox59.Text;
        c.r86 = TextBox60.Text;

        c.rAngle = TextBox61.Text;
        c.rPlate = TextBox62.Text;
        c.rGuard = TextBox63.Text;
        c.rPlug = TextBox64.Text;
        c.rTest = TextBox65.Text;
        c.note1 = TextBox66.Text;
        c.note2 = TextBox67.Text;
        c.Insert_Data();
        Clear_data();

    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Clear_data();
    }
    protected void Clear_data()
    {
        txtdate.Text = "";
        txtfinish.Text = "";
        txtstart.Text = "";

        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox6.Text = "";
        TextBox7.Text = "";
        TextBox8.Text = "";
        TextBox9.Text = "";
        //-----------------------------
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
        //-------------------------------------------
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

    }
    protected void ddlClass_SelectedIndexChanged(object sender, EventArgs e)
    {
        Fill_LocoNo();
    }
    protected void ddlLocono_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        Fill_Schedule();
    }
    protected void ddlSection_SelectedIndexChanged(object sender, EventArgs e)
    {
        Fill_Card();
    }
    protected void ddlCard_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlCard.SelectedIndex != '0')
        { 
            p1.Visible = true;
        }
        else { 
            p1.Visible = false;
        }

    }
}
