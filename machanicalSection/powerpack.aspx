<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true"
    CodeFile="powerpack.aspx.cs" Inherits="machanicalSection_powerpack" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table>
        <tr>
            <th colspan="11">
                POWER PACK
            </th>
        </tr>
        <tr>
            <td colspan="17">
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
                &nbsp; &nbsp;&nbsp; &nbsp;&nbsp; <span style="font-size: 12pt; font-family: Arial;
                    mso-fareast-font-family: 'Times New Roman'; mso-ansi-language: EN-US; mso-fareast-language: EN-US;
                    mso-bidi-language: AR-SA"><strong>LOCO NO</strong></span><span style="font-size: 11pt;
                        font-family: 'Arial Narrow'; mso-fareast-font-family: 'Times New Roman'; mso-ansi-language: EN-US;
                        mso-fareast-language: EN-US; mso-bidi-language: AR-SA; mso-bidi-font-size: 12.0pt;
                        mso-bidi-font-family: Arial"><strong>: </strong></span>
                <asp:DropDownList ID="ddlLocono" runat="server" AutoPostBack="True" CssClass="t1">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList>&nbsp; &nbsp; &nbsp; <span style="font-size: 12pt; font-family: Arial;
                    mso-fareast-font-family: 'Times New Roman'; mso-ansi-language: EN-US; mso-fareast-language: EN-US;
                    mso-bidi-language: AR-SA"><strong>SCHEDULE</strong></span><span style="font-size: 11pt;
                        font-family: 'Arial Narrow'; mso-fareast-font-family: 'Times New Roman'; mso-ansi-language: EN-US;
                        mso-fareast-language: EN-US; mso-bidi-language: AR-SA; mso-bidi-font-size: 12.0pt;
                        mso-bidi-font-family: Arial"><strong>:</strong></span><asp:DropDownList ID="ddlSchedule"
                            runat="server" CssClass="t1">
                            <asp:ListItem>SELECT</asp:ListItem>
                        </asp:DropDownList>
                &nbsp; &nbsp; &nbsp; <strong><span style="font-family: Arial">Date</span></strong>
                <strong><span style="font-size: 11pt; font-family: Arial Narrow">:</span></strong>
                <asp:TextBox ID="txtdate" runat="server" CssClass="t1"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="17">
                <span style="font-size: 11pt; font-family: 'Arial Narrow'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial"><strong>Name of Technician</strong></span><span
                        style="font-size: 11pt; font-family: 'Arial Narrow'; mso-fareast-font-family: 'Times New Roman';
                        mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                        mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial"><strong>:&nbsp;<asp:DropDownList
                            ID="ddlhr" runat="server" CssClass="t1" >
                            <asp:ListItem>SELECT</asp:ListItem>
                        </asp:DropDownList></strong></span> &nbsp; &nbsp; &nbsp; <span style="font-size: 11pt;
                            font-family: 'Arial Narrow'; mso-fareast-font-family: 'Times New Roman'; mso-ansi-language: EN-US;
                            mso-fareast-language: EN-US; mso-bidi-language: AR-SA; mso-bidi-font-size: 12.0pt;
                            mso-bidi-font-family: Arial"></span><strong><span style="font-size: 11pt; font-family: 'Arial Narrow';
                                mso-fareast-font-family: 'Times New Roman'; mso-ansi-language: EN-US; mso-fareast-language: EN-US;
                                mso-bidi-language: AR-SA; mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial">
                                Timing : Work start <span style="font-size: 11pt; font-family: 'Arial Narrow'; mso-fareast-font-family: 'Times New Roman';
                                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                                    mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial"><strong>: &nbsp;</strong></span><asp:TextBox
                                        ID="txtstart" runat="server" CssClass="t1" Width="43px"></asp:TextBox>
                                &nbsp; &nbsp; &nbsp; </span></strong><strong><span style="font-size: 11pt"><span
                                    style="font-family: Arial Narrow">Finish</span><span style="font-family: 'Arial Narrow';
                                        mso-fareast-font-family: 'Times New Roman'; mso-ansi-language: EN-US; mso-fareast-language: EN-US;
                                        mso-bidi-language: AR-SA; mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial">:
                                        &nbsp;</span></span></strong><asp:TextBox ID="txtfinish" runat="server" CssClass="t1"
                                            Width="43px"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="11">
                <span style="font-size: 11pt; font-family: 'Arial Narrow'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial"><strong>Name of Supervisor
                    </strong></span><span style="font-size: 11pt; font-family: 'Arial Narrow'; mso-fareast-font-family: 'Times New Roman';
                        mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                        mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial"><strong>:
                            <asp:DropDownList ID="ddlhr2" runat="server" CssClass="t1">
                                <asp:ListItem>SELECT</asp:ListItem>
                            </asp:DropDownList></strong></span></td>
        </tr>
        <tr>
            <td >
                IRC LOAD TEST READING</td>
            <td >
            </td>
            <td >
            </td>
            <td >
            </td>
            <td >
            </td>
            <td >
            </td>
            <td >
            </td>
            <td >
            </td>
            <td >
            </td>
            <td >
            </td>
            <td >
            </td>
        </tr>
        <tr>
            <td >
                <span style="font-size: 12pt; font-family: 'Times New Roman'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    <strong>Throttle position</strong></span></td>
            <td >
                <span style="font-size: 12pt; font-family: 'Times New Roman'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    <strong>Idle</strong></span></td>
            <td >
                <span style="font-size: 12pt; font-family: 'Times New Roman'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    <strong>1</strong></span></td>
            <td >
                <span style="font-size: 12pt; font-family: 'Times New Roman'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    <strong>2</strong></span></td>
            <td >
                <span style="font-size: 12pt; font-family: 'Times New Roman'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    <strong>3</strong></span></td>
            <td >
                <span style="font-size: 12pt; font-family: 'Times New Roman'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    <strong>4</strong></span></td>
            <td >
                <span style="font-size: 12pt; font-family: 'Times New Roman'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    <strong>5</strong></span></td>
            <td >
                <span style="font-size: 12pt; font-family: 'Times New Roman'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    <strong>6</strong></span></td>
            <td >
                <span style="font-size: 12pt; font-family: 'Times New Roman'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    <strong>7</strong></span></td>
            <td >
                <span style="font-size: 12pt; font-family: 'Times New Roman'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    <strong>8</strong></span></td>
            <td >
                <span style="font-size: 12pt; font-family: 'Times New Roman'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    <strong>LT2</strong></span></td>
        </tr>
        <tr>
            <td >
                <span style="font-size: 12pt; font-family: 'Times New Roman'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    Engg, RPM</span></td>
            <td >
                <asp:TextBox ID="TextBox1" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox2" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox3" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox4" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox5" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox6" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox7" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox8" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox9" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox10" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
        </tr>
        <tr>
            <td >
                <span style="font-size: 12pt; font-family: 'Times New Roman'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    LR%</span></td>
            <td >
                <asp:TextBox ID="TextBox11" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox12" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox13" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox14" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox15" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox16" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox17" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox18" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox19" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox20" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
        </tr>
        <tr>
            <td >
                <span style="font-size: 12pt; font-family: 'Times New Roman'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    Eng.HP</span></td>
            <td >
                <asp:TextBox ID="TextBox21" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox22" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox23" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox24" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox25" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox26" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox27" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox28" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox29" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox30" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
        </tr>
        <tr>
            <td >
                <span style="font-size: 12pt; font-family: 'Times New Roman'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    TPU RPM</span></td>
            <td >
                <asp:TextBox ID="TextBox31" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox32" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox33" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox34" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox35" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox36" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox37" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox38" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox39" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox40" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
        </tr>
        <tr>
            <td >
                <span style="font-size: 12pt; font-family: 'Times New Roman'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    Eng Temp ºC</span></td>
            <td >
                <asp:TextBox ID="TextBox41" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox42" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox43" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox44" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox45" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox46" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox47" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox48" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox49" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox50" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
        </tr>
        <tr>
            <td >
                <span style="font-size: 12pt; font-family: 'Times New Roman'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    R.Fan1</span></td>
            <td >
                <asp:TextBox ID="TextBox51" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox52" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox53" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox54" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox55" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox56" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox57" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox58" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox59" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox60" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
        </tr>
        <tr>
            <td >
                <span style="font-size: 12pt; font-family: 'Times New Roman'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    R.Fan2</span></td>
            <td >
                <asp:TextBox ID="TextBox61" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox62" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox63" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox64" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox65" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox66" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox67" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox68" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox69" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox70" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
        </tr>
        <tr>
            <td >
                <span style="font-size: 12pt; font-family: 'Times New Roman'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    Lube oil pressure</span></td>
            <td >
                <asp:TextBox ID="TextBox71" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox72" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox73" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox74" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox75" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox76" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox77" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox78" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox79" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox80" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
        </tr>
        <tr>
            <td >
                <span style="font-size: 12pt; font-family: 'Times New Roman'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    Air box pressure</span></td>
            <td >
                <asp:TextBox ID="TextBox81" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox82" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox83" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox84" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox85" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox86" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox87" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox88" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox89" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox90" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
        </tr>
        <tr>
            <td >
                <span style="font-size: 12pt; font-family: 'Times New Roman'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    C C Vacuum</span></td>
            <td >
                <asp:TextBox ID="TextBox91" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox92" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox93" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox94" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox95" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox96" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox97" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox98" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox99" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox100" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
        </tr>
        <tr>
            <td >
                <span style="font-size: 12pt; font-family: 'Times New Roman'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    Turbo gear train pressure</span></td>
            <td >
                <asp:TextBox ID="TextBox101" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox102" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox103" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox104" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox105" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox106" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox107" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox108" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox109" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox110" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
        </tr>
        <tr>
            <td >
                <?xml namespace="" ns="urn:schemas-microsoft-com:office:smarttags" prefix="st1" ?><st1:place w:st="on"><st1:country-region w:st="on"><SPAN style="FONT-SIZE: 12pt; FONT-FAMILY: 'Times New Roman'; mso-fareast-font-family: 'Times New Roman'; mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">Eng.+</SPAN></st1:country-region></st1:place>
                <span style="font-size: 12pt; font-family: 'Times New Roman'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    Inertial</span></td>
            <td >
                <asp:TextBox ID="TextBox111" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox112" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox113" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox114" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox115" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox116" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox117" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox118" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox119" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox120" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
        </tr>
        <tr>
            <td >
            </td>
            <td >
            </td>
            <td >
            </td>
            <td >
            </td>
            <td >
            </td>
            <td >
            </td>
            <td >
            </td>
            <td >
            </td>
            <td >
            </td>
            <td >
            </td>
            <td >
            </td>
        </tr>
        <tr>
            <td colspan="5" >
            </td>
            <td colspan="3" >
                STATUS</td>
            <td colspan="3" >
                ACTION TAKEN</td>
        </tr>
        <tr>
            <td >
                <span style="font-size: 12pt; font-family: 'Times New Roman'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    OSTA Tripping RPM<span style="mso-spacerun: yes"> &nbsp; &nbsp; &nbsp; </span>(990-1045)<span
                        style="mso-spacerun: yes"> &nbsp; </span></span>
            </td>
            <td >
                </td>
            <td >
                </td>
            <td >
            </td>
            <td >
            </td>
            <td colspan="3">
                <asp:TextBox ID="TextBox121" runat="server" CssClass="t1" Width="163px"></asp:TextBox></td>
            <td colspan="3">
                <asp:TextBox ID="TextBox131" runat="server" CssClass="t1" Width="163px"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="5" >
                <span style="font-size: 12pt; font-family: 'Times New Roman'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    Differential Pressure across After Cooler<span style="mso-spacerun: yes"> <span style="font-size: 12pt;
                        font-family: 'Times New Roman'; mso-fareast-font-family: 'Times New Roman'; mso-ansi-language: EN-US;
                        mso-fareast-language: EN-US; mso-bidi-language: AR-SA">Inches of H<sub>2</sub>O
                        (25”Max—15”Max
                        for New)</span></span></span></td>
            <td colspan="3">
                <asp:TextBox ID="TextBox122" runat="server" CssClass="t1" Width="163px"></asp:TextBox></td>
            <td colspan="3">
                <asp:TextBox ID="TextBox132" runat="server" CssClass="t1" Width="163px"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="5"  >
                <span style="font-size: 12pt; font-family: 'Times New Roman'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    Compression Pressure readings in PSI<span style="font-size: 12pt; font-family: 'Times New Roman';
                        mso-fareast-font-family: 'Times New Roman'; mso-ansi-language: EN-US; mso-fareast-language: EN-US;
                        mso-bidi-language: AR-SA">:<span style="mso-spacerun: yes">&nbsp; </span>(275-350psi)</span></span></td>
            <td >
            </td>
            <td >
            </td>
            <td >
            </td>
            <td >
            </td>
            <td >
            </td>
            <td >
            </td>
        </tr>
        <tr>
            <td >
            </td>
            <td >
                <asp:TextBox ID="TextBox141" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox145" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox149" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox153" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
            </td>
            <td >
            </td>
            <td >
            </td>
            <td >
            </td>
            <td >
            </td>
            <td >
            </td>
        </tr>
        <tr>
            <td >
            </td>
            <td >
                <asp:TextBox ID="TextBox142" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox146" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox150" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox154" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
            </td>
            <td >
            </td>
            <td >
            </td>
            <td >
            </td>
            <td >
            </td>
            <td >
            </td>
        </tr>
        <tr>
            <td >
            </td>
            <td >
                <asp:TextBox ID="TextBox143" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox147" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox151" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox155" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox157" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
            </td>
            <td >
            </td>
            <td >
            </td>
            <td >
            </td>
            <td >
            </td>
        </tr>
        <tr>
            <td >
            </td>
            <td >
                <asp:TextBox ID="TextBox144" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox148" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox152" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
                <asp:TextBox ID="TextBox156" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td >
            </td>
            <td >
            </td>
            <td >
            </td>
            <td >
            </td>
            <td >
            </td>
            <td >
            </td>
        </tr>
        <tr>
            <td colspan="5" >
                <span style="font-size: 12pt; font-family: 'Times New Roman'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    Check exhaust screen fordebris/foreign material</span></td>
            <td colspan="3">
                <asp:TextBox ID="TextBox123" runat="server" CssClass="t1" Width="163px"></asp:TextBox></td>
            <td colspan="3">
                <asp:TextBox ID="TextBox133" runat="server" CssClass="t1" Width="163px"></asp:TextBox></td>
        </tr>
        <tr>
            <td >
                <span style="font-size: 12pt; font-family: 'Times New Roman'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    Check piston crown</span></td>
            <td >
                </td>
            <td >
                </td>
            <td >
            </td>
            <td >
            </td>
            <td colspan="3">
                <asp:TextBox ID="TextBox124" runat="server" CssClass="t1" Width="163px"></asp:TextBox></td>
            <td colspan="3">
                <asp:TextBox ID="TextBox134" runat="server" CssClass="t1" Width="163px"></asp:TextBox></td>
        </tr>
        <tr>
            <td >
                <span style="font-size: 12pt; font-family: 'Times New Roman'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    “Pee” Pipe alignment </span>
            </td>
            <td >
                </td>
            <td >
                </td>
            <td >
            </td>
            <td >
            </td>
            <td colspan="3">
                <asp:TextBox ID="TextBox125" runat="server" CssClass="t1" Width="163px"></asp:TextBox></td>
            <td colspan="3">
                <asp:TextBox ID="TextBox135" runat="server" CssClass="t1" Width="163px"></asp:TextBox></td>
        </tr>
        <tr>
            <td >
                <span style="font-size: 12pt; font-family: 'Times New Roman'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    Following Filters to change</span></td>
            <td >
                </td>
            <td >
                </td>
            <td >
            </td>
            <td >
            </td>
            <td colspan="3">
                <asp:TextBox ID="TextBox126" runat="server" CssClass="t1" Width="163px"></asp:TextBox></td>
            <td colspan="3">
                <asp:TextBox ID="TextBox136" runat="server" CssClass="t1" Width="163px"></asp:TextBox></td>
        </tr>
        <tr>
            <td >
                <span style="font-size: 12pt; font-family: 'Times New Roman'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    a) Turbo spin on</span></td>
            <td >
                </td>
            <td >
                </td>
            <td >
            </td>
            <td >
            </td>
            <td colspan="3">
                <asp:TextBox ID="TextBox127" runat="server" CssClass="t1" Width="163px"></asp:TextBox></td>
            <td colspan="3">
                <asp:TextBox ID="TextBox137" runat="server" CssClass="t1" Width="163px"></asp:TextBox></td>
        </tr>
        <tr>
            <td >
                <span style="font-size: 12pt; font-family: 'Times New Roman'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    b) Turbo soak back<span style="mso-spacerun: yes">&nbsp; </span></span>
            </td>
            <td >
                </td>
            <td >
                </td>
            <td >
            </td>
            <td >
            </td>
            <td colspan="3">
                <asp:TextBox ID="TextBox128" runat="server" CssClass="t1" Width="163px"></asp:TextBox></td>
            <td colspan="3">
                <asp:TextBox ID="TextBox138" runat="server" CssClass="t1" Width="163px"></asp:TextBox></td>
        </tr>
        <tr>
            <td >
                <span style="font-size: 12pt; font-family: 'Times New Roman'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    c) Baggie filters<span style="mso-spacerun: yes"> &nbsp; &nbsp; </span></span>
            </td>
            <td >
                </td>
            <td >
                </td>
            <td >
            </td>
            <td >
            </td>
            <td colspan="3">
                <asp:TextBox ID="TextBox129" runat="server" CssClass="t1" Width="163px"></asp:TextBox></td>
            <td colspan="3">
                <asp:TextBox ID="TextBox139" runat="server" CssClass="t1" Width="163px"></asp:TextBox></td>
        </tr>
        <tr>
            <td >
                <span style="font-size: 12pt; font-family: 'Times New Roman'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    Impeller condition (Visually)</span></td>
            <td >
                </td>
            <td >
                </td>
            <td >
            </td>
            <td >
            </td>
            <td colspan="3">
                <asp:TextBox ID="TextBox130" runat="server" CssClass="t1" Width="163px"></asp:TextBox></td>
            <td colspan="3">
                <asp:TextBox ID="TextBox140" runat="server" CssClass="t1" Width="163px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="center" colspan="11">
                <asp:Button ID="btnInsert" runat="server" CssClass="t1" Height="33px" OnClick="btnInsert_Click"
                    Text="INSERT" Width="98px" />
                &nbsp;
                <asp:Button ID="btnCancel" runat="server" CssClass="t1" Height="33px" OnClick="btnCancel_Click"
                    Text="CANCEL" Width="98px" /></td>
        </tr>
    </table>
</asp:Content>
