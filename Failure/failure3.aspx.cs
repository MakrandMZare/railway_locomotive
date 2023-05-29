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

public partial class Loco_failure3 : System.Web.UI.Page
{
    Cls_Failure_Detail c = new Cls_Failure_Detail();
    public void Fill_Supplier()
    {
        ddlSupplier.DataSource = c.Select_Supplier();
        ddlSupplier.DataTextField = "s_name";
        ddlSupplier.DataValueField = "id_supp";
        ddlSupplier.DataBind();
        ddlSupplier.Items.Insert(0, "SELECT");

    }
    public void Fill_Schedule()
    {
        ddlSchedule.Items.Clear();
        ddlSchedule.DataSource = c.Select_schedule();
        ddlSchedule.DataTextField = "s_type";
        ddlSchedule.DataValueField = "id_loco_sch";
        ddlSchedule.DataBind();
        ddlSchedule.Items.Insert(0, "SELECT");
        
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
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Fill_HQ();
            Fill_Supplier();
            Fill_Schedule();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if(btnInsert.Text=="INSERT")
        {
            InsertData();
        }
    }
    protected void InsertData()
    {

        c.not_use_of_defect = txtNotUse.Text;
    c.IdSupplier=ddlSupplier.SelectedValue.ToString();
    c.Message=txtmsg.Text;
    c.DateOfAttension = txtDateOfAtt.Text.Substring(3, 2).ToString() + "/" + txtDateOfAtt.Text.Substring(0, 2).ToString() + "/" + txtDateOfAtt.Text.Substring(6, 4).ToString();
    c.lastScheduledate = txtLastScheduleDate.Text.Substring(3, 2).ToString() + "/" + txtLastScheduleDate.Text.Substring(0, 2).ToString() + "/" + txtLastScheduleDate.Text.Substring(6, 4).ToString();
    c.Place = ddlHq.SelectedValue.ToString();
    c.Date1 = txtDate1.Text.Substring(3, 2).ToString() + "/" + txtDate1.Text.Substring(0, 2).ToString() + "/" + txtDate1.Text.Substring(6, 4).ToString();
    c.lastSchedule = ddlSchedule.SelectedValue.ToString();
    c.IdSupervisor=ddlSupplier.SelectedValue.ToString();
    c.IdMechanic=txtMechanic.Text;
    c.Shift=txtshift.Text;
    c.CPA=txtcpa.Text;
    c.LastOutDate = txtlastout.Text.Substring(3, 2).ToString() + "/" + txtlastout.Text.Substring(0, 2).ToString() + "/" + txtlastout.Text.Substring(6, 4).ToString();
    c.ShedArrivalDate = txtShedarrival.Text.Substring(3, 2).ToString() + "/" + txtShedarrival.Text.Substring(0, 2).ToString() + "/" + txtShedarrival.Text.Substring(6, 4).ToString();
    c.SheduleinWh=txtShedInWh.Text;
    c.ArrivalPosition=txtArrivalPosition.Text;
    c.ShedResponse=txtShedResponse.Text;
    c.Observation=txtObservation.Text;
    c.Repercussion=txtRepercussion.Text;
    c.Insert_Data_FailureAnalysis3New();
    Clear_Data();
    }

    public void Clear_Data()
    {

        txtNotUse.Text="";
        ddlSupplier.SelectedIndex = 0;
        txtmsg.Text="";
        txtDateOfAtt.Text="";
        txtLastScheduleDate.Text = "";
        ddlHq.SelectedIndex = 0;
        txtDate1.Text="";
        ddlSchedule.SelectedIndex = 0;
        txtSupervisor.Text = "";
        txtMechanic.Text="";
        txtshift.Text="";
        txtcpa.Text="";
        txtlastout.Text="";
        txtShedarrival.Text="";
        txtShedInWh.Text="";
        txtArrivalPosition.Text="";
        txtShedResponse.Text="";
        txtObservation.Text="";
        txtRepercussion.Text="";
        
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        ddlHq.SelectedIndex = 0;
        ddlSupplier.SelectedIndex = 0;
        Clear_Data();
    }
}
