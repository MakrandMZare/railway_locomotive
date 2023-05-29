using System;
using System.Collections;
using System.Configuration;
using System.Data;
//using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
//using System.Xml.Linq;
using Railway;
using System.Data.SqlClient;


public partial class Loco_Loco_In : System.Web.UI.Page
{
    Cls_jos_railway_loco_in obj = new Cls_jos_railway_loco_in();
    public void Fill_TemporaryRepairData()
    {
        DataTable dt = obj.Get_TemporaryRepairData(ddlLocono.SelectedValue.ToString());
        if (dt.Rows.Count > 0)
        {
            lblHeader.Text = "TEMPORARY REPAIR";
            TempRepair.DataSource = dt;
            TempRepair.DataBind();
            ViewState["TemporaryRepairId"] = dt.Rows[0]["rid"].ToString();
            txtRemarks.Text = dt.Rows[0]["reason"].ToString();
        }
    }
    public void Fill_DeadOnlineData()
    {
        DataTable dt = obj.Get_DeadOnlineData(ddlLocono.SelectedValue.ToString());
        if (dt.Rows.Count > 0)
        {

            lblHeader.Text = "DEAD ON LINE";

            gvDeadOnline.DataSource = dt;
            gvDeadOnline.DataBind();
            ViewState["DeadOnlineId"] = dt.Rows[0]["rid"].ToString();
            txtRemarks.Text = dt.Rows[0]["REPOTED REASON"].ToString();
        }
    }
    public void Fill_Class()
    {
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
        ddlLastSchedule.Items.Clear();

        Cls_jos_railway_loco_type_schedule c = new Cls_jos_railway_loco_type_schedule();
        c.loco_id = ddlClass.SelectedValue.ToString();
        ddlSchedule.DataSource = c.Select_Data();
        ddlSchedule.DataTextField = "Schedule_Type";
        ddlSchedule.DataValueField = "id_loco_sch";
        ddlSchedule.DataBind();
        ddlSchedule.Items.Insert(0, "SELECT");
        ddlLastSchedule.DataSource = c.Select_Data();
        ddlLastSchedule.DataTextField = "Schedule_Type";
        ddlLastSchedule.DataValueField = "id_loco_sch";
        ddlLastSchedule.DataBind();
        ddlLastSchedule.Items.Insert(0, "SELECT");
    }
    public void Fill_HQ()
    {
        ddlHq.Items.Clear();
        Cls_jos_railway_mst_Hq c = new Cls_jos_railway_mst_Hq();
        ddlHq.DataSource = c.Select_Data();
        ddlHq.DataTextField = "name";
        ddlHq.DataValueField = "id_mst_hq";
        ddlHq.DataBind();
        ddlHq.Items.Insert(0, "SELECT");

    }
    public void Fill_TNCName()
    {

        ddlTncName.Items.Clear();
        Cls_jos_railway_Hr c = new Cls_jos_railway_Hr();
        ddlTncName.DataSource = c.Select_Fullname();
        ddlTncName.DataTextField = "sname";
        ddlTncName.DataValueField = "id";
        ddlTncName.DataBind();
        ddlTncName.Items.Insert(0, "SELECT");
    }
    public string tempstr(string str)
    {
        return str.Length == 1 ? ("0" + str) : str;
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            
            txtArrivalDate.Text = tempstr(System.DateTime.Now.Day.ToString()) + "/" + tempstr(System.DateTime.Now.Month.ToString()) + "/" + tempstr(System.DateTime.Now.Year.ToString());
            Fill_Class();
            //Fill_Schedule();
            Fill_HQ();
            Fill_TNCName();
            DateTime t1 = DateTime.Now;
            ddlArrivalTime1.Text = t1.Hour.ToString();
            ddlArrivalTime2.Text = t1.Minute.ToString();
            if (ddlArrivalTime1.Text.Length < 2)
            { ddlArrivalTime1.Text = "0" + ddlArrivalTime1.Text; }
            if (ddlArrivalTime2.Text.Length < 2)
            { ddlArrivalTime2.Text = "0" + ddlArrivalTime2.Text; }
            if (ddlArrivalTime1.Text != "00")
            {
                if (Convert.ToInt16(ddlArrivalTime1.Text) > 0 && Convert.ToInt16(ddlArrivalTime1.Text) < 8)
                {
                    lblShift.Text = "SHIFT :  0 / 8 ";
                }
                if (Convert.ToInt16(ddlArrivalTime1.Text) > 8 && Convert.ToInt16(ddlArrivalTime1.Text) < 16)
                {
                    lblShift.Text = "SHIFT :  8 / 16 ";
                }
                if (Convert.ToInt16(ddlArrivalTime1.Text) > 16 && Convert.ToInt16(ddlArrivalTime1.Text) < 24)
                {
                    lblShift.Text = "SHIFT :  16 / 24 ";
                }
            }

            if ((string)Request.QueryString["id"] != null)
            {
                obj.id_loco_in = Request.QueryString["id"].ToString();
                DataTable dt = obj.Select_DataById();
                ddlClass.SelectedIndex = ddlClass.Items.IndexOf(ddlClass.Items.FindByValue(dt.Rows[0][1].ToString()));
                Fill_LocoNo();
                ddlLocono.SelectedIndex = ddlLocono.Items.IndexOf(ddlLocono.Items.FindByValue(dt.Rows[0][2].ToString()));
                txtArrivalDate.Text = dt.Rows[0][3].ToString().Substring(3, 2) + "/" + dt.Rows[0][3].ToString().Substring(0, 2) + "/" + dt.Rows[0][3].ToString().Substring(6, 4);
                string temp = dt.Rows[0][4].ToString();
                //ddlArrivalTime1.SelectedIndex = ddlArrivalTime1.Items.IndexOf(ddlArrivalTime1.Items.FindByValue(temp.Substring(0,2)));
                //ddlArrivalTime2.SelectedIndex = ddlArrivalTime2.Items.IndexOf(ddlArrivalTime2.Items.FindByValue(temp.Substring(3,2)));
                ddlArrivalTime1.Text = temp.Substring(0, 2);
                ddlArrivalTime2.Text = temp.Substring(3, 2);
                //timeremaindt.Rows[0][3].ToString();
                Fill_Schedule();
                ddlSchedule.SelectedIndex = ddlSchedule.Items.IndexOf(ddlSchedule.Items.FindByValue(dt.Rows[0][5].ToString()));
                txtDescription.Text = dt.Rows[0][6].ToString();
                txtTrainno.Text = dt.Rows[0][7].ToString();
                txtLastOutDate.Text = dt.Rows[0][8].ToString().Substring(3, 2) + "/" + dt.Rows[0][8].ToString().Substring(0, 2) + "/" + dt.Rows[0][8].ToString().Substring(6, 4);
                ddlLastSchedule.SelectedIndex = ddlLastSchedule.Items.IndexOf(ddlLastSchedule.Items.FindByValue(dt.Rows[0][9].ToString()));
                ddlHq.SelectedIndex = ddlHq.Items.IndexOf(ddlHq.Items.FindByValue(dt.Rows[0][10].ToString()));
                txtDriverName.Text = dt.Rows[0][11].ToString();
                txtLubelevel.Text = dt.Rows[0][12].ToString();
                txtFulelevel.Text = dt.Rows[0][13].ToString();
                if (dt.Rows[0][14].ToString() == "True")
                {
                    rdoDriverBook.SelectedIndex = 0;
                }
                else
                {
                    rdoDriverBook.SelectedIndex = 1;
                }
                if (dt.Rows[0][15].ToString() == "True")
                {
                    rdoReverserKey.SelectedIndex = 0;
                }
                else
                {
                    rdoReverserKey.SelectedIndex = 1;
                }
                if (dt.Rows[0][16].ToString() == "True")
                {
                    rdpPcpset.SelectedIndex = 0;
                }
                else
                {
                    rdpPcpset.SelectedIndex = 1;
                }
                if (dt.Rows[0][17].ToString() == "True")
                {
                    rdoFireExtingusher.SelectedIndex = 0;
                }
                else
                {
                    rdoFireExtingusher.SelectedIndex = 1;
                }
                ddlTncName.SelectedIndex = ddlTncName.Items.IndexOf(ddlTncName.Items.FindByValue(dt.Rows[0][18].ToString()));
                txtShiftDate.Text = dt.Rows[0][19].ToString().Substring(3, 2) + "/" + dt.Rows[0][19].ToString().Substring(0, 2) + "/" + dt.Rows[0][19].ToString().Substring(6, 4);
                txtBookedRepair.Text = dt.Rows[0][20].ToString();
                txtRemarks.Text = dt.Rows[0][21].ToString();
                Cls_jos_railway_fire_detail c1 = new Cls_jos_railway_fire_detail();
                c1.mid = Request.QueryString["id"].ToString();
                DataTable dtfire = c1.Select_DataById();
                if (dtfire.Rows.Count == 1)
                {
                    //Fill First Row
                    txtsr1.Text = dtfire.Rows[0][3].ToString();
                    txtfire1.Text = dtfire.Rows[0][2].ToString().Substring(3, 2) + "/" + dtfire.Rows[0][2].ToString().Substring(0, 2) + "/" + dtfire.Rows[0][2].ToString().Substring(6, 4);
                    ViewState["i1"] = dtfire.Rows[0][0].ToString();
                }
                if (dtfire.Rows.Count == 2)
                {
                    //Fill Second Row
                    txtsr2.Text = dtfire.Rows[1][3].ToString();
                    txtfire2.Text = dtfire.Rows[1][2].ToString().Substring(3, 2) + "/" + dtfire.Rows[1][2].ToString().Substring(0, 2) + "/" + dtfire.Rows[1][2].ToString().Substring(6, 4);
                    ViewState["i2"] = dtfire.Rows[1][0].ToString();



                }
                if (dtfire.Rows.Count == 3)
                {
                    //Fill Third Row
                    txtsr3.Text = dtfire.Rows[2][3].ToString();
                    txtfire3.Text = dtfire.Rows[2][2].ToString().Substring(3, 2) + "/" + dtfire.Rows[2][2].ToString().Substring(0, 2) + "/" + dtfire.Rows[2][2].ToString().Substring(6, 4);
                    ViewState["i3"] = dtfire.Rows[2][0].ToString();

                }
                if (dtfire.Rows.Count == 4)
                {
                    //Fill Fourth Row
                    txtsr4.Text = dtfire.Rows[3][3].ToString();
                    txtfire4.Text = dtfire.Rows[3][2].ToString().Substring(3, 2) + "/" + dtfire.Rows[3][2].ToString().Substring(0, 2) + "/" + dtfire.Rows[3][2].ToString().Substring(6, 4);
                    ViewState["i4"] = dtfire.Rows[3][0].ToString();
                }
                btnSave.Text = "UPDATE";
            }

        }
    }
    protected void InsertData()
    {
        //Assign Data To Insert
        obj.type_id = ddlClass.SelectedValue.ToString();
        obj.loco_id = ddlLocono.SelectedValue.ToString();
        obj.a_date = txtArrivalDate.Text.Substring(3, 2).ToString() + "/" + txtArrivalDate.Text.Substring(0, 2).ToString() + "/" + txtArrivalDate.Text.Substring(6, 4).ToString();
        obj.a_time = ddlArrivalTime1.Text + ":" + ddlArrivalTime2.Text + ":00";
        obj.action = txtRemarks.Text;
        obj.booked = txtBookedRepair.Text;




        if (rdoDriverBook.SelectedIndex == 0)
        { obj.d_book = "True"; }
        else { obj.d_book = "False"; }

        if (rdoReverserKey.SelectedIndex == 0)
        { obj.r_key = "True"; }
        else
        { obj.r_key = "False"; }

        if (rdpPcpset.SelectedIndex == 0)
        { obj.d_set = "True"; }
        else
        { obj.d_set = "False"; }

        if (rdoFireExtingusher.SelectedIndex == 0)
        { obj.f_ext = "True"; }
        else
        { obj.f_ext = "False"; }


        obj.hq = ddlHq.SelectedValue.ToString();
        obj.f_level = txtFulelevel.Text;
        if (txtLastOutDate.Text != "")
        {
            obj.l_date = txtLastOutDate.Text.Substring(3, 2) + "/" + txtLastOutDate.Text.Substring(0, 2) + "/" + txtLastOutDate.Text.Substring(6, 4);
        }
        else
        {
            obj.l_date = "";
        }
        obj.l_oil = txtLubelevel.Text;
        obj.l_sch = ddlLastSchedule.SelectedValue.ToString();
        obj.loco_id = ddlLocono.SelectedValue.ToString();
        //obj.shift = ddlShift.SelectedValue.ToString();
        obj.desc_sche = txtDescription.Text;

        obj.sid = ddlSchedule.SelectedValue.ToString();
        obj.sname = txtDriverName.Text;
        obj.tnc_name = ddlTncName.SelectedValue.ToString();
        obj.tid = txtTrainno.Text;
        obj.avaibility = "true";
        obj.shift_date = txtShiftDate.Text.Substring(3, 2).ToString() + "/" + txtShiftDate.Text.Substring(0, 2).ToString() + "/" + txtShiftDate.Text.Substring(6, 4).ToString();
        Int64 m = obj.Insert_Data();
        Cls_jos_railway_fire_detail c = new Cls_jos_railway_fire_detail();
        if (txtsr1.Text != "" && txtfire1.Text != "")
        {
            c.mid = m.ToString();
            c.l_type = "Loco In";
            c.srno = txtsr1.Text;

            c.fdate = txtfire1.Text.Substring(3, 2).ToString() + "/" + txtfire1.Text.Substring(0, 2).ToString() + "/" + txtfire1.Text.Substring(6, 4).ToString();
            c.Insert_Data();
        }
        if (txtsr2.Text != "" && txtfire2.Text != "")
        {
            c.mid = m.ToString();
            c.l_type = "Loco In";
            c.srno = txtsr2.Text;
            c.fdate = txtfire2.Text.Substring(3, 2).ToString() + "/" + txtfire2.Text.Substring(0, 2).ToString() + "/" + txtfire2.Text.Substring(6, 4).ToString();
            c.Insert_Data();
        }
        if (txtsr3.Text != "" && txtfire3.Text != "")
        {
            c.mid = m.ToString();
            c.l_type = "Loco In";
            c.srno = txtsr3.Text;
            c.fdate = txtfire3.Text.Substring(3, 2).ToString() + "/" + txtfire3.Text.Substring(0, 2).ToString() + "/" + txtfire3.Text.Substring(6, 4).ToString();
            c.Insert_Data();
        }
        if (txtsr4.Text != "" && txtfire4.Text != "")
        {
            c.mid = m.ToString();
            c.l_type = "Loco In";
            c.srno = txtsr4.Text;
            c.fdate = txtfire4.Text.Substring(3, 2).ToString() + "/" + txtfire4.Text.Substring(0, 2).ToString() + "/" + txtfire4.Text.Substring(6, 4).ToString();
            c.Insert_Data();
        }
        //----------------Insert MG Data
        if (MeterguagePh.Visible == true)
        {
            Cls_jos_railway_loco_in_mg mgc = new Cls_jos_railway_loco_in_mg();
            mgc.WheelDia = txtMGWheelDia.Text;
            mgc.id_loco_in = m.ToString();
            mgc.Pass = ddlMGPass.SelectedValue.ToString();
            mgc.PDC = txtMGPDC.Text != null ? txtMGPDC.Text.Substring(3, 2) + "/" + txtMGPDC.Text.Substring(0, 2) + "/" + txtMGPDC.Text.Substring(6, 4) : "";
            mgc.Insert_Data();
        }

    }
    protected void Updatation()
    {
        //Assign Data To Insert
        obj.id_loco_in = Request.QueryString["id"].ToString();
        obj.type_id = ddlClass.SelectedValue.ToString();
        obj.loco_id = ddlLocono.SelectedValue.ToString();
        obj.a_date = txtArrivalDate.Text.Substring(3, 2).ToString() + "/" + txtArrivalDate.Text.Substring(0, 2).ToString() + "/" + txtArrivalDate.Text.Substring(6, 4).ToString();
        //obj.a_date = txtArrivalDate.Text;
        obj.a_time = ddlArrivalTime1.Text + ":" + ddlArrivalTime2.Text + ":00";
        obj.action = txtRemarks.Text;
        obj.booked = txtBookedRepair.Text;




        if (rdoDriverBook.SelectedIndex == 0)
        { obj.d_book = "True"; }
        else { obj.d_book = "False"; }

        if (rdoReverserKey.SelectedIndex == 0)
        { obj.r_key = "True"; }
        else
        { obj.r_key = "False"; }

        if (rdpPcpset.SelectedIndex == 0)
        { obj.d_set = "True"; }
        else
        { obj.d_set = "False"; }

        if (rdoFireExtingusher.SelectedIndex == 0)
        { obj.f_ext = "True"; }
        else
        { obj.f_ext = "False"; }


        obj.hq = ddlHq.SelectedValue.ToString();
        obj.f_level = txtFulelevel.Text;
        obj.l_date = txtLastOutDate.Text.Substring(3, 2) + "/" + txtLastOutDate.Text.Substring(0, 2) + "/" + txtLastOutDate.Text.Substring(6, 4);
        obj.l_oil = txtLubelevel.Text;
        obj.l_sch = ddlLastSchedule.SelectedValue.ToString();
        obj.loco_id = ddlLocono.SelectedValue.ToString();
        //obj.shift = ddlShift.SelectedValue.ToString();
        obj.desc_sche = txtDescription.Text;

        obj.sid = ddlSchedule.SelectedValue.ToString();
        obj.sname = txtDriverName.Text;
        obj.tnc_name = ddlTncName.SelectedValue.ToString();
        obj.tid = txtTrainno.Text;
        obj.shift_date = txtShiftDate.Text.Substring(3, 2) + "/" + txtShiftDate.Text.Substring(0, 2) + "/" + txtShiftDate.Text.Substring(6, 4);
        Int64 m = obj.Update_Data();
        Cls_jos_railway_fire_detail c = new Cls_jos_railway_fire_detail();
        if (txtsr1.Text != "" && txtfire1.Text != "")
        {
            c.mid = Request.QueryString["id"].ToString();
            c.l_type = "Loco In";
            c.id_firedet = ViewState["i1"].ToString();
            c.srno = txtsr1.Text;

            c.fdate = txtfire1.Text.Substring(3, 2).ToString() + "/" + txtfire1.Text.Substring(0, 2).ToString() + "/" + txtfire1.Text.Substring(6, 4).ToString();
            c.Update_Data();
        }
        if (txtsr2.Text != "" && txtfire2.Text != "")
        {
            c.mid = Request.QueryString["id"].ToString();
            c.l_type = "Loco In";
            c.id_firedet = ViewState["i2"].ToString();
            c.srno = txtsr2.Text;
            c.fdate = txtfire2.Text.Substring(3, 2).ToString() + "/" + txtfire2.Text.Substring(0, 2).ToString() + "/" + txtfire2.Text.Substring(6, 4).ToString();
            c.Update_Data();
        }
        if (txtsr3.Text != "" && txtfire3.Text != "")
        {
            c.mid = Request.QueryString["id"].ToString();
            c.l_type = "Loco In";
            c.id_firedet = ViewState["i3"].ToString();
            c.srno = txtsr3.Text;
            c.fdate = txtfire3.Text.Substring(3, 2).ToString() + "/" + txtfire3.Text.Substring(0, 2).ToString() + "/" + txtfire3.Text.Substring(6, 4).ToString();
            c.Update_Data();
        }
        if (txtsr4.Text != "" && txtfire4.Text != "")
        {
            c.mid = Request.QueryString["id"].ToString();
            c.l_type = "Loco In";
            c.id_firedet = ViewState["i4"].ToString();
            c.srno = txtsr4.Text;
            c.fdate = txtfire4.Text.Substring(3, 2).ToString() + "/" + txtfire4.Text.Substring(0, 2).ToString() + "/" + txtfire4.Text.Substring(6, 4).ToString();
            c.Update_Data();
        }

    }
    protected void ddlArrivalTime1_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlArrivalTime1.Text != "")
        {
            if (Convert.ToInt16(ddlArrivalTime1.Text) > 0 && Convert.ToInt16(ddlArrivalTime1.Text) < 8)
            {
                lblShift.Text = "SHIFT :  0 / 8 ";
            }
            if (Convert.ToInt16(ddlArrivalTime1.Text) > 8 && Convert.ToInt16(ddlArrivalTime1.Text) < 16)
            {
                lblShift.Text = "SHIFT :  8 / 16 ";
            }
            if (Convert.ToInt16(ddlArrivalTime1.Text) > 16 && Convert.ToInt16(ddlArrivalTime1.Text) < 24)
            {
                lblShift.Text = "SHIFT :  16 / 24 ";
            }
        }
    }
    protected void btnSave_OnClick(object sender, EventArgs e)
    {
        if (btnSave.Text == "INSERT")
        {
            InsertData();
            //Make Temporay Repair Unavailable
            if (ViewState["TemporaryRepairId"] != null)
            {
                Cls_jos_railway_Loco_Temporary_Repair c1 = new Cls_jos_railway_Loco_Temporary_Repair();
                c1.Id_Loco_Temp_Repair = ViewState["TemporaryRepairId"].ToString();
                c1.Make_Loco_Unavailable();
            }
            //Make Dead online Unavailable
            if (ViewState["DeadOnlineId"] != null)
            {
                Cls_jos_railway_shed_pos3 c2 = new Cls_jos_railway_shed_pos3();
                c2.id_shed_Pos3 = ViewState["DeadOnlineId"].ToString();
                c2.Make_Loco_Unavailable();
            }
        }
        else if (btnSave.Text == "UPDATE")
        {
            Updatation();
        }
        Response.Redirect("~/Loco/View_Locolist.aspx");
    }
    protected void ddlClass_SelectedIndexChanged(object sender, EventArgs e)
    {
        Fill_LocoNo();
        Fill_Schedule();
        Cls_Master_Loco_Type c = new Cls_Master_Loco_Type();
        c.id_ltype = ddlClass.SelectedValue.ToString();
        lblguage.Text = "";
        lblguage.Visible = true;
        lblguage.Text = c.Get_LocoGuageByLocotype();
        if (lblguage.Text == "METER GUAGE")
        {
            MeterguagePh.Visible = true;
        }
        else
        {
            MeterguagePh.Visible = false;
        }

    }
    public void Fill_LastOutDate_n_Schedule()
    {
        Cls_jos_railway_loco_in c = new Cls_jos_railway_loco_in();
        c.loco_id = ddlLocono.SelectedValue.ToString();
        DataTable dt = c.Get_LastOutDate_n_ScheduleOfLoco();
        if (dt.Rows.Count > 0)
        {
            txtLastOutDate.Text = dt.Rows[0]["LastOutDate"].ToString();
            ddlLastSchedule.SelectedIndex = ddlLastSchedule.Items.IndexOf(ddlLastSchedule.Items.FindByValue(dt.Rows[0]["LastSchedule"].ToString()));
        }
        else
        {
            txtLastOutDate.Text = "";
            ddlLastSchedule.SelectedIndex = 0;

        }
    }
    protected void ddlLocono_SelectedIndexChanged(object sender, EventArgs e)
    {
        Fill_LastOutDate_n_Schedule();
        Fill_TemporaryRepairData();
        Fill_DeadOnlineData();
        if (gvDeadOnline.Rows.Count == 0 && TempRepair.Rows.Count == 0)
        {
            p1.Visible = false;
        }
        else
        {
            p1.Visible = true;
        }


    }
}
