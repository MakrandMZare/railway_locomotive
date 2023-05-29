using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data;
using System.Data.SqlClient;
/// <summary>
/// Summary description for Cls_Assembly_ElectricalItem
/// </summary>
public class Cls_Assembly_ElectricalItem : Cls_DBConnection
{
    public string Id_Electrical;
    public string NameOfItem;
    public Cls_Assembly_ElectricalItem()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public Int64 Insert_Data()
    {

        cmd = new SqlCommand("INSERT INTO Assembly_ElectricalItem_Master(NameOfItem) VALUES(@NameOfItem)", cnn);
        cmd.Parameters.AddWithValue("@NameOfItem", this.NameOfItem);
        cmd.Connection.Open();
        Int16 n = Convert.ToInt16(cmd.ExecuteNonQuery());
        cmd.Connection.Close();
        if (n == 1)
        {
            cmd = new SqlCommand("SELECT MAX(Id_Electrical) FROM Assembly_ElectricalItem_Master", cnn);
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
            cmd = new SqlCommand("UPDATE Assembly_ElectricalItem_Master SET NameOfItem=@NameOfItem WHERE Id_Electrical=@Id_Electrical", cnn);
            cmd.Parameters.AddWithValue("@Id_Electrical", this.Id_Electrical);
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
            cmd = new SqlCommand("DELETE FROM Assembly_ElectricalItem_Master WHERE Id_Electrical=@Id_Electrical", cnn);
            cmd.Parameters.AddWithValue("@Id_Electrical", this.Id_Electrical);
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
            cmd = new SqlCommand("SELECT * FROM Assembly_ElectricalItem_Master", cnn);
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
        try {
            cmd = new SqlCommand("SELECT * FROM Assemlby_ElectricalItem_Master", cnn);
            da = new SqlDataAdapter();
            dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        catch { throw; }
    }
}
