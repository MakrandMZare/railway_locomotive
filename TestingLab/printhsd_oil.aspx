<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true" CodeFile="printhsd_oil.aspx.cs" Inherits="TestingLab_printhsd_oil" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table align="center">
        <tr>
            <th>
                RETAILS OF FAILURE COMPONENT&nbsp; DURING SCHEDULE TESTING BY NDT&nbsp;</th>
        </tr>
        <tr>
            <td>
                <table align="left">
                    <tr>
                        <td align="right" colspan="2">
                            CLASS &nbsp; &nbsp; &nbsp;
                        </td>
                        <td>
                            :</td>
                        <td>
                            <asp:DropDownList runat="server" ID="ddlclass" onfocus="ChangeStyle(this.id.toString());"
                                onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Width="88px" AutoPostBack="True" OnSelectedIndexChanged="ddlclass_SelectedIndexChanged">
                            </asp:DropDownList></td>
                        <td>
                            </td>
                        <td>
                            STARTING DATE</td>
                        <td>
                            :</td>
                        <td>
                            <asp:TextBox ID="txtstartdate" runat="server" onfocus="ChangeStyle(this.id.toString());"
                                onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:ImageButton runat="server" ID="btnPrint" ImageUrl="~/Images/printer_icon.jpg"
                                Height="20px" Width="20px" OnClick="btnPrint_Click" />
                        </td>
                        <td>
                            LOCO NO&nbsp;</td>
                        <td>
                            :
                        </td>
                        <td>
                            <asp:DropDownList runat="server" ID="ddlloco" onfocus="ChangeStyle(this.id.toString());"
                                onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Width="88px" AutoPostBack="True"></asp:DropDownList> 
                        </td>
                        <td>
                            <asp:Button runat="server" ID="btnShow" Text="SHOW" onfocus="ChangeStyle(this.id.toString());"
                                onBlur="ChangeDefaultStyle(this.id.toString());" class="t2" OnClick="btnShow_OnClick"
                                Height="16px" />
                        </td>
                        <td>
                            ENDING DATE</td>
                        <td>
                            :</td>
                        <td>
                            <asp:TextBox ID="txtenddate" runat="server" class="t1" onblur="ChangeDefaultStyle(this.id.toString());"
                                onfocus="ChangeStyle(this.id.toString());"></asp:TextBox></td>
                        
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Panel runat="server" ID="p1">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:GridView ID="gv1" runat="Server" AutoGenerateColumns="false" DataKeyNames="hsd_id"
                        EmptyDataText="No Data Found...!" >
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
                            <%--<asp:TemplateField>
                                <ItemTemplate>
                                    <table>
                                        <tr>
                                            <td>
                                                <asp:ImageButton ID="lbtnUpdate" runat="server" CommandName="Edit" ImageUrl="~/Images/Edit-icon.png"
                                                    Width="10px" />
                                            </td>
                                            <td>
                                                <asp:ImageButton ID="lbtnDelete" runat="server" CommandName="Delete" ImageUrl="~/Images/Delete-icon.png"
                                                    Width="10px" />
                                            </td>
                                        </tr>
                                    </table>
                                </ItemTemplate>
                            </asp:TemplateField>--%>
                        </Columns>
                    </asp:GridView>
                </asp:Panel>
            </td>
        </tr>
    </table>

</asp:Content>

