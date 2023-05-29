using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Railway;
using System.Text.RegularExpressions;
public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(Object sender, EventArgs e)
    {
        Fill_Data();
        
        
    }
    public void Insert_LocoSchedule(string m)
    {

        Cls_jos_railway_mst_loco c = new Cls_jos_railway_mst_loco();
        c.id_mst_loco = m;
        DataTable locobt = c.Select_DataByLocoNo();
        DateTime schdate = Convert.ToDateTime(locobt.Rows[0][2].ToString());
        Cls_jos_railway_loco_type_schedule c1 = new Cls_jos_railway_loco_type_schedule();

        //if (m == "28")
        //{
        //    c1.loco_id = "2";
        //}
        //else
        //{
        //    c1.loco_id = "1";
        //}
        c1.loco_id = "1";
        DataTable ScheduleData = c1.Select_Data();
        if (ScheduleData.Rows.Count > 0)
        {
            foreach (DataRow dr in ScheduleData.Rows)
            {
                c.Schedule_Id = dr[0].ToString();
                schdate = schdate.AddDays(Convert.ToInt64(dr[2].ToString()));
                string str = schdate.ToShortDateString().Replace("-", "/");
                c.ScheduleDate = str.Substring(3, 2).ToString() + "/" + str.Substring(0, 2).ToString() + "/" + str.Substring(6, 4).ToString();
                c.Loco_Id = m;
                c.Insert_Data_Loco_Schedule();
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ////for (int i = 1; i <= 27; i++)
        ////{
        //string[] str = {"29","30","31","32","33","34","35","36","37","38","39","40","41","42","73","74","75","76","77","78","79"};
        //foreach (string i in str)
        //{
        //    Insert_LocoSchedule(i.ToString());
        //}
        ////}
        //Cls_jos_railway_loco_in c = new Cls_jos_railway_loco_in();
        
        //DataTable dtLocoin = c.Select_LocoNo("1");
        //foreach (DataRow dr in dtLocoin.Rows)
        //{
        //    c.Update_BookedToRemarks(dr[0].ToString());
        //}
        Cls_DBConnection co = new Cls_DBConnection();
        //SqlDbType.SmallDateTime getdate ;

            SqlCommand cmd = new SqlCommand("INSERT INTO TempTable(tempdate,asd)VALUES(@tempdate,@asd)",co.cnn);
        //cmd.Parameters.AddWithValue("@tempdate",);
        cmd.Parameters.AddWithValue("@tempdate",SqlDateTime.Null);
        cmd.Parameters.AddWithValue("@asd", "asd");
        cmd.Connection.Open();
        cmd.ExecuteNonQuery();
        cmd.Connection.Close();
        
    }
    protected void gv1_OnRowDataBound(object sender, GridViewRowEventArgs e)
    {
        Label l = (Label)e.Row.FindControl("l1");
        string str = l.Text;
    }
    public void Fill_Data()
    {
    Cls_jos_railway_mst_SiteSection c =new Cls_jos_railway_mst_SiteSection();
    DetailsView1.DataSource = c.Select_Data();
    DetailsView1.DataBind();
    DataList1.DataSource = c.Select_Data();
    DataList1.DataBind();

    }
    protected void DetailsView1_PageIndexChanging(object sender, DetailsViewPageEventArgs e)
    {

    }
}
