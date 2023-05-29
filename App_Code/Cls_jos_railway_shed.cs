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
    public class Cls_jos_railway_shed : Cls_DBConnection
    {

        public string id_shed;
        public string sname;
        public string FULLNAME;

        public Int64 Insert_Data()
        {
            Int64 n = 0;
            try
            {
                cmd = new SqlCommand("SELECT COUNT(*) FROM jos_railway_shed", cnn);
                cmd.Connection.Open();
                n = Convert.ToInt64(cmd.ExecuteScalar());
                cmd.Connection.Close();

                cmd = new SqlCommand("INSERT INTO jos_railway_shed(\"sname\",\"FULLNAME\") VALUES (@sname,@FULLNAME)", cnn);
                cmd.Parameters.AddWithValue("@sname", this.sname);
                cmd.Parameters.AddWithValue("@FULLNAME", this.FULLNAME);
                cmd.Connection.Open();
                int m = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                if (n > 0)
                {
                    cmd = new SqlCommand("SELECT MAX(id_shed) FROM jos_railway_shed", cnn);
                    cmd.Connection.Open();
                    n = Convert.ToInt64(cmd.ExecuteScalar());
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
                cmd = new SqlCommand("DELETE FROM jos_railway_shed  WHERE (id_shed=@id_shed)", cnn);
                cmd.Parameters.AddWithValue("@id_shed", this.id_shed);
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
                cmd = new SqlCommand(" UPDATE jos_railway_shed SET \"sname\" =@sname,\"FULLNAME\" =@FULLNAME WHERE id_shed=@id_shed ", cnn);
                cmd.Parameters.AddWithValue("@id_shed", this.id_shed);
                cmd.Parameters.AddWithValue("@sname", this.sname);
                cmd.Parameters.AddWithValue("@FULLNAME", this.FULLNAME);
                cmd.Connection.Open();
                int n = Convert.ToInt16(cmd.ExecuteNonQuery());
                cmd.Connection.Close();
                return n;
            }
            catch { throw; }
        }

        public bool IsDataExists()
        {
            cmd = new SqlCommand("select count(*) from jos_railway_shed where sname='" + this.sname + "' ", cnn);
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
            cmd = new SqlCommand("SELECT * FROM jos_railway_shed", cnn);
            dt = new DataTable();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;
        }
        public bool Check_Existance()
        {
            try
            {
                cmd = new SqlCommand("SELECT COUNT(*) FROM jos_railway_shed WHERE sname='" + this.sname + "'", cnn);
                cmd.Connection.Open();
                int n = Convert.ToInt16(cmd.ExecuteScalar());
                cmd.Connection.Close();
                if (n == 0)
                {
                    return false;
                }

            }
            catch
            { throw; }
            return true;

        }
        //    public string select_shed(string sname)
        //    {
        //        try
        //        {
        //            cmd = new SqlCommand("select id_shed from jos_railway_shed where sname='" + sname + "'", cnn);
        //            cmd.Connection.Open();
        //            string n = Convert.ToString(cmd.ExecuteScalar());
        //            cmd.Connection.Close();
        //            if (n == 0)
        //            {
        //                return false;
        //            }
        //        }
        //        catch
        //        {
        //            throw;
        //        }
        //        return true;
        //    }
        //}
    }

}
