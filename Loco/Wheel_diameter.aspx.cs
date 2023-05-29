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

public partial class Loco_Wheel_diameter : System.Web.UI.Page
{
    Cls_Wheel_Diameter c = new Cls_Wheel_Diameter();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Fill_Class();
            Fill_Data();

            
        }
        else
        {

        }
    }
    public void Fill_Data()
    {
        gv1.DataSource = c.Select_Data();
        gv1.DataBind();
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

    public void Insert()
    {
        Cls_Wheel_Diameter c = new Cls_Wheel_Diameter();
        //  c.id_wheel_diameter;
        c.id_mst_loco = ddlLocono.SelectedIndex.ToString();
        c.doc = txtdoc.Text.Substring(3, 2) + "/" + txtdoc.Text.Substring(0, 2) + "/" + txtdoc.Text.Substring(6, 4);
        
        c.id_schedule = ddlSchedule.SelectedIndex.ToString();
        c.w_date = txtdate.Text.Substring(3, 2) + "/" + txtdate.Text.Substring(0, 2) + "/" + txtdate.Text.Substring(6,4) ;
        c.dia = txtdia.Text;
        c.r1 = lr1.Text;
        c.p1 = lp1.Text;
        c.h1 = ph1.Text;
        c.r2 = lr2.Text;
        c.p2 = lp2.Text;
        c.h2 = ph2.Text;
        c.r3 = lr3.Text;
        c.p3 = lp3.Text;
        c.h3 = ph3.Text;
        c.r4 = lr4.Text;
        c.p4 = lp4.Text;
        c.h4 = ph4.Text;
        c.r5 = lr5.Text;
        c.p5 = lp5.Text;
        c.h5 = ph5.Text;
        c.r6 = lr6.Text;
        c.p6 = lp6.Text;
        c.h6 = ph6.Text;
        c.r7 = rr1.Text;
        c.p7 = rp1.Text;
        c.h7 = rh1.Text;
        c.r8 = rr2.Text;
        c.p8 = rp2.Text;
        c.h8 = rh2.Text;
        c.r9 = rr3.Text;
        c.p9 = rp3.Text;
        c.h9 = rh3.Text;
        c.r10 = rr4.Text;
        c.p10 = rp4.Text;
        c.h10 = rh4.Text;
        c.r11 = rr5.Text;
        c.p11 = rp5.Text;
        c.h11 = rh5.Text;
        c.r12 = rr6.Text;
        c.p12 = rp6.Text;
        c.h12 = rh6.Text;
        c.Insert_Data();
        CleanData();


    }
    public void CleanData()
    {
        ddlLocono.SelectedIndex = 0;
        txtdoc.Text = "";
        ddlSchedule.SelectedIndex = 0;
        txtdate.Text = "";

        txtdia.Text = "";
        lr1.Text = "";
        lp1.Text = "";
        ph1.Text = "";
        lr2.Text = "";
        lp2.Text = "";
        ph2.Text = "";
        lr3.Text = "";
        lp3.Text = "";
        ph3.Text = "";
        lr4.Text = "";
        lp4.Text = "";
        ph4.Text = "";
        lr5.Text = "";
        lp5.Text = "";
        ph5.Text = "";
        lr6.Text = "";
        lp6.Text = "";
        ph6.Text = "";
        rr1.Text = "";
        rp1.Text = "";
        rh1.Text = "";
        rr2.Text = "";
        rp2.Text = "";
        rh2.Text = "";
        rr3.Text = "";
        rp3.Text = "";
        rh3.Text = "";
        rr4.Text = "";
        rp4.Text = "";
        rh4.Text = "";
        rr5.Text = "";
        rp5.Text = "";
        rh5.Text = "";
        rr6.Text = "";
        rp6.Text = "";
        rh6.Text = "";
        c.Insert_Data();

    }
    protected void btnInsert_Click(object sender, EventArgs e)
    {
        Insert();
    }
    //public void Fill_Schedule()
    //{
    //    ddlSchedule.Items.Clear();
    //    Cls_jos_railway_loco_type_schedule c = new Cls_jos_railway_loco_type_schedule();
    //    c.loco_id = ddlClass.SelectedValue.ToString();
    //    ddlSchedule.DataSource = c.Select_Data();
    //    ddlSchedule.DataTextField = "Schedule_Type";
    //    ddlSchedule.DataValueField = "id_loco_sch";
    //    ddlSchedule.DataBind();
    //    ddlSchedule.Items.Insert(0, "SELECT");
    //}
    public void Fill_Schedule()
    {
        Cls_jos_railway_loco_type_schedule c = new Cls_jos_railway_loco_type_schedule();
        c.loco_id = ddlClass.SelectedValue.ToString();
        ddlSchedule.DataSource = c.Select_Data();
        ddlSchedule.DataTextField = "Schedule_Type";
        ddlSchedule.DataValueField = "id_loco_sch";
        ddlSchedule.DataBind();
        ddlSchedule.Items.Insert(0, "SELECT");


    }
    protected void ddlClass_SelectedIndexChanged(object sender, EventArgs e)
    {
        Fill_LocoNo();
        Fill_Schedule();
    }
    
    protected void ddlLocono_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlLocono.SelectedIndex != 0)
        {
            Fill_Data();
        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        CleanData();
    }

    
    //protected void gv1_OnRowEditing(object sender, GridViewEditEventArgs e)
    //{
    //    ViewState["Id"] = gv1.DataKeys[e.NewEditIndex].Value.ToString();
    //    string n = gv1.Rows[e.NewEditIndex].Cells[1].Text;
    //    ddlLocono.SelectedIndex = ddlLocono.Items.IndexOf(ddlLocono.Items.FindByText(gv1.Rows[e.NewEditIndex].Cells[1].Text));
    //    //ddlLocono.SelectedIndex = ddlLocono.Items.IndexOf(ddlLocono.Items.FindByValue(gv1.DataKeys[e.NewEditIndex].Values[1].ToString()));
    //    if (ddlLocono.SelectedIndex != 0)
    //    {
    //        Cls_Master_Loco_Type c = new Cls_Master_Loco_Type();

    //        DataTable dt = c.Get_LocoTypeByLocoId(ddlLocono.Text);
    //        if (dt.Rows.Count == 1)
    //        {
    //            ddlclass.SelectedIndex = ddlclass.Items.IndexOf(ddlclass.Items.FindByValue(dt.Rows[0][0].ToString()));
    //        }
    //    }
    //    txtdate.Text = gv1.Rows[e.NewEditIndex].Cells[2].Text;


    //    txtCompName.Text = gv1.Rows[e.NewEditIndex].Cells[3].Text;
    //    txtTypeTest.Text = gv1.Rows[e.NewEditIndex].Cells[4].Text;
    //    txtSuitable.Text = gv1.Rows[e.NewEditIndex].Cells[5].Text;
    //    txtRejected.Text = gv1.Rows[e.NewEditIndex].Cells[6].Text;
    //    txtRemarks.Text = gv1.Rows[e.NewEditIndex].Cells[7].Text;
    //    txtTested.Text = gv1.Rows[e.NewEditIndex].Cells[8].Text;

    //    btnadd.Text = "Update";
    //}
    //protected void gv1_OnRowDeleting(object sender, GridViewDeleteEventArgs e)
    //{
    //    Cls_failure_component c = new Cls_failure_component();
    //    c.comp_id = gv1.DataKeys[e.RowIndex].Value.ToString();
    //    c.Delete_Data();
    //    Fill_Data();
    //    // Response.Redirect("~\\TestingLab\\ComponantFailure.aspx");

    ////}
    //public void Updation()
    //{
    //    Cls_failure_component c = new Cls_failure_component();
    //    //c.comp_id = Request.QueryString["Id"].ToString();
    //    c.comp_id = ViewState["Id"].ToString();
    //    c.comp_name = txtCompName.Text;
    //    c.id_mst_loco = ddlLocono.SelectedValue.ToString();

    //    c.l_date = txtdate.Text.Substring(3, 2) + "/" + txtdate.Text.Substring(0, 2) + "/" + txtdate.Text.Substring(6, 4);
    //    c.test_type = txtTypeTest.Text;
    //    c.suitable = txtSuitable.Text;
    //    c.rejected = txtRejected.Text;
    //    c.remarks = txtRemarks.Text;
    //    c.testedby = txtTested.Text;

    //    c.Update_Data();
    //    btnadd.Text = "Insert";
    //    Clear_Data();

    //}

    //protected void gv_OnEditCommand(object sender, EventArgs e)
    //{
        
    //}
}
