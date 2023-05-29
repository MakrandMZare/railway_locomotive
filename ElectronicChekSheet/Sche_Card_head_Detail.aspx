<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true" CodeFile="Sche_Card_head_Detail.aspx.cs" Inherits="ElectronicChekSheet_Sche_Card_head_Detail" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
        <tr>
            <th colspan="6">
                SCHEDULE CARD HEAD DETAIL</th>
        </tr>
        <tr>
            <td >
                CARD HEAD</td>
            <td >
                :</td>
            <td >
                <asp:DropDownList ID="ddlCardDetail" runat="server" CssClass="t1">
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td >
                SUB HEAD DETAIL</td>
            <td >
                :</td>
            <td >
                <asp:TextBox ID="txtDetail" runat="server" CssClass="t1" Height="62px" TextMode="MultiLine"
                    Width="422px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="center" colspan="3" >
                <asp:Button ID="btnInsert" runat="server" CssClass="t1" OnClick="btnInsert_Click"
                    Text="INSERT" /></td>
        </tr>
    </table>
</asp:Content>

