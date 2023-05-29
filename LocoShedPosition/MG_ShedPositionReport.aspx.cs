using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Railway;
using System.Data.SqlClient;

public partial class LocoShedPosition_MG_ShedPositionReport : System.Web.UI.Page
{
    Cls_DBConnection cdb = new Cls_DBConnection();
    public Int64 SelectLocoInId(string id)
    {
        SqlCommand cmd = new SqlCommand("SELECT MAX(id_loco_in) FROM jos_railway_loco_in WHERE loco_id=" + id, cdb.cnn);
        cmd.Connection.Open();
        Int64 m = Convert.ToInt64(cmd.ExecuteScalar());
        cmd.Connection.Close();
        return m;
    }
    public Int64 Find_Locoin(string id)
    {
        SqlCommand cmd = new SqlCommand("SELECT COUNT(loco_id) FROM jos_railway_loco_in WHERE loco_id=" + id, cdb.cnn);
        cmd.Connection.Open();
        Int64 m = Convert.ToInt64(cmd.ExecuteScalar());
        cmd.Connection.Close();
        return m;
    }
    public Int64 Find_Locoout(string id)
    {
        SqlCommand cmd = new SqlCommand("SELECT COUNT(loco_id) FROM jos_railway_loco_out WHERE loco_id=" + id, cdb.cnn);
        cmd.Connection.Open();
        Int64 m = Convert.ToInt64(cmd.ExecuteScalar());
        cmd.Connection.Close();
        return m;
    }

