using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

public partial class LocoShedPosition_Railway_OutAge : System.Web.UI.Page
{
    
    public void Insert_Outage()
    {
        Cls_Master_Outage c = new Cls_Master_Outage();
        c.Locotype = "1";
        c.OutageDate = System.DateTime.Now.Month.ToString() + "/" + System.DateTime.Now.Day.ToString() + "/" + System.DateTime.Now.Year.ToString();
        Int64 m = c.Insert_Data();
        //INSERT HOLDING DATE
        Cls_Outage_Holding c5 = new Cls_Outage_Holding();
        c5.Id_Outage = m.ToString();
        c5.LocoType = "BG";
        c5.book = txtBGHoldingBook.Text;
        c5.eff = txtBGHoldingEff.Text;
        c5.Insert_Data();
        c5.Id_Outage = m.ToString();
        c5.LocoType = "MG";
        c5.book = txtMGHoldingBook.Text;
        c5.eff = txtMGHoldingEff.Text;
        c5.Insert_Data();
        //INSERT CUM DATA
        Cls_Outage_Cum c6 = new Cls_Outage_Cum();
        c6.Id_Outage = m.ToString();
        c6.LocoType = "BG";
        c6.tar = txtTar.Text;
        c6.act = txtAct.Text;
        c6.dead = txtDead1.Text;
        c6.Insert_Data();
        c6.Id_Outage = m.ToString();
        c6.LocoType = "MG";
        c6.tar = txtTar2.Text;
        c6.act = txtact2.Text;
        c6.dead = txtDead2.Text;
        c6.Insert_Data();
        c.Id_Outage = m.ToString();
        c.guage = "BG";
        c.tar = txtTar1.Text;
        c.net = txtNet.Text;
        c.fois = txtFois.Text;
        c.Insert_Outage();
        c.Id_Outage = m.ToString();
        c.guage = "MG";
        c.tar = txtMGTar1.Text;
        c.net = txtMGNet1.Text;
        c.fois = txtFois.Text;
        c.Insert_Outage();
        //INSERT DATE IN  Outage_Sub1
        Cls_Outage_Sub1 c1 = new Cls_Outage_Sub1();
        //MG
        c1.SBIHR = txtsbihrMG.Text;
        c1.SBILR = txtsbilrMG.Text;
        c1.SBIUR = txtsbiurMG.Text;
        c1.Dead = txtDeadMG.Text;
        c1.OtherDiv = txtOtherDivMG.Text;
        c1.LieOver = txtLieOverMG.Text;
        c1.Id_Outage = m.ToString();
        c1.guage = "MG";
        c1.Insert_Data();
        //BG
        c1.SBIHR = txtsbihrBG.Text;
        c1.SBILR = txtsbilrBG.Text;
        c1.SBIUR = txtsbiurBG.Text;
        c1.Dead = txtDeadBG.Text;
        c1.OtherDiv = txtOtherDivBG.Text;
        c1.LieOver = txtLieOverBG.Text;
        c1.guage = "BG";
        c1.Id_Outage = m.ToString();
        c1.Insert_Data();
        //INSET DATE IN OutAge_Sub2
        Cls_OutAge_Sub2 c2 = new Cls_OutAge_Sub2();
        c2.Failures = txt1.Text;
        c2.AvgLOC = txt2.Text;
        c2.AvgGear = txt3.Text;
        c2.AvgCompressor = txt4.Text;
        c2.SpecificFuel = txt5.Text;
        c2.AvgRunniung = txt6.Text;
        c2.Id_Outage = m.ToString();
        c2.Insert_Data();
        //INSET MONTHELY  OUTAGE
        
        Cls_Monthly_Outage c3 = new Cls_Monthly_Outage();
        //Jan
        if (txtJan.Text != "" && txtJan1.Text != "")
        {
            c3.Mnth = "1";
            c3.year = System.DateTime.Now.Year.ToString();
            c3.target = txtJan.Text;
            c3.actual = txtJan1.Text;
            c3.Id_Outage = m.ToString();
            if (!c3.Check_Existance())
            {
                c3.Insert_Data();
            }
            else
            {
                c3.Id_Monthly_OutAge = c3.Get_IdByMonth_n_Year().ToString();
                c3.Update_Data();
            }
        }
        //Feb
        if (txtFeb.Text != "" && txtFeb1.Text != "")
        {
            c3.Mnth = "2";
            c3.target = txtFeb.Text;
            c3.actual = txtFeb1.Text;
            c3.year = System.DateTime.Now.Year.ToString();
            c3.Id_Outage = m.ToString();
            if (!c3.Check_Existance())
            {
                c3.Insert_Data();
            }
            else
            {
                c3.Id_Monthly_OutAge = c3.Get_IdByMonth_n_Year().ToString();
                c3.Update_Data();
            }
        }
        //March
        if (txtMarch.Text != "" && txtMarch1.Text != "")
        {
            c3.Mnth = "3";
            c3.target = txtMarch.Text;
            c3.actual = txtMarch1.Text;
            c3.year = System.DateTime.Now.Year.ToString();
            c3.Id_Outage = m.ToString();
            if (!c3.Check_Existance())
            {
                c3.Insert_Data();
            }
            else
            {
                c3.Id_Monthly_OutAge = c3.Get_IdByMonth_n_Year().ToString();
                c3.Update_Data();
            }
        }
        //April
        if (txtApril.Text != "" && txtApril1.Text != "")
        {
            c3.Mnth = "4";
            c3.target = txtApril.Text;
            c3.actual = txtApril1.Text;
            c3.year = System.DateTime.Now.Year.ToString();
            c3.Id_Outage = m.ToString();
            if (!c3.Check_Existance())
            {
                c3.Insert_Data();
            }
            else
            {
                c3.Id_Monthly_OutAge = c3.Get_IdByMonth_n_Year().ToString();
                c3.Update_Data();
            }
        }
        //May
        if (txtMay.Text != "" && txtMay.Text != "")
        {
            c3.Mnth = "5";
            c3.target = txtMay.Text;
            c3.actual = txtMay1.Text;
            c3.year = System.DateTime.Now.Year.ToString();
            c3.Id_Outage = m.ToString();
            if (!c3.Check_Existance())
            {
                c3.Insert_Data();
            }
            else
            {
                c3.Id_Monthly_OutAge = c3.Get_IdByMonth_n_Year().ToString();
                c3.Update_Data();
            }
        }
        //June
        if (txtJune.Text != "" && txtJune1.Text != "")
        {
            c3.Mnth = "6";
            c3.target = txtJune.Text;
            c3.actual = txtJune1.Text;
            c3.year = System.DateTime.Now.Year.ToString();
            c3.Id_Outage = m.ToString();
            if (!c3.Check_Existance())
            {
                c3.Insert_Data();
            }
            else
            {
                c3.Id_Monthly_OutAge = c3.Get_IdByMonth_n_Year().ToString();
                c3.Update_Data();
            }
        }
        //July
        if (txtJuly.Text != "" && txtJuly1.Text != "")
        {
            c3.Mnth = "7";
            c3.target = txtJuly.Text;
            c3.actual = txtJuly1.Text;
            c3.year = System.DateTime.Now.Year.ToString();
            c3.Id_Outage = m.ToString();
            if (!c3.Check_Existance())
            {
                c3.Insert_Data();
            }
            else
            {
                c3.Id_Monthly_OutAge = c3.Get_IdByMonth_n_Year().ToString();
                c3.Update_Data();
            }
        }
        //August
        if (txtAug.Text != "" && txtAug1.Text != "")
        {
            c3.Mnth = "8";
            c3.target = txtAug.Text;
            c3.actual = txtAug1.Text;
            c3.year = System.DateTime.Now.Year.ToString();
            c3.Id_Outage = m.ToString();
            if (!c3.Check_Existance())
            {
                c3.Insert_Data();
            }
            else
            {
                c3.Id_Monthly_OutAge = c3.Get_IdByMonth_n_Year().ToString();
                c3.Update_Data();
            }
        }
        //Sep
        if (txtSep.Text != "" && txtSep1.Text != "")
        {
            c3.Mnth = "9";
            c3.target = txtSep.Text;
            c3.actual = txtSep1.Text;
            c3.year = System.DateTime.Now.Year.ToString();
            c3.Id_Outage = m.ToString();
            if (!c3.Check_Existance())
            {
                c3.Insert_Data();
            }
            else
            {
                c3.Id_Monthly_OutAge = c3.Get_IdByMonth_n_Year().ToString();
                c3.Update_Data();
            }
        }
        //Oct
        if (txtOct.Text != "" && txtOct1.Text != "")
        {
            c3.Mnth = "10";
            c3.target = txtOct.Text;
            c3.actual = txtOct1.Text;
            c3.year = System.DateTime.Now.Year.ToString();
            c3.Id_Outage = m.ToString();
            if (!c3.Check_Existance())
            {
                c3.Insert_Data();
            }
            else
            {
                c3.Id_Monthly_OutAge = c3.Get_IdByMonth_n_Year().ToString();
                c3.Update_Data();
            }
        }
        //November
        if (txtNov.Text != "" && txtNov1.Text != "")
        {
            c3.Mnth = "11";
            c3.target = txtNov.Text;
            c3.actual = txtNov1.Text;
            c3.year = System.DateTime.Now.Year.ToString();
            c3.Id_Outage = m.ToString();
            if (!c3.Check_Existance())
            {
                c3.Insert_Data();
            }
            else
            {
                c3.Id_Monthly_OutAge = c3.Get_IdByMonth_n_Year().ToString();
                c3.Update_Data();
            }
        }
        //Dec
        if (txtDec.Text != "" && txtDec1.Text != "")
        {

            c3.Mnth = "12";
            c3.target = txtDec.Text;
            c3.actual = txtDec1.Text;
            c3.year = System.DateTime.Now.Year.ToString();
            c3.Id_Outage = m.ToString();
            if (!c3.Check_Existance())
            {
                c3.Insert_Data();
            }
            else
            {
                c3.Id_Monthly_OutAge = c3.Get_IdByMonth_n_Year().ToString();
                c3.Update_Data();
            }
        }
        

    }
    public void Clear_Data()
    {
        txt1.Text = "";
        txt2.Text = "";
        txt3.Text = "";
        txt4.Text = "";
        txt5.Text = "";
        txt6.Text = "";
        txtAct.Text = "";
        txtact2.Text = "";
        txtApril.Text = "";
        txtApril1.Text = ""; ;
        txtAug.Text = "";
        txtAug1.Text = "";
        txtBGHoldingBook.Text = "";
        txtBGHoldingEff.Text = "";
        txtDead1.Text = "";
        txtDead2.Text = "";
        txtDeadBG.Text = "";
        txtDeadMG.Text = "";
        txtDec.Text = "";
        txtDec1.Text = "";
        txtFeb.Text = "";
        txtFeb1.Text = "";
        txtFois.Text = "";
        txtJan.Text = "";
        txtJan1.Text = "";
        txtJuly.Text = "";
        txtJuly1.Text = "";
        txtJune.Text = "";
        txtJune1.Text = "";
        txtLieOverBG.Text = "";
        txtLieOverMG.Text = "";
        txtMarch.Text = "";
        txtMarch1.Text = "";
        txtMay.Text = "";
        txtMay1.Text = "";
        txtMGHoldingBook.Text = "";
        txtMGHoldingEff.Text = "";
        txtMGNet1.Text = "";
        txtMGTar1.Text = "";
        txtNet.Text = "";
        txtNov.Text = "";
        txtNov1.Text = "";
        txtOct.Text = "";
        txtOct1.Text = "";
        txtOtherDivBG.Text = "";
        txtOtherDivMG.Text = "";
        txtsbihrBG.Text = "";
        txtsbihrMG.Text = "";
        txtsbilrBG.Text = "";
        txtsbilrMG.Text = "";
        txtsbiurBG.Text = "";
        txtsbiurMG.Text = "";
        txtSep.Text = "";
        txtSep1.Text = "";
        txtTar.Text = "";
        txtTar1.Text = ""; ;
        txtTar2.Text = "";
        

    }
    public void Insert_OutageSub1()
    {
        Cls_Outage_Sub1 c = new Cls_Outage_Sub1();
        //MG
        c.SBIHR = txtsbihrMG.Text;
        c.SBILR = txtsbilrMG.Text;
        c.SBIUR = txtsbiurMG.Text;
        c.Dead = txtDeadMG.Text;
        c.OtherDiv = txtOtherDivMG.Text;
        c.LieOver = txtLieOverMG.Text;
        c.Insert_Data();
        //BG
        c.SBIHR = txtsbihrBG.Text;
        c.SBILR = txtsbilrBG.Text;
        c.SBIUR = txtsbiurBG.Text;
        c.Dead = txtDeadBG.Text;
        c.OtherDiv = txtOtherDivBG.Text;
        c.LieOver = txtLieOverBG.Text;
        c.Insert_Data();
    }
    public void Insert_OutageSub2()
    {
        Cls_OutAge_Sub2 c = new Cls_OutAge_Sub2();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            lblHeader.Text = "MONTHLY OUTAGE OF WDG4" + System.DateTime.Now.Year.ToString();
        }
    }
    protected void btnSave_OnClick(object sender, EventArgs e)
    {
        Insert_Outage();
        Clear_Data();
        lbshow.Visible = true;
        lbshow.Text = "Entered Successfully";
       
    }
}
