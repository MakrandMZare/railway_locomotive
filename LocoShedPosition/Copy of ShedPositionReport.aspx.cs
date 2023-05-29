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

public partial class LocoShedPosition_ShedPositionReport : System.Web.UI.Page
{
    Cls_DBConnection cdb = new Cls_DBConnection();
    ViewShedPostionReport objViewShedPositionRpt = new ViewShedPostionReport();


    public void Fill_OutAge()
    {
        Cls_Master_Outage c1 = new Cls_Master_Outage();
        Cls_Outage_Sub1 c2 = new Cls_Outage_Sub1();
        Cls_OutAge_Sub2 c3 = new Cls_OutAge_Sub2();
        Cls_Monthly_Outage c4 = new Cls_Monthly_Outage();
        Cls_Outage_Holding c5 = new Cls_Outage_Holding();
        Cls_Outage_Cum c6 = new Cls_Outage_Cum();
        c1.Locotype = "1";
        c4.Id_Outage = c1.returnmaxMonthlyOutage().ToString();
        gvMonthlyOutage.DataSource = c4.Select_DataById_1();
        gvMonthlyOutage.DataBind();
        c1.OutageDate = System.DateTime.Now.Month.ToString() + "/" + System.DateTime.Now.Day.ToString() + "/" + System.DateTime.Now.Year.ToString();
        DataTable dt = c1.Select_DataById_1();
        if (dt.Rows.Count > 0)
        {
            c4.Id_Outage = dt.Rows[0][0].ToString();
            //gvMonthlyOutage.DataSource = c4.Select_DataById_1();
            //gvMonthlyOutage.DataBind();


            c1.Id_Outage = dt.Rows[0][0].ToString();
            DataTable dt1 = c1.Select_DataById_Sub3_1("BG");
            txtTar1.Text = dt1.Rows[0][1].ToString();
            // txtNet.Text = dt1.Rows[0][2].ToString();
            // txtNet.Text = lblNetBGTotal.Text;
            txtFois.Text = dt1.Rows[0][3].ToString();
            dt1 = c1.Select_DataById_Sub3_1("MG");
            txtMGTar1.Text = dt1.Rows[1][1].ToString();
            // txtMGNet1.Text = dt1.Rows[1][2].ToString();
            // txtMGNet1.Text = lblNetBGTotal.Text;
            txtFois.Text = dt1.Rows[1][3].ToString();

            c6.Id_Outage = dt.Rows[0][0].ToString();
            DataTable dt4 = c6.Select_DataById_1("BG");
            txtTar.Text = dt4.Rows[0][2].ToString();
            txtAct.Text = dt4.Rows[0][3].ToString();
            txtDead1.Text = dt4.Rows[0][4].ToString();
            dt4 = c6.Select_DataById_1("MG");
            txtTar2.Text = dt4.Rows[1][2].ToString();
            txtact2.Text = dt4.Rows[1][3].ToString();
            txtDead2.Text = dt4.Rows[1][4].ToString();
            c5.Id_Outage = dt.Rows[0][0].ToString();
            DataTable dt5 = c5.Select_DataById_1("BG");
            txtBGHoldingBook.Text = dt5.Rows[0][7].ToString();
            txtBGHoldingEff.Text = dt5.Rows[0][6].ToString();
            dt5 = c5.Select_DataById_1("MG");
            txtMGHoldingBook.Text = dt5.Rows[1][7].ToString();
            txtMGHoldingEff.Text = dt5.Rows[1][6].ToString();

            c2.Id_Outage = dt.Rows[0][0].ToString();
            DataTable dt2 = c2.Select_DataById_1("MG");
            txtsbihrBG.Text = dt2.Rows[1][1].ToString();

            txtsbilrBG.Text = dt2.Rows[1][2].ToString();

            txtsbiurBG.Text = dt2.Rows[1][3].ToString();

            txtDeadBG.Text = dt2.Rows[1][4].ToString();

            txtOtherDivBG.Text = dt2.Rows[1][5].ToString();

            txtLieOverBG.Text = dt2.Rows[1][6].ToString();
            lblNetBG.Text = Convert.ToString(Convert.ToDouble(dt2.Rows[1][1].ToString()) + Convert.ToDouble(dt2.Rows[1][2].ToString()) + Convert.ToDouble(dt2.Rows[1][3].ToString()) + Convert.ToDouble(dt2.Rows[1][4].ToString()) + Convert.ToDouble(dt2.Rows[1][5].ToString()) - Convert.ToDouble(dt2.Rows[1][6].ToString()));
            //lblNetBGTotal.Text = string.Format("{0:f3}",(Convert.ToString(Convert.ToDecimal(lblNetBG.Text) / 24));
            lblNetBGTotal.Text = String.Format("{0:0.00}", Convert.ToDecimal(lblNetBG.Text) / 24);
            //.Substring(0,3);
            dt2 = c2.Select_DataById_1("BG");

            txtsbihrMG.Text = dt2.Rows[0][1].ToString();

            txtsbilrMG.Text = dt2.Rows[0][2].ToString();

            txtsbiurMG.Text = dt2.Rows[0][3].ToString();

            txtDeadMG.Text = dt2.Rows[0][4].ToString();

            txtOtherDivMG.Text = dt2.Rows[0][5].ToString();

            txtLieOverMG.Text = dt2.Rows[0][6].ToString();

            lblNetMG.Text = Convert.ToString(Convert.ToDouble(dt2.Rows[0][1].ToString()) + Convert.ToDouble(dt2.Rows[0][2].ToString()) + Convert.ToDouble(dt2.Rows[0][3].ToString()) + Convert.ToDouble(dt2.Rows[0][4].ToString()) + Convert.ToDouble(dt2.Rows[0][5].ToString()) - Convert.ToDouble(dt2.Rows[0][6].ToString()));
            //   lblNetMGTotal.Text= Convert.ToString(Convert.ToDecimal(lblNetMG.Text)/ 24);
            lblNetMGTotal.Text = String.Format("{0:0.00}", (Convert.ToDecimal(lblNetMG.Text) / 24));

            //txtNet.Text = lblNetBGTotal.Text;
            txtNet.Text = String.Format("{0:0.00}", Convert.ToDecimal(lblNetBGTotal.Text));
            txtMGNet1.Text = lblNetMGTotal.Text;

            c3.Id_Outage = dt.Rows[0][0].ToString();
            DataTable dt3 = c3.Select_DataById_1();
            txt1.Text = dt3.Rows[0][1].ToString();
            txt2.Text = dt3.Rows[0][2].ToString();
            txt3.Text = dt3.Rows[0][3].ToString();
            txt4.Text = dt3.Rows[0][4].ToString();
            txt5.Text = dt3.Rows[0][5].ToString();
            txt6.Text = dt3.Rows[0][6].ToString();

            //c4.Id_Outage = dt.Rows[0][0].ToString();
            //gvMonthlyOutage.DataSource = c4.Select_DataById_1();
            //gvMonthlyOutage.DataBind();

        }

    }
    public string ChangeMonthInLetter(string m, string y)
    {
        switch (Convert.ToInt16(m))
        {
            case 1:
                return "Jan '" + y;
                break;
            case 2:
                return "Feb '" + y;
                break;
            case 3:
                return "Mar '" + y;
                break;
            case 4:
                return "Apr '" + y;
                break;
            case 5:
                return "May '" + y;
                break;
            case 6:
                return "June '" + y;
                break;
            case 7:
                return "July '" + y;
                break;
            case 8:
                return "Aug '" + y;
                break;
            case 9:
                return "Sept '" + y;
                break;
            case 10:
                return "Oct '" + y;
                break;
            case 11:
                return "Nov '" + y;
                break;
            case 12:
                return "Dec '" + y;
                break;
            default:
                return "Invalid Month";
                break;


        }
    }
    protected void gvMonthlyOutage_OnRowDataBound(object sender, GridViewRowEventArgs e)
    {
        //if (e.Row.RowType == DataControlRowType.DataRow)
        //{
        //    Label l = (Label)e.Row.FindControl("lblMonth");
        //    l.Text = ChangeMonthInLetter(DataBinder.Eval(e.Row.DataItem, "Month").ToString(), DataBinder.Eval(e.Row.DataItem, "Year").ToString());
        //    Label target = (Label)e.Row.FindControl("lblTarget");
        //    Label actual = (Label)e.Row.FindControl("lblActual");

        //    // decimal diff = Convert.ToDecimal((Convert.ToDecimal(target.Text) - Convert.ToDecimal(actual.Text))/100);
        //    if (target.Text == "0")
        //    {

        //    }
        //    if (target.Text != "0")
        //    {
        //        decimal diff = Convert.ToDecimal(((Convert.ToDecimal(target.Text) - Convert.ToDecimal(actual.Text)) * 100) / Convert.ToDecimal(target.Text));
        //        Label diffa = (Label)e.Row.FindControl("lblDiff");
        //        //  diffa.Text  = diff.ToString();
        //        string ans = diff.ToString();
        //        //   diffa.Text = ans.Remove(5);
        //        diffa.Text = ans.Remove(5);
        //    }
        //}
    }
    public void Transfer_LineMessage_To_TemporaryRepor()
    {
        //this will transfer line message to temporary message after 24 hrs.
        Cls_jos_Railway_Loco_LineMsg c = new Cls_jos_Railway_Loco_LineMsg();
        DataTable dt = c.Get_LineMessageEnterBeforeDay();
        foreach (DataRow dr in dt.Rows)
        {
            Cls_jos_railway_Loco_Temporary_Repair c1 = new Cls_jos_railway_Loco_Temporary_Repair();
            c1.Generation_Date = System.DateTime.Now.Month.ToString() + "/" + System.DateTime.Now.Day.ToString() + "/" + System.DateTime.Now.Year.ToString();
            //c1.Id_Loco = dt.Rows[0][1].ToString();
            //c1.Id_Site = dt.Rows[0][4].ToString();
            //c1.Id_SiteSection = dt.Rows[0][5].ToString();
            //c1.Reason = dt.Rows[0][6].ToString();
            //c1.Remarks = "--";
            //c1.Insert_Data();
            ////Make LineMessage unavailable
            //c.Id_Loco_Linemsg = dt.Rows[0][0].ToString();

            c1.Id_Loco = dr[1].ToString();
            c1.Id_Site = dr[4].ToString();
            c1.Id_SiteSection = dr[5].ToString();
            c1.Reason = dr[6].ToString();
            c1.Remarks = "--";
            c1.Insert_Data();
            //Make LineMessage unavailable
            c.Id_Loco_Linemsg = dr[0].ToString();
            c.Make_Unavailable();
        }
    }
    //Save_OutageInrptOutage
    public void btnSave_OnClick(object sender, EventArgs e)
    {
        Cls_Shed_PositionReport crptTempRepair = new Cls_Shed_PositionReport();
        Cls_jos_railway_Loco_Temporary_Repair TempRepair1 = new Cls_jos_railway_Loco_Temporary_Repair();
        jos_railway_loco_Schedule_TimeTable c = new jos_railway_loco_Schedule_TimeTable();
        DataTable dt = c.Get_ScheduleArisingForMonthFromCurrentDate();
        DataTable dtt = c.Get_ScheduleArisingForMonthBeforeCurrentDate();
        dl1.DataSource = dt;
        dl1.DataBind();
        DataTable temp = c.Get_OverdueScheduleLoco(dtt);
        dl2.DataSource = temp;
        dl2.DataBind();
        foreach (DataRow dr in temp.Rows)
        {
            crptTempRepair.ReportDate = System.DateTime.Now.Month.ToString() + "/" + System.DateTime.Now.Day.ToString() + "/" + System.DateTime.Now.Year.ToString();
            //dl2 will insert in rpt_dl1
            //      crptTempRepair.rpt_dl1(dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), crptTempRepair.Insert_Data().ToString());
        }
        foreach (DataRow dr in dt.Rows)
        {
            crptTempRepair.ReportDate = System.DateTime.Now.Month.ToString() + "/" + System.DateTime.Now.Day.ToString() + "/" + System.DateTime.Now.Year.ToString();

            //       crptTempRepair.rpt_dl11(dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), crptTempRepair.Insert_Data().ToString());
        }
        Cls_Shed_PositionReport crptTempRepair_2 = new Cls_Shed_PositionReport();
        DataTable dt1 = c.Get_ScheduleArisingForMonthFORO1FromCurrentDate();
        DataTable dtt1 = c.Get_ScheduleArisingForMonthFORO1BeforeCurrentDate();
        gv4.DataSource = dt1;
        gv4.DataBind();
        foreach (DataRow dr in dt1.Rows)
        {
            crptTempRepair_2.ReportDate = System.DateTime.Now.Month.ToString() + "/" + System.DateTime.Now.Day.ToString() + "/" + System.DateTime.Now.Year.ToString();
            //1 st
            //      crptTempRepair_2.rpt_o1_1(dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), crptTempRepair.Insert_Data().ToString());
        }
        Cls_Shed_PositionReport crptTempRepair_3 = new Cls_Shed_PositionReport();
        DataTable temp1 = c.Get_OverdueScheduleLocoFor1(dtt1);

        gv5.DataSource = temp1;
        gv5.DataBind();
        foreach (DataRow dr in temp1.Rows)
        {
            crptTempRepair_3.ReportDate = System.DateTime.Now.Month.ToString() + "/" + System.DateTime.Now.Day.ToString() + "/" + System.DateTime.Now.Year.ToString();
            //
            //        crptTempRepair_3.rpt_o1_2(dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), crptTempRepair.Insert_Data().ToString());
        }
        string a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20, a21, a22, a23, a24, a25, a26, a27, a28, a29, a30, a31, a32, a33, a34, a35;
        a1 = txtBGHoldingBook.Text;

        a2 = txtBGHoldingEff.Text;
        a3 = txtTar1.Text;
        a4 = txtNet.Text;
        a5 = txtFois.Text;
        a6 = txtDead1.Text;
        a7 = txtMGHoldingBook.Text;
        a8 = txtMGHoldingEff.Text;
        a9 = txtMGTar1.Text;
        a10 = txtMGNet1.Text;
        a11 = txtTar2.Text;
        a12 = txtact2.Text;
        a13 = txtDead2.Text;
        a14 = txtsbihrMG.Text;
        a15 = txtsbihrBG.Text;
        a16 = txtsbilrMG.Text;
        a17 = txtsbilrBG.Text;
        a18 = txtsbiurMG.Text;
        a19 = txtsbiurBG.Text;
        a20 = txtDeadMG.Text;
        a21 = txtDeadBG.Text;
        a22 = txtOtherDivMG.Text;
        a23 = txtOtherDivBG.Text;
        a24 = txtLieOverMG.Text;
        a25 = txtLieOverBG.Text;
        a26 = lblNetMG.Text;
        a27 = lblNetMGTotal.Text;
        a28 = lblNetBG.Text;
        a29 = lblNetBGTotal.Text;
        a30 = txt1.Text;
        a31 = txt2.Text;
        a32 = txt3.Text;
        a33 = txt4.Text;
        a34 = txt5.Text;
        a35 = txt6.Text;
        crptTempRepair.ReportDate = System.DateTime.Now.Month.ToString() + "/" + System.DateTime.Now.Day.ToString() + "/" + System.DateTime.Now.Year.ToString();
        //       TempRepair1.Save_OutageInrptOutage(a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20, a21, a22, a23, a24, a25, a26, a27, a28, a29, a30, a31, a32, a33, a34, a35, crptTempRepair.Insert_Data().ToString());

        //Cls_Shed_PositionReport crptTempRepair = new Cls_Shed_PositionReport();
        //foreach (GridViewRow gr1 in gvshed.Rows)
        foreach (GridViewRow gr1 in TempRepair.Rows)
        {
            DataTable dt2 = new DataTable();
            dt2 = crptTempRepair.Get_SavedReportId();
            if (gr1.RowType == DataControlRowType.DataRow)
            {
                Label l1, l2, l3, l4, l5 = new Label();
                l1 = (Label)gr1.FindControl("Label6");
                l2 = (Label)gr1.FindControl("Label1");
                l3 = (Label)gr1.FindControl("Label2");
                l4 = (Label)gr1.FindControl("Label3");
                l5 = (Label)gr1.FindControl("Label4");
                if (dt2.Rows.Count > 0)
                {
                    string rptid = dt2.Rows[0][0].ToString();
                    //               TempRepair1.Save_TempRepair(l1.Text, l2.Text, l3.Text, l4.Text, l5.Text, rptid);
                }
                else
                {
                    crptTempRepair.ReportDate = System.DateTime.Now.Month.ToString() + "/" + System.DateTime.Now.Day.ToString() + "/" + System.DateTime.Now.Year.ToString();
                    //                TempRepair1.Save_TempRepair(l1.Text, l2.Text, l3.Text, l4.Text, l5.Text, crptTempRepair.Insert_Data().ToString());

                }
            }
        }

        Cls_jos_railway_shed_pos3 Linemessage = new Cls_jos_railway_shed_pos3();
        Cls_Shed_PositionReport crpt = new Cls_Shed_PositionReport();

        Cls_jos_railway_loco_in WDG4 = new Cls_jos_railway_loco_in();
        Cls_Shed_PositionReport crptWDG = new Cls_Shed_PositionReport();
        foreach (GridViewRow gr4 in gvshed.Rows)
        {
            DataTable dt3 = new DataTable();
            dt3 = crptWDG.Get_SavedReportId();
            if (gr4.RowType == DataControlRowType.DataRow)
            {
                //12 ( LocoNo,  LODate,  Train,  DueSchedule,  ADate, ATime, LOC,  LFR,  PDC,  REL, Remarks, Id_ShedPosition_rpt)
                Label l1, l2, l3, l4, l5, l6, l7, l8, l9, l10, l11 = new Label();
                l1 = (Label)gr4.FindControl("Label1");
                l2 = (Label)gr4.FindControl("Label2");
                l3 = (Label)gr4.FindControl("Labe3");
                l4 = (Label)gr4.FindControl("Label4");
                l5 = (Label)gr4.FindControl("Label6");
                l6 = (Label)gr4.FindControl("Label5");
                l7 = (Label)gr4.FindControl("Label7");
                l8 = (Label)gr4.FindControl("Label8");
                l9 = (Label)gr4.FindControl("Label9");
                l10 = (Label)gr4.FindControl("Label10");
                l11 = (Label)gr4.FindControl("Label11");
                if (dt3.Rows.Count > 0)
                {
                    string rptid = dt3.Rows[0][0].ToString();

                    //          WDG4.Save_LocoWDG(l1.Text, l2.Text, l3.Text, l4.Text, l5.Text, l6.Text, l7.Text, l8.Text, l9.Text, l10.Text, l11.Text, rptid);
                }
                else
                {
                    crptWDG.ReportDate = System.DateTime.Now.Month.ToString() + "/" + System.DateTime.Now.Day.ToString() + "/" + System.DateTime.Now.Year.ToString();
                    //              WDG4.Save_LocoWDG(l1.Text, l2.Text, l3.Text, l4.Text, l5.Text, l6.Text, l7.Text, l8.Text, l9.Text, l10.Text, l11.Text, crptWDG.Insert_Data().ToString());
                }
            }
        }

        // this is for monthly outage entry
        foreach (GridViewRow gr5 in gvMonthlyOutage.Rows)
        {
            DataTable dt5 = new DataTable();
            dt5 = crptWDG.Get_SavedReportId();
            if (gr5.RowType == DataControlRowType.DataRow)
            {
                Label l1, l2, l3 ,l4= new Label();
                l1 = (Label)gr5.FindControl("lblMonth");
                l2 = (Label)gr5.FindControl("lblTarget");
                l3 = (Label)gr5.FindControl("lblActual");
                l4 = (Label)gr5.FindControl("lblDiff");
               
                if (dt5.Rows.Count > 0)
                {
                    string rptid1 = dt5.Rows[0][0].ToString();

                         WDG4.Insert_rpt_monthly_outage(l1.Text, l2.Text, l3.Text, l4.Text, rptid1);
                }
                else
                {
                    crptWDG.ReportDate = System.DateTime.Now.Month.ToString() + "/" + System.DateTime.Now.Day.ToString() + "/" + System.DateTime.Now.Year.ToString();
                               WDG4.Insert_rpt_monthly_outage(l1.Text, l2.Text, l3.Text, l4.Text,  crptWDG.Insert_Data().ToString());
                }
            }
        }
        foreach (GridViewRow gr in gvlinemsg2.Rows)
        {
            DataTable dt4 = new DataTable();
            dt4 = crpt.Get_SavedReportId();
            if (gr.RowType == DataControlRowType.DataRow)
            {
                Label l1, l2, l3, l4, l5, l6 = new Label();
                l1 = (Label)gr.FindControl("Label1");
                string[] str1 = new string[10];
                str1 = l1.Text.Split('-');
                string LocoNo, LocoDate;
                LocoNo = str1[0];
                LocoDate = l1.Text.Substring(LocoNo.Length + 1, 10);

                l2 = (Label)gr.FindControl("Label2");
                l3 = (Label)gr.FindControl("Labe3");
                l4 = (Label)gr.FindControl("Label4");
                l5 = (Label)gr.FindControl("Label5");
                l6 = (Label)gr.FindControl("Label6");
                //l7 = (Label)gr.FindControl("Label7");
                if (dt4.Rows.Count > 0)
                {
                    string rptid = dt.Rows[0][0].ToString();
                    //          Linemessage.Save_LineMessage(LocoNo, LocoDate, l2.Text, l3.Text, l4.Text, l5.Text, l6.Text, rptid);
                }
                else
                {
                    crpt.ReportDate = System.DateTime.Now.Month.ToString() + "/" + System.DateTime.Now.Day.ToString() + "/" + System.DateTime.Now.Year.ToString();
                    //         Linemessage.Save_LineMessage(LocoNo, LocoDate, l2.Text, l3.Text, l4.Text, l5.Text, l6.Text, crpt.Insert_Data().ToString());
                }
            }
        }

        //----------------------------------
        foreach (GridViewRow gr in gvlinemsg1.Rows)
        {
            DataTable dt5 = new DataTable();
            dt5 = crpt.Get_SavedReportId();
            if (gr.RowType == DataControlRowType.DataRow)
            {
                Label l1, l2, l3, l5 = new Label();
                l1 = (Label)gr.FindControl("Label1");
                l2 = (Label)gr.FindControl("Label2");
                l3 = (Label)gr.FindControl("Label3");
                // l4 = (Label)gr.FindControl("Label4");
                l5 = (Label)gr.FindControl("Label5");
                //l6 = (Label)gr.FindControl("Label6");
                //l7 = (Label)gr.FindControl("Label7");
                if (dt5.Rows.Count > 0)
                {
                    string rptid = dt.Rows[0][0].ToString();
                    //            Linemessage.Save_LineMessage1(l1.Text, l2.Text, l3.Text, l5.Text, rptid);
                }
                else
                {
                    crpt.ReportDate = System.DateTime.Now.Month.ToString() + "/" + System.DateTime.Now.Day.ToString() + "/" + System.DateTime.Now.Year.ToString();
                    //           Linemessage.Save_LineMessage1(l1.Text, l2.Text, l3.Text,l5.Text, crpt.Insert_Data().ToString());
                }
            }
        }


    }
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
    public void Delete_LineMessage1_Data()
    {
        Cls_jos_Railway_Loco_LineMsg c = new Cls_jos_Railway_Loco_LineMsg();
        if ((string)Request.QueryString["LineMessage1Id"] != null)
        {
            c.Id_Loco_Linemsg = Request.QueryString["LineMessage1Id"].ToString();
            c.Delete_Data();
        }
    }
    public void Delete_LineMessage2_Data()
    {
        Cls_jos_railway_shed_pos3 c = new Cls_jos_railway_shed_pos3();
        if ((string)Request.QueryString["LineMessage2Id"] != null)
        {
            c.id_shed_Pos3 = Request.QueryString["LineMessage2Id"].ToString();
            c.Delete_Data();
        }

    }
    public void Delete_Temporary_Data()
    {
        Cls_jos_railway_Loco_Temporary_Repair c = new Cls_jos_railway_Loco_Temporary_Repair();
        if ((string)Request.QueryString["TemporaryId"] != null)
        {
            c.Id_Loco_Temp_Repair = Request.QueryString["TemporaryId"].ToString();
            c.Delete_Data();
        }
    }
   
