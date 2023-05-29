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
/// Summary description for Cls_jos_railway_section
/// </summary>
namespace Railway
{
    public class Cls_jos_railway_section : Cls_DBConnection 
    {
        public string id_section;
        public string s_type;
        public string f_name;
        public Cls_jos_railway_section()
        {
            //Declare Connection
            //cnn = new SqlConnection(@"SERVER=railwayd.db.4989407.hostedresource.com;DATABASE=railwayd;USER ID=railwayd;PASSWORD=Dhara1980");

        }
        public Int64 Insert_Data()
        {
            Int64 n = 0;
            try
            {
                cmd = new SqlCommand("SELECT COUNT(*) FROM jos_railway_section", cnn);
                cmd.Connection.Open();
                n = Convert.ToInt64(cmd.ExecuteScalar());
                cmd.Connection.Close();
                if (n > 0)
                {
                    cmd = new SqlCommand("SELECT MAX(id_section) FROM jos_railway_section", cnn);
                    cmd.Connection.Open();
                    n = Convert.ToInt64(cmd.ExecuteScalar());
                    n++;
                    cmd.Connection.Close();
                }
                else
                {
                    n = 1;
                }
                cmd = new SqlCommand("INSERT INTO jos_railway_section(s_type,f_name) VALUES (@s_type,@f_name)", cnn);
                cmd.Parameters.AddWithValue("@s_type", this.s_type);
                cmd.Parameters.AddWithValue("@f_name", this.f_name);
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
                cmd = new SqlCommand("DELETE FROM jos_railway_section  WHERE (id_section=@id_section)", cnn);
                cmd.Parameters.AddWithValue("@id_section", this.id_section);
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
                cmd = new SqlCommand(" UPDATE jos_railway_section SET s_type=@s_type,f_name=@f_name WHERE id_section=@id_section ", cnn);
                cmd.Parameters.AddWithValue("@id_section", this.id_section);
                cmd.Parameters.AddWithValue("@s_type", this.s_type);
                cmd.Parameters.AddWithValue("@f_name", this.f_name);
                cmd.Connection.Open();
                int n = Convert.ToInt16(cmd.ExecuteNonQuery());
                cmd.Connection.Close();
                return n;
            }
            catch { throw; }
        }
        public bool IsDataExists()
        {
            //cmd = new SqlCommand("select count(*) from jos_railway_section where s_type ='" + this.s_type + "', f_name = ' " + this.f_name  + " '  ", cnn);
            cmd = new SqlCommand("select count(*) from jos_railway_section where s_type ='" + this.s_type + "' ", cnn);


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
            cmd = new SqlCommand("SELECT * FROM jos_railway_section", cnn);
            dt = new DataTable();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;
        }
    }

}