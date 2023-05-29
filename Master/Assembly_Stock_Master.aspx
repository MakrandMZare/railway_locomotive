<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true" CodeFile="Assembly_Stock_Master.aspx.cs" Inherits="Master_Assembly_Stock_Master" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <table align="center">
        <tr>
            <th align="center" colspan="10">
                Stock Items
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
                <asp:GridView runat="server" ID="gv1" AutoGenerateColumns="false" DataKeyNames="Id_Stock" EmptyDataText="Non Item Found...!"
                    OnRowEditing="gv1_OnRowEditing" OnRowDeleting="gv1_OnRowDeleting">
                    <Columns>
                        <asp:TemplateField HeaderText="No.">
                            <ItemTemplate>
                                <%#Container.DataItemIndex + 1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField HeaderText="Name Of Assembly" DataField="NameOfAssembly" />
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

