<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true"
    CodeFile="MG_Incoming_PassengeLoco_n_Scheule.aspx.cs" Inherits="LocoShedPosition_MG_Incoming_PassengeLoco_n_Scheule"
    Title="Untitled Page" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:ToolkitScriptManager runat="server" ID="ToolkitScriptManager1">
    </asp:ToolkitScriptManager>
    <script language="javascript" type="text/javascript">
    function CallValidation()
    {
       var n1 = document.getElementById('<%=ddlClass.ClientID%>').value;
       var n2 = document.getElementById('<%=ddlLocono.ClientID%>').value;
      if(Validate_selectedIndex(n1,'Class') && Validate_selectedIndex(n2,'Loco'))
       {return true;}
       return false;
    }
    </script>
    <table>
        <tr>
            <th colspan="10">
                MG INCOMING PASSENGER LOCO'S THEIER SCHEDULE PARTICULRS.
            </th>
        </tr>
        <tr>
            <td>
                INCOMING TRAIN NO
            </td>
            <td>
                :
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtTrno" onfocus="ChangeStyle(this.id.toString());"
                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
            </td>
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
                        class="t1" >
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
            <td>WHEEL DIAMETER</td><td> : </td><td><asp:TextBox runat="server" ID="txtWheelDia" onfocus="ChangeStyle(this.id.toString());"
                        onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox></td>
            </tr>
            <tr>
            <td colspan="10" align="left"><b>DUE SCHEDULE</b></td>
            </tr>
            <tr>
                <td>
                    MINOR
                </td>
                <td>
                    :
                </td>
                <td>
                    <asp:DropDownList runat="server" ID="ddlMinor" onfocus="ChangeStyle(this.id.toString());"
                        onBlur="ChangeDefaultStyle(this.id.toString());" class="t1">
                        <asp:ListItem>SELECT</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    MAJOR
                </td>
                <td>
                    :
                </td>
                <td>
                    <asp:DropDownList runat="server" ID="ddlMajor" onfocus="ChangeStyle(this.id.toString());"
                        onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" >
                        <asp:ListItem>SELECT</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    LAST SCHEDULE
                </td>
                <td>
                    :
                </td>
                <td>
                    <asp:DropDownList runat="server" ID="ddlLastSchedule" onfocus="ChangeStyle(this.id.toString());"
                        onBlur="ChangeDefaultStyle(this.id.toString());" class="t1">
                        <asp:ListItem>SELECT</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    LAST MLY/QTLY/HTL
                </td>
                <td>
                    :
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtMLY"  onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"   class="t1"></asp:TextBox>DATE : <asp:TextBox runat="server" ID="txtMLYDate"  onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"   class="t1"></asp:TextBox>
                    <asp:CalendarExtender runat="server" ID="CalendarExtender1" 
                        TargetControlID="txtMLYDate" Format="dd/MM/yyyy"></asp:CalendarExtender>
                </td>
            </tr>
            <tr>
            <td colspan="6" align="center"><asp:Button runat="server" ID="btnSave" 
                    Text="INSERT" onfocus="ChangeStyle(this.id.toString());" 
                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t2" 
                    OnClick="btnSave_OnClick" OnClientClick="return CallValidation();"/></td>
            </tr>
    </table>
</asp:Content>
