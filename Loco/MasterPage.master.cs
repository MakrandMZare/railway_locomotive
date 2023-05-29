using System;
using System.Collections;
using System.Configuration;
using System.Data;
//using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
//using System.Xml.Linq;

public partial class Loco_MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //string str = Session["Username"].ToString();
        
        string str = (string)Session["Username"];
        if (Session["Username"] != null)
        {
            MenuPanel.Visible = true;
            string str1 = Session["UserType"].ToString();
            if ((string)Session["UserType"] != "Admin")
            {
             foreach(MenuItem mi in Menu1.Items)
             {
                 mi.Enabled = false;
             }
            }
        }
        else
        {
            MenuPanel.Visible = false;
            //Response.Redirect("~/Default.aspx");
        }
    }
    protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/LocoShedPosition/ViewShedPositionReport.aspx");
    }
}
