using System;
using System.Collections;
using System.Configuration;
using System.Data;
//using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Railway;
//using System.Xml.Linq;

public partial class Loco_View_LocoDetails : System.Web.UI.Page
{
    Cls_jos_railway_loco_in c = new Cls_jos_railway_loco_in();
    Cls_jos_railway_fire_detail f = new Cls_jos_railway_fire_detail();
    public void Fill_LocoDetails()
    {
        
        if ((string)Request.QueryString["id"] != null)
        {
            c.id_loco_in=Request.QueryString["id"].ToString();
            LocoDatalist.DataSource = c.Select_DataByID1();
            LocoDatalist.DataBind();
            f.mid = Request.QueryString["id"].ToString();
            GridViewfire.DataSource = f.Select_DataById();
            GridViewfire.DataBind();
        
        }
    }
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Fill_LocoDetails();
        }
    }
    protected void lbtnUpdate_OnClick(object sender, EventArgs e)
    {
        Fill_LocoDetails();
        Response.Redirect("~/Loco/Loco_In.aspx?id=" + Request.QueryString["id"].ToString());
    }
    protected void GridViewfire_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void btnPrint_Click(object sender, ImageClickEventArgs e)
    {

        //gv.Columns[gv.Columns.Count - 1].Visible = false;
        //PrintHelper.PrintWebControl(gvTemporaryRepair,
        PrintHelper.PrintWebControl(p1, string.Empty, 0, Request.Url.ToString(), " LOCO IN DETAILS ");
    }
}
