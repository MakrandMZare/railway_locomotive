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

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ////if ((string)Session["Username"] == "admin")
        ////{ p1.Visible = false; }
        ////else
        ////{ p1.Visible = true; }
       


    }
    protected void btnlogin_OnClick(object sender, EventArgs e)
    {
        //Panel p = (Panel)this.Master.FindControl("MenuPanel");
        //if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
        //{
        //    Session["Username"] = "admin";



        //}
        //else
        //{
        //    Session["Username"] = "";

        //}
        Cls_Master_User c = new Cls_Master_User();
        c.Username = txtUsername.Text;
        c.Password = txtPassword.Text;
        if (c.Check_Login())
        {
            //p1.Visible = false;
            Session["Username"] = txtUsername.Text;
            Session["UserType"] = c.Get_UserTypeById();
            lblerror.Visible = false;
            Response.Redirect("~/Wellcome.aspx");
            
        }
        else
        {
            //p1.Visible = true;
            lblerror.Visible = true;
        }

        
    }


}
