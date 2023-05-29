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
/// Summary description for Cls_jos_railway_mst_loco
/// </summary>
public class Cls_jos_railway_mst_loco : Cls_DBConnection
{
    public Cls_jos_railway_mst_loco()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public string id_mst_loco;
    public string locono;
    public string tid;
    public string shed_id;
    public string doc_date;
    public string a_time;
    public string poh_date;
    public string native;
    public string rfrom;
    //Schedule Data member
    public string Schedule_Id;
    public string ScheduleDate;
    public string id_loco_schedule;
    public string Loco_Id;
    public bool IsDataExists()
    {
        cmd = new SqlCommand("select count(*) from jos_railway_mst_loco where locono='" + this.locono + "'", cnn);
        cmd.Connection.Open();
        Int16 n = Convert.ToInt16(cmd.ExecuteScalar());
        cmd.Connection.Close();
        if (n == 0)
        {
            return false;
        }
        else
        {
            return true;
        }

    }
    public string get_AssemblySupplier(string locono, string assembly)
    {
        cmd = new SqlCommand("SELECT DISTINCT jos_railway_mst_supplier.s_name FROM jos_railway_mst_supplier INNER JOIN  jos_railway_loco_assembly ON  jos_railway_loco_assembly.id_sup = jos_railway_mst_supplier.id_supp WHERE jos_railway_loco_assembly.mid='"+ locono +"' AND jos_railway_loco_assembly.id_ass='"+ assembly +" '", cnn);
        cmd.Connection.Open();
        string str = Convert.ToString(cmd.ExecuteScalar());
        cmd.Connection.Close();
        return str;
    }
    public Int64 Insert_Data()
    {
        Int64 n = 0;
        try
        {
            cmd = new SqlCommand("SELECT COUNT(*) FROM jos_railway_mst_loco", cnn);
            cmd.Connection.Open();
            n = Convert.ToInt64(cmd.ExecuteScalar());
            cmd.Connection.Close();

            cmd = new SqlCommand("INSERT INTO jos_railway_mst_loco(locono,tid,shed_id,doc_date,a_time,poh_date,native,rfrom) VALUES (@locono,@tid,@shed_id,@doc_date,@a_time,@poh_date,@native,@rfrom)", cnn);
            cmd.Parameters.AddWithValue("@locono", this.locono);
            cmd.Parameters.AddWithValue("@tid", this.tid);
            cmd.Parameters.AddWithValue("@shed_id", this.shed_id);
            //cmd.Parameters.AddWithValue("@doc_date", this.doc_date);
            if (this.doc_date != "")
            { cmd.Parameters.AddWithValue("@doc_date", this.doc_date); }
            else { cmd.Parameters.AddWithValue("@doc_date", System.Data.SqlTypes.SqlDateTime.Null); }
            cmd.Parameters.AddWithValue("@a_time", this.a_time);
            if (this.poh_date != "")
            { cmd.Parameters.AddWithValue("@poh_date", this.poh_date); }
            else { cmd.Parameters.AddWithValue("@poh_date", System.Data.SqlTypes.SqlDateTime.Null); }
            cmd.Parameters.AddWithValue("@native", this.native);
            cmd.Parameters.AddWithValue("@rfrom", this.rfrom);
            cmd.Connection.Open();
            int m = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            if (n > 0)
            {
                cmd = new SqlCommand("SELECT MAX(id_mst_loco) FROM jos_railway_mst_loco", cnn);
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
            cmd = new SqlCommand("DELETE FROM jos_railway_mst_loco  WHERE (id_mst_loco=@id_mst_loco)", cnn);
            cmd.Parameters.AddWithValue("@id_mst_loco", this.id_mst_loco);
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
            cmd = new SqlCommand(" UPDATE jos_railway_mst_loco SET locono=@locono,tid=@tid,shed_id=@shed_id,doc_date=@doc_date,a_time=@a_time,poh_date=@poh_date,native=@native,rfrom=@rfrom WHERE id_mst_loco=@id_mst_loco ", cnn);
            cmd.Parameters.AddWithValue("@id_mst_loco", this.id_mst_loco);
            cmd.Parameters.AddWithValue("@locono", this.locono);
            cmd.Parameters.AddWithValue("@tid", this.tid);
            cmd.Parameters.AddWithValue("@shed_id", this.shed_id);
            //cmd.Parameters.AddWithValue("@doc_date", this.doc_date);
            if (this.doc_date != "")
            { cmd.Parameters.AddWithValue("@doc_date", this.doc_date); }
            else { cmd.Parameters.AddWithValue("@doc_date", System.Data.SqlTypes.SqlDateTime.Null); }
            cmd.Parameters.AddWithValue("@a_time", this.a_time);
            if (this.poh_date != "")
            { cmd.Parameters.AddWithValue("@poh_date", this.poh_date); }
            else { cmd.Parameters.AddWithValue("@poh_date", System.Data.SqlTypes.SqlDateTime.Null); }
            cmd.Parameters.AddWithValue("@native", this.native);
            cmd.Parameters.AddWithValue("@rfrom", this.rfrom);
            cmd.Connection.Open();
            int n = Convert.ToInt16(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            return n;
        }
        catch { throw; }
    }
    public DataTable Select_Data()
    {
        cmd = new SqlCommand("SELECT " +
"jos_railway_mst_loco.id_mst_loco  as \"id\"" +
",jos_railway_mst_loco.a_time as \"Arrival Time\"" +
",CONVERT(VARCHAR(10),jos_railway_mst_loco.doc_date,105) as \"doc\"" +
",jos_railway_mst_loco.locono \"locono\"" +
",jos_railway_mst_loco.native \"native\"" +
",CONVERT(VARCHAR(10),jos_railway_mst_loco.poh_date,105) as \"poh\"" +
",jos_railway_mst_loco.rfrom \"rfrom\"" +
",jos_railway_loco_type.loco_type \"class\"" +
",jos_railway_shed.sname as \"shed\"" +
"FROM jos_railway_mst_loco " +
"INNER JOIN jos_railway_loco_type ON jos_railway_loco_type.id_ltype = jos_railway_mst_loco.tid " +
"INNER JOIN jos_railway_shed ON jos_railway_shed.id_shed = jos_railway_mst_loco.shed_id", cnn);
        dt = new DataTable();
        da = new SqlDataAdapter();
        da.SelectCommand = cmd;
        dt.Clear();
        da.Fill(dt);
        return dt;
    }
    public DataTable Select_DataById()
    {
        cmd = new SqlCommand("SELECT " +
"jos_railway_mst_loco.id_mst_loco  as \"id\"" + 
",jos_railway_mst_loco.a_time as \"Arrival Time\"" + 
",REPLACE(CONVERT(VARCHAR(10),jos_railway_mst_loco.doc_date,105),'-','/') as \"doc\"" + 
",jos_railway_mst_loco.locono \"locono\"" + 
",jos_railway_mst_loco.native \"native\"" + 
",REPLACE(CONVERT(VARCHAR(10),jos_railway_mst_loco.poh_date,105),'-','/') as \"poh\"" + 
",jos_railway_mst_loco.rfrom \"rfrom\"" + 
",jos_railway_loco_type.loco_type \"class\"" + 
",jos_railway_shed.sname as \"shed\"" + 
"FROM jos_railway_mst_loco " + 
"INNER JOIN jos_railway_loco_type ON jos_railway_loco_type.id_ltype = jos_railway_mst_loco.tid " +
"INNER JOIN jos_railway_shed ON jos_railway_shed.id_shed = jos_railway_mst_loco.shed_id WHERE jos_railway_mst_loco.id_mst_loco='" + this.id_mst_loco + "'", cnn);
        dt = new DataTable();
        da = new SqlDataAdapter();
        da.SelectCommand = cmd;
        dt.Clear();
        da.Fill(dt);
        return dt;
    }
    public DataTable Select_DataByLocoNo()
    {
        cmd = new SqlCommand("SELECT " +
"jos_railway_mst_loco.id_mst_loco  as \"id\"" +
",jos_railway_mst_loco.a_time as \"Arrival Time\"" +
",CONVERT(VARCHAR(10),jos_railway_mst_loco.doc_date,105) as \"doc\"" +
",jos_railway_mst_loco.locono \"locono\"" +
",jos_railway_mst_loco.native \"native\"" +
",CONVERT(VARCHAR(10),jos_railway_mst_loco.poh_date,105) as \"poh\"" +
",jos_railway_mst_loco.rfrom \"rfrom\"" +
",jos_railway_loco_type.loco_type \"class\"" +
",jos_railway_shed.sname as \"shed\"" +
"FROM jos_railway_mst_loco " +
"INNER JOIN jos_railway_loco_type ON jos_railway_loco_type.id_ltype = jos_railway_mst_loco.tid " +
"INNER JOIN jos_railway_shed ON jos_railway_shed.id_shed = jos_railway_mst_loco.shed_id WHERE jos_railway_mst_loco.id_mst_loco='" + this.id_mst_loco + "'", cnn);
        dt = new DataTable();
        da = new SqlDataAdapter();
        da.SelectCommand = cmd;
        dt.Clear();
        da.Fill(dt);
        return dt;
    }
    public DataTable Select_LocoNo()
    {
        cmd = new SqlCommand("SELECT jos_railway_mst_loco.locono,jos_railway_mst_loco.id_mst_loco FROM jos_railway_mst_loco", cnn);
        dt = new DataTable();
        da = new SqlDataAdapter();
        da.SelectCommand = cmd;
        dt.Clear();
        da.Fill(dt);
        return dt;
    }
    public DataTable Select_LocoNoByType()
    {
        //this function return locolist by class
        //cmd = new SqlCommand("SELECT jos_railway_mst_loco.locono,jos_railway_mst_loco.id_mst_loco FROM jos_railway_mst_loco WHERE tid=@tid", cnn);
        //cmd = new SqlCommand("SELECT jos_railway_mst_loco.id_mst_loco,jos_railway_mst_loco.locono,REPLACE(CONVERT(VARCHAR(10),jos_railway_mst_loco.poh_date,105),'-','/') AS poh_date,jos_railway_mst_loco.rfrom,jos_railway_mst_loco.id_mst_loco,REPLACE(CONVERT(VARCHAR(10),jos_railway_mst_loco.doc_date,105),'-','/')as doc_date FROM jos_railway_mst_loco WHERE tid=@tid AND jos_railway_mst_loco.id_mst_loco IN(1,2,3) AND jos_railway_mst_loco.native='HOME' ORDER BY jos_railway_mst_loco.locono", cnn);
        cmd = new SqlCommand("SELECT jos_railway_mst_loco.id_mst_loco,jos_railway_mst_loco.locono,REPLACE(CONVERT(VARCHAR(10),jos_railway_mst_loco.poh_date,105),'-','/') AS poh_date,jos_railway_mst_loco.rfrom,jos_railway_mst_loco.id_mst_loco,REPLACE(CONVERT(VARCHAR(10),jos_railway_mst_loco.doc_date,105),'-','/')as doc_date FROM jos_railway_mst_loco WHERE tid=@tid AND jos_railway_mst_loco.native='HOME' ORDER BY jos_railway_mst_loco.locono", cnn);
        cmd.Parameters.AddWithValue("@tid", this.tid);
        dt = new DataTable();
        da = new SqlDataAdapter();
        da.SelectCommand = cmd;
        dt.Clear();
        da.Fill(dt);
        return dt;
    }
    public DataTable Select_LocoType()
    {
        try
        {
            cmd = new SqlCommand("SELECT native FROM jos_railway_mst_loco WHERE id_mst_loco='" + this.id_mst_loco + "'", cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        catch { throw; }
    }

    public Int64 Insert_Data_Loco_Schedule()
    {   //Insert Loco Schedule
        Int64 n = 0;
        try
        {
            cmd = new SqlCommand("SELECT COUNT(*) FROM jos_railway_loco_Schedule_TimeTable", cnn);
            cmd.Connection.Open();
            n = Convert.ToInt64(cmd.ExecuteScalar());
            cmd.Connection.Close();

            cmd = new SqlCommand("INSERT INTO jos_railway_loco_Schedule_TimeTable(Schedule_Id,Loco_Id,ScheduleDate) VALUES(@Schedule_Id,@Loco_Id,@ScheduleDate)", cnn);
            cmd.Parameters.AddWithValue("@Schedule_Id", this.Schedule_Id);
            cmd.Parameters.AddWithValue("@Loco_Id", this.Loco_Id);
            cmd.Parameters.AddWithValue("@ScheduleDate", this.ScheduleDate);
            cmd.Connection.Open();
            int m = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            if (n > 0)
            {
                cmd = new SqlCommand("SELECT MAX(id_loco_Schedule) FROM jos_railway_loco_Schedule_TimeTable", cnn);
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
    public bool Check_Loco_ScheduleIsExists()
    {

        try
        {
            cmd = new SqlCommand("SELECT COUNT(*) FROM jos_railway_loco_Schedule_TimeTable WHERE Loco_Id=@Loco_Id AND Schedule_Id=@Schedule_Id", cnn);
            cmd.Parameters.AddWithValue("@Schedule_Id", this.Schedule_Id);
            cmd.Parameters.AddWithValue("@Loco_Id", this.Loco_Id);
            cmd.Connection.Open();
            int n = Convert.ToInt16(cmd.ExecuteScalar());
            cmd.Connection.Close();
            return n == 1 ? true : false;
        }
        catch { throw; }

    }
    public void Update_Data_Loco_Schedule()
    {
        try
        {

            cmd = new SqlCommand("UPDATE jos_railway_loco_Schedule_TimeTable SET Schedule_Id=@Schedule_Id,Loco_Id=@Loco_Id,ScheduleDate=@ScheduleDate WHERE Schedule_Id=@Schedule_Id AND Loco_Id=@Loco_Id", cnn);
            cmd.Parameters.AddWithValue("@Schedule_Id", this.Schedule_Id);
            cmd.Parameters.AddWithValue("@Loco_Id", this.Loco_Id);
            cmd.Parameters.AddWithValue("@ScheduleDate", this.ScheduleDate);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }
        catch { throw; }

    }
    public DataTable Select_Loco_ScheduleData()
    {
        cmd = new SqlCommand("SELECT jos_railway_loco_Schedule_TimeTable.id_loco_Schedule as \"ScheduleId\",jos_railway_loco_type_schedule.s_type as \"Schedule\",CONVERT(VARCHAR(10),jos_railway_loco_Schedule_TimeTable.ScheduleDate,105) as \"ScheduleDate\" FROM jos_railway_loco_Schedule_TimeTable INNER JOIN jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = jos_railway_loco_Schedule_TimeTable.Schedule_Id WHERE jos_railway_loco_Schedule_TimeTable.Loco_Id='" + this.Loco_Id + "'", cnn);
        da = new SqlDataAdapter();
        dt = new DataTable();
        da.SelectCommand = cmd;
        dt.Clear();
        da.Fill(dt);
        return dt;


    }
    public DataTable Select_DocDateById()
    {
        try
        {
            cmd = new SqlCommand("SELECT doc_date FROM jos_railway_mst_loco WHERE id_mst_loco=@id_mst_loco", cnn);
            cmd.Parameters.AddWithValue("@id_mst_loco", this.id_mst_loco);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        catch { throw; }
    }
    public string GetLocoIdByLocono()
    {
        try
        {
            cmd = new SqlCommand("SELECT id_mst_loco FROM jos_railway_mst_loco WHERE locono=@locono", cnn);
            cmd.Parameters.AddWithValue("@locono", this.locono);
            cmd.Connection.Open();
            string str = Convert.ToString(cmd.ExecuteScalar());
            cmd.Connection.Close();
            return str == "" ? "" : str;
        }
        catch { throw; }
    }
    public string GetDocDateBylocoId()
    {
        try
        {
            cmd = new SqlCommand("SELECT REPLACE(CONVERT(VARCHAR(10),doc_date,105),'-','/') FROM jos_railway_mst_loco WHERE id_mst_loco=@id_mst_loco", cnn);
            cmd.Parameters.AddWithValue("@id_mst_loco", this.id_mst_loco);
            cmd.Connection.Open();
            string str = Convert.ToString(cmd.ExecuteScalar());
            cmd.Connection.Close();
            return str == "" ? "" : str;
        }
        catch { throw; }
    }
    public string GetDOCBylocoId(string LocoId)
    {
        try
        {
            cmd = new SqlCommand("SELECT REPLACE(CONVERT(VARCHAR(10),doc_date,105),'-','/') as doc_date FROM jos_railway_mst_loco WHERE id_mst_loco=@id_mst_loco", cnn);
            cmd.Parameters.AddWithValue("@id_mst_loco", LocoId);
            cmd.Connection.Open();
            string str =  Convert.ToString(cmd.ExecuteScalar());
            cmd.Connection.Close();
            return str;
        }
        catch { throw; }
    }
    public string GetHeavyScheduleDateBylocoId(string LocoId)
    {
        try
        {
            cmd = new SqlCommand("SELECT REPLACE(CONVERT(VARCHAR(10),HeavyScheduleDate,105),'-','/') FROM Loco_HeavySchedule WHERE Id_HeavySchedule=(SELECT MAX(Id_HeavySchedule) FROM Loco_HeavySchedule WHERE Loco_Id=@Loco_Id)", cnn);
            cmd.Parameters.AddWithValue("@Loco_Id", LocoId);
            cmd.Connection.Open();
            string str = Convert.ToString(cmd.ExecuteScalar());
            cmd.Connection.Close();
            return str;
        }
        catch { throw; }
    }
    public DataTable Get_MGLocono()
    {
        try
        {
            cmd = new SqlCommand("SELECT jos_railway_mst_loco.id_mst_loco,jos_railway_mst_loco.locono FROM jos_railway_mst_loco INNER JOIN jos_railway_loco_type ON jos_railway_loco_type.id_ltype = jos_railway_mst_loco.tid WHERE jos_railway_loco_type.guage='METER GUAGE'", cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            return dt;
        }
        catch { throw; }
    }
    public DataTable Get_BGLocono()
    {
        try
        {
            cmd = new SqlCommand("SELECT jos_railway_mst_loco.id_mst_loco,jos_railway_mst_loco.locono FROM jos_railway_mst_loco INNER JOIN jos_railway_loco_type ON jos_railway_loco_type.id_ltype = jos_railway_mst_loco.tid WHERE jos_railway_loco_type.guage='BROAD GUAGE'", cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            return dt;
        }
        catch { throw; }
    }

   
}


