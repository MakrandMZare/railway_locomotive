using System;
using System.Data;
using System.Configuration;
//using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
//using System.Xml.Linq;
using System.Data.SqlClient;
using Railway;

/// <summary>
/// Summary description for Cls_jos_railway_Loco_Movements
/// </summary>
namespace Railway
{
    public class Cls_jos_railway_Loco_Movements : Cls_DBConnection
    {

        DataTable dt;
        public string Id_Loco_Movement;
        public string LocoId;
        public string RepairAttended;
        public string Div;
        public string Site_Id;
        public string Section_Id;
        public string Remarks;
        public string GenerationDate;
        public string ReportDate;
        public Cls_jos_railway_Loco_Movements()
        {
            //Declare Connection
            //cnn = new SqlConnection(@"Data Source = DWPL1\SOFTWARE; Initial Catalog=sbidiesel; User ID=bharat; Password=bharat;");

        }
        public DataTable Get_LocoMovement_Date_Wise(string ReportDate)
        {
          // cmd = new SqlCommand("SELECT locono as \"LocoNo\", dateofarrival as \"ARRIVAL DATE\", doc as \"DOC\", lastout as \"LAST OUT\", lastschedule as \"LAST SCHEULE\" , rapairattended as \"REPAIR ATTENDED\", division as \"DIVISION\", site as \"SITE\", section as \"SECTION\", remarks as \"REMARKS\" FROM rpt_locomovment", cnn);
            //cmd = new SqlCommand("SELECT rpt_locomovment.IdLocoMovement, rpt_locomovment.locono as \"LocoNo\", rpt_locomovment.dateofarrival as \"ARRIVAL DATE\", rpt_locomovment.doc as  \"DOC\", rpt_locomovment.lastout as \"LAST OUT\", rpt_locomovment.lastschedule  as \"LAST SCHEULE\" , rpt_locomovment.rapairattended  as \"REPAIR ATTENDED\", rpt_locomovment.site as \"SITE\", rpt_locomovment.section as \"SECTION\", rpt_locomovment.remarks  as \"REMARKS\",rpt_locomovment.Shed_Position_rpt, rpt_locomovment.division as \"DIVISION\", Saved_ShedPositionReport.Id_ShedPosition_rpt, Convert(varchar(10),Saved_ShedPositionReport.ReportDate,105) FROM rpt_locomovment CROSS JOIN Saved_ShedPositionReport where Saved_ShedPositionReport.ReportDate ='@ReportDate'", cnn);
            //cmd = new SqlCommand("SELECT rpt_locomovment.IdLocoMovement, rpt_locomovment.locono as \"LocoNo\", rpt_locomovment.dateofarrival as \"ARRIVAL DATE\", rpt_locomovment.doc as  \"DOC\", rpt_locomovment.lastout as \"LAST OUT\", rpt_locomovment.lastschedule  as \"LAST SCHEULE\" , rpt_locomovment.rapairattended  as \"REPAIR ATTENDED\", rpt_locomovment.site as \"SITE\", rpt_locomovment.section as \"SECTION\", rpt_locomovment.remarks  as \"REMARKS\",rpt_locomovment.Shed_Position_rpt, rpt_locomovment.division as \"DIVISION\", Saved_ShedPositionReport.Id_ShedPosition_rpt,Saved_ShedPositionReport.ReportDate FROM rpt_locomovment CROSS JOIN Saved_ShedPositionReport where Saved_ShedPositionReport.ReportDate ='" +ReportDate +"'", cnn);
            cmd = new SqlCommand("SELECT  rpt_locomovment.locono as \"LocoNo\", rpt_locomovment.dateofarrival as \"ARRIVAL DATE\", rpt_locomovment.doc as  \"DOC\", rpt_locomovment.lastout as \"LAST OUT\", rpt_locomovment.lastschedule  as \"LAST SCHEULE\" , rpt_locomovment.rapairattended  as \"REPAIR ATTENDED\", rpt_locomovment.site as \"SITE\", rpt_locomovment.section as \"SECTION\", rpt_locomovment.remarks  as \"REMARKS\",rpt_locomovment.Shed_Position_rpt, rpt_locomovment.division as \"DIVISION\", Saved_ShedPositionReport.Id_ShedPosition_rpt,Saved_ShedPositionReport.ReportDate FROM rpt_locomovment  INNER JOIN Saved_ShedPositionReport ON Saved_ShedPositionReport.Id_ShedPosition_rpt=rpt_locomovment.Shed_Position_rpt where Saved_ShedPositionReport.ReportDate ='" + ReportDate + "'", cnn);
            // SELECT     rpt_locomovment.IdLocoMovement, rpt_locomovment.locono, rpt_locomovment.dateofarrival, rpt_locomovment.doc, rpt_locomovment.lastout, rpt_locomovment.lastschedule, rpt_locomovment.rapairattended, rpt_locomovment.site, rpt_locomovment.section, rpt_locomovment.remarks,rpt_locomovment.Shed_Position_rpt, rpt_locomovment.division, Saved_ShedPositionReport.Id_ShedPosition_rpt, Saved_ShedPositionReport.ReportDate FROM rpt_locomovment INNER JOIN Saved_ShedPositionReport ON Saved_ShedPositionReport.Id_ShedPosition_rpt=rpt_locomovment.Shed_Position_rpt where Saved_ShedPositionReport.ReportDate 
            //SELECT     rpt_locomovment.IdLocoMovement, rpt_locomovment.locono, rpt_locomovment.dateofarrival, rpt_locomovment.doc, rpt_locomovment.lastout, rpt_locomovment.lastschedule, rpt_locomovment.rapairattended, rpt_locomovment.site, rpt_locomovment.section, rpt_locomovment.remarks,rpt_locomovment.Shed_Position_rpt, rpt_locomovment.division, Saved_ShedPositionReport.Id_ShedPosition_rpt, Saved_ShedPositionReport.ReportDate FROM rpt_locomovment CROSS JOIN Saved_ShedPositionReport where Saved_ShedPositionReport.ReportDate ='2011-01-07'
            dt = new DataTable();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            //dt.Clear();
            da.Fill(dt);
            return dt;
        }

       
        public Int64 Insert_Data()
        {
            Int64 n = 0;
            try
            {
                cmd = new SqlCommand("SELECT COUNT(*) FROM jos_railway_Loco_Movements", cnn);
                cmd.Connection.Open();
                n = Convert.ToInt64(cmd.ExecuteScalar());
                cmd.Connection.Close();

                cmd = new SqlCommand("INSERT INTO jos_railway_Loco_Movements(LocoId,RepairAttended,Div,Site_Id,Section_Id,Remarks,GenerationDate) VALUES (@LocoId,@RepairAttended,@Div,@Site_Id,@Section_Id,@Remarks,@GenerationDate)", cnn);
                cmd.Parameters.AddWithValue("@LocoId", this.LocoId);
                cmd.Parameters.AddWithValue("@RepairAttended", this.RepairAttended);
                cmd.Parameters.AddWithValue("@Div", this.Div);
                cmd.Parameters.AddWithValue("@Site_Id", this.Site_Id);
                cmd.Parameters.AddWithValue("@Section_Id", this.Section_Id);
                cmd.Parameters.AddWithValue("@Remarks", this.Remarks);
                cmd.Parameters.AddWithValue("@GenerationDate", this.GenerationDate);
                cmd.Connection.Open();
                int m = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                if (n > 0)
                {
                    cmd = new SqlCommand("SELECT MAX(Id_Loco_Movement) FROM jos_railway_Loco_Movements", cnn);
                    cmd.Connection.Open();
                    n = Convert.ToInt64(cmd.ExecuteScalar());
                    //n++;
                    cmd.Connection.Close();
                }
                else
                {
                    n = 1;
                }
                if (m == 1)
                {
                    return n;
                }
                else
                {
                    return 0;
                }
            }
            catch { throw; }
        }
        //Delete Data
        public int Delete_Data()
        {
            try
            {
                cmd = new SqlCommand("DELETE FROM jos_railway_Loco_Movements  WHERE (Id_Loco_Movement=@Id_Loco_Movement)", cnn);
                cmd.Parameters.AddWithValue("@Id_Loco_Movement", this.Id_Loco_Movement);
                cmd.Connection.Open();
                int n = Convert.ToInt16(cmd.ExecuteNonQuery());
                cmd.Connection.Close();
                return n;
            }
            catch { throw; }
        }
        public int Update_Data()
        {
            try
            {
                cmd = new SqlCommand(" UPDATE jos_railway_Loco_Movements SET LocoId=@LocoId,RepairAttended=@RepairAttended,Div=@Div,Site_Id=@Site_Id,Section_Id=@Section_Id,Remarks=@Remarks WHERE Id_Loco_Movement=@Id_Loco_Movement ", cnn);
                cmd.Parameters.AddWithValue("@Id_Loco_Movement", this.Id_Loco_Movement);
                cmd.Parameters.AddWithValue("@LocoId", this.LocoId);
                cmd.Parameters.AddWithValue("@RepairAttended", this.RepairAttended);
                cmd.Parameters.AddWithValue("@Div", this.Div);
                cmd.Parameters.AddWithValue("@Site_Id", this.Site_Id);
                cmd.Parameters.AddWithValue("@Section_Id", this.Section_Id);
                cmd.Parameters.AddWithValue("@Remarks", this.Remarks);
                //cmd.Parameters.AddWithValue("@GenerationDate", this.GenerationDate);
                cmd.Connection.Open();
                int n = Convert.ToInt16(cmd.ExecuteNonQuery());
                cmd.Connection.Close();
                return n;
            }
            catch { throw; }
        }
        //public DataTable Select_Data()
        //{
        //    cmd = new SqlCommand("SELECT * FROM jos_railway_Loco_Movements", cnn);
        //    dt = new DataTable();
        //    da = new SqlDataAdapter();
        //    da.SelectCommand = cmd;
        //    dt.Clear();
        //    da.Fill(dt);
        //    return dt;
        //}
        public void Update_Div_Site_Section_RemarksInLocoMovement()
        {
            try
            {
                cmd = new SqlCommand("UPDATE jos_railway_Loco_Movements SET Div=@Div,Section_Id=@Section_Id,Site_Id=@Site_Id,Remarks=@Remarks WHERE  Id_Loco_Movement=@Id_Loco_Movement", cnn);
                cmd.Parameters.AddWithValue("@Div", this.Div);
                cmd.Parameters.AddWithValue("@Site_Id", this.Site_Id);
                cmd.Parameters.AddWithValue("@Section_Id", this.Section_Id);
                cmd.Parameters.AddWithValue("@Remarks", this.Remarks);
                cmd.Parameters.AddWithValue("@Id_Loco_Movement", this.Id_Loco_Movement);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            catch { throw; }
        }
        public DataTable Select_Data()
        {
            //    cmd = new SqlCommand("SELECT jos_railway_mst_loco.locono AS \"LOCO NO\" " +
            //      ",Convert(varchar(10),jos_railway_loco_in.a_date,5) AS \"DATE OF ARRIVAL\" " +
            //      ",Convert(varchar(10),jos_railway_mst_loco.doc_date,5)	AS \"DOC\" " +
            //      ",Convert(varchar(10),jos_railway_loco_in.l_date,5) AS \"LAST OUT\" " +
            //      ",jos_railway_loco_type_schedule.s_type AS \"LAST SCH\" " +
            //      ",jos_railway_Loco_Movements.RepairAttended AS \"REPAIR ATTENDED\" " +
            //      ",jos_railway_division.div AS \"DIV\" " +
            //      ",jos_railway_mst_site.Site_Name AS \"SITE\" " +
            //      ",jos_railway_mst_SiteSection.SiteSectionName AS \"SECTION\" " +
            //      ",jos_railway_Loco_Movements.Remarks AS \"REMARKS\" " +
            //      ",jos_railway_Loco_Movements.GenerationDate as \"GENERATION DATE\" " +
            //"FROM jos_railway_Loco_Movements " +
            //"INNER JOIN jos_railway_mst_loco ON jos_railway_Loco_Movements.LocoId = jos_railway_mst_loco.id_mst_loco " +
            //"INNER JOIN jos_railway_loco_in ON jos_railway_loco_in.loco_id = jos_railway_Loco_Movements.LocoId " +
            //"INNER JOIN jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = jos_railway_loco_in.sid " +
            //"INNER JOIN jos_railway_division ON jos_railway_division.id_div = jos_railway_Loco_Movements.Div " +
            //"INNER JOIN jos_railway_mst_site ON jos_railway_Loco_Movements.Site_Id = jos_railway_mst_site.Id_Site " +
            //"INNER JOIN jos_railway_mst_SiteSection ON jos_railway_mst_SiteSection.Id_SiteSection = jos_railway_Loco_Movements.Section_Id " +
            //"WHERE jos_railway_Loco_Movements.GenerationDate='" + this.GenerationDate + "'", cnn);
            cmd = new SqlCommand("SELECT * FROM  jos_railway_Loco_Movements WHERE jos_railway_Loco_Movements.Id_Loco_Movement ='" + this.Id_Loco_Movement + "'", cnn);
            da = new SqlDataAdapter();
            dt = new DataTable();
            dt.Clear();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        public DataTable Select_LocoDetails()
        {
            cmd = new SqlCommand("SELECT TOP 1 CONVERT(VARCHAR(10),jos_railway_loco_in.a_date,5) as \"DATE OF ARRIVAL\" " +
                                 ",CONVERT(VARCHAR(10),dbo.jos_railway_mst_loco.doc_date,5) as \"DOC\" " +
                                 ",CONVERT(VARCHAR(10),jos_railway_loco_in.l_date,5) AS \"LAST OUT\" " +
                                 ",CONVERT(VARCHAR(10),jos_railway_loco_type_schedule.s_type,5) as \"LAST SCH\" " +
                                 " FROM jos_railway_loco_in " +
                                 " INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = jos_railway_loco_in.loco_id " +
                                 " INNER JOIN jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = jos_railway_loco_in.l_sch " +
                                 " WHERE jos_railway_loco_in.loco_id='" + this.LocoId + "' ORDER BY jos_railway_loco_in.id_loco_in ", cnn);

            dt = new DataTable();
            dt.Clear();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;

        }
        public DataTable Select_DataById()
        {
            cmd = new SqlCommand("SELECT * FROM jos_railway_Loco_Movements where Id_Loco_Movement='" + this.Id_Loco_Movement + "'", cnn);
            dt = new DataTable();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;

        }
        public DataTable Select_Data2()
        {
            //cmd = new SqlCommand("SELECT jos_railway_Loco_Movements.Id_Loco_Movement as \"tid\" " +
            //      ",jos_railway_mst_loco.locono AS \"LOCO NO\" " +
            //      ",Convert(varchar(10),jos_railway_loco_in.a_date,5) AS \"DATE OF ARRIVAL\" " +
            //      ",Convert(varchar(10),jos_railway_mst_loco.doc_date,5)	AS \"DOC\" " +
            //      ",Convert(varchar(10),jos_railway_loco_in.l_date,5) AS \"LAST OUT\" " +
            //      ",jos_railway_loco_type_schedule.s_type AS \"LAST SCH\" " +
            //      ",jos_railway_Loco_Movements.RepairAttended AS \"REPAIR ATTENDED\" " +
            //      ",jos_railway_division.div AS \"DIV\" " +
            //      ",jos_railway_mst_site.Site_Name AS \"SITE\" " +
            //      ",jos_railway_mst_SiteSection.SiteSectionName AS \"SECTION\" " +
            //      ",jos_railway_Loco_Movements.Remarks AS \"REMARKS\" " +
            //"FROM jos_railway_Loco_Movements " +
            //"INNER JOIN jos_railway_mst_loco ON jos_railway_Loco_Movements.LocoId = jos_railway_mst_loco.id_mst_loco " +
            //"INNER JOIN jos_railway_loco_in ON jos_railway_loco_in.loco_id = jos_railway_Loco_Movements.LocoId " +
            //"INNER JOIN jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = jos_railway_loco_in.sid " +
            //"INNER JOIN jos_railway_division ON jos_railway_division.id_div = jos_railway_Loco_Movements.Div " +
            //"INNER JOIN jos_railway_mst_site ON jos_railway_Loco_Movements.Site_Id = jos_railway_mst_site.Id_Site " +
            //"INNER JOIN jos_railway_mst_SiteSection ON jos_railway_mst_SiteSection.Id_SiteSection = jos_railway_Loco_Movements.Section_Id " +
            //"WHERE jos_railway_Loco_Movements.GenerationDate='" + this.GenerationDate + "' ORDER BY jos_railway_loco_in.id_loco_in", cnn);
            cmd = new SqlCommand("SELECT   " +
                                 "jos_railway_mst_loco.id_mst_loco as \"Loco Id\" " +
                                 ",jos_railway_mst_loco.locono as \"LocoNo\" " +
                                 ",CONVERT(VARCHAR(10),jos_railway_mst_loco.doc_date,105) as \"DOC\" " +
                                 ",(SELECT CONVERT(VARCHAR(10),jos_railway_loco_in.a_date,105) FROM jos_railway_loco_in WHERE jos_railway_loco_in.id_loco_in = (SELECT MAX(id_loco_in) FROM jos_railway_loco_in WHERE jos_railway_loco_in.loco_id=jos_railway_mst_loco.id_mst_loco))as \"ARRIVAL DATE\" " +
                                 ",(SELECT CONVERT(VARCHAR(10),jos_railway_loco_in.l_date,105) FROM jos_railway_loco_in WHERE jos_railway_loco_in.id_loco_in = (SELECT MAX(id_loco_in) FROM jos_railway_loco_in WHERE jos_railway_loco_in.loco_id=jos_railway_mst_loco.id_mst_loco))as \"LAST OUT\" " +
                                 ",(SELECT jos_railway_loco_type_schedule.s_type FROM jos_railway_loco_in INNER JOIN jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = jos_railway_loco_in.l_sch  WHERE jos_railway_loco_in.id_loco_in = (SELECT MAX(id_loco_in) FROM jos_railway_loco_in WHERE jos_railway_loco_in.loco_id=jos_railway_mst_loco.id_mst_loco))as \"LAST SCHEULE\" " +
                                 ",(SELECT jos_railway_Loco_Movements.RepairAttended FROM jos_railway_Loco_Movements WHERE jos_railway_Loco_Movements.Id_Loco_Movement = (SELECT MAX(Id_Loco_Movement) FROM jos_railway_Loco_Movements WHERE jos_railway_Loco_Movements.LocoId = jos_railway_mst_loco.id_mst_loco)) as \"REPAIR ATTENDED\" " +
                                 ",(SELECT jos_railway_division.div FROM jos_railway_Loco_Movements INNER JOIN jos_railway_division ON jos_railway_division.id_div = jos_railway_Loco_Movements.Div WHERE jos_railway_Loco_Movements.Id_Loco_Movement = (SELECT MAX(Id_Loco_Movement) FROM jos_railway_Loco_Movements WHERE jos_railway_Loco_Movements.LocoId = jos_railway_mst_loco.id_mst_loco)) as \"DIVISION\" " +
                                 ",(SELECT jos_railway_mst_site.Site_Name FROM jos_railway_Loco_Movements INNER JOIN jos_railway_mst_site ON jos_railway_mst_site.Id_Site = jos_railway_Loco_Movements.Site_Id WHERE jos_railway_Loco_Movements.Id_Loco_Movement = (SELECT MAX(Id_Loco_Movement) FROM jos_railway_Loco_Movements WHERE jos_railway_Loco_Movements.LocoId = jos_railway_mst_loco.id_mst_loco)) as \"SITE\" " +
                                 ",(SELECT jos_railway_mst_SiteSection.SiteSectionName FROM jos_railway_Loco_Movements INNER JOIN jos_railway_mst_SiteSection ON jos_railway_mst_SiteSection.Id_SiteSection= jos_railway_Loco_Movements.Section_Id WHERE jos_railway_Loco_Movements.Id_Loco_Movement = (SELECT MAX(Id_Loco_Movement) FROM jos_railway_Loco_Movements WHERE jos_railway_Loco_Movements.LocoId = jos_railway_mst_loco.id_mst_loco)) as \"SECTION\" " +
                                 ",(SELECT jos_railway_Loco_Movements.Remarks FROM jos_railway_Loco_Movements WHERE jos_railway_Loco_Movements.Id_Loco_Movement = (SELECT MAX(Id_Loco_Movement) FROM  jos_railway_Loco_Movements WHERE jos_railway_Loco_Movements.LocoId = jos_railway_mst_loco.id_mst_loco)) AS \"REMARKS\"  " +
                                 ",(SELECT jos_railway_Loco_Movements.Id_Loco_Movement FROM jos_railway_Loco_Movements WHERE jos_railway_Loco_Movements.Id_Loco_Movement = (SELECT MAX(Id_Loco_Movement) FROM  jos_railway_Loco_Movements WHERE jos_railway_Loco_Movements.LocoId = jos_railway_mst_loco.id_mst_loco)) AS \"Id_Loco_Movement\"  " +
                                 " FROM jos_railway_mst_loco WHERE jos_railway_mst_loco.native='HOME'", cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable Select_Data2_yearly()
        {
           cmd = new SqlCommand("SELECT jos_railway_loco_Schedule_TimeTable.id_loco_Schedule, jos_railway_loco_Schedule_TimeTable.Schedule_Id, jos_railway_loco_Schedule_TimeTable.Loco_Id, jos_railway_loco_Schedule_TimeTable.ScheduleDate, jos_railway_loco_in.id_loco_in, jos_railway_loco_in.loco_id AS Expr1, jos_railway_loco_in.sid FROM         jos_railway_loco_in INNER JOIN jos_railway_loco_Schedule_TimeTable ON jos_railway_loco_in.loco_id = jos_railway_loco_Schedule_TimeTable.Loco_Id where Schedule_Id = '19'", cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        
        public Int64 Save_LocoMovementReport(string locono,string dateofarrival,string doc,string lastout,string lastschedule, string rapairattended,string division,string site,string section,string remarks,string Shed_Position_rpt)
        {
            try
            {
               // cmd = new SqlCommand("INSERT INTO rpt_LocoMovement (Locono,DOA,DOC,LastOut,LastSch,RepairAttended,Div,Site,Section,Remarks,Shed_Position_rpt) VALUES(@Locono,@DOA,@DOC,@LastOut,@LastSch,@RepairAttended,@Div,@Site,@Section,@Remarks,@Shed_Position_rpt)", cnn);
                cmd = new SqlCommand("INSERT INTO rpt_locomovment(locono, dateofarrival, doc, lastout, lastschedule,  rapairattended, division, site, section, remarks, Shed_Position_rpt)VALUES (@locono,@dateofarrival,@doc,@lastout,@lastschedule,@rapairattended,@division,@site,@section,@remarks,@Shed_Position_rpt)", cnn);

                cmd.Parameters.AddWithValue("locono",locono);
                cmd.Parameters.AddWithValue("dateofarrival",dateofarrival);
                cmd.Parameters.AddWithValue("doc",doc);
                cmd.Parameters.AddWithValue("lastout",lastout);
                cmd.Parameters.AddWithValue("lastschedule",lastschedule);
                //cmd.Parameters.AddWithValue("yearly",yearly);
                cmd.Parameters.AddWithValue("rapairattended",rapairattended);
                cmd.Parameters.AddWithValue("division",division);
                cmd.Parameters.AddWithValue("site",site);
                cmd.Parameters.AddWithValue("section",section);
                cmd.Parameters.AddWithValue("remarks",remarks);
                cmd.Parameters.AddWithValue("Shed_Position_rpt",Shed_Position_rpt);
                cmd.Connection.Open();
                Int64 n =  Convert.ToInt64(cmd.ExecuteNonQuery());
                cmd.Connection.Close();
                return n;
            }
            catch { throw; }            
        }
    }
}