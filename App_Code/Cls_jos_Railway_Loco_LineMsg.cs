using System;
using System.Data;
using System.Configuration;
//using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
//using System.Xml.Linq;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Cls_jos_Railway_Loco_LineMsg
/// </summary>
/// 
public class Cls_jos_Railway_Loco_LineMsg : Cls_DBConnection
{

    DataTable dt;
    public string Id_Loco_Linemsg;
    public string Loco_Id;
    public string Loco_Date;
    public string TrainNo;
    public string Site_Id;
    public string SiteSection_Id;
    public string LineMsg;
    public string Schedule;
    public string Last_Sch_Date;
    public string Generation_Date;
    public Cls_jos_Railway_Loco_LineMsg()
    {
        //Declare Connection
        //cnn = new SqlConnection(@"Data Source = DWPL1\SOFTWARE; Initial Catalog=sbidiesel; User ID=bharat; Password=bharat;");

    }
    public Int64 Insert_Data()
    {
        Int64 n = 0;
        try
        {
            cmd = new SqlCommand("SELECT COUNT(*) FROM jos_railway_Loco_LineMsg", cnn);
            cmd.Connection.Open();
            n = Convert.ToInt64(cmd.ExecuteScalar());
            cmd.Connection.Close();

            cmd = new SqlCommand("INSERT INTO jos_railway_Loco_LineMsg(Loco_Id,Loco_Date,TrainNo,Site_Id,SiteSection_Id,LineMsg,Generation_Date,avaibility) VALUES (@Loco_Id,@Loco_Date,@TrainNo,@Site_Id,@SiteSection_Id,@LineMsg,@Generation_Date,@avaibility)", cnn);
            cmd.Parameters.AddWithValue("@Loco_Id", this.Loco_Id);
            cmd.Parameters.AddWithValue("@Loco_Date", this.Loco_Date);
            cmd.Parameters.AddWithValue("@TrainNo", this.TrainNo);
            cmd.Parameters.AddWithValue("@Site_Id", this.Site_Id);
            cmd.Parameters.AddWithValue("@SiteSection_Id", this.SiteSection_Id);
            cmd.Parameters.AddWithValue("@LineMsg", this.LineMsg);
            cmd.Parameters.AddWithValue("@Generation_Date", this.Generation_Date);
            cmd.Parameters.AddWithValue("@avaibility", "1");
            cmd.Connection.Open();
            int m = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            if (n > 0)
            {
                cmd = new SqlCommand("SELECT MAX(Id_Loco_Linemsg) FROM jos_railway_Loco_LineMsg", cnn);
                cmd.Connection.Open();
                n = Convert.ToInt64(cmd.ExecuteScalar());
                //n++;
                cmd.Connection.Close();
            }
            else
            {
                n = 1;
            }
            if (m == 1)
            {
                return n;
            }
            else
            {
                return 0;
            }
        }
        catch { throw; }
    }
    //Delete Data
    public int Delete_Data()
    {
        try
        {
            cmd = new SqlCommand("DELETE FROM jos_railway_Loco_LineMsg  WHERE (Id_Loco_Linemsg=@Id_Loco_Linemsg)", cnn);
            cmd.Parameters.AddWithValue("@Id_Loco_Linemsg", this.Id_Loco_Linemsg);
            cmd.Connection.Open();
            int n = Convert.ToInt16(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            return n;
        }
        catch { throw; }
    }
    public int Update_Data()
    {
        try
        {
            cmd = new SqlCommand(" UPDATE jos_railway_Loco_LineMsg SET Loco_Id=@Loco_Id,Loco_Date=@Loco_Date,TrainNo=@TrainNo,Site_Id=@Site_Id,SiteSection_Id=@SiteSection_Id,LineMsg=@LineMsg WHERE Id_Loco_Linemsg=@Id_Loco_Linemsg ", cnn);
            cmd.Parameters.AddWithValue("@Id_Loco_Linemsg", this.Id_Loco_Linemsg);
            cmd.Parameters.AddWithValue("@Loco_Id", this.Loco_Id);
            cmd.Parameters.AddWithValue("@Loco_Date", this.Loco_Date);
            cmd.Parameters.AddWithValue("@TrainNo", this.TrainNo);
            cmd.Parameters.AddWithValue("@Site_Id", this.Site_Id);
            cmd.Parameters.AddWithValue("@SiteSection_Id", this.SiteSection_Id);
            cmd.Parameters.AddWithValue("@LineMsg", this.LineMsg);
            //cmd.Parameters.AddWithValue("@Schedule", this.Schedule);
            //cmd.Parameters.AddWithValue("@Last_Sch_Date", this.Last_Sch_Date);
            cmd.Connection.Open();
            int n = Convert.ToInt16(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            return n;
        }
        catch { throw; }
    }
    public DataTable Select_Data()
    {
        //        cmd = new SqlCommand(" SELECT " + 
        //"jos_railway_Loco_LineMsg.id_Loco_Linemsg AS \"tid\" " +
        //",jos_railway_loco_in.id_loco_in AS \"loco id\" " +
        //",jos_railway_mst_loco.locono AS \"LOCO NO\"  " +
        //",CONVERT(VARCHAR(10),jos_railway_Loco_LineMsg.Loco_Date,5) AS \"DATE\" "+
        //",jos_railway_mst_site.Site_Name AS \"SITE\" "+ 
        //",jos_railway_mst_SiteSection.SiteSectionName  AS \"SECTION\" "+
        //",jos_railway_Loco_LineMsg.TrainNo AS \"TRAIN NO\" " +
        //",jos_railway_Loco_LineMsg.LineMsg AS \"LINE MESSAGE\" " +
        //",CONVERT(VARCHAR(10),jos_railway_mst_loco.doc_date,5) AS \"DOC\"  " +
        //",CONVERT(VARCHAR(10),jos_railway_loco_in.l_date,5) AS \"LAST\" "+
        //",jos_railway_loco_type_schedule.s_type AS \"LAST SCH\" "+
        //" FROM  jos_railway_Loco_LineMsg "+
        //" INNER JOIN  jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = jos_railway_Loco_LineMsg.Loco_Id "+
        //" INNER JOIN  jos_railway_mst_site ON jos_railway_mst_site.Id_Site = jos_railway_Loco_LineMsg.Site_Id "+
        //" INNER JOIN  jos_railway_mst_SiteSection ON jos_railway_mst_SiteSection.Id_SiteSection = jos_railway_Loco_LineMsg.SiteSection_Id "+
        //" LEFT OUTER JOIN jos_railway_loco_in ON jos_railway_loco_in.loco_id = jos_railway_Loco_LineMsg.Loco_Id "+
        //" LEFT OUTER JOIN jos_railway_loco_type_schedule ON jos_railway_loco_in.l_sch = jos_railway_loco_type_schedule.id_loco_sch "+
        //" WHERE jos_railway_Loco_LineMsg.Generation_Date ='"+ this.Generation_Date +"' order by jos_railway_loco_in.id_loco_in desc", cnn);
        cmd = new SqlCommand("SELECT " +
"jos_railway_Loco_LineMsg.id_Loco_Linemsg AS  \"tid\"  " +
",jos_railway_mst_loco.locono AS  \"LOCONO\"  " +
",CONVERT(VARCHAR(10),jos_railway_Loco_LineMsg.Loco_Date,5) AS  \"DATE\" " +
",jos_railway_mst_site.Site_Name AS  \"SITE\" " +
",jos_railway_mst_SiteSection.SiteSectionName  AS  \"SECTION\" " +
",jos_railway_Loco_LineMsg.TrainNo AS  \"TRAINNO\" " +
",jos_railway_Loco_LineMsg.LineMsg AS  \"LINE MESSAGE\"  " +
",CONVERT(VARCHAR(10),jos_railway_mst_loco.doc_date,5) AS  \"DOC\" " +
",(SELECT jos_railway_loco_type_schedule.s_type FROM jos_railway_loco_in INNER JOIN jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = jos_railway_loco_in.l_sch WHERE jos_railway_loco_in.id_loco_in = (SELECT MAX(id_loco_in) FROM jos_railway_loco_in WHERE jos_railway_loco_in.loco_id = jos_railway_Loco_LineMsg.Loco_Id)) AS \"LAST SCH\" " +
",(SELECT jos_railway_loco_in.l_date FROM jos_railway_loco_in  WHERE jos_railway_loco_in.id_loco_in = (SELECT MAX(id_loco_in) FROM jos_railway_loco_in WHERE jos_railway_loco_in.loco_id = jos_railway_Loco_LineMsg.Loco_Id)) AS \"LAST\" " +

"FROM jos_railway_Loco_LineMsg  " +
"INNER JOIN  jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = jos_railway_Loco_LineMsg.Loco_Id  " +
"INNER JOIN  jos_railway_mst_site ON jos_railway_mst_site.Id_Site = jos_railway_Loco_LineMsg.Site_Id " +
"INNER JOIN  jos_railway_mst_SiteSection ON jos_railway_mst_SiteSection.Id_SiteSection = jos_railway_Loco_LineMsg.SiteSection_Id  " +
"WHERE jos_railway_Loco_LineMsg.Id_Loco_Linemsg IN(SELECT MAX(jos_railway_Loco_LineMsg.Id_Loco_Linemsg) FROM jos_railway_Loco_LineMsg GROUP BY Loco_Id) AND jos_railway_Loco_LineMsg.avaibility='true'", cnn);
        dt = new DataTable();
        da = new SqlDataAdapter();
        da.SelectCommand = cmd;
        dt.Clear();
        da.Fill(dt);
        return dt;
    }
    public DataTable Select_DataById()
    {
        cmd = new SqlCommand("SELECT Id_Loco_Linemsg,Loco_Id,CONVERT(VARCHAR(10),Loco_Date,101)as \"Loco_Date\",TrainNo,Site_Id,SiteSection_Id,LineMsg,Generation_Date FROM jos_railway_Loco_LineMsg WHERE  id_Loco_Linemsg='" + this.Id_Loco_Linemsg + "'", cnn);
        dt = new DataTable();
        da = new SqlDataAdapter();
        da.SelectCommand = cmd;
        dt.Clear();
        da.Fill(dt);
        return dt;
    }
    public DataTable Get_LineMessageEnterBeforeDay()
    {
        cmd = new SqlCommand("SELECT * FROM jos_railway_Loco_LineMsg WHERE avaibility='true' AND DATEDIFF(hh,Generation_Date,GETDATE()) > 24", cnn);
        dt = new DataTable();
        da = new SqlDataAdapter();
        da.SelectCommand = cmd;
        dt.Clear();
        da.Fill(dt);
        return dt;

    }
    public void Make_Unavailable()
    {
        cmd = new SqlCommand("UPDATE jos_railway_Loco_LineMsg SET avaibility='false' WHERE id_Loco_Linemsg=@id_Loco_Linemsg", cnn);
        cmd.Parameters.AddWithValue("@Id_Loco_Linemsg", this.Id_Loco_Linemsg);
        cmd.Connection.Open();
        cmd.ExecuteNonQuery();
        cmd.Connection.Close();
            
    }

}
