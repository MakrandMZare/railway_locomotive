//using System;
//using System.Data;
//using System.Configuration;
//using System.Web;
//using System.Web.Security;
//using System.Web.UI;
//using System.Web.UI.HtmlControls;
//using System.Web.UI.WebControls;
//using System.Web.UI.WebControls.WebParts;
//using Railway;
//using System.Data.SqlClient;
///// <summary>
///// Summary description for jos_railway_loco_Schedule_TimeTable
///// </summary>
//namespace Railway
//{
//    public class jos_railway_loco_Schedule_TimeTable : Cls_DBConnection
//    {
//        public string id_loco_Schedule;
//        public string Schedule_Id;
//        public string Loco_Id;
//        public string ScheduleDate;
//        public string Id_Master;

//        public jos_railway_loco_Schedule_TimeTable()
//        {
//            //
//            // TODO: Add constructor logic here
//            //
//        }
//        public Int64 Insert_Data()
//        {
//            try
//            {
//                cmd = new SqlCommand("INSERT INTO jos_railway_loco_Schedule_TimeTable(Schedule_Id,Loco_Id,ScheduleDate,Id_Master) VALUES(@Schedule_Id,@Loco_Id,@ScheduleDate,@Id_Master)", cnn);
//                cmd.Parameters.AddWithValue("@Schedule_Id",this.Schedule_Id);
//                cmd.Parameters.AddWithValue("@Loco_Id",this.Loco_Id);
//                cmd.Parameters.AddWithValue("@ScheduleDate",this.ScheduleDate);
//                cmd.Parameters.AddWithValue("@Id_Master",this.Id_Master);
//                cmd.Connection.Open();
//                Int64 n = cmd.ExecuteNonQuery();
//                cmd.Connection.Close();
//                if (n == 1)
//                {
//                    cmd = new SqlCommand("SELECT MAX(id_loco_Schedule) FROM jos_railway_loco_Schedule_TimeTable", cnn);
//                    cmd.Connection.Open();
//                    Int64 m = Convert.ToInt64(cmd.ExecuteScalar());
//                    cmd.Connection.Close();
//                    return m;
//                }
//                else { return 0; }

//            }
//            catch { throw; }
//        }
//        public bool Check_Loco_Come_At_RegularSchedule(string locoid, string arrivaldate, string Schedule)
//        {
//            cmd = new SqlCommand("SELECT COUNT(*) FROM jos_railway_loco_in WHERE jos_railway_loco_in.loco_id='" + locoid + "' AND CONVERT(VARCHAR(10),jos_railway_loco_in.a_date,105)>='" + arrivaldate + "' AND sid='" + Schedule + "'", cnn);
//            cmd.Connection.Open();
//            int n = Convert.ToInt16(cmd.ExecuteScalar());
//            cmd.Connection.Close();
//            return n == 1 ? true : false;
//        }
//        public DataTable Get_OverdueScheduleLocoFORO1(DataTable dt)
//        {
//            string str = ",";
//            foreach (DataRow dr in dt.Rows)
//            {
//                if (!Check_Loco_Come_At_RegularSchedule(dr[0].ToString(), dr[4].ToString(), dr[5].ToString()))
//                {
//                    str += ("'" + dr[1].ToString() + "',");
//                }
//            }
//            if (str == ",")
//            {
//                str = "'0'";
//            }
//            else
//            {
//                str = str.Remove(str.Length - 1, 1);
//                if (str.StartsWith(","))
//                {
//                    str = str.Remove(0, 1);
//                }
//            }


//            return Get_ScheduleArisingForMonthByIdFORO1(str);
//        }
//        public DataTable Get_OverdueScheduleLoco(DataTable dt)
//        {
//            string str = ",";
//            foreach (DataRow dr in dt.Rows)
//            {
//                if (!Check_Loco_Come_At_RegularSchedule(dr[0].ToString(), dr[4].ToString(), dr[5].ToString()))
//                {
//                    str += ("'" + dr[1].ToString() + "',");
//                }
//            }
//            if (str == ",")
//            {
//                str = "'0'";
//            }
//            else
//            {
//                str = str.Remove(str.Length - 1, 1);
//                if (str.StartsWith(","))
//                {
//                    str = str.Remove(0,1);
//                }
//            }
            

