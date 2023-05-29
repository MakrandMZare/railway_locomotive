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
/// Summary description for Cls_Outage_Holding
/// </summary>
public class Cls_Outage_Holding : Cls_DBConnection
{
    public string Id_Outage;
    public string book;
    public string LocoType;
    public string eff;
    public string Id_Outage_Holding;
    public Cls_Outage_Holding()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public Int64 Insert_Data()
    {
        cmd = new SqlCommand("INSERT INTO Outage_Holding(Id_Outage,book,LocoType,eff)VALUES(@Id_Outage,@book,@LocoType,@eff)", cnn);
        cmd.Parameters.AddWithValue("@Id_Outage", this.Id_Outage);
        cmd.Parameters.AddWithValue("@book", this.book);
        cmd.Parameters.AddWithValue("@LocoType", this.LocoType);
        cmd.Parameters.AddWithValue("@eff", this.eff);
        cmd.Connection.Open();
        Int64 n = cmd.ExecuteNonQuery();
        cmd.Connection.Close();
        if (n == 1)
        {
            cmd = new SqlCommand("SELECT MAX(Id_Outage_Holding) FROM Outage_Holding", cnn);
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
    public DataTable Select_DataById(string LocoType)
    {
        cmd = new SqlCommand("SELECT * FROM Outage_Holding WHERE Id_Outage=@Id_Outage", cnn);
        cmd.Parameters.AddWithValue("@Id_Outage", this.Id_Outage);
        cmd.Parameters.AddWithValue("@LocoType",LocoType);
        da = new SqlDataAdapter();
        da.SelectCommand = cmd;
        dt = new DataTable();
        da.Fill(dt);
        return dt;
    }
    public DataTable Select_DataById_1(string LocoType)
    {
         //cmd = new SqlCommand("SELECT Master_Outage.Id_Outage, Master_Outage.OutageDate, Master_Outage.LocoType, Outage_Holding.Id_Outage_Holding, Outage_Holding.Id_Outage , Outage_Holding.LocoType , Outage_Holding.eff, Outage_Holding.book FROM  Master_Outage INNER JOIN  Outage_Holding ON Master_Outage.Id_Outage=Outage_Holding.Id_Outage WHERE Id_Outage=@Id_Outage", cnn);
        cmd = new SqlCommand("SELECT Master_Outage.Id_Outage, Master_Outage.OutageDate, Master_Outage.LocoType, Outage_Holding.Id_Outage_Holding, Outage_Holding.Id_Outage , Outage_Holding.LocoType , Outage_Holding.eff, Outage_Holding.book FROM  Master_Outage INNER JOIN  Outage_Holding ON Master_Outage.Id_Outage=Outage_Holding.Id_Outage WHERE Master_Outage.Id_Outage=@Id_Outage", cnn);
       // cmd = new SqlCommand("SELECT * FROM Outage_Holding ", cnn);
        cmd.Parameters.AddWithValue("@Id_Outage", this.Id_Outage);
        cmd.Parameters.AddWithValue("@LocoType", LocoType);
        da = new SqlDataAdapter();
        da.SelectCommand = cmd;
        dt = new DataTable();
        da.Fill(dt);
        return dt;
    }
}
