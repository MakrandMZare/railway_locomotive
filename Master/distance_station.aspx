<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true"
    CodeFile="distance_station.aspx.cs" Inherits="Master_distance_station" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table>
        <tr>
            <th colspan="3">
                DISTANCE BETWEEN STATIONS</th>
        </tr>
        <tr>
            <td align="center">
                FROM</td>
            <td align="center">
                &nbsp;TO</td>
            <td align="center">
                K.M.</td>
        </tr>
        <tr>
            <td align="center">
                <asp:TextBox ID="txtStn1" runat="server" CssClass="t1"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="txtStn2" runat="server" CssClass="t1"></asp:TextBox></td>
            <td align="center">
                <asp:TextBox ID="txtkm" runat="server" CssClass="t1"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="center" colspan="3">
                <asp:Button ID="btnInsert" Text="INSERT" runat="server" CssClass="t1" OnClick="btnInsert_Click" />
                <asp:Button ID="btnCancel" Text="CANCEL" runat="server" CssClass="t1" />
            </td>
        </tr>
        <tr align="center">
            <asp:GridView ID="gv1" AutoGenerateColumns="false" runat="server">
                <Columns>
                    <asp:TemplateField HeaderText="SNO.">
                        <ItemTemplate>
                            <%#Container.DataItemIndex  + 1 %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="station_one" HeaderText="FROM" />
                    <asp:BoundField DataField="station_two" HeaderText="TO" />
                    <asp:BoundField DataField="km" HeaderText="K.M." />
                </Columns>
            </asp:GridView>
        </tr>
    </table>
</asp:Content>
