<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true" CodeFile="failure2.aspx.cs" Inherits="Loco_failure2" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table width="100%">
        <tr>
            <th colspan="6" >FAILURE ANALYSIS
            </th>
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
                </asp:DropDownList></td>
            <td >
                LOCO NO</td>
            <td >
                :</td>
            <td >
                <asp:DropDownList ID="ddlLocono" runat="server" AutoPostBack="True" class="t1" onblur="ChangeDefaultStyle(this.id.toString());"
                    onfocus="ChangeStyle(this.id.toString());" OnSelectedIndexChanged="ddlLocono_SelectedIndexChanged">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td >
                RAILWAY</td>
            <td >
                :</td>
            <td ><asp:DropDownList ID="ddlrailway" runat="server" CssClass="t1">
                <asp:ListItem>SELECT</asp:ListItem>
                <asp:ListItem>WESTERN RAILWAY</asp:ListItem>
                <asp:ListItem>SOUTH RAILWAY</asp:ListItem>
                <asp:ListItem>NORTH RAILWAY</asp:ListItem>
                <asp:ListItem>EAST RAILWAY</asp:ListItem>
            </asp:DropDownList></td>
            <td >
                RESP</td>
            <td >
                :</td>
            <td >
                <asp:TextBox ID="txtresp" runat="server" CssClass="t1"></asp:TextBox></td>
        </tr>
        <tr>
            <td >
                FAILURE TYPE</td>
            <td >
                :</td>
            <td >
                <asp:DropDownList ID="ddlFailuretype" runat="server" CssClass="t1">
                    <asp:ListItem>SELECT</asp:ListItem>
                    <asp:ListItem>REPORTED</asp:ListItem>
                    <asp:ListItem>DEAD ON LINE</asp:ListItem>
                </asp:DropDownList></td>
            <td >
                OVER DUE</td>
            <td >
                :</td>
            <td >
                <asp:TextBox ID="txtOverdue" runat="server" CssClass="t1"></asp:TextBox></td>
        </tr>
        <tr>
            <td >
                UNIT</td>
            <td >
                :</td>
            <td >
                <asp:DropDownList ID="ddlUnit" runat="server" CssClass="t1">
                </asp:DropDownList></td>
            <td >
                MAIN ASSEMBLY</td>
            <td >
                :</td>
            <td >
                <asp:TextBox ID="txtmainAssembly" runat="server" CssClass="t1"></asp:TextBox></td>
        </tr>
        <tr>
            <td >
                WING</td>
            <td >
                :</td>
            <td >
                <asp:DropDownList ID="ddlwing" runat="server" CssClass="t1">
                </asp:DropDownList></td>
            <td >
                SUBASSEMBLY</td>
            <td >
                :</td>
            <td >
                <asp:TextBox ID="txtsubassembly" runat="server" CssClass="t1"></asp:TextBox></td>
        </tr>
        <tr>
            <td >
                CATEGORY</td>
            <td >
                :</td>
            <td >
                <asp:DropDownList ID="ddlCategory" runat="server" CssClass="t1">
                </asp:DropDownList></td>
            <td >
                COMPONENT BISECTION</td>
            <td >
                :</td>
            <td >
                <asp:TextBox ID="txtcomponent" runat="server" CssClass="t1"></asp:TextBox></td>
        </tr>
        <tr>
            <td >
                AVOIDABLE</td>
            <td >
                :</td>
            <td >
                <asp:DropDownList ID="ddlAvoidable" runat="server" CssClass="t1">
                    <asp:ListItem>SELECT</asp:ListItem>
                    <asp:ListItem>YES</asp:ListItem>
                    <asp:ListItem>NO</asp:ListItem>
                </asp:DropDownList></td>
            <td >
                SERVICES</td>
            <td >
            </td>
            <td >
                <asp:TextBox ID="txtservices" runat="server" CssClass="t1"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="center" colspan="6" >
                <asp:Button ID="btnInsert" runat="server" CssClass="t1" Height="29px" OnClick="Button1_Click"
                    Text="INSERT" Width="98px" />
                &nbsp;
                <asp:Button ID="btncancel" runat="server" CssClass="t1" Height="29px" OnClick="btncancel_Click"
                    Text="CANCEL" Width="98px" /></td>
        </tr>
    </table>
</asp:Content>

