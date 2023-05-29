<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true"
    CodeFile="LocoType.aspx.cs" Inherits="Master_LocoType" Title="Untitled Page" Theme="SkinFile"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <script language="javascript" type="text/javascript">
function CallValidation()
    {
       var n1 = document.getElementById('<%=ddlType.ClientID%>').value;
       if(Validate_selectedIndex(n1,'Guage'))
       {return true;}
           if(document.getElementById('<%=ddlType.ClientID %>').value == "SELECT")
    {
        
        document.getElementById('<%=ddlType.ClientID %>').focus();
        return false;
    }
           if(document.getElementById('<%=txtlocotype.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter 0");
        document.getElementById('<%=txtlocotype.ClientID %>').focus();
        return false;
    }
     
    else
    {
        return true;
    }

       return false;
    }
function ShowPanel()
    {
        if(document.getElementById('insertDiv').style.display == 'block')
        {
        document.getElementById('insertDiv').style.display = "none";
        }
        else
        {
        document.getElementById('insertDiv').style.display = "block";
        }
        return false;
    }
    </script>

    <asp:ImageButton ID="ImageButton1" runat="server" OnClientClick="return ShowPanel();"
        onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"
        class="t1" ImageUrl="~/Images/Add-icon.png" Height="10px" Width="10px" />
    <div id="insertDiv" style="display: block;">
        <table>
            <tr>
                <th colspan="20">
                    LOCO TYPE DETAILS
                </th>
            </tr>
            <tr>
                <td>
                    GUAGE
                </td>
                <td>
                    :
                </td>
                <td>
                    <asp:DropDownList runat="server" ID="ddlType" onfocus="ChangeStyle(this.id.toString());"
                        onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" AutoPostBack="true" OnSelectedIndexChanged="ddlType_OnSelectedIndexChanged">
                        <asp:ListItem Text="SELECT" Value="0"></asp:ListItem>
                        <asp:ListItem Text="METER GUAGE" Value="1"></asp:ListItem>
                        <asp:ListItem Text="BROAD GUAGE" Value="2"></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    TYPE
                </td>
                <td>
                    :
                </td>
                <td>
                    <asp:TextBox ID="txtlocotype" onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"
                        class="t1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="10" align="center">
                    <asp:Label ID="lblerro" runat="server" ForeColor="Red" Text="Data Already Exists...!"
                        Visible="false"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="10" align="center">
                    <asp:Button ID="btnadd" runat="server" onfocus="ChangeStyle(this.id.toString());"
                        onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" OnClick="btnadd_Click"
                        Text="Add" OnClientClick="return CallValidation();" />
                </td>
            </tr>
            <tr>
                <td colspan="10">
                    <asp:GridView runat="server" ID="gv1" AutoGenerateColumns="false">
                        <Columns>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    NO.</HeaderTemplate>
                                <ItemTemplate>
                                    <%#Container.DataItemIndex + 1 %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    GUAGE
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lblguage" Text='<%#Eval("guage")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    TYPE</HeaderTemplate>
                                <ItemTemplate>
                                <asp:Label runat="server" id="lblType" Text='<%#Eval("type") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                            <ItemTemplate>
                            <asp:ImageButton ID="lbtnupdate" runat="server"  Text="Update" ImageUrl="~/Images/Edit-icon.png" PostBackUrl='<%# "~/Master/LocoType.aspx?id="+ Eval("id_ltype") + "&action=update" %>' OnClientClick ="ShowPanel();" Height="10px" Width="10px" />
                            <asp:ImageButton ID="lbtnDelete" runat="server" Text="Delete" ImageUrl="~/Images/Delete-icon.png" PostBackUrl='<%# "~/Master/LocoType.aspx?id="+ Eval("id_ltype") + "&action=delete" %>'  Height="10px" Width="10px"/>
                            </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
