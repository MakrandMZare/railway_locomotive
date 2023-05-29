<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true" CodeFile="CoolanWater.aspx.cs" Inherits="TestingLab_CoolanWater" Title="Untitled Page" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

  <script language="javascript" type="text/javascript">
    function CallValidation()
    {
       var n1 = document.getElementById('<%=ddlClass.ClientID%>').value;
       var n2 = document.getElementById('<%=ddlLocono.ClientID%>').value;
       
       if(Validate_selectedIndex(n1,'Class') && Validate_selectedIndex(n2,'Loco') )
       {return true;}
    </script>

    <table align="center" width="900">
        <tr>
            <th colspan="9">
                COOLANT WATER</th>
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
                AFTER WATER 
                <br />
                CHANGE</td>
            <td align="center">
                pH</td>
            <td align="center">
                HARDNESS<br />
                PPM</td>
            <td align="center">
                CHLORIDE<br />
                PPM</td>
            <td align="center">
                NITRATE<br />
                PPM</td>
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
                <asp:TextBox runat="server" ID="txtwater" CssClass="t1"></asp:TextBox>
            </td>
            <td align="center">
                <asp:TextBox runat="server" ID="txtph" CssClass="t1"></asp:TextBox>
            </td>
            <td align="center">
                <asp:TextBox runat="server" ID="txthardness" CssClass="t1"></asp:TextBox>
            </td>
            <td align="center">
                <asp:TextBox runat="server" ID="txtchloride" CssClass="t1"></asp:TextBox>
            </td>
            <td align="center">
                <asp:TextBox ID="txtnitrate" runat="server" CssClass="t1"></asp:TextBox></td>
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
                <asp:TextBox ID="TXTREMARK" runat="server" CssClass="t1" Height="85px" TextMode="MultiLine" Width="200px"></asp:TextBox></td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="9">
                <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
                </cc1:ToolkitScriptManager>
                <asp:TextBox runat="server" ID="TXTTESTEDBY" CssClass="t1" Visible="False"></asp:TextBox>
                <cc1:CalendarExtender ID="CalendarExtender1" runat="server" Format="dd/MM/yyyy" TargetControlID="txtDate">
                </cc1:CalendarExtender>
                <asp:Button runat="server" ID="btnSave" CssClass="t2" OnClick="btnSave_OnClick" Text="Insert"/>
                &nbsp;
                <asp:Button runat="server" ID="btnCancel" CssClass="t2" OnClick="btnCancel_OnClick"
                    Text="Cancel" /></td>
        </tr>
        <tr>
            <td colspan="49">
                <asp:GridView runat="Server" ID="gv1" DataKeyNames="coolantwater_id" AutoGenerateColumns="false"
                    EmptyDataText="No Data Found...!" OnRowEditing="gv1_OnRowEditing" OnRowDeleting="gv1_OnRowDeleting">
                    <Columns>
                        <asp:TemplateField HeaderText="SNO.">
                            <ItemTemplate>
                                <%#Container.DataItemIndex  + 1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="Locono" HeaderText="LOCO NO" />
                        <asp:BoundField DataField="Loco_Date" HeaderText="DATE" />
                        <asp:BoundField DataField="after_water_chage" HeaderText="AFTER WATER CHANGE" />
                        <asp:BoundField DataField="ph" HeaderText="pH" />
                        <asp:BoundField DataField="hardness" HeaderText="HARDNESS PPM" />
                        <asp:BoundField DataField="chloride" HeaderText="CHLORIDE PPM" />
                        <asp:BoundField DataField="nitrate" HeaderText="NITRATE PPM" />
                        <asp:BoundField DataField="remarks" HeaderText="REMRARK" />
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

