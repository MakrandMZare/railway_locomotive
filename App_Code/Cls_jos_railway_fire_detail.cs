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
    public class Cls_jos_railway_fire_detail : Cls_DBConnection
    {
        public string id_firedet;
        public string mid;
        public string fdate;
        public string srno;
        public string l_type;
        string id;
        public Cls_jos_railway_fire_detail()
        {
            //Declare Connection
            //cnn = new SqlConnection(@"SERVER=railwayd.db.4989407.hostedresource.com;DATABASE=railwayd;USER ID=railwayd;PASSWORD=Dhara1980");

        }
        public Int64 Insert_Data()
        {
            Int64 n = 0;
            try
            {
                cmd = new SqlCommand("SELECT COUNT(*) FROM jos_railway_fire_detail", cnn);
                cmd.Connection.Open();
                n = Convert.ToInt64(cmd.ExecuteScalar());
                cmd.Connection.Close();

                cmd = new SqlCommand("INSERT INTO jos_railway_fire_detail(mid,fdate,srno) VALUES (@mid,@fdate,@srno)", cnn);
                cmd.Parameters.AddWithValue("@mid", this.mid);
                //cmd.Parameters.AddWithValue("@fdate", Convert.ToDateTime(this.fdate));
                cmd.Parameters.AddWithValue("@fdate", this.fdate);
                cmd.Parameters.AddWithValue("@srno", this.srno);
                //cmd.Parameters.AddWithValue("@l_type", this.l_type);
                cmd.Connection.Open();
                int m = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                if (n > 0)
                {
                    cmd = new SqlCommand("SELECT MAX(id_firedet) FROM jos_railway_fire_detail", cnn);
                    cmd.Connection.Open();
                    n = Convert.ToInt64(cmd.ExecuteScalar());
                    n++;
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
                cmd = new SqlCommand("DELETE FROM jos_railway_fire_detail  WHERE (id_firedet=@id_firedet)", cnn);
                cmd.Parameters.AddWithValue("@id_firedet", this.id_firedet);
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
                cmd = new SqlCommand(" UPDATE jos_railway_fire_detail SET mid=@mid,fdate=@fdate,srno=@srno WHERE id_firedet=@id_firedet ", cnn);
                cmd.Parameters.AddWithValue("@id_firedet", this.id_firedet);
                cmd.Parameters.AddWithValue("@mid", this.mid);
                //cmd.Parameters.AddWithValue("@fdate", Convert.ToDateTime(this.fdate));
                cmd.Parameters.AddWithValue("@fdate", this.fdate);
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
            cmd = new SqlCommand("SELECT * " +

                                 "FROM jos_railway_fire_detail \"mid\"='" + this.mid + "'", cnn);
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
                                 "id_firedet " +
                                 ",mid " +
                                 ",Convert(varchar(10),fdate,101) as \"fdate\" " +
                                 ",srno " +
                                 "FROM jos_railway_fire_detail WHERE \"mid\"='" + this.mid + "'", cnn);
            dt = new DataTable();
      
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;
        }
        public DataTable Select_DataById_Out(string mid)
        {
            cmd = new SqlCommand("SELECT srno,fdate FROM jos_railway_fire_detail where mid=@mid", cnn);
            cmd.Parameters.AddWithValue("mid",mid);
            dt = new DataTable();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;
        }
        
    }
}
