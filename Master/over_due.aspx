<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true" CodeFile="over_due.aspx.cs" Inherits="over_due" Title="Untitled Page" EnableEventValidation ="false" Theme="SkinFile" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
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
            if(document.getElementById('<%=txtoverdue.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter 0");
        document.getElementById('<%=txtoverdue.ClientID %>').focus();
        return false;
    }
     
   
    if(document.getElementById('<%=txtduedate.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter 0");
        document.getElementById('<%=txtduedate.ClientID %>').focus();
        return false;
    }
     
    else
    {
        return true;
    }

        return false;
        
    }
        </script>

    <table>
        <tr>
            <th >
                OVER DUE</th>
        </tr>
        <tr>
            <td colspan="2">
<asp:ImageButton ID="ImageButton1" runat="server"  onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" OnClientClick="return ShowPanel();" ImageUrl="~/Images/Add-icon.png"/>
            <div ID="insertDiv" style="display:block;">
            
                    <table >
                        <tr>
                            <td>
                                OVER DUE</td>
                            <td >
                                <asp:TextBox ID="txtoverdue"  onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtoverdue"
                                    ErrorMessage="*" ValidationGroup="a"></asp:RequiredFieldValidator></td>
                        </tr>
                        <tr>
                            <td>
                                DUE DATE</td>
                            <td>
                                <asp:TextBox ID="txtduedate"  onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" runat="server"></asp:TextBox><cc1:CalendarExtender ID="CalendarExtender1" runat="server" Format="dd/MM/yyyy" TargetControlID="txtduedate">
                                </cc1:CalendarExtender>
                                </td>
                                
                                
                        </tr>
                        <tr>
                        <td></td><td><asp:Label runat="server" ID="lblerro" ForeColor="Red" Visible="false" Text="Data Already Exists...!"></asp:Label></td>
                        </tr>
                        <tr>
                            <td>
                            </td>
                            <td >
                                <asp:Button ID="btnadd" OnClientClick="return ShowPanel();" runat="server"  onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" OnClick="btnadd_Click" Text="Add" Width="58px" />
                                
                            </td>
                        </tr>
                    </table>
            </div>
                <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
                </cc1:ToolkitScriptManager>
            </td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="GridView1"  onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" runat="server"  AutoGenerateColumns="False">
               <Columns>
                     <asp:TemplateField headertext="NO.">
                    <ItemTemplate>
                    <%#Container.DataItemIndex + 1 %>
                    </ItemTemplate>
                    </asp:TemplateField>
    <asp:TemplateField headertext="DUE">
    <ItemTemplate>
    <asp:Label runat="server" ID="l1" Text='<%#Eval("due")%>'></asp:Label>
    </ItemTemplate>
    </asp:TemplateField>
    
    <asp:TemplateField headertext="DUE DATE">
    <ItemTemplate>
    <asp:Label runat="server" ID="l2" Text='<%#Eval("Due Date")%>'></asp:Label>
    </ItemTemplate>
    </asp:TemplateField>
   
    
    <asp:TemplateField HeaderText="Update">
    <HeaderTemplate>
    ACTION
    </HeaderTemplate>
    <ItemTemplate>
    <asp:ImageButton ID="lbtnupdate" runat="server" Text="Update" ImageUrl="~/Images/Edit-icon.png" PostBackUrl='<%# "~/Master/over_due.aspx?id="+ Eval("id_od") + "&action=update" %>' />
    <asp:ImageButton ID="lbtnDelete" runat="server" Text="Delete" ImageUrl="~/Images/Delete-icon.png" PostBackUrl='<%# "~/Master/over_due.aspx?id="+ Eval("id_od") + "&action=delete" %>'/>
    </ItemTemplate>
    </asp:TemplateField>
   
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td >
            </td>
        </tr>
    </table>
</asp:Content>

