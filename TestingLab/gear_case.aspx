<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true" CodeFile="gear_case.aspx.cs" Inherits="TestingLab_gear_case" Title="Untitled Page" %>

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

    <table width="900" align="center">
        <tr>
            <th colspan="11">
                GEAR CASE OIL
            </th>
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
                LG<br />
                1</td>
            <td align="center">
                LG<br />
                2</td>
            <td align="center">
                LG<br />
                3</td>
            <td align="center">
                RG<br />
                4</td>
            <td align="center">
                RG<br />
                5</td>
            <td align="center">
                RG<br />
                6</td>
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
                <asp:TextBox runat="server" ID="txtDate" CssClass="t1" Width="94px"></asp:TextBox>
            </td>
            <td align="center">
                <asp:DropDownList runat="server" ID="ddlSchedule" CssClass="t1">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td align="center">
                <asp:TextBox runat="server" ID="txtlg1" CssClass="t1" Width="38px"></asp:TextBox>
            </td>
            <td align="center">
                <asp:TextBox runat="server" ID="txtlg2" CssClass="t1" Width="38px"></asp:TextBox>
            </td>
            <td align="center">
                <asp:TextBox runat="server" ID="txtlg3" CssClass="t1" Width="38px"></asp:TextBox>
            </td>
            <td align="center">
                <asp:TextBox runat="server" ID="txtrg4" CssClass="t1" Width="38px"></asp:TextBox>
            </td>
            <td align="center">
                <asp:TextBox runat="server" ID="txtrg5" CssClass="t1" Width="38px"></asp:TextBox>
            </td>
            <td align="center">
                <asp:TextBox ID="txtrg6" runat="server" CssClass="t1" Width="38px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="center" colspan="11">
                <table width="100">
                    <tr>
                        <td style="width: 100px">
                            REMARK</td>
                        <td style="width: 100px">
                            :</td>
                        <td style="width: 100px">
                <asp:TextBox ID="txtremark" runat="server" CssClass="t1" Height="85px" Width="200px" TextMode="MultiLine"></asp:TextBox></td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="11">
                <cc1:toolkitscriptmanager id="ToolkitScriptManager1" runat="server"></cc1:toolkitscriptmanager>
                <asp:TextBox ID="txttested" runat="server" CssClass="t1" Visible="False"></asp:TextBox>
                <cc1:calendarextender id="CalendarExtender1" runat="server" format="dd/MM/yyyy" targetcontrolid="txtDate"></cc1:calendarextender>
                <asp:Button runat="server" ID="btnSave" CssClass="t2" OnClick="btnSave_OnClick" Text="Insert"/>&nbsp;
                <asp:Button runat="server" ID="btnCancel" CssClass="t2" OnClick="btnCancel_OnClick"
                    Text="Cancel" /></td>
        </tr>
        <tr>
            <td colspan="51">
                <asp:GridView runat="Server" ID="gv1" DataKeyNames="gear_case_id" AutoGenerateColumns="false"
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
                        <asp:BoundField DataField="lg1" HeaderText="LG1" />
                        <asp:BoundField DataField="lg2" HeaderText="LG2" />
                        <asp:BoundField DataField="lg3" HeaderText="LG3" />
                        
                              <asp:BoundField DataField="rg4" HeaderText="RG4" />
                        <asp:BoundField DataField="rg5" HeaderText="RG5" />
                        <asp:BoundField DataField="rg6" HeaderText="RG6" />
                        <asp:BoundField DataField="remarks" HeaderText="REMARK" />
                       <%-- <asp:BoundField DataField="testedby" HeaderText="TESTED BY" />--%>
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

