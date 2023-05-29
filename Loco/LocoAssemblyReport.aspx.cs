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

public partial class Loco_LocoAssemblyReport : System.Web.UI.Page
{
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
            Fill_Rdso1Digit();
        }
    }
    protected void ddlRdso1_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        Fill_Rdso2Digit();
    }
    protected void ddlRdso2_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        Fill_Rdso3Digit();
    }
    protected void ddlRdso3_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        Fill_Rdso4Digit();
    }
    protected void ddlRdso4_OnSelectedIndexChanged(object sender, EventArgs e)
    {
    }
    protected void ChkLoco_OnCheckedChanged(object sender, EventArgs e)
    {
        //ddlLocono.Enabled = ChkLoco.Checked;
        //ddlClass.Enabled = ChkLoco.Checked;
    }
    protected void ChkRdso1_OnCheckedChanged(object sender, EventArgs e)
    {
        //ddlRdso1.Enabled = ChkRdso1.Checked;
    }
    protected void ChkRdso2_OnCheckedChanged(object sender, EventArgs e)
    {
        //ddlRdso2.Enabled = ChkRdso2.Checked;
    }
    protected void ChkRdso3_OnCheckedChanged(object sender, EventArgs e)
    {
        //ddlRdso3.Enabled = ChkRdso3.Checked;
    }
    protected void ChkRdso4_OnCheckedChanged(object sender, EventArgs e)
    {
        //ddlRdso4.Enabled = ChkRdso4.Checked;
    }
    public string Generate_Query()
    {
        string str = "";
        string tempstr = "";
        if (ChkLoco.Checked == true && ddlClass.SelectedIndex != 0 && ddlLocono.SelectedIndex != 0)
        {
            tempstr = !str.StartsWith(" WHERE ") ? " WHERE Id_LocoNo='" + ddlLocono.SelectedValue.ToString() + "'" : " AND Id_LocoNo='" + ddlLocono.SelectedValue.ToString() + "'";
            str += tempstr;
        }
        if (ChkRdso1.Checked == true && ddlRdso1.SelectedIndex != 0)
        {
            tempstr = "";
            tempstr = !str.StartsWith(" WHERE ") ? " WHERE LEFT(RdsoCode,1)='" + ddlRdso1.SelectedValue.ToString() + "'" : " AND LEFT(RdsoCode,1)='" + ddlRdso1.SelectedValue.ToString() + "'";
            str += tempstr;
        }
        if (ChkRdso2.Checked == true && ddlRdso2.SelectedIndex != 0)
        {
            tempstr = "";
            tempstr = !str.StartsWith(" WHERE ") ? " WHERE LEFT(RdsoCode,2)='" + ddlRdso2.SelectedValue.ToString() + "'" : " AND LEFT(RdsoCode,2)='" + ddlRdso2.SelectedValue.ToString() + "'";
            str += tempstr;
        }
        if (ChkRdso3.Checked == true && ddlRdso3.SelectedIndex != 0)
        {
            tempstr = "";
            tempstr = !str.StartsWith(" WHERE ") ? " WHERE LEFT(RdsoCode,3)='" + ddlRdso3.SelectedValue.ToString() + "'" : " AND LEFT(RdsoCode,3)='" + ddlRdso3.SelectedValue.ToString() + "'";
            str += tempstr;
        }
        if (ChkRdso4.Checked == true && ddlRdso4.SelectedIndex != 0)
        {
            tempstr = "";
            tempstr = !str.StartsWith(" WHERE ") ? " WHERE LEFT(RdsoCode,4)='" + ddlRdso4.SelectedValue.ToString() + "'" : " AND LEFT(RdsoCode,4)='" + ddlRdso4.SelectedValue.ToString() + "'";
            str += tempstr;
        }
        return str;

    }
    protected void btnShow_OnClick(object sender, EventArgs e)
    {
        if (ChkLoco.Checked == true || ChkRdso1.Checked == true || ChkRdso2.Checked == true || ChkRdso3.Checked == true || ChkRdso4.Checked == true)
        {
            Cls_Loco_Assembly_History c = new Cls_Loco_Assembly_History();
            lblError.Visible = false;
            string str = Generate_Query();
            if (str != "")
            {
                gv1.DataSource = c.Generate_AssemblyReport(str);
                gv1.DataBind();
            }
        }
        else
        {
            lblError.Visible = true;
        }
    }
    protected void ddlClass_SelectedIndexChanged(object sender, EventArgs e)
    {
        Fill_LocoNo();
    }
}
