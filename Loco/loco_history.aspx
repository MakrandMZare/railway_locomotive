<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true"
    CodeFile="loco_history.aspx.cs" Inherits="Loco_loco_history" Title="Untitled Page" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table>
        <tr>
            <th colspan="7">
                LOCO HISTORY
            </th>
        </tr>
        <tr>
            <td>
                CLASS</td>
            <td>
                :</td>
            <td>
                <asp:DropDownList ID="ddlClass" runat="server" AutoPostBack="True" class="t1" onblur="ChangeDefaultStyle(this.id.toString());"
                    onfocus="ChangeStyle(this.id.toString());" OnSelectedIndexChanged="ddlClass_SelectedIndexChanged">
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td>
                LOCO NO</td>
            <td>
                :</td>
            <td>
                <asp:DropDownList ID="ddlLocono" runat="server" AutoPostBack="true" class="t1" onblur="ChangeDefaultStyle(this.id.toString());"
                    onfocus="ChangeStyle(this.id.toString());" OnSelectedIndexChanged="ddlLocono_SelectedIndexChanged" >
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList></td>
            <td>
                SCHEDULE</td>
            <td>
                :</td>
            <td>
                <asp:DropDownList ID="ddlSchedule" runat="server" class="t1" onblur="ChangeDefaultStyle(this.id.toString());"
                    onfocus="ChangeStyle(this.id.toString());">
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td>
                DATE</td>
            <td>
                :</td>
            <td colspan="4">
                <asp:TextBox ID="txtDate" runat="server" CssClass="t1"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                REASON</td>
        <td>:</td>
            <td colspan="4">
        <asp:TextBox ID="txtReason" runat="server" CssClass="t1" Height="114px" TextMode="MultiLine" Width="207px" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="center" class="t1" colspan="6">
                <asp:Button ID="btnInsert" runat="server" CssClass="t1" Text="INSERT" OnClick="btnInsert_Click" />
                <asp:Button ID="btnCancel" runat="server" CssClass="t1" Text="CANCEL" /></td>
        </tr>
    </table>
    <cc1:toolkitscriptmanager id="ToolkitScriptManager1" runat="server"></cc1:toolkitscriptmanager>
    <cc1:calendarextender id="CalendarExtender1" runat="server" format="dd/MM/yyyy" targetcontrolid="txtDate"></cc1:calendarextender>
</asp:Content>
