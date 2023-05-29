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
/// Summary description for Cls_Assembly_MechanicalItem_SubMaster
/// </summary>
public class Cls_Assembly_MechanicalItem_SubMaster : Cls_DBConnection
{
    public string Id_MechanicalSub;
    public string Id_Mechanical;
    public string Grno;
    public string ItemDescription;
    public string EMDPrno;
    public string QEMPrno;
    public string SWRPrno;
    public string DlwPlno;
    public string Qty;
    public string Rate;
    string s = "Id_Mechanical,Grno,ItemDescription,EMDPrno,QEMPrno,DlwPlno,Qty,Rate";
    public Cls_Assembly_MechanicalItem_SubMaster()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public Int64 Insert_Data()
    {
        cmd = new SqlCommand("INSERT INTO Assembly_Mechanical_Item_SubMaster(Id_Mechanical,Grno,ItemDescription,EMDPrno,QEMPrno,SWRPrno,DlwPlno,Qty,Rate) VALUES(@Id_Mechanical,@Grno,@ItemDescription,@EMDPrno,@QEMPrno,@SWRPrno,@DlwPlno,@Qty,@Rate)", cnn);
        cmd.Parameters.AddWithValue("@DlwPlno", this.DlwPlno);
        cmd.Parameters.AddWithValue("@EMDPrno", this.EMDPrno);
        cmd.Parameters.AddWithValue("@Grno", this.Grno);
        cmd.Parameters.AddWithValue("@Id_Mechanical", this.Id_Mechanical);
        cmd.Parameters.AddWithValue("@ItemDescription", this.ItemDescription);
        cmd.Parameters.AddWithValue("@QEMPrno", this.QEMPrno);
        cmd.Parameters.AddWithValue("@SWRPrno", this.SWRPrno);
        cmd.Parameters.AddWithValue("@Qty", this.Qty);
        cmd.Parameters.AddWithValue("@Rate", this.Rate);
        cmd.Connection.Open();
        Int16 n = Convert.ToInt16(cmd.ExecuteNonQuery());
        cmd.Connection.Close();
        if (n == 1)
        {
            cmd = new SqlCommand("SELECT MAX(Id_MechanicalSub) FROM Assembly_Mechanical_Item_SubMaster", cnn);
            cmd.Connection.Open();
            Int64 m = Convert.ToInt16(cmd.ExecuteScalar());
            cmd.Connection.Close();
            return m;
        }
        else { return 0; }
    }
    public bool Update_Data()
    {
        cmd = new SqlCommand("UPDATE Assembly_Mechanical_Item_SubMaster SET DlwPlno=@DlwPlno,EMDPrno=@EMDPrno,Grno=@Grno,Id_Mechanical=@Id_Mechanical,ItemDescription=@ItemDescription,QEMPrno=@QEMPrno,SWRPrno=@SWRPrno,Qty=@Qty,Rate=@Rate WHERE Id_MechanicalSub=@Id_MechanicalSub", cnn);
        cmd.Parameters.AddWithValue("@Id_MechanicalSub", this.Id_MechanicalSub);
        cmd.Parameters.AddWithValue("@DlwPlno", this.DlwPlno);
        cmd.Parameters.AddWithValue("@EMDPrno", this.EMDPrno);
        cmd.Parameters.AddWithValue("@Grno", this.Grno);
        cmd.Parameters.AddWithValue("@Id_Mechanical", this.Id_Mechanical);
        cmd.Parameters.AddWithValue("@ItemDescription", this.ItemDescription);
        cmd.Parameters.AddWithValue("@QEMPrno", this.QEMPrno);
        cmd.Parameters.AddWithValue("@SWRPrno", this.SWRPrno);
        cmd.Parameters.AddWithValue("@Qty", this.Qty);
        cmd.Parameters.AddWithValue("@Rate", this.Rate);
        
        cmd.Connection.Open();
        Int16 n = Convert.ToInt16(cmd.ExecuteNonQuery());
        cmd.Connection.Close();
        return n == 1 ? true : false;
    }
    public bool Delete_Data()
    {
        cmd = new SqlCommand("DELETE FROM Assembly_Mechanical_Item_SubMaster WHERE Id_MechanicalSub=@Id_MechanicalSub", cnn);
        cmd.Parameters.AddWithValue("@Id_MechanicalSub", this.Id_MechanicalSub);
        cmd.Connection.Open();
        Int16 n = Convert.ToInt16(cmd.ExecuteNonQuery());
        cmd.Connection.Close();
        return n == 1 ? true : false;
    }
    public DataTable Select_DataByItemId()
    {
        cmd = new SqlCommand("SELECT * FROM Assembly_Mechanical_Item_SubMaster WHERE Id_Mechanical=@Id_Mechanical", cnn);
        cmd.Parameters.AddWithValue("@Id_Mechanical", this.Id_Mechanical);
        da = new SqlDataAdapter();
        dt = new DataTable();
        da.SelectCommand = cmd;
        da.Fill(dt);
        return dt;

    }
    public DataTable Select_DataById()
    {
        cmd = new SqlCommand("SELECT * FROM Assembly_Mechanical_Item_SubMaster WHERE Id_MechanicalSub=@Id_MechanicalSub", cnn);
        cmd.Parameters.AddWithValue("@Id_MechanicalSub", this.Id_MechanicalSub);
        da = new SqlDataAdapter();
        dt = new DataTable();
        da.SelectCommand = cmd;
        da.Fill(dt);
        return dt;
    }
}