    public void FillShed_Data()
    {
        Cls_jos_railway_loco_in c = new Cls_jos_railway_loco_in();
        gvshed.DataSource = c.Get_ShedPositionReport();
        gvshed.DataBind();
    }
    public void FillShed_Data_Date_Wise()
    {
        //Cls_jos_railway_loco_in c = new Cls_jos_railway_loco_in();
        //gvshed.DataSource = c.Get_ShedPositionReport_Date_Wise();
        //gvshed.DataBind();
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
        gvlinemsg1.DataSource = c.Select_Data();
        gvlinemsg1.DataBind();
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

        gvlinemsg2.DataSource = c.Select_Data();
        gvlinemsg2.DataBind();
        //if (gvlinemsg2.Rows.Count > 0)
        //{
        //    btnPrint.Visible = true;
        //}
        //else
        //{ btnPrint.Visible = false; }


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

        TempRepair.DataSource = c.Select_Data();
        TempRepair.DataBind();
        //if (TempRepair.Rows.Count > 0)
        //{
        //    btnPrint.Visible = true;
        //}
        //else
        //{
        //    btnPrint.Visible = false;
        //}

        //gvLineMessage2.DataSource = c.Select_Data();
        //gvLineMessage2.DataBind();


    }
    //public void FillLocoMovement_Data()
    //{
    //    Cls_jos_railway_Loco_Movements c = new Cls_jos_railway_Loco_Movements();
    //    if (txtDate.Text == "")
    //    {
    //        c.GenerationDate = DateTime.Today.Month.ToString() + "/" + DateTime.Today.Day.ToString() + "/" + DateTime.Today.Year.ToString();
    //    }
    //    else
    //    {
    //        c.GenerationDate = txtDate.Text.Substring(3, 2) + "/" + txtDate.Text.Substring(0, 2) + "/" + txtDate.Text.Substring(6, 4);
    //    }
    //    gvLocoMovements.DataSource = c.Select_Data2();
    //    gvLocoMovements.DataBind();