    protected void editcheckbox_OnCheckedChanged(object sender, EventArgs e)
    {
        if (editcheckbox.Checked == false)
        {
            //Make Action Panel Invisible in gridview
            //if (gvlinemsg1.Rows.Count > 0)
            //{
            //    gvlinemsg1.Columns[gvlinemsg1.Columns.Count - 1].Visible = false;
            //}
            //if (gvlinemsg2.Rows.Count > 0)
            //{
            //    gvlinemsg2.Columns[gvlinemsg2.Columns.Count - 1].Visible = false;
            //}
            //if (gvLocoMovements.Rows.Count > 0)
            //{
            //    gvLocoMovements.Columns[gvLocoMovements.Columns.Count - 1].Visible = false;
            //}
            //if (TempRepair.Rows.Count > 0)
            //{
            //    TempRepair.Columns[TempRepair.Columns.Count - 1].Visible = false;
            //}


        }
        else
        {
            //Make Action Panel Visible in gridview
            //if (gvlinemsg1.Rows.Count > 0)
            //{
            //    gvlinemsg1.Columns[gvlinemsg1.Columns.Count - 1].Visible = true;
            //}
            //if (gvlinemsg2.Rows.Count > 0)
            //{
            //    gvlinemsg2.Columns[gvlinemsg2.Columns.Count - 1].Visible = true;
            //}
            //if (gvLocoMovements.Rows.Count > 0)
            //{
            //    gvLocoMovements.Columns[gvLocoMovements.Columns.Count - 1].Visible = true;
            //}
            //if (TempRepair.Rows.Count > 0)
            //{
            //    TempRepair.Columns[TempRepair.Columns.Count - 1].Visible = true;
            //}
        }
    }
    public void FillShed_Data()
    {
        Cls_jos_railway_loco_in c = new Cls_jos_railway_loco_in();
        gvshed.DataSource = c.MG_Get_ShedPositionReport();
        gvshed.DataBind();
    }
    public void FillLineMessage1_Data()
    {
        Cls_jos_Railway_Loco_LineMsg c = new Cls_jos_Railway_Loco_LineMsg();
        if (txtDate.Text == "")
        {
            c.Generation_Date = DateTime.Today.Month.ToString() + "/" + DateTime.Today.Day.ToString() + "/" + DateTime.Today.Year.ToString();
        }
        else
        {
            c.Generation_Date = txtDate.Text.Substring(3, 2) + "/" + txtDate.Text.Substring(0, 2) + "/" + txtDate.Text.Substring(6, 4);
        }
        //gvlinemsg1.DataSource = c.Select_Data();
        //gvlinemsg1.DataBind();
    }
    public void FillLineMessage2_Data()
    {

        Cls_jos_railway_shed_pos3 c = new Cls_jos_railway_shed_pos3();

        if (txtDate.Text == "")
        {
            DateTime d = DateTime.Today;
            c.Generationdate = d.Month.ToString() + "/" + d.Day.ToString() + "/" + d.Year.ToString();

        }
        else
        {
            c.Generationdate = txtDate.Text.Substring(3, 2).ToString() + "-" + txtDate.Text.Substring(0, 2).ToString() + "/" + txtDate.Text.Substring(6, 4).ToString();

        }

        //gvlinemsg2.DataSource = c.Select_Data();
        //gvlinemsg2.DataBind();
        


    }
    public void FillTempararyRepair_Data()
    {
        Cls_jos_railway_Loco_Temporary_Repair c = new Cls_jos_railway_Loco_Temporary_Repair();
        Cls_jos_railway_shed_pos3 c2 = new Cls_jos_railway_shed_pos3();
        if (txtDate.Text == "")
        {
            DateTime d = DateTime.Today;
            c.Generation_Date = d.Month.ToString() + "/" + d.Day.ToString() + "/" + d.Year.ToString();
            c2.Generationdate = d.Month.ToString() + "/" + d.Day.ToString() + "/" + d.Year.ToString();
        }
        else
        {
            c.Generation_Date = txtDate.Text.Substring(3, 2).ToString() + "-" + txtDate.Text.Substring(0, 2).ToString() + "/" + txtDate.Text.Substring(6, 4).ToString();
            c.Generation_Date = txtDate.Text.Substring(3, 2).ToString() + "-" + txtDate.Text.Substring(0, 2).ToString() + "/" + txtDate.Text.Substring(6, 4).ToString();
        }

        //TempRepair.DataSource = c.Select_Data();
        //TempRepair.DataBind();
        


    }
    public void FillLocoMovement_Data()
    {
        Cls_jos_railway_Loco_Movements c = new Cls_jos_railway_Loco_Movements();
        if (txtDate.Text == "")
        {
            c.GenerationDate = DateTime.Today.Month.ToString() + "/" + DateTime.Today.Day.ToString() + "/" + DateTime.Today.Year.ToString();
        }
        else
        {
            c.GenerationDate = txtDate.Text.Substring(3, 2) + "/" + txtDate.Text.Substring(0, 2) + "/" + txtDate.Text.Substring(6, 4);
        }
        //gvLocoMovements.DataSource = c.Select_Data2();
        //gvLocoMovements.DataBind();

    }
    public void Fill_LocoScheduleArisingData()
    {
        jos_railway_loco_Schedule_TimeTable c = new jos_railway_loco_Schedule_TimeTable();
        DataTable dt = c.MG_Get_ScheduleArisingForMonth();
        gv4.DataSource = dt;
        gv4.DataBind();
        if (gv4.Rows.Count > 0)
        {
            lbl7.Visible = true;
            lbl7.Text = " SCHEDULE ARISING FOR THE MONTH OF " + System.DateTime.Now.ToString("Y").ToUpper();
        }
        else
        {
            lbl7.Visible = false;
        }

        gv5.DataSource = c.Get_OverdueScheduleLoco(dt); ;
        gv5.DataBind();
        if (gv5.Rows.Count > 0)
        {
            lbl8.Visible = true;
            lbl8.Text = " OVERDUE SCHEDULE LOCO FOR THE MONTH OF " + System.DateTime.Now.ToString("Y").ToUpper();
        }
        else
        {
            lbl8.Visible = false;
        }
    }
    public void Fill_OverdueScheduleloco(DataTable dt)
    {
        jos_railway_loco_Schedule_TimeTable c = new jos_railway_loco_Schedule_TimeTable();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            FillShed_Data();
            //FillLineMessage1_Data();
            //FillLineMessage2_Data();
            //FillLocoMovement_Data();
            //FillTempararyRepair_Data();
            Fill_LocoScheduleArisingData();
            editcheckbox_OnCheckedChanged(sender, e);
            //Make header lable visible / Invisible according to data filled in gridview
            if (gvshed.Rows.Count > 0)
            {
                lbl1.Visible = true;
            }
            else
            {
                lbl1.Visible = false;
            }

            //if (gvlinemsg1.Rows.Count > 0)
            //{
            //    lbl2.Visible = true;
            //}
            //else
            //{
            //    lbl2.Visible = false;
            //}

            //if (gvlinemsg2.Rows.Count > 0)
            //{
            //    lbl3.Visible = true;
            //}
            //else
            //{
            //    lbl3.Visible = false;
            //}

            //if (TempRepair.Rows.Count > 0)
            //{
            //    lbl4.Visible = true;
            //}
            //else
            //{
            //    lbl4.Visible = false;
            //}

            //if (gvLocoMovements.Rows.Count > 0)
            //{
            //    lbl5.Visible = true;
            //}
            //else
            //{
            //    lbl5.Visible = false;
            //}
        }
    }
    protected void btnShow_OnClick(object sender, EventArgs e)
    {
        if (txtDate.Text != null)
        {
            FillShed_Data();
            FillLineMessage1_Data();
            FillLineMessage2_Data();
            FillLocoMovement_Data();
            FillTempararyRepair_Data();
            editcheckbox_OnCheckedChanged(sender, e);
        }
    }
    protected void btnPrint_Click(object sender, ImageClickEventArgs e)
    {
        //if (gvlinemsg1.Rows.Count > 0)
        //{
        //    gvlinemsg1.Columns[gvlinemsg1.Columns.Count - 1].Visible = false;
        //}
        //if (gvlinemsg2.Rows.Count > 0)
        //{
        //    gvlinemsg2.Columns[gvlinemsg2.Columns.Count - 1].Visible = false;

        //}
        //if (gvLocoMovements.Rows.Count > 0)
        //{
        //    gvLocoMovements.Columns[gvLocoMovements.Columns.Count - 1].Visible = false;

        //}
        //if (TempRepair.Rows.Count > 0)
        //{
        //    TempRepair.Columns[TempRepair.Columns.Count - 1].Visible = false;

        //}

        PrintHelper.PrintWebControl(p1, string.Empty, 0, Request.Url.ToString(), " SHED POSITION ");
    }
    protected void gvshed_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void gv4_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
