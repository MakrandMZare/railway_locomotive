<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true" CodeFile="mstrloco.aspx.cs" Inherits="mstrloco" Title="Untitled Page" EnableEventValidation ="false" Theme="SkinFile" %>
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
        </script>
 
    <table >
        <tr>
            <th >
                LOCO</th>
        </tr>
        <tr>
            <td >
                <asp:ImageButton  onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"
 ID="ImageButton1" runat="server" ImageUrl="~/Images/Add-icon.png"
                    OnClientClick="return ShowPanel();" />
                <div id="insertDiv" style="display: block">
                    <table>
                        <tr>
                            <td >
                                <asp:TextBox  onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"
 ID="txtloco" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtloco"
                                    ErrorMessage="*" ValidationGroup="a"></asp:RequiredFieldValidator></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblerro" runat="server" ForeColor="Red" Text="Data Already Exists...!"
                                    Visible="false"></asp:Label></td>
                        </tr>
                        <tr>
                            <td >
                                <asp:Button OnClientClick="return ShowPanel();" onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"
 ID="btnadd" runat="server" OnClick="btnadd_Click" Text="Add" Width="55px" ValidationGroup="a" /></td>
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
                            <asp:TemplateField HeaderText="LOCO TYPE">
                                <ItemTemplate>
                                    <asp:Label ID="l1" runat="server" Text='<%#Eval("loco_type")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Update"  >
                                <HeaderTemplate>
                                    ACTION
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:ImageButton ID="lbtnupdate" runat="server" ImageUrl="~/Images/Edit-icon.png"
                                        PostBackUrl='<%# "~/mstrloco.aspx?id="+ Eval("id_ltype") + "&action=update" %>'
                                        Text="Update" />
                                    <asp:ImageButton ID="lbtnDelete" runat="server" ImageUrl="~/Images/Delete-icon.png"
                                        PostBackUrl='<%# "~/mstrloco.aspx?id="+ Eval("id_ltype") + "&action=delete" %>'
                                        Text="Delete" />
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
            <td>
            </td>
        </tr>
    </table>
</asp:Content>