    //}
    public void Fill_LocoScheduleArisingData()
    {
        //Fill schedule arisin except O1
        jos_railway_loco_Schedule_TimeTable c = new jos_railway_loco_Schedule_TimeTable();
        Cls_Shed_PositionReport crptTempRepair = new Cls_Shed_PositionReport();
        DataTable dt = c.Get_ScheduleArisingForMonthFromCurrentDate();
        DataTable dtt = c.Get_ScheduleArisingForMonthBeforeCurrentDate();
        dl1.DataSource = dt;
        dl1.DataBind();
        //foreach (DataRow dr in dt.Rows)
        //{
        //crptTempRepair.ReportDate = System.DateTime.Now.Month.ToString() + "/" + System.DateTime.Now.Day.ToString() + "/" + System.DateTime.Now.Year.ToString();

        //crptTempRepair.rpt_o1_2(dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), crptTempRepair.Insert_Data().ToString());
        //}
        if (dl1.Items.Count > 0)
        {
            lbl9.Visible = true;
            lbl9.Text = " SCHEDULE ARISING IN THE MONTH OF " + System.DateTime.Now.ToString("Y").ToUpper();
        }
        else
        {
            //lbl9.Visible = false;
            lbl9.Visible = true;
            lbl9.Text = " SCHEDULE ARISING IN THE MONTH OF " + System.DateTime.Now.ToString("Y").ToUpper();

        }
        Cls_Shed_PositionReport crptTempRepair_1 = new Cls_Shed_PositionReport();
        DataTable temp = c.Get_OverdueScheduleLoco(dtt);
        dl2.DataSource = temp;
        dl2.DataBind();
        //  foreach (DataRow dr in temp.Rows)
        //  {
        //crptTempRepair_1.ReportDate = System.DateTime.Now.Month.ToString() + "/" + System.DateTime.Now.Day.ToString() + "/" + System.DateTime.Now.Year.ToString();

        // crptTempRepair_1.rpt_dl1(dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), crptTempRepair.Insert_Data().ToString());
        //   }
        if (dl2.Items.Count > 0)
        {
            lbl10.Visible = true;
            lbl10.Text = " OVERDUE SCHEDULE LOCO IN THE MONTH OF " + System.DateTime.Now.ToString("Y").ToUpper();
        }
        else
        {
            //lbl10.Visible = false;
            lbl10.Visible = true;
            lbl10.Text = " OVERDUE SCHEDULE LOCO IN THE MONTH OF " + System.DateTime.Now.ToString("Y").ToUpper();
        }
        //Fill schedule arising of O1
        Cls_Shed_PositionReport crptTempRepair_2 = new Cls_Shed_PositionReport();
        DataTable dt1 = c.Get_ScheduleArisingForMonthFORO1FromCurrentDate();
        DataTable dtt1 = c.Get_ScheduleArisingForMonthFORO1BeforeCurrentDate();
        gv4.DataSource = dt1;
        gv4.DataBind();
        //foreach (DataRow dr in temp.Rows)
        //{
        //crptTempRepair_2.ReportDate = System.DateTime.Now.Month.ToString() + "/" + System.DateTime.Now.Day.ToString() + "/" + System.DateTime.Now.Year.ToString();

        //crptTempRepair_2.rpt_o1_1(dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), crptTempRepair.Insert_Data().ToString());
        //}
        if (gv4.Items.Count > 0)
        {
            lbl7.Visible = true;
            lbl7.Text = " SCHEDULE O1 ARISING FOR THE MONTH OF " + System.DateTime.Now.ToString("Y").ToUpper();
        }
        else
        {
            // lbl7.Visible = false;
            lbl7.Visible = true;
            lbl7.Text = " SCHEDULE O1 ARISING FOR THE MONTH OF " + System.DateTime.Now.ToString("Y").ToUpper();

        }
        Cls_Shed_PositionReport crptTempRepair_3 = new Cls_Shed_PositionReport();
        DataTable temp1 = c.Get_OverdueScheduleLocoFor1(dtt1);

        gv5.DataSource = temp;
        gv5.DataBind();
        //foreach (DataRow dr in temp1.Rows)
        //{
        //crptTempRepair_3.ReportDate = System.DateTime.Now.Month.ToString() + "/" + System.DateTime.Now.Day.ToString() + "/" + System.DateTime.Now.Year.ToString();

        //crptTempRepair_3.rpt_o1_1(dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), crptTempRepair.Insert_Data().ToString());
        //}
        if (gv5.Items.Count > 0)
        {
            lbl8.Visible = true;
            lbl8.Text = " OVERDUE SCHEDULE LOCO FOR THE MONTH OF " + System.DateTime.Now.ToString("Y").ToUpper() + "FOR O1";
        }
        else
        {
            //lbl8.Visible = false;
            lbl8.Visible = true;
            lbl8.Text = " OVERDUE SCHEDULE LOCO FOR THE MONTH OF " + System.DateTime.Now.ToString("Y").ToUpper() + "FOR O1";
        }
    }
    //public void Fill_LocoScheduleArisingData()
    //{
    //    //Fill schedule arisin except O1
    //    jos_railway_loco_Schedule_TimeTable c = new jos_railway_loco_Schedule_TimeTable();
    //    DataTable dt = c.Get_ScheduleArisingForMonth();
    //    gv4.DataSource = dt;
    //    gv4.DataBind();
    //    if (gv4.Items.Count > 0)
    //    {
    //        lbl7.Visible = true;
    //        lbl7.Text = " SCHEDULE ARISING FOR THE MONTH OF " + System.DateTime.Now.ToString("Y").ToUpper();
    //    }
    //    else
    //    {
    //        lbl7.Visible = false;
    //    }

