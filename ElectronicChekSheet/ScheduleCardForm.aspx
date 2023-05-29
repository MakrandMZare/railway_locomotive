<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true"
    CodeFile="ScheduleCardForm.aspx.cs" Inherits="ElectronicChekSheet_ScheduleCardForm"
    Title="Untitled Page" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table>
        <tr>
            <th colspan="12">
                SCHEDULE CARD FORM</th>
        </tr>
        <tr>
            <td>
                <strong>SECTION</strong></td>
            <td>
                :</td>
            <td>
                <asp:DropDownList ID="ddlSection" runat="server" CssClass="t1" AutoPostBack="True"
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
                <asp:DropDownList ID="ddlClass" runat="server" CssClass="t1" AutoPostBack="True"
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
                <asp:DropDownList ID="ddlSchedule" runat="server" CssClass="t1" AutoPostBack="True"
                    OnSelectedIndexChanged="ddlSchedule_SelectedIndexChanged">
                </asp:DropDownList></td>
            <td>
                <strong>Date</strong></td>
            <td>
                :</td>
            <td>
                <asp:TextBox ID="txtdate" runat="server" CssClass="t1" Width="83px"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <strong>Name of Technician</strong></td>
            <td>
                :</td>
            <td>
                <asp:DropDownList ID="ddlHr" runat="server" CssClass="t1">
                </asp:DropDownList></td>
            <td>
                <strong>Timing: Work start</strong></td>
            <td>
                :</td>
            <td>
                <asp:TextBox ID="txtstart" runat="server" CssClass="t1" Width="56px"></asp:TextBox></td>
            <td>
                <strong>Finish</strong></td>
            <td>
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
                <strong>Name of Supervisor:<u> </u></strong>
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
                CARD</td>
            <td>
                :</td>
            <td colspan="10">
                <asp:DropDownList ID="ddlCard" runat="server" CssClass="t1" AutoPostBack="True" OnSelectedIndexChanged="ddlCard_SelectedIndexChanged">
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td align="left" colspan="12">
                <p class="MsoNormal" style="margin: 0in 0in 0pt">
                    <b><span style="font-size: 9pt; font-family: Arial; mso-bidi-font-size: 12.0pt">CONTROL
                        STANDS:</span></b></p>
                <asp:GridView ID="gvControlStand" runat="server" AutoGenerateColumns="False" OnRowDataBound="gv1_OnRowDataBound">
                    <Columns>
                        <asp:TemplateField HeaderText="SNO.">
                            <ItemTemplate>
                                <%#Container.DataItemIndex +1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="sub_head_details" HeaderText="detail" />
                        <asp:TemplateField HeaderText="status">
                            <ItemTemplate>
                                <asp:TextBox ID="txt1" CssClass="t1" runat="server"></asp:TextBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="action_taken">
                            <ItemTemplate>
                                <asp:TextBox ID="txt2" CssClass="t1" runat="server"></asp:TextBox>
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
                    <strong><span style="font-size: 10pt; font-family: Times New Roman">ECC1:</span></strong></p>
                <asp:GridView ID="gvECC1" runat="server" AutoGenerateColumns="False" OnRowDataBound="gv1_OnRowDataBound">
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
                    <strong><span style="font-size: 10pt; font-family: Times New Roman">ECC2:</span></strong></p>
                <asp:GridView ID="gvECC2" runat="server" AutoGenerateColumns="False" OnRowDataBound="gv1_OnRowDataBound">
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
                    <strong><span style="font-size: 10pt; font-family: Times New Roman">ECC3:</span></strong></p>
                <asp:GridView ID="gvECC3" runat="server" AutoGenerateColumns="False" OnRowDataBound="gv1_OnRowDataBound">
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
                <p class="MsoHeading9" style="margin: 0in 0in 0pt">
                    <span style="font-family: Arial"><strong><span style="font-size: 10pt">MISCELLANEOUS:
                        <?xml namespace="" ns="urn:schemas-microsoft-com:office:office" prefix="o" ?><o:p></o:p></span></strong></span></p>
                <asp:GridView ID="gvMiscell" runat="server" AutoGenerateColumns="False" OnRowDataBound="gv1_OnRowDataBound">
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
                <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
                </cc1:ToolkitScriptManager>
                <cc1:CalendarExtender ID="CalendarExtender1" runat="server" Format="dd/MM/yyyy" TargetControlID="txtdate">
                </cc1:CalendarExtender>
            </td>
        </tr>
    </table>
</asp:Content>
