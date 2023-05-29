<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true" CodeFile="arrival.aspx.cs"   Inherits="arrival" Title="Sabarmati Diesels : Loco : Arrival" EnableEventValidation ="false" Theme="SkinFile" StylesheetTheme="SkinFile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


   <script language="javascript" type="text/javascript">
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
        
         if(document.getElementById('<%=txtarrival.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter -");
        document.getElementById('<%=txtarrival.ClientID %>').focus();
        return false;
    }
   

 
   
    else
    {
        return true;
    }
        
        return false;
    }
        </script>
    <table id = "tbl1" >
        <tr>
            <th>
                ARRIVAL</th>
        </tr>
        <tr>
            <td >
            <asp:ImageButton ID="ImageButton1" runat="server" OnClientClick="return ShowPanel();"  onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" ImageUrl="~/Images/Add-icon.png"/>
            <div id="insertDiv" style="display:block;">
                
                    <table>
                        <tr>
                            <td >
                                <asp:TextBox ID="txtarrival"  onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtarrival"
                                    ErrorMessage="*" ValidationGroup="a"></asp:RequiredFieldValidator></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblerro" runat="server" ForeColor="Red" Text="Data Already Exists...!"
                                    Visible="false"></asp:Label></td>
                        </tr>
                        <tr>
                            <td >
                                <asp:Button ID="btnadd" OnClientClick="return ShowPanel();" runat="server"  onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" OnClick="btnadd_Click" Text="Add" ValidationGroup="a" /></td>
                        </tr>
                    </table>
                
                </div>
            </td>
        </tr>
        <tr>
            <td colspan="2">
            <div>
                <asp:GridView ID="GridView1"   onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" runat="server" AutoGenerateColumns="False">
                    <Columns>
                     <asp:TemplateField headertext="NO.">
                       
                    <ItemTemplate>
                    <%#Container.DataItemIndex + 1 %>
                    </ItemTemplate>
                       
                    </asp:TemplateField>
    <asp:TemplateField headertext="POSITION"  >
    <ItemTemplate>
    <asp:Label runat="server" ID="l1" Text='<%#Eval("position")%>'></asp:Label>
    </ItemTemplate>
        <HeaderStyle  />
    </asp:TemplateField>
   
    <asp:TemplateField HeaderText="Update" >
    <HeaderTemplate>
    ACTION
    </HeaderTemplate>
    <ItemTemplate>
    <asp:ImageButton ID="lbtnupdate" runat="server"  Text="Update" ImageUrl="~/Images/Edit-icon.png" PostBackUrl='<%# "~/Master/arrival.aspx?id="+ Eval("id_mst_arr") + "&action=update" %>' OnClientClick ="ShowPanel();" Height="10px" Width="10px" />
    <asp:ImageButton ID="lbtnDelete" runat="server" Text="Delete" ImageUrl="~/Images/Delete-icon.png" PostBackUrl='<%# "~/Master/arrival.aspx?id="+ Eval("id_mst_arr") + "&action=delete" %>'  />
    </ItemTemplate>
      
    </asp:TemplateField>
    
                        
                    </Columns>
                </asp:GridView>
                </div>
            </td>
        </tr>
        <tr>
            <td >
            </td>
        </tr>
    </table>
</asp:Content>

