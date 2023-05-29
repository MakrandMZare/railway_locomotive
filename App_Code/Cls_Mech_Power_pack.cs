using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using Railway;

/// <summary>
/// Summary description for Cls_Mech_Power_pack
/// </summary>
public class Cls_Mech_Power_pack : Cls_DBConnection
{
    public Cls_Mech_Power_pack()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public string id_power_pack,id_mst_loco, id_hr_tech, date1, id_hr_super, id_loco_sch, w_start, w_end, idle1, i11, i12, i13, i14, i15, i16, i17, i18, lt2_1, idle2, i21, i22, i23, i24, i25, i26, i27, i28, lt2_2, idle3, i31, i32, i33, i34, i35, i36, i37, i38, lt2_3, idle4, i41, i42, i43, i44, i45, i46, i47, i48, lt2_4, idle5, i51, i52, i53, i54, i55, i56, i57, i58, lt2_5, idle6, i61, i62, i63, i64, i65, i66, i67, i68, lt2_6, idle7, i71, i72, i73, i74, i75, i76, i77, i78, lt2_7, idle8, i81, i82, i83, i84, i85, i86, i87, i88, lt2_8, idle9, i91, i92, i93, i94, i95, i96, i97, i98, lt2_9, idle10, i101, i102, i103, i104, i105, i106, i107, i108, lt2_10, idle11, i111, i112, i113, i114, i115, i116, i117, i118, lt2_11, idle12, i121, i122, i123, i124, i125, i126, i127, i128, lt2_12, s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, l1, l2, l3, l4, l5, l6, l7, l8, l9, l10, l11, l12, l13, l14, l15, l16, l17;
    //INSERT INTO sch_mech_power_pack     (id_mst_loco, id_hr_tech, id_hr_super, id_loco_sch, w_start, w_end, idle1, i11, i12, i13, i14, i15, i16, i17, i18, lt2_1, idle2, i21, i22, i23, i24, i25, i26, i27,                       i28, lt2_2, idle3, i31, i32, i33, i34, i35, i36, i37, i38, lt2_3, idle4, i41, i42, i43, i44, i45, i46, i47, i48, lt2_4, idle5, i51, i52, i53, i54, i55, i56, i57, i58, lt2_5,                       idle6, i61, i62, i63, i64, i65, i66, i67, i68, lt2_6, idle7, i71, i72, i73, i74, i75, i76, i77, i78, lt2_7, idle8, i81, i82, i83, i84, i85, i86, i87, i88, lt2_8, idle9, i91,                       i92, i93, i94, i95, i96, i97, i98, lt2_9, idle10, i101, i102, i103, i104, i105, i106, i107, i108, lt2_10, idle11, i111, i112, i113, i114, i115, i116, i117, i118,                       lt2_11, idle12, i121, i122, i123, i124, i125, i126, i127, i128, lt2_12, s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, l1, l2,                       l3, l4, l5, l6, l7, l8, l9, l10, l11, l12, l13, l14, l15, l16, l17)VALUES  (@id_mst_loco, @id_hr_tech, @id_hr_super, @id_loco_sch, @w_start, @w_end, @idle1, @i11, @i12, @i13, @i14, @i15, @i16, @i17, @i18, @lt2_1, @idle2, @i21, @i22, @i23, @i24, @i25, @i26, @i27,                       @i28, @lt2_2, @idle3, @i31, @i32, @i33, @i34, @i35, @i36, @i37, @i38, @lt2_3, @idle4, @i41, @i42, @i43, @i44, @i45, @i46, @i47, @i48, @lt2_4, @idle5, @i51, @i52, @i53, @i54, @i55, @i56, @i57, @i58, @lt2_5,                       @idle6, @i61, @i62, @i63, @i64, @i65, @i66, @i67, @i68, @lt2_6, @idle7, @i71, @i72, @i73, @i74, @i75, @i76, @i77, @i78, @lt2_7, @idle8, @i81, @i82, @i83, @i84, @i85, @i86, @i87, @i88, @lt2_8, @idle9, @i91,                       @i92, @i93, @i94, @i95, @i96, @i97, @i98, @lt2_9, @idle10, @i101, @i102, @i103, @i104, @i105, @i106, @i107, @i108, @lt2_10, @idle11, @i111, @i112, @i113, @i114, @i115, @i116, @i117, @i118,                       @lt2_11, @idle12, @i121, @i122, @i123, @i124, @i125, @i126, @i127, @i128, @lt2_12, @s1, @s2, @s3, @s4, @s5, @s6, @s7, @s8, @s9, @s10, @a1, @a2, @a3, @a4, @a5, @a6, @a7, @a8, @a9, @a10, @l1, @l2,                       @l3, @l4, @l5, @l6, @l7, @l8, @l9, @l10, @l11, @l12, @l13, @l14, @l15, @l16, @l17)

