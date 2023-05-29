<%@ Page Language="C#" MasterPageFile="../Loco/MasterPage.master" AutoEventWireup="true"
    CodeFile="View_Loco_Master.aspx.cs" Inherits="Master_View_Loco_Master" Title="View Loco Assembly And Supplier" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table align="center">
        <tr>
            <th>
                LOCO
            </th>
        </tr>
        <tr>
            <td>
                <asp:ImageButton runat="server" ID="btnPrint" ImageUrl="~/Images/printer_icon.jpg"
                    Height="20px" Width="20px" Visible="true" OnClick="btnPrint_Click" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Panel runat="server" ID="p1">
                    <asp:GridView runat="server" ID="gv1" AutoGenerateColumns="false" OnRowDataBound="gv1_OnRowDataBound">
                        <Columns>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="SN." Width="15px" Font-Size="XX-Small"></asp:Label></HeaderTemplate>
                                <ItemTemplate>
                                    <%#Container.DataItemIndex  + 1 %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l2" Text="LOCO NO" Width="55px" Font-Size="XX-Small"></asp:Label></HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lbllocono" Text='<%#Eval("locono")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l3" Text="CLASS" Width="55px" Font-Size="XX-Small"></asp:Label></HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lblclass" Text='<%#Eval("class")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l4" Text="SHED" Width="25px" Font-Size="XX-Small"></asp:Label></HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lblshed" Text='<%#Eval("shed")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l5" Text="D.O.C" Width="15px" Font-Size="XX-Small"></asp:Label></HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lbldoc" Text='<%#Eval("doc")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l6" Text="TIME" Width="15px" Font-Size="XX-Small"></asp:Label></HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lblArrivaltime" Text='<%#Eval("Arrival Time")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l7" Text="NATIVE" Width="35px" Font-Size="XX-Small"></asp:Label></HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lblnative" Text='<%#Eval("native")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l8" Text="P.O.H DATE" Width="65px" Font-Size="XX-Small"></asp:Label></HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lblpoh" Text='<%#Eval("poh")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <%--<asp:TemplateField >
<HeaderTemplate>P.O.H DATE</HeaderTemplate>
<ItemTemplate>
<asp:Label runat="server" ID="lbllocono" Text='<%#Eval("poh")%>'></asp:Label>
</ItemTemplate>
</asp:TemplateField>--%>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l9" Text="RECEIVED FROM" Width="45px" Font-Size="XX-Small"></asp:Label></HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lblrfrom" Text='<%#Eval("rfrom")%>'></asp:Label>
                                    <asp:Label runat="server" ID="lblid1" Text='<%#Eval("id")%>' Visible="false"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                            <ItemTemplate>
                                <table>
                                    <tr>
                                        <td>
                                            <asp:ImageButton runat="server" Width="10px" ImageUrl="~/Images/Edit-icon.png" ID="lbtnUpdate"
                                                PostBackUrl='<%# "~/Master/Loco1.aspx?id=" + Eval("id")+"&action=update" %>' />
                                        </td>
                                    </tr>
                                </table>
                            </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </asp:Panel>
            </td>
        </tr>
    </table>
</asp:Content>
