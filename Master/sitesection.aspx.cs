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

public partial class sitesection : System.Web.UI.Page
{
    Cls_jos_railway_mst_SiteSection c = new Cls_jos_railway_mst_SiteSection();
    protected void Fill_Data()
    {

        gv1.DataSource = c.Select_Data();
        gv1.DataBind();
    }
    protected void gv1_OnPageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gv1.PageIndex = e.NewPageIndex;
        Fill_Data();
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
    //            c.Id_SiteSection = Request.QueryString["id"].ToString();
    //            c.Delete_Data();
    //            Fill_Data();
    //        }

    //        if ((string)Request.QueryString["id"] != "" && (string)Request.QueryString["action"] == "update")
    //        {
    //            if (txtsitesection.Text == "")
    //            {
    //                c.Id_SiteSection  = Request.QueryString["id"].ToString();
    //                DataTable dt = c.Select_Data();
    //                btnadd.Text = "Update";
    //                foreach (DataRow dr in dt.Rows)
    //                {
    //                    if (dr[0].ToString() == c.Id_SiteSection)
    //                    {
    //                        txtsitesection.Text = dr[1].ToString();

    //                    }
    //                }
    //            }
    //            else
    //            {
    //                if ((string)Request.QueryString["id"] != "" && (string)Request.QueryString["action"] == "update")
    //                {
    //                    c.Id_SiteSection = Request.QueryString["id"].ToString();
    //                    c.SiteSectionName  = txtsitesection.Text;
    //                    c.Update_Data();
    //                    Fill_Data();
    //                }
    //            }

    //        }


    //        if ((string)Request.QueryString["id"] != "" && (string)Request.QueryString["action"] == "edit")
    //        {
    //            c.Id_SiteSection = Request.QueryString["id"].ToString();
    //            c.Update_Data();
    //            Fill_Data();
    //        }
    //    }
if (!Page.IsPostBack)
        {
            Fill_Data();
        }
        else
        {
            if ((string)Request.QueryString["id"] != "" && (string)Request.QueryString["action"] == "delete")
            {
                c.Id_SiteSection  = Request.QueryString["id"].ToString();
                c.Delete_Data();
                Fill_Data();
            }

            if ((string)Request.QueryString["id"] != "" && (string)Request.QueryString["action"] == "update")
            {
                if (txtsitesection.Text == "")
                {
                    c.Id_SiteSection = Request.QueryString["id"].ToString();
                    DataTable dt = c.Select_Data();
                    btnadd.Text = "Update";
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (dr[0].ToString() == c.Id_SiteSection)
                        {
                            txtsitesection.Text = dr[1].ToString();

                        }
                    }
                }
            }
        }
    }
    protected void btnadd_Click(object sender, EventArgs e)
    {
        //c.SiteSectionName  = txtsitesection.Text;


        //if (btnadd.Text == "Add")
        //{

        //    if (Convert.ToInt64(c.Insert_Data()) > 0)
        //    {

        //        cleardata();
        //        Fill_Data();

        //    }
        //}

        //else if (btnadd.Text == "Update")
        //{

        //    //c.Id_SiteSection  = Request.QueryString["Id_SiteSection"].ToString();
        //    //c.Update_Data();
        //    Response.Redirect("~/sitesection.aspx?id=" + Request.QueryString["id"].ToString() + "&action=update");

        //}

c.SiteSectionName   = txtsitesection.Text.ToUpper();
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

            c.Id_SiteSection  = Request.QueryString["id"].ToString();
            c.Update_Data();
            cleardata();
            Response.Redirect("~/Master/sitesection.aspx");
        }
    }
    public void cleardata()
    {
        txtsitesection.Text = "";

    }

}
