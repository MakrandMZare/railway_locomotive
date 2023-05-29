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

public partial class over_due : System.Web.UI.Page
{
    Cls_jos_railway_mst_over_due c = new Cls_jos_railway_mst_over_due();
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
        }
        else
        {
            if ((string)Request.QueryString["id"] != "" && (string)Request.QueryString["action"] == "delete")
            {
                c.id_od  = Request.QueryString["id"].ToString();
                c.Delete_Data();
                Fill_Data();
            }

            if ((string)Request.QueryString["id"] != "" && (string)Request.QueryString["action"] == "update")
            {
                //if (txtoverdue .Text == "" && txtduedate .Text == "")
                if (txtoverdue.Text == "" )
                {
                    c.id_od = Request.QueryString["id"].ToString();
                    DataTable dt = c.Select_Data();
                    btnadd.Text = "Update";
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (dr[0].ToString() == c.id_od)
                        {
                            txtoverdue .Text = dr[1].ToString();
                            txtduedate.Text = dr[2].ToString();

                        }
                  }
                }
                

            }


         
        }

    }
    protected void btnadd_Click(object sender, EventArgs e)
    {
        c.due  = txtoverdue.Text.ToUpper();
        c.duedate  = txtduedate.Text;


        if (btnadd.Text == "Add")
        {
            if (!c.IsDataExists())
            {
                if (Convert.ToInt64(c.Insert_Data()) > 0)
                {

                    cleardata();
                    Fill_Data();

                }
                lblerro.Visible = false;
            }
            else
            {
                lblerro.Visible = true;
                
            }
        }

        else if (btnadd.Text == "Update")
        {

            c.id_od = Request.QueryString["id"].ToString();
            c.Update_Data();
            cleardata();
            Response.Redirect("~/Master/over_due.aspx");

        }

    }
    public void cleardata()
    {
        txtoverdue .Text = "";
        txtduedate .Text = "";

    }

}
