<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true" CodeFile="failure3.aspx.cs" Inherits="Loco_failure3" Title="Untitled Page" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table width="100%">
        <tr>
            <th colspan="6" >
                FAILURE 3</th>
        </tr>
        <tr>
            <td colspan="6">
                <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
                </cc1:ToolkitScriptManager>
                <cc1:CalendarExtender ID="CalendarExtender1" runat="server" Format="dd/MM/yyyy" TargetControlID="txtDate1">
                </cc1:CalendarExtender>
                &nbsp;
                <cc1:CalendarExtender ID="CalendarExtender3" runat="server" Format="dd/MM/yyyy" TargetControlID="txtlastout">
                </cc1:CalendarExtender>
                <cc1:CalendarExtender ID="CalendarExtender2" runat="server" Format="dd/MM/yyyy" TargetControlID="txtLastScheduleDate">
                </cc1:CalendarExtender>
                <cc1:CalendarExtender ID="CalendarExtender4" runat="server" Format="dd/MM/yyyy" TargetControlID="txtShedarrival">
                </cc1:CalendarExtender>
                <cc1:CalendarExtender ID="CalendarExtender5" runat="server" Format="dd/MM/yyyy" TargetControlID="txtDateOfAtt">
                </cc1:CalendarExtender>
            </td>
        </tr>
        <tr>
            <td >
                NOT USE OF DEFECT&nbsp;
            </td>
            <td >
                :</td>
            <td >
                <asp:TextBox ID="txtNotUse" runat="server" CssClass="t1"></asp:TextBox></td>
            <td >
                LAST OUT DATE
            </td>
            <td >
                :</td>
            <td >
                <asp:TextBox ID="txtlastout" runat="server" CssClass="t1"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                SUPPLIER
            </td>
            <td>
                :</td>
            <td>
                <asp:DropDownList ID="ddlSupplier" runat="server" CssClass="t1">
                </asp:DropDownList></td>
            <td>
                SHED ARRIVAL DATE</td>
            <td>
                :</td>
            <td>
                <asp:TextBox ID="txtShedarrival" runat="server" CssClass="t1"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                PLACE</td>
            <td>
                :</td>
            <td>
                <asp:DropDownList ID="ddlHq" runat="server" CssClass="t1">
                </asp:DropDownList></td>
            <td>
                CPA</td>
            <td>
                :</td>
            <td>
                <asp:TextBox ID="txtcpa" runat="server" CssClass="t1"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                DATE</td>
            <td>
                :</td>
            <td>
                <asp:TextBox ID="txtDate1" runat="server" CssClass="t1"></asp:TextBox></td>
            <td>
                SHIFT</td>
            <td>
                :</td>
            <td>
                <asp:TextBox ID="txtshift" runat="server" CssClass="t1"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                DATE OF ATTENSION
            </td>
            <td>
                :</td>
            <td>
                <asp:TextBox ID="txtDateOfAtt" runat="server" CssClass="t1"></asp:TextBox></td>
            <td>
                SHEDULE IN WH
            </td>
            <td>
                :</td>
            <td>
                <asp:TextBox ID="txtShedInWh" runat="server" CssClass="t1"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                LAST SCHEDULE DATE</td>
            <td>
                :</td>
            <td>
                <asp:TextBox ID="txtLastScheduleDate" runat="server" CssClass="t1"></asp:TextBox></td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
                LAST SCHEDULE</td>
            <td>
                :</td>
            <td>
                <asp:DropDownList ID="ddlSchedule" runat="server" class="t1" onblur="ChangeDefaultStyle(this.id.toString());"
                    onfocus="ChangeStyle(this.id.toString());">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList></td>
            <td>
                ARRIVAL POSITION
            </td>
            <td>
                :</td>
            <td>
                <asp:TextBox ID="txtArrivalPosition" runat="server" CssClass="t1"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                SUPERVISOR&nbsp;</td>
            <td>
                :</td>
            <td>
                <asp:TextBox ID="txtSupervisor" runat="server" CssClass="t1"></asp:TextBox></td>
            <td>
                SHED RESPONSE</td>
            <td>
                :</td>
            <td>
                <asp:TextBox ID="txtShedResponse" runat="server" CssClass="t1"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                MECHANIC
            </td>
            <td>
                :</td>
            <td>
                <asp:TextBox ID="txtMechanic" runat="server" CssClass="t1"></asp:TextBox></td>
            <td>
                OBSERVATION</td>
            <td>
                :</td>
            <td>
                <asp:TextBox ID="txtObservation" runat="server" CssClass="t1"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                REPERCUSSION</td>
            <td>
                :</td>
            <td>
                <asp:TextBox ID="txtRepercussion" runat="server" CssClass="t1"></asp:TextBox></td>
        </tr>
        <tr>
            <td >
                MESSAGE
            </td>
            <td >
                :</td>
            <td >
                <asp:TextBox ID="txtmsg" runat="server" CssClass="t1" Height="75px" TextMode="MultiLine"
                    Width="201px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="center" colspan="6">
                <asp:Button ID="btnInsert" runat="server" CssClass="t1" Height="29px" OnClick="Button1_Click"
                    Text="INSERT" Width="98px" />
                &nbsp; &nbsp;
                <asp:Button ID="btncancel" runat="server" CssClass="t1" Height="29px" OnClick="btncancel_Click"
                    Text="CANCEL" Width="98px" /></td>
        </tr>
    </table>
</asp:Content>

