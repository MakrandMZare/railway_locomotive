using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data.SqlClient;
/// <summary>
/// Summary description for Cls_Shed_PositionReport
/// </summary>
public class Cls_Shed_PositionReport : Cls_DBConnection
{
    public string Id_ShedPosition_rpt;
    public string ReportDate;
    public Cls_Shed_PositionReport()
    {

        // TODO: Add constructor logic here

    }
    public DataTable Get_SavedReportId()
    {
        try
        {
            cmd = new SqlCommand("SELECT * FROM Saved_ShedPositionReport WHERE CONVERT(VARCHAR(10),ReportDate,101)=@ReportDate", cnn);
            cmd.Parameters.AddWithValue("@ReportDate", System.DateTime.Now.Month.ToString() + "/" + System.DateTime.Now.Day.ToString() + "/" + System.DateTime.Now.Year.ToString());
            da = new SqlDataAdapter();
            dt = new DataTable();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;
        }
        catch { throw; }
    }
    //}
    //public Int64 Insert_Data()
    //{
    //    int n = 0;
    //    try
    //    {
    //        cmd = new SqlCommand("INSERT INTO Saved_ShedPositionReport(ReportDate) VALUES(@ReportDate)", cnn);
    //        cmd.Parameters.AddWithValue("@ReportDate", this.ReportDate);
    //        cmd.Connection.Open();
    //        Int16 n =Convert.ToInt64( cmd.ExecuteNonQuery());
    //        cmd.Connection.Close();
    //        if (n == 1)
    //        {
    //            cmd = new SqlCommand("SELECT MAX(Id_ShedPosition_rpt) FROM Saved_ShedPositionReport", cnn);
    //            cmd.Connection.Open();
    //            Int64 n = Convert.ToInt64(cmd.ExecuteScalar());
    //            cmd.Connection.Close();
    //            return n;
    //        }
    //        return n;
    //    }
    //    catch { throw; }


    //}

