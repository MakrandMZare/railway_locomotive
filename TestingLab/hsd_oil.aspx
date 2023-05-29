<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true" CodeFile="hsd_oil.aspx.cs" Inherits="TestingLab_hsd_oil" Title="Untitled Page" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

  <script language="javascript" type="text/javascript">
    function CallValidation()
    {
       var n1 = document.getElementById('<%=ddlClass.ClientID%>').value;
       var n2 = document.getElementById('<%=ddlLocono.ClientID%>').value;
       var n3 = document.getElementById('<%=ddlSchedule.ClientID%>').value;
       if(Validate_selectedIndex(n1,'Class') && Validate_selectedIndex(n2,'Loco') && Validate_selectedIndex(n3,'Schedule'))
       {return true;}
    </script>

    <table align="center">
        <tr>
            <th colspan="8">
                LOCO WISE HSD OIL</th>
        </tr>
        <tr>
            <td align="center">
                CLASS
            </td>
            <td align="center">
                LOCO NO.
            </td>
            <td align="center">
                DATE
            </td>
            <td align="center">
                SCHEDULE
            </td>
            <td align="center">
                SAMPLE<br />
                COLLECT FROM</td>
            <td align="center">
                WATER 
                <br />
                CONTS.(%)</td>
            <td align="center">
                SEDI.MENTS.</td>
            <td align="center">
                COLOUR</td>
        </tr>
        <tr>
            <td align="center">
                <asp:DropDownList runat="server" ID="ddlClass" CssClass="t1" AutoPostBack="True"
                    OnSelectedIndexChanged="ddlClass_SelectedIndexChanged">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td align="center">
                <asp:DropDownList runat="server" ID="ddlLocono" CssClass="t1" OnSelectedIndexChanged="ddlLocono_OnSelectedIndexChanged"
                    AutoPostBack="True">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td align="center">
                <asp:TextBox runat="server" ID="txtDate" CssClass="t1"></asp:TextBox>
            </td>
            <td align="center">
                <asp:DropDownList runat="server" ID="ddlSchedule" CssClass="t1">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td align="center">
                <asp:TextBox runat="server" ID="txtsample" CssClass="t1"></asp:TextBox>
            </td>
            <td align="center">
                <asp:TextBox runat="server" ID="txtwater" CssClass="t1"></asp:TextBox>
            </td>
            <td align="center">
                <asp:TextBox runat="server" ID="txtsedi" CssClass="t1"></asp:TextBox>
            </td>
            <td align="center">
                <asp:TextBox runat="server" ID="txtcolour" CssClass="t1"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="8">
                <table width="100">
                    <tr>
                        <td style="width: 100px">
                REMARK</td>
                        <td style="width: 100px">
                            :</td>
                        <td style="width: 100px">
                <asp:TextBox runat="server" ID="txtreport" CssClass="t1" Height="85px" Width="200px" TextMode="MultiLine"></asp:TextBox></td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="8">
                <cc1:toolkitscriptmanager id="ToolkitScriptManager1" runat="server"></cc1:toolkitscriptmanager>
                <asp:TextBox ID="txttested" runat="server" CssClass="t1" Visible="False"></asp:TextBox>
                <cc1:calendarextender id="CalendarExtender1" runat="server" format="dd/MM/yyyy" targetcontrolid="txtDate"></cc1:calendarextender>
                <asp:Button runat="server" ID="btnSave" CssClass="t2" OnClick="btnSave_OnClick" Text="Insert"/>
                &nbsp;
                <asp:Button runat="server" ID="btnCancel" CssClass="t2" OnClick="btnCancel_OnClick"
                    Text="Cancel" /></td>
        </tr>
        <tr>
            <td colspan="48" align="center">
                <asp:GridView runat="Server" ID="gv1" DataKeyNames="hsd_id" AutoGenerateColumns="false"
                    EmptyDataText="No Data Found...!" OnRowEditing="gv1_OnRowEditing" OnRowDeleting="gv1_OnRowDeleting">
                    <Columns>
                        <asp:TemplateField HeaderText="SNO.">
                            <ItemTemplate>
                                <%#Container.DataItemIndex  + 1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="Locono" HeaderText="LOCO NO" />
                        <asp:BoundField DataField="Loco_Date" HeaderText="DATE" />
                        <asp:BoundField DataField="Id_Schedule" HeaderText="SCHEDULE" />
                        <asp:BoundField DataField="sample_collect" HeaderText="SAMPLE COLLECT FROM" />
                        <asp:BoundField DataField="water_conts" HeaderText="WATER CONTS.(%)" />
                        <asp:BoundField DataField="sediments" HeaderText="SEDI MENTS." />
                        <asp:BoundField DataField="color" HeaderText="COLOUR" />
                        <asp:BoundField DataField="remarks" HeaderText="REMARK" />
                        <%--<asp:BoundField DataField="testedby" HeaderText="TESTED BY" />--%>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <table>
                                    <tr>
                                        <td>
                                            <asp:ImageButton Width="10px" runat="server" ImageUrl="~/Images/Edit-icon.png" ID="lbtnUpdate"
                                                CommandName="Edit" />
                                        </td>
                                        <td>
                                            <asp:ImageButton Width="10px" runat="server" ImageUrl="~/Images/Delete-icon.png"
                                                ID="lbtnDelete" CommandName="Delete" />
                                        </td>
                                    </tr>
                                </table>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>

