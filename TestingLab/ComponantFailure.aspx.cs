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
using Railway;
using System.Data.SqlClient;


public partial class TestingLab_ComponantFailure : System.Web.UI.Page
{
    //  Cls_jos_railway_loco_in obj = new Cls_jos_railway_loco_in();

    public void Fill_Data()
    {
        if (ddlLocono.SelectedIndex != 0)
        {
            Cls_failure_component c = new Cls_failure_component();
            c.id_mst_loco = ddlLocono.SelectedValue.ToString();
            gv1.DataSource = c.Select_DataByLoco_n_Date();
            gv1.DataBind();
        }
    }
    public void ddlLocono_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlLocono.SelectedIndex != 0)
        {
            Fill_Data();
        }
    }
    public void Insertion()
    {
        Cls_failure_component c = new Cls_failure_component();

        c.comp_name = txtCompName.Text;
        c.id_mst_loco = ddlLocono.SelectedValue.ToString();

        c.l_date = txtdate.Text.Substring(3, 2) + "/" + txtdate.Text.Substring(0, 2) + "/" + txtdate.Text.Substring(6, 4);
        c.test_type = txtTypeTest.Text;
        c.suitable = txtSuitable.Text;
        c.rejected = txtRejected.Text;
        c.remarks = txtRemarks.Text;
        c.testedby = txtTested.Text;

        c.Insert_Data();
        Clear_Data();

    }
    public void Updation()
    {
        Cls_failure_component c = new Cls_failure_component();
        //c.comp_id = Request.QueryString["Id"].ToString();
        c.comp_id = ViewState["Id"].ToString();
        c.comp_name = txtCompName.Text;
        c.id_mst_loco = ddlLocono.SelectedValue.ToString();

        c.l_date = txtdate.Text.Substring(3, 2) + "/" + txtdate.Text.Substring(0, 2) + "/" + txtdate.Text.Substring(6, 4);
        c.test_type = txtTypeTest.Text;
        c.suitable = txtSuitable.Text;
        c.rejected = txtRejected.Text;
        c.remarks = txtRemarks.Text;
        c.testedby = txtTested.Text;

        c.Update_Data();
        btnadd.Text = "Insert";
        Clear_Data();

    }
    public void Clear_Data()
    {
        //ddlclass.SelectedIndex = 0;
        //ddlLocono.SelectedIndex = 0;
        //ddlSchedule.SelectedIndex = 0;
        txtCompName.Text = "";
        txtdate.Text = "";
        txtTypeTest.Text = "";
        txtSuitable.Text = "";
        txtRejected.Text = "";
        txtRemarks.Text = "";
        txtTested.Text = "";
    }
    protected void btnCancel_OnClick(object sender, EventArgs e)
    {
        ddlclass.SelectedIndex = 0;
        ddlLocono.SelectedIndex = 0;

        Clear_Data();
    }
    public void Fill_Class()
    {
        Cls_jos_railway_loco_in obj = new Cls_jos_railway_loco_in();
        ddlclass.DataSource = obj.SelectLocoType();
        ddlclass.DataTextField = "loco_type";
        ddlclass.DataValueField = "id_ltype";
        ddlclass.DataBind();
        ddlclass.Items.Insert(0, "SELECT");
    }
    public void Fill_LocoNo()
    {
        if (ddlclass.SelectedIndex != 0)
        {
            Cls_jos_railway_loco_in obj = new Cls_jos_railway_loco_in();
            ddlLocono.DataSource = obj.Select_LocoNo(ddlclass.SelectedValue.ToString());
            ddlLocono.DataTextField = "locono";
            ddlLocono.DataValueField = "id_mst_loco";
            ddlLocono.DataBind();
            ddlLocono.Items.Insert(0, "SELECT");
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Fill_Class();
            ddlclass.SelectedIndex = 0;
            ddlLocono.SelectedIndex = 0;

        }
    }
    protected void gv1_OnRowEditing(object sender, GridViewEditEventArgs e)
    {
        ViewState["Id"] = gv1.DataKeys[e.NewEditIndex].Value.ToString();
        string n = gv1.Rows[e.NewEditIndex].Cells[1].Text;
        ddlLocono.SelectedIndex = ddlLocono.Items.IndexOf(ddlLocono.Items.FindByText(gv1.Rows[e.NewEditIndex].Cells[1].Text));
        //ddlLocono.SelectedIndex = ddlLocono.Items.IndexOf(ddlLocono.Items.FindByValue(gv1.DataKeys[e.NewEditIndex].Values[1].ToString()));
        if (ddlLocono.SelectedIndex != 0)
        {
            Cls_Master_Loco_Type c = new Cls_Master_Loco_Type();

            DataTable dt = c.Get_LocoTypeByLocoId(ddlLocono.Text);
            if (dt.Rows.Count == 1)
            {
                ddlclass.SelectedIndex = ddlclass.Items.IndexOf(ddlclass.Items.FindByValue(dt.Rows[0][0].ToString()));
            }
        }
        txtdate.Text = gv1.Rows[e.NewEditIndex].Cells[2].Text;


        txtCompName.Text = gv1.Rows[e.NewEditIndex].Cells[3].Text;
        txtTypeTest.Text = gv1.Rows[e.NewEditIndex].Cells[4].Text;
        txtSuitable.Text = gv1.Rows[e.NewEditIndex].Cells[5].Text;
        txtRejected.Text = gv1.Rows[e.NewEditIndex].Cells[6].Text;
        txtRemarks.Text = gv1.Rows[e.NewEditIndex].Cells[7].Text;
        txtTested.Text = gv1.Rows[e.NewEditIndex].Cells[8].Text;

        btnadd.Text = "Update";
    }
    protected void gv1_OnRowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Cls_failure_component c = new Cls_failure_component();
        c.comp_id = gv1.DataKeys[e.RowIndex].Value.ToString();
        c.Delete_Data();
        Fill_Data();
       // Response.Redirect("~\\TestingLab\\ComponantFailure.aspx");

    }

    protected void btnSave_OnClick(object sender, EventArgs e)
    {
        //if (btnSave.Text == "Insert")
        //{
        //    Insertion();
        //}
        //else if (btnSave.Text == "Update")
        //{
        //    Updation();
        //}
        //Fill_Data();
    }
    protected void ddlclass_SelectedIndexChanged(object sender, EventArgs e)
    {
        Fill_LocoNo();

    }
    protected void btnadd_Click(object sender, EventArgs e)
    {
        if (btnadd.Text == "Insert")
        {
            Insertion();
        }
        else if (btnadd.Text == "Update")
        {
            Updation();
        }
        Fill_Data();
    }
    protected void ddlClass_SelectedIndexChanged(object sender, EventArgs e)
    {
        Fill_LocoNo();
    }
    protected void gv1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
