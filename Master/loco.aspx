<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true" CodeFile="loco.aspx.cs" Inherits="loco" Title="Untitled Page" EnableEventValidation ="false" Theme="SkinFile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
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
     if(document.getElementById('<%=txtloco.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter -");
        document.getElementById('<%=txtloco.ClientID %>').focus();
        return false;
    }
     if(document.getElementById('<%=txtdockdate.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter -");
        document.getElementById('<%=txtdockdate.ClientID %>').focus();
        return false;
    }
     if(document.getElementById('<%=txtatime.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter -");
        document.getElementById('<%=txtatime.ClientID %>').focus();
        return false;
    }
     if(document.getElementById('<%=txtphodate.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter -");
        document.getElementById('<%=txtphodate.ClientID %>').focus();
        return false;
    }
     if(document.getElementById('<%=txtnativ.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter -");
        document.getElementById('<%=txtnativ.ClientID %>').focus();
        return false;
    }
     if(document.getElementById('<%=txtrfrom.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter -");
        document.getElementById('<%=txtrfrom.ClientID %>').focus();
        return false;
    }
if(document.getElementById('<%=ddlclass.ClientID %>').value == "SELECT")
    {
       
        document.getElementById('<%=ddlclass.ClientID %>').focus();
        return false;
    }
if(document.getElementById('<%=ddlshedid.ClientID %>').value == "SELECT")
    {
       
        document.getElementById('<%=ddlshedid.ClientID %>').focus();
        return false;
    }
    else
    {
        return true;
    }

        return false;
        
    }
        </script>

    <table >
        <tr>
            <td colspan="2">
                LOCO</td>
        </tr>
        <tr>
            <td colspan="2">
<asp:ImageButton ID="ImageButton1"  runat="server" OnClientClick="return ShowPanel();" ImageUrl="~/Images/Add-icon.png"/>
            <div ID="insertDiv" style="display:none;">
            
                    <table >
                        <tr>
                            <td>
                                LOCO</td>
                            <td>
                                <asp:TextBox ID="txtloco" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtloco"
                                    ErrorMessage="*" ValidationGroup="a"></asp:RequiredFieldValidator></td>
                        </tr>
                        <tr>
                            <td>
                                CLASS</td>
                            <td>
                                <asp:DropDownList ID="ddlclass" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="139px">
                                </asp:DropDownList></td>
                        </tr>
                        <tr>
                            <td>
                                SHED
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlshedid" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="139px">
                                </asp:DropDownList></td>
                        </tr>
                        <tr>
                            <td>
                                DOC DATE</td>
                            <td>
                                <asp:TextBox ID="txtdockdate" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>
                                A TIME</td>
                            <td>
                                <asp:TextBox ID="txtatime" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>
                                POH DATE</td>
                            <td>
                                <asp:TextBox ID="txtphodate" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>
                                NATIVE</td>
                            <td>
                                <asp:TextBox ID="txtnativ" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>
                                R FROM</td>
                            <td>
                                <asp:TextBox ID="txtrfrom" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>
                            </td>
                            <td>
                                <asp:Button ID="btnadd" OnClientClick="return ShowPanel();" runat="server" OnClick="btnadd_Click" Text="Add" Width="57px" ValidationGroup="a" /></td>
                        </tr>
                    </table>
        </div>
                <br />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                <Columns>
                     <asp:TemplateField headertext="NO.">
                    <ItemTemplate>
                    <%#Container.DataItemIndex + 1 %>
                    </ItemTemplate>
                    </asp:TemplateField>
    
    
     
    
     <asp:TemplateField headertext="A TIME">
    <ItemTemplate>
    <asp:Label runat="server" ID="l2" Text='<%#Eval("a_time")%>'></asp:Label>
    </ItemTemplate>
    </asp:TemplateField>
    
     <asp:TemplateField headertext="DOC DATE">
    <ItemTemplate>
    <asp:Label runat="server" ID="l3" Text='<%#Eval("doc_date")%>'></asp:Label>
    </ItemTemplate>
    </asp:TemplateField>
    
     <asp:TemplateField headertext="LOCO NO.">
    <ItemTemplate>
    <asp:Label runat="server" ID="l4" Text='<%#Eval("locono")%>'></asp:Label>
    </ItemTemplate>
    </asp:TemplateField>
    
     <asp:TemplateField headertext="NATIVE">
    <ItemTemplate>
    <asp:Label runat="server" ID="l5" Text='<%#Eval("native")%>'></asp:Label>
    </ItemTemplate>
    </asp:TemplateField>
    
     <asp:TemplateField headertext="POH DATE">
    <ItemTemplate>
    <asp:Label runat="server" ID="l6" Text='<%#Eval("poh_date")%>'></asp:Label>
    </ItemTemplate>
    </asp:TemplateField>
    
     <asp:TemplateField headertext="R FROM">
    <ItemTemplate>
    <asp:Label runat="server" ID="l7" Text='<%#Eval("rfrom")%>'></asp:Label>
    </ItemTemplate>
    </asp:TemplateField>
    
     <asp:TemplateField headertext="LOCO TYPE">
    <ItemTemplate>
    <asp:Label runat="server" ID="l8" Text='<%#Eval("loco_type")%>'></asp:Label>
    </ItemTemplate>
    </asp:TemplateField>
    
     <asp:TemplateField headertext="S NAME">
    <ItemTemplate>
    <asp:Label runat="server" ID="l9" Text='<%#Eval("sname")%>'></asp:Label>
    </ItemTemplate>
    </asp:TemplateField>
    
   
    <asp:TemplateField HeaderText="Update" >
    <HeaderTemplate>
    ACTION
    </HeaderTemplate>
    <ItemTemplate>
    <asp:ImageButton ID="lbtnupdate" runat="server" Text="Update" ImageUrl="~/Images/Edit-icon.png" PostBackUrl='<%# "~/loco.aspx?id="+ Eval("id_mst_loco") + "&action=update" %>' />
    <%--<asp:ImageButton ID="lbtnDelete" runat="server" Text="Delete" ImageUrl="~/Images/Delete-icon.png" PostBackUrl='<%# "~/loco.aspx?id="+ Eval("id_mst_loco") + "&action=delete" %>'/>--%>
    </ItemTemplate>
    </asp:TemplateField>
                            </Columns>
                
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
            </td>
        </tr>
    </table>
</asp:Content>

