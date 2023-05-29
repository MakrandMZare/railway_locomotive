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

namespace Railway
{
    public class Cls_jos_railway_loco_type_schedule : Cls_DBConnection
    {

        public string id_loco_sch;
        public string loco_id;
        public string s_type;
        public string duration;
        public Cls_jos_railway_loco_type_schedule()
        {
            //Declare Connection
            //cnn = new MySqlConnection(@"SERVER=railwayd.db.4989407.hostedresource.com;DATABASE=railwayd;USER ID=railwayd;PASSWORD=Dhara1980");

        }
        public bool IsDataExists()
        {
            int n = 0;
            cmd = new SqlCommand("SELECT COUNT(id_loco_sch) FROM jos_railway_loco_type_schedule WHERE loco_id='" + this.loco_id + "' AND s_type='" + this.s_type + "'", cnn);
            cmd.Connection.Open();
            n = Convert.ToInt16(cmd.ExecuteScalar());
            cmd.Connection.Close();
            if (n == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public Int64 Insert_Data()
        {
            Int64 n = 0;
            try
            {
                cmd = new SqlCommand("SELECT COUNT(*) FROM jos_railway_loco_type_schedule", cnn);
                cmd.Connection.Open();
                n = Convert.ToInt64(cmd.ExecuteScalar());
                cmd.Connection.Close();
                if (n > 0)
                {
                    cmd = new SqlCommand("SELECT MAX(id_loco_sch) FROM jos_railway_loco_type_schedule", cnn);
                    cmd.Connection.Open();
                    n = Convert.ToInt64(cmd.ExecuteScalar());
                    n++;
                    cmd.Connection.Close();
                }
                else
                {
                    n = 1;
                }
                cmd = new SqlCommand("INSERT INTO jos_railway_loco_type_schedule(loco_id,s_type,duration) VALUES (@loco_id,@s_type,@duration)", cnn);
                cmd.Parameters.AddWithValue("@loco_id", this.loco_id);
                cmd.Parameters.AddWithValue("@s_type", this.s_type);
                cmd.Parameters.AddWithValue("@duration", this.duration);
                cmd.Connection.Open();
                int m = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
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
                cmd = new SqlCommand("DELETE FROM jos_railway_loco_type_schedule  WHERE (id_loco_sch=@id_loco_sch)", cnn);
                cmd.Parameters.AddWithValue("@id_loco_sch", this.id_loco_sch);
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
                cmd = new SqlCommand("UPDATE jos_railway_loco_type_schedule SET s_type=@s_type,duration=@duration WHERE id_loco_sch=@id_loco_sch ", cnn);
                cmd.Parameters.AddWithValue("@id_loco_sch", this.id_loco_sch);
                //cmd.Parameters.AddWithValue("@loco_id", this.loco_id);
                cmd.Parameters.AddWithValue("@s_type", this.s_type);
                cmd.Parameters.AddWithValue("@duration", this.duration);
                cmd.Connection.Open();
                int n = Convert.ToInt16(cmd.ExecuteNonQuery());
                cmd.Connection.Close();
                return n;
            }
            catch { throw; }
        }
        public DataTable Select_DataByid(string lid)
        {
            cmd = new SqlCommand("SELECT id_loco_sch ,s_type as Schedule_Type,duration as duration FROM jos_railway_loco_type_schedule WHERE loco_id ='" + lid + "'", cnn);
            dt = new DataTable();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;
        }
        public DataTable Select_Data()
        {
            cmd = new SqlCommand("SELECT id_loco_sch,s_type as Schedule_Type,duration as duration FROM jos_railway_loco_type_schedule WHERE loco_id='" + this.loco_id + "'", cnn);
            dt = new DataTable();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;
        }
        public DataTable Select_Data_by_id()
        {
            cmd = new SqlCommand("SELECT id_loco_sch,s_type as Schedule_Type,duration as duration FROM jos_railway_loco_type_schedule WHERE loco_id='" + this.loco_id + "'", cnn);
            dt = new DataTable();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;
        }
        public DataTable Select_Data_schedule()
        {
            cmd = new SqlCommand("SELECT * FROM jos_railway_loco_type_schedule ", cnn);
            dt = new DataTable();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;
        }
        public Int64 Get_DurationById(string ScheduleId)
        {
            try
            {
                cmd = new SqlCommand("SELECT duration FROM jos_railway_loco_type_schedule WHERE id_loco_sch='" + ScheduleId + "'",cnn);
                cmd.Connection.Open();
                Int64 n = Convert.ToInt64(cmd.ExecuteScalar());
                cmd.Connection.Close();
                return n;
            }
            catch { throw; }
            
        }
    }
}
