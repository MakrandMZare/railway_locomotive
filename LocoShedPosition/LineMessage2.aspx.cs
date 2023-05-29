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
public partial class LocoShedPosition_LineMessage2 : System.Web.UI.Page
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
        Cls_jos_railway_loco_in c = new Cls_jos_railway_loco_in();
        //c.type_id = ddlClass.SelectedValue.ToString();
        //ddlLocono.DataSource = c.Select_LocoNo_From_LocoIn();
        ddlLocono.DataSource = c.Select_LocoNo(ddlClass.SelectedValue.ToString());
        ddlLocono.DataTextField = "locono";
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
    public void Fill_Data()
    {
        Cls_jos_railway_shed_pos3 c = new Cls_jos_railway_shed_pos3();
        c.id_shed_Pos3 = Request.QueryString["id"].ToString();
        DataTable dt = c.Select_DataById();
        Cls_Master_Loco_Type cl = new Cls_Master_Loco_Type();
        DataTable c1dt = cl.Get_LocoTypeByLocoId(dt.Rows[0]["Loco Id"].ToString());
        if (c1dt.Rows.Count > 0)
        {
            ddlClass.SelectedIndex = ddlClass.Items.IndexOf(ddlClass.Items.FindByValue(c1dt.Rows[0][0].ToString()));
            Fill_LocoNo();
            ddlLocono.SelectedIndex = ddlLocono.Items.IndexOf(ddlLocono.Items.FindByValue(dt.Rows[0]["Loco Id"].ToString()));
        }
        txtDate.Text = dt.Rows[0]["DATE"].ToString().Substring(3, 2) + "/" + dt.Rows[0]["DATE"].ToString().Substring(0, 2) + "/" + dt.Rows[0]["DATE"].ToString().Substring(6, 4);
        string str1 = ddlSite.Items.IndexOf(ddlSite.Items.FindByValue(dt.Rows[0]["SITE"].ToString())).ToString();
        string str2 = ddlD_W.Items.IndexOf(ddlD_W.Items.FindByValue(dt.Rows[0]["D/W"].ToString())).ToString();
        ddlSite.SelectedIndex = ddlSite.Items.IndexOf(ddlSite.Items.FindByValue(dt.Rows[0]["SITEID"].ToString()));
        ddlD_W.SelectedIndex = ddlD_W.Items.IndexOf(ddlD_W.Items.FindByValue(dt.Rows[0]["D/W"].ToString()));
        txtTrainino.Text = dt.Rows[0]["TRNO"].ToString();
        txtLoad.Text = dt.Rows[0]["LOAD"].ToString();
        txtGrad.Text = dt.Rows[0]["GRAD"].ToString();
        txtReputedReason.Text = dt.Rows[0]["REPOTED REASON"].ToString();
        //txtRemarks.Text = dt.Rows[0]["REMARKS"].ToString();

    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Fill_Class();
            Fill_Site();
            if ((string)Request.QueryString["id"] != null)
            {
                btnSave.Text = "UPDATE";
                Fill_Data();
            }
        }
    }
    public void Insertion()
    {
        Cls_jos_railway_shed_pos3 c = new Cls_jos_railway_shed_pos3();
        c.d_or_W = ddlD_W.SelectedValue.ToString();
        c.Grad = txtGrad.Text;
        c.Loco_id = ddlLocono.SelectedValue.ToString();
        //string str = txtDate.Text;
        c.LocoDate = txtDate.Text.Substring(3, 2).ToString() + "/" + txtDate.Text.Substring(0, 2).ToString() + "/" + txtDate.Text.Substring(6, 4).ToString();
        c.ReportedReason = txtReputedReason.Text;
        c.site_id = ddlSite.SelectedValue.ToString();
        c.TLoad = txtLoad.Text;
        c.Trno = txtTrainino.Text;
        c.Generationdate = DateTime.Today.Month.ToString() + "/" + DateTime.Today.Day.ToString() + "/" + DateTime.Today.Year.ToString();
        c.Insert_Data();
    }
    public void Updation()
    {
        Cls_jos_railway_shed_pos3 c = new Cls_jos_railway_shed_pos3();
        c.d_or_W = ddlD_W.SelectedValue.ToString();
        c.Grad = txtGrad.Text;
        c.Loco_id = ddlLocono.SelectedValue.ToString();
        //string str = txtDate.Text;
        c.LocoDate = txtDate.Text.Substring(3, 2).ToString() + "/" + txtDate.Text.Substring(0, 2).ToString() + "/" + txtDate.Text.Substring(6, 4).ToString();
        c.ReportedReason = txtReputedReason.Text;
        c.site_id = ddlSite.SelectedValue.ToString();
        c.TLoad = txtLoad.Text;
        c.Trno = txtTrainino.Text;
        c.Generationdate = DateTime.Today.Month.ToString() + "/" + DateTime.Today.Day.ToString() + "/" + DateTime.Today.Year.ToString();
        c.id_shed_Pos3 = Request.QueryString["id"].ToString();
        c.Update_Data();
    }
    protected void btnSave_OnClick(object sender, EventArgs e)
    {
        if (btnSave.Text == "INSERT")
        { Insertion();  }
        else if (btnSave.Text == "UPDATE")
        { Updation(); }
        Response.Redirect("~/LocoShedPosition/View_LineMessage2.aspx");
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
}