    //    gv5.DataSource = c.Get_OverdueScheduleLoco(dt);
    //    gv5.DataBind();
    //    if (gv5.Items.Count > 0)
    //    {
    //        lbl8.Visible = true;
    //        lbl8.Text = " OVERDUE SCHEDULE LOCO FOR THE MONTH OF " + System.DateTime.Now.ToString("Y").ToUpper();
    //    }
    //    else
    //    {
    //        lbl8.Visible = false;
    //    }
    //    //Fill schedule arising of O1

    //    DataTable dt1 = c.Get_ScheduleArisingForMonthFORO1();
    //    dl1.DataSource = dt1;
    //    dl1.DataBind();
    //    if (dl1.Items.Count > 0)
    //    {
    //        lbl9.Visible = true;
    //        lbl9.Text = " SCHEDULE O1 ARISING FOR THE MONTH OF " + System.DateTime.Now.ToString("Y").ToUpper();
    //    }
    //    else
    //    {
    //        lbl9.Visible = false;
    //    }

    //    dl2.DataSource = c.Get_OverdueScheduleLoco(dt);
    //    dl2.DataBind();
    //    if (dl2.Items.Count > 0)
    //    {
    //        lbl10.Visible = true;
    //        lbl10.Text = " OVERDUE SCHEDULE LOCO FOR THE MONTH OF " + System.DateTime.Now.ToString("Y").ToUpper() + "FOR O1";
    //    }
    //    else
    //    {
    //        lbl10.Visible = false;
    //    }
    //}
    public void Fill_OverdueScheduleloco(DataTable dt)
    {
        jos_railway_loco_Schedule_TimeTable c = new jos_railway_loco_Schedule_TimeTable();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if ((string)Request.QueryString["LineMessage1Id"] != "" && (string)Request.QueryString["action"] == "delete")
        {
            Delete_LineMessage1_Data();
        }
        if ((string)Request.QueryString["LineMessage2Id"] != "" && (string)Request.QueryString["action"] == "delete")
        {
            Delete_LineMessage2_Data();
        }
        if ((string)Request.QueryString["TemporaryId"] != "" && (string)Request.QueryString["action"] == "delete")
        {
            Delete_Temporary_Data();
        }
        Transfer_LineMessage_To_TemporaryRepor();
        if (!Page.IsPostBack)
        {
            //Fill_OutAge();
            //FillShed_Data();
            //FillLineMessage1_Data();
            //FillLineMessage2_Data();
            ////FillLocoMovement_Data();
            //FillTempararyRepair_Data();
            //Fill_LocoScheduleArisingData();
            //editcheckbox_OnCheckedChanged(sender, e);

            //Make header lable visible / Invisible according to data filled in gridview
            if (gvshed.Rows.Count > 0)
            {
                lbl1.Visible = true;
            }
            else
            {
                //lbl1.Visible = false;
                lbl1.Visible = true;
            }

            if (gvlinemsg1.Rows.Count > 0)
            {
                //  lbl2.Visible = true;
            }
            else
            {
                // lbl2.Visible = false;
                // lbl2.Visible = true;
            }

            if (gvlinemsg2.Rows.Count > 0)
            {
                lbl3.Visible = true;
            }
            else
            {
                //lbl3.Visible = false;
                lbl3.Visible = true;
            }

            if (TempRepair.Rows.Count > 0)
            {
                lbl4.Visible = true;
            }
            else
            {
                //lbl4.Visible = false;
                lbl4.Visible = true;
            }
        }


    }

