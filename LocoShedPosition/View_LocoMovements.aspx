<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true"
    CodeFile="View_LocoMovements.aspx.cs" Inherits="LocoShedPosition_View_LocoMovements"
    Title="Untitled Page" EnableEventValidation="false" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:ToolkitScriptManager runat="server" ID="ToolkitScriptManager1">
    </asp:ToolkitScriptManager>
    <table align="center">
        <tr>
            <th>
                EMD LOCOS UNDER LOCO MOVEMENTS
            </th>
        </tr>
        <tr>
            <td>
                <table align="left">
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
                        <td>
                            <asp:Button runat="server" ID="btnShow" Text="SHOW" onfocus="ChangeStyle(this.id.toString());"
                                onBlur="ChangeDefaultStyle(this.id.toString());" class="t2" OnClick="btnShow_OnClick"
                                Height="16px" />
                        </td>
                        <td>
                            <asp:CheckBox runat="server" ID="chkEdit" Text="Edit" Visible="true" OnCheckedChanged="chkEdit_OnCheckedChanged"
                                AutoPostBack="true" Checked="false" />
                            <asp:Label runat="server" ID="lblmsg" Visible="False" ForeColor="Maroon">[This 
                            report Can&#39;t be Edited...]</asp:Label>
                        </td>
                        <td>
                            <asp:CalendarExtender runat="server" ID="CalendarExtender1" TargetControlID="txtDate"
                                Format="dd/MM/yyyy">
                            </asp:CalendarExtender>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Panel runat="server" ID="p1">
                    <asp:GridView runat="server" ID="gvLocoMovements" AutoGenerateColumns="false" 
                        PageSize="20" Font-Size="14" Width="990px" DataKeyNames="Id_Loco_Movement"
                        OnRowCancelingEdit="gvLocoMovements_OnRowCancelingEdit" OnRowUpdating="gvLocoMovements_OnRowUpdating"
                        OnRowEditing="gvLocoMovements_OnRowEditing" 
                        OnRowDataBound="gvLocoMovements_OnRowDataBound">
                        <Columns>
                            <asp:TemplateField HeaderStyle-CssClass="Freezing">
                                <HeaderTemplate>
                                    SN.
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <%#Container.DataItemIndex + 1 %>
                                </ItemTemplate>
                                <HeaderStyle CssClass="Freezing" />
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    LOCO NO.
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="Label1" Text='<%#Eval("LocoNo")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField ControlStyle-Width="115">
                                <HeaderTemplate>
                                    DATE OF ARRIVAL
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="Label2" Text='<%#Eval("ARRIVAL DATE")%>'></asp:Label>
                                </ItemTemplate>
                                <ControlStyle Width="115px" />
                            </asp:TemplateField>
                            <asp:TemplateField ControlStyle-Width="115">
                                <HeaderTemplate>
                                    DOC
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="Label3" Text='<%#Eval("DOC")%>'></asp:Label>
                                </ItemTemplate>
                                <ControlStyle Width="115px" />
                            </asp:TemplateField>
                            <asp:TemplateField ControlStyle-Width="115">
                                <HeaderTemplate>
                                    LAST OUT
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="Label11" Text='<%#Eval("LAST OUT")%>'></asp:Label>
                                </ItemTemplate>
                                <ControlStyle Width="115px" />
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    LAST SCHEDULE
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="Label4" Text='<%#Eval("LAST SCHEULE")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <%--<asp:TemplateField>
                                <HeaderTemplate>
                                    Yearly
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="Label14" Text='<%#Eval(" Id_Loco_Movement")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>--%>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    REPAIR ATTENDED
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="Label5" Text='<%#Eval("REPAIR ATTENDED")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="DIVISION">
                                <EditItemTemplate>
                                    <asp:DropDownList runat="server" ID="ddlDiv">
                                        <asp:ListItem Selected="True">SELECT</asp:ListItem>
                                    </asp:DropDownList>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="Label6" Text='<%#Eval("DIVISION")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="SITE">
                                <EditItemTemplate>
                                    <asp:DropDownList runat="server" ID="ddlSite">
                                        <asp:ListItem Selected="True">SELECT</asp:ListItem>
                                    </asp:DropDownList>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="Label7" Text='<%#Eval("SITE")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="SECTION">
                                <EditItemTemplate>
                                    <asp:DropDownList runat="server" ID="ddlSection">
                                        <asp:ListItem Selected="True">SELECT</asp:ListItem>
                                    </asp:DropDownList>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="Label8" Text='<%#Eval("SECTION")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    REMARKS
                                </HeaderTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox runat="server" ID="txtRemarks"></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="Label9" Text='<%#Eval("REMARKS")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <EditItemTemplate>
                                    <asp:ImageButton runat="server" ID="btnSave" ImageUrl="~/Images/Save-icon.png" Height="20px"
                                        Width="20px" CommandName="Update" />
                                    <asp:ImageButton runat="server" ID="btnCancel" ImageUrl="~/Images/Cancel-icon.png"
                                        Height="20px" Width="20px" CommandName="Cancel" />
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:ImageButton runat="server" ID="btnEdit" ImageUrl="~/Images/Edit-icon.png" Height="20px"
                                        Width="20px" CommandName="Edit" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                   
                    <asp:GridView ID="gvmov" runat="server" PageSize="20" Font-Size="14" Width="990px" AutoGenerateColumns="False">
                   <Columns>
                            <asp:TemplateField HeaderStyle-CssClass="Freezing">
                                <HeaderTemplate>
                                    SN.
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <%#Container.DataItemIndex + 1 %>
                                </ItemTemplate>
                                <HeaderStyle CssClass="Freezing" />
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    LOCO NO.
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="Label1" Text='<%#Eval("LocoNo")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField ControlStyle-Width="115">
                                <HeaderTemplate>
                                    DATE OF ARRIVAL
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="Label2" Text='<%#Eval("ARRIVAL DATE")%>'></asp:Label>
                                </ItemTemplate>
                                <ControlStyle Width="115px" />
                            </asp:TemplateField>
                            <asp:TemplateField ControlStyle-Width="115">
                                <HeaderTemplate>
                                    DOC
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="Label3" Text='<%#Eval("DOC")%>'></asp:Label>
                                </ItemTemplate>
                                <ControlStyle Width="115px" />
                            </asp:TemplateField>
                            <asp:TemplateField ControlStyle-Width="115">
                                <HeaderTemplate>
                                    LAST OUT
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="Label11" Text='<%#Eval("LAST OUT")%>'></asp:Label>
                                </ItemTemplate>
                                <ControlStyle Width="115px" />
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    LAST SCHEDULE
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="Label4" Text='<%#Eval("LAST SCHEULE")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <%--<asp:TemplateField>
                                <HeaderTemplate>
                                    Yearly
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="Label14" Text='<%#Eval(" Id_Loco_Movement")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>--%>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    REPAIR ATTENDED
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="Label5" Text='<%#Eval("REPAIR ATTENDED")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="DIVISION">
                                <EditItemTemplate>
                                    <asp:DropDownList runat="server" ID="ddlDiv">
                                        <asp:ListItem Selected="True">SELECT</asp:ListItem>
                                    </asp:DropDownList>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="Label6" Text='<%#Eval("DIVISION")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="SITE">
                                <EditItemTemplate>
                                    <asp:DropDownList runat="server" ID="ddlSite">
                                        <asp:ListItem Selected="True">SELECT</asp:ListItem>
                                    </asp:DropDownList>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="Label7" Text='<%#Eval("SITE")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="SECTION">
                                <EditItemTemplate>
                                    <asp:DropDownList runat="server" ID="ddlSection">
                                        <asp:ListItem Selected="True">SELECT</asp:ListItem>
                                    </asp:DropDownList>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="Label8" Text='<%#Eval("SECTION")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    REMARKS
                                </HeaderTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox runat="server" ID="txtRemarks"></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="Label9" Text='<%#Eval("REMARKS")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            
                        </Columns>
                   
                    </asp:GridView>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button runat="server" ID="Button1" Text="SHOW" onfocus="ChangeStyle(this.id.toString());"
                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t2" OnClick="btnSave_OnClick"
                    Height="16px" />
                &nbsp;
            </td>
        </tr>
    </table>
</asp:Content>
