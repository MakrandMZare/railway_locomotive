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
    public class Cls_jos_railway_mst_failure : Cls_DBConnection
    {

        public string id_m_fail;
        public string failure;
        public Cls_jos_railway_mst_failure()
        {
            //Declare Connection
            //cnn = new SqlConnection(@"SERVER=railwayd.db.4989407.hostedresource.com;DATABASE=railwayd;USER ID=railwayd;PASSWORD=Dhara1980");

        }
        public Int64 Insert_Data()
        {
            Int64 n = 0;
            try
            {
                cmd = new SqlCommand("SELECT COUNT(*) FROM jos_railway_mst_failure", cnn);
                cmd.Connection.Open();
                n = Convert.ToInt64(cmd.ExecuteScalar());
                cmd.Connection.Close();
                if (n > 0)
                {
                    cmd = new SqlCommand("SELECT MAX(id_m_fail) FROM jos_railway_mst_failure", cnn);
                    cmd.Connection.Open();
                    n = Convert.ToInt64(cmd.ExecuteScalar());
                    n++;
                    cmd.Connection.Close();
                }
                else
                {
                    n = 1;
                }
                cmd = new SqlCommand("INSERT INTO jos_railway_mst_failure(failure) VALUES (@failure)", cnn);
                cmd.Parameters.AddWithValue("@failure", this.failure);
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
                cmd = new SqlCommand("DELETE FROM jos_railway_mst_failure  WHERE (id_m_fail=@id_m_fail)", cnn);
                cmd.Parameters.AddWithValue("@id_m_fail", this.id_m_fail);
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
                cmd = new SqlCommand(" UPDATE jos_railway_mst_failure SET failure=@failure WHERE id_m_fail=@id_m_fail ", cnn);
                cmd.Parameters.AddWithValue("@id_m_fail", this.id_m_fail);
                cmd.Parameters.AddWithValue("@failure", this.failure);
                cmd.Connection.Open();
                int n = Convert.ToInt16(cmd.ExecuteNonQuery());
                cmd.Connection.Close();
                return n;
            }
            catch { throw; }
        }
        public bool IsDataExists()
        {
            cmd = new SqlCommand("select count(*) from jos_railway_mst_failure where failure ='" + this.failure  + "'", cnn);


            cmd.Connection.Open();
            Int16 n = Convert.ToInt16(cmd.ExecuteScalar());
            cmd.Connection.Close();
            if (n == 0)
            { return false; }
            else
            { return true; }
        }
        public DataTable Select_Data()
        {
            cmd = new SqlCommand("SELECT * FROM jos_railway_mst_failure", cnn);
            dt = new DataTable();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;
        }
    }
}
