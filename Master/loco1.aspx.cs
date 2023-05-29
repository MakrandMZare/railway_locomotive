using System;
using System.Collections;
using System.Configuration;
using System.Data;
//using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
//using System.Xml.Linq;
using Railway;


public partial class Master_loco1 : System.Web.UI.Page
{

    Cls_jos_railway_mst_loco c = new Cls_jos_railway_mst_loco();
    DataTable dt1 = new DataTable();

    //public void Fill_Assembly()
    //{
    //    Cls_jos_railway_mst_Assembly c = new Cls_jos_railway_mst_Assembly();
    //    ddlAssembly.DataSource = c.Select_Data();
    //    ddlAssembly.DataValueField = "id_mst_assem";
    //    ddlAssembly.DataTextField = "name";
    //    ddlAssembly.DataBind();
    //}
    //public void Fill_Supplier()
    //{
    //    Cls_jos_railway_mst_supplier c = new Cls_jos_railway_mst_supplier();
    //    ddlSupplier.DataSource = c.Select_Data();
    //    ddlSupplier.DataTextField = "s_name";
    //    ddlSupplier.DataValueField = "id_supp";
    //    ddlSupplier.DataBind();
    //}

    public void Fill_AssemblyGridview()
    {
        Cls_jos_railway_mst_Assembly c = new Cls_jos_railway_mst_Assembly();
        gvAssembly.DataSource = c.Select_Data();
        gvAssembly.DataBind();

    }
    public void Fill_Data()
    {
        Cls_jos_railway_mst_loco c = new Cls_jos_railway_mst_loco();
        c.id_mst_loco = Request.QueryString["id"].ToString();
        DataTable dt =  c.Select_DataById();
        if (dt.Rows.Count > 0)
        {
        ddlclass.SelectedIndex = ddlclass.Items.IndexOf(ddlclass.Items.FindByText(dt.Rows[0][7].ToString()));
            txtloco.Text = dt.Rows[0][3].ToString();
            ddlshedid.SelectedIndex  = ddlshedid.Items.IndexOf(ddlshedid.Items.FindByText(dt.Rows[0][8].ToString()));
            ddlnetive.SelectedIndex = ddlnetive.Items.IndexOf(ddlnetive.Items.FindByText(dt.Rows[0][4].ToString()));
            txtdoc.Text = dt.Rows[0][2].ToString();
            txtpoh.Text = dt.Rows[0][5].ToString();
            txtrecive.Text = dt.Rows[0][6].ToString();
        }
        Fill_Assembly_Data();

    }
    public void Fill_Assembly_Data()
    {
        //Fill_AssemblyGridview();
        if ((string)Request.QueryString["id"] != "")
        {
            Cls_jos_railway_loco_assembly c = new Cls_jos_railway_loco_assembly();
            c.mid = Request.QueryString["id"].ToString();
            DataTable dt1 = c.Select_DataByLocoId();
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                DropDownList ddla = (DropDownList)gvAssembly.Rows[i].FindControl("ddlAssembly");
                DropDownList ddls = (DropDownList)gvAssembly.Rows[i].FindControl("ddlSupplier");
                Label lblid = (Label)gvAssembly.Rows[i].FindControl("lblid");
                if (ddla != null && ddls != null)
                {
                    if (ddla.SelectedIndex == 0)
                    {
                        ddla.SelectedIndex = ddla.Items.IndexOf(ddla.Items.FindByValue(dt1.Rows[i][0].ToString()));
                    }
                    if (ddls.SelectedIndex == 0)
                    {
                        ddls.SelectedIndex = ddls.Items.IndexOf(ddls.Items.FindByValue(dt1.Rows[i][2].ToString()));
                    }
                lblid.Text = dt1.Rows[i][4].ToString();
                }
            }
            
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        //dt1.Columns.Add("sn", typeof(System.Int64));
        //dt1.Columns.Add("a1", typeof(System.String));
        //dt1.Columns.Add("a2", typeof(System.String));
        //dt1.Columns.Add("a3", typeof(System.String));
        //dt1.Columns.Add("a4", typeof(System.String));
        if (!Page.IsPostBack)
        {
            fill_class_ddl();
            fillShed();
            Fill_AssemblyGridview();
            //Fill_Assembly();
            //Fill_Supplier();
        }
        
            if ((string)Request.QueryString["id"] != "" && (string)Request.QueryString["action"] == "update")
            {
                Fill_Data();
                btnsave.Text = "UPDATE";
                
            }
        
        
        
        //DataRow dr = dt1.NewRow();
        //dr["sn"] = dt1.Rows.Count + 1;
        //dr["a1"] = ddlAssembly.SelectedValue.ToString();
        //dr["a2"] = ddlAssembly.SelectedItem.ToString();
        //dr["a3"] = ddlSupplier.SelectedValue.ToString();
        //dr["a4"] = ddlSupplier.SelectedItem.ToString();
        ////dt1.Rows.Add(dr);
        //gv1.DataSource = dt1;
        //gv1.DataBind();
        //Session["dd"] = dt1;



        //if (Request.QueryString["action"] == "Remove")
        //{
        //    dt1 = (DataTable)Session["dd"];
        //    if (dt1.Rows.Count != 0)
        //    {
        //        dt1.Rows.RemoveAt(dt1.Rows.Count - 1);
        //    }
        //    gv1.DataSource = dt1;
        //    gv1.DataBind();
        //}
        //if (Request.QueryString["action"] == "Insert")
        //{
        //    dt1 = (DataTable)Session["dd"];
        //    DataRow dr = dt1.NewRow();
        //    dr["sn"] = dt1.Rows.Count + 1;
        //    dr["a1"] = ddlAssembly.SelectedValue.ToString();
        //    dr["a2"] = ddlAssembly.SelectedItem.ToString();
        //    dr["a3"] = ddlSupplier.SelectedValue.ToString();
        //    dr["a4"] = ddlSupplier.SelectedItem.ToString();
        //    dt1.Rows.Add(dr);

        //    gv1.DataSource = dt1;
        //    gv1.DataBind();
        //}


    }
    public void Insert_LocoSchedule(string m)
    {

        //DateTime schdate = Convert.ToDateTime(txtdoc.Text);

        //Cls_jos_railway_loco_type_schedule c1 = new Cls_jos_railway_loco_type_schedule();
        //c1.loco_id = ddlclass.SelectedValue.ToString();
        //DataTable ScheduleData = c1.Select_Data();
        //if (ScheduleData.Rows.Count > 0)
        //{
        //    foreach (DataRow dr in ScheduleData.Rows)
        //    {
        //        c.Schedule_Id = dr[0].ToString();
        //        schdate = schdate.AddDays(Convert.ToInt64(dr[2].ToString()));
        //        string str = schdate.ToShortDateString().Replace("-", "/");
        //        c.ScheduleDate = str.Substring(3, 2).ToString() + "/" + str.Substring(0, 2).ToString() + "/" + str.Substring(6, 4).ToString();
        //        c.Loco_Id = m;
        //        c.Insert_Data_Loco_Schedule();
        //    }
        //}
    }
    public void Updatation()
    {
        Cls_jos_railway_mst_loco c = new Cls_jos_railway_mst_loco();
        //Cls_jos_railway_shed c1 = new Cls_jos_railway_shed();
        c.id_mst_loco = Request.QueryString["id"].ToString();
        c.locono = txtloco.Text;
        c.tid = ddlclass.SelectedValue.ToString();
        c.shed_id = ddlshedid.SelectedValue.ToString();
        c.native = ddlnetive.SelectedValue.ToString();
        if (txtdoc.Text != "")
        {
            c.doc_date = txtdoc.Text.Substring(3, 2) + "/" + txtdoc.Text.Substring(0, 2) + "/" + txtdoc.Text.Substring(6, 4);
        }
        else
        {
            c.doc_date = " " ;
        }
        if (ddlArrivalTime1.Text != "" && ddlArrivalTime2.Text != "")
        {
            c.a_time = ddlArrivalTime1.Text + ":" + ddlArrivalTime2.Text + ":00";
        }
        else
        {
            c.a_time = "";
        }
        if (txtpoh.Text != "")
        {
            c.poh_date = txtpoh.Text.Substring(3, 2) + "/" + txtpoh.Text.Substring(0, 2) + "/" + txtpoh.Text.Substring(6, 4);
        }
        else
        {
            c.poh_date = "";
        }
        if (txtrecive.Text != "")
        {
            c.rfrom = txtrecive.Text;
        }
        else
        {
            c.rfrom = "";
        }
        c.Update_Data();
        //Update Assembly data
        Cls_jos_railway_loco_assembly c1 = new Cls_jos_railway_loco_assembly();
        foreach (GridViewRow gr in gvAssembly.Rows)
        {

            DropDownList ddla = new DropDownList();
            DropDownList ddls = new DropDownList();
            ddls = (DropDownList)gr.FindControl("ddlSupplier");
            ddla = (DropDownList)gr.FindControl("ddlAssembly");
            Label lblid = (Label)gr.FindControl("lblid");
            if (ddla != null && ddls != null)
            {
                string str = ddla.SelectedIndex.ToString();
                string str1 = ddls.SelectedIndex.ToString();
                if (ddla.SelectedIndex != 0 && ddls.SelectedIndex != 0)
                {
                    if (lblid.Text != "")
                    {
                        Cls_jos_railway_loco_assembly assmobj = new Cls_jos_railway_loco_assembly();
                        assmobj.id_asembly = lblid.Text;
                        assmobj.mid = Request.QueryString["id"].ToString();
                        assmobj.id_ass = ddla.SelectedValue.ToString();
                        assmobj.id_sup = ddls.SelectedValue.ToString();
                        assmobj.Update_Data();
                    }
                    else if (lblid.Text == "")
                    {
                        Cls_jos_railway_loco_assembly assmobj = new Cls_jos_railway_loco_assembly();
                        assmobj.mid = Request.QueryString["id"].ToString();
                        assmobj.id_ass = ddla.SelectedValue.ToString();
                        assmobj.id_sup = ddls.SelectedValue.ToString();
                        assmobj.Insert_Data();
                    }
                    
                }
                else if(ddla.SelectedIndex == 0 && ddls.SelectedIndex == 0)
                {
                    if (ddla.SelectedIndex == 0)
                    {
                        ddla.BackColor = System.Drawing.Color.Red;
                    }
                    if (ddls.SelectedIndex == 0)
                    {
                        ddls.BackColor = System.Drawing.Color.Red;
                    }
                }
               
            }
        }
        //Cls_jos_railway_loco_assembly assmobj1 = new Cls_jos_railway_loco_assembly();

        //c1.Update_Data();
        Response.Redirect("~/Master/View_Loco_Master.aspx?id=" + Request.QueryString["id"].ToString());
    }

