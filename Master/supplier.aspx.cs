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

public partial class supplier : System.Web.UI.Page
{
    Cls_jos_railway_mst_supplier c = new Cls_jos_railway_mst_supplier();
    protected void Fill_Data()
    {

        gv1.DataSource = c.Select_Data();
        gv1.DataBind();
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
                c.id_supp = Request.QueryString["id"].ToString();
                c.Delete_Data();
                Fill_Data();
            }

            if ((string)Request.QueryString["id"] != "" && (string)Request.QueryString["action"] == "update")
            {
                if (txtSname.Text == "")
                {
                    c.id_supp = Request.QueryString["id"].ToString();
                    DataTable dt = c.Select_Data();
                    btnadd.Text = "Update";
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (dr[0].ToString() == c.id_supp)
                        {
                            txtSname.Text = dr[1].ToString();
                            txtAddress.Text = dr[2].ToString();
                            txtPincode.Text = dr[3].ToString();
                            txtState.Text = dr[4].ToString();
                            txtDistrict.Text = dr[5].ToString();
                            txtPhone.Text = dr[6].ToString();
                            txtLandline.Text = dr[7].ToString();
                            txtMobile.Text = dr[8].ToString();
                            txtContactPerson.Text = dr[9].ToString();
                            txtWebSite.Text = dr[10].ToString();
                            txtEmailId.Text = dr[11].ToString();
                            //txtsupplier.Text = dr[1].ToString();
                            //txts_address.Text = dr[2].ToString();
                            //txtcontact.Text = dr[3].ToString();
                            ////txtComponantName.Text = dr[4].ToString();
                            //txtPLNo.Text = dr[5].ToString();
                            //txtMake.Text = dr[6].ToString();
                            //txtRate.Text = dr[7].ToString();
                            //txtWaranty.Text = dr[8].ToString();
                        }
                    }
                }
            }
        }
    }
    protected void btnadd_Click(object sender, EventArgs e)
    {


        c.contactperson = txtContactPerson.Text;
        c.emailid = txtEmailId.Text;
        c.dist = txtDistrict.Text;
        c.Landline = txtLandline.Text;
        c.mobilen = txtMobile.Text;
        c.Phone = txtPhone.Text;
        c.s_address = txtAddress.Text;
        c.s_name = txtSname.Text;
        c.s_pincode = txtPincode.Text;
        c.state = txtState.Text;
        c.webaddress = txtWebSite.Text;

        //c.s_name = txtsupplier.Text.ToUpper();
        //c.s_address = txts_address.Text.ToUpper();
        //c.s_phone_no = txtcontact.Text.ToUpper();
        //c.s_compponant_name = txtComponantName.Text.ToUpper();
        //c.s_plno = txtPLNo.Text.ToUpper();
        //c.s_make = txtMake.Text.ToUpper();
        //c.s_rate = txtRate.Text.ToUpper();
        //c.s_waranty = txtWaranty.Text.ToUpper();
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

            c.id_supp = Request.QueryString["id"].ToString();
            c.Update_Data();
            cleardata();
            Response.Redirect("~/Master/supplier.aspx");
        }

    }
    public void cleardata()
    {
        //txtsupplier.Text = "";
        //txts_address.Text = "";
        //txtcontact.Text = "";
        //txtComponantName.Text = "";
        //txtPLNo.Text = "";
        //txtMake.Text = "";
        //txtRate.Text = "";
        //txtWaranty.Text = "";

    }

}
