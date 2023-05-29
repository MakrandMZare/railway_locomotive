<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true"
    CodeFile="ShedPositionReport.aspx.cs" Inherits="LocoShedPosition_ShedPositionReport"
    Title="Sabarmati Diesels : Loco" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </asp:ToolkitScriptManager>
    <%-- <asp:ToolkitScriptManager runat="server">
    </asp:ToolkitScriptManager>--%>
    <table align="center">
        <tr>
            <th>
                <asp:Label runat="server" ID="l1" Text="BG SHED POSITION" Font-Size="Large"></asp:Label>
            </th>
        </tr>
        <tr>
            <td>
                <table align="left">
                    <tr>
                        <td>
                            <asp:ImageButton runat="server" ID="btnPrint" ImageUrl="~/Images/printer_icon.jpg"
                                Height="20px" Width="20px" OnClick="btnPrint_Click" />
                        </td>
                        <td>
                            DATE
                        </td>
                        <td>
                            :
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtDate" onfocus="ChangeStyle(this.id.toString());"
                                onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
                        </td>
                        <td>
                            <asp:Button runat="server" ID="btnShow" Text="SHOW" onfocus="ChangeStyle(this.id.toString());"
                                onBlur="ChangeDefaultStyle(this.id.toString());" class="t2" OnClick="btnShow_OnClick"
                                Height="16px" />
                        </td>
                        <td>
                            <asp:CalendarExtender runat="server" ID="CalendarExtender1" TargetControlID="txtDate"
                                Format="dd/MM/yyyy">
                            </asp:CalendarExtender>
                        </td>
                        <td>
                            <asp:CheckBox runat="server" ID="editcheckbox" Text="Edit" AutoPostBack="true" OnCheckedChanged="editcheckbox_OnCheckedChanged" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Panel runat="server" ID="p1">
                    <asp:Label runat="server" ID="lbl1" Visible="False" Text="EMD LOCOS WDG4 SHED POSITION"
                        Font-Bold="True" Font-Size="Large"></asp:Label>
                    <asp:GridView runat="server" ID="gvshed" AutoGenerateColumns="false" Font-Bold="true"
                        Font-Size="Small" Width="950px" ShowFooter="true" CellPadding="0" CellSpacing="0">
                        <Columns>
                            <asp:TemplateField ItemStyle-VerticalAlign="Top">
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="SN." Font-Size="medium"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <%#Container.DataItemIndex + 1 %>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <table width="100%" border="1" cellspacing="0" cellpadding="0">
                                        <tr>
                                            <td>
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                &nbsp;
                                            </td>
                                        </tr>
                                    </table>
                                </FooterTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField ItemStyle-VerticalAlign="Top">
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="LOCO NO." Font-Size="medium"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" Text='<%#Eval("LOCO NO")%>' ID="Label1" Font-Size="medium"></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <table width="100%" border="1" cellspacing="0" cellpadding="0">
                                        <tr>
                                            <td>
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                &nbsp;
                                            </td>
                                        </tr>
                                    </table>
                                </FooterTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField ItemStyle-VerticalAlign="Top">
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="LAST OUT DATE" Font-Size="medium"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label2" runat="server" Text='<%#Eval("LAST OUT DATE")%>' Font-Size="medium"></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <table width="100%" border="1" cellspacing="0" cellpadding="0">
                                        <tr>
                                            <td>
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                &nbsp;
                                            </td>
                                        </tr>
                                    </table>
                                </FooterTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField ItemStyle-VerticalAlign="Top">
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="TRAIN" Font-Size="medium"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Labe3" runat="server" Text='<%#Eval("TRAIN")%>' Font-Size="medium"></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <table width="100%" border="1" cellspacing="0" cellpadding="0">
                                        <tr>
                                            <td>
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                &nbsp;
                                            </td>
                                        </tr>
                                    </table>
                                </FooterTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField ItemStyle-VerticalAlign="Top">
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="DUE SCHEDULE" Font-Size="medium"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label4" runat="server" Text='<%#Eval("DUE SCHEDULE")%>' Font-Size="medium"></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <table width="100%" border="1" cellspacing="0" cellpadding="0">
                                        <tr>
                                            <td>
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                &nbsp;
                                            </td>
                                        </tr>
                                    </table>
                                </FooterTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField ItemStyle-VerticalAlign="Top">
                                <HeaderTemplate>
                                    <%--<table border="0" width="100%">
                                        <tr>
                                            <td colspan="2" style="font-size: medium;">
                                                <asp:Label runat="server" Text="Shed Arrival" ID="lblShedArrival"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: medium;">
                                                <asp:Label runat="server" Text="Date" ID="Label16"></asp:Label>
                                            </td>
                                            <td style="font-size: medium;">
                                                <asp:Label runat="server" Text="Time" ID="Label17"></asp:Label>
                                            </td>
                                        </tr>
                                    </table>--%>
                                    <asp:Label runat="server" Text="SHED ARRIVAL" ID="lblShedArrival" Font-Size="Medium"></asp:Label><br />
                                    <asp:Label runat="server" Text="DATE" ID="Label16" Font-Size="Medium"></asp:Label>&nbsp;&nbsp;&nbsp;<asp:Label
                                        runat="server" Text="TIME" ID="Label17" Font-Size="Medium"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <table border="0">
                                        <tr>
                                            <td>
                                                <asp:Label ID="Label6" runat="server" Text='<%#Eval("DATE")%>' Font-Size="medium"></asp:Label>
                                            </td>
                                            <td>
                                                :
                                            </td>
                                            <td>
                                                <asp:Label ID="Label5" runat="server" Text='<%#Eval("TIME")%>' Font-Size="medium"></asp:Label>
                                            </td>
                                        </tr>
                                    </table>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <table width="100%" border="1" cellspacing="0" cellpadding="0">
                                        <tr>
                                            <td>
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                &nbsp;
                                            </td>
                                        </tr>
                                    </table>
                                </FooterTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField ItemStyle-VerticalAlign="Top">
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="LOC" Font-Size="medium"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label7" runat="server" Text='' Font-Size="medium"></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <table width="100%" border="1" cellspacing="0" cellpadding="0">
                                        <tr>
                                            <td>
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                &nbsp;
                                            </td>
                                        </tr>
                                    </table>
                                </FooterTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField ItemStyle-VerticalAlign="Top">
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="LFR%" Font-Size="medium"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label8" runat="server" Text='' Font-Size="medium"></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <table width="100%" border="1" cellspacing="0" cellpadding="0">
                                        <tr>
                                            <td>
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                &nbsp;
                                            </td>
                                        </tr>
                                    </table>
                                </FooterTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField ItemStyle-VerticalAlign="Top">
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="PDC" Font-Size="medium"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label9" runat="server" Text='' Font-Size="medium"></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <table width="100%" border="1" cellspacing="0" cellpadding="0">
                                        <tr>
                                            <td>
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                &nbsp;
                                            </td>
                                        </tr>
                                    </table>
                                </FooterTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField ItemStyle-VerticalAlign="Top">
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="REL" Font-Size="medium"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label10" runat="server" Text='' Font-Size="medium"></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <table width="100%" border="1" cellspacing="0" cellpadding="0">
                                        <tr>
                                            <td>
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                &nbsp;
                                            </td>
                                        </tr>
                                    </table>
                                </FooterTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField ItemStyle-VerticalAlign="Top">
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="REMARKS" Width="100" Font-Size="medium"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label11" runat="server" Text='<%#Eval("REMARKS")%>' Font-Size="medium"></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <table width="100%" border="1" cellspacing="0" cellpadding="0">
                                        <tr>
                                            <td>
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                &nbsp;
                                            </td>
                                        </tr>
                                    </table>
                                </FooterTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                    <asp:Label runat="server" ID="lbl2" Visible="False" Text="LINE MESSAGE" Font-Bold="True"
                        Font-Size="Large"></asp:Label><br />
                    <asp:GridView runat="server" ID="gvlinemsg1" AutoGenerateColumns="false" Font-Bold="true"
                        Font-Size="Small">
                        <Columns>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="SN." Font-Size="medium"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <%#Container.DataItemIndex + 1 %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="LOCO NO DATE" Width="80px" Font-Size="medium"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" Text='<%#Eval("LOCONO") + "-" +  Eval("DATE")%>' ID="Label1"
                                        Font-Size="medium"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="TRAIN NO - SITE - SECTION" Width="140" Font-Size="medium"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" Text='<%#Eval("TRAINNO") + "-" + Eval("SITE") + "-" +  Eval("SECTION")%>'
                                        ID="Label2" Font-Size="medium"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="LINE MESSAGE" Width="80" Font-Size="medium"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" Text='<%#Eval("LINE MESSAGE") %>' ID="Label3"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="LAST SCHEDULE" Width="100" Font-Size="medium"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" Text='<%#"DOC" +"-" + Eval("DOC")+ "-" + Eval("LAST SCH")  + "-" + Eval("LAST") %>'
                                        ID="Label5" Font-Size="medium"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="ACTION" Width="40" Font-Size="medium"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <table>
                                        <tr>
                                            <td>
                                                <asp:ImageButton Width="10px" runat="server" ImageUrl="~/Images/Edit-icon.png" ID="lbtnUpdate"
                                                    PostBackUrl='<%# "~/LocoShedPosition/shedposition2.aspx?id=" + Eval("tid") %>' />
                                            </td>
                                            <td>
                                                <asp:ImageButton Width="10px" runat="server" ImageUrl="~/Images/Delete-icon.png"
                                                    ID="lbtnDelete" PostBackUrl='<%# "~/LocoShedPosition/ShedPositionReport.aspx?LineMessage1Id=" + Eval("tid") + "&action=delete"%>' />
                                            </td>
                                        </tr>
                                    </table>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                    <asp:Label runat="server" ID="lbl3" Visible="False" Text="DEAD ON LINE" Font-Bold="True"
                        Font-Size="medium"></asp:Label><br />
                    <asp:GridView runat="server" ID="gvlinemsg2" AutoGenerateColumns="false" Font-Bold="true"
                        Font-Size="small">
                        <Columns>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="SN." Font-Size="medium"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <%#Container.DataItemIndex + 1 %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="LOCO NO" Font-Size="medium"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" Text='<%#Eval("LOCO NO") + "-" +  Eval("DATE")%>' ID="Label1"
                                        Font-Size="medium"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="D/W" Font-Size="medium"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label2" runat="server" Text='<%#Eval("D/W")%>' Font-Size="medium"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="TRAINONO - LOAD" Font-Size="medium"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Labe3" runat="server" Text='<%#Eval("TRNO") + " - " + Eval("LOAD")%>'
                                        Font-Size="medium"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="GRAD" Font-Size="medium"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label4" runat="server" Text='<%#Eval("GRAD")%>' Font-Size="medium"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="REPOTED REASON" Font-Size="medium"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label5" runat="server" Text='<%#Eval("REPOTED REASON")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="LAST SCHEDULE" Font-Size="medium"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label6" runat="server" Text='<%#"DOC -" + Eval("DOC") + Eval("LAST") + Eval("LAST SCHEDULE") %>'
                                        Font-Size="medium"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label ID="Label7" runat="server" Font-Size="medium" Text="ACTION"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <table>
                                        <tr>
                                            <td>
                                                <asp:ImageButton runat="server" Width="10px" ImageUrl="~/Images/Edit-icon.png" ID="lbtnUpdate"
                                                    PostBackUrl='<%# "~/LocoShedPosition/LineMessage2.aspx?id=" + Eval("rid") %>' />
                                            </td>
                                            <td>
                                                <asp:ImageButton runat="server" Width="10px" ImageUrl="~/Images/Delete-icon.png"
                                                    ID="lbtnDelete" PostBackUrl='<%# "~/LocoShedPosition/ShedPositionReport.aspx?LineMessage2Id=" + Eval("rid")+"&action=delete" %>' />
                                            </td>
                                        </tr>
                                    </table>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                    <table cellspacing="0" cellpadding="0" width="100%">
                        <tr>
                            <th>
                                &nbsp;
                            </th>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" ID="lbl9" Visible="False" Font-Bold="True" Font-Size="Large"></asp:Label>
                                <asp:DataList runat="server" ID="dl1" RepeatColumns="4" RepeatDirection="Horizontal"
                                    Font-Size="Large">
                                    <ItemTemplate>
                                        <table width="100%">
                                            <tr>
                                                <td>
                                                    <asp:Label runat="server" ID="lbl1" Text='<%#Eval("Locono")%>' Font-Size="Large"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label runat="server" ID="lbl2" Text='<%#Eval("Schedule")%>' Font-Size="Large"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label runat="server" ID="lbl3" Text='<%#Eval("ScheduleDate")%>' Font-Size="Large"></asp:Label>
                                                </td>
                                            </tr>
                                        </table>
                                    </ItemTemplate>
                                </asp:DataList>
                                <asp:Label runat="server" ID="lbl10" Visible="False" Font-Bold="True" Font-Size="Large"></asp:Label>
                                <asp:DataList runat="server" ID="dl2" RepeatColumns="4" RepeatDirection="Horizontal"
                                    Font-Size="Large">
                                    <ItemTemplate>
                                        <table>
                                            <tr>
                                                <td>
                                                    <%#Eval("Locono")%>
                                                    <%--<asp:Label runat="server" ID="lbl1" Text='<%#Eval("Locono")%>' Font-Size="Large"></asp:Label>--%>
                                                </td>
                                                <td>
                                                    <%--<%#Eval("Schedule")%>--%>
                                                    <asp:Label runat="server" ID="lbl2" Text='<%#Eval("Schedule")%>' Font-Size="Large"
                                                        Width="100px"></asp:Label>
                                                </td>
                                                <td>
                                                    <%#Eval("ScheduleDate")%>
                                                    <%--<asp:Label runat="server" ID="lbl3" Text='<%#Eval("ScheduleDate")%>' Font-Size="Large"></asp:Label>--%>
                                                </td>
                                            </tr>
                                        </table>
                                    </ItemTemplate>
                                </asp:DataList>
                            </td>
                        </tr>
                        <tr>
                            <td>
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
    </table>
    <asp:Panel runat="server" ID="Page2">
        <table>
            <tr>
                <td>
                    <asp:ImageButton runat="server" ID="ImageButton1" ImageUrl="~/Images/printer_icon.jpg"
                        Height="20px" Width="20px" OnClick="ImageButton1_Click" /></td>
            </tr>
            <tr>
                <td>
                    <table>
                        <tr>
                            <td>
                                <table>
                                    <tr>
                                        <th style="font-size: large">
                                            MONTHLY OUTAGE OF WDG4
                                        </th>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:GridView runat="server" ID="gvMonthlyOutage" AutoGenerateColumns="false" Font-Size="Large"
                                                OnRowDataBound="gvMonthlyOutage_OnRowDataBound">
                                                <Columns>
                                                    <asp:TemplateField HeaderText="MONTH">
                                                        <ItemTemplate>
                                                            <asp:Label runat="server" ID="lblMonth" Text='<%#Eval("Month") + "/" + Eval("Year")%>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="TARGET">
                                                        <ItemTemplate>
                                                            <asp:Label runat="server" ID="lblTarget" Text='<%#Eval("Target")%>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="ACTUAL">
                                                        <ItemTemplate>
                                                            <asp:Label runat="server" ID="lblActual" Text='<%#Eval("Actual")%>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="% DEFF.">
                                                        <ItemTemplate>
                                                            <%--<asp:Label runat="server" ID="lblDiff" Text='<%#Eval("Diffrance")%>'></asp:Label>--%>
                                                            <asp:Label runat="server" ID="lblDiff" Text=""></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                </Columns>
                                            </asp:GridView>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td>
                                <table width="100%" border="1">
                                    <tr>
                                        <th colspan="50" align="center">
                                            OUTAGE
                                        </th>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table border="1" style="font-size: medium; width: 593px; border-top-style: solid;
                                                border-right-style: solid; border-left-style: solid; border-bottom-style: solid;"
                                                cellpadding="0" cellspacing="0">
                                                <tr>
                                                    <td  border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                    </td>
                                                </tr>
                                                <tr>
                                                </tr>
                                                <tr>
                                                    <td colspan="1" rowspan="1"  border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                    </td>
                                                    <td colspan="2" rowspan="1"  border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;" align="center">
                                                        HOLDING</td>
                                                    <td colspan="4" rowspan="1"  border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;" align="center">
                                                        FOIS</td>
                                                    <td colspan="1" rowspan="1"  border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        DEAD</td>
                                                </tr>
                                                <tr>
                                                    <td colspan="1" rowspan="1"  border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                    </td>
                                                    <td colspan="1" rowspan="1"  border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        BOOK</td>
                                                    <td colspan="1" rowspan="1"  border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        EFF</td>
                                                    <td colspan="1" rowspan="1"  border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        TAR</td>
                                                    <td colspan="1" rowspan="1"  border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        NET</td>
                                                    <td colspan="2" rowspan="1"  border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        CUM</td>
                                                    <td rowspan="2" colspan="1"  border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        <asp:Label runat="server" ID="txtDead1" onfocus="ChangeStyle(this.id.toString());"
                                                            Text="0" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Font-Size="Large"></asp:Label></td>
                                                </tr>
                                                <tr>
                                                    <td colspan="1" rowspan="1"  border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        BG</td>
                                                    <td colspan="1" rowspan="1"  border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        <asp:Label runat="server" ID="txtBGHoldingBook" onfocus="ChangeStyle(this.id.toString());"
                                                            onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Text="0" Font-Size="Large"></asp:Label></td>
                                                    <td colspan="1" rowspan="1"  border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        <asp:Label runat="server" Text="0" ID="txtBGHoldingEff" onfocus="ChangeStyle(this.id.toString());"
                                                            onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Font-Size="Large"></asp:Label></td>
                                                    <td colspan="1" rowspan="1"  border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        <asp:Label runat="server" ID="txtTar1" onfocus="ChangeStyle(this.id.toString());"
                                                            onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Text="0" Font-Size="Large"></asp:Label></td>
                                                    <td colspan="1" rowspan="1"  border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        <asp:Label runat="server" ID="txtNet" onfocus="ChangeStyle(this.id.toString());"
                                                            Text="0" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Font-Size="Large"></asp:Label></td>
                                                    <td colspan="2" rowspan="1"  border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        <asp:Label runat="server" ID="txtFois" onfocus="ChangeStyle(this.id.toString());"
                                                            Text="0" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Font-Size="Large"></asp:Label></td>
                                                </tr>
                                                <tr>
                                                    <td colspan="1" rowspan="1"  border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        <asp:Label runat="server" ID="txtTar" onfocus="ChangeStyle(this.id.toString());"
                                                            Text="0" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Font-Size="Large"
                                                            Visible="False"></asp:Label></td>
                                                    <td colspan="1" rowspan="1"  border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        <asp:Label runat="server" ID="txtAct" onfocus="ChangeStyle(this.id.toString());"
                                                            Text="0" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Font-Size="Large"
                                                            Visible="False"></asp:Label></td>
                                                    <td colspan="1" rowspan="1"  border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                    </td>
                                                    <td colspan="1" rowspan="1"  border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                    </td>
                                                    <td colspan="1" rowspan="1"  border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                    </td>
                                                    <td colspan="1" rowspan="1"  border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        Tar</td>
                                                    <td colspan="1" rowspan="1"  border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        Act</td>
                                                    <td colspan="1" rowspan="1"  border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td colspan="1" rowspan="1"  border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        MG</td>
                                                    <td colspan="1" rowspan="1"  border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        <asp:Label runat="server" Text="0" ID="txtMGHoldingBook" onfocus="ChangeStyle(this.id.toString());"
                                                            onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Font-Size="Large"></asp:Label></td>
                                                    <td colspan="1" rowspan="1"  border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        <asp:Label runat="server" Text="0" ID="txtMGHoldingEff" onfocus="ChangeStyle(this.id.toString());"
                                                            onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Font-Size="Large"></asp:Label></td>
                                                    <td colspan="1" rowspan="1"  border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        <asp:Label runat="server" ID="txtMGTar1" onfocus="ChangeStyle(this.id.toString());"
                                                            onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Text="0" Font-Size="Large"></asp:Label></td>
                                                    <td colspan="1" rowspan="1"  border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        <asp:Label runat="server" ID="txtMGNet1" onfocus="ChangeStyle(this.id.toString());"
                                                            Text="0" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Font-Size="Large"></asp:Label></td>
                                                    <td colspan="1" rowspan="1"  border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        <asp:Label runat="server" ID="txtTar2" onfocus="ChangeStyle(this.id.toString());"
                                                            Text="0" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Font-Size="Large"></asp:Label></td>
                                                    <td colspan="1" rowspan="1"  border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        <asp:Label runat="server" ID="txtact2" onfocus="ChangeStyle(this.id.toString());"
                                                            Text="0" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Font-Size="Large"></asp:Label></td>
                                                    <td colspan="1" rowspan="1"  border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        <asp:Label runat="server" ID="txtDead2" onfocus="ChangeStyle(this.id.toString());"
                                                            Text="0" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Font-Size="Large"></asp:Label></td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <th colspan="50">
                                            LOCO OUT AGE DETAIL
                                        </th>
                                    </tr>
                                    <tr>
                                        <td style="font-size: large; border-top-style: solid; border-right-style: solid;
                                            border-left-style: solid; border-bottom-style: solid;">
                                        </td>
                                        <td style="font-size: large; border-top-style: solid; border-right-style: solid;
                                            border-left-style: solid; border-bottom-style: solid">
                                        </td>
                                        <td align="center" style="font-size: large; border-top-style: solid; border-right-style: solid;
                                            border-left-style: solid; border-bottom-style: solid">
                                            <b>MG</b>
                                        </td>
                                        <td align="center" style="font-size: large; border-top-style: solid; border-right-style: solid;
                                            border-left-style: solid; border-bottom-style: solid">
                                            <b>BG </b>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="font-size: large; border-top-style: solid; border-right-style: solid;
                                            border-left-style: solid; border-bottom-style: solid;">
                                            SBI HR
                                        </td>
                                        <td style="font-size: large; border-top-style: solid; border-right-style: solid;
                                            border-left-style: solid; border-bottom-style: solid">
                                            :
                                        </td>
                                        <td align="left" style="font-size: large; border-top-style: solid; border-right-style: solid;
                                            border-left-style: solid; border-bottom-style: solid">
                                            <asp:Label ID="txtsbihrMG" runat="server" class="t1" Font-Size="Large" onBlur="ChangeDefaultStyle(this.id.toString());"
                                                onfocus="ChangeStyle(this.id.toString());" Text="0.00"></asp:Label>
                                        </td>
                                        <td style="font-size: large; border-top-style: solid; border-right-style: solid;
                                            border-left-style: solid; border-bottom-style: solid">
                                            <asp:Label ID="txtsbihrBG" runat="server" class="t1" Font-Size="Large" onBlur="ChangeDefaultStyle(this.id.toString());"
                                                onfocus="ChangeStyle(this.id.toString());" Text="0.00"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="font-size: large; border-top-style: solid; border-right-style: solid;
                                            border-left-style: solid; border-bottom-style: solid;">
                                            SBI LR
                                        </td>
                                        <td style="font-size: large; border-top-style: solid; border-right-style: solid;
                                            border-left-style: solid; border-bottom-style: solid">
                                            :
                                        </td>
                                        <td align="left" style="font-size: large; border-top-style: solid; border-right-style: solid;
                                            border-left-style: solid; border-bottom-style: solid">
                                            <asp:Label ID="txtsbilrMG" runat="server" class="t1" Font-Size="Large" onBlur="ChangeDefaultStyle(this.id.toString());"
                                                onfocus="ChangeStyle(this.id.toString());" Text="0.0"></asp:Label>
                                        </td>
                                        <td style="font-size: large; border-top-style: solid; border-right-style: solid;
                                            border-left-style: solid; border-bottom-style: solid">
                                            <asp:Label ID="txtsbilrBG" runat="server" class="t1" Font-Size="Large" onBlur="ChangeDefaultStyle(this.id.toString());"
                                                onfocus="ChangeStyle(this.id.toString());" Text="0.00"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="font-size: large; border-top-style: solid; border-right-style: solid;
                                            border-left-style: solid; border-bottom-style: solid;">
                                            SBI UR
                                        </td>
                                        <td style="font-size: large; border-top-style: solid; border-right-style: solid;
                                            border-left-style: solid; border-bottom-style: solid;">
                                            :
                                        </td>
                                        <td align="left" style="font-size: large; border-top-style: solid; border-right-style: solid;
                                            border-left-style: solid; border-bottom-style: solid;">
                                            <asp:Label ID="txtsbiurMG" runat="server" class="t1" Font-Size="Large" onBlur="ChangeDefaultStyle(this.id.toString());"
                                                onfocus="ChangeStyle(this.id.toString());" Text="0.0"></asp:Label>
                                        </td>
                                        <td style="font-size: large; border-top-style: solid; border-right-style: solid;
                                            border-left-style: solid; border-bottom-style: solid;">
                                            <asp:Label ID="txtsbiurBG" runat="server" class="t1" Font-Size="Large" onBlur="ChangeDefaultStyle(this.id.toString());"
                                                onfocus="ChangeStyle(this.id.toString());" Text="0.0"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="font-size: large; border-top-style: solid; border-right-style: solid;
                                            border-left-style: solid; border-bottom-style: solid;">
                                            DEAD
                                        </td>
                                        <td style="font-size: large; border-top-style: solid; border-right-style: solid;
                                            border-left-style: solid; border-bottom-style: solid">
                                            :
                                        </td>
                                        <td align="left" style="font-size: large; border-top-style: solid; border-right-style: solid;
                                            border-left-style: solid; border-bottom-style: solid">
                                            <asp:Label ID="txtDeadMG" runat="server" class="t1" Font-Size="Large" onBlur="ChangeDefaultStyle(this.id.toString());"
                                                onfocus="ChangeStyle(this.id.toString());" Text="0.00"></asp:Label>
                                        </td>
                                        <td style="font-size: large; border-top-style: solid; border-right-style: solid;
                                            border-left-style: solid; border-bottom-style: solid">
                                            <asp:Label ID="txtDeadBG" runat="server" class="t1" Font-Size="Large" onBlur="ChangeDefaultStyle(this.id.toString());"
                                                onfocus="ChangeStyle(this.id.toString());" Text="0.0"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="font-size: large; border-top-style: solid; border-right-style: solid;
                                            border-left-style: solid; border-bottom-style: solid;">
                                            Other Div
                                        </td>
                                        <td style="font-size: large; border-top-style: solid; border-right-style: solid;
                                            border-left-style: solid; border-bottom-style: solid">
                                            :
                                        </td>
                                        <td align="left" style="font-size: large; border-top-style: solid; border-right-style: solid;
                                            border-left-style: solid; border-bottom-style: solid">
                                            <asp:Label ID="txtOtherDivMG" runat="server" class="t1" Font-Size="Large" onBlur="ChangeDefaultStyle(this.id.toString());"
                                                onfocus="ChangeStyle(this.id.toString());" Text="0.0"></asp:Label>
                                        </td>
                                        <td style="font-size: large; border-top-style: solid; border-right-style: solid;
                                            border-left-style: solid; border-bottom-style: solid">
                                            <asp:Label ID="txtOtherDivBG" runat="server" class="t1" Font-Size="Large" onBlur="ChangeDefaultStyle(this.id.toString());"
                                                onfocus="ChangeStyle(this.id.toString());" Text="0.0"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="font-size: large; border-top-style: solid; border-right-style: solid;
                                            border-left-style: solid; border-bottom-style: solid;">
                                            (-) Lie Over
                                        </td>
                                        <td style="font-size: large; border-top-style: solid; border-right-style: solid;
                                            border-left-style: solid; border-bottom-style: solid">
                                            :
                                        </td>
                                        <td align="left" style="font-size: large; border-top-style: solid; border-right-style: solid;
                                            border-left-style: solid; border-bottom-style: solid">
                                            <asp:Label ID="txtLieOverMG" runat="server" class="t1" Font-Size="Large" onBlur="ChangeDefaultStyle(this.id.toString());"
                                                onfocus="ChangeStyle(this.id.toString());" Text="0.0"></asp:Label>
                                        </td>
                                        <td style="font-size: large; border-top-style: solid; border-right-style: solid;
                                            border-left-style: solid; border-bottom-style: solid">
                                            <asp:Label ID="txtLieOverBG" runat="server" class="t1" Font-Size="Large" onBlur="ChangeDefaultStyle(this.id.toString());"
                                                onfocus="ChangeStyle(this.id.toString());" Text="0.0"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="font-size: large; border-top-style: solid; border-right-style: solid;
                                            border-left-style: solid; border-bottom-style: solid;">
                                            NET
                                        </td>
                                        <td style="font-size: large; border-top-style: solid; border-right-style: solid;
                                            border-left-style: solid; border-bottom-style: solid">
                                            :
                                        </td>
                                        <td align="left" style="font-size: large; border-top-style: solid; border-right-style: solid;
                                            border-left-style: solid; border-bottom-style: solid">
                                            <asp:Label ID="lblNetMG" runat="server" Font-Size="Large" Text="..."></asp:Label>
                                            <asp:Label ID="lblNetMGTotal" runat="server" Text="..." Width="10px"></asp:Label></td>
                                        <td style="font-size: large; border-top-style: solid; border-right-style: solid;
                                            border-left-style: solid; border-bottom-style: solid">
                                            <asp:Label ID="lblNetBG" runat="server" Font-Size="Large" Text="..."></asp:Label>
                                            le<asp:Label ID="lblNetBGTotal" runat="server" Text="..." Width="77px"></asp:Label>
                                            Loco</td>
                                    </tr>
                                    <tr>
                                        <td style="font-size: large; border-top-style: solid; border-right-style: solid;
                                            border-left-style: solid; border-bottom-style: solid;">
                                            <img alt="arrow" height="10" src="../Images/Next-icon.png" width="10" />
                                            SR / 100 LOCO HOLDING
                                        </td>
                                        <td style="font-size: large; border-top-style: solid; border-right-style: solid;
                                            border-left-style: solid; border-bottom-style: solid">
                                            :
                                        </td>
                                        <td style="font-size: large; border-top-style: solid; border-right-style: solid;
                                            border-left-style: solid; border-bottom-style: solid">
                                            <asp:Label ID="txt1" runat="server" class="t1" Font-Size="Large" onBlur="ChangeDefaultStyle(this.id.toString());"
                                                onfocus="ChangeStyle(this.id.toString());" Text="0.0"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="font-size: large; border-top-style: solid; border-right-style: solid;
                                            border-left-style: solid; border-bottom-style: solid;">
                                            <img alt="arrow" height="10" src="../Images/Next-icon.png" width="10" />
                                            AVERAGE LOC / 100 EKM
                                        </td>
                                        <td style="font-size: large; border-top-style: solid; border-right-style: solid;
                                            border-left-style: solid; border-bottom-style: solid">
                                            :
                                        </td>
                                        <td style="font-size: large; border-top-style: solid; border-right-style: solid;
                                            border-left-style: solid; border-bottom-style: solid">
                                            <asp:Label ID="txt2" runat="server" class="t1" Font-Size="Large" onBlur="ChangeDefaultStyle(this.id.toString());"
                                                onfocus="ChangeStyle(this.id.toString());" Text="0.0"></asp:Label>
                                            <asp:Label ID="Label11" runat="server" class="t1" Font-Size="Large" onblur="ChangeDefaultStyle(this.id.toString());"
                                                onfocus="ChangeStyle(this.id.toString());" Text="Ltr"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="font-size: large; border-top-style: solid; border-right-style: solid;
                                            border-left-style: solid; border-bottom-style: solid;">
                                            <img alt="arrow" height="10" src="../Images/Next-icon.png" width="10" />AVERAGE
                                            GEAR CASE OIL
                                        </td>
                                        <td style="font-size: large; border-top-style: solid; border-right-style: solid;
                                            border-left-style: solid; border-bottom-style: solid">
                                            :
                                        </td>
                                        <td style="font-size: large; border-top-style: solid; border-right-style: solid;
                                            border-left-style: solid; border-bottom-style: solid">
                                            <asp:Label ID="txt3" runat="server" class="t1" Font-Size="Large" onBlur="ChangeDefaultStyle(this.id.toString());"
                                                onfocus="ChangeStyle(this.id.toString());" Text="0.0"></asp:Label>
                                            <asp:Label ID="Label12" runat="server" Font-Size="Large" onblur="ChangeDefaultStyle(this.id.toString());"
                                                onfocus="ChangeStyle(this.id.toString());" Text="Litters/Loco/month"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="font-size: large; border-top-style: solid; border-right-style: solid;
                                            border-left-style: solid; border-bottom-style: solid;">
                                            <img alt="arrow" height="10" src="../Images/Next-icon.png" width="10" />AVERAGE
                                            COMPRESSOR OIL
                                        </td>
                                        <td style="font-size: large; border-top-style: solid; border-right-style: solid;
                                            border-left-style: solid; border-bottom-style: solid">
                                            :
                                        </td>
                                        <td style="font-size: large; border-top-style: solid; border-right-style: solid;
                                            border-left-style: solid; border-bottom-style: solid">
                                            <asp:Label ID="txt4" runat="server" class="t1" Font-Size="Large" onBlur="ChangeDefaultStyle(this.id.toString());"
                                                onfocus="ChangeStyle(this.id.toString());" Text="0.0"></asp:Label>
                                            <asp:Label ID="Label13" runat="server" Font-Size="Large" onblur="ChangeDefaultStyle(this.id.toString());"
                                                onfocus="ChangeStyle(this.id.toString());" Text="Litters/Loco/month"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="font-size: large; border-top-style: solid; border-right-style: solid;
                                            border-left-style: solid; border-bottom-style: solid;">
                                            <img alt="arrow" height="10" src="../Images/Next-icon.png" width="10" />AVERAGE
                                            SPECIFIC FUEL CONSUMPTION
                                        </td>
                                        <td style="font-size: large; border-top-style: solid; border-right-style: solid;
                                            border-left-style: solid; border-bottom-style: solid">
                                            :
                                        </td>
                                        <td style="font-size: large; border-top-style: solid; border-right-style: solid;
                                            border-left-style: solid; border-bottom-style: solid">
                                            <asp:Label ID="txt5" runat="server" class="t1" Font-Size="Large" onBlur="ChangeDefaultStyle(this.id.toString());"
                                                onfocus="ChangeStyle(this.id.toString());" Text="0.0"></asp:Label>
                                            <asp:Label ID="Label14" runat="server" Font-Size="Large" onblur="ChangeDefaultStyle(this.id.toString());"
                                                onfocus="ChangeStyle(this.id.toString());" Text="Liters/1000 GTKM"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="font-size: large; border-top-style: solid; border-right-style: solid;
                                            border-left-style: solid; border-bottom-style: solid;">
                                            <img alt="arrow" height="10" src="../Images/Next-icon.png" width="10" />AVERAGE
                                            RUNNING
                                        </td>
                                        <td style="font-size: large; border-top-style: solid; border-right-style: solid;
                                            border-left-style: solid; border-bottom-style: solid">
                                            :
                                        </td>
                                        <td style="font-size: large; border-top-style: solid; border-right-style: solid;
                                            border-left-style: solid; border-bottom-style: solid">
                                            <asp:Label ID="txt6" runat="server" class="t1" Font-Size="Large" onBlur="ChangeDefaultStyle(this.id.toString());"
                                                onfocus="ChangeStyle(this.id.toString());" Text="0"></asp:Label>
                                            <asp:Label ID="Label15" runat="server" Font-Size="Large" onblur="ChangeDefaultStyle(this.id.toString());"
                                                onfocus="ChangeStyle(this.id.toString());" Text="Km/Loco/day"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                </td>
            </tr>
        </table>
        <asp:Label runat="server" ID="lbl5" Visible="False" Text="LOCO MOVEMENTS" Font-Bold="True"
            Font-Size="Large"></asp:Label>
        <asp:Label runat="server" ID="lbl6" Visible="False" Font-Bold="True" Font-Size="Large"></asp:Label>
        <asp:GridView runat="server" ID="gv3" AutoGenerateColumns="false" Width="100%" Font-Size="Small">
            <Columns>
                <asp:TemplateField>
                    <HeaderTemplate>
                        LOCO
                    </HeaderTemplate>
                    <ItemTemplate>
                        <asp:Label runat="server" ID="l1" Text='<%#Eval("Loco")%>' Font-Size="large"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <HeaderTemplate>
                        SCHEDULE
                    </HeaderTemplate>
                    <ItemTemplate>
                        <asp:Label runat="server" ID="l1" Text='<%#Eval("Schedule")%>' Font-Size="large"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <HeaderTemplate>
                        DATE
                    </HeaderTemplate>
                    <ItemTemplate>
                        <asp:Label runat="server" ID="l1" Text='<%#Eval("Date")%>' Font-Size="large"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:Label runat="server" ID="lbl7" Visible="False" Font-Bold="True" Font-Size="Large"></asp:Label>
        <asp:DataList runat="server" ID="gv4" RepeatColumns="3" RepeatDirection="Horizontal"
            Font-Size="Large">
            <ItemTemplate>
                <table width="100%">
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lbl1" Text='<%#Eval("Locono")%>' Font-Size="Large"></asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" ID="lbl2" Text='<%#Eval("Schedule")%>' Font-Size="Large"></asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" ID="lbl3" Text='<%#Eval("ScheduleDate")%>' Font-Size="Large"></asp:Label>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
        <asp:Label runat="server" ID="lbl8" Visible="False" Font-Bold="True" Font-Size="Large"></asp:Label>
        <asp:DataList runat="server" ID="gv5" RepeatColumns="3" RepeatDirection="Horizontal"
            Font-Size="Large">
            <ItemTemplate>
                <table width="100%">
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="lbl1" Text='<%#Eval("Locono")%>' Font-Size="Large"></asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" ID="lbl2" Text='<%#Eval("Schedule")%>' Font-Size="Large"></asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" ID="lbl3" Text='<%#Eval("ScheduleDate")%>' Font-Size="Large"></asp:Label>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
        <br />
        <table>
            <tr>
                <td>
                    <asp:Label runat="server" ID="lbl4" Visible="False" Text="EMD LOCOS UNDER TEMPORARY REPAIR"
                        Font-Bold="True" Font-Size="Large"></asp:Label>
                    <asp:GridView runat="server" ID="TempRepair" Width="950" AutoGenerateColumns="false"
                        Font-Size="Small">
                        <Columns>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="SN." Font-Size="large"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <%#Container.DataItemIndex + 1 %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="LOCO NO" Font-Bold="true" Font-Size="large"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" Text='<%#Eval("locono")%>' ID="Label6" Font-Size="large"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="SITE" Font-Size="large"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label1" runat="server" Text='<%#Eval("site")%>' Font-Size="large"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="SECTION" Font-Size="large"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label2" runat="server" Text='<%#Eval("section")%>' Font-Size="large"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="REASON" Font-Size="large"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label3" runat="server" Text='<%#Eval("reason")%>' Font-Size="large"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="REMARKS" Font-Size="large"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label4" runat="server" Text='<%#Eval("remarks")%>' Font-Size="large"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label ID="Label5" runat="server" Text="ACTION" Font-Size="large"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <table>
                                        <tr>
                                            <td>
                                                <asp:ImageButton Width="10px" runat="server" ImageUrl="~/Images/Edit-icon.png" ID="lbtnUpdate"
                                                    PostBackUrl='<%# "~/LocoShedPosition/Temporary_Repair.aspx?id=" + Eval("rid") %>' />
                                            </td>
                                            <td>
                                                <asp:ImageButton Width="10px" runat="server" ImageUrl="~/Images/Delete-icon.png"
                                                    ID="lbtnDelete" PostBackUrl='<%# "~/LocoShedPosition/ShedPositionReport.aspx?TemporaryId=" + Eval("rid") + "&action=delete" %>' />
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
    </asp:Panel>
    <table>
        <tr>
            <td colspan="50">
                <asp:Button runat="server" ID="btnSave" Text="INSERT" onfocus="ChangeStyle(this.id.toString());"
                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t2" OnClick="btnSave_OnClick" />
            </td>
        </tr>
    </table>
</asp:Content>
