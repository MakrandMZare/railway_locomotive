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

    public void Transfer_LineMessage_To_TemporaryRepor()
    {
        //this will transfer line message to temporary message after 24 hrs.
        Cls_jos_Railway_Loco_LineMsg c = new Cls_jos_Railway_Loco_LineMsg();
        DataTable dt = c.Get_LineMessageEnterBeforeDay();
        foreach (DataRow dr in dt.Rows)
        {
            Cls_jos_railway_Loco_Temporary_Repair c1 = new Cls_jos_railway_Loco_Temporary_Repair();
            c1.Generation_Date = DateTime.Now.Month.ToString() + "/" + DateTime.Now.Day.ToString() + "/" + DateTime.Now.Year.ToString();
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
        Transfer_LineMessage_To_TemporaryRepor();
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
