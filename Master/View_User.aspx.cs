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
using Railway;
public partial class Master_View_User : System.Web.UI.Page
{
    public void Fill_Department()
    {
        //Fill All Department In DropDownList
        Cls_jos_railway_section c = new Cls_jos_railway_section();
        ddlDepartment.DataSource = c.Select_Data();
        ddlDepartment.DataTextField = "s_type";
        ddlDepartment.DataValueField = "id_section";
        ddlDepartment.DataBind();
        ddlDepartment.Items.Insert(0, "SELECT");
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Fill_Department();
        }
    }
    public void Fill_Data()
    {
        Cls_Master_User c = new Cls_Master_User();
        c.Department = ddlDepartment.SelectedValue.ToString();
         gvUser.DataSource =  c.Select_Data_ByDepartment();
         gvUser.DataBind();
    }
    
    protected void btnSave_OnClick(object sender, EventArgs e)
    {
        Fill_Data();
    }
}
