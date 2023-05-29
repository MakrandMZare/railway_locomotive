<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true" CodeFile="underTruck.aspx.cs" Inherits="machanicalSection_underTruck" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<table>
        <tr>
            <th colspan="12">
                UNDERTRUCK</th>
        </tr>
        <tr>
            <td>
                <strong>SECTION</strong></td>
            <td>
                :</td>
            <td>
                <asp:DropDownList ID="ddlSection" runat="server" AutoPostBack="True" CssClass="t1"
                    OnSelectedIndexChanged="ddlSection_SelectedIndexChanged">
                </asp:DropDownList></td>
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
            <td>
            </td>
        </tr>
        <tr>
            <td>
                CLASS</td>
            <td>
                :</td>
            <td>
                <asp:DropDownList ID="ddlClass" runat="server" AutoPostBack="True" CssClass="t1"
                    OnSelectedIndexChanged="ddlClass_SelectedIndexChanged">
                </asp:DropDownList></td>
            <td>
                LOCO NO</td>
            <td>
                :</td>
            <td>
                <asp:DropDownList ID="ddlLocono" runat="server" CssClass="t1">
                </asp:DropDownList></td>
            <td>
                SCHEDULE</td>
            <td>
                :</td>
            <td>
            <asp:DropDownList ID="ddlSchedule" runat="server" AutoPostBack="True"
                    CssClass="t1" OnSelectedIndexChanged="ddlSchedule_SelectedIndexChanged">
                </asp:DropDownList></td>
            <td>
                DATE</td>
            <td>
                :</td>
            <td>
                <asp:TextBox ID="txtdate" runat="server" CssClass="t1" Width="83px"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                NAME OF TECHNICIAN</td>
            <td>
                :</td>
            <td>
                <asp:DropDownList ID="ddlHr" runat="server" CssClass="t1">
                </asp:DropDownList></td>
            <td>
            </td>
            <td>
            </td>
            <td>
                SHIFT</td>
            <td>
                START TIME</td>
            <td>
                :</td>
            <td>
                <asp:TextBox ID="txtstart" runat="server" CssClass="t1" Width="40px"></asp:TextBox></td>
            <td>
                END TIME</td>
            <td>
            </td>
            <td>
                <asp:TextBox ID="txtfinish" runat="server" CssClass="t1" Width="40px"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                NAME OF SUPERVISOR</td>
            <td>
            </td>
            <td>
                <asp:DropDownList ID="ddlhr2" runat="server" CssClass="t1">
                </asp:DropDownList></td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
            <td>
                CARD</td>
            <td>
                :</td>
            <td>
                <asp:DropDownList ID="ddlCard" runat="server" AutoPostBack="True" CssClass="t1" OnSelectedIndexChanged="ddlCard_SelectedIndexChanged">
                </asp:DropDownList></td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="12">
                90 DAYS SCHEDULE&nbsp;
                <asp:Label ID="Label1" runat="server" Text="Insert SucsessFully." Visible="False"></asp:Label></td>
        </tr>
        <tr>
            <td colspan="12">
                A HAMMER TEST:-<br />
                1. BUFFER<asp:GridView ID="gv20" runat="server" AutoGenerateColumns="False" Height="139px"
                    OnRowDataBound="gv1_OnRowDataBound" Width="705px">
                    <Columns>
                        <asp:TemplateField HeaderText="SNO.">
                            <ItemTemplate>
                                <%#Container.DataItemIndex +1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="sub_head_details" HeaderText="detail" />
                        <asp:TemplateField HeaderText="status">
                            <ItemTemplate>
                                <asp:TextBox ID="txt1" runat="server" CssClass="t1"></asp:TextBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="action_taken">
                            <ItemTemplate>
                                <asp:TextBox ID="txt2" runat="server" CssClass="t1"></asp:TextBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
    <tr>
        <td colspan="12">
            2. CBC &amp; SCREW COUPLING<asp:GridView ID="gv21" runat="server" AutoGenerateColumns="False" Height="139px"
                    OnRowDataBound="gv1_OnRowDataBound" Width="705px">
                <Columns>
                    <asp:TemplateField HeaderText="SNO.">
                        <ItemTemplate>
                            <%#Container.DataItemIndex +1 %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="sub_head_details" HeaderText="detail" />
                    <asp:TemplateField HeaderText="status">
                        <ItemTemplate>
                            <asp:TextBox ID="txt1" runat="server" CssClass="t1"></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="action_taken">
                        <ItemTemplate>
                            <asp:TextBox ID="txt2" runat="server" CssClass="t1"></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </td>
    </tr>
    <tr>
        <td colspan="12">
            3. CATTEL GUARD &amp; RAIL GUARD<asp:GridView ID="gv22" runat="server" AutoGenerateColumns="False" Height="139px"
                    OnRowDataBound="gv1_OnRowDataBound" Width="705px">
                <Columns>
                    <asp:TemplateField HeaderText="SNO.">
                        <ItemTemplate>
                            <%#Container.DataItemIndex +1 %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="sub_head_details" HeaderText="detail" />
                    <asp:TemplateField HeaderText="status">
                        <ItemTemplate>
                            <asp:TextBox ID="txt1" runat="server" CssClass="t1"></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="action_taken">
                        <ItemTemplate>
                            <asp:TextBox ID="txt2" runat="server" CssClass="t1"></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </td>
    </tr>
    <tr>
        <td colspan="12">
            4. SUSPENSION<asp:GridView ID="gv23" runat="server" AutoGenerateColumns="False" Height="139px"
                    OnRowDataBound="gv1_OnRowDataBound" Width="705px">
                <Columns>
                    <asp:TemplateField HeaderText="SNO.">
                        <ItemTemplate>
                            <%#Container.DataItemIndex +1 %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="sub_head_details" HeaderText="detail" />
                    <asp:TemplateField HeaderText="status">
                        <ItemTemplate>
                            <asp:TextBox ID="txt1" runat="server" CssClass="t1"></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="action_taken">
                        <ItemTemplate>
                            <asp:TextBox ID="txt2" runat="server" CssClass="t1"></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </td>
    </tr>
    <tr>
        <td colspan="12">
            5. HAND BREAK &amp; BRAKE CYLINDER<asp:GridView ID="gv24" runat="server" AutoGenerateColumns="False" Height="139px"
                    OnRowDataBound="gv1_OnRowDataBound" Width="705px">
                <Columns>
                    <asp:TemplateField HeaderText="SNO.">
                        <ItemTemplate>
                            <%#Container.DataItemIndex +1 %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="sub_head_details" HeaderText="detail" />
                    <asp:TemplateField HeaderText="status">
                        <ItemTemplate>
                            <asp:TextBox ID="txt1" runat="server" CssClass="t1"></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="action_taken">
                        <ItemTemplate>
                            <asp:TextBox ID="txt2" runat="server" CssClass="t1"></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <br />
            <table>
                <tr>
                    <td style="width: 100px">
                        LOCATION</td>
                    <td style="width: 100px">
                        1</td>
                    <td style="width: 100px">
                        2</td>
                    <td style="width: 100px">
                        3</td>
                    <td style="width: 100px">
                        4</td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        RT.</td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox36" runat="server" CssClass="t1" Width="83px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox37" runat="server" CssClass="t1" Width="83px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox38" runat="server" CssClass="t1" Width="83px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox39" runat="server" CssClass="t1" Width="83px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        LT.</td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox40" runat="server" CssClass="t1" Width="83px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox41" runat="server" CssClass="t1" Width="83px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox42" runat="server" CssClass="t1" Width="83px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox43" runat="server" CssClass="t1" Width="83px"></asp:TextBox></td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td colspan="12">
            6. SUNDERS BRACKETS, HOSES &amp; NOZZLES<asp:GridView ID="gv25" runat="server" AutoGenerateColumns="False" Height="139px"
                    OnRowDataBound="gv1_OnRowDataBound" Width="705px">
                <Columns>
                    <asp:TemplateField HeaderText="SNO.">
                        <ItemTemplate>
                            <%#Container.DataItemIndex +1 %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="sub_head_details" HeaderText="detail" />
                    <asp:TemplateField HeaderText="status">
                        <ItemTemplate>
                            <asp:TextBox ID="txt1" runat="server" CssClass="t1"></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="action_taken">
                        <ItemTemplate>
                            <asp:TextBox ID="txt2" runat="server" CssClass="t1"></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </td>
    </tr>
    <tr>
        <td colspan="12">
            7. TRUCKS<asp:GridView ID="gv26" runat="server" AutoGenerateColumns="False" Height="139px"
                    OnRowDataBound="gv1_OnRowDataBound" Width="705px">
                <Columns>
                    <asp:TemplateField HeaderText="SNO.">
                        <ItemTemplate>
                            <%#Container.DataItemIndex +1 %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="sub_head_details" HeaderText="detail" />
                    <asp:TemplateField HeaderText="status">
                        <ItemTemplate>
                            <asp:TextBox ID="txt1" runat="server" CssClass="t1"></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="action_taken">
                        <ItemTemplate>
                            <asp:TextBox ID="txt2" runat="server" CssClass="t1"></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </td>
    </tr>
    <tr>
        <td colspan="12">
            8. WHEEL &amp; AXLE<asp:GridView ID="gv27" runat="server" AutoGenerateColumns="False" Height="139px"
                    OnRowDataBound="gv1_OnRowDataBound" Width="705px">
                <Columns>
                    <asp:TemplateField HeaderText="SNO.">
                        <ItemTemplate>
                            <%#Container.DataItemIndex +1 %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="sub_head_details" HeaderText="detail" />
                    <asp:TemplateField HeaderText="status">
                        <ItemTemplate>
                            <asp:TextBox ID="txt1" runat="server" CssClass="t1"></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="action_taken">
                        <ItemTemplate>
                            <asp:TextBox ID="txt2" runat="server" CssClass="t1"></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </td>
    </tr>
    <tr>
        <td colspan="12">
            9. GEAR CASE MOUNTING<asp:GridView ID="gv28" runat="server" AutoGenerateColumns="False" Height="139px"
                    OnRowDataBound="gv1_OnRowDataBound" Width="705px">
                <Columns>
                    <asp:TemplateField HeaderText="SNO.">
                        <ItemTemplate>
                            <%#Container.DataItemIndex +1 %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="sub_head_details" HeaderText="detail" />
                    <asp:TemplateField HeaderText="status">
                        <ItemTemplate>
                            <asp:TextBox ID="txt1" runat="server" CssClass="t1"></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="action_taken">
                        <ItemTemplate>
                            <asp:TextBox ID="txt2" runat="server" CssClass="t1"></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <br />
            <table>
                <tr>
                    <td style="width: 100px">
                        LOCATION</td>
                    <td style="width: 100px">
                        1</td>
                    <td style="width: 100px">
                        2</td>
                    <td style="width: 100px">
                        3</td>
                    <td style="width: 100px">
                        4</td>
                    <td style="width: 100px">
                        5</td>
                    <td style="width: 100px">
                        6</td>
                    <td style="width: 100px">
                        TOTAL OIL ADDED</td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        SHORTAGE OIL LEVEL</td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox44" runat="server" CssClass="t1" Width="83px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox45" runat="server" CssClass="t1" Width="83px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox46" runat="server" CssClass="t1" Width="83px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox47" runat="server" CssClass="t1" Width="83px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox48" runat="server" CssClass="t1" Width="83px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox49" runat="server" CssClass="t1" Width="83px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox50" runat="server" CssClass="t1" Width="83px"></asp:TextBox></td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td colspan="12">
            10. BRAKE &amp; BRAKE HANGER ASSEMBLY<asp:GridView ID="gv29" runat="server" AutoGenerateColumns="False" Height="139px"
                    OnRowDataBound="gv1_OnRowDataBound" Width="705px">
                <Columns>
                    <asp:TemplateField HeaderText="SNO.">
                        <ItemTemplate>
                            <%#Container.DataItemIndex +1 %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="sub_head_details" HeaderText="detail" />
                    <asp:TemplateField HeaderText="status">
                        <ItemTemplate>
                            <asp:TextBox ID="txt1" runat="server" CssClass="t1"></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="action_taken">
                        <ItemTemplate>
                            <asp:TextBox ID="txt2" runat="server" CssClass="t1"></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <br />
            <table>
                <tr>
                    <td style="width: 100px">
                        LOCATION</td>
                    <td style="width: 100px">
                        L1</td>
                    <td style="width: 100px">
                        R1</td>
                    <td style="width: 100px">
                        L2</td>
                    <td style="width: 100px">
                        R2</td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        HEIGHT</td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox1" runat="server" CssClass="t1" Width="83px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox2" runat="server" CssClass="t1" Width="83px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox3" runat="server" CssClass="t1" Width="83px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox4" runat="server" CssClass="t1" Width="83px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        WEIGHT</td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox5" runat="server" CssClass="t1" Width="83px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox6" runat="server" CssClass="t1" Width="83px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox7" runat="server" CssClass="t1" Width="83px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox8" runat="server" CssClass="t1" Width="83px"></asp:TextBox></td>
                </tr>
            </table>
            <br />
            <table>
                <tr>
                    <td style="width: 100px">
                        LOCATION</td>
                    <td style="width: 100px">
                        L1</td>
                    <td style="width: 100px">
                        R1</td>
                    <td style="width: 100px">
                        L2</td>
                    <td style="width: 100px">
                        R2</td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        RAIL GUARD</td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox9" runat="server" CssClass="t1" Width="83px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox10" runat="server" CssClass="t1" Width="83px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox11" runat="server" CssClass="t1" Width="83px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox12" runat="server" CssClass="t1" Width="83px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        CATTLE GUARD</td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox13" runat="server" CssClass="t1" Width="83px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox14" runat="server" CssClass="t1" Width="83px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox15" runat="server" CssClass="t1" Width="83px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox16" runat="server" CssClass="t1" Width="83px"></asp:TextBox></td>
                </tr>
            </table>
            <br />
            <table>
                <tr>
                    <td style="width: 100px">
                        LOCATION</td>
                    <td style="width: 100px">
                        1</td>
                    <td style="width: 100px">
                        2</td>
                    <td style="width: 100px">
                        3</td>
                    <td style="width: 100px">
                        4</td>
                    <td style="width: 100px">
                        5</td>
                    <td style="width: 100px">
                        6</td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        LH</td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox17" runat="server" CssClass="t1" Width="83px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox18" runat="server" CssClass="t1" Width="83px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox19" runat="server" CssClass="t1" Width="83px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox20" runat="server" CssClass="t1" Width="83px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox21" runat="server" CssClass="t1" Width="83px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox22" runat="server" CssClass="t1" Width="83px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        RH</td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox23" runat="server" CssClass="t1" Width="83px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox24" runat="server" CssClass="t1" Width="83px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox25" runat="server" CssClass="t1" Width="83px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox26" runat="server" CssClass="t1" Width="83px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox27" runat="server" CssClass="t1" Width="83px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox28" runat="server" CssClass="t1" Width="83px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        TRUSTED PAD LH &amp; RH</td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox29" runat="server" CssClass="t1" Width="83px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox30" runat="server" CssClass="t1" Width="83px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox31" runat="server" CssClass="t1" Width="83px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox32" runat="server" CssClass="t1" Width="83px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox33" runat="server" CssClass="t1" Width="83px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox34" runat="server" CssClass="t1" Width="83px"></asp:TextBox></td>
                </tr>
            </table>
            <span style="font-size: 12pt; font-family: 'Times New Roman'; mso-fareast-font-family: 'Times New Roman';
                mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                All locations gear case oil sample to be tested in LAB :
                <asp:TextBox ID="TextBox35" runat="server" CssClass="t1" Width="275px"></asp:TextBox></span></td>
    </tr>
        <tr>
            <td align="center" colspan="12">
                <asp:Button ID="btnInsert" runat="server" CssClass="t1" OnClick="btnInsert_Click"
                    Text="INSERT" /></td>
        </tr>
    </table>
    </asp:Content>

