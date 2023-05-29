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
/// Summary description for Cls_Loco_HeavySchedule
/// </summary>
public class Cls_Loco_HeavySchedule : Cls_DBConnection
{
    public string Loco_Id;
    public string HeavyScheduleDate;
    public Cls_Loco_HeavySchedule()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public Int64 Insert_Data()
    {
        try
        {
            cmd = new SqlCommand("INSERT INTO Loco_HeavySchedule(Loco_Id,HeavyScheduleDate) VALUES(@Loco_Id,@HeavyScheduleDate)", cnn);
            cmd.Parameters.AddWithValue("@Loco_Id", this.Loco_Id);
            cmd.Parameters.AddWithValue("@HeavyScheduleDate", this.HeavyScheduleDate);
            cmd.Connection.Open();
           Int64 n  = Convert.ToInt64 (cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            if (n == 1)
            {
                cmd = new SqlCommand("SELECT MAX(Id_HeavySchedule) FROM Loco_HeavySchedule", cnn);
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
}
