<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true" CodeFile="View_Loco_Assembly.aspx.cs" Inherits="Master_View_Loco_Assembly" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table align="center">
<tr>
<td> ASSEMBLY </td>
</tr>
<tr>
<td>
<asp:GridView runat="server" ID="gv1" AutoGenerateColumns="false">
<Columns>
<asp:TemplateField>
<HeaderTemplate>
SN
</HeaderTemplate>
<ItemTemplate>
<%#Container.DataItemIndex + 1 %>
</ItemTemplate>
</asp:TemplateField>

<asp:TemplateField>
<HeaderTemplate>
ASSEMBLY
</HeaderTemplate>
<ItemTemplate>
<asp:Label runat="server" ID="lblAssembly" Text='<%#Eval("name")%>'></asp:Label>
</ItemTemplate>
</asp:TemplateField>


<asp:TemplateField>
<HeaderTemplate>
SUPPLIER
</HeaderTemplate>
<ItemTemplate>
<asp:Label runat="server" ID="lblAssembly" Text='<%#Eval("s_name")%>'></asp:Label>
</ItemTemplate>
</asp:TemplateField>

</Columns>
</asp:GridView></td>
</tr>
</table>
</asp:Content>

