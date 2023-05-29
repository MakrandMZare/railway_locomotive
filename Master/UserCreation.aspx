<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true"
    CodeFile="UserCreation.aspx.cs" Inherits="Master_UserCreation" Title="Untitled Page" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:ToolkitScriptManager runat="server" ID="ToolkitScriptManager1">
     
    </asp:ToolkitScriptManager>
    <script type="text/javascript" language="javascript">
    function CallValidation()
    {
       var n1 = document.getElementById('<%=ddlDepartment.ClientID%>').value;
       var n2 = document.getElementById('<%=txtUsername.ClientID%>').value;
       var n3 = document.getElementById('<%=txtPassword.ClientID%>').value;
       var n4 = document.getElementById('<%=txtConfirm.ClientID%>').value;
       
       if(Validate_selectedIndex(n1,'Department') && IsNull(n2,'Username')&& IsNull(n3,'Password')&& IsNull(n4,'Confirm Password') && ConfirmPassword(document.getElementById('<%=txtPassword.ClientID%>').value,document.getElementById('<%=txtConfirm.ClientID%>').value))
       {return true;}
       return false;
    }
    </script>
    <table>
        <tr>
            <th colspan="50">
                USER CREATION
            </th>
        </tr>
        <tr><td></td><td colspan="10"><asp:Label runat="server" ID="errormsg" Text="User is already exist..Please Choose another username.!" Visible="false" ForeColor="Red"></asp:Label></td></tr>
        <tr>
            <td>
                Department
            </td>
            <td>
                :
            </td>
            <td>
                <asp:DropDownList runat="server" ID="ddlDepartment" AutoPostBack="False" onfocus="ChangeStyle(this.id.toString());"
                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t1">
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                Username
            </td>
            <td>
                :
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtUsername" onfocus="ChangeStyle(this.id.toString());"
                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
            </td>
            <td><asp:RequiredFieldValidator runat="server" ControlToValidate="txtUsername" ErrorMessage="*" ID="RequiredFieldValidator1"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>
                Password
            </td>
            <td>
                :
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" onfocus="ChangeStyle(this.id.toString());"
                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
            </td>
            <td><asp:RequiredFieldValidator runat="server" ControlToValidate="txtPassword" ErrorMessage="*" ID="RequiredFieldValidator2" ValidationGroup="b"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>
                Confirm Password
            </td>
            <td>
                :
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtConfirm" TextMode="Password" onfocus="ChangeStyle(this.id.toString());"
                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
            </td>
            <td><asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator3" ErrorMessage="*" ControlToValidate="txtConfirm" ValidationGroup="b"></asp:RequiredFieldValidator></td>
            <td><asp:CompareValidator runat="server" ControlToCompare="txtPassword" ControlToValidate="txtConfirm" ErrorMessage="Please Enter Same Password again...!" ValidationGroup="b"></asp:CompareValidator></td>
        </tr>
        <tr><td><asp:Button runat="server" ID="btnSave" Text="INSERT" onfocus="ChangeStyle(this.id.toString());"
                        onBlur="ChangeDefaultStyle(this.id.toString());" class="t2" OnClick="btnSave_OnClick"
                        OnClientClick="return CallValidation();" ValidationGroup="b"/></td></tr>
    </table>
</asp:Content>
