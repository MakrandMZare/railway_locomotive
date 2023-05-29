<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true" CodeFile="LineMessage2.aspx.cs" Inherits="LocoShedPosition_LineMessage2" Title="Sabarmati Diesels : Loco : Dead on Line" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
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
    if(document.getElementById('<%=ddlD_W.ClientID%>').value == "SELECT")
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
    if(document.getElementById('<%=txtTrainino.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter 0");
        document.getElementById('<%=txtTrainino.ClientID %>').focus();
        return false;
    }
    if(document.getElementById('<%=txtLoad.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter 0");
        document.getElementById('<%=txtLoad.ClientID %>').focus();
        return false;
    }
    
    
    if(document.getElementById('<%=txtGrad.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter 0");
        document.getElementById('<%=txtGrad.ClientID %>').focus();
        return false;
    }
    if(document.getElementById('<%=txtReputedReason.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter 0");
        document.getElementById('<%=txtReputedReason.ClientID %>').focus();
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
                        DEAD ON LINE
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
                <td>DATE</td><td> : </td><td>
                    <asp:TextBox runat="server" ID="txtDate"  onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"   class="t1"></asp:TextBox>
                    <asp:CalendarExtender runat="server" ID="CalendarExtender1" 
                        TargetControlID="txtDate" Format="dd/MM/yyyy"></asp:CalendarExtender>
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
                <td>D/W</td><td> : </td><td><asp:DropDownList runat="server" ID="ddlD_W" onfocus="ChangeStyle(this.id.toString());"
                            onBlur="ChangeDefaultStyle(this.id.toString());" class="t1">
                            <asp:ListItem>SELECT</asp:ListItem>
                            <asp:ListItem>DEAD</asp:ListItem>
                            <asp:ListItem>WORKING</asp:ListItem>
                        </asp:DropDownList></td>
                </tr>
                <tr>
                <td> TRAIN NO. </td>
                <td> : </td><td> <asp:TextBox runat="server" ID="txtTrainino" onfocus="ChangeStyle(this.id.toString());"
                            onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox> </td>
                </tr>
                <tr>
                <td> LOAD </td>
                <td> : </td><td> <asp:TextBox runat="server" ID="txtLoad" onfocus="ChangeStyle(this.id.toString());"
                            onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox> </td>
                </tr>
                <tr>
                <td> GRAD </td>
                <td> : </td><td> <asp:TextBox runat="server" ID="txtGrad" onfocus="ChangeStyle(this.id.toString());"
                            onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox> </td>
                </tr>
                <tr>
                    <td>
                        REPUTED REASON
                    </td>
                    <td>
                        :
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtReputedReason" onfocus="ChangeStyle(this.id.toString());"
                            onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" TextMode="MultiLine" Rows ="10" Columns="50"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                
                <tr><td colspan="6" align="center"><asp:Button runat="server" ID="btnSave" 
                    Text="INSERT" onfocus="ChangeStyle(this.id.toString());" 
                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t2" 
                    OnClientClick="return CallValidation();" OnClick="btnSave_OnClick"/></td></tr>
            </table>
       
    
</asp:Content>

