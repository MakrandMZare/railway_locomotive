using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data.SqlClient;
using Railway;
/// <summary>
/// Summary description for Cls_jos_railway_loco_in_mg
/// </summary>
namespace Railway
{
    public class Cls_jos_railway_loco_in_mg : Cls_DBConnection
    {

        public string id_loco_in_mg = null;
        public string id_loco_in = null;
        public string WheelDia = null;
        public string Pass = null;
        public string PDC = null;
        public Cls_jos_railway_loco_in_mg()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        public Int64 Insert_Data()
        {
            try
            {
                cmd = new SqlCommand("INSERT INTO jos_railway_loco_in_mg(id_loco_in,WheelDia,Pass,PDC) VALUES(@id_loco_in,@WheelDia,@Pass,@PDC)", cnn);
                cmd.Parameters.AddWithValue("@id_loco_in", this.id_loco_in);
                cmd.Parameters.AddWithValue("@WheelDia", this.WheelDia);
                cmd.Parameters.AddWithValue("@Pass", this.Pass);
                cmd.Parameters.AddWithValue("@PDC", this.PDC);
                cmd.Connection.Open();
                int n = Convert.ToInt16(cmd.ExecuteNonQuery());
                cmd.Connection.Close();
                if (n == 1)
                {
                    cmd = new SqlCommand("SELECT MAX(id_loco_in_mg) FROM jos_railway_loco_in_mg", cnn);
                    cmd.Connection.Open();
                    Int64 m = Convert.ToInt64(cmd.ExecuteScalar());
                    cmd.Connection.Close();
                    return m;
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                throw;
            }
        }
        public DataTable SelectDataById()
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM jos_railway_loco_in_mg WHERE id_loco_in='" + this.id_loco_in + "'", cnn);
                da = new SqlDataAdapter();
                dt = new DataTable();
                da.SelectCommand = cmd;
                dt.Clear();
                da.Fill(dt);
                return dt;
            }
            catch { throw; }
        }
        public void Delete_Data()
        {
            try
            {
                cmd = new SqlCommand("DELTE FROM jos_railway_loco_in_mg WHERE id_loco_in='" + this.id_loco_in + "'", cnn);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            catch { throw; }
        }
        public void Update_Data()
        {
            try
            {
                cmd = new SqlCommand("UPDATE jos_railway_loco_in_mg SET WheelDia=@WheelDia,Pass=@Pass,PDC=@PDC WHERE id_loco_in_mg=@id_loco_in_mg",cnn);
                cmd.Parameters.AddWithValue("@id_loco_in_mg",this.id_loco_in_mg );
                cmd.Parameters.AddWithValue("@Pass",this.Pass);
                cmd.Parameters.AddWithValue("@PDC",this.PDC);
                cmd.Parameters.AddWithValue("@WheelDia",this.WheelDia);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            catch { throw; }
        }
    }
}
