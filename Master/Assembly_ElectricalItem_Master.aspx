<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true"
    CodeFile="Assembly_ElectricalItem_Master.aspx.cs" Inherits="Master_Assembly_ElectricalItem_Master"
    Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table align="center">
        <tr>
            <th align="center" colspan="10">
                Assembly Electrical Item
            </th>
        </tr>
        <tr>
            <td>
                Item
            </td>
            <td>
                :
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtNameOfItem" CssClass="t1"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="10" align="center">
                <asp:Button runat="server" ID="btnSave" OnClick="btnSave_OnClick" CssClass="t2" Text="Insert" />
                <asp:Button runat="server" ID="btnCancel" OnClick="btnCancel_OnClick" CssClass="t2" Text="Cancel" />
            </td>
        </tr>
        <tr>
            <td colspan="10">
                <asp:GridView runat="server" ID="gv1" AutoGenerateColumns="false" DataKeyNames="Id_Electrical" EmptyDataText="Non Item Found...!"
                    OnRowEditing="gv1_OnRowEditing" OnRowDeleting="gv1_OnRowDeleting">
                    <Columns>
                        <asp:TemplateField HeaderText="No.">
                            <ItemTemplate>
                                <%#Container.DataItemIndex + 1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField HeaderText="Items" DataField="NameOfItem" />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <table>
                                    <tr>
                                        <td>
                                            <asp:ImageButton Width="10px" runat="server" ImageUrl="~/Images/Edit-icon.png" ID="lbtnUpdate"
                                                CommandName="Edit" />
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
