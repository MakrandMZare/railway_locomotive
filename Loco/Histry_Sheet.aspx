<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true" CodeFile="Histry_Sheet.aspx.cs" Inherits="Loco_Histry_Sheet" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
        <tr>
            <th colspan="9">
                HISTRY SHEET</th>
        </tr>
        <tr>
            <td>
                CLASS</td>
            <td style="width: 100px">
                :</td>
            <td style="width: 100px">
                <asp:DropDownList ID="ddlClass" runat="server" AutoPostBack="True" class="t1" onblur="ChangeDefaultStyle(this.id.toString());"
                    onfocus="ChangeStyle(this.id.toString());" OnSelectedIndexChanged="ddlClass_SelectedIndexChanged">
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList></td>
            <td style="width: 100px">
                LOCO NO</td>
            <td style="width: 100px">
                :</td>
            <td style="width: 100px">
                <asp:DropDownList ID="ddlLocono" runat="server" AutoPostBack="True" class="t1" onblur="ChangeDefaultStyle(this.id.toString());"
                    onfocus="ChangeStyle(this.id.toString());" >
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList></td>
            <td style="width: 100px">
                SCHEDULE</td>
            <td style="width: 100px">
                :</td>
            <td style="width: 100px">
                <asp:DropDownList ID="ddlSchedule" runat="server" CssClass="t1">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td>
                DATE</td>
            <td>
                :</td>
            <td>
                <asp:TextBox ID="txtdate" runat="server" CssClass="t1"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                REASON</td>
            <td>
                :</td>
            <td colspan="7">
                <asp:TextBox ID="txtreason" runat="server" CssClass="t1" Height="87px" TextMode="MultiLine"
                    Width="503px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="center" colspan="9">
                <asp:Button ID="btnInsert" runat="server" CssClass="t1" OnClick="btnInsert_Click"
                    Text="INSERT" />
                <asp:Button ID="btnCancel" runat="server" CssClass="t1" Text="CANCEL" /></td>
        </tr>
        <tr>
            <td colspan="9">
                <asp:GridView ID="gv1" runat="server" AutoGenerateColumns="False">
                <Columns>
                 <asp:TemplateField HeaderText="SNO.">
                            <ItemTemplate>
                                <%#Container.DataItemIndex  + 1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="locono" HeaderText="LOCO NO" />
                        <asp:BoundField DataField="s_type" HeaderText="SCHEDULE" />
                        <asp:BoundField DataField="h_date" HeaderText="DATE" />
                        <asp:BoundField DataField="reason" HeaderText="REASON" />
                </Columns>
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>

