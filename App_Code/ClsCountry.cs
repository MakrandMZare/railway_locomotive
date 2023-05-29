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
/// Summary description for ClsCountry
/// </summary>
public class ClsCountry : Cls_DBConnection
{
	public ClsCountry()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public string CountryId;
    public string CountryName;
   
      
 //       public Int64 Insert_Data()
 //       {
 //           Int64 n = 0;
 //           try
 //           {
 //               cmd = new SqlCommand("SELECT COUNT(*) FROM tblCountry", cnn);
 //               cmd.Connection.Open();
 //               n = Convert.ToInt64(cmd.ExecuteScalar());
 //               cmd.Connection.Close();
 //               if (n > 0)
 //               {
 //                   cmd = new SqlCommand("SELECT MAX(CountryId) FROM tblCountry", cnn);
 //                   cmd.Connection.Open();
 //                   n = Convert.ToInt64(cmd.ExecuteScalar());
 //                   n++;
 //                   cmd.Connection.Close();
 //               }
 //               else
 //               {
 //                   n = 1;
 //               }
 //               cmd = new SqlCommand("INSERT INTO tblCountry(CountryName) VALUES (@CountryName)", cnn);
 //               cmd.Parameters.AddWithValue("@CountryName", this.CountryName);
 //               cmd.Connection.Open();
 //               int m = cmd.ExecuteNonQuery();
 //               cmd.Connection.Close();
 //               if (m == 1)
 //               {
 //                   return n;
 //               }
 //               else
 //               {
 //                   return 0;
 //               }
 //           }
 //           catch { throw; }
 //       }
        //Delete Data
        public int Delete_Data()
        {
            try
            {
                cmd = new SqlCommand("DELETE FROM tblCountry  WHERE (CountryId=@CountryId)", cnn);
                cmd.Parameters.AddWithValue("@CountryId", this.CountryId);
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
                cmd = new SqlCommand(" UPDATE tblCountry SET CountryName=@CountryName WHERE CountryId=@CountryId ", cnn);
                cmd.Parameters.AddWithValue("@CountryId", this.CountryId);
                cmd.Parameters.AddWithValue("@CountryName", this.CountryName);
                cmd.Connection.Open();
                int n = Convert.ToInt16(cmd.ExecuteNonQuery());
                cmd.Connection.Close();
                return n;
            }
            catch { throw; }
        }
        public DataTable Select_Data()
        {
           // cmd = new SqlCommand("SELECT * FROM tblCountry", cnn);
            cmd = new SqlCommand("select CountryId,CountryName from tblCountry",cnn);
            dt = new DataTable();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;
        }
    public DataTable Select_Temp_Data()
    {
        // cmd = new SqlCommand("SELECT * FROM tblCountry", cnn);
        cmd = new SqlCommand("select * from temp", cnn);
        dt = new DataTable();
        da = new SqlDataAdapter();
        da.SelectCommand = cmd;
        dt.Clear();
        da.Fill(dt);
        return dt;
    }
     //   public bool IsDataExists()
 //       {
 //           int n=0;
 //           cmd = new SqlCommand("SELECT COUNT(CountryId) FROM tblCountry WHERE CountryName = '" + this.CountryName + "'", cnn);
 //           cmd.Connection.Open();
 //           n = Convert.ToInt16(cmd.ExecuteScalar());
 //           cmd.Connection.Close();
 //            if (n == 0)
 //            {
 //                return false;
 //            }
 //            else
 //            {
 //                return true;
 //            }
 //       }


    public Int64 Insert_Data_Country()
    {
        try
        {
            cmd = new SqlCommand("insert into tblCountry(CountryName) values(@CountryName)",cnn);
            cmd.Parameters.AddWithValue("@CountryName", this.CountryName);
            cmd.Connection.Open();
            Int64 n = Convert.ToInt64(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            return n;

        }
        catch
        {
            throw;
        }
    }

}



