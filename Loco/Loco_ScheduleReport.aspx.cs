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
using System.Data.SqlClient;
public partial class Loco_Loco_ScheduleReport : System.Web.UI.Page
{
    public void Fill_ScheduleReport()
    {
        Cls_jos_railway_mst_loco c = new Cls_jos_railway_mst_loco();
        c.Loco_Id = ddlLocono.SelectedValue.ToString();
        gv1.DataSource = c.Select_Loco_ScheduleData();
        gv1.DataBind();
    }
    public void Fill_Class()
    {
        Cls_jos_railway_loco_in obj = new Cls_jos_railway_loco_in();
        ddlClass.DataSource = obj.SelectLocoType();
        ddlClass.DataTextField = "loco_type";
        ddlClass.DataValueField = "id_ltype";
        ddlClass.DataBind();
        ddlClass.Items.Insert(0, "SELECT");
    }
    public void Fill_LocoNo()
    {

        if (ddlClass.SelectedIndex != 0)
        {
            Cls_jos_railway_loco_in obj = new Cls_jos_railway_loco_in();
            ddlLocono.DataSource = obj.Select_LocoNo(ddlClass.SelectedValue.ToString());
            ddlLocono.DataTextField = "locono";
            ddlLocono.DataValueField = "id_mst_loco";
            ddlLocono.DataBind();
            ddlLocono.Items.Insert(0, "SELECT");
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Fill_Class();
        }
    }
    protected void ddlClass_SelectedIndexChanged(object sender, EventArgs e)
    {
        Fill_LocoNo();
        Cls_Master_Loco_Type c = new Cls_Master_Loco_Type();
        c.id_ltype = ddlClass.SelectedValue.ToString();
        lblguage.Text = "";
        lblguage.Visible = true;
        lblguage.Text = c.Get_LocoGuageByLocotype();
    }
    public void Insert_LocoSchedule(string m, string locotype, string docdate)
    {
        Cls_jos_railway_mst_loco c = new Cls_jos_railway_mst_loco();
        Cls_jos_railway_loco_type_schedule c1 = new Cls_jos_railway_loco_type_schedule();

        DateTime schdate = Convert.ToDateTime(docdate);

        c1.loco_id = locotype;
        DataTable ScheduleData = c1.Select_Data();
        if (ScheduleData.Rows.Count > 0)
        {
            foreach (DataRow dr in ScheduleData.Rows)
            {
                c.Schedule_Id = dr[0].ToString();
                schdate = schdate.AddDays(Convert.ToInt64(dr[2].ToString()));
                string mm = schdate.Month.ToString();
                
                string d = schdate.Day.ToString();
                string y = schdate.Year.ToString();
                if (mm.Length == 1)
                {
                    mm = "0" + mm;
                }
                if (d.Length == 1)
                {
                    d = "0" + d;
                }
                //string str = schdate.ToShortDateString().Replace("-", "/");

                //c.ScheduleDate = str.Substring(3, 2).ToString() + "/" + str.Substring(0, 2).ToString() + "/" + str.Substring(6, 4).ToString();
                c.ScheduleDate = mm + "/" + d + "/" + y;
                c.Loco_Id = m;
                if (c.Check_Loco_ScheduleIsExists())
                {
                    c.Update_Data_Loco_Schedule();
                }
                else 
                {
                    c.Insert_Data_Loco_Schedule();
                }
            }
        }
    }
    protected void btnShow_OnClick(object sender, EventArgs e)
    {
        //Update Schedule Information
        Cls_jos_railway_mst_loco c = new Cls_jos_railway_mst_loco();
        c.id_mst_loco = ddlLocono.SelectedValue.ToString();
        DataTable dt = c.Select_DocDateById();
        if (dt.Rows.Count > 0)
        {
            Insert_LocoSchedule(ddlLocono.SelectedValue.ToString(),ddlClass.SelectedValue.ToString(),dt.Rows[0][0].ToString());
        }

        //Display Schedule Time Table
        Fill_ScheduleReport();
    }
    protected void ddlLocono_SelectedIndexChanged(object sender, EventArgs e)
    {
        Cls_jos_railway_mst_loco c = new Cls_jos_railway_mst_loco();
        c.id_mst_loco = ddlLocono.SelectedValue.ToString();
        lbldoc.Text = c.GetDocDateBylocoId();
    }
}
