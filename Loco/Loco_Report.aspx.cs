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

public partial class Loco_Loco_Report : System.Web.UI.Page
{
    public string Find_DateDifference(Int16 m, Int64 y)
    {
        Int64 mdiff = DateTime.Now.Month - m;
        Int64 ydiff = DateTime.Now.Year - y;
        if (ydiff < 0)
        {
            ydiff = 12 - (y - DateTime.Now.Year);

        }
        if (mdiff < 0)
        {
            mdiff = 12 - (m - DateTime.Now.Month);
            ydiff--;
        }
        return ydiff.ToString() + "." + mdiff.ToString();
    }
    protected void btnPrint_Click(object sender, ImageClickEventArgs e)
    {
        PrintHelper.PrintWebControl(p1, string.Empty, 0, Request.Url.ToString(), " LOCO ASSEMBLY REPORT ");
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        PrintHelper.PrintWebControl(PlaceHolder2, string.Empty, 0, Request.Url.ToString(), " LOCO ASSEMBLY REPORT ");
    }
    
    public void Fill_Data()
    {
        //Cls_jos_railway_mst_loco c = new Cls_jos_railway_mst_loco();
        //c.tid = "1";
        //DataTable dt = c.Select_LocoNoByType();
        //Table t = new Table();
        //t.Font.Size = 6;
        //t.CellSpacing = 0;
        //t.CellPadding = 0;
        //Cls_jos_railway_loco_assembly c1 = new Cls_jos_railway_loco_assembly();
        //DataTable dtAssembly = c1.Select_AssemblyByLocoType("WDG4");

        ////for (int i = 0; i <= dt.Rows.Count - 1; i++)
        //for (int i = 0; i <= 2; i++)
        //{
        //    TableRow tr = new TableRow();
        //    for (int j = 0; j <= dtAssembly.Rows.Count + 4; j++)
        //    {
        //        TableCell tc = new TableCell();
        //        tc.BorderWidth = 1;
        //        if (i == 0 && j == 0)
        //        {
        //            tc.Text = "LOCONO";
        //            tc.BorderWidth = 1;
        //            tc.BackColor = System.Drawing.Color.Gray;
        //            tc.Font.Bold = true;

        //        }
        //        else if (i > 0 && j == 0)
        //        {
        //            tc.Text = dt.Rows[i][0].ToString();
        //            tc.BorderWidth = 1;
        //            tc.BackColor = System.Drawing.Color.Gray;
        //            tc.Font.Bold = true;
        //        }
        //        else if (j > 5 && i == 0)
        //        {
        //            tc.Text = dtAssembly.Rows[j - 5][1].ToString();
        //            tc.BorderWidth = 1;
        //            tc.BackColor = System.Drawing.Color.Gray;
        //            tc.Font.Bold = true;
        //        }
        //        else if (j > 5 && i > 0)
        //        {
        //            c1.mid = dt.Rows[i][1].ToString();
        //            DataTable dtlocoAssembly = c1.Select_DataByLocoId();
        //            foreach (DataRow dr in dtlocoAssembly.Rows)
        //            {
        //                if (dr[0].ToString() == dtAssembly.Rows[j - 5][0].ToString())
        //                {
        //                    tc.Text = dr[3].ToString();
        //                }
        //            }
        //        }
        //        else if (j <= 5 && i > 0)
        //        {
                 
        //            Cls_jos_railway_mst_loco c2 = new Cls_jos_railway_mst_loco();
        //            c2.id_mst_loco = dt.Rows[i][1].ToString();
        //            DataTable dtloco = c2.Select_DataById();
        //            switch (j)
        //            {
        //                case 1:
        //                    tc.Text = dtloco.Rows[0][7].ToString();
        //                    break;
        //                case 2:
        //                    tc.Text = dtloco.Rows[0][2].ToString();
        //                    break;
        //                case 3:

        //                    if (dtloco.Rows[0][2].ToString() != "")
        //                    {
        //                        //string str = dtloco.Rows[0][2].ToString();
        //                        DateTime d = Convert.ToDateTime(dtloco.Rows[0][2].ToString());
        //                        //DateTime d = Convert.ToDateTime(dtloco.Rows[0][2].ToString().Substring(3, 2).ToString() + "/" + dtloco.Rows[0][2].ToString().Substring(0, 2).ToString() + "/" + dtloco.Rows[0][2].ToString().Substring(6, 4).ToString());
        //                        tc.Text = Find_DateDifference(Convert.ToInt16(d.Month), Convert.ToInt64(d.Year));
        //                    }
        //                    break;
        //                case 4:
        //                    tc.Text = dtloco.Rows[0][6].ToString();
        //                    break;
        //                case 5:
        //                    tc.Text = dtloco.Rows[0][5].ToString();
        //                    break;

        //            }
        //        }
        //        else if (j <= 5 && i == 0)
        //        {
        //            tc.BackColor = System.Drawing.Color.Gray;
        //            tc.Font.Bold = true;
        //            switch (j)
        //            {
        //                case 1:
        //                    tc.Text = "TYPE";
        //                    break;
        //                case 2:
        //                    tc.Text = "DOC";
        //                    break;
        //                case 3:
        //                    tc.Text = "AGE";
        //                    break;
        //                case 4:
        //                    tc.Text = "RECEIVED FROM";
        //                    break;
        //                case 5:
        //                    tc.Text = "DATE OF POH";
        //                    break;

        //            }
        //        }
        //        tr.Cells.Add(tc);
        //    }

        //    t.Rows.Add(tr);
        //}

        //p1.Controls.Add(t);
    }
    public void Fill_Data2()
    {
        Cls_jos_railway_mst_loco c = new Cls_jos_railway_mst_loco();
        c.tid="1";
        gvLocoAssembly.DataSource = c.Select_LocoNoByType();
        gvLocoAssembly.DataBind();
        gvLocoAssembly2.DataSource = c.Select_LocoNoByType();
        gvLocoAssembly2.DataBind();
    }
 
