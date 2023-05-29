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
/// Summary description for Cls_DBConnection
/// </summary>
public class Cls_DBConnection
{
    public SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["Railwaydb"].ConnectionString);
    public SqlCommand cmd;
    public SqlDataAdapter da;
    public DataSet ds;
    public DataTable dt;
    public SqlDataReader dr;
    public Cls_DBConnection()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}
