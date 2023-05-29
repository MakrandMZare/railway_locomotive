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
using System.Data.SqlClient;
using Railway;

public partial class loco : System.Web.UI.Page
{
    Cls_jos_railway_mst_loco c = new Cls_jos_railway_mst_loco();
    protected void Fill_Data()
    {
        GridView1.DataSource = c.Select_Data();
        GridView1.DataBind();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Fill_Data();
            fill_Shed();
            fill_class_ddl();
        }
        else
        {
            if ((string)Request.QueryString["id"] != "" && (string)Request.QueryString["action"] == "delete")
            {
                c.id_mst_loco = Request.QueryString["id"].ToString();
                //c.locono = txtloco.Text;
                c.Delete_Data();
                Fill_Data();
            }

            if ((string)Request.QueryString["id"] != "" && (string)Request.QueryString["action"] == "update")
            {
                c.id_mst_loco = Request.QueryString["id"].ToString();
                DataTable dt = c.Select_Data();
                btnadd.Text = "Update";
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr[0].ToString() == c.id_mst_loco)
                    {

                        txtloco.Text = dr[1].ToString();
                        ddlclass.Text = dr[2].ToString();
                        ddlshedid.Text = dr[3].ToString();
                        txtdockdate.Text = dr[4].ToString();
                        txtatime.Text = dr[5].ToString();
                        txtphodate.Text = dr[6].ToString();
                        txtnativ.Text = dr[7].ToString();
                        txtrfrom.Text = dr[8].ToString();


                    }
                }
            }



        }
    }
    public void Insert_LocoSchedule(string m)
    {

        DateTime schdate = Convert.ToDateTime(txtdockdate.Text.Substring(3, 2).ToString() + "/" + txtdockdate.Text.Substring(0, 2).ToString() + "/" + txtdockdate.Text.Substring(6, 4).ToString());
        
        Cls_jos_railway_loco_type_schedule c1 = new Cls_jos_railway_loco_type_schedule();
        c1.loco_id = ddlclass.SelectedValue.ToString();
        DataTable ScheduleData = c1.Select_Data();
        foreach (DataRow dr in ScheduleData.Rows)
        {
            c.Schedule_Id = dr[0].ToString();
            schdate = schdate.AddDays(Convert.ToInt64(dr[2].ToString()));
            c.ScheduleDate = schdate.ToString();
            c.Loco_Id = m;
            c.Insert_Data_Loco_Schedule();
        }
    }
    protected void btnadd_Click(object sender, EventArgs e)
    {
        c.locono = txtloco.Text;
        c.tid = ddlclass.Text;
        c.shed_id = ddlshedid.Text;
        c.doc_date = txtdockdate.Text;
        c.a_time = txtatime.Text;
        c.poh_date = txtphodate.Text;
        c.native = txtnativ.Text;
        c.rfrom = txtrfrom.Text;
        if (btnadd.Text == "Add")
        {

            if (Convert.ToInt64(c.Insert_Data()) > 0)
            {
                cleardata();
                Fill_Data();

            }
        }

        else if (btnadd.Text == "Update")
        {

            c.id_mst_loco = Request.QueryString["id_mst_loco"].ToString();
            c.Update_Data();
            cleardata();
            Response.Redirect("~/hq.aspx?id=" + Request.QueryString["id"].ToString() + "&action=edit");

        }

    }
    public void cleardata()
    {
        txtloco.Text = "";
        txtloco.Text = "";
        txtdockdate.Text = "";
        txtatime.Text = "";
        txtphodate.Text = "";
        txtnativ.Text = "";
        txtrfrom.Text = "";

    }
    public void fill_class_ddl()
    {
        Cls_Master_Loco_Type c = new Cls_Master_Loco_Type();
        ddlclass.DataSource = c.Select_Data();
        ddlclass.DataTextField = "loco_type";
        ddlclass.DataValueField = "id_ltype";
        ddlclass.DataBind();
        ddlclass.Items.Insert(0, "SELECT");

    }
    public void fill_Shed()
    {
        Cls_jos_railway_shed c = new Cls_jos_railway_shed();
        ddlshedid.DataSource = c.Select_Data();
        ddlshedid.DataTextField = "sname";
        ddlshedid.DataValueField = "id_shed";
        ddlshedid.DataBind();
        ddlshedid.Items.Insert(0, "SELECT");
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}

