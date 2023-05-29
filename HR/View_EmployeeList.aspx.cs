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
public partial class HR_View_EmployeeList : System.Web.UI.Page
{
    public void fill_Data()
    {
        Cls_jos_railway_Hr c = new Cls_jos_railway_Hr();
        gvEmployeeList.DataSource = c.Get_EmployeeList();
        gvEmployeeList.DataBind();
        if (gvEmployeeList.Rows.Count > 0)
        { lblerror.Visible = false; }
        else
        { lblerror.Visible = true; }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            fill_Data();
        }
    }
    protected void gvEmployeeList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
