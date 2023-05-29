<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true"
    CodeFile="failure1.aspx.cs" Inherits="Loco_failure1" Title="Untitled Page" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table width="100%">
        <tr>
            <th colspan="9" align="center">
                FAILURE DETAIL
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
                </asp:DropDownList>
            </td>
            <td>
                LOCO NO</td>
            <td>
                :</td>
            <td>
                <asp:DropDownList ID="ddlLocono" runat="server" AutoPostBack="True" class="t1" onblur="ChangeDefaultStyle(this.id.toString());"
                    onfocus="ChangeStyle(this.id.toString());">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
                MU / SU</td>
            <td>
                :</td>
            <td>
                <asp:DropDownList ID="ddlMuSu" runat="server" class="t1" onblur="ChangeDefaultStyle(this.id.toString());"
                    onfocus="ChangeStyle(this.id.toString());" OnSelectedIndexChanged="ddlMuSu_SelectedIndexChanged" AutoPostBack="True">
                    <asp:ListItem>SELECT</asp:ListItem>
                    <asp:ListItem>MU</asp:ListItem>
                    <asp:ListItem>SU</asp:ListItem>
                </asp:DropDownList></td>
            <td>
                MU WITH</td>
            <td>
                :</td>
            <td>
                <asp:TextBox ID="txtMuWith" runat="server" CssClass="t1" Width="79px" Visible="False"></asp:TextBox></td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
                INCIDENT DATE</td>
            <td>
                :</td>
            <td>
                <asp:TextBox ID="txtIncidentDate" runat="server" CssClass="t1"></asp:TextBox></td>
            <td>
                TIME</td>
            <td>
                :</td>
            <td>
                <asp:TextBox ID="txtTime11" runat="server" CssClass="t1" Width="24px"></asp:TextBox>:<asp:TextBox
                    ID="txtTime12" runat="server" CssClass="t1" Width="24px"></asp:TextBox></td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
                TRAIN NO</td>
            <td>
                :</td>
            <td>
                <asp:TextBox ID="txtTrainNo" runat="server" CssClass="t1"></asp:TextBox></td>
            <td>
                LOAD</td>
            <td>
                :</td>
            <td>
                <asp:TextBox ID="txtLoad" runat="server" CssClass="t1"></asp:TextBox></td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
                LINK</td>
            <td>
                :</td>
            <td>
                <asp:DropDownList ID="ddlLink" runat="server" class="t1" onblur="ChangeDefaultStyle(this.id.toString());"
                    onfocus="ChangeStyle(this.id.toString());">
                    <asp:ListItem>SELECT</asp:ListItem>
                    <asp:ListItem>GOODS</asp:ListItem>
                    <asp:ListItem>PASSENGER</asp:ListItem>
                    <asp:ListItem>MIX</asp:ListItem>
                </asp:DropDownList></td>
            <td>
                DIVISION</td>
            <td>
                :</td>
            <td>
                <asp:DropDownList ID="ddlDivision" runat="server" class="t1" onblur="ChangeDefaultStyle(this.id.toString());"
                    onfocus="ChangeStyle(this.id.toString());">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList></td>
            <td>
                ARRIVAL POSITION</td>
            <td>
                :</td>
            <td>
                <asp:DropDownList ID="ddlArrivalPosition" runat="server" CssClass="t1">
                    <asp:ListItem>SELECT</asp:ListItem>
                    <asp:ListItem>WORKING</asp:ListItem>
                    <asp:ListItem>LIGHT POSITION</asp:ListItem>
                    <asp:ListItem>DEAD</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td>
                DRIVER'S NAME</td>
            <td>
                :</td>
            <td>
                <asp:TextBox ID="txtDriverName" runat="server" CssClass="t1"></asp:TextBox></td>
            <td>
                HQ</td>
            <td>
                :</td>
            <td>
                <asp:TextBox ID="txtHq" runat="server" CssClass="t1"></asp:TextBox></td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
                SITE</td>
            <td>
                :</td>
            <td>
                <asp:TextBox ID="txtSite" runat="server" CssClass="t1"></asp:TextBox></td>
            <td>
                SECTION</td>
            <td>
                :</td>
            <td>
                <asp:TextBox ID="txtSection" runat="server" CssClass="t1"></asp:TextBox></td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
                RAILWAY</td>
            <td>
                :</td>
            <td>
                <asp:DropDownList ID="ddlrailway" runat="server" CssClass="t1">
                    <asp:ListItem>SELECT</asp:ListItem>
                    <asp:ListItem>WESTERN RAILWAY</asp:ListItem>
                    <asp:ListItem>SOUTH RAILWAY</asp:ListItem>
                    <asp:ListItem>NORTH RAILWAY</asp:ListItem>
                    <asp:ListItem>EAST RAILWAY</asp:ListItem>
                </asp:DropDownList></td>
            <td>
                RESP</td>
            <td>
                :</td>
            <td>
                <asp:DropDownList ID="ddlresp" runat="server" class="t1" onblur="ChangeDefaultStyle(this.id.toString());"
                    onfocus="ChangeStyle(this.id.toString());">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList></td>
            <td>
                CATEGORY</td>
            <td>
                :</td>
            <td>
                <asp:DropDownList ID="ddlCategory" runat="server" CssClass="t1">
                    <asp:ListItem>LINE MESSAGE</asp:ListItem>
                    <asp:ListItem>STATICAL</asp:ListItem>
                    <asp:ListItem>NONSTATICAL</asp:ListItem>
                    <asp:ListItem>UNREPORTED</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td>
                FAILURE TYPE</td>
            <td>
                :</td>
            <td>
                <asp:DropDownList ID="ddlFailuretype" runat="server" CssClass="t1">
                    <asp:ListItem>SELECT</asp:ListItem>
                    <asp:ListItem>SHED DETECTION</asp:ListItem>
                    <asp:ListItem>LINE FAILURE</asp:ListItem>
                </asp:DropDownList></td>
            <td>
                WING</td>
            <td>
                :</td>
            <td>
                <asp:DropDownList ID="ddlwing" runat="server" CssClass="t1">
                    <asp:ListItem>SELECT</asp:ListItem>
                    <asp:ListItem>ELECTRICAL</asp:ListItem>
                    <asp:ListItem>MECHENICAL</asp:ListItem>
                </asp:DropDownList></td>
            <td>
                OVER DUE</td>
            <td>
                :</td>
            <td>
                <asp:DropDownList ID="ddlOverDue" runat="server" class="t1" onblur="ChangeDefaultStyle(this.id.toString());"
                    onfocus="ChangeStyle(this.id.toString());">
                    <asp:ListItem>SELECT</asp:ListItem>
                    <asp:ListItem>YES</asp:ListItem>
                    <asp:ListItem>NO</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td>
                AVOIDABLE</td>
            <td>
                :</td>
            <td>
                <asp:DropDownList ID="ddlAvoidable" runat="server" CssClass="t1">
                    <asp:ListItem>SELECT</asp:ListItem>
                    <asp:ListItem>YES</asp:ListItem>
                    <asp:ListItem>NO</asp:ListItem>
                </asp:DropDownList></td>
            <td>
                </td>
            <td>
            </td>
            <td>
                </td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
                ASSEMBLY</td>
            <td>
                :</td>
            <td>
                <asp:DropDownList ID="ddlRdso1" runat="server" AutoPostBack="True" class="t1" onblur="ChangeDefaultStyle(this.id.toString());"
                    onfocus="ChangeStyle(this.id.toString());" OnSelectedIndexChanged="ddlRdso1_SelectedIndexChanged">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList></td>
            <td>
                </td>
            <td>
                </td>
            <td>
                </td>
            <td>
                </td>
            <td>
                </td>
            <td>
                </td>
        </tr>
        <tr>
            <td>
                MAIN ASSEMBLY</td>
            <td>
                :</td>
            <td>
                <asp:DropDownList ID="ddlRdso2" runat="server" AutoPostBack="True" class="t1" onblur="ChangeDefaultStyle(this.id.toString());"
                    onfocus="ChangeStyle(this.id.toString());" OnSelectedIndexChanged="ddlRdso2_SelectedIndexChanged">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList></td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
                SUB ASSEMBLY</td>
            <td>
                :</td>
            <td>
                <asp:DropDownList ID="ddlRdso3" runat="server" AutoPostBack="True" class="t1" onblur="ChangeDefaultStyle(this.id.toString());"
                    onfocus="ChangeStyle(this.id.toString());" OnSelectedIndexChanged="ddlRdso3_SelectedIndexChanged">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList></td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
                DIFFECTIVE CODE</td>
            <td>
                :</td>
            <td>
                <asp:DropDownList ID="ddlRdso4" runat="server" AutoPostBack="True" class="t1" onblur="ChangeDefaultStyle(this.id.toString());"
                    onfocus="ChangeStyle(this.id.toString());" OnSelectedIndexChanged="ddlRdso4_SelectedIndexChanged">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList></td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
                SERVICES</td>
            <td>
                :</td>
            <td>
                <asp:TextBox ID="txtservices" runat="server" CssClass="t1"></asp:TextBox></td>
            <td>
                SUPERVISOR</td>
            <td>
                :</td>
            <td>
                <asp:TextBox ID="txtSupervisor" runat="server" CssClass="t1"></asp:TextBox></td>
            <td>
                C &amp; PA</td>
            <td>
                :</td>
            <td>
                <asp:TextBox ID="txtcpa" runat="server" CssClass="t1"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
            </td>
            <td>
                </td>
            <td>
                &nbsp;</td>
            <td>
            </td>
            <td>
                </td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
                SHED RESPONSE</td>
            <td>
                :</td>
            <td>
                <asp:TextBox ID="txtShedResponse" runat="server" CssClass="t1"></asp:TextBox></td>
            <td>
                MECHANIC</td>
            <td>
                :</td>
            <td>
                <asp:TextBox ID="txtMechanic" runat="server" CssClass="t1"></asp:TextBox></td>
            <td>
                SHIFT</td>
            <td>
                :</td>
            <td>
                <asp:TextBox ID="txtshift" runat="server" CssClass="t1"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
                MESSAGE
            </td>
            <td>
                :</td>
            <td>
                <asp:TextBox ID="txtmsg" runat="server" CssClass="t1" Height="80px" TextMode="MultiLine"
                    Width="200px"></asp:TextBox></td>
            <td>
                OBSERVATION</td>
            <td>
                :</td>
            <td>
                <asp:TextBox ID="txtObservation" runat="server" CssClass="t1" Height="80px" TextMode="MultiLine"
                    Width="200px"></asp:TextBox></td>
            <td>
                REPERCUSSION</td>
            <td>
                :</td>
            <td>
                <asp:TextBox ID="txtRepercussion" runat="server" CssClass="t1" Height="80px" TextMode="MultiLine"
                    Width="200px"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                LAST OUT DATE
            </td>
            <td>
            </td>
            <td>
                <asp:TextBox ID="txtlastoutDate" runat="server" CssClass="t1"></asp:TextBox></td>
            <td>
                SHED ARRIVAL DATE</td>
            <td>
                :</td>
            <td>
                <asp:TextBox ID="txtShedarrival" runat="server" CssClass="t1"></asp:TextBox></td>
            <td>
                LAST SCHEDULE</td>
            <td>
                :</td>
            <td><asp:DropDownList ID="ddlschedule1" runat="server" CssClass="t1">
            </asp:DropDownList></td>
        </tr>
        <tr>
            <td>
                </td>
            <td>
            </td>
            <td>
                &nbsp;&nbsp;
            </td>
            <td>
            </td>
            <td>
            </td>
            <td>
                &nbsp;
            </td>
            <td>
            </td>
            <td>
            </td>
            <td>
                &nbsp;</td>
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
                PLACE</td>
            <td>
                :</td>
            <td>
                <asp:DropDownList ID="ddlHq" runat="server" CssClass="t1">
                </asp:DropDownList></td>
            <td>
                SHEDULE IN WH
            </td>
            <td>
                :</td>
            <td>
                <asp:DropDownList ID="ddlScheduleInWh" runat="server" CssClass="t1">
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td>
                </td>
            <td>
            </td>
            <td>
                </td>
            <td>
                </td>
            <td>
            </td>
            <td>
                </td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
                DATE</td>
            <td>
                :</td>
            <td>
                <asp:TextBox ID="txtDate1" runat="server" CssClass="t1"></asp:TextBox></td>
            <td>
                DATE OF ATTENSION</td>
            <td>
                :</td>
            <td>
                <asp:TextBox ID="txtDateOfAtt" runat="server" CssClass="t1"></asp:TextBox></td>
            <td>
                LAST SCHEDULE DATE</td>
            <td>
                :</td>
            <td>
                <asp:TextBox ID="txtLastScheduleDate" runat="server" CssClass="t1"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="center" colspan="9">
                <asp:Button ID="btnInsert" runat="server" CssClass="t1" Text="INSERT" Width="98px"
                    Height="29px" OnClick="Button1_Click" />
                &nbsp; &nbsp;<asp:Button ID="btncancel" runat="server" CssClass="t1" Text="CANCEL"
                    Width="98px" Height="29px" OnClick="btncancel_Click" /></td>
        </tr>
        <tr>
            <td align="center" colspan="9">
                <cc1:CalendarExtender ID="CalendarExtender4" runat="server" Format="dd/MM/yyyy"
                    TargetControlID="txtDate1">
                </cc1:CalendarExtender>
                <cc1:CalendarExtender ID="CalendarExtender3" runat="server" Format="dd/MM/yyyy" TargetControlID="txtShedarrival">
                </cc1:CalendarExtender>
                <cc1:CalendarExtender ID="CalendarExtender2" runat="server" Format="dd/MM/yyyy" TargetControlID="txtlastoutDate">
                </cc1:CalendarExtender>
            <cc1:CalendarExtender ID="CalendarExtender5" runat="server" Format="dd/MM/yyyy"
                    TargetControlID="txtDateOfAtt">
                </cc1:CalendarExtender>
                <cc1:CalendarExtender ID="CalendarExtender6" runat="server" Format="dd/MM/yyyy" TargetControlID="txtLastScheduleDate">
                </cc1:CalendarExtender>
                <cc1:CalendarExtender ID="CalendarExtender1" runat="server" Format="dd/MM/yyyy" TargetControlID="txtIncidentDate">
                </cc1:CalendarExtender>
                <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
                </cc1:ToolkitScriptManager>
            </td>
        </tr>
    </table>
</asp:Content>
