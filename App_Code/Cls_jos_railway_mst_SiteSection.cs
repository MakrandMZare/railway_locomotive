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
/// Summary description for Cls_jos_railway_mst_SiteSection
/// </summary>
public class Cls_jos_railway_mst_SiteSection : Cls_DBConnection
{
	public Cls_jos_railway_mst_SiteSection()
	{
		//
		// TODO: Add constructor logic here
		//
	}
public string Id_SiteSection;
        public string SiteSectionName;
       
        public Int64 Insert_Data()
        {
            Int64 n = 0;
            try
            {
                cmd = new SqlCommand("SELECT COUNT(*) FROM jos_railway_mst_SiteSection", cnn);
                cmd.Connection.Open();
                n = Convert.ToInt64(cmd.ExecuteScalar());
                cmd.Connection.Close();
                if (n > 0)
                {
                    cmd = new SqlCommand("SELECT MAX(Id_SiteSection) FROM jos_railway_mst_SiteSection", cnn);
                    cmd.Connection.Open();
                    n = Convert.ToInt64(cmd.ExecuteScalar());
                    n++;
                    cmd.Connection.Close();
                }
                else
                {
                    n = 1;
                }
                cmd = new SqlCommand("INSERT INTO jos_railway_mst_SiteSection(SiteSectionName) VALUES (@SiteSectionName)", cnn);
                cmd.Parameters.AddWithValue("@SiteSectionName", this.SiteSectionName);
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
                cmd = new SqlCommand("DELETE FROM jos_railway_mst_SiteSection  WHERE (Id_SiteSection=@Id_SiteSection)", cnn);
                cmd.Parameters.AddWithValue("@Id_SiteSection", this.Id_SiteSection);
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
                cmd = new SqlCommand(" UPDATE jos_railway_mst_SiteSection SET SiteSectionName=@SiteSectionName WHERE Id_SiteSection=@Id_SiteSection ", cnn);
                cmd.Parameters.AddWithValue("@Id_SiteSection", this.Id_SiteSection);
                cmd.Parameters.AddWithValue("@SiteSectionName", this.SiteSectionName);
                cmd.Connection.Open();
                int n = Convert.ToInt16(cmd.ExecuteNonQuery());
                cmd.Connection.Close();
                return n;
            }
            catch { throw; }
        }
        public DataTable Select_Data()
        {
            cmd = new SqlCommand("SELECT * FROM jos_railway_mst_SiteSection ORDER BY SiteSectionName asc", cnn);
            dt = new DataTable();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;
        }
        public bool IsDataExists()
        {
            int n = 0;
            cmd = new SqlCommand("SELECT COUNT(Id_SiteSection) FROM jos_railway_mst_SiteSection WHERE SiteSectionName='"+ this.SiteSectionName +"'", cnn);
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



