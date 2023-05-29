<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true" CodeFile="Section.aspx.cs" Inherits="caste" Title="Untitled Page" EnableEventValidation ="false" Theme="SkinFile" %>
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

    <table id = "tbl">
        <tr>
            <th>
                SECTION</th>
        </tr>
        <tr>
            <td>
                <asp:ImageButton   ID="ImageButton1" onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"

 runat="server" OnClientClick="return ShowPanel();" ImageUrl="~/Images/Add-icon.png"/>
            <div ID="insertDiv" style="display:block;">
                    <table >
                        <tr>
                            <td >
                               TYPE</td>
                            <td >
                                <asp:TextBox ID="txtcaste" onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"

 runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtcaste"
                                    ErrorMessage="*" ValidationGroup="a"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>
                            FULL NAME
                            </td>
                            <td>
                                <asp:TextBox ID="txtfname" runat="server" class="t1" onblur="ChangeDefaultStyle(this.id.toString());"
                                    onfocus="ChangeStyle(this.id.toString());"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtfname"
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
                            <td >
                            </td>
                            <td >
                                <asp:Button ID="btnadd" onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"

 runat="server" Text="Add" Width="58px" OnClick="btnadd_Click" ValidationGroup="a" /></td>
                        </tr>
                    </table>
                </div>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="gv1" onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"

 runat="server" AutoGenerateColumns="False" Height="163px">
                    <Columns>
                     <asp:TemplateField headertext="NO.">
                         
                    <ItemTemplate>
                    <%#Container.DataItemIndex + 1 %>
                    </ItemTemplate>
                    </asp:TemplateField>
    <asp:TemplateField headertext="TYPE">
      
    <ItemTemplate>
    <asp:Label runat="server" ID="l1" Text='<%#Eval("s_type")%>'></asp:Label>
    </ItemTemplate>
    </asp:TemplateField>
   
   <asp:TemplateField headertext="FULL NAME">
      
    <ItemTemplate>
    <asp:Label runat="server" ID="l2" Text='<%#Eval("f_name")%>'></asp:Label>
    </ItemTemplate>
    </asp:TemplateField>
    
    <asp:TemplateField HeaderText="Update" >
        
    <HeaderTemplate>
    ACTION
    </HeaderTemplate>
    <ItemTemplate>
    <asp:ImageButton ID="lbtnupdate" runat="server" Text="Update" ImageUrl="~/Images/Edit-icon.png" PostBackUrl='<%# "~/Master/Section.aspx?id="+ Eval("id_section") + "&action=update" %>' />
    <asp:ImageButton ID="lbtnDelete" runat="server" Text="Delete" ImageUrl="~/Images/Delete-icon.png" PostBackUrl='<%# "~/Master/Section.aspx?id="+ Eval("id_section") + "&action=delete" %>'/>
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

