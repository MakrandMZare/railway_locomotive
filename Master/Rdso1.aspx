<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true"
    CodeFile="Rdso1.aspx.cs" Inherits="Master_Rdso1" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table align="Center" cellpadding="0" cellspacing="0">
        <tr>
            <th align="center" colspan="10">
                RDSO Details
            </th>
        </tr>
        <tr>
            <td>
                Rdso Code</td>
            <td>
                :
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtrdsoCode" CssClass="t1" MaxLength="4"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                Details</td>
            <td>
                :
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtDetails" CssClass="t1" MaxLength="500" Rows="5"
                    Wrap="true" Columns="100" TextMode="MultiLine"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="10">
                <asp:DropDownList runat="Server" ID="ddlSupplier" CssClass="t1">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList>
                <asp:Button runat="server" ID="btnSupplier" OnClick="OnClick_btnSupplier" CssClass="t2"
                    Text="Insert" />
            </td>
        </tr>
        <tr>
            <td>
                
            </td>
        </tr>
        <tr>
            <td colspan="10" align="center">
                <asp:Button runat="server" ID="btnSave" OnClick="OnClick_btnSave" CssClass="t2" Text="Insert" />
                <asp:Button runat="server" ID="btnCancel" OnClick="OnClick_btnCancel" CssClass="t2"
                    Text="Cancel" /></td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="lblError" Text="Rdso Code Already Found..!" ForeColor="red"
                    Visible="false"></asp:Label></td>
        </tr>
        <tr>
            <td>
                <asp:LinkButton runat="Server" ID="lbtnRdso1" OnClick="lbtnRdso1_OnClick">Rdso 1 Digit</asp:LinkButton>
            </td>
            <td>
            </td>
            <td>
                <asp:LinkButton runat="Server" ID="lbtnRdso3" OnClick="lbtnRdso3_OnClick">Rdso 3 Digit</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td>
                <asp:LinkButton runat="Server" ID="lbtnRdso2" OnClick="lbtnRdso2_OnClick">Rdso 2 Digit</asp:LinkButton></td>
            <td>
            </td>
            <td>
                <asp:LinkButton runat="Server" ID="lbtnRdso4" OnClick="lbtnRdso4_OnClick">Rdso 4 Digit</asp:LinkButton>
            </td>
        </tr>
    </table>
    <table cellpadding="0" cellspacing="0" align="center">
        <tr>
            <td>
                <asp:GridView runat="server" ID="gv1" EmptyDataText="No Data Found..!" AutoGenerateColumns="false"
                    OnRowEditing="gv1_OnRowEditing" OnRowDeleting="gv1_OnRowDeleting" DataKeyNames="id_rdso"
                    OnPageIndexChanging="gv1_OnPageIndexChanging" AllowPaging="true" PageSize="50">
                    <Columns>
                        <asp:TemplateField HeaderText="No.">
                            <ItemTemplate>
                                <%#Container.DataItemIndex + 1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Rdso">
                            <ItemTemplate>
                                <asp:Label runat="Server" ID="lblRdso" Text='<%#Eval("rdso")%>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Defect">
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lbldefect" Text='<%#Eval("nature_defect")%>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Action">
                            <ItemTemplate>
                                <asp:ImageButton ID="lbtnupdate" runat="server" ImageUrl="~/Images/Edit-icon.png"
                                    CommandName="Edit" CommandArgument='<%#Eval("id_rdso")%>' Height="15px" Width="15px" />
                                <asp:ImageButton ID="lbtnDelete" runat="server" ImageUrl="~/Images/Delete-icon.png"
                                    CommandName="Delete" CommandArgument='<%#Eval("id_rdso")%>' Height="15px" Width="15px"
                                    OnClientClick="return Confirm('Are you wants to delete...?);" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