//            return Get_ScheduleArisingForMonthById(str);
//        }
//        public DataTable Get_ScheduleArisingForMonthById(string Ids)
//        {
//            //this function return all schedule arrising in current 1 month except 'O1' 
//            cmd = new SqlCommand("SELECT " +
//                                 " jos_railway_mst_loco.id_mst_loco as \"locoid\" " +
//                                 ",jos_railway_loco_Schedule_TimeTable.id_loco_Schedule as \"id\"" +
//                                 ",jos_railway_mst_loco.locono as \"Locono\" " +
//                                 ",jos_railway_loco_type_schedule.s_type as \"Schedule\" " +
//                                 ",REPLACE(CONVERT(VARCHAR(10),jos_railway_loco_Schedule_TimeTable.ScheduleDate,105),'-','/') as \"ScheduleDate\" " +
//                                 ",jos_railway_loco_type_schedule.id_loco_sch as \"ScheduleId\" " +
//                                 " FROM jos_railway_loco_Schedule_TimeTable " +
//                                 " INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = jos_railway_loco_Schedule_TimeTable.Loco_Id " +
//                                 " INNER JOIN jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = jos_railway_loco_Schedule_TimeTable.Schedule_Id " +
//                                 " WHERE jos_railway_loco_Schedule_TimeTable.id_loco_Schedule IN (" + Ids + ") AND jos_railway_loco_type_schedule.s_type !='O1' order by jos_railway_loco_Schedule_TimeTable.ScheduleDate asc", cnn);
//            da = new SqlDataAdapter();
//            dt = new DataTable();
//            da.SelectCommand = cmd;
//            da.Fill(dt);
//            return dt;
//        }
//        public DataTable Get_ScheduleArisingForMonth()
//        {
//            //this function return all schedule arrising in current 1 month except 'O1' 
//            cmd = new SqlCommand("SELECT " +
//                                 "jos_railway_mst_loco.id_mst_loco as \"locoid\" " +                 
//                                 ",jos_railway_loco_Schedule_TimeTable.id_loco_Schedule as \"id\"" +
//                                 ",jos_railway_mst_loco.locono as \"Locono\" " +
//                                 ",jos_railway_loco_type_schedule.s_type as \"Schedule\" " +
//                                 ",REPLACE(CONVERT(VARCHAR(10),jos_railway_loco_Schedule_TimeTable.ScheduleDate,105),'-','/') as \"ScheduleDate\" " +
//                                 ",jos_railway_loco_type_schedule.id_loco_sch as \"ScheduleId\" " +
//                                 "FROM jos_railway_loco_Schedule_TimeTable " +
//                                 "INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = jos_railway_loco_Schedule_TimeTable.Loco_Id " +
//                                 "INNER JOIN jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = jos_railway_loco_Schedule_TimeTable.Schedule_Id " +
//                                 "INNER JOIN jos_railway_loco_type ON  jos_railway_loco_type.id_ltype = jos_railway_mst_loco.tid " +
//                                 //"WHERE jos_railway_loco_Schedule_TimeTable.ScheduleDate between GETDATE() AND  Dateadd(MM,1,GETDATE()) AND jos_railway_loco_type.guage='METER GUAGE' order by jos_railway_loco_Schedule_TimeTable.ScheduleDate asc", cnn);
//                                 "WHERE MONTH(jos_railway_loco_Schedule_TimeTable.ScheduleDate)= MONTH(GETDATE()) AND YEAR(jos_railway_loco_Schedule_TimeTable.ScheduleDate)= YEAR(GETDATE()) AND jos_railway_loco_type.guage='BROAD GUAGE' AND jos_railway_loco_type_schedule.s_type !='O1' order by jos_railway_loco_Schedule_TimeTable.ScheduleDate asc", cnn);
//                                 //"WHERE jos_railway_loco_Schedule_TimeTable.ScheduleDate between CONVERT(VARCHAR(10),GETDATE(),101) AND CONVERT(VARCHAR(10),DATEADD(MM,1,GETDATE()),101) AND jos_railway_loco_type.guage='BROAD GUAGE' order by jos_railway_loco_Schedule_TimeTable.ScheduleDate asc", cnn);
//            da = new SqlDataAdapter();
//            dt = new DataTable();
//            da.SelectCommand = cmd;
//            da.Fill(dt);
//            return dt;
//        }
//        public DataTable Get_ScheduleArisingForMonthFORO1()
//        {
//            //this function return all schedule arrising in current 1 month except 'O1' 
//            cmd = new SqlCommand("SELECT " +
//                                 "jos_railway_mst_loco.id_mst_loco as \"locoid\" " +
//                                 ",jos_railway_loco_Schedule_TimeTable.id_loco_Schedule as \"id\"" +
//                                 ",jos_railway_mst_loco.locono as \"Locono\" " +
//                                 ",jos_railway_loco_type_schedule.s_type as \"Schedule\" " +
//                                 ",REPLACE(CONVERT(VARCHAR(10),jos_railway_loco_Schedule_TimeTable.ScheduleDate,105),'-','/') as \"ScheduleDate\" " +
//                                 ",jos_railway_loco_type_schedule.id_loco_sch as \"ScheduleId\" " +
//                                 "FROM jos_railway_loco_Schedule_TimeTable " +
//                                 "INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = jos_railway_loco_Schedule_TimeTable.Loco_Id " +
//                                 "INNER JOIN jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = jos_railway_loco_Schedule_TimeTable.Schedule_Id " +
//                                 "INNER JOIN jos_railway_loco_type ON  jos_railway_loco_type.id_ltype = jos_railway_mst_loco.tid " +
//                //"WHERE jos_railway_loco_Schedule_TimeTable.ScheduleDate between GETDATE() AND  Dateadd(MM,1,GETDATE()) AND jos_railway_loco_type.guage='METER GUAGE' order by jos_railway_loco_Schedule_TimeTable.ScheduleDate asc", cnn);
//                                 "WHERE MONTH(jos_railway_loco_Schedule_TimeTable.ScheduleDate)= MONTH(GETDATE()) AND YEAR(jos_railway_loco_Schedule_TimeTable.ScheduleDate)= YEAR(GETDATE()) AND jos_railway_loco_type.guage='BROAD GUAGE' AND jos_railway_loco_type_schedule.s_type ='O1' order by jos_railway_loco_Schedule_TimeTable.ScheduleDate asc", cnn);
//            //"WHERE jos_railway_loco_Schedule_TimeTable.ScheduleDate between CONVERT(VARCHAR(10),GETDATE(),101) AND CONVERT(VARCHAR(10),DATEADD(MM,1,GETDATE()),101) AND jos_railway_loco_type.guage='BROAD GUAGE' order by jos_railway_loco_Schedule_TimeTable.ScheduleDate asc", cnn);
//            da = new SqlDataAdapter();
//            dt = new DataTable();
//            da.SelectCommand = cmd;
//            da.Fill(dt);
//            return dt;
//        }

