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
public partial class LocoShedPosition_View_LocoMovements : System.Web.UI.Page
{
    public void Fill_Data()
    {
        Cls_jos_railway_Loco_Movements c = new Cls_jos_railway_Loco_Movements();
        if (txtDate.Text == "")
        {
            c.GenerationDate = DateTime.Today.Month.ToString() + "/" + DateTime.Today.Day.ToString() + "/" + DateTime.Today.Year.ToString();
        }
        else
        {
            //c.GenerationDate = txtDate.Text.Substring(3, 2) + "/" + txtDate.Text.Substring(0, 2) + "/" + txtDate.Text.Substring(6, 4);
            c.GenerationDate = txtDate.Text.ToString();
        }
        gvLocoMovements.DataSource = c.Select_Data2();
        gvLocoMovements.DataBind();
        //    gvLocoMovements.DataSource = c.Select_Data2_yearly();
        //   gvLocoMovements.DataBind();
        if (gvLocoMovements.Rows.Count > 0)
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
        //    txtDate.Text = temp(System.DateTime.Now.Day.ToString()) + "/" + temp(System.DateTime.Now.Month.ToString()) + "/" + temp(System.DateTime.Now.Year.ToString());
        }
        else
        {
            if ((string)Request.QueryString["id"] != null)
            {
                Cls_jos_railway_Loco_Movements c = new Cls_jos_railway_Loco_Movements();
                c.Id_Loco_Movement = Request.QueryString["id"].ToString();
                c.Delete_Data();
                Fill_Data();
            }
        }
    }

    protected void btnShow_OnClick(object sender, EventArgs e)
    {
        //Fill_Data();

        if (txtDate.Text != null)
        {
            Fill_Data_DateWise(txtDate.Text);

        //Response.Redirect("~/LocoShedPosition/View_LocoMovements.aspx");
          }
    }

    public void Fill_Data_DateWise(string ReportDate)
    {

        if (ReportDate != "")
        {
            {
                //RDate = RDate.Substring(3, 2) + "/" + RDate.Substring(0, 2) + "/" + RDate.Substring(6, 4);
                ReportDate = ReportDate.Substring(6, 4) + "-" + ReportDate.Substring(3, 2) + "-" + ReportDate.Substring(0, 2);

                Cls_jos_railway_Loco_Movements c = new Cls_jos_railway_Loco_Movements();
                DataTable dt = c.Get_LocoMovement_Date_Wise(ReportDate);
                gvLocoMovements.Visible = false;
                gvmov.DataSource = dt;
  
               
                //gvmov.DataSource = c.Get_LocoMovement_Date_Wise(RDate);
                gvmov.DataBind();
//
            }
        }
    }
    protected void btnSave_OnClick(object sender, EventArgs e)
    {
        Cls_jos_railway_Loco_Movements cLocoMovement = new Cls_jos_railway_Loco_Movements();
        Cls_Shed_PositionReport crpt = new Cls_Shed_PositionReport();
        foreach (GridViewRow gr in gvLocoMovements.Rows)
        {

            DataTable dt = new DataTable();
            dt = crpt.Get_SavedReportId();
            if (gr.RowType == DataControlRowType.DataRow)
            {
                Label l1, l2, l3, l4, l5,  l7, l8, l9, l10, l11 = new Label();
                l1 = (Label)gr.FindControl("Label1");
                l2 = (Label)gr.FindControl("Label2");
                l3 = (Label)gr.FindControl("Label3");
                l4 = (Label)gr.FindControl("Label11");
                l5 = (Label)gr.FindControl("Label4");
                //  l6 = (Label)gr.FindControl("Label14");
                l7 = (Label)gr.FindControl("Label5");
                l8 = (Label)gr.FindControl("Label6");
                l9 = (Label)gr.FindControl("Label7");
                l10 = (Label)gr.FindControl("Label8");
                l11 = (Label)gr.FindControl("Label9");

                //l5 = (Label)gr.FindControl("Label4");
                //l6 = (Label)gr.FindControl("Label5");
                //l7 = (Label)gr.FindControl("Label6");
                //l8 = (Label)gr.FindControl("Label7");
                //l9 = (Label)gr.FindControl("Label8");
                //l10 = (Label)gr.FindControl("Label9");
                ////l10 = (Label)gr.FindControl("Label9");

                if (dt.Rows.Count > 0)
                {

                    string rptid = dt.Rows[0][0].ToString();
                    cLocoMovement.Save_LocoMovementReport(l1.Text, l2.Text, l3.Text, l4.Text, l5.Text, l7.Text, l8.Text, l9.Text, l10.Text, l11.Text, rptid);

                }
                else
                {

                    crpt.ReportDate = System.DateTime.Now.Month.ToString() + "/" + System.DateTime.Now.Day.ToString() + "/" + System.DateTime.Now.Year.ToString();
                    cLocoMovement.Save_LocoMovementReport(l1.Text, l2.Text, l3.Text, l4.Text, l5.Text, l7.Text, l8.Text, l9.Text, l10.Text, l11.Text, crpt.Insert_Data().ToString());

                }
            }




        }
    }
    protected void gvLocoMovements_OnRowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow && e.Row.RowState == DataControlRowState.Edit)
        {

            Cls_jos_railway_division cdiv = new Cls_jos_railway_division();
            DropDownList dd = (DropDownList)e.Row.FindControl("ddlDiv");
            DataTable dt = new DataTable();
            dt = cdiv.Select_Data();
            dd.DataSource = dt;
            dd.DataTextField = "div";
            dd.DataValueField = "id_div";
            dd.DataBind();
            Cls_jos_railway_mst_site cSite = new Cls_jos_railway_mst_site();
            DropDownList dd1 = (DropDownList)e.Row.FindControl("ddlSite");
            dd1.DataSource = cSite.Select_Data();
            dd1.DataTextField = "Site_Name";
            dd1.DataValueField = "Id_Site";
            dd1.DataBind();
            Cls_jos_railway_mst_SiteSection cSection = new Cls_jos_railway_mst_SiteSection();
            DropDownList dd2 = new DropDownList();
            dd2 = (DropDownList)e.Row.FindControl("ddlSection");
            dd2.DataSource = cSection.Select_Data();
            dd2.DataTextField = "SiteSectionName";
            dd2.DataValueField = "Id_SiteSection";
            dd2.DataBind();
        }
    }
    protected void gvLocoMovements_OnRowEditing(object sender, GridViewEditEventArgs e)
    {
        gvLocoMovements.EditIndex = e.NewEditIndex;
        Fill_Data();
    }
    protected void gvLocoMovements_OnRowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        DropDownList ddlDiv, ddlSite, ddlSection = new DropDownList();
        TextBox txtRemarks = new TextBox();
        Cls_jos_railway_Loco_Movements c = new Cls_jos_railway_Loco_Movements();
        ddlDiv = (DropDownList)gvLocoMovements.Rows[e.RowIndex].FindControl("ddlDiv");
        ddlSite = (DropDownList)gvLocoMovements.Rows[e.RowIndex].FindControl("ddlSite");
        ddlSection = (DropDownList)gvLocoMovements.Rows[e.RowIndex].FindControl("ddlSection");
        txtRemarks = (TextBox)gvLocoMovements.Rows[e.RowIndex].FindControl("txtRemarks");
        c.Div = ddlDiv.SelectedValue.ToString();
        c.Site_Id = ddlSite.SelectedValue.ToString();
        c.Section_Id = ddlSection.SelectedValue.ToString();
        c.Remarks = txtRemarks.Text;
        c.Id_Loco_Movement = gvLocoMovements.DataKeys[e.RowIndex].Value.ToString();
        c.Update_Div_Site_Section_RemarksInLocoMovement();
        gvLocoMovements.EditIndex = -1;
        Fill_Data();
    }

    protected void gvLocoMovements_OnRowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        gvLocoMovements.EditIndex = -1;
        Fill_Data();
    }
    public string temp(string str)
    {
        return str.Length == 1 ? "0" + str : str;
    }
    protected void chkEdit_OnCheckedChanged(object sender, EventArgs e)
    {
        if (chkEdit.Checked == true)
        {
            string a = temp(System.DateTime.Now.Day.ToString()) + "/" + temp(System.DateTime.Now.Month.ToString()) + "/" + temp(System.DateTime.Now.Year.ToString());
            if (txtDate.Text == a)
            {
                lblmsg.Visible = false;
                gvLocoMovements.Columns[gvLocoMovements.Columns.Count - 1].Visible = true;
            }
            else
            {
                lblmsg.Visible = true;
                gvLocoMovements.Columns[gvLocoMovements.Columns.Count - 1].Visible = false;
            }
        }
        else
        {
            lblmsg.Visible = true;
            gvLocoMovements.Columns[gvLocoMovements.Columns.Count - 1].Visible = false;
        }
    }
    protected void btnPrint_Click(object sender, ImageClickEventArgs e)
    {
        gvLocoMovements.Columns[gvLocoMovements.Columns.Count - 1].Visible = false;

        PrintHelper.PrintWebControl(p1, string.Empty, 0, Request.Url.ToString(), " LOCO MOVEMENTS ");
    }


    //SELECT     rpt_locomovment.IdLocoMovement, rpt_locomovment.locono, rpt_locomovment.dateofarrival, rpt_locomovment.doc, rpt_locomovment.lastout, rpt_locomovment.lastschedule, rpt_locomovment.rapairattended, rpt_locomovment.site, rpt_locomovment.section, rpt_locomovment.remarks,rpt_locomovment.Shed_Position_rpt, rpt_locomovment.division, Saved_ShedPositionReport.Id_ShedPosition_rpt, Saved_ShedPositionReport.ReportDate FROM rpt_locomovment CROSS JOIN Saved_ShedPositionReport where Saved_ShedPositionReport.ReportDate ='2011-01-07'
    //SELECT     rpt_locomovment.IdLocoMovement, rpt_locomovment.locono, rpt_locomovment.dateofarrival, rpt_locomovment.doc, rpt_locomovment.lastout, rpt_locomovment.lastschedule, rpt_locomovment.rapairattended, rpt_locomovment.site, rpt_locomovment.section, rpt_locomovment.remarks,rpt_locomovment.Shed_Position_rpt, rpt_locomovment.division, Saved_ShedPositionReport.Id_ShedPosition_rpt, Saved_ShedPositionReport.ReportDate FROM rpt_locomovment INNER JOIN Saved_ShedPositionReport ON Saved_ShedPositionReport.Id_ShedPosition_rpt=rpt_locomovment.Shed_Position_rpt where Saved_ShedPositionReport.ReportDate 
}
