<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true"
    CodeFile="VieWAssemblyNonStock.aspx.cs" Inherits="Master_VieWAssemblyNonStock"
    Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table>
        <tr>
            <th colspan="100" align="center">
                SOUTH WESTERN RAILWAY
            </th>
        </tr>
        <tr>
            <th align="Center" colspan="100">
                MATERIAL DIRECTORY -EMD LOCOMOTIVE Non-Stock Items
            </th>
        </tr>
        <tr>
            <td>
                Assembly
            </td>
            <td>
                :
            </td>
            <td>
                <asp:DropDownList runat="server" ID="ddlAssembly" CssClass="t1">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:Button runat="server" ID="btnShow" CssClass="t2" OnClick="btnShow_OnClick" Text="Show" />
            </td>
        </tr>
        <tr>
            <td colspan="100">
                <asp:GridView runat="server" ID="gv1" AutoGenerateColumns="false" DataKeyNames="Id_NonStock"
                    EmptyDataText="No Data Found...!">
                    <Columns>
                        <asp:TemplateField HeaderText="SNo.">
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lblid" Text='<%#Container.DataItemIndex + 1 %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="Grno" HeaderText="Gr. Sno" />
                        <asp:BoundField DataField="Description" HeaderText="Description" />
                        <asp:BoundField DataField="EMDPrno" HeaderText=" EMD Pt No / OEM Pt No " />
                        <asp:BoundField DataField="DLWPrno" HeaderText="DLW PL No" />
                        <asp:BoundField DataField="Drgno" HeaderText="Drg No" />
                        <asp:BoundField DataField="Sch_Qpl_Aac" HeaderText="Sch-QPL-AAC for 50/100/150 Locos" />
                        <asp:BoundField DataField="Pac" HeaderText="If PAC, then firm's Name" />
                        <asp:BoundField HeaderText="RDSO Sources Part I" DataField="Rdso1" />
                        <asp:BoundField HeaderText="RDSO Sources Part II" DataField="Rdso2" />
                        <asp:BoundField HeaderText="DLW Sources Part I" DataField="Dlw1" />
                        <asp:BoundField HeaderText="DLW Sources Part II" DataField="Dlw2" />
                        <asp:BoundField HeaderText="LPR with Contract / PO Ref" DataField="Upr" />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <table>
                                    <tr>
                                        <td>
                                            <asp:ImageButton Width="10px" runat="server" ImageUrl="~/Images/Edit-icon.png" ID="lbtnUpdate"
                                                PostBackUrl='<%# "~/Master/Assembly_NonStock.aspx?Id=" + Eval("Id_NonStock") + "&action=update" %>' />
                                        </td>
                                        <td>
                                            <asp:ImageButton Width="10px" runat="server" ImageUrl="~/Images/Delete-icon.png"
                                                ID="lbtnDelete" PostBackUrl='<%# "~/Master/VieWAssemblyNonStock.aspx?Id=" + Eval("Id_NonStock") + "&action=delete" %>' />
                                        </td>
                                    </tr>
                                </table>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
