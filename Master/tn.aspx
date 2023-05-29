<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true" CodeFile="tn.aspx.cs" Inherits="tn" Title="Sabarmati Diesels : Loco" EnableEventValidation ="false" Theme="SkinFile" %>
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
            <th>
               
               
              
                TN</th>
        </tr>
        <tr>
            <td colspan="2">
                <asp:ImageButton onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"
 ControlStyle-BorderWidth="2px" ID="ImageButton1" runat="server" OnClientClick="return ShowPanel();" ImageUrl="~/Images/Add-icon.png"/>
            <div ID="insertDiv" style="display:block;">
             <table >
                        <tr>
                            <td>
                                <asp:TextBox onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"
 ID="txttn" runat="server"></asp:TextBox>&nbsp;
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txttn"
                                    ErrorMessage="*" ValidationGroup="a"></asp:RequiredFieldValidator></td>
                        </tr>
                 <tr>
                     <td>
                         <asp:Label ID="lblerro" runat="server" ForeColor="Red" Text="Data Already Exists...!"
                             Visible="false"></asp:Label></td>
                 </tr>
                        <tr>
                            <td >
                                <asp:Button onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"
 ID="btnadd" runat="server" OnClick="btnadd_Click" Text="Add" Width="67px" ValidationGroup="a" /></td>
                        </tr>
                    </table>
              </div>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"
 ID="GridView1" runat="server" AutoGenerateColumns="False" >
                    <Columns>
                        <asp:TemplateField HeaderText="NO.">
                             <%--<HeaderStyle  Width="30px" />--%>
                            <ItemTemplate>
                                <%#Container.DataItemIndex + 1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="TN">
                            <ItemTemplate>
                                <asp:Label ID="l1" runat="server" Text='<%#Eval("tn")%>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Update" >
    <HeaderTemplate>
    ACTION
    </HeaderTemplate>
    <ItemTemplate>
    <asp:ImageButton ID="lbtnupdate" runat="server" Text="Update" ImageUrl="~/Images/Edit-icon.png" PostBackUrl='<%# "~/Master/tn.aspx?id="+ Eval("id_tn") + "&action=update" %>' />
    <asp:ImageButton ID="lbtnDelete" runat="server" Text="Delete" ImageUrl="~/Images/Delete-icon.png" PostBackUrl='<%# "~/Master/tn.aspx?id="+ Eval("id_tn") + "&action=delete" %>'/>
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

