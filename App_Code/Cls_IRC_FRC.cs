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
/// Summary description for Cls_IRC_FRC
/// </summary>
public class Cls_IRC_FRC : Cls_DBConnection
{
    public Cls_IRC_FRC()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public string long_wkg_1, long_wkg_2, long_wkg_3, long_wkg_4, long_wkg_5, long_wkg_6, long_wkg_7, long_wkg_8, long_wkg_9, long_nw_1, long_nw_2, long_nw_3, long_nw_4, long_nw_5, long_nw_6, long_nw_7, long_nw_8, long_nw_9, short_wkg_1, short_wkg_2, short_wkg_3, short_wkg_4, short_wkg_5, short_wkg_6, short_wkg_7, short_wkg_8, short_wkg_9, short_nw_1, short_nw_2, short_nw_3, short_nw_4, short_nw_5, short_nw_6, short_nw_7, short_nw_8, short_nw_9, remark1, remark2, remark3, remark4, remark5, remark6, remark7, remark8, remark9, remark10, remark11, remark12, remark13, rg10, indication1, indication2, attendant1, attendant2, cab1, cab2, ridel1, ridel2, ridel3, ridel4, ridel5, r8th1, r8th2, r8th3, r8th4, r8th5, sidle1, sidle2, sidle3, sidle4, s8th1, s8th2, s8th3, s8th4, tidle1, tidle2, tidle3, tidle4, t8th1, t8th2, t8th3, t8th4, opMode, dclv, dcla, gridkw, grid1a, grid2a, grid_blw1A, grid_blw2A, eng_rpm_db, db_post_s1, db_post_s2, db_post_s3, db_post_s4, db_post_s5, db_post_s6, db_post_s7, db_post_s8, db_post_l1, db_post_l2, db_post_l3, db_post_l4, db_post_l5, db_post_l6, db_post_l7, db_post_l8, th_pos, th_idl, dbntco, db17t, db21t, tl24t, rhsf, rhsr, ldunit, dvr_bcp1, dvr_8th, dvr_bp1, dvr_bp2, dvr_aux1, dvr_aux2, dvr_ph_ab1, dvr_ph_bc1, dvr_ph_ca1, dvr_ph_ab2, dvr_ph_bc2, dvr_ph_ca2, radi1_bp1, radi1_bp2, radi1_aux1, radi1_aux2, radi1_ph_ab1, radi1_ph_bc1, radi1_ph_ca1, radi1_ph_ab2, radi1_ph_bc2, radi1_ph_ca2, radi2_bp1, radi2_bp2, radi2_aux1, radi2_aux2, radi2_pf_ab1, radi2_pf_bc1, radi2_pf_ca1, radi2_pf_ab2, radi2_pf_bc2, radi2_pf_ca2, test_mu_s1, test_mu_s2, test_mu_s3, test_mu_s4, test_mu_s5, test_mu_s6, test_mu_s7, test_mu_s8, test_mu_s9, test_mu_s10, test_mu_s12, test_mu_s13, test_mu_s14, test_mu_s15, test_mu_s16, test_mu_s17, test_mu_s18, test_mu_s19, test_mu_l1, test_mu_l2, test_mu_l3, test_mu_l4, test_mu_l5, test_mu_l6, test_mu_l7, test_mu_l8, test_mu_l9, test_mu_l0, test_mu_l11, test_mu_l12, test_mu_l13, test_mu_l14, test_mu_l15, test_mu_l16, test_mu_l17, test_mu_l18, test_mu_l19;
   public string  p_i_1_1, p_i_1_2, p_i_1_3, p300_i_1, p300_i_2, p300_i_3, p310_i_1, p310_i_2, p310_i_3, p320_i_1, p320_i_2, p320_i_3, p_8_1, p_8_2, p_8_3,                      p300_8_1, p300_8_2, p300_8_3, p310_8_1, p310_8_2, p310_8_3, p320_8_1, p320_8_2, p320_8_3, sh1, lh1, eng_rpm, eng_rpm1, eng_rp2, eng_rp3,                       eng_rp4, eng_rp5, eng_rp6, eng_rp7, eng_rp8, eng_rp9, lr, lr1, lr2, lr3, lr4, lr5, lr6, lr7, lr8, lr9, eng_hp, eng_hp1, eng_hp2, eng_hp3, eng_hp4, eng_hp5,                       eng_hp6, eng_hp7, eng_hp8, eng_hp9, tpu, tpu1, tpu2, tpu3, tpu4, tpu5, tpu6, tpu7, tpu8, tpu9, kwref, kwref1, kwref2, kwref3, kwref4, kwref5, kwref6,                       kwref7, kwref8, kwref9, kwfbk, kwfbk1, kwfbk2, kwfbk3, kwfbk4, kwfbk5, kwfbk6, kwfbk7, kwfbk8, kwfbk9, mga, mga1, mga2, mga3, mga4, mga5, mga6,                     mga7, mga8, mga9, mgv, mgv1, mgv2, mgv3, mgv4, mgv5, mgv6, mgv7, mgv8, mgv9, bar_pres, bar_pres1, bar_pres2, bar_pres3, bar_pres4,                       bar_pres5, bar_pres6, bar_pres7, bar_pres8, bar_pres9, tm_air, tm_air1, tm_air2, tm_air3, tm_air4, tm_air5, tm_air6, tm_air7, tm_air8, tm_air9,                      mg_field, mg_field1, mg_field2, mg_field3, mg_field4, mg_field5, mg_field6, mg_field7, mg_field8, mg_field9, mg_ct, mg_ct1, mg_ct2, mg_ct3, mg_ct4,                       mg_ct5, mg_ct6, mg_ct7, mg_ct8, mg_ct9, grid1, grid1_1, grid1_2, grid1_3, grid1_4, grid1_5, grid1_6, grid1_7, grid1_8, grid1_9, grid2, grid2_1, grid2_2,                      grid2_3, grid2_4, grid2_5, grid2_6, grid2_7, grid2_8, grid2_9, grid_blw1, grid_blw1_1, grid_blw1_2, grid_blw1_3, grid_blw1_4, grid_blw1_5,                     grid_blw1_6, grid_blw1_7, grid_blw1_8, grid_blw1_9, grid_blw2, grid_blw2_1, grid_blw2_2, grid_blw2_3, grid_blw2_4, grid_blw2_5, grid_blw2_6,                     grid_blw2_7, grid_blw2_8, grid_blw2_9, cav, cav1, cav2, cav3, cav4, cav5, cav6, cav7, cav8, cav9, etp1, etp1_1, etp1_2, etp1_3, etp1_4, etp1_5,                     etp1_6, etp1_7, etp1_8, etp1_9, etp2, etp2_1, etp2_2, etp2_3, etp2_4, etp2_5, etp2_6, etp2_7, etp2_8, etp2_9, rad1, rad1_1, rad1_2, rad1_3, rad1_4,                     rad1_5, rad1_6, rad1_7, rad1_8, rad1_9, rad2, rad2_1, rad2_2, rad2_3, rad2_4, rad2_5, rad2_6, rad2_7, rad2_8, rad2_9, ecc1, ecc11, ecc12, ecc13,                      ecc14, ecc15, ecc16, ecc17, ecc18, ecc19;
    //table 1   id_irc_frc1
    //    INSERT INTO sch_ele_irc_frc1        (long_wkg_1, long_wkg_2, long_wkg_3, long_wkg_4, long_wkg_5, long_wkg_6, long_wkg_7, long_wkg_8, long_wkg_9, long_nw_1, long_nw_2,                       long_nw_3, long_nw_4, long_nw_5, long_nw_6, long_nw_7, long_nw_8, long_nw_9, short_wkg_1, short_wkg_2, short_wkg_3, short_wkg_4,                       short_wkg_5, short_wkg_6, short_wkg_7, short_wkg_8, short_wkg_9, short_nw_1, short_nw_2, short_nw_3, short_nw_4, short_nw_5, short_nw_6,                       short_nw_7, short_nw_8, short_nw_9, remark1, remark2, remark3, remark4, remark5, remark6, remark7, remark8, remark9, remark10, remark11,                       remark12, remark13, rg10, indication1, indication2, attendant1, attendant2, cab1, cab2, ridel1, ridel2, ridel3, ridel4, ridel5, r8th1, r8th2, r8th3, r8th4,                       r8th5, sidle1, sidle2, sidle3, sidle4, s8th1, s8th2, s8th3, s8th4, tidle1, tidle2, tidle3, tidle4, t8th1, t8th2, t8th3, t8th4, opMode, dclv, dcla, gridkw, grid1a,                       grid2a, grid_blw1A, grid_blw2A, eng_rpm_db, db_post_s1, db_post_s2, db_post_s3, db_post_s4, db_post_s5, db_post_s6, db_post_s7, db_post_s8,                       db_post_l1, db_post_l2, db_post_l3, db_post_l4, db_post_l5, db_post_l6, db_post_l7, db_post_l8, th_pos, th_idl, dbntco, db17t, db21t, tl24t, rhsf, rhsr,                       ldunit, dvr_bcp1, dvr_8th, dvr_bp1, dvr_bp2, dvr_aux1, dvr_aux2, dvr_ph_ab1, dvr_ph_bc1, dvr_ph_ca1, dvr_ph_ab2, dvr_ph_bc2, dvr_ph_ca2,                       radi1_bp1, radi1_bp2, radi1_aux1, radi1_aux2, radi1_ph_ab1, radi1_ph_bc1, radi1_ph_ca1, radi1_ph_ab2, radi1_ph_bc2, radi1_ph_ca2, radi2_bp1,                       radi2_bp2, radi2_aux1, radi2_aux2, radi2_pf_ab1, radi2_pf_bc1, radi2_pf_ca1, radi2_pf_ab2, radi2_pf_bc2, radi2_pf_ca2, test_mu_s1, test_mu_s2,                     test_mu_s3, test_mu_s4, test_mu_s5, test_mu_s6, test_mu_s7, test_mu_s8, test_mu_s9, test_mu_s10, test_mu_s12, test_mu_s13, test_mu_s14,                     test_mu_s15, test_mu_s16, test_mu_s17, test_mu_s18, test_mu_s19, test_mu_l1, test_mu_l2, test_mu_l3, test_mu_l4, test_mu_l5, test_mu_l6,                       test_mu_l7, test_mu_l8, test_mu_l9, test_mu_l0, test_mu_l11, test_mu_l12, test_mu_l13, test_mu_l14, test_mu_l15, test_mu_l16, test_mu_l17,                       test_mu_l18, test_mu_l19)VALUES    (long_wkg_1, long_wkg_2, long_wkg_3, long_wkg_4, long_wkg_5, long_wkg_6, long_wkg_7, long_wkg_8, long_wkg_9, long_nw_1, long_nw_2,                       long_nw_3, long_nw_4, long_nw_5, long_nw_6, long_nw_7, long_nw_8, long_nw_9, short_wkg_1, short_wkg_2, short_wkg_3, short_wkg_4,                       short_wkg_5, short_wkg_6, short_wkg_7, short_wkg_8, short_wkg_9, short_nw_1, short_nw_2, short_nw_3, short_nw_4, short_nw_5, short_nw_6,                       short_nw_7, short_nw_8, short_nw_9, remark1, remark2, remark3, remark4, remark5, remark6, remark7, remark8, remark9, remark10, remark11,                       remark12, remark13, rg10, indication1, indication2, attendant1, attendant2, cab1, cab2, ridel1, ridel2, ridel3, ridel4, ridel5, r8th1, r8th2, r8th3, r8th4,                       r8th5, sidle1, sidle2, sidle3, sidle4, s8th1, s8th2, s8th3, s8th4, tidle1, tidle2, tidle3, tidle4, t8th1, t8th2, t8th3, t8th4, opMode, dclv, dcla, gridkw, grid1a,                       grid2a, grid_blw1A, grid_blw2A, eng_rpm_db, db_post_s1, db_post_s2, db_post_s3, db_post_s4, db_post_s5, db_post_s6, db_post_s7, db_post_s8,                       db_post_l1, db_post_l2, db_post_l3, db_post_l4, db_post_l5, db_post_l6, db_post_l7, db_post_l8, th_pos, th_idl, dbntco, db17t, db21t, tl24t, rhsf, rhsr,                       ldunit, dvr_bcp1, dvr_8th, dvr_bp1, dvr_bp2, dvr_aux1, dvr_aux2, dvr_ph_ab1, dvr_ph_bc1, dvr_ph_ca1, dvr_ph_ab2, dvr_ph_bc2, dvr_ph_ca2,                       radi1_bp1, radi1_bp2, radi1_aux1, radi1_aux2, radi1_ph_ab1, radi1_ph_bc1, radi1_ph_ca1, radi1_ph_ab2, radi1_ph_bc2, radi1_ph_ca2, radi2_bp1,                       radi2_bp2, radi2_aux1, radi2_aux2, radi2_pf_ab1, radi2_pf_bc1, radi2_pf_ca1, radi2_pf_ab2, radi2_pf_bc2, radi2_pf_ca2, test_mu_s1, test_mu_s2,                     test_mu_s3, test_mu_s4, test_mu_s5, test_mu_s6, test_mu_s7, test_mu_s8, test_mu_s9, test_mu_s10, test_mu_s12, test_mu_s13, test_mu_s14,                     test_mu_s15, test_mu_s16, test_mu_s17, test_mu_s18, test_mu_s19, test_mu_l1, test_mu_l2, test_mu_l3, test_mu_l4, test_mu_l5, test_mu_l6,                       test_mu_l7, test_mu_l8, test_mu_l9, test_mu_l0, test_mu_l11, test_mu_l12, test_mu_l13, test_mu_l14, test_mu_l15, test_mu_l16, test_mu_l17,                       test_mu_l18, test_mu_l19)


