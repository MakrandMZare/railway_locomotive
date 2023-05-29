<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true"
    CodeFile="Assembly_Supplier.aspx.cs" Inherits="Master_Assembly_Supplier" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table>
        <tr>
            <td style="height: 56px">
                <table>
                    <tr>
                        <td>
                            <asp:LinkButton runat="Server" ID="lbtnRdso1" OnClick="lbtnRdso1_OnClick">Rdso 1 Digit</asp:LinkButton>
                        </td>
                        <td>
                        </td>
                        <td>
                            <asp:LinkButton runat="Server" ID="lbtnRdso3" OnClick="lbtnRdso3_OnClick">Rdso 3 Digit</asp:LinkButton>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:LinkButton runat="Server" ID="lbtnRdso2" OnClick="lbtnRdso2_OnClick">Rdso 2 Digit</asp:LinkButton></td>
                        <td>
                        </td>
                        <td>
                            <asp:LinkButton runat="Server" ID="lbtnRdso4" OnClick="lbtnRdso4_OnClick">Rdso 4 Digit</asp:LinkButton>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td colspan="50" style="width: 218px">
                Assembly :
                <asp:DropDownList runat="Server" ID="ddlrdso" CssClass="t1" OnSelectedIndexChanged="ddlrdso_SelectedIndexChanged" AutoPostBack="True">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td>
                <table>
                    <tr>
                        <td>
                            <asp:LinkButton ID="lbtnA" runat="server" OnClick="lbtnA_OnClick">A</asp:LinkButton></td>
                        <td>
                            <asp:LinkButton ID="lbtnB" runat="server" OnClick="lbtnB_OnClick">B</asp:LinkButton></td>
                        <td>
                            <asp:LinkButton ID="lbtnC" runat="server" OnClick="lbtnC_OnClick">C</asp:LinkButton></td>
                        <td>
                            <asp:LinkButton ID="lbtnD" runat="server" OnClick="lbtnD_OnClick">D</asp:LinkButton></td>
                        <td>
                            <asp:LinkButton ID="lbtnE" runat="server" OnClick="lbtnE_OnClick">E</asp:LinkButton></td>
                        <td>
                            <asp:LinkButton ID="lbtnF" runat="server" OnClick="lbtnF_OnClick">F</asp:LinkButton></td>
                        <td>
                            <asp:LinkButton ID="lbtnG" runat="server" OnClick="lbtnG_OnClick">G</asp:LinkButton></td>
                        <td>
                            <asp:LinkButton ID="lbtnH" runat="server" OnClick="lbtnH_OnClick">H</asp:LinkButton></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:LinkButton ID="lbtnI" runat="server" OnClick="lbtnI_OnClick">I</asp:LinkButton></td>
                        <td>
                            <asp:LinkButton ID="lbtnJ" runat="server" OnClick="lbtnJ_OnClick">J</asp:LinkButton></td>
                        <td>
                            <asp:LinkButton ID="lbtnK" runat="server" OnClick="lbtnK_OnClick">K</asp:LinkButton></td>
                        <td>
                            <asp:LinkButton ID="lbtnL" runat="server" OnClick="lbtnL_OnClick">L</asp:LinkButton></td>
                        <td>
                            <asp:LinkButton ID="lbtnM" runat="server" OnClick="lbtnM_OnClick">M</asp:LinkButton></td>
                        <td>
                            <asp:LinkButton ID="lbtnN" runat="server" OnClick="lbtnN_OnClick">N</asp:LinkButton></td>
                        <td>
                            <asp:LinkButton ID="lbtnO" runat="server" OnClick="lbtnO_OnClick">O</asp:LinkButton></td>
                        <td>
                            <asp:LinkButton ID="lbtnP" runat="server" OnClick="lbtnP_OnClick">P</asp:LinkButton></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:LinkButton ID="lbtnQ" runat="server" OnClick="lbtnQ_OnClick">Q</asp:LinkButton></td>
                        <td>
                            <asp:LinkButton ID="lbtnR" runat="server" OnClick="lbtnR_OnClick">R</asp:LinkButton></td>
                        <td>
                            <asp:LinkButton ID="lbtnS" runat="server" OnClick="lbtnS_OnClick">S</asp:LinkButton></td>
                        <td>
                            <asp:LinkButton ID="lbtnT" runat="server" OnClick="lbtnT_OnClick">T</asp:LinkButton></td>
                        <td>
                            <asp:LinkButton ID="lbtnU" runat="server" OnClick="lbtnU_OnClick">U</asp:LinkButton></td>
                        <td>
                            <asp:LinkButton ID="lbtnV" runat="server" OnClick="lbtnV_OnClick">V</asp:LinkButton></td>
                        <td>
                            <asp:LinkButton ID="lbtnW" runat="server" OnClick="lbtnW_OnClick">W</asp:LinkButton></td>
                        <td>
                            <asp:LinkButton ID="lbtnX" runat="server" OnClick="lbtnX_OnClick">X</asp:LinkButton></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:LinkButton ID="lbtnY" runat="server" OnClick="lbtnY_OnClick">Y</asp:LinkButton></td>
                        <td>
                            <asp:LinkButton ID="lbtnZ" runat="server" OnClick="lbtnZ_OnClick">Z</asp:LinkButton></td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td colspan="50" style="width: 218px">
                Supplier :
                <asp:DropDownList runat="Server" ID="ddlSupplier" CssClass="t1">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
        <td><asp:Button runat="server" ID="btnSave" Text="Save" OnClick="btnSave_OnClick" CssClass="t1"/></td>
        </tr>
        <tr>
            <td>
                <asp:GridView runat="server" ID="gvSupplier" AutoGenerateColumns="false" EmptyDataText="No Supplier Found..!">
                    <Columns>
                        <asp:TemplateField HeaderText="No.">
                            <ItemTemplate>
                                <%#Container.DataItemIndex  + 1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText=" Supplier ">
                            <ItemTemplate>
                                <asp:Label runat="Server" ID="lblSupplier" Text='<%#Eval("s_name") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
