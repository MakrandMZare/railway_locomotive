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

public partial class mstrloco : System.Web.UI.Page
{
    Cls_Master_Loco_Type c = new Cls_Master_Loco_Type();
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
        if (!Page.IsPostBack)
        {
            Fill_Data();
        }
        else
        {
            if ((string)Request.QueryString["id"] != "" && (string)Request.QueryString["action"] == "delete")
            {
                c.id_ltype   = Request.QueryString["id"].ToString();
                c.Delete_Data();
                Fill_Data();
            }

            if ((string)Request.QueryString["id"] != "" && (string)Request.QueryString["action"] == "update")
            {
                if (txtloco.Text == "")
                {
                    c.id_ltype  = Request.QueryString["id"].ToString();
                    DataTable dt = c.Select_Data();
                    btnadd.Text = "Update";
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (dr[0].ToString() == c.id_ltype )
                        {
                            txtloco.Text = dr[1].ToString();

                        }
                    }
                }
                else
                {
                    if ((string)Request.QueryString["id"] != "" && (string)Request.QueryString["action"] == "update")
                    {
                        c.id_ltype  = Request.QueryString["id"].ToString();
                        c.loco_type   = txtloco.Text;
                        c.Update_Data();
                        Fill_Data();
                    }
                }

            }


            if ((string)Request.QueryString["id"] != "" && (string)Request.QueryString["action"] == "edit")
            {
                c.id_ltype  = Request.QueryString["id"].ToString();
                c.Update_Data();
                Fill_Data();
            }
        }

    }
    protected void btnadd_Click(object sender, EventArgs e)
    {
        c.loco_type  = txtloco.Text.ToUpper();


        if (btnadd.Text == "Add")
        {
            if(!c.IsDataExists()){
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

            //c.id_med  = Request.QueryString["id_med"].ToString();
            //c.Update_Data();
            Response.Redirect("~/mstrloco.aspx?id=" + Request.QueryString["id"].ToString() + "&action=update");

        }

    }
    public void cleardata()
    {
        txtloco.Text = "";

    }

}


