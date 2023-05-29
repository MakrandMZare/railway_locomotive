<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true" CodeFile="sche_card_sub_head.aspx.cs" Inherits="ElectronicChekSheet_sche_card_sub_head" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
        <tr>
            <th colspan="6">
                SUB SECTION</th>
        </tr>
        <tr>
            <td >
                SUB
                SECTION</td>
            <td >
                :</td>
            <td >
                <asp:DropDownList ID="ddlSubSection" runat="server" CssClass="t1">
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td >
                SCHEDULE</td>
            <td >
                :</td>
            <td >
                <asp:DropDownList ID="ddlSchedule" runat="server" CssClass="t1">
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td >
                SUB HEAD</td>
            <td >
                :</td>
            <td >
                <asp:TextBox ID="txtSubHead" runat="server" CssClass="t1" OnTextChanged="txtSubHead_TextChanged"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="center" colspan="3" rowspan="2" >
                <asp:Button ID="btnInsert" runat="server" CssClass="t1" Text="INSERT" /></td>
        </tr>
        <tr>
        </tr>
    </table>
</asp:Content>

