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
/// Summary description for Cls_Failure_detailNew
/// </summary>
public class Cls_Failure_detailNew : Cls_DBConnection
{
    public Cls_Failure_detailNew()
    {
        //
        // TODO; Add constructor logic here
        //
    }

    public string id_failure_analysis;
    public string id_mst_loco;
    public string id_loco_sch;
    public string mu_su;
    public string muWith;
    public string incidentDate;
    public string trainNo;
    public string trainLoad;
    public string trainLink;
    public string driverName;
    public string hq;
    public string site;
    public string section;
    public string division;
    public string railway;
    public string resp;
    public string failureType;
    public string wing;
    public string category;
    public string overDue;
    public string avoidable;
    public string mainAssembly;
    public string subAssembly;
    public string compoBisec;
    public string diffectiveCode;
    public string service;
    public string arrivalPosition;
    public string supervisor;
    public string shedResponce;
    public string mechanic;
    public string message;
    public string observation;
    public string repercussion;
    public string lastOutDate;
    public string shedArrivalDate;
    public string supplier;
    public string place;
    public string cpa;
    public string shift;
    public string f_date;
    public string shedInWh;
    public string dateOfAttension;
    public string lastScheduleDate;
    public string lastSchedule;

    public Int64 Insert_data()
    {
        try
        {
            cmd = new SqlCommand("INSERT INTO failure_analysis ( id_mst_loco, id_loco_sch, mu_su, muWith, incidentDate, trainNo, trainLoad, trainLink, driverName, hq, site, section, division,  railway, resp, failureType, wing, category, overDue, avoidable, mainAssembly, subAssembly, compoBisec, diffectiveCode ,service, arrivalPosition, supervisor,  shedResponce, mechanic, message, observation, repercussion, lastOutDate, shedArrivalDate, supplier, place, cpa, shift, f_date, shedInWh,  dateOfAttension, lastScheduleDate, lastSchedule) VALUES  ( @id_mst_loco, @id_loco_sch, @mu_su, @muWith, @incidentDate, @trainNo, @trainLoad, @trainLink, @driverName, @hq, @site, @section, @division,  @railway, @resp, @failureType, @wing, @category, @overDue, @avoidable, @mainAssembly, @subAssembly, @compoBisec, @diffectiveCode ,@service, @arrivalPosition, @supervisor,  @shedResponce, @mechanic, @message, @observation, @repercussion, @lastOutDate, @shedArrivalDate, @supplier, @place, @cpa, @shift, @f_date, @shedInWh,  @dateOfAttension, @lastScheduleDate, @lastSchedule) ", cnn);
            //     cmd = new SqlCommand("@id_failure_analysis",this.id_failure_analysiscnn);
            cmd.Parameters.AddWithValue("@id_mst_loco", this.id_mst_loco);
            cmd.Parameters.AddWithValue("@id_loco_sch", this.id_loco_sch);
            cmd.Parameters.AddWithValue("@mu_su", this.mu_su);
            cmd.Parameters.AddWithValue("@muWith", this.muWith);
            cmd.Parameters.AddWithValue("@incidentDate", this.incidentDate);
            cmd.Parameters.AddWithValue("@trainNo", this.trainNo);
            cmd.Parameters.AddWithValue("@trainLoad", this.trainLoad);
            cmd.Parameters.AddWithValue("@trainLink", this.trainLink);
            cmd.Parameters.AddWithValue("@driverName", this.driverName);
            cmd.Parameters.AddWithValue("@hq", this.hq);
            cmd.Parameters.AddWithValue("@site", this.site);
            cmd.Parameters.AddWithValue("@section", this.section);
            cmd.Parameters.AddWithValue("@division", this.division);
            cmd.Parameters.AddWithValue("@railway", this.railway);
            cmd.Parameters.AddWithValue("@resp", this.resp);
            cmd.Parameters.AddWithValue("@failureType", this.failureType);
            cmd.Parameters.AddWithValue("@wing", this.wing);
            cmd.Parameters.AddWithValue("@category", this.category);
            cmd.Parameters.AddWithValue("@overDue", this.overDue);
            cmd.Parameters.AddWithValue("@avoidable", this.avoidable);
            cmd.Parameters.AddWithValue("@mainAssembly", this.mainAssembly);
            cmd.Parameters.AddWithValue("@subAssembly", this.subAssembly);
            cmd.Parameters.AddWithValue("@compoBisec", this.compoBisec);
            cmd.Parameters.AddWithValue("@diffectiveCode", this.diffectiveCode);
            cmd.Parameters.AddWithValue("@service", this.service);
            cmd.Parameters.AddWithValue("@arrivalPosition", this.arrivalPosition);
            cmd.Parameters.AddWithValue("@supervisor", this.supervisor);
            cmd.Parameters.AddWithValue("@shedResponce", this.shedResponce);
            cmd.Parameters.AddWithValue("@mechanic", this.mechanic);
            cmd.Parameters.AddWithValue("@message", this.message);
            cmd.Parameters.AddWithValue("@observation", this.observation);
            cmd.Parameters.AddWithValue("@repercussion", this.repercussion);
            cmd.Parameters.AddWithValue("@lastOutDate", this.lastOutDate);


            cmd.Parameters.AddWithValue("@shedArrivalDate", this.shedArrivalDate);
            cmd.Parameters.AddWithValue("@supplier", this.supplier);

            cmd.Parameters.AddWithValue("@place", this.place);
            cmd.Parameters.AddWithValue("@cpa", this.cpa);
            cmd.Parameters.AddWithValue("@shift", this.shift);
            cmd.Parameters.AddWithValue("@f_date", this.f_date);
            cmd.Parameters.AddWithValue("@shedInWh", this.shedInWh);
            cmd.Parameters.AddWithValue("@dateOfAttension", this.dateOfAttension);
            cmd.Parameters.AddWithValue("@lastScheduleDate", this.lastScheduleDate);
            cmd.Parameters.AddWithValue("@lastSchedule", this.lastSchedule);

            cmd.Connection.Open();
            Int16 n = Convert.ToInt16(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            if (n == 1)
            {
                cmd = new SqlCommand("SELECT MAX(id_failure_analysis) FROM failure_analysis ", cnn);
                cmd.Connection.Open();
                Int16 m = Convert.ToInt16(cmd.ExecuteNonQuery());
                cmd.Connection.Close();
                return m;
            }
            else
            {

                return 0;
            }

        }
        catch { throw; }
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


    public DataTable Select_Resp()
    {
        cmd = new SqlCommand("select * from jos_railway_mst_resp",cnn);
        da = new SqlDataAdapter();
        dt = new DataTable();
        da.SelectCommand = cmd;
        da.Fill(dt);
        return dt;
    }

    public DataTable Select_Supplier()
    {
        cmd = new SqlCommand("select * from jos_railway_mst_supplier", cnn);
        da = new SqlDataAdapter();
        dt = new DataTable();
        da.SelectCommand = cmd;
        da.Fill(dt);
        return dt;
    }


























    //public bool Update_Data()
    //{
    //    try
    //    {
    //        cmd = new SqlCommand("UPDATE    table_lube_oil SET  id_mst_loco =@id_mst_loco, l_date =@l_date , schedule =@schedule , water =@water , flashpoint =@flashpoint , viscosity =@viscosity , ph =@ph , tbne =@tbne , hi =@hi , ti =@ti , resin =@resin , oil_date_change =@oil_date_change , remarks =@remarks   WHERE lube_oil_id=@lube_oil_id", cnn);
    //        cmd.Parameters.AddWithValue("@lube_oil_id", this.lube_oil_id);
    //        cmd.Parameters.AddWithValue("@id_mst_loco", this.id_mst_loco);
    //        cmd.Parameters.AddWithValue("@l_date", this.l_date);
    //        cmd.Parameters.AddWithValue("@schedule", this.schedule);
    //        cmd.Parameters.AddWithValue("@water", this.water);
    //        cmd.Parameters.AddWithValue("@flashpoint", this.flashpoint);
    //        cmd.Parameters.AddWithValue("@viscosity", this.viscosity);
    //        cmd.Parameters.AddWithValue("@ph", this.ph);
    //        cmd.Parameters.AddWithValue("@tbne", this.tbne);
    //        cmd.Parameters.AddWithValue("@hi", this.hi);
    //        cmd.Parameters.AddWithValue("@ti", this.ti);
    //        cmd.Parameters.AddWithValue("@resin", this.resin);
    //        cmd.Parameters.AddWithValue("@oil_date_change", this.oil_date_change);
    //        cmd.Parameters.AddWithValue("@remarks", this.remarks);

    //        cmd.Connection.Open();
    //        Int16 n = Convert.ToInt16(cmd.ExecuteNonQuery());
    //        cmd.Connection.Close();
    //        return n == 1 ? true : false;
    //    }
    //    catch { throw; }
    //}
    //public bool Delete_Data()
    //{
    //    try
    //    {
    //        cmd = new SqlCommand("DELETE FROM table_lube_oil WHERE lube_oil_id=@lube_oil_id", cnn);
    //        cmd.Parameters.AddWithValue("@lube_oil_id", this.lube_oil_id);
    //        cmd.Connection.Open();
    //        Int16 n = Convert.ToInt16(cmd.ExecuteNonQuery());
    //        cmd.Connection.Close();
    //        return n == 1 ? true : false;
    //    }
    //    catch { throw; }
    //}
    ////public DataTable Select_DataByLoco_n_Date()
    ////{
    ////    try
    ////    {
    ////        //cmd = new SqlCommand("SELECT * FROM Loco_CompressorOil WHERE Id_Loco=@Id_Loco AND Loco_Date=@Loco_Date", cnn);
    ////        //cmd = new SqlCommand("SELECT * FROM Loco_CompressorOil WHERE Id_Loco=@Id_Loco", cnn);
    ////        cmd = new SqlCommand("SELECT table_lube_oil.lube_oil_id" +
    ////  ",table_lube_oil.id_mst_loco " +
    ////  ",jos_railway_mst_loco.locono as Locono" +
    ////  ",REPLACE(CONVERT(VARCHAR(10),table_lube_oil.l_date,105),'-','/') as  Loco_Date" +
    ////  ",table_lube_oil.schedule as Id_Schedule1 " +
    ////  ",jos_railway_loco_type_schedule.s_type as Id_Schedule " +
    ////  ",table_lube_oil.water " +
    ////  ",table_lube_oil.flashpoint " +
    ////  ",table_lube_oil.viscosity" +
    ////  ",table_lube_oil.ph " +
    ////  ",table_lube_oil.tbne" +
    ////  ",table_lube_oil.hi" +
    ////  ",table_lube_oil.ti" +
    ////  ",table_lube_oil.resin" +
    ////  ",table_lube_oil.oil_date_change" +
    ////  ",table_lube_oil.remarks"  +
    ////  "INNER JOIN  jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = table_lube_oil.schedule " +
    ////  "INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = table_lube_oil.id_mst_loco WHERE id_mst_loco=@id_mst_loco", cnn);
    ////        cmd.Parameters.AddWithValue("@id_mst_loco", this.id_mst_loco);
    ////        da = new SqlDataAdapter();
    ////        da.SelectCommand = cmd;
    ////        dt = new DataTable();
    ////        da.Fill(dt);
    ////        return dt;
    ////    }
    ////    catch { throw; }
    ////}


    //public DataTable Select_DataByLoco_n_Date()
    //{
    //    try
    //    {
    //        //cmd = new SqlCommand("SELECT * FROM Loco_CompressorOil WHERE Id_Loco=@Id_Loco AND Loco_Date=@Loco_Date", cnn);
    //        //cmd = new SqlCommand("SELECT * FROM Loco_CompressorOil WHERE Id_Loco=@Id_Loco", cnn);
    //        // cmd = new SqlCommand("SELECT table_lube_oil.lube_oil_id,table_lube_oil.id_mst_loco ,jos_railway_mst_loco.locono as Locono,REPLACE(CONVERT(VARCHAR(10),table_lube_oil.l_date,105),'-','/') as  Loco_Date,table_lube_oil.schedule as Id_Schedule1,jos_railway_loco_type_schedule.s_type as Id_Schedule,table_lube_oil.water,table_lube_oil.flashpoint,table_lube_oil.viscosity,table_lube_oil.ph,table_lube_oil.tbne,table_lube_oil.hi,table_lube_oil.ti,table_lube_oil.resin,table_lube_oil.oil_date_change,table_lube_oil.remarks INNER JOIN  jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = table_lube_oil.schedule INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = table_lube_oil.id_mst_loco WHERE id_mst_loco=@id_mst_loco", cnn);
    //        cmd = new SqlCommand("SELECT table_lube_oil.lube_oil_id " +
    //  ",table_lube_oil.id_mst_loco " +
    //  ",jos_railway_mst_loco.locono as Locono" +
    //  ",REPLACE(CONVERT(VARCHAR(10),table_lube_oil.l_date,105),'-','/') as  Loco_Date" +
    //  ",table_lube_oil.schedule as schedule " +
    //  ",jos_railway_loco_type_schedule.s_type as Id_Schedule " +
    //  ",table_lube_oil.water " +
    //  ",table_lube_oil.flashpoint " +
    //  ",table_lube_oil.viscosity " +
    //  ",table_lube_oil.hi " +
    //  ",table_lube_oil.ti " +
    //  ",table_lube_oil.resin " +
    //     ",table_lube_oil.oil_date_change " +
    //  ",table_lube_oil.remarks " +
    //  ",table_lube_oil.ph " +
    //  ",table_lube_oil.tbne " +
    //  "FROM table_lube_oil " +
    //  "INNER JOIN  jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = table_lube_oil.schedule " +
    //  "INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = table_lube_oil.id_mst_loco WHERE table_lube_oil.id_mst_loco=@id_mst_loco", cnn);


    //        cmd.Parameters.AddWithValue("@id_mst_loco", this.id_mst_loco);
    //        da = new SqlDataAdapter();
    //        da.SelectCommand = cmd;
    //        dt = new DataTable();
    //        da.Fill(dt);
    //        return dt;
    //    }
    //    catch { throw; }
    //}
    //public DataTable Select_DataById()
    //{
    //    try
    //    {
    //        cmd = new SqlCommand("SELECT * FROM table_lube_oil WHERE  id_mst_loco=@id_mst_loco", cnn);
    //        da = new SqlDataAdapter();
    //        da.SelectCommand = cmd;
    //        da.Fill(dt);
    //        return dt;
    //    }
    //    catch { throw; }
    //}
    //public DataTable Select_Databyloco(string locono)
    //{

    //    //cmd = new SqlCommand("select * from table_compo_during_failure  ", cnn);
    //    cmd = new SqlCommand("SELECT     table_lube_oil.lube_oil_id, table_lube_oil.id_mst_loco, CONVERT(VARCHAR(10),table_lube_oil.l_date,105)as l_date, table_lube_oil.schedule as Id_Schedule, table_lube_oil.water as water, table_lube_oil.flashpoint as flashpoint,  table_lube_oil.viscosity as viscosity, table_lube_oil.ph as ph, table_lube_oil.tbne as tbne, table_lube_oil.hi as hi, table_lube_oil.ti, table_lube_oil.resin,         table_lube_oil.oil_date_change as oil_date_change, table_lube_oil.remarks as remarks, jos_railway_loco_type_schedule.id_loco_sch, jos_railway_loco_type_schedule.loco_id, jos_railway_mst_loco.id_mst_loco AS Expr1, jos_railway_mst_loco.locono, jos_railway_loco_type_schedule.s_type FROM         table_lube_oil INNER JOIN jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch=table_lube_oil.schedule INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco=table_lube_oil.id_mst_loco where table_lube_oil.id_mst_loco='" + locono + "' ", cnn);
    //    //cmd.Parameters.AddWithValue("@comp_id", this.comp_id);
    //    dt = new DataTable();
    //    da = new SqlDataAdapter();
    //    da.SelectCommand = cmd;
    //    dt.Clear();
    //    da.Fill(dt);
    //    return dt;
    //}
    //public DataTable Select_Data()
    //{
    //    try
    //    {
    //        cmd = new SqlCommand("SELECT * FROM table_lube_oil ", cnn);
    //        da = new SqlDataAdapter();
    //        da.SelectCommand = cmd;
    //        dt = new DataTable();
    //        da.Fill(dt);
    //        return dt;
    //    }
    //    catch { throw; }
    //}

    //public DataTable Select_Data_All()
    //{

    //    //cmd = new SqlCommand("select * from table_compo_during_failure  ", cnn);
    //    cmd = new SqlCommand("SELECT     table_lube_oil.lube_oil_id, table_lube_oil.id_mst_loco, CONVERT(VARCHAR(10),table_lube_oil.l_date,105)as l_date, table_lube_oil.schedule as Id_Schedule, table_lube_oil.water as water, table_lube_oil.flashpoint as flashpoint,  table_lube_oil.viscosity as viscosity, table_lube_oil.ph as ph, table_lube_oil.tbne as tbne, table_lube_oil.hi as hi, table_lube_oil.ti, table_lube_oil.resin,         table_lube_oil.oil_date_change as oil_date_change, table_lube_oil.remarks as remarks, jos_railway_loco_type_schedule.id_loco_sch, jos_railway_loco_type_schedule.loco_id, jos_railway_mst_loco.id_mst_loco AS Expr1, jos_railway_mst_loco.locono, jos_railway_loco_type_schedule.s_type FROM         table_lube_oil INNER JOIN jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch=table_lube_oil.schedule INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco=table_lube_oil.id_mst_loco", cnn);
    //    //cmd.Parameters.AddWithValue("@comp_id", this.comp_id);
    //    dt = new DataTable();
    //    da = new SqlDataAdapter();
    //    da.SelectCommand = cmd;
    //    dt.Clear();
    //    da.Fill(dt);
    //    return dt;
    //}

    //public DataTable Select_Data1()
    //{

    //    try
    //    {
    //        //cmd = new SqlCommand("SELECT * FROM Loco_CompressorOil WHERE Id_Loco=@Id_Loco AND Loco_Date=@Loco_Date", cnn);
    //        //cmd = new SqlCommand("SELECT * FROM Loco_CompressorOil WHERE Id_Loco=@Id_Loco", cnn);
    //        // cmd = new SqlCommand("SELECT table_lube_oil.lube_oil_id,table_lube_oil.id_mst_loco ,jos_railway_mst_loco.locono as Locono,REPLACE(CONVERT(VARCHAR(10),table_lube_oil.l_date,105),'-','/') as  Loco_Date,table_lube_oil.schedule as Id_Schedule1,jos_railway_loco_type_schedule.s_type as Id_Schedule,table_lube_oil.water,table_lube_oil.flashpoint,table_lube_oil.viscosity,table_lube_oil.ph,table_lube_oil.tbne,table_lube_oil.hi,table_lube_oil.ti,table_lube_oil.resin,table_lube_oil.oil_date_change,table_lube_oil.remarks INNER JOIN  jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = table_lube_oil.schedule INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = table_lube_oil.id_mst_loco WHERE id_mst_loco=@id_mst_loco", cnn);
    //        cmd = new SqlCommand("SELECT table_lube_oil.lube_oil_id " +
    //  ",table_lube_oil.id_mst_loco " +
    //  ",jos_railway_mst_loco.locono as Locono" +
    //  ",REPLACE(CONVERT(VARCHAR(10),table_lube_oil.l_date,105),'-','/') as  Loco_Date" +
    //  ",table_lube_oil.schedule as schedule " +
    //  ",jos_railway_loco_type_schedule.s_type as Id_Schedule " +
    //  ",table_lube_oil.water " +
    //  ",table_lube_oil.flashpoint " +
    //  ",table_lube_oil.viscosity " +
    //  ",table_lube_oil.hi " +
    //  ",table_lube_oil.ti " +
    //  ",table_lube_oil.resin " +
    //     ",table_lube_oil.oil_date_change " +
    //  ",table_lube_oil.remarks " +
    //  ",table_lube_oil.ph " +
    //  ",table_lube_oil.tbne " +
    //  "FROM table_lube_oil " +
    //  "INNER JOIN  jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = table_lube_oil.schedule " +
    //  "INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = table_lube_oil.id_mst_loco ", cnn);


    //        //   cmd.Parameters.AddWithValue("@id_mst_loco", this.id_mst_loco);
    //        da = new SqlDataAdapter();
    //        da.SelectCommand = cmd;
    //        dt = new DataTable();
    //        da.Fill(dt);
    //        return dt;
    //    }
    //    catch { throw; }
    //}

}
