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
using Railway;
//using System.Xml.Linq;

public partial class Loco_View_Logooutdetails : System.Web.UI.Page
{
    Cls_jos_railway_loco_out c = new Cls_jos_railway_loco_out();
    Cls_jos_railway_fire_detail_out fi = new Cls_jos_railway_fire_detail_out();
    public void Fill_LocooutDetails()
    {
        if ((string)Request.QueryString["id"] != null)
        {
            c.id_loco_out = Request.QueryString["id"].ToString();
            LocooutDataList.DataSource = c.Select_DataByID2();
            LocooutDataList.DataBind();

            fi.mid = Request.QueryString["id"].ToString();
            GridViewfire.DataSource = fi.Select_DataById();
            GridViewfire.DataBind();

        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        Fill_LocooutDetails();
    }
    protected void LocooutDataList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void lbtnUpdate_OnClick(object sender, ImageClickEventArgs e)
    {
        Fill_LocooutDetails();
        Response.Redirect("~/Loco/Loco_Out.aspx?id=" + Request.QueryString["id"].ToString());
    }
    protected void GridViewfire_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
