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


public partial class Loco_failure1 : System.Web.UI.Page
{
    Cls_Failure_detailNew c = new Cls_Failure_detailNew();
    Cls_jos_railway_loco_in obj = new Cls_jos_railway_loco_in();
    public void Fill_Class()
    {
        ddlClass.DataSource = obj.SelectLocoType();
        ddlClass.DataTextField = "loco_type";
        ddlClass.DataValueField = "id_ltype";
        ddlClass.DataBind();
        ddlClass.Items.Insert(0, "SELECT");

    }
    public void Fill_Schedule()
    {
        ddlschedule1.Items.Clear();
        Cls_jos_railway_loco_type_schedule c = new Cls_jos_railway_loco_type_schedule();
        c.loco_id = ddlClass.SelectedValue.ToString();
        ddlschedule1.DataSource = c.Select_Data_schedule();
        ddlschedule1.DataTextField = "s_type";
        ddlschedule1.DataValueField = "id_loco_sch";
        ddlschedule1.DataBind();
        ddlschedule1.Items.Insert(0, "SELECT");
    }

    public void Fill_ScheduleInWh()
    {
        ddlScheduleInWh.Items.Clear();
        Cls_jos_railway_loco_type_schedule c = new Cls_jos_railway_loco_type_schedule();
        c.loco_id = ddlClass.SelectedValue.ToString();
        ddlScheduleInWh.DataSource = c.Select_Data_schedule();
        ddlScheduleInWh.DataTextField = "s_type";
        ddlScheduleInWh.DataValueField = "id_loco_sch";
        ddlScheduleInWh.DataBind();
        ddlScheduleInWh.Items.Insert(0, "SELECT");
    }

    public void Fill_Resp()
    {
        ddlresp.DataSource = c.Select_Resp();
        ddlresp.DataTextField = "resp";
        ddlresp.DataValueField = "id_resp";
        ddlresp.DataBind();
        ddlresp.Items.Insert(0,"SELECT");
    }
    public void Fill_Supplier()
    {
        ddlSupplier.DataSource = c.Select_Supplier();
        ddlSupplier.DataTextField = "s_name";
        ddlSupplier.DataValueField = "id_supp";
        ddlSupplier.DataBind();
        ddlSupplier.Items.Insert(0, "SELECT");
    }
    //public void Fill_Site()
    //{
    //    ddlSite.DataSource = c.Select_Site();
    //    ddlSite.DataTextField = "Site_Name";
    //    ddlSite.DataValueField = "Id_Site";
    //    ddlSite.DataBind();
    //    ddlSite.Items.Insert(0, "SELECT");

    //}

    //public void Fill_Section()
    //{
    //    ddlSection.DataSource = c.Select_Section();
    //    ddlSection.DataTextField = "f_name";
    //    ddlSection.DataValueField = "id_section";
    //    ddlSection.DataBind();
    //    ddlSection.Items.Insert(0, "SELECT");

    //}

