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
using Railway;
using System.Data.SqlClient;

public partial class Loco_loco_gtkm : System.Web.UI.Page
{
    Cls_bg_gtkm c = new Cls_bg_gtkm();
    public void Fill_Class()
    {
        Cls_jos_railway_loco_in c = new Cls_jos_railway_loco_in();
        ddlclass.DataSource = c.SelectLocoType();
        ddlclass.DataTextField = "loco_type";
        ddlclass.DataValueField = "id_ltype";
        ddlclass.DataBind();
        ddlclass.Items.Insert(0, "SELECT");
    }
    public void Fill_LocoNo()
    {
        if (ddlclass.SelectedIndex != 0)
        {
            Cls_jos_railway_loco_in c = new Cls_jos_railway_loco_in();
            ddlLocono.DataSource = c.Select_LocoNo(ddlclass.SelectedValue.ToString());
            ddlLocono.DataTextField = "locono";
            ddlLocono.DataValueField = "id_mst_loco";
            ddlLocono.DataBind();
            ddlLocono.Items.Insert(0, "SELECT");
        }
    }
    public void Fill_From()
    {
        ddlFrom.DataSource = c.Select_Station();
        ddlFrom.DataTextField = "station_one";
        ddlFrom.DataValueField = "id_station";
        ddlFrom.DataBind();
        ddlFrom.Items.Insert(0, "SELECT");
    }

    public void Fill_To()
    {
        ddlTo.DataSource = c.Select_Station();
        ddlTo.DataTextField = "station_two";
        ddlTo.DataValueField = "id_station";
        ddlTo.DataBind();
        ddlTo.Items.Insert(0, "SELECT");
    }
    public void ddlLocono_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlLocono.SelectedIndex != 0)
        {
            // Fill_Data();
        }
    }
    protected void ddlClass_SelectedIndexChanged(object sender, EventArgs e)
    {
        Fill_LocoNo();

    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Fill_Class();
            Fill_From();
            Fill_To();
        }

    }
    protected void btnInert_Click(object sender, EventArgs e)
    {
        c.to1 = ddlTo.SelectedValue.ToString();
        c.from1 = ddlFrom.SelectedValue.ToString();
        c.id_mst_loco = ddlLocono.SelectedValue.ToString();
        c.gtkm_date = txtDate.Text;
        c.ekm = txtEkm.Text;
        c.FuelOilCons = txtFuelOil.Text;
        c.lubeoil = txtLubeoil.Text;
        c.TrainLoad = txtLoad.Text;

        c.sfc = txtsfc.Text;
        c.lfr = txtlfr.Text;
        c.loc = txtloc.Text;
        c.gtkm = txtgtkm.Text;
        c.Insert_Data();
        Clear_Data();
    }
    protected void ddlTo_SelectedIndexChanged(object sender, EventArgs e)
    {
        //string a=Convert.ToString(c.Select_Data1(ddlTo.SelectedIndex.ToString()));
        //txtEkm.Text = a.ToString();

        DataTable dt = c.Select_Data1(ddlTo.SelectedIndex.ToString());
        string a = dt.Rows[0][3].ToString();
        txtEkm.Text = a.ToString();

    }

    protected void Clear_Data()
    {
        ddlTo.SelectedIndex = 0;
        ddlFrom.SelectedIndex = 0;
        ddlLocono.SelectedIndex = 0;
        txtDate.Text = "";
        txtEkm.Text = "";
        txtFuelOil.Text = "";
        txtLubeoil.Text = "";
        txtLoad.Text = "";
    }
    //protected void txtLoad_OnTextChanged(object sender, EventArgs e)
    //{
    //    txtTotalLoad.Text = txtLoad.Text.ToString() + 126;
    //}
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //----------------------------- load calculation === load +126
        string load = txtLoad.Text;
        int a = 126;
        string ansload = Convert.ToString(Convert.ToDecimal(a) + Convert.ToDecimal(load.ToString()));
        txtTotalLoad.Text = ansload.ToString();

        // ----------------------------gtkm calculation 

        string km = txtEkm.Text;
        string totalLoad = txtTotalLoad.Text;
        string ansgtkm = Convert.ToString(Convert.ToDecimal(km) * Convert.ToDecimal(totalLoad));
        txtgtkm.Text = ansgtkm.ToString();
        //-----------------------------SFC
        string gtkm = txtgtkm.Text;
        string fuel = txtFuelOil.Text;
        string ansSfc = Convert.ToString((Convert.ToDecimal(fuel) * 1000) / Convert.ToDecimal(gtkm));
        txtsfc.Text = ansSfc.ToString().Substring(0, 2);

        //-------------------------LFR
        string fuel1 = txtFuelOil.Text;
        string lue1 = txtLubeoil.Text;
        string ansLfr = Convert.ToString(((Convert.ToDecimal(lue1)) / (Convert.ToDecimal(fuel1))) * 100);
        txtlfr.Text = ansLfr.ToString().Substring(0, 2);

        //-------------------------LOC
        string ansLoc = Convert.ToString((Convert.ToDecimal(lue1) * 100) / Convert.ToDecimal(km));
        txtloc.Text = ansLoc.ToString().Substring(0, 2);


    }
}
