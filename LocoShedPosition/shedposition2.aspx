<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true" CodeFile="shedposition2.aspx.cs" Inherits="LocoShedPosition_shedposition2" Title="Sabarmati Diesels : Loco" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:ToolkitScriptManager runat="server" ID="ToolkitScriptManager1"></asp:ToolkitScriptManager>       
    <script language="javascript" type="text/javascript">
    function CallValidation()
    {
       
    if(document.getElementById('<%=ddlClass.ClientID%>').value == "SELECT")
   {
        alert("Please select value from dropdown");
        return false;
    }
     if(document.getElementById('<%=ddlLocono.ClientID%>').value == "SELECT")
   {
        alert("Please select value from dropdown");
        return false;
    }

 if(document.getElementById('<%=ddlSite.ClientID%>').value == "SELECT")
   {
        alert("Please select value from dropdown");
        return false;
    }
     if(document.getElementById('<%=ddlSection.ClientID%>').value == "SELECT")
   {
        alert("Please select value from dropdown");
        return false;
    }
      
      
      
      
      
    if(document.getElementById('<%=txtDate.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter Date");
        document.getElementById('<%=txtDate.ClientID %>').focus();
        return false;
    }
    
    
    if(document.getElementById('<%=txtTrainno.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter 0");
        document.getElementById('<%=txtTrainno.ClientID %>').focus();
        return false;
    }
    if(document.getElementById('<%=txtlinemsg.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter 0");
        document.getElementById('<%=txtlinemsg.ClientID %>').focus();
        return false;
    }

   else
   {
   return true;
   }

       return false;
    
    }

    </script>
            <table align="center">
                <tr>
                    <th colspan="6">
                        LINE MESSAGES
                    </th>
                </tr>
                <tr>
                    <th colspan="6">
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True" />
                    </th>
                </tr>
                <tr>
                    <td>
                        CLASS
                    </td>
                    <td>
                        :
                    </td>
                    <td>
                        <asp:DropDownList runat="server" ID="ddlClass" AutoPostBack="True" OnSelectedIndexChanged="ddlClass_SelectedIndexChanged"
                            onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"
                            class="t1">
                            <asp:ListItem></asp:ListItem>
                        </asp:DropDownList>
                        <asp:Label runat="server" ID="lblguage" Visible="false"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        LOCO NO
                    </td>
                    <td>
                        :
                    </td>
                    <td>
                        <asp:DropDownList runat="server" ID="ddlLocono" onfocus="ChangeStyle(this.id.toString());"
                            onBlur="ChangeDefaultStyle(this.id.toString());" class="t1">
                            <asp:ListItem>SELECT</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        DATE
                    </td>
                    <td>
                        : <b>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtDate"
                                ErrorMessage="ENTER LOCO DATE">*</asp:RequiredFieldValidator>
                        </b>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtDate" onfocus="ChangeStyle(this.id.toString());"
                            onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
                        <asp:CalendarExtender runat="server" ID="CalendarExtender2" TargetControlID="txtDate"
                            Format="dd/MM/yyyy">
                        </asp:CalendarExtender>
                    </td>
                    <td>
                        TRAIN NO.
                    </td>
                    <td>
                        :
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtTrainno" onfocus="ChangeStyle(this.id.toString());"
                            onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        SITE
                    </td>
                    <td>
                        :
                    </td>
                    <td>
                        <asp:DropDownList runat="server" ID="ddlSite" onfocus="ChangeStyle(this.id.toString());"
                            onBlur="ChangeDefaultStyle(this.id.toString());" class="t1">
                            <asp:ListItem>SELECT</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        SECTION
                    </td>
                    <td>
                        :
                    </td>
                    <td>
                        <asp:DropDownList runat="server" ID="ddlSection" onfocus="ChangeStyle(this.id.toString());"
                            onBlur="ChangeDefaultStyle(this.id.toString());" class="t1">
                            <asp:ListItem>SELECT</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        LINE MESSAGES
                    </td>
                    <td>
                        :
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtlinemsg" onfocus="ChangeStyle(this.id.toString());"
                            onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Height="210px" 
                            TextMode="MultiLine" Width="224px"></asp:TextBox>
                    </td>
                </tr>
                
                <tr><td colspan="6" align="center"><asp:Button runat="server" ID="btnSave" 
                    Text="INSERT" onfocus="ChangeStyle(this.id.toString());" 
                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t2" 
                   OnClientClick="return CallValidation();" OnClick="btnSave_OnClick"/></td></tr>
            </table>
        
    
</asp:Content>
