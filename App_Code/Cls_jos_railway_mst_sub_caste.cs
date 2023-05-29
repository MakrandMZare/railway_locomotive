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
/// Summary description for Cls_jos_railway_mst_sub_caste
/// </summary>
public class Cls_jos_railway_mst_sub_caste : Cls_DBConnection
{
	public Cls_jos_railway_mst_sub_caste()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public string id_s_caste;
        public string mid;
        public string sub_caste;
       
        public Int64 Insert_Data()
        {
            Int64 n = 0;
            try
            {
                cmd = new SqlCommand("SELECT COUNT(*) FROM jos_railway_mst_sub_caste", cnn);
                cmd.Connection.Open();
                n = Convert.ToInt64(cmd.ExecuteScalar());
                cmd.Connection.Close();
                
                cmd = new SqlCommand("INSERT INTO jos_railway_mst_sub_caste(mid,sub_caste) VALUES (@mid,@sub_caste)", cnn);
                cmd.Parameters.AddWithValue("@mid", this.mid);
                cmd.Parameters.AddWithValue("@sub_caste", this.sub_caste);
                cmd.Connection.Open();
                int m = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                if (n > 0)
                {
                    cmd = new SqlCommand("SELECT MAX(id_s_caste) FROM jos_railway_mst_sub_caste", cnn);
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
                cmd = new SqlCommand("DELETE FROM jos_railway_mst_sub_caste  WHERE (id_s_caste=@id_s_caste)", cnn);
                cmd.Parameters.AddWithValue("@id_s_caste", this.id_s_caste);
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
                cmd = new SqlCommand(" UPDATE jos_railway_mst_sub_caste SET sub_caste=@sub_caste WHERE id_s_caste=@id_s_caste ", cnn);
                cmd.Parameters.AddWithValue("@id_s_caste", this.id_s_caste);
                //cmd.Parameters.AddWithValue("@mid", this.mid);
                cmd.Parameters.AddWithValue("@sub_caste", this.sub_caste);
                cmd.Connection.Open();
                int n = Convert.ToInt16(cmd.ExecuteNonQuery());
                cmd.Connection.Close();
                return n;
            }
            catch { throw; }
        }
    public bool IsDataExists()
    {
        cmd = new SqlCommand("select count(*) from jos_railway_mst_sub_caste where sub_caste ='" + this.sub_caste  + "'", cnn);


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
            cmd = new SqlCommand("SELECT * FROM jos_railway_mst_sub_caste", cnn);
            dt = new DataTable();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;
        }
        public DataTable Select_DataByCaste()
        {
            cmd = new SqlCommand("SELECT * FROM jos_railway_mst_sub_caste where mid='" + this.mid + "'", cnn);
            dt = new DataTable();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;

        }
    }



