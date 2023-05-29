<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true" CodeFile="category.aspx.cs" Inherits="category" Title="Sabarmati Diesels : Loco : Catagory" EnableEventValidation ="false" Theme="SkinFile" %>
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
            if(document.getElementById('<%=txtcategory.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter -");
        document.getElementById('<%=txtcategory.ClientID %>').focus();
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
            <th>
                CATEGORY</th>
        </tr>
        <tr>
            <td >
                 <asp:ImageButton ID="ImageButton1"  onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"
 runat="server" OnClientClick="return ShowPanel();" ImageUrl="~/Images/Add-icon.png"/>
            <div ID="insertDiv" style="display:block;">
         
                    <table>
                        <tr>
                            <td >
                                <asp:TextBox ID="txtcategory"  onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"
 runat="server"></asp:TextBox>
                               
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblerro" runat="server" ForeColor="Red" Text="Data Already Exists...!"
                                    Visible="false"></asp:Label></td>
                        </tr>
                        <tr>
                            <td >
                                <asp:Button ID="btnadd" OnClientClick="return ShowPanel();"  onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"
 runat="server" OnClick="btnadd_Click" Text="Add" Width="60px" ValidationGroup="a" /></td>
                        </tr>
                    </table>
         </div> 
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="GridView1"  onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"
 runat="server" AutoGenerateColumns="False">
                <Columns>
                     <asp:TemplateField headertext="NO.">
                    
                    <ItemTemplate>
                    <%#Container.DataItemIndex + 1 %>
                    </ItemTemplate>
                    </asp:TemplateField>
    <asp:TemplateField headertext="CATEGORY">
  
    <ItemTemplate>
    <asp:Label runat="server" ID="l1" Text='<%#Eval("category")%>'></asp:Label>
    </ItemTemplate>
    </asp:TemplateField>
   

    <asp:TemplateField HeaderText="Update">
  
    <HeaderTemplate>
    ACTION
    </HeaderTemplate>
    <ItemTemplate>
    <asp:ImageButton ID="lbtnupdate" runat="server" Text="Update" ImageUrl="~/Images/Edit-icon.png" PostBackUrl='<%# "~/Master/category.aspx?id="+ Eval("id_cat") + "&action=update" %>' />
    <asp:ImageButton ID="lbtnDelete" runat="server" Text="Delete" ImageUrl="~/Images/Delete-icon.png" PostBackUrl='<%# "~/Master/category.aspx?id="+ Eval("id_cat") + "&action=delete" %>'/>
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

