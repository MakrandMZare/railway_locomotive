<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true"
    CodeFile="Loco_CompressorOil.aspx.cs" Inherits="Master_Loco_CompressorOil" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

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
                COMPRESSOR OIL
            </th>
        </tr>
        <tr>
            <td>
                CLASS
            </td>
            <td>
                LOCO NO.
            </td>
            <td>
                DATE
            </td>
            <td>
                SCHEDULE
            </td>
            <td>
                WATER CONTENT (%)
            </td>
            <td>
                FLASH POINT
            </td>
            <td>
                VISCOSITY
            </td>
            <td>
                RESULT/REMARKS
            </td>
            <td>
                TESTED BY
            </td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList runat="server" ID="ddlClass" CssClass="t1" AutoPostBack="True"
                    OnSelectedIndexChanged="ddlClass_SelectedIndexChanged">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:DropDownList runat="server" ID="ddlLocono" CssClass="t1" OnSelectedIndexChanged="ddlLocono_OnSelectedIndexChanged"
                    AutoPostBack="True">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtDate" CssClass="t1"></asp:TextBox>
            </td>
            <td>
                <asp:DropDownList runat="server" ID="ddlSchedule" CssClass="t1">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtWaterContent" CssClass="t1"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtFlashPoint" CssClass="t1"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtViscosity" CssClass="t1"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtResult_Remraks" CssClass="t1"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtTestedBy" CssClass="t1"></asp:TextBox>
            </td>
            <td>
                <asp:Button runat="server" ID="btnSave" CssClass="t2" OnClick="btnSave_OnClick" Text="Insert"/>
                <asp:Button runat="server" ID="btnCancel" CssClass="t2" OnClick="btnCancel_OnClick"
                    Text="Cancel" />
            </td>
        </tr>
        <tr>
            <td colspan="50">
                <asp:GridView runat="Server" ID="gv1" DataKeyNames="Id_CompressorOil" AutoGenerateColumns="false"
                    EmptyDataText="No Data Found...!" OnRowEditing="gv1_OnRowEditing" OnRowDeleting="gv1_OnRowDeleting">
                    <Columns>
                        <asp:TemplateField HeaderText="Sno.">
                            <ItemTemplate>
                                <%#Container.DataItemIndex  + 1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="Locono" HeaderText="LOCO NO" />
                        <asp:BoundField DataField="Loco_Date" HeaderText="DATE" />
                        <asp:BoundField DataField="Id_Schedule" HeaderText="SCHEDULE" />
                        <asp:BoundField DataField="WaterContent" HeaderText="WATER CONTENT(%)" />
                        <asp:BoundField DataField="FalshPoint" HeaderText="FLASH POINT" />
                        <asp:BoundField DataField="Viscosity" HeaderText="VISCOSITY" />
                        <asp:BoundField DataField="Result_Remarks" HeaderText="RESULT / REMARK" />
                        <asp:BoundField DataField="Tested_By" HeaderText="TESTED BY" />
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
