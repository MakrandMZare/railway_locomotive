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
using Railway;
//using System.Xml.Linq;

public partial class Loco_View_Locolist : System.Web.UI.Page
{
    Cls_jos_railway_loco_in c = new Cls_jos_railway_loco_in();

    public void Fill_Class()
    {
        ddlClass.DataSource = c.SelectLocoType();
        ddlClass.DataTextField = "loco_type";
        ddlClass.DataValueField = "id_ltype";
        ddlClass.DataBind();
        ddlClass.Items.Insert(0, "SELECT");
    }
    public void Fill_LocoNo()
    {
        if (ddlClass.SelectedIndex != 0)
        {
            ddlLocono.DataSource = c.Select_LocoNo(ddlClass.SelectedValue.ToString());
            ddlLocono.DataTextField = "locono";
            ddlLocono.DataValueField = "id_mst_loco";
            ddlLocono.DataBind();
            ddlLocono.Items.Insert(0, "SELECT");
        }
    }
    public void fill_Data()
    {

        gvLocolist.DataSource = c.Select_Data();
        gvLocolist.DataBind();
        if (gvLocolist.Rows.Count > 0)
        {
            lblerror.Visible = false;
        }
        else
        {
            lblerror.Visible = true;
        }
    }
    public void Delete_Data()
    {
        c.id_loco_in = Request.QueryString["Id"].ToString();
        c.Delete_Data();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Fill_Class();
            fill_Data();
        }
        else
        {
            if ((string)Request.QueryString["action"] == "delete" && (string)Request.QueryString["Id"] != "")
            {
                btnShow_OnClick(sender, e);
            }
        }
    }
    protected void gvLocolist_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void ddlClass_SelectedIndexChanged(object sender, EventArgs e)
    {
        Cls_Master_Loco_Type c = new Cls_Master_Loco_Type();
        c.id_ltype = ddlClass.SelectedValue.ToString();
        lblguage.Text = "";
        lblguage.Visible = true;
        lblguage.Text = c.Get_LocoGuageByLocotype();
        Fill_LocoNo();
    }
    protected void ddlLocono_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void CheckboxEdit_OnCheckedChanged(object sender, EventArgs e)
    {
        if (CheckboxEdit.Checked == true)
        {
            gvLocolist.Columns[gvLocolist.Columns.Count - 1].Visible = true;   
        }
        else if(CheckboxEdit.Checked == false)
        {
            gvLocolist.Columns[gvLocolist.Columns.Count - 1].Visible = false;   
        }
    }
    public void Fill_Data(string loco, string Arrivaldate)
    {
        if (Arrivaldate != "")
        {
            Arrivaldate = Arrivaldate.Substring(3, 2) + "/" + Arrivaldate.Substring(0, 2) + "/" + Arrivaldate.Substring(6, 4);
        }
        gvLocolist.DataSource = c.Select_Data(loco, Arrivaldate);
        gvLocolist.DataBind();
        if (gvLocolist.Rows.Count > 0)
        {
            lblerror.Visible = false;
        }
        else
        {
            lblerror.Visible = true;
        }
    }
    protected void btnShow_OnClick(object sender, EventArgs e)
    {
        Fill_Data(ddlLocono.SelectedValue.ToString(), txtArrivalDate.Text);
    }
}
