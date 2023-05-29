<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true" CodeFile="nonstate.aspx.cs" Inherits="nonstate" Title="Untitled Page" EnableEventValidation ="false"  %>
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
            if(document.getElementById('<%=txtsitenonstate.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter 0");
        document.getElementById('<%=txtsitenonstate.ClientID %>').focus();
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
            <th>SITE NONSTATE</th>
        </tr>
        <tr>
            <td >
            <asp:ImageButton  onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"
 ID="ImageButton1" runat="server" OnClientClick="return ShowPanel();" ImageUrl="~/Images/Add-icon.png"/>
            <div ID="insertDiv" style="display:block;">
                    <table>
                        <tr>
                            <td >
                                <asp:TextBox  onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"
 ID="txtsitenonstate" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtsitenonstate"
                                    ErrorMessage="*" ValidationGroup="a"></asp:RequiredFieldValidator></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblerro" runat="server" ForeColor="Red" Text="Data Already Exists...!"
                                    Visible="false"></asp:Label></td>
                        </tr>
                        <tr>
                            <td >
                                <asp:Button  onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"
 ID="btnnonstate" runat="server" OnClientClick="return ShowPanel();" Text="Add" ValidationGroup="a" OnClick="btnnonstate_Click"/></td>
                        </tr>
                    </table>
             </div>
            </td>
        </tr>
        <tr>
            <td >
                <asp:GridView  onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"
 ID="GridView1" runat="server" AutoGenerateColumns="False" >
               <Columns>
                     <asp:TemplateField headertext="NO.">
                    <ItemTemplate>
                    <%#Container.DataItemIndex + 1 %>
                    </ItemTemplate>
                    </asp:TemplateField>
    <asp:TemplateField headertext="STATE">
    <ItemTemplate>
    <asp:Label runat="server" ID="l1" Text='<%#Eval("stat")%>'></asp:Label>
    </ItemTemplate>
    </asp:TemplateField>
   
    
   <asp:TemplateField HeaderText="Update">
    <HeaderTemplate>
    ACTION
    </HeaderTemplate>
    <ItemTemplate>
    <asp:ImageButton ID="lbtnupdate" runat="server" Text="Update" ImageUrl="~/Images/Edit-icon.png" PostBackUrl='<%# "~/Master/nonstate.aspx?id="+ Eval("id_stat") + "&action=update" %>' />
    <asp:ImageButton ID="lbtnDelete" runat="server" Text="Delete" ImageUrl="~/Images/Delete-icon.png" PostBackUrl='<%# "~/Master/nonstate.aspx?id="+ Eval("id_stat") + "&action=delete" %>'/>
    </ItemTemplate>
    </asp:TemplateField>
    
    </Columns>
                     </asp:GridView>
            </td>
        </tr>
        <tr>
            <td >
            </td>
            <td >
            </td>
        </tr>
    </table>
</asp:Content>

