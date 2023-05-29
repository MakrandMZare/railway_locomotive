<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true" CodeFile="subCast.aspx.cs" Inherits="subCast" Title="Untitled Page" EnableEventValidation ="false" Theme="SkinFile" %>
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
        if(document.getElementById('<%=txtmid.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter 0");
        document.getElementById('<%=txtmid.ClientID %>').focus();
        return false;
    }
    
if(document.getElementById('<%=txtsubcast.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter 0");
        document.getElementById('<%=txtsubcast.ClientID %>').focus();
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
                SUB CAST</th>
        </tr>
        <tr>
            <td >
                         <asp:ImageButton  onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"

 ID="ImageButton1"   runat="server" OnClientClick="return ShowPanel();" ImageUrl="~/Images/Add-icon.png"/>
            <div ID="insertDiv" style="display:block;"> <table >
                <tr>
                    <td>
                        MID</td>
                    <td>
                        <asp:TextBox  onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"

 ID="txtmid" runat="server"></asp:TextBox></td>
                </tr>
                        <tr>
                            <td>
                                SUB CAST</td>
                            <td >
                                <asp:TextBox  onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"

 ID="txtsubcast" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtsubcast"
                                    ErrorMessage="*" ValidationGroup="a"></asp:RequiredFieldValidator></td>
                        </tr>
                <tr>
                    <td>
                    </td>
                    <td>
                        <asp:Label ID="lblerro" runat="server" ForeColor="Red" Text="Data Already Exists...!"
                            Visible="false"></asp:Label></td>
                </tr>
                        <tr>
                            <td>
                            </td>
                            <td >
                                <asp:Button  onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"

 ID="btnadd" runat="server" OnClick="btnadd_Click" OnClientClick="return ShowPanel();" Text="Add" Width="79px" ValidationGroup="a" /></td>
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
                        <asp:TemplateField HeaderText="NO.">
                                    
                            <ItemTemplate>
                                <%#Container.DataItemIndex + 1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
                         <asp:TemplateField HeaderText="MID">
                                     
                            <ItemTemplate>
                                <asp:Label ID="l1" runat="server" Text='<%#Eval("mid")%>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="SUB CAST">
                                     
                            <ItemTemplate>
                                <asp:Label ID="l2" runat="server" Text='<%#Eval("sub_caste")%>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                      
                      <asp:TemplateField HeaderText="Update"  >
                                  
    <HeaderTemplate>
    ACTION
    </HeaderTemplate>
    <ItemTemplate>
    <asp:ImageButton ID="lbtnupdate" runat="server" Text="Update" ImageUrl="~/Images/Edit-icon.png" PostBackUrl='<%# "~/Master/subCast.aspx?id="+ Eval("id_s_caste") + "&action=update" %>' />
    <asp:ImageButton ID="lbtnDelete" runat="server" Text="Delete" ImageUrl="~/Images/Delete-icon.png" PostBackUrl='<%# "~/Master/subCast.aspx?id="+ Eval("id_s_caste") + "&action=delete" %>'/>
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

