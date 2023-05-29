<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true"
    CodeFile="Loco_ScheduleReport.aspx.cs" Inherits="Loco_Loco_ScheduleReport" Title="Sabarmati Diesels : Schedule Report" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
<asp:ToolkitScriptManager runat="server" ID="ToolkitScriptManager1"></asp:ToolkitScriptManager>
    <script language="javascript" type="text/javascript">
    function CallValidation()
    {
       var n1 = document.getElementById('<%=ddlClass.ClientID%>').value;
       var n2 = document.getElementById('<%=ddlLocono.ClientID%>').value;
       if(Validate_selectedIndex(n1,'Class') && Validate_selectedIndex(n2,'Loco'))
       {return true;}
       return false;
    }

    </script>

    <table align="center" cellpadding="0" cellspacing="0">
        <tr>
            <th colspan="10">
                LOCO SCHEDULE DETAILS
            </th>
        </tr>
        <tr>
            <td align="right">
                CLASS
            </td>
            <td>
                :
            </td>
            <td>
                <asp:DropDownList runat="server" ID="ddlClass" AutoPostBack="True" OnSelectedIndexChanged="ddlClass_SelectedIndexChanged"
                    onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"
                    class="t1">
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
                <asp:Label runat="server" ID="lblguage" Visible="false"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="right">
                LOCO NO
            </td>
            <td>
                :
            </td>
            <td>
                <asp:DropDownList runat="server" ID="ddlLocono" onfocus="ChangeStyle(this.id.toString());"
                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" 
                    onselectedindexchanged="ddlLocono_SelectedIndexChanged" AutoPostBack="true">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
        <td align="right">D.O.C</td><td> : </td><td><asp:Label runat="server" ID="lbldoc" Text="--"></asp:Label></td>
        </tr>
        <tr>
        <td align="right">Last Heavy Schedule / Commisson</td><td> : </td><td><asp:TextBox runat="server" ID="txtHeavySchDate" onfocus="ChangeStyle(this.id.toString());"
                        onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
                    <asp:CalendarExtender runat="server" ID="CalendarExtender1" TargetControlID="txtHeavySchDate"
                        Format="dd/MM/yyyy">
                    </asp:CalendarExtender></td>
        </tr>
        <tr><td colspan="10" style="Color:brown;">*If Last Heavy Schedule /Commission is not provided then Loco Schedule will be generated as per D.O.C date.
</td></tr>
        <tr>
            <td>
            </td>
            <td>
            </td>
            <td>
                <asp:Button runat="server" ID="btnShow" Text="SHOW" onfocus="ChangeStyle(this.id.toString());"
                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t2" OnClick="btnShow_OnClick" />
            </td>
        </tr>
        <tr>
            <td colspan="10">
                <asp:GridView runat="Server" AutoGenerateColumns="false" ID="gv1">
                    <Columns>
                        <asp:TemplateField>
                            <HeaderTemplate>
                                No.1
                            </HeaderTemplate>
                            <ItemTemplate>
                                <%#Container.DataItemIndex + 1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <HeaderTemplate>
                                Schedule
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label runat="server" ID="l1" Text='<%#Eval("Schedule")%>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <HeaderTemplate>
                                Schedule Date
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label runat="server" ID="l1" Text='<%#Eval("ScheduleDate")%>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        </td> </tr>
    </table>
</asp:Content>
