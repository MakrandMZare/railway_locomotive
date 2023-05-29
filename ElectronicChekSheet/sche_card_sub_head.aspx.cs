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

public partial class ElectronicChekSheet_sche_card_sub_head : System.Web.UI.Page
{
    Cls_sub_head c = new Cls_sub_head();
    public void Fill_Schedule()
    {
        ddlSchedule.DataSource = c.Select_Schedule();
        ddlSchedule.DataTextField = "s_type";
        ddlSchedule.DataValueField = "id_loco_sch";
        ddlSchedule.DataBind();
        ddlSchedule.Items.Insert(0, "SELECT");
    }
    public void Fill_SubSection()
    {
        ddlSubSection.DataSource = c.Select_Schedule_Card();
        ddlSubSection.DataTextField = "name_sub_section";
        ddlSubSection.DataValueField = "id_sch_card";
        ddlSubSection.DataBind();
        ddlSubSection.Items.Insert(0, "SELECT");
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Fill_Schedule();
            Fill_SubSection();
        }
    }
    protected void txtSubHead_TextChanged(object sender, EventArgs e)
    {
        c.id_sch_card = ddlSubSection.SelectedValue.ToString();
        c.id_loco_sch = ddlSchedule.SelectedValue.ToString();
        c.sub_head = txtSubHead.Text;
        c.Insert_data();
        ddlSubSection.SelectedIndex = 0;
        ddlSchedule.SelectedIndex = 0;
        txtSubHead.Text = "";


    }
}
