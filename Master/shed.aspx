<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true" CodeFile="shed.aspx.cs" Inherits="shed" Title="Untitled Page" EnableEventValidation ="false" Theme="SkinFile" %>
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
     
if(document.getElementById('<%=txtfname.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter 0");
        document.getElementById('<%=txtfname.ClientID %>').focus();
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
            <th >
                SHED</th>
        </tr>
        <tr>
            <td>
                <asp:ImageButton  onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"

 ID="ImageButton1" runat="server" ImageUrl="~/Images/Add-icon.png"
                    OnClientClick="return ShowPanel();" />
                <div id="insertDiv" style="display: block">
                    <table >
                        <tr>
                            <td>
                                NAME</td>
                            <td>
                                <asp:TextBox  onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"

 ID="txtname" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtname"
                                    ErrorMessage="*" ValidationGroup="a"></asp:RequiredFieldValidator></td>
                        </tr>
                        <tr>
                            <td>
                                FULL NAME</td>
                            <td >
                                <asp:TextBox  onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"

 ID="txtfname" runat="server"></asp:TextBox></td>
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

 ID="btnadd" runat="server" OnClientClick="return ShowPanel();" OnClick="btnadd_Click" Text="Add" Width="67px" ValidationGroup="a" /></td>
                        </tr>
                    </table>
                </div>
            </td>
        </tr>
        <tr>
            <td>
                <div>
                    <asp:GridView  onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"

 ID="GridView1" runat="server" AutoGenerateColumns="False" >
                        <Columns>
                            <asp:TemplateField HeaderText="NO.">
                              
                                <ItemTemplate>
                                    <%#Container.DataItemIndex + 1 %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="SHED NAME">
                                
                                <ItemTemplate>
                                    <asp:Label ID="l1" runat="server" Text='<%#Eval("sname")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                              <asp:TemplateField HeaderText="SHED FULL NAME">
                                  
                                <ItemTemplate>
                                    <asp:Label ID="l2" runat="server" Text='<%#Eval("FULLNAME")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Update">
                               
                                <HeaderTemplate>
                                    ACTION
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:ImageButton ID="lbtnupdate" runat="server" ImageUrl="~/Images/Edit-icon.png"
                                        PostBackUrl='<%# "~/Master/shed.aspx?id="+ Eval("id_shed") + "&action=update" %>'
                                        Text="Update" />
                                    <asp:ImageButton ID="lbtnDelete" runat="server" ImageUrl="~/Images/Delete-icon.png"
                                        PostBackUrl='<%# "~/Master/shed.aspx?id="+ Eval("id_shed") + "&action=delete" %>'
                                        Text="Delete" />
                                </ItemTemplate>
                                
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </td>
        </tr>
        <tr><td >
            
            </td>
            <td>
            </td>
        </tr>
    </table>
</asp:Content>

