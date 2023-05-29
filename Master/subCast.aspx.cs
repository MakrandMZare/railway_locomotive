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

public partial class subCast : System.Web.UI.Page
{
    Cls_jos_railway_mst_sub_caste c= new Cls_jos_railway_mst_sub_caste();
    protected void Fill_Data()
    {

        GridView1.DataSource = c.Select_Data();
        GridView1.DataBind();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
    //    if (!Page.IsPostBack)
    //    {
    //        Fill_Data();
    //    }
    //    else
    //    {
    //        if ((string)Request.QueryString["id"] != "" && (string)Request.QueryString["action"] == "delete")
    //        {
    //            c.id_s_caste  = Request.QueryString["id"].ToString();
    //            c.Delete_Data();
    //            Fill_Data();
    //        }

    //        if ((string)Request.QueryString["id"] != "" && (string)Request.QueryString["action"] == "update")
    //        {
    //            if (txtsubcast.Text == "")
    //            {
    //                c.id_s_caste = Request.QueryString["id"].ToString();
    //                DataTable dt = c.Select_Data();
    //                btnadd.Text = "Update";
    //                foreach (DataRow dr in dt.Rows)
    //                {
    //                    if (dr[0].ToString() == c.id_s_caste)
    //                    {
    //                        txtsubcast.Text = dr[2].ToString();

    //                    }
    //                }
    //            }
    //            else
    //            {
    //                if ((string)Request.QueryString["id"] != "" && (string)Request.QueryString["action"] == "update")
    //                {
    //                    c.id_s_caste = Request.QueryString["id"].ToString();
    //                    c.sub_caste  = txtsubcast.Text;
    //                    c.Update_Data();
    //                    Fill_Data();
    //                }
    //            }

    //        }


    //        if ((string)Request.QueryString["id"] != "" && (string)Request.QueryString["action"] == "edit")
    //        {
    //            c.id_s_caste = Request.QueryString["id"].ToString();
    //            c.Update_Data();
    //            Fill_Data();
    //        }
      
if (!Page.IsPostBack)
        {
            Fill_Data();
        }
        else
        {
            if ((string)Request.QueryString["id"] != "" && (string)Request.QueryString["action"] == "delete")
            {
                c.id_s_caste  = Request.QueryString["id"].ToString();
                c.Delete_Data();
                Fill_Data();
            }

            if ((string)Request.QueryString["id"] != "" && (string)Request.QueryString["action"] == "update")
            {
                if (txtsubcast.Text == "" && txtmid.Text == "")
                {
                    c.id_s_caste = Request.QueryString["id"].ToString();
                    DataTable dt = c.Select_Data();
                    btnadd.Text = "Update";
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (dr[0].ToString() == c.id_s_caste)
                        {

                            txtmid.Text = dr[1].ToString(); 
                            txtsubcast.Text = dr[2].ToString();

                        }
                    }
                }
            }
        }
    }
    protected void btnadd_Click(object sender, EventArgs e)
    {
    //    c.sub_caste  = txtsubcast.Text;


    //    if (btnadd.Text == "Add")
    //    {

    //        if (Convert.ToInt64(c.Insert_Data()) > 0)
    //        {

    //            cleardata();
    //            Fill_Data();

    //        }
    //    }

    //    else if (btnadd.Text == "Update")
    //    {

    //        //c.id_s_caste  = Request.QueryString["id_s_caste"].ToString();
    //        //c.Update_Data();
    //        Response.Redirect("~/subCast.aspx?id=" + Request.QueryString["id"].ToString() + "&action=update");

    //    }

        c.mid = txtmid.Text.ToUpper();
        c.sub_caste  = txtsubcast.Text;

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

            c.id_s_caste  = Request.QueryString["id"].ToString();
            c.Update_Data();
            cleardata();
            Response.Redirect("~/Master/subCast.aspx");
        }

    }
    public void cleardata()
    {
        txtsubcast.Text = "";
        txtmid.Text = "";

    }

}
