<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true"
    CodeFile="Assembly_MechanicalItems_SubMaster.aspx.cs" Inherits="Master_Assembly_MechanicalItems_SubMaster"
    Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table align="center">
        <tr>
            <th colspan="20">
                Electrical Kits Items. of EMD Locomotives
            </th>
        </tr>
        <tr>
            <td>
                Electrical Item
            </td>
            <td>
                :
            </td>
            <td>
                <asp:DropDownList runat="server" ID="ddlMechanical" CssClass="t1">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                Gr SNo.
            </td>
            <td>
                :
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtGrno" CssClass="t1"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Name Description
            </td>
            <td>
                :
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtItemsDescription" CssClass="t1"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                EMD Pr No
            </td>
            <td>
                :
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtEmd" CssClass="t1"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                OEM Pt No
            </td>
            <td>
                :
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtOem" CssClass="t1"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                SWR PL No
            </td>
            <td>
                :
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtSwr" CssClass="t1"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                DLW PL No.
            </td>
            <td>
                :
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtDwlpl" CssClass="t1"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Qty in kit
            </td>
            <td>
                :
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtQty" CssClass="t1"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                LPR and PO Ref.
            </td>
            <td>
                :
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtRate" CssClass="t1"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button runat="server" ID="btnSave" OnClick="btnSave_OnClick"  Text="Insert" CssClass="t2"/>
            </td>
        </tr>
    </table>
</asp:Content>
