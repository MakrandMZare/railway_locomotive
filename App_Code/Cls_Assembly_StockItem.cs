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
/// Summary description for Cls_Assembly_StockItem
/// </summary>
public class Cls_Assembly_StockItem : Cls_DBConnection
{
    public string Id_Assembly;
    public string Id_Stock;
    public string Grno;
    public string Description;
    public string EmdPrno;
    public string DLWplno;
    public string Drgno;
    public string Sch_Qpl_Aac;
    public string Pac;
    public string Rdso1;
    public string Rdso2;
    public string Dlw1;
    public string Dlw2;
    public string Lpr;
    public string Swrno;

    public Cls_Assembly_StockItem()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public DataTable SelectDataById()
    {
        try
        {
            cmd = new SqlCommand("SELECT * FROM Assembly_Stock_Item WHERE Id_Stock=@Id_Stock", cnn);
            cmd.Parameters.AddWithValue("@Id_Stock", this.Id_Stock);
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
        try
        {
            cmd = new SqlCommand("INSERT INTO Assembly_Stock_Item(Id_Assembly,Grno,Description,EmdPrno,DLWplno,Drgno,Sch_Qpl_Aac,Pac,Rdso1,Rdso2,Dlw1,Dlw2,Lpr,Swrno) VALUES(@Id_Assembly,@Grno,@Description,@EmdPrno,@DLWplno,@Drgno,@Sch_Qpl_Aac,@Pac,@Rdso1,@Rdso2,@Dlw1,@Dlw2,@Lpr,@Swrno)", cnn);

            cmd.Parameters.AddWithValue("@Description", this.Description);
            cmd.Parameters.AddWithValue("@Dlw1", this.Dlw1);
            cmd.Parameters.AddWithValue("@Dlw2", this.Dlw2);
            cmd.Parameters.AddWithValue("@DLWplno", this.DLWplno);
            cmd.Parameters.AddWithValue("@Drgno", this.Drgno);
            cmd.Parameters.AddWithValue("@EmdPrno", this.EmdPrno);
            cmd.Parameters.AddWithValue("@Grno", this.Grno);
            cmd.Parameters.AddWithValue("@Id_Assembly", this.Id_Assembly);
            cmd.Parameters.AddWithValue("@Lpr", this.Lpr);
            cmd.Parameters.AddWithValue("@Pac", this.Pac);
            cmd.Parameters.AddWithValue("@Rdso1", this.Rdso1);
            cmd.Parameters.AddWithValue("@Rdso2", this.Rdso2);
            cmd.Parameters.AddWithValue("@Sch_Qpl_Aac", this.Sch_Qpl_Aac);
            cmd.Parameters.AddWithValue("@Swrno", this.Swrno);

            cmd.Connection.Open();
            Int16 m = Convert.ToInt16(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            if (m == 1)
            {
                cmd = new SqlCommand("SELECT MAX(Id_Stock) FROM Assembly_Stock_Item", cnn);
                cmd.Connection.Open();
                Int64 n = Convert.ToInt64(cmd.ExecuteScalar());
                cmd.Connection.Close();
                return n;
            }
            else { return 0; }
        }
        catch { throw; }
    }
    public bool Update_Data()
    {
        cmd = new SqlCommand("UPDATE Assembly_Stock_Item SET Description=@Description,Dlw1=@Dlw1,Dlw2=@Dlw2,DLWplno=@DLWplno,Drgno=@Drgno,EmdPrno=@EmdPrno,Grno=@Grno,Id_Assembly=@Id_Assembly,Lpr=@Lpr,Pac=@Pac,Rdso1=@Rdso1,Rdso2=@Rdso2,Sch_Qpl_Aac=@Sch_Qpl_Aac,Swrno=@Swrno WHERE Id_Stock=@Id_Stock", cnn);
        cmd.Parameters.AddWithValue("@Description", this.Description);
        cmd.Parameters.AddWithValue("@Dlw1", this.Dlw1);
        cmd.Parameters.AddWithValue("@Dlw2", this.Dlw2);
        cmd.Parameters.AddWithValue("@DLWplno", this.DLWplno);
        cmd.Parameters.AddWithValue("@Drgno", this.Drgno);
        cmd.Parameters.AddWithValue("@EmdPrno", this.EmdPrno);
        cmd.Parameters.AddWithValue("@Grno", this.Grno);
        cmd.Parameters.AddWithValue("@Id_Assembly", this.Id_Assembly);
        cmd.Parameters.AddWithValue("@Lpr", this.Lpr);
        cmd.Parameters.AddWithValue("@Pac", this.Pac);
        cmd.Parameters.AddWithValue("@Rdso1", this.Rdso1);
        cmd.Parameters.AddWithValue("@Rdso2", this.Rdso2);
        cmd.Parameters.AddWithValue("@Sch_Qpl_Aac", this.Sch_Qpl_Aac);
        cmd.Parameters.AddWithValue("@Swrno", this.Swrno);
        cmd.Parameters.AddWithValue("@Id_Stock", this.Id_Stock);
        cmd.Connection.Open();
        Int16 n = Convert.ToInt16(cmd.ExecuteNonQuery());
        cmd.Connection.Close();
        return n == 1 ? true : false;
    }
    public bool Delete_Data()
    {
        cmd = new SqlCommand("Delete From Assembly_Stock_Item WHERE Id_Stock=@Id_Stock", cnn);
        cmd.Parameters.AddWithValue("@Id_Stock", this.Id_Stock);
        cmd.Connection.Open();
        Int16 n = Convert.ToInt16(cmd.ExecuteNonQuery());
        cmd.Connection.Close();
        return n == 1 ? true : false;
    }
    public DataTable Select_DataByAssemblyId()
    {
        cmd = new SqlCommand("SELECT * FROM Assembly_Stock_Item WHERE Id_Assembly=@Id_Assembly", cnn);
        cmd.Parameters.AddWithValue("@Id_Assembly", this.Id_Assembly);
        da = new SqlDataAdapter();
        dt = new DataTable();
        da.SelectCommand = cmd;
        da.Fill(dt);
        return dt;
    }
}
