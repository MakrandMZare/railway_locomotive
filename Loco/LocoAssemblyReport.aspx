<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true"
    CodeFile="LocoAssemblyReport.aspx.cs" Inherits="Loco_LocoAssemblyReport" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table align="center">
        <tr>
            <th colspan="10">
                LOCO ASSEMBLY HISTORY REPORT
            </th>
        </tr>
        <tr>
            <td colspan="10">
                <asp:Label runat="server" ID="lblError" Text="Please Choose Aleast One Option..!"
                    ForeColor="Red" Visible="false"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="10">
                <table>
                    <tr>
                        <td>
                            <asp:CheckBox runat="server" ID="ChkLoco" OnCheckedChanged="ChkLoco_OnCheckedChanged"
                                AutoPostBack="true" />
                        </td>
                        <td>
                            Class
                        </td>
                        <td>
                            :
                        </td>
                        <td>
                            <asp:DropDownList runat="server" ID="ddlClass" class="t1" OnSelectedIndexChanged="ddlClass_SelectedIndexChanged"
                                AutoPostBack="true">
                                <asp:ListItem>SELECT</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                            Loco No
                        </td>
                        <td>
                            :
                        </td>
                        <td>
                            <asp:DropDownList runat="server" ID="ddlLocono" class="t1" AutoPostBack="true">
                                <asp:ListItem>SELECT</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:Button runat="server" ID="btnShow" OnClick="btnShow_OnClick" Class="t2" Text="Generate Report" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <asp:CheckBox runat="server" ID="ChkRdso1" OnCheckedChanged="ChkRdso1_OnCheckedChanged"
                    AutoPostBack="true" />
            </td>
            <td>
                Rdso 1
            </td>
            <td>
                :
            </td>
            <td>
                <asp:DropDownList runat="server" ID="ddlRdso1" class="t1" OnSelectedIndexChanged="ddlRdso1_OnSelectedIndexChanged"
                    AutoPostBack="true">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:CheckBox runat="server" ID="ChkRdso2" OnCheckedChanged="ChkRdso2_OnCheckedChanged"
                    AutoPostBack="true" />
            </td>
            <td>
                Rdso 2
            </td>
            <td>
                :
            </td>
            <td>
                <asp:DropDownList runat="server" ID="ddlRdso2" class="t1" OnSelectedIndexChanged="ddlRdso2_OnSelectedIndexChanged"
                    AutoPostBack="true">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:CheckBox runat="server" ID="ChkRdso3" OnCheckedChanged="ChkRdso3_OnCheckedChanged"
                    AutoPostBack="true" />
            </td>
            <td>
                Rdso 3
            </td>
            <td>
                :
            </td>
            <td>
                <asp:DropDownList runat="server" ID="ddlRdso3" class="t1" OnSelectedIndexChanged="ddlRdso3_OnSelectedIndexChanged"
                    AutoPostBack="true">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:CheckBox runat="server" ID="ChkRdso4" OnCheckedChanged="ChkRdso4_OnCheckedChanged"
                    AutoPostBack="true" />
            </td>
            <td>
                Rdso 4
            </td>
            <td>
                :
            </td>
            <td>
                <asp:DropDownList runat="server" ID="ddlRdso4" class="t1" OnSelectedIndexChanged="ddlRdso4_OnSelectedIndexChanged"
                    AutoPostBack="true">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td colspan="10">
                <asp:GridView runat="server" ID="gv1" AllowPaging="True" AutoGenerateColumns="false"
                     EmptyDataText="No Assembly Found...!">
                    <Columns>
                        <asp:TemplateField HeaderText="No.">
                            <ItemTemplate>
                                <%#Container.DataItemIndex + 1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField HeaderText="Loco No." DataField="LocoNo" />
                        <asp:BoundField HeaderText="Date" DataField="GenerationDate" />
                        <asp:BoundField HeaderText="Assembly No." DataField="AssemblyNo" />
                        <asp:BoundField HeaderText="RDSO 1 DIGIT CODE" DataField="Rdso1" />
                        <asp:BoundField HeaderText="RDSO 2 DIGIT CODE" DataField="Rdso2" />
                        <asp:BoundField HeaderText="RDSO 3 DIGIT CODE" DataField="Rdso3" />
                        <asp:BoundField HeaderText="RDSO 4 DIGIT CODE" DataField="Rdso4" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
