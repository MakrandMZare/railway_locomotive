<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true" CodeFile="TrectionMotor.aspx.cs" Inherits="ElectronicChekSheet_TrectionMotor" Title="Untitled Page" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
        <tr>
            <th colspan="12">
                <span style="font-size: 12pt; color: #000000; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    TRACTION MOTOR</span></th>
        </tr>
        <tr>
            <td colspan="13">
                <strong>SECTION : </strong>
                <asp:DropDownList ID="ddlSection" runat="server" AutoPostBack="True" CssClass="t1"
                    OnSelectedIndexChanged="ddlSection_SelectedIndexChanged">
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td colspan="13">
                <strong>CARD &nbsp; &nbsp; &nbsp; : </strong>
                <asp:DropDownList ID="ddlCard" runat="server" AutoPostBack="True" CssClass="t1" OnSelectedIndexChanged="ddlCard_SelectedIndexChanged" >
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td colspan="13">
            <asp:Panel ID="p1" runat="server" Visible="false">
            <table style="width: 866px">
        <tr>
            <td colspan="12">
                <span style="font-size: 11pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    <strong>CLASS </strong></span><span style="font-size: 11pt; font-family: 'Arial Narrow';
                        mso-fareast-font-family: 'Times New Roman'; mso-ansi-language: EN-US; mso-fareast-language: EN-US;
                        mso-bidi-language: AR-SA; mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial">
                        <strong>: </strong></span>
                <asp:DropDownList ID="ddlClass" runat="server" AutoPostBack="True" CssClass="t1"
                    OnSelectedIndexChanged="ddlClass_SelectedIndexChanged">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList>
                &nbsp; &nbsp;&nbsp; &nbsp;&nbsp;
                <span style="font-size: 12pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    <strong>LOCO NO</strong></span><span style="font-size: 11pt; font-family: 'Arial Narrow';
                        mso-fareast-font-family: 'Times New Roman'; mso-ansi-language: EN-US; mso-fareast-language: EN-US;
                        mso-bidi-language: AR-SA; mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial"><strong>:
                        </strong></span>
                <asp:DropDownList ID="ddlLocono" runat="server" AutoPostBack="True" CssClass="t1"
                    OnSelectedIndexChanged="ddlLocono_OnSelectedIndexChanged">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList>&nbsp; &nbsp; &nbsp;
                <span style="font-size: 12pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    <strong>SCHEDULE</strong></span><span style="font-size: 11pt; font-family: 'Arial Narrow'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial"><strong>:</strong></span><asp:DropDownList ID="ddlSchedule" runat="server" CssClass="t1">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList>
                &nbsp; &nbsp; &nbsp;
                <strong><span style="font-family: Arial">Date</span></strong>
                <strong><span style="font-size: 11pt; font-family: Arial Narrow">:</span></strong>
                <asp:TextBox ID="txtdate" runat="server" CssClass="t1"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="12">
                <span style="font-size: 11pt; font-family: 'Arial Narrow'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial"><strong>Name of Technician</strong></span><span
                        style="font-size: 11pt; font-family: 'Arial Narrow'; mso-fareast-font-family: 'Times New Roman';
                        mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                        mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial"><strong>:&nbsp;<asp:DropDownList ID="ddlTech" runat="server" CssClass="t1">
                            <asp:ListItem>SELECT</asp:ListItem>
                        </asp:DropDownList></strong></span>
                &nbsp; &nbsp; &nbsp; <span style="font-size: 11pt; font-family: 'Arial Narrow'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial"></span>
                <strong><span style="font-size: 11pt; font-family: 'Arial Narrow'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial">Timing : Work start <span
                        style="font-size: 11pt; font-family: 'Arial Narrow'; mso-fareast-font-family: 'Times New Roman';
                        mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                        mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial"><strong>: &nbsp;</strong></span><asp:TextBox ID="txtstart" runat="server" CssClass="t1" Width="43px"></asp:TextBox>
                    &nbsp; &nbsp; &nbsp; </span></strong>
                <strong><span style="font-size: 11pt"><span style="font-family: Arial Narrow">Finish</span><span
                        style="font-family: 'Arial Narrow'; mso-fareast-font-family: 'Times New Roman';
                        mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                        mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial">: &nbsp;</span></span></strong><asp:TextBox ID="txtfinish" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="6">
                <span style="font-size: 11pt; font-family: 'Arial Narrow'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial"><strong>Name of Supervisor
                    </strong></span><span style="font-size: 11pt; font-family: 'Arial Narrow'; mso-fareast-font-family: 'Times New Roman';
                        mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                        mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial"><strong>: <asp:DropDownList ID="ddlSuper" runat="server" CssClass="t1">
                            <asp:ListItem>SELECT</asp:ListItem>
                        </asp:DropDownList></strong></span></td>
        </tr>
        <tr>
            <td colspan="6">
                <span style="font-size: 11pt; font-family: 'Arial Narrow'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial"><strong>CHECK THE FOLLOWING
                        ITEMS OF TRACTION MOTOR</strong></span>
                <span style="font-size: 11pt; font-family: 'Arial Narrow'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial"><strong>:</strong></span></td>
        </tr>
        <tr>
            <td >
                <span style="font-size: 11pt; font-family: 'Arial Narrow'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial"><strong>SL.NO.</strong></span></td>
            <td >
                <span style="font-size: 11pt; font-family: 'Arial Narrow'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial"><strong>ITEM DISCRIPTION</strong></span></td>
            <td  align="center">
                <span style="font-size: 11pt; font-family: 'Arial Narrow'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial"><strong>TM-1</strong></span></td>
            <td  align="center">
                <span style="font-size: 11pt; font-family: 'Arial Narrow'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial"><strong>TM-2</strong></span></td>
            <td  align="center">
                <span style="font-size: 11pt; font-family: 'Arial Narrow'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial"><strong>TM-3</strong></span></td>
            <td  align="center">
                <span style="font-size: 11pt; font-family: 'Arial Narrow'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial"><strong>TM-4</strong></span></td>
            <td  align="center">
                <span style="font-size: 11pt; font-family: 'Arial Narrow'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial"><strong>TM-5</strong></span></td>
            <td  align="center">
                <span style="font-size: 11pt; font-family: 'Arial Narrow'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial"><strong>TM-6</strong></span></td>
        </tr>
        <tr>
            <td >
                1</td>
            <td >
                <span style="font-size: 11pt; font-family: 'Arial Narrow'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial">TM Sensor &amp; Locking
                    Plug/</span></td>
            <td  align="center">
                <asp:TextBox ID="TextBox1" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td  align="center">
                <asp:TextBox ID="TextBox2" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td  align="center">
                <asp:TextBox ID="TextBox3" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td  align="center">
                <asp:TextBox ID="TextBox4" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td  align="center">
                <asp:TextBox ID="TextBox5" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td  align="center">
                <asp:TextBox ID="TextBox6" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
        </tr>
        <tr>
            <td  rowspan="3" valign="top">
                2</td>
            <td >
                <span style="font-size: 11pt; font-family: 'Arial Narrow'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial">a. TM Cable</span></td>
            <td  align="center">
                <asp:TextBox ID="TextBox7" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td  align="center">
                <asp:TextBox ID="TextBox8" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td  align="center">
                <asp:TextBox ID="TextBox9" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td  align="center">
                <asp:TextBox ID="TextBox10" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td  align="center">
                <asp:TextBox ID="TextBox11" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td  align="center">
                <asp:TextBox ID="TextBox12" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
        </tr>
        <tr>
            <td >
                <span style="font-size: 11pt; font-family: 'Arial Narrow'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial">b. Sensor Cable</span></td>
            <td  align="center">
                <asp:TextBox ID="TextBox13" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td  align="center">
                <asp:TextBox ID="TextBox14" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td  align="center">
                <asp:TextBox ID="TextBox15" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td  align="center">
                <asp:TextBox ID="TextBox16" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td  align="center">
                <asp:TextBox ID="TextBox17" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td  align="center">
                <asp:TextBox ID="TextBox18" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
        </tr>
        <tr>
            <td >
                <span style="font-size: 11pt; font-family: 'Arial Narrow'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial">c. Earthing Cable</span></td>
            <td  align="center">
                <asp:TextBox ID="TextBox19" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td  align="center">
                <asp:TextBox ID="TextBox20" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td  align="center">
                <asp:TextBox ID="TextBox21" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td  align="center">
                <asp:TextBox ID="TextBox22" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td  align="center">
                <asp:TextBox ID="TextBox23" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td  align="center">
                <asp:TextBox ID="TextBox24" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
        </tr>
        <tr>
            <td >
                3</td>
            <td >
                <span style="font-size: 11pt; font-family: 'Arial Narrow'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial">Rubber Cleat &amp; Umbrella
                    Boot</span></td>
            <td  align="center">
                <asp:TextBox ID="TextBox25" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td  align="center">
                <asp:TextBox ID="TextBox26" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td  align="center">
                <asp:TextBox ID="TextBox27" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td  align="center">
                <asp:TextBox ID="TextBox28" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td  align="center">
                <asp:TextBox ID="TextBox29" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td  align="center">
                <asp:TextBox ID="TextBox30" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
        </tr>
        <tr>
            <td >
                4</td>
            <td >
                <span style="font-size: 11pt; font-family: 'Arial Narrow'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial">TM Inspection Covers &amp;
                    Bolt</span></td>
            <td  align="center">
                <asp:TextBox ID="TextBox31" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td  align="center">
                <asp:TextBox ID="TextBox32" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td  align="center">
                <asp:TextBox ID="TextBox33" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td  align="center">
                <asp:TextBox ID="TextBox34" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td  align="center">
                <asp:TextBox ID="TextBox35" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td  align="center">
                <asp:TextBox ID="TextBox36" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
        </tr>
        <tr>
            <td >
                5</td>
            <td >
                <span style="font-size: 11pt; font-family: 'Arial Narrow'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial">TM End shield cover bolts
                    38 mm</span></td>
            <td  align="center">
                <asp:TextBox ID="TextBox37" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td  align="center">
                <asp:TextBox ID="TextBox38" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td  align="center">
                <asp:TextBox ID="TextBox39" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td  align="center">
                <asp:TextBox ID="TextBox40" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td  align="center">
                <asp:TextBox ID="TextBox41" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td  align="center">
                <asp:TextBox ID="TextBox42" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
        </tr>
        <tr>
            <td >
                6</td>
            <td >
                <span style="font-size: 11pt; font-family: 'Arial Narrow'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial">TM End shield cover bolts
                    18 mm</span></td>
            <td  align="center">
                <asp:TextBox ID="TextBox43" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td  align="center">
                <asp:TextBox ID="TextBox44" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td  align="center">
                <asp:TextBox ID="TextBox45" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td  align="center">
                <asp:TextBox ID="TextBox46" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td  align="center">
                <asp:TextBox ID="TextBox47" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td  align="center">
                <asp:TextBox ID="TextBox48" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
        </tr>
        <tr>
            <td >
                7</td>
            <td >
                <span style="font-size: 11pt; font-family: 'Arial Narrow'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial">Open TM inspection covers
                    &amp; ensure 
                    <br />
                    no Foreign body presence (monthly)</span></td>
            <td  align="center">
                <asp:TextBox ID="TextBox49" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td  align="center">
                <asp:TextBox ID="TextBox50" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td  align="center">
                <asp:TextBox ID="TextBox51" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td  align="center">
                <asp:TextBox ID="TextBox52" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td  align="center">
                <asp:TextBox ID="TextBox53" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td  align="center">
                <asp:TextBox ID="TextBox54" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
        </tr>
         <tr>
            <td >
                8</td>
            <td >
                <span style="font-size: 11pt; font-family: 'Arial Narrow'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial">Check motors for any hit
                    marks and 
                    <br />
                    damage</span></td>
            <td  align="center">
                <asp:TextBox ID="TextBox55" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td  align="center">
                <asp:TextBox ID="TextBox56" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td  align="center">
                <asp:TextBox ID="TextBox57" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td  align="center">
                <asp:TextBox ID="TextBox58" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td  align="center">
                <asp:TextBox ID="TextBox59" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td  align="center">
                <asp:TextBox ID="TextBox60" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="10">
                <span style="font-size: 11pt; font-family: 'Arial Narrow'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial"><strong>CHECK THE FOLLOWING
                        ITEMS OF RADAR</strong></span></td>
        </tr>
        <tr>
            <td >
                <span style="font-size: 11pt; font-family: 'Arial Narrow'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial"><strong>SL.NO.</strong></span></td>
            <td >
                <span style="font-size: 11pt; font-family: 'Arial Narrow'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial"><strong>ITEMS DESCRIPTION</strong></span></td>
            <td colspan="10">
                <span style="font-size: 11pt; font-family: 'Arial Narrow'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial"><strong>REMARKS</strong></span></td>
        </tr>
         <tr>
            <td >
                1</td>
            <td >
                <span style="font-size: 11pt; font-family: 'Arial Narrow'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial">Radar Angle</span></td>
            <td colspan="10">
                <asp:TextBox ID="TextBox61" runat="server" CssClass="t1" Width="473px"></asp:TextBox></td>
        </tr>
        <tr>
            <td >
                2</td>
            <td >
                <span style="font-size: 11pt; font-family: 'Arial Narrow'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial">Radar Face Plate</span></td>
            <td colspan="10">
                <asp:TextBox ID="TextBox62" runat="server" CssClass="t1" Width="473px"></asp:TextBox></td>
        </tr>
        <tr>
            <td >
                3</td>
            <td >
                <span style="font-size: 11pt; font-family: 'Arial Narrow'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial">Radar Safety Guard</span></td>
            <td colspan="10">
                <asp:TextBox ID="TextBox63" runat="server" CssClass="t1" Width="473px"></asp:TextBox></td>
        </tr>
         <tr>
            <td >
                4</td>
            <td >
                <span style="font-size: 11pt; font-family: 'Arial Narrow'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial">Radar Plug</span></td>
            <td colspan="10">
                <asp:TextBox ID="TextBox64" runat="server" CssClass="t1" Width="473px"></asp:TextBox></td>
        </tr>
        <tr>
            <td >
                5</td>
            <td >
                <span style="font-size: 11pt; font-family: 'Arial Narrow'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial">Radar Self Test</span></td>
            <td align="left" colspan="10">
                <asp:TextBox ID="TextBox65" runat="server" CssClass="t1" Width="473px"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="12">
                <strong><span style="font-size: 11pt; font-family: 'Arial Narrow'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial"><span style="text-decoration: underline">
                        <span style="mso-spacerun: yes">&nbsp;</span>NOTE:</span></span><span style="font-size: 11pt;
                            font-family: 'Arial Narrow'; mso-fareast-font-family: 'Times New Roman'; mso-ansi-language: EN-US;
                            mso-fareast-language: EN-US; mso-bidi-language: AR-SA; mso-bidi-font-size: 12.0pt;
                            mso-bidi-font-family: Arial"> </span></strong><span style="font-size: 11pt; font-family: 'Arial Narrow';
                                mso-fareast-font-family: 'Times New Roman'; mso-ansi-language: EN-US; mso-fareast-language: EN-US;
                                mso-bidi-language: AR-SA; mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial">
                                Check all cables for any excessive hanging and improper routing</span></td>
        </tr>
        <tr>
            <td colspan="12">
                <p class="MsoNormal" style="margin: 0in 0in 0pt; tab-stops: .25in">
                    <b><span style="font-size: 9pt; font-family: Arial; mso-bidi-font-size: 12.0pt">CHECK
                        FAULT ARCHIVE &amp; RECORD SIGNIFICANT FAULTS UPTO LAST TRIP</span></b></p>
            </td>
        </tr>
        <tr>
            <td colspan="12">
                <asp:TextBox ID="TextBox66" runat="server" CssClass="t1" Height="66px" TextMode="MultiLine"
                    Width="473px"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="12" >
                <p class="MsoNormal" style="margin: 0in 0in 0pt">
                    <b><span style="font-size: 10pt; font-family: 'Arial Narrow'; mso-bidi-font-size: 12.0pt;
                        mso-bidi-font-family: Arial">LIST OF MATERIAL DRAWN FROM / RETURN TO STORES</span></b></p>
            </td>
        </tr>
        <tr>
            <td colspan="12" style="height: 82px">
                <asp:TextBox ID="TextBox67" runat="server" CssClass="t1" Height="66px" TextMode="MultiLine"
                    Width="473px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="center" colspan="12">
                <asp:Button ID="btnInsert" runat="server" CssClass="t1" Height="33px" OnClick="btnInsert_Click"
                    Text="INSERT" Width="98px" />&nbsp;
                <asp:Button ID="btnCancel" runat="server" CssClass="t1" Height="33px" OnClick="btnCancel_Click"
                    Text="CANCEL" Width="98px" /></td>
        </tr>
        
    </table>
            </asp:Panel>
            </td>
        </tr>
        <tr>
        
        </tr>
        </table>
        
    <cc1:toolkitscriptmanager id="ToolkitScriptManager1" runat="server"></cc1:toolkitscriptmanager>
    <cc1:calendarextender id="CalendarExtender1" runat="server" format="dd/MM/yyyy" targetcontrolid="txtdate"></cc1:calendarextender>
</asp:Content>

