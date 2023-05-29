<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true"
    CodeFile="User_Authorisation.aspx.cs" Inherits="Master_User_Authorisation" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table cellpadding="0" cellspacing="0">
        <tr>
            <th colspan="50">
                USER AUTHORIZATION
            </th>
        </tr>
        <tr>
            <td>
            </td>
        </tr>
        <tr>
            <td>
                <table cellspacing="0" cellpadding="0">
                    <tr>
                        <th>
                            DATA ENTRY
                        </th>
                        <th>
                        </th>
                        <th>
                            PERMISSION
                        </th>
                    </tr>
                    <tr>
                        <td>
                            LOCO IN
                        </td>
                        <td>
                            :
                        </td>
                        <td>
                            <asp:RadioButtonList runat="server" ID="r1" RepeatDirection="Horizontal">
                                <asp:ListItem Text="Yes" Value="Yes"></asp:ListItem>
                                <asp:ListItem Selected="True" Text="No" Value="No"></asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            LOCO OUT
                        </td>
                        <td>
                            :
                        </td>
                        <td>
                            <asp:RadioButtonList runat="server" ID="r2" RepeatDirection="Horizontal">
                                <asp:ListItem Text="Yes" Value="Yes"></asp:ListItem>
                                <asp:ListItem Selected="True" Text="No" Value="No"></asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            LINE MESSAGE
                        </td>
                        <td>
                            :
                        </td>
                        <td>
                            <asp:RadioButtonList runat="server" ID="r3" RepeatDirection="Horizontal">
                                <asp:ListItem Text="Yes" Value="Yes"></asp:ListItem>
                                <asp:ListItem Selected="True" Text="No" Value="No"></asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            DEAD ON LINE
                        </td>
                        <td>
                            :
                        </td>
                        <td>
                            <asp:RadioButtonList runat="server" ID="r4" RepeatDirection="Horizontal">
                                <asp:ListItem Text="Yes" Value="Yes"></asp:ListItem>
                                <asp:ListItem Selected="True" Text="No" Value="No"></asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            LOCO MOVEMENT
                        </td>
                        <td>
                            :
                        </td>
                        <td>
                            <asp:RadioButtonList runat="server" ID="r5" RepeatDirection="Horizontal">
                                <asp:ListItem Text="Yes" Value="Yes"></asp:ListItem>
                                <asp:ListItem Selected="True" Text="No" Value="No"></asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            EMPLOYEE
                        </td>
                        <td>
                            :
                        </td>
                        <td>
                            <asp:RadioButtonList runat="server" ID="r6" RepeatDirection="Horizontal">
                                <asp:ListItem Text="Yes" Value="Yes"></asp:ListItem>
                                <asp:ListItem Selected="True" Text="No" Value="No"></asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            INCOMING PASSANGER LOCO
                        </td>
                        <td>
                            :
                        </td>
                        <td>
                            <asp:RadioButtonList runat="server" ID="r7" RepeatDirection="Horizontal">
                                <asp:ListItem Text="Yes" Value="Yes"></asp:ListItem>
                                <asp:ListItem Selected="True" Text="No" Value="No"></asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            OUT AGE
                        </td>
                        <td>
                            :
                        </td>
                        <td>
                            <asp:RadioButtonList runat="server" ID="r8" RepeatDirection="Horizontal">
                                <asp:ListItem Text="Yes" Value="Yes"></asp:ListItem>
                                <asp:ListItem Selected="True" Text="No" Value="No"></asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                </table>
            </td>
            <td>
            <table cellspacing="0" cellpadding="0">
                <tr>
                    <th>
                        REPORT
                    </th>
                    <th>
                    </th>
                    <th>
                        PERMISSION
                    </th>
                </tr>
                <tr>
                    <td>
                        LOCO IN
                    </td>
                    <td>
                        :
                    </td>
                    <td>
                        <asp:RadioButtonList runat="server" ID="r9" RepeatDirection="Horizontal">
                            <asp:ListItem Text="Yes" Value="Yes"></asp:ListItem>
                            <asp:ListItem Selected="True" Text="No" Value="No"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td>
                        LOCO OUT
                    </td>
                    <td>
                        :
                    </td>
                    <td>
                        <asp:RadioButtonList runat="server" ID="r10" RepeatDirection="Horizontal">
                            <asp:ListItem Text="Yes" Value="Yes"></asp:ListItem>
                            <asp:ListItem Selected="True" Text="No" Value="No"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td>
                        LINE MESSAGE
                    </td>
                    <td>
                        :
                    </td>
                    <td>
                        <asp:RadioButtonList runat="server" ID="r11" RepeatDirection="Horizontal">
                            <asp:ListItem Text="Yes" Value="Yes"></asp:ListItem>
                            <asp:ListItem Selected="True" Text="No" Value="No"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td>
                        DEAD ON LINE
                    </td>
                    <td>
                        :
                    </td>
                    <td>
                        <asp:RadioButtonList runat="server" ID="r12" RepeatDirection="Horizontal">
                            <asp:ListItem Text="Yes" Value="Yes"></asp:ListItem>
                            <asp:ListItem Selected="True" Text="No" Value="No"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td>
                        LOCO MOVEMENT
                    </td>
                    <td>
                        :
                    </td>
                    <td>
                        <asp:RadioButtonList runat="server" ID="r13" RepeatDirection="Horizontal">
                            <asp:ListItem Text="Yes" Value="Yes"></asp:ListItem>
                            <asp:ListItem Selected="True" Text="No" Value="No"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td>
                        EMPLOYEE
                    </td>
                    <td>
                        :
                    </td>
                    <td>
                        <asp:RadioButtonList runat="server" ID="r14" RepeatDirection="Horizontal">
                            <asp:ListItem Text="Yes" Value="Yes"></asp:ListItem>
                            <asp:ListItem Selected="True" Text="No" Value="No"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td>
                        INCOMING PASSANGER LOCO
                    </td>
                    <td>
                        :
                    </td>
                    <td>
                        <asp:RadioButtonList runat="server" ID="r15" RepeatDirection="Horizontal">
                            <asp:ListItem Text="Yes" Value="Yes"></asp:ListItem>
                            <asp:ListItem Selected="True" Text="No" Value="No"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td>
                        OUT AGE
                    </td>
                    <td>
                        :
                    </td>
                    <td>
                        <asp:RadioButtonList runat="server" ID="r16" RepeatDirection="Horizontal">
                            <asp:ListItem Text="Yes" Value="Yes"></asp:ListItem>
                            <asp:ListItem Selected="True" Text="No" Value="No"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button runat="server" ID="btnSave" Text="SHOW" onfocus="ChangeStyle(this.id.toString());"
                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t2" OnClick="btnSave_OnClick"
                    OnClientClick="return CallValidation();" ValidationGroup="b" />
            </td>
        </tr>
    </table>
</asp:Content>
