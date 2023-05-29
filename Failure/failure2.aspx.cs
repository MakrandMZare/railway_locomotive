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
using Railway;
using System.Data.SqlClient;
public partial class Loco_failure2 : System.Web.UI.Page
{

    Cls_Failure_Detail c = new Cls_Failure_Detail();
    Cls_jos_railway_loco_in obj = new Cls_jos_railway_loco_in();
    public void Fill_Class()
    {
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
            ddlLocono.DataSource = obj.Select_LocoNo(ddlClass.SelectedValue.ToString());
            ddlLocono.DataTextField = "locono";
            ddlLocono.DataValueField = "id_mst_loco";
            ddlLocono.DataBind();
            ddlLocono.Items.Insert(0, "SELECT");
        }
    }
    public void Fill_Category()
    {
        ddlCategory.DataSource = c.select_category();
        ddlCategory.DataTextField = "category";
        ddlCategory.DataValueField = "id_cat";
        ddlCategory.DataBind();
        ddlCategory.Items.Insert(0, "SELECT");

    }

    public void Fill_Unit()
    {
        ddlUnit.DataSource = c.select_Unit();
        ddlUnit.DataTextField = "unit";
        ddlUnit.DataValueField = "id_unit";
        ddlUnit.DataBind();
        ddlUnit.Items.Insert(0, "SELECT");

    }
    public void Fill_Wing()
    {
        ddlwing.DataSource = c.select_wing();
        ddlwing.DataTextField = "wing";
        ddlwing.DataValueField = "id_wings";
        ddlwing.DataBind();
        ddlwing.Items.Insert(0, "SELECT");
    }
    protected void ddlClass_SelectedIndexChanged(object sender, EventArgs e)
    {
        Fill_LocoNo();
    }

    protected void ddlLocono_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!Page.IsPostBack)
        {
            Fill_Category();
            Fill_Unit();
            Fill_Class();
            Fill_Wing();

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {


        if (btnInsert.Text == "INSERT")
        {
            InsertData();
        }

    }


    protected void InsertData()
    {

        c.IdLoco = ddlLocono.SelectedValue.ToString();
        c.IdRailway = ddlrailway.SelectedIndex.ToString();
        c.IdCategory = ddlCategory.SelectedValue.ToString();
        c.FailureType = ddlFailuretype.SelectedIndex.ToString();
        c.IdUnit = ddlUnit.SelectedValue.ToString();
        c.IdWing = ddlwing.SelectedValue.ToString();
        c.Avoidable = ddlAvoidable.SelectedIndex.ToString();
        c.Services = txtservices.Text;
        c.Resp = txtresp.Text;
        c.Overdue = txtOverdue.Text;
        c.MainAssembly = txtmainAssembly.Text;
        c.SubAssembly = txtsubassembly.Text;
        c.ComponentBisection = txtcomponent.Text;
   
        c.Insert_Data_FailureAnalysis2New();
        Clear_Data();

    }

    public void Clear_Data()
    {
        ddlLocono.SelectedIndex = 0;
        ddlrailway.SelectedIndex = 0;
        ddlCategory.SelectedIndex = 0;
        ddlFailuretype.SelectedIndex = 0;
        ddlUnit.SelectedIndex = 0;
        ddlwing.SelectedIndex = 0;
        ddlAvoidable.SelectedIndex = 0;

     txtservices.Text="";
     txtresp.Text="";
     txtOverdue.Text="";
     txtmainAssembly.Text="";
     txtsubassembly.Text="";
     txtcomponent.Text="";
   

    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        ddlClass.SelectedIndex = 0;
        ddlLocono.SelectedIndex = 0;
       

        Clear_Data();
    }
}



