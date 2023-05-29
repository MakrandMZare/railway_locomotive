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
/// Summary description for Cls_jos_railway_mst_supplier
/// </summary>
public class Cls_jos_railway_mst_supplier : Cls_DBConnection
{
    public Cls_jos_railway_mst_supplier()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public string id_supp;
    //    public string s_name;

    public string s_name;
    public string s_address;
    public string s_pincode;
    public string state;
    public string dist;
    public string Phone;
    public string Landline;
    public string mobilen;
    public string contactperson;
    public string webaddress;
    public string emailid;

    public DataTable GetSupplier(string str)
    {
        try
        {
            cmd = new SqlCommand("SELECT id_supp,s_name FROM jos_railway_mst_supplier WHERE LEFT(s_name,1)='" + str + "'", cnn);
            da = new SqlDataAdapter();
            dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        catch { throw; }

    }
    public Int64 Insert_Data()
    {
        Int64 n = 0;
        try
        {
            cmd = new SqlCommand("SELECT COUNT(*) FROM jos_railway_mst_supplier", cnn);
            cmd.Connection.Open();
            n = Convert.ToInt64(cmd.ExecuteScalar());
            cmd.Connection.Close();

            //    cmd = new SqlCommand("INSERT INTO jos_railway_mst_supplier(s_name) VALUES (@s_name)", cnn);
            cmd = new SqlCommand("INSERT INTO jos_railway_mst_supplier(s_name,s_address,s_pincode,state,dist,Phone,Landline,mobilen,contactperson,webaddress,emailid) VALUES(@s_name,@s_address,@s_pincode,@state,@dist,@Phone,@Landline,@mobilen,@contactperson,@webaddress,@emailid)", cnn);
            cmd.Parameters.AddWithValue("@s_name", this.s_name);
            cmd.Parameters.AddWithValue("@s_address", this.s_address);
            cmd.Parameters.AddWithValue("@s_pincode", this.s_pincode);
            cmd.Parameters.AddWithValue("@state", this.state);
            cmd.Parameters.AddWithValue("@dist", this.dist);
            cmd.Parameters.AddWithValue("@Phone", this.Phone);
            cmd.Parameters.AddWithValue("@Landline", this.Landline);
            cmd.Parameters.AddWithValue("@mobilen", this.mobilen);
            cmd.Parameters.AddWithValue("@contactperson", this.contactperson);
            cmd.Parameters.AddWithValue("@webaddress", this.webaddress);
            cmd.Parameters.AddWithValue("@emailid", this.emailid);
            cmd.Connection.Open();
            int m = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            if (n > 0)
            {
                cmd = new SqlCommand("SELECT MAX(id_supp) FROM jos_railway_mst_supplier", cnn);
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
            cmd = new SqlCommand("DELETE FROM jos_railway_mst_supplier  WHERE (id_supp=@id_supp)", cnn);
            cmd.Parameters.AddWithValue("@id_supp", this.id_supp);
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
            cmd = new SqlCommand("UPDATE jos_railway_mst_supplier SET s_name =  @s_name,s_address = @s_address,s_pincode = @s_pincode,state = @state,dist = @dist,Phone = @Phone,Landline = @Landline,mobilen = @mobilen,contactperson = @contactperson,webaddress = @webaddress,emailid = @emailid WHERE id_supp=@id_supp", cnn);
            cmd.Parameters.AddWithValue("@id_supp", this.id_supp);
            cmd.Parameters.AddWithValue("@s_name", this.s_name);
            cmd.Parameters.AddWithValue("@s_address", this.s_address);
            cmd.Parameters.AddWithValue("@s_pincode", this.s_pincode);
            cmd.Parameters.AddWithValue("@state", this.state);
            cmd.Parameters.AddWithValue("@dist", this.dist);
            cmd.Parameters.AddWithValue("@Phone", this.Phone);
            cmd.Parameters.AddWithValue("@Landline", this.Landline);
            cmd.Parameters.AddWithValue("@mobilen", this.mobilen);
            cmd.Parameters.AddWithValue("@contactperson", this.contactperson);
            cmd.Parameters.AddWithValue("@webaddress", this.webaddress);
            cmd.Parameters.AddWithValue("@emailid", this.emailid);
            cmd.Connection.Open();
            int n = Convert.ToInt16(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            return n;
        }
        catch { throw; }
    }

    public bool IsDataExists()
    {
        cmd = new SqlCommand("select count(*) from jos_railway_mst_supplier where s_name ='" + this.s_name + "'", cnn);


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
        cmd = new SqlCommand("SELECT * FROM jos_railway_mst_supplier", cnn);
        dt = new DataTable();
        da = new SqlDataAdapter();
        da.SelectCommand = cmd;
        dt.Clear();
        da.Fill(dt);
        return dt;
    }
}



