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
/// Summary description for Cls_MG_Incoming_PassengerLoco_n_Schedule
/// </summary>
public class Cls_MG_Incoming_PassengerLoco_n_Schedule : Cls_DBConnection
{
    public string Id_Passnger_loco=null;
    public string Incoming_Trno = null;
    public string Incoming_LocoId = null;
    public string Minor_ScheduleId = null;
    public string Major_ScheduleId = null;
    public string LastScheduleId = null;
    public string LastMLY_Qtly_Hly = null;
    public string GenerationDate = null;
    public string LastMLYDate = null;
    public string WheelDiameter = null;

    public Cls_MG_Incoming_PassengerLoco_n_Schedule()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public DataTable Select_DataById()
    { 
        try{
            cmd = new SqlCommand("SELECT * FROM MG_Incoming_PassengerLoco_n_Schedule WHERE Id_Passnger_loco=@Id_Passnger_loco",cnn);
            cmd.Parameters.AddWithValue("@Id_Passnger_loco", this.Id_Passnger_loco);
            
        da = new SqlDataAdapter();
        dt = new DataTable();
        dt.Clear();
        da.Fill(dt);
        return dt;
        }catch{throw;}
    }
    public bool Check_Existance()
    {
    //this will check existance according to loco id and generation date
        cmd = new SqlCommand("SELECT COUNT(*) FROM MG_Incoming_PassengerLoco_n_Schedule WHERE Incoming_LocoId='" + this.Incoming_LocoId + "' AND GenerationDate='" + this.GenerationDate + "'", cnn);
        cmd.Connection.Open();
        Int16 n = Convert.ToInt16(cmd.ExecuteScalar());
        cmd.Connection.Close();
       return  n == 0 ? true : false;
    }
    public Int64 Insert_Data()
    {
        try
        {
            cmd = new SqlCommand("INSERT INTO MG_Incoming_PassengerLoco_n_Schedule(Incoming_Trno,Incoming_LocoId,Minor_ScheduleId,Major_ScheduleId,LastScheduleId,LastMLY_Qtly_Hly,GenerationDate,WheelDiameter,LastMLYDate)VALUES(@Incoming_Trno,@Incoming_LocoId,@Minor_ScheduleId,@Major_ScheduleId,@LastScheduleId,@LastMLY_Qtly_Hly,@GenerationDate,@WheelDiameter,@LastMLYDate)", cnn);
            cmd.Parameters.AddWithValue("@Incoming_LocoId", this.Incoming_LocoId);
            cmd.Parameters.AddWithValue("@Incoming_Trno", this.Incoming_Trno);
            cmd.Parameters.AddWithValue("@LastMLY_Qtly_Hly", this.LastMLY_Qtly_Hly);
            if (this.LastScheduleId != "")
            {
                cmd.Parameters.AddWithValue("@LastScheduleId", this.LastScheduleId);
            }
            else
            {
                cmd.Parameters.AddWithValue("@LastScheduleId", System.Data.SqlTypes.SqlInt16.Null);
            }
            if (this.Major_ScheduleId != "")
            {
                cmd.Parameters.AddWithValue("@Major_ScheduleId", this.Major_ScheduleId);
            }
            else
            {
                cmd.Parameters.AddWithValue("@Major_ScheduleId", System.Data.SqlTypes.SqlInt16.Null);
            }
            if (this.Minor_ScheduleId != "")
            {
                cmd.Parameters.AddWithValue("@Minor_ScheduleId", this.Minor_ScheduleId);
            }
            else {
                cmd.Parameters.AddWithValue("@Minor_ScheduleId", System.Data.SqlTypes.SqlInt16.Null);
            }

            if (this.LastMLYDate != "")
            {
                cmd.Parameters.AddWithValue("@LastMLYDate", this.LastMLYDate);
            }
            else
            {
                cmd.Parameters.AddWithValue("@LastMLYDate", System.Data.SqlTypes.SqlDateTime.Null);
            }
            cmd.Parameters.AddWithValue("@GenerationDate", this.GenerationDate);
            cmd.Parameters.AddWithValue("@WheelDiameter", this.WheelDiameter);
            cmd.Connection.Open();
            int n = Convert.ToInt16(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            if (n == 1)
            {
                cmd = new SqlCommand("SELECT MAX(Id_Passnger_loco) FROM MG_Incoming_PassengerLoco_n_Schedule", cnn);
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
    public void Update_Data()
    {
        try
        {
            cmd = new SqlCommand("UPDATE MG_Incoming_PassengerLoco_n_Schedule SET Incoming_Trno = @Incoming_Trno , Minor_ScheduleId = @Minor_ScheduleId , Major_ScheduleId = @Major_ScheduleId , LastScheduleId = @LastScheduleId LastMLY_Qtly_Hly = @LastMLY_Qtly_Hly WHERE Id_Passnger_loco=@Id_Passnger_loco", cnn);
            cmd.Parameters.AddWithValue("@Id_Passnger_loco", this.Id_Passnger_loco);
            cmd.Parameters.AddWithValue("@Incoming_Trno", this.Incoming_Trno);
            cmd.Parameters.AddWithValue("@Incoming_LocoId", this.Incoming_LocoId);
            cmd.Parameters.AddWithValue("@WheelDiameter",this.WheelDiameter);
            if (this.LastScheduleId != "")
            {
                cmd.Parameters.AddWithValue("@LastScheduleId", this.LastScheduleId);
            }
            else
            {
                cmd.Parameters.AddWithValue("@LastScheduleId", System.Data.SqlTypes.SqlInt16.Null);
            }
            if (this.Major_ScheduleId != "")
            {
                cmd.Parameters.AddWithValue("@Major_ScheduleId", this.Major_ScheduleId);
            }
            else
            {
                cmd.Parameters.AddWithValue("@Major_ScheduleId", System.Data.SqlTypes.SqlInt16.Null);
            }
            if (this.Minor_ScheduleId != "")
            {
                cmd.Parameters.AddWithValue("@Minor_ScheduleId", this.Minor_ScheduleId);
            }
            else
            {
                cmd.Parameters.AddWithValue("@Minor_ScheduleId", System.Data.SqlTypes.SqlInt16.Null);
            }
            

            //cmd.Parameters.AddWithValue("@Major_ScheduleId", this.Major_ScheduleId);
            //cmd.Parameters.AddWithValue("@Minor_ScheduleId", this.Minor_ScheduleId);
            //cmd.Parameters.AddWithValue("@LastScheduleId", this.LastScheduleId);
            cmd.Parameters.AddWithValue("@LastMLYDate", this.LastMLYDate);
            cmd.Parameters.AddWithValue("@LastMLY_Qtly_Hly", this.LastMLY_Qtly_Hly);
            
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        catch { throw; }
    }
    public void Delete_Data()
    {
        try
        {
            cmd = new SqlCommand("DELTE FROM MG_Incoming_PassengerLoco_n_Schedule WHERE Id_Passnger_loco='" + this.Id_Passnger_loco + "'", cnn);
            cmd.Parameters.AddWithValue("@Id_Passnger_loco", this.Id_Passnger_loco);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        catch { throw; }
    }
//    public DataTable Select_DataBy_GenerationDate()
//    {
////        cmd = new SqlCommand("SELECT * FROM ")
//    }

}

