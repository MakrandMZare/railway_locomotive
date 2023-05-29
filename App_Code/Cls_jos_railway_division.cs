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
/// Summary description for Cls_jos_railway_division
/// </summary>
namespace Railway
{
    public class Cls_jos_railway_division:Cls_DBConnection 
    {
        public string id_div;
        public string div;
        public Cls_jos_railway_division()
        {
            //Declare Connection
            //cnn = new SqlConnection(@"  SERVER=railwayd.db.4989407.hostedresource.com;DATABASE=railwayd;USER ID=railwayd;PASSWORD=Dhara1980");

        }
        public bool IsDataExists()
        {
            int n = 0;
            cmd = new SqlCommand("SELECT COUNT(id_div) from jos_railway_division WHERE div='" + this.div + "'", cnn);
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
                cmd = new SqlCommand("SELECT COUNT(*) FROM jos_railway_division", cnn);
                cmd.Connection.Open();
                n = Convert.ToInt64(cmd.ExecuteScalar());
                cmd.Connection.Close();
                
                cmd = new SqlCommand("INSERT INTO jos_railway_division(div) VALUES (@div)", cnn);
                cmd.Parameters.AddWithValue("@div", this.div);
                cmd.Connection.Open();
                int m = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                if (n > 0)
                {
                    cmd = new SqlCommand("SELECT MAX(id_div) FROM jos_railway_division", cnn);
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
                cmd = new SqlCommand("DELETE FROM jos_railway_division  WHERE (id_div=@id_div)", cnn);
                cmd.Parameters.AddWithValue("@id_div", this.id_div);
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
                cmd = new SqlCommand(" UPDATE jos_railway_division SET \"div\"=@div WHERE id_div=@id_div ", cnn);
                cmd.Parameters.AddWithValue("@id_div", this.id_div);
                cmd.Parameters.AddWithValue("@div", this.div);
                cmd.Connection.Open();
                int n = Convert.ToInt16(cmd.ExecuteNonQuery());
                cmd.Connection.Close();
                return n;
            }
            catch { throw; }
        }
        public DataTable Select_Data()
        {
            cmd = new SqlCommand("SELECT * FROM jos_railway_division", cnn);
            dt = new DataTable();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;
        }
    }
}