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
using Railway;

/// <summary>
/// Summary description for Cls_Failure_Detail
/// </summary>
public class Cls_Failure_Detail : Cls_DBConnection
{
    public Cls_Failure_Detail()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    //------------table1-----------------------
    public string IdFailureAnalysis1;
    public string IdLoco;
    public string MU_SU;
    public string MUWith;
    public string Cab;
    public string IncidentDate;
    public string Trainno;
    public string Load1;
    public string DriverName;
    public string Hq;
    public string Link;
    public string IdSite;
    public string IdSection;
    public string IdDivision;
    //------------------table2---------------
    public string IdFailureAnalysis2;
    public string IdRailway;
    public string Services;
    public string IdCategory;
    public string FailureType;
    public string IdUnit;
    public string IdWing;
    public string Overdue;
    public string Resp;
    public string Avoidable;
    public string MainAssembly;
    public string SubAssembly;
    public string ComponentBisection;
    //------------------table3---------------------
    public string IdFailureAnalysis3;
    public string not_use_of_defect;
    public string IdSupplier;
    public string Message;
    public string DateOfAttension;
    public string lastSchedule;
    public string Place;
    public string Date1;
    public string lastScheduledate;
    public string IdSupervisor;
    public string IdMechanic;
    public string Shift;
    public string CPA;
    public string LastOutDate;
    public string ShedArrivalDate;
    public string SheduleinWh;
    public string ArrivalPosition;
    public string ShedResponse;
    public string Observation;
    public string Repercussion;



    public DataTable Select_schedule()
    {
        cmd = new SqlCommand("SELECT * FROM jos_railway_loco_type_schedule", cnn);
        da = new SqlDataAdapter();
        dt = new DataTable();
        da.SelectCommand = cmd;
        da.Fill(dt);
        return dt;
    }
    public DataTable Select_Supplier()
    {
        cmd = new SqlCommand("SELECT * FROM jos_railway_mst_supplier", cnn);
        da = new SqlDataAdapter();
        dt = new DataTable();
        da.SelectCommand = cmd;
        da.Fill(dt);
        return dt;
    }
    public DataTable Select_Site()
    {
        cmd = new SqlCommand("SELECT * FROM jos_railway_mst_site", cnn);
        da = new SqlDataAdapter();
        dt = new DataTable();
        da.SelectCommand = cmd;
        da.Fill(dt);
        return dt;
    }

    public DataTable Select_Section()
    {
        cmd = new SqlCommand("SELECT * FROM jos_railway_section", cnn);
        da = new SqlDataAdapter();
        dt = new DataTable();
        da.SelectCommand = cmd;
        da.Fill(dt);
        return dt;
    }

    public DataTable Select_Division()
    {
        cmd = new SqlCommand("SELECT * FROM jos_railway_division", cnn);
        da = new SqlDataAdapter();
        dt = new DataTable();
        da.SelectCommand = cmd;
        da.Fill(dt);
        return dt;
    }


    public DataTable select_category()
    {
        cmd = new SqlCommand("SELECT * FROM jos_railway_mst_category", cnn);
        da = new SqlDataAdapter();
        dt = new DataTable();
        da.SelectCommand = cmd;
        da.Fill(dt);
        return dt;
    }

    public DataTable select_Unit()
    {
        cmd = new SqlCommand("SELECT * FROM jos_railway_mst_unit", cnn);
        da = new SqlDataAdapter();
        dt = new DataTable();
        da.SelectCommand = cmd;
        da.Fill(dt);
        return dt;
    }

    public DataTable select_wing()
    {
        cmd = new SqlCommand("SELECT * FROM jos_railway_mst_wings", cnn);
        da = new SqlDataAdapter();
        dt = new DataTable();
        da.SelectCommand = cmd;
        da.Fill(dt);
        return dt;
    }


    public Int64 Insert_Data_FailureAnalysis1NewNew()
    {
        Int64 n = 0;
        try
        {

            cmd = new SqlCommand("INSERT INTO FailureAnalysis1New(IdLoco, MU_SU, MUWith, Cab, IncidentDate, Trainno, Load1, DriverName, Hq, Link, IdSite, IdSection, IdDivision) VALUES (@IdLoco, @MU_SU, @MUWith, @Cab, @IncidentDate, @Trainno, @Load1, @DriverName, @Hq, @Link, @IdSite, @IdSection, @IdDivision) ", cnn);
            cmd.Parameters.AddWithValue("@IdLoco", this.IdLoco);
            cmd.Parameters.AddWithValue("@MU_SU", this.MU_SU);
            cmd.Parameters.AddWithValue("@MUWith", this.MUWith);
            cmd.Parameters.AddWithValue("@Cab", this.Cab);
            cmd.Parameters.AddWithValue("@IncidentDate", this.IncidentDate);
            cmd.Parameters.AddWithValue("@Trainno", this.Trainno);
            cmd.Parameters.AddWithValue("@Load1", this.Load1);
            cmd.Parameters.AddWithValue("@DriverName", this.DriverName);
            cmd.Parameters.AddWithValue("@Hq", this.Hq);
            cmd.Parameters.AddWithValue("@Link", this.Link);
            cmd.Parameters.AddWithValue("@IdSite", this.IdSite);
            cmd.Parameters.AddWithValue("@IdSection", this.IdSection);
            cmd.Parameters.AddWithValue("@IdDivision", this.IdDivision);

            cmd.Connection.Open();
            int m = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            if (m == 1)
            {
                cmd = new SqlCommand("SELECT MAX(IdFailureAnalysis1) FROM FailureAnalysis1New", cnn);
                cmd.Connection.Open();
                n = Convert.ToInt64(cmd.ExecuteScalar());
                cmd.Connection.Close();
                return n;
            }
            else
            {
                return 0;
            }
        }
        catch { throw; }
    }


