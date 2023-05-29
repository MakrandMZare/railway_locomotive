<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true" CodeFile="Schdeule.aspx.cs" Inherits="Master_Schdeule" Title="Untitled Page"  EnableEventValidation="false" Theme="SkinFile"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
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
    function CallValidation()
    {
       var n = document.getElementById('<%=ddlClass.ClientID%>').value;
       return Validate_selectedIndex(n,'Class');
    }
        </script>

    <table>
        <tr>
            <th >
                SCHEDULE</th>
        </tr>
        <tr>
            <td >
            <asp:ImageButton ID="ImageButton1"  runat="server" OnClientClick="return ShowPanel();" ImageUrl="~/Images/Add-icon.png"/>
            <div id="insertDiv" style="display:block;">
                    <table>
                        <tr>
                <td>
                    CLASS
                </td>
                <td> : </td>
                <td>
                    
                    <asp:DropDownList runat="server" ID="ddlClass" AutoPostBack="True" OnSelectedIndexChanged="ddlClass_SelectedIndexChanged"
                        onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"
                        class="t1">
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                    <asp:Label runat="server" ID="lblguage" Text="..." Font-Bold="true" Visible="false"></asp:Label>
                </td>
            </tr>
                        <tr>
                            <td>
                                SCHEDULE</td>
                                <td> : </td>
                            <td >
                                
                                <asp:TextBox ID="txtSchedule" runat="server" onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"
                        class="t1"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtSchedule"
                                    ErrorMessage="*" ValidationGroup="a"></asp:RequiredFieldValidator>&nbsp;
                            </td>
                            
                        </tr>
                        <tr>
                        <td>DURATION  </td><td> : </td><td><asp:TextBox ID="txtDuration" runat="server" onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"
                        class="t1"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtDuration"
                                    ErrorMessage="*" ValidationGroup="a"></asp:RequiredFieldValidator>&nbsp;</td>
                        </tr>
                        <tr>
                        <td> </td>
                            <td>
                            </td>
                            <td >
                                <asp:Button ID="btnadd" runat="server" OnClick="btnadd_Click" Text="Add" Width="53px" ValidationGroup="a" onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t2"  OnClientClick="CallValidation();" /></td>
                        </tr>
                    </table>
            </div>
           </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" >
               <Columns>
                     <asp:TemplateField headertext="NO.">
                   
                    <ItemTemplate>
                    <%#Container.DataItemIndex + 1 %>
                    </ItemTemplate>
                    </asp:TemplateField>
    <asp:TemplateField headertext="NAME">
  
    <ItemTemplate>
    <asp:Label runat="server" ID="l1" Text='<%#Eval("Schedule_Type")%>'></asp:Label>
    </ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField>
    
    <ItemTemplate>
    <asp:Label runat="server" ID="l2" Text='<%#Eval("duration")%>'></asp:Label>
    </ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="Update" >
    <HeaderTemplate>
    ACTION
    </HeaderTemplate>
    <ItemTemplate>
    <asp:ImageButton ID="lbtnupdate" runat="server" Text="Update" ImageUrl="~/Images/Edit-icon.png" PostBackUrl='<%# "~/Master/Schdeule.aspx?id=" + Eval("id_loco_sch") + "&action=update" %>' />
    <asp:ImageButton ID="lbtnDelete" runat="server" Text="Delete" ImageUrl="~/Images/Delete-icon.png" PostBackUrl='<%# "~/Master/Schdeule.aspx?id=" + Eval("id_loco_sch") + "&action=delete" %>'/>
    </ItemTemplate>
    </asp:TemplateField>

                    </Columns>
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>

