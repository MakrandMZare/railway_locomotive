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

public partial class Master_ViewAssemblystock : System.Web.UI.Page
{
    public void Fill_Assembly()
    {
        Cls_jos_railway_mst_Assembly c = new Cls_jos_railway_mst_Assembly();
        ddlAssembly.DataSource = c.Select_Data();
        ddlAssembly.DataTextField = "name";
        ddlAssembly.DataValueField = "id_mst_assem";
        ddlAssembly.DataBind();
        ddlAssembly.Items.Insert(0, "SELECt");
    }
    public void Fill_Data()
    {
        Cls_Assembly_StockItem c = new Cls_Assembly_StockItem();
        c.Id_Assembly = ddlAssembly.SelectedValue.ToString();
        gv1.DataSource = c.Select_DataByAssemblyId();
        gv1.DataBind();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Fill_Assembly();
        }
        else
        {
            if ((string)Request.QueryString["Id"] != "" && Request.QueryString["action"] == "delete")
            {
                Cls_Assembly_StockItem c = new Cls_Assembly_StockItem();
                c.Id_Stock = Request.QueryString["Id"].ToString();
                c.Delete_Data();
                Fill_Data();
            }
        }
    }
    protected void btnShow_OnClick(object sender, EventArgs e)
    {
        if (ddlAssembly.SelectedIndex != 0)
        {
            Fill_Data();
        }
    }
}
