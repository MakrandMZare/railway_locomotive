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
public partial class Master_Assembly_NonStock : System.Web.UI.Page
{
    public void Fill_Assembly()
    {
        Cls_Assembly_NonStock_Master c = new Cls_Assembly_NonStock_Master();
        ddlAssembly.DataSource = c.Select_Data();
        ddlAssembly.DataTextField = "NameOfAssembly";
        ddlAssembly.DataValueField = "Id_NonStock";
        ddlAssembly.DataBind();
        ddlAssembly.Items.Insert(0, "SELECT");
    }
    public void Insertion()
    {
        Cls_Assembly_NonStock c = new Cls_Assembly_NonStock();
        c.Description = txtDescription.Text;
        c.Grno = txtGrno.Text;
        c.Dlw1 = txtDlw1.Text;
        c.Dlw2 = txtDlw2.Text;
        c.DLWPrno = txtDlwplno.Text;
        c.DrgNo = txtDrgno.Text;
        c.EMDPrno = txtEmdPtno.Text;
        c.Id_Assembly = ddlAssembly.SelectedValue.ToString();
        c.Pac = txtPac.Text;
        c.Rdso1 = txtRdso1.Text;
        c.Rdso2 = txtRdso2.Text;
        c.Sch_Qpl_Aac = txtSchQpl.Text;
        c.Upr = txtLpr.Text;
        c.Insert_Data();
    }
    public void Updation()
    {
        Cls_Assembly_NonStock c = new Cls_Assembly_NonStock();
        c.Id_NonStock = Request.QueryString["id"].ToString();
        c.Grno = txtGrno.Text;
        c.Description = txtDescription.Text;
        c.Dlw1 = txtDlw1.Text;
        c.Dlw2 = txtDlw2.Text;
        c.DLWPrno = txtDlwplno.Text;
        c.DrgNo = txtDrgno.Text;
        c.EMDPrno = txtEmdPtno.Text;
        c.Id_Assembly = ddlAssembly.SelectedValue.ToString();
        c.Pac = txtPac.Text;
        c.Rdso1 = txtRdso1.Text;
        c.Rdso2 = txtRdso2.Text;
        c.Sch_Qpl_Aac = txtSchQpl.Text;
        c.Upr = txtLpr.Text;
        c.Update_Data();
    }
    public void Fill_Data()
    {

        if ((string)Request.QueryString["Id"] != "" && (string)Request.QueryString["Id"] != null)
        {
            Cls_Assembly_NonStock c = new Cls_Assembly_NonStock();
            c.Id_NonStock = Request.QueryString["Id"].ToString();
            DataTable dt = c.Select_DataById();
            if (dt.Rows.Count != 0)
            {
                ddlAssembly.SelectedIndex = ddlAssembly.Items.IndexOf(ddlAssembly.Items.FindByValue(dt.Rows[0][0].ToString()));
                txtGrno.Text = dt.Rows[0][2].ToString();
                txtDescription.Text = dt.Rows[0][3].ToString();
                txtEmdPtno.Text = dt.Rows[0][4].ToString();
                txtDlwplno.Text = dt.Rows[0][5].ToString();
                txtDrgno.Text = dt.Rows[0][6].ToString();
                txtSchQpl.Text = dt.Rows[0][7].ToString();
                txtPac.Text = dt.Rows[0][8].ToString();
                txtRdso1.Text = dt.Rows[0][9].ToString();
                txtRdso2.Text = dt.Rows[0][10].ToString();
                txtDlw1.Text = dt.Rows[0][11].ToString();
                txtDlw2.Text = dt.Rows[0][12].ToString();
                txtLpr.Text = dt.Rows[0][13].ToString();
                btnSave.Text = "Update";
            }
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Fill_Assembly();
            if ((string)Request.QueryString["Id"] != "")
            { Fill_Data(); }

        }
    }
    protected void btnSave_OnClick(object sender, EventArgs e)
    {
        if (btnSave.Text == "Insert")
        {
            Insertion();
        }
        else if (btnSave.Text == "Update") { Updation(); }
    }

}
