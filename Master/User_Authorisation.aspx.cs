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

public partial class Master_User_Authorisation : System.Web.UI.Page
{
    public void Show_Authorization(string uid,string Modulename,string action,RadioButtonList r)
    {
      Cls_User_Authorisation c = new Cls_User_Authorisation();
        c.ModuleName = Modulename;
        c.ActionType = action;
        c.Id_User = uid;
        if (c.Check_Existance())
        {
            c.Id_UserAuthorisation = c.Get_Id().ToString();
            if (c.Get_Permission())
            {
                r.SelectedIndex = 0;
            }
            else
            {
                r.SelectedIndex = 1;
            }

        }
        
    }
    public void Save_Permission(string uid,string module,string action,string permission)
    {
        Cls_User_Authorisation c = new Cls_User_Authorisation();
        c.Id_User = uid;
        c.ModuleName = module;
        c.ActionType = action;
        if (permission == "No")
        {
            c.PermissionType = "0";
        }
        else if (permission == "Yes")
        {
            c.PermissionType = "1";
        }
        
        if (!c.Check_Existance())
        {
            c.Insert_Data();
        }
        else
        {
            c.Id_UserAuthorisation = c.Get_Id().ToString();
            c.Update_Data();
        }
        
    }
    protected void btnSave_OnClick(object sender, EventArgs e)
    {
        //Data Entry

        Save_Permission(Request.QueryString["id"].ToString(), "LOCO IN", "DATA ENTRY", r1.SelectedValue);
        Save_Permission(Request.QueryString["id"].ToString(), "LOCO OUT", "DATA ENTRY", r2.SelectedValue);
        Save_Permission(Request.QueryString["id"].ToString(), "LINE MESSAGE", "DATA ENTRY", r3.SelectedValue);
        Save_Permission(Request.QueryString["id"].ToString(), "DEAD ON LINE", "DATA ENTRY", r4.SelectedValue);
        Save_Permission(Request.QueryString["id"].ToString(), "LOCO MOVEMENT", "DATA ENTRY", r5.SelectedValue);
        Save_Permission(Request.QueryString["id"].ToString(), "EMPLOYEE", "DATA ENTRY", r6.SelectedValue);
        Save_Permission(Request.QueryString["id"].ToString(), "INCOMING PASSANGER LOCO ", "DATA ENTRY", r7.SelectedValue);
        Save_Permission(Request.QueryString["id"].ToString(), "OUT AGE", "DATA ENTRY", r8.SelectedValue);

        //Report
        Save_Permission(Request.QueryString["id"].ToString(), "LOCO IN", "REPORT", r9.SelectedValue);
        Save_Permission(Request.QueryString["id"].ToString(), "LOCO OUT", "REPORT", r10.SelectedValue);
        Save_Permission(Request.QueryString["id"].ToString(), "LINE MESSAGE", "REPORT", r11.SelectedValue);
        Save_Permission(Request.QueryString["id"].ToString(), "DEAD ON LINE", "REPORT", r12.SelectedValue);
        Save_Permission(Request.QueryString["id"].ToString(), "LOCO MOVEMENT", "REPORT", r13.SelectedValue);
        Save_Permission(Request.QueryString["id"].ToString(), "EMPLOYEE", "REPORT", r14.SelectedValue);
        //Show_Authorization(Request.QueryString["id"].ToString(), "INCOMING PASSANGER LOCO ", "REPORT");
        //Show_Authorization(Request.QueryString["id"].ToString(), "OUT AGE", "REPORT");
    }
    public void Fill_Permission()
    {
        //Data Entry
        Show_Authorization(Request.QueryString["id"].ToString(), "LOCO IN", "DATA ENTRY", r1);
        Show_Authorization(Request.QueryString["id"].ToString(), "LOCO OUT", "DATA ENTRY", r2);
        Show_Authorization(Request.QueryString["id"].ToString(), "LINE MESSAGE", "DATA ENTRY", r3);
        Show_Authorization(Request.QueryString["id"].ToString(), "DEAD ON LINE", "DATA ENTRY", r4);
        Show_Authorization(Request.QueryString["id"].ToString(), "LOCO MOVEMENT", "DATA ENTRY", r5);
        Show_Authorization(Request.QueryString["id"].ToString(), "EMPLOYEE", "DATA ENTRY", r6);
        Show_Authorization(Request.QueryString["id"].ToString(), "INCOMING PASSANGER LOCO ", "DATA ENTRY", r7);
        Show_Authorization(Request.QueryString["id"].ToString(), "OUT AGE", "DATA ENTRY", r8);

        //Report
        Show_Authorization(Request.QueryString["id"].ToString(), "LOCO IN", "REPORT", r9);
        Show_Authorization(Request.QueryString["id"].ToString(), "LOCO OUT", "REPORT", r10);
        Show_Authorization(Request.QueryString["id"].ToString(), "LINE MESSAGE", "REPORT", r11);
        Show_Authorization(Request.QueryString["id"].ToString(), "DEAD ON LINE", "REPORT", r12);
        Show_Authorization(Request.QueryString["id"].ToString(), "LOCO MOVEMENT", "REPORT", r13);
        Show_Authorization(Request.QueryString["id"].ToString(), "EMPLOYEE", "REPORT", r14);
        //Show_Authorization(Request.QueryString["id"].ToString(), "INCOMING PASSANGER LOCO ", "REPORT");
        //Show_Authorization(Request.QueryString["id"].ToString(), "OUT AGE", "REPORT");
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Fill_Permission();
        }
    }
}
