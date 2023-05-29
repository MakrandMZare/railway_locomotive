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
public partial class LocoShedPosition_View_ShedPostion1 : System.Web.UI.Page
{
    public void Fill_Data()
    {
        Cls_jos_railway_loco_in c = new Cls_jos_railway_loco_in();
        string str;
        if (txtDate.Text == "")
        {str = DateTime.Today.ToString().Substring(0,10);}
        else
        { str = txtDate.Text.Substring(3, 2) + "/" + txtDate.Text.Substring(0, 2) + "/" + txtDate.Text.Substring(6, 4); }
            
        c.a_date = str.Substring(0, 2).ToString() + "/" + str.Substring(3, 2).ToString() + "/" + str.Substring(6, 4).ToString();
        gv.DataSource = c.Get_ShedPositionReport();
        gv.DataBind();
        if (gv.Rows.Count > 0)
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
       if(!Page.IsPostBack)
       {
           Fill_Data();
       }
       
    }
    protected void btnShow_OnClick(object sender, EventArgs e)
    {
        if (txtDate.Text != null)
        { Fill_Data(); }
    }
    protected void btnPrint_Click(object sender, ImageClickEventArgs e)
    {

        gv.Columns[gv.Columns.Count - 1].Visible = false;
        //PrintHelper.PrintWebControl(gvTemporaryRepair,
        PrintHelper.PrintWebControl(p1, string.Empty, 0, Request.Url.ToString(), " SHED POSITION ");
    }
}
