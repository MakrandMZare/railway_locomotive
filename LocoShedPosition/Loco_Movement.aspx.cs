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
public partial class LocoShedPosition_Loco_Movement : System.Web.UI.Page
{
    
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
        Cls_jos_railway_loco_in obj
            = new Cls_jos_railway_loco_in();
        //c.type_id = ddlClass.SelectedValue.ToString();
        //ddlLocono.DataSource = c.Select_LocoNo_From_LocoIn();
        //ddlLocono.DataTextField = "LocoNo";
        //ddlLocono.DataValueField = "LocoId";
        //ddlLocono.DataBind();
        //ddlLocono.Items.Insert(0, "SELECT");
        if (ddlClass.SelectedIndex != 0)
        {
            ddlLocono.DataSource = obj.Select_LocoNo(ddlClass.SelectedValue.ToString());
            ddlLocono.DataTextField = "locono";
            ddlLocono.DataValueField = "id_mst_loco";
            ddlLocono.DataBind();
            ddlLocono.Items.Insert(0, "SELECT");
        }
    }
    public void Fill_Site()
    {
        ddlSite.Items.Clear();
        Cls_jos_railway_mst_site c = new Cls_jos_railway_mst_site();
        ddlSite.DataSource = c.Select_Data();
        ddlSite.DataTextField = "Site_Name";
        ddlSite.DataValueField = "Id_Site";
        ddlSite.DataBind();
        ddlSite.Items.Insert(0, "SELECT");
    }
    public void Fill_Section()
    {
        ddlSection.Items.Clear();
        Cls_jos_railway_mst_SiteSection c = new Cls_jos_railway_mst_SiteSection();
        ddlSection.DataSource = c.Select_Data();
        ddlSection.DataTextField = "SiteSectionName";
        ddlSection.DataValueField = "Id_SiteSection";
        ddlSection.DataBind();
        ddlSection.Items.Insert(0, "SELECT");
    }
    public void Fill_Div()
    {
        ddlDiv.Items.Clear();
        Cls_jos_railway_division c = new Cls_jos_railway_division();
        ddlDiv.DataSource = c.Select_Data();
        ddlDiv.DataTextField = "div";
        ddlDiv.DataValueField = "id_div";
        ddlDiv.DataBind();
        ddlDiv.Items.Insert(0, "SELECT");
    }
    public void Insertion()
    {
        Cls_jos_railway_Loco_Movements c = new Cls_jos_railway_Loco_Movements();
        c.GenerationDate = DateTime.Today.Month.ToString() + "/" + DateTime.Today.Day.ToString() + "/" + DateTime.Today.Year.ToString();
        c.LocoId = ddlLocono.SelectedValue.ToString();
        c.Remarks = txtRemarks.Text;
        c.RepairAttended = txtRepair.Text;
        c.Section_Id = ddlSection.SelectedValue.ToString();
        c.Site_Id = ddlSite.SelectedValue.ToString();
        c.Div = ddlDiv.SelectedValue.ToString();
        c.Insert_Data();
        
    }
    public void Updation()
    {
        Cls_jos_railway_Loco_Movements c = new Cls_jos_railway_Loco_Movements();
        c.LocoId = ddlLocono.SelectedValue.ToString();
        c.Remarks = txtRemarks.Text;
        c.RepairAttended = txtRepair.Text;
        c.Section_Id = ddlSection.SelectedValue.ToString();
        c.Site_Id = ddlSite.SelectedValue.ToString();
        c.Div = ddlDiv.SelectedValue.ToString();
        c.Id_Loco_Movement = Request.QueryString["id"].ToString();
        c.Update_Data();
    }
    public void Fill_Data()
    {
        
        Cls_jos_railway_Loco_Movements c = new Cls_jos_railway_Loco_Movements();
        c.Id_Loco_Movement = Request.QueryString["id"].ToString();
        DataTable dt = c.Select_Data();
        Cls_Master_Loco_Type cl = new Cls_Master_Loco_Type();
        DataTable c1dt = cl.Get_LocoTypeByLocoId(dt.Rows[0][1].ToString());
        if(c1dt.Rows.Count > 0)
        {
        ddlClass.SelectedIndex = ddlClass.Items.IndexOf(ddlClass.Items.FindByValue(c1dt.Rows[0][0].ToString()));
        Fill_LocoNo();
        ddlLocono.SelectedIndex = ddlLocono.Items.IndexOf(ddlLocono.Items.FindByValue(dt.Rows[0][1].ToString()));
        Fill_LocoDetails();
        }
            txtRepair.Text = dt.Rows[0][2].ToString();
        txtRemarks.Text = dt.Rows[0][6].ToString();
        ddlDiv.SelectedIndex = ddlDiv.Items.IndexOf(ddlDiv.Items.FindByValue(dt.Rows[0][3].ToString()));
        ddlSite.SelectedIndex = ddlSite.Items.IndexOf(ddlSite.Items.FindByValue(dt.Rows[0][4].ToString()));
        ddlSection.SelectedIndex = ddlSection.Items.IndexOf(ddlSection.Items.FindByValue(dt.Rows[0][5].ToString()));
        //Fill Loco In details
        //Fill_LocoDetails();
        
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!Page.IsPostBack)
        {
            Fill_Class();
            Fill_Site();
            Fill_Section();
            Fill_Div();
            if (Request.QueryString["id"] != null)
            {
                Fill_Data();
                btnSave.Text = "UPDATE"; }
        }
    }
    public void Fill_LocoDetails()
    {
    Cls_jos_railway_Loco_Movements c = new Cls_jos_railway_Loco_Movements();
    c.LocoId = ddlLocono.SelectedValue.ToString();
    DataTable dt =c.Select_LocoDetails();
    if (dt.Rows.Count > 0)
    { 
    txtArrivalDate.Text = dt.Rows[0][0].ToString();
    txtDoc.Text = dt.Rows[0][1].ToString();
    txtOut.Text = dt.Rows[0][2].ToString();
    txtLastSchedule.Text = dt.Rows[0][3].ToString();
    }
    }
    protected void btnSave_OnClick(object sender, EventArgs e)
    {
        if (btnSave.Text == "INSERT")
        { Insertion(); }
        else if (btnSave.Text == "UPDATE")
        { Updation(); }
        Response.Redirect("~/LocoShedPosition/View_LocoMovements.aspx");
    }
    protected void ddlClass_SelectedIndexChanged(object sender, EventArgs e)
    {
        Fill_LocoNo();
        Cls_Master_Loco_Type c = new Cls_Master_Loco_Type();
        c.id_ltype = ddlClass.SelectedValue.ToString();
        lblguage.Text = "";
        lblguage.Visible = true;
        lblguage.Text = c.Get_LocoGuageByLocotype();
    }
    protected void ddlLocono_SelectedIndexChanged(object sender, EventArgs e)
    {
        Fill_LocoDetails();
    }
}
