<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true" CodeFile="airbreak.aspx.cs" Inherits="machanicalSection_airbreak" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
        <tr>
            <th colspan="12">
                SCHEDULE CARD FORM</th>
        </tr>
        <tr>
            <td>
                <strong>SECTION</strong></td>
            <td>
                :</td>
            <td>
                <asp:DropDownList ID="ddlSection" runat="server" AutoPostBack="True" CssClass="t1"
                    OnSelectedIndexChanged="ddlSection_SelectedIndexChanged">
                </asp:DropDownList></td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
                <strong>CLASS.</strong></td>
            <td>
                :</td>
            <td>
                <asp:DropDownList ID="ddlClass" runat="server" AutoPostBack="True" CssClass="t1"
                    OnSelectedIndexChanged="ddlClass_SelectedIndexChanged">
                </asp:DropDownList></td>
            <td>
                <strong>LOCO NO.</strong></td>
            <td>
                :</td>
            <td>
                <asp:DropDownList ID="ddlLocono" runat="server" CssClass="t1">
                </asp:DropDownList></td>
            <td>
                <strong>SCHEDULE</strong></td>
            <td>
            </td>
            <td>
                <asp:DropDownList ID="ddlSchedule" runat="server" AutoPostBack="True" CssClass="t1"
                    OnSelectedIndexChanged="ddlSchedule_SelectedIndexChanged">
                </asp:DropDownList></td>
            <td>
                <strong><span style="text-decoration: underline">Date</span></strong></td>
            <td style="text-decoration: underline">
                :</td>
            <td>
                <asp:TextBox ID="txtdate" runat="server" CssClass="t1" Width="83px"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                Name of Technician</td>
            <td>
                <span style="font-family: Arial">:</span></td>
            <td style="font-family: Arial">
                <asp:DropDownList ID="ddlHr" runat="server" CssClass="t1">
                </asp:DropDownList></td>
            <td>
                <strong><span style="font-size: 10pt; font-family: Times New Roman">Timing: Work start</span></strong></td>
            <td style="font-size: 10pt; font-family: Times New Roman">
                :</td>
            <td>
                <asp:TextBox ID="txtstart" runat="server" CssClass="t1" Width="56px"></asp:TextBox></td>
            <td>
                <strong><span style="font-size: 10pt; font-family: Times New Roman">Finish</span></strong></td>
            <td style="font-size: 10pt; font-family: Times New Roman">
                :</td>
            <td>
                <asp:TextBox ID="txtfinish" runat="server" CssClass="t1" Width="56px"></asp:TextBox></td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
                <span style="font-size: 10pt; font-family: Times New Roman"><strong>Name of Supervisor:</strong></span><u>
                </u>
            </td>
            <td>
            </td>
            <td>
                <asp:DropDownList ID="ddlhr2" runat="server" CssClass="t1">
                </asp:DropDownList></td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
                CARD</td>
            <td>
                :</td>
            <td colspan="10">
                <asp:DropDownList ID="ddlCard" runat="server" AutoPostBack="True" CssClass="t1" OnSelectedIndexChanged="ddlCard_SelectedIndexChanged">
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td align="left" colspan="12">
               
                            Check the following items during 90/180/270
                            Days schedule:
                                
                  
                <asp:GridView ID="gv1" runat="server" AutoGenerateColumns="False" OnRowDataBound="gv1_OnRowDataBound" Height="139px" Width="705px">
                    <Columns>
                        <asp:TemplateField HeaderText="SNO.">
                            <ItemTemplate>
                                <%#Container.DataItemIndex +1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="sub_head_details" HeaderText="detail" />
                        <asp:TemplateField HeaderText="status">
                            <ItemTemplate>
                                <asp:TextBox ID="txt1" runat="server" CssClass="t1"></asp:TextBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="action_taken">
                            <ItemTemplate>
                                <asp:TextBox ID="txt2" runat="server" CssClass="t1"></asp:TextBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <br />
                &nbsp; &nbsp;&nbsp;
            </td>
        </tr>
        <tr>
            <td align="center" colspan="12" rowspan="2">
                <asp:Button ID="btnInsert" runat="server" CssClass="t1" OnClick="btnInsert_Click"
                    Text="INSERT" /></td>
        </tr>
        <tr>
        </tr>
        <tr>
            <td align="center" colspan="12" rowspan="1">
            </td>
        </tr>
    </table>
</asp:Content>

