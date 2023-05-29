using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Railway;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for Cls_Loco_Assembly_History
/// </summary>
public class Cls_Loco_Assembly_History : Cls_DBConnection
{
    public string Id_LocoHistory;
    public string Id_LocoNo;
    public string RdsoCode;
    public string GenerationDate;
    public string AssemblyNo;
    public string id_rdso;
    public string id_supp;
    public Cls_Loco_Assembly_History()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public bool Delete_Data()
    {
        try
        {
            cmd = new SqlCommand("DELETE FROM Loco_History WHERE Id_LocoHistory=@Id_LocoHistory", cnn);
            cmd.Parameters.AddWithValue("@Id_LocoHistory", this.Id_LocoHistory);
            cmd.Connection.Open();
            Int16 n = Convert.ToInt16(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            return n == 1 ? true : false;
        }
        catch { throw; }

    }
    public bool Check_Existance()
    {
        try
        {
            cmd = new SqlCommand("SELECT COUNT(*) FROM Loco_History WHERE AssemblyNo=@AssemblyNo", cnn);
            cmd.Parameters.AddWithValue("@AssemblyNo", this.AssemblyNo);
            cmd.Connection.Open();
            Int16 n = Convert.ToInt16(cmd.ExecuteScalar());
            cmd.Connection.Close();
            return n == 1 ? true : false;
        }
        catch { throw; }

    }
    public DataTable Generate_AssemblyReport(string strquery)
    {
        cmd = new SqlCommand("SELECT Id_LocoHistory" +
        ",(SELECT locono FROM jos_Railway_mst_loco WHERE id_mst_loco=Loco_History.Id_LocoNo)as LocoNo " +
        ", CONVERT(VARCHAR(10),RdsoCode) as RdsoCode " +
        ", AssemblyNo " +
        ",REPLACE(CONVERT(VARCHAR(10),GenerationDate,105),'-','/') as GenerationDate" +
        ",(SELECT nature_defect FROM jos_railway_rdso WHERE rdso=LEFT(Loco_History.RdsoCode,1)) as Rdso1 " +
        ",(SELECT nature_defect FROM jos_railway_rdso WHERE rdso=LEFT(Loco_History.RdsoCode,2)) as Rdso2 " +
        ",(SELECT nature_defect FROM jos_railway_rdso WHERE rdso=LEFT(Loco_History.RdsoCode,3)) as Rdso3 " +
        ",(SELECT nature_defect FROM jos_railway_rdso WHERE rdso=LEFT(Loco_History.RdsoCode,4)AND LEN(Loco_History.RdsoCode)=4) as Rdso4 " +
        " FROM Loco_History " + strquery + " Order By GenerationDate Asc", cnn);
        string s = cmd.CommandText;
        da = new SqlDataAdapter();
        dt = new DataTable();
        da.SelectCommand = cmd;
        da.Fill(dt);
        return dt;
    }
    public DataTable Select_SupplierbyRDSO()
    {
      //  cmd = new SqlCommand("SELECT Loco_Assembly_Supplier.Id_Ass_Supp, jos_railway_mst_supplier.id_supp, Loco_Assembly_Supplier.Id_LocoHistory, Loco_Assembly_Supplier.id_rdso, jos_railway_mst_supplier.s_name, jos_railway_mst_supplier.s_address, jos_railway_mst_supplier.s_phone_no,  jos_railway_mst_supplier.s_compponant_name, jos_railway_mst_supplier.s_plno, jos_railway_mst_supplier.s_make, jos_railway_mst_supplier.s_rate, jos_railway_mst_supplier.s_waranty FROM         Loco_Assembly_Supplier INNER JOIN jos_railway_mst_supplier ON Loco_Assembly_Supplier.id_supp = jos_railway_mst_supplier.id_supp  WHERE Loco_Assembly_Supplier.id_rdso='"+this.RdsoCode+"' ", cnn);
        cmd = new SqlCommand("SELECT Loco_Assembly_Supplier.Id_Ass_Supp, jos_railway_mst_supplier.id_supp, Loco_Assembly_Supplier.Id_LocoHistory, Loco_Assembly_Supplier.id_rdso, jos_railway_mst_supplier.s_name, jos_railway_mst_supplier.s_address, jos_railway_mst_supplier.s_phone_no,  jos_railway_mst_supplier.s_compponant_name, jos_railway_mst_supplier.s_plno, jos_railway_mst_supplier.s_make, jos_railway_mst_supplier.s_rate, jos_railway_mst_supplier.s_waranty FROM         Loco_Assembly_Supplier INNER JOIN jos_railway_mst_supplier ON Loco_Assembly_Supplier.id_supp = jos_railway_mst_supplier.id_supp  ", cnn);
     //   cmd.Parameters.AddWithValue("@RdsoCode", this.RdsoCode);
        da = new SqlDataAdapter();
        dt = new DataTable();
        da.SelectCommand = cmd;
        da.Fill(dt);
        return dt;

    }

    public DataTable Select_AssemblyByLoocNo()
    {
        cmd = new SqlCommand("SELECT Id_LocoHistory" +
    ",(SELECT locono FROM jos_Railway_mst_loco WHERE id_mst_loco=Loco_History.Id_LocoNo)as LocoNo " +
    ", CONVERT(VARCHAR(10),RdsoCode) as RdsoCode " +
    ", AssemblyNo " +
    ",REPLACE(CONVERT(VARCHAR(10),GenerationDate,105),'-','/') as GenerationDate" +
    ",(SELECT nature_defect FROM jos_railway_rdso WHERE rdso=LEFT(Loco_History.RdsoCode,1)) as Rdso1 " +
    ",(SELECT nature_defect FROM jos_railway_rdso WHERE rdso=LEFT(Loco_History.RdsoCode,2)) as Rdso2 " +
    ",(SELECT nature_defect FROM jos_railway_rdso WHERE rdso=LEFT(Loco_History.RdsoCode,3)) as Rdso3 " +
    ",(SELECT nature_defect FROM jos_railway_rdso WHERE rdso=LEFT(Loco_History.RdsoCode,4)AND LEN(Loco_History.RdsoCode)=4) as Rdso4 " +
    " FROM Loco_History WHERE Id_LocoNo=@Id_LocoNo Order By GenerationDate Asc", cnn);
        cmd.Parameters.AddWithValue("@Id_LocoNo", this.Id_LocoNo);
        da = new SqlDataAdapter();
        dt = new DataTable();
        da.SelectCommand = cmd;
        da.Fill(dt);
        return dt;

    }
    public Int64 Insert_Asse_Supp()
    {
        try
        {
            cmd = new SqlCommand("INSERT INTO Loco_Assembly_Supplier(Id_LocoHistory, id_rdso, id_supp) VALUES(@Id_LocoHistory,@id_rdso,@id_supp)", cnn);
            cmd.Parameters.AddWithValue("@Id_LocoHistory", this.Id_LocoHistory);
            cmd.Parameters.AddWithValue("@id_rdso", this.id_rdso);
            cmd.Parameters.AddWithValue("@id_supp", this.id_supp);

            cmd.Connection.Open();
            Int16 n = Convert.ToInt16(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            return n;
        }
        catch
        {
            throw;
        }

    }

    public Int64 Insert_Data()
    {
        try
        {
            cmd = new SqlCommand("INSERT INTO Loco_History (Id_LocoNo,RdsoCode,GenerationDate,AssemblyNo) VALUES(@Id_LocoNo,@RdsoCode,@GenerationDate,@AssemblyNo)", cnn);
            cmd.Parameters.AddWithValue("@AssemblyNo", this.AssemblyNo);
            cmd.Parameters.AddWithValue("@GenerationDate", this.GenerationDate);
            cmd.Parameters.AddWithValue("@Id_LocoNo", this.Id_LocoNo);
            cmd.Parameters.AddWithValue("@RdsoCode", this.RdsoCode);
            cmd.Connection.Open();
            Int16 n = Convert.ToInt16(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            if (n == 1)
            {
                cmd = new SqlCommand("SELECT MAX(Id_LocoHistory) FROM Loco_History", cnn);
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
        catch { throw; }
    }
    public bool Update_Data()
    {
        try
        {
            cmd = new SqlCommand("UPDATE Loco_History SET Id_LocoNo=@Id_LocoNo,RdsoCode=@RdsoCode,GenerationDate=@GenerationDate,AssemblyNo=@AssemblyNo WHERE Id_LocoHistory=@Id_LocoHistory", cnn);
            cmd.Parameters.AddWithValue("@AssemblyNo", this.AssemblyNo);
            cmd.Parameters.AddWithValue("@GenerationDate", this.GenerationDate);
            cmd.Parameters.AddWithValue("@Id_LocoNo", this.Id_LocoNo);
            cmd.Parameters.AddWithValue("@RdsoCode", this.RdsoCode);
            cmd.Parameters.AddWithValue("@Id_LocoHistory", this.Id_LocoHistory);
            cmd.Connection.Open();
            Int16 n = Convert.ToInt16(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            return n == 1 ? true : false;
        }
        catch { throw; }
    }
}
