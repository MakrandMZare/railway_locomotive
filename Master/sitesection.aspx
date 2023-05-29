<%@ Page Language="C#" MasterPageFile="~//Loco/MasterPage.master" AutoEventWireup="true"
    CodeFile="sitesection.aspx.cs" Inherits="sitesection" Title="Untitled Page" EnableEventValidation="false"
    Theme="SkinFile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <script language="javascript" type="text/javascript">
    function ShowPanel()
    {
        //alert(document.getElementById('insertDiv').style.visibility);
        if(document.getElementById('insertDiv').style.display == 'block')
        {
        document.getElementById('insertDiv').style.display = "none";
        //alert(document.getElementById('insertDiv').style.visibility);
        }
        else
        {
        document.getElementById('insertDiv').style.display = "block";
        //alert(document.getElementById('insertDiv').style.visibility);
        }
        
        return false;
        
    }
    </script>

    <table>
        <tr>
            <th>
                SITE SECTION
            </th>
        </tr>
        <tr>
            <td>
                <asp:ImageButton onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"
                    class="t1" ID="ImageButton1" runat="server" OnClientClick="return ShowPanel();"
                    ImageUrl="~/Images/Add-icon.png" />
                <div id="insertDiv" style="display: block;">
                    <table>
                        <tr>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:TextBox onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"
                                    class="t1" ID="txtsitesection" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtsitesection"
                                    ErrorMessage="*" ValidationGroup="a"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblerro" runat="server" ForeColor="Red" Text="Data Already Exists...!"
                                    Visible="false"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"
                                    class="t1" ID="btnadd" runat="server" OnClick="btnadd_Click" Text="Add" Width="74px"
                                    ValidationGroup="a" />
                            </td>
                        </tr>
                    </table>
                </div>
            </td>
        </tr>
        <tr>
            <td>
                <asp:GridView onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"
                    class="t1" ID="gv1" runat="server" AutoGenerateColumns="False" AllowPaging="true"
                    OnPageIndexChanging="gv1_OnPageIndexChanging">
                    <Columns>
                        <asp:TemplateField HeaderText="NO.">
                            <ItemTemplate>
                                <%#Container.DataItemIndex + 1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="SITE SECTION">
                            <ItemTemplate>
                                <asp:Label ID="l1" runat="server" Text='<%#Eval("SiteSectionName")%>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Update">
                            <HeaderTemplate>
                                ACTION
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:ImageButton ID="lbtnupdate" runat="server" Text="Update" ImageUrl="~/Images/Edit-icon.png"
                                    PostBackUrl='<%# "~/Master/sitesection.aspx?id="+ Eval("Id_SiteSection") + "&action=update" %>' />
                                <asp:ImageButton ID="lbtnDelete" runat="server" Text="Delete" ImageUrl="~/Images/Delete-icon.png"
                                    PostBackUrl='<%# "~/Master/sitesection.aspx?id="+ Eval("Id_SiteSection") + "&action=delete" %>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
