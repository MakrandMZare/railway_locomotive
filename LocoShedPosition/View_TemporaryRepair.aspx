<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true"
    CodeFile="View_TemporaryRepair.aspx.cs" Inherits="LocoShedPosition_View_TemporaryRepair"
    Title="Untitled Page" EnableEventValidation="false" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:ToolkitScriptManager runat="server" ID="ToolkitScriptManager1">
    </asp:ToolkitScriptManager>
    <table align="center">
        <tr>
            <th colspan="10">
                EMD LOCOS UNDER TEMPORARY REPAIR
            </th>
        </tr>
        <tr>
        <td><table align="left">
                    <tr>
                        <td>
                            <asp:ImageButton runat="server" ID="btnPrint" ImageUrl="~/Images/printer_icon.jpg"
                                Height="20px" Width="20px" Visible="false" OnClick="btnPrint_Click" />
                        </td>
                        <td>
                            DATE
                        </td>
                        <td>
                            :
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtDate" onfocus="ChangeStyle(this.id.toString());"
                                onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
                        </td>
                        <td><asp:Button runat="server" ID="btnShow" Text="SHOW" onfocus="ChangeStyle(this.id.toString());"
                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t2" OnClick="btnShow_OnClick"
                    Height="16px" /></td>
                        <td>
                <asp:CalendarExtender runat="server" ID="CalendarExtender1" TargetControlID="txtDate"
                    Format="dd/MM/yyyy">
                </asp:CalendarExtender>
                
                                        </td>
                    </tr>
                </table></td>
        </tr>
        <tr>
            <td>
                <asp:Panel runat="server" ID="p1">
                <asp:GridView runat="server" ID="gvTemporaryRepair" AutoGenerateColumns="false">
                    <Columns>
                        <asp:TemplateField>
                            <HeaderTemplate>
                                SN.
                            </HeaderTemplate>
                            <ItemTemplate>
                                <%#Container.DataItemIndex + 1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <HeaderTemplate>
                                LOCO NO
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label runat="server" Text='<%#Eval("locono")%>' ID="Label6"></asp:Label>
                            </ItemTemplate>
                            
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <HeaderTemplate>
                                SITE
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%#Eval("site")%>'></asp:Label>
                            </ItemTemplate>
                            
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <HeaderTemplate>
                                SECTION
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label2" runat="server" Text='<%#Eval("section")%>'></asp:Label>
                            </ItemTemplate>
                            
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <HeaderTemplate>
                                REASON
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label3" runat="server" Text='<%#Eval("reason")%>'></asp:Label>
                            </ItemTemplate>
                            
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <HeaderTemplate>
                                REMARKS
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label4" runat="server" Text='<%#Eval("remarks")%>'></asp:Label>
                            </ItemTemplate>
                            
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <HeaderTemplate>
                                <asp:Label ID="Label5" runat="server" Text="ACTION"></asp:Label>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <table>
                                    <tr>
                                        <td>
                                            <asp:ImageButton runat="server" ImageUrl="~/Images/Edit-icon.png" ID="lbtnUpdate"
                                                PostBackUrl='<%# "~/LocoShedPosition/Temporary_Repair.aspx?id=" + Eval("rid") %>' />
                                        </td>
                                        <td>
                                            <asp:ImageButton runat="server" ImageUrl="~/Images/Delete-icon.png" ID="lbtnDelete"
                                                PostBackUrl='<%# "~/LocoShedPosition/View_TemporaryRepair.aspx?id=" + Eval("rid") %>' />
                                        </td>
                                    </tr>
                                </table>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                </asp:Panel>
            </td>
        </tr>
        <tr>
        <td>
        </td>
        </tr>
        
    </table>
</asp:Content>
