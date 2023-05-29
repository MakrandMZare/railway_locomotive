using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Railway;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Cls_Battery_section
/// </summary>
public class Cls_Battery_section : Cls_DBConnection
{
    public Cls_Battery_section()
    {
        //
        // TODO: Add constructor logic here
        //
    }


    // r20_25 is not in datatbase
    public string id_battery_section;
    public string id_loco_sch;
    public string id_mst_loco;
    public string date1;
    public string techni;
    public string wkstart;
    public string wkend;
    public string super;
    public string r8;
    public string r9;
    public string r10;
    public string r11;
    public string r12;
    public string r13;
    public string r14;
    public string r15;
    public string r16, r17, r18_11, r18_12, r18_13, r18_14, r18_15, r18_16, r18_17, r18_18, r18_19, r18_110, r18_21, r18_22, r18_23, r18_24, r18_25, r18_26, r18_27, r18_28, r18_29, r18_210, r18_31, r18_32, r18_33, r18_34, r18_35, r18_36, r18_37, r18_38, r18_39, r18_310, r18_41, r18_42, r18_43, r18_44, r18_45, r18_46, r18_47, r18_48, r18_49, r18_410, r18_51, r18_52, r18_53, r18_54, r18_55, r18_56, r18_57, r18_58, r18_59, r18_510, r19_11, r19_12, r19_13, r19_14, r19_15, r19_16, r19_17, r19_18, r19_19, r19_110, r19_21, r19_22, r19_23, r19_24, r19_25, r19_26, r19_27, r19_28, r19_29, r19_210, r19_31, r19_32, r19_33, r19_34, r19_35, r19_36, r19_37, r19_38, r19_39, r19_310, r19_41, r19_42, r19_43, r19_44, r19_45, r19_46, r19_47, r19_48, r19_49, r19_410, r19_51, r19_52, r19_53, r19_54, r19_55, r19_56, r19_57, r19_58, r19_59, r19_510, r20_11, r20_12, r20_13, r20_14, r20_15, r20_16, r20_17, r20_18, r20_19, r20_110, r20_21, r20_22, r20_23, r20_24, r20_26, r20_27, r20_28, r20_31, r20_33, r20_34, r20_35, r20_36, r20_37, r20_38, r20_39, r20_310, r20_41, r20_42, r20_43, r20_44, r20_45, r20_46, r20_47, r20_48, r20_49, r20_410, r20_51, r20_52, r20_53, r20_54, r20_55, r20_57, r20_58, r20_59, r20_510, r21_1, r21_2, r20_56, r20_29, r20_210, r20_25, r20_32;
     

