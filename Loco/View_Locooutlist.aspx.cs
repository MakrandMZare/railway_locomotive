using System;
using System.Collections;
using System.Configuration;
using System.Data;
//using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Railway;
//using System.Xml.Linq;

public partial class Loco_Locooutlist : System.Web.UI.Page
{
    Cls_jos_railway_loco_out c = new Cls_jos_railway_loco_out();
    protected void Fill_LocoNo()
    {
        c.tid = ddlClass.SelectedValue.ToString();
        c.tid = ddlClass.SelectedValue.ToString();
        ddlLocono.DataSource = c.Select_Loco();
        ddlLocono.DataTextField = "locono";
        ddlLocono.DataValueField = "id_mst_loco";
        ddlLocono.DataBind();
        ddlLocono.Items.Insert(0,"SELECT");
    }
    protected void Fill_Class()
    {
        ddlClass.DataSource = c.Select_Class();
        ddlClass.DataTextField = "loco_type";
        ddlClass.DataValueField = "id_ltype";
        ddlClass.DataBind();
        ddlClass.Items.Insert(0, "SELECT");
    }
    public void Fill_Outdetails()
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
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Fill_Outdetails();
            Fill_Class();
        }
    }
    protected void gvLocolist_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void ddlLocono_SelectedIndexChanged(object sender, EventArgs e)
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
    protected void CheckboxEdit_OnCheckedChanged(object sender, EventArgs e)
    {
        if (CheckboxEdit.Checked == true)
        {
            gvLocolist.Columns[gvLocolist.Columns.Count - 1].Visible = true;
        }
        else if (CheckboxEdit.Checked == false)
        {
            gvLocolist.Columns[gvLocolist.Columns.Count - 1].Visible = false;
        }
    }
    public void Fill_Data(string loco, string outdate)
    {
        if (outdate != "")
        {
            outdate = outdate.Substring(3, 2).ToString() + "/" + outdate.Substring(0, 2).ToString() + "/" + outdate.Substring(6, 4).ToString();
        }
        gvLocolist.DataSource = c.Select_Data(loco,outdate);
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
        Fill_Data(ddlLocono.SelectedValue.ToString(), txtoutdate.Text);
    }
}
