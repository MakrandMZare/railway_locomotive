<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true" CodeFile="Temporary_Repair.aspx.cs" Inherits="LocoShedPosition_Temporary_Repair" Title="Untitled Page" EnableEventValidation="false"%>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:ToolkitScriptManager runat="server" ID="ToolkitScriptManager1"></asp:ToolkitScriptManager>       

            <table align="center">
                <tr>
                    <th colspan="6">
                        EMD LOCOS UNDER TEMPORARY REPAIR </th>
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
                <%--<tr>
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
                </tr>--%>
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
                        REASON
                    </td>
                    <td>
                        :
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtReason" onfocus="ChangeStyle(this.id.toString());"
                            onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" 
                            TextMode="MultiLine" Height="99px" Width="256px" ></asp:TextBox>
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
                        <asp:TextBox runat="server" ID="txtRemarks" onfocus="ChangeStyle(this.id.toString());"
                            onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" 
                            TextMode="MultiLine" Height="90px" Width="259px"></asp:TextBox>
                    </td>
                </tr>
                <tr><td colspan="6" align="center"><asp:Button runat="server" ID="btnSave" 
                    Text="INSERT" onfocus="ChangeStyle(this.id.toString());" 
                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t2" 
                    OnClick="btnSave_OnClick"/></td></tr>
            </table>

</asp:Content>

