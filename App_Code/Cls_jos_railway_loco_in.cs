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
/// Summary description for Cls_Student
/// </summary>
namespace Railway
{
    public class Cls_jos_railway_loco_in : Cls_DBConnection
    {
        public string id_loco_in = null;
        public string type_id = null;
        public string loco_id = null;
        public string a_date = null;
        public string a_time = null;
        public string sid = null;
        public string desc_sche = null;
        public string tid = null;
        public string l_date = null;
        public string l_sch = null;
        public string hq = null;
        public string sname = null;
        public string l_oil = null;
        public string f_level = null;
        public string d_book = null;
        public string r_key = null;
        public string d_set = null;
        public string f_ext = null;
        public string tnc_name = null;
        public string shift_date = null;
        public string booked = null;
        public string action = null;
        public string avaibility = null;

        //----------------------------------------------------------------------------------
        public string bgh1;
        public string bgh2;
        public string bgf1;
        public string bgf2;
        public string bgf3;
        public string bgd;
        public string mgh1;
        public string mgh2;
        public string mgf1;
        public string mgf2;
        public string mgf3;
        public string mgf4;
        public string mfd;
        //---------------------------
        public string mghr;
        public string bghr;
        public string mglr;
        public string bglr;
        public string mgur;
        public string bgur;
        public string mgdead;
        public string bgdead;
        public string mgdiv;
        public string bgdiv;
        public string mglie;
        public string bglie;
        public string mgnet1;
        public string mgnet2;
        public string bgnet1;
        public string bgnet2;
        public string mgsr;
        public string mgloc;
        public string mggear;
        public string mgcompress;
        public string mgfuel;
        public string mgrunning;

        //-------------------------------------------------------------------------------------------------
        public Cls_jos_railway_loco_in()
        {
            //Declare Connection
            //cnn = new SqlConnection(@"Data Source = DWPL1\SOFTWARE; Initial Catalog=sbidiesel; User ID=bharat; Password=bharat;");

        }

