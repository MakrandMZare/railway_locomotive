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
/// Summary description for Cls_Master_User
/// </summary>
public class Cls_Master_User : Cls_DBConnection
{
    public string Username;
    public string Password;
    public string Id_User;
    public string Department;
    public Cls_Master_User()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public bool Check_Login()
    {
        
            cmd = new SqlCommand("SELECT COUNT(*) FROM Master_User WHERE Username=@Username AND Password=@Password",cnn);
            cmd.Parameters.AddWithValue("@Username", this.Username);
            cmd.Parameters.AddWithValue("@Password", this.Password);
            cmd.Connection.Open();
            Int16 n = Convert.ToInt16(cmd.ExecuteScalar());
            cmd.Connection.Close();
           return n == 1?true:false;
    }
    public string Get_UserTypeById()
    {
        cmd = new SqlCommand("SELECT jos_railway_section.s_type FROM Master_User INNER JOIN jos_railway_section ON jos_railway_section.Id_Section = Master_User.Department WHERE Master_User.Username=@Username", cnn);
        cmd.Parameters.AddWithValue("@Username", this.Username);
        cmd.Connection.Open();
        string str = Convert.ToString(cmd.ExecuteScalar());
        cmd.Connection.Close();
        return str;
    }
    public Int64 Insert_Data()
    {
        try
        {
            cmd = new SqlCommand("INSERT INTO Master_User(Username,Password,Department) VALUES(@Username,@Password,@Department)", cnn);
            cmd.Parameters.AddWithValue("@Username", this.Username);
            cmd.Parameters.AddWithValue("@Password", this.Password);
            cmd.Parameters.AddWithValue("@Department", this.Department);
            cmd.Connection.Open();
            Int64 n = Convert.ToInt64(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            if (n == 1)
            {
                cmd = new SqlCommand("SELECT MAX(Id_User) FROM Master_User", cnn);
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
            cmd.Connection.Close();
            throw;
        }
    }
    public void Update_Data()
    {
        try
        {
            cmd = new SqlCommand("UPDATE Master_User SET Username=@Username,Password=@Password,Department=@Department WHERE Id_User=@Id_User", cnn);
            cmd.Parameters.AddWithValue("@Id_User", this.Id_User);
            cmd.Parameters.AddWithValue("@Username", this.Username);
            cmd.Parameters.AddWithValue("@Password", this.Password);
            cmd.Parameters.AddWithValue("@Department", this.Department);
            Int64 n = Convert.ToInt64(cmd.ExecuteNonQuery());
        }
        catch
        {
            cmd.Connection.Close();
            throw;
        }
    }
    public void Delete_Data()
    {
        try
        {
            cmd = new SqlCommand("DELTE FROM Master_User WHERE Id_User=@Id_User", cnn);
            cmd.Parameters.AddWithValue("@Id_User", this.Id_User);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        catch
        {
            cmd.Connection.Close();
            throw;
        }
    }
    public DataTable Select_Data_ByDepartment()
    {
        try
        {
            cmd = new SqlCommand("SELECT * FROM Master_User WHERE Department=@Department", cnn);
            cmd.Parameters.AddWithValue("@Department", this.Department);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            return dt;
            
        }
        catch { cmd.Connection.Close();
        throw;
        }
    }
    public DataTable Select_Data()
    {
        try
        {
            cmd = new SqlCommand("SELECT * FROM Master_User", cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            return dt;
        }
        catch { cmd.Connection.Close(); throw; }
    }
    public DataTable Select_DataById()
    {
        try
        {
            cmd = new SqlCommand("SELECT * FROM Master_User WHERE Id_User=@Id_User", cnn);
            cmd.Parameters.AddWithValue("@Id_User", this.Id_User);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            return dt;
        }
        catch { cmd.Connection.Close(); throw; }
    }
    public bool Check_Existance()
    {
        try
        {
            cmd = new SqlCommand("SELECT COUNT(*) FROM Master_User WHERE Username=@Username", cnn);
            cmd.Parameters.AddWithValue("@Username", this.Username);
            cmd.Connection.Open();
            int n = Convert.ToInt16(cmd.ExecuteScalar());
            cmd.Connection.Close();
            return n == 1 ? true : false;
        }
        catch { throw; }
    }
}