    public Int64 Insert_Data_FailureAnalysis2New()
    {
        Int64 n = 0;
        try
        {
            cmd = new SqlCommand("INSERT INTO FailureAnalysis2New (IdRailway, Services, IdCategory, FailureType, IdUnit, IdWing, Overdue, Resp, Avoidable, MainAssembly, SubAssembly, ComponentBisection) VALUES (@IdRailway, @Services, @IdCategory, @FailureType, @IdUnit, @IdWing, @Overdue, @Resp, @Avoidable, @MainAssembly, @SubAssembly, @ComponentBisection)", cnn);
            cmd.Parameters.AddWithValue("@IdRailway", this.IdRailway);
            cmd.Parameters.AddWithValue("@Services", this.Services);
            cmd.Parameters.AddWithValue("@IdCategory", this.IdCategory);
            cmd.Parameters.AddWithValue("@FailureType", this.FailureType);
            cmd.Parameters.AddWithValue("@IdUnit", this.IdUnit);
            cmd.Parameters.AddWithValue("@IdWing", this.IdWing);
            cmd.Parameters.AddWithValue("@Overdue", this.Overdue);
            cmd.Parameters.AddWithValue("@Resp", this.Resp);
            cmd.Parameters.AddWithValue("@Avoidable", this.Avoidable);
            cmd.Parameters.AddWithValue("@MainAssembly", this.MainAssembly);
            cmd.Parameters.AddWithValue("@SubAssembly", this.SubAssembly);
            cmd.Parameters.AddWithValue("@ComponentBisection", this.ComponentBisection);
            cmd.Connection.Open();
            int m = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            if (m == 1)
            {
                cmd = new SqlCommand("SELECT MAX(IdFailureAnalysis2) FROM FailureAnalysis2New", cnn);
                cmd.Connection.Open();
                n = Convert.ToInt64(cmd.ExecuteScalar());
                cmd.Connection.Close();
                return n;
            }
            else
            {
                return 0;
            }

        }
        catch
        {
            throw;
        }

    }

    public Int64 Insert_Data_FailureAnalysis3New()
    {
        Int64 n = 0;
        try
        {
            cmd = new SqlCommand("INSERT INTO FailureAnalysis3New (not_use_of_defect, IdSupplier, Message, DateOfAttension, lastSchedule, Place, Date1, lastScheduledate, IdSupervisor, IdMechanic, Shift, CPA, LastOutDate, ShedArrivalDate, SheduleinWh, ArrivalPosition, ShedResponse, Observation, Repercussion) VALUES (@not_use_of_defect, @IdSupplier, @Message, @DateOfAttension, @lastSchedule, @Place, @Date1, @lastScheduledate, @IdSupervisor, @IdMechanic, @Shift, @CPA, @LastOutDate, @ShedArrivalDate, @SheduleinWh, @ArrivalPosition, @ShedResponse, @Observation, @Repercussion)", cnn);
            //cmd.Parameters.AddWithValue("@IdFailureAnalysis3",this.IdFailureAnalysis3);
            cmd.Parameters.AddWithValue("@not_use_of_defect", this.not_use_of_defect);
            cmd.Parameters.AddWithValue("@IdSupplier", this.IdSupplier);
            cmd.Parameters.AddWithValue("@Message", this.Message);
            cmd.Parameters.AddWithValue("@DateOfAttension", this.DateOfAttension);
            cmd.Parameters.AddWithValue("@lastSchedule", this.lastSchedule);
            cmd.Parameters.AddWithValue("@Place", this.Place);
            cmd.Parameters.AddWithValue("@Date1", this.Date1);
            cmd.Parameters.AddWithValue("@lastScheduledate", this.lastScheduledate);
            cmd.Parameters.AddWithValue("@IdSupervisor", this.IdSupervisor);
            cmd.Parameters.AddWithValue("@IdMechanic", this.IdMechanic);
            cmd.Parameters.AddWithValue("@Shift", this.Shift);
            cmd.Parameters.AddWithValue("@CPA", this.CPA);
            cmd.Parameters.AddWithValue("@LastOutDate", this.LastOutDate);
            cmd.Parameters.AddWithValue("@ShedArrivalDate", this.ShedArrivalDate);
            cmd.Parameters.AddWithValue("@SheduleinWh", this.SheduleinWh);
            cmd.Parameters.AddWithValue("@ArrivalPosition", this.ArrivalPosition);
            cmd.Parameters.AddWithValue("@ShedResponse", this.ShedResponse);
            cmd.Parameters.AddWithValue("@Observation", this.Observation);
            cmd.Parameters.AddWithValue("@Repercussion", this.Repercussion);
            cmd.Connection.Open();
            int m = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            if (m == 1)
            {
                cmd = new SqlCommand("SELECT MAX(IdFailureAnalysis3) FROM FailureAnalysis3New", cnn);
                cmd.Connection.Open();
                n = Convert.ToInt64(cmd.ExecuteScalar());
                cmd.Connection.Close();
                return n;
            }
            else
            {
                return 0;
            }


        }
        catch
        {
            throw;
        }


    }


