<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true" CodeFile="resp.aspx.cs" Inherits="resp" Title="Untitled Page"  EnableEventValidation ="false" Theme="SkinFile" %>
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
        
        return false;
        
    }
        </script>
  
  <table>
        <tr>
            <th >
                RESP</th>
        </tr>
        <tr>
            <td >
            <asp:ImageButton ID="ImageButton1"  onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"

 runat="server" OnClientClick="return ShowPanel();" ImageUrl="~/Images/Add-icon.png"/>
            <div ID="insertDiv" style="display:block;">
                
  
                    <table>
                        <tr>
                            <td>
                                <asp:TextBox  onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"

 ID="txtresp" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtresp"
                                    ErrorMessage="*" ValidationGroup="a"></asp:RequiredFieldValidator></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button  onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"

 ID="btnadd" runat="server" Text="Add" Width="66px" OnClick="btnadd_Click" ValidationGroup="a" /></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblerro" runat="server" ForeColor="Red" Text="Data Already Exists...!"
                                    Visible="false"></asp:Label></td>
                        </tr>
                    </table>
                </div>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView  onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"

 ID="GridView1" runat="server" AutoGenerateColumns="False" AllowPaging = "false" AllowSorting = " true " >
                    <Columns>
                     <asp:TemplateField headertext="NO.">
                    <ItemTemplate>
                    <%#Container.DataItemIndex + 1 %>
                    </ItemTemplate>
                    </asp:TemplateField>
    <asp:TemplateField headertext="RESP">
    <ItemTemplate>
    <asp:Label runat="server" ID="l1" Text='<%#Eval("resp")%>'></asp:Label>
    </ItemTemplate>
    </asp:TemplateField>
   
      <asp:TemplateField HeaderText="Update">
    <HeaderTemplate>
    ACTION
    </HeaderTemplate>
    <ItemTemplate>
    <asp:ImageButton ID="lbtnupdate" runat="server" Text="Update" ImageUrl="~/Images/Edit-icon.png" PostBackUrl='<%# "~/Master/resp.aspx?id="+ Eval("id_resp") + "&action=update" %>' />
    <asp:ImageButton ID="lbtnDelete" runat="server" Text="Delete" ImageUrl="~/Images/Delete-icon.png" PostBackUrl='<%# "~/Master/resp.aspx?id="+ Eval("id_resp") + "&action=delete" %>'/>
    </ItemTemplate>
    </asp:TemplateField>
  
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>