    public Int64 Insert_data()
    {
        try
        {
            cmd = new SqlCommand("INSERT INTO bg_battery_section (id_loco_sch,id_mst_loco, date1, techni, wkstart, wkend, super, r8, r9, r10, r11, r12, r13, r14, r15, r16, r17, r18_11, r18_12, r18_13, r18_14, r18_15, r18_16, r18_17, r18_18, r18_19, r18_110, r18_21, r18_22, r18_23, r18_24, r18_25, r18_26, r18_27, r18_28, r18_29, r18_210, r18_31, r18_32, r18_33, r18_34, r18_35, r18_36, r18_37, r18_38, r18_39, r18_310, r18_41, r18_42, r18_43, r18_44, r18_45, r18_46, r18_47, r18_48, r18_49, r18_410, r18_51, r18_52, r18_53, r18_54, r18_55, r18_56, r18_57, r18_58, r18_59, r18_510, r19_11, r19_12, r19_13, r19_14, r19_15, r19_16, r19_17, r19_18, r19_19, r19_110, r19_21, r19_22, r19_23, r19_24, r19_25, r19_26, r19_27, r19_28, r19_29, r19_210, r19_31, r19_32, r19_33, r19_34, r19_35, r19_36, r19_37, r19_38, r19_39, r19_310, r19_41, r19_42, r19_43, r19_44, r19_45, r19_46, r19_47, r19_48, r19_49, r19_410, r19_51, r19_52, r19_53, r19_54, r19_55, r19_56, r19_57, r19_58, r19_59, r19_510, r20_11, r20_12, r20_13, r20_14, r20_15, r20_16, r20_17, r20_18, r20_19, r20_110, r20_21, r20_22, r20_23, r20_24, r20_26, r20_27, r20_28, r20_31, r20_33, r20_34, r20_35, r20_36, r20_37, r20_38, r20_39, r20_310, r20_41, r20_42, r20_43, r20_44, r20_45, r20_46, r20_47, r20_48, r20_49, r20_410, r20_51, r20_52, r20_53, r20_54, r20_55, r20_57, r20_58, r20_59, r20_510, r21_1, r21_2, r20_56, r20_29, r20_210, r20_25, r20_32) VALUES  (@id_loco_sch,@id_mst_loco, @date1, @techni, @wkstart, @wkend, @super, @r8, @r9, @r10, @r11, @r12, @r13, @r14, @r15, @r16, @r17, @r18_11, @r18_12, @r18_13, @r18_14, @r18_15, @r18_16, @r18_17, @r18_18, @r18_19, @r18_110, @r18_21, @r18_22, @r18_23, @r18_24, @r18_25, @r18_26, @r18_27, @r18_28, @r18_29, @r18_210, @r18_31, @r18_32, @r18_33, @r18_34, @r18_35, @r18_36, @r18_37, @r18_38, @r18_39, @r18_310, @r18_41, @r18_42, @r18_43, @r18_44, @r18_45, @r18_46, @r18_47, @r18_48, @r18_49, @r18_410, @r18_51, @r18_52, @r18_53, @r18_54, @r18_55, @r18_56, @r18_57, @r18_58, @r18_59, @r18_510, @r19_11, @r19_12, @r19_13, @r19_14, @r19_15, @r19_16, @r19_17, @r19_18, @r19_19, @r19_110, @r19_21, @r19_22, @r19_23, @r19_24, @r19_25, @r19_26, @r19_27, @r19_28, @r19_29, @r19_210, @r19_31, @r19_32, @r19_33, @r19_34, @r19_35, @r19_36, @r19_37, @r19_38, @r19_39, @r19_310, @r19_41, @r19_42, @r19_43, @r19_44, @r19_45, @r19_46, @r19_47, @r19_48, @r19_49, @r19_410, @r19_51, @r19_52, @r19_53, @r19_54, @r19_55, @r19_56, @r19_57, @r19_58, @r19_59, @r19_510, @r20_11, @r20_12, @r20_13, @r20_14, @r20_15, @r20_16, @r20_17, @r20_18, @r20_19, @r20_110, @r20_21, @r20_22, @r20_23, @r20_24, @r20_26, @r20_27, @r20_28, @r20_31, @r20_33, @r20_34, @r20_35, @r20_36, @r20_37, @r20_38, @r20_39, @r20_310, @r20_41, @r20_42, @r20_43, @r20_44, @r20_45, @r20_46, @r20_47, @r20_48, @r20_49, @r20_410, @r20_51, @r20_52, @r20_53, @r20_54, @r20_55, @r20_57, @r20_58, @r20_59, @r20_510, @r21_1, @r21_2, @r20_56, @r20_29, @r20_210, @r20_25, @r20_32)", cnn);
            cmd.Parameters.AddWithValue("@id_loco_sch", this.id_loco_sch);
            cmd.Parameters.AddWithValue("@id_mst_loco",this.id_mst_loco);
                  cmd.Parameters.AddWithValue("@date1",this.date1);
                  cmd.Parameters.AddWithValue("@techni",this.techni);
                  cmd.Parameters.AddWithValue("@wkstart",this.wkstart);
                  cmd.Parameters.AddWithValue("@wkend",this.wkend);
                  cmd.Parameters.AddWithValue("@super",this.super);
                  cmd.Parameters.AddWithValue("@r8",this.r8);
                  cmd.Parameters.AddWithValue("@r9",this.r9);
                  cmd.Parameters.AddWithValue("@r10",this.r10);
            cmd.Parameters.AddWithValue("@r11",this.r11);
                  cmd.Parameters.AddWithValue("@r12",this.r12);
                  cmd.Parameters.AddWithValue("@r13",this.r13);
                  cmd.Parameters.AddWithValue("@r14",this.r14);
                  cmd.Parameters.AddWithValue("@r15",this.r15);
                  cmd.Parameters.AddWithValue("@r16",this.r16);
                  cmd.Parameters.AddWithValue("@r17",this.r17);
                  cmd.Parameters.AddWithValue("@r18_11",this.r18_11);
                  cmd.Parameters.AddWithValue("@r18_12",this.r18_12);
            cmd.Parameters.AddWithValue("@r18_13",this.r18_13);
                  cmd.Parameters.AddWithValue("@r18_14",this.r18_14);
                  cmd.Parameters.AddWithValue("@r18_15",this.r18_15);
                  cmd.Parameters.AddWithValue("@r18_16",this.r18_16);
                  cmd.Parameters.AddWithValue("@r18_17",this.r18_17);
                  cmd.Parameters.AddWithValue("@r18_18",this.r18_18);
                  cmd.Parameters.AddWithValue("@r18_19",this.r18_19);
                  cmd.Parameters.AddWithValue("@r18_110",this.r18_110);
                  cmd.Parameters.AddWithValue("@r18_21",this.r18_21);
            cmd.Parameters.AddWithValue("@r18_22",this.r18_22);
                  cmd.Parameters.AddWithValue("@r18_23",this.r18_23);
                
                  cmd.Parameters.AddWithValue("@r18_24",this.r18_24);
                  cmd.Parameters.AddWithValue("@r18_25",this.r18_25);
                  cmd.Parameters.AddWithValue("@r18_26",this.r18_26);
                  cmd.Parameters.AddWithValue("@r18_27",this.r18_27);
                  cmd.Parameters.AddWithValue("@r18_28",this.r18_28);
                  cmd.Parameters.AddWithValue("@r18_29",this.r18_29);
            cmd.Parameters.AddWithValue("@r18_210",this.r18_210);
                  cmd.Parameters.AddWithValue("@r18_31",this.r18_31);
                  cmd.Parameters.AddWithValue("@r18_32",this.r18_32);
                  cmd.Parameters.AddWithValue("@r18_33",this.r18_33);
                  cmd.Parameters.AddWithValue("@r18_34",this.r18_34);
                  cmd.Parameters.AddWithValue("@r18_35",this.r18_35);
                  cmd.Parameters.AddWithValue("@r18_36",this.r18_36);
                  cmd.Parameters.AddWithValue("@r18_37",this.r18_37);
                  cmd.Parameters.AddWithValue("@r18_38",this.r18_38);

            cmd.Parameters.AddWithValue("@r18_39",this.r18_39);
                  cmd.Parameters.AddWithValue("@r18_310",this.r18_310);
                  cmd.Parameters.AddWithValue("@r18_41",this.r18_41);
                  cmd.Parameters.AddWithValue("@r18_42",this.r18_42);
                  cmd.Parameters.AddWithValue("@r18_43",this.r18_43);
                  cmd.Parameters.AddWithValue("@r18_44",this.r18_44);
                  cmd.Parameters.AddWithValue("@r18_45",this.r18_45);
                  cmd.Parameters.AddWithValue("@r18_46",this.r18_46);
                  cmd.Parameters.AddWithValue("@r18_47",this.r18_47);
            cmd.Parameters.AddWithValue("@r18_48",this.r18_48);
                  cmd.Parameters.AddWithValue("@r18_49",this.r18_49);
                  cmd.Parameters.AddWithValue("@r18_410",this.r18_410);
                  cmd.Parameters.AddWithValue("@r18_51",this.r18_51);
                  cmd.Parameters.AddWithValue("@r18_52",this.r18_52);
                  cmd.Parameters.AddWithValue("@r18_53",this.r18_53);
                  cmd.Parameters.AddWithValue("@r18_54",this.r18_54);
                  cmd.Parameters.AddWithValue("@r18_55",this.r18_55);
                  cmd.Parameters.AddWithValue("@r18_56",this.r18_56);
            cmd.Parameters.AddWithValue("@r18_57",this.r18_57);
                  cmd.Parameters.AddWithValue("@r18_58",this.r18_58);
                  cmd.Parameters.AddWithValue("@r18_59",this.r18_59);
                  cmd.Parameters.AddWithValue("@r18_510",this.r18_510);
                  cmd.Parameters.AddWithValue("@r19_11",this.r19_11);
                  cmd.Parameters.AddWithValue("@r19_12",this.r19_12);
                  cmd.Parameters.AddWithValue("@r19_13",this.r19_13);
                  cmd.Parameters.AddWithValue("@r19_14",this.r19_14);
                  cmd.Parameters.AddWithValue("@r19_15",this.r19_15);
            cmd.Parameters.AddWithValue("@r19_16",this.r19_16);
                  cmd.Parameters.AddWithValue("@r19_17",this.r19_17);
                  cmd.Parameters.AddWithValue("@r19_18",this.r19_18);
                  cmd.Parameters.AddWithValue("@r19_19",this.r19_19);
                  cmd.Parameters.AddWithValue("@r19_110",this.r19_110);
                  cmd.Parameters.AddWithValue("@r19_21",this.r19_21);
                  cmd.Parameters.AddWithValue("@r19_22",this.r19_22);
                  cmd.Parameters.AddWithValue("@r19_23",this.r19_23);
                  cmd.Parameters.AddWithValue("@r19_24",this.r19_24);
            cmd.Parameters.AddWithValue("@r19_25",this.r19_25);
                  cmd.Parameters.AddWithValue("@r19_26",this.r19_26);
                  cmd.Parameters.AddWithValue("@r19_27",this.r19_27);
                  cmd.Parameters.AddWithValue("@r19_28",this.r19_28);
                  cmd.Parameters.AddWithValue("@r19_29",this.r19_29);
                  cmd.Parameters.AddWithValue("@r19_210",this.r19_210);
                  cmd.Parameters.AddWithValue("@r19_31",this.r19_31);
                  cmd.Parameters.AddWithValue("@r19_32",this.r19_32);
                  cmd.Parameters.AddWithValue("@r19_33",this.r19_33);

            cmd.Parameters.AddWithValue("@r19_34",this.r19_34);
                  cmd.Parameters.AddWithValue("@r19_35",this.r19_35);
                  cmd.Parameters.AddWithValue("@r19_36",this.r19_36);
                  cmd.Parameters.AddWithValue("@r19_37",this.r19_37);
                  cmd.Parameters.AddWithValue("@r19_38",this.r19_38);
                  cmd.Parameters.AddWithValue("@r19_39",this.r19_39);
                  cmd.Parameters.AddWithValue("@r19_310",this.r19_310);
                  cmd.Parameters.AddWithValue("@r19_41",this.r19_41);
                  cmd.Parameters.AddWithValue("@r19_42",this.r19_42);
            cmd.Parameters.AddWithValue("@r19_43",this.r19_43);
                  cmd.Parameters.AddWithValue("@r19_44",this.r19_44);
                  cmd.Parameters.AddWithValue("@r19_45",this.r19_45);
                  cmd.Parameters.AddWithValue("@r19_46",this.r19_46);
                  cmd.Parameters.AddWithValue("@r19_47",this.r19_47);
                  cmd.Parameters.AddWithValue("@r19_48",this.r19_48);
                  cmd.Parameters.AddWithValue("@r19_49",this.r19_49);
                  cmd.Parameters.AddWithValue("@r19_410",this.r19_410);
                  cmd.Parameters.AddWithValue("@r19_51",this.r19_51);
            cmd.Parameters.AddWithValue("@r19_52",this.r19_52);
                  cmd.Parameters.AddWithValue("@r19_53",this.r19_53);
                  cmd.Parameters.AddWithValue("@r19_54",this.r19_54);
                  cmd.Parameters.AddWithValue("@r19_55",this.r19_55);
                  cmd.Parameters.AddWithValue("@r19_56",this.r19_56);
                  cmd.Parameters.AddWithValue("@r19_57",this.r19_57);
                  cmd.Parameters.AddWithValue("@r19_58",this.r19_58);
                  cmd.Parameters.AddWithValue("@r19_59",this.r19_59);
                  cmd.Parameters.AddWithValue("@r19_510",this.r19_510);
            cmd.Parameters.AddWithValue("@r20_11",this.r20_11);
                  cmd.Parameters.AddWithValue("@r20_12",this.r20_12);
                  cmd.Parameters.AddWithValue("@r20_13",this.r20_13);
                  cmd.Parameters.AddWithValue("@r20_14",this.r20_14);
                  cmd.Parameters.AddWithValue("@r20_15",this.r20_15);
                  cmd.Parameters.AddWithValue("@r20_16",this.r20_16);
                  cmd.Parameters.AddWithValue("@r20_17",this.r20_17);
                  cmd.Parameters.AddWithValue("@r20_18",this.r20_18);
                  cmd.Parameters.AddWithValue("@r20_19",this.r20_19);
            cmd.Parameters.AddWithValue("@r20_110",this.r20_110);
                  cmd.Parameters.AddWithValue("@r20_21",this.r20_21);
                  cmd.Parameters.AddWithValue("@r20_22",this.r20_22);
                  cmd.Parameters.AddWithValue("@r20_23",this.r20_23);
                  cmd.Parameters.AddWithValue("@r20_24",this.r20_24);

      
                  cmd.Parameters.AddWithValue("@r20_26",this.r20_26);
                  cmd.Parameters.AddWithValue("@r20_27",this.r20_27);
                  cmd.Parameters.AddWithValue("@r20_28",this.r20_28);
   
                  cmd.Parameters.AddWithValue("@r20_31",this.r20_31);
             cmd.Parameters.AddWithValue("@r20_33",this.r20_33);
                  cmd.Parameters.AddWithValue("@r20_34",this.r20_34);
                  cmd.Parameters.AddWithValue("@r20_35",this.r20_35);
                  cmd.Parameters.AddWithValue("@r20_36",this.r20_36);
                  cmd.Parameters.AddWithValue("@r20_37",this.r20_37);
                  cmd.Parameters.AddWithValue("@r20_38",this.r20_38);
             cmd.Parameters.AddWithValue("@r20_39",this.r20_39);
                  cmd.Parameters.AddWithValue("@r20_310",this.r20_310);
                  cmd.Parameters.AddWithValue("@r20_41",this.r20_41);
                  cmd.Parameters.AddWithValue("@r20_42",this.r20_42);
                  cmd.Parameters.AddWithValue("@r20_43",this.r20_43);
                  cmd.Parameters.AddWithValue("@r20_44",this.r20_44);
             cmd.Parameters.AddWithValue("@r20_45",this.r20_45);
                  cmd.Parameters.AddWithValue("@r20_46",this.r20_46);
                  cmd.Parameters.AddWithValue("@r20_47",this.r20_47);
                  cmd.Parameters.AddWithValue("@r20_48",this.r20_48);
                  cmd.Parameters.AddWithValue("@r20_49",this.r20_49);
                  cmd.Parameters.AddWithValue("@r20_410",this.r20_410);
                cmd.Parameters.AddWithValue("@r20_51",this.r20_51);
                  cmd.Parameters.AddWithValue("@r20_52",this.r20_52);
                  cmd.Parameters.AddWithValue("@r20_53",this.r20_53);
            cmd.Parameters.AddWithValue("@r20_54",this.r20_54);
                  cmd.Parameters.AddWithValue("@r20_55",this.r20_55);
        
                  cmd.Parameters.AddWithValue("@r20_57",this.r20_57);
                cmd.Parameters.AddWithValue("@r20_58",this.r20_58);
                  cmd.Parameters.AddWithValue("@r20_59",this.r20_59);
                  cmd.Parameters.AddWithValue("@r20_510",this.r20_510);
            
                  cmd.Parameters.AddWithValue("@r21_1",this.r21_1);
                cmd.Parameters.AddWithValue("@r21_2",this.r21_2);
                  cmd.Parameters.AddWithValue("@r20_56",this.r20_56);
                  cmd.Parameters.AddWithValue("@r20_29",this.r20_29);
            cmd.Parameters.AddWithValue("@r20_210",this.r20_210);
                  cmd.Parameters.AddWithValue("@r20_25",this.r20_25);
                  cmd.Parameters.AddWithValue("@r20_32",this.r20_32);
              


            cmd.Connection.Open();
            Int16 n = Convert.ToInt16(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            if(n==1)
            {
            cmd = new SqlCommand ("SELECT MAX(id_battery_section) FROM bg_battery_section",cnn);
                cmd.Connection.Open();
                Int64 m = Convert.ToInt16(cmd.ExecuteScalar());
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
