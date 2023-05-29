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
/// Summary description for Cls_jos_railway_mst_medical
/// </summary>
public class Cls_jos_railway_mst_medical : Cls_DBConnection
{
	public Cls_jos_railway_mst_medical()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public string id_med;
        public string name;
        
       
        public Int64 Insert_Data()
        {
            Int64 n = 0;
            try
            {
                cmd = new SqlCommand("SELECT COUNT(*) FROM jos_railway_mst_medical", cnn);
                cmd.Connection.Open();
                n = Convert.ToInt64(cmd.ExecuteScalar());
                cmd.Connection.Close();
                cmd = new SqlCommand("INSERT INTO jos_railway_mst_medical(\"name\") VALUES (@name)", cnn);
                cmd.Parameters.AddWithValue("@name", this.name);
                cmd.Connection.Open();
                int m = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    cmd = new SqlCommand("SELECT MAX(id_med) FROM jos_railway_mst_medical", cnn);
                    cmd.Connection.Open();
                    n = Convert.ToInt64(cmd.ExecuteScalar());
                    n++;
                    cmd.Connection.Close();
                }
                else
                {
                    n = 1;
                }
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
                cmd = new SqlCommand("DELETE FROM jos_railway_mst_medical  WHERE (id_med=@id_med)", cnn);
                cmd.Parameters.AddWithValue("@id_med", this.id_med);
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
                cmd = new SqlCommand(" UPDATE jos_railway_mst_medical SET \"name\"=@name WHERE id_med=@id_med ", cnn);
                cmd.Parameters.AddWithValue("@id_med", this.id_med);
                cmd.Parameters.AddWithValue("@name", this.name);
                cmd.Connection.Open();
                int n = Convert.ToInt16(cmd.ExecuteNonQuery());
                cmd.Connection.Close();
                return n;
            }
            catch { throw; }
        }
    public bool IsDataExists()
    {
        cmd = new SqlCommand("select count(*) from jos_railway_mst_medical where name ='" + this.name  + "'", cnn);


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
            cmd = new SqlCommand("SELECT * FROM jos_railway_mst_medical", cnn);
            dt = new DataTable();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;
      }


}
