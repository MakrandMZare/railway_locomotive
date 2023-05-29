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
public partial class Loco_LocoAssemblyEntry : System.Web.UI.Page
{
    public void Fill_Assembly()
    {
        Cls_Loco_Assembly_History c = new Cls_Loco_Assembly_History();
        c.Id_LocoNo = ddlLocono.SelectedValue.ToString();
        gv1.DataSource = c.Select_AssemblyByLoocNo();
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
    protected void gv1_OnPageIndexChanging(object sender, GridViewPageEventArgs e)
    {
    }
    protected void gv1_OnRowDeleting(object sender, GridViewDeleteEventArgs e)
    {

        if (true)
        {
            Cls_Loco_Assembly_History c = new Cls_Loco_Assembly_History();
            c.Id_LocoHistory = gv1.DataKeys[e.RowIndex].Values[0].ToString();
            c.Delete_Data();
            Fill_Assembly();
        }
    }
    protected void gv1_OnSelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
        ddlLocono.SelectedIndex = ddlLocono.Items.IndexOf(ddlLocono.Items.FindByText(gv1.DataKeys[e.NewSelectedIndex].Values[1].ToString()));
        string str = gv1.DataKeys[e.NewSelectedIndex].Values[2].ToString();
        ddlRdso1.SelectedIndex = ddlRdso1.Items.IndexOf(ddlRdso1.Items.FindByValue(str.Substring(0, 1).ToString()));
        Fill_Rdso2Digit();
        ddlRdso2.SelectedIndex = ddlRdso2.Items.IndexOf(ddlRdso2.Items.FindByValue(str.Substring(0, 2).ToString()));
        Fill_Rdso3Digit();
        ddlRdso3.SelectedIndex = ddlRdso3.Items.IndexOf(ddlRdso3.Items.FindByValue(str.Substring(0, 3).ToString()));
        Fill_Rdso4Digit();
        if (str.Length == 4)
        {
            ddlRdso4.SelectedIndex = ddlRdso4.Items.IndexOf(ddlRdso4.Items.FindByValue(str.Substring(0, 4).ToString()));
        }
        txtAssemblyNo.Text = gv1.Rows[e.NewSelectedIndex].Cells[3].Text;
        ViewState["Id"] = gv1.DataKeys[e.NewSelectedIndex].Values[0].ToString();
        ViewState["AssemblyNo"] = txtAssemblyNo.Text;
        btnSave.Text = "Update";
    }

    public void Fill_Rdso1Digit()
    {
        Cls_railway_rdso c = new Cls_railway_rdso();
        ddlRdso1.DataSource = c.Select_Rdso1Digit();
        ddlRdso1.DataValueField = "rdso";
        ddlRdso1.DataTextField = "nature_defect";
        ddlRdso1.DataBind();
        ddlRdso1.Items.Insert(0, "SELECT");
    }
    public void Fill_Rdso2Digit()
    {
        Cls_railway_rdso c = new Cls_railway_rdso();
        ddlRdso2.DataSource = c.Select_Rdso2Digit(ddlRdso1.SelectedValue.ToString());
        ddlRdso2.DataValueField = "rdso";
        ddlRdso2.DataTextField = "nature_defect";
        ddlRdso2.DataBind();
        ddlRdso2.Items.Insert(0, "SELECT");
    }
    public void Fill_Rdso3Digit()
    {
        Cls_railway_rdso c = new Cls_railway_rdso();
        ddlRdso3.DataSource = c.Select_Rdso3Digit(ddlRdso2.SelectedValue.ToString());
        ddlRdso3.DataValueField = "rdso";
        ddlRdso3.DataTextField = "nature_defect";
        ddlRdso3.DataBind();
        ddlRdso3.Items.Insert(0, "SELECT");
    }
    public void Fill_Rdso4Digit()
    {
        Cls_railway_rdso c = new Cls_railway_rdso();

        ddlRdso4.DataSource = c.Select_Rdso4Digit(ddlRdso3.SelectedValue.ToString());
        ddlRdso4.DataValueField = "rdso";
        ddlRdso4.DataTextField = "nature_defect";
        ddlRdso4.DataBind();
        ddlRdso4.Items.Insert(0, "SELECT");
    }
    
    public void fill_Supplier1()
    {

        Cls_Loco_Assembly_Supplier c = new Cls_Loco_Assembly_Supplier();
        c.rdso = ddlRdso1.SelectedValue.ToString();
        ddlSupplier1.DataSource = c.SelectSupplierByAssembly();
        ddlSupplier1.DataValueField = "id_supp";
        ddlSupplier1.DataTextField = "s_name";
        ddlSupplier1.DataBind();
        ddlSupplier1.Items.Insert(0, "SELECT");
    }

    public void fill_Supplier2()
    {
        Cls_Loco_Assembly_Supplier c = new Cls_Loco_Assembly_Supplier();
        c.rdso = ddlRdso2.SelectedValue.ToString();
        ddlSupplier2.DataSource = c.SelectSupplierByAssembly();
        ddlSupplier2.DataValueField = "id_supp";
        ddlSupplier2.DataTextField = "s_name";
        ddlSupplier2.DataBind();
        ddlSupplier2.Items.Insert(0, "SELECT");
    }
    public void fill_Supplier3()
    {
        Cls_Loco_Assembly_Supplier c = new Cls_Loco_Assembly_Supplier();
        c.rdso = ddlRdso3.SelectedValue.ToString();
        ddlSupplier3.DataSource = c.SelectSupplierByAssembly();
        ddlSupplier3.DataValueField = "id_supp";
        ddlSupplier3.DataTextField = "s_name";
        ddlSupplier3.DataBind();
        ddlSupplier3.Items.Insert(0, "SELECT");
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        lblError.Visible = false;
        if (!Page.IsPostBack)
        {
            Fill_Class();
            Fill_Rdso1Digit();

            //fill_Supplier1();
            //fill_Supplier2();
            //fill_Supplier3();
        }
    }
    
