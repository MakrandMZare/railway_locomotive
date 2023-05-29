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
public partial class Loco_View_LocoOut : System.Web.UI.Page
{
    Cls_jos_railway_loco_out c = new Cls_jos_railway_loco_out();
    protected void Fill_Data()
    {
        gvLocoOut.DataSource = c.Select_Data();
        gvLocoOut.DataBind();
        if (gvLocoOut.Rows.Count > 0)
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
            if ((string)Request.QueryString["id"] != null)
            {
                c.id_loco_out  = Request.QueryString["id"].ToString();
                c.Delete_Data();
                Fill_Data();
            }
        }
    }
    protected void btnPrint_Click(object sender, ImageClickEventArgs e)
    {
        gvLocoOut.Columns[gvLocoOut.Columns.Count - 1].Visible = false;

        PrintHelper.PrintWebControl(p1, string.Empty, 0, Request.Url.ToString(), " LOCO OUT ");
    }
}
