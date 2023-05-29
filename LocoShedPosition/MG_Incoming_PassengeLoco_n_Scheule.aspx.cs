using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Railway;
using System.Data.SqlTypes;

public partial class LocoShedPosition_MG_Incoming_PassengeLoco_n_Scheule : System.Web.UI.Page
{
    public void InsertData()
    {
        Cls_MG_Incoming_PassengerLoco_n_Schedule c = new Cls_MG_Incoming_PassengerLoco_n_Schedule();
        c.Incoming_Trno = txtTrno.Text;
        c.Incoming_LocoId = ddlLocono.SelectedValue.ToString();
        c.WheelDiameter = txtWheelDia.Text;
        c.Major_ScheduleId = ddlMajor.SelectedIndex != 0 ? ddlMajor.SelectedValue.ToString() : "";
        c.Minor_ScheduleId = ddlMinor.SelectedIndex != 0 ? ddlMinor.SelectedValue.ToString() : "";
        c.LastScheduleId = ddlLastSchedule.SelectedIndex != 0 ? ddlLastSchedule.SelectedValue.ToString() : "";
        c.LastMLY_Qtly_Hly = txtMLY.Text;
        c.LastMLYDate = txtMLYDate.Text;
        c.GenerationDate = System.DateTime.Now.Month.ToString() + "/" + System.DateTime.Now.Day.ToString() + "/" + System.DateTime.Now.Year.ToString();
        c.Insert_Data();
    }
    public void UpdateData()
    {
        Cls_MG_Incoming_PassengerLoco_n_Schedule c = new Cls_MG_Incoming_PassengerLoco_n_Schedule();
        c.Id_Passnger_loco = Request.QueryString["id"].ToString();
        c.Incoming_Trno = txtTrno.Text;
        c.Incoming_LocoId = ddlLocono.SelectedValue.ToString();
        c.WheelDiameter = txtWheelDia.Text;
        c.Major_ScheduleId = ddlMajor.SelectedIndex != 0 ? ddlMajor.SelectedValue.ToString() : null;
        c.Minor_ScheduleId = ddlMinor.SelectedIndex != 0 ? ddlMinor.SelectedValue.ToString() : null;
        c.LastScheduleId = ddlLastSchedule.SelectedIndex != 0 ? ddlLastSchedule.SelectedValue.ToString() : null;
        c.LastMLY_Qtly_Hly = txtMLY.Text;
        c.LastMLYDate = txtMLYDate.Text;
        c.GenerationDate = System.DateTime.Now.Month.ToString() + "/" + System.DateTime.Now.Day.ToString() + "/" + System.DateTime.Now.Year.ToString();
        c.Update_Data();

    }
    protected void ddlClass_SelectedIndexChanged(object sender, EventArgs e)
    {
        Cls_Master_Loco_Type c = new Cls_Master_Loco_Type();
        c.id_ltype = ddlClass.SelectedValue.ToString();
        lblguage.Text = "";
        lblguage.Visible = true;
        lblguage.Text = c.Get_LocoGuageByLocotype();
        Fill_LocoNo();
        Fill_Schedule();
    }
    public void Fill_Class()
    {
        Cls_Master_Loco_Type c = new Cls_Master_Loco_Type();
        ddlClass.DataSource = c.Get_MGLocoType();
        ddlClass.DataTextField = "loco_type";
        ddlClass.DataValueField = "id_ltype";
        ddlClass.DataBind();
        ddlClass.Items.Insert(0, "SELECT");
    }
    public void Fill_LocoNo()
    {
        Cls_jos_railway_mst_loco c = new Cls_jos_railway_mst_loco();
        c.tid = ddlClass.SelectedValue.ToString();
        ddlLocono.DataSource = c.Select_LocoNoByType();
        ddlLocono.DataTextField = "locono";
        ddlLocono.DataValueField = "id_mst_loco";
        ddlLocono.DataBind();
        ddlLocono.Items.Insert(0, "SELECT");
    }
    public void Fill_Schedule()
    {

        ddlLastSchedule.Items.Clear();
        ddlMajor.Items.Clear();
        ddlMinor.Items.Clear();
        Cls_jos_railway_loco_type_schedule c = new Cls_jos_railway_loco_type_schedule();
        c.loco_id = ddlClass.SelectedValue.ToString();
        DataTable dt = c.Select_Data();
        //Fill Due Schedule Major
        ddlMajor.DataSource = dt;
        ddlMajor.DataTextField = "Schedule_Type";
        ddlMajor.DataValueField = "id_loco_sch";
        ddlMajor.DataBind();
        ddlMajor.Items.Insert(0, "SELECT");
        //Fill Due Schedule Minor
        ddlMinor.DataSource = dt;
        ddlMinor.DataTextField = "Schedule_Type";
        ddlMinor.DataValueField = "id_loco_sch";
        ddlMinor.DataBind();
        ddlMinor.Items.Insert(0, "SELECT");
        //Fill Last Schedule
        ddlLastSchedule.DataSource = dt;
        ddlLastSchedule.DataTextField = "Schedule_Type";
        ddlLastSchedule.DataValueField = "id_loco_sch";
        ddlLastSchedule.DataBind();
        ddlLastSchedule.Items.Insert(0, "SELECT");
    }
    public void Fill_Data()
    {
        Cls_MG_Incoming_PassengerLoco_n_Schedule c = new Cls_MG_Incoming_PassengerLoco_n_Schedule();
        c.Id_Passnger_loco = Request.QueryString["id"].ToString();
        DataTable dt = c.Select_DataById();
        if (dt.Rows.Count > 0)
        {
            txtTrno.Text = dt.Rows[0][1].ToString();
            Cls_Master_Loco_Type cl = new Cls_Master_Loco_Type();
            DataTable c1dt = cl.Get_LocoTypeByLocoId(dt.Rows[0][2].ToString());
            if (c1dt.Rows.Count > 0)
            {
                ddlClass.SelectedIndex = ddlClass.Items.IndexOf(ddlClass.Items.FindByValue(c1dt.Rows[0][0].ToString()));
                Fill_LocoNo();
                ddlLocono.SelectedIndex = ddlLocono.Items.IndexOf(ddlLocono.Items.FindByValue(dt.Rows[0][2].ToString()));
            }
            if (dt.Rows[0][3].ToString() != null)
            {
                ddlMinor.SelectedIndex = ddlMinor.Items.IndexOf(ddlMinor.Items.FindByValue(dt.Rows[0][3].ToString()));
            }
            if (dt.Rows[0][4].ToString() != null)
            {
                ddlMajor.SelectedIndex = ddlMajor.Items.IndexOf(ddlMajor.Items.FindByValue(dt.Rows[0][4].ToString()));
            }
            if (dt.Rows[0][5].ToString() != null)
            {
                ddlLastSchedule.SelectedIndex = ddlLastSchedule.Items.IndexOf(ddlLastSchedule.Items.FindByValue(dt.Rows[0][5].ToString()));
            }
            txtMLY.Text = dt.Rows[0][6].ToString();
            txtMLYDate.Text = dt.Rows[0][7].ToString();
            txtWheelDia.Text = dt.Rows[0][9].ToString();
        }

    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Fill_Class();
        }
        else
        {
            if ((string)Request.QueryString["id"] != "" && (string)Request.QueryString["action"] == "update")
            {
                Fill_Data();
            }
        }
    }
    protected void btnSave_OnClick(object sender, EventArgs e)
    {
        if (btnSave.Text == "INSERT")
        {
            InsertData();
        }
        else if (btnSave.Text == "UPDATE")
        {
            UpdateData();
        }
    }

}
