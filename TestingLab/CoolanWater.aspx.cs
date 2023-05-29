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

public partial class TestingLab_CoolanWater : System.Web.UI.Page
{


    public void Fill_Data()
    {
        if (ddlLocono.SelectedIndex != 0)
        {

            Cls_Coolant_Water c = new Cls_Coolant_Water();
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
        Cls_Coolant_Water c = new Cls_Coolant_Water();


        c.id_mst_loco = ddlLocono.SelectedValue.ToString();

        c.c_date = txtDate.Text.Substring(3, 2) + "/" + txtDate.Text.Substring(0, 2) + "/" + txtDate.Text.Substring(6, 4);
        c.after_water_chage = txtwater.Text;
        c.ph = txtph.Text;
        c.hardness = txthardness.Text;
        c.chloride = txtchloride.Text;
        c.nitrate = txtnitrate.Text;
        c.remarks = TXTREMARK.Text;
        c.testedby = TXTTESTEDBY.Text;

        //     public string coolantwater_id;
        //public string id_mst_loco;
        //public string c_date;
        //public string after_water_chage;
        //public string ph;
        //public string hardness;
        //public string chloride;
        //public string nitrate;
        //public string remarks;
        //public string testedby;


        c.Insert_Data();
        Clear_Data();

    }
    public void Updation()
    {
        Cls_Coolant_Water c = new Cls_Coolant_Water();
        //c.Id_CompressorOil = Request.QueryString["Id"].ToString();
        c.coolantwater_id = ViewState["Id"].ToString();
        c.id_mst_loco = ddlLocono.SelectedValue.ToString();

        c.c_date = txtDate.Text.Substring(3, 2) + "/" + txtDate.Text.Substring(0, 2) + "/" + txtDate.Text.Substring(6, 4);
        c.after_water_chage = txtwater.Text;
        c.ph = txtph.Text;
        c.hardness = txthardness.Text;
        c.chloride = txtchloride.Text;
        c.nitrate = txtnitrate.Text;
        c.remarks = TXTREMARK.Text;
        c.testedby = TXTTESTEDBY.Text;
        c.Update_Data();
        btnSave.Text = "Insert";
        Clear_Data();

    }
    public void Clear_Data()
    {
        //ddlClass.SelectedIndex = 0;
        //ddlLocono.SelectedIndex = 0;
        //ddlSchedule.SelectedIndex = 0;
        txtwater.Text="";
        txtDate.Text = "";
        txtchloride.Text = "";
        txtph.Text="";
        txthardness.Text="";
        txtwater.Text="";
        txtnitrate.Text="";
         TXTREMARK.Text="";
        TXTTESTEDBY.Text="";
    }
    protected void btnCancel_OnClick(object sender, EventArgs e)
    {
        ddlClass.SelectedIndex = 0;
        ddlLocono.SelectedIndex = 0;
       
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
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Fill_Class();
            ddlClass.SelectedIndex = 0;
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
                ddlClass.SelectedIndex = ddlClass.Items.IndexOf(ddlClass.Items.FindByValue(dt.Rows[0][0].ToString()));
            }
        }
        txtDate.Text = gv1.Rows[e.NewEditIndex].Cells[2].Text;
        txtwater.Text = gv1.Rows[e.NewEditIndex].Cells[3].Text;
        txtph.Text = gv1.Rows[e.NewEditIndex].Cells[4].Text;
        txthardness.Text = gv1.Rows[e.NewEditIndex].Cells[5].Text;
        txtchloride.Text = gv1.Rows[e.NewEditIndex].Cells[6].Text;
        txtnitrate.Text = gv1.Rows[e.NewEditIndex].Cells[7].Text;
        TXTREMARK.Text = gv1.Rows[e.NewEditIndex].Cells[8].Text;
        TXTTESTEDBY.Text = gv1.Rows[e.NewEditIndex].Cells[9].Text;
        btnSave.Text = "Update";
    }
    protected void gv1_OnRowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Cls_Coolant_Water c = new Cls_Coolant_Water();
        c.coolantwater_id = gv1.DataKeys[e.RowIndex].Value.ToString();
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
        
    }
}
