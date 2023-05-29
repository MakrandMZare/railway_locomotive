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

public partial class Loco_View_LocoIn : System.Web.UI.Page
{
    Cls_jos_railway_loco_in c = new Cls_jos_railway_loco_in();
    protected void Fill_Data()
    {
        gvLocoIn.DataSource = c.Select_Data();
        gvLocoIn.DataBind();
        if (gvLocoIn.Rows.Count > 0)
        {
            btnPrint.Visible = true;
        }
        else
        {
            btnPrint.Visible = false;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Fill_Data();
        }
        else
        {
        if((string)Request.QueryString["id"] != null)
            {
                c.id_loco_in = Request.QueryString["id"].ToString();
                c.Delete_Data();
                Fill_Data();
            }
        }
    }
    protected void btnPrint_Click(object sender, ImageClickEventArgs e)
    {
        gvLocoIn.Columns[gvLocoIn.Columns.Count - 1].Visible = false;

        PrintHelper.PrintWebControl(p1, string.Empty, 0, Request.Url.ToString(), " LOCO IN ");
    }
}
