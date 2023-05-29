using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
//using System.Web.Security;
//using System.Web.UI;
//using System.Web.UI.WebControls;
//using System.Web.UI.WebControls.WebParts;
//using System.Web.UI.HtmlControls;
using System.IO;
using System.Text;
using System.Web.SessionState;

/// <summary>
/// Summary description for PrintHelper
/// </summary>
public class PrintHelper
{
    public PrintHelper()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    //public static void PrintWebControl(Control ctrl)
   // {
        //PrintWebControl(ctrl, string.Empty);
       
        
    //}
public static void PrintWebControl(Control ctrl, string Script,int UId,string PUrl,string ReportName )
    {
     StringWriter stringWrite = new StringWriter();
        
        System.Web.UI.HtmlTextWriter htmlWrite = new System.Web.UI.HtmlTextWriter(stringWrite);
       

            if (ctrl is WebControl)
            {
        
                //Unit w = new Unit(100, UnitType.Percentage); 
                
                Unit w = new Unit(100, UnitType.Inch);
               
                
                ((WebControl)ctrl).Width = w;
              
                
            }
            Page pg = new Page();
            pg.EnableEventValidation = false;
            if (Script != string.Empty)
            {
                pg.ClientScript.RegisterStartupScript(pg.GetType(), "PrintJavaScript", Script);
            }
            HtmlForm frm = new HtmlForm();
            pg.Controls.Add(frm);
            frm.Attributes.Add("runat", "server");
            frm.Controls.Add(ctrl);
            pg.DesignerInitialize();
            //System.Web.UI.HtmlTextWriter htmlWrite = new System.Web.UI.HtmlTextWriter(stringWrite);
            pg.RenderControl(htmlWrite);
            string strHTML = stringWrite.ToString();
            HttpContext.Current.Response.Clear();
            //HttpContext.Current.Response.Write("<Div style='Backgound:gray;'>" + schoolname + "</div>");
            if (ReportName != "")
            {
                HttpContext.Current.Response.Write("<div style='font-family:Verdana Arial Black Tahoma; font-size:20px;'><table align='center'><tr><td align='center'><H1> RAILWAY LOCO MAINTENANCE SYSTEM </H1></td></tr><tr><td align='center'> " + ReportName + " </td></tr><tr><td align='right'>Date : </td><td align='right'>" + DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString() + "</td></tr></table></div>");
            }
            HttpContext.Current.Response.Write(strHTML);
    
            
            HttpContext.Current.Response.Write("<script>window.print();</script>");

            //User Details Stor In DataBase
            //UserSessionLog.UserSessionPrintLog UUSPLObj1 = new UserSessionLog.UserSessionPrintLog();
            //UUSPLObj1.PrintTime = DateTime.Now.ToString();
            //UUSPLObj1.PrintDetails = PUrl;
            //UUSPLObj1.UserSessionLogId = Convert.ToString(UId);
            //UUSPLObj1.Insert_UserSessionPrint_Details();

            HttpContext.Current.Response.End();
       
    }

}