    protected void gvLocoAssembly_OnRowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
        Cls_jos_railway_mst_loco c = new Cls_jos_railway_mst_loco();
        
            e.Row.Cells[6].Text = c.get_AssemblySupplier(gvLocoAssembly.DataKeys[e.Row.RowIndex].Value.ToString(),"1");
            e.Row.Cells[7].Text = c.get_AssemblySupplier(gvLocoAssembly.DataKeys[e.Row.RowIndex].Value.ToString(), "2");
            e.Row.Cells[8].Text = c.get_AssemblySupplier(gvLocoAssembly.DataKeys[e.Row.RowIndex].Value.ToString(), "3");
            e.Row.Cells[9].Text = c.get_AssemblySupplier(gvLocoAssembly.DataKeys[e.Row.RowIndex].Value.ToString(), "4");

            e.Row.Cells[10].Text = c.get_AssemblySupplier(gvLocoAssembly.DataKeys[e.Row.RowIndex].Value.ToString(), "5");
            e.Row.Cells[11].Text = c.get_AssemblySupplier(gvLocoAssembly.DataKeys[e.Row.RowIndex].Value.ToString(), "6");
            e.Row.Cells[12].Text = c.get_AssemblySupplier(gvLocoAssembly.DataKeys[e.Row.RowIndex].Value.ToString(), "7");
            e.Row.Cells[13].Text = c.get_AssemblySupplier(gvLocoAssembly.DataKeys[e.Row.RowIndex].Value.ToString(), "8");

            e.Row.Cells[14].Text = c.get_AssemblySupplier(gvLocoAssembly.DataKeys[e.Row.RowIndex].Value.ToString(), "9");
            e.Row.Cells[15].Text = c.get_AssemblySupplier(gvLocoAssembly.DataKeys[e.Row.RowIndex].Value.ToString(), "10");
            e.Row.Cells[16].Text = c.get_AssemblySupplier(gvLocoAssembly.DataKeys[e.Row.RowIndex].Value.ToString(), "11");
            e.Row.Cells[17].Text = c.get_AssemblySupplier(gvLocoAssembly.DataKeys[e.Row.RowIndex].Value.ToString(), "12");

            e.Row.Cells[18].Text = c.get_AssemblySupplier(gvLocoAssembly.DataKeys[e.Row.RowIndex].Value.ToString(), "13");
        }
    }
    protected void gvLocoAssembly2_OnRowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            Cls_jos_railway_mst_loco c = new Cls_jos_railway_mst_loco();

            e.Row.Cells[6].Text = c.get_AssemblySupplier(gvLocoAssembly.DataKeys[e.Row.RowIndex].Value.ToString(), "14");
            e.Row.Cells[7].Text = c.get_AssemblySupplier(gvLocoAssembly.DataKeys[e.Row.RowIndex].Value.ToString(), "15");
            e.Row.Cells[8].Text = c.get_AssemblySupplier(gvLocoAssembly.DataKeys[e.Row.RowIndex].Value.ToString(), "16");
            e.Row.Cells[9].Text = c.get_AssemblySupplier(gvLocoAssembly.DataKeys[e.Row.RowIndex].Value.ToString(), "17");

            e.Row.Cells[10].Text = c.get_AssemblySupplier(gvLocoAssembly.DataKeys[e.Row.RowIndex].Value.ToString(), "18");
            e.Row.Cells[11].Text = c.get_AssemblySupplier(gvLocoAssembly.DataKeys[e.Row.RowIndex].Value.ToString(), "19");
            e.Row.Cells[12].Text = c.get_AssemblySupplier(gvLocoAssembly.DataKeys[e.Row.RowIndex].Value.ToString(), "20");
            e.Row.Cells[13].Text = c.get_AssemblySupplier(gvLocoAssembly.DataKeys[e.Row.RowIndex].Value.ToString(), "21");

            e.Row.Cells[14].Text = c.get_AssemblySupplier(gvLocoAssembly.DataKeys[e.Row.RowIndex].Value.ToString(), "22");
            e.Row.Cells[15].Text = c.get_AssemblySupplier(gvLocoAssembly.DataKeys[e.Row.RowIndex].Value.ToString(), "23");
            e.Row.Cells[16].Text = c.get_AssemblySupplier(gvLocoAssembly.DataKeys[e.Row.RowIndex].Value.ToString(), "24");
            e.Row.Cells[17].Text = c.get_AssemblySupplier(gvLocoAssembly.DataKeys[e.Row.RowIndex].Value.ToString(), "25");

            
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            //Fill_Data();
            Fill_Data2();
        }
    }
}
