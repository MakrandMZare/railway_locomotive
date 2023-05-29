<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true" CodeFile="rot_90.aspx.cs" Inherits="ElectronicChekSheet_rot_90" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
        <tr>
            <th colspan="12">
                ROT</th>
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
                <strong>CLASS.</strong></td>
            <td>
                :</td>
            <td>
                <asp:DropDownList ID="ddlClass" runat="server" AutoPostBack="True" CssClass="t1"
                    OnSelectedIndexChanged="ddlClass_SelectedIndexChanged">
                </asp:DropDownList></td>
            <td>
                <strong>LOCO NO.</strong></td>
            <td>
                :</td>
            <td>
                <asp:DropDownList ID="ddlLocono" runat="server" CssClass="t1">
                </asp:DropDownList></td>
            <td>
                <strong>SCHEDULE</strong></td>
            <td>
            </td>
            <td>
                <asp:DropDownList ID="ddlSchedule" runat="server" AutoPostBack="True" CssClass="t1"
                    OnSelectedIndexChanged="ddlSchedule_SelectedIndexChanged">
                </asp:DropDownList></td>
            <td>
                <strong>Date</strong></td>
            <td style="text-decoration: underline">
                :</td>
            <td>
                <asp:TextBox ID="txtdate" runat="server" CssClass="t1" Width="83px"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                Name of Technician</td>
            <td>
                :</td>
            <td style="font-family: Arial">
                <asp:DropDownList ID="ddlHr" runat="server" CssClass="t1">
                </asp:DropDownList></td>
            <td>
                <strong>Timing: Work start</strong></td>
            <td style="font-size: 10pt; font-family: Times New Roman">
                :</td>
            <td>
                <asp:TextBox ID="txtstart" runat="server" CssClass="t1" Width="56px"></asp:TextBox></td>
            <td>
                <strong>Finish</strong></td>
            <td style="font-size: 10pt; font-family: Times New Roman">
                :</td>
            <td>
                <asp:TextBox ID="txtfinish" runat="server" CssClass="t1" Width="56px"></asp:TextBox></td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
                <strong>Name of Supervisor:</strong><u>
                </u>
            </td>
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
                <asp:TextBox ID="TextBox1" runat="server" CssClass="t1" Visible="False" Width="56px"></asp:TextBox></td>
            <td>
            </td>
            <td>
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" CssClass="t1" Visible="False" Width="56px"></asp:TextBox></td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
                CARD</td>
            <td>
                :</td>
            <td colspan="10">
                <asp:DropDownList ID="ddlCard" runat="server" AutoPostBack="True" CssClass="t1" OnSelectedIndexChanged="ddlCard_SelectedIndexChanged">
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td align="left" colspan="12">
                <p class="MsoNormal" style="margin: 0in 0in 0pt">
                    <b>MAIN&nbsp;
                        ALTERNATOR &amp; COMPANION ALTERNATOR:</b></p>
                <asp:GridView ID="gv1" runat="server" AutoGenerateColumns="False" OnRowDataBound="gv1_OnRowDataBound" >
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
                &nbsp; &nbsp;&nbsp;
            </td>
        </tr>
        <tr>
            <td align="left" colspan="12">
                <p class="MsoHeading9" style="margin: 0in 0in 0pt">
                    <strong>AUXILLARY GENERATOR/ RADIATOR FAN MOTOR:</strong></p>
                <asp:GridView ID="gv2" runat="server" AutoGenerateColumns="False" OnRowDataBound="gv1_OnRowDataBound">
                    <Columns>
                        <asp:TemplateField HeaderText="SNO.">
                            <ItemTemplate>
                                <%#Container.DataItemIndex +1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="sub_head_details" HeaderText="detail" />
                        <asp:TemplateField HeaderText="status">
                            <ItemTemplate>
                                <asp:TextBox ID="txt3" runat="server" CssClass="t1"></asp:TextBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="action_taken">
                            <ItemTemplate>
                                <asp:TextBox ID="txt4" runat="server" CssClass="t1"></asp:TextBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td align="left" colspan="12">
                <p class="MsoHeading9" style="margin: 0in 0in 0pt">
                    <strong>DYNAMIC BRAKE MOTOR:</strong></p>
                <asp:GridView ID="gv3" runat="server" AutoGenerateColumns="False" OnRowDataBound="gv1_OnRowDataBound">
                    <Columns>
                        <asp:TemplateField HeaderText="SNO.">
                            <ItemTemplate>
                                <%#Container.DataItemIndex +1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="sub_head_details" HeaderText="detail" />
                        <asp:TemplateField HeaderText="status">
                            <ItemTemplate>
                                <asp:TextBox ID="txt5" runat="server" CssClass="t1"></asp:TextBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="action_taken">
                            <ItemTemplate>
                                <asp:TextBox ID="txt6" runat="server" CssClass="t1"></asp:TextBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td align="left" colspan="12">
                <p class="MsoHeading9" style="margin: 0in 0in 0pt">
                  FUEL PUMP MOTOR / TLPM / GOVERNOR BOOSTER PUMP MOTOR:
                        </p>
                <asp:GridView ID="gv4" runat="server" AutoGenerateColumns="False" OnRowDataBound="gv1_OnRowDataBound">
                    <Columns>
                        <asp:TemplateField HeaderText="SNO.">
                            <ItemTemplate>
                                <%#Container.DataItemIndex +1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="sub_head_details" HeaderText="detail" />
                        <asp:TemplateField HeaderText="status">
                            <ItemTemplate>
                                <asp:TextBox ID="txt7" runat="server" CssClass="t1"></asp:TextBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="action_taken">
                            <ItemTemplate>
                                <asp:TextBox ID="txt8" runat="server" CssClass="t1"></asp:TextBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td align="left" colspan="12">
                <strong>TCC ELECTRONIC BLOWER
                        MOTOR/ DUST BIN BLOWER MOTOR:<asp:GridView ID="gv5" runat="server" AutoGenerateColumns="False"
                            OnRowDataBound="gv1_OnRowDataBound">
                            <Columns>
                                <asp:TemplateField HeaderText="SNO.">
                                    <ItemTemplate>
                                        <%#Container.DataItemIndex +1 %>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="sub_head_details" HeaderText="detail" />
                                <asp:TemplateField HeaderText="status">
                                    <ItemTemplate>
                                        <asp:TextBox ID="txt9" runat="server" CssClass="t1"></asp:TextBox>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="action_taken">
                                    <ItemTemplate>
                                        <asp:TextBox ID="txt10" runat="server" CssClass="t1"></asp:TextBox>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </strong>
            </td>
        </tr>
        <tr>
            <td align="left" colspan="12">
