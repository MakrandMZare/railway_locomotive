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
using Railway;


namespace Railway
{
    public class Cls_Master_Loco_Type : Cls_DBConnection
    {

        public string id_ltype;
        public string loco_type;
        public string guage;

        public bool IsDataExists()
        {
            int n = 0;
            cmd = new SqlCommand("SELECT COUNT(id_ltype) from jos_railway_loco_type WHERE loco_type='" + this.loco_type + "' AND guage='" + this.guage + "'", cnn);
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
        public string Get_LocoGuageByLocotype()
        {
            cmd = new SqlCommand("SELECT guage FROM jos_railway_loco_type WHERE id_ltype='" + this.id_ltype + "'", cnn);
            
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0][0].ToString();
            }
            else
            {
                return string.Empty;
            }

        }
        public Int64 Insert_Data()
        {
            Int64 n = 0;
            try
            {
                cmd = new SqlCommand("SELECT COUNT(*) FROM jos_railway_loco_type", cnn);
                cmd.Connection.Open();
                n = Convert.ToInt64(cmd.ExecuteScalar());
                cmd.Connection.Close();
                if (n > 0)
                {
                    cmd = new SqlCommand("SELECT MAX(id_ltype) FROM jos_railway_loco_type", cnn);
                    cmd.Connection.Open();
                    n = Convert.ToInt64(cmd.ExecuteScalar());
                    n++;
                    cmd.Connection.Close();
                }
                else
                {
                    n = 1;
                }
                cmd = new SqlCommand("INSERT INTO jos_railway_loco_type(loco_type,guage) VALUES (@loco_type,@guage)", cnn);
                cmd.Parameters.AddWithValue("@loco_type", this.loco_type);
                cmd.Parameters.AddWithValue("@guage", this.guage);
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
                cmd = new SqlCommand("DELETE FROM jos_railway_loco_type  WHERE (id_ltype=@id_ltype)", cnn);
                cmd.Parameters.AddWithValue("@id_ltype", this.id_ltype);
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
                cmd = new SqlCommand(" UPDATE jos_railway_loco_type SET loco_type=@loco_type,guage=@guage WHERE id_ltype=@id_ltype ", cnn);
                cmd.Parameters.AddWithValue("@id_ltype", this.id_ltype);
                cmd.Parameters.AddWithValue("@loco_type", this.loco_type);
                cmd.Parameters.AddWithValue("@guage", this.guage);
                cmd.Connection.Open();
                int n = Convert.ToInt16(cmd.ExecuteNonQuery());
                cmd.Connection.Close();
                return n;
            }
            catch { throw; }
        }
        public DataTable Select_Data()
        {
            cmd = new SqlCommand("SELECT id_ltype,loco_type,guage FROM jos_railway_loco_type", cnn);
            dt = new DataTable();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;
        }
        public DataTable Select_Data(string guage)
        {
            cmd = new SqlCommand("SELECT id_ltype,loco_type as \"type\",guage as \"guage\" FROM jos_railway_loco_type  WHERE guage='" + guage + "'", cnn);
            dt = new DataTable();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;
        }
        public DataTable Select_DataById()
        {
            cmd = new SqlCommand("SELECT * FROM jos_railway_loco_type WHERE id_ltype='" + this.id_ltype + "'", cnn);
            dt = new DataTable();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;
        }
        public DataTable Get_LocoTypeByLocoId(string Locono)
        {
            cmd = new SqlCommand("SELECT id_ltype,loco_type FROM jos_railway_loco_type INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.tid = jos_railway_loco_type.id_ltype WHERE jos_railway_mst_loco.id_mst_loco='" + Locono + "'", cnn);
            da = new SqlDataAdapter();
            dt = new DataTable();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;

        }
        public DataTable Get_BGLocoType()
        {
            cmd = new SqlCommand("SELECT id_ltype,loco_type FROM  jos_railway_loco_type WHERE guage='BROAD GUAGE'", cnn);
            da = new SqlDataAdapter();
            dt = new DataTable();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;
        }
        public DataTable Get_MGLocoType()
        {
            cmd = new SqlCommand("SELECT id_ltype,loco_type FROM  jos_railway_loco_type WHERE guage='METER GUAGE'", cnn);
            da = new SqlDataAdapter();
            dt = new DataTable();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;
        }
    }
}
