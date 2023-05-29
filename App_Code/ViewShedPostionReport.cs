using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

/// <summary>
/// Summary description for ViewShedPostionReport
/// </summary>
public class ViewShedPostionReport : Cls_DBConnection
{
	public ViewShedPostionReport()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public DataTable  View_TempRepair()
    {
        cmd = new SqlCommand("select LocoNo, Site, Section, Reason, Remarks, Id_ShedPosition_rpt from rpt_EmdTempRepair", cnn);
        da = new SqlDataAdapter();
        dt = new DataTable();
        da.SelectCommand = cmd;
        da.Fill(dt);
        return dt;
    
    }
    public DataTable View_WDG4()
    {
       // cmd = new SqlCommand("SELECT rpt_LocoWDG4_ID, \"LocoNo\" as \"LocoNo\", \"LODate\" as \"LAST OUT DATE\", \"Train\" as \"TRAIN\", \"ADate\" as \"DATE\",\"ATime\" as \"TIME\", \"DueSchedule\" as \"DUE SCHEDULE\", LFR, LOC, PDC, REL, Remarks, Id_ShedPosition_rpt FROM  rpt_LocoWDG", cnn);
        cmd = new SqlCommand("SELECT rpt_LocoWDG4_ID, LocoNo , LODate , Train, ADate,ATime, DueSchedule, LFR, LOC, PDC, REL, Remarks, Id_ShedPosition_rpt FROM  rpt_LocoWDG", cnn);
        da = new SqlDataAdapter();
        dt = new DataTable();
        da.SelectCommand = cmd;
        da.Fill(dt);
        return dt;

    }


    

    
    public DataTable View_DeadOnLine()
    {
        //cmd = new SqlCommand("SELECT rpt_LineMessage_Id, \"LocoNo\" as \"LOCO NO\",\"LDate\" as \"DATE\", \"d_or_W\" as\"D/W\", \"TrnoLoad\" as \"TRNO\" ,\"TrnoLoad\" as \"LOAD\", Grad, \"ReportedReason\" as \"REPOTED REASON\", LastSchedule, Id_ShedPosition_rpt FROM  rpt_LineMessage", cnn);
        cmd = new SqlCommand("SELECT rpt_LineMessage_Id, LocoNo,LDate,d_or_W, TrnoLoad ,TrnoLoad, Grad, ReportedReason, LastSchedule, Id_ShedPosition_rpt FROM  rpt_LineMessage", cnn);
        da = new SqlDataAdapter();
        dt = new DataTable();
        da.SelectCommand = cmd;
        da.Fill(dt);
        return dt;

    }

    public DataTable View_LocoMovement()
    {
        cmd = new SqlCommand("SELECT Id_LocoMovement, Locono, DOA, DOC, LastOut, LastSch, RepairAttended, Div, Site, Remarks, Shed_Position_rpt, Section FROM  rpt_LocoMovement", cnn);
        da = new SqlDataAdapter();
        dt = new DataTable();
        da.SelectCommand = cmd;
        da.Fill(dt);
        return dt;

    }
}