<strong>TRACTION MOTOR BLOWER
                        FAN<asp:GridView ID="gv6" runat="server" AutoGenerateColumns="False" OnRowDataBound="gv1_OnRowDataBound">
                            <Columns>
                                <asp:TemplateField HeaderText="SNO.">
                                    <ItemTemplate>
                                        <%#Container.DataItemIndex +1 %>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="sub_head_details" HeaderText="detail" />
                                <asp:TemplateField HeaderText="status">
                                    <ItemTemplate>
                                        <asp:TextBox ID="txt11" runat="server" CssClass="t1"></asp:TextBox>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="action_taken">
                                    <ItemTemplate>
                                        <asp:TextBox ID="txt12" runat="server" CssClass="t1"></asp:TextBox>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </strong>
            </td>
        </tr>
        <tr>
            <td align="left" colspan="12">
             <strong>VII. STARTING MOTOR<asp:GridView
                        ID="gv7" runat="server" AutoGenerateColumns="False" OnRowDataBound="gv1_OnRowDataBound">
                        <Columns>
                            <asp:TemplateField HeaderText="SNO.">
                                <ItemTemplate>
                                    <%#Container.DataItemIndex +1 %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="sub_head_details" HeaderText="detail" />
                            <asp:TemplateField HeaderText="status">
                                <ItemTemplate>
                                    <asp:TextBox ID="txt13" runat="server" CssClass="t1"></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="action_taken">
                                <ItemTemplate>
                                    <asp:TextBox ID="txt14" runat="server" CssClass="t1"></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                    </strong>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="12" rowspan="2">
                <asp:Button ID="btnInsert" runat="server" CssClass="t1" OnClick="btnInsert_Click"
                    Text="INSERT" /></td>
        </tr>
        <tr>
        </tr>
        <tr>
            <td align="center" colspan="12" rowspan="1">
            <%--
                <cc1:toolkitscriptmanager id="ToolkitScriptManager1" runat="server"></cc1:toolkitscriptmanager>
                <cc1:calendarextender id="CalendarExtender1" runat="server" format="dd/MM/yyyy" targetcontrolid="txtdate"></cc1:calendarextender>--%>
            </td>
        </tr>
    </table>
</asp:Content>

