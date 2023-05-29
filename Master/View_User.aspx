<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true"
    CodeFile="View_User.aspx.cs" Inherits="Master_View_User" Title="Untitled Page" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <script language="javascript" type="text/javascript">
    function CallValidation()
    {
       var n1 = document.getElementById('<%=ddlDepartment.ClientID%>').value;
       if(Validate_selectedIndex(n1,'Department'))
       {return true;}
       return false;
    }
    </script>

    <table>
        <tr>
            <th colspan="10">
                USER LIST
            </th>
        </tr>
        <tr>
            <td>
                DEPARTMENT
            </td>
            <td>
                :
            </td>
            <td>
                <asp:DropDownList runat="server" ID="ddlDepartment" AutoPostBack="false" onfocus="ChangeStyle(this.id.toString());"
                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t1">
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button runat="server" ID="btnSave" Text="SHOW" onfocus="ChangeStyle(this.id.toString());"
                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t2" OnClick="btnSave_OnClick"
                    OnClientClick="return CallValidation();" ValidationGroup="b" />
            </td>
        </tr>
        <tr>
            <td colspan="10">
                <asp:GridView runat="server" AutoGenerateColumns="false" ID="gvUser">
                    <Columns>
                        <asp:TemplateField HeaderText='NO.'>
                            <ItemTemplate>
                                <%#Container.DataItemIndex + 1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField Visible="false">
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lblid" Text='<%#Eval("Id_User")%>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="USERNAME">
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lblUsername" Text='<%#Eval("Username") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="PASSWORD">
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lblPassword" Text='<%#Eval("Password")%>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="UPDATE" ItemStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <asp:ImageButton runat="server" ID="ibtnUpdate" ImageUrl="~/Images/Edit-icon.png"
                                    PostBackUrl='<%#"~/Master/UserCreation.aspx?id=" + Eval("Id_User") + "&action=update"%>'
                                    Height="10px" Width="10px" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="AUTHORIZATION" ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                        <asp:LinkButton runat="server" ID="lbtn" Text="GO >>" PostBackUrl='<%#"~/Master/User_Authorisation.aspx?id=" + Eval("Id_User")%>'></asp:LinkButton>
                        </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
