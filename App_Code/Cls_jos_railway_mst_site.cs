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
/// Summary description for Cls_jos_railway_mst_site
/// </summary>
public class Cls_jos_railway_mst_site : Cls_DBConnection
{
	public Cls_jos_railway_mst_site()
	{
		//
		// TODO: Add constructor logic here
		//
	}
 public string Id_Site;
        public string Site_Name;
      
        public Int64 Insert_Data()
        {
            Int64 n = 0;
            try
            {
                cmd = new SqlCommand("SELECT COUNT(*) FROM jos_railway_mst_site", cnn);
                cmd.Connection.Open();
                n = Convert.ToInt64(cmd.ExecuteScalar());
                cmd.Connection.Close();
                if (n > 0)
                {
                    cmd = new SqlCommand("SELECT MAX(Id_Site) FROM jos_railway_mst_site", cnn);
                    cmd.Connection.Open();
                    n = Convert.ToInt64(cmd.ExecuteScalar());
                    n++;
                    cmd.Connection.Close();
                }
                else
                {
                    n = 1;
                }
                cmd = new SqlCommand("INSERT INTO jos_railway_mst_site(Site_Name) VALUES (@Site_Name)", cnn);
                cmd.Parameters.AddWithValue("@Site_Name", this.Site_Name);
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
                cmd = new SqlCommand("DELETE FROM jos_railway_mst_site  WHERE (Id_Site=@Id_Site)", cnn);
                cmd.Parameters.AddWithValue("@Id_Site", this.Id_Site);
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
                cmd = new SqlCommand(" UPDATE jos_railway_mst_site SET Site_Name=@Site_Name WHERE Id_Site=@Id_Site ", cnn);
                cmd.Parameters.AddWithValue("@Id_Site", this.Id_Site);
                cmd.Parameters.AddWithValue("@Site_Name", this.Site_Name);
                cmd.Connection.Open();
                int n = Convert.ToInt16(cmd.ExecuteNonQuery());
                cmd.Connection.Close();
                return n;
            }
            catch { throw; }
        }
        public DataTable Select_Data()
        {
            cmd = new SqlCommand("SELECT * FROM jos_railway_mst_site", cnn);
            dt = new DataTable();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;
        }
        public bool IsDataExists()
        {
            int n=0;
            cmd = new SqlCommand("SELECT COUNT(Id_Site) FROM jos_railway_mst_site WHERE Site_Name = '" + this.Site_Name + "'", cnn);
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

    }