    public int Delete_Data_FailureAnalysis1NewNew()
    {
        try
        {
            cmd = new SqlCommand("DELETE FROM FailureAnalysis1New  WHERE IdFailureAnalysis1=@IdFailureAnalysis1", cnn);
            cmd.Parameters.AddWithValue("@IdFailureAnalysis1", this.IdFailureAnalysis1);
            cmd.Connection.Open();
            int n = Convert.ToInt16(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            return n;
        }
        catch { throw; }
    }

    public int Delete_Data_FailureAnalysis2New()
    {
        try
        {
            cmd = new SqlCommand("DELETE FROM FailureAnalysis2New WHERE IdFailureAnalysis2=@IdFailureAnalysis2", cnn);
            cmd.Parameters.AddWithValue("@IdFailureAnalysis2", this.IdFailureAnalysis2);
            cmd.Connection.Open();
            int n = Convert.ToInt16(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            return n;
        }
        catch { throw; }
    }



    public int Update_Data_FailureAnalysis1NewNew()
    {
        try
        {
            cmd = new SqlCommand("UPDATE    FailureAnalysis1NewNew SET IdLoco =@IdLoco, MU_SU =@MU_SU, MUWith =@MUWith, Cab =@Cab , IncidentDate =@IncidentDate , Trainno =@Trainno , Load1 =@Load1 , DriverName =@DriverName , Hq =@Hq , Link =@Link , IdSite =@IdSite , IdSection =@IdSection , IdDivision =@IdDivision   WHERE IdFailureAnalysis1=IdFailureAnalysis1 ", cnn);
            cmd.Parameters.AddWithValue("@IdFailureAnalysis1", this.IdFailureAnalysis1);
            cmd.Parameters.AddWithValue("@IdLoco", this.IdLoco);
            cmd.Parameters.AddWithValue("@MU_SU", this.MU_SU);
            cmd.Parameters.AddWithValue("@MUWith", this.MUWith);
            cmd.Parameters.AddWithValue("@Cab", this.Cab);
            cmd.Parameters.AddWithValue("@IncidentDate", this.IncidentDate);
            cmd.Parameters.AddWithValue("@Trainno", this.Trainno);
            cmd.Parameters.AddWithValue("@DriverName", this.DriverName);
            cmd.Parameters.AddWithValue("@Hq", this.Hq);
            cmd.Parameters.AddWithValue("@Link", this.Link);
            cmd.Parameters.AddWithValue("@IdSite", this.IdSite);
            cmd.Parameters.AddWithValue("@IdSection", this.IdSection);
            cmd.Parameters.AddWithValue("@IdDivision", this.IdDivision);

            cmd.Connection.Open();
            int n = Convert.ToInt16(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            return n;
        }
        catch { throw; }
    }

    public int FailureAnalysis2NewNew()
    {
        try
        {
            cmd = new SqlCommand(" UPDATE    FailureAnalysis2NewNew SET  IdRailway =@IdRailway, Services =@Services , IdCategory =@IdCategory , FailureType =@FailureType , IdUnit =@IdUnit , IdWing =@IdWing , Overdue =@Overdue , Resp =@Resp , Avoidable =@Avoidable , MainAssembly =@MainAssembly , SubAssembly =@SubAssembly ,  ComponentBisection =@ComponentBisection  WHERE IdFailureAnalysis2=IdFailureAnalysis2 ", cnn);
            cmd.Parameters.AddWithValue("@IdFailureAnalysis2", this.IdFailureAnalysis2);
            cmd.Parameters.AddWithValue("@IdRailway", this.IdRailway);
            cmd.Parameters.AddWithValue("@Services", this.Services);
            cmd.Parameters.AddWithValue("@IdCategory", this.IdCategory);
            cmd.Parameters.AddWithValue("@FailureType", this.FailureType);
            cmd.Parameters.AddWithValue("@IdWing", this.IdWing);
            cmd.Parameters.AddWithValue("@Overdue", this.Overdue);
            cmd.Parameters.AddWithValue("@Resp", this.Resp);
            cmd.Parameters.AddWithValue("@Avoidable", this.Avoidable);
            cmd.Parameters.AddWithValue("@MainAssembly", this.MainAssembly);
            cmd.Parameters.AddWithValue("@SubAssembly", this.SubAssembly);
            cmd.Parameters.AddWithValue("@ComponentBisection", this.ComponentBisection);

            cmd.Connection.Open();
            int n = Convert.ToInt16(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            return n;
        }
        catch { throw; }
    }
}

