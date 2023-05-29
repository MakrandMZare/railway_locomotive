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
/// Summary description for Cls_jos_railway_mst_rly
/// </summary>
public class Cls_jos_railway_mst_rly : Cls_DBConnection
{
	public Cls_jos_railway_mst_rly()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public string id_rly;
        public string s_name;
        public string full_name;
       
        public Int64 Insert_Data()
        {
            Int64 n = 0;
            try
            {
                cmd = new SqlCommand("SELECT COUNT(*) FROM jos_railway_mst_rly", cnn);
                cmd.Connection.Open();
                n = Convert.ToInt64(cmd.ExecuteScalar());
                cmd.Connection.Close();
                if (n > 0)
                {
                    cmd = new SqlCommand("SELECT MAX(id_rly) FROM jos_railway_mst_rly", cnn);
                    cmd.Connection.Open();
                    n = Convert.ToInt64(cmd.ExecuteScalar());
                    n++;
                    cmd.Connection.Close();
                }
                else
                {
                    n = 1;
                }
                cmd = new SqlCommand("INSERT INTO jos_railway_mst_rly(s_name,full_name) VALUES (@s_name,@full_name)", cnn);
                cmd.Parameters.AddWithValue("@s_name", this.s_name);
                cmd.Parameters.AddWithValue("@full_name", this.full_name);
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
                cmd = new SqlCommand("DELETE FROM jos_railway_mst_rly  WHERE (id_rly=@id_rly)", cnn);
                cmd.Parameters.AddWithValue("@id_rly", this.id_rly);
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
                cmd = new SqlCommand(" UPDATE jos_railway_mst_rly SET s_name=@s_name,full_name=@full_name WHERE id_rly=@id_rly ", cnn);
                cmd.Parameters.AddWithValue("@id_rly", this.id_rly);
                cmd.Parameters.AddWithValue("@s_name", this.s_name);
                cmd.Parameters.AddWithValue("@full_name", this.full_name);
                cmd.Connection.Open();
                int n = Convert.ToInt16(cmd.ExecuteNonQuery());
                cmd.Connection.Close();
                return n;
            }
            catch { throw; }
        }
    public bool IsDataExists()
    {
        cmd = new SqlCommand("select count(*) from jos_railway_mst_rly where s_name ='" + this.s_name  + "'", cnn);


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
            cmd = new SqlCommand("SELECT * FROM jos_railway_mst_rly", cnn);
            dt = new DataTable();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;
        }
    }



