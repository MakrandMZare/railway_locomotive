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
using Railway;
using System.IO;
using System.Text;
using System.Web.SessionState;

public partial class TestingLab_printgear_case : System.Web.UI.Page
{
    gear_case_oil c = new gear_case_oil();
    Cls_jos_railway_loco_in obj = new Cls_jos_railway_loco_in();



    public void Fill_Class()
    {
        ddlclass.DataSource = obj.SelectLocoType();
        ddlclass.DataTextField = "loco_type";
        ddlclass.DataValueField = "id_ltype";
        ddlclass.DataBind();
        ddlclass.Items.Insert(0, "SELECT");
    }
    public void Fill_LocoNo()
    {
        if (ddlclass.SelectedIndex != 0)
        {
            ddlloco.DataSource = obj.Select_LocoNo(ddlclass.SelectedValue.ToString());
            ddlloco.DataTextField = "locono";
            ddlloco.DataValueField = "id_mst_loco";
            ddlloco.DataBind();
            ddlloco.Items.Insert(0, "SELECT");
        }
    }
    protected void Fill_Data()
    {

        gv1.DataSource = c.Select_Data_All();
        gv1.DataBind();
    }

    protected void Page_Load(object sender, EventArgs e)
    {

        if (!Page.IsPostBack)
        {
            string str = System.DateTime.Now.Date.ToString();
            txtenddate.Text = str.Substring(3, 2) + "/" + str.Substring(0, 2) + "/" + str.Substring(6, 4);
            Fill_Data();
            Fill_Class();

        }
    }
    protected void btnShow_OnClick(object sender, EventArgs e)
    {
        DataTable dt = c.Select_DataByLOCO(ddlloco.SelectedValue.ToString());
        gv1.DataSource = dt;

        gv1.DataBind();
    }
    // protected void btnPrint_Click(object sender, ImageClickEventArgs e)
    protected void btnPrint_Click(object sender, EventArgs e)
    {
        //    gv1.Columns[gv1.Columns.Count - 1].Visible = false;

        PrintHelper.PrintWebControl(p1, string.Empty, 0, Request.Url.ToString(), "  report ");


        //Session["ctrl"] = p1;
        //ClientScript.RegisterStartupScript(this.GetType(), "onclick", "<script language=javascript>window.open('printComponantFailure.aspx','PrintMe','height=300px,width=300px,scrollbars=1');</script>");
        //---------------------------
        //Response.Clear();
        //Response.Buffer = true;
        //Response.Charset = "utf-8";
        //System.IO.StringWriter sw = new System.IO.StringWriter();
        //System.Web.UI.HtmlTextWriter hw = new HtmlTextWriter(sw);
        //p1.RenderControl(hw); //Pl_ToPrint
        //Response.Write(sw.ToString());
        //Response.End();

    }
    protected void ddlclass_SelectedIndexChanged(object sender, EventArgs e)
    {
        Fill_LocoNo();
    }
    //public class PrintHelper
    //{
    //    public PrintHelper()
    //    {
    //    }

    //    public static void PrintWebControl(Control ctrl)
    //    {
    //        PrintWebControl(ctrl, string.Empty);
    //    }

    //    public static void PrintWebControl(Control ctrl, string Script)
    //    {
    //        StringWriter stringWrite = new StringWriter();
    //        System.Web.UI.HtmlTextWriter htmlWrite = new System.Web.UI.HtmlTextWriter(stringWrite);
    //        if (ctrl is WebControl)
    //        {
    //            Unit w = new Unit(100, UnitType.Percentage); ((WebControl)ctrl).Width = w;
    //        }
    //        Page pg = new Page();
    //        pg.EnableEventValidation = false;
    //        if (Script != string.Empty)
    //        {
    //            pg.ClientScript.RegisterStartupScript(pg.GetType(), "PrintJavaScript", Script);
    //        }
    //        HtmlForm frm = new HtmlForm();
    //        pg.Controls.Add(frm);
    //        frm.Attributes.Add("runat", "server");
    //        frm.Controls.Add(ctrl);
    //        pg.DesignerInitialize();
    //        pg.RenderControl(htmlWrite);
    //        string strHTML = stringWrite.ToString();
    //        HttpContext.Current.Response.Clear();
    //        HttpContext.Current.Response.Write(strHTML);
    //        HttpContext.Current.Response.Write("<script>window.print();</script>");
    //        HttpContext.Current.Response.End();
    //    }
    //}

    protected void btnPrint_Click(object sender, ImageClickEventArgs e)
    {
        PrintHelper.PrintWebControl(p1, string.Empty, 0, Request.Url.ToString(), "  report ");
    }
}
