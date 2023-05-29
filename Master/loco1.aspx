<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true"
    CodeFile="loco1.aspx.cs" Inherits="Master_loco1" Title="Untitled Page" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%--<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>--%>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:ToolkitScriptManager runat="server" ID="ToolkitScriptManager1">
    </asp:ToolkitScriptManager>

    <script language="javascript" type="text/javascript">
    function CallValidation()
    {
       var n1 = document.getElementById('<%=ddlclass.ClientID%>').value;
       var n2 = document.getElementById('<%=ddlshedid.ClientID%>').value;
       var n3 = document.getElementById('<%=ddlnetive.ClientID%>').value;
       if(Validate_selectedIndex(n1,'Class') && Validate_selectedIndex(n2,'Shed') && Validate_selectedIndex(n3,'Native'))
       {return true;}
if(document.getElementById('<%=txtloco.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter 0");
        document.getElementById('<%=txtloco.ClientID %>').focus();
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
            <th align="center" colspan="4">
                NEW LOCO DETAIL
            </th>
        </tr>
        <tr>
            <td>
                <asp:ImageButton ID="ImageButton1" runat="server" OnClientClick="return ShowPanel();"
                    ImageUrl="~/Images/Add-icon.png" />
                <div id="insertDiv" style="display: block;">
                    <table>
                        <tr>
                            <td>
                            </td>
                            <td>
                                <asp:LinkButton runat="server" ID="lbtnerror" Text=" Loco Already Exists...!  [View]"
                                    ForeColor="Red" Font-Underline="false" Visible="false" OnClick="lblerror_OnClick"></asp:LinkButton>
                            </td>
                        </tr>
                        <tr>
                            <td align="right">
                                CLASS
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlclass" onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"
                                    class="t1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlclass_SelectedIndexChanged">
                                </asp:DropDownList>
                                <asp:Label runat="server" ID="lblguage" Text="..." Visible="false"></asp:Label>
                            </td>
                            <td align="right">
                            </td>
                            <td>
                            </td>
                            
                        </tr>
                        <tr>
                            <td align="right">
                                NEW LOCO
                            </td>
                            <td>
                                <asp:TextBox ID="txtloco" onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"
                                    class="t1" runat="server" OnTextChanged="txtloco_TextChanged" AutoPostBack="True"></asp:TextBox>
                            </td>
                            <td align="right">
                                <asp:RadioButtonList AutoPostBack="true" runat="server" ID="rdo1" RepeatDirection="Horizontal"
                                    OnSelectedIndexChanged="rdo1_SelectedIndexChanged" Height="16px">
                                    <asp:ListItem Selected="True">New</asp:ListItem>
                                    <asp:ListItem>Old</asp:ListItem>
                                </asp:RadioButtonList>
                            </td>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td align="right">
                                SHED
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlshedid" onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"
                                    class="t1" runat="server">
                                </asp:DropDownList>
                            </td>
                            <td align="right">
                            </td>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td align="right">
                                NATIVE
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlnetive" onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"
                                    class="t1" runat="server">
                                    <asp:ListItem Text="SELECT" Value="0">SELECT</asp:ListItem>
                                    <asp:ListItem Text="HOME" Value="1"></asp:ListItem>
                                    <asp:ListItem Text="FOREIGN" Value="2"></asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td align="right">
                            </td>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="10">
                                <asp:PlaceHolder runat="server" ID="ph1" Visible="false">
                                    <table>
                                        <tr>
                                            <td align="right">
                                                D.O.C
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtdoc" onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"
                                                    class="t1" runat="server"></asp:TextBox>
                                                <asp:CalendarExtender runat="server" ID="CalendarExtender1" TargetControlID="txtdoc"
                                                    Format="dd/MM/yyyy">
                                                </asp:CalendarExtender>
                                                &nbsp; TIME(HH.MM)
                                            </td>
                                            <td align="right">
                                                <asp:TextBox ID="ddlArrivalTime1" runat="server" onfocus="ChangeStyle(this.id.toString());"
                                                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Width="30px"></asp:TextBox>
                                                &nbsp;:<asp:TextBox ID="ddlArrivalTime2" runat="server" onfocus="ChangeStyle(this.id.toString());"
                                                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Width="30px">
                        
                                                </asp:TextBox>
                                            </td>
                                            <td>
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="right">
                                                RECIEVED FROM
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtrecive" onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"
                                                    class="t1" runat="server"></asp:TextBox>
                                            </td>
                                            <td align="right">
                                            </td>
                                            <td>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="right">
                                                DATE OF POH
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtpoh" onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"
                                                    class="t1" runat="server"></asp:TextBox><asp:CalendarExtender runat="server" ID="CalendarExtender2"
                                                        TargetControlID="txtpoh" Format="dd/MM/yyyy">
                                                    </asp:CalendarExtender>
                                                (DD-MM-YYYY)
                                            </td>
                                            <td align="right">
                                            </td>
                                            <td>
                                                &nbsp;
                                            </td>
                                        </tr>
                                    </table>
                                </asp:PlaceHolder>
                            </td>
                        </tr>
                        
                        
                        <tr>
                            <td>
                                
                            </td>
                            <td align="center">
                                <asp:Button ID="btnsave" class="t2" runat="server" Text="INSERT" OnClick="btnsave_Click"
                                   OnClientClick="return CallValidation();" />
                            </td>
                            <td>
                                &nbsp;
                            </td>
                            <td>
                                &nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td colspan="10">
                                <asp:GridView runat="server" ID="gvAssembly" AutoGenerateColumns="false" 
                                    OnRowDataBound="gvAssembly_OnRowDataBound" 
                                    onselectedindexchanged="gvAssembly_SelectedIndexChanged">
                                    <Columns>
                                        <asp:TemplateField HeaderText="NO.">
                                            <ItemTemplate>
                                                <%#Container.DisplayIndex + 1 %>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="ASSEMBLY">
                                            <ItemTemplate>
                                                <asp:DropDownList runat="server" ID="ddlAssembly" AutoPostBack="false" 
                                                    onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"
                                                    class="t1">
                                                    <asp:ListItem>SELECT</asp:ListItem>
                                                </asp:DropDownList>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="SUPPLIERY">
                                            <ItemTemplate>
                                                <asp:DropDownList runat="server" ID="ddlSupplier" AutoPostBack="false" 
                                                    onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"
                                                    class="t1">
                                                    <asp:ListItem>SELECT</asp:ListItem>
                                                </asp:DropDownList>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField Visible="false">
                                        <ItemTemplate>
                                        <asp:Label runat="server" ID="lblid"></asp:Label>
                                        </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                </asp:GridView>
                            </td>
                        </tr>
                    </table>
                </div>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="4">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td align="right">
            </td>
            <td>
            </td>
            <td>
            </td>
        </tr>
    </table>
</asp:Content>
