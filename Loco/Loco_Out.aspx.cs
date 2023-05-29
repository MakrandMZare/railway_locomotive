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
public partial class Loco_Out : System.Web.UI.Page
{
    Cls_jos_railway_loco_out obj = new Cls_jos_railway_loco_out();

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
        try
        {
            Cls_jos_railway_loco_in c = new Cls_jos_railway_loco_in();
            c.type_id = ddlClass.SelectedValue.ToString();

            ddlLocono.DataSource = c.Select_LocoNo_From_LocoIn();
            ddlLocono.DataTextField = "locono";
            ddlLocono.DataValueField = "locoid";
            ddlLocono.DataBind();
            ddlLocono.Items.Insert(0, "SELECT");
        }
        catch { }
    }
    protected void Fill_Schedule()
    {
        ddlSchedule.Items.Clear();
        //ddlLastSchedule.Items.Clear();
        Cls_jos_railway_loco_type_schedule c = new Cls_jos_railway_loco_type_schedule();
        c.loco_id = ddlClass.SelectedValue.ToString();
        ddlSchedule.DataSource = c.Select_Data();
        ddlSchedule.DataTextField = "Schedule_Type";
        ddlSchedule.DataValueField = "id_loco_sch";
        ddlSchedule.DataBind();
        ddlSchedule.Items.Insert(0, "SELECT");
        //// ddlSchedule.ValueMember = "id";
        //ddlLastSchedule.DataSource = c.Select_Data();
        //ddlLastSchedule.DisplayMember = "Schedule_Type";
        //ddlLastSchedule.ValueMember = "id_loco_sch";
    }
    protected void Fill_Hq()
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
        ddlTncName.Items.Insert(1, "ADD NEW");
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Fill_Class();
            //Fill_Schedule();
            Fill_Hq();
            Fill_TNCName();
            //Fill_Fire();
            DateTime t1 = System.DateTime.Now;
            txtArrivalDate.Text = System.DateTime.Now.ToString("dd/MM/yyyy");
            ddlArrivalTime1.Text = t1.Hour.ToString();
            ddlArrivalTime2.Text = t1.Minute.ToString();
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
                obj.id_loco_out = Request.QueryString["id"].ToString();
                DataTable dt = obj.Select_DataById();
                ddlClass.SelectedIndex = ddlClass.Items.IndexOf(ddlClass.Items.FindByValue(dt.Rows[0][1].ToString()));
                //Fill loco From Loco Out
                obj.tid = ddlClass.SelectedValue.ToString();
                ddlLocono.DataSource = obj.Select_Loco();
                ddlLocono.DataTextField = "locono";
                ddlLocono.DataValueField = "id_mst_loco";
                ddlLocono.DataBind();
                ddlLocono.SelectedIndex = ddlLocono.Items.IndexOf(ddlLocono.Items.FindByValue(dt.Rows[0][2].ToString()));
                txtArrivalDate.Text = dt.Rows[0]["A_DATE"].ToString();
                string temp = dt.Rows[0]["A_TIME"].ToString();
                //ddlArrivalTime1.SelectedIndex = ddlArrivalTime1.Items.IndexOf(ddlArrivalTime1.Items.FindByValue(temp.Substring(0, 2)));
                //ddlArrivalTime2.SelectedIndex = ddlArrivalTime2.Items.IndexOf(ddlArrivalTime2.Items.FindByValue(temp.Substring(3, 2)));
                ddlArrivalTime1.Text = temp.Substring(0, 2);
                ddlArrivalTime2.Text = temp.Substring(3, 2);
                Fill_Schedule();
                Fill_Fire();
                ddlSchedule.SelectedIndex = ddlSchedule.Items.IndexOf(ddlSchedule.Items.FindByValue(dt.Rows[0][5].ToString()));
                txtDescription.Text = dt.Rows[0][6].ToString();
                txtTrainno.Text = dt.Rows[0][7].ToString();
                ddlHq.SelectedIndex = ddlHq.Items.IndexOf(ddlHq.Items.FindByValue(dt.Rows[0][8].ToString()));
                txtDriverName.Text = dt.Rows[0][9].ToString();
                txtLubelevel.Text = dt.Rows[0][10].ToString();
                txtFulelevel.Text = dt.Rows[0][11].ToString();
                if (dt.Rows[0][12].ToString() == "True")
                {
                    rdoDriverBook.SelectedIndex = 0;
                }
                else
                {
                    rdoDriverBook.SelectedIndex = 1;
                }
                if (dt.Rows[0][13].ToString() == "True")
                {
                    rdoReverserKey.SelectedIndex = 0;
                }
                else
                {
                    rdoDriverBook.SelectedIndex = 1;
                }
                if (dt.Rows[0][14].ToString() == "True")
                {
                    rdpPcpset.SelectedIndex = 0;
                }
                else
                {
                    rdpPcpset.SelectedIndex = 1;
                }
                if (dt.Rows[0][15].ToString() == "True")
                {
                    rdoFireExtingusher.SelectedIndex = 0;
                }
                else
                {
                    rdoFireExtingusher.SelectedIndex = 1;
                }
                ddlTncName.SelectedIndex = ddlTncName.Items.IndexOf(ddlTncName.Items.FindByValue(dt.Rows[0][16].ToString()));
                string tempstr = dt.Rows[0][17].ToString();
                txtShiftDate.Text = tempstr.Substring(3, 2) + "/" + tempstr.Substring(0, 2) + "/" + tempstr.Substring(6, 4);
                txtReason.Text = dt.Rows[0][18].ToString();
                txtRemarks.Text = dt.Rows[0][19].ToString();
                Cls_jos_railway_fire_detail_out c1 = new Cls_jos_railway_fire_detail_out();

                Cls_jos_railway_fire_detail c = new Cls_jos_railway_fire_detail();
                c1.mid = Request.QueryString["id"].ToString();
                DataTable dtfire = c.Select_DataById();
                if (dtfire.Rows.Count == 1)
                {
                    txtsr1.Text = dtfire.Rows[0][3].ToString();
                    txtfire1.Text = dtfire.Rows[0][2].ToString();
                    ViewState["i1"] = dtfire.Rows[0][0].ToString();
                }
                if (dtfire.Rows.Count == 2)
                {
                    txtsr2.Text = dtfire.Rows[1][3].ToString();
                    txtfire2.Text = dtfire.Rows[1][2].ToString();
                    ViewState["i2"] = dtfire.Rows[1][0].ToString();
                }
                if (dtfire.Rows.Count == 3)
                {
                    txtsr3.Text = dtfire.Rows[2][3].ToString();
                    txtfire3.Text = dtfire.Rows[2][2].ToString();
                    ViewState["i3"] = dtfire.Rows[2][0].ToString();
                }
                if (dtfire.Rows.Count == 4)
                {
                    txtsr4.Text = dtfire.Rows[3][3].ToString();
                    txtfire4.Text = dtfire.Rows[3][2].ToString();
                    ViewState["i4"] = dtfire.Rows[3][0].ToString();
                }

                btnSave.Text = "UPDATE";
            }

        }

    }

    protected void Insertion()
    {
        //Assign Data To Insert
        obj.type_id = ddlClass.SelectedValue.ToString();
        obj.loco_id = ddlLocono.SelectedValue.ToString();
        obj.a_date = txtArrivalDate.Text.Substring(3, 2).ToString() + "/" + txtArrivalDate.Text.Substring(0, 2).ToString() + "/" + txtArrivalDate.Text.Substring(6, 4).ToString();
        //obj.a_date = txtArrivalDate.Text;
        obj.a_time = ddlArrivalTime1.Text + ":" + ddlArrivalTime2.Text + ":00";
        obj.action = txtReason.Text;
        obj.booked = txtRemarks.Text;

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
        //mltobj.l_date = dtLOD.Value.ToString();
        obj.l_oil = txtLubelevel.Text;
        ///mltobj.l_sch = ddlLastSchedule.SelectedValue.ToString();
        obj.loco_id = ddlLocono.SelectedValue.ToString();
        //mltobj.shift = ddlShift.SelectedValue.ToString();
        obj.desc_sche = txtDescription.Text;

        obj.sid = ddlSchedule.SelectedValue.ToString();
        obj.sname = txtDriverName.Text;
        obj.tnc_name = ddlTncName.SelectedValue.ToString();
        obj.tid = txtTrainno.Text;
        //obj.shift_date = txtShiftDate.Text;
        obj.shift_date = txtShiftDate.Text.Substring(3, 2).ToString() + "/" + txtShiftDate.Text.Substring(0, 2).ToString() + "/" + txtShiftDate.Text.Substring(6, 4).ToString();
        Int64 m = obj.Insert_Data();

        Cls_jos_railway_fire_detail_out c = new Cls_jos_railway_fire_detail_out();
        //Cls_jos_railway_fire_detail_out c = new Cls_jos_railway_fire_detail_out();

        if (txtsr1.Text != "")
        {
            c.mid = m.ToString();
            c.l_type = "Loco out";
            c.srno = txtsr1.Text;
            //c.fdate = txtfire1.Text;
            c.fdate = txtfire1.Text.Substring(3, 2).ToString() + "/" + txtfire1.Text.Substring(0, 2).ToString() + "/" + txtfire1.Text.Substring(6, 4).ToString();
            c.Insert_Data();
        }
        if (txtsr2.Text != "")
        {
            c.mid = m.ToString();
            c.l_type = "Loco out";
            c.srno = txtsr2.Text;
            c.fdate = txtfire2.Text.Substring(3, 2).ToString() + "/" + txtfire2.Text.Substring(0, 2).ToString() + "/" + txtfire2.Text.Substring(6, 4).ToString();
            c.Insert_Data();
        }
        if (txtsr3.Text != "")
        {
            c.mid = m.ToString();
            c.l_type = "Loco out";
            c.srno = txtsr3.Text;
            c.fdate = txtfire3.Text.Substring(3, 2).ToString() + "/" + txtfire3.Text.Substring(0, 2).ToString() + "/" + txtfire3.Text.Substring(6, 4).ToString();
            c.Insert_Data();
        }
        if (txtsr4.Text != "")
        {
            c.mid = m.ToString();
            c.l_type = "Loco out";
            c.srno = txtsr4.Text;
            c.fdate = txtfire4.Text.Substring(3, 2).ToString() + "/" + txtfire4.Text.Substring(0, 2).ToString() + "/" + txtfire4.Text.Substring(6, 4).ToString();
            c.Insert_Data();
        }
        //Make loco unavailable
        Cls_jos_railway_loco_in locoinobj = new Cls_jos_railway_loco_in();
        locoinobj.loco_id = ddlLocono.SelectedValue.ToString();
        if (locoinobj.Check_Loco_Avaibility())
        {
            locoinobj.Make_Loco_Unavailable();
        }
        else
        {
            Response.Write("<script language='javascript'> alert('Sorry... Selected Loco is not available...!');</script>");
        }
        Response.Redirect("~/Loco/View_Locooutdetails.aspx?id=" + m);
    }
    public void Fill_Fire()
    {
        Cls_jos_railway_fire_detail c = new Cls_jos_railway_fire_detail();
        Cls_jos_railway_loco_in c1 = new Cls_jos_railway_loco_in();
        string x = ddlLocono.SelectedItem.ToString();
        c.mid = c1.Select_Data(x);
        DataTable dt1 = c.Select_DataById_Out(c.mid);
       txtsr1.Text = dt1.Rows[0][0].ToString();
       string str1 = dt1.Rows[0][1].ToString().Substring(0, 10);
       txtfire1.Text = str1.Substring(0, 2) + "/" + str1.Substring(3, 2) + "/" + str1.Substring(6, 4);

        txtsr2.Text = dt1.Rows[1][0].ToString();
     
        txtfire2.Text = dt1.Rows[1][1].ToString().Substring(0, 10);
        string str2 = dt1.Rows[0][1].ToString().Substring(0, 10);
        txtfire2.Text = str2.Substring(0, 2) + "/" + str2.Substring(3, 2) + "/" + str2.Substring(6, 4);

        txtsr3.Text = dt1.Rows[2][0].ToString();
        txtfire3.Text = dt1.Rows[2][1].ToString().Substring(0, 10);
        string str3 = dt1.Rows[0][1].ToString().Substring(0, 10);
        txtfire3.Text = str3.Substring(0, 2) + "/" + str3.Substring(3, 2) + "/" + str3.Substring(6, 4);

        txtsr4.Text = dt1.Rows[3][0].ToString();
        txtfire4.Text = dt1.Rows[3][1].ToString().Substring(0, 10);
        string str4 = dt1.Rows[0][1].ToString().Substring(0, 10);
        txtfire4.Text = str4.Substring(0, 2) + "/" + str4.Substring(3, 2) + "/" + str4.Substring(6, 4);



    }
    public void Updation()
    {
        //Assign Data To Update
        obj.id_loco_out = Request.QueryString["id"].ToString();
        obj.type_id = ddlClass.SelectedValue.ToString();
        obj.loco_id = ddlLocono.SelectedValue.ToString();
        obj.a_date = txtArrivalDate.Text.Substring(3, 2).ToString() + "/" + txtArrivalDate.Text.Substring(0, 2).ToString() + "/" + txtArrivalDate.Text.Substring(6, 4).ToString();
        obj.a_time = ddlArrivalTime1.Text + ":" + ddlArrivalTime2.Text + ":00";
        obj.action = txtReason.Text;
        obj.booked = txtRemarks.Text;

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
        //mltobj.l_date = dtLOD.Value.ToString();
        obj.l_oil = txtLubelevel.Text;
        ///mltobj.l_sch = ddlLastSchedule.SelectedValue.ToString();
        obj.loco_id = ddlLocono.SelectedValue.ToString();
        //mltobj.shift = ddlShift.SelectedValue.ToString();
        obj.desc_sche = txtDescription.Text;

        obj.sid = ddlSchedule.SelectedValue.ToString();
        obj.sname = txtDriverName.Text;
        obj.tnc_name = ddlTncName.SelectedValue.ToString();
        obj.tid = txtTrainno.Text;
        obj.shift_date = txtShiftDate.Text.Substring(3, 2).ToString() + "/" + txtShiftDate.Text.Substring(0, 2).ToString() + "/" + txtShiftDate.Text.Substring(6, 4).ToString();
        Int64 m = obj.Update_Data();

        Cls_jos_railway_fire_detail_out c = new Cls_jos_railway_fire_detail_out();
        //Cls_jos_railway_fire_detail_out c = new Cls_jos_railway_fire_detail_out();
        if (txtsr1.Text != "")
        {
            c.mid = Request.QueryString["id"].ToString();
            c.l_type = "Loco out";
            c.srno = txtsr1.Text;
            c.fdate = txtfire1.Text.Substring(3, 2).ToString() + "/" + txtfire1.Text.Substring(0, 2).ToString() + "/" + txtfire1.Text.Substring(6, 4).ToString();
            c.id_fire_dout = ViewState["i1"].ToString();
            c.Update_Data();
        }
        if (txtsr2.Text != "")
        {
            c.mid = Request.QueryString["id"].ToString();
            c.l_type = "Loco out";
            c.srno = txtsr2.Text;
            c.fdate = txtfire2.Text.Substring(3, 2).ToString() + "/" + txtfire2.Text.Substring(0, 2).ToString() + "/" + txtfire2.Text.Substring(6, 4).ToString();
            c.id_fire_dout = ViewState["i2"].ToString();
            c.Update_Data();
        }
        if (txtsr3.Text != "")
        {
            c.mid = Request.QueryString["id"].ToString();
            c.l_type = "Loco out";
            c.srno = txtsr3.Text;
            c.fdate = txtfire3.Text.Substring(3, 2).ToString() + "/" + txtfire3.Text.Substring(0, 2).ToString() + "/" + txtfire3.Text.Substring(6, 4).ToString();
            c.id_fire_dout = ViewState["i3"].ToString();
            c.Update_Data();
        }
        if (txtsr4.Text != "")
        {
            c.mid = Request.QueryString["id"].ToString();
            c.l_type = "Loco out";
            c.srno = txtsr4.Text;
            c.fdate = txtfire4.Text.Substring(3, 2).ToString() + "/" + txtfire4.Text.Substring(0, 2).ToString() + "/" + txtfire4.Text.Substring(6, 4).ToString();
            c.id_fire_dout = ViewState["i4"].ToString();
            c.Update_Data();
        }
        Response.Redirect("~/Loco/View_Locooutdetails.aspx?id=" + m);
    }
    protected void btnSave_OnClick(object sender, EventArgs e)
    {
        if (btnSave.Text == "INSERT")
        {
            Insertion();
        }
        else if (btnSave.Text == "UPDATE")
        {
            Updation();
        }

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
    protected void ddlLocono_SelectedIndexChanged(object sender, EventArgs e)
    {
        if ((string)Request.QueryString["id"] == null)
        {
            Cls_jos_railway_loco_in c = new Cls_jos_railway_loco_in();
            c.loco_id = ddlLocono.SelectedValue.ToString();
            DataTable dt = c.Select_DataByLocoNo();
            if (dt.Rows.Count != 0)
            {
                //ddlClass.SelectedIndex = ddlClass.Items.IndexOf(ddlClass.Items.FindByValue(dt.Rows[0][1].ToString()));
                //Fill_LocoNo();
                //ddlLocono.SelectedIndex = ddlLocono.Items.IndexOf(ddlLocono.Items.FindByValue(dt.Rows[0][2].ToString()));
                //txtArrivalDate.Text = dt.Rows[0][3].ToString();
                //timeremaindt.Rows[0][3].ToString();
                ddlSchedule.SelectedIndex = ddlSchedule.Items.IndexOf(ddlSchedule.Items.FindByValue(dt.Rows[0][5].ToString()));
                txtDescription.Text = dt.Rows[0][6].ToString();
                txtTrainno.Text = dt.Rows[0][7].ToString();
                //txtLastOutDate.Text = dt.Rows[0][8].ToString();
                //ddlLastSchedule.SelectedIndex = ddlLastSchedule.Items.IndexOf(ddlLastSchedule.Items.FindByValue(dt.Rows[0][9].ToString()));
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
                string sdate = dt.Rows[0][19].ToString();
                //txtShiftDate.Text = dt.Rows[0][19].ToString();
                txtShiftDate.Text = sdate.Substring(3, 2).ToString() + "/" + sdate.Substring(0, 2).ToString() + "/" + sdate.Substring(6, 4).ToString();
                //txtBookedRepair.Text = dt.Rows[0][20].ToString();
                //txtActionTaken.Text = dt.Rows[0][21].ToString();
                Fill_Fire();
            }
        }

    }
    protected void txtbtn_OnClick(object sender, EventArgs e)
    {
        if (txtsurname.Text != "" && txtfathername.Text != "" && txtName.Text != "")
        {
            Cls_jos_railway_Hr c = new Cls_jos_railway_Hr();
            c.surname = txtsurname.Text;
            c.FullName = txtName.Text;
            c.fname = txtfathername.Text;
            c.DOB = DateTime.Today.ToShortDateString().ToString();
            c.RetirementDate = DateTime.Today.ToShortDateString().ToString();

            c.Address = "";
            c.BloodGroup = "";
            c.Cast = "1";
            c.City = "";
            c.Disease = "";
            c.EmailAddress = "";
            c.EmployeeNo = "";
            c.equa = "";
            c.Gender = "";
            c.m_cat = "1";
            c.MobileNo = "";
            c.paddress = "";
            c.Pan = "";
            c.photo = "";
            c.Post = "";
            c.SubCast = "1";
            c.RecidentNo = "";
            c.SalaryCode = "0";
            c.Section = "1";
            c.signature = "";
            c.State = "";

            c.tech_qua = "";
            c.thumb = "";

            //c.DOB = null;
            //c.RetirementDate = null;
            if (Convert.ToInt64(c.Insert_Data()) != 0)
            {
                Fill_TNCName();
                PanelTnc.Visible = false;
            }
        }
    }
    protected void ddlTncName_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlTncName.SelectedIndex == 1)
        {
            PanelTnc.Visible = true;
        }
        else
        {
            PanelTnc.Visible = false;
        }
    }
}