    public Int64 Insert_Data()
    {

        try
        {
            cmd = new SqlCommand("INSERT INTO Saved_ShedPositionReport(ReportDate) VALUES(@ReportDate)", cnn);
            cmd.Parameters.AddWithValue("@ReportDate", this.ReportDate);
            cmd.Connection.Open();
            Int64 n = Convert.ToInt64(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            //if (n == 1)
            //{
            //    cmd = new SqlCommand("SELECT MAX(Id_ShedPosition_rpt) FROM Saved_ShedPositionReport", cnn);
            //    cmd.Connection.Open();
            //    Int64 n = Convert.ToInt64(cmd.ExecuteScalar());
            //    cmd.Connection.Close();
            //    return n;
            //}
            return n;
        }
        catch { throw; }


    }
    public Int64 rpt_ReportedReason_Rpt(string Id_ShedPosition, string LocoNo, string d_w, string TrainnoLoad, string Grad, string ReportedReason, string LastSchedule)
    {
        try
        {
            cmd = new SqlCommand("INSERT INTO rpt_ReportedReason(Id_ReportedReason,Id_ShedPosition,LocoNo,d_w,TrainnoLoad,Grad,ReportedReason,LastSchedule) VALUES(@Id_ReportedReason,@Id_ShedPosition,@LocoNo,@d_w,@TrainnoLoad,@Grad,@ReportedReason,@LastSchedule)", cnn);
            cmd.Parameters.AddWithValue("@Id_ShedPosition", Id_ShedPosition);
            cmd.Parameters.AddWithValue("@LocoNo", LocoNo);
            cmd.Parameters.AddWithValue("@d_w", d_w);
            cmd.Parameters.AddWithValue("@TrainnoLoad", TrainnoLoad);
            cmd.Parameters.AddWithValue("@Grad", Grad);
            cmd.Parameters.AddWithValue("@ReportedReason", ReportedReason);
            cmd.Parameters.AddWithValue("@LastSchedule", LastSchedule);
            cmd.Connection.Open();
            Int16 n = Convert.ToInt16(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            cmd = new SqlCommand("SELECT MAX() FROM rpt_ReportedReason", cnn);
            cmd.Connection.Open();
            Int64 m = Convert.ToInt64(cmd.ExecuteScalar());
            cmd.Connection.Close();
            return m;
        }
        catch { throw; }


    }
    //public Int64 Shed_Position_Rpt(string Locono,string LastOutDate,string Train,string DueSchedule,string LOC,string LFR,string PDC,string REL,string Remarks)
    //{
    //    //Insert Shed position1
    //    cmd = new SqlCommand("INSERT INTO rpt_ShedPosition1 VALUES(Locono,LastOutDate,Train,DueSchedule,LOC,LFR,PDC,REL,Remarks) VALUES (@Locono,@LastOutDate,@Train,@DueSchedule,@LOC,@LFR,@PDC,@REL,@Remarks)",cnn);

    //    cmd.Parameters.AddWithValue("@Locono",Locono);
    //    cmd.Parameters.AddWithValue("@LastOutDate",LastOutDate);
    //    cmd.Parameters.AddWithValue("@Train",Train);
    //    cmd.Parameters.AddWithValue("@DueSchedule",DueSchedule);
    //    cmd.Parameters.AddWithValue("@LOC",LOC);
    //    cmd.Parameters.AddWithValue("@LFR",LFR);
    //    cmd.Parameters.AddWithValue("@PDC",PDC);


    public Int64 rpt_dl1(string Locono,string Schedule,string ScheduleDate,string Id_ShedPosition_rpt)
    {
        try
        {
            cmd = new SqlCommand("INSERT INTO rpt_dl1(Locono, Schedule, ScheduleDate, Id_ShedPosition_rpt)VALUES (@Locono,@Schedule,@ScheduleDate,@Id_ShedPosition_rpt)", cnn);
            cmd.Parameters.AddWithValue("@Locono", Locono);
            cmd.Parameters.AddWithValue("@Schedule", Schedule);
            cmd.Parameters.AddWithValue("@ScheduleDate", ScheduleDate);
            cmd.Parameters.AddWithValue("@Id_ShedPosition_rpt", Id_ShedPosition_rpt);
            
            cmd.Connection.Open();
            Int64 n = Convert.ToInt16(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            
            return n;
        }
        catch { throw; }


    }


    
    public Int64 rpt_dl11( string Locono, string Schedule, string ScheduleDate, string Id_ShedPosition_rpt)
    {
        try
        {
            cmd = new SqlCommand("INSERT INTO rpt_dl11(Locono, Schedule, ScheduleDate, Id_ShedPosition_rpt)VALUES( @Locono, @Schedule, @ScheduleDate, @Id_ShedPosition_rpt)", cnn);
            cmd.Parameters.AddWithValue("@Locono", Locono);
            cmd.Parameters.AddWithValue("@Schedule", Schedule);
            cmd.Parameters.AddWithValue("@ScheduleDate", ScheduleDate);
            cmd.Parameters.AddWithValue("@Id_ShedPosition_rpt", Id_ShedPosition_rpt);
            
            cmd.Connection.Open();
            Int64 n = Convert.ToInt16(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            
            return n;
        }
        catch { throw; }


    }

    public Int64 rpt_o1_1(string Locono, string Schedule, string ScheduleDate, string Id_ShedPosition_rpt)
    {
        try
        {
            cmd = new SqlCommand("INSERT INTO rpt_o1_1(Locono, Schedule, ScheduleDate, Id_ShedPosition_rpt)VALUES( @Locono, @Schedule, @ScheduleDate, @Id_ShedPosition_rpt)", cnn);
            cmd.Parameters.AddWithValue("@Locono", Locono);
            cmd.Parameters.AddWithValue("@Schedule", Schedule);
            cmd.Parameters.AddWithValue("@ScheduleDate", ScheduleDate);
            cmd.Parameters.AddWithValue("@Id_ShedPosition_rpt", Id_ShedPosition_rpt);

            cmd.Connection.Open();
            Int64 n = Convert.ToInt16(cmd.ExecuteNonQuery());
            cmd.Connection.Close();

            return n;
        }
        catch { throw; }


    }

    public Int64 rpt_o1_2(string Locono, string Schedule, string ScheduleDate, string Id_ShedPosition_rpt)
    {
        try
        {
            cmd = new SqlCommand("INSERT INTO rpt_o1_1(Locono, Schedule, ScheduleDate, Id_ShedPosition_rpt)VALUES( @Locono, @Schedule, @ScheduleDate, @Id_ShedPosition_rpt)", cnn);
            cmd.Parameters.AddWithValue("@Locono", Locono);
            cmd.Parameters.AddWithValue("@Schedule", Schedule);
            cmd.Parameters.AddWithValue("@ScheduleDate", ScheduleDate);
            cmd.Parameters.AddWithValue("@Id_ShedPosition_rpt", Id_ShedPosition_rpt);

            cmd.Connection.Open();
            Int64 n = Convert.ToInt16(cmd.ExecuteNonQuery());
            cmd.Connection.Close();

            return n;
        }
        catch { throw; }


    }
}
