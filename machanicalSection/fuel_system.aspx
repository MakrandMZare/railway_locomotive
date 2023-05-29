<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true" CodeFile="fuel_system.aspx.cs" Inherits="machanicalSection_fuel_system" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
        <tr>
            <th colspan="12">
                FUEL SYSTEM AND GOVERNER SECTION</th>
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
                <asp:GridView ID="gv1" runat="server" AutoGenerateColumns="False" Height="139px"
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
            <td align="center" colspan="12">
                <asp:Button ID="btnInsert" runat="server" CssClass="t1" OnClick="btnInsert_Click"
                    Text="INSERT" /></td>
        </tr>
    </table>
</asp:Content>

