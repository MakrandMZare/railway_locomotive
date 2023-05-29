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
/// Summary description for Cls_jos_railway_mst_stat_nonstat
/// </summary>
public class Cls_jos_railway_mst_stat_nonstat : Cls_DBConnection
{
	public Cls_jos_railway_mst_stat_nonstat()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public string id_stat;
        public string stat;
      
        public Int64 Insert_Data()
        {
            Int64 n = 0;
            try
            {
                cmd = new SqlCommand("SELECT COUNT(*) FROM jos_railway_mst_stat_nonstat", cnn);
                cmd.Connection.Open();
                n = Convert.ToInt64(cmd.ExecuteScalar());
                cmd.Connection.Close();
                if (n > 0)
                {
                    cmd = new SqlCommand("SELECT MAX(id_stat) FROM jos_railway_mst_stat_nonstat", cnn);
                    cmd.Connection.Open();
                    n = Convert.ToInt64(cmd.ExecuteScalar());
                    n++;
                    cmd.Connection.Close();
                }
                else
                {
                    n = 1;
                }
                cmd = new SqlCommand("INSERT INTO jos_railway_mst_stat_nonstat(stat) VALUES (@stat)", cnn);
                cmd.Parameters.AddWithValue("@stat", this.stat);
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
                cmd = new SqlCommand("DELETE FROM jos_railway_mst_stat_nonstat  WHERE (id_stat=@id_stat)", cnn);
                cmd.Parameters.AddWithValue("@id_stat", this.id_stat);
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
                cmd = new SqlCommand(" UPDATE jos_railway_mst_stat_nonstat SET stat=@stat WHERE id_stat=@id_stat ", cnn);
                cmd.Parameters.AddWithValue("@id_stat", this.id_stat);
                cmd.Parameters.AddWithValue("@stat", this.stat);
                cmd.Connection.Open();
                int n = Convert.ToInt16(cmd.ExecuteNonQuery());
                cmd.Connection.Close();
                return n;
            }
            catch { throw; }
        }

    public bool IsDataExists()
    {
        cmd = new SqlCommand("select count(*) from jos_railway_mst_stat_nonstat where stat ='" + this.stat  + "'", cnn);


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
            cmd = new SqlCommand("SELECT * FROM jos_railway_mst_stat_nonstat", cnn);
            dt = new DataTable();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;
        }
    }