    public void Fill_Division()
    {
        ddlDivision.DataSource = c.Select_Division();
        ddlDivision.DataTextField = "div";
        ddlDivision.DataValueField = "id_div";
        ddlDivision.DataBind();
        ddlDivision.Items.Insert(0, "SELECT");

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
    //public void Fill_TNCName()
    //{

    //    ddlTncName.Items.Clear();
    //    Cls_jos_railway_Hr c = new Cls_jos_railway_Hr();
    //    ddlTncName.DataSource = c.Select_Fullname();
    //    ddlTncName.DataTextField = "sname";
    //    ddlTncName.DataValueField = "id";
    //    ddlTncName.DataBind();
    //    ddlTncName.Items.Insert(0, "SELECT");
    //}
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
    //public void Fill_TNCName()
    //{

    //    ddlTncName.Items.Clear();
    //    Cls_jos_railway_Hr c = new Cls_jos_railway_Hr();
    //    ddlTncName.DataSource = c.Select_Fullname();
    //    ddlTncName.DataTextField = "sname";
    //    ddlTncName.DataValueField = "id";
    //    ddlTncName.DataBind();
    //    ddlTncName.Items.Insert(0, "SELECT");
    //}
    protected void ddlClass_SelectedIndexChanged(object sender, EventArgs e)
    {
        Fill_LocoNo();
    }

    protected void ddlRdso1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Fill_Rdso2Digit();
       
    }
    protected void ddlRdso2_SelectedIndexChanged(object sender, EventArgs e)
    {
        Fill_Rdso3Digit();
        
    }
    protected void ddlRdso3_SelectedIndexChanged(object sender, EventArgs e)
    {
        Fill_Rdso4Digit();
       
    }
    protected void ddlRdso4_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
   
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!Page.IsPostBack)
        {
            //c.l_date = txtdate.Text.Substring(3, 2) + "/" + txtdate.Text.Substring(0, 2) + "/" + txtdate.Text.Substring(6, 4);
            Fill_Class();
            Fill_HQ();
            Fill_Resp();
            Fill_Schedule();
            Fill_ScheduleInWh();
            Fill_Supplier();
            Fill_Division();
            //-----------------------
            Fill_Rdso1Digit();
            Fill_Rdso2Digit();
            Fill_Rdso3Digit();
            Fill_Rdso4Digit();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {


        if (btnInsert.Text == "INSERT")
        {
            InsertData();
        }

    }


    protected void InsertData()
    {

        c.id_mst_loco = ddlLocono.SelectedValue.ToString();
        c.id_loco_sch = ddlClass.SelectedValue.ToString();
        c.mu_su = ddlMuSu.SelectedValue.ToString();
        c.muWith = txtMuWith.Text;
        c.incidentDate = txtIncidentDate.Text.Substring(3, 2) + "/" + txtIncidentDate.Text.Substring(0, 2) + "/" + txtIncidentDate.Text.Substring(6, 4);
//        string date = txtIncidentDate.Text;
        c.trainNo = txtTrainNo.Text;
        c.trainLoad = txtLoad.Text;
        c.trainLink = ddlLink.SelectedIndex.ToString();

        c.driverName = txtDriverName.Text;
        c.hq = txtHq.Text;
        c.site = txtSite.Text;
        c.section = txtSection.Text;
        c.division = ddlDivision.SelectedValue.ToString();
        c.railway = ddlrailway.SelectedIndex.ToString();
        c.resp = ddlresp.SelectedValue.ToString(); ;
        c.failureType = ddlFailuretype.SelectedIndex.ToString();
        c.wing = ddlwing.SelectedValue.ToString();
        c.category = ddlCategory.SelectedIndex.ToString();
        c.overDue = ddlOverDue.SelectedValue.ToString();
        c.avoidable = ddlAvoidable.SelectedValue.ToString();
        //----------------------------------------------------
        c.mainAssembly = ddlRdso1.SelectedValue.ToString();
        c.subAssembly = ddlRdso2.SelectedValue.ToString();
        c.compoBisec = ddlRdso3.SelectedValue.ToString();
        c.diffectiveCode = ddlRdso4.SelectedValue.ToString();
        //---------------------------------------------
        c.service = txtservices.Text;
        c.arrivalPosition = ddlArrivalPosition.SelectedIndex.ToString();
        c.supervisor = txtSupervisor.Text;
        c.shedResponce = txtShedResponse.Text;
        c.mechanic = txtMechanic.Text;
        c.message = txtmsg.Text;
        c.observation = txtObservation.Text;
        c.repercussion = txtRepercussion.Text;
        c.lastOutDate = txtlastoutDate.Text.Substring(3, 2) + "/" + txtlastoutDate.Text.Substring(0, 2) + "/" + txtlastoutDate.Text.Substring(6, 4);
        c.shedArrivalDate = txtShedarrival.Text.Substring(3, 2) + "/" + txtShedarrival.Text.Substring(0, 2) + "/" + txtShedarrival.Text.Substring(6, 4);
        c.supplier = ddlSupplier.SelectedValue.ToString();
        c.place = ddlHq.SelectedValue.ToString();
        c.cpa = txtcpa.Text;
        c.shift = txtshift.Text;
        c.f_date = txtDate1.Text.Substring(3, 2) + "/" + txtDate1.Text.Substring(0, 2) + "/" + txtDate1.Text.Substring(6, 4);
        c.shedInWh = ddlScheduleInWh.SelectedValue.ToString();
        c.dateOfAttension = txtDateOfAtt.Text.Substring(3, 2) + "/" + txtDateOfAtt.Text.Substring(0, 2) + "/" + txtDateOfAtt.Text.Substring(6, 4);
        c.lastScheduleDate = txtLastScheduleDate.Text.Substring(3, 2) + "/" + txtLastScheduleDate.Text.Substring(0, 2) + "/" + txtLastScheduleDate.Text.Substring(6, 4);
        c.lastSchedule = ddlschedule1.SelectedValue.ToString();


        c.Insert_data();
        Clear_Data();

    }

    public void Clear_Data()
    {


        ddlLocono.SelectedIndex = 0;
        ddlClass.SelectedIndex = 0;
        ddlMuSu.SelectedIndex = 0;
        txtMuWith.Text = "";
        txtIncidentDate.Text = "";
        txtTrainNo.Text = "";
        txtLoad.Text = "";
        ddlLink.SelectedIndex = 0;

        txtDriverName.Text = "";
        txtHq.Text = "";
        txtSite.Text = "";
        txtSection.Text = "";
        ddlDivision.SelectedIndex = 0;
        ddlrailway.SelectedIndex = 0;
        ddlresp.SelectedIndex = 0;
        ddlFailuretype.SelectedIndex = 0;
        ddlwing.SelectedIndex = 0;
        ddlCategory.SelectedIndex = 0;
        ddlOverDue.SelectedIndex = 0;
        ddlAvoidable.SelectedIndex = 0;
        ddlRdso1.SelectedIndex = 0;
        ddlRdso2.SelectedIndex = 0;
        ddlRdso3.SelectedIndex = 0;
        ddlRdso4.SelectedIndex = 0;
        txtservices.Text = "";
        ddlArrivalPosition.SelectedIndex = 0;
        txtSupervisor.Text = "";
        txtShedResponse.Text = "";
        txtMechanic.Text = "";
        txtmsg.Text = "";
        txtObservation.Text = "";
        txtRepercussion.Text = "";
        txtlastoutDate.Text = "";
        txtShedarrival.Text = "";
        ddlSupplier.SelectedIndex = 0;
        ddlHq.SelectedIndex = 0;
        txtcpa.Text = "";
        txtshift.Text = "";
        txtDate1.Text = "";
        ddlScheduleInWh.SelectedIndex = 0;
        txtDateOfAtt.Text = "";
        txtLastScheduleDate.Text = "";
        ddlschedule1.SelectedIndex = 0;


    }
    protected void btncancel_Click(object sender, EventArgs e)
    {

        Clear_Data();
    }
    protected void ddlMuSu_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlMuSu.SelectedValue == "MU")
        {
            txtMuWith.Visible = true;
        }
        else
        {

            txtMuWith.Visible = false;
        }
    }

    public void Fill_Rdso1Digit()
    {
        Cls_railway_rdso c = new Cls_railway_rdso();
        ddlRdso1.DataSource = c.Select_Rdso1Digit();
        ddlRdso1.DataValueField = "rdso";
        ddlRdso1.DataTextField = "nature_defect";
        ddlRdso1.DataBind();
        ddlRdso1.Items.Insert(0, "SELECT");
    }
    public void Fill_Rdso2Digit()
    {
        Cls_railway_rdso c = new Cls_railway_rdso();
        ddlRdso2.DataSource = c.Select_Rdso2Digit(ddlRdso1.SelectedValue.ToString());
        ddlRdso2.DataValueField = "rdso";
        ddlRdso2.DataTextField = "nature_defect";
        ddlRdso2.DataBind();
        ddlRdso2.Items.Insert(0, "SELECT");
    }
    public void Fill_Rdso3Digit()
    {
        Cls_railway_rdso c = new Cls_railway_rdso();
        ddlRdso3.DataSource = c.Select_Rdso3Digit(ddlRdso2.SelectedValue.ToString());
        ddlRdso3.DataValueField = "rdso";
        ddlRdso3.DataTextField = "nature_defect";
        ddlRdso3.DataBind();
        ddlRdso3.Items.Insert(0, "SELECT");
    }
    public void Fill_Rdso4Digit()
    {
        Cls_railway_rdso c = new Cls_railway_rdso();

        ddlRdso4.DataSource = c.Select_Rdso4Digit(ddlRdso3.SelectedValue.ToString());
        ddlRdso4.DataValueField = "rdso";
        ddlRdso4.DataTextField = "nature_defect";
        ddlRdso4.DataBind();
        ddlRdso4.Items.Insert(0, "SELECT");
    }
   
}



