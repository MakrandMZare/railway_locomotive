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

public partial class Master_View_Loco_Master : System.Web.UI.Page
{
    public void Fill_Data()
    {
        Cls_jos_railway_mst_loco c = new Cls_jos_railway_mst_loco();
        if ((string)Request.QueryString["Id"] != null)
        {
            c.id_mst_loco = Request.QueryString["Id"].ToString();
            gv1.DataSource = c.Select_DataById();
            gv1.DataBind();
        }
        else
        {
            gv1.DataSource = c.Select_Data();
            gv1.DataBind();
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Fill_Data();
        }
    }
    protected void gv1_OnRowDataBound(object sender, GridViewRowEventArgs e)
    {
        //foreach (GridViewRow gr in gv1.Rows)
        //{
        //    Label l1 = new Label();
        //    l1 = (Label)gr.FindControl("lblid1");
        //    GridView g = new GridView();
        //    g = (GridView)gr.FindControl("gv2");
        //    Cls_jos_railway_loco_assembly c = new Cls_jos_railway_loco_assembly();
        //    c.mid = l1.Text;
        //    g.DataSource = c.Select_DataByLocoId();
        //    g.DataBind();
        //}

    }
    protected void btnPrint_Click(object sender, ImageClickEventArgs e)
    {

        //gv.Columns[gv.Columns.Count - 1].Visible = false;
        //PrintHelper.PrintWebControl(gvTemporaryRepair,
        PrintHelper.PrintWebControl(p1, string.Empty, 0, Request.Url.ToString(), " LOCO ");
    }
}
