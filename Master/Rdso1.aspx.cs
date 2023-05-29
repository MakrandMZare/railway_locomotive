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
public partial class Master_Rdso1 : System.Web.UI.Page
{
    public void Insertion()
    {
        Cls_railway_rdso c = new Cls_railway_rdso();
        c.rdso = txtrdsoCode.Text;
        c.nature_defect = txtDetails.Text;
        Int64 m = Convert.ToInt64(c.Insert_Rdso());
        if (m != 0)
        {
            Fill_RdsoCode(txtrdsoCode.Text.Length.ToString());
        }
    }
    
    protected void OnClick_btnSupplier(object sender, EventArgs e)
    {

    }
    public void Fill_RdsoCode(string code)
    {
        Cls_railway_rdso c = new Cls_railway_rdso();
        gv1.DataSource = c.Select_Rdso(code);
        gv1.DataBind();
        ViewState["Code"] = code;
        txtrdsoCode.Text = "";
        txtDetails.Text = "";
    }
    protected void gv1_OnRowEditing(object sender, GridViewEditEventArgs e)
    {
        gv1.EditIndex = e.NewEditIndex;
        Fill_RdsoCode(ViewState["Code"].ToString());
        //string a = gv1.DataKeys[e.NewEditIndex].Value.ToString();
        ViewState["id"] = gv1.DataKeys[0].Value.ToString();
        Label l1 = new Label();
        Label l2 = new Label();
        l1 = (Label)gv1.Rows[gv1.EditIndex].FindControl("lblRdso");
        l2 = (Label)gv1.Rows[gv1.EditIndex].FindControl("lbldefect");
        txtDetails.Text = l2.Text;
        txtrdsoCode.Text = l1.Text;
        btnSave.Text = "Update";
    }
    public void Updation()
    {
        Cls_railway_rdso c = new Cls_railway_rdso();
        c.rdso = txtrdsoCode.Text;
        c.nature_defect = txtDetails.Text;
        c.Update_Data();
        btnSave.Text = "Insert";
        Fill_RdsoCode(txtrdsoCode.Text.Length.ToString());
    }
    protected void gv1_OnRowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        if (true)
        {
            Cls_railway_rdso c = new Cls_railway_rdso();
            c.id_rdso = gv1.DataKeys[e.RowIndex].Value.ToString();
            c.Delete_Data();
            Fill_RdsoCode(ViewState["Code"].ToString());
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
    protected void OnClick_btnCancel(object sender, EventArgs e)
    {
        txtDetails.Text = "";
        txtrdsoCode.Text = "";
        ViewState["Code"] = "";
        //gv1.EditIndex = -1;
    }
    protected void gv1_OnPageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gv1.PageIndex = e.NewPageIndex;
        Fill_RdsoCode(ViewState["Code"].ToString());
    }
    protected void OnClick_btnSave(object sender, EventArgs e)
    {
        if (btnSave.Text == "Insert")
        {
            Insertion();
        }
        else if (btnSave.Text == "Update")
        {
            Updation();
        }

    }
}
