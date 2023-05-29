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
/// Summary description for Cls_jos_railway_mst_d_id
/// </summary>
public class Cls_jos_railway_mst_d_id : Cls_DBConnection
{
	public Cls_jos_railway_mst_d_id()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public string Id_irregularity;
        public string irregularity_type;
      
        public Int64 Insert_Data()
        {
            Int64 n = 0;
            try
            {
                cmd = new SqlCommand("SELECT COUNT(*) FROM jos_railway_mst_irregularity", cnn);
                cmd.Connection.Open();
                n = Convert.ToInt64(cmd.ExecuteScalar());
                cmd.Connection.Close();

                cmd = new SqlCommand("INSERT INTO jos_railway_mst_irregularity(irregularity_type) VALUES (@irregularity_type)", cnn);
                cmd.Parameters.AddWithValue("@irregularity_type", this.irregularity_type);
                cmd.Connection.Open();
                int m = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                if (n > 0)
                {
                    cmd = new SqlCommand("SELECT MAX(Id_irregularity) FROM jos_railway_mst_irregularity", cnn);
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
                cmd = new SqlCommand("DELETE FROM jos_railway_mst_irregularity  WHERE (Id_irregularity=@Id_irregularity)", cnn);
                cmd.Parameters.AddWithValue("@Id_irregularity", this.Id_irregularity);
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
                cmd = new SqlCommand(" UPDATE jos_railway_mst_irregularity SET irregularity_type=@irregularity_type WHERE Id_irregularity=@Id_irregularity ", cnn);
                cmd.Parameters.AddWithValue("@Id_irregularity", this.Id_irregularity);
                cmd.Parameters.AddWithValue("@irregularity_type", this.irregularity_type);
                cmd.Connection.Open();
                int n = Convert.ToInt16(cmd.ExecuteNonQuery());
                cmd.Connection.Close();
                return n;
            }
            catch { throw; }
        }
    public bool IsDataExists()
    {
        cmd = new SqlCommand("select count(*) from jos_railway_mst_irregularity where irregularity_type ='" + this.irregularity_type  + "'", cnn);


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
            cmd = new SqlCommand("SELECT * FROM jos_railway_mst_irregularity", cnn);
            dt = new DataTable();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;
        }

}
