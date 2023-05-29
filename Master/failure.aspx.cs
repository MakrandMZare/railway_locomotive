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

public partial class failure : System.Web.UI.Page
{
    Cls_jos_railway_mst_failure c = new Cls_jos_railway_mst_failure();
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
                c.id_m_fail  = Request.QueryString["id"].ToString();
                c.Delete_Data();
                Fill_Data();
            }

            if ((string)Request.QueryString["id"] != "" && (string)Request.QueryString["action"] == "update")
            {
                if (TextBox1 .Text == "")
                {
                    c.id_m_fail = Request.QueryString["id"].ToString();
                    DataTable dt = c.Select_Data();
                    btnfailure .Text = "Update";
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (dr[0].ToString() == c.id_m_fail)
                        {
                            TextBox1 .Text = dr[1].ToString();

                        }
                    }
                }
                

            }


            
        }

    }
    protected void btnadd_Click(object sender, EventArgs e)
    {
        //c.failure  = TextBox1 .Text;


        //if (btnfailure .Text == "Add")
        //{

        //    if (Convert.ToInt64(c.Insert_Data()) > 0)
        //    {

        //        cleardata();
        //        Fill_Data();

        //    }
        //}

        //else if (btnfailure .Text == "Update")
        //{

        //    c.id_m_fail = Request.QueryString["id"].ToString();
        //    c.Update_Data();
        //    cleardata();
        //    Response.Redirect("~/Master/failure.aspx");

        //}

    }
    public void cleardata()
    {
        TextBox1 .Text = "";

    }

    protected void btnfailure_Click(object sender, EventArgs e)
    {
        c.failure = TextBox1.Text.ToUpper();


        if (btnfailure.Text == "Add")
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

        else if (btnfailure.Text == "Update")
        {

            c.id_m_fail = Request.QueryString["id"].ToString();
            c.Update_Data();
            cleardata();
            Response.Redirect("~/Master/failure.aspx");

        }

    }
}
