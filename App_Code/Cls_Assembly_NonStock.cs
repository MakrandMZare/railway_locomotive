using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data;
using System.Data.SqlClient;
/// <summary>
/// Summary description for Cls_Assembly_NonStock
/// </summary>
public class Cls_Assembly_NonStock : Cls_DBConnection
{
    public string Id_NonStock;
    public string Id_Assembly;
    public string Grno;
    public string Description;
    public string EMDPrno;
    public string DLWPrno;
    public string DrgNo;
    public string Sch_Qpl_Aac;
    public string Pac;
    public string Rdso1;
    public string Rdso2;
    public string Dlw1;
    public string Dlw2;
    public string Upr;
    public Cls_Assembly_NonStock()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public Int64 Insert_Data()
    {
        cmd = new SqlCommand("INSERT INTO Assembly_NonStockItem(Id_Assembly,Grno,Description,EMDPrno,DLWPrno,DrgNo,Sch_Qpl_Aac,Pac,Rdso1,Rdso2,Dlw1,Dlw2,Upr) VALUES(@Id_Assembly,@Grno,@Description,@EMDPrno,@DLWPrno,@DrgNo,@Sch_Qpl_Aac,@Pac,@Rdso1,@Rdso2,@Dlw1,@Dlw2,@Upr)", cnn);
        cmd.Parameters.AddWithValue("@Description", this.Description);
        cmd.Parameters.AddWithValue("@Dlw1", this.Dlw1);
        cmd.Parameters.AddWithValue("@Dlw2", this.Dlw2);
        cmd.Parameters.AddWithValue("@DLWPrno", this.DLWPrno);
        cmd.Parameters.AddWithValue("@DrgNo", this.DrgNo);
        cmd.Parameters.AddWithValue("@EMDPrno", this.EMDPrno);
        cmd.Parameters.AddWithValue("@Grno", this.Grno);
        cmd.Parameters.AddWithValue("@Id_Assembly", this.Id_Assembly);
        cmd.Parameters.AddWithValue("@Pac", this.Pac);
        cmd.Parameters.AddWithValue("@Rdso1", this.Rdso1);
        cmd.Parameters.AddWithValue("@Rdso2", this.Rdso2);
        cmd.Parameters.AddWithValue("@Sch_Qpl_Aac", this.Sch_Qpl_Aac);
        cmd.Parameters.AddWithValue("@Upr", this.Upr);
        cmd.Connection.Open();
        Int16 m = Convert.ToInt16(cmd.ExecuteNonQuery());
        cmd.Connection.Close();
        if (m == 1)
        {
            cmd = new SqlCommand("SELECT MAX(Id_NonStock) FROM Assembly_NonStockItem", cnn);
            cmd.Connection.Open();
            Int64 n = Convert.ToInt64(cmd.ExecuteScalar());
            cmd.Connection.Close();
            return n;
        }
        else
        { return 0; }

    }
    public bool Update_Data()
    {
        cmd = new SqlCommand("UPDATE Assembly_NonStockItem SET Id_Assembly=@Id_Assembly,Grno=@Grno,Description=@Description,EMDPrno=@EMDPrno,DLWPrno=@DLWPrno,DrgNo=@DrgNo,Sch_Qpl_Aac=@Sch_Qpl_Aac,Pac=@Pac,Rdso1=@Rdso1,Rdso2=@Rdso2,Dlw1=@Dlw1,Dlw2=@Dlw2,Upr=@Upr WHERE Id_NonStock=@Id_NonStock", cnn);
        cmd.Parameters.AddWithValue("@Id_NonStock", this.Id_NonStock);
        cmd.Parameters.AddWithValue("@Description", this.Description);
        cmd.Parameters.AddWithValue("@Dlw1", this.Dlw1);
        cmd.Parameters.AddWithValue("@Dlw2", this.Dlw2);
        cmd.Parameters.AddWithValue("@DLWPrno", this.DLWPrno);
        cmd.Parameters.AddWithValue("@DrgNo", this.DrgNo);
        cmd.Parameters.AddWithValue("@EMDPrno", this.EMDPrno);
        cmd.Parameters.AddWithValue("@Grno", this.Grno);
        cmd.Parameters.AddWithValue("@Id_Assembly", this.Id_Assembly);
        cmd.Parameters.AddWithValue("@Pac", this.Pac);
        cmd.Parameters.AddWithValue("@Rdso1", this.Rdso1);
        cmd.Parameters.AddWithValue("@Rdso2", this.Rdso2);
        cmd.Parameters.AddWithValue("@Sch_Qpl_Aac", this.Sch_Qpl_Aac);
        cmd.Parameters.AddWithValue("@Upr", this.Upr);
        cmd.Connection.Open();
        Int16 n = Convert.ToInt16(cmd.ExecuteNonQuery());
        cmd.Connection.Close();
        return n == 1 ? true : false;
    }
    public bool Delete_Data()
    {
        cmd = new SqlCommand("DELETE FROM Assembly_NonStockItem WHERE Id_NonStock=@Id_NonStock", cnn);
        cmd.Parameters.AddWithValue("@Id_NonStock", this.Id_NonStock);
        cmd.Connection.Open();
        Int16 n = Convert.ToInt16(cmd.ExecuteNonQuery());
        cmd.Connection.Close();
        return n == 1 ? true : false;

    }
    public DataTable Select_DataByAssemblyId()
    {
        cmd = new SqlCommand("SELECT * FROM Assembly_NonStockItem WHERE Id_Assembly=@Id_Assembly", cnn);
        cmd.Parameters.AddWithValue("@Id_Assembly", this.Id_Assembly);
        da = new SqlDataAdapter();
        dt = new DataTable();
        da.SelectCommand = cmd;
        da.Fill(dt);
        return dt;
    }
    public DataTable Select_DataById()
    {
        cmd = new SqlCommand("SELECT * FROM Assembly_NonStockItem WHERE Id_NonStock=@Id_NonStock", cnn);
        cmd.Parameters.AddWithValue("@Id_NonStock", this.Id_NonStock);
        da = new SqlDataAdapter();
        dt = new DataTable();
        da.SelectCommand = cmd;
        da.Fill(dt);
        return dt;
    }
}
