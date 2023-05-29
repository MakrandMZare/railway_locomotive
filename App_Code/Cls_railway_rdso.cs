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
using System.Data;
/// <summary>
/// Summary description for Cls_railway_rdso
/// </summary>
public class Cls_railway_rdso : Cls_DBConnection
{
    public string id_rdso;
    public string rdso;
    public string nature_defect;
    public Cls_railway_rdso()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public bool Delete_Data()
    {
        cmd = new SqlCommand("DELETE FROM jos_railway_rdso WHERE id_rdso=@id_rdso", cnn);
        cmd.Parameters.AddWithValue("@id_rdso", this.id_rdso);
        cmd.Connection.Open();
        Int16 n = Convert.ToInt16(cmd.ExecuteNonQuery());
        cmd.Connection.Close();
        return n == 1 ? true : false;
    }
    public bool Update_Data()
    {
        cmd = new SqlCommand("UPDATE jos_railway_rdso SET nature_defect=@nature_defect WHERE rdso=@rdso", cnn);
        cmd.Parameters.AddWithValue("@rdso", this.rdso);
        cmd.Parameters.AddWithValue("@nature_defect", this.nature_defect);
        cmd.Connection.Open();
        Int16 n = Convert.ToInt16(cmd.ExecuteNonQuery());
        cmd.Connection.Close();
        return n == 1 ? true : false;
    }
    public bool Check_Existance()
    {
        cmd = new SqlCommand("SELECT COUNT(*) FROM jos_railway_rdso where rdso=@rdso", cnn);
        cmd.Connection.Open();
        Int64 n = Convert.ToInt64(cmd.ExecuteScalar());
        cmd.Connection.Close();
        return n == 1 ? true : false;
    }
    public DataTable Select_Rdso(string code)
    {
        try
        {
            cmd = new SqlCommand("SELECT * FROM jos_railway_rdso WHERE len(rdso)='" + code + "' order by rdso desc", cnn);
            da = new SqlDataAdapter();
            dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        catch { throw; }

    }
    public DataTable Select_RdsoByDigit(string n)
    {
        try
        {
            cmd = new SqlCommand("SELECT (CONVERT(VARCHAR(10),rdso) + '   ' + nature_defect ) as nature_defect , rdso FROM jos_railway_rdso WHERE len(rdso)='" + n + "'", cnn);
            da = new SqlDataAdapter();
            dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        catch { throw; }

    }
    public Int64 Insert_Rdso()
    {
        try
        {
            cmd = new SqlCommand("INSERT INTO jos_railway_rdso(rdso,nature_defect) values(@rdso,@nature_defect)", cnn);
            cmd.Parameters.AddWithValue("@rdso", this.rdso);
            cmd.Parameters.AddWithValue("@nature_defect", this.nature_defect);
            cmd.Connection.Open();
            Int16 n = Convert.ToInt16(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            if (n == 1)
            {
                cmd = new SqlCommand("SELECT MAX(id_rdso) FROM jos_railway_rdso", cnn);
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
        catch { throw; }
    }
    public DataTable Select_Rdso1Digit()
    {
        try
        {
            cmd = new SqlCommand("SELECT (CONVERT(VARCHAR(10),rdso) + '   ' + nature_defect ) as nature_defect , rdso FROM jos_railway_rdso WHERE len(rdso)='1'", cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        catch { throw; }
    }
    public DataTable Select_Rdso2Digit(string n)
    {
        try
        {
            cmd = new SqlCommand("SELECT (CONVERT(VARCHAR(10),rdso) + '   ' + nature_defect ) as nature_defect , rdso FROM jos_railway_rdso WHERE len(rdso)='2' AND LEFT(rdso,1)='" + n + "'", cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        catch { throw; }
    }
    public DataTable Select_Rdso3Digit(string n)
    {
        try
        {
            cmd = new SqlCommand("SELECT (CONVERT(VARCHAR(10),rdso) + '   ' + nature_defect ) as nature_defect , rdso FROM jos_railway_rdso WHERE len(rdso)='3' AND LEFT(rdso,2)='" + n + "'", cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        catch { throw; }
    }
    public DataTable Select_Rdso4Digit(string n)
    {
        try
        {
            cmd = new SqlCommand("SELECT (CONVERT(VARCHAR(10),rdso) + '   ' + nature_defect ) as nature_defect , rdso FROM jos_railway_rdso WHERE len(rdso)='4' AND LEFT(rdso,3)='" + n + "'", cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        catch { throw; }
    }
}
