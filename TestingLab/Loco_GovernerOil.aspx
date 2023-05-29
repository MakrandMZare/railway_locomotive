<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true" CodeFile="Loco_GovernerOil.aspx.cs" Inherits="Loco_Loco_GovernerOil" Title="Untitled Page" %>

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
            <th colspan="10">
                GOVERNER OIL
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
                WATER 
                <br />
                CONTENT (%)
            </td>
            <td align="center">
                FLASH<br />
                POINT<br />
                &nbsp;<span style="font-family: Tahoma"><span style="font-size: 12pt">◦c</span></span></td>
            <td align="center">
                VISCOSITY&nbsp; CST</td>
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
                <asp:TextBox runat="server" ID="txtWaterContent" CssClass="t1"></asp:TextBox>
            </td>
            <td align="center">
                <asp:TextBox runat="server" ID="txtFlashPoint" CssClass="t1"></asp:TextBox>
            </td>
            <td align="center">
                <asp:TextBox runat="server" ID="txtViscosity" CssClass="t1"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="10">
                <table width="100">
                    <tr>
                        <td style="width: 100px">
                            REMARKS</td>
                        <td style="width: 100px">
                            :</td>
                        <td style="width: 100px">
                <asp:TextBox runat="server" ID="txtResult_Remraks" CssClass="t1" Height="85px" TextMode="MultiLine" Width="200px"></asp:TextBox></td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="10">
                <asp:TextBox runat="server" ID="txtTestedBy" CssClass="t1" Visible="False"></asp:TextBox>
                <cc1:toolkitscriptmanager id="ToolkitScriptManager1" runat="server"></cc1:toolkitscriptmanager>
                <cc1:calendarextender id="CalendarExtender1" runat="server" format="dd/MM/yyyy" targetcontrolid="txtDate"></cc1:calendarextender>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="10">
                <asp:Button runat="server" ID="btnSave" CssClass="t2" OnClick="btnSave_OnClick" Text="Insert"/>
                &nbsp; &nbsp;<asp:Button runat="server" ID="btnCancel" CssClass="t2" OnClick="btnCancel_OnClick"
                    Text="Cancel" /></td>
        </tr>
        <tr>
            <td colspan="50">
                <asp:GridView runat="Server" ID="gv1" DataKeyNames="Id_GovernerOil" AutoGenerateColumns="false"
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
                        <asp:BoundField DataField="WaterContent" HeaderText="WATER CONTENT(%)" />
                        <asp:BoundField DataField="FalshPoint" HeaderText="FLASH POINT ◦c" />
                        <asp:BoundField DataField="Viscosity" HeaderText="VISCOSITY CST" />
                        <asp:BoundField DataField="Result_Remarks" HeaderText="REMARK" />
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