//        public DataTable Get_ScheduleArisingForMonthByIdFORO1(string Ids)
//        {
//            //this function return all schedule arrising in current 1 month except 'O1' 
//            cmd = new SqlCommand("SELECT " +
//                                 " jos_railway_mst_loco.id_mst_loco as \"locoid\" " +
//                                 ",jos_railway_loco_Schedule_TimeTable.id_loco_Schedule as \"id\"" +
//                                 ",jos_railway_mst_loco.locono as \"Locono\" " +
//                                 ",jos_railway_loco_type_schedule.s_type as \"Schedule\" " +
//                                 ",REPLACE(CONVERT(VARCHAR(10),jos_railway_loco_Schedule_TimeTable.ScheduleDate,105),'-','/') as \"ScheduleDate\" " +
//                                 ",jos_railway_loco_type_schedule.id_loco_sch as \"ScheduleId\" " +
//                                 " FROM jos_railway_loco_Schedule_TimeTable " +
//                                 " INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = jos_railway_loco_Schedule_TimeTable.Loco_Id " +
//                                 " INNER JOIN jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = jos_railway_loco_Schedule_TimeTable.Schedule_Id " +
//                                 " WHERE jos_railway_loco_Schedule_TimeTable.id_loco_Schedule IN (" + Ids + ") AND jos_railway_loco_type_schedule.s_type = 'O1' order by jos_railway_loco_Schedule_TimeTable.ScheduleDate asc", cnn);
//            da = new SqlDataAdapter();
//            dt = new DataTable();
//            da.SelectCommand = cmd;
//            da.Fill(dt);
//            return dt;
//        }
//        public DataTable MG_Get_ScheduleArisingForMonth()
//        {
//            cmd = new SqlCommand("SELECT " +
//                                "jos_railway_mst_loco.id_mst_loco as  \"locoid\"  " +
//                                ",jos_railway_loco_Schedule_TimeTable.id_loco_Schedule as  \"id\" " +
//                                ",jos_railway_mst_loco.locono as  \"Locono\"  " +
//                                ",jos_railway_loco_type_schedule.s_type as  \"Schedule\"  " +
//                                ",CONVERT(VARCHAR(10),jos_railway_loco_Schedule_TimeTable.ScheduleDate,105) as  \"ScheduleDate\"  " +
//                                ",jos_railway_loco_type_schedule.id_loco_sch as  \"ScheduleId\"  " +
//                                "FROM jos_railway_loco_Schedule_TimeTable  " +
//                                "INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = jos_railway_loco_Schedule_TimeTable.Loco_Id " +
//                                "INNER JOIN jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = jos_railway_loco_Schedule_TimeTable.Schedule_Id " +
//                                "INNER JOIN jos_railway_loco_type ON  jos_railway_loco_type.id_ltype = jos_railway_mst_loco.tid  " +
//                                "WHERE jos_railway_loco_Schedule_TimeTable.ScheduleDate between CONVERT(VARCHAR(10),GETDATE(),101) AND CONVERT(VARCHAR(10),DATEADD(MM,1,GETDATE()),101) AND jos_railway_loco_type.guage='METER GUAGE' order by jos_railway_loco_Schedule_TimeTable.ScheduleDate asc", cnn);
//            da = new SqlDataAdapter();
//            dt = new DataTable();
//            da.SelectCommand = cmd;
//            da.Fill(dt);
//            return dt;
//        }
//        public DataTable Get_ScheduleInCurrentLoco_Schedule(string locoid,string Master)
//        {
//            cmd = new SqlCommand("SELECT jos_railway_loco_type_schedule.id_loco_sch,jos_railway_loco_type_schedule.s_type FROM jos_railway_Loco_Schedule_TimeTable INNER JOIN jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = jos_railway_Loco_Schedule_TimeTable.Schedule_Id WHERE jos_railway_Loco_Schedule_TimeTable.Loco_Id=@Loco_Id AND Id_Master=@Id_Master", cnn);
//            cmd.Parameters.AddWithValue("@Id_Master", Master);
//            cmd.Parameters.AddWithValue("@Loco_Id", locoid);
//            da = new SqlDataAdapter();
//            dt = new DataTable();
//            da.SelectCommand = cmd;
//            da.Fill(dt);
//            da.SelectCommand = cmd;
//            return dt;
//        }
//        public DataTable Get_LoconoInCurrentLocoSchedule()
//        {
//            cmd = new SqlCommand("SELECT DISTINCT jos_railway_mst_loco.id_mst_loco,jos_railway_mst_loco.locono FROM jos_railway_loco_Schedule_TimeTable INNER JOIN jos_railway_mst_loco ON jos_railway_loco_Schedule_TimeTable.Loco_Id = jos_railway_mst_loco.id_mst_loco WHERE jos_railway_Loco_Schedule_TimeTable.Id_Master=@Id_Master", cnn);
//            cmd.Parameters.AddWithValue("@Id_Master", this.Id_Master);
//            da = new SqlDataAdapter();
//            dt = new DataTable();
//            da.SelectCommand = cmd;
//            da.Fill(dt);
//            da.SelectCommand = cmd;
//            return dt;
//        }
//        public DataTable Select_DataById()
//        {
//            cmd = new SqlCommand("SELECT REPLACE(CONVERT(VARCHAR(10),ScheduleDate,105),'-','/')as ScheduleDate FROM jos_railway_Loco_Schedule_TimeTable WHERE Id_Master=@Id_Master AND Loco_Id=@Loco_Id", cnn);
//            cmd.Parameters.AddWithValue("@Id_Master", this.Id_Master);
//            cmd.Parameters.AddWithValue("@Loco_Id", this.Loco_Id);
//            da = new SqlDataAdapter();
//            dt = new DataTable();
//            da.SelectCommand = cmd;
//            da.Fill(dt);
//            da.SelectCommand = cmd;
//            return dt;
//        }
//    }
//}
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
/// Summary description for jos_railway_loco_Schedule_TimeTable
/// </summary>
namespace Railway
{
    public class jos_railway_loco_Schedule_TimeTable : Cls_DBConnection
    {
        public string id_loco_Schedule;
        public string Schedule_Id;
        public string Loco_Id;
        public string ScheduleDate;
        public string Id_Master;