    // public Int64 Insert_Data()
    //{
    //    try
    //    {
    //        cmd = new SqlCommand("INSERT INTO Loco_CompressorOil(Id_Loco,Loco_Date,Id_Schedule,WaterContent,FalshPoint,Viscosity,Result_Remarks,Tested_By) VALUES(@Id_Loco,@Loco_Date,@Id_Schedule,@WaterContent,@FalshPoint,@Viscosity,@Result_Remarks,@Tested_By)", cnn);
    //        cmd.Parameters.AddWithValue("@FalshPoint", this.FalshPoint);
    //        cmd.Parameters.AddWithValue("@Id_Loco", this.Id_Loco);
    //        cmd.Parameters.AddWithValue("@Id_Schedule", this.Id_Schedule);
    //        cmd.Parameters.AddWithValue("@Loco_Date", this.Loco_Date);
    //        cmd.Parameters.AddWithValue("@Result_Remarks", this.Result_Remarks);
    //        cmd.Parameters.AddWithValue("@Tested_By", this.Tested_By);
    //        cmd.Parameters.AddWithValue("@Viscosity", this.Viscosity);
    //        cmd.Parameters.AddWithValue("@WaterContent", this.WaterContent);
    //        cmd.Connection.Open();
    //        Int16 n = Convert.ToInt16(cmd.ExecuteNonQuery());
    //        cmd.Connection.Close();
    //        if (n == 1)
    //        {
    //            cmd = new SqlCommand("SELECT MAX(Id_CompressorOil) FROM  Loco_CompressorOil", cnn);
    //            cmd.Connection.Open();
    //            Int64 m = Convert.ToInt64(cmd.ExecuteNonQuery());
    //            cmd.Connection.Close();
    //            return m;
    //        }
    //        else
    //        {
    //            return 0;
    //        }
    //    }
    //    catch { throw; }
    //}
    public Int64 Insert_Data()
    {
        try
        {
            cmd = new SqlCommand("INSERT INTO sch_mech_power_pack(id_mst_loco, id_hr_tech, id_hr_super, id_loco_sch, date1, w_start, w_end, idle1, i11, i12, i13, i14, i15, i16, i17, i18, lt2_1, idle2, i21, i22, i23, i24, i25, i26, i27, i28, lt2_2, idle3, i31, i32, i33, i34, i35, i36, i37, i38, lt2_3, idle4, i41, i42, i43, i44, i45, i46, i47, i48, lt2_4, idle5, i51, i52, i53, i54, i55, i56, i57, i58, lt2_5, idle6, i61, i62, i63, i64, i65, i66, i67, i68, lt2_6, idle7, i71, i72, i73, i74, i75, i76, i77, i78, lt2_7, idle8, i81, i82, i83, i84, i85, i86, i87, i88, lt2_8, idle9, i91, i92, i93, i94, i95, i96, i97, i98, lt2_9, idle10, i101, i102, i103, i104, i105, i106, i107, i108, lt2_10, idle11, i111, i112, i113, i114, i115, i116, i117, i118, lt2_11, idle12, i121, i122, i123, i124, i125, i126, i127, i128, lt2_12, s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, l1, l2, l3, l4, l5, l6, l7, l8, l9, l10, l11, l12, l13, l14, l15, l16, l17)VALUES    (@id_mst_loco, @id_hr_tech, @id_hr_super, @id_loco_sch, @date1, @w_start, @w_end, @idle1, @i11, @i12, @i13, @i14, @i15, @i16, @i17, @i18, @lt2_1, @idle2, @i21, @i22, @i23, @i24, @i25, @i26, @i27, @i28, @lt2_2, @idle3, @i31, @i32, @i33, @i34, @i35, @i36, @i37, @i38, @lt2_3, @idle4, @i41, @i42, @i43, @i44, @i45, @i46, @i47, @i48, @lt2_4, @idle5, @i51, @i52, @i53, @i54, @i55, @i56, @i57, @i58, @lt2_5, @idle6, @i61, @i62, @i63, @i64, @i65, @i66, @i67, @i68, @lt2_6, @idle7, @i71, @i72, @i73, @i74, @i75, @i76, @i77, @i78, @lt2_7, @idle8, @i81, @i82, @i83, @i84, @i85, @i86, @i87, @i88, @lt2_8, @idle9, @i91, @i92, @i93, @i94, @i95, @i96, @i97, @i98, @lt2_9, @idle10, @i101, @i102, @i103, @i104, @i105, @i106, @i107, @i108, @lt2_10, @idle11, @i111, @i112, @i113, @i114, @i115, @i116, @i117, @i118, @lt2_11, @idle12, @i121, @i122, @i123, @i124, @i125, @i126, @i127, @i128, @lt2_12, @s1, @s2, @s3,@2s42, @s5, @s6, @s7, @s8, @s9, @s10, @a1, @a2, @a3, @a4, @a5, @a6, @a7, @a8, @a9, @a10, @l1, @l2, @l3, @l4, @l5, @l6, @l7, @l8, @l9, @l10, @l11, @l12, @l13, @l14, @l15, @l16, @l17)");
            cmd.Parameters.AddWithValue("@id_mst_loco",this.id_mst_loco);
            cmd.Parameters.AddWithValue("@id_hr_tech",this.id_hr_tech);
            cmd.Parameters.AddWithValue("@id_hr_super",this.id_hr_super);
            cmd.Parameters.AddWithValue("@id_loco_sch",this.id_loco_sch);
            cmd.Parameters.AddWithValue("@date1", this.date1);
            cmd.Parameters.AddWithValue("@w_start",this.w_start);
            cmd.Parameters.AddWithValue("@w_end",this.w_end);
            cmd.Parameters.AddWithValue("@idle1",this.idle1);
            cmd.Parameters.AddWithValue("@i11",this.i11);
            cmd.Parameters.AddWithValue("@i12",this.i12);
            cmd.Parameters.AddWithValue("@i13",this.i13);
            cmd.Parameters.AddWithValue("@i14",this.i14);
            cmd.Parameters.AddWithValue("@i15",this.i15);
            cmd.Parameters.AddWithValue("@i16",this.i16);
            cmd.Parameters.AddWithValue("@i17",this.i17);
            cmd.Parameters.AddWithValue("@i18",this.i18);
            cmd.Parameters.AddWithValue("@lt2_1",this.lt2_1);
            cmd.Parameters.AddWithValue("@idle2",this.idle2);
            cmd.Parameters.AddWithValue("@i21",this.i21);
            cmd.Parameters.AddWithValue("@i22",this.i22);
            cmd.Parameters.AddWithValue("@i23",this.i23);
            cmd.Parameters.AddWithValue("@i24",this.i24);
            cmd.Parameters.AddWithValue("@i25",this.i25);
            cmd.Parameters.AddWithValue("@i26",this.i26);
            cmd.Parameters.AddWithValue("@i27",this.i27);
            cmd.Parameters.AddWithValue("@i28",this.i28);
            cmd.Parameters.AddWithValue("@lt2_2",this.lt2_2);
            cmd.Parameters.AddWithValue("@idle3",this.idle3);
            cmd.Parameters.AddWithValue("@i31",this.i31);
            cmd.Parameters.AddWithValue("@i32",this.i32);
            cmd.Parameters.AddWithValue("@i33",this.i33);
            cmd.Parameters.AddWithValue("@i34",this.i34);
            cmd.Parameters.AddWithValue("@i35",this.i35);
            cmd.Parameters.AddWithValue("@i36",this.i36);
            cmd.Parameters.AddWithValue("@i37",this.i37);
            cmd.Parameters.AddWithValue("@i38",this.i38);
            cmd.Parameters.AddWithValue("@lt2_3",this.lt2_3);
            cmd.Parameters.AddWithValue("@idle4",this.idle4);
            cmd.Parameters.AddWithValue("@i41",this.i41);
            cmd.Parameters.AddWithValue("@i42",this.i42);
            cmd.Parameters.AddWithValue("@i43",this.i43);
            cmd.Parameters.AddWithValue("@i44",this.i44);
            cmd.Parameters.AddWithValue("@i45",this.i45);
            cmd.Parameters.AddWithValue("@i46",this.i46);
            cmd.Parameters.AddWithValue("@i47",this.i47);
            cmd.Parameters.AddWithValue("@i48",this.i48);
            cmd.Parameters.AddWithValue("@lt2_4",this.lt2_4);
            cmd.Parameters.AddWithValue("@idle5",this.idle5);
            cmd.Parameters.AddWithValue("@i51",this.i51);
            cmd.Parameters.AddWithValue("@i52",this.i52);
            cmd.Parameters.AddWithValue("@i53",this.i53);
            cmd.Parameters.AddWithValue("@i54",this.i54);
            cmd.Parameters.AddWithValue("@i55",this.i55);
            cmd.Parameters.AddWithValue("@i56",this.i56);
            cmd.Parameters.AddWithValue("@i57",this.i57);
            cmd.Parameters.AddWithValue("@i58",this.i58);
            cmd.Parameters.AddWithValue("@lt2_5",this.lt2_5);
            cmd.Parameters.AddWithValue("@idle6",this.idle6);
            cmd.Parameters.AddWithValue("@i61",this.i61);
            cmd.Parameters.AddWithValue("@i62",this.i62);
            cmd.Parameters.AddWithValue("@i63",this.i63);
            cmd.Parameters.AddWithValue("@i64",this.i64);
            cmd.Parameters.AddWithValue("@i65",this.i65);
            cmd.Parameters.AddWithValue("@i66",this.i66);
            cmd.Parameters.AddWithValue("@i67",this.i67);
            cmd.Parameters.AddWithValue("@i68",this.i68);
            cmd.Parameters.AddWithValue("@lt2_6",this.lt2_6);
            cmd.Parameters.AddWithValue("@idle7",this.idle7);
            cmd.Parameters.AddWithValue("@i71",this.i71);
            cmd.Parameters.AddWithValue("@i72",this.i72);
            cmd.Parameters.AddWithValue("@i73",this.i73);
            cmd.Parameters.AddWithValue("@i74",this.i74);
            cmd.Parameters.AddWithValue("@i75",this.i75);
            cmd.Parameters.AddWithValue("@i76",this.i76);
            cmd.Parameters.AddWithValue("@i77",this.i77);
            cmd.Parameters.AddWithValue("@i78",this.i78);
            cmd.Parameters.AddWithValue("@lt2_7",this.lt2_7);
            cmd.Parameters.AddWithValue("@idle8",this.idle8);
            cmd.Parameters.AddWithValue("@i81",this.i81);
            cmd.Parameters.AddWithValue("@i82",this.i82);
            cmd.Parameters.AddWithValue("@i83",this.i83);
            cmd.Parameters.AddWithValue("@i84",this.i84);
            cmd.Parameters.AddWithValue("@i85",this.i85);
            cmd.Parameters.AddWithValue("@i86",this.i86);
            cmd.Parameters.AddWithValue("@i87",this.i87);
            cmd.Parameters.AddWithValue("@i88",this.i88);
            cmd.Parameters.AddWithValue("@lt2_8",this.lt2_8);
            cmd.Parameters.AddWithValue("@idle9",this.idle9);
            cmd.Parameters.AddWithValue("@i91",this.i91);
            cmd.Parameters.AddWithValue("@i92",this.i92);
            cmd.Parameters.AddWithValue("@i93",this.i93);
            cmd.Parameters.AddWithValue("@i94",this.i94);
            cmd.Parameters.AddWithValue("@i95",this.i95);
            cmd.Parameters.AddWithValue("@i96",this.i96);
            cmd.Parameters.AddWithValue("@i97",this.i97);
            cmd.Parameters.AddWithValue("@i98",this.i98);
            cmd.Parameters.AddWithValue("@lt2_9",this.lt2_9);
            cmd.Parameters.AddWithValue("@idle10",this.idle10);
            cmd.Parameters.AddWithValue("@i101",this.i101);
            cmd.Parameters.AddWithValue("@i102",this.i102);
            cmd.Parameters.AddWithValue("@i103",this.i103);
            cmd.Parameters.AddWithValue("@i104",this.i104);
            cmd.Parameters.AddWithValue("@i105",this.i105);
            cmd.Parameters.AddWithValue("@i106",this.i106);
            cmd.Parameters.AddWithValue("@i107",this.i107);
            cmd.Parameters.AddWithValue("@i108",this.i108);
            cmd.Parameters.AddWithValue("@lt2_10",this.lt2_10);
            cmd.Parameters.AddWithValue("@idle11",this.idle11);
            cmd.Parameters.AddWithValue("@i111",this.i111);
            cmd.Parameters.AddWithValue("@i112",this.i112);
            cmd.Parameters.AddWithValue("@i113",this.i113);
            cmd.Parameters.AddWithValue("@i114",this.i114);
            cmd.Parameters.AddWithValue("@i115",this.i115);
            cmd.Parameters.AddWithValue("@i116",this.i116);
            cmd.Parameters.AddWithValue("@i117",this.i117);
            cmd.Parameters.AddWithValue("@i118",this.i118);
            cmd.Parameters.AddWithValue("@lt2_11",this.lt2_11);
            cmd.Parameters.AddWithValue("@idle12",this.idle12);
            cmd.Parameters.AddWithValue("@i121",this.i121);
            cmd.Parameters.AddWithValue("@i122",this.i122);
            cmd.Parameters.AddWithValue("@i123",this.i123);
            cmd.Parameters.AddWithValue("@i124",this.i124);
            cmd.Parameters.AddWithValue("@i125",this.i125);
            cmd.Parameters.AddWithValue("@i126",this.i126);
            cmd.Parameters.AddWithValue("@i127",this.i127);
            cmd.Parameters.AddWithValue("@i128",this.i128);
            cmd.Parameters.AddWithValue("@lt2_12",this.lt2_12);
            cmd.Parameters.AddWithValue("@s1",this.s1);
            cmd.Parameters.AddWithValue("@s2",this.s2);
            cmd.Parameters.AddWithValue("@s3",this.s3);
            cmd.Parameters.AddWithValue("@s4",this.s4);
            cmd.Parameters.AddWithValue("@s5",this.s5);
            cmd.Parameters.AddWithValue("@s6",this.s6);
            cmd.Parameters.AddWithValue("@s7",this.s7);
            cmd.Parameters.AddWithValue("@s8",this.s8);
            cmd.Parameters.AddWithValue("@s9",this.s9);
            cmd.Parameters.AddWithValue("@s10",this.s10);
            cmd.Parameters.AddWithValue("@a1",this.a1);
            cmd.Parameters.AddWithValue("@a2",this.a2);
            cmd.Parameters.AddWithValue("@a3",this.a3);
            cmd.Parameters.AddWithValue("@a4",this.a4);
            cmd.Parameters.AddWithValue("@a5",this.a5);
            cmd.Parameters.AddWithValue("@a6",this.a6);
            cmd.Parameters.AddWithValue("@a7",this.a7);
            cmd.Parameters.AddWithValue("@a8",this.a8);
            cmd.Parameters.AddWithValue("@a9",this.a9);
            cmd.Parameters.AddWithValue("@a10",this.a10);
            cmd.Parameters.AddWithValue("@l1",this.l1);
            cmd.Parameters.AddWithValue("@l2",this.l2);
            cmd.Parameters.AddWithValue("@l3",this.l3);
            cmd.Parameters.AddWithValue("@l4",this.l4);
            cmd.Parameters.AddWithValue("@l5",this.l5);
            cmd.Parameters.AddWithValue("@l6",this.l6);
            cmd.Parameters.AddWithValue("@l7",this.l7);
            cmd.Parameters.AddWithValue("@l8",this.l8);
            cmd.Parameters.AddWithValue("@l9",this.l9);
            cmd.Parameters.AddWithValue("@l10",this.l10);
            cmd.Parameters.AddWithValue("@l11",this.l11);
            cmd.Parameters.AddWithValue("@l12",this.l12);
            cmd.Parameters.AddWithValue("@l13",this.l13);
            cmd.Parameters.AddWithValue("@l14",this.l14);
            cmd.Parameters.AddWithValue("@l15",this.l15);
            cmd.Parameters.AddWithValue("@l16",this.l16);
            cmd.Parameters.AddWithValue("@l17",this.l17);
            cmd.Connection.Open();
            Int16 n = Convert.ToInt16(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            return n;
            if (n == 1)
            {
                cmd = new SqlCommand("SELECT MAX(id_power_pack) FROM sch_mech_power_pack", cnn);
                cmd.Connection.Open();
                Int64 m = Convert.ToInt64(cmd.ExecuteNonQuery());
                cmd.Connection.Close();
                return m;
            }
            else
            {
                return 0;
            }
        }

        catch
        {
            throw;
        }
    }
    public DataTable select_employee()
    {
        try
        {
            cmd = new SqlCommand("select * from jos_railway_Hr", cnn);

            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        catch { throw; }
    }
   }
