<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true"
    CodeFile="Loco_ScheduleManagement_View.aspx.cs" Inherits="Loco_Loco_ScheduleManagement_View"
    Title="Sabarmati Diesels : Loco Schedule Manage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table>
        <tr>
            <th colspan="20">
                LOCO SCHEDULE MANAGEMENT
            </th>
        </tr>
        <tr>
            <td>
                <asp:ImageButton runat="server" ID="btnPrint" ImageUrl="~/Images/printer_icon.jpg"
                    Height="20px" Width="20px" OnClick="btnPrint_Click" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Panel runat="server" ID="p1" Width="100%" Height="100%">
                </asp:Panel>
            </td>
        </tr>
    </table>
</asp:Content>
