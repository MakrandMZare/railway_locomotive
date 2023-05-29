using System;
using System.Collections;
using System.Configuration;
using System.Data;
//using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
//using System.Xml.Linq;
using Railway;
public partial class HR_EmployeeDetails : System.Web.UI.Page
{
    public void Fill_Medical()
    {
        Cls_jos_railway_mst_medical c = new Cls_jos_railway_mst_medical();
        ddlMedical.DataSource = c.Select_Data();
        ddlMedical.DataTextField = "name";
        ddlMedical.DataValueField = "id_med";
        ddlMedical.DataBind();
        ddlMedical.Items.Insert(0, "SELECT");

    }
    public void Fill_Section()
    {
        Cls_jos_railway_section c = new Cls_jos_railway_section();
        ddlSection.DataSource = c.Select_Data();
        ddlSection.DataTextField = "s_type";
        ddlSection.DataValueField = "id_section";
        ddlSection.DataBind();
        ddlSection.Items.Insert(0, "SELECT");
    }
    public void Fill_Caste()
    {
        Cls_jos_railway_mst_caste c = new Cls_jos_railway_mst_caste();

        ddlCaste.DataSource = c.Select_Data();
        ddlCaste.DataTextField = "caste";
        ddlCaste.DataValueField = "id_caste";
        ddlCaste.DataBind();
        ddlCaste.Items.Insert(0, "SELECT");
    }
    public void Fill_SubCaste()
    {
        Cls_jos_railway_mst_sub_caste c = new Cls_jos_railway_mst_sub_caste();
        c.mid = ddlCaste.SelectedValue.ToString();
        ddlSubCaste.DataSource = c.Select_DataByCaste();
        ddlSubCaste.DataTextField = "sub_caste";
        ddlSubCaste.DataValueField = "id_s_caste";
        ddlSubCaste.DataBind();
        ddlSubCaste.Items.Insert(0, "SELECT");

    }
    public void Fill_EmployeeDetails()
    { 
    Cls_jos_railway_Hr c = new Cls_jos_railway_Hr();
        c.Hrid = Request.QueryString["id"].ToString();
        DataTable dt = c.Select_DataById();
        txtSurname.Text = dt.Rows[0]["Surname"].ToString();
        txtName.Text = dt.Rows[0]["sName"].ToString();
        txtFathername.Text = dt.Rows[0]["FathersName"].ToString();
        txtEmployeeno.Text = dt.Rows[0]["Employee No"].ToString();
        txtSalaryCode.Text = dt.Rows[0]["Salary Code"].ToString();
        txtEduQua.Text = dt.Rows[0]["Educatinal Qualification"].ToString();
        txtTechQua.Text = dt.Rows[0]["Technical Qualification"].ToString();
        ddlMedical.SelectedIndex = ddlMedical.Items.IndexOf(ddlMedical.Items.FindByValue(dt.Rows[0]["MedicalCategory"].ToString()));
        ddlBloodGroup.SelectedIndex = ddlBloodGroup.Items.IndexOf(ddlBloodGroup.Items.FindByValue(dt.Rows[0]["BloodGroup"].ToString()));
        ddlSection.SelectedIndex = ddlSection.Items.IndexOf(ddlSection.Items.FindByValue(dt.Rows[0]["Section"].ToString()));
        txtPan.Text = dt.Rows[0]["PAN"].ToString();
        txtPost.Text = dt.Rows[0]["Post"].ToString();
        ddlCaste.SelectedIndex = ddlCaste.Items.IndexOf(ddlCaste.Items.FindByValue(dt.Rows[0]["Caste"].ToString()));
        ddlSubCaste.SelectedIndex = ddlSubCaste.Items.IndexOf(ddlSubCaste.Items.FindByValue(dt.Rows[0]["Sub Caste"].ToString()));
        txtCurAddress.Text = dt.Rows[0]["Current Address"].ToString();
        txtPerAddress.Text = dt.Rows[0]["Permanent Address"].ToString();
        
        

    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Fill_Caste();
            Fill_Medical();
            Fill_Section();
            if ((string)Request.QueryString["id"] != null)
            {
                Fill_EmployeeDetails();
                btnSave.Text = "UPDATE";
            }
        }
    }
    public void Insertion()
    {
        Cls_jos_railway_Hr mltobj = new Cls_jos_railway_Hr();
        //Assign Data To Insert
        mltobj.Address = txtCurAddress.Text;
        mltobj.BloodGroup = ddlBloodGroup.SelectedValue.ToString();
        mltobj.Cast = ddlCaste.SelectedValue.ToString();
        mltobj.City = txtCity.Text;
        mltobj.Disease = txtDiesease.Text;
        mltobj.DOB = txtDOB.Text.Substring(3, 2) + "/" + txtDOB.Text.Substring(0,2) + "/" + txtDOB.Text.Substring(6, 4);
        mltobj.EmailAddress = txtEmail.Text;
        mltobj.EmployeeNo = txtEmployeeno.Text;
        mltobj.equa = txtEduQua.Text;
        mltobj.fname = txtFathername.Text;
        mltobj.FullName = txtName.Text;
        mltobj.Gender = rdoGender.SelectedValue.ToString();
        mltobj.m_cat = ddlMedical.SelectedValue.ToString();
        mltobj.MobileNo = txtMobile.Text;
        mltobj.paddress = txtPerAddress.Text;
        mltobj.Pan = txtPan.Text;
        mltobj.Post = txtPost.Text;
        mltobj.RecidentNo = txtRecno.Text;
        mltobj.RetirementDate = txtRdate.Text.Substring(3, 2) + "/" + txtRdate.Text.Substring(0, 2) + "/" + txtRdate.Text.Substring(6, 4);
        mltobj.SalaryCode = txtSalaryCode.Text;
        mltobj.Section = ddlSection.SelectedValue.ToString();
        mltobj.State = txtState.Text;
        mltobj.SubCast = ddlSubCaste.SelectedValue.ToString();
        mltobj.surname = txtSurname.Text;
        mltobj.tech_qua = txtTechQua.Text;
        mltobj.photo = "";
        mltobj.signature = "";
        mltobj.thumb = "";
        mltobj.Insert_Data();
    }
    public void Updation()
    {
        Cls_jos_railway_Hr mltobj = new Cls_jos_railway_Hr();
        //Assign Data To Insert
        mltobj.Address = txtCurAddress.Text;
        mltobj.BloodGroup = ddlBloodGroup.SelectedValue.ToString();
        mltobj.Cast = ddlCaste.SelectedValue.ToString();
        mltobj.City = txtCity.Text;
        mltobj.Disease = txtDiesease.Text;
        mltobj.DOB = txtDOB.Text.Substring(3, 2) + "/" + txtDOB.Text.Substring(0, 2) + "/" + txtDOB.Text.Substring(6, 4);
        mltobj.EmailAddress = txtEmail.Text;
        mltobj.EmployeeNo = txtEmployeeno.Text;
        mltobj.equa = txtEduQua.Text;
        mltobj.fname = txtFathername.Text;
        mltobj.FullName = txtName.Text;
        mltobj.Gender = rdoGender.SelectedValue.ToString();
        mltobj.m_cat = ddlMedical.SelectedValue.ToString();
        mltobj.MobileNo = txtMobile.Text;
        mltobj.paddress = txtPerAddress.Text;
        mltobj.Pan = txtPan.Text;
        mltobj.Post = txtPost.Text;
        mltobj.RecidentNo = txtRecno.Text;
        mltobj.RetirementDate = txtRdate.Text.Substring(3, 2) + "/" + txtRdate.Text.Substring(0, 2) + "/" + txtRdate.Text.Substring(6, 4);
        mltobj.SalaryCode = txtSalaryCode.Text;
        mltobj.Section = ddlSection.SelectedValue.ToString();
        mltobj.State = txtState.Text;
        mltobj.SubCast = ddlSubCaste.SelectedValue.ToString();
        mltobj.surname = txtSurname.Text;
        mltobj.tech_qua = txtTechQua.Text;
        mltobj.photo = "";
        mltobj.signature = "";
        mltobj.thumb = "";
        mltobj.Hrid = Request.QueryString["id"].ToString();
        mltobj.Update_Data();
    }
    protected void btnSave_OnClick(object sender, EventArgs e)
    {
        if (btnSave.Text == "INSERT")
        {
            Insertion();
        }
        else if (btnSave.Text == "UPDATE")
        {
            if ((string)Request.QueryString["id"] != null)
            {
                Updation();
            }
        }
    }
    protected void rdoDiesease_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        if (rdoDiesease.SelectedIndex == 0)
        {
            txtDiesease.Visible = true;
        }
        else if (rdoDiesease.SelectedIndex == 1)
        {
            txtDiesease.Visible = false;
        }
    }
    protected void ddlCaste_SelectedIndexChanged(object sender, EventArgs e)
    {
        Fill_SubCaste();
    }
}
