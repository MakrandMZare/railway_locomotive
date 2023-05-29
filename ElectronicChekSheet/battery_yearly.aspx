<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true"
    CodeFile="battery_yearly.aspx.cs" Inherits="battery_section_battery_yearly" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table>
        <tr>
            <th colspan="16">
                BATTERY SECTION</th>
        </tr>
        <tr>
            <td colspan="9">
                <strong>SECTION : </strong>
                <asp:DropDownList ID="ddlSection" runat="server" AutoPostBack="True" CssClass="t1"
                    OnSelectedIndexChanged="ddlSection_SelectedIndexChanged">
                </asp:DropDownList></td>
            <td colspan="4">
            </td>
        </tr>
        <tr>
            <td colspan="9">
                <strong>CARD &nbsp; &nbsp; &nbsp; : </strong>
                <asp:DropDownList ID="ddlCard" runat="server" AutoPostBack="True" CssClass="t1" OnSelectedIndexChanged="ddlCard_SelectedIndexChanged" >
                </asp:DropDownList></td>
            <td colspan="4">
            </td>
        </tr>
        <tr>
            <td colspan="13">
            <asp:Panel ID="p1" runat="server" Visible="false">
            <table>
        <tr>
            <td colspan="3" style="width: 200px">
                <strong><span style="font-size: 11pt; font-family: Arial Narrow">CLASS</span></strong>
                <span style="font-size: 12pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    <strong>:</strong></span>
                <asp:DropDownList ID="ddlClass" runat="server" AutoPostBack="True" CssClass="t1"
                    OnSelectedIndexChanged="ddlClass_SelectedIndexChanged">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList></td>
            <td colspan="3">
                <span style="font-size: 12pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    <strong>LOCO NO</strong></span> <span style="font-size: 12pt; font-family: Arial;
                        mso-fareast-font-family: 'Times New Roman'; mso-ansi-language: EN-US; mso-fareast-language: EN-US;
                        mso-bidi-language: AR-SA"><strong>:</strong></span>
                <asp:DropDownList ID="ddlLocono" runat="server" AutoPostBack="True" CssClass="t1"
                    OnSelectedIndexChanged="ddlLocono_OnSelectedIndexChanged">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList></td>
            <td colspan="3">
                <span style="font-size: 12pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    <strong>SCHEDULE</strong></span> <span style="font-size: 12pt; font-family: Arial;
                        mso-fareast-font-family: 'Times New Roman'; mso-ansi-language: EN-US; mso-fareast-language: EN-US;
                        mso-bidi-language: AR-SA"><strong>:</strong></span>
                <asp:DropDownList ID="ddlSchedule" runat="server" CssClass="t1">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList></td>
            <td colspan="4">
                <span style="font-size: 12pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    <strong>Date</strong></span> <span style="font-size: 12pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                        mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                        <strong>:&nbsp; </strong></span>
                <asp:TextBox ID="txtdate" runat="server" CssClass="t1"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="5">
                <span style="font-size: 11pt; font-family: 'Arial Narrow'; mso-bidi-font-size: 12.0pt;
                    mso-fareast-font-family: 'Times New Roman'; mso-ansi-language: EN-US; mso-fareast-language: EN-US;
                    mso-bidi-language: AR-SA; mso-bidi-font-family: Arial"><strong>Name of Technician</strong></span>
                <span style="font-size: 12pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    <strong>:
                        <asp:TextBox ID="txtTech" runat="server" CssClass="t1"></asp:TextBox></strong></span></td>
            <td>
                <span style="font-size: 11pt; font-family: 'Arial Narrow'; mso-bidi-font-size: 12.0pt;
                    mso-fareast-font-family: 'Times New Roman'; mso-ansi-language: EN-US; mso-fareast-language: EN-US;
                    mso-bidi-language: AR-SA; mso-bidi-font-family: Arial"><strong>Timing</strong></span></td>
            <td colspan="3">
                <span style="font-size: 11pt; font-family: 'Arial Narrow'; mso-bidi-font-size: 12.0pt;
                    mso-fareast-font-family: 'Times New Roman'; mso-ansi-language: EN-US; mso-fareast-language: EN-US;
                    mso-bidi-language: AR-SA; mso-bidi-font-family: Arial"><strong>Work start</strong></span>
                <span style="font-size: 12pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    <strong>:
                        <asp:TextBox ID="txtstart" runat="server" CssClass="t1" Width="46px"></asp:TextBox></strong></span></td>
            <td colspan="4">
                <strong><span style="font-size: 11pt; font-family: 'Arial Narrow'; mso-bidi-font-size: 12.0pt;
                    mso-fareast-font-family: 'Times New Roman'; mso-ansi-language: EN-US; mso-fareast-language: EN-US;
                    mso-bidi-language: AR-SA; mso-bidi-font-family: Arial">Finish</span></strong>
                <span style="font-size: 12pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    <strong>:
                        <asp:TextBox ID="txtfinish" runat="server" CssClass="t1" Width="46px"></asp:TextBox></strong></span></td>
        </tr>
        <tr>
            <td colspan="5">
                <span style="font-size: 11pt; font-family: 'Arial Narrow'; mso-bidi-font-size: 12.0pt;
                    mso-fareast-font-family: 'Times New Roman'; mso-ansi-language: EN-US; mso-fareast-language: EN-US;
                    mso-bidi-language: AR-SA; mso-bidi-font-family: Arial"><strong>Name of Supervisor</strong></span>
                <span style="font-size: 12pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    <strong>:
                        <asp:TextBox ID="txtSuper" runat="server" CssClass="t1"></asp:TextBox></strong></span></td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
                <span style="font-size: 10pt; font-family: Arial; mso-bidi-font-size: 12.0pt; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    <strong>SL.NO.</strong></span></td>
            <td colspan="2">
                <span style="font-size: 10pt; font-family: Arial; mso-bidi-font-size: 12.0pt; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    <strong>ITEMS DESCRIPTION</strong></span></td>
            <td colspan="10">
                <span style="font-size: 10pt; font-family: Arial; mso-bidi-font-size: 12.0pt; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    <strong>REMARKS</strong></span></td>
        </tr>
        <tr>
            <td>
                1</td>
            <td>
                <span style="font-size: 8pt; font-family: Arial; mso-bidi-font-size: 12.0pt; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    Visual checkup of Cables /
                    <br />
                    Terminals for tightness.</span></td>
            <td>
                <span style="font-size: 12pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    <strong>:</strong></span></td>
            <td colspan="10">
                <asp:TextBox ID="TextBox6" runat="server" CssClass="t1" Height="38px" TextMode="MultiLine"
                    Width="632px"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                2</td>
            <td>
                <span style="font-size: 8pt; font-family: Arial; mso-bidi-font-size: 12.0pt; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    Check the battery voltage.</span></td>
            <td>
                <span style="font-size: 12pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    <strong>:</strong></span></td>
            <td colspan="10">
                <asp:TextBox ID="TextBox7" runat="server" CssClass="t1" Height="38px" TextMode="MultiLine"
                    Width="632px"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                3</td>
            <td>
                <span style="font-size: 8pt; font-family: Arial; mso-bidi-font-size: 12.0pt; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    Check the lock assembly of<br />
                    Covers.</span></td>
            <td>
                <span style="font-size: 12pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    <strong>:</strong></span></td>
            <td colspan="10">
                <asp:TextBox ID="TextBox8" runat="server" CssClass="t1" Height="38px" TextMode="MultiLine"
                    Width="632px"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                4</td>
            <td>
                <span style="font-size: 8pt; font-family: Arial; mso-bidi-font-size: 12.0pt; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    Vent plugs intact.</span></td>
            <td>
                <span style="font-size: 12pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    <strong>:</strong></span></td>
            <td colspan="10">
                <asp:TextBox ID="TextBox9" runat="server" CssClass="t1" Height="38px" TextMode="MultiLine"
                    Width="632px"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                5</td>
            <td>
                <span style="font-size: 8pt; font-family: Arial; mso-bidi-font-size: 12.0pt; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    Check for no Leakages / Excess<br />
                    dust inside.</span></td>
            <td>
                <span style="font-size: 12pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    <strong>:</strong></span></td>
            <td colspan="10">
                <asp:TextBox ID="TextBox10" runat="server" CssClass="t1" Height="38px" TextMode="MultiLine"
                    Width="632px"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                6</td>
            <td>
                <span style="font-size: 8pt; font-family: Arial; mso-bidi-font-size: 12.0pt; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    Check for low voltage grounding.</span></td>
            <td>
                <span style="font-size: 12pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    <strong>:</strong></span></td>
            <td colspan="10">
                <asp:TextBox ID="TextBox11" runat="server" CssClass="t1" Height="38px" TextMode="MultiLine"
                    Width="632px"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                7</td>
            <td>
                <span style="font-size: 8pt; font-family: Arial; mso-bidi-font-size: 12.0pt; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    Blowing &amp; cleaning with Washing
                    <br />
                    Soda.</span></td>
            <td>
                <span style="font-size: 12pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    <strong>:</strong></span></td>
            <td colspan="10">
                <asp:TextBox ID="TextBox12" runat="server" CssClass="t1" Height="38px" TextMode="MultiLine"
                    Width="632px"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                8</td>
            <td>
                <span style="font-size: 8pt; font-family: Arial; mso-bidi-font-size: 12.0pt; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    Terminal coating to be applied.</span></td>
            <td>
                <span style="font-size: 12pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    <strong>:</strong></span></td>
            <td colspan="10">
                <asp:TextBox ID="TextBox13" runat="server" CssClass="t1" Height="38px" TextMode="MultiLine"
                    Width="632px"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                9</td>
            <td>
                <span style="font-size: 8pt; font-family: Arial; mso-bidi-font-size: 12.0pt; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    Check battery leads for loose<br />
                    connections damages due to<br />
                    rubbing.</span></td>
            <td>
                <span style="font-size: 12pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    <strong>:</strong></span></td>
            <td colspan="10">
                <asp:TextBox ID="TextBox14" runat="server" CssClass="t1" Height="38px" TextMode="MultiLine"
                    Width="632px"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                10</td>
            <td>
                <span style="font-size: 8pt; font-family: Arial; mso-bidi-font-size: 12.0pt; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    Check battery containers for
                    <br />
                    damage</span></td>
            <td>
                <span style="font-size: 12pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    <strong>:</strong></span></td>
            <td colspan="10">
                <asp:TextBox ID="TextBox15" runat="server" CssClass="t1" Height="38px" TextMode="MultiLine"
                    Width="632px"></asp:TextBox></td>
        </tr>
        <tr>
            <td rowspan="7">
                11</td>
            <td rowspan="7">
                <span style="font-size: 8pt; font-family: Arial; mso-bidi-font-size: 12.0pt; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    Check Specific Gravity.</span></td>
            <td rowspan="7">
                <span style="font-size: 12pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    <strong>:</strong></span></td>
            <td align="center">
                1</td>
            <td align="center">
                2</td>
            <td align="center">
                3</td>
            <td align="center">
                4</td>
            <td align="center">
                5</td>
            <td align="center">
                6</td>
            <td align="center">
                7</td>
            <td align="center">
                8</td>
            <td align="center">
                9</td>
            <td align="center">
                10</td>
        </tr>
        <tr>
            <td align="center">
                <asp:TextBox ID="TextBox16" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox17" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox18" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox19" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox20" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox21" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox22" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox23" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox24" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox25" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="center">
                <asp:TextBox ID="TextBox26" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox27" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox28" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox29" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox30" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox31" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox32" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox33" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox34" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox35" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="center">
                <asp:TextBox ID="TextBox36" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox37" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox38" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox39" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox40" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox41" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox42" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox43" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox44" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox45" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="center">
                <asp:TextBox ID="TextBox46" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox47" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox48" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox49" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox50" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox51" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox52" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox53" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox54" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox55" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="center" rowspan="2">
                <asp:TextBox ID="TextBox56" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox57" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox58" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox59" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox60" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox61" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox62" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox63" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox64" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox65" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
        </tr>
        <tr>
        </tr>
        <tr>
            <td rowspan="8">
                12</td>
            <td rowspan="8">
                <span style="font-size: 8pt; font-family: Arial; mso-bidi-font-size: 12.0pt; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    Check Electrolyte level.</span></td>
            <td rowspan="8">
                <span style="font-size: 12pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    <strong>:</strong></span></td>
            <td align="center">
                1</td>
            <td align="center">
                2</td>
            <td align="center">
                3</td>
            <td align="center">
                4</td>
            <td align="center">
                5</td>
            <td align="center">
                6</td>
            <td align="center">
                7</td>
            <td align="center">
                8</td>
            <td align="center">
                9</td>
            <td align="center">
                10</td>
        </tr>
        <tr>
            <td align="center">
                <asp:TextBox ID="TextBox66" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox67" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox68" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox69" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox70" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox71" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox72" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox73" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox74" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox75" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="center">
                <asp:TextBox ID="TextBox76" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox77" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox78" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox79" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox80" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox81" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox82" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox83" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox84" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox85" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="center">
                <asp:TextBox ID="TextBox86" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox87" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox88" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox89" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox90" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox91" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox92" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox93" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox94" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox95" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="center">
                <asp:TextBox ID="TextBox96" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox97" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox98" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox99" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox100" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox101" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox102" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox103" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox104" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox105" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="center" rowspan="3">
                <asp:TextBox ID="TextBox106" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center" rowspan="3">
                <asp:TextBox ID="TextBox107" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center" rowspan="3">
                <asp:TextBox ID="TextBox108" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center" rowspan="3">
                <asp:TextBox ID="TextBox109" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center" rowspan="3">
                <asp:TextBox ID="TextBox110" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center" rowspan="3">
                <asp:TextBox ID="TextBox111" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center" rowspan="3">
                <asp:TextBox ID="TextBox112" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center" rowspan="3">
                <asp:TextBox ID="TextBox113" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center" rowspan="3">
                <asp:TextBox ID="TextBox114" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center" rowspan="3">
                <asp:TextBox ID="TextBox115" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
        </tr>
        <tr>
        </tr>
        <tr>
        </tr>
        <tr>
            <td rowspan="8">
                13</td>
            <td rowspan="8">
                <span style="font-size: 8pt; font-family: Arial; mso-bidi-font-size: 12.0pt; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    Record Cell Voltages</span></td>
            <td rowspan="8">
                <span style="font-size: 12pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    <strong>:</strong></span></td>
            <td align="center">
                1</td>
            <td align="center">
                2</td>
            <td align="center">
                3</td>
            <td align="center">
                4</td>
            <td align="center">
                5</td>
            <td align="center">
                6</td>
            <td align="center">
                7</td>
            <td align="center">
                8</td>
            <td align="center">
                9</td>
            <td align="center">
                10</td>
        </tr>
        <tr>
            <td align="center">
                <asp:TextBox ID="TextBox116" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox117" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox118" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox119" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox120" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox121" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox122" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox123" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox124" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox125" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="center">
                <asp:TextBox ID="TextBox126" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox127" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox128" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox129" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox130" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox131" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox132" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox133" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox134" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox135" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="center">
                <asp:TextBox ID="TextBox136" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox137" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox138" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox139" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox140" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox141" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox142" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox143" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox144" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox145" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="center">
                <asp:TextBox ID="TextBox146" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox147" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox148" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox149" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox150" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox151" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox152" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox153" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox154" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="TextBox155" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="center" rowspan="3">
                <asp:TextBox ID="TextBox156" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center" rowspan="3">
                <asp:TextBox ID="TextBox157" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center" rowspan="3">
                <asp:TextBox ID="TextBox158" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center" rowspan="3">
                <asp:TextBox ID="TextBox159" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center" rowspan="3">
                <asp:TextBox ID="TextBox160" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center" rowspan="3">
                <asp:TextBox ID="TextBox161" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center" rowspan="3">
                <asp:TextBox ID="TextBox162" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center" rowspan="3">
                <asp:TextBox ID="TextBox163" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center" rowspan="3">
                <asp:TextBox ID="TextBox164" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
            <td align="center" rowspan="3">
                <asp:TextBox ID="TextBox165" runat="server" CssClass="t1" Width="48px"></asp:TextBox></td>
        </tr>
        <tr>
        </tr>
        <tr>
        </tr>
        <tr>
            <td>
                14</td>
            <td>
                <span style="font-size: 8pt; font-family: Arial; mso-bidi-font-size: 12.0pt; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    Check each bank voltage.</span></td>
            <td>
                <span style="font-size: 12pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    <strong>:</strong></span></td>
            <td align="center" colspan="5">
                1</td>
            <td align="center" colspan="5">
                2</td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
            <td align="center" colspan="5">
                <asp:TextBox ID="TextBox166" runat="server" CssClass="t1" Width="304px"></asp:TextBox></td>
            <td align="center" colspan="5">
                <asp:TextBox ID="TextBox167" runat="server" CssClass="t1" Width="304px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="center" colspan="13">
                <asp:Button ID="btnInsert" runat="server" CssClass="t1" Height="33px" Text="INSERT"
                    Width="98px" OnClick="btnInsert_Click" />
                &nbsp;
                <asp:Button ID="btnCancel" runat="server" CssClass="t1" Height="33px" Text="CANCEL"
                    Width="98px" OnClick="btnCancel_Click" /></td>
        </tr>
    </table></asp:Panel>
            </td>
        </tr>
        </table>
        
</asp:Content>
