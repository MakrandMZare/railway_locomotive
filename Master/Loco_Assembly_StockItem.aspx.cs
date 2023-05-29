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
public partial class Master_Loco_Assembly_StockItem : System.Web.UI.Page
{
    public void Fill_Assembly()
    {
        //Cls_jos_railway_mst_Assembly c = new Cls_jos_railway_mst_Assembly();
        //ddlAssembly.DataSource = c.Select_Data();
        //ddlAssembly.DataTextField = "name";
        //ddlAssembly.DataValueField = "id_mst_assem";
        //ddlAssembly.DataBind();
        //ddlAssembly.Items.Insert(0, "SELECt");
        Cls_Assembly_Stock_Master c = new Cls_Assembly_Stock_Master();
        ddlAssembly.DataSource = c.Select_Data();
        ddlAssembly.DataTextField = "NameOfAssembly";
        ddlAssembly.DataValueField = "Id_Stock";
        ddlAssembly.DataBind();
        ddlAssembly.Items.Insert(0, "SELECT");
    }
    public void Fill_Data()
    {
        Cls_Assembly_StockItem c = new Cls_Assembly_StockItem();
        c.Id_Stock = Request.QueryString["Id"].ToString();
        DataTable dt = c.SelectDataById();
        ddlAssembly.SelectedIndex = ddlAssembly.Items.IndexOf(ddlAssembly.Items.FindByValue(dt.Rows[0][0].ToString()));
        txtGr.Text = dt.Rows[0][2].ToString();
        txtDescription.Text = dt.Rows[0][3].ToString();
        txtEmdpt.Text = dt.Rows[0][4].ToString();
        txtDlwplno.Text = dt.Rows[0][5].ToString();
        txtDrgno.Text = dt.Rows[0][6].ToString();
        txtSch.Text = dt.Rows[0][7].ToString();
        txtPac.Text = dt.Rows[0][8].ToString();
        txtRdsoPart1.Text = dt.Rows[0][9].ToString();
        txtRdsoPart2.Text = dt.Rows[0][10].ToString();
        txtDwlPart1.Text = dt.Rows[0][11].ToString();
        txtDwlPart2.Text = dt.Rows[0][12].ToString();
        txtLpr.Text = dt.Rows[0][13].ToString();
        txtSwr.Text = dt.Rows[0][14].ToString();
    }
    public void Updation()
    {
        Cls_Assembly_StockItem c = new Cls_Assembly_StockItem();
        c.Id_Stock = Request.QueryString["Id"].ToString();
        c.Description = txtDescription.Text;
        c.Dlw1 = txtDwlPart1.Text;
        c.Dlw2 = txtDwlPart2.Text;
        c.DLWplno = txtDlwplno.Text;
        c.Drgno = txtDrgno.Text;
        c.EmdPrno = txtEmdpt.Text;
        c.Grno = txtGr.Text;
        c.Id_Assembly = ddlAssembly.SelectedValue.ToString();
        c.Lpr = txtLpr.Text;
        c.Pac = txtPac.Text;
        c.Rdso1 = txtRdsoPart1.Text;
        c.Rdso2 = txtRdsoPart2.Text;
        c.Sch_Qpl_Aac = txtSch.Text;
        c.Swrno = txtSwr.Text;
        c.Update_Data();
    }
    public void Insertion()
    {
        Cls_Assembly_StockItem c = new Cls_Assembly_StockItem();
        c.Description = txtDescription.Text;
        c.Dlw1 = txtDwlPart1.Text;
        c.Dlw2 = txtDwlPart2.Text;
        c.DLWplno = txtDlwplno.Text;
        c.Drgno = txtDrgno.Text;
        c.EmdPrno = txtEmdpt.Text;
        c.Grno = txtGr.Text;
        c.Id_Assembly = ddlAssembly.SelectedValue.ToString();
        c.Lpr = txtLpr.Text;
        c.Pac = txtPac.Text;
        c.Rdso1 = txtRdsoPart1.Text;
        c.Rdso2 = txtRdsoPart2.Text;
        c.Sch_Qpl_Aac = txtSch.Text;
        c.Swrno = txtSwr.Text;
        c.Insert_Data();

    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Fill_Assembly();
            if ((string)Request.QueryString["Id"] != "" && Request.QueryString["action"] == "update")
            {
                Fill_Data();
                btnSave.Text = "Update";
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
            Updation();
        }

    }
}
