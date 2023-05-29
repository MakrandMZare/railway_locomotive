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
/// Summary description for Cls_jos_railway_Loco_Temporary_Repair
/// </summary>
namespace Railway
{
    public class Cls_jos_railway_Loco_Temporary_Repair :Cls_DBConnection 
    {
        public string Id_Loco_Temp_Repair;
        public string Id_Loco;
        public string Id_Site;
        public string Id_SiteSection;
        public string Reason;
        public string Remarks;
        public string Generation_Date;
        public Cls_jos_railway_Loco_Temporary_Repair()
        {
            //Declare Connection
            //cnn = new SqlConnection(@"Data Source = DWPL1\SOFTWARE; Initial Catalog=sbidiesel; User ID=bharat; Password=bharat;");

        }
        public Int64 Insert_Data()
        {
            Int64 n = 0;
            try
            {
                cmd = new SqlCommand("SELECT COUNT(*) FROM jos_railway_Loco_Temporary_Repair", cnn);
                cmd.Connection.Open();
                n = Convert.ToInt64(cmd.ExecuteScalar());
                cmd.Connection.Close();

                cmd = new SqlCommand("INSERT INTO jos_railway_Loco_Temporary_Repair(Id_Loco,Id_Site,Id_SiteSection,Reason,Remarks,Generation_Date,avaibility) VALUES (@Id_Loco,@Id_Site,@Id_SiteSection,@Reason,@Remarks,@Generation_Date,@avaibility)", cnn);
                cmd.Parameters.AddWithValue("@Id_Loco", this.Id_Loco);
                cmd.Parameters.AddWithValue("@Id_Site", this.Id_Site);
                cmd.Parameters.AddWithValue("@Id_SiteSection", this.Id_SiteSection);
                cmd.Parameters.AddWithValue("@Reason", this.Reason);
                cmd.Parameters.AddWithValue("@Remarks", this.Remarks);
                cmd.Parameters.AddWithValue("@Generation_Date", this.Generation_Date);
                cmd.Parameters.AddWithValue("@avaibility", "1");
                cmd.Connection.Open();
                int m = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                if (n > 0)
                {
                    cmd = new SqlCommand("SELECT MAX(Id_Loco_Temp_Repair) FROM jos_railway_Loco_Temporary_Repair", cnn);
                    cmd.Connection.Open();
                    n = Convert.ToInt64(cmd.ExecuteScalar());
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
                cmd = new SqlCommand("DELETE FROM jos_railway_Loco_Temporary_Repair  WHERE (Id_Loco_Temp_Repair=@Id_Loco_Temp_Repair)", cnn);
                cmd.Parameters.AddWithValue("@Id_Loco_Temp_Repair", this.Id_Loco_Temp_Repair);
                cmd.Connection.Open();
                int n = Convert.ToInt16(cmd.ExecuteNonQuery());
                cmd.Connection.Close();
                return n;
            }
            catch { throw; }
        }

        public Int64 Save_TempRepair(string LocoNo, string Site, string Section, string Reason, string Remarks, string Id_ShedPosition_rpt)
        {
            try
            {
                cmd = new SqlCommand("INSERT INTO rpt_EmdTempRepair (LocoNo, Site, Section, Reason, Remarks, Id_ShedPosition_rpt)VALUES(@LocoNo, @Site, @Section, @Reason, @Remarks, @Id_ShedPosition_rpt)", cnn);

                cmd.Parameters.AddWithValue("@LocoNo", LocoNo);
                cmd.Parameters.AddWithValue("@Site", Site);
                cmd.Parameters.AddWithValue("@Section", Section);
                cmd.Parameters.AddWithValue("@Reason", Reason);
                cmd.Parameters.AddWithValue("@Remarks", Remarks);
                cmd.Parameters.AddWithValue("@Id_ShedPosition_rpt", Id_ShedPosition_rpt);
                cmd.Connection.Open();
                Int64 n = Convert.ToInt64((cmd.ExecuteNonQuery()));
                cmd.Connection.Close();
                return n;

            }

            catch { throw; }
        }

        public Int64 Save_OutageInrptOutage (string bgh1,string bgh2,string bgf1,string bgf2,string bgf3,string bgd,string mgh1,string mgh2,string mgf1,string mgf2,string mgf3,string mgf4,string mfd,string mghr,string bghr,string mglr,string bglr,string mgur,string bgur,string mgdead,string bgdead,string mgdiv,string bgdiv,string mglie,string bglie,string mgnet1,string mgnet2,string bgnet1,string bgnet2,string mgsr,string mgloc,string mggear,string mgcompress,string mgfuel,string mgrunning,string Id_ShedPosition_rpt)
        {
            try
            {
                cmd = new SqlCommand("INSERT INTO rpt_Outage(bgh1, bgh2, bgf1, bgf2, bgf3, bgd, mgh1, mgh2, mgf1, mgf2, mgf3, mgf4, mfd, mghr, bghr, mglr, bglr, mgur, bgur, mgdead, bgdead, mgdiv, bgdiv, mglie, bglie, mgnet1, mgnet2, bgnet1, bgnet2, mgsr, mgloc, mggear, mgcompress, mgfuel, mgrunning, Id_ShedPosition_rpt) VALUES (@bgh1,@bgh2,@bgf1,@bgf2,@bgf3,@bgd,@mgh1,@mgh2,@mgf1,@mgf2,@mgf3,@mgf4,@mfd,@mghr,@bghr,@mglr,@bglr,@mgur,@bgur,@mgdead,@bgdead,@mgdiv,@bgdiv,@mglie,@bglie,@mgnet1,@mgnet2,@bgnet1,@bgnet2,@mgsr,@mgloc,@mggear,@mgcompress,@mgfuel,@mgrunning,@Id_ShedPosition_rpt)", cnn);
                cmd.Parameters.AddWithValue("@bgh1", bgh1);
                cmd.Parameters.AddWithValue("@bgh2", bgh2);
                cmd.Parameters.AddWithValue("@bgf1", bgf1);
                cmd.Parameters.AddWithValue("@bgf2", bgf2);
                cmd.Parameters.AddWithValue("@bgf3", bgf3);
                cmd.Parameters.AddWithValue("@bgd", bgd);
                cmd.Parameters.AddWithValue("@mgh1", mgh1);
                cmd.Parameters.AddWithValue("@mgh2", mgh2);
                cmd.Parameters.AddWithValue("@mgf1", mgf1);
                cmd.Parameters.AddWithValue("@mgf2", mgf2);
                cmd.Parameters.AddWithValue("@mgf3", mgf3);
                cmd.Parameters.AddWithValue("@mgf4", mgf4);

                cmd.Parameters.AddWithValue("@mfd", mfd);
                cmd.Parameters.AddWithValue("@mghr", mghr);
                cmd.Parameters.AddWithValue("@bghr", bghr);
                cmd.Parameters.AddWithValue("@mglr", mglr);
                cmd.Parameters.AddWithValue("@bglr", bglr);
                cmd.Parameters.AddWithValue("@mgur", mgur);

                cmd.Parameters.AddWithValue("@bgur", bgur);
                cmd.Parameters.AddWithValue("@mgdead", mgdead);
                cmd.Parameters.AddWithValue("@bgdead", bgdead);
                cmd.Parameters.AddWithValue("@mgdiv", mgdiv);
                cmd.Parameters.AddWithValue("@bgdiv", bgdiv);
                cmd.Parameters.AddWithValue("@mglie", mglie);

                cmd.Parameters.AddWithValue("@bglie", bglie);
                cmd.Parameters.AddWithValue("@mgnet1", mgnet1);
                cmd.Parameters.AddWithValue("@mgnet2", mgnet2);
                cmd.Parameters.AddWithValue("@bgnet1", bgnet1);
                cmd.Parameters.AddWithValue("@bgnet2", bgnet2);
                cmd.Parameters.AddWithValue("@mgsr", mgsr);

                cmd.Parameters.AddWithValue("@mgloc", mgloc);
                cmd.Parameters.AddWithValue("@mggear", mggear);
                cmd.Parameters.AddWithValue("@mgcompress", mgcompress);
                cmd.Parameters.AddWithValue("@mgfuel", mgfuel);
                cmd.Parameters.AddWithValue("@mgrunning", mgrunning);
                cmd.Parameters.AddWithValue("@Id_ShedPosition_rpt", Id_ShedPosition_rpt);
               
                cmd.Connection.Open();
                Int64 n = Convert.ToInt64((cmd.ExecuteNonQuery()));
                cmd.Connection.Close();
                return n;

            }

            catch { throw; }
        }
      
        public int Update_Data()
        {
            try
            {
                cmd = new SqlCommand(" UPDATE jos_railway_Loco_Temporary_Repair SET Id_Loco=@Id_Loco,Id_Site=@Id_Site,Id_SiteSection=@Id_SiteSection,Reason=@Reason,Remarks=@Remarks WHERE Id_Loco_Temp_Repair=@Id_Loco_Temp_Repair ", cnn);
                cmd.Parameters.AddWithValue("@Id_Loco_Temp_Repair", this.Id_Loco_Temp_Repair);
                cmd.Parameters.AddWithValue("@Id_Loco", this.Id_Loco);
                cmd.Parameters.AddWithValue("@Id_Site", this.Id_Site);
                cmd.Parameters.AddWithValue("@Id_SiteSection", this.Id_SiteSection);
                cmd.Parameters.AddWithValue("@Reason", this.Reason);
                cmd.Parameters.AddWithValue("@Remarks", this.Remarks);
                //cmd.Parameters.AddWithValue("@Generation_Date", this.Generation_Date);
                cmd.Connection.Open();
                int n = Convert.ToInt16(cmd.ExecuteNonQuery());
                cmd.Connection.Close();
                return n;
            }
            catch { throw; }
        }
        //public DataTable Select_Data()
        //{
        //    //cmd = new SqlCommand("SELECT * FROM jos_railway_Loco_Temporary_Repair", cnn);
        //    cmd = new SqlCommand("SELECT " +
        //                "jos_railway_Loco_Temporary_Repair.Id_Loco_Temp_Repair " +
        //                ",jos_railway_mst_loco.locono, " +
        //              " jos_railway_mst_SiteSection.SiteSectionName " +
        //              ", jos_railway_mst_site.Site_Name" +
        //              ", jos_railway_Loco_Temporary_Repair.Reason" +
        //              ", jos_railway_Loco_Temporary_Repair.Remarks" +
        //              ", jos_railway_loco_type.loco_type," +
        //              " jos_railway_Loco_Temporary_Repair.Generation_Date " +
        //              " FROM jos_railway_Loco_Temporary_Repair INNER JOIN" +
        //              " jos_railway_mst_loco ON jos_railway_Loco_Temporary_Repair.Id_Loco = jos_railway_mst_loco.id_mst_loco INNER JOIN" +
        //              " jos_railway_mst_SiteSection ON jos_railway_Loco_Temporary_Repair.Id_SiteSection = jos_railway_mst_SiteSection.Id_SiteSection INNER JOIN" +
        //              " jos_railway_mst_site ON jos_railway_Loco_Temporary_Repair.Id_Site = jos_railway_mst_site.Id_Site INNER JOIN" +
        //              " jos_railway_loco_type ON jos_railway_mst_loco.tid = jos_railway_loco_type.id_ltype" +

        //              " WHERE jos_railway_Loco_Temporary_Repair.Generation_Date ='" + this.Generation_Date.Substring(0, 10) + "'", cnn);
        //    dt = new DataTable();
        //    da = new SqlDataAdapter();
        //    da.SelectCommand = cmd;
        //    dt.Clear();
        //    da.Fill(dt);
        //    return dt;
        //}
        public DataTable  Select_Data()
        { 
            //cmd = new SqlCommand(" SELECT jos_railway_mst_loco.locono as \"locono\"" + 
            //                                       " ,jos_railway_Loco_Temporary_Repair.Id_Loco_Temp_Repair \"rid\"" +
            //                                       " ,jos_railway_mst_site.Site_Name \"site\" " +
            //                                       " ,jos_railway_mst_SiteSection.SiteSectionName \"section\" " +
            //                                       " ,jos_railway_Loco_Temporary_Repair.Reason \"reason\" " +
            //                                       " ,jos_railway_Loco_Temporary_Repair.Remarks \"remarks\" " +
            //                                       " FROM jos_railway_Loco_Temporary_Repair " +
            //                                       " INNER JOIN jos_railway_mst_loco ON jos_railway_Loco_Temporary_Repair.Id_Loco = jos_railway_mst_loco.id_mst_loco " +
            //                                       " INNER JOIN jos_railway_mst_site ON jos_railway_mst_site.Id_Site = jos_railway_Loco_Temporary_Repair.Id_Site " +
            //                                       " INNER JOIN jos_railway_mst_SiteSection ON jos_railway_mst_SiteSection.Id_SiteSection = jos_railway_Loco_Temporary_Repair.Id_SiteSection  WHERE jos_railway_Loco_Temporary_Repair.Generation_Date='" + this.Generation_Date  + "'",cnn);
            cmd = new SqlCommand("SELECT jos_railway_mst_loco.locono as  \"locono\" " +
                                 ",jos_railway_Loco_Temporary_Repair.Id_Loco_Temp_Repair  \"rid\" " +
                                 ",jos_railway_mst_site.Site_Name  \"site\"  " +
                                 ",jos_railway_mst_SiteSection.SiteSectionName  \"section\" " +
                                 ",jos_railway_Loco_Temporary_Repair.Reason  \"reason\"  " +
                                 ",jos_railway_Loco_Temporary_Repair.Remarks  \"remarks\"  " +
                                 "FROM jos_railway_Loco_Temporary_Repair  " +
                                 "INNER JOIN jos_railway_mst_loco ON jos_railway_Loco_Temporary_Repair.Id_Loco = jos_railway_mst_loco.id_mst_loco  " +
                                 "INNER JOIN jos_railway_mst_site ON jos_railway_mst_site.Id_Site = jos_railway_Loco_Temporary_Repair.Id_Site  " +
                                 "INNER JOIN jos_railway_mst_SiteSection ON jos_railway_mst_SiteSection.Id_SiteSection = jos_railway_Loco_Temporary_Repair.Id_SiteSection   " +
                                 "WHERE jos_railway_Loco_Temporary_Repair.Id_Loco_Temp_Repair IN (SELECT MAX(jos_railway_Loco_Temporary_Repair.Id_Loco_Temp_Repair) FROM jos_railway_Loco_Temporary_Repair GROUP BY jos_railway_Loco_Temporary_Repair.Id_Loco) AND jos_railway_Loco_Temporary_Repair.avaibility='true'", cnn);
                dt = new DataTable();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;
        }
        
        public DataTable  Select_DataById()
        {
            cmd = new SqlCommand("SELECT * FROM jos_railway_Loco_Temporary_Repair WHERE Id_Loco_Temp_Repair='" + this.Id_Loco_Temp_Repair  +"'", cnn);
            dt = new DataTable();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;
        }
        public void Make_Loco_Unavailable()
        {
            //this function will make last loco unavailable after locoin
            try
            {
                cmd = new SqlCommand("update  jos_railway_Loco_Temporary_Repair SET avaibility='false' WHERE id_Loco_Temp_Repair=@id_Loco_Temp_Repair", cnn);
                cmd.Parameters.AddWithValue("@id_Loco_Temp_Repair", this.Id_Loco_Temp_Repair);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            catch { throw; }
        }
    }
}