    //table2    id_irc_frc2
    //    INSERT INTO scl_ele_irc_frc2        (p_i_1_1, p_i_1_2, p_i_1_3, p300_i_1, p300_i_2, p300_i_3, p310_i_1, p310_i_2, p310_i_3, p320_i_1, p320_i_2, p320_i_3, p_8_1, p_8_2, p_8_3,                      p300_8_1, p300_8_2, p300_8_3, p310_8_1, p310_8_2, p310_8_3, p320_8_1, p320_8_2, p320_8_3, sh1, lh1, eng_rpm, eng_rpm1, eng_rp2, eng_rp3,                       eng_rp4, eng_rp5, eng_rp6, eng_rp7, eng_rp8, eng_rp9, lr, lr1, lr2, lr3, lr4, lr5, lr6, lr7, lr8, lr9, eng_hp, eng_hp1, eng_hp2, eng_hp3, eng_hp4, eng_hp5,                       eng_hp6, eng_hp7, eng_hp8, eng_hp9, tpu, tpu1, tpu2, tpu3, tpu4, tpu5, tpu6, tpu7, tpu8, tpu9, kwref, kwref1, kwref2, kwref3, kwref4, kwref5, kwref6,                       kwref7, kwref8, kwref9, kwfbk, kwfbk1, kwfbk2, kwfbk3, kwfbk4, kwfbk5, kwfbk6, kwfbk7, kwfbk8, kwfbk9, mga, mga1, mga2, mga3, mga4, mga5, mga6,                     mga7, mga8, mga9, mgv, mgv1, mgv2, mgv3, mgv4, mgv5, mgv6, mgv7, mgv8, mgv9, bar_pres, bar_pres1, bar_pres2, bar_pres3, bar_pres4,                       bar_pres5, bar_pres6, bar_pres7, bar_pres8, bar_pres9, tm_air, tm_air1, tm_air2, tm_air3, tm_air4, tm_air5, tm_air6, tm_air7, tm_air8, tm_air9,                      mg_field, mg_field1, mg_field2, mg_field3, mg_field4, mg_field5, mg_field6, mg_field7, mg_field8, mg_field9, mg_ct, mg_ct1, mg_ct2, mg_ct3, mg_ct4,                       mg_ct5, mg_ct6, mg_ct7, mg_ct8, mg_ct9, grid1, grid1_1, grid1_2, grid1_3, grid1_4, grid1_5, grid1_6, grid1_7, grid1_8, grid1_9, grid2, grid2_1, grid2_2,                      grid2_3, grid2_4, grid2_5, grid2_6, grid2_7, grid2_8, grid2_9, grid_blw1, grid_blw1_1, grid_blw1_2, grid_blw1_3, grid_blw1_4, grid_blw1_5,                     grid_blw1_6, grid_blw1_7, grid_blw1_8, grid_blw1_9, grid_blw2, grid_blw2_1, grid_blw2_2, grid_blw2_3, grid_blw2_4, grid_blw2_5, grid_blw2_6,                     grid_blw2_7, grid_blw2_8, grid_blw2_9, cav, cav1, cav2, cav3, cav4, cav5, cav6, cav7, cav8, cav9, etp1, etp1_1, etp1_2, etp1_3, etp1_4, etp1_5,                     etp1_6, etp1_7, etp1_8, etp1_9, etp2, etp2_1, etp2_2, etp2_3, etp2_4, etp2_5, etp2_6, etp2_7, etp2_8, etp2_9, rad1, rad1_1, rad1_2, rad1_3, rad1_4,                     rad1_5, rad1_6, rad1_7, rad1_8, rad1_9, rad2, rad2_1, rad2_2, rad2_3, rad2_4, rad2_5, rad2_6, rad2_7, rad2_8, rad2_9, ecc1, ecc11, ecc12, ecc13,                      ecc14, ecc15, ecc16, ecc17, ecc18, ecc19) VALUES  (@p_i_1_1, @p_i_1_2, @p_i_1_3, @p300_i_1, @p300_i_2, @p300_i_3, @p310_i_1, @p310_i_2, @p310_i_3, @p320_i_1, @p320_i_2, @p320_i_3, @p_8_1, @p_8_2, @p_8_3,                      @p300_8_1, @p300_8_2, @p300_8_3, @p310_8_1, @p310_8_2, @p310_8_3, @p320_8_1, @p320_8_2, @p320_8_3, @sh1, @lh1, @eng_rpm, @eng_rpm1, @eng_rp2, @eng_rp3,                       @eng_rp4, @eng_rp5, @eng_rp6, @eng_rp7, @eng_rp8, @eng_rp9, @lr, @lr1, @lr2, @lr3, @lr4, @lr5, @lr6, @lr7, @lr8, @lr9, @eng_hp, @eng_hp1, @eng_hp2, @eng_hp3, @eng_hp4, @eng_hp5,                       @eng_hp6, @eng_hp7, @eng_hp8, @eng_hp9, @tpu, @tpu1, @tpu2, @tpu3, @tpu4, @tpu5, @tpu6, @tpu7, @tpu8, @tpu9, @kwref, @kwref1, @kwref2, @kwref3, @kwref4, @kwref5, @kwref6,                       @kwref7, @kwref8, @kwref9, @kwfbk, @kwfbk1, @kwfbk2, @kwfbk3, @kwfbk4, @kwfbk5, @kwfbk6, @kwfbk7, @kwfbk8, @kwfbk9, @mga, @mga1, @mga2, @mga3, @mga4, @mga5, @mga6,                     @mga7, @mga8, @mga9, @mgv, @mgv1, @mgv2, @mgv3, @mgv4, @mgv5, @mgv6, @mgv7, @mgv8, @mgv9, @bar_pres, @bar_pres1, @bar_pres2, @bar_pres3, @bar_pres4,                       @bar_pres5, @bar_pres6, @bar_pres7, @bar_pres8, @bar_pres9, @tm_air, @tm_air1, @tm_air2, @tm_air3, @tm_air4, @tm_air5, @tm_air6, @tm_air7, @tm_air8, @tm_air9,                      @mg_field, @mg_field1, @mg_field2, @mg_field3, @mg_field4, @mg_field5, @mg_field6, @mg_field7, @mg_field8, @mg_field9, @mg_ct, @mg_ct1, @mg_ct2, @mg_ct3, @mg_ct4,                       @mg_ct5, @mg_ct6, @mg_ct7, @mg_ct8, @mg_ct9, @grid1, @grid1_1, @grid1_2, @grid1_3, @grid1_4, @grid1_5, @grid1_6, @grid1_7, @grid1_8, @grid1_9, @grid2, @grid2_1, @grid2_2,                      @grid2_3, @grid2_4, @grid2_5, @grid2_6, @grid2_7, @grid2_8, @grid2_9, @grid_blw1, @grid_blw1_1, @grid_blw1_2, @grid_blw1_3, @grid_blw1_4, @grid_blw1_5,                     @grid_blw1_6, @grid_blw1_7, @grid_blw1_8, @grid_blw1_9, @grid_blw2, @grid_blw2_1, @grid_blw2_2, @grid_blw2_3, @grid_blw2_4, @grid_blw2_5, @grid_blw2_6,                     @grid_blw2_7, @grid_blw2_8, @grid_blw2_9, @cav, @cav1, @cav2, @cav3, @cav4, @cav5, @cav6, @cav7, @cav8, @cav9, @etp1, @etp1_1, @etp1_2, @etp1_3, @etp1_4, @etp1_5,                     @etp1_6, @etp1_7, @etp1_8, @etp1_9, @etp2, @etp2_1, @etp2_2, @etp2_3, @etp2_4, @etp2_5, @etp2_6, @etp2_7, @etp2_8, @etp2_9, @rad1, @rad1_1, @rad1_2, @rad1_3, @rad1_4,                     @rad1_5, @rad1_6, @rad1_7, @rad1_8, @rad1_9, @rad2, @rad2_1, @rad2_2, @rad2_3, @rad2_4, @rad2_5, @rad2_6, @rad2_7, @rad2_8, @rad2_9, @ecc1, @ecc11, @ecc12, @ecc13,                      @ecc14, @ecc15, @ecc16, @ecc17, @ecc18, @ecc19)  

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
    public DataTable Select_Data_gv1(string id_loco_sch)
    {
        try
        {
            cmd = new SqlCommand("SELECT jos_railway_loco_type_schedule.id_loco_sch, jos_railway_loco_type_schedule.loco_id, jos_railway_loco_type_schedule.s_type,                       jos_railway_loco_type_schedule.duration, sch_card_head_deatils.id_sd_con, sch_card_head_deatils.id_sc_para,                       sch_card_head_deatils.sub_head_details as sub_head_details , sch_card_sub_head.id_sc_para AS Expr1, sch_card_sub_head.id_sch_card,                       sch_card_sub_head.id_loco_sch AS Expr2, sch_card_sub_head.sub_head, schedule_card.id_sch_card AS Expr3, schedule_card.id_section,                       schedule_card.name_sub_section FROM         jos_railway_loco_type_schedule INNER JOIN                       sch_card_sub_head ON jos_railway_loco_type_schedule.id_loco_sch = sch_card_sub_head.id_loco_sch INNER JOIN                      sch_card_head_deatils ON sch_card_sub_head.id_sc_para = sch_card_head_deatils.id_sc_para INNER JOIN                      schedule_card ON sch_card_sub_head.id_sch_card = schedule_card.id_sch_card where jos_railway_loco_type_schedule.id_loco_sch='" + id_loco_sch + "' and sch_card_sub_head.id_sc_para='31'  ", cnn);
            // cmd = new SqlCommand("SELECT distinct (sch_card_sub_head.id_sc_para), sch_card_head_deatils.sub_head_details,sch_card_sub_head.sub_head,schedule_card_form.id_sc_format ,jos_railway_loco_type_schedule.id_loco_sch, jos_railway_loco_type_schedule.loco_id, jos_railway_loco_type_schedule.s_type,                       jos_railway_loco_type_schedule.duration, sch_card_sub_head.id_sch_card,                       sch_card_sub_head.id_loco_sch AS Expr1,   schedule_card_form.id_section,                       schedule_card_form.id_schedule, schedule_card_form.id_loco, schedule_card_form.id_technician, schedule_card_form.id_supervisor,                       schedule_card_form.w_s_time, schedule_card_form.w_end_time, schedule_card_form.date1, schedule_card_form.id_sch_card AS Expr2,                       schedule_card_form.status, schedule_card_form.action_tak, jos_railway_mst_loco.id_mst_loco, jos_railway_mst_loco.locono,                      jos_railway_mst_loco.tid, jos_railway_mst_loco.shed_id, jos_railway_mst_loco.doc_date, jos_railway_mst_loco.a_time,                       jos_railway_mst_loco.poh_date, jos_railway_mst_loco.native, jos_railway_mst_loco.rfrom, sch_card_head_deatils.id_sd_con,                       sch_card_head_deatils.id_sc_para AS Expr3,  sch_card_form_detail.id_card_form_detail,                       sch_card_form_detail.id_sc_format AS Expr4, sch_card_form_detail.status AS Expr5, sch_card_form_detail.action_taken,                      sch_card_form_detail.staff,schedule_card.id_sch_card,schedule_card.name_sub_section FROM   schedule_card_form   INNER JOIN jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = schedule_card_form.id_schedule INNER JOIN   jos_railway_mst_loco   ON schedule_card_form.id_loco = jos_railway_mst_loco.id_mst_loco INNER JOIN  sch_card_sub_head ON jos_railway_loco_type_schedule.id_loco_sch = sch_card_sub_head.id_loco_sch INNER JOIN  sch_card_head_deatils ON sch_card_sub_head.id_sc_para = sch_card_head_deatils.id_sc_para INNER JOIN  sch_card_form_detail ON sch_card_form_detail.id_sc_format=schedule_card_form.id_sc_format INNER JOIN jos_railway_section ON jos_railway_section.id_section = schedule_card_form.id_section INNER JOIN schedule_card ON schedule_card.id_sch_card=sch_card_sub_head.id_sch_card  where jos_railway_section.id_section='2'and  schedule_card.id_sch_card ='3'and jos_railway_loco_type_schedule.id_loco_sch='" + id_loco_sch + "' ", cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        catch
        { throw; }
    }
    public DataTable Select_Data_gv2(string id_loco_sch)
    {
        try
        {
            cmd = new SqlCommand("SELECT jos_railway_loco_type_schedule.id_loco_sch, jos_railway_loco_type_schedule.loco_id, jos_railway_loco_type_schedule.s_type,                       jos_railway_loco_type_schedule.duration, sch_card_head_deatils.id_sd_con, sch_card_head_deatils.id_sc_para,                       sch_card_head_deatils.sub_head_details as sub_head_details , sch_card_sub_head.id_sc_para AS Expr1, sch_card_sub_head.id_sch_card,                       sch_card_sub_head.id_loco_sch AS Expr2, sch_card_sub_head.sub_head, schedule_card.id_sch_card AS Expr3, schedule_card.id_section,                       schedule_card.name_sub_section FROM         jos_railway_loco_type_schedule INNER JOIN                       sch_card_sub_head ON jos_railway_loco_type_schedule.id_loco_sch = sch_card_sub_head.id_loco_sch INNER JOIN                      sch_card_head_deatils ON sch_card_sub_head.id_sc_para = sch_card_head_deatils.id_sc_para INNER JOIN                      schedule_card ON sch_card_sub_head.id_sch_card = schedule_card.id_sch_card where jos_railway_loco_type_schedule.id_loco_sch='" + id_loco_sch + "' and sch_card_sub_head.id_sc_para='32'  ", cnn);
            // cmd = new SqlCommand("SELECT distinct (sch_card_sub_head.id_sc_para), sch_card_head_deatils.sub_head_details,sch_card_sub_head.sub_head,schedule_card_form.id_sc_format ,jos_railway_loco_type_schedule.id_loco_sch, jos_railway_loco_type_schedule.loco_id, jos_railway_loco_type_schedule.s_type,                       jos_railway_loco_type_schedule.duration, sch_card_sub_head.id_sch_card,                       sch_card_sub_head.id_loco_sch AS Expr1,   schedule_card_form.id_section,                       schedule_card_form.id_schedule, schedule_card_form.id_loco, schedule_card_form.id_technician, schedule_card_form.id_supervisor,                       schedule_card_form.w_s_time, schedule_card_form.w_end_time, schedule_card_form.date1, schedule_card_form.id_sch_card AS Expr2,                       schedule_card_form.status, schedule_card_form.action_tak, jos_railway_mst_loco.id_mst_loco, jos_railway_mst_loco.locono,                      jos_railway_mst_loco.tid, jos_railway_mst_loco.shed_id, jos_railway_mst_loco.doc_date, jos_railway_mst_loco.a_time,                       jos_railway_mst_loco.poh_date, jos_railway_mst_loco.native, jos_railway_mst_loco.rfrom, sch_card_head_deatils.id_sd_con,                       sch_card_head_deatils.id_sc_para AS Expr3,  sch_card_form_detail.id_card_form_detail,                       sch_card_form_detail.id_sc_format AS Expr4, sch_card_form_detail.status AS Expr5, sch_card_form_detail.action_taken,                      sch_card_form_detail.staff,schedule_card.id_sch_card,schedule_card.name_sub_section FROM   schedule_card_form   INNER JOIN jos_railway_loco_type_schedule ON jos_railway_loco_type_schedule.id_loco_sch = schedule_card_form.id_schedule INNER JOIN   jos_railway_mst_loco   ON schedule_card_form.id_loco = jos_railway_mst_loco.id_mst_loco INNER JOIN  sch_card_sub_head ON jos_railway_loco_type_schedule.id_loco_sch = sch_card_sub_head.id_loco_sch INNER JOIN  sch_card_head_deatils ON sch_card_sub_head.id_sc_para = sch_card_head_deatils.id_sc_para INNER JOIN  sch_card_form_detail ON sch_card_form_detail.id_sc_format=schedule_card_form.id_sc_format INNER JOIN jos_railway_section ON jos_railway_section.id_section = schedule_card_form.id_section INNER JOIN schedule_card ON schedule_card.id_sch_card=sch_card_sub_head.id_sch_card  where jos_railway_section.id_section='2'and  schedule_card.id_sch_card ='3'and jos_railway_loco_type_schedule.id_loco_sch='" + id_loco_sch + "' ", cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        catch
        { throw; }
    }
    //public Int64 Insert_Data()
    //{
    //    try
    //    {
    //        cmd = new SqlCommand("INSERT INTO Loco_GovernerOil(Id_Loco,Loco_Date,Id_Schedule,WaterContent,FalshPoint,Viscosity,Result_Remarks,Tested_By) VALUES(@Id_Loco,@Loco_Date,@Id_Schedule,@WaterContent,@FalshPoint,@Viscosity,@Result_Remarks,@Tested_By)", cnn);
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
    //            cmd = new SqlCommand("SELECT MAX(Id_GovernerOil) FROM  Loco_GovernerOil", cnn);
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


    public string id_sc_format;

    public Int16 Insert_Data_IRC_FRC_1()
    {
        try
        {
            cmd = new SqlCommand("INSERT INTO sch_ele_irc_frc1        (id_sc_format,long_wkg_1, long_wkg_2, long_wkg_3, long_wkg_4, long_wkg_5, long_wkg_6, long_wkg_7, long_wkg_8, long_wkg_9, long_nw_1, long_nw_2,                       long_nw_3, long_nw_4, long_nw_5, long_nw_6, long_nw_7, long_nw_8, long_nw_9, short_wkg_1, short_wkg_2, short_wkg_3, short_wkg_4,                       short_wkg_5, short_wkg_6, short_wkg_7, short_wkg_8, short_wkg_9, short_nw_1, short_nw_2, short_nw_3, short_nw_4, short_nw_5, short_nw_6,                       short_nw_7, short_nw_8, short_nw_9, remark1, remark2, remark3, remark4, remark5, remark6, remark7, remark8, remark9, remark10, remark11,                       remark12, remark13, rg10, indication1, indication2, attendant1, attendant2, cab1, cab2, ridel1, ridel2, ridel3, ridel4, ridel5, r8th1, r8th2, r8th3, r8th4,                       r8th5, sidle1, sidle2, sidle3, sidle4, s8th1, s8th2, s8th3, s8th4, tidle1, tidle2, tidle3, tidle4, t8th1, t8th2, t8th3, t8th4, opMode, dclv, dcla, gridkw, grid1a,                       grid2a, grid_blw1A, grid_blw2A, eng_rpm_db, db_post_s1, db_post_s2, db_post_s3, db_post_s4, db_post_s5, db_post_s6, db_post_s7, db_post_s8,                       db_post_l1, db_post_l2, db_post_l3, db_post_l4, db_post_l5, db_post_l6, db_post_l7, db_post_l8, th_pos, th_idl, dbntco, db17t, db21t, tl24t, rhsf, rhsr,                       ldunit, dvr_bcp1, dvr_8th, dvr_bp1, dvr_bp2, dvr_aux1, dvr_aux2, dvr_ph_ab1, dvr_ph_bc1, dvr_ph_ca1, dvr_ph_ab2, dvr_ph_bc2, dvr_ph_ca2,                       radi1_bp1, radi1_bp2, radi1_aux1, radi1_aux2, radi1_ph_ab1, radi1_ph_bc1, radi1_ph_ca1, radi1_ph_ab2, radi1_ph_bc2, radi1_ph_ca2, radi2_bp1,                       radi2_bp2, radi2_aux1, radi2_aux2, radi2_pf_ab1, radi2_pf_bc1, radi2_pf_ca1, radi2_pf_ab2, radi2_pf_bc2, radi2_pf_ca2, test_mu_s1, test_mu_s2,                     test_mu_s3, test_mu_s4, test_mu_s5, test_mu_s6, test_mu_s7, test_mu_s8, test_mu_s9, test_mu_s10, test_mu_s12, test_mu_s13, test_mu_s14,                     test_mu_s15, test_mu_s16, test_mu_s17, test_mu_s18, test_mu_s19, test_mu_l1, test_mu_l2, test_mu_l3, test_mu_l4, test_mu_l5, test_mu_l6,                       test_mu_l7, test_mu_l8, test_mu_l9, test_mu_l0, test_mu_l11, test_mu_l12, test_mu_l13, test_mu_l14, test_mu_l15, test_mu_l16, test_mu_l17,                       test_mu_l18, test_mu_l19) VALUES    (@id_sc_format,@long_wkg_1, @long_wkg_2, @long_wkg_3, @long_wkg_4, @long_wkg_5, @long_wkg_6, @long_wkg_7, @long_wkg_8, @long_wkg_9, @long_nw_1, @long_nw_2,                       @long_nw_3, @long_nw_4, @long_nw_5, @long_nw_6, @long_nw_7, @long_nw_8, @long_nw_9, @short_wkg_1, @short_wkg_2, @short_wkg_3, @short_wkg_4,                       @short_wkg_5, @short_wkg_6, @short_wkg_7, @short_wkg_8, @short_wkg_9, @short_nw_1, @short_nw_2, @short_nw_3, @short_nw_4, @short_nw_5, @short_nw_6,                       @short_nw_7, @short_nw_8, @short_nw_9, @remark1, @remark2, @remark3, @remark4, @remark5, @remark6, @remark7, @remark8, @remark9, @remark10, @remark11,                       @remark12, @remark13, @rg10, @indication1, @indication2, @attendant1, @attendant2, @cab1, @cab2, @ridel1, @ridel2, @ridel3, @ridel4, @ridel5, @r8th1, @r8th2, @r8th3, @r8th4,                       @r8th5, @sidle1, @sidle2, @sidle3, @sidle4, @s8th1, @s8th2, @s8th3, @s8th4, @tidle1, @tidle2, @tidle3, @tidle4, @t8th1, @t8th2, @t8th3, @t8th4, @opMode, @dclv, @dcla, @gridkw, @grid1a,                       @grid2a, @grid_blw1A, @grid_blw2A, @eng_rpm_db, @db_post_s1, @db_post_s2, @db_post_s3, @db_post_s4, @db_post_s5, @db_post_s6, @db_post_s7, @db_post_s8,                       @db_post_l1, @db_post_l2, @db_post_l3, @db_post_l4, @db_post_l5, @db_post_l6, @db_post_l7, @db_post_l8, @th_pos, @th_idl, @dbntco, @db17t, @db21t, @tl24t, @rhsf, @rhsr,                       @ldunit, @dvr_bcp1, @dvr_8th, @dvr_bp1, @dvr_bp2, @dvr_aux1, @dvr_aux2, @dvr_ph_ab1, @dvr_ph_bc1, @dvr_ph_ca1, @dvr_ph_ab2, @dvr_ph_bc2, @dvr_ph_ca2,                       @radi1_bp1, @radi1_bp2, @radi1_aux1, @radi1_aux2, @radi1_ph_ab1, @radi1_ph_bc1, @radi1_ph_ca1, @radi1_ph_ab2, @radi1_ph_bc2, @radi1_ph_ca2, @radi2_bp1,                       @radi2_bp2, @radi2_aux1, @radi2_aux2, @radi2_pf_ab1, @radi2_pf_bc1, @radi2_pf_ca1, @radi2_pf_ab2, @radi2_pf_bc2, @radi2_pf_ca2, @test_mu_s1, @test_mu_s2,                     @test_mu_s3, @test_mu_s4, @test_mu_s5, @test_mu_s6, @test_mu_s7, @test_mu_s8, @test_mu_s9, @test_mu_s10, @test_mu_s12, @test_mu_s13, @test_mu_s14,                     @test_mu_s15, @test_mu_s16, @test_mu_s17, @test_mu_s18, @test_mu_s19, @test_mu_l1, @test_mu_l2, @test_mu_l3, @test_mu_l4, @test_mu_l5, @test_mu_l6,                       @test_mu_l7, @test_mu_l8, @test_mu_l9, @test_mu_l0, @test_mu_l11, @test_mu_l12, @test_mu_l13, @test_mu_l14, @test_mu_l15, @test_mu_l16, @test_mu_l17,                       @test_mu_l18, @test_mu_l19)", cnn);
            cmd.Parameters.AddWithValue("@id_sc_format", this.id_sc_format);
            cmd.Parameters.AddWithValue("@long_wkg_1", this.long_wkg_1);
            cmd.Parameters.AddWithValue("@long_wkg_2", this.long_wkg_2);
            cmd.Parameters.AddWithValue("@long_wkg_3", this.long_wkg_3);
            cmd.Parameters.AddWithValue("@long_wkg_4", this.long_wkg_4);
            cmd.Parameters.AddWithValue("@long_wkg_5", this.long_wkg_5);
            cmd.Parameters.AddWithValue("@long_wkg_6", this.long_wkg_6);
            cmd.Parameters.AddWithValue("@long_wkg_7", this.long_wkg_7);
            cmd.Parameters.AddWithValue("@long_wkg_8", this.long_wkg_8);
            cmd.Parameters.AddWithValue("@long_wkg_9", this.long_wkg_9);
            cmd.Parameters.AddWithValue("@long_nw_1", this.long_nw_1);
            cmd.Parameters.AddWithValue("@long_nw_2", this.long_nw_2);
            cmd.Parameters.AddWithValue("@long_nw_3", this.long_nw_3);
            cmd.Parameters.AddWithValue("@long_nw_4", this.long_nw_4);
            cmd.Parameters.AddWithValue("@long_nw_5", this.long_nw_5);
            cmd.Parameters.AddWithValue("@long_nw_6", this.long_nw_6);
            cmd.Parameters.AddWithValue("@long_nw_7", this.long_nw_7);
            cmd.Parameters.AddWithValue("@long_nw_8", this.long_nw_8);
            cmd.Parameters.AddWithValue("@long_nw_9", this.long_nw_9);
            cmd.Parameters.AddWithValue("@short_wkg_1", this.short_wkg_1);
            cmd.Parameters.AddWithValue("@short_wkg_2", this.short_wkg_2);
            cmd.Parameters.AddWithValue("@short_wkg_3", this.short_wkg_3);
            cmd.Parameters.AddWithValue("@short_wkg_4", this.short_wkg_4);
            cmd.Parameters.AddWithValue("@short_wkg_5", this.short_wkg_5);
            cmd.Parameters.AddWithValue("@short_wkg_6", this.short_wkg_6);
            cmd.Parameters.AddWithValue("@short_wkg_7", this.short_wkg_7);
            cmd.Parameters.AddWithValue("@short_wkg_8", this.short_wkg_8);
            cmd.Parameters.AddWithValue("@short_wkg_9", this.short_wkg_9);
            cmd.Parameters.AddWithValue("@short_nw_1", this.short_nw_1);
            cmd.Parameters.AddWithValue("@short_nw_2", this.short_nw_2);
            cmd.Parameters.AddWithValue("@short_nw_3", this.short_nw_3);
            cmd.Parameters.AddWithValue("@short_nw_4", this.short_nw_4);
            cmd.Parameters.AddWithValue("@short_nw_5", this.short_nw_5);
            cmd.Parameters.AddWithValue("@short_nw_6", this.short_nw_6);
            cmd.Parameters.AddWithValue("@short_nw_7", this.short_nw_7);
            cmd.Parameters.AddWithValue("@short_nw_8", this.short_nw_8);
            cmd.Parameters.AddWithValue("@short_nw_9", this.short_nw_9);
            //cmd.Parameters.AddWithValue("@short_nw_2", this.short_nw_2);
            //cmd.Parameters.AddWithValue("@short_nw_3", this.short_nw_3);
            //cmd.Parameters.AddWithValue("@short_nw_4", this.short_nw_4);
            //cmd.Parameters.AddWithValue("@short_nw_5", this.short_nw_5);
            //cmd.Parameters.AddWithValue("@short_nw_6", this.short_nw_6);
            //cmd.Parameters.AddWithValue("@short_nw_7", this.short_nw_7);
            //cmd.Parameters.AddWithValue("@short_nw_8", this.short_nw_8);
            //cmd.Parameters.AddWithValue("@short_nw_9", this.short_nw_9);
            cmd.Parameters.AddWithValue("@remark1", this.remark1);
            cmd.Parameters.AddWithValue("@remark2", this.remark2);
            cmd.Parameters.AddWithValue("@remark3", this.remark3);
            cmd.Parameters.AddWithValue("@remark4", this.remark4);
            cmd.Parameters.AddWithValue("@remark5", this.remark5);
            cmd.Parameters.AddWithValue("@remark6", this.remark6);
            cmd.Parameters.AddWithValue("@remark7", this.remark7);
            cmd.Parameters.AddWithValue("@remark8", this.remark8);
            cmd.Parameters.AddWithValue("@remark9", this.remark9);
            cmd.Parameters.AddWithValue("@remark10", this.remark10);
            cmd.Parameters.AddWithValue("@remark11", this.remark11);
            cmd.Parameters.AddWithValue("@remark12", this.remark12);
            cmd.Parameters.AddWithValue("@remark13", this.remark13);
            cmd.Parameters.AddWithValue("@rg10", this.rg10);
            cmd.Parameters.AddWithValue("@indication1", this.indication1);
            cmd.Parameters.AddWithValue("@indication2", this.indication2);
            cmd.Parameters.AddWithValue("@attendant1", this.attendant1);
            cmd.Parameters.AddWithValue("@attendant2", this.attendant2);
            cmd.Parameters.AddWithValue("@cab1", this.cab1);
            cmd.Parameters.AddWithValue("@cab2", this.cab2);
            cmd.Parameters.AddWithValue("@ridel1", this.ridel1);
            cmd.Parameters.AddWithValue("@ridel2", this.ridel2);
            cmd.Parameters.AddWithValue("@ridel3", this.ridel3);
            cmd.Parameters.AddWithValue("@ridel4", this.ridel4);
            cmd.Parameters.AddWithValue("@ridel5", this.ridel5);
            cmd.Parameters.AddWithValue("@r8th1", this.r8th1);
            cmd.Parameters.AddWithValue("@r8th2", this.r8th2);
            cmd.Parameters.AddWithValue("@r8th3", this.r8th3);
            cmd.Parameters.AddWithValue("@r8th4", this.r8th4);
            cmd.Parameters.AddWithValue("@r8th5", this.r8th5);
            cmd.Parameters.AddWithValue("@sidle1", this.sidle1);
            cmd.Parameters.AddWithValue("@sidle2", this.sidle2);
            cmd.Parameters.AddWithValue("@sidle3", this.sidle3);
            cmd.Parameters.AddWithValue("@sidle4", this.sidle4);
            cmd.Parameters.AddWithValue("@s8th1", this.s8th1);
            cmd.Parameters.AddWithValue("@s8th2", this.s8th2);
            cmd.Parameters.AddWithValue("@s8th3", this.s8th3);
            cmd.Parameters.AddWithValue("@s8th4", this.s8th4);
            cmd.Parameters.AddWithValue("@tidle1", this.tidle1);
            cmd.Parameters.AddWithValue("@tidle2", this.tidle2);
            cmd.Parameters.AddWithValue("@tidle3", this.tidle3);
            cmd.Parameters.AddWithValue("@tidle4", this.tidle4);
            cmd.Parameters.AddWithValue("@t8th1", this.t8th1);
            cmd.Parameters.AddWithValue("@t8th2", this.t8th2);
            cmd.Parameters.AddWithValue("@t8th3", this.t8th3);
            cmd.Parameters.AddWithValue("@t8th4", this.t8th4);
            cmd.Parameters.AddWithValue("@opMode", this.opMode);
            cmd.Parameters.AddWithValue("@dclv", this.dclv);
            cmd.Parameters.AddWithValue("@dcla", this.dcla);
            cmd.Parameters.AddWithValue("@gridkw", this.gridkw);
            cmd.Parameters.AddWithValue("@grid1a", this.grid1a);
            cmd.Parameters.AddWithValue("@grid2a", this.grid2a);
            cmd.Parameters.AddWithValue("@grid_blw1A", this.grid_blw1A);
            cmd.Parameters.AddWithValue("@grid_blw2A", this.grid_blw2A);
            cmd.Parameters.AddWithValue("@eng_rpm_db", this.eng_rpm_db);
            cmd.Parameters.AddWithValue("@db_post_s1", this.db_post_s1);
            cmd.Parameters.AddWithValue("@db_post_s2", this.db_post_s2);
            cmd.Parameters.AddWithValue("@db_post_s3", this.db_post_s3);
            cmd.Parameters.AddWithValue("@db_post_s4", this.db_post_s4);
            cmd.Parameters.AddWithValue("@db_post_s5", this.db_post_s5);
            cmd.Parameters.AddWithValue("@db_post_s6", this.db_post_s6);
            cmd.Parameters.AddWithValue("@db_post_s7", this.db_post_s7);
            cmd.Parameters.AddWithValue("@db_post_s8", this.db_post_s8);
            cmd.Parameters.AddWithValue("@db_post_l1", this.db_post_l1);
            cmd.Parameters.AddWithValue("@db_post_l2", this.db_post_l2);
            cmd.Parameters.AddWithValue("@db_post_l3", this.db_post_l3);
            cmd.Parameters.AddWithValue("@db_post_l4", this.db_post_l4);
            cmd.Parameters.AddWithValue("@db_post_l5", this.db_post_l5);
            cmd.Parameters.AddWithValue("@db_post_l6", this.db_post_l6);
            cmd.Parameters.AddWithValue("@db_post_l7", this.db_post_l7);
            cmd.Parameters.AddWithValue("@db_post_l8", this.db_post_l8);
            cmd.Parameters.AddWithValue("@th_pos", this.th_pos);
            cmd.Parameters.AddWithValue("@th_idl", this.th_idl);
            cmd.Parameters.AddWithValue("@dbntco", this.dbntco);
            cmd.Parameters.AddWithValue("@db17t", this.db17t);
            cmd.Parameters.AddWithValue("@db21t", this.db21t);
            cmd.Parameters.AddWithValue("@tl24t", this.tl24t);
            cmd.Parameters.AddWithValue("@rhsf", this.rhsf);
            cmd.Parameters.AddWithValue("@rhsr", this.rhsr);
            cmd.Parameters.AddWithValue("@ldunit", this.ldunit);
            cmd.Parameters.AddWithValue("@dvr_bcp1", this.dvr_bcp1);
            cmd.Parameters.AddWithValue("@dvr_8th", this.dvr_8th);
            cmd.Parameters.AddWithValue("@dvr_bp1", this.dvr_bp1);
            cmd.Parameters.AddWithValue("@dvr_bp2", this.dvr_bp2);
            cmd.Parameters.AddWithValue("@dvr_aux1", this.dvr_aux1);
            cmd.Parameters.AddWithValue("@dvr_aux2", this.dvr_aux2);
            cmd.Parameters.AddWithValue("@dvr_ph_ab1", this.dvr_ph_ab1);
            cmd.Parameters.AddWithValue("@dvr_ph_bc1", this.dvr_ph_bc1);
            cmd.Parameters.AddWithValue("@dvr_ph_ca1", this.dvr_ph_ca1);
            cmd.Parameters.AddWithValue("@dvr_ph_ab2", this.dvr_ph_ab2);
            cmd.Parameters.AddWithValue("@dvr_ph_bc2", this.dvr_ph_bc2);
            cmd.Parameters.AddWithValue("@dvr_ph_ca2", this.dvr_ph_ca2);
            cmd.Parameters.AddWithValue("@radi1_bp1", this.radi1_bp1);
            cmd.Parameters.AddWithValue("@radi1_bp2", this.radi1_bp2);
            cmd.Parameters.AddWithValue("@radi1_aux1", this.radi1_aux1);
            cmd.Parameters.AddWithValue("@radi1_aux2", this.radi1_aux2);
            cmd.Parameters.AddWithValue("@radi1_ph_ab1", this.radi1_ph_ab1);
            cmd.Parameters.AddWithValue("@radi1_ph_bc1", this.radi1_ph_bc1);
            cmd.Parameters.AddWithValue("@radi1_ph_ca1", this.radi1_ph_ca1);
            cmd.Parameters.AddWithValue("@radi1_ph_ab2", this.radi1_ph_ab2);
            cmd.Parameters.AddWithValue("@radi1_ph_bc2", this.radi1_ph_bc2);
            cmd.Parameters.AddWithValue("@radi1_ph_ca2", this.radi1_ph_ca2);
            cmd.Parameters.AddWithValue("@radi2_bp1", this.radi2_bp1);
            cmd.Parameters.AddWithValue("@radi2_bp2", this.radi2_bp2);
            cmd.Parameters.AddWithValue("@radi2_aux1", this.radi2_aux1);
            cmd.Parameters.AddWithValue("@radi2_aux2", this.radi2_aux2);
            cmd.Parameters.AddWithValue("@radi2_pf_ab1", this.radi2_pf_ab1);
            cmd.Parameters.AddWithValue("@radi2_pf_bc1", this.radi2_pf_bc1);
            cmd.Parameters.AddWithValue("@radi2_pf_ca1", this.radi2_pf_ca1);
            cmd.Parameters.AddWithValue("@radi2_pf_ab2", this.radi2_pf_ab2);
            cmd.Parameters.AddWithValue("@radi2_pf_bc2", this.radi2_pf_bc2);
            cmd.Parameters.AddWithValue("@radi2_pf_ca2", this.radi2_pf_ca2);
            cmd.Parameters.AddWithValue("@test_mu_s1", this.test_mu_s1);
            cmd.Parameters.AddWithValue("@test_mu_s2", this.test_mu_s2);
            cmd.Parameters.AddWithValue("@test_mu_s3", this.test_mu_s3);
            cmd.Parameters.AddWithValue("@test_mu_s4", this.test_mu_s4);
            cmd.Parameters.AddWithValue("@test_mu_s5", this.test_mu_s5);
            cmd.Parameters.AddWithValue("@test_mu_s6", this.test_mu_s6);
            cmd.Parameters.AddWithValue("@test_mu_s7", this.test_mu_s7);
            cmd.Parameters.AddWithValue("@test_mu_s8", this.test_mu_s8);
            cmd.Parameters.AddWithValue("@test_mu_s9", this.test_mu_s9);
            cmd.Parameters.AddWithValue("@test_mu_s10", this.test_mu_s10);
            //cmd.Parameters.AddWithValue("@test_mu_s11", this.test_mu_s11);
            cmd.Parameters.AddWithValue("@test_mu_s12", this.test_mu_s12);
            cmd.Parameters.AddWithValue("@test_mu_s13", this.test_mu_s13);
            cmd.Parameters.AddWithValue("@test_mu_s14", this.test_mu_s14);
            cmd.Parameters.AddWithValue("@test_mu_s15", this.test_mu_s15);
            cmd.Parameters.AddWithValue("@test_mu_s16", this.test_mu_s16);
            cmd.Parameters.AddWithValue("@test_mu_s17", this.test_mu_s17);
            cmd.Parameters.AddWithValue("@test_mu_s18", this.test_mu_s18);
            cmd.Parameters.AddWithValue("@test_mu_s19", this.test_mu_s19);
            cmd.Parameters.AddWithValue("@test_mu_l1", this.test_mu_l1);
            cmd.Parameters.AddWithValue("@test_mu_l2", this.test_mu_l2);
            cmd.Parameters.AddWithValue("@test_mu_l3", this.test_mu_l3);
            cmd.Parameters.AddWithValue("@test_mu_l4", this.test_mu_l4);
            cmd.Parameters.AddWithValue("@test_mu_l5", this.test_mu_l5);
            cmd.Parameters.AddWithValue("@test_mu_l6", this.test_mu_l6);
            cmd.Parameters.AddWithValue("@test_mu_l7", this.test_mu_l7);
            cmd.Parameters.AddWithValue("@test_mu_l8", this.test_mu_l8);
            cmd.Parameters.AddWithValue("@test_mu_l9", this.test_mu_l9);
            cmd.Parameters.AddWithValue("@test_mu_l0", this.test_mu_l0);
            cmd.Parameters.AddWithValue("@test_mu_l11", this.test_mu_l11);
            cmd.Parameters.AddWithValue("@test_mu_l12", this.test_mu_l12);
            cmd.Parameters.AddWithValue("@test_mu_l13", this.test_mu_l13);
            cmd.Parameters.AddWithValue("@test_mu_l14", this.test_mu_l14);
            cmd.Parameters.AddWithValue("@test_mu_l15", this.test_mu_l15);
            cmd.Parameters.AddWithValue("@test_mu_l16", this.test_mu_l16);
            cmd.Parameters.AddWithValue("@test_mu_l17", this.test_mu_l17);
            cmd.Parameters.AddWithValue("@test_mu_l18", this.test_mu_l18);
            cmd.Parameters.AddWithValue("@test_mu_l19", this.test_mu_l19);


            cmd.Connection.Open();
            Int16 n = Convert.ToInt16(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            return n;
        }
        catch
        {
            throw;
        }
    }

    public Int16 Insert_Data_IRC_FRC_2()
    {
        try
        {
            cmd = new SqlCommand("INSERT INTO scl_ele_irc_frc2        (id_sc_format,p_i_1_1, p_i_1_2, p_i_1_3, p300_i_1, p300_i_2, p300_i_3, p310_i_1, p310_i_2, p310_i_3, p320_i_1, p320_i_2, p320_i_3, p_8_1, p_8_2, p_8_3,                      p300_8_1, p300_8_2, p300_8_3, p310_8_1, p310_8_2, p310_8_3, p320_8_1, p320_8_2, p320_8_3, sh1, lh1, eng_rpm, eng_rpm1, eng_rp2, eng_rp3,                       eng_rp4, eng_rp5, eng_rp6, eng_rp7, eng_rp8, eng_rp9, lr, lr1, lr2, lr3, lr4, lr5, lr6, lr7, lr8, lr9, eng_hp, eng_hp1, eng_hp2, eng_hp3, eng_hp4, eng_hp5,                       eng_hp6, eng_hp7, eng_hp8, eng_hp9, tpu, tpu1, tpu2, tpu3, tpu4, tpu5, tpu6, tpu7, tpu8, tpu9, kwref, kwref1, kwref2, kwref3, kwref4, kwref5, kwref6,                       kwref7, kwref8, kwref9, kwfbk, kwfbk1, kwfbk2, kwfbk3, kwfbk4, kwfbk5, kwfbk6, kwfbk7, kwfbk8, kwfbk9, mga, mga1, mga2, mga3, mga4, mga5, mga6,                     mga7, mga8, mga9, mgv, mgv1, mgv2, mgv3, mgv4, mgv5, mgv6, mgv7, mgv8, mgv9, bar_pres, bar_pres1, bar_pres2, bar_pres3, bar_pres4,                       bar_pres5, bar_pres6, bar_pres7, bar_pres8, bar_pres9, tm_air, tm_air1, tm_air2, tm_air3, tm_air4, tm_air5, tm_air6, tm_air7, tm_air8, tm_air9,                      mg_field, mg_field1, mg_field2, mg_field3, mg_field4, mg_field5, mg_field6, mg_field7, mg_field8, mg_field9, mg_ct, mg_ct1, mg_ct2, mg_ct3, mg_ct4,                       mg_ct5, mg_ct6, mg_ct7, mg_ct8, mg_ct9, grid1, grid1_1, grid1_2, grid1_3, grid1_4, grid1_5, grid1_6, grid1_7, grid1_8, grid1_9, grid2, grid2_1, grid2_2,                      grid2_3, grid2_4, grid2_5, grid2_6, grid2_7, grid2_8, grid2_9, grid_blw1, grid_blw1_1, grid_blw1_2, grid_blw1_3, grid_blw1_4, grid_blw1_5,                     grid_blw1_6, grid_blw1_7, grid_blw1_8, grid_blw1_9, grid_blw2, grid_blw2_1, grid_blw2_2, grid_blw2_3, grid_blw2_4, grid_blw2_5, grid_blw2_6,                     grid_blw2_7, grid_blw2_8, grid_blw2_9, cav, cav1, cav2, cav3, cav4, cav5, cav6, cav7, cav8, cav9, etp1, etp1_1, etp1_2, etp1_3, etp1_4, etp1_5,                     etp1_6, etp1_7, etp1_8, etp1_9, etp2, etp2_1, etp2_2, etp2_3, etp2_4, etp2_5, etp2_6, etp2_7, etp2_8, etp2_9, rad1, rad1_1, rad1_2, rad1_3, rad1_4,                     rad1_5, rad1_6, rad1_7, rad1_8, rad1_9, rad2, rad2_1, rad2_2, rad2_3, rad2_4, rad2_5, rad2_6, rad2_7, rad2_8, rad2_9, ecc1, ecc11, ecc12, ecc13,                      ecc14, ecc15, ecc16, ecc17, ecc18, ecc19) VALUES  (@id_sc_format , @p_i_1_1, @p_i_1_2, @p_i_1_3, @p300_i_1, @p300_i_2, @p300_i_3, @p310_i_1, @p310_i_2, @p310_i_3, @p320_i_1, @p320_i_2, @p320_i_3, @p_8_1, @p_8_2, @p_8_3,                      @p300_8_1, @p300_8_2, @p300_8_3, @p310_8_1, @p310_8_2, @p310_8_3, @p320_8_1, @p320_8_2, @p320_8_3, @sh1, @lh1, @eng_rpm, @eng_rpm1, @eng_rp2, @eng_rp3,                       @eng_rp4, @eng_rp5, @eng_rp6, @eng_rp7, @eng_rp8, @eng_rp9, @lr, @lr1, @lr2, @lr3, @lr4, @lr5, @lr6, @lr7, @lr8, @lr9, @eng_hp, @eng_hp1, @eng_hp2, @eng_hp3, @eng_hp4, @eng_hp5,                       @eng_hp6, @eng_hp7, @eng_hp8, @eng_hp9, @tpu, @tpu1, @tpu2, @tpu3, @tpu4, @tpu5, @tpu6, @tpu7, @tpu8, @tpu9, @kwref, @kwref1, @kwref2, @kwref3, @kwref4, @kwref5, @kwref6,                       @kwref7, @kwref8, @kwref9, @kwfbk, @kwfbk1, @kwfbk2, @kwfbk3, @kwfbk4, @kwfbk5, @kwfbk6, @kwfbk7, @kwfbk8, @kwfbk9, @mga, @mga1, @mga2, @mga3, @mga4, @mga5, @mga6,                     @mga7, @mga8, @mga9, @mgv, @mgv1, @mgv2, @mgv3, @mgv4, @mgv5, @mgv6, @mgv7, @mgv8, @mgv9, @bar_pres, @bar_pres1, @bar_pres2, @bar_pres3, @bar_pres4,                       @bar_pres5, @bar_pres6, @bar_pres7, @bar_pres8, @bar_pres9, @tm_air, @tm_air1, @tm_air2, @tm_air3, @tm_air4, @tm_air5, @tm_air6, @tm_air7, @tm_air8, @tm_air9,                      @mg_field, @mg_field1, @mg_field2, @mg_field3, @mg_field4, @mg_field5, @mg_field6, @mg_field7, @mg_field8, @mg_field9, @mg_ct, @mg_ct1, @mg_ct2, @mg_ct3, @mg_ct4,                       @mg_ct5, @mg_ct6, @mg_ct7, @mg_ct8, @mg_ct9, @grid1, @grid1_1, @grid1_2, @grid1_3, @grid1_4, @grid1_5, @grid1_6, @grid1_7, @grid1_8, @grid1_9, @grid2, @grid2_1, @grid2_2,                      @grid2_3, @grid2_4, @grid2_5, @grid2_6, @grid2_7, @grid2_8, @grid2_9, @grid_blw1, @grid_blw1_1, @grid_blw1_2, @grid_blw1_3, @grid_blw1_4, @grid_blw1_5,                     @grid_blw1_6, @grid_blw1_7, @grid_blw1_8, @grid_blw1_9, @grid_blw2, @grid_blw2_1, @grid_blw2_2, @grid_blw2_3, @grid_blw2_4, @grid_blw2_5, @grid_blw2_6,                     @grid_blw2_7, @grid_blw2_8, @grid_blw2_9, @cav, @cav1, @cav2, @cav3, @cav4, @cav5, @cav6, @cav7, @cav8, @cav9, @etp1, @etp1_1, @etp1_2, @etp1_3, @etp1_4, @etp1_5,                     @etp1_6, @etp1_7, @etp1_8, @etp1_9, @etp2, @etp2_1, @etp2_2, @etp2_3, @etp2_4, @etp2_5, @etp2_6, @etp2_7, @etp2_8, @etp2_9, @rad1, @rad1_1, @rad1_2, @rad1_3, @rad1_4,                     @rad1_5, @rad1_6, @rad1_7, @rad1_8, @rad1_9, @rad2, @rad2_1, @rad2_2, @rad2_3, @rad2_4, @rad2_5, @rad2_6, @rad2_7, @rad2_8, @rad2_9, @ecc1, @ecc11, @ecc12, @ecc13,                      @ecc14, @ecc15, @ecc16, @ecc17, @ecc18, @ecc19)  ", cnn);
            cmd.Parameters.AddWithValue("@id_sc_format", this.id_sc_format);
            cmd.Parameters.AddWithValue("@p_i_1_1", this.p_i_1_1);
            cmd.Parameters.AddWithValue("@p_i_1_2",this.p_i_1_2);
            cmd.Parameters.AddWithValue("@p_i_1_3",this.p_i_1_3);
            cmd.Parameters.AddWithValue("@p300_i_1",this.p300_i_1);
            cmd.Parameters.AddWithValue("@p300_i_2",this.p300_i_2);
            cmd.Parameters.AddWithValue("@p300_i_3",this.p300_i_3);
            cmd.Parameters.AddWithValue("@p310_i_1",this.p310_i_1);
            cmd.Parameters.AddWithValue("@p310_i_2",this.p310_i_2);
            cmd.Parameters.AddWithValue("@p310_i_3",this.p310_i_3);
            cmd.Parameters.AddWithValue("@p320_i_1",this.p320_i_1);
            cmd.Parameters.AddWithValue("@p320_i_2",this.p320_i_2);
            cmd.Parameters.AddWithValue("@p320_i_3",this.p320_i_3);
            cmd.Parameters.AddWithValue("@p_8_1",this.p_8_1);
            cmd.Parameters.AddWithValue("@p_8_2",this.p_8_2);
            cmd.Parameters.AddWithValue("@p_8_3",this.p_8_3);
            cmd.Parameters.AddWithValue("@p300_8_1",this.p300_8_1);
            cmd.Parameters.AddWithValue("@p300_8_2",this.p300_8_2);
            cmd.Parameters.AddWithValue("@p300_8_3",this.p300_8_3);
            cmd.Parameters.AddWithValue("@p310_8_1",this.p310_8_1);
            cmd.Parameters.AddWithValue("@p310_8_2",this.p310_8_2);
            cmd.Parameters.AddWithValue("@p310_8_3",this.p310_8_3);
            cmd.Parameters.AddWithValue("@p320_8_1",this.p320_8_1);
            cmd.Parameters.AddWithValue("@p320_8_2",this.p320_8_2);
            cmd.Parameters.AddWithValue("@p320_8_3",this.p320_8_3);
            cmd.Parameters.AddWithValue("@sh1",this.sh1);
            cmd.Parameters.AddWithValue("@lh1",this.lh1);
            cmd.Parameters.AddWithValue("@eng_rpm",this.eng_rpm);
            cmd.Parameters.AddWithValue("@eng_rpm1",this.eng_rpm1);
            cmd.Parameters.AddWithValue("@eng_rp2",this.eng_rp2);
            cmd.Parameters.AddWithValue("@eng_rp3",this.eng_rp3);
            cmd.Parameters.AddWithValue("@eng_rp4",this.eng_rp4);
            cmd.Parameters.AddWithValue("@eng_rp5",this.eng_rp5);
            cmd.Parameters.AddWithValue("@eng_rp6",this.eng_rp6);
            cmd.Parameters.AddWithValue("@eng_rp7",this.eng_rp7);
            cmd.Parameters.AddWithValue("@eng_rp8",this.eng_rp8);
            cmd.Parameters.AddWithValue("@eng_rp9",this.eng_rp9);
            cmd.Parameters.AddWithValue("@lr",this.lr);
            cmd.Parameters.AddWithValue("@lr1",this.lr1);
            cmd.Parameters.AddWithValue("@lr2",this.lr2);
            cmd.Parameters.AddWithValue("@lr3",this.lr3);
            cmd.Parameters.AddWithValue("@lr4",this.lr4);
            cmd.Parameters.AddWithValue("@lr5",this.lr5);
            cmd.Parameters.AddWithValue("@lr6",this.lr6);
            cmd.Parameters.AddWithValue("@lr7",this.lr7);
            cmd.Parameters.AddWithValue("@lr8",this.lr8);
            cmd.Parameters.AddWithValue("@lr9",this.lr9);
            cmd.Parameters.AddWithValue("@eng_hp",this.eng_hp);
            cmd.Parameters.AddWithValue("@eng_hp1",this.eng_hp1);
            cmd.Parameters.AddWithValue("@eng_hp2",this.eng_hp2);
            cmd.Parameters.AddWithValue("@eng_hp3",this.eng_hp3);
            cmd.Parameters.AddWithValue("@eng_hp4",this.eng_hp4);
            cmd.Parameters.AddWithValue("@eng_hp5",this.eng_hp5);
            cmd.Parameters.AddWithValue("@eng_hp6",this.eng_hp6);
            cmd.Parameters.AddWithValue("@eng_hp7",this.eng_hp7);
            cmd.Parameters.AddWithValue("@eng_hp8",this.eng_hp8);
            cmd.Parameters.AddWithValue("@eng_hp9",this.eng_hp9);
            cmd.Parameters.AddWithValue("@tpu",this.tpu);
            cmd.Parameters.AddWithValue("@tpu1",this.tpu1);
            cmd.Parameters.AddWithValue("@tpu2",this.tpu2);
            cmd.Parameters.AddWithValue("@tpu3",this.tpu3);
            cmd.Parameters.AddWithValue("@tpu4",this.tpu4);
            cmd.Parameters.AddWithValue("@tpu5",this.tpu5);
            cmd.Parameters.AddWithValue("@tpu6",this.tpu6);
            cmd.Parameters.AddWithValue("@tpu7",this.tpu7);
            cmd.Parameters.AddWithValue("@tpu8",this.tpu8);
            cmd.Parameters.AddWithValue("@tpu9",this.tpu9);
            cmd.Parameters.AddWithValue("@kwref",this.kwref);
            cmd.Parameters.AddWithValue("@kwref1",this.kwref1);
            cmd.Parameters.AddWithValue("@kwref2",this.kwref2);
            cmd.Parameters.AddWithValue("@kwref3",this.kwref3);
            cmd.Parameters.AddWithValue("@kwref4",this.kwref4);
            cmd.Parameters.AddWithValue("@kwref5",this.kwref5);
            cmd.Parameters.AddWithValue("@kwref6",this.kwref6);
            cmd.Parameters.AddWithValue("@kwref7",this.kwref7);
            cmd.Parameters.AddWithValue("@kwref8",this.kwref8);
            cmd.Parameters.AddWithValue("@kwref9",this.kwref9);
            cmd.Parameters.AddWithValue("@kwfbk",this.kwfbk);
            cmd.Parameters.AddWithValue("@kwfbk1",this.kwfbk1);
            cmd.Parameters.AddWithValue("@kwfbk2",this.kwfbk2);
            cmd.Parameters.AddWithValue("@kwfbk3",this.kwfbk3);
            cmd.Parameters.AddWithValue("@kwfbk4",this.kwfbk4);
            cmd.Parameters.AddWithValue("@kwfbk5",this.kwfbk5);
            cmd.Parameters.AddWithValue("@kwfbk6",this.kwfbk6);
            cmd.Parameters.AddWithValue("@kwfbk7",this.kwfbk7);
            cmd.Parameters.AddWithValue("@kwfbk8",this.kwfbk8);
            cmd.Parameters.AddWithValue("@kwfbk9",this.kwfbk9);
            cmd.Parameters.AddWithValue("@mga",this.mga);
            cmd.Parameters.AddWithValue("@mga1",this.mga1);
            cmd.Parameters.AddWithValue("@mga2",this.mga2);
            cmd.Parameters.AddWithValue("@mga3",this.mga3);
            cmd.Parameters.AddWithValue("@mga4",this.mga4);
            cmd.Parameters.AddWithValue("@mga5",this.mga5);
            cmd.Parameters.AddWithValue("@mga6",this.mga6);
            cmd.Parameters.AddWithValue("@mga7",this.mga7);

            cmd.Parameters.AddWithValue("@mga8",this.mga8);
            cmd.Parameters.AddWithValue("@mga9",this.mga9);
            cmd.Parameters.AddWithValue("@mgv",this.mgv);
            cmd.Parameters.AddWithValue("@mgv1",this.mgv1);
            cmd.Parameters.AddWithValue("@mgv2",this.mgv2);
            cmd.Parameters.AddWithValue("@mgv3",this.mgv3);
            cmd.Parameters.AddWithValue("@mgv4",this.mgv4);
            cmd.Parameters.AddWithValue("@mgv5",this.mgv5);
            cmd.Parameters.AddWithValue("@mgv6",this.mgv6);
            cmd.Parameters.AddWithValue("@mgv7",this.mgv7);
            cmd.Parameters.AddWithValue("@mgv8",this.mgv8);
            cmd.Parameters.AddWithValue("@mgv9",this.mgv9);
            cmd.Parameters.AddWithValue("@bar_pres",this.bar_pres);
            cmd.Parameters.AddWithValue("@bar_pres1",this.bar_pres1);
            cmd.Parameters.AddWithValue("@bar_pres2",this.bar_pres2);
            cmd.Parameters.AddWithValue("@bar_pres3",this.bar_pres3);
            cmd.Parameters.AddWithValue("@bar_pres4",this.bar_pres4);
            cmd.Parameters.AddWithValue("@bar_pres5",this.bar_pres5);
            cmd.Parameters.AddWithValue("@bar_pres6",this.bar_pres6);
            cmd.Parameters.AddWithValue("@bar_pres7",this.bar_pres7);
            cmd.Parameters.AddWithValue("@bar_pres8",this.bar_pres8);
            cmd.Parameters.AddWithValue("@bar_pres9",this.bar_pres9);
            cmd.Parameters.AddWithValue("@tm_air",this.tm_air);
            cmd.Parameters.AddWithValue("@tm_air1",this.tm_air1);
            cmd.Parameters.AddWithValue("@tm_air2",this.tm_air2);
            cmd.Parameters.AddWithValue("@tm_air3",this.tm_air3);
            cmd.Parameters.AddWithValue("@tm_air4",this.tm_air4);
            cmd.Parameters.AddWithValue("@tm_air5",this.tm_air5);
            cmd.Parameters.AddWithValue("@tm_air6",this.tm_air6);
            cmd.Parameters.AddWithValue("@tm_air7",this.tm_air7);
            cmd.Parameters.AddWithValue("@tm_air8",this.tm_air8);
            cmd.Parameters.AddWithValue("@tm_air9",this.tm_air9);
            cmd.Parameters.AddWithValue("@mg_field",this.mg_field);
            cmd.Parameters.AddWithValue("@mg_field1",this.mg_field1);
            cmd.Parameters.AddWithValue("@mg_field2",this.mg_field2);
            cmd.Parameters.AddWithValue("@mg_field3",this.mg_field3);
            cmd.Parameters.AddWithValue("@mg_field4",this.mg_field4);
            cmd.Parameters.AddWithValue("@mg_field5",this.mg_field5);
            cmd.Parameters.AddWithValue("@mg_field6",this.mg_field6);
            cmd.Parameters.AddWithValue("@mg_field7",this.mg_field7);
            cmd.Parameters.AddWithValue("@mg_field8",this.mg_field8);
            cmd.Parameters.AddWithValue("@mg_field9",this.mg_field9);
            cmd.Parameters.AddWithValue("@mg_ct",this.mg_ct);
            cmd.Parameters.AddWithValue("@mg_ct1",this.mg_ct1);
            cmd.Parameters.AddWithValue("@mg_ct2",this.mg_ct2);
            cmd.Parameters.AddWithValue("@mg_ct3",this.mg_ct3);
            cmd.Parameters.AddWithValue("@mg_ct4",this.mg_ct4);
            cmd.Parameters.AddWithValue("@mg_ct5",this.mg_ct5);
            cmd.Parameters.AddWithValue("@mg_ct6",this.mg_ct6);
            cmd.Parameters.AddWithValue("@mg_ct7",this.mg_ct7);
            cmd.Parameters.AddWithValue("@mg_ct8",this.mg_ct8);
            cmd.Parameters.AddWithValue("@mg_ct9",this.mg_ct9);
            cmd.Parameters.AddWithValue("@grid1",this.grid1);
            cmd.Parameters.AddWithValue("@grid1_1",this.grid1_1);
            cmd.Parameters.AddWithValue("@grid1_2",this.grid1_2);
            cmd.Parameters.AddWithValue("@grid1_3",this.grid1_3);
            cmd.Parameters.AddWithValue("@grid1_4",this.grid1_4);
            cmd.Parameters.AddWithValue("@grid1_5",this.grid1_5);
            cmd.Parameters.AddWithValue("@grid1_6",this.grid1_6);
            cmd.Parameters.AddWithValue("@grid1_7",this.grid1_7);
            cmd.Parameters.AddWithValue("@grid1_8",this.grid1_8);
            cmd.Parameters.AddWithValue("@grid1_9",this.grid1_9);
            cmd.Parameters.AddWithValue("@grid2",this.grid2);
            cmd.Parameters.AddWithValue("@grid2_1",this.grid2_1);
            cmd.Parameters.AddWithValue("@grid2_2",this.grid2_2);
            cmd.Parameters.AddWithValue("@grid2_3",this.grid2_3);
            cmd.Parameters.AddWithValue("@grid2_4",this.grid2_4);
            cmd.Parameters.AddWithValue("@grid2_5",this.grid2_5);
            cmd.Parameters.AddWithValue("@grid2_6",this.grid2_6);
            cmd.Parameters.AddWithValue("@grid2_7",this.grid2_7);
            cmd.Parameters.AddWithValue("@grid2_8",this.grid2_8);
            cmd.Parameters.AddWithValue("@grid2_9",this.grid2_9);
            cmd.Parameters.AddWithValue("@grid_blw1",this.grid_blw1);
            cmd.Parameters.AddWithValue("@grid_blw1_1",this.grid_blw1_1);
            cmd.Parameters.AddWithValue("@grid_blw1_2",this.grid_blw1_2);
            cmd.Parameters.AddWithValue("@grid_blw1_3",this.grid_blw1_3);
            cmd.Parameters.AddWithValue("@grid_blw1_4",this.grid_blw1_4);
            cmd.Parameters.AddWithValue("@grid_blw1_5",this.grid_blw1_5);
            cmd.Parameters.AddWithValue("@grid_blw1_6",this.grid_blw1_6);
            cmd.Parameters.AddWithValue("@grid_blw1_7",this.grid_blw1_7);
            cmd.Parameters.AddWithValue("@grid_blw1_8",this.grid_blw1_8);
            cmd.Parameters.AddWithValue("@grid_blw1_9",this.grid_blw1_9);
            cmd.Parameters.AddWithValue("@grid_blw2",this.grid_blw2);
            cmd.Parameters.AddWithValue("@grid_blw2_1",this.grid_blw2_1);
            cmd.Parameters.AddWithValue("@grid_blw2_2",this.grid_blw2_2);
            cmd.Parameters.AddWithValue("@grid_blw2_3",this.grid_blw2_3);
            cmd.Parameters.AddWithValue("@grid_blw2_4",this.grid_blw2_4);
            cmd.Parameters.AddWithValue("@grid_blw2_5",this.grid_blw2_5);
            cmd.Parameters.AddWithValue("@grid_blw2_6",this.grid_blw2_6);
            cmd.Parameters.AddWithValue("@grid_blw2_7",this.grid_blw2_7);
            cmd.Parameters.AddWithValue("@grid_blw2_8",this.grid_blw2_8);
            cmd.Parameters.AddWithValue("@grid_blw2_9",this.grid_blw2_9);
            
            cmd.Parameters.AddWithValue("@cav",this.cav);
            cmd.Parameters.AddWithValue("@cav1",this.cav1);
            cmd.Parameters.AddWithValue("@cav2",this.cav2);
            cmd.Parameters.AddWithValue("@cav3",this.cav3);
            cmd.Parameters.AddWithValue("@cav4",this.cav4);
            cmd.Parameters.AddWithValue("@cav5",this.cav5);
            cmd.Parameters.AddWithValue("@cav6",this.cav6);
            cmd.Parameters.AddWithValue("@cav7",this.cav7);
            cmd.Parameters.AddWithValue("@cav8",this.cav8);
            cmd.Parameters.AddWithValue("@cav9",this.cav9);
            
            cmd.Parameters.AddWithValue("@etp1",this.etp1);
            cmd.Parameters.AddWithValue("@etp1_1",this.etp1_1);
            cmd.Parameters.AddWithValue("@etp1_2",this.etp1_2);
            cmd.Parameters.AddWithValue("@etp1_3",this.etp1_3);
            cmd.Parameters.AddWithValue("@etp1_4",this.etp1_4);
            cmd.Parameters.AddWithValue("@etp1_5",this.etp1_5);
            cmd.Parameters.AddWithValue("@etp1_6",this.etp1_6);
            cmd.Parameters.AddWithValue("@etp1_7",this.etp1_7);
            cmd.Parameters.AddWithValue("@etp1_8",this.etp1_8);
            cmd.Parameters.AddWithValue("@etp1_9",this.etp1_9);

            cmd.Parameters.AddWithValue("@etp2",this.etp2);
            cmd.Parameters.AddWithValue("@etp2_1",this.etp2_1);
            cmd.Parameters.AddWithValue("@etp2_2",this.etp2_2);
            cmd.Parameters.AddWithValue("@etp2_3",this.etp2_3);
            cmd.Parameters.AddWithValue("@etp2_4",this.etp2_4);
            cmd.Parameters.AddWithValue("@etp2_5",this.etp2_5);
            cmd.Parameters.AddWithValue("@etp2_6",this.etp2_6);
            cmd.Parameters.AddWithValue("@etp2_7",this.etp2_7);
            cmd.Parameters.AddWithValue("@etp2_8",this.etp2_8);
            cmd.Parameters.AddWithValue("@etp2_9",this.etp2_9);


            cmd.Parameters.AddWithValue("@rad1",this.rad1);
            cmd.Parameters.AddWithValue("@rad1_1",this.rad1_1);
            cmd.Parameters.AddWithValue("@rad1_2",this.rad1_2);
            cmd.Parameters.AddWithValue("@rad1_3",this.rad1_3);
            cmd.Parameters.AddWithValue("@rad1_4",this.rad1_4);
            cmd.Parameters.AddWithValue("@rad1_5",this.rad1_5);
            cmd.Parameters.AddWithValue("@rad1_6",this.rad1_6);
            cmd.Parameters.AddWithValue("@rad1_7",this.rad1_7);
            cmd.Parameters.AddWithValue("@rad1_8",this.rad1_8);
            cmd.Parameters.AddWithValue("@rad1_9",this.rad1_9);

            cmd.Parameters.AddWithValue("@rad2",this.rad2);
            cmd.Parameters.AddWithValue("@rad2_1",this.rad2_1);
            cmd.Parameters.AddWithValue("@rad2_2",this.rad2_2);
            cmd.Parameters.AddWithValue("@rad2_3",this.rad2_3);
            cmd.Parameters.AddWithValue("@rad2_4",this.rad2_4);
            cmd.Parameters.AddWithValue("@rad2_5",this.rad2_5);
            cmd.Parameters.AddWithValue("@rad2_6",this.rad2_6);
            cmd.Parameters.AddWithValue("@rad2_7",this.rad2_7);
            cmd.Parameters.AddWithValue("@rad2_8",this.rad2_8);
            cmd.Parameters.AddWithValue("@rad2_9",this.rad2_9);

            cmd.Parameters.AddWithValue("@ecc1",this.ecc1);
            cmd.Parameters.AddWithValue("@ecc11",this.ecc11);
            cmd.Parameters.AddWithValue("@ecc12",this.ecc12);
            cmd.Parameters.AddWithValue("@ecc13",this.ecc13);
            cmd.Parameters.AddWithValue("@ecc14",this.ecc14);
            cmd.Parameters.AddWithValue("@ecc15",this.ecc15);
            cmd.Parameters.AddWithValue("@ecc16",this.ecc16);
            cmd.Parameters.AddWithValue("@ecc17",this.ecc17);
            cmd.Parameters.AddWithValue("@ecc18",this.ecc18);
            cmd.Parameters.AddWithValue("@ecc19",this.ecc19);

            
            cmd.Connection.Open();
            Int16 n = Convert.ToInt16(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            return n;

        }
        catch
        {
            throw;
        }
    }


}
