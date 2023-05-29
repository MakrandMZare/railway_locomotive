<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true" CodeFile="failure1.aspx.cs" Inherits="Loco_failure1" Title="Untitled Page" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table width="100%">
        <tr>
            <th colspan="6" align="center">
            FAILURE DETAIL
            </th>
        </tr>
        <tr>
            <td colspan="6">
                <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
                </cc1:ToolkitScriptManager>
                <cc1:CalendarExtender ID="CalendarExtender1" runat="server" Format="dd/MM/yyyy"
                    TargetControlID="txtIncidentDate">
                </cc1:CalendarExtender>
                &nbsp; &nbsp;
            </td>
        </tr>
        <tr>
            <td >
                CLASS</td>
            <td >
                :</td>
            <td >
                <asp:DropDownList ID="ddlClass" runat="server" AutoPostBack="True" class="t1" onblur="ChangeDefaultStyle(this.id.toString());"
                    onfocus="ChangeStyle(this.id.toString());" OnSelectedIndexChanged="ddlClass_SelectedIndexChanged">
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
                </td>
            <td >
                LOCO NO</td>
            <td >
                :</td>
            <td >
                <asp:DropDownList ID="ddlLocono" runat="server" AutoPostBack="True" class="t1" onblur="ChangeDefaultStyle(this.id.toString());"
                    onfocus="ChangeStyle(this.id.toString());" 
                    OnSelectedIndexChanged="ddlLocono_SelectedIndexChanged">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList>
                </td>
        </tr>
        <tr>
            <td >
                MU / SU</td>
            <td >
                :</td>
            <td >
                <asp:TextBox ID="txtmu_su" runat="server" CssClass="t1"></asp:TextBox></td>
            <td >
                MU WITH</td>
            <td >
                :</td>
            <td >
                <asp:TextBox ID="txtMuWith" runat="server" CssClass="t1"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                CAB</td>
            <td>
                :</td>
            <td>
                <asp:TextBox ID="txtCab" runat="server" CssClass="t1"></asp:TextBox></td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td >
                INCIDENT DATE</td>
            <td >
                :</td>
            <td >
                <asp:TextBox ID="txtIncidentDate" runat="server" CssClass="t1"></asp:TextBox></td>
            <td >
                TIME</td>
            <td >
                :</td>
            <td >
                <asp:TextBox ID="txtTime11" runat="server" CssClass="t1" Width="24px"></asp:TextBox>:<asp:TextBox
                    ID="txtTime12" runat="server" CssClass="t1" Width="24px"></asp:TextBox></td>
        </tr>
        <tr>
            <td >
                TRAIN NO</td>
            <td >
                :</td>
            <td >
                <asp:TextBox ID="txtTrainNo" runat="server" CssClass="t1"></asp:TextBox></td>
            <td >
                LOAD</td>
            <td >
                :</td>
            <td >
                <asp:TextBox ID="txtLoad" runat="server" CssClass="t1"></asp:TextBox></td>
        </tr>
        <tr>
            <td >
                LINK</td>
            <td >
                :</td>
            <td ><asp:DropDownList ID="ddlLink" runat="server" class="t1" onblur="ChangeDefaultStyle(this.id.toString());"
                    onfocus="ChangeStyle(this.id.toString());" 
                    OnSelectedIndexChanged="ddlLocono_SelectedIndexChanged">
                <asp:ListItem>SELECT</asp:ListItem>
                <asp:ListItem>GOODS</asp:ListItem>
            </asp:DropDownList></td>
            <td >
                </td>
            <td >
                </td>
            <td >
                </td>
        </tr>
        <tr>
            <td >
                DRIVER'S NAME</td>
            <td >
                :</td>
            <td ><asp:DropDownList ID="ddlTncName" runat="server" class="t1" onblur="ChangeDefaultStyle(this.id.toString());"
                    onfocus="ChangeStyle(this.id.toString());" 
                    OnSelectedIndexChanged="ddlLocono_SelectedIndexChanged">
                <asp:ListItem>SELECT</asp:ListItem>
            </asp:DropDownList></td>
            <td >
                HQ</td>
            <td >
                :</td>
            <td >
                <asp:DropDownList ID="ddlHq" runat="server" class="t1" onblur="ChangeDefaultStyle(this.id.toString());"
                    onfocus="ChangeStyle(this.id.toString());">
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td>
                SITE</td>
            <td>
                :</td>
            <td>
                <asp:DropDownList ID="ddlSite" runat="server" class="t1" onblur="ChangeDefaultStyle(this.id.toString());"
                    onfocus="ChangeStyle(this.id.toString());" 
                    OnSelectedIndexChanged="ddlLocono_SelectedIndexChanged">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList></td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
                SECTION</td>
            <td>
                :</td>
            <td>
                <asp:DropDownList ID="ddlSection" runat="server" class="t1" onblur="ChangeDefaultStyle(this.id.toString());"
                    onfocus="ChangeStyle(this.id.toString());" 
                    OnSelectedIndexChanged="ddlLocono_SelectedIndexChanged">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList></td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
                DIVISION</td>
            <td>
                :</td>
            <td>
                <asp:DropDownList ID="ddlDivision" runat="server" class="t1" onblur="ChangeDefaultStyle(this.id.toString());"
                    onfocus="ChangeStyle(this.id.toString());" 
                    OnSelectedIndexChanged="ddlLocono_SelectedIndexChanged">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList></td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="6" >
                <asp:Button ID="btnInsert" runat="server" CssClass="t1" Text="INSERT" Width="98px" Height="29px" OnClick="Button1_Click" />
                &nbsp; &nbsp;<asp:Button ID="btncancel" runat="server" CssClass="t1" Text="CANCEL"
                    Width="98px" Height="29px" OnClick="btncancel_Click" /></td>
        </tr>
    </table>
</asp:Content>

