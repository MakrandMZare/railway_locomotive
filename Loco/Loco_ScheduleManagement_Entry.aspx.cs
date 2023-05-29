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
public partial class Loco_ScheduleManagement_Entry : System.Web.UI.Page
{
    public void Fill_LocoList()
    {
        Cls_jos_railway_mst_loco c = new Cls_jos_railway_mst_loco();
        c.tid = ddlClass.SelectedValue.ToString();
        gvLocoList.DataSource = c.Select_LocoNoByType();
        gvLocoList.DataBind();
    }
    public void Fill_Class()
    {
        Cls_Master_Loco_Type c = new Cls_Master_Loco_Type();
        ddlClass.DataSource = c.Select_Data();
        ddlClass.DataTextField = "loco_type";
        ddlClass.DataValueField = "id_ltype";
        ddlClass.DataBind();
        ddlClass.Items.Insert(0, "SELECT");
    }

    public string GenerateSchedulename(string sname)
    {
        Cls_Loco_ScheduleList c = new Cls_Loco_ScheduleList();
        c.ScheduleName = sname;
        if (!c.Is_Exists())
        {
            return sname;
        }
        else
        {
            Int64 m = c.Count_ScheduleName();
            c.ScheduleName += ("_" + (c.Count_ScheduleName() + 1).ToString());
            return GenerateSchedulename(c.ScheduleName);
        }



    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Fill_Class();

        }
    }
    protected void gvSchedule_OnDataBound(object sender, GridViewRowEventArgs e)
    {
        Cls_jos_railway_loco_type_schedule c = new Cls_jos_railway_loco_type_schedule();
        DropDownList ddl = new DropDownList();
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            ddl = (DropDownList)e.Row.FindControl("ddlSchedule");
            if (ddl != null)
            {
                ddl.DataSource = c.Select_DataByid(ddlClass.SelectedValue.ToString());
                ddl.DataTextField = "Schedule_Type";
                ddl.DataValueField = "id_loco_sch";
                ddl.DataBind();
                ddl.Items.Insert(0, "SELECT");
            }
        }
    }
    public void Insert_ScheduleData()
    {
        Cls_Loco_ScheduleList c = new Cls_Loco_ScheduleList();
        jos_railway_loco_Schedule_TimeTable c1 = new jos_railway_loco_Schedule_TimeTable();
        c.ClassId = ddlClass.SelectedValue.ToString();
        c.ScheduleDate = System.DateTime.Now.Month.ToString() + "/" + System.DateTime.Now.Day.ToString() + "/" + System.DateTime.Now.Year.ToString();
        c.ScheduleName = txtScheduleName.Text;
        Int64 m =  c.Insert_Data();
        //Insert LocoSchedule

        foreach (GridViewRow gr in gvLocoList.Rows)
        {
            CheckBox ch = new CheckBox();
            ch = (CheckBox)gr.FindControl("chk1");
            if (ch.Checked == true)
            {
                string startingdate;
                TextBox txtHeavySch = new TextBox();
                txtHeavySch =(TextBox)gr.FindControl("txtHeavy");
                Label lbllocoid = new Label();
                lbllocoid = (Label)gr.FindControl("Label1");
                if (txtHeavySch.Text != "")
                {
                    //startingdate = txtHeavySch.Text.Substring(3, 2) + "/" + txtHeavySch.Text.Substring(0, 2) + "/" + txtHeavySch.Text.Substring(6, 4);
                    startingdate = txtHeavySch.Text;
                    //Fill Heavey Schedule Date Loco wise
                    Cls_Loco_HeavySchedule Hobj = new Cls_Loco_HeavySchedule();
                    Hobj.HeavyScheduleDate = txtHeavySch.Text.Substring(3, 2) + "/" + txtHeavySch.Text.Substring(0, 2) + "/" + txtHeavySch.Text.Substring(6, 4);
                    Hobj.Loco_Id = lbllocoid.Text;
                    Hobj.Insert_Data();
                }
                else
                {
                    Label txtdoc = new Label();
                    txtdoc =(Label)gr.FindControl("lbldoc");
                    //startingdate = txtdoc.Text.Substring(3, 2) + "/" + txtdoc.Text.Substring(0, 2) + "/" + txtdoc.Text.Substring(6, 4);
                    startingdate = txtdoc.Text;
                }
                
                if (startingdate != "")
                {
                    foreach (GridViewRow gr1 in gvSchedule.Rows)
                    {
                        Cls_jos_railway_loco_type_schedule c2 = new Cls_jos_railway_loco_type_schedule();
                        
                        DropDownList ddl = new DropDownList();
                        ddl = (DropDownList)gr1.FindControl("ddlSchedule");
                        if (ddl != null)
                            
                        {
                            //startingdate = startingdate.Text.Substring(3, 2) + "/" + startingdate.Text.Substring(0, 2) + "/" + startingdate.Text.Substring(6, 4);
                            //System.DateTime d = Convert.ToDateTime(a, System.Globalization.CultureInfo.CreateSpecificCulture("en-AU").DateTimeFormat);
                            System.DateTime x = (Convert.ToDateTime(startingdate, System.Globalization.CultureInfo.CreateSpecificCulture("en-AU").DateTimeFormat).AddDays(c2.Get_DurationById(ddl.SelectedValue.ToString())));
                            startingdate = Convert.ToString(x);
                               
                            c1.Id_Master = m.ToString();
                            c1.Loco_Id = lbllocoid.Text;
                            c1.Schedule_Id = ddl.SelectedValue.ToString();
                            c1.ScheduleDate = Convert.ToDateTime(startingdate).Month.ToString() + "/" + Convert.ToDateTime(startingdate).Day.ToString() + "/" + Convert.ToDateTime(startingdate).Year.ToString();
                            c1.Insert_Data();
                        }
                    }
                }
            }
        }
        Response.Redirect("~/Loco/Loco_ScheduleManagement_View.aspx?id=" + m.ToString());

        
    }
    protected void btnGenerate_OnClick(object sender, EventArgs e)
    {
        Cls_Loco_ScheduleList c = new Cls_Loco_ScheduleList();
        c.ScheduleName = txtScheduleName.Text;
        if (!c.Is_Exists())
        {
            lblError.Visible = false;
            Insert_ScheduleData();
        }
        else
        {
            lblError.Visible = true;
            lblError.Text = "This Schedule Already Exists...Please Rename Schedule.";
        }
    }
    public void Fill_Schedule()
    {
        DataTable dt = new DataTable();
        dt.Columns.Add("NO", typeof(System.Int16));
        dt.Columns.Add("aa", typeof(System.Int16));
        for (int i = 1; i <= Convert.ToInt16(txtTotalSchedule.Text); i++)
        {
            DataRow dr = dt.NewRow();
            dr[0] = i.ToString();
            dt.Rows.Add(dr);
        }
        gvSchedule.DataSource = dt;
        gvSchedule.DataBind();
    }
    public void Fill_ExistingSchedule()
    {
        Cls_Loco_ScheduleList c = new Cls_Loco_ScheduleList();
        c.ClassId = ddlClass.SelectedValue.ToString();
        gvExistingSchedule.DataSource = c.Get_ExstingScheduleByClass();
        gvExistingSchedule.DataBind();
    }
    protected void btnDisplay_OnClick(object sender, EventArgs e)
    {
        Fill_LocoList();
        Fill_Schedule();
        GENERATE.Visible = true;
        txtScheduleName.Text = GenerateSchedulename(ddlClass.SelectedItem.ToString() + "/" + System.DateTime.Now.ToString("Y").Replace(',', '/'));

    }
    protected void ddlClass_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlClass.SelectedIndex != 0)
        {
            Cls_Master_Loco_Type c = new Cls_Master_Loco_Type();
            c.id_ltype = ddlClass.SelectedValue.ToString();
            lblguage.Text = "";
            lblguage.Visible = true;
            lblguage.Text = c.Get_LocoGuageByLocotype();
            Fill_ExistingSchedule();

        }
    }
    protected void txtTotalSchedule_TextChanged(object sender, EventArgs e)
    {

    }
}