    public void fill_gvShed()
    {
        gvshed.DataSource = objViewShedPositionRpt.View_WDG4();
        gvshed.DataBind();
    }
    //public void fill_WDG4()
    //{
    //    gvLineMessage.DataSource = objViewShedPositionRpt.View_WDG4();
    //    gvLineMessage.DataBind();
    //}
    public void fill_gvlinemsg2()
    {
        //gvlinemsg2.DataSource = objViewShedPositionRpt.View_DeadOnLine();
        //gvlinemsg2.DataBind();
        //gvlinemsg2_1.DataSource = objViewShedPositionRpt.View_DeadOnLine();
        //gvlinemsg2_1.DataBind();
    }
    //public void fill_Locomovement()
    //{
    //    gvLineMessage.DataSource = objViewShedPositionRpt.View_WDG4();
    //    gvLineMessage.DataBind();
    //}
    protected void btnShow_OnClick(object sender, EventArgs e)
    {
        if (txtDate.Text != null)
        {
            p1.Visible = true;
            Page2.Visible = true;
            Fill_Data_DateWise(txtDate.Text);
            
        }
    }
    public void Fill_Data_DateWise(string RDate)
    {
        Cls_jos_railway_loco_in c = new Cls_jos_railway_loco_in();
        if (RDate != "")
        {

            RDate = RDate.Substring(6, 4) + "-" + RDate.Substring(3, 2) + "-" + RDate.Substring(0, 2);

            //gvshed1.DataSource = c.Get_ShedPositionReport_Date_Wise(RDate);
            //gvshed1.DataBind();

            gvshed.DataSource = c.Get_ShedPositionReport_Date_Wise(RDate);
            gvshed.DataBind();

            //Get_DeadOnLine_Date_Wise

            //gvlinemsg2_1.DataSource = c.Get_DeadOnLine_Date_Wise(RDate);
            //gvlinemsg2_1.DataBind();

            //gvshed1.DataSource = c.Get_ShedPositionReport_Date_Wise(RDate);
            // gvshed1.DataBind();

            //gvtemprepair.DataSource = c.Get_temprepair_Date_Wise(RDate);
            //gvtemprepair.DataBind();

            //gvtemp1.DataSource = c.Get_temprepair_Date_Wise(RDate);
            //gvtemp1.DataBind();

            TempRepair.DataSource = c.Get_temprepair_Date_Wise(RDate);
            TempRepair.DataBind();

            gvMonthlyOutage.DataSource = c.Get_Monthly_outage_Date_Wise(RDate);
            gvMonthlyOutage.DataBind();

            //gvmonthly_outage1.DataSource = c.Get_Monthly_outage_Date_Wise(RDate);
            //gvmonthly_outage1.DataBind();

            dl2.DataSource = c.Get_dl2_Date_Wise(RDate);
            dl2.DataBind();

            dl1.DataSource = c.Get_dl1_Date_Wise(RDate);
            dl1.DataBind();

            gv5.DataSource = c.Get_gv5_Date_Wise(RDate);
            gv5.DataBind();

            gv4.DataSource = c.Get_gv4_Date_Wise(RDate);
            gv4.DataBind();
            c.bgh1 = txtBGHoldingBook.Text;
            c.bgh2 = txtBGHoldingEff.Text;
            c.bgf1 = txtTar1.Text;
            c.bgf2 = txtNet.Text;
            c.bgf3 = txtFois.Text;
            c.bgd = txtDead1.Text;
            c.mgh1 = txtMGHoldingBook.Text;
            c.mgh2 = txtMGHoldingEff.Text;
            c.mgf1 = txtMGTar1.Text;
            c.mgf2 = txtMGNet1.Text;
            c.mgf3 = txtTar2.Text;
            c.mgf4 = txtact2.Text;
            c.mfd = txtDead2.Text;
            //--------------------------------------------------------------
            c.mghr = txtsbihrMG.Text;
            c.bghr = txtsbihrBG.Text;
            c.mglr = txtsbilrMG.Text;
            c.bglr = txtsbilrBG.Text;
            c.mgur = txtsbiurMG.Text;
            c.bgur = txtsbiurBG.Text;
            c.mgdead = txtDeadMG.Text;
            c.bgdead = txtDeadBG.Text;
            c.mgdiv = txtOtherDivMG.Text;
            c.bgdiv = txtOtherDivBG.Text;
            c.mglie = txtLieOverMG.Text;
            c.bglie = txtLieOverBG.Text;
            c.mgnet1 = lblNetMG.Text;
            c.mgnet2 = lblNetMGTotal.Text;
            c.bgnet1 = lblNetBG.Text;
            c.bgnet2 = lblNetBGTotal.Text;
            c.mgsr = txt1.Text;
            c.mgloc = txt2.Text;
            c.mggear = txt3.Text;
            c.mgcompress = txt4.Text;
            c.mgfuel = txt5.Text;
            c.mgrunning = txt6.Text;
            c.Get_outage_Date_Wise(RDate);

        }


    }
    protected void btnPrint_Click(object sender, ImageClickEventArgs e)
    {
        if (gvlinemsg1.Rows.Count > 0)
        {
            gvlinemsg1.Columns[gvlinemsg1.Columns.Count - 1].Visible = false;
        }
        if (gvlinemsg2.Rows.Count > 0)
        {
            gvlinemsg2.Columns[gvlinemsg2.Columns.Count - 1].Visible = false;

        }
        if (TempRepair.Rows.Count > 0)
        {
            TempRepair.Columns[TempRepair.Columns.Count - 1].Visible = false;

        }

        PrintHelper.PrintWebControl(p1, string.Empty, 0, Request.Url.ToString(), " SHED POSITION ");
    }

   
    //protected void btnPrint_Click(object sender, ImageClickEventArgs e)
    //{
    //    if (gvlinemsg1.Rows.Count > 0)
    //    {
    //        gvlinemsg1.Columns[gvlinemsg1.Columns.Count - 1].Visible = false;
    //    }
    //    if (gvlinemsg2.Rows.Count > 0)
    //    {
    //        gvlinemsg2.Columns[gvlinemsg2.Columns.Count - 1].Visible = false;

    //    }
    //    if (TempRepair.Rows.Count > 0)
    //    {
    //        TempRepair.Columns[TempRepair.Columns.Count - 1].Visible = false;

    //    }

    //    PrintHelper.PrintWebControl(p1, string.Empty, 0, Request.Url.ToString(), " SHED POSITION ");
    //}
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        PrintHelper.PrintWebControl(Page2, string.Empty, 0, Request.Url.ToString(), " SHED POSITION ");
    }
    protected void gv4_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
