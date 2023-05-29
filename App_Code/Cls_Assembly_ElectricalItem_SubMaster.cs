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
/// Summary description for Cls_Assembly_ElectricalItem_SubMaster
/// </summary>
public class Cls_Assembly_ElectricalItem_SubMaster : Cls_DBConnection
{
    public string Id_Electrical;
    public string Id_ElectricalSub;
    public string Grno;
    public string ItemDescription;
    public string EMDPrno;
    public string QEMPrno;
    public string SWRPlno;
    public string DLWPlno;
    public string Qty;
    public string Lpr;
    public Cls_Assembly_ElectricalItem_SubMaster()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public Int64 Insert_Data()
    {
        cmd = new SqlCommand("INSERT INTO Assembly_Electrical_Sub_Master(Id_Electrical,Grno,ItemDescription,EMDPrno,QEMPrno,SWRPlno,DLWPlno,Qty,Lpr)VALUES(@Id_Electrical,@Grno,@ItemDescription,@EMDPrno,@QEMPrno,@SWRPlno,@DLWPlno,@Qty,@Lpr)", cnn);
        cmd.Parameters.AddWithValue("@DLWPlno", this.DLWPlno);
        cmd.Parameters.AddWithValue("@EMDPrno", this.EMDPrno);
        cmd.Parameters.AddWithValue("@Grno", this.Grno);
        cmd.Parameters.AddWithValue("@Id_Electrical", this.Id_Electrical);
        cmd.Parameters.AddWithValue("@ItemDescription", this.ItemDescription);
        cmd.Parameters.AddWithValue("@Lpr", this.Lpr);
        cmd.Parameters.AddWithValue("@QEMPrno", this.QEMPrno);
        cmd.Parameters.AddWithValue("@Qty", this.Qty);
        cmd.Parameters.AddWithValue("@SWRPlno", this.SWRPlno);
        cmd.Connection.Open();
        Int16 n = Convert.ToInt16(cmd.ExecuteNonQuery());
        cmd.Connection.Close();
        cmd = new SqlCommand("SELECT MAX(Id_ElectricalSub) FROM Assembly_Electrical_Sub_Master", cnn);
        if (n == 1)
        {
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
        cmd = new SqlCommand("UPDATE Assembly_Electrical_Sub_Master SET DLWPlno=@DLWPlno,EMDPrno=@EMDPrno,Grno=@Grno,Id_Electrical=@Id_Electrical,ItemDescription=@ItemDescription,Lpr=@Lpr,QEMPrno=@QEMPrno,Qty=@Qty,SWRPlno=@SWRPlno WHERE Id_ElectricalSub=@Id_ElectricalSub", cnn);
        cmd.Parameters.AddWithValue("@Id_ElectricalSub", this.Id_ElectricalSub);
        cmd.Parameters.AddWithValue("@DLWPlno", this.DLWPlno);
        cmd.Parameters.AddWithValue("@EMDPrno", this.EMDPrno);
        cmd.Parameters.AddWithValue("@Grno", this.Grno);
        cmd.Parameters.AddWithValue("@Id_Electrical", this.Id_Electrical);
        cmd.Parameters.AddWithValue("@ItemDescription", this.ItemDescription);
        cmd.Parameters.AddWithValue("@Lpr", this.Lpr);
        cmd.Parameters.AddWithValue("@QEMPrno", this.QEMPrno);
        cmd.Parameters.AddWithValue("@Qty", this.Qty);
        cmd.Parameters.AddWithValue("@SWRPlno", this.SWRPlno);
        cmd.Connection.Open();
        Int16 n = Convert.ToInt16(cmd.ExecuteNonQuery());
        cmd.Connection.Close();
        return n == 1 ? true : false;
    }
    public bool Delete_Data()
    {
        cmd = new SqlCommand("DELETE FROM Assembly_Electrical_Sub_Master WHERE Id_ElectricalSub=@Id_ElectricalSub", cnn);
        cmd.Parameters.AddWithValue("@Id_ElectricalSub", this.Id_ElectricalSub);
        cmd.Connection.Open();
        Int16 n = Convert.ToInt16(cmd.ExecuteNonQuery());
        cmd.Connection.Close();
        return n == 1 ? true : false;

    }
    public DataTable Select_DataByItemId()
    {
        cmd = new SqlCommand("SELECT * FROM Assembly_Electrical_Sub_Master WHERE Id_Electrical=@Id_Electrical", cnn);
        cmd.Parameters.AddWithValue("@Id_Electrical", this.Id_Electrical);
        da = new SqlDataAdapter();
        dt = new DataTable();
        da.SelectCommand = cmd;
        da.Fill(dt);
        return dt;
    }
    public DataTable Select_DataById()
    {
        cmd = new SqlCommand("SELECT * FROM Assembly_Electrical_Sub_Master WHERE Id_ElectricalSub=@Id_ElectricalSub", cnn);
        cmd.Parameters.AddWithValue("@Id_ElectricalSub", this.Id_ElectricalSub);
        da = new SqlDataAdapter();
        dt = new DataTable();
        da.SelectCommand = cmd;
        da.Fill(dt);
        return dt;
    }
}