        public DataTable Get_LastOutDate_n_ScheduleOfLoco()
        {
            cmd = new SqlCommand("SELECT REPLACE(CONVERT(VARCHAR(10),jos_railway_Loco_out.a_date,105),'-','/') as \"LastOutDate\",jos_railway_Loco_out.sid as \"LastSchedule\"  FROM jos_railway_Loco_out WHERE id_loco_out = (SELECT MAX(id_loco_out) FROM jos_railway_loco_out WHERE loco_id=@loco_id)", cnn);
            cmd.Parameters.AddWithValue("@loco_id", this.loco_id);
            da = new SqlDataAdapter();
            dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        public bool Check_Loco_Existance()
        {
            cmd = new SqlCommand("SELECT COUNT(*) FROM jos_railway_loco_in WHERE type_id='" + this.type_id + "' AND loco_id='" + this.loco_id + "' AND avaibility='True'", cnn);
            cmd.Parameters.AddWithValue("@type_id", this.type_id);
            cmd.Parameters.AddWithValue("@loco_id", this.loco_id);
            cmd.Parameters.AddWithValue("@avaibility", this.avaibility);
            cmd.Connection.Open();
            int n = Convert.ToInt16(cmd.ExecuteScalar());
            cmd.Connection.Close();
            if (n == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public Int64 Insert_Data()
        {
            Int64 n = 0;
            try
            {
                //cmd = new SqlCommand("SELECT COUNT(*) FROM jos_railway_loco_in", cnn);
                //        cmd.Connection.Open();
                //        n = Convert.ToInt64(cmd.ExecuteScalar());
                //        cmd.Connection.Close();

                cmd = new SqlCommand("INSERT INTO jos_railway_loco_in(type_id,loco_id,a_date,a_time,sid,desc_sche,tid,l_date,l_sch,hq,sname,l_oil,f_level,d_book,r_key,d_set,f_ext,tnc_name,shift_date,booked,action,avaibility) VALUES (@type_id,@loco_id,@a_date,@a_time,@sid,@desc_sche,@tid,@l_date,@l_sch,@hq,@sname,@l_oil,@f_level,@d_book,@r_key,@d_set,@f_ext,@tnc_name,@shift_date,@booked,@action,@avaibility)", cnn);
                cmd.Parameters.AddWithValue("@type_id", this.type_id);
                cmd.Parameters.AddWithValue("@loco_id", this.loco_id);
                //cmd.Parameters.AddWithValue("@a_date", Convert.ToDateTime(this.a_date));
                cmd.Parameters.AddWithValue("@a_date", this.a_date);
                cmd.Parameters.AddWithValue("@a_time", this.a_time);
                cmd.Parameters.AddWithValue("@sid", this.sid);
                cmd.Parameters.AddWithValue("@desc_sche", this.desc_sche);
                cmd.Parameters.AddWithValue("@tid", this.tid);
                //cmd.Parameters.AddWithValue("@l_date", Convert.ToDateTime(this.l_date));
                cmd.Parameters.AddWithValue("@l_date", this.l_date);
                cmd.Parameters.AddWithValue("@l_sch", this.l_sch);
                cmd.Parameters.AddWithValue("@hq", this.hq);
                cmd.Parameters.AddWithValue("@sname", this.sname);
                cmd.Parameters.AddWithValue("@l_oil", this.l_oil);
                cmd.Parameters.AddWithValue("@f_level", this.f_level);
                cmd.Parameters.AddWithValue("@d_book", this.d_book);
                cmd.Parameters.AddWithValue("@r_key", this.r_key);
                cmd.Parameters.AddWithValue("@d_set", this.d_set);
                cmd.Parameters.AddWithValue("@f_ext", this.f_ext);
                cmd.Parameters.AddWithValue("@tnc_name", this.tnc_name);
                //cmd.Parameters.AddWithValue("@shift_date", Convert.ToDateTime(this.shift_date));
                cmd.Parameters.AddWithValue("@shift_date", this.shift_date);
                cmd.Parameters.AddWithValue("@booked", this.booked);
                cmd.Parameters.AddWithValue("@action", this.action);
                cmd.Parameters.AddWithValue("@avaibility", this.avaibility);

                cmd.Connection.Open();
                int m = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                if (m == 1)
                {
                    cmd = new SqlCommand("SELECT MAX(id_loco_in) FROM jos_railway_loco_in", cnn);
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
        public DataTable SelectLocoType()
        {
            cmd = new SqlCommand("SELECT Distinct jos_railway_loco_type.id_ltype,jos_railway_loco_type.loco_type from jos_railway_loco_type INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.tid = jos_railway_loco_type.id_ltype", cnn);
            da = new SqlDataAdapter();
            dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;

        }
        public DataTable Select_LocoNo(string LocoType)
        {
            cmd = new SqlCommand("SELECT id_mst_loco,locono from jos_railway_mst_loco  WHERE tid = '" + LocoType + "' ORDER BY locono", cnn);

            da = new SqlDataAdapter();
            dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        //Delete Data
        public int Delete_Data()
        {
            try
            {
                cmd = new SqlCommand("DELETE FROM jos_railway_loco_in  WHERE (id_loco_in=@id_loco_in)", cnn);
                cmd.Parameters.AddWithValue("@id_loco_in", this.id_loco_in);
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
                cmd = new SqlCommand(" UPDATE jos_railway_loco_in SET type_id=@type_id,loco_id=@loco_id,a_date=@a_date,a_time=@a_time,sid=@sid,desc_sche=@desc_sche,tid=@tid,l_date=@l_date,l_sch=@l_sch,hq=@hq,sname=@sname,l_oil=@l_oil,f_level=@f_level,d_book=@d_book,r_key=@r_key,d_set=@d_set,f_ext=@f_ext,tnc_name=@tnc_name,shift_date=@shift_date,booked=@booked,action=@action WHERE id_loco_in=@id_loco_in ", cnn);
                cmd.Parameters.AddWithValue("@id_loco_in", this.id_loco_in);
                cmd.Parameters.AddWithValue("@type_id", this.type_id);
                cmd.Parameters.AddWithValue("@loco_id", this.loco_id);
                //cmd.Parameters.AddWithValue("@a_date", Convert.ToDateTime(this.a_date));
                cmd.Parameters.AddWithValue("@a_date", this.a_date);
                cmd.Parameters.AddWithValue("@a_time", this.a_time);
                cmd.Parameters.AddWithValue("@sid", this.sid);
                cmd.Parameters.AddWithValue("@desc_sche", this.desc_sche);
                cmd.Parameters.AddWithValue("@tid", this.tid);
                //cmd.Parameters.AddWithValue("@l_date", Convert.ToDateTime(this.l_date));
                cmd.Parameters.AddWithValue("@l_date", this.l_date);
                cmd.Parameters.AddWithValue("@l_sch", this.l_sch);
                cmd.Parameters.AddWithValue("@hq", this.hq);
                cmd.Parameters.AddWithValue("@sname", this.sname);
                cmd.Parameters.AddWithValue("@l_oil", this.l_oil);
                cmd.Parameters.AddWithValue("@f_level", this.f_level);
                cmd.Parameters.AddWithValue("@d_book", this.d_book);
                cmd.Parameters.AddWithValue("@r_key", this.r_key);
                cmd.Parameters.AddWithValue("@d_set", this.d_set);
                cmd.Parameters.AddWithValue("@f_ext", this.f_ext);
                cmd.Parameters.AddWithValue("@tnc_name", this.tnc_name);
                //cmd.Parameters.AddWithValue("@shift_date", Convert.ToDateTime(this.shift_date));
                cmd.Parameters.AddWithValue("@shift_date", this.shift_date);
                cmd.Parameters.AddWithValue("@booked", this.booked);
                cmd.Parameters.AddWithValue("@action", this.action);
                cmd.Connection.Open();
                int n = Convert.ToInt16(cmd.ExecuteNonQuery());
                cmd.Connection.Close();
                return n;
            }
            catch { throw; }
        }
        public DataTable Select_Data()
        {
            //cmd = new SqlCommand("SELECT * FROM jos_railway_loco_in", cnn);
            cmd = new SqlCommand("SELECT " +
              "jos_railway_loco_in.id_loco_in" +
            ", jos_railway_loco_type.loco_type as \"Class\"" +
            ", jos_railway_mst_loco.locono as \"Loco No\"" +
            ", CONVERT(varchar(10),jos_railway_loco_in.a_date,5) as \"Arrival Date\"" +
            ", jos_railway_loco_in.a_time as \"Arrival time\"" +
            ", jos_railway_loco_type_schedule.s_type as \"Schedule\"" +
            ", jos_railway_loco_in.desc_sche as \"Description\"" +
            ", jos_railway_loco_in.tid as \"Train No\" " +
            ", CONVERT(varchar(10),jos_railway_loco_in.l_date,5) as \"Last Out Date\" " +
            ", jos_railway_loco_type_schedule.s_type as \"Last Schedule\" " +
            ", jos_railway_mst_hq.\"name\" as \"HQ\"" +
            ", jos_railway_loco_in.sname as \"Driver name\" " +
            ", jos_railway_loco_in.l_oil as \"Oil Level\" " +
            ", jos_railway_loco_in.f_level as \"Fule Level\" " +
            ", jos_railway_loco_in.d_book as \"Driver book\"" +
            ", jos_railway_loco_in.r_key as \"Reverser Key\"" +
            ", jos_railway_loco_in.d_set as \"Dep Set\"" +
            ", jos_railway_loco_in.f_ext as \"Fire Ext\" " +
            ",(jos_railway_Hr.surname + ' ' + jos_railway_Hr.fullname + ' ' + jos_railway_Hr.father_name) as tncname " +
            ", CONVERT(varchar(10),jos_railway_loco_in.shift_date,5) as \"Shift Date\"" +
            ", jos_railway_loco_in.booked as \"Booked Repairs\"" +
            ", jos_railway_loco_in.\"action\" as \"Action Taken\"" +
            "FROM  jos_railway_loco_in " +
            " INNER JOIN jos_railway_loco_type ON jos_railway_loco_in.type_id = jos_railway_loco_type.id_ltype " +
            " INNER JOIN jos_railway_loco_type_schedule ON jos_railway_loco_in.sid = jos_railway_loco_type_schedule.id_loco_sch " +
            " INNER JOIN jos_railway_mst_hq ON jos_railway_loco_in.hq = jos_railway_mst_hq.id_mst_hq " +
            " INNER JOIN jos_railway_Hr ON jos_railway_loco_in.tnc_name = jos_railway_Hr.id_hr " +
            " INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = jos_railway_loco_in.loco_id " +
            " WHERE jos_railway_loco_in.a_date between DATEADD(m,-1,GETDATE()) AND GETDATE() ", cnn);

            dt = new DataTable();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;
        }
        public DataTable Select_Data(string locono, string arrivaldate)
        {
            //select data by locono or arrival date
            string Commandstr = "SELECT " +
              "jos_railway_loco_in.id_loco_in" +
            ", jos_railway_loco_type.loco_type as \"Class\"" +
            ", jos_railway_mst_loco.locono as \"Loco No\"" +
            ", CONVERT(varchar(10),jos_railway_loco_in.a_date,105) as \"Arrival Date\"" +
            ", jos_railway_loco_in.a_time as \"Arrival time\"" +
            ", jos_railway_loco_type_schedule.s_type as \"Schedule\"" +
            ", jos_railway_loco_in.desc_sche as \"Description\"" +
            ", jos_railway_loco_in.tid as \"Train No\" " +
            ", CONVERT(varchar(10),jos_railway_loco_in.l_date,105) as \"Last Out Date\" " +
            ", jos_railway_loco_type_schedule.s_type as \"Last Schedule\" " +
            ", jos_railway_mst_hq.\"name\" as \"HQ\"" +
            ", jos_railway_loco_in.sname as \"Driver name\" " +
            ", jos_railway_loco_in.l_oil as \"Oil Level\" " +
            ", jos_railway_loco_in.f_level as \"Fule Level\" " +
            ", jos_railway_loco_in.d_book as \"Driver book\"" +
            ", jos_railway_loco_in.r_key as \"Reverser Key\"" +
            ", jos_railway_loco_in.d_set as \"Dep Set\"" +
            ", jos_railway_loco_in.f_ext as \"Fire Ext\" " +
            ",(jos_railway_Hr.surname + ' ' + jos_railway_Hr.fullname + ' ' + jos_railway_Hr.father_name) as tncname " +
            ", CONVERT(varchar(10),jos_railway_loco_in.shift_date,5) as \"Shift Date\"" +
            ", jos_railway_loco_in.booked as \"Booked Repairs\"" +
            ", jos_railway_loco_in.\"action\" as \"Action Taken\"" +
            "FROM  jos_railway_loco_in " +
            " INNER JOIN jos_railway_loco_type ON jos_railway_loco_in.type_id = jos_railway_loco_type.id_ltype " +
            " INNER JOIN jos_railway_loco_type_schedule ON jos_railway_loco_in.sid = jos_railway_loco_type_schedule.id_loco_sch " +
            " INNER JOIN jos_railway_mst_hq ON jos_railway_loco_in.hq = jos_railway_mst_hq.id_mst_hq " +
            " INNER JOIN jos_railway_Hr ON jos_railway_loco_in.tnc_name = jos_railway_Hr.id_hr " +
            " INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = jos_railway_loco_in.loco_id ";
            //" WHERE jos_railway_loco_out.a_date between DATEADD(m,-1,GETDATE()) AND GETDATE() ";
            if (locono != "")
            {
                Commandstr += "  WHERE jos_railway_loco_in.loco_id='" + locono + "'";
            }
            if (locono != "" && arrivaldate != "")
            {
                Commandstr += " AND jos_railway_loco_in.a_date='" + arrivaldate + "'";
            }
            cmd = new SqlCommand(Commandstr, cnn);
            dt = new DataTable();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;
        }
        public DataTable Select_DataByID1()
        {
            cmd = new SqlCommand("SELECT " +
            "jos_railway_loco_in.id_loco_in as \"id\"" +
            ", jos_railway_loco_type.loco_type as \"Class\"" +
            ", jos_railway_mst_loco.locono as \"Loco No\"" +
            ", CONVERT(varchar(10),jos_railway_loco_in.a_date,5) as \"Arrival Date\"" +
            ", jos_railway_loco_in.a_time as \"Arrival time\"" +
            ", jos_railway_loco_type_schedule.s_type as \"Schedule\"" +
            ", jos_railway_loco_in.desc_sche as \"Description\"" +
            ", jos_railway_loco_in.tid as \"Train No\" " +
            ", CONVERT(varchar(10),jos_railway_loco_in.l_date,5) as \"Last Out Date\" " +
            ", jos_railway_loco_type_schedule.s_type as \"Last Schedule\" " +
            ", jos_railway_mst_hq.\"name\" as \"HQ\"" +
            ", jos_railway_loco_in.sname as \"Driver name\" " +
            ", jos_railway_loco_in.l_oil as \"Oil Level\" " +
            ", jos_railway_loco_in.f_level as \"Fule Level\" " +
            ", jos_railway_loco_in.d_book as \"Driver book\"" +
            ", jos_railway_loco_in.r_key as \"Reverser Key\"" +
            ", jos_railway_loco_in.d_set as \"Dep Set\"" +
            ", jos_railway_loco_in.f_ext as \"Fire Ext\" " +
            ",(jos_railway_Hr.surname + ' ' + jos_railway_Hr.fullname + ' ' + jos_railway_Hr.father_name) as tncname " +
            ", CONVERT(varchar(10),jos_railway_loco_in.shift_date,5) as \"Shift Date\"" +
            ", jos_railway_loco_in.booked as \"Booked Repairs\"" +
            ", jos_railway_loco_in.\"action\" as \"Action Taken\"" +
            "FROM  jos_railway_loco_in " +
            " INNER JOIN jos_railway_loco_type ON jos_railway_loco_in.type_id = jos_railway_loco_type.id_ltype " +
            " INNER JOIN jos_railway_loco_type_schedule ON jos_railway_loco_in.sid = jos_railway_loco_type_schedule.id_loco_sch " +
            " INNER JOIN jos_railway_mst_hq ON jos_railway_loco_in.hq = jos_railway_mst_hq.id_mst_hq " +
            " INNER JOIN jos_railway_Hr ON jos_railway_loco_in.tnc_name = jos_railway_Hr.id_hr " +
            " INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = jos_railway_loco_in.loco_id " +
            "WHERE id_loco_in = '" + this.id_loco_in + "'", cnn);

            dt = new DataTable();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;
        }


        public DataTable Select_DataById()
        {
            cmd = new SqlCommand(" SELECT " +
                                 "id_loco_in" +
                                 ",type_id" +
                                 ",loco_id" +
                                 ",Convert(varchar(10),a_date,101) as \"a_date\"" +
                                 ",Convert(varchar(10),a_time,101) as \"a_time\"" +
                                 ",sid" +
                                 ",desc_sche" +
                                 ",tid" +
                                 ",Convert(varchar(10),l_date,101) as \"l_date\"" +
                                 ",l_sch" +
                                 ",hq" +
                                 ",sname" +
                                 ",l_oil" +
                                 ",f_level" +
                                 ",d_book" +
                                 ",r_key" +
                                 ",d_set" +
                                 ",f_ext" +
                                 ",tnc_name" +
                                 ",Convert(varchar(10),shift_date,101) as \"shit date\"" +
                                 ",booked " +
                                 ",\"action\" " +
                                 "FROM jos_railway_loco_in " +
                                 "WHERE id_loco_in='" + this.id_loco_in + "'", cnn);
            dt = new DataTable();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;
        }

        public DataTable Select_DataByLocoNo()
        {
            cmd = new SqlCommand(" SELECT " +
                                 "id_loco_in" +
                                 ",type_id" +
                                 ",loco_id" +
                                 ",Convert(varchar(10),a_date,101) as \"a_date\"" +
                                 ",Convert(varchar(10),a_time,101) as \"a_time\"" +
                                 ",sid" +
                                 ",desc_sche" +
                                 ",tid" +
                                 ",Convert(varchar(10),l_date,101) as \"l_date\"" +
                                 ",l_sch" +
                                 ",hq" +
                                 ",sname" +
                                 ",l_oil" +
                                 ",f_level" +
                                 ",d_book" +
                                 ",r_key" +
                                 ",d_set" +
                                 ",f_ext" +
                                 ",tnc_name" +
                                 ",Convert(varchar(10),shift_date,101) as \"shit date\"" +
                                 ",booked " +
                                 ",\"action\" " +
                                 "FROM jos_railway_loco_in " +
                                 "WHERE loco_id='" + this.loco_id + "' order by id_loco_in desc", cnn);
            dt = new DataTable();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;
        }
        public DataTable Select_LocoNo_From_LocoIn()
        {
            //cmd = new SqlCommand("SELECT distinct jos_railway_loco_in.type_id as Class, jos_railway_mst_loco.locono as LocoNo, jos_railway_mst_loco.id_mst_loco as LocoId " +
            //                     "FROM jos_railway_loco_in INNER JOIN " +
            //                     "jos_railway_mst_loco ON jos_railway_loco_in.loco_id = jos_railway_mst_loco.id_mst_loco " +
            //                     "WHERE jos_railway_loco_in.type_id ='" + this.type_id + "'", cnn);
            cmd = new SqlCommand("SELECT DISTINCT jos_railway_mst_loco.locono as \"locono\",jos_railway_mst_loco.id_mst_loco as \"locoid\" FROM jos_railway_mst_loco INNER JOIN jos_railway_loco_in on jos_railway_loco_in.loco_id = jos_railway_mst_loco.id_mst_loco WHERE jos_railway_loco_in.avaibility='True'", cnn);
            dt = new DataTable();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;

        }


        public Int64 Save_LocoWDG(string LocoNo, string LODate, string Train, string DueSchedule, string ADate, string ATime, string LOC, string LFR, string PDC, string REL, string Remarks, string Id_ShedPosition_rpt)
        {
            try
            {
                cmd = new SqlCommand("INSERT INTO rpt_LocoWDG(LocoNo, LODate, Train, DueSchedule, ADate, ATime, LOC, LFR, PDC, REL, Remarks, Id_ShedPosition_rpt)VALUES (@LocoNo, @LODate, @Train, @DueSchedule, @ADate, @ATime, @LOC, @LFR, @PDC, @REL, @Remarks, @Id_ShedPosition_rpt)", cnn);

                cmd.Parameters.AddWithValue("@LocoNo", LocoNo);
                cmd.Parameters.AddWithValue("@LODate", LODate);
                cmd.Parameters.AddWithValue("@Train", Train);
                cmd.Parameters.AddWithValue("@DueSchedule", DueSchedule);
                cmd.Parameters.AddWithValue("@ADate", ADate);
                cmd.Parameters.AddWithValue("@ATime", ATime);
                cmd.Parameters.AddWithValue("@LOC", LOC);
                cmd.Parameters.AddWithValue("@LFR", LFR);
                cmd.Parameters.AddWithValue("@PDC", PDC);
                cmd.Parameters.AddWithValue("@REL", REL);
                cmd.Parameters.AddWithValue("@Remarks", Remarks);
                cmd.Parameters.AddWithValue("@Id_ShedPosition_rpt", Id_ShedPosition_rpt);
                cmd.Connection.Open();
                Int64 n = Convert.ToInt64((cmd.ExecuteNonQuery()));
                cmd.Connection.Close();
                return n;

            }

            catch { throw; }
        }

        public Int64 Insert_rpt_monthly_outage(string o_month, string traget, string actual, string diffrance, string Id_ShedPosition_rpt)
        {
            try
            {
                cmd = new SqlCommand("INSERT INTO rpt_monthly_outage (o_month, traget, actual, diffrance, Id_ShedPosition_rpt)VALUES (@o_month,@traget,@actual,@diffrance,@Id_ShedPosition_rpt)", cnn);
                cmd.Parameters.AddWithValue("@o_month", o_month);
                cmd.Parameters.AddWithValue("@traget", traget);
                cmd.Parameters.AddWithValue("@actual", actual);
                cmd.Parameters.AddWithValue("@diffrance", diffrance);
                cmd.Parameters.AddWithValue("@Id_ShedPosition_rpt", Id_ShedPosition_rpt);
                cmd.Connection.Open();
                Int64 n = Convert.ToInt64((cmd.ExecuteNonQuery()));
                cmd.Connection.Close();
                return n;
            }
            catch { throw; }
        }


        //public DataTable Get_ShedPositionReport()
        //{
        //    cmd = new SqlCommand("SELECT jos_railway_loco_in.id_loco_in " +
        //                        ",jos_railway_mst_loco.locono as \"LOCO NO\" " +
        //                        ",CONVERT(varchar(10),jos_railway_loco_in.l_date,5) as \"LAST OUT DATE\"  " +
        //                        ",jos_railway_loco_in.tid AS \"TRAIN\"  " +
        //                        ",jos_railway_loco_type_schedule.s_type AS \"DUE SCHEDULE\"  " +
        //                        ",CONVERT(varchar(10),jos_railway_loco_in.a_date,5) AS \"DATE\"  " +
        //                        ",jos_railway_loco_in.a_time AS \"TIME\"  " +
        //                        ",jos_railway_loco_in.action AS \"REMARKS\"  " +
        //                        " FROM jos_railway_loco_in INNER JOIN  " +
        //                        "jos_railway_mst_loco ON jos_railway_loco_in.loco_id = jos_railway_mst_loco.id_mst_loco  " +
        //                        "INNER JOIN jos_railway_loco_type_schedule ON jos_railway_loco_in.l_sch = jos_railway_loco_type_schedule.id_loco_sch " +
        //                        "INNER JOIN jos_railway_loco_type ON jos_railway_loco_type.id_ltype = jos_railway_mst_loco.tid " +
        //                        "WHERE jos_railway_loco_in.avaibility='True' AND jos_railway_loco_type.guage='BROAD GUAGE'" +
        //                        "order by jos_railway_loco_in.a_date asc ", cnn);
        //    da = new SqlDataAdapter();
        //    da.SelectCommand = cmd;
        //    dt = new DataTable();
        //    dt.Clear();
        //    da.Fill(dt);
        //    return dt;
        //}
        public DataTable Get_ShedPositionReport_Date_Wise(string RDate)
        {
            //cmd = new SqlCommand("SELECT LocoNo as \"LOCO NO\" , LODate as \"LAST OUT DATE\", Train as \"TRAIN\" , DueSchedule as \"DUE SCHEDULE\",ADate as \"DATE\", ATime as \"TIME\" ,LOC , LFR, PDC , REL ,Remarks as \"REMARKS\" FROM rpt_LocoWDG", cnn);
            //cmd = new SqlCommand("SELECT Saved_ShedPositionReport.Id_ShedPosition_rpt, Saved_ShedPositionReport.ReportDate, rpt_LocoWDG.rpt_LocoWDG4_ID, rpt_LocoWDG.LocoNo, rpt_LocoWDG.LODate, rpt_LocoWDG.Train, rpt_LocoWDG.DueSchedule, rpt_LocoWDG.ADate, rpt_LocoWDG.ATime, rpt_LocoWDG.LOC, rpt_LocoWDG.LFR, rpt_LocoWDG.PDC, rpt_LocoWDG.REL, rpt_LocoWDG.Remarks, rpt_LocoWDG.Id_ShedPosition_rpt AS Expr1 FROM         Saved_ShedPositionReport INNER JOIN rpt_LocoWDG ON Saved_ShedPositionReport.Id_ShedPosition_rpt = rpt_LocoWDG.Id_ShedPosition_rpt where Saved_ShedPositionReport.ReportDate='" + RDate + "'", cnn);
            cmd = new SqlCommand("SELECT Saved_ShedPositionReport.Id_ShedPosition_rpt, Saved_ShedPositionReport.ReportDate, rpt_LocoWDG.rpt_LocoWDG4_ID, rpt_LocoWDG.LocoNo as \"LOCO NO\" , rpt_LocoWDG.LODate as \"LAST OUT DATE\", rpt_LocoWDG.Train as \"TRAIN\", rpt_LocoWDG.DueSchedule  as \"DUE SCHEDULE\", rpt_LocoWDG.ADate  as \"DATE\", rpt_LocoWDG.ATime  as \"TIME\", rpt_LocoWDG.LOC, rpt_LocoWDG.LFR, rpt_LocoWDG.PDC, rpt_LocoWDG.REL, rpt_LocoWDG.Remarks as \"REMARKS\", rpt_LocoWDG.Id_ShedPosition_rpt AS Expr1 FROM         Saved_ShedPositionReport INNER JOIN rpt_LocoWDG ON Saved_ShedPositionReport.Id_ShedPosition_rpt = rpt_LocoWDG.Id_ShedPosition_rpt where Saved_ShedPositionReport.ReportDate='" + RDate + "'", cnn);
            dt = new DataTable();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;
        }


        public DataTable Get_DeadOnLine_Date_Wise(string RDate)
        {
            cmd = new SqlCommand("SELECT     Saved_ShedPositionReport.Id_ShedPosition_rpt, Saved_ShedPositionReport.ReportDate, rpt_LineMessage.rpt_LineMessage_Id, rpt_LineMessage.LocoNo, rpt_LineMessage.LDate, rpt_LineMessage.d_or_W, rpt_LineMessage.TrnoLoad, rpt_LineMessage.Grad, rpt_LineMessage.ReportedReason, rpt_LineMessage.LastSchedule, rpt_LineMessage.Id_ShedPosition_rpt AS Expr1 FROM         Saved_ShedPositionReport INNER JOIN  rpt_LineMessage ON rpt_LineMessage.Id_ShedPosition_rpt=Saved_ShedPositionReport.Id_ShedPosition_rpt where Saved_ShedPositionReport.ReportDate='" + RDate + "'", cnn);
            dt = new DataTable();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;
        }

        public DataTable Get_dl2_Date_Wise(string RDate)
        {
            cmd = new SqlCommand("SELECT     rpt_dl1.id_dl1, rpt_dl1.Locono, rpt_dl1.Schedule, rpt_dl1.ScheduleDate, rpt_dl1.Id_ShedPosition_rpt, Saved_ShedPositionReport.Id_ShedPosition_rpt AS Expr1, Saved_ShedPositionReport.ReportDate FROM         rpt_dl1 INNER JOIN  Saved_ShedPositionReport ON rpt_dl1.Id_ShedPosition_rpt = Saved_ShedPositionReport.Id_ShedPosition_rpt where Saved_ShedPositionReport.ReportDate='" + RDate + "' ", cnn);
            dt = new DataTable();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;
        }
        public DataTable Get_dl1_Date_Wise(string RDate)
        {
            cmd = new SqlCommand(" SELECT  rpt_o1_2.id_o1_2, rpt_o1_2.Locono, rpt_o1_2.Schedule, rpt_o1_2.ScheduleDate, rpt_o1_2.Id_ShedPosition_rpt, Saved_ShedPositionReport.Id_ShedPosition_rpt AS Expr1, Saved_ShedPositionReport.ReportDate FROM         rpt_o1_2 INNER JOIN Saved_ShedPositionReport ON rpt_o1_2.Id_ShedPosition_rpt = Saved_ShedPositionReport.Id_ShedPosition_rpt where Saved_ShedPositionReport.ReportDate='" + RDate + "' ", cnn);

            dt = new DataTable();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;
        }
        public DataTable Get_gv5_Date_Wise(string RDate)
        {
            cmd = new SqlCommand("SELECT  rpt_o1_1.id_o1_1, rpt_o1_1.Locono, rpt_o1_1.Schedule, rpt_o1_1.ScheduleDate, rpt_o1_1.Id_ShedPosition_rpt, Saved_ShedPositionReport.Id_ShedPosition_rpt AS Expr1, Saved_ShedPositionReport.ReportDate FROM  rpt_o1_1 INNER JOIN  Saved_ShedPositionReport ON rpt_o1_1.Id_ShedPosition_rpt = Saved_ShedPositionReport.Id_ShedPosition_rpt where Saved_ShedPositionReport.ReportDate='" + RDate + "' ", cnn);
            dt = new DataTable();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;
        }
        public DataTable Get_Monthly_outage_Date_Wise(string RDate)
        {
            //cmd = new SqlCommand("SELECT     rpt_monthly_outage.Id_monthlyOutage, rpt_monthly_outage.o_month, rpt_monthly_outage.traget, rpt_monthly_outage.actual, rpt_monthly_outage.diffrance, rpt_monthly_outage.Id_ShedPosition_rpt, Saved_ShedPositionReport.Id_ShedPosition_rpt AS Expr1, Saved_ShedPositionReport.ReportDate FROM         rpt_monthly_outage INNER JOIN Saved_ShedPositionReport ON rpt_monthly_outage.Id_ShedPosition_rpt =Saved_ShedPositionReport.Id_ShedPosition_rpt where Saved_ShedPositionReport.ReportDate='" + RDate + "'", cnn);
            cmd = new SqlCommand("SELECT     rpt_monthly_outage.Id_monthlyOutage, rpt_monthly_outage.o_month as \"Month\", rpt_monthly_outage.traget as \"Target\" , rpt_monthly_outage.actual as \"Actual\", rpt_monthly_outage.diffrance, rpt_monthly_outage.Id_ShedPosition_rpt, Saved_ShedPositionReport.Id_ShedPosition_rpt AS Expr1, Saved_ShedPositionReport.ReportDate FROM         rpt_monthly_outage INNER JOIN Saved_ShedPositionReport ON rpt_monthly_outage.Id_ShedPosition_rpt =Saved_ShedPositionReport.Id_ShedPosition_rpt where Saved_ShedPositionReport.ReportDate='" + RDate + "'", cnn);

            dt = new DataTable();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;
        }

        public DataTable Get_gv4_Date_Wise(string RDate)
        {
            cmd = new SqlCommand("SELECT  rpt_dl11.id_dl11, rpt_dl11.Locono, rpt_dl11.Schedule, rpt_dl11.ScheduleDate, rpt_dl11.Id_ShedPosition_rpt, Saved_ShedPositionReport.Id_ShedPosition_rpt AS Expr1,Saved_ShedPositionReport.ReportDate FROM rpt_dl11 INNER JOIN Saved_ShedPositionReport ON rpt_dl11.Id_ShedPosition_rpt = Saved_ShedPositionReport.Id_ShedPosition_rpt where Saved_ShedPositionReport.ReportDate='" + RDate + "'", cnn);

            dt = new DataTable();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;
        }
        public DataTable Get_outage_Date_Wise(string RDate)
        {
            cmd = new SqlCommand("SELECT rpt_Outage.IdOutage, rpt_Outage.bgh1, rpt_Outage.bgh2, rpt_Outage.bgf1, rpt_Outage.bgf2, rpt_Outage.bgf3, rpt_Outage.bgd, rpt_Outage.mgh1, rpt_Outage.mgh2, rpt_Outage.mgf1, rpt_Outage.mgf2, rpt_Outage.mgf3, rpt_Outage.mgf4, rpt_Outage.mfd, rpt_Outage.mghr, rpt_Outage.bghr, rpt_Outage.mglr, rpt_Outage.bglr, rpt_Outage.mgur, rpt_Outage.bgur, rpt_Outage.mgdead, rpt_Outage.bgdead, rpt_Outage.mgdiv, rpt_Outage.bgdiv, rpt_Outage.mglie, rpt_Outage.bglie, rpt_Outage.mgnet1, rpt_Outage.mgnet2, rpt_Outage.bgnet1, rpt_Outage.bgnet2, rpt_Outage.mgsr, rpt_Outage.mgloc, rpt_Outage.mggear, rpt_Outage.mgcompress, rpt_Outage.mgfuel, rpt_Outage.mgrunning, rpt_Outage.Id_ShedPosition_rpt, Saved_ShedPositionReport.Id_ShedPosition_rpt AS Expr1, Saved_ShedPositionReport.ReportDate FROM   rpt_Outage INNER JOIN  Saved_ShedPositionReport ON rpt_Outage.Id_ShedPosition_rpt=Saved_ShedPositionReport.Id_ShedPosition_rpt WHERE Saved_ShedPositionReport.ReportDate='" + RDate + "'", cnn);
            cmd.Parameters.AddWithValue("@bgh1", bgh1);
            cmd.Parameters.AddWithValue("@bgh2", bgh2);
            cmd.Parameters.AddWithValue("@bgf1", bgf1);
            cmd.Parameters.AddWithValue("@bgf2", bgf2);
            cmd.Parameters.AddWithValue("@bgf3", bgf3);
            cmd.Parameters.AddWithValue("@bgd", bgd);
            cmd.Parameters.AddWithValue("@mgh1", mgh1);
            cmd.Parameters.AddWithValue("@mgh2", mgh2);
            cmd.Parameters.AddWithValue("@mgf1", mgf1);
            cmd.Parameters.AddWithValue("@mgf2", mgf2);
            cmd.Parameters.AddWithValue("@mgf3", mgf3);
            cmd.Parameters.AddWithValue("@mgf4", mgf4);
            cmd.Parameters.AddWithValue("@mfd", mfd);
            //--------------------------------------------------------------
            cmd.Parameters.AddWithValue("@mghr", mghr);
            cmd.Parameters.AddWithValue("@bghr", bghr);
            cmd.Parameters.AddWithValue("@mglr", mglr);
            cmd.Parameters.AddWithValue("@bglr", bglr);
            cmd.Parameters.AddWithValue("@mgur", mgur);
            cmd.Parameters.AddWithValue("@bgur", bgur);
            cmd.Parameters.AddWithValue("@mgdead", mgdead);
            cmd.Parameters.AddWithValue("@bgdead", bgdead);
            cmd.Parameters.AddWithValue("@mgdiv", mgdiv);
            cmd.Parameters.AddWithValue("@bgdiv", bgdiv);
            cmd.Parameters.AddWithValue("@mglie", mglie);
            cmd.Parameters.AddWithValue("@bglie", bglie);
            cmd.Parameters.AddWithValue("@mgnet1", mgnet1);
            cmd.Parameters.AddWithValue("@mgnet2", mgnet2);
            cmd.Parameters.AddWithValue("@bgnet1", bgnet1);
            cmd.Parameters.AddWithValue("@bgnet2", bgnet2);
            cmd.Parameters.AddWithValue("@mgsr", mgsr);
            cmd.Parameters.AddWithValue("@mgloc", mgloc);
            cmd.Parameters.AddWithValue("@mggear", mggear);
            cmd.Parameters.AddWithValue("@mgcompress", mgcompress);
            cmd.Parameters.AddWithValue("@mgfuel", mgfuel);
            cmd.Parameters.AddWithValue("@mgrunning", mgrunning);

            dt = new DataTable();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;
        }
        public DataTable Get_temprepair_Date_Wise(string RDate)
        {
            //cmd = new SqlCommand("SELECT Saved_ShedPositionReport.Id_ShedPosition_rpt, Saved_ShedPositionReport.ReportDate, rpt_EmdTempRepair.rpt_EmdTempRepair, rpt_EmdTempRepair.LocoNo, rpt_EmdTempRepair.Site, rpt_EmdTempRepair.Section, rpt_EmdTempRepair.Reason, rpt_EmdTempRepair.Remarks, rpt_EmdTempRepair.Id_ShedPosition_rpt AS Expr1 FROM         rpt_EmdTempRepair INNER JOIN Saved_ShedPositionReport ON rpt_EmdTempRepair.Id_ShedPosition_rpt=Saved_ShedPositionReport.Id_ShedPosition_rpt WHERE Saved_ShedPositionReport.ReportDate='" + RDate + "'", cnn);
            cmd = new SqlCommand("SELECT Saved_ShedPositionReport.Id_ShedPosition_rpt, Saved_ShedPositionReport.ReportDate, rpt_EmdTempRepair.rpt_EmdTempRepair, rpt_EmdTempRepair.LocoNo as \"locono\", rpt_EmdTempRepair.Site as \"site\", rpt_EmdTempRepair.Section as \"section\", rpt_EmdTempRepair.Reason as \"reason\", rpt_EmdTempRepair.Remarks as \"remarks\", rpt_EmdTempRepair.Id_ShedPosition_rpt AS Expr1 FROM         rpt_EmdTempRepair INNER JOIN Saved_ShedPositionReport ON rpt_EmdTempRepair.Id_ShedPosition_rpt=Saved_ShedPositionReport.Id_ShedPosition_rpt WHERE Saved_ShedPositionReport.ReportDate='" + RDate + "'", cnn);
            dt = new DataTable();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;
        }
        public DataTable Get_ShedPositionReport()
        {
            cmd = new SqlCommand("SELECT jos_railway_loco_in.id_loco_in " +
                                ",jos_railway_mst_loco.locono as \"LOCO NO\" " +
                                ",CONVERT(varchar(10),jos_railway_loco_in.l_date,5) as \"LAST OUT DATE\"  " +
                                ",jos_railway_loco_in.tid AS \"TRAIN\"  " +
                                ",jos_railway_loco_type_schedule.s_type AS \"DUE SCHEDULE\"  " +
                                ",CONVERT(varchar(5),jos_railway_loco_in.a_date,5) AS \"DATE\"  " +
                                ",CONVERT(varchar(5),jos_railway_loco_in.a_time,7) AS \"TIME\"  " +
                                ",jos_railway_loco_in.action AS \"REMARKS\"  " +
                                " FROM jos_railway_loco_in INNER JOIN  " +
                                "jos_railway_mst_loco ON jos_railway_loco_in.loco_id = jos_railway_mst_loco.id_mst_loco  " +
                                "INNER JOIN jos_railway_loco_type_schedule ON jos_railway_loco_in.sid = jos_railway_loco_type_schedule.id_loco_sch " +
                                "INNER JOIN jos_railway_loco_type ON jos_railway_loco_type.id_ltype = jos_railway_mst_loco.tid " +
                                "WHERE jos_railway_loco_in.avaibility='True' AND jos_railway_loco_type.guage='BROAD GUAGE'" +
                                "order by jos_railway_loco_in.a_date asc ", cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            return dt;
        }
        public DataTable MG_Get_ShedPositionReport()
        {
            //Show shedposition report form Meter guage locos
            cmd = new SqlCommand("SELECT jos_railway_loco_in.id_loco_in  " +
                                 ",jos_railway_mst_loco.locono as  \"LOCO NO\"  " +
                                 ",jos_railway_loco_in_mg.WheelDia as \"WHEEL DIAMETER\" " +
                                 ",jos_railway_loco_in_mg.Pass as \"PASS\" " +
                                 ",jos_railway_loco_in.tid AS  \"TRAIN\" " +
                                 ",jos_railway_loco_type_schedule.s_type AS  \"DUE SCHEDULE\" " +
                                 ",CONVERT(varchar(10),jos_railway_loco_in.a_date,5) AS  \"DATE\"   " +
                                 ",jos_railway_loco_in.a_time AS  \"TIME\"   " +
                                 ",CONVERT(VARCHAR(10),jos_railway_loco_in_mg.PDC,105) as \"PDC\" " +
                                 ",jos_railway_loco_in.booked AS \"REMARKS\"  " +
                                 "FROM jos_railway_loco_in  " +
                                 "INNER JOIN jos_railway_mst_loco ON jos_railway_loco_in.loco_id = jos_railway_mst_loco.id_mst_loco   " +
                                 "INNER JOIN jos_railway_loco_type_schedule ON jos_railway_loco_in.l_sch = jos_railway_loco_type_schedule.id_loco_sch  " +
                                 "INNER JOIN jos_railway_loco_type ON jos_railway_loco_type.id_ltype = jos_railway_mst_loco.tid " +
                                 "INNER JOIN jos_railway_loco_in_mg ON  jos_railway_loco_in_mg.id_loco_in = jos_railway_loco_in.id_loco_in " +
                                 "WHERE jos_railway_loco_in.avaibility='True' AND jos_railway_loco_type.guage='METER GUAGE' " +
                                 "order by jos_railway_loco_in.a_date asc", cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            return dt;
        }
        public DataTable Get_ShedPositionReport(string s)
        {
            cmd = new SqlCommand("SELECT jos_railway_loco_in.id_loco_in " +
                                ",jos_railway_mst_loco.locono as \"LOCO NO\" " +
                                ",CONVERT(varchar(10),jos_railway_loco_in.l_date,5) as \"LAST OUT DATE\" " +
                                ",jos_railway_loco_in.tid AS \"TRAIN\" " +
                                ",jos_railway_loco_in.l_sch AS \"DUE SCHEDULE\" " +
                                ",CONVERT(varchar(10),jos_railway_loco_in.a_date,5) AS \"DATE\" " +
                                ",jos_railway_loco_in.a_time AS \"TIME\" " +
                                ",jos_railway_loco_in.booked AS \"REMARKS\" " +
                                " FROM jos_railway_loco_in INNER JOIN " +
                                "jos_railway_mst_loco ON jos_railway_loco_in.loco_id = jos_railway_mst_loco.id_mst_loco " +
                                "WHERE jos_railway_loco_in.id_loco_in in(" + s + ") ORDER BY jos_railway_loco_in.id_loco_in asc ", cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);

            return dt;
        }
        public bool Check_Loco_Avaibility()
        {
            cmd = new SqlCommand("SELECT COUNT(*) FROM jos_railway_loco_in WHERE loco_id='" + this.loco_id + "' AND avaibility='true'", cnn);
            cmd.Connection.Open();
            int n = Convert.ToInt16(cmd.ExecuteScalar());
            cmd.Connection.Close();
            return n == 1 ? true : false;
        }
        public void Make_Loco_Unavailable()
        {
            cmd = new SqlCommand("UPDATE jos_railway_loco_in SET avaibility='false' WHERE loco_id='" + this.loco_id + "'", cnn);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public void Update_BookedToRemarks(string id)
        {
            cmd = new SqlCommand("UPDATE jos_railway_loco_in SET \"action\"=(SELECT booked FROM jos_railway_loco_in WHERE id_loco_in='" + id + "') WHERE id_loco_in='" + id + "'", cnn);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();


        }
        public DataTable Get_TemporaryRepairData(string locoId)
        {
            cmd = new SqlCommand("SELECT jos_railway_mst_loco.locono as  \"locono\" " +
                                 ",jos_railway_Loco_Temporary_Repair.Id_Loco_Temp_Repair  \"rid\" " +
                                 ",jos_railway_mst_site.Site_Name  \"site\"  " +
                                 ",jos_railway_mst_SiteSection.SiteSectionName  \"section\" " +
                                 ",jos_railway_Loco_Temporary_Repair.Reason  \"reason\"  " +
                                 ",jos_railway_Loco_Temporary_Repair.Remarks  \"remarks\"  " +
                                 "FROM jos_railway_Loco_Temporary_Repair  " +
                                 "INNER JOIN jos_railway_mst_loco ON jos_railway_Loco_Temporary_Repair.Id_Loco = jos_railway_mst_loco.id_mst_loco  " +
                                 "INNER JOIN jos_railway_mst_site ON jos_railway_mst_site.Id_Site = jos_railway_Loco_Temporary_Repair.Id_Site  " +
                                 "INNER JOIN jos_railway_mst_SiteSection ON jos_railway_mst_SiteSection.Id_SiteSection = jos_railway_Loco_Temporary_Repair.Id_SiteSection   " +
                                 "WHERE jos_railway_Loco_Temporary_Repair.id_loco_Temp_Repair=(SELECT MAX(id_Loco_Temp_Repair) FROM jos_railway_Loco_Temporary_Repair WHERE Id_Loco=@Id_Loco AND avaibility='true')", cnn);

            cmd.Parameters.AddWithValue("@Id_Loco", locoId);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            return dt;
        }
        public DataTable Get_DeadOnlineData(string locoId)
        {
            cmd = new SqlCommand("SELECT jos_railway_shed_pos3.id_shed_Pos3 AS \"rid\" " +
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
"WHERE jos_railway_shed_pos3.id_shed_Pos3 = (SELECT MAX(id_shed_Pos3) FROM jos_railway_shed_pos3 WHERE Loco_id=@Loco_id AND avaibility='true')", cnn);
            cmd.Parameters.AddWithValue("@Loco_id", locoId);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            return dt;
        }



        public string Select_Data(string locono)
        {
            cmd = new SqlCommand("select jos_railway_loco_in.id_loco_in " +
                    " from jos_railway_loco_in INNER JOIN jos_railway_mst_loco ON " +
                    " jos_railway_loco_in.loco_id = jos_railway_mst_loco.id_mst_loco " +
                    " WHERE jos_railway_mst_loco.locono ='" + locono + "'", cnn);
            cmd.Connection.Open();
            string n = Convert.ToString(cmd.ExecuteScalar());
            cmd.Connection.Close();
            return n;

        }
    }


}

















































































































































































































































































































































