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
namespace Railway
{
   public class Cls_jos_railway_fire_detail_out : Cls_DBConnection 
    {
        public string id_fire_dout;
        public string mid;
        public string fdate;
        public string srno;
        public string l_type;
        public Cls_jos_railway_fire_detail_out()
        {
            //Declare Connection
            //cnn = new SqlConnection(@"SERVER=railwayd.db.4989407.hostedresource.com;DATABASE=railwayd;USER ID=railwayd;PASSWORD=Dhara1980");

        }
        public Int64 Insert_Data()
        {
            Int64 n = 0;
            try
            {
                cmd = new SqlCommand("SELECT COUNT(*) FROM jos_railway_fire_detail_lout", cnn);
                cmd.Connection.Open();
                n = Convert.ToInt64(cmd.ExecuteScalar());
                cmd.Connection.Close();

                cmd = new SqlCommand("INSERT INTO jos_railway_fire_detail_lout(mid,fdate,srno) VALUES (@mid,@fdate,@srno)", cnn);
                cmd.Parameters.AddWithValue("@mid", this.mid);
                cmd.Parameters.AddWithValue("@fdate", this.fdate);
                cmd.Parameters.AddWithValue("@srno", this.srno);
                //cmd.Parameters.AddWithValue("@l_type", this.l_type);
                cmd.Connection.Open();
                int m = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                if (m > 0)
                
                {
                    cmd = new SqlCommand("SELECT MAX(id_fire_dout) FROM jos_railway_fire_detail_lout", cnn);
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
                cmd = new SqlCommand("DELETE FROM jos_railway_fire_detail_lout  WHERE (id_fire_dout=@id_fire_dout)", cnn);
                cmd.Parameters.AddWithValue("@id_fire_dout", this.id_fire_dout);
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
                cmd = new SqlCommand(" UPDATE jos_railway_fire_detail_lout SET mid=@mid,fdate=@fdate,srno=@srno WHERE id_fire_dout=@id_fire_dout ", cnn);
                cmd.Parameters.AddWithValue("@id_fire_dout", this.id_fire_dout);
                cmd.Parameters.AddWithValue("@mid", this.mid);
                cmd.Parameters.AddWithValue("@fdate", Convert.ToDateTime(this.fdate));
                cmd.Parameters.AddWithValue("@srno", this.srno);
                
                cmd.Connection.Open();
                int n = Convert.ToInt16(cmd.ExecuteNonQuery());
                cmd.Connection.Close();
                return n;
            }
            catch { throw; }
        }
        public DataTable Select_Data()
        {
            cmd = new SqlCommand("SELECT * FROM jos_railway_fire_detail_lout WHERE l_type='"+ this.l_type +"' AND \"mid\"='"+ this.mid + "'", cnn);
            dt = new DataTable();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;
        }
        public DataTable Select_DataById()
        {
            cmd = new SqlCommand("SELECT id_fire_dout,mid,Convert(varchar(10),fdate,101) as fdate,srno FROM jos_railway_fire_detail_lout WHERE mid='" + this.mid + "'", cnn);
            dt = new DataTable();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;
        }
    }
}

