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
using Railway;

public partial class Loco_Loco_ScheduleManagement_View : System.Web.UI.Page
{
    protected void Fill_Data()
    {
        if (Request.QueryString["id"] != null)
        {
            Table t = new Table();
            jos_railway_loco_Schedule_TimeTable c = new jos_railway_loco_Schedule_TimeTable();
            c.Id_Master = Request.QueryString["id"].ToString();
            DataTable Locodt = c.Get_LoconoInCurrentLocoSchedule();
            if (Locodt.Rows.Count > 0)
            {
                DataTable Scheduledt = c.Get_ScheduleInCurrentLoco_Schedule(Locodt.Rows[0][0].ToString(),c.Id_Master);
                if (Scheduledt.Rows.Count > 0)
                {
                    for (int i = 0; i <= Locodt.Rows.Count; i++)
                    {
                        TableRow tr = new TableRow();
                        for (int j = 0; j <= Scheduledt.Rows.Count; j++)
                        {
                            TableCell tc = new TableCell();
                            tc.BorderWidth = 1;
                            if (i == 0 && j == 0)
                            {
                                tc.Text = "LOCO / SCHEDULE";
                                tc.BackColor = System.Drawing.Color.Gainsboro;
                            }
                            if (i == 0 && j > 0)
                            {
                                tc.Text = Scheduledt.Rows[j - 1][1].ToString();
                                tc.BackColor = System.Drawing.Color.Gainsboro;
                            }
                            if (j == 0 && i > 0)
                            {
                                tc.Text = Locodt.Rows[i - 1][1].ToString();
                                tc.BackColor = System.Drawing.Color.Gainsboro;
                            }
                            if (i > 0 && j > 0)
                            {
                                c.Loco_Id = Locodt.Rows[i - 1][0].ToString();
                                DataTable dt = c.Select_DataById();
                                tc.Text = dt.Rows[j - 1][0].ToString();
                            }
                            //else
                            // {
                            //tc.Text = Locodt.Rows[i - 1][1].ToString();
                            //}
                            tr.Cells.Add(tc);
                        }

                        t.Rows.Add(tr);
                    }

                    p1.Controls.Add(t);
                }
            }
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        Fill_Data();
    }
    protected void btnPrint_Click(object sender, EventArgs e)
    {
        PrintHelper.PrintWebControl(p1, string.Empty, 0, Request.Url.ToString(), " LOCO SCHEDULE MANAGEMENT ");
    }
}
