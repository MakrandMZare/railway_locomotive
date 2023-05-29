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

/// <summary>
/// Summary description for Cls_jos_railway_shed_pos3
/// </summary>
namespace Railway
{
    public class Cls_jos_railway_shed_pos3:Cls_DBConnection 
    {
        public string id_shed_Pos3;
        public string Loco_id;
        public string LocoDate;
        public string d_or_W;
        public string site_id;
        public string Trno;
        public string TLoad;
        public string Grad;
        public string ReportedReason;
        public string Last_Sch;
        public string Generationdate;
        public Cls_jos_railway_shed_pos3()
        {
            //Declare Connection
            //cnn = new SqlConnection(@"Data Source = DWPL1\SOFTWARE; Initial Catalog=sbidiesel; User ID=bharat; Password=bharat;");

        }
        public Int64 Insert_Data()
        {
            Int64 n = 0;
            try
            {
                cmd = new SqlCommand("SELECT COUNT(*) FROM jos_railway_shed_pos3", cnn);
                cmd.Connection.Open();
                n = Convert.ToInt64(cmd.ExecuteScalar());
                cmd.Connection.Close();

                cmd = new SqlCommand("INSERT INTO jos_railway_shed_pos3(Loco_id,LocoDate,d_or_W,site_id,Trno,TLoad,Grad,ReportedReason,Generationdate,avaibility) VALUES (@Loco_id,@LocoDate,@d_or_W,@site_id,@Trno,@TLoad,@Grad,@ReportedReason,@Generationdate,@avaibility)", cnn);
                cmd.Parameters.AddWithValue("@Loco_id", this.Loco_id);
                cmd.Parameters.AddWithValue("@LocoDate", this.LocoDate);
                cmd.Parameters.AddWithValue("@d_or_W", this.d_or_W);
                cmd.Parameters.AddWithValue("@site_id", this.site_id);
                cmd.Parameters.AddWithValue("@Trno", this.Trno);
                cmd.Parameters.AddWithValue("@TLoad", this.TLoad);
                cmd.Parameters.AddWithValue("@Grad", this.Grad);
                cmd.Parameters.AddWithValue("@ReportedReason", this.ReportedReason);
                cmd.Parameters.AddWithValue("@Generationdate", this.Generationdate);
                cmd.Parameters.AddWithValue("@avaibility", "1");
                cmd.Connection.Open();
                int m = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                if (n > 0)
                {
                    cmd = new SqlCommand("SELECT MAX(id_shed_Pos3) FROM jos_railway_shed_pos3", cnn);
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
                cmd = new SqlCommand("DELETE FROM jos_railway_shed_pos3  WHERE (id_shed_Pos3=@id_shed_Pos3)", cnn);
                cmd.Parameters.AddWithValue("@id_shed_Pos3", this.id_shed_Pos3);
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
                cmd = new SqlCommand(" UPDATE jos_railway_shed_pos3 SET Loco_id=@Loco_id,LocoDate=@LocoDate,d_or_W=@d_or_W,site_id=@site_id,Trno=@Trno,TLoad=@TLoad,Grad=@Grad,ReportedReason=@ReportedReason WHERE id_shed_Pos3=@id_shed_Pos3 ", cnn);
                cmd.Parameters.AddWithValue("@id_shed_Pos3", this.id_shed_Pos3);
                cmd.Parameters.AddWithValue("@Loco_id", this.Loco_id);
                cmd.Parameters.AddWithValue("@LocoDate", this.LocoDate);
                cmd.Parameters.AddWithValue("@d_or_W", this.d_or_W);
                cmd.Parameters.AddWithValue("@site_id", this.site_id);
                cmd.Parameters.AddWithValue("@Trno", this.Trno);
                cmd.Parameters.AddWithValue("@TLoad", this.TLoad);
                cmd.Parameters.AddWithValue("@Grad", this.Grad);
                cmd.Parameters.AddWithValue("@ReportedReason", this.ReportedReason);
                //cmd.Parameters.AddWithValue("@Last_Sch", this.Last_Sch);
                cmd.Connection.Open();
                int n = Convert.ToInt16(cmd.ExecuteNonQuery());
                cmd.Connection.Close();
                return n;
            }
            catch { throw; }
        }
        public DataTable Select_Data()
        {
//            cmd = new SqlCommand("SELECT jos_railway_shed_pos3.id_shed_Pos3 as \"rid\"" +
//                ",jos_railway_mst_loco.locono AS \"LOCO NO\" " +
//    ",convert(varchar(10),jos_railway_shed_pos3.LocoDate,5) AS \"DATE\" " +
//    ",jos_railway_shed_pos3.d_or_W AS \"D/W\" " +
//    ",jos_railway_mst_site.Site_Name AS \"SITE\" " +
//    ",jos_railway_shed_pos3.Trno AS \"TRNO\" " +
//    ",jos_railway_shed_pos3.TLoad AS \"LOAD\" " +
//    ",jos_railway_shed_pos3.Grad AS \"GRAD\" " +
//    ",jos_railway_shed_pos3.ReportedReason AS \"REPOTED REASON\" " +
//    ",CONVERT(VARCHAR(10),jos_railway_mst_loco.doc_date,5) AS \"DOC\" " +
//    ",CONVERT(VARCHAR(10),jos_railway_loco_in.l_date,5) AS \"LAST\" " +
//    ",jos_railway_loco_type_schedule.s_type  AS \"LAST SCH\" " +
//    ",jos_railway_shed_pos3.Loco_id AS \"Loco Id\" " + 
//"FROM jos_railway_shed_pos3 " +
//"INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = jos_railway_shed_pos3.Loco_id " +
//"INNER JOIN jos_railway_mst_site ON jos_railway_mst_site.Id_Site = jos_railway_shed_pos3.site_id " +
//"LEFT OUTER JOIN jos_railway_loco_in ON jos_railway_loco_in.loco_id = jos_railway_shed_pos3.Loco_Id " +
//"INNER JOIN jos_railway_loco_type_schedule ON jos_railway_loco_in.l_sch = jos_railway_loco_type_schedule.id_loco_sch  " +
//"WHERE jos_railway_shed_pos3.Generationdate = '" + this.Generationdate + "'", cnn);
            cmd = new SqlCommand(
"SELECT jos_railway_shed_pos3.id_shed_Pos3 AS \"rid\" " +
",jos_railway_mst_loco.locono AS \"LOCO NO\" " +
",CONVERT(VARCHAR(10),convert(datetime,jos_railway_shed_pos3.LocoDate),105) AS   \"DATE\" " +
",jos_railway_shed_pos3.d_or_W AS \"D/W\" " +
",jos_railway_mst_site.Site_Name AS \"SITE\" " +
",jos_railway_shed_pos3.Trno AS \"TRNO\" " +
",jos_railway_shed_pos3.TLoad AS \"LOAD\" " +
",jos_railway_shed_pos3.Grad AS \"GRAD\"  " +
",jos_railway_shed_pos3.ReportedReason AS \"REPOTED REASON\"  " +
",jos_railway_shed_pos3.Loco_id AS \"Loco Id\"  " +
",CONVERT(VARCHAR(10),jos_railway_mst_loco.doc_date,105) AS  \"DOC\" " +
",(SELECT jos_railway_loco_type_schedule.s_type FROM jos_railway_loco_in INNER JOIN jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = jos_railway_loco_in.l_sch WHERE jos_railway_loco_in.id_loco_in = (SELECT MAX(id_loco_in) FROM jos_railway_loco_in WHERE jos_railway_loco_in.loco_id = jos_railway_shed_pos3.Loco_id)) as \"LAST SCHEDULE\" " +
",(SELECT jos_railway_loco_in.a_date FROM jos_railway_loco_in  WHERE jos_railway_loco_in.id_loco_in = (SELECT MAX(id_loco_in) FROM jos_railway_loco_in WHERE jos_railway_loco_in.loco_id = jos_railway_shed_pos3.Loco_id)) as \"LAST\" " +
"FROM jos_railway_shed_pos3  " +
"INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = jos_railway_shed_pos3.Loco_id  " +
"INNER JOIN jos_railway_mst_site ON jos_railway_mst_site.Id_Site = jos_railway_shed_pos3.site_id  " +
" WHERE jos_railway_shed_pos3.id_shed_Pos3 IN(SELECT MAX(jos_railway_shed_pos3.id_shed_Pos3) FROM jos_railway_shed_pos3 GROUP BY jos_railway_shed_pos3.Loco_id) AND jos_railway_shed_pos3.avaibility='true'", cnn);
            dt = new DataTable();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;
        }
        public DataTable Select_DataById()
        {
            cmd = new SqlCommand("SELECT jos_railway_shed_pos3.id_shed_Pos3 as \"rid\"" +
                
                ",jos_railway_mst_loco.locono AS \"LOCO NO\" " +
    ",convert(varchar(10),jos_railway_shed_pos3.LocoDate,5) AS \"DATE\" " +
    ",jos_railway_shed_pos3.d_or_W AS \"D/W\" " +
    ",jos_railway_mst_site.Site_Name AS \"SITE\" " +
    ",jos_railway_shed_pos3.Trno AS \"TRNO\" " +
    ",jos_railway_shed_pos3.TLoad AS \"LOAD\" " +
    ",jos_railway_shed_pos3.Grad AS \"GRAD\" " +
    ",jos_railway_shed_pos3.ReportedReason AS \"REPOTED REASON\" " +
    ",CONVERT(VARCHAR(10),jos_railway_mst_loco.doc_date,5) AS \"DOC\" " +
    ",CONVERT(VARCHAR(10),jos_railway_loco_in.l_date,5) AS \"LAST\" " +
    ",jos_railway_loco_type_schedule.s_type  AS \"LAST SCH\" " +
    ",jos_railway_shed_pos3.Loco_id AS \"Loco Id\" " + 
    ",jos_railway_mst_site.Id_Site as \"SITEID\" " +
"FROM jos_railway_shed_pos3 " +
"INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = jos_railway_shed_pos3.Loco_id " +
"INNER JOIN jos_railway_mst_site ON jos_railway_mst_site.Id_Site = jos_railway_shed_pos3.site_id " +
"INNER JOIN jos_railway_loco_in ON jos_railway_loco_in.loco_id = jos_railway_shed_pos3.Loco_Id " +
"INNER JOIN jos_railway_loco_type_schedule ON jos_railway_loco_in.l_sch = jos_railway_loco_type_schedule.id_loco_sch  WHERE id_shed_Pos3='" + this.id_shed_Pos3 + "'", cnn);
            dt = new DataTable();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;
        }

        public Int64 Save_LineMessage(string LocoNo, string LDate ,string d_or_W, string TrnoLoad, string Grad, string ReportedReason, string LastSchedule,string  Id_ShedPosition_rpt)
        {
            try
            {
                cmd = new SqlCommand("INSERT INTO rpt_LineMessage ( LocoNo, LDate ,d_or_W, TrnoLoad, Grad , ReportedReason, LastSchedule, Id_ShedPosition_rpt) VALUES (@LocoNo, @LDate ,@d_or_W, @TrnoLoad, @Grad , @ReportedReason, @LastSchedule, @Id_ShedPosition_rpt)", cnn);
               
                cmd.Parameters.AddWithValue("@LocoNo", LocoNo);
                cmd.Parameters.AddWithValue("@LDate", LDate);
                cmd.Parameters.AddWithValue("@d_or_W", d_or_W);
                cmd.Parameters.AddWithValue("@TrnoLoad", TrnoLoad);
                cmd.Parameters.AddWithValue("@Grad", Grad);
                cmd.Parameters.AddWithValue("@ReportedReason", ReportedReason);
                
                cmd.Parameters.AddWithValue("@LastSchedule", LastSchedule);
                cmd.Parameters.AddWithValue("@Id_ShedPosition_rpt", Id_ShedPosition_rpt);
                cmd.Connection.Open();
                Int64 n = Convert.ToInt64((cmd.ExecuteNonQuery()));
                cmd.Connection.Close();
                return n;

            }

            catch { throw; }
        }

        public Int64 Save_LineMessage1(string  LocoNo_Date,string  TrainNoSiteSection,string  LineMessage,string  LastSchedule,string  Id_ShedPosition_rpt)
        {
            try
            {
                cmd = new SqlCommand("INSERT INTO rpt_LineMessage1 (LocoNo_Date, TrainNoSiteSection, LineMessage, LastSchedule, Id_ShedPosition_rpt)VALUES(@LocoNo_Date,@TrainNoSiteSection,@LineMessage,@LastSchedule,@Id_ShedPosition_rpt)", cnn);

                cmd.Parameters.AddWithValue("@LocoNo_Date", LocoNo_Date);
                cmd.Parameters.AddWithValue("@TrainNoSiteSection", TrainNoSiteSection);
                cmd.Parameters.AddWithValue("@LineMessage", LineMessage);
                cmd.Parameters.AddWithValue("@LastSchedule", LastSchedule);
                cmd.Parameters.AddWithValue("@Id_ShedPosition_rpt", Id_ShedPosition_rpt);
             

                cmd.Connection.Open();
                Int64 n = Convert.ToInt64((cmd.ExecuteNonQuery()));
                cmd.Connection.Close();
                return n;

            }

            catch { throw; }
        }
         public void Make_Loco_Unavailable()
        {
            //this function will make last loco unavailable after locoin
            try
            {
                cmd = new SqlCommand("UPDATE jos_railway_shed_pos3 set avaibility='false' WHERE id_shed_Pos3=@id_shed_Pos3", cnn);
                cmd.Parameters.AddWithValue("@id_shed_Pos3", this.id_shed_Pos3);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            catch { throw; }
        }
    }
}

