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

public partial class irregularity : System.Web.UI.Page
{
    Cls_jos_railway_mst_d_id c = new Cls_jos_railway_mst_d_id();
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
                c.Id_irregularity = Request.QueryString["id"].ToString();
                c.Delete_Data();
                Fill_Data();
            }

            if ((string)Request.QueryString["id"] != "" && (string)Request.QueryString["action"] == "update")
            {
                if (txtirregularity.Text == "")
                {
                    c.Id_irregularity = Request.QueryString["id"].ToString();
                    DataTable dt = c.Select_Data();
                    btnirregularity.Text = "Update";
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (dr[0].ToString() == c.Id_irregularity)
                        {
                            txtirregularity.Text = dr[1].ToString();

                        }
                    }
                }
            }

        }



        //----------------------------------------------------------
        //if (!Page.IsPostBack)
        //{
        //    Fill_Data();
        //}
        //else
        //{
        //    if ((string)Request.QueryString["id"] != "" && (string)Request.QueryString["action"] == "delete")
        //    {
        //        c.Id_Site = Request.QueryString["id"].ToString();
        //        c.Delete_Data();
        //        Fill_Data();
        //    }

        //    if ((string)Request.QueryString["id"] != "" && (string)Request.QueryString["action"] == "update")
        //    {
        //        if (txtsite.Text == "")
        //        {
        //            c.Id_Site = Request.QueryString["id"].ToString();
        //            DataTable dt = c.Select_Data();
        //            btnadd.Text = "Update";
        //            foreach (DataRow dr in dt.Rows)
        //            {
        //                if (dr[0].ToString() == c.Id_irregularity )
        //                {
        //                    txtsite.Text = dr[1].ToString();

        //                }
        //            }
        //        }
        //    }
        //}
    }
   
    public void cleardata()
    {
        txtirregularity.Text = "";
    }

    protected void btnirregularity_Click(object sender, EventArgs e)
    {
        //c.irregularity_type = txtirregularity.Text;


        //if (btnirregularity.Text == "Add")
        //{

        //    if (Convert.ToInt64(c.Insert_Data()) > 0)
        //    {
        //        cleardata();
        //        Fill_Data();
        //    }
        //}

        //else if (btnirregularity.Text == "Update")
        //{

        //    c.irregularity_type = Request.QueryString["id"].ToString();
        //    c.Update_Data();
        //    cleardata();
        //    Response.Redirect("~/Master/irregularity.aspx");

        //}
        c.irregularity_type  = txtirregularity.Text;
        if (btnirregularity.Text == "Add")
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
        else if (btnirregularity.Text == "Update")
        {

            c.Id_irregularity = Request.QueryString["id"].ToString();
            c.Update_Data();
            cleardata();
            Response.Redirect("~/Master/irregularity.aspx");
        }
    }
}
