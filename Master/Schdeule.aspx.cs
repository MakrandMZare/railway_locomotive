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
public partial class Master_Schdeule : System.Web.UI.Page
{
    Cls_jos_railway_loco_type_schedule c = new Cls_jos_railway_loco_type_schedule();
    DataTable dtt;
    public void Fill_Class()
    {
        Cls_Master_Loco_Type c = new Cls_Master_Loco_Type();
        ddlClass.DataSource = c.Select_Data();
        ddlClass.DataTextField = "loco_type";
        ddlClass.DataValueField = "id_ltype";
        ddlClass.DataBind();
        ddlClass.Items.Insert(0, "SELECT");
    }
    
    protected void ddlClass_SelectedIndexChanged(object sender, EventArgs e)
    {
        Fill_Data();
        Cls_Master_Loco_Type c = new Cls_Master_Loco_Type();
        c.id_ltype = ddlClass.SelectedValue.ToString();
        lblguage.Text = "";
        lblguage.Visible = true;
        lblguage.Text = c.Get_LocoGuageByLocotype();
        
    }
    protected void Fill_Data()
    {
        c.loco_id = ddlClass.SelectedValue.ToString();
        dtt = c.Select_Data();
        GridView1.DataSource = dtt;
        GridView1.DataBind();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Fill_Class();
            //Fill_Data();
        }
        else
        {
            
            Fill_Data();
            string id = (string)Request.QueryString["id"];
            string action = (string)Request.QueryString["action"];
            if ((id != "" && action == "update"))
            {
                //Fill_Class();
                foreach (DataRow dr in dtt.Rows)
                {
                    string str = dr[0].ToString();
                    if (dr[0].ToString() == Request.QueryString["id"].ToString())
                    {
                        Cls_Master_Loco_Type cl = new Cls_Master_Loco_Type();
                        //string str1 = dr[1].ToString();
                        //DataTable c1dt = cl.Get_LocoTypeByLocoId(dr[1].ToString());
                        //if (c1dt.Rows.Count > 0)
                        //{
                           // ddlClass.SelectedIndex = ddlClass.Items.IndexOf(ddlClass.Items.FindByValue(c1dt.Rows[0][0].ToString()));
                       // }
                        if (txtSchedule.Text == "")
                        {
                            txtSchedule.Text = dr[1].ToString();
                            txtDuration.Text = dr[2].ToString();
                        }
                    }
                    btnadd.Text = "Update";
                }
            }
            if (id != "" && action == "delete")
            {
                c.id_loco_sch = Request.QueryString["id"].ToString();
                c.Delete_Data();
                Fill_Data();
            }
        }
    }
    protected void btnadd_Click(object sender, EventArgs e)
    {
        c.loco_id = ddlClass.SelectedValue.ToString();
        c.s_type = txtSchedule.Text;
        c.duration = txtDuration.Text;
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
            c.id_loco_sch = Request.QueryString["id"].ToString();
            // c.loco_id = ddlLocono.SelectedValue.ToString();
            c.s_type = txtSchedule.Text;
            c.duration = txtDuration.Text;
            c.Update_Data();
            cleardata();
            Fill_Data();
        }
    }
    public void cleardata()
    {
        txtSchedule.Text = "";
        txtDuration.Text = "";
    }
}
