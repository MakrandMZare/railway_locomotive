<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true"
    CodeFile="Railway_OutAge.aspx.cs" Inherits="LocoShedPosition_Railway_OutAge"
    Title="Sabarmati Diesels : Loco" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <script type="text/javascript" language="javascript">
function Validation()
{
    if(document.getElementById('<%=txtBGHoldingBook.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter 0");
        document.getElementById('<%=txtBGHoldingBook.ClientID %>').focus();
        return false;
    }
   
    if(document.getElementById('<%= txtBGHoldingEff.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter 0");
        document.getElementById('<%= txtBGHoldingEff.ClientID %>').focus();
        return false;
    }
    if(document.getElementById('<%= txt1.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter 0");
        document.getElementById('<%= txt1.ClientID %>').focus();
        return false;
    }
    if(document.getElementById('<%= txt2.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter 0");
        document.getElementById('<%= txt2.ClientID %>').focus();
        return false;
    }
    if(document.getElementById('<%= txtTar1.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter 0");
        document.getElementById('<%= txtTar1.ClientID %>').focus();
        return false;
    }
    if(document.getElementById('<%= txtNet.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter 0");
        document.getElementById('<%= txtNet.ClientID %>').focus();
        return false;
    }
    if(document.getElementById('<%= txtTar.ClientID %>').value == "")
    {
         alert("IF you Have no Value then enter 0");
         document.getElementById('<%= txtTar.ClientID %>').focus();
         return false;
    }
        if(document.getElementById('<%= txtAct.ClientID %>').value == "")
        {
            alert("IF you Have no Value then enter 0");
            document.getElementById('<%= txtAct.ClientID %>').focus();
            return false;
        }
        if(document.getElementById('<%= txtDead1.ClientID %>').value == "")
        {
            alert("IF you Have no Value then enter 0");
            document.getElementById('<%= txtDead1.ClientID %>').focus();
            return false;
        }
        if(document.getElementById('<%= txtMGHoldingBook.ClientID %>').value == "")
        {
            alert("IF you Have no Value then enter 0");
            document.getElementById('<%= txtMGHoldingBook.ClientID %>').focus();
            return false;
        }
         if(document.getElementById('<%= txtMGHoldingEff.ClientID %>').value == "")
        {
            alert("IF you Have no Value then enter 0");
            document.getElementById('<%= txtMGHoldingEff.ClientID %>').focus();
            return false;
        }
         if(document.getElementById('<%= txtMGTar1.ClientID %>').value == "")
        {
            alert("IF you Have no Value then enter 0");
            document.getElementById('<%= txtMGTar1.ClientID %>').focus();
            return false;
        }
         if(document.getElementById('<%= txtMGNet1.ClientID %>').value == "")
        {
            alert("IF you Have no Value then enter 0");
            document.getElementById('<%= txtMGNet1.ClientID %>').focus();
            return false;
        }
         if(document.getElementById('<%= txtTar2.ClientID %>').value == "")
        {
            alert("IF you Have no Value then enter 0");
            document.getElementById('<%= txtTar2.ClientID %>').focus();
            return false;
        }
         if(document.getElementById('<%= txtact2.ClientID %>').value == "")
        {
            alert("IF you Have no Value then enter 0");
            document.getElementById('<%= txtact2.ClientID %>').focus();
            return false;
        }
         if(document.getElementById('<%= txtDead2.ClientID %>').value == "")
        {
            alert("IF you Have no Value then enter 0");
            document.getElementById('<%= txtDead2.ClientID %>').focus();
            return false;
        }
         if(document.getElementById('<%= txtFois.ClientID %>').value == "")
        {
            alert("IF you Have no Value then enter 0");
            document.getElementById('<%= txtFois.ClientID %>').focus();
            return false;
        }
         if(document.getElementById('<%= txtsbihrMG.ClientID %>').value == "")
        {
            alert("IF you Have no Value then enter 0");
            document.getElementById('<%= txtsbihrMG.ClientID %>').focus();
            return false;
        }
         if(document.getElementById('<%= txtsbihrBG.ClientID %>').value == "")
        {
            alert("IF you Have no Value then enter 0");
            document.getElementById('<%= txtsbihrBG.ClientID %>').focus();
            return false;
        }
         if(document.getElementById('<%= txtsbilrMG.ClientID %>').value == "")
        {
            alert("IF you Have no Value then enter 0");
            document.getElementById('<%= txtsbilrMG.ClientID %>').focus();
            return false;
        }
         if(document.getElementById('<%= txtsbilrBG.ClientID %>').value == "")
        {
            alert("IF you Have no Value then enter 0");
            document.getElementById('<%= txtsbilrBG.ClientID %>').focus();
            return false;
        }
         if(document.getElementById('<%= txtsbiurMG.ClientID %>').value == "")
        {
            alert("IF you Have no Value then enter 0");
            document.getElementById('<%= txtsbiurMG.ClientID %>').focus();
            return false;
        }
         if(document.getElementById('<%= txtsbiurBG.ClientID %>').value == "")
        {
            alert("IF you Have no Value then enter 0");
            document.getElementById('<%= txtsbiurBG.ClientID %>').focus();
            return false;
        }
         if(document.getElementById('<%= txtDeadMG.ClientID %>').value == "")
        {
            alert("IF you Have no Value then enter 0");
            document.getElementById('<%= txtDeadMG.ClientID %>').focus();
            return false;
        }
        if(document.getElementById('<%= txtDeadBG.ClientID %>').value == "")
        {
            alert("IF you Have no Value then enter 0");
            document.getElementById('<%= txtDeadBG.ClientID %>').focus();
            return false;
        }
        if(document.getElementById('<%= txtOtherDivMG.ClientID %>').value == "")
        {
            alert("IF you Have no Value then enter 0");
            document.getElementById('<%= txtOtherDivMG.ClientID %>').focus();
            return false;
        }
        if(document.getElementById('<%= txtOtherDivBG.ClientID %>').value == "")
        {
            alert("IF you Have no Value then enter 0");
            document.getElementById('<%= txtOtherDivBG.ClientID %>').focus();
            return false;
        }
        if(document.getElementById('<%= txtLieOverMG.ClientID %>').value == "")
        {
            alert("IF you Have no Value then enter 0");
            document.getElementById('<%= txtLieOverMG.ClientID %>').focus();
            return false;
        }
        if(document.getElementById('<%= txtLieOverBG.ClientID %>').value == "")
        {
            alert("IF you Have no Value then enter 0");
            document.getElementById('<%= txtLieOverBG.ClientID %>').focus();
            return false;
        }
        if(document.getElementById('<%= txt3.ClientID %>').value == "")
        {
            alert("IF you Have no Value then enter 0");
            document.getElementById('<%= txt3.ClientID %>').focus();
            return false;
        }
        if(document.getElementById('<%= txt4.ClientID %>').value == "")
        {
            alert("IF you Have no Value then enter 0");
            document.getElementById('<%= txt4.ClientID %>').focus();
            return false;
        }
        if(document.getElementById('<%= txt5.ClientID %>').value == "")
        {
            alert("IF you Have no Value then enter 0");
            document.getElementById('<%= txt5.ClientID %>').focus();
            return false;
        }
        if(document.getElementById('<%= txt6.ClientID %>').value == "")
        {
            alert("IF you Have no Value then enter 0");
            document.getElementById('<%= txt6.ClientID %>').focus();
            return false;
        }
        if(document.getElementById('<%= txtJan.ClientID %>').value == "")
        {
            alert("IF you Have no Value then enter 0");
            document.getElementById('<%= txt3.ClientID %>').focus();
            return false;
        }
        if(document.getElementById('<%= txtJan1.ClientID %>').value == "")
        {
            alert("IF you Have no Value then enter 0");
            document.getElementById('<%= txtJan1.ClientID %>').focus();
            return false;
        }
        if(document.getElementById('<%= txtFeb.ClientID %>').value == "")
        {
            alert("IF you Have no Value then enter 0");
            document.getElementById('<%= txtFeb.ClientID %>').focus();
            return false;
        }
        if(document.getElementById('<%= txtFeb1.ClientID %>').value == "")
        {
            alert("IF you Have no Value then enter 0");
            document.getElementById('<%= txtFeb1.ClientID %>').focus();
            return false;
        }
        if(document.getElementById('<%= txtMarch.ClientID %>').value == "")
        {
            alert("IF you Have no Value then enter 0");
            document.getElementById('<%= txtMarch.ClientID %>').focus();
            return false;
        }
        if(document.getElementById('<%= txtApril.ClientID %>').value == "")
        {
            alert("IF you Have no Value then enter 0");
            document.getElementById('<%= txtApril.ClientID %>').focus();
            return false;
        }
        if(document.getElementById('<%= txtApril1.ClientID %>').value == "")
        {
            alert("IF you Have no Value then enter 0");
            document.getElementById('<%= txtApril1.ClientID %>').focus();
            return false;
        }
        if(document.getElementById('<%= txtMay.ClientID %>').value == "")
        {
            alert("IF you Have no Value then enter 0");
            document.getElementById('<%= txtMay.ClientID %>').focus();
            return false;
        }
        if(document.getElementById('<%= txtMay1.ClientID %>').value == "")
        {
            alert("IF you Have no Value then enter 0");
            document.getElementById('<%= txtMay1.ClientID %>').focus();
            return false;
        }
        if(document.getElementById('<%= txtJune.ClientID %>').value == "")
        {
            alert("IF you Have no Value then enter 0");
            document.getElementById('<%= txtJune.ClientID %>').focus();
            return false;
        }
        if(document.getElementById('<%= txtJune1.ClientID %>').value == "")
        {
            alert("IF you Have no Value then enter 0");
            document.getElementById('<%= txtJune1.ClientID %>').focus();
            return false;
        }
        if(document.getElementById('<%= txtJuly.ClientID %>').value == "")
        {
            alert("IF you Have no Value then enter 0");
            document.getElementById('<%= txtJuly.ClientID %>').focus();
            return false;
        }
        if(document.getElementById('<%= txtJuly1.ClientID %>').value == "")
        {
            alert("IF you Have no Value then enter 0");
            document.getElementById('<%= txtJuly1.ClientID %>').focus();
            return false;
        }
        if(document.getElementById('<%= txtAug.ClientID %>').value == "")
        {
            alert("IF you Have no Value then enter 0");
            document.getElementById('<%= txtAug.ClientID %>').focus();
            return false;
        }
        if(document.getElementById('<%= txtAug1.ClientID %>').value == "")
        {
            alert("IF you Have no Value then enter 0");
            document.getElementById('<%= txtAug1.ClientID %>').focus();
            return false;
        }
        if(document.getElementById('<%= txtSep.ClientID %>').value == "")
        {
            alert("IF you Have no Value then enter 0");
            document.getElementById('<%= txtSep.ClientID %>').focus();
            return false;
        }
        if(document.getElementById('<%= txtSep1.ClientID %>').value == "")
        {
            alert("IF you Have no Value then enter 0");
            document.getElementById('<%= txtSep1.ClientID %>').focus();
            return false;
        }
        if(document.getElementById('<%= txtOct.ClientID %>').value == "")
        {
            alert("IF you Have no Value then enter 0");
            document.getElementById('<%= txtOct.ClientID %>').focus();
            return false;
        }
        if(document.getElementById('<%= txtOct1.ClientID %>').value == "")
        {
            alert("IF you Have no Value then enter 0");
            document.getElementById('<%= txtOct1.ClientID %>').focus();
            return false;
        }
        if(document.getElementById('<%= txtNov.ClientID %>').value == "")
        {
            alert("IF you Have no Value then enter 0");
            document.getElementById('<%= txtNov.ClientID %>').focus();
            return false;
        }
        if(document.getElementById('<%= txtNov1.ClientID %>').value == "")
        {
            alert("IF you Have no Value then enter 0");
            document.getElementById('<%= txtNov1.ClientID %>').focus();
            return false;
        }
        if(document.getElementById('<%= txtDec.ClientID %>').value == "")
        {
            alert("IF you Have no Value then enter 0");
            document.getElementById('<%= txtDec.ClientID %>').focus();
            return false;
        }
        if(document.getElementById('<%= txtDec1.ClientID %>').value == "")
        {
            alert("IF you Have no Value then enter 0");
            document.getElementById('<%= txtDec1.ClientID %>').focus();
            return false;
        }
 
   
    else
    {
        return true;
    }
    return false;
}

    </script>

    <table cellspacing="1" cellpadding="0">
        <tr>
            <th colspan="50">
                LOCO OUT AGE DETAIL
            </th>
        </tr>
        <tr>
            <td>
                <table>
                    <tr>
                    <td>
                    <table>
                    
                    <tr>
                        <td colspan="10" align="center">OUTAGE
                        </td>
                    </tr>
                    <tr>
                        <td colspan="" rowspan="">
                        </td>
                        <td colspan="2" rowspan="">
                            HOLDING</td>
                        <td colspan="4" rowspan="">
                            FOIS</td>
                        <td colspan="" rowspan="">
                            DEAD</td>
                    </tr>
                    <tr>
                        <td colspan="" rowspan="">
                        </td>
                        <td colspan="" rowspan="">
                            BOOK</td>
                        <td colspan="" rowspan="">
                            EFF</td>
                        <td colspan="" rowspan="">
                            TAR</td>
                        <td colspan="" rowspan="">
                            NET</td>
                        <td colspan="2" rowspan="">
                            CUM</td>
                        <td rowspan="2" colspan="">
                            <asp:TextBox runat="server" ID="txtDead1" onfocus="ChangeStyle(this.id.toString());"
                             Text="0"   onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Height="16px" Width="40px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td colspan="" rowspan="">
                            BG</td>
                        <td colspan="" rowspan="">
                            <asp:TextBox runat="server" ID="txtBGHoldingBook" onfocus="ChangeStyle(this.id.toString());"
                            Text="0"    onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Height="16px" Width="40px"></asp:TextBox></td>
                        <td colspan="" rowspan="">
                            <asp:TextBox runat="server" ID="txtBGHoldingEff" onfocus="ChangeStyle(this.id.toString());"
                              Text="0"  onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Height="16px" Width="40px"></asp:TextBox></td>
                        <td colspan="" rowspan="">
                            <asp:TextBox runat="server" ID="txtTar1" onfocus="ChangeStyle(this.id.toString());"
                              Text="0"  onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Height="16px" Width="40px"></asp:TextBox></td>
                        <td colspan="" rowspan="">
                            <asp:TextBox runat="server" ID="txtNet" onfocus="ChangeStyle(this.id.toString());"
                             Text="0"   onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Height="16px" Width="40px" Visible="False"></asp:TextBox></td>
                        <td colspan="2" rowspan="">
                            <asp:TextBox runat="server" ID="txtFois" onfocus="ChangeStyle(this.id.toString());"
                            Text="0"    onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Height="16px" Width="40px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td colspan="" rowspan="">
                        </td>
                        <td colspan="" rowspan="">
                        </td>
                        <td colspan="" rowspan="">
                        </td>
                        <td colspan="" rowspan="">
                        </td>
                        <td colspan="" rowspan="">
                        </td>
                        <td colspan="" rowspan="">
                            Tar</td>
                        <td colspan="" rowspan="">
                            Act</td>
                        <td colspan="" rowspan="">
                        </td>
                    </tr>
                    <tr>
                        <td colspan="" rowspan="">
                            MG</td>
                        <td colspan="" rowspan="">
                            <asp:TextBox runat="server" ID="txtMGHoldingBook" onfocus="ChangeStyle(this.id.toString());"
                          Text="0"      onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Height="16px" Width="40px"></asp:TextBox></td>
                        <td colspan="" rowspan="">
                            <asp:TextBox runat="server" ID="txtMGHoldingEff" onfocus="ChangeStyle(this.id.toString());"
                               Text="0" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Height="16px" Width="40px"></asp:TextBox></td>
                        <td colspan="" rowspan="">
                            <asp:TextBox runat="server" ID="txtMGTar1" onfocus="ChangeStyle(this.id.toString());"
                            Text="0"    onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Height="16px" Width="40px"></asp:TextBox></td>
                        <td colspan="" rowspan="">
                            <asp:TextBox runat="server" ID="txtMGNet1" onfocus="ChangeStyle(this.id.toString());"
                             Text="0"   onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Height="16px" Width="40px" Visible="False"></asp:TextBox></td>
                        <td colspan="" rowspan="">
                            <asp:TextBox runat="server" ID="txtTar2" onfocus="ChangeStyle(this.id.toString());"
                               Text="0" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Height="16px" Width="40px"></asp:TextBox></td>
                        <td colspan="" rowspan="">
                            <asp:TextBox runat="server" ID="txtact2" onfocus="ChangeStyle(this.id.toString());"
                             Text="0"   onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Height="16px" Width="40px"></asp:TextBox></td>
                        <td colspan="" rowspan="">
                            <asp:TextBox runat="server" ID="txtDead2" onfocus="ChangeStyle(this.id.toString());"
                             Text="0"   onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Height="16px" Width="40px"></asp:TextBox></td>
                    </tr>
                        <tr>
                            <td colspan="" rowspan="">
                            </td>
                            <td colspan="" rowspan="">
                            <asp:TextBox runat="server" ID="txtTar" onfocus="ChangeStyle(this.id.toString());"
                             Text="0"   onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Height="16px" Width="40px" Visible="False"></asp:TextBox></td>
                            <td colspan="" rowspan="">
                            <asp:TextBox runat="server" ID="txtAct" onfocus="ChangeStyle(this.id.toString());"
                              Text="0"  onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Height="16px" Width="40px" Visible="False"></asp:TextBox></td>
                            <td colspan="" rowspan="">
                            </td>
                            <td colspan="" rowspan="">
                            </td>
                            <td colspan="" rowspan="">
                            </td>
                            <td colspan="" rowspan="">
                            </td>
                            <td colspan="" rowspan="">
                            </td>
                        </tr>
                    </table>
                    </td>
                    </tr>
                    
                    <asp:Label ID="lbshow" runat="server" Visible="False"></asp:Label></table>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
            </td>
            <td align="center">
                <b>MG </b>
            </td>
            <td align="center">
                <b>BG </b>
            </td>
        </tr>
        <tr>
            <td>
                SBI HR
            </td>
            <td>
                :
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtsbihrMG" onfocus="ChangeStyle(this.id.toString());"
                  Text="0"  onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtsbihrBG" onfocus="ChangeStyle(this.id.toString());"
                  Text="0"  onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                SBI LR
            </td>
            <td>
                :
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtsbilrMG" onfocus="ChangeStyle(this.id.toString());"
                 Text="0"   onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtsbilrBG" onfocus="ChangeStyle(this.id.toString());"
                 Text="0"   onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                SBI UR
            </td>
            <td>
                :
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtsbiurMG" onfocus="ChangeStyle(this.id.toString());"
                 Text="0"   onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtsbiurBG" onfocus="ChangeStyle(this.id.toString());"
               Text="0"     onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                DEAD
            </td>
            <td>
                :
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtDeadMG" onfocus="ChangeStyle(this.id.toString());"
                 Text="0"   onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtDeadBG" onfocus="ChangeStyle(this.id.toString());"
                  Text="0"  onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Other Div
            </td>
            <td>
                :
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtOtherDivMG" onfocus="ChangeStyle(this.id.toString());"
                  Text="0"  onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtOtherDivBG" onfocus="ChangeStyle(this.id.toString());"
                  Text="0"  onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                (-) Lie Over
            </td>
            <td>
                :
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtLieOverMG" onfocus="ChangeStyle(this.id.toString());"
                 Text="0"   onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtLieOverBG" onfocus="ChangeStyle(this.id.toString());"
                 Text="0"   onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                NET
            </td>
            <td>
                :
            </td>
            <td>
                <asp:Label runat="server" ID="lblNet" Text="..."></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <img src="../Images/Next-icon.png" height="10px" width="10px" alt="arrow" />
                SR / 100 LOCO HOLDING
            </td>
            <td>
                :
            </td>
            <td>
                <asp:TextBox runat="server" ID="txt1" onfocus="ChangeStyle(this.id.toString());"
                 Text="0"   onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <img src="../Images/Next-icon.png" height="10px" width="10px" alt="arrow" />
                AVERAGE LOC / 100 EKM
            </td>
            <td>
                :
            </td>
            <td>
                <asp:TextBox runat="server" ID="txt2" onfocus="ChangeStyle(this.id.toString());"
                Text="0"    onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <img src="../Images/Next-icon.png" height="10px" width="10px" alt="arrow" />AVERAGE
                GEAR CASE OIL
            </td>
            <td>
                :
            </td>
            <td>
                <asp:TextBox runat="server" ID="txt3" onfocus="ChangeStyle(this.id.toString());"
                  Text="0"  onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <img src="../Images/Next-icon.png" height="10px" width="10px" alt="arrow" />AVERAGE
                COMPRESSOR OIL
            </td>
            <td>
                :
            </td>
            <td>
                <asp:TextBox runat="server" ID="txt4" onfocus="ChangeStyle(this.id.toString());"
                  Text="0"  onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <img src="../Images/Next-icon.png" height="10px" width="10px" alt="arrow" />AVERAGE
                SPECIFIC FUEL CONSUMPTION
            </td>
            <td>
                :
            </td>
            <td>
                <asp:TextBox runat="server" ID="txt5" onfocus="ChangeStyle(this.id.toString());"
                Text="0"    onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <img src="../Images/Next-icon.png" height="10px" width="10px" alt="arrow" />AVERAGE
                RUNNING
            </td>
            <td>
                :
            </td>
            <td>
                <asp:TextBox runat="server" ID="txt6" onfocus="ChangeStyle(this.id.toString());"
                 Text="0"   onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <th colspan="50">
                <asp:Label runat="server" ID="lblHeader" Text=""></asp:Label>
            </th>
        </tr>
        <tr>
            <td>
                MONTH
            </td>
            <td>
            </td>
            <td>
                TARGET
            </td>
            <td>
                ACTUAL
            </td>
            <td>
                DIFFENANCE(%)
            </td>
        </tr>
        <tr>
            <td>
                JAN
            </td>
            <td>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtJan" onfocus="ChangeStyle(this.id.toString());"
                    Text="0.00" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtJan1" Text="0.00" onfocus="ChangeStyle(this.id.toString());"
                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t1">
                </asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                FEB
            </td>
            <td>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtFeb" onfocus="ChangeStyle(this.id.toString());"
                    Text="0.00" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtFeb1" onfocus="ChangeStyle(this.id.toString());"
                    Text="0.00" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                MARCH
            </td>
            <td>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtMarch" onfocus="ChangeStyle(this.id.toString());"
                    Text="0.00" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtMarch1" onfocus="ChangeStyle(this.id.toString());"
                    Text="0.00" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                APRIL
            </td>
            <td>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtApril" onfocus="ChangeStyle(this.id.toString());"
                    Text="35.2" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox runat="server" Text="31.87" ID="txtApril1" onfocus="ChangeStyle(this.id.toString());"
                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t1">
                </asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                MAY
            </td>
            <td>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtMay" onfocus="ChangeStyle(this.id.toString()); "
                    Text="37.9" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtMay1" onfocus="ChangeStyle(this.id.toString()); "
                    Text="35.48" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                JUNE
            </td>
            <td>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtJune" onfocus="ChangeStyle(this.id.toString());"
                    Text="37.9" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtJune1" onfocus="ChangeStyle(this.id.toString());"
                    Text="36.84" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                JULY
            </td>
            <td>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtJuly" onfocus="ChangeStyle(this.id.toString());"
                    Text="37.9" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtJuly1" onfocus="ChangeStyle(this.id.toString());"
                    Text="36.29" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                AUGUST
            </td>
            <td>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtAug" onfocus="ChangeStyle(this.id.toString());"
                    Text="39.71" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtAug1" onfocus="ChangeStyle(this.id.toString());"
                    Text="37.90" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                SEPTEBER
            </td>
            <td>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtSep" onfocus="ChangeStyle(this.id.toString());"
                    Text="39.71" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtSep1" onfocus="ChangeStyle(this.id.toString());"
                    Text="38.35" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                OCTOMBER
            </td>
            <td>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtOct" onfocus="ChangeStyle(this.id.toString());"
                    Text="39.71" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtOct1" onfocus="ChangeStyle(this.id.toString());"
                    Text="37.81" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                NOVEMBER
            </td>
            <td>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtNov" onfocus="ChangeStyle(this.id.toString());"
                    Text="41.5" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtNov1" onfocus="ChangeStyle(this.id.toString());"
                    Text="42.2" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                DECEMBER
            </td>
            <td>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtDec" onfocus="ChangeStyle(this.id.toString());"
                    Text="0.00" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtDec1" onfocus="ChangeStyle(this.id.toString());"
                    Text="0.00" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
                   
            </td>
        </tr>
        
        <tr>
            <td>
                <asp:Button runat="server" ID="btnSave" Text="INSERT" onfocus="ChangeStyle(this.id.toString());"
                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t2" OnClick="btnSave_OnClick"
                    OnClientClick="return Validation();" />
            </td>
        </tr>
    </table>
</asp:Content>
