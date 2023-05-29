using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
/// <summary>
/// Summary description for Cls_Loco_Assembly_Supplier
/// </summary>
public class Cls_Loco_Assembly_Supplier : Cls_DBConnection
{
    public string rdso;
    public string id_supp;
    public Cls_Loco_Assembly_Supplier()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public Int64 Insert_Data()
    {
        cmd = new SqlCommand("INSERT INTO Loco_Assembly_Supplier(rdso,id_supp)VALUES(@rdso,@id_supp)", cnn);
        cmd.Parameters.AddWithValue("@rdso", this.rdso);
        cmd.Parameters.AddWithValue("@id_supp", this.id_supp);
        cmd.Connection.Open();
        Int16 n = Convert.ToInt16(cmd.ExecuteNonQuery());
        cmd.Connection.Close();
        if (n == 1)
        {
            cmd = new SqlCommand("SELECT MAX(Id_Ass_Supp) FROM Loco_Assembly_Supplier", cnn);
            cmd.Connection.Open();
            Int64 m = Convert.ToInt64(cmd.ExecuteScalar());
            cmd.Connection.Close();
            return m;
        }
        else { return 0; }
    }
    public DataTable SelectSupplierByAssembly()
    {
        try
        {
            cmd = new SqlCommand("SELECT jos_railway_mst_supplier.id_supp,jos_railway_mst_supplier.s_name FROM jos_railway_mst_supplier INNER JOIN Loco_Assembly_Supplier ON Loco_Assembly_Supplier.id_supp=jos_railway_mst_supplier.id_supp WHERE Loco_Assembly_Supplier.rdso=@rdso", cnn);
            cmd.Parameters.AddWithValue("@rdso", this.rdso);
            da = new SqlDataAdapter();
            dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        catch { throw; }
    }
}
