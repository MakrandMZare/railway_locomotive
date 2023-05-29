using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

public partial class LocoShedPosition_ViewShedPositionReport : System.Web.UI.Page
{
    //ViewShedPostionReport objViewShedPositionRpt = new ViewShedPostionReport();
    Cls_DBConnection cdb = new Cls_DBConnection();
    ViewShedPostionReport objViewShedPositionRpt = new ViewShedPostionReport();

    //Cls_jos_railway_loco_in objWDG = new Cls_jos_railway_loco_in();

    //public void fill_gvShed()
    //{
    //    gvShed.DataSource = objViewShedPositionRpt.View_TempRepair();
    //    gvShed.DataBind();
    //}
    //public void fill_WDG4()
    //{
    //    gvLineMessage.DataSource = objViewShedPositionRpt.View_WDG4();
    //    gvLineMessage.DataBind();
    //}
    //public void fill_gvlinemsg2()
    //{
    //    gvLineMessage.DataSource = objViewShedPositionRpt.View_WDG4();
    //    gvLineMessage.DataBind();
    //}
    //public void fill_Locomovement()
    //{
    //    gvLineMessage.DataSource = objViewShedPositionRpt.View_WDG4();
    //    gvLineMessage.DataBind();
    //}

    public void fill_gvShed()
    {
        gvShed.DataSource = objViewShedPositionRpt.View_WDG4();
        gvShed.DataBind();
    }
    public void fill_gvlinemsg2()
    {
        gvLineMessage.DataSource = objViewShedPositionRpt.View_TempRepair();
        gvLineMessage.DataBind();
    }

    
         public void fill_DeadOnLine()
    {
        gvDeadOnLine.DataSource = objViewShedPositionRpt.View_DeadOnLine();
        gvDeadOnLine.DataBind();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
       if(!Page.IsPostBack)
       {

           fill_gvShed();
           fill_gvlinemsg2();
           fill_DeadOnLine();
           //fill_gvShed();

           //fill_WDG4();

           //fill_gvlinemsg2();

           //fill_Locomovement();
       }
    }
    protected void btnPrint_Click(object sender, ImageClickEventArgs e)
    {

    }
    protected void editcheckbox_OnCheckedChanged(object sender, EventArgs e)
    {

    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {

    }
    protected void btnShow_OnClick(object sender, EventArgs e)
    {

    }
    protected void btnSave_OnClick(object sender, EventArgs e)
    {

    }
}
