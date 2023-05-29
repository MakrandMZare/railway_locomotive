using System;
using System.Collections;
using System.Configuration;
using System.Data;
//using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
//using System.Xml.Linq;
using Railway;
public partial class HR_View_EmployeeDetails : System.Web.UI.Page
{
    public void Fill_EmployeeData()
    {
        Cls_jos_railway_Hr c = new Cls_jos_railway_Hr();
        if ((string)Request.QueryString["id"] != null)
        {
            c.Hrid = Request.QueryString["id"].ToString();
            empDataList.DataSource = c.Select_DataById();
            empDataList.DataBind();
        }

    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Fill_EmployeeData();
        }
    }


    protected void btnEdit_Click(object sender, EventArgs e)
    {
        
    }
}
