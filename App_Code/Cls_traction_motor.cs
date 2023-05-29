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
/// Summary description for Cls_traction_motor
/// </summary>
public class Cls_traction_motor : Cls_DBConnection
{
    public Cls_traction_motor()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public string id_traction_motor, id_mst_loco, id_loco_sch, date1, id_hr_tech, w_start, w_finish, id_hr_super, r11, r12, r13, r14, r15, r16, r21, r22, r23, r24, r25, r26, r31, r32, r33, r34, r35, r36, r41, r42, r43, r44, r45, r46, r51, r52, r53, r54, r55, r56, r61, r62, r63, r64, r65, r66, r71, r72, r73, r74, r75, r76, r81, r82, r83, r84, r85, r86, rAngle, rPlate, rGuard, rPlug, rTest, note1, note2, rb1, rb2, rb3, rb4, rb5, rb6, rc1, rc2, rc3, rc4, rc5, rc6;
    public Int64 Insert_Data()
    {
        try
        {
            cmd = new SqlCommand("INSERT INTO bg_traction_motor ( id_mst_loco, id_loco_sch, date1, id_hr_tech, w_start, w_finish, id_hr_super, r11, r12, r13, r14, r15, r16, r21, r22, r23, r24, r25, r26,  r31, r32, r33, r34, r35, r36, r41, r42, r43, r44, r45, r46, r51, r52, r53, r54, r55, r56, r61, r62, r63, r64, r65, r66, r71, r72, r73, r74, r75, r76, r81, r82, r83,  r84, r85, r86, rAngle, rPlate, rGuard, rPlug, rTest, note1, note2,rb1, rb2, rb3, rb4, rb5, rb6, rc1, rc2, rc3, rc4, rc5, rc6) VALUES (@id_mst_loco, @id_loco_sch, @date1, @id_hr_tech, @w_start, @w_finish, @id_hr_super, @r11, @r12, @r13, @r14, @r15, @r16, @r21, @r22, @r23, @r24, @r25, @r26,  @r31, @r32, @r33, @r34, @r35, @r36, @r41, @r42, @r43, @r44, @r45, @r46, @r51, @r52, @r53, @r54, @r55, @r56, @r61, @r62, @r63, @r64, @r65, @r66, @r71, @r72, @r73, @r74, @r75, @r76, @r81, @r82, @r83,  @r84, @r85, @r86, @rAngle, @rPlate, @rGuard, @rPlug, @rTest, @note1, @note2, @rb1, @rb2, @rb3, @rb4, @rb5, @rb6, @rc1, @rc2, @rc3, @rc4, @rc5, @rc6) ", cnn);
            cmd.Parameters.AddWithValue("@id_mst_loco", this.id_mst_loco);
            cmd.Parameters.AddWithValue("@id_loco_sch", this.id_loco_sch);
            cmd.Parameters.AddWithValue("@date1", this.date1);
            cmd.Parameters.AddWithValue("@id_hr_tech", this.id_hr_tech);
            cmd.Parameters.AddWithValue("@w_start", this.w_start);
            cmd.Parameters.AddWithValue("@w_finish", this.w_finish);
            cmd.Parameters.AddWithValue("@id_hr_super", this.id_hr_super);
            cmd.Parameters.AddWithValue("@r11", this.r11);
            cmd.Parameters.AddWithValue("@r12", this.r12);
            cmd.Parameters.AddWithValue("@r13", this.r13);
            cmd.Parameters.AddWithValue("@r14", this.r14);
            cmd.Parameters.AddWithValue("@r15", this.r15);
            cmd.Parameters.AddWithValue("@r16", this.r16);
            cmd.Parameters.AddWithValue("@r21", this.r21);
            cmd.Parameters.AddWithValue("@r22", this.r22);
            cmd.Parameters.AddWithValue("@r23", this.r23);
            cmd.Parameters.AddWithValue("@r24", this.r24);
            cmd.Parameters.AddWithValue("@r25", this.r25);
            cmd.Parameters.AddWithValue("@r26", this.r26);
            cmd.Parameters.AddWithValue("@r31", this.r31);
            cmd.Parameters.AddWithValue("@r32", this.r32);
            cmd.Parameters.AddWithValue("@r33", this.r33);
            cmd.Parameters.AddWithValue("@r34", this.r34);
            cmd.Parameters.AddWithValue("@r35", this.r35);
            cmd.Parameters.AddWithValue("@r36", this.r36);

            cmd.Parameters.AddWithValue("@r41", this.r41);
            cmd.Parameters.AddWithValue("@r42", this.r42);
            cmd.Parameters.AddWithValue("@r43", this.r43);
            cmd.Parameters.AddWithValue("@r44", this.r44);
            cmd.Parameters.AddWithValue("@r45", this.r45);
            cmd.Parameters.AddWithValue("@r46", this.r46);
            cmd.Parameters.AddWithValue("@r51", this.r51);

            cmd.Parameters.AddWithValue("@r52", this.r52);
            cmd.Parameters.AddWithValue("@r53", this.r53);
            cmd.Parameters.AddWithValue("@r54", this.r54);
            cmd.Parameters.AddWithValue("@r55", this.r55);
            cmd.Parameters.AddWithValue("@r56", this.r56);
            cmd.Parameters.AddWithValue("@r61", this.r61);
            cmd.Parameters.AddWithValue("@r62", this.r62);
            cmd.Parameters.AddWithValue("@r63", this.r63);
            cmd.Parameters.AddWithValue("@r64", this.r64);
            cmd.Parameters.AddWithValue("@r65", this.r65);
            cmd.Parameters.AddWithValue("@r66", this.r66);
            cmd.Parameters.AddWithValue("@r71", this.r71);
            cmd.Parameters.AddWithValue("@r72", this.r72);
            cmd.Parameters.AddWithValue("@r73", this.r73);
            cmd.Parameters.AddWithValue("@r74", this.r74);
            cmd.Parameters.AddWithValue("@r75", this.r75);
            cmd.Parameters.AddWithValue("@r76", this.r76);
            cmd.Parameters.AddWithValue("@r81", this.r81);
            cmd.Parameters.AddWithValue("@r82", this.r82);
            cmd.Parameters.AddWithValue("@r83", this.r83);
            cmd.Parameters.AddWithValue("@r84", this.r84);
            cmd.Parameters.AddWithValue("@r85", this.r85);
            cmd.Parameters.AddWithValue("@r86", this.r86);
            cmd.Parameters.AddWithValue("@rAngle", this.rAngle);

            cmd.Parameters.AddWithValue("@rPlate", this.rPlate);
            cmd.Parameters.AddWithValue("@rGuard", this.rGuard);
            cmd.Parameters.AddWithValue("@rPlug", this.rPlug);
            cmd.Parameters.AddWithValue("@rTest", this.rTest);
            cmd.Parameters.AddWithValue("@note1", this.note1);
            cmd.Parameters.AddWithValue("@note2", this.note2);

            //------------------------------


            cmd.Parameters.AddWithValue("@rb1", this.rb1);
            cmd.Parameters.AddWithValue("@rb2", this.rb2);
            cmd.Parameters.AddWithValue("@rb3", this.rb3);
            cmd.Parameters.AddWithValue("@rb4", this.rb4);
            cmd.Parameters.AddWithValue("@rb5", this.rb5);
            cmd.Parameters.AddWithValue("@rb6", this.rb6);
            cmd.Parameters.AddWithValue("@rc1", this.rc1);
            cmd.Parameters.AddWithValue("@rc2", this.rc2);
            cmd.Parameters.AddWithValue("@rc3", this.rc3);
            cmd.Parameters.AddWithValue("@rc4", this.rc4);
            cmd.Parameters.AddWithValue("@rc5", this.rc5);
            cmd.Parameters.AddWithValue("@rc6", this.rc6);
            cmd.Connection.Open();
            Int16 n = Convert.ToInt16(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            if (n == 1)
            {
                cmd = new SqlCommand("SELECT MAX(gear_case_id) FROM  table_gear_case_oil", cnn);
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
    //cmd.Parameters.AddWithValue("@id_mst_loco", this.id_mst_loco);
    //        da = new SqlDataAdapter();
    //        da.SelectCommand = cmd;
    //        dt = new DataTable();
    //        da.Fill(dt);
    //        return dt;
    //    }
    //    catch { throw; }
    //}
}
