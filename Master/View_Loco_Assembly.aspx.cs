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
public partial class Master_View_Loco_Assembly : System.Web.UI.Page
{
    public void Fill_Data()
    {
        Cls_jos_railway_loco_assembly c = new Cls_jos_railway_loco_assembly();
        c.mid = Request.QueryString["id"].ToString();
        gv1.DataSource = c.Select_DataByLocoId();
        gv1.DataBind();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if ((string)Request.QueryString["id"] != null)
            {
                Fill_Data();
            }
        }
    }
}
