<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true" CodeFile="ScheduleCard.aspx.cs" Inherits="ElectronicChekSheet_ScheduleCard" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
        <tr>
            <th colspan="6">
                SCHEDULE CARD</th>
        </tr>
        <tr>
            <td >
                SECTION</td>
            <td >
                :</td>
            <td >
                <asp:DropDownList ID="ddlsection" runat="server" CssClass="t1">
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td >
                SUB SECTION</td>
            <td >
                :</td>
            <td >
                <asp:TextBox ID="txtsubSection" runat="server" CssClass="t1" Width="361px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="center" colspan="3" >
                <asp:Button ID="Button1" runat="server" CssClass="t1" OnClick="Button1_Click" Text="INSERT" /></td>
        </tr>
    </table>
</asp:Content>

