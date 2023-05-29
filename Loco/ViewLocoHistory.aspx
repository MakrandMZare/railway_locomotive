<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true"
    CodeFile="ViewLocoHistory.aspx.cs" Inherits="Loco_ViewLocoHistory" Title="Untitled Page" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:ToolkitScriptManager runat="server" ID="ToolkitScriptManager1">
    </asp:ToolkitScriptManager>
    <table align="center" cellspacing="0" cellpadding="0" width="100%">
        <tr>
            <th align="center" colspan="10">
                LOCO HISTORY
            </th>
        </tr>
        <tr>
            <td>
                <table>
                    <tr>
                        <td>
                            CLASS
                        </td>
                        <td>
                            :
                        </td>
                        <td>
                            <asp:DropDownList runat="server" ID="ddlClass" AutoPostBack="True" OnSelectedIndexChanged="ddlClass_SelectedIndexChanged"
                                onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"
                                class="t1">
                                <asp:ListItem></asp:ListItem>
                            </asp:DropDownList>
                            <asp:Label runat="server" ID="lblguage" Visible="false"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            LOCO NO
                        </td>
                        <td>
                            :
                        </td>
                        <td>
                            <asp:DropDownList runat="server" ID="ddlLocono" onfocus="ChangeStyle(this.id.toString());"
                                onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" OnSelectedIndexChanged="ddlLocono_SelectedIndexChanged"
                                AutoPostBack="True">
                                <asp:ListItem>SELECT</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:Button runat="server" ID="btnShow" Text="Show History" onfocus="ChangeStyle(this.id.toString());"
                                onBlur="ChangeDefaultStyle(this.id.toString());" class="t2" OnClick="btnShow_OnClick"
                                OnClientClick="return CallValidation();" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td colspan="10">
                <table>
                    <tr>
                        <td align="center">
                            SCHEDULE DETAILS
                        </td>
                        <td>
                            ASSEMBLY DETAILS</td>
                    </tr>
                    <tr>
                        <td valign="top">
                            <asp:DataList runat="server" ID="dv1">
                                <ItemTemplate>
                                    <table>
                                        <tr>
                                            <td>
                                                Schedule</td>
                                            <td>
                                                :
                                            </td>
                                            <td>
                                                <b>
                                                    <%#Eval("scheduletype") %>
                                                </b>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                Date
                                            </td>
                                            <td>
                                                :
                                            </td>
                                            <td>
                                                <%#Eval("arrivaldate")%>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                Details
                                            </td>
                                            <td>
                                                :
                                            </td>
                                            <td>
                                                <%#Eval("Remarks")%>
                                            </td>
                                        </tr>
                                    </table>
                                </ItemTemplate>
                            </asp:DataList>
                        </td>
                        <td valign="top">
                            <asp:DataList runat="server" ID="dv2">
                                <ItemTemplate>
                                    <table>
                                        <tr>
                                            <td>
                                                Date</td>
                                            <td>
                                                :
                                            </td>
                                            <td>
                                                <b>
                                                    <%#Eval("GenerationDate")%>
                                                </b>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                Assembly Name
                                            </td>
                                            <td>
                                                :
                                            </td>
                                            <td>
                                                <asp:LinkButton runat="server" ID="LbtnAssembly" Text='<%#Eval("AssemblyNo")%>'></asp:LinkButton>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                Rdso 1
                                            </td>
                                            <td>
                                                :
                                            </td>
                                            <td>
                                                <asp:LinkButton runat="server" ID="lbtnRdso1" Text='<%#Eval("Rdso1")%>'></asp:LinkButton>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                Rdso 2
                                            </td>
                                            <td>
                                                :
                                            </td>
                                            <td>
                                                <asp:LinkButton runat="server" ID="LinkButton1" Text='<%#Eval("Rdso2")%>'></asp:LinkButton>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                Rdso 3
                                            </td>
                                            <td>
                                                :
                                            </td>
                                            <td>
                                                <asp:LinkButton runat="server" ID="LinkButton2" Text='<%#Eval("Rdso3")%>'></asp:LinkButton>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                Rdso 4
                                            </td>
                                            <td>
                                                :
                                            </td>
                                            <td>
                                                <asp:LinkButton runat="server" ID="LinkButton3" Text='<%#Eval("Rdso4")%>'></asp:LinkButton>
                                            </td>
                                        </tr>
                                    </table>
                                </ItemTemplate>
                            </asp:DataList>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
