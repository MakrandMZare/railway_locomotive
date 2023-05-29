<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true"
    CodeFile="Loco_Assembly_StockItem.aspx.cs" Inherits="Master_Loco_Assembly_StockItem"
    Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table align="center">
        <tr>
            <th colspan="20" align="center">
                Stock Items
            </th>
        </tr>
        <tr>
            <td>
                Assembly</td>
            <td>
            </td>
            <td>
                <asp:DropDownList runat="server" ID="ddlAssembly" CssClass="t1">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td>
                Gr.Sno</td>
            <td>
                :
            </td>
            <td>
                <asp:TextBox runat="Server" ID="txtGr" CssClass="t1"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                Description</td>
            <td>
                :
            </td>
            <td>
                <asp:TextBox runat="Server" ID="txtDescription" CssClass="t1"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                SWR PL No</td>
            <td>
                :
            </td>
            <td>
                <asp:TextBox runat="Server" ID="txtSwr" CssClass="t1"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                EMD Pt No/OEM Pt No</td>
            <td>
                :
            </td>
            <td>
                <asp:TextBox runat="Server" ID="txtEmdpt" CssClass="t1"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                DLW PL No</td>
            <td>
                :
            </td>
            <td>
                <asp:TextBox runat="Server" ID="txtDlwplno" CssClass="t1"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                Drg No</td>
            <td>
                :
            </td>
            <td>
                <asp:TextBox runat="Server" ID="txtDrgno" CssClass="t1"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                Sch-QPL-AAC for 50/100/150 Locos</td>
            <td>
                :
            </td>
            <td>
                <asp:TextBox runat="Server" ID="txtSch" CssClass="t1"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                If PAC, then firm's Name.</td>
            <td>
                :
            </td>
            <td>
                <asp:TextBox runat="Server" ID="txtPac" CssClass="t1"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <table>
                    <tr>
                        <td colspan="10" align="center">
                            RDSO Sources</td>
                    </tr>
                    <tr>
                        <td>
                            Part-I</td>
                        <td>
                            :
                        </td>
                        <td>
                            <asp:TextBox runat="Server" ID="txtRdsoPart1" CssClass="t1"></asp:TextBox></td>
                        <td>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Part-II</td>
                        <td>
                            :
                        </td>
                        <td>
                            <asp:TextBox runat="Server" ID="txtRdsoPart2" CssClass="t1"></asp:TextBox></td>
                        <td>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <table>
                    <tr>
                        <td colspan="10" align="center">
                            DWL Sources</td>
                    </tr>
                    <tr>
                        <td>
                            Part-I</td>
                        <td>
                            :
                        </td>
                        <td>
                            <asp:TextBox runat="Server" ID="txtDwlPart1" CssClass="t1"></asp:TextBox></td>
                        <td>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Part-II</td>
                        <td>
                            :
                        </td>
                        <td>
                            <asp:TextBox runat="Server" ID="txtDwlPart2" CssClass="t1"></asp:TextBox></td>
                        <td>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                LPR with Contract / PO Ref</td>
            <td>
                :
            </td>
            <td>
                <asp:TextBox runat="Server" ID="txtLpr" CssClass="t1"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="height: 19px">
                <asp:Button runat="server" ID="btnSave" OnClick="btnSave_OnClick" CssClass="t2" Text="Insert" />
            </td>
        </tr>
    </table>
</asp:Content>
