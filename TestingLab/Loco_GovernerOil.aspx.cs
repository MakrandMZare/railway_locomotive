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
public partial class Loco_Loco_GovernerOil : System.Web.UI.Page
{

    public void Fill_Data()
    {
        if (ddlLocono.SelectedIndex != 0)
        {
            Cls_Loco_GovernerOil c = new Cls_Loco_GovernerOil();
            c.Id_Loco = ddlLocono.SelectedValue.ToString();
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
        Cls_Loco_GovernerOil c = new Cls_Loco_GovernerOil();

        c.FalshPoint = txtFlashPoint.Text;
        c.Id_Loco = ddlLocono.SelectedValue.ToString();
        c.Id_Schedule = ddlSchedule.SelectedValue.ToString();
        c.Loco_Date = txtDate.Text.Substring(3, 2) + "/" + txtDate.Text.Substring(0, 2) + "/" + txtDate.Text.Substring(6, 4);
        c.Result_Remarks = txtResult_Remraks.Text;
        c.Tested_By = txtTestedBy.Text;
        c.Viscosity = txtViscosity.Text;
        c.WaterContent = txtWaterContent.Text;
        c.Insert_Data();
        Clear_Data();

    }
    public void Updation()
    {
        Cls_Loco_GovernerOil c = new Cls_Loco_GovernerOil();
        //c.Id_CompressorOil = Request.QueryString["Id"].ToString();
        c.Id_GovernerOil = ViewState["Id"].ToString();
        c.FalshPoint = txtFlashPoint.Text;
        c.Id_Loco = ddlLocono.SelectedValue.ToString();
        c.Id_Schedule = ddlSchedule.SelectedValue.ToString();
        c.Loco_Date = txtDate.Text.Substring(3, 2) + "/" + txtDate.Text.Substring(0, 2) + "/" + txtDate.Text.Substring(6, 4);
        c.Result_Remarks = txtResult_Remraks.Text;
        c.Tested_By = txtTestedBy.Text;
        c.Viscosity = txtViscosity.Text;
        c.WaterContent = txtWaterContent.Text;
        c.Update_Data();
        btnSave.Text = "Insert";
        Clear_Data();

    }
    public void Clear_Data()
    {
        //ddlClass.SelectedIndex = 0;
        //ddlLocono.SelectedIndex = 0;
        //ddlSchedule.SelectedIndex = 0;
        txtDate.Text = "";
        txtFlashPoint.Text = "";
        txtResult_Remraks.Text = "";
        txtTestedBy.Text = "";
        txtViscosity.Text = "";
        txtWaterContent.Text = "";
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

        txtWaterContent.Text = gv1.Rows[e.NewEditIndex].Cells[4].Text;
        txtFlashPoint.Text = gv1.Rows[e.NewEditIndex].Cells[5].Text;
        txtViscosity.Text = gv1.Rows[e.NewEditIndex].Cells[6].Text;
        txtResult_Remraks.Text = gv1.Rows[e.NewEditIndex].Cells[7].Text;
        txtTestedBy.Text = gv1.Rows[e.NewEditIndex].Cells[8].Text;
        btnSave.Text = "Update";
    }
    protected void gv1_OnRowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Cls_Loco_GovernerOil c = new Cls_Loco_GovernerOil();
        c.Id_GovernerOil = gv1.DataKeys[e.RowIndex].Value.ToString();
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