    protected void btnsave_Click(object sender, EventArgs e)
    {
        c.locono = txtloco.Text;
        c.tid = ddlclass.SelectedValue.ToString();
        c.shed_id = ddlshedid.SelectedValue.ToString();
        c.native = ddlnetive.SelectedItem.ToString();
        if (txtdoc.Text != "")
        {
            c.doc_date = txtdoc.Text.Substring(3, 2) + "/" + txtdoc.Text.Substring(0, 2) + "/" + txtdoc.Text.Substring(6, 4);
        }
        else
        {
            c.doc_date = "";
        }
        if (ddlArrivalTime1.Text != "" && ddlArrivalTime2.Text != "")
        {
            c.a_time = ddlArrivalTime1.Text + ":" + ddlArrivalTime2.Text + ":00";
        }
        else
        {
            c.a_time = "";
        }
        if (txtpoh.Text != "")
        {
            c.poh_date = txtpoh.Text.Substring(3, 2) + "/" + txtpoh.Text.Substring(0, 2) + "/" + txtpoh.Text.Substring(6, 4);
        }
        else
        {
            c.poh_date = "";
        }
        if (txtrecive.Text != "")
        {
            c.rfrom = txtrecive.Text;
        }
        else
        {
            c.rfrom = "";
        }
        if (btnsave.Text == "INSERT")
        {
            if (!c.IsDataExists())
            {
                Int64 m = c.Insert_Data();
                //Insert_LocoSchedule(m.ToString());
                foreach (GridViewRow gr in gvAssembly.Rows)
                {

                    DropDownList ddla = new DropDownList();
                    DropDownList ddls = new DropDownList();
                    ddls = (DropDownList)gr.FindControl("ddlSupplier");
                    ddla = (DropDownList)gr.FindControl("ddlAssembly");
                    if (ddla != null && ddls != null)
                    {
                        string str = ddla.SelectedIndex.ToString();
                        string str1 = ddls.SelectedIndex.ToString();
                        if (ddla.SelectedIndex != 0 && ddls.SelectedIndex != 0)
                        {
                            Cls_jos_railway_loco_assembly assmobj = new Cls_jos_railway_loco_assembly();
                            assmobj.mid = m.ToString();
                            assmobj.id_ass = ddla.SelectedValue.ToString();
                            assmobj.id_sup = ddls.SelectedValue.ToString();
                            assmobj.Insert_Data();
                        }
                        else
                        {
                            if (ddla.SelectedIndex == 0)
                            {
                                ddla.BackColor = System.Drawing.Color.Red;
                            }
                            if (ddls.SelectedIndex == 0)
                            {
                                ddls.BackColor = System.Drawing.Color.Red;
                            }
                        }
                    }
                }
            }
        }

        else if (btnsave.Text == "UPDATE")
        {
            c.id_mst_loco = Request.QueryString["id"].ToString();
            Updatation();
        }
        //Response.Redirect("~/Master/View_Loco_Master.aspx");

    }
    public void fill_class_ddl()
    {
        Cls_Master_Loco_Type c = new Cls_Master_Loco_Type();
        ddlclass.DataSource = c.Select_Data();
        ddlclass.DataTextField = "loco_type";
        ddlclass.DataValueField = "id_ltype";
        ddlclass.DataBind();
        ddlclass.Items.Insert(0, "SELECT");

    }
    public void fillShed()
    {
        Cls_jos_railway_shed c = new Cls_jos_railway_shed();
        ddlshedid.DataSource = c.Select_Data();
        ddlshedid.DataTextField = "sname";
        ddlshedid.DataValueField = "id_shed";
        ddlshedid.DataBind();
        ddlshedid.Items.Insert(0, "SELECT");
    }



