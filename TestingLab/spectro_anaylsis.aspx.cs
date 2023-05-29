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

public partial class TestingLab_spectro_anaylsis : System.Web.UI.Page
{
    public void Fill_Data()
    {
        if (ddlLocono.SelectedIndex != 0)
        {

            Cls_spectro_analysis c = new Cls_spectro_analysis();
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
        Cls_spectro_analysis c = new Cls_spectro_analysis();


        c.id_mst_loco = ddlLocono.SelectedValue.ToString();
        c.schedule = ddlSchedule.SelectedValue.ToString();
        c.date_of_collection = txtdateCollection.Text.Substring(3, 2) + "/" + txtdateCollection.Text.Substring(0, 2) + "/" + txtdateCollection.Text.Substring(6, 4);
        c.dateof = txtdateof.Text.Substring(3, 2) + "/" + txtdateof.Text.Substring(0, 2) + "/" + txtdateof.Text.Substring(6, 4);
        c.A1 = txta1.Text;
        c.B = txtb.Text;
        c.Cr = txtcr.Text;
        c.Cu = txtcu.Text;
        c.Fe = txtfe.Text;
        c.Na = txtna.Text;
        c.Pb = txtpb.Text;
        c.Si = txtsi.Text;
        c.Sn = txtsn.Text;
        c.remarks = txtResult_Remraks.Text;
        c.Insert_Data();
        Clear_Data();

    }
    public void Updation()
    {
        Cls_spectro_analysis c = new Cls_spectro_analysis();
        //c.Id_CompressorOil = Request.QueryString["Id"].ToString();
        c.spectro_id = ViewState["Id"].ToString();
        c.id_mst_loco = ddlLocono.SelectedValue.ToString();
        c.schedule = ddlSchedule.SelectedValue.ToString();
        c.date_of_collection = txtdateCollection.Text.Substring(3, 2) + "/" + txtdateCollection.Text.Substring(0, 2) + "/" + txtdateCollection.Text.Substring(6, 4);
        c.dateof = txtdateof.Text.Substring(3, 2) + "/" + txtdateof.Text.Substring(0, 2) + "/" + txtdateof.Text.Substring(6, 4);
        c.A1 = txta1.Text;
        c.B = txtb.Text;
        c.Cr = txtcr.Text;
        c.Cu = txtcu.Text;
        c.Fe = txtfe.Text;
        c.Na = txtna.Text;
        c.Pb = txtpb.Text;
        c.Si = txtsi.Text;
        c.Sn = txtsn.Text;
        c.remarks = txtResult_Remraks.Text;
        c.Update_Data();
        btnSave.Text = "Insert";
        Clear_Data();

    }
    public void Clear_Data()
    {
        //ddlClass.SelectedIndex = 0;
        //ddlLocono.SelectedIndex = 0;
        //ddlSchedule.SelectedIndex = 0;
        txtdateCollection.Text = "";
        txtdateof.Text = "";
        txta1.Text = "";
        txtb.Text = "";
        txtcr.Text = "";
        txtcu.Text = "";
        txtfe.Text = "";
        txtna.Text = "";
        txtpb.Text = "";
        txtsi.Text = "";
        txtsn.Text = "";
        txtResult_Remraks.Text = "";
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
        txtdateCollection.Text = gv1.Rows[e.NewEditIndex].Cells[2].Text;
        txtdateof.Text = gv1.Rows[e.NewEditIndex].Cells[3].Text;
        ddlSchedule.SelectedIndex = ddlSchedule.Items.IndexOf(ddlSchedule.Items.FindByText(gv1.Rows[e.NewEditIndex].Cells[4].Text));

        txta1.Text = gv1.Rows[e.NewEditIndex].Cells[5].Text;
        txtb.Text = gv1.Rows[e.NewEditIndex].Cells[6].Text;
        txtcr.Text = gv1.Rows[e.NewEditIndex].Cells[7].Text;
        txtcu.Text = gv1.Rows[e.NewEditIndex].Cells[8].Text;
        txtfe.Text = gv1.Rows[e.NewEditIndex].Cells[9].Text;


        txtna.Text = gv1.Rows[e.NewEditIndex].Cells[10].Text;
        txtpb.Text = gv1.Rows[e.NewEditIndex].Cells[11].Text;
        txtsi.Text = gv1.Rows[e.NewEditIndex].Cells[12].Text;
        txtsn.Text = gv1.Rows[e.NewEditIndex].Cells[13].Text;
        txtResult_Remraks.Text = gv1.Rows[e.NewEditIndex].Cells[14].Text;


        btnSave.Text = "Update";
    }
    protected void gv1_OnRowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Cls_spectro_analysis c = new Cls_spectro_analysis();
        c.spectro_id = gv1.DataKeys[e.RowIndex].Value.ToString();
        c.Delete_Data();
        Fill_Data();

    }

    protected void btnSave_OnClick(object sender, EventArgs e)
    {
        if (btnSave.Text == "Insert")
        {
            Insertion();
            Response.Redirect("~\\TestingLab\\spectro_anaylsis.aspx");
        }
        else if (btnSave.Text == "Update")
        {
            Updation();
            Response.Redirect("~\\TestingLab\\spectro_anaylsis.aspx");
        }
        Fill_Data();
    }
    protected void ddlClass_SelectedIndexChanged(object sender, EventArgs e)
    {
        Fill_LocoNo();
        Fill_Schedule();
    }
}
