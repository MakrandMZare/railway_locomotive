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

public partial class Master_Assembly_MechanicalItems_SubMaster : System.Web.UI.Page
{
    public void Insertion()
    {
        //Cls_Assembly_ElectricalItem_SubMaster c = new Cls_Assembly_ElectricalItem_SubMaster();
        
        Cls_Assembly_MechanicalItem_SubMaster c = new Cls_Assembly_MechanicalItem_SubMaster();

        c.DlwPlno = txtDwlpl.Text;
        c.EMDPrno = txtEmd.Text;
        c.Grno = txtGrno.Text;
        c.Id_Mechanical = ddlMechanical.SelectedValue.ToString();
        c.ItemDescription = txtItemsDescription.Text;
        c.QEMPrno = txtOem.Text;
        c.Qty = txtQty.Text;
        c.Rate = txtRate.Text;
        c.SWRPrno = txtSwr.Text;
        c.Insert_Data();
        Response.Redirect("~/Master/View_Assembly_Mechanical_SubMaster.aspx?MecId=" + c.Id_Mechanical);
    }
    public void Fill_MechanicalMasteItems()
    {
        Cls_Assembly_MechanicalItem c = new Cls_Assembly_MechanicalItem();
        ddlMechanical.DataSource = c.Select_Data();
        ddlMechanical.DataTextField = "NameOfItem";
        ddlMechanical.DataValueField = "Id_Mechanic";
        ddlMechanical.DataBind();

        ddlMechanical.Items.Insert(0, "SELECT");
    }
    public void Updation()
    {
        Cls_Assembly_MechanicalItem_SubMaster c = new Cls_Assembly_MechanicalItem_SubMaster();
        c.Id_MechanicalSub = Request.QueryString["Id"].ToString();
        c.DlwPlno = txtDwlpl.Text;
        c.EMDPrno = txtEmd.Text;
        c.Grno = txtGrno.Text;
        c.Id_Mechanical = ddlMechanical.SelectedValue.ToString();
        c.ItemDescription = txtItemsDescription.Text;
        c.QEMPrno = txtOem.Text;
        c.Qty = txtQty.Text;
        c.Rate = txtRate.Text;
        c.SWRPrno = txtSwr.Text;
        c.Update_Data();
        Response.Redirect("~/Master/View_Assembly_Mechanical_SubMaster.aspx?MecId=" + c.Id_Mechanical);
    }
    public void Fill_Data()
    {
        Cls_Assembly_MechanicalItem_SubMaster c = new Cls_Assembly_MechanicalItem_SubMaster();
        DataTable dt = new DataTable();
        c.Id_MechanicalSub = Request.QueryString["Id"].ToString();
        dt = c.Select_DataById();
        ddlMechanical.SelectedIndex = ddlMechanical.Items.IndexOf(ddlMechanical.Items.FindByValue(dt.Rows[0][1].ToString()));
        txtGrno.Text = dt.Rows[0][2].ToString();
        txtItemsDescription.Text = dt.Rows[0][3].ToString();
        txtEmd.Text = dt.Rows[0][4].ToString();
        txtOem.Text = dt.Rows[0][5].ToString();
        txtSwr.Text = dt.Rows[0][6].ToString();
        txtDwlpl.Text = dt.Rows[0][7].ToString();
        txtQty.Text = dt.Rows[0][8].ToString();
        txtRate.Text = dt.Rows[0][9].ToString();
        btnSave.Text = "Update";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Fill_MechanicalMasteItems();
            if ((string)Request.QueryString["Id"] != "" && (string)Request.QueryString["action"] == "Update")
            {
                Fill_Data();
            }
        }

    }
    protected void btnSave_OnClick(object sender, EventArgs e)
    {
        if (btnSave.Text == "Insert")
        {
            Insertion();
        }
        else if (btnSave.Text == "Update")
        {
            if ((string)Request.QueryString["Id"] != "")
            {
                Updation();
            }

        }
    }
}
