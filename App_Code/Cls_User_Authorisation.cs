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
/// <summary>
/// Summary description for Cls_User_Authorisation
/// </summary>
public class Cls_User_Authorisation : Cls_DBConnection
{
    public string Id_UserAuthorisation;
    public string Id_User;
    public string ModuleName;
    public string ActionType;
    public string PermissionType;
    
    public Cls_User_Authorisation()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public bool Check_Existance()
    {
        try
        {
            cmd = new SqlCommand("SELECT COUNT(*) FROM User_Authorisation WHERE Id_User=@Id_User AND ModuleName=@ModuleName AND ActionType=@ActionType", cnn);
            cmd.Parameters.AddWithValue("@Id_User", this.Id_User);
            cmd.Parameters.AddWithValue("@ModuleName", this.ModuleName);
            cmd.Parameters.AddWithValue("@ActionType", this.ActionType);
            cmd.Connection.Open();
            Int16 n = Convert.ToInt16(cmd.ExecuteScalar());
            cmd.Connection.Close();
            return n == 1 ? true : false;
        }
        catch { throw; }
    }
    public bool Get_Permission()
    {
        cmd = new SqlCommand("SELECT PermissionType FROM User_Authorisation WHERE Id_UserAuthorisation=@Id_UserAuthorisation", cnn);
        cmd.Parameters.AddWithValue("@Id_UserAuthorisation", this.Id_UserAuthorisation);
        cmd.Connection.Open();
        Int16 n = Convert.ToInt16(cmd.ExecuteScalar());
        cmd.Connection.Close();
        return n == 1 ? true : false;
        
    }
    public Int64 Get_Id()
    {
        try
        {
            cmd = new SqlCommand("SELECT Id_UserAuthorisation FROM User_Authorisation WHERE Id_User=@Id_User AND ModuleName=@ModuleName AND ActionType=@ActionType", cnn);
            cmd.Parameters.AddWithValue("@Id_User", this.Id_User);
            cmd.Parameters.AddWithValue("@ModuleName", this.ModuleName);
            cmd.Parameters.AddWithValue("@ActionType", this.ActionType);
            cmd.Connection.Open();
            Int64 n = Convert.ToInt16(cmd.ExecuteScalar());
            cmd.Connection.Close();
            return n;
        }
        catch { throw; }
    }
    public Int64 Insert_Data()
    {
        try
        {
            cmd = new SqlCommand("INSERT INTO User_Authorisation(Id_User,ModuleName,ActionType,PermissionType) VALUES(@Id_User,@ModuleName,@ActionType,@PermissionType)", cnn);
            cmd.Parameters.AddWithValue("@Id_User", this.Id_User);
            cmd.Parameters.AddWithValue("@ModuleName", this.ModuleName);
            cmd.Parameters.AddWithValue("@PermissionType", this.PermissionType);
            cmd.Parameters.AddWithValue("@ActionType", this.ActionType);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            cmd = new SqlCommand("SELECT MAX(Id_UserAuthorisation) FROM User_Authorisation", cnn);
            cmd.Connection.Open();
            Int64 m = Convert.ToInt64(cmd.ExecuteScalar());
            cmd.Connection.Close();
            return m;
        }
        catch { throw; }
    }
    public void Update_Data()
    {
        cmd = new SqlCommand("UPDATE User_Authorisation SET PermissionType=@PermissionType WHERE Id_UserAuthorisation=@Id_UserAuthorisation", cnn);
        cmd.Parameters.AddWithValue("@Id_UserAuthorisation", this.Id_UserAuthorisation);
        cmd.Parameters.AddWithValue("@PermissionType", this.PermissionType);
        cmd.Connection.Open();
        cmd.ExecuteNonQuery();
        cmd.Connection.Close();
    }
}
