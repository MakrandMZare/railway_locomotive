<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true" CodeFile="Loco_Movement.aspx.cs" Inherits="LocoShedPosition_Loco_Movement" Title="Sabarmati Diesels : Loco Movement" %>

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

 
      if(document.getElementById('<%= ddlDiv.ClientID %>').value == "SELECT")
   {
        alert("Please select value from dropdown");
        return false;
    }

if(document.getElementById('<%= ddlSite.ClientID %>').value == "SELECT")
   {
        alert("Please select value from dropdown");
        return false;
    }
if(document.getElementById('<%= ddlSection.ClientID %>').value == "SELECT")
   {
        alert("Please select value from dropdown");
        return false;
    }
    
    
    
    
    
 if(document.getElementById('<%=txtArrivalDate.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter Date");
        document.getElementById('<%=txtArrivalDate.ClientID %>').focus();
        return false;
    }
    if(document.getElementById('<%=txtDoc.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter 0");
        document.getElementById('<%=txtDoc.ClientID %>').focus();
        return false;
    }
    if(document.getElementById('<%=txtOut.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter Date");
        document.getElementById('<%=txtOut.ClientID %>').focus();
        return false;
    }
    
    
    if(document.getElementById('<%=txtLastSchedule.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter -");
        document.getElementById('<%=txtLastSchedule.ClientID %>').focus();
        return false;
    }
    if(document.getElementById('<%=txtRepair.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter -");
        document.getElementById('<%=txtRepair.ClientID %>').focus();
        return false;
    }
    if(document.getElementById('<%=txtRemarks.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter -");
        document.getElementById('<%=txtRemarks.ClientID %>').focus();
        return false;
    }
      else
   {
   return true;
   }
    return false;
    
    }

    </script>
    
    <table ALIGN="center">
<tr>
<th colspan="20"> SBI BASED LOCOS MOVEMENTS </th>
</tr>
  <tr>
                <td>
                    CLASS
                </td>
                <td>
                    :
                </td>
                <td>
                    <asp:DropDownList runat="server" ID="ddlClass" AutoPostBack="True" 
                        onselectedindexchanged="ddlClass_SelectedIndexChanged" onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1">
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
                    <asp:DropDownList runat="server" ID="ddlLocono" 
                        onfocus="ChangeStyle(this.id.toString());" 
                        onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" 
                        onselectedindexchanged="ddlLocono_SelectedIndexChanged" AutoPostBack="true">
                        <asp:ListItem>SELECT</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    ARRIVAL DATE
                </td>
                <td>
                    :
                    <b>
                    
                    </b>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtArrivalDate" 
                        onfocus="ChangeStyle(this.id.toString());" 
                        onBlur="ChangeDefaultStyle(this.id.toString());"   class="t1" Enabled="False"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    DOC
                </td>
                <td>
                    :
                    <b>
                    
                    </b>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtDoc" 
                        onfocus="ChangeStyle(this.id.toString());" 
                        onBlur="ChangeDefaultStyle(this.id.toString());"   class="t1" Enabled="False">
                    </asp:TextBox>
                          
                </td>
            </tr>
            <tr>
                <td>
                    LAST OUT
                </td>
                <td>
                    :
                    <b>
                    
                    </b>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtOut" 
                        onfocus="ChangeStyle(this.id.toString());" 
                        onBlur="ChangeDefaultStyle(this.id.toString());"   class="t1" Enabled="False"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    LAST SCHEDULE
                </td>
                <td>
                    :
                    <b>
                    
                    </b>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtLastSchedule" 
                        onfocus="ChangeStyle(this.id.toString());" 
                        onBlur="ChangeDefaultStyle(this.id.toString());"   class="t1" Enabled="False"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    REPAIR ATTENDED
                </td>
                <td>
              :
                    <b>
                    
                    </b>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtRepair" TextMode="MultiLine" 
                        onfocus="ChangeStyle(this.id.toString());" 
                        onBlur="ChangeDefaultStyle(this.id.toString());"   class="t1" Height="68px" 
                        Width="281px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    DIV
                      </td>
                <td>
                    :
                    <b>
                    
                    </b>
                </td>
                <td>
                    <asp:DropDownList runat="server" ID="ddlDiv" onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"   class="t1"></asp:DropDownList>
                </td>
            </tr>

                <tr>
                <td>
                    SITE
                </td>
                <td>
                    :
                    <b>
                    
                    </b>
                </td>
                <td>
                    <asp:DropDownList runat="server" ID="ddlSite" onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"   class="t1"></asp:DropDownList>
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
                    <asp:DropDownList runat="server" ID="ddlSection" onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"   class="t1"></asp:DropDownList>
                </td>
            </tr>
            
              <tr>
                <td>
                    REMARKS
                </td>
                <td>
                    :
                </td>
                <td>
                  <asp:TextBox runat="server" ID="txtRemarks" TextMode="MultiLine" 
                        onfocus="ChangeStyle(this.id.toString());" 
                        onBlur="ChangeDefaultStyle(this.id.toString());"   class="t1" Height="62px" 
                        Width="281px"></asp:TextBox>  
                </td>
            </tr>
            <td colspan="7" align="center"><asp:Button runat="server" ID="btnSave" 
                    Text="INSERT" onfocus="ChangeStyle(this.id.toString());" 
                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t2" 
                    OnClientClick="return CallValidation();" OnClick="btnSave_OnClick"/></td>

</table>
</asp:Content>

