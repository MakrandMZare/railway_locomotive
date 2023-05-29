<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true" CodeFile="printspectro_anaylsis.aspx.cs" Inherits="TestingLab_printspectro_anaylsis" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<table align="center">
        <tr>
            <th>
                LUBE OIL</th>
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
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:GridView ID="gv1" runat="Server" AutoGenerateColumns="false" DataKeyNames="spectro_id"
                        EmptyDataText="No Data Found...!" >
                        <Columns>
                            <asp:TemplateField HeaderText="SNO.">
                                <ItemTemplate>
                                    <%#Container.DataItemIndex  + 1 %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="Locono" HeaderText="LOCO NO" />
                            <asp:BoundField DataField="date_of_collection" HeaderText="DATE OF COLLECTION" />
                            <asp:BoundField DataField="Loco_Date" HeaderText="DATE OF REPORT" />
                            <asp:BoundField DataField="Id_Schedule" HeaderText="SCHEDULE" />
                            <asp:BoundField DataField="A1" HeaderText="A1- 0/5" />
                            <asp:BoundField DataField="B" HeaderText="B- 10/20" />
                            <asp:BoundField DataField="Cr" HeaderText="Cr- 10/20" />
                            <asp:BoundField DataField="Cu" HeaderText="Cu- 75/155" />
                            <asp:BoundField DataField="Fe" HeaderText="Fe- 75/25" />
                            <asp:BoundField DataField="Na" HeaderText="Na" />
                            <asp:BoundField DataField="Pb" HeaderText="Pb- 50/75" />
                            <asp:BoundField DataField="Si" HeaderText="Si- 15/20" />
                            <asp:BoundField DataField="Sn" HeaderText="Sn- 20/40" />
                            <asp:BoundField DataField="remarks" HeaderText="REMARK" />
                            <asp:TemplateField>
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
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </asp:Panel>
            </td>
        </tr>
    </table>
    </asp:Content>

