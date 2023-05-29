<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true" CodeFile="View_Assembly_Electrical_SubMaster.aspx.cs" Inherits="Master_View_Assembly_Electrical_SubMaster" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table cellpadding="0" cellspacing="0" align="center">
        <tr>
            <th colspan="10" align="center">
                Mechanical Kits  Items. of EMD Locomotives
            </th>
        </tr>
        <tr>
            <td>
                Mechanical Item
            </td>
            <td>
                :
            </td>
            <td>
                <asp:DropDownList runat="server" ID="ddlMechenical" CssClass="t1" OnSelectedIndexChanged="ddlMechanical_OnSelectedIndexChanged"
                    AutoPostBack="true">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td colspan="15">
                <asp:GridView runat="server" ID="gv1" AutoGenerateColumns="false" EmptyDataText="Data Not Found..!"
                    DataKeyNames="Id_ElectricalSub" OnRowDeleting="gv1_OnRowDeleting">
                    <Columns>
                        <asp:TemplateField HeaderText="Sr no.">
                            <ItemTemplate>
                                <%#Container.DataItemIndex + 1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="Grno" HeaderText="Gr SNo." />
                        <asp:BoundField DataField="ItemDescription" HeaderText="Items Description" />
                        <asp:BoundField DataField="EMDPrno" HeaderText="EMD Pt No" />
                        <asp:BoundField DataField="QEMPrno" HeaderText="OEM Pt No" />
                        <asp:BoundField DataField="SWRPlno" HeaderText="SWR PL No." />
                        <asp:BoundField DataField="DlwPlno" HeaderText="DLW PL No." />
                        <asp:BoundField DataField="Qty" HeaderText="Qty in kit" />
                        <asp:BoundField DataField="Lpr" HeaderText="Lpr and PO Ref." />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <table>
                                    <tr>
                                        <td>
                                            <asp:ImageButton Width="10px" runat="server" ImageUrl="~/Images/Edit-icon.png" ID="lbtnUpdate"
                                                PostBackUrl='<%#"~/Master/Assembly_ElectricalItem_SubMaster.aspx?Id=" + Eval("Id_ElectricalSub")+"&action=Update" %>'/>
                                        </td>
                                        <td>
                                            <asp:ImageButton Width="10px" runat="server" ImageUrl="~/Images/Delete-icon.png"
                                                ID="lbtnDelete" CommandName="Delete" />
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

