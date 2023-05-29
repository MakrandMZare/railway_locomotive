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
using System.Data.SqlClient;
using Railway;



public partial class ElectronicChekSheet_ScheduleCard : System.Web.UI.Page
{
    Cls_ScheduleCard c = new Cls_ScheduleCard();
    public void Fill_ScheduleCad()
    {
        ddlsection.DataSource = c.Select_section();
        ddlsection.DataTextField = "f_name";
        ddlsection.DataValueField = "id_section";
        ddlsection.DataBind();
        ddlsection.Items.Insert(0,"SELECT");


    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Fill_ScheduleCad();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        c.id_section= ddlsection.SelectedValue.ToString();
        c.name_sub_section = txtsubSection.Text;
        c.Insert_SectionCard();
        ddlsection.SelectedIndex = 0;
        txtsubSection.Text = "";
    }
}
