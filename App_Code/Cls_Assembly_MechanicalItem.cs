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
/// Summary description for Cls_Assembly_MechanicalItem
/// </summary>
public class Cls_Assembly_MechanicalItem : Cls_DBConnection 
{
    public Cls_Assembly_MechanicalItem()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public string Id_Mechanic;
    public string NameOfItem;
    public Int64 Insert_Data()
    {

        cmd = new SqlCommand("INSERT INTO Assembly_MechanicalItem_Master(NameOfItem) VALUES(@NameOfItem)", cnn);
        cmd.Parameters.AddWithValue("@NameOfItem", this.NameOfItem);
        cmd.Connection.Open();
        Int16 n = Convert.ToInt16(cmd.ExecuteNonQuery());
        cmd.Connection.Close();
        if (n == 1)
        {
            cmd = new SqlCommand("SELECT MAX(Id_Mechanic) FROM Assembly_MechanicalItem_Master", cnn);
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
    public bool Update_Data()
    {
        try
        {
            cmd = new SqlCommand("UPDATE Assembly_MechanicalItem_Master SET NameOfItem=@NameOfItem WHERE Id_Mechanic=@Id_Mechanic", cnn);
            cmd.Parameters.AddWithValue("@Id_Mechanic", this.Id_Mechanic);
            cmd.Parameters.AddWithValue("@NameOfItem", this.NameOfItem);
            cmd.Connection.Open();
            Int16 n = Convert.ToInt16(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            return n == 1 ? true : false;
        }
        catch { throw; }
    }
    public bool Delete_Data()
    {
        try
        {
            cmd = new SqlCommand("DELETE FROM Assembly_MechanicalItem_Master WHERE Id_Mechanic=@Id_Mechanic", cnn);
            cmd.Parameters.AddWithValue("@Id_Mechanic", this.Id_Mechanic);
            cmd.Connection.Open();
            Int16 n = Convert.ToInt16(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            return n == 1 ? true : false;
        }
        catch { throw; }
    }
    public DataTable Select_Data()
    {
        try
        {
            cmd = new SqlCommand("SELECT * FROM Assembly_MechanicalItem_Master", cnn);
            da = new SqlDataAdapter();
            dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        catch { throw; }
    }
    public DataTable Select_DataById()
    {
        try
        {
            cmd = new SqlCommand("SELECT * FROM Assembly_MechanicalItem_Master", cnn);
            da = new SqlDataAdapter();
            dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        catch { throw; }
    }
}

