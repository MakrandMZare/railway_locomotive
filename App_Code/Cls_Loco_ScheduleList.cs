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
/// <summary>
/// Summary description for Cls_Loco_ScheduleList
/// </summary>
public class Cls_Loco_ScheduleList : Cls_DBConnection
{
	public string id_loco_Schedule; 
    public string ScheduleName;
    public string ClassId;
    public string ScheduleDate;
    public Cls_Loco_ScheduleList()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public bool Is_Exists()
    {
        try
        {
            cmd = new SqlCommand("SELECT COUNT(*) FROM Loco_ScheduleList WHERE ScheduleName=@ScheduleName", cnn);
            cmd.Parameters.AddWithValue("@ScheduleName", this.ScheduleName);
            cmd.Connection.Open();
            int n = Convert.ToInt16(cmd.ExecuteScalar());
            cmd.Connection.Close();
            return n == 0 ? false : true;
        }
        catch { throw; }
    }
    public Int64 Count_ScheduleName()
    {
        try
        {
            cmd = new SqlCommand("SELECT COUNT(*) FROM Loco_ScheduleList WHERE ScheduleName=@ScheduleName", cnn);
            cmd.Parameters.AddWithValue("@ScheduleName", this.ScheduleName);
            cmd.Connection.Open();
            Int64 n = Convert.ToInt64(cmd.ExecuteScalar());
            cmd.Connection.Close();
            return n;
            
        }
        catch { throw; }
    }
    public Int64 Insert_Data()
    {
        try
        {
            cmd = new SqlCommand("INSERT INTO Loco_ScheduleList(ScheduleName,ClassId,ScheduleDate) VALUES(@ScheduleName,@ClassId,@ScheduleDate)", cnn);
            cmd.Parameters.AddWithValue("@ScheduleName", this.ScheduleName);
            cmd.Parameters.AddWithValue("@ClassId", this.ClassId);
            cmd.Parameters.AddWithValue("@ScheduleDate", this.ScheduleDate);
            cmd.Connection.Open();
            int n = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            if (n == 1)
            {
                cmd = new SqlCommand("SELECT MAX(id_loco_Schedule) FROM Loco_ScheduleList", cnn);
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
    public DataTable Get_ExstingScheduleByClass()
    {
        try
        {
            cmd = new SqlCommand("SELECT id_loco_Schedule,ScheduleName,REPLACE(CONVERT(VARCHAR(10),ScheduleDate,105),'-','/') as ScheduleDate FROM Loco_ScheduleList WHERE ClassId=@ClassId", cnn);
            cmd.Parameters.AddWithValue("@ClassId", this.ClassId);
            da = new SqlDataAdapter();
            dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);

            return dt;
        }
        catch { throw; }
    }
}
