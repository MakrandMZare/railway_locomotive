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

public partial class Master_View_Assembly_Electrical_SubMaster : System.Web.UI.Page
{
    public void Fill_MechanicalMasteItems()
    {
        Cls_Assembly_ElectricalItem c = new Cls_Assembly_ElectricalItem();
        ddlMechenical.DataSource = c.Select_Data();
        ddlMechenical.DataTextField = "NameOfItem";
        ddlMechenical.DataValueField = "Id_Electrical";

        ddlMechenical.DataBind();

        ddlMechenical.Items.Insert(0, "SELECT");
    }
    public void Fill_Data()
    {
        Cls_Assembly_ElectricalItem_SubMaster c = new Cls_Assembly_ElectricalItem_SubMaster();
        c.Id_Electrical = ddlMechenical.SelectedValue.ToString();
        gv1.DataSource = c.Select_DataByItemId();
        gv1.DataBind();

    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Fill_MechanicalMasteItems();
        }
    }

    protected void gv1_OnRowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Cls_Assembly_ElectricalItem_SubMaster c = new Cls_Assembly_ElectricalItem_SubMaster();
        c.Id_ElectricalSub = gv1.DataKeys[e.RowIndex].Value.ToString();
        c.Delete_Data();
        Fill_Data();
    }
    protected void ddlMechanical_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlMechenical.SelectedIndex != 0)
        {
            Fill_Data();
        }
    }
}
