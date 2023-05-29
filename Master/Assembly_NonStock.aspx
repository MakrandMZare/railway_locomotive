<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true"
    CodeFile="Assembly_NonStock.aspx.cs" Inherits="Master_Assembly_NonStock" Title="Untitled Page" EnableEventValidation="false"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table align="center">
        <tr>
            <th align="center" colspan="10">
                WESTERN RAILWAY
            </th>
        </tr>
        <tr>
            <th align="center" colspan="10">
                MATERIAL DIRECTORY -EMD LOCOMOTIVE Non-Stock Items
            </th>
        </tr>
        <tr>
            <td>
                Assembly</td>
            <td>
                :
            </td>
            <td>
                <asp:DropDownList runat="server" CssClass="t1" ID="ddlAssembly">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td>
                Gr. Sno
            </td>
            <td>
                :
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtGrno" CssClass="t1"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                Description</td>
            <td>
                :
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtDescription" CssClass="t1"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                EMD Pt No/ OEM Pt No</td>
            <td>
                :
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtEmdPtno" CssClass="t1"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                DLW PL No</td>
            <td>
                :
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtDlwplno" CssClass="t1"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Drg No</td>
            <td>
                :
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtDrgno" CssClass="t1"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                Sch-QPL-AAC for 50/100/150 Locos
            </td>
            <td>
                :
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtSchQpl" CssClass="t1"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                If PAC, then firm's Name.</td>
            <td>
                :
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtPac" CssClass="t1"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <table>
                    <tr>
                        <td colspan="10">
                            RDSO Sources
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Part I</td>
                        <td>
                            :
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtRdso1" CssClass="t1"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Part II</td>
                        <td>
                            :
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtRdso2" CssClass="t1"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <table>
                    <tr>
                        <td colspan="10">
                            DLW Sources
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Part I</td>
                        <td>
                            :
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtDlw1" CssClass="t1"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Part II</td>
                        <td>
                            :
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtDlw2" CssClass="t1"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                LPR with Contract/ PO Ref</td>
            <td>
                :
            </td>
            <td>
                <asp:TextBox runat="Server" ID="txtLpr" CssClass="t1"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="10">
                <asp:Button runat="Server" ID="btnSave" OnClick="btnSave_OnClick" Text="Insert"/></td>
        </tr>
    </table>
</asp:Content>
