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
    Cls_Failure_Detail c = new Cls_Failure_Detail();
    Cls_jos_railway_loco_in obj = new Cls_jos_railway_loco_in();
    public void Fill_Class()
    {
        ddlClass.DataSource = obj.SelectLocoType();
        ddlClass.DataTextField = "loco_type";
        ddlClass.DataValueField = "id_ltype";
        ddlClass.DataBind();
        ddlClass.Items.Insert(0, "SELECT");

    }
    public void Fill_Site()
    {
        ddlSite.DataSource = c.Select_Site();
        ddlSite.DataTextField = "Site_Name";
        ddlSite.DataValueField = "Id_Site";
        ddlSite.DataBind();
        ddlSite.Items.Insert(0, "SELECT");

    }

    public void Fill_Section()
    {
        ddlSection.DataSource = c.Select_Section();
        ddlSection.DataTextField = "f_name";
        ddlSection.DataValueField = "id_section";
        ddlSection.DataBind();
        ddlSection.Items.Insert(0, "SELECT");

    }

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
    protected void ddlClass_SelectedIndexChanged(object sender, EventArgs e)
    {
        Fill_LocoNo();
    }

    protected void ddlLocono_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!Page.IsPostBack)
        {

            Fill_Class();
            Fill_HQ();
            Fill_Site();
            Fill_Section();
            Fill_Division();
            Fill_TNCName();
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

        c.IdLoco = ddlLocono.SelectedValue.ToString();
        c.MU_SU = txtmu_su.Text;
        c.MUWith = txtMuWith.Text;
        c.Cab = txtCab.Text;
        c.IncidentDate = txtIncidentDate.Text.Substring(3, 2).ToString() + "/" + txtIncidentDate.Text.Substring(0, 2).ToString() + "/" + txtIncidentDate.Text.Substring(6, 4).ToString();

        c.Trainno = txtTrainNo.Text;
        c.Load1 = txtLoad.Text;
        c.DriverName = ddlTncName.SelectedValue.ToString();
        c.Hq = ddlHq.SelectedValue.ToString();
        c.Link = ddlLink.SelectedIndex.ToString();
        c.IdSite=ddlSite.SelectedValue.ToString();
        c.IdSection=ddlSection.SelectedValue.ToString();
        c.IdDivision=ddlDivision.SelectedValue.ToString();
      
        c.Insert_Data_FailureAnalysis1NewNew();
        Clear_Data();

    }

    public void Clear_Data()
    {

        txtmu_su.Text = "";
        txtMuWith.Text = "";
        txtCab.Text = "";
        txtIncidentDate.Text = "";
        txtTrainNo.Text = "";
        txtLoad.Text = "";
        

    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        ddlClass.SelectedIndex = 0;
        ddlLocono.SelectedIndex = 0;
        ddlHq.SelectedIndex = 0;
        ddlTncName.SelectedIndex = 0;
        ddlLink.SelectedIndex = 0;
        ddlSite.SelectedIndex = 0;
        ddlSection.SelectedIndex = 0;
        ddlDivision.SelectedIndex = 0;
        Clear_Data();
    }
}



