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

public partial class Loco_ViewLocoHistory : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Fill_Class();
        }
    }
    public void Fill_ScheduleHistory()
    {
        Cls_Loco_History c = new Cls_Loco_History();
        c.loco_id = ddlLocono.SelectedValue.ToString();
        dv1.DataSource = c.Select_LocoScheduleData();
        dv1.DataBind();
    }
   
    protected void ddlLocono_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void ddlClass_SelectedIndexChanged(object sender, EventArgs e)
    {
        Cls_Master_Loco_Type c = new Cls_Master_Loco_Type();
        c.id_ltype = ddlClass.SelectedValue.ToString();
        lblguage.Text = "";
        lblguage.Visible = true;
        lblguage.Text = c.Get_LocoGuageByLocotype();
        if (lblguage.Text == "METER GUAGE")
        {
            lblguage.Visible = true;
        }
        else
        {
            lblguage.Visible = false;
        }
        Fill_LocoNo();
    }
    protected void btnShow_OnClick(object sender, EventArgs e)
    {
        Fill_ScheduleHistory();
        Fill_AssemblyHistory();
    }
    public void Fill_AssemblyHistory()
    {
        Cls_Loco_Assembly_History c = new Cls_Loco_Assembly_History();
        dv2.DataSource = c.Generate_AssemblyReport("WHERE Id_LocoNo='" + ddlLocono.SelectedValue.ToString() + "'");
        dv2.DataBind();
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
}
