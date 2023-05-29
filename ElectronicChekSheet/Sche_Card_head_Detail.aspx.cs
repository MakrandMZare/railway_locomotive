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
public partial class ElectronicChekSheet_Sche_Card_head_Detail : System.Web.UI.Page
{
    Cls_card_head_details c = new Cls_card_head_details();
    public void Fill_ScheduleCad()
    {
        ddlCardDetail.DataSource = c.select_sch_card_sub_head();
        ddlCardDetail.DataTextField = "sub_head";
        ddlCardDetail.DataValueField = "id_sc_para";
        ddlCardDetail.DataBind();
        ddlCardDetail.Items.Insert(0, "SELECT");
}

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Fill_ScheduleCad();
        }
    }
    protected void btnInsert_Click(object sender, EventArgs e)
    {
        c.id_sc_para = ddlCardDetail.SelectedValue.ToString();
        c.sub_head_details = txtDetail.Text;
        c.Insert_Data();
        ddlCardDetail.SelectedIndex = 0;
        txtDetail.Text = "";
    }
}
