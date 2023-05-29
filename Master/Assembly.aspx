<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true" CodeFile="Assembly.aspx.cs" Inherits="Assembly" EnableEventValidation ="false" Title="Sabarmati Diesels : Loco : Assembly" Theme="SkinFile" %>
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
        
    if(document.getElementById('<%=txtname.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter 0");
        document.getElementById('<%=txtname.ClientID %>').focus();
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
     <th>
    ASSEMBLY</th>
    </tr>
        <tr>
            <td>
                <asp:ImageButton ID="ImageButton1"  onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"

 runat="server" OnClientClick="return ShowPanel();" ImageUrl="~/Images/Add-icon.png"/>
                <div ID="insertDiv" style="display:block;">
                    <table>
                        
                        <tr>
                            <td>
                                <asp:TextBox ID="txtname"  onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"

 runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtname"
                                    ErrorMessage="*" ValidationGroup="a"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblerro" runat="server" ForeColor="Red" Text="Data Already Exists...!"
                                    Visible="false"></asp:Label></td>
                        </tr>
                        <tr>
                            <td >
                                <asp:Button ID="btnadd" OnClientClick="return ShowPanel();" onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"

 runat="server" Text="Add" Width="58px" OnClick="btnadd_Click" /></td>
                        </tr>
                    </table>
                    </div>
                
            </td>
        </tr>
        <tr>
            <td >
                <asp:GridView ID="gv1"  onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"

 runat="server" AutoGenerateColumns="False" >
                <Columns>
                     <asp:TemplateField headertext="NO.">
                   
                    <ItemTemplate>
                    <%#Container.DataItemIndex + 1 %>
                    </ItemTemplate>
                    </asp:TemplateField>
    <asp:TemplateField headertext="NAME">

    <ItemTemplate>
    <asp:Label runat="server" ID="l1" Text='<%#Eval("name")%>'></asp:Label>
    </ItemTemplate>
    </asp:TemplateField>
   <asp:TemplateField HeaderText="Update">

    <HeaderTemplate>
    ACTION
    </HeaderTemplate>
    <ItemTemplate>
    <asp:ImageButton ID="lbtnupdate" runat="server" Text="Update" ImageUrl="~/Images/Edit-icon.png" PostBackUrl='<%# "~/Master/Assembly.aspx?id="+ Eval("id_mst_assem") + "&action=update" %>' />
    <asp:ImageButton ID="lbtnDelete" runat="server" Text="Delete" ImageUrl="~/Images/Delete-icon.png" PostBackUrl='<%# "~/Master/Assembly.aspx?id="+ Eval("id_mst_assem") + "&action=delete" %>'/>
    </ItemTemplate>
      
    </asp:TemplateField>
    </Columns>
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>