    protected void ddlclass_SelectedIndexChanged(object sender, EventArgs e)
    {
        Cls_Master_Loco_Type c = new Cls_Master_Loco_Type();
        c.id_ltype = ddlclass.SelectedValue.ToString();
        lblguage.Text = "";
        lblguage.Visible = true;
        lblguage.Text = c.Get_LocoGuageByLocotype();
    }
    protected void rdo1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (rdo1.SelectedIndex == 0)
        {
            ph1.Visible = false;
        }
        else if (rdo1.SelectedIndex == 1)
        {
            ph1.Visible = true;
        }
    }
    protected void txtloco_TextChanged(object sender, EventArgs e)
    {
        Cls_jos_railway_mst_loco c = new Cls_jos_railway_mst_loco();
        //Check Wheather loco is Meter guage / Broad guage
        if (lblguage.Text == "METER GUAGE")
        {
            //Validate loco no has 4 digit or not
            if (txtloco.Text.Length == 4)
            {
                lbtnerror.Visible = false;
                c.locono = txtloco.Text;
                if (c.IsDataExists())
                {
                    lbtnerror.Visible = true;
                    lbtnerror.Text = " Loco Already Exists...!  [View]";
                }
                else
                {
                    lbtnerror.Visible = false;
                }
            }
            else
            {
                lbtnerror.Visible = true;
                lbtnerror.Text = "Locono must be 4 digits..!";
            }
        }
        else if (lblguage.Text == "BROAD GUAGE")
        {
            //Validate loco no has 5 digit or not
            if (txtloco.Text.Length == 5)
            {
                lbtnerror.Visible = false;
                c.locono = txtloco.Text;
                if (c.IsDataExists())
                {
                    lbtnerror.Visible = true;
                    lbtnerror.Text = " Loco Already Exists...!  [View]";
                }
                else
                {
                    lbtnerror.Visible = false;
                }
            }
            else
            {
                lbtnerror.Visible = true;
                lbtnerror.Text = "Locono must be 4 digits..!";
            }
        }
    }
    protected void lblerror_OnClick(object sender, EventArgs e)
    {
        Cls_jos_railway_mst_loco c = new Cls_jos_railway_mst_loco();
        if (txtloco.Text != "")
        {
            c.locono = txtloco.Text;
            Response.Redirect("~/Master/View_Loco_Master.aspx?Id=" + c.GetLocoIdByLocono());
        }
    }
    protected void gvAssembly_OnRowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            //Fill Assembly
            DropDownList ddla = new DropDownList();
            ddla = (DropDownList)e.Row.FindControl("ddlAssembly");
            if (ddla != null)
            {
                Cls_jos_railway_mst_Assembly c = new Cls_jos_railway_mst_Assembly();
                ddla.DataSource = c.Select_Data();
                ddla.DataValueField = "id_mst_assem";
                ddla.DataTextField = "name";
                ddla.DataBind();
                ddla.Items.Insert(0, "SELECT");
            }
        }
        //Fill Supplier
        DropDownList ddls = new DropDownList();
        ddls = (DropDownList)e.Row.FindControl("ddlSupplier");
        if (ddls != null)
        {
            Cls_jos_railway_mst_supplier c = new Cls_jos_railway_mst_supplier();
            ddls.DataSource = c.Select_Data();
            ddls.DataTextField = "s_name";
            ddls.DataValueField = "id_supp";
            ddls.DataBind();
            ddls.Items.Insert(0, "SELECT");

        }
    }
    protected void gvAssembly_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
