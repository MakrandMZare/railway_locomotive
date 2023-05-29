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
using System.Data.SqlClient;
using Railway;
public partial class Master_LocoType : System.Web.UI.Page
{
    public void Fill_Data()
    {
        Cls_Master_Loco_Type c = new Cls_Master_Loco_Type();
        //c.guage = ddlType.SelectedItem.ToString();
        gv1.DataSource = c.Select_Data(ddlType.SelectedItem.ToString());
        gv1.DataBind();
    }
    public void Fill_DataById()
    {
        Cls_Master_Loco_Type c = new Cls_Master_Loco_Type();
        c.id_ltype = Request.QueryString["id"].ToString();
        DataTable dt = c.Select_DataById();
        if (dt.Rows.Count > 0)
        {
            ddlType.SelectedIndex = ddlType.Items.IndexOf(ddlType.Items.FindByText(dt.Rows[0][2].ToString()));
            if (txtlocotype.Text != dt.Rows[0][1].ToString())
            { txtlocotype.Text = dt.Rows[0][1].ToString(); }
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        lblerro.Visible = false;
        if (Page.IsPostBack)
        {
            if ((string)Request.QueryString["id"] != null && (string)Request.QueryString["action"] == "update")
            {
                Fill_DataById();
                btnadd.Text = "Update";
            }
            if ((string)Request.QueryString["id"] != null && (string)Request.QueryString["action"] == "delete")
            {
                Cls_Master_Loco_Type c = new Cls_Master_Loco_Type();
                c.id_ltype = Request.QueryString["id"].ToString();
                c.Delete_Data();
                Fill_Data();
            }
        }
    }
    protected void btnadd_Click(object sender, EventArgs e)
    {
        Cls_Master_Loco_Type c = new Cls_Master_Loco_Type();
        if (btnadd.Text == "Add")
        {
            c.loco_type = txtlocotype.Text;
            c.guage = ddlType.SelectedItem.ToString();
            if (!c.IsDataExists())
            {
                lblerro.Visible = false;
                c.Insert_Data();
            }
            else
            {
                lblerro.Visible = true;
            }
        }
        else if (btnadd.Text == "Update")
        {
            c.id_ltype = Request.QueryString["id"].ToString();
            c.guage = ddlType.SelectedItem.ToString();
            c.loco_type = txtlocotype.Text;
            c.Update_Data();
        }
        Fill_Data();
    }
    protected void ddlType_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        Fill_Data();
    }
}
