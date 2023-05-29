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

public partial class site : System.Web.UI.Page
{
    Cls_jos_railway_mst_site c = new Cls_jos_railway_mst_site();

    protected void Fill_Data()
    {

        GridView1.DataSource = c.Select_Data();
        GridView1.DataBind();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!Page.IsPostBack)
        //{
        //    Fill_Data();
        //}
        //else
        //{
        //    if ((string)Request.QueryString["id"] != "" && (string)Request.QueryString["action"] == "delete")
        //    {
        //        c.Id_Site  = Request.QueryString["id"].ToString();
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
        //                if (dr[0].ToString() == c.Id_Site)
        //                {
        //                    txtsite.Text = dr[1].ToString();

        //                }
        //            }
        //        }
        //        else
        //        {
        //            if ((string)Request.QueryString["id"] != "" && (string)Request.QueryString["action"] == "update")
        //            {
        //                c.Id_Site = Request.QueryString["id"].ToString();
        //                c.Site_Name  = txtsite.Text;
        //                c.Update_Data();
        //                Fill_Data();
        //            }
        //        }

        //    }


        //    if ((string)Request.QueryString["id"] != "" && (string)Request.QueryString["action"] == "edit")
        //    {
        //        c.Id_Site = Request.QueryString["id"].ToString();
        //        c.Update_Data();
        //        Fill_Data();
        //    }
        //}
        if (!Page.IsPostBack)
        {
            Fill_Data();
        }
        else
        {
            if ((string)Request.QueryString["id"] != "" && (string)Request.QueryString["action"] == "delete")
            {
                c.Id_Site  = Request.QueryString["id"].ToString();
                c.Delete_Data();
                Fill_Data();
            }

            if ((string)Request.QueryString["id"] != "" && (string)Request.QueryString["action"] == "update")
            {
                if (txtsite.Text == "")
                {
                    c.Id_Site = Request.QueryString["id"].ToString();
                    DataTable dt = c.Select_Data();
                    btnadd.Text = "Update";
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (dr[0].ToString() == c.Id_Site)
                        {
                            txtsite.Text = dr[1].ToString();

                        }
                    }
                }
            }
        }
    }
    protected void btnadd_Click(object sender, EventArgs e)
    {
    //    c.Site_Name  = txtsite.Text;


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

    //        //c.Id_Site  = Request.QueryString["Id_Site"].ToString();
    //        //c.Update_Data();
    //        Response.Redirect("~/site.aspx?id=" + Request.QueryString["id"].ToString() + "&action=update");

    //    }
        c.Site_Name  = txtsite.Text.ToUpper();
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

            c.Id_Site  = Request.QueryString["id"].ToString();
            c.Update_Data();
            cleardata();
            Response.Redirect("~/Master/site.aspx");
        }
    }
    public void cleardata()
    {
        txtsite.Text = "";

    }

}