    protected void ddlClass_SelectedIndexChanged(object sender, EventArgs e)
    {
        Fill_LocoNo();
    }
    protected void ddlRdso1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Fill_Rdso2Digit();
        fill_Supplier1();
    }
    protected void ddlRdso2_SelectedIndexChanged(object sender, EventArgs e)
    {
        Fill_Rdso3Digit();
        fill_Supplier2();
    }
    protected void ddlRdso3_SelectedIndexChanged(object sender, EventArgs e)
    {
        Fill_Rdso4Digit();
        fill_Supplier3();
    }
    protected void ddlRdso4_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void ddlLoco_SelectedIndexChanged(object sender, EventArgs e)
    {
        Fill_Assembly();
    }
    public string Tempstr(string str)
    {
        return str.Length == 1 ? "0" + str : str;
    }
    protected void btnSave_OnClick(object sender, EventArgs e)
    {
        Cls_Loco_Assembly_History c = new Cls_Loco_Assembly_History();
        c.AssemblyNo = txtAssemblyNo.Text;

        //        c.Id_LocoHistory =Convert.ToString(c.Insert_Data());
        //        c.id_rdso = Convert.ToString(c.Insert_Data());
        //c.id_supp = Convert.ToString(c.Insert_Data());

        if (btnSave.Text == "INSERT")
        {
            if (!c.Check_Existance())
            {
                lblError.Visible = false;
                c.GenerationDate = Tempstr(System.DateTime.Now.Month.ToString()) + "/" + Tempstr(System.DateTime.Now.Day.ToString()) + "/" + Tempstr(System.DateTime.Now.Year.ToString());
                c.Id_LocoNo = ddlLocono.SelectedValue.ToString();
                if (ddlRdso1.SelectedIndex != 0)
                {
                    c.RdsoCode = ddlRdso1.SelectedValue.ToString();
                }
                if (ddlRdso2.SelectedIndex != 0)
                {
                    c.RdsoCode = ddlRdso2.SelectedValue.ToString();
                }
                if (ddlRdso3.SelectedIndex != 0)
                {
                    c.RdsoCode = ddlRdso3.SelectedValue.ToString();
                }
                if (ddlRdso4.SelectedIndex != 0)
                {
                    c.RdsoCode = ddlRdso4.SelectedValue.ToString();
                }
                
                Int64 n = c.Insert_Data();
                if (n != 0)
                {
                    Fill_Assembly();
                }
            }
            else { lblError.Visible = true; }

        }
        else if (btnSave.Text == "Update")
        {
            if (c.AssemblyNo != ViewState["AssemblyNo"].ToString())
            {
                if (!c.Check_Existance())
                {
                    lblError.Visible = false;
                    c.GenerationDate = Tempstr(System.DateTime.Now.Month.ToString()) + "/" + Tempstr(System.DateTime.Now.Day.ToString()) + "/" + Tempstr(System.DateTime.Now.Year.ToString());
                    c.Id_LocoNo = ddlLocono.SelectedValue.ToString();
                    if (ddlRdso4.SelectedIndex != 0)
                    {
                        c.RdsoCode = ddlRdso4.SelectedValue.ToString();
                    }
                    else
                    {
                        c.RdsoCode = ddlRdso3.SelectedValue.ToString();
                    }
                    if (c.Insert_Data() != 0)
                    {
                        Fill_Assembly();
                    }
                }

                else { lblError.Visible = true; }
            }
            else
            {
                lblError.Visible = false;
                c.GenerationDate = Tempstr(System.DateTime.Now.Month.ToString()) + "/" + Tempstr(System.DateTime.Now.Day.ToString()) + "/" + Tempstr(System.DateTime.Now.Year.ToString());
                c.Id_LocoNo = ddlLocono.SelectedValue.ToString();
                if (ddlRdso4.SelectedIndex != 0)
                {
                    c.RdsoCode = ddlRdso4.SelectedValue.ToString();
                }
                else
                {
                    c.RdsoCode = ddlRdso3.SelectedValue.ToString();
                }
                c.Id_LocoHistory = ViewState["Id"].ToString();
                if (c.Update_Data())
                {
                    Fill_Assembly();
                }
            }
        }
    }
    //protected void btnSave1digit_OnClick(object sender, EventArgs e)
    //{
    //    if (RdsoPanel1.Visible == true)
    //    {
    //        RdsoPanel1.Visible = false;
    //        btnSave1digit.Text = "ADD NEW";
    //    }
    //    else if (RdsoPanel1.Visible == false)
    //    {
    //        RdsoPanel1.Visible = true;
    //        btnSave1digit.Text = "SAVE";
    //    }
    //}
    //protected void btnSave2digit_OnClick(object sender, EventArgs e)
    //{
    //    if (RdsoPanel2.Visible == true)
    //    {
    //        RdsoPanel2.Visible = false;
    //        btnSave2digit.Text = "ADD NEW";
    //    }
    //    else if (RdsoPanel2.Visible == false)
    //    {
    //        RdsoPanel2.Visible = true;
    //        btnSave2digit.Text = "SAVE";
    //    }
    //}
    //protected void btnSave3digit_OnClick(object sender, EventArgs e)
    //{
    //    if (RdsoPanel3.Visible == true)
    //    {
    //        RdsoPanel3.Visible = false;
    //        btnSave3digit.Text = "ADD NEW";
    //    }
    //    else if (RdsoPanel3.Visible == false)
    //    {
    //        RdsoPanel3.Visible = true;
    //        btnSave3digit.Text = "SAVE";
    //    }
    //}
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