        public jos_railway_loco_Schedule_TimeTable()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        public Int64 Insert_Data()
        {
            try
            {
                cmd = new SqlCommand("INSERT INTO jos_railway_loco_Schedule_TimeTable(Schedule_Id,Loco_Id,ScheduleDate,Id_Master) VALUES(@Schedule_Id,@Loco_Id,@ScheduleDate,@Id_Master)", cnn);
                cmd.Parameters.AddWithValue("@Schedule_Id", this.Schedule_Id);
                cmd.Parameters.AddWithValue("@Loco_Id", this.Loco_Id);
                cmd.Parameters.AddWithValue("@ScheduleDate", this.ScheduleDate);
                cmd.Parameters.AddWithValue("@Id_Master", this.Id_Master);
                cmd.Connection.Open();
                Int64 n = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                if (n == 1)
                {
                    cmd = new SqlCommand("SELECT MAX(id_loco_Schedule) FROM jos_railway_loco_Schedule_TimeTable", cnn);
                    cmd.Connection.Open();
                    Int64 m = Convert.ToInt64(cmd.ExecuteScalar());
                    cmd.Connection.Close();
                    return m;
                }
                else { return 0; }

            }
            catch { throw; }
        }
        public bool Check_Loco_Come_At_RegularSchedule(string locoid, string arrivaldate, string Schedule)
        {
            cmd = new SqlCommand("SELECT COUNT(*) FROM jos_railway_loco_in WHERE jos_railway_loco_in.loco_id='" + locoid + "' AND CONVERT(VARCHAR(10),jos_railway_loco_in.a_date,105)>='" + arrivaldate + "' AND sid='" + Schedule + "'", cnn);
            cmd.Connection.Open();
            int n = Convert.ToInt16(cmd.ExecuteScalar());
            cmd.Connection.Close();
            return n == 1 ? true : false;
        }
        public DataTable Get_OverdueScheduleLocoFORO1(DataTable dt)
        {
            string str = ",";
            foreach (DataRow dr in dt.Rows)
            {
                if (!Check_Loco_Come_At_RegularSchedule(dr[0].ToString(), dr[4].ToString(), dr[5].ToString()))
                {
                    str += ("'" + dr[1].ToString() + "',");
                }
            }
            if (str == ",")
            {
                str = "'0'";
            }
            else
            {
                str = str.Remove(str.Length - 1, 1);
                if (str.StartsWith(","))
                {
                    str = str.Remove(0, 1);
                }
            }


            return Get_ScheduleArisingForMonthByIdFORO1(str);
        }
        public DataTable Get_OverdueScheduleLoco(DataTable dt)
        {
            string str = ",";
            foreach (DataRow dr in dt.Rows)
            {
                if (!Check_Loco_Come_At_RegularSchedule(dr[0].ToString(), dr[4].ToString(), dr[5].ToString()))
                {
                    str += ("'" + dr[1].ToString() + "',");
                }
            }
            if (str == ",")
            {
                str = "'0'";
            }
            else
            {
                str = str.Remove(str.Length - 1, 1);
                if (str.StartsWith(","))
                {
                    str = str.Remove(0, 1);
                }
            }


            return Get_ScheduleArisingForMonthById(str);
        }
        public DataTable Get_OverdueScheduleLocoFor1(DataTable dt)
        {
            string str = ",";
            foreach (DataRow dr in dt.Rows)
            {
                if (!Check_Loco_Come_At_RegularSchedule(dr[0].ToString(), dr[4].ToString(), dr[5].ToString()))
                {
                    str += ("'" + dr[1].ToString() + "',");
                }
            }
            if (str == ",")
            {
                str = "'0'";
            }
            else
            {
                str = str.Remove(str.Length - 1, 1);
                if (str.StartsWith(","))
                {
                    str = str.Remove(0, 1);
                }
            }


            return Get_ScheduleArisingForMonthByIdForO1(str);
        }
        public DataTable Get_ScheduleArisingForMonthById(string Ids)
        {
            //this function return all schedule arrising in current 1 month except 'O1' 
            cmd = new SqlCommand("SELECT " +
                                 " jos_railway_mst_loco.id_mst_loco as \"locoid\" " +
                                 ",jos_railway_loco_Schedule_TimeTable.id_loco_Schedule as \"id\"" +
                                 ",jos_railway_mst_loco.locono as \"Locono\" " +
                                 ",jos_railway_loco_type_schedule.s_type as \"Schedule\" " +
                                 ",REPLACE(CONVERT(VARCHAR(10),jos_railway_loco_Schedule_TimeTable.ScheduleDate,105),'-','/') as \"ScheduleDate\" " +
                                 ",jos_railway_loco_type_schedule.id_loco_sch as \"ScheduleId\" " +
                                 " FROM jos_railway_loco_Schedule_TimeTable " +
                                 " INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = jos_railway_loco_Schedule_TimeTable.Loco_Id " +
                                 " INNER JOIN jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = jos_railway_loco_Schedule_TimeTable.Schedule_Id " +
                                 " WHERE jos_railway_loco_Schedule_TimeTable.id_loco_Schedule IN (" + Ids + ") AND jos_railway_loco_type_schedule.s_type !='O1' order by jos_railway_loco_Schedule_TimeTable.ScheduleDate asc", cnn);
            da = new SqlDataAdapter();
            dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        public DataTable Get_ScheduleArisingForMonthByIdForO1(string Ids)
        {
            //this function return all schedule arrising in current 1 month except 'O1' 
            cmd = new SqlCommand("SELECT " +
                                 " jos_railway_mst_loco.id_mst_loco as \"locoid\" " +
                                 ",jos_railway_loco_Schedule_TimeTable.id_loco_Schedule as \"id\"" +
                                 ",jos_railway_mst_loco.locono as \"Locono\" " +
                                 ",jos_railway_loco_type_schedule.s_type as \"Schedule\" " +
                                 ",REPLACE(CONVERT(VARCHAR(10),jos_railway_loco_Schedule_TimeTable.ScheduleDate,105),'-','/') as \"ScheduleDate\" " +
                                 ",jos_railway_loco_type_schedule.id_loco_sch as \"ScheduleId\" " +
                                 " FROM jos_railway_loco_Schedule_TimeTable " +
                                 " INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = jos_railway_loco_Schedule_TimeTable.Loco_Id " +
                                 " INNER JOIN jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = jos_railway_loco_Schedule_TimeTable.Schedule_Id " +
                                 " WHERE jos_railway_loco_Schedule_TimeTable.id_loco_Schedule IN (" + Ids + ") AND jos_railway_loco_type_schedule.s_type ='O1' order by jos_railway_loco_Schedule_TimeTable.ScheduleDate asc", cnn);
            da = new SqlDataAdapter();
            dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        //public DataTable Get_ScheduleArisingForMonthByIdForO1(string Ids)
        //{
        //    //this function return all schedule arrising in current 1 month except 'O1' 
        //    cmd = new SqlCommand("SELECT " +
        //                         " jos_railway_mst_loco.id_mst_loco as \"locoid\" " +
        //                         ",jos_railway_loco_Schedule_TimeTable.id_loco_Schedule as \"id\"" +
        //                         ",jos_railway_mst_loco.locono as \"Locono\" " +
        //                         ",jos_railway_loco_type_schedule.s_type as \"Schedule\" " +
        //                         ",REPLACE(CONVERT(VARCHAR(10),jos_railway_loco_Schedule_TimeTable.ScheduleDate,105),'-','/') as \"ScheduleDate\" " +
        //                         ",jos_railway_loco_type_schedule.id_loco_sch as \"ScheduleId\" " +
        //                         " FROM jos_railway_loco_Schedule_TimeTable " +
        //                         " INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = jos_railway_loco_Schedule_TimeTable.Loco_Id " +
        //                         " INNER JOIN jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = jos_railway_loco_Schedule_TimeTable.Schedule_Id " +
        //                         " WHERE jos_railway_loco_Schedule_TimeTable.id_loco_Schedule IN (" + Ids + ") AND jos_railway_loco_type_schedule.s_type !='O1' order by jos_railway_loco_Schedule_TimeTable.ScheduleDate asc", cnn);
        //    da = new SqlDataAdapter();
        //    dt = new DataTable();
        //    da.SelectCommand = cmd;
        //    da.Fill(dt);
        //    return dt;
        //}
        public DataTable Get_ScheduleArisingForMonthFromCurrentDate()
        {
            //this function return all schedule arrising in current 1 month except 'O1' 
            cmd = new SqlCommand("SELECT " +
                                 "jos_railway_mst_loco.id_mst_loco as \"locoid\" " +
                                 ",jos_railway_loco_Schedule_TimeTable.id_loco_Schedule as \"id\"" +
                                 ",jos_railway_mst_loco.locono as \"Locono\" " +
                                 ",jos_railway_loco_type_schedule.s_type as \"Schedule\" " +
                                 ",REPLACE(CONVERT(VARCHAR(10),jos_railway_loco_Schedule_TimeTable.ScheduleDate,105),'-','/') as \"ScheduleDate\" " +
                                 ",jos_railway_loco_type_schedule.id_loco_sch as \"ScheduleId\" " +
                                 "FROM jos_railway_loco_Schedule_TimeTable " +
                                 "INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = jos_railway_loco_Schedule_TimeTable.Loco_Id " +
                                 "INNER JOIN jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = jos_railway_loco_Schedule_TimeTable.Schedule_Id " +
                                 "INNER JOIN jos_railway_loco_type ON  jos_railway_loco_type.id_ltype = jos_railway_mst_loco.tid " +
                //"WHERE jos_railway_loco_Schedule_TimeTable.ScheduleDate between GETDATE() AND  Dateadd(MM,1,GETDATE()) AND jos_railway_loco_type.guage='METER GUAGE' order by jos_railway_loco_Schedule_TimeTable.ScheduleDate asc", cnn);
                                 "WHERE MONTH(jos_railway_loco_Schedule_TimeTable.ScheduleDate)= MONTH(GETDATE()) AND YEAR(jos_railway_loco_Schedule_TimeTable.ScheduleDate)= YEAR(GETDATE()) AND jos_railway_loco_type.guage='BROAD GUAGE' AND jos_railway_loco_type_schedule.s_type !='O1' AND jos_railway_loco_Schedule_TimeTable.ScheduleDate >= CONVERT(VARCHAR(10),GETDATE(),101) order by jos_railway_loco_Schedule_TimeTable.ScheduleDate asc", cnn);
            //"WHERE jos_railway_loco_Schedule_TimeTable.ScheduleDate between CONVERT(VARCHAR(10),GETDATE(),101) AND CONVERT(VARCHAR(10),DATEADD(MM,1,GETDATE()),101) AND jos_railway_loco_type.guage='BROAD GUAGE' order by jos_railway_loco_Schedule_TimeTable.ScheduleDate asc", cnn);
            da = new SqlDataAdapter();
            dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        public DataTable Get_ScheduleArisingForMonthBeforeCurrentDate()
        {
            //this function return all schedule arrising in current 1 month except 'O1' 
            cmd = new SqlCommand("SELECT " +
                                 "jos_railway_mst_loco.id_mst_loco as \"locoid\" " +
                                 ",jos_railway_loco_Schedule_TimeTable.id_loco_Schedule as \"id\"" +
                                 ",jos_railway_mst_loco.locono as \"Locono\" " +
                                 ",jos_railway_loco_type_schedule.s_type as \"Schedule\" " +
                                 ",REPLACE(CONVERT(VARCHAR(10),jos_railway_loco_Schedule_TimeTable.ScheduleDate,105),'-','/') as \"ScheduleDate\" " +
                                 ",jos_railway_loco_type_schedule.id_loco_sch as \"ScheduleId\" " +
                                 "FROM jos_railway_loco_Schedule_TimeTable " +
                                 "INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = jos_railway_loco_Schedule_TimeTable.Loco_Id " +
                                 "INNER JOIN jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = jos_railway_loco_Schedule_TimeTable.Schedule_Id " +
                                 "INNER JOIN jos_railway_loco_type ON  jos_railway_loco_type.id_ltype = jos_railway_mst_loco.tid " +
                //"WHERE jos_railway_loco_Schedule_TimeTable.ScheduleDate between GETDATE() AND  Dateadd(MM,1,GETDATE()) AND jos_railway_loco_type.guage='METER GUAGE' order by jos_railway_loco_Schedule_TimeTable.ScheduleDate asc", cnn);
                                 "WHERE MONTH(jos_railway_loco_Schedule_TimeTable.ScheduleDate)= MONTH(GETDATE()) AND YEAR(jos_railway_loco_Schedule_TimeTable.ScheduleDate)= YEAR(GETDATE()) AND jos_railway_loco_type.guage='BROAD GUAGE' AND jos_railway_loco_type_schedule.s_type !='O1' AND jos_railway_loco_Schedule_TimeTable.ScheduleDate < CONVERT(VARCHAR(10),GETDATE(),101) order by jos_railway_loco_Schedule_TimeTable.ScheduleDate asc", cnn);
            //"WHERE jos_railway_loco_Schedule_TimeTable.ScheduleDate between CONVERT(VARCHAR(10),GETDATE(),101) AND CONVERT(VARCHAR(10),DATEADD(MM,1,GETDATE()),101) AND jos_railway_loco_type.guage='BROAD GUAGE' order by jos_railway_loco_Schedule_TimeTable.ScheduleDate asc", cnn);
            da = new SqlDataAdapter();
            dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        public DataTable Get_ScheduleArisingForMonthFORO1FromCurrentDate()
        {
            //this function return all schedule arrising in current 1 month except 'O1' 
            cmd = new SqlCommand("SELECT " +
                                 "jos_railway_mst_loco.id_mst_loco as \"locoid\" " +
                                 ",jos_railway_loco_Schedule_TimeTable.id_loco_Schedule as \"id\"" +
                                 ",jos_railway_mst_loco.locono as \"Locono\" " +
                                 ",jos_railway_loco_type_schedule.s_type as \"Schedule\" " +
                                 ",REPLACE(CONVERT(VARCHAR(10),jos_railway_loco_Schedule_TimeTable.ScheduleDate,105),'-','/') as \"ScheduleDate\" " +
                                 ",jos_railway_loco_type_schedule.id_loco_sch as \"ScheduleId\" " +
                                 "FROM jos_railway_loco_Schedule_TimeTable " +
                                 "INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = jos_railway_loco_Schedule_TimeTable.Loco_Id " +
                                 "INNER JOIN jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = jos_railway_loco_Schedule_TimeTable.Schedule_Id " +
                                 "INNER JOIN jos_railway_loco_type ON  jos_railway_loco_type.id_ltype = jos_railway_mst_loco.tid " +
                //"WHERE jos_railway_loco_Schedule_TimeTable.ScheduleDate between GETDATE() AND  Dateadd(MM,1,GETDATE()) AND jos_railway_loco_type.guage='METER GUAGE' order by jos_railway_loco_Schedule_TimeTable.ScheduleDate asc", cnn);
                                 "WHERE MONTH(jos_railway_loco_Schedule_TimeTable.ScheduleDate)= MONTH(GETDATE()) AND YEAR(jos_railway_loco_Schedule_TimeTable.ScheduleDate)= YEAR(GETDATE()) AND jos_railway_loco_type.guage='BROAD GUAGE' AND jos_railway_loco_type_schedule.s_type ='O1' AND jos_railway_loco_Schedule_TimeTable.ScheduleDate >= CONVERT(VARCHAR(10),GETDATE(),101) order by jos_railway_loco_Schedule_TimeTable.ScheduleDate asc", cnn);
            //"WHERE jos_railway_loco_Schedule_TimeTable.ScheduleDate between CONVERT(VARCHAR(10),GETDATE(),101) AND CONVERT(VARCHAR(10),DATEADD(MM,1,GETDATE()),101) AND jos_railway_loco_type.guage='BROAD GUAGE' order by jos_railway_loco_Schedule_TimeTable.ScheduleDate asc", cnn);
            da = new SqlDataAdapter();
            dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        public DataTable Get_ScheduleArisingForMonthFORO1BeforeCurrentDate()
        {
            //this function return all schedule arrising in current 1 month except 'O1' 
            cmd = new SqlCommand("SELECT " +
                                 "jos_railway_mst_loco.id_mst_loco as \"locoid\" " +
                                 ",jos_railway_loco_Schedule_TimeTable.id_loco_Schedule as \"id\"" +
                                 ",jos_railway_mst_loco.locono as \"Locono\" " +
                                 ",jos_railway_loco_type_schedule.s_type as \"Schedule\" " +
                                 ",REPLACE(CONVERT(VARCHAR(10),jos_railway_loco_Schedule_TimeTable.ScheduleDate,105),'-','/') as \"ScheduleDate\" " +
                                 ",jos_railway_loco_type_schedule.id_loco_sch as \"ScheduleId\" " +
                                 "FROM jos_railway_loco_Schedule_TimeTable " +
                                 "INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = jos_railway_loco_Schedule_TimeTable.Loco_Id " +
                                 "INNER JOIN jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = jos_railway_loco_Schedule_TimeTable.Schedule_Id " +
                                 "INNER JOIN jos_railway_loco_type ON  jos_railway_loco_type.id_ltype = jos_railway_mst_loco.tid " +
                //"WHERE jos_railway_loco_Schedule_TimeTable.ScheduleDate between GETDATE() AND  Dateadd(MM,1,GETDATE()) AND jos_railway_loco_type.guage='METER GUAGE' order by jos_railway_loco_Schedule_TimeTable.ScheduleDate asc", cnn);
                                 "WHERE MONTH(jos_railway_loco_Schedule_TimeTable.ScheduleDate)= MONTH(GETDATE()) AND YEAR(jos_railway_loco_Schedule_TimeTable.ScheduleDate)= YEAR(GETDATE()) AND jos_railway_loco_type.guage='BROAD GUAGE' AND jos_railway_loco_type_schedule.s_type ='O1' AND jos_railway_loco_Schedule_TimeTable.ScheduleDate < CONVERT(VARCHAR(10),GETDATE(),101) order by jos_railway_loco_Schedule_TimeTable.ScheduleDate asc", cnn);
            //"WHERE jos_railway_loco_Schedule_TimeTable.ScheduleDate between CONVERT(VARCHAR(10),GETDATE(),101) AND CONVERT(VARCHAR(10),DATEADD(MM,1,GETDATE()),101) AND jos_railway_loco_type.guage='BROAD GUAGE' order by jos_railway_loco_Schedule_TimeTable.ScheduleDate asc", cnn);
            da = new SqlDataAdapter();
            dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        public DataTable Get_ScheduleArisingForMonthByIdFORO1(string Ids)
        {
            //this function return all schedule arrising in current 1 month except 'O1' 
            cmd = new SqlCommand("SELECT " +
                                 " jos_railway_mst_loco.id_mst_loco as \"locoid\" " +
                                 ",jos_railway_loco_Schedule_TimeTable.id_loco_Schedule as \"id\"" +
                                 ",jos_railway_mst_loco.locono as \"Locono\" " +
                                 ",jos_railway_loco_type_schedule.s_type as \"Schedule\" " +
                                 ",REPLACE(CONVERT(VARCHAR(10),jos_railway_loco_Schedule_TimeTable.ScheduleDate,105),'-','/') as \"ScheduleDate\" " +
                                 ",jos_railway_loco_type_schedule.id_loco_sch as \"ScheduleId\" " +
                                 " FROM jos_railway_loco_Schedule_TimeTable " +
                                 " INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = jos_railway_loco_Schedule_TimeTable.Loco_Id " +
                                 " INNER JOIN jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = jos_railway_loco_Schedule_TimeTable.Schedule_Id " +
                                 " WHERE jos_railway_loco_Schedule_TimeTable.id_loco_Schedule IN (" + Ids + ") AND jos_railway_loco_type_schedule.s_type = 'O1' order by jos_railway_loco_Schedule_TimeTable.ScheduleDate asc", cnn);
            da = new SqlDataAdapter();
            dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        public DataTable MG_Get_ScheduleArisingForMonth()
        {
            cmd = new SqlCommand("SELECT " +
                                "jos_railway_mst_loco.id_mst_loco as  \"locoid\"  " +
                                ",jos_railway_loco_Schedule_TimeTable.id_loco_Schedule as  \"id\" " +
                                ",jos_railway_mst_loco.locono as  \"Locono\"  " +
                                ",jos_railway_loco_type_schedule.s_type as  \"Schedule\"  " +
                                ",CONVERT(VARCHAR(10),jos_railway_loco_Schedule_TimeTable.ScheduleDate,105) as  \"ScheduleDate\"  " +
                                ",jos_railway_loco_type_schedule.id_loco_sch as  \"ScheduleId\"  " +
                                "FROM jos_railway_loco_Schedule_TimeTable  " +
                                "INNER JOIN jos_railway_mst_loco ON jos_railway_mst_loco.id_mst_loco = jos_railway_loco_Schedule_TimeTable.Loco_Id " +
                                "INNER JOIN jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = jos_railway_loco_Schedule_TimeTable.Schedule_Id " +
                                "INNER JOIN jos_railway_loco_type ON  jos_railway_loco_type.id_ltype = jos_railway_mst_loco.tid  " +
                                "WHERE jos_railway_loco_Schedule_TimeTable.ScheduleDate between CONVERT(VARCHAR(10),GETDATE(),101) AND CONVERT(VARCHAR(10),DATEADD(MM,1,GETDATE()),101) AND jos_railway_loco_type.guage='METER GUAGE' order by jos_railway_loco_Schedule_TimeTable.ScheduleDate asc", cnn);
            da = new SqlDataAdapter();
            dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        public DataTable Get_ScheduleInCurrentLoco_Schedule(string locoid, string Master)
        {
            cmd = new SqlCommand("SELECT jos_railway_loco_type_schedule.id_loco_sch,jos_railway_loco_type_schedule.s_type FROM jos_railway_Loco_Schedule_TimeTable INNER JOIN jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = jos_railway_Loco_Schedule_TimeTable.Schedule_Id WHERE jos_railway_Loco_Schedule_TimeTable.Loco_Id=@Loco_Id AND Id_Master=@Id_Master", cnn);
            cmd.Parameters.AddWithValue("@Id_Master", Master);
            cmd.Parameters.AddWithValue("@Loco_Id", locoid);
            da = new SqlDataAdapter();
            dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            da.SelectCommand = cmd;
            return dt;
        }
        public DataTable Get_LoconoInCurrentLocoSchedule()
        {
            cmd = new SqlCommand("SELECT DISTINCT jos_railway_mst_loco.id_mst_loco,jos_railway_mst_loco.locono FROM jos_railway_loco_Schedule_TimeTable INNER JOIN jos_railway_mst_loco ON jos_railway_loco_Schedule_TimeTable.Loco_Id = jos_railway_mst_loco.id_mst_loco WHERE jos_railway_Loco_Schedule_TimeTable.Id_Master=@Id_Master", cnn);
            cmd.Parameters.AddWithValue("@Id_Master", this.Id_Master);
            da = new SqlDataAdapter();
            dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            da.SelectCommand = cmd;
            return dt;
        }
        public DataTable Select_DataById()
        {
            cmd = new SqlCommand("SELECT REPLACE(CONVERT(VARCHAR(10),ScheduleDate,105),'-','/')as ScheduleDate FROM jos_railway_Loco_Schedule_TimeTable WHERE Id_Master=@Id_Master AND Loco_Id=@Loco_Id", cnn);
            cmd.Parameters.AddWithValue("@Id_Master", this.Id_Master);
            cmd.Parameters.AddWithValue("@Loco_Id", this.Loco_Id);
            da = new SqlDataAdapter();
            dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            da.SelectCommand = cmd;
            return dt;
        }
    }
}
