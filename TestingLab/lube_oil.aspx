<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true" CodeFile="lube_oil.aspx.cs" Inherits="TestingLab_lube_oil" Title="Untitled Page" %>

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

    <table  align="center" width="900">
        <tr>
            <th colspan="11">
                LUBE OIL&nbsp;</th>
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
                WATER<br />
                CONTENT(%)</td>
            <td align="center" valign="top">
                FLASH<br />
                POINT<br />
                &nbsp;<span style="font-family: Tahoma"><span style="font-size: 12pt">◦c</span></span></td>
            <td align="center">
                VISCOSITY<br />
                CST
            </td>
            <td align="center">
                pH</td>
            <td align="center">
                TBNE</td>
            <td align="center">
                DATE OF OIL<br />
                CHANGE</td>
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
                <asp:TextBox runat="server" ID="txtDate" CssClass="t1" Width="80px"></asp:TextBox>
            </td>
            <td align="center">
                <asp:DropDownList runat="server" ID="ddlSchedule" CssClass="t1">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td align="center">
                <asp:TextBox runat="server" ID="txtWaterContent" CssClass="t1" Width="37px"></asp:TextBox>
            </td>
            <td align="center">
                <asp:TextBox runat="server" ID="txtFlashPoint" CssClass="t1" Width="37px"></asp:TextBox>
            </td>
            <td align="center">
                <asp:TextBox runat="server" ID="txtViscosity" CssClass="t1" Width="37px"></asp:TextBox>
            </td>
            <td align="center">
                <asp:TextBox runat="server" ID="txtph" CssClass="t1" Width="37px"></asp:TextBox>
            </td>
            <td align="center">
                <asp:TextBox runat="server" ID="txttbne" CssClass="t1" Width="37px"></asp:TextBox>
            </td>
            <td align="center">
                <asp:TextBox ID="txtdateOfOilChange" runat="server" CssClass="t1"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="center" colspan="10">
                <table>
                    <tr>
                        <td colspan="3">
                INSOLUBLE 
                <br />
                MATTER%
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <table>
                                <tr>
                                    <td>
                                        HI</td>
                                    <td>
                                        TI</td>
                                    <td>
                                        RESIN</td>
                                </tr>
                <tr>
                <td >
                <asp:TextBox ID="txthi" runat="server" CssClass="t1" Width="37px"></asp:TextBox></td>
                <td>
                <asp:TextBox ID="txtti" runat="server" CssClass="t1" Width="37px"></asp:TextBox></td>
                <td><asp:TextBox ID="txtresin" runat="server" CssClass="t1" Width="37px"></asp:TextBox></td>
                </tr>
                </table>
                        </td>
                    </tr>
                    <tr>
                        <td >
                REMARKS</td>
                        <td >
                :</td>
                        <td >
                <asp:TextBox ID="txtremarks" runat="server" CssClass="t1" Height="85px" TextMode="MultiLine" Width="200px"></asp:TextBox></td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="11">
                <asp:Button runat="server" ID="btnSave" CssClass="t2" OnClick="btnSave_OnClick" Text="Insert"/>
                &nbsp;&nbsp;
                <asp:Button runat="server" ID="btnCancel" CssClass="t2" OnClick="btnCancel_OnClick"
                    Text="Cancel" /></td>
        </tr>
        <tr>
            <td colspan="11">
                <cc1:toolkitscriptmanager id="ToolkitScriptManager1" runat="server"></cc1:toolkitscriptmanager>
                <cc1:calendarextender id="CalendarExtender1" runat="server" format="dd/MM/yyyy" targetcontrolid="txtDate"></cc1:calendarextender>
                &nbsp;
                <cc1:calendarextender id="CalendarExtender2" runat="server" format="dd/MM/yyyy" targetcontrolid="txtdateOfOilChange"></cc1:calendarextender>
            </td>
        </tr>
        <tr>
            <td colspan="51">
                <asp:GridView runat="Server" ID="gv1" DataKeyNames="lube_oil_id" AutoGenerateColumns="false"
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
                        <asp:BoundField DataField="water" HeaderText="WATER CONTENT(%)" />
                        <asp:BoundField DataField="flashpoint" HeaderText="FLASH POINT ◦c" />
                        <asp:BoundField DataField="viscosity" HeaderText="VISCOSITY  SCT" />
                        <asp:BoundField DataField="ph" HeaderText="pH" />
                        <asp:BoundField DataField="tbne" HeaderText="TBNE" />
                        
                         <asp:BoundField DataField="hi" HeaderText="HI% " />
                        <asp:BoundField DataField="ti" HeaderText="TI" />
                        <asp:BoundField DataField="resin" HeaderText="RESIN" />
                        <asp:BoundField DataField="oil_date_change" HeaderText="DATE OF OIL CHANGE" />
                        <asp:BoundField DataField="remarks" HeaderText="REMARK" />
                        
                        
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

