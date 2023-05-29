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

public partial class LocoShedPosition_View_ShedPosition : System.Web.UI.Page
{
    public void Fill_Data()
    {
        Cls_jos_Railway_Loco_LineMsg c = new Cls_jos_Railway_Loco_LineMsg();
        if (txtDate.Text == "")
        {
            c.Generation_Date  = DateTime.Today.Month.ToString() + "/" + DateTime.Today.Day.ToString() + "/" + DateTime.Today.Year.ToString();
        }
        else
        {
            c.Generation_Date = txtDate.Text.Substring(3, 2) + "/" + txtDate.Text.Substring(0, 2) + "/" + txtDate.Text.Substring(6, 4);
        }
        gvTemporaryRepair.DataSource = c.Select_Data();
        gvTemporaryRepair.DataBind();
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
                Cls_jos_Railway_Loco_LineMsg c = new Cls_jos_Railway_Loco_LineMsg();
                c.Id_Loco_Linemsg = Request.QueryString["id"].ToString();
                c.Delete_Data();
                Fill_Data();
            }
        }
    }
    protected void btnShow_OnClick(object sender, EventArgs e)
    {
        Fill_Data();
    }
    protected void btnPrint_Click(object sender, ImageClickEventArgs e)
    {

        gvTemporaryRepair.Columns[gvTemporaryRepair.Columns.Count - 1].Visible = false;
        //PrintHelper.PrintWebControl(gvTemporaryRepair,
        PrintHelper.PrintWebControl(p1, string.Empty, 0, Request.Url.ToString(), " SHED POSITION ");
    }
}
