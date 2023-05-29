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
public partial class Master_Assembly_Supplier : System.Web.UI.Page
{
    public void Fill_Assembly_Supplier()
    {
        Cls_Loco_Assembly_Supplier c = new Cls_Loco_Assembly_Supplier();
        c.rdso = ddlrdso.SelectedValue.ToString();
        gvSupplier.DataSource = c.SelectSupplierByAssembly();
        gvSupplier.DataBind();

    }
    public void Fill_RdsoCode(string code)
    {
        Cls_railway_rdso c = new Cls_railway_rdso();
        ddlrdso.DataSource = c.Select_RdsoByDigit(code);
        ddlrdso.DataTextField = "nature_defect";
        ddlrdso.DataValueField = "rdso";
        ddlrdso.DataBind();
        ddlrdso.Items.Insert(0, "SELECT");
        ViewState["Code"] = code;
    }
    public void Fill_Supplier(string str)
    {
        Cls_jos_railway_mst_supplier c = new Cls_jos_railway_mst_supplier();
        ddlSupplier.DataSource = c.GetSupplier(str);
        ddlSupplier.DataTextField = "s_name";
        ddlSupplier.DataValueField = "id_supp";
        ddlSupplier.DataBind();
        ddlSupplier.Items.Insert(0, "SELECT");

    }
    protected void lbtnA_OnClick(object sender, EventArgs e)
    {
        Fill_Supplier("A");
    }
    protected void lbtnB_OnClick(object sender, EventArgs e)
    {
        Fill_Supplier("B");
    }
    protected void lbtnC_OnClick(object sender, EventArgs e)
    {
        Fill_Supplier("C");
    }
    protected void lbtnD_OnClick(object sender, EventArgs e)
    {
        Fill_Supplier("D");
    }
    protected void lbtnE_OnClick(object sender, EventArgs e)
    {
        Fill_Supplier("E");
    }
    protected void lbtnF_OnClick(object sender, EventArgs e)
    {
        Fill_Supplier("F");
    }
    protected void lbtnG_OnClick(object sender, EventArgs e)
    {
        Fill_Supplier("G");
    }
    protected void lbtnH_OnClick(object sender, EventArgs e)
    {
        Fill_Supplier("H");
    }
    protected void lbtnI_OnClick(object sender, EventArgs e)
    {
        Fill_Supplier("I");
    }
    protected void lbtnJ_OnClick(object sender, EventArgs e)
    {
        Fill_Supplier("J");
    }
    protected void lbtnK_OnClick(object sender, EventArgs e)
    {
        Fill_Supplier("K");
    }
    protected void lbtnL_OnClick(object sender, EventArgs e)
    {
        Fill_Supplier("L");
    }
    protected void lbtnM_OnClick(object sender, EventArgs e)
    {
        Fill_Supplier("M");
    }
    protected void lbtnN_OnClick(object sender, EventArgs e)
    {
        Fill_Supplier("N");
    }
    protected void lbtnO_OnClick(object sender, EventArgs e)
    {
        Fill_Supplier("O");
    }
    protected void lbtnP_OnClick(object sender, EventArgs e)
    {
        Fill_Supplier("P");
    }
    protected void lbtnQ_OnClick(object sender, EventArgs e)
    {
        Fill_Supplier("Q");
    }
    protected void lbtnR_OnClick(object sender, EventArgs e)
    {
        Fill_Supplier("R");
    }
    protected void lbtnS_OnClick(object sender, EventArgs e)
    {
        Fill_Supplier("S");
    }
    protected void lbtnT_OnClick(object sender, EventArgs e)
    {
        Fill_Supplier("T");
    }
    protected void lbtnU_OnClick(object sender, EventArgs e)
    {
        Fill_Supplier("U");
    }
    protected void lbtnV_OnClick(object sender, EventArgs e)
    {
        Fill_Supplier("V");
    }
    protected void lbtnW_OnClick(object sender, EventArgs e)
    {
        Fill_Supplier("W");
    }
    protected void lbtnX_OnClick(object sender, EventArgs e)
    {
        Fill_Supplier("X");
    }
    protected void lbtnY_OnClick(object sender, EventArgs e)
    {
        Fill_Supplier("Y");
    }
    protected void lbtnZ_OnClick(object sender, EventArgs e)
    {
        Fill_Supplier("Z");
    }
    protected void btnSave_OnClick(object sender, EventArgs e)
    {
        Cls_Loco_Assembly_Supplier c = new Cls_Loco_Assembly_Supplier();
        c.id_supp = ddlSupplier.SelectedValue.ToString();
        c.rdso = ddlrdso.SelectedValue.ToString();
        if (c.Insert_Data() != 0)
        {
            Fill_Assembly_Supplier();
        }

    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void lbtnRdso1_OnClick(object sender, EventArgs e)
    {
        Fill_RdsoCode("1");
        ViewState["Code"] = "1";
    }
    protected void lbtnRdso2_OnClick(object sender, EventArgs e)
    {
        Fill_RdsoCode("2");
        ViewState["Code"] = "2";
    }
    protected void lbtnRdso3_OnClick(object sender, EventArgs e)
    {
        Fill_RdsoCode("3");
        ViewState["Code"] = "3";
    }
    protected void lbtnRdso4_OnClick(object sender, EventArgs e)
    {
        Fill_RdsoCode("4");
        ViewState["Code"] = "4";
    }

    protected void ddlrdso_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlrdso.SelectedIndex != 0)
        {
            Fill_Assembly_Supplier();
        }
    }
}
