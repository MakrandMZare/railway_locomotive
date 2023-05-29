<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true" CodeFile="loco_gtkm.aspx.cs" Inherits="Loco_loco_gtkm" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
        <tr>
            <th colspan="9">
                GTKM DETAIL</th>
        </tr>
        <tr>
            <td align="left">
                DATE</td>
            <td align="left">
                :</td>
            <td align="left">
            <asp:TextBox ID="txtDate" runat="server" CssClass="t1"></asp:TextBox></td>
            <td align="left">
                CLASS</td>
            <td align="left">
                :</td>
            <td align="left">
                <asp:DropDownList ID="ddlclass" runat="server" AutoPostBack="True" CssClass="t1"
                    OnSelectedIndexChanged="ddlClass_SelectedIndexChanged">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList></td>
            <td align="left">
                LOCO NO</td>
            <td align="left">
                :</td>
            <td align="left">
                <asp:DropDownList ID="ddlLocono" runat="server" AutoPostBack="True" CssClass="t1"
                    OnSelectedIndexChanged="ddlLocono_OnSelectedIndexChanged">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td align="left">
                FROM</td>
            <td align="left">
                :</td>
            <td align="left">
                <asp:DropDownList ID="ddlFrom" runat="server" AutoPostBack="True" CssClass="t1">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList></td>
            <td align="left">
                TO</td>
            <td align="left">
                :</td>
            <td align="left">
                <asp:DropDownList ID="ddlTo" runat="server" AutoPostBack="True" CssClass="t1" OnSelectedIndexChanged="ddlTo_SelectedIndexChanged">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList></td>
            <td align="left">
                EKM</td>
            <td align="left">
                :</td>
            <td align="left">
            <asp:TextBox ID="txtEkm" runat="server" CssClass="t1" Enabled="False" Width="35px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="left" >
                FUEL OIL CONSUPTION</td>
            <td align="left" >
                :</td>
            <td align="left" >
            <asp:TextBox ID="txtFuelOil" runat="server" CssClass="t1"></asp:TextBox>
            </td>
            <td align="center" >
            </td>
            <td align="center" >
            </td>
            <td align="center" >
            </td>
            <td align="center">
            </td>
            <td align="center">
            </td>
            <td align="center">
            </td>
        </tr>
        <tr>
            <td align="left" >
                LUBE OIL </td>
            <td align="left" >
                :</td>
            <td align="left" >
            <asp:TextBox ID="txtLubeoil" runat="server" CssClass="t1"></asp:TextBox>
            </td>
            <td align="center" >
            </td>
            <td align="center" >
            </td>
            <td align="center" >
            </td>
            <td align="center">
            </td>
            <td align="center">
            </td>
            <td align="center">
            </td>
        </tr>
        <tr>
            <td align="left">
                LOAD</td>
            <td align="left">
                :</td>
            <td align="left">
            <asp:TextBox ID="txtLoad"  runat="server" CssClass="t1"></asp:TextBox>
            </td>
            <td align="center">
                </td>
            <td align="center">
                </td>
            <td align="center">
                </td>
            <td align="center">
                </td>
            <td align="center">
            </td>
            <td align="center">
            </td>
        </tr>
        <tr>
            <td align="center">
                TOTAL LOAD</td>
            <td align="center">
            </td>
            <td align="center">
                GTKM</td>
            <td align="center">
            </td>
            <td align="center">
            </td>
            <td align="center">
                SFC</td>
            <td align="center">
                LRF</td>
            <td align="center">
            </td>
            <td align="center">
                LOC</td>
        </tr>
        <tr>
            <td align="center">
                <asp:TextBox ID="txtTotalLoad" runat="server" CssClass="t1" Enabled="False" Width="41px"></asp:TextBox></td>
            <td align="center">
            </td>
            <td align="center">
                <asp:TextBox ID="txtgtkm" runat="server" CssClass="t1" Enabled="False" Width="41px"></asp:TextBox></td>
            <td align="center">
            </td>
            <td align="center">
            </td>
            <td align="center">
                <asp:TextBox ID="txtsfc" runat="server" CssClass="t1" Enabled="False" Width="41px"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="txtlfr" runat="server" CssClass="t1" Enabled="False" Width="41px"></asp:TextBox></td>
            <td align="center">
            </td>
            <td align="center">
                <asp:TextBox ID="txtloc" runat="server" CssClass="t1" Enabled="False" Width="41px"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="9" align="center">
                &nbsp;
            <asp:Button ID="btnShow" Text="CALCULATE" CssClass="t1" runat="server" OnClick="btnCancel_Click" />
                <asp:Button ID="btnInert" Text="INSERT" CssClass="t1" runat="server" OnClick="btnInert_Click" />
                <asp:Button ID="btnCancel" Text="CANCEL" CssClass="t1" runat="server" OnClick="btnInert_Click" /></td>
        </tr>
        <tr>
            <td align="center" colspan="9">
            </td>
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
    </table>
</asp:Content>

