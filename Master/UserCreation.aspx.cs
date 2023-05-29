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
public partial class Master_UserCreation : System.Web.UI.Page
{
    public void CheckUserAvaibility(string uname)
    {
        Cls_Master_User c = new Cls_Master_User();
        c.Username = uname;
        
    }
    public void Insertion()
    {
        //this functino creat new user
        Cls_Master_User c = new Cls_Master_User();
        c.Username = txtUsername.Text;
        c.Password = txtPassword.Text;
        c.Department = ddlDepartment.SelectedValue.ToString();
        if (!c.Check_Existance())
        {
            c.Insert_Data();
            errormsg.Visible = false;
        }
        else
        {
            errormsg.Visible = true;
        }
        
    }
    public void Updation()
    {
        //this function update user information
        Cls_Master_User c = new Cls_Master_User();
        c.Username = txtUsername.Text;
        c.Password = txtPassword.Text;
        c.Department = ddlDepartment.SelectedValue.ToString();
        if (Request.QueryString["id"] != null)
        {
            c.Id_User = Request.QueryString["id"].ToString();
            if (!c.Check_Existance())
            {
                c.Update_Data();
                errormsg.Visible = false;
            }
            else
            {
                errormsg.Visible = true;
            }
            
        }
    }
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
    public void Fill_Data()
    {
        Cls_Master_User c = new Cls_Master_User();
        c.Id_User = Request.QueryString["id"].ToString();
        DataTable dt = c.Select_DataById();
        ddlDepartment.SelectedIndex = ddlDepartment.Items.IndexOf(ddlDepartment.Items.FindByValue(dt.Rows[0][3].ToString()));
        txtUsername.Text = dt.Rows[0][1].ToString();
        //txtPassword.Text = dt.Rows[0][2].ToString();
        
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Fill_Department();
            if (Request.QueryString["id"] != null && Request.QueryString["action"] == "update")
            {
                Fill_Data();
                btnSave.Text = "UPDATE";
            }
        }
    }
    protected void btnSave_OnClick(object sender, EventArgs e)
    {
        if (btnSave.Text == "INSERT")
        {
            
            
            
            Insertion();
        }
        else if (btnSave.Text == "UPDATE")
        {
            Updation();
        }

    }
}
