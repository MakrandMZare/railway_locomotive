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

public partial class shed : System.Web.UI.Page
{
    Cls_jos_railway_shed c = new Cls_jos_railway_shed();
    //protected void Page_Load(object sender, EventArgs e)
    //{

    //}
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
        //        c.id_shed  = Request.QueryString["id"].ToString();
        //        c.Delete_Data();
        //        Fill_Data();
        //    }

        //    if ((string)Request.QueryString["id"] != "" && (string)Request.QueryString["action"] == "update")
        //    {
        //        if (txtname .Text == "" && txtfname.Text == "")
        //        {
        //            c.id_shed = Request.QueryString["id"].ToString();
        //            DataTable dt = c.Select_Data();
        //            btnadd.Text = "Update";
        //            foreach (DataRow dr in dt.Rows)
        //            {
        //                if (dr[0].ToString() == c.id_shed)
        //                {
        //                    txtname .Text = dr[1].ToString();
        //                    txtfname.Text = dr[2].ToString();

        //                }
        //            }
        //        }
        //        else
        //        {
        //            if ((string)Request.QueryString["id"] != "" && (string)Request.QueryString["action"] == "update")
        //            {
        //                c.id_shed = Request.QueryString["id"].ToString();
        //                c.sname  = txtname .Text;
        //                c.FULLNAME = txtfname .Text;
        //                c.Update_Data();
        //                Fill_Data();
        //            }
        //        }

        //    }


        //    if ((string)Request.QueryString["id"] != "" && (string)Request.QueryString["action"] == "edit")
        //    {
        //        c.id_shed = Request.QueryString["id"].ToString();
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
                c.id_shed = Request.QueryString["id"].ToString();
                c.Delete_Data();
                Fill_Data();
            }

            if ((string)Request.QueryString["id"] != "" && (string)Request.QueryString["action"] == "update")
            {
                if (txtname.Text == "" && txtfname.Text == "")
                {
                    c.id_shed = Request.QueryString["id"].ToString();
                    DataTable dt = c.Select_Data();
                    btnadd.Text = "Update";
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (dr[0].ToString() == c.id_shed)
                        {
                            txtname.Text = dr[1].ToString();
                            txtfname.Text = dr[2].ToString();

                        }
                    }
                }
            }
        }
    }
    protected void btnadd_Click(object sender, EventArgs e)
    {
        //c.sname  = txtname .Text;
        //c.FULLNAME  = txtfname .Text;


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

        //    //c.id_shed  = Request.QueryString["id_shed"].ToString();
        //    //c.Update_Data();
        //    Response.Redirect("~/shed.aspx?id=" + Request.QueryString["id"].ToString() + "&action=update");

        //}
        c.sname = txtname.Text.ToUpper();
        c.FULLNAME = txtfname.Text.ToUpper();

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

            c.id_shed  = Request.QueryString["id"].ToString();
            c.Update_Data();
            cleardata();
            Response.Redirect("~/Master/shed.aspx");

        }

    }


    public void cleardata()
    {
        txtfname.Text = "";
        txtname.Text = "";

    }

}