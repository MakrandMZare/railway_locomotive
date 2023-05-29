using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace Railway
{
    public class Cls_jos_railway_loco_assembly : Cls_DBConnection
    {

        public string id_asembly;
        public string mid;
        public string id_ass;
        public string id_sup;
        public Cls_jos_railway_loco_assembly()
        {
            //Declare Connection
            //cnn = new SqlConnection(@"SERVER=railwayd.db.4989407.hostedresource.com;DATABASE=railwayd;USER ID=railwayd;PASSWORD=Dhara1980");

        }
        public Int64 Insert_Data()
        {
            Int64 n = 0;
            try
            {
                cmd = new SqlCommand("SELECT COUNT(*) FROM jos_railway_loco_assembly", cnn);
                cmd.Connection.Open();
                n = Convert.ToInt64(cmd.ExecuteScalar());
                cmd.Connection.Close();
                if (n > 0)
                {
                    cmd = new SqlCommand("SELECT MAX(id_asembly) FROM jos_railway_loco_assembly", cnn);
                    cmd.Connection.Open();
                    n = Convert.ToInt64(cmd.ExecuteScalar());
                    n++;
                    cmd.Connection.Close();
                }
                else
                {
                    n = 1;
                }
                cmd = new SqlCommand("INSERT INTO jos_railway_loco_assembly(mid,id_ass,id_sup) VALUES (@mid,@id_ass,@id_sup)", cnn);
                cmd.Parameters.AddWithValue("@mid", this.mid);
                cmd.Parameters.AddWithValue("@id_ass", this.id_ass);
                cmd.Parameters.AddWithValue("@id_sup", this.id_sup);
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
                cmd = new SqlCommand("DELETE FROM jos_railway_loco_assembly  WHERE (id_asembly=@id_asembly)", cnn);
                cmd.Parameters.AddWithValue("@id_asembly", this.id_asembly);
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
                cmd = new SqlCommand(" UPDATE jos_railway_loco_assembly SET mid=@mid,id_ass=@id_ass,id_sup=@id_sup WHERE id_asembly=@id_asembly ", cnn);
                cmd.Parameters.AddWithValue("@id_asembly", this.id_asembly);
                cmd.Parameters.AddWithValue("@mid", this.mid);
                cmd.Parameters.AddWithValue("@id_ass", this.id_ass);
                cmd.Parameters.AddWithValue("@id_sup", this.id_sup);
                cmd.Connection.Open();
                int n = Convert.ToInt16(cmd.ExecuteNonQuery());
                cmd.Connection.Close();
                return n;
            }
            catch { throw; }
        }
        public DataTable Select_Data()
        {
            cmd = new SqlCommand("SELECT * FROM jos_railway_loco_assembly", cnn);
            dt = new DataTable();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;
        }
        public DataTable Select_AssemblyByLocoType(string locotype)
        {
            //This function return all assembly related to given locotype
            cmd = new SqlCommand("SELECT DISTINCT jos_railway_mst_assembly.id_mst_assem as \"aid\" ,jos_railway_mst_assembly.\"name\" as \"Assembly\" " +
                                 "FROM jos_railway_loco_Assembly " +
                                 "INNER JOIN jos_railway_mst_assembly ON jos_railway_mst_assembly.id_mst_assem = jos_railway_loco_Assembly.id_ass " +
                                 "INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = jos_railway_loco_Assembly.mid  " +
                                 "INNER JOIN jos_railway_loco_type ON jos_railway_loco_type.id_ltype = jos_railway_mst_loco.tid " +
                                 "WHERE jos_railway_loco_type.loco_type='" + locotype + "'", cnn);
            da = new SqlDataAdapter();
            dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        public DataTable Select_DataByLocoId()
        {
            cmd = new SqlCommand("SELECT " +
                " jos_railway_loco_assembly.id_ass " +
                " ,jos_railway_mst_assembly.name  " +
                " ,jos_railway_loco_assembly.id_sup " +
                " ,jos_railway_mst_supplier.s_name " +
                " ,jos_railway_loco_assembly.id_asembly " +
                " FROM " +
                " jos_railway_loco_assembly " +
                " INNER JOIN jos_railway_mst_assembly ON jos_railway_mst_assembly.id_mst_assem = jos_railway_loco_assembly.id_ass " +
                " INNER JOIN jos_railway_mst_supplier ON jos_railway_mst_supplier.id_supp = jos_railway_loco_assembly.id_sup " +
                " WHERE jos_railway_loco_assembly.mid='" + this.mid + "'", cnn);
            dt = new DataTable();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;
        }
    }

}
