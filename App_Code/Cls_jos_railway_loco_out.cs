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
    public class Cls_jos_railway_loco_out : Cls_DBConnection
    {
        public string id_loco_out;
        public string type_id;
        public string loco_id;
        public string a_date;
        public string a_time;
        public string sid;
        public string desc_sche;
        public string tid;
        public string hq;
        public string sname;
        public string l_oil;
        public string f_level;
        public string d_book;
        public string r_key;
        public string d_set;
        public string f_ext;
        public string tnc_name;
        public string shift_date;
        public string booked;
        public string action;
        public Cls_jos_railway_loco_out()
        {
            //Declare Connection
            //cnn = new SqlConnection(@"Data Source = DWPL1\SOFTWARE; Initial Catalog=sbidiesel; User ID=bharat; Password=bharat;");

        }
        public Int64 Insert_Data()
        {
            Int64 n = 0;
            try
            {
                cmd = new SqlCommand("SELECT COUNT(*) FROM jos_railway_loco_out", cnn);
                cmd.Connection.Open();
                n = Convert.ToInt64(cmd.ExecuteScalar());
                cmd.Connection.Close();

                cmd = new SqlCommand("INSERT INTO jos_railway_loco_out(type_id,loco_id,a_date,a_time,sid,desc_sche,tid,hq,sname,l_oil,f_level,d_book,r_key,d_set,f_ext,tnc_name,shift_date,booked,action) VALUES (@type_id,@loco_id,@a_date,@a_time,@sid,@desc_sche,@tid,@hq,@sname,@l_oil,@f_level,@d_book,@r_key,@d_set,@f_ext,@tnc_name,@shift_date,@booked,@action)", cnn);
                cmd.Parameters.AddWithValue("@type_id", this.type_id);
                cmd.Parameters.AddWithValue("@loco_id", this.loco_id);
                cmd.Parameters.AddWithValue("@a_date", this.a_date);
                cmd.Parameters.AddWithValue("@a_time", this.a_time);
                cmd.Parameters.AddWithValue("@sid", this.sid);
                cmd.Parameters.AddWithValue("@desc_sche", this.desc_sche);
                cmd.Parameters.AddWithValue("@tid", this.tid);
                cmd.Parameters.AddWithValue("@hq", this.hq);
                cmd.Parameters.AddWithValue("@sname", this.sname);
                cmd.Parameters.AddWithValue("@l_oil", this.l_oil);
                cmd.Parameters.AddWithValue("@f_level", this.f_level);
                cmd.Parameters.AddWithValue("@d_book", this.d_book);
                cmd.Parameters.AddWithValue("@r_key", this.r_key);
                cmd.Parameters.AddWithValue("@d_set", this.d_set);
                cmd.Parameters.AddWithValue("@f_ext", this.f_ext);
                cmd.Parameters.AddWithValue("@tnc_name", this.tnc_name);
                cmd.Parameters.AddWithValue("@shift_date", this.shift_date);
                cmd.Parameters.AddWithValue("@booked", this.booked);
                cmd.Parameters.AddWithValue("@action", this.action);
                cmd.Connection.Open();
                int m = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                if (m > 0)
                {
                    cmd = new SqlCommand("SELECT MAX(id_loco_out) FROM jos_railway_loco_out", cnn);
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
                cmd = new SqlCommand("DELETE FROM jos_railway_loco_out  WHERE (id_loco_out=@id_loco_out)", cnn);
                cmd.Parameters.AddWithValue("@id_loco_out", this.id_loco_out);
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
                cmd = new SqlCommand(" UPDATE jos_railway_loco_out SET type_id=@type_id,loco_id=@loco_id,a_date=@a_date,a_time=@a_time,sid=@sid,desc_sche=@desc_sche,tid=@tid,hq=@hq,sname=@sname,l_oil=@l_oil,f_level=@f_level,d_book=@d_book,r_key=@r_key,d_set=@d_set,f_ext=@f_ext,tnc_name=@tnc_name,shift_date=@shift_date,booked=@booked,action=@action WHERE id_loco_out=@id_loco_out ", cnn);
                cmd.Parameters.AddWithValue("@id_loco_out", this.id_loco_out);
                cmd.Parameters.AddWithValue("@type_id", this.type_id);
                cmd.Parameters.AddWithValue("@loco_id", this.loco_id);
                cmd.Parameters.AddWithValue("@a_date", this.a_date);
                cmd.Parameters.AddWithValue("@a_time", this.a_time);
                cmd.Parameters.AddWithValue("@sid", this.sid);
                cmd.Parameters.AddWithValue("@desc_sche", this.desc_sche);
                cmd.Parameters.AddWithValue("@tid", this.tid);
                cmd.Parameters.AddWithValue("@hq", this.hq);
                cmd.Parameters.AddWithValue("@sname", this.sname);
                cmd.Parameters.AddWithValue("@l_oil", this.l_oil);
                cmd.Parameters.AddWithValue("@f_level", this.f_level);
                cmd.Parameters.AddWithValue("@d_book", this.d_book);
                cmd.Parameters.AddWithValue("@r_key", this.r_key);
                cmd.Parameters.AddWithValue("@d_set", this.d_set);
                cmd.Parameters.AddWithValue("@f_ext", this.f_ext);
                cmd.Parameters.AddWithValue("@tnc_name", this.tnc_name);
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
            cmd = new SqlCommand("SELECT " +
              "jos_railway_loco_out.id_loco_out as \"id\"" +
            ", jos_railway_loco_type.loco_type as \"Class\"" +
            ", jos_railway_mst_loco.locono as \"Loco No\"" +
            ", Convert(varchar(10),jos_railway_loco_out.a_date,105) as \"Out Date\"" +
            ", jos_railway_loco_out.a_time as \"Out time\"" +
            ", jos_railway_loco_type_schedule.s_type as \"Schedule\"" +
            ", jos_railway_loco_out.desc_sche as \"Description\"" +
            ", jos_railway_loco_out.tid as \"Train No\" " +
            ", jos_railway_loco_type_schedule.s_type as \"Last Schedule\" " +
            ", jos_railway_mst_hq.\"name\" as \"HQ\"" +
            ", jos_railway_loco_out.sname as \"Driver name\" " +
            ", jos_railway_loco_out.l_oil as \"Oil Level\" " +
            ", jos_railway_loco_out.f_level as \"Fule Level\" " +
            ", jos_railway_loco_out.d_book as \"Driver book\"" +
            ", jos_railway_loco_out.r_key as \"Reverser Key\"" +
            ", jos_railway_loco_out.d_set as \"Dep Set\"" +
            ", jos_railway_loco_out.f_ext as \"Fire Ext\" " +
            ",(jos_railway_Hr.surname + ' ' + jos_railway_Hr.fullname + ' ' + jos_railway_Hr.father_name) as tncname " +
            ", Convert(varchar(10),jos_railway_loco_out.shift_date,101) as \"Shift Date\"" +
            ", jos_railway_loco_out.booked as \"Booked Repairs\"" +
            ", jos_railway_loco_out.\"action\" as \"Action Taken\"" +
            "FROM  jos_railway_loco_out " +
            " INNER JOIN jos_railway_loco_type ON jos_railway_loco_out.type_id = jos_railway_loco_type.id_ltype " +
            " INNER JOIN jos_railway_loco_type_schedule ON jos_railway_loco_out.sid = jos_railway_loco_type_schedule.id_loco_sch " +
            " INNER JOIN jos_railway_mst_hq ON jos_railway_loco_out.hq = jos_railway_mst_hq.id_mst_hq " +
            " INNER JOIN jos_railway_Hr ON jos_railway_loco_out.tnc_name = jos_railway_Hr.id_hr " +
            " INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = jos_railway_loco_out.loco_id", cnn);

            dt = new DataTable();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;
        }
        public DataTable Select_Data(string loco,string outdate)
        {
            string Commandstr = "SELECT " +
                  "jos_railway_loco_out.id_loco_out as \"id\"" +
                ", jos_railway_loco_type.loco_type as \"Class\"" +
                ", jos_railway_mst_loco.locono as \"Loco No\"" +
                ", Convert(varchar(10),jos_railway_loco_out.a_date,105) as \"Out Date\"" +
                ", jos_railway_loco_out.a_time as \"Out time\"" +
                ", jos_railway_loco_type_schedule.s_type as \"Schedule\"" +
                ", jos_railway_loco_out.desc_sche as \"Description\"" +
                ", jos_railway_loco_out.tid as \"Train No\" " +
                ", jos_railway_loco_type_schedule.s_type as \"Last Schedule\" " +
                ", jos_railway_mst_hq.\"name\" as \"HQ\"" +
                ", jos_railway_loco_out.sname as \"Driver name\" " +
                ", jos_railway_loco_out.l_oil as \"Oil Level\" " +
                ", jos_railway_loco_out.f_level as \"Fule Level\" " +
                ", jos_railway_loco_out.d_book as \"Driver book\"" +
                ", jos_railway_loco_out.r_key as \"Reverser Key\"" +
                ", jos_railway_loco_out.d_set as \"Dep Set\"" +
                ", jos_railway_loco_out.f_ext as \"Fire Ext\" " +
                ",(jos_railway_Hr.surname + ' ' + jos_railway_Hr.fullname + ' ' + jos_railway_Hr.father_name) as tncname " +
                ", Convert(varchar(10),jos_railway_loco_out.shift_date,101) as \"Shift Date\"" +
                ", jos_railway_loco_out.booked as \"Booked Repairs\"" +
                ", jos_railway_loco_out.\"action\" as \"Action Taken\"" +
                "FROM  jos_railway_loco_out " +
                " INNER JOIN jos_railway_loco_type ON jos_railway_loco_out.type_id = jos_railway_loco_type.id_ltype " +
                " INNER JOIN jos_railway_loco_type_schedule ON jos_railway_loco_out.sid = jos_railway_loco_type_schedule.id_loco_sch " +
                " INNER JOIN jos_railway_mst_hq ON jos_railway_loco_out.hq = jos_railway_mst_hq.id_mst_hq " +
                " INNER JOIN jos_railway_Hr ON jos_railway_loco_out.tnc_name = jos_railway_Hr.id_hr " +
                " INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = jos_railway_loco_out.loco_id";
            if (loco != "")
            {
                Commandstr += (" WHERE jos_railway_loco_out.loco_id='" + loco + "'");
            }
            if (loco != "" && outdate != "")
            {
               Commandstr += " AND jos_railway_loco_out.a_date='" + outdate + "'";
            }
            cmd = new SqlCommand(Commandstr, cnn);
            dt = new DataTable();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;
        }

        public DataTable Select_DataByID2()
        {
            cmd = new SqlCommand("SELECT " +
            " jos_railway_loco_out.id_loco_out as  \"id\" " +
            ", jos_railway_loco_type.loco_type as  \"Class\" " +
            ", jos_railway_mst_loco.locono as  \"Loco No\" " +
            ", Convert(varchar(10),jos_railway_loco_out.a_date,101) as  \"Out Date\" " +
            ", jos_railway_loco_out.a_time as  \"Out time\" " +
            ", jos_railway_loco_type_schedule.s_type as  \"Schedule\" " +
            ", jos_railway_loco_out.desc_sche as  \"Description\" " +
            ", jos_railway_loco_out.tid as  \"Train No\"  " +
            ", jos_railway_loco_type_schedule.s_type as  \"Last Schedule\" " +
            ", jos_railway_mst_hq.\"name\" as  \"HQ\" " +
            ", jos_railway_loco_out.sname as  \"Driver name\"  " +
            ", jos_railway_loco_out.l_oil as  \"Oil Level\"  " +
            ", jos_railway_loco_out.f_level as  \"Fule Level\"  " +
            ", jos_railway_loco_out.d_book as  \"Driver book\" " +
            ", jos_railway_loco_out.r_key as  \"Reverser Key\" " +
            ", jos_railway_loco_out.d_set as  \"Dep Set\" " +
            ", jos_railway_loco_out.f_ext as \"Fire Ext\"  " +
            ",(jos_railway_Hr.surname + ' ' + jos_railway_Hr.fullname + ' ' + jos_railway_Hr.father_name) as tncname " +
            ", Convert(varchar(10),jos_railway_loco_out.shift_date,101) as  \"Shift Date\" " +
            ", jos_railway_loco_out.booked as  \"Booked Repairs\" " +
            ", jos_railway_loco_out. \"action \" as  \"Action Taken\" " +
            "  FROM  jos_railway_loco_out " +
            " INNER JOIN jos_railway_loco_type ON jos_railway_loco_out.type_id = jos_railway_loco_type.id_ltype " +
            " INNER JOIN jos_railway_loco_type_schedule ON jos_railway_loco_out.sid = jos_railway_loco_type_schedule.id_loco_sch  " +
            " INNER JOIN jos_railway_mst_hq ON jos_railway_loco_out.hq = jos_railway_mst_hq.id_mst_hq  " +
            " INNER JOIN jos_railway_Hr ON jos_railway_loco_out.tnc_name = jos_railway_Hr.id_hr " +
            " INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = jos_railway_loco_out.loco_id " +
            "WHERE id_loco_out = '" + this.id_loco_out + "'", cnn);

            dt = new DataTable();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;
        }
        public DataTable Select_DataById()
        {
            cmd = new SqlCommand("SELECT " +
            "id_loco_out " +
            ",type_id " +
            ",loco_id " +
            ",CONVERT(VARCHAR(10),a_date,101) AS \"A_DATE\" " +
            ",CONVERT(VARCHAR(10),a_time,101) AS \"A_TIME\" " +
            ",sid " +
            ",desc_sche " +
            ",tid " +
            ",hq " +
            ",sname " +
            ",l_oil " +
            ",f_level " +
            ",d_book " +
            ",r_key " +
            ",d_set " +
            ",f_ext " +
            ",tnc_name " +
            ",CONVERT(VARCHAR(10),shift_date,101) AS \"Shift Date\" " +
            ",booked " +
            ",\"action\" " +
            " FROM jos_railway_loco_out WHERE jos_railway_loco_out.id_loco_out='" + this.id_loco_out + "'", cnn);
            da = new SqlDataAdapter();
            dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
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
        public DataTable Select_LocoNo(string guage)
        {
            cmd = new SqlCommand("SELECT locono from jos_railway_mst_loco WHERE tid = '" + guage + "'", cnn);
            da = new SqlDataAdapter();
            dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        public DataTable Select_LocoDetailsFromLocoIn()
        {
            string d = Convert.ToDateTime(this.a_date).ToShortDateString().ToString(); ;
            d = d.Replace("-", "/");
            cmd = new SqlCommand("SELECT " +
              "jos_railway_loco_in.id_loco_in" +
            ", jos_railway_loco_type.loco_type as \"Class\"" +
            ", jos_railway_loco_in.loco_id as \"Loco No\"" +
            ", jos_railway_loco_in.a_date as \"Arrival Date\"" +
            ", jos_railway_loco_in.a_time as \"Arrival time\"" +
            ", jos_railway_loco_type_schedule.s_type as \"Schedule\"" +
            ", jos_railway_loco_in.desc_sche as \"Description\"" +
            ", jos_railway_loco_in.tid as \"Train No\" " +
            ", jos_railway_loco_in.l_date as \"Last Out Date\" " +
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
            ", jos_railway_loco_in.shift_date as \"Shift Date\"" +
            ", jos_railway_loco_in.booked as \"Booked Repairs\"" +
            ", jos_railway_loco_in.\"action\" as \"Action Taken\"" +
            ", jos_railway_mst_loco.\"native\" as \"native\"" +
            "FROM  jos_railway_loco_in " +
            " INNER JOIN jos_railway_loco_type ON jos_railway_loco_in.type_id = jos_railway_loco_type.id_ltype " +
            " INNER JOIN jos_railway_loco_type_schedule ON jos_railway_loco_in.sid = jos_railway_loco_type_schedule.id_loco_sch " +
            " INNER JOIN jos_railway_mst_hq ON jos_railway_loco_in.hq = jos_railway_mst_hq.id_mst_hq " +
            " INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = jos_railway_loco_in.loco_id " +
            " INNER JOIN jos_railway_Hr ON jos_railway_loco_in.tnc_name = jos_railway_Hr.id_hr " +
            "WHERE jos_railway_loco_in.loco_id='" + this.loco_id + "' AND jos_railway_loco_in.a_time='" + this.a_time + "' AND Convert(varchar(10),jos_railway_loco_in.a_date,103)='" + d + "'", cnn);

            dt = new DataTable();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;
        }
        public DataTable Select_LastLocoInDetails()
        {

            cmd = new SqlCommand("SELECT " +
              "jos_railway_loco_in.id_loco_in" +
            ", jos_railway_loco_type.loco_type as \"Class\"" +
            ", jos_railway_loco_in.loco_id as \"Loco No\"" +
            ", jos_railway_loco_in.a_date as \"Out Date\"" +
            ", jos_railway_loco_in.a_time as \"Out time\"" +
            ", jos_railway_loco_type_schedule.s_type as \"Schedule\"" +
            ", jos_railway_loco_in.desc_sche as \"Description\"" +
            ", jos_railway_loco_in.tid as \"Train No\" " +
            ", jos_railway_loco_in.l_date as \"Last Out Date\" " +
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
            ", jos_railway_loco_in.shift_date as \"Shift Date\"" +
            ", jos_railway_loco_in.booked as \"Booked Repairs\"" +
            ", jos_railway_loco_in.\"action\" as \"Action Taken\"" +
            ", jos_railway_mst_loco.\"native\" as \"native\"" +
            "  FROM  jos_railway_loco_in " +
            " INNER JOIN jos_railway_loco_type ON jos_railway_loco_in.type_id = jos_railway_loco_type.id_ltype " +
            " INNER JOIN jos_railway_loco_type_schedule ON jos_railway_loco_in.sid = jos_railway_loco_type_schedule.id_loco_sch " +
            " INNER JOIN jos_railway_mst_hq ON jos_railway_loco_in.hq = jos_railway_mst_hq.id_mst_hq " +
            " INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = jos_railway_loco_in.loco_id " +
            " INNER JOIN jos_railway_Hr ON jos_railway_loco_in.tnc_name = jos_railway_Hr.id_hr " +
            " WHERE jos_railway_loco_in.loco_id='" + this.loco_id + "' order by jos_railway_loco_in.a_date desc ", cnn);

            dt = new DataTable();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;
        }
        public DataTable Select_Class()
        {
            cmd = new SqlCommand("SELECT DISTINCT  jos_railway_loco_type.loco_type,jos_railway_loco_type.id_ltype FROM jos_railway_loco_out INNER JOIN jos_railway_loco_type ON jos_railway_loco_type.id_ltype = jos_railway_loco_out.type_id", cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable Select_Loco()
        {
            cmd = new SqlCommand("SELECT DISTINCT jos_railway_mst_loco.locono,jos_railway_mst_loco.id_mst_loco FROM jos_railway_mst_loco INNER JOIN jos_railway_loco_out ON jos_railway_loco_out.loco_id = jos_railway_mst_loco.id_mst_loco WHERE jos_railway_loco_out.type_id='" + this.tid + "'", cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}






















































































































































































































































































































































