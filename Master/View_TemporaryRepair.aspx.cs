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
public partial class LocoShedPosition_View_TemporaryRepair : System.Web.UI.Page
{
    public void Fill_Data()
    {
        Cls_jos_railway_Loco_Temporary_Repair c = new Cls_jos_railway_Loco_Temporary_Repair();
        Cls_jos_railway_shed_pos3 c2 = new Cls_jos_railway_shed_pos3();
        if (txtDate.Text == "")
        {
            DateTime d = DateTime.Today;
            c.Generation_Date = d.Month.ToString() + "/" + d.Day.ToString() + "/" + d.Year.ToString();
            c2.Generationdate = d.Month.ToString() + "/" + d.Day.ToString() + "/" + d.Year.ToString();
        }
        else
        {
            c.Generation_Date = txtDate.Text.Substring(3, 2).ToString() + "-" + txtDate.Text.Substring(0, 2).ToString() + "/" + txtDate.Text.Substring(6, 4).ToString();
            c.Generation_Date = txtDate.Text.Substring(3, 2).ToString() + "-" + txtDate.Text.Substring(0, 2).ToString() + "/" + txtDate.Text.Substring(6, 4).ToString();
        }

        gvTemporaryRepair.DataSource = c.Select_Data();
        gvTemporaryRepair.DataBind();
        if (gvTemporaryRepair.Rows.Count > 0)
        {
            btnPrint.Visible = true;
        }
        else
        {
            btnPrint.Visible = false;
        }

        //gvLineMessage2.DataSource = c.Select_Data();
        //gvLineMessage2.DataBind();

    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Fill_Data();

        }
        else
        {
            if (Request.QueryString["id"] != null)
            {
                Cls_jos_railway_Loco_Temporary_Repair c = new Cls_jos_railway_Loco_Temporary_Repair();
                c.Id_Loco_Temp_Repair = Request.QueryString["id"].ToString();
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
        PrintHelper.PrintWebControl(p1, string.Empty,0, Request.Url.ToString()," EMD LOCOS UNDER TEMPORARY REPAIR ");
    }

}
