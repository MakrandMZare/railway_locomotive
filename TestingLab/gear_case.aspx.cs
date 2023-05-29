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

public partial class TestingLab_gear_case : System.Web.UI.Page
{

    public void Fill_Data()
    {
        if (ddlLocono.SelectedIndex != 0)
        {

            gear_case_oil c = new gear_case_oil();
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
        gear_case_oil c = new gear_case_oil();

    //   public string gear_case_id;
    //public string id_mst_loco;
    //public string g_date;
    //public string sch;
    //public string lg1;
    //public string lg2;
    //public string lg3;
    //public string rg4;
    //public string rg5;
    //public string rg6;
    //public string remarks;
    //public string testedby;


        c.id_mst_loco = ddlLocono.SelectedValue.ToString();
        c.sch = ddlSchedule.SelectedValue.ToString();
        c.g_date = txtDate.Text.Substring(3, 2) + "/" + txtDate.Text.Substring(0, 2) + "/" + txtDate.Text.Substring(6, 4);
        c.lg1 = txtlg1.Text;
        c.lg2 = txtlg2.Text;
        c.lg3 = txtlg3.Text;
        c.rg4= txtrg4.Text;

        c.rg5 = txtrg5.Text;
        c.rg6 = txtrg6.Text;
        c.remarks = txtremark.Text;
        c.testedby = txttested.Text;
        c.Insert_Data();
        Clear_Data();

    }
    public void Updation()
    {
        gear_case_oil c = new gear_case_oil();
        //c.Id_CompressorOil = Request.QueryString["Id"].ToString();
        c.gear_case_id = ViewState["Id"].ToString();
        c.id_mst_loco = ddlLocono.SelectedValue.ToString();
        c.sch = ddlSchedule.SelectedValue.ToString();
        c.g_date = txtDate.Text.Substring(3, 2) + "/" + txtDate.Text.Substring(0, 2) + "/" + txtDate.Text.Substring(6, 4);
        c.lg1 = txtlg1.Text;
        c.lg2 = txtlg2.Text;
        c.lg3 = txtlg3.Text;
        c.rg4 = txtrg4.Text;

        c.rg5 = txtrg5.Text;
        c.rg6 = txtrg6.Text;
        c.remarks = txtremark.Text;
        c.testedby = txttested.Text;
        c.Update_Data();
        btnSave.Text = "Insert";
        Clear_Data();

    }
    public void Clear_Data()
    {
        //ddlClass.SelectedIndex = 0;
        //ddlLocono.SelectedIndex = 0;
        //ddlSchedule.SelectedIndex = 0;
        txtlg1.Text="";
        txtlg2.Text="";
        txtlg3.Text="";
        txtrg4.Text="";
       txtDate.Text="";
        txtrg5.Text="";
        txtrg6.Text="";
        txtremark.Text="";
        txttested.Text="";
    }
    protected void btnCancel_OnClick(object sender, EventArgs e)
    {
        ddlClass.SelectedIndex = 0;
        ddlLocono.SelectedIndex = 0;
        ddlSchedule.SelectedIndex = 0;
        Clear_Data();
    }
    public void Fill_Class()
    {
        Cls_jos_railway_loco_in obj = new Cls_jos_railway_loco_in();
        ddlClass.DataSource = obj.SelectLocoType();
        ddlClass.DataTextField = "loco_type";
        ddlClass.DataValueField = "id_ltype";
        ddlClass.DataBind();
        ddlClass.Items.Insert(0, "SELECT");
    }
    public void Fill_LocoNo()
    {
        if (ddlClass.SelectedIndex != 0)
        {
            Cls_jos_railway_loco_in obj = new Cls_jos_railway_loco_in();
            ddlLocono.DataSource = obj.Select_LocoNo(ddlClass.SelectedValue.ToString());
            ddlLocono.DataTextField = "locono";
            ddlLocono.DataValueField = "id_mst_loco";
            ddlLocono.DataBind();
            ddlLocono.Items.Insert(0, "SELECT");
        }
    }
    public void Fill_Schedule()
    {
        ddlSchedule.Items.Clear();
        Cls_jos_railway_loco_type_schedule c = new Cls_jos_railway_loco_type_schedule();
        c.loco_id = ddlClass.SelectedValue.ToString();
        ddlSchedule.DataSource = c.Select_Data();
        ddlSchedule.DataTextField = "Schedule_Type";
        // ddlSchedule.DataValueField = "id_mst_loco_sch";       id_loco_sch
        ddlSchedule.DataValueField = "id_loco_sch";  
        ddlSchedule.DataBind();
        ddlSchedule.Items.Insert(0, "SELECT");
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Fill_Class();
            ddlClass.SelectedIndex = 0;
            ddlLocono.SelectedIndex = 0;
            ddlSchedule.SelectedIndex = 0;
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
                ddlClass.SelectedIndex = ddlClass.Items.IndexOf(ddlClass.Items.FindByValue(dt.Rows[0][0].ToString()));
            }
        }
        txtDate.Text = gv1.Rows[e.NewEditIndex].Cells[2].Text;
        ddlSchedule.SelectedIndex = ddlSchedule.Items.IndexOf(ddlSchedule.Items.FindByText(gv1.Rows[e.NewEditIndex].Cells[3].Text));

        txtlg1.Text = gv1.Rows[e.NewEditIndex].Cells[4].Text;
        txtlg2.Text = gv1.Rows[e.NewEditIndex].Cells[5].Text;
        txtlg3.Text = gv1.Rows[e.NewEditIndex].Cells[6].Text;
        txtrg4.Text = gv1.Rows[e.NewEditIndex].Cells[7].Text;
        txtrg5.Text = gv1.Rows[e.NewEditIndex].Cells[8].Text;
        txtrg6.Text = gv1.Rows[e.NewEditIndex].Cells[9].Text;
        txtremark.Text = gv1.Rows[e.NewEditIndex].Cells[10].Text;
        txttested.Text = gv1.Rows[e.NewEditIndex].Cells[11].Text;
        btnSave.Text = "Update";
    }
    protected void gv1_OnRowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        gear_case_oil c = new gear_case_oil();
        c.gear_case_id = gv1.DataKeys[e.RowIndex].Value.ToString();
        c.Delete_Data();
        Fill_Data();

    }

    protected void btnSave_OnClick(object sender, EventArgs e)
    {
        if (btnSave.Text == "Insert")
        {
            Insertion();
        }
        else if (btnSave.Text == "Update")
        {
            Updation();
        }
        Fill_Data();
    }
    protected void ddlClass_SelectedIndexChanged(object sender, EventArgs e)
    {
        Fill_LocoNo();
        Fill_Schedule();
    }
}
