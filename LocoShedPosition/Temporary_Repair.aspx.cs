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
public partial class LocoShedPosition_Temporary_Repair : System.Web.UI.Page
{
    Cls_jos_railway_loco_in obj = new Cls_jos_railway_loco_in();

    public void Transfer_LineMessage_To_TemporaryRepor()
    {
        //this will transfer line message to temporary message after 24 hrs.
        Cls_jos_Railway_Loco_LineMsg c = new Cls_jos_Railway_Loco_LineMsg();
        DataTable dt = c.Get_LineMessageEnterBeforeDay();
        foreach (DataRow dr in dt.Rows)
        {
            Cls_jos_railway_Loco_Temporary_Repair c1 = new Cls_jos_railway_Loco_Temporary_Repair();
            c1.Generation_Date = System.DateTime.Now.Month.ToString() + "/" + System.DateTime.Now.Day.ToString() + "/" + System.DateTime.Now.Year.ToString();
            c1.Id_Loco = dt.Rows[0][1].ToString();
            c1.Id_Site = dt.Rows[0][4].ToString();
            c1.Id_SiteSection = dt.Rows[0][5].ToString();
            c1.Reason = dt.Rows[0][6].ToString();
            c1.Remarks = "--";
            c1.Insert_Data();
            //Make LineMessage unavailable
            c.Id_Loco_Linemsg = dt.Rows[0][0].ToString();
            c.Make_Unavailable();
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
        Cls_jos_railway_loco_in c = new Cls_jos_railway_loco_in();
        //c.type_id = ddlClass.SelectedValue.ToString();
        //ddlLocono.DataSource = c.Select_LocoNo_From_LocoIn();
        ddlLocono.DataSource = c.Select_LocoNo(ddlClass.SelectedValue.ToString());
        ddlLocono.DataTextField = "LocoNo";
        ddlLocono.DataValueField = "id_mst_loco";
        ddlLocono.DataBind();
        ddlLocono.Items.Insert(0, "SELECT");
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
    protected void Page_Load(object sender, EventArgs e)
    {
        Transfer_LineMessage_To_TemporaryRepor();
        if (!Page.IsPostBack)
        {
            Fill_Class();
            Fill_Site();
            Fill_Section();
            if ((string)Request.QueryString["id"] != null)
            { 
                btnSave.Text = "UPDATE";
                Cls_jos_railway_Loco_Temporary_Repair c = new Cls_jos_railway_Loco_Temporary_Repair();
                c.Id_Loco_Temp_Repair = Request.QueryString["id"].ToString();
                DataTable dt = c.Select_DataById();
                Cls_Master_Loco_Type cl = new Cls_Master_Loco_Type();
                DataTable c1dt = cl.Get_LocoTypeByLocoId(dt.Rows[0][1].ToString());
                if (c1dt.Rows.Count > 0)
                {
                    ddlClass.SelectedIndex = ddlClass.Items.IndexOf(ddlClass.Items.FindByValue(c1dt.Rows[0][0].ToString()));
                    Fill_LocoNo();
                    ddlLocono.SelectedIndex = ddlLocono.Items.IndexOf(ddlLocono.Items.FindByValue(dt.Rows[0][1].ToString()));
                    //Fill_LocoDetails();
                }
                ddlSite.SelectedIndex = ddlSite.Items.IndexOf(ddlSite.Items.FindByValue(dt.Rows[0][2].ToString()));
                ddlSection.SelectedIndex = ddlSection.Items.IndexOf(ddlSection.Items.FindByValue(dt.Rows[0][3].ToString()));
                txtReason.Text = dt.Rows[0][4].ToString();
                txtRemarks.Text = dt.Rows[0][5].ToString();
            }
        }
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
    public void Insertion()
    {
        Cls_jos_railway_Loco_Temporary_Repair c = new Cls_jos_railway_Loco_Temporary_Repair();
        c.Id_Site = ddlSite.SelectedValue.ToString();
        c.Id_SiteSection = ddlSection.SelectedIndex.ToString();
        c.Id_Loco = ddlClass.SelectedValue.ToString();
        c.Reason = txtReason.Text;
        c.Remarks = txtRemarks.Text;
        DateTime d = DateTime.Today;
        c.Generation_Date = d.Month.ToString() + "/" + d.Day.ToString() + "/" + d.Year.ToString();
        c.Insert_Data();
    }
    public void Updation()
    {
        Cls_jos_railway_Loco_Temporary_Repair c = new Cls_jos_railway_Loco_Temporary_Repair();
        c.Id_Loco_Temp_Repair = Request.QueryString["id"].ToString();
        c.Id_Site = ddlSite.SelectedValue.ToString();
        c.Id_SiteSection = ddlSection.SelectedValue.ToString();
        c.Id_Loco = ddlLocono.SelectedValue.ToString();
        c.Reason = txtReason.Text;
        c.Remarks = txtRemarks.Text;
        c.Update_Data();
    }
    protected void btnSave_OnClick(object sender, EventArgs e)
    {
        if (btnSave.Text == "INSERT")
        {
            Insertion();
        }
        else if (btnSave.Text == "UPDATE")
        {
            if ((string)Request.QueryString["id"] != null)
            {
                Updation();
            }
        }
        Response.Redirect("~/LocoShedPosition/View_TemporaryRepair.aspx");
    }
}
