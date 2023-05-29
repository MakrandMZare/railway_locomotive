<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" Title="Sabarmati Diesels : Loco" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <script src="JScript.js" language="javascript" type="text/javascript"></script>
<script language="javascript" type="text/javascript">
function CancelLogin()
{
document.getElementById('<%=txtUsername.ClientID%>').value="";
document.getElementById('<%=txtPassword.ClientID%>').value="";
return false;
}
</script>
<asp:Panel runat="server" ID="p1">
<table align="center">
<tr>
<td rowspan="10">
<img src="img/login.png" height="90px" width="100px" align="right" style="border:solid 1px gray;" alt="Login"/>
</td>
</tr>
<tr>
<th colspan="10"> LOGIN </th>
</tr>

<tr>
<td>
                   USERNAME
                </td>
                <td>
                    :
                    <b>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtUsername" ErrorMessage="ENTER USERNAME...!">*</asp:RequiredFieldValidator>
                    </b>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtUsername" onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
                </td>
</tr>

<tr>
<td>
                   PASSWORD
                </td>
                <td>
                    :
                    <b>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="txtPassword" ErrorMessage="ENTER PASSWORD...!">*</asp:RequiredFieldValidator>
                    </b>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtPassword" onfocus="ChangeStyle(this.id.toString());" TextMode="Password" onBlur="ChangeDefaultStyle(this.id.toString());"   class="t1" ></asp:TextBox>
                </td>
</tr>
<tr>

<th colspan="10"><asp:Button runat="server" ID="btnlogin" 
                    Text="LOGIN" onfocus="ChangeStyle(this.id.toString());" 
                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t2" 
                    OnClick="btnlogin_OnClick"/>&nbsp;&nbsp;&nbsp;&nbsp;
                     <asp:Button runat="server" ID="btnCancel" 
                    Text="CANCEL" onfocus="ChangeStyle(this.id.toString());" 
                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t2" 
                    OnClientClick="return CancelLogin();"/></th>
                    </tr>
                    <tr>
                    <td colspan="10"><asp:Label runat="server" ID="lblerror" Text="Invalid Username / Password" Visible="false" ForeColor="Red"></asp:Label></td>
                    </tr>

</table>
</asp:Panel>
</asp:Content>

