<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true"
    CodeFile="Loco_ScheduleManagement_Entry.aspx.cs" Inherits="Loco_ScheduleManagement_Entry"
    Title="Sabarmati Diesels : Schedule Manage" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:ToolkitScriptManager runat="server" ID="ToolkitScriptManager1">
    </asp:ToolkitScriptManager>

    <script language="javascript" type="text/javascript">
    function CallValidation()
    {
       var n1 = document.getElementById('<%=ddlClass.ClientID%>').value;
       if(Validate_selectedIndex(n1,'Class'))
       {return true;}
       return false;
    }
    
    </script>

    <table>
        <tr>
            <td>
                <table>
                    <tr>
                        <th colspan="20">
                            LOCO SCHEDULE MANAGEMENT
                        </th>
                    </tr>
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
                            <asp:Label runat="Server" ID="lblguage" Text="" Visible="false"></asp:Label>
                    </tr>
                    <tr>
                        <td>
                            Total Schedule In Year
                        </td>
                        <td>
                            :
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtTotalSchedule" onfocus="ChangeStyle(this.id.toString());"
                                onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" OnTextChanged="txtTotalSchedule_TextChanged"
                                ValidationGroup="a"></asp:TextBox>
                        </td>
                        <td>
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Schedule Name
                        </td>
                        <td>
                            :
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtScheduleName" onfocus="ChangeStyle(this.id.toString());"
                                onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Height="16px" Width="153px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="10">
                            <asp:Label runat="server" ID="lblError" Text="" Visible="false" ForeColor="Red"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="10">
                            <asp:Button runat="server" ID="btnSave" Text="DISPLAY" onfocus="ChangeStyle(this.id.toString());"
                                onBlur="ChangeDefaultStyle(this.id.toString());" class="t2" OnClick="btnDisplay_OnClick"
                                OnClientClick="return CallValidation();" />
                            <asp:Button runat="server" ID="GENERATE" Text="GENERATE" onfocus="ChangeStyle(this.id.toString());"
                                onBlur="ChangeDefaultStyle(this.id.toString());" class="t2" OnClick="btnGenerate_OnClick"
                                OnClientClick="return CallValidation();" Visible="false" />
                        </td>
                    </tr>
                    <tr>
                        <td valign="top">
                            <asp:GridView runat="server" ID="gvLocoList" AutoGenerateColumns="false">
                                <Columns>
                                    <asp:TemplateField HeaderText="No.">
                                        <ItemTemplate>
                                            <%#Container.DataItemIndex + 1 %>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:CheckBox runat="server" ID="chk1" Checked="true" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="LOCO NO">
                                        <ItemTemplate>
                                            <asp:Label runat="server" ID="lblLocono" Text='<%#Eval("locono")%>'></asp:Label>
                                            <asp:Label runat="server" ID="Label1" Text='<%#Eval("id_mst_loco")%>' Visible="false"></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="D.O.C">
                                        <ItemTemplate>
                                            <asp:Label runat="server" ID="lblDoc" Text='<%#Eval("doc_date")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Heavy Schedule / Commission">
                                        <ItemTemplate>
                                            <asp:TextBox runat="server" ID="txtHeavy" onfocus="ChangeStyle(this.id.toString());"
                                                onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
                                            <asp:CalendarExtender runat="server" ID="CalendarExtender1" TargetControlID="txtHeavy"
                                                Format="dd/MM/yyyy">
                                            </asp:CalendarExtender>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </td>
                        <td>
                        </td>
                        <td valign="top">
                            <asp:GridView runat="server" ID="gvSchedule" AutoGenerateColumns="false" OnRowDataBound="gvSchedule_OnDataBound">
                                <Columns>
                                    <asp:TemplateField HeaderText="No.">
                                        <ItemTemplate>
                                            <asp:Label runat="server" ID="lblno" Text='<%#Eval("NO") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="SCHEDULE">
                                        <ItemTemplate>
                                            <asp:DropDownList runat="server" ID="ddlSchedule" AutoPostBack="false" onfocus="ChangeStyle(this.id.toString());"
                                                onBlur="ChangeDefaultStyle(this.id.toString());" class="t1">
                                                <asp:ListItem>SELECT</asp:ListItem>
                                            </asp:DropDownList>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </td>
                    </tr>
                </table>
            </td>
            <td valign="top">
                <asp:GridView runat="server" ID="gvExistingSchedule" AutoGenerateColumns="false">
                    <Columns>
                        <asp:TemplateField HeaderText="NO.">
                            <ItemTemplate>
                                <%#Container.DataItemIndex + 1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="SCHEDULE NAME">
                            <ItemTemplate>
                            <asp:Label runat="server" ID="lblScheduleName" Text='<%#Eval("ScheduleName")%>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="SCHEDULE DATE">
                            <ItemTemplate>
                            <asp:Label runat="server" ID="lblScheduleDate" Text='<%#Eval("ScheduleDate")%>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="VIEW" ItemStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                            <asp:ImageButton ImageUrl="~/Images/84.jpg" runat="server" ID="viewimage" PostBackUrl='<%#"~/Loco/Loco_ScheduleManagement_View.aspx?id=" + Eval("id_loco_Schedule") %>' AlternateText="View More"
                                    Height="20px" Width="20px" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
