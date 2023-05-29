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
    public class Cls_jos_railway_mst_Assembly : Cls_DBConnection
    {
        public string id_mst_assem;
        public string name;
        public Cls_jos_railway_mst_Assembly()
        {
            //Declare Connection
            //cnn = new SqlConnection(@"SERVER=railwayd.db.4989407.hostedresource.com;DATABASE=railwayd;USER ID=railwayd;PASSWORD=Dhara1980");

        }
        public Int64 Insert_Data()
        {
            Int64 n = 0;
            try
            {
                cmd = new SqlCommand("SELECT COUNT(*) FROM jos_railway_mst_assembly", cnn);
                cmd.Connection.Open();
                n = Convert.ToInt64(cmd.ExecuteScalar());
                cmd.Connection.Close();

                cmd = new SqlCommand("INSERT INTO jos_railway_mst_assembly(\"name\") VALUES (@name)", cnn);
                cmd.Parameters.AddWithValue("@name", this.name);
                cmd.Connection.Open();
                int m = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                if (n > 0)
                {
                    cmd = new SqlCommand("SELECT MAX(id_mst_assem) FROM jos_railway_mst_assembly", cnn);
                    cmd.Connection.Open();
                    n = Convert.ToInt64(cmd.ExecuteScalar());
                    n++;
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
                cmd = new SqlCommand("DELETE FROM jos_railway_mst_assembly  WHERE (id_mst_assem=@id_mst_assem)", cnn);
                cmd.Parameters.AddWithValue("@id_mst_assem", this.id_mst_assem);
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
                cmd = new SqlCommand(" UPDATE jos_railway_mst_assembly SET \"name\"=@name WHERE id_mst_assem=@id_mst_assem ", cnn);
                cmd.Parameters.AddWithValue("@id_mst_assem", this.id_mst_assem);
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
            cmd = new SqlCommand("select count(*) from jos_railway_mst_assembly where name ='" + this.name  + "'", cnn);


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
            cmd = new SqlCommand("SELECT * FROM jos_railway_mst_assembly", cnn);
            dt = new DataTable();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;
        }
    }

}
