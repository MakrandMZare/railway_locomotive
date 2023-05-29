<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true"
    CodeFile="Copy of ShedPositionReport.aspx.cs" Inherits="LocoShedPosition_ShedPositionReport"
    Title="Sabarmati Diesels : Loco" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    
 
    
    <asp:ToolkitScriptManager runat="server">
    </asp:ToolkitScriptManager>
    <table align="center">
        <tr>
            <th>
                <asp:Label runat="server" ID="l1" Text="BG SHED POSITION" Font-Size="14"></asp:Label>
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
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Panel runat="server" ID="p1" Width="100%" Visible="false">
                    <asp:Label runat="server" ID="lbl1" Text="EMD LOCOS WDG4 SHED POSITION"
                        Font-Bold="True" Font-Size="15pt"></asp:Label>
                    <asp:GridView runat="server" ID="gvshed" AutoGenerateColumns="false" 
                     Font-Size="14" Width="990"  ShowFooter="true" 
                    CellPadding="0" CellSpacing="0">
                        <Columns>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="SN." Font-Size="medium"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                 <asp:Label ID="w1" runat="server" Font-Size="14" Text='<%#Container.DataItemIndex + 1 %>'></asp:Label>   
                                </ItemTemplate>
                                <FooterTemplate>
                                    <table width="100%" border="1" cellspacing="0" cellpadding="0">
                                        <tr>
                                            <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                           <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                            <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                    </table>
                                </FooterTemplate>
                                <ItemStyle VerticalAlign="Top" />
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="LOCO NO." Font-Size="medium"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" Text='<%#Eval("LOCO NO")%>' ID="Label1" Font-Size="14"></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <table width="100%" border="1" cellspacing="0" cellpadding="0">
                                        <tr>
                                          <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                           <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                            <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                    </table>
                                </FooterTemplate>
                                <ItemStyle VerticalAlign="Top" />
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="LASTOUT DATE" Font-Size="medium"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label2" runat="server" Text='<%#Eval("LAST OUT DATE")%>' Font-Size="14"></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <table width="100%" border="1" cellspacing="0" cellpadding="0">
                                        <tr>
                                           <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                            <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                          <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                    </table>
                                </FooterTemplate>
                                <ItemStyle VerticalAlign="Top" />
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="TRAIN" Font-Size="medium"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Labe3" runat="server" Text='<%#Eval("TRAIN")%>' Font-Size="14"></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <table  width="100%" border="1" cellspacing="0" cellpadding="0">
                                        <tr>
                                        <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                           <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                        <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                    </table>
                                </FooterTemplate>
                                <ItemStyle VerticalAlign="Top" />
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="DUE SCHEDULE" Font-Size="medium"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label4" runat="server" Text='<%#Eval("DUE SCHEDULE")%>' Font-Size="14"></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <table width="100%" border="1" cellspacing="0" cellpadding="0">
                                        <tr>
                                         <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                        <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                          <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                    </table>
                                </FooterTemplate>
                                <ItemStyle VerticalAlign="Top" />
                            </asp:TemplateField>
                            <asp:TemplateField>
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
                                    <asp:Label runat="server" Text="SHED ARRIVAL"  ID="lblShedArrival" Font-Size="Medium"></asp:Label><br />
                                    <asp:Label runat="server" Text="DATE" ID="Label16" Font-Size="Medium"></asp:Label>&nbsp;&nbsp;&nbsp;<asp:Label
                                        runat="server" Text="TIME" ID="Label17" Font-Size="Medium"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <table border="0">
                                        <tr>
                                            <td>
                                                <asp:Label ID="Label6" Width="100%"  runat="server" Text='<%#Eval("DATE")%>' Font-Size="14"></asp:Label>
                                            </td>
                                            <td>
                                               |
                                            </td>
                                            <td>
                                                <asp:Label ID="Label5" Width="100%" runat="server" Text='<%#Eval("TIME")%>' Font-Size="14"></asp:Label>
                                            </td>
                                        </tr>
                                    </table>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <table width="100%" border="1" cellspacing="0" cellpadding="0">
                                        <tr>
                                           <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                            <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                            <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                    </table>
                                </FooterTemplate>
                                <ItemStyle VerticalAlign="Top" />
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="LOC" Font-Size="medium"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label7" runat="server" Text='' Font-Size="medium"></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <table width="100%" border="1" cellspacing="0" cellpadding="0">
                                        <tr>
                                       <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                          <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                         <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                    </table>
                                </FooterTemplate>
                                <ItemStyle VerticalAlign="Top" />
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="LFR%" Font-Size="medium"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label8" runat="server" Text='' Font-Size="medium"></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <table width="100%" border="1" cellspacing="0" cellpadding="0">
                                        <tr>
                                         <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                         <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                      <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                    </table>
                                </FooterTemplate>
                                <ItemStyle VerticalAlign="Top" />
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="PDC" Font-Size="medium"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label9" runat="server" Text='' Font-Size="medium"></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <table width="100%" border="1" cellspacing="0" cellpadding="0">
                                        <tr>
                                           <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                          <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                        <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                    </table>
                                </FooterTemplate>
                                <ItemStyle VerticalAlign="Top" />
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="REL" Font-Size="medium"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label10" runat="server" Text='' Font-Size="medium"></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <table width="100%" border="1" cellspacing="0" cellpadding="0">
                                        <tr>
                                          <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                          <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                          <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                    </table>
                                </FooterTemplate>
                                <ItemStyle VerticalAlign="Top" />
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="REMARKS" Width="100%" Font-Size="medium"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label11" runat="server" Text='<%#Eval("REMARKS")%>' Font-Size="14"></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <table width="100%" border="1" cellspacing="0" cellpadding="0">
                                        <tr>
                                          <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                         <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                            <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                    </table>
                                </FooterTemplate>
                                <ItemStyle VerticalAlign="Top" />
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                    &nbsp;<br />
                   
                    <br />
                    <asp:Label runat="server" ID="Label18" Text="LINE MESSAGE" Font-Bold="True" Font-Size="14"></asp:Label>
                    <%--<asp:GridView runat="server" ID="gvlinemsg1" AutoGenerateColumns="false" Font-Bold="true"
                        Font-Size="Small" EmptyDataText="<table border='1'><tr><th>SN.</th><th>LOCO NO DATE</th><th>TRAIN NO - SITE - SECTION</th><th>LINE MESSAGE</th><th>LAST SCHEDULE</th><th>ACTION</th></tr><tr><td>1.</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td></tr><tr><td>2.</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td></tr></table>">
                    --%>
                    <table  cellspacing="0" border="1" cellpadding="0" width="990" >
                    <tr >
                    <th style="font-size: 15px">SN.</th>
                    <th style="font-size: 15px" width="150">LOCO
                        <br />
                        NO DATE</th>
                    <th style="font-size: 15px" width="150">TRAIN NO-
                        <br />
                        SITE-
                        <br />
                        SECTION</th>
                    <th style="font-size: 15px">LINE MESSAGE</th>
                    <th style="font-size: 15px" width="150">LAST SCHEDULE</th>
                    
                    
                    </tr>
                    <tr>
                    <td style="font-size: 15px">
                        <br />
                        </td>
                    <td style="font-size: 15px">
                        <br />
                        </td>
                        <td style="font-size: 15px">
                        <br />
                        </td>
                        <td style="font-size: 15px">
                        <br />
                        </td>
                        <td style="font-size: 15px">
                        <br />
                        </td>
                    
                    </tr>
                 
                 <tr>
                    <td style="font-size: 15px">
                        <br />
                        </td>
                    <td style="font-size: 15px">
                        <br />
                        </td>
                        <td style="font-size: 15px">
                        <br />
                        </td>
                        <td style="font-size: 15px">
                        <br />
                        </td>
                        <td style="font-size: 15px">
                        <br />
                        </td>
                    
                    </tr>
                    <tr>
                    <td style="font-size: 15px">
                        <br />
                        </td>
                    <td style="font-size: 15px">
                        <br />
                        </td>
                        <td style="font-size: 15px">
                        <br />
                        </td>
                        <td style="font-size: 15px">
                        <br />
                        </td>
                        <td style="font-size: 15px">
                        <br />
                        </td>
                    
                    </tr>
                    </table>
                    <asp:GridView  runat="server" ID="gvlinemsg1" AutoGenerateColumns="false"
                   EmptyDataText="<table border='0' width='987'><tr><th >SN.</th><th >LOCO NO DATE</th><th >TRAIN NO - SITE - SECTION</th><th  width='300'>LINE MESSAGE</th><th >LAST SCHEDULE</th></tr><tr><td >1.</td><td >&nbsp;</td><td >&nbsp;</td><td >&nbsp;</td><td >&nbsp;</td></tr><tr><td >2.</td><td >&nbsp;</td><td >&nbsp;</td><td >&nbsp;</td><td>&nbsp;</td></tr></table>"  ShowFooter="true" 
                  Font-Size="14" Width="990px"   CellPadding="0" CellSpacing="0" >
                        <Columns>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="SN." Font-Size="medium"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                <asp:Label Text='<%#Container.DataItemIndex + 1 %>' ID="e2" runat="server" Font-Size="14"></asp:Label>  
                                </ItemTemplate>
                                <FooterTemplate>
                                    <table width="100%" border="1" cellspacing="0" cellpadding="0">
                                        <tr>
                                          <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                        <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                          <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                    </table>
                                </FooterTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="LOCO NO DATE" Width="80px" Font-Size="medium"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" Text='<%#Eval("LOCONO") + "-" +  Eval("DATE")%>' ID="Label1"
                                        Font-Size="14"></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <table width="100%" border="1" cellspacing="0" cellpadding="0">
                                        <tr>
                                          <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                       <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                      <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                    </table>
                                </FooterTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="TRAIN NO - SITE - SECTION" Width="140" Font-Size="medium"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" Text='<%#Eval("TRAINNO") + "-" + Eval("SITE") + "-" +  Eval("SECTION")%>'
                                        ID="Label2" Font-Size="14"></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <table width="100%" border="1" cellspacing="0" cellpadding="0">
                                        <tr>
                                           <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                           <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                            <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                    </table>
                                </FooterTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="LINE MESSAGE" Width="80" Font-Size="medium"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" Font-Size="14" Text='<%#Eval("LINE MESSAGE") %>' ID="Label3"></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <table width="300" border="1" cellspacing="0" cellpadding="0">
                                        <tr>
                                            <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                            <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                           <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                    </table>
                                </FooterTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="LAST SCHEDULE" Width="100" Font-Size="medium"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" Text='<%#"DOC" +"-" + Eval("DOC")+ "-" + Eval("LAST SCH")  + "-" + Eval("LAST") %>'
                                        ID="Label5" Font-Size="14"></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <table width="100%" border="1" cellspacing="0" cellpadding="0">
                                        <tr>
                                            <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                          <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                           <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                    </table>
                                </FooterTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="ACTION" Width="40" Font-Size="14"></asp:Label>
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
                                <%--<FooterTemplate>
                                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
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
                                </FooterTemplate>--%>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                    <br />
                    <asp:Label runat="server" ID="lbl3" Text="DEAD ON LINE" Font-Bold="True" Font-Size="14"></asp:Label><br />
                    <asp:GridView runat="server" ID="gvlinemsg2" AutoGenerateColumns="false" 
                      ShowFooter="true"  
                    CellPadding="0" CellSpacing="0"  Font-Size="14" Width="990px" >
                        <Columns>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="SN." Font-Size="medium"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                   <%-- <%#Container.DataItemIndex + 1 %>--%>
                                      <asp:Label runat="server" ID="e1" Text='<%#Container.DataItemIndex + 1 %>' Font-Size="14"></asp:Label>

                                </ItemTemplate>
                                <FooterTemplate>
                                    <table width="100%" border="1" cellspacing="0" cellpadding="0">
                                        <tr>
                                          <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                            <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                          <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                    </table>
                                </FooterTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="LOCO NO" Font-Size="medium"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" Text='<%#Eval("LOCO NO") + "-" +  Eval("DATE")%>' ID="Label1"
                                        Font-Size="14"></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <table width="100%" border="1" cellspacing="0" cellpadding="0">
                                        <tr>
                                            <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                             <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                             <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                    </table>
                                </FooterTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="D/W" Font-Size="medium"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label2" runat="server" Text='<%#Eval("D/W")%>' Font-Size="14"></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <table width="100%" border="1" cellspacing="0" cellpadding="0">
                                        <tr>
                                            <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                              <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                              <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                    </table>
                                </FooterTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="TRAINONO  LOAD" Font-Size="medium"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Labe3" runat="server" Text='<%#Eval("TRNO") + " - " + Eval("LOAD")%>'
                                        Font-Size="14"></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <table width="100%" border="1" cellspacing="0" cellpadding="0">
                                        <tr>
                                              <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                              <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                              <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                    </table>
                                </FooterTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="GRAD" Font-Size="medium"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label4" runat="server" Text='<%#Eval("GRAD")%>' Font-Size="14"></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <table width="100%" border="1" cellspacing="0" cellpadding="0">
                                        <tr>
                                              <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                              <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                              <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                    </table>
                                </FooterTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="REPOTED REASON" Font-Size="medium"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label5" Font-Size="14" runat="server" Text='<%#Eval("REPOTED REASON")%>'></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <table width="100%" border="1" cellspacing="0" cellpadding="0">
                                        <tr>
                                              <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                              <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                              <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                    </table>
                                </FooterTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="LAST SCHEDULE" Font-Size="medium"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label6" runat="server" Text='<%#"DOC -" + Eval("DOC") + Eval("LAST") + Eval("LAST SCHEDULE") %>'
                                      width="177"  Font-Size="14"></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <table width="100%" border="1" cellspacing="0" cellpadding="0">
                                        <tr>
                                              <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                              <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                              <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                    </table>
                                </FooterTemplate>
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
                                <FooterTemplate>
                                    <table width="100%" border="1" cellspacing="0" cellpadding="0">
                                        <tr>
                                              <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                              <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                              <td rowspan="1" colspan="1">
                                                &nbsp;
                                            </td>
                                        </tr>
                                    </table>
                                </FooterTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                    
                  
                    
                    <table cellspacing="1" cellpadding="0" width="990">
                        <tr>
                              <td rowspan="1" colspan="1">
                                &nbsp;
                           </td>
                        </tr>
                        <tr>
                              <td rowspan="1" colspan="1">
                             <br /> 
                             <asp:Label runat="server" ID="lbl10" Font-Bold="True" Text="OVERDUE SCHEDULE LOCO IN THE MONTH OF JANUARY , 2011" Font-Size="15pt"></asp:Label>
                                <asp:DataList runat="server" ID="dl2" RepeatColumns="3" RepeatDirection="Horizontal" 
                          Width="990"    ShowFooter="false" Font-Size="14"   Font-Bold="False" >
                                    <ItemTemplate>
                                        <table border="1" width="100%"  cellpadding="0" cellspacing="0">
                                            <tr>
                                                <td rowspan="0"  colspan="0">
                                                  <asp:Label Text='<%#Eval("Locono")%>'  runat="server" ID="lbl11" Font-Size="14"></asp:Label>  
                                                </td>
                                                <td rowspan="0"  colspan="0">
                                                    <asp:Label runat="server" ID="lbl2" Width="99" Text='<%#Eval("Schedule")%>' Font-Size="14"></asp:Label>
                                                </td>
                                                <td rowspan="0"  colspan="0">
                                                    <asp:Label runat ="server" ID="q11" Font-Size="14" Text='<%#Eval("ScheduleDate")%>'></asp:Label>
                                                   
                                                </td>
                                            </tr>
                                        </table>
                                    </ItemTemplate>
                               <FooterTemplate>
            <table border="0" cellpadding="0" cellspacing="0" width="987">
            <tr>
          <td rowspan="1" colspan="1">
            &nbsp;
            </td>
          <td rowspan="1" colspan="1">
            &nbsp;
            </td>
           <td rowspan="1" colspan="1">
            &nbsp;
            </td>
            <td rowspan="1" colspan="1">
            &nbsp;
            </td>
           <td rowspan="1" colspan="1">
            &nbsp;
            </td>
            <td rowspan="1" colspan="1">
            &nbsp;
            </td>
            </tr>
            <tr>
           <td rowspan="1" colspan="1">
            &nbsp;
            </td>
          <td rowspan="1" colspan="1">
            &nbsp;
            </td>
            <td rowspan="1" colspan="1">
            &nbsp;
            </td>
            <td rowspan="1" colspan="1">
            &nbsp;
            </td>
             <td rowspan="1" colspan="1">
            &nbsp;
            </td>
           <td rowspan="1" colspan="1">
            &nbsp;
            </td>
            </tr>
           <tr>
           <td rowspan="1" colspan="1">
            &nbsp;
            </td>
           <td>
            &nbsp;
            </td>
            <td rowspan="1" colspan="1">
            &nbsp;
            </td>
             <td rowspan="1" colspan="1">
            &nbsp;
            </td>
             <td rowspan="1" colspan="1">
            &nbsp;
            </td>
             <td rowspan="1" colspan="1">
            &nbsp;
            </td>
            </tr>
             </table>
            </FooterTemplate>
                                </asp:DataList>
                                
                                <br />
                                
         <asp:Label runat="server" ID="lbl9" Font-Bold="True" Text="SCHEDULE ARISING IN THE MONTH OF JANUARY , 2011" Font-Size="15pt"></asp:Label>
                                <asp:DataList runat="server" ID="dl1" RepeatColumns="3" RepeatDirection="Horizontal"
                                 Width="990" ShowFooter="false" CellPadding="0" CellSpacing="0"  Font-Size="14" >
                                    <ItemTemplate>
                                        <table border="1" cellpadding="0" width="100%" cellspacing="0" >
                                            <tr>
                                                <td colspan ="0" rowspan="0">
                                                    <asp:Label runat="server"  ID="lbl1"  Text='<%#Eval("Locono")%>' Font-Size="14"></asp:Label>
                                                </td >
                                                <td colspan ="0" rowspan="0">
                                                    <asp:Label runat="server" ID="lbl2" Width="99"  Text='<%#Eval("Schedule")%>' Font-Size="14"></asp:Label>
                                                </td>
                                                <td colspan ="0" rowspan="0">
                                                    <asp:Label runat="server" ID="lbl3"   Text='<%#Eval("ScheduleDate")%>' Font-Size="14"></asp:Label>
                                                </td>
                                            </tr>
                                        </table>
                                    </ItemTemplate>
                                    <FooterTemplate>
            <table border="1" cellpadding="0" cellspacing="0" width="100%">
            <tr>
           <td rowspan="1" colspan="1">
            &nbsp;
            </td>
           <td rowspan="1" colspan="1">
            &nbsp;
            </td>
            <td rowspan="1" colspan="1">
            &nbsp;
            </td>
             <td rowspan="1" colspan="1">
            &nbsp;
            </td>
             <td rowspan="1" colspan="1">
            &nbsp;
            </td>
             <td rowspan="1" colspan="1">
            &nbsp;
            </td>
            </tr>
            <tr>
           <td rowspan="1" colspan="1">
            &nbsp;
            </td>
           <td>
            &nbsp;
            </td>
            <td rowspan="1" colspan="1">
            &nbsp;
            </td>
             <td rowspan="1" colspan="1">
            &nbsp;
            </td>
             <td rowspan="1" colspan="1">
            &nbsp;
            </td>
             <td rowspan="1" colspan="1">
            &nbsp;
            </td>
            </tr>
           <tr>
           <td rowspan="1" colspan="1">
            &nbsp;
            </td>
           <td>
            &nbsp;
            </td>
            <td rowspan="1" colspan="1">
            &nbsp;
            </td>
             <td>
            &nbsp;
            </td>
            <td rowspan="1" colspan="1">
            &nbsp;
            </td>
            <td rowspan="1" colspan="1">
            &nbsp;
            </td>
            </tr>
             </table>
            </FooterTemplate>
                                </asp:DataList>
                                <asp:DataList runat="server" ID="dl1t" RepeatColumns="3" RepeatDirection="Horizontal"
                                 Width="990" ShowFooter="false" CellPadding="0" CellSpacing="0"  Font-Size="14" >
                                    <ItemTemplate>
                                        <table border="1" cellpadding="0" width="100%" cellspacing="0" >
                                            <tr>
                                                <td colspan ="0" rowspan="0">
                                                    <asp:Label runat="server"  ID="lbl1"  Text='<%#Eval("Locono")%>' Font-Size="14"></asp:Label>
                                                </td >
                                                <td colspan ="0" rowspan="0">
                                                    <asp:Label runat="server" ID="lbl2" Width="99"  Text='<%#Eval("Schedule")%>' Font-Size="14"></asp:Label>
                                                </td>
                                                <td colspan ="0" rowspan="0">
                                                    <asp:Label runat="server" ID="lbl3"   Text='<%#Eval("ScheduleDate")%>' Font-Size="14"></asp:Label>
                                                </td>
                                            </tr>
                                        </table>
                                    </ItemTemplate>
                                    <FooterTemplate>
            <table border="1" cellpadding="0" cellspacing="0" width="100%">
            <tr>
           <td rowspan="1" colspan="1">
            &nbsp;
            </td>
           <td rowspan="1" colspan="1">
            &nbsp;
            </td>
            <td rowspan="1" colspan="1">
            &nbsp;
            </td>
             <td rowspan="1" colspan="1">
            &nbsp;
            </td>
             <td rowspan="1" colspan="1">
            &nbsp;
            </td>
             <td rowspan="1" colspan="1">
            &nbsp;
            </td>
            </tr>
            <tr>
           <td rowspan="1" colspan="1">
            &nbsp;
            </td>
           <td>
            &nbsp;
            </td>
            <td rowspan="1" colspan="1">
            &nbsp;
            </td>
             <td rowspan="1" colspan="1">
            &nbsp;
            </td>
             <td rowspan="1" colspan="1">
            &nbsp;
            </td>
             <td rowspan="1" colspan="1">
            &nbsp;
            </td>
            </tr>
           <tr>
           <td rowspan="1" colspan="1">
            &nbsp;
            </td>
           <td>
            &nbsp;
            </td>
            <td rowspan="1" colspan="1">
            &nbsp;
            </td>
             <td>
            &nbsp;
            </td>
            <td rowspan="1" colspan="1">
            &nbsp;
            </td>
            <td rowspan="1" colspan="1">
            &nbsp;
            </td>
            </tr>
             </table>
            </FooterTemplate>
                                </asp:DataList>
                                  <br /> 
                              
                              
                            </td>
                        </tr>
                        <tr>
                            <td> &nbsp;
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
    </table>
    
    
    <asp:Panel runat="server"  ID="Page2" Visible="false" >
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
                            <td valign="top">
                                <table>
                                    <tr>
                                        <th style="font-size: large">
                                            MONTHLY OUTAGE OF WDG4
                                        </th>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:GridView runat="server" ID="gvMonthlyOutage" AutoGenerateColumns="false" 
                                               ShowFooter="false" Font-Size="14"
                    CellPadding="0" CellSpacing="0" OnRowDataBound="gvMonthlyOutage_OnRowDataBound">
                 
                                                <Columns>
                                                    <asp:TemplateField HeaderText="MONTH">
                                                        <ItemTemplate>
                                                            <asp:Label runat="server" ID="lblMonth" Text='<%#Eval("Month")%>'></asp:Label>
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
                                    <tr>
                                    <td>
                                        &nbsp;</td>
                                    </tr>
                                </table>
                            </td>
                            <td>
                                <table width="100%" border="0">
                                    <tr>
                                        <th colspan="50" align="center">
                                            OUTAGE
                                        </th>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table border="1" style="border-style: solid; font-size: medium; width: 626px;" 
                                                cellpadding="0" cellspacing="0">
                                                <tr>
                                                    <td colspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                    </td>
                                                    <td align="center" colspan="2"   style="border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        HOLDING</td>
                                                    <td align="center" colspan="4"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        FOIS</td>
                                                    <td colspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        DEAD</td>
                                                </tr>
                                                <tr>
                                                    <td colspan="1" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                    </td>
                                                    <td colspan="1" rowspan="1" style="  border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        BOOK</td>
                                                    <td colspan="1" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        EFF</td>
                                                    <td colspan="1" rowspan="1" style="  border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        TAR</td>
                                                    <td colspan="1" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        NET</td>
                                                    <td colspan="2" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        CUM</td>
                                                    <td colspan="1" rowspan="2"   style="border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        <asp:Label ID="txtDead1" runat="server" class="t1" Font-Size="14" 
                                                            onBlur="ChangeDefaultStyle(this.id.toString());" 
                                                            onfocus="ChangeStyle(this.id.toString());" Text="0"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td colspan="1" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        BG</td>
                                                    <td colspan="1" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        <asp:Label ID="txtBGHoldingBook" runat="server" class="t1" Font-Size="14" 
                                                            onBlur="ChangeDefaultStyle(this.id.toString());" 
                                                            onfocus="ChangeStyle(this.id.toString());" Text="0"></asp:Label>
                                                    </td>
                                                    <td colspan="1" rowspan="1"   style="border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        <asp:Label ID="txtBGHoldingEff" runat="server" class="t1" Font-Size="14" 
                                                            onBlur="ChangeDefaultStyle(this.id.toString());" 
                                                            onfocus="ChangeStyle(this.id.toString());" Text="0"></asp:Label>
                                                    </td>
                                                    <td colspan="1" rowspan="1"   style="border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        <asp:Label ID="txtTar1" runat="server" class="t1" Font-Size="14" 
                                                            onBlur="ChangeDefaultStyle(this.id.toString());" 
                                                            onfocus="ChangeStyle(this.id.toString());" Text="0"></asp:Label>
                                                    </td>
                                                    <td colspan="1" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        <asp:Label ID="txtNet" runat="server" class="t1" Font-Size="14" 
                                                            onBlur="ChangeDefaultStyle(this.id.toString());" 
                                                            onfocus="ChangeStyle(this.id.toString());" Text="0"></asp:Label>
                                                    </td>
                                                    <td colspan="2" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        <asp:Label ID="txtFois" runat="server" class="t1" Font-Size="14" 
                                                            onBlur="ChangeDefaultStyle(this.id.toString());" 
                                                            onfocus="ChangeStyle(this.id.toString());" Text="0"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td colspan="1" rowspan="1"  style="border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        <asp:Label ID="txtTar" runat="server" class="t1" Font-Size="14" 
                                                            onBlur="ChangeDefaultStyle(this.id.toString());" 
                                                            onfocus="ChangeStyle(this.id.toString());" Text="0" Visible="False"></asp:Label>
                                                    </td>
                                                    <td colspan="1" rowspan="1"  style="border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        <asp:Label runat="server" ID="txtAct" onfocus="ChangeStyle(this.id.toString());"
                                                            onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Text="0" 
                                                            Font-Size="14" Visible="False"></asp:Label></td>
                                                    <td colspan="1" rowspan="1"  style="border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        </td>
                                                    <td colspan="1" rowspan="1" style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        </td>
                                                    <td colspan="1" rowspan="1"  style="border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        </td>
                                                    <td colspan="1" rowspan="1" style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        Tar</td>
                                                    <td colspan="1" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        Act</td>
                                                    <td colspan="1" rowspan="1" style="  border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td colspan="1" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        MG</td>
                                                    <td colspan="1" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        <asp:Label runat="server" ID="txtMGHoldingBook" onfocus="ChangeStyle(this.id.toString());"
                                                            Text="0" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" 
                                                            Font-Size="14"></asp:Label></td>
                                                    <td colspan="1" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        <asp:Label ID="txtMGHoldingEff" runat="server" class="t1" Font-Size="14" 
                                                            onBlur="ChangeDefaultStyle(this.id.toString());" 
                                                            onfocus="ChangeStyle(this.id.toString());" Text="0"></asp:Label>
                                                    </td>
                                                    <td colspan="1" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        <asp:Label ID="txtMGTar1" runat="server" class="t1" Font-Size="14" 
                                                            onBlur="ChangeDefaultStyle(this.id.toString());" 
                                                            onfocus="ChangeStyle(this.id.toString());" Text="0"></asp:Label>
                                                    </td>
                                                    <td colspan="1" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        <asp:Label ID="txtMGNet1" runat="server" class="t1" Font-Size="14" 
                                                            onBlur="ChangeDefaultStyle(this.id.toString());" 
                                                            onfocus="ChangeStyle(this.id.toString());" Text="0"></asp:Label>
                                                    </td>
                                                    <td colspan="1" rowspan="1"   style="border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        <asp:Label ID="txtTar2" runat="server" class="t1" Font-Size="14" 
                                                            onBlur="ChangeDefaultStyle(this.id.toString());" 
                                                            onfocus="ChangeStyle(this.id.toString());" Text="0"></asp:Label>
                                                    </td>
                                                    <td colspan="1" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        <asp:Label ID="txtact2" runat="server" class="t1" Font-Size="14" 
                                                            onBlur="ChangeDefaultStyle(this.id.toString());" 
                                                            onfocus="ChangeStyle(this.id.toString());" Text="0"></asp:Label>
                                                    </td>
                                                    <td colspan="1" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        <asp:Label ID="txtDead2" runat="server" class="t1" Font-Size="14" 
                                                            onBlur="ChangeDefaultStyle(this.id.toString());" 
                                                            onfocus="ChangeStyle(this.id.toString());" Text="0"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td colspan="1" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        </td>
                                                    <td colspan="1" rowspan="1" style="  border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        </td>
                                                    <td colspan="1" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        </td>
                                                    <td colspan="1" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        </td>
                                                    <td colspan="1" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        </td>
                                                    <td colspan="1" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        </td>
                                                    <td colspan="1" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        </td>
                                                    <td colspan="1" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double;">
                                                        </td>
                                                </tr>
                                                <tr>
                                                    <td colspan="1" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                    </td>
                                                    <td colspan="1" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                    </td>
                                                    <td colspan="1" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                    </td>
                                                    <td colspan="2" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                        MG</td>
                                                    <td colspan="1" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                        BG</td>
                                                    <td colspan="1" rowspan="1"  style="border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                    </td>
                                                    <td colspan="1" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td colspan="3" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                        SBI HR</td>
                                                    <td colspan="2" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                        <asp:Label ID="txtsbihrMG" runat="server" class="t1" Font-Size="14" 
                                                            onBlur="ChangeDefaultStyle(this.id.toString());" 
                                                            onfocus="ChangeStyle(this.id.toString());" Text="0.00"></asp:Label>
                                                    </td>
                                                    <td colspan="1" rowspan="1"   style="border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                        <asp:Label ID="txtsbihrBG" runat="server" class="t1" Font-Size="14" 
                                                            onBlur="ChangeDefaultStyle(this.id.toString());" 
                                                            onfocus="ChangeStyle(this.id.toString());" Text="0.00"></asp:Label>
                                                    </td>
                                                    <td colspan="1" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                        </td>
                                                    <td colspan="1" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                        </td>
                                                </tr>
                                                <tr>
                                                    <td colspan="3" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                        SBI LR</td>
                                                    <td colspan="2" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                        <asp:Label ID="txtsbilrMG" runat="server" class="t1" Font-Size="14" onBlur="ChangeDefaultStyle(this.id.toString());"
                                                            onfocus="ChangeStyle(this.id.toString());" Text="0.0"></asp:Label></td>
                                                    <td colspan="1" rowspan="1" style="  border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                        <asp:Label ID="txtsbilrBG" runat="server" class="t1" Font-Size="14" onBlur="ChangeDefaultStyle(this.id.toString());"
                                                            onfocus="ChangeStyle(this.id.toString());" Text="0.00"></asp:Label></td>
                                                    <td colspan="1" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                    </td>
                                                    <td colspan="1" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td colspan="3" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                        SBI UR</td>
                                                    <td colspan="2" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                        <asp:Label ID="txtsbiurMG" runat="server" class="t1" Font-Size="14" onBlur="ChangeDefaultStyle(this.id.toString());"
                                                            onfocus="ChangeStyle(this.id.toString());" Text="0.0"></asp:Label></td>
                                                    <td colspan="1" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                        <asp:Label ID="txtsbiurBG" runat="server" class="t1" Font-Size="14" onBlur="ChangeDefaultStyle(this.id.toString());"
                                                            onfocus="ChangeStyle(this.id.toString());" Text="0.0"></asp:Label></td>
                                                    <td colspan="1" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                    </td>
                                                    <td colspan="1" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td colspan="3" rowspan="1" style="  border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                        DEAD</td>
                                                    <td colspan="2" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                        <asp:Label ID="txtDeadMG" runat="server" class="t1" Font-Size="14" onBlur="ChangeDefaultStyle(this.id.toString());"
                                                            onfocus="ChangeStyle(this.id.toString());" Text="0.00"></asp:Label></td>
                                                    <td colspan="1" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                        <asp:Label ID="txtDeadBG" runat="server" class="t1" Font-Size="14" onBlur="ChangeDefaultStyle(this.id.toString());"
                                                            onfocus="ChangeStyle(this.id.toString());" Text="0.0"></asp:Label></td>
                                                    <td colspan="1" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                    </td>
                                                    <td colspan="1" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td colspan="3" rowspan="1"   style="border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                        Other Div</td>
                                                    <td colspan="2" rowspan="1"   style="border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                        <asp:Label ID="txtOtherDivMG" runat="server" class="t1" Font-Size="14" onBlur="ChangeDefaultStyle(this.id.toString());"
                                                            onfocus="ChangeStyle(this.id.toString());" Text="0.0"></asp:Label></td>
                                                    <td colspan="1" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                        <asp:Label ID="txtOtherDivBG" runat="server" class="t1" Font-Size="14" onBlur="ChangeDefaultStyle(this.id.toString());"
                                                            onfocus="ChangeStyle(this.id.toString());" Text="0.0"></asp:Label></td>
                                                    <td colspan="1" rowspan="1" style="  border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                    </td>
                                                    <td colspan="1" rowspan="1" style="  border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td colspan="3" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                        (-) Lie Over</td>
                                                    <td colspan="2" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                        <asp:Label ID="txtLieOverMG" runat="server" class="t1" Font-Size="14" onBlur="ChangeDefaultStyle(this.id.toString());"
                                                            onfocus="ChangeStyle(this.id.toString());" Text="0.0"></asp:Label></td>
                                                    <td colspan="1" rowspan="1" style="  border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                        <asp:Label ID="txtLieOverBG" runat="server" class="t1" Font-Size="14" onBlur="ChangeDefaultStyle(this.id.toString());"
                                                            onfocus="ChangeStyle(this.id.toString());" Text="0.0"></asp:Label></td>
                                                    <td colspan="1" rowspan="1"   style="border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                    </td>
                                                    <td colspan="1" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td colspan="3" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                        NET</td>
                                                    <td colspan="2" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                        <asp:Label ID="lblNetMG" runat="server" Font-Size="14" Text="..."></asp:Label>
                                                        &nbsp;&nbsp;
                                                        <asp:Label ID="lblNetMGTotal" runat="server" Text="..." Width="10px"></asp:Label>
                                                    </td>
                                                    <td colspan="1" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                        <asp:Label ID="lblNetBG" runat="server" Font-Size="14" Text="..."></asp:Label>
                                                        &nbsp; le</td>
                                                    <td colspan="1" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                        <asp:Label ID="lblNetBGTotal" runat="server" Text="..." Width="55px"></asp:Label>
                                                        Loco</td>
                                                    <td colspan="1" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td colspan="3" rowspan="1"   style="border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                        <img alt="arrow" height="10" src="../Images/Next-icon.png" width="10" /> SR / 
                                                        100 Loco holding</td>
                                                    <td colspan="2" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                        <asp:Label ID="txt1" runat="server" Font-Size="14" Text="0.0" class="t1" 
                                                            onBlur="ChangeDefaultStyle(this.id.toString());" 
                                                            onfocus="ChangeStyle(this.id.toString());"></asp:Label>
                                                        </td>
                                                    <td colspan="1" rowspan="1"  style="border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                        </td>
                                                    <td colspan="1" rowspan="1" style="  border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                        </td>
                                                    <td colspan="1" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td colspan="3" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                        <img alt="arrow" height="10" src="../Images/Next-icon.png" width="10" />
                                                        Avg LOC / 100 EKM</td>
                                                    <td colspan="2" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                        <asp:Label ID="txt2" runat="server" class="t1" Font-Size="14" onBlur="ChangeDefaultStyle(this.id.toString());"
                                                            onfocus="ChangeStyle(this.id.toString());" Text="0.0"></asp:Label>
                                                        <asp:Label ID="Label11" runat="server" class="t1" Font-Size="12" 
                                                            onblur="ChangeDefaultStyle(this.id.toString());" 
                                                            onfocus="ChangeStyle(this.id.toString());" Text="Ltr"></asp:Label>
                                                    </td>
                                                    <td colspan="1" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                    </td>
                                                    <td colspan="1" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                    </td>
                                                    <td colspan="1" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td colspan="3" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                        <img alt="arrow" height="10" src="../Images/Next-icon.png" width="10" />Avg Gear 
                                                        case oil</td>
                                                    <td colspan="2" rowspan="1"   style="border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                        <asp:Label ID="txt3" runat="server" class="t1" Font-Size="14" onBlur="ChangeDefaultStyle(this.id.toString());"
                                                            onfocus="ChangeStyle(this.id.toString());" Text="0.0"></asp:Label>
                                                        <asp:Label ID="Label12" runat="server" Font-Size="12" onblur="ChangeDefaultStyle(this.id.toString());"
                                                            onfocus="ChangeStyle(this.id.toString());" Text="Litters/Loco/month" >
                                                            </asp:Label></td>
                                                    <td colspan="3" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td colspan="3" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                        <img alt="arrow" height="10" src="../Images/Next-icon.png" width="10" />Avg 
                                                        Compressor oil</td>
                                                    <td colspan="2" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                        <asp:Label ID="txt4" runat="server" class="t1" Font-Size="14" onBlur="ChangeDefaultStyle(this.id.toString());"
                                                            onfocus="ChangeStyle(this.id.toString());" Text="0.0"></asp:Label>
                                                        <asp:Label ID="Label13" runat="server" Font-Size="12" onblur="ChangeDefaultStyle(this.id.toString());"
                                                            onfocus="ChangeStyle(this.id.toString());" Text="Litters/Loco/month" 
                                                            ></asp:Label></td>
                                                    <td colspan="3" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td colspan="3" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                        <img alt="arrow" height="10" src="../Images/Next-icon.png" width="10" />Specific 
                                                        Fuel Consumption</td>
                                                    <td colspan="2" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                        <asp:Label ID="txt5" runat="server" class="t1" Font-Size="14" onBlur="ChangeDefaultStyle(this.id.toString());"
                                                            onfocus="ChangeStyle(this.id.toString());" Text="0.0"></asp:Label>
                                                        <asp:Label ID="Label14" runat="server" Font-Size="12" onblur="ChangeDefaultStyle(this.id.toString());"
                                                            onfocus="ChangeStyle(this.id.toString());" Text="Liters/1000 GTKM" 
                                                            ></asp:Label></td>
                                                    <td colspan="3" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td colspan="3" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                        <img alt="arrow" height="10" src="../Images/Next-icon.png" width="10" />Avg 
                                                        Running</td>
                                                    <td colspan="2" rowspan="1" style="  border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                        <asp:Label ID="txt6" runat="server" class="t1" Font-Size="14" onBlur="ChangeDefaultStyle(this.id.toString());"
                                                            onfocus="ChangeStyle(this.id.toString());" Text="0"></asp:Label>
                                                        <asp:Label ID="Label15" runat="server" Font-Size="12" onblur="ChangeDefaultStyle(this.id.toString());"
                                                            onfocus="ChangeStyle(this.id.toString());" Text="Km/Loco/day" 
                                                            ></asp:Label></td>
                                                    <td colspan="3" rowspan="1"  style=" border-top-style: double; border-right-style: double;
                                                        border-left-style: double; border-bottom-style: double">
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
        &nbsp;&nbsp;
        
        <br />
          <asp:Label runat="server" ID="lbl8" Text="OVERDUE SCHEDULE LOCO FOR THE MONTH OF JANUARY 2011 FOR O1"  Font-Bold="True" Font-Size="14"></asp:Label>
        <asp:DataList runat="server" ID="gv5" RepeatColumns="3" RepeatDirection="Horizontal"
                Width="990"     CellPadding="0" CellSpacing="0"    Font-Size="14" ShowFooter="false" >
            <ItemTemplate>
                <table border="1" cellpadding="1"  cellspacing="0" width="100%">
                    <tr>
                          <td rowspan="1" colspan="1">
                            <asp:Label runat="server" ID="lbl1"  Text='<%#Eval("Locono")%>' Font-Size="14"></asp:Label>
                        </td>
                          <td rowspan="1" colspan="1">
                            <asp:Label runat="server" ID="lbl2" Width="99"  Text='<%#Eval("Schedule")%>' Font-Size="14"></asp:Label>
                        </td>
                          <td rowspan="1" colspan="1">
                            <asp:Label runat="server" ID="lbl3"  Text='<%#Eval("ScheduleDate")%>' Font-Size="14"></asp:Label>
                        </td>
                        
                          <%--<td rowspan="1" colspan="1">
                            <asp:Label runat="server" ID="Labele3" Text="" Font-Size="14"></asp:Label>
                        </td>--%>
                    </tr>
                </table>
           
            </ItemTemplate>
            
     <%--<FooterTemplate>
            <table border="1" cellpadding="1" cellspacing="0"  width="990">
            <tr>
            <td rowspan="1" colspan="1">
            &nbsp;
            </td>
             <td rowspan="1" colspan="1">
            &nbsp;
            </td>
             <td rowspan="1" colspan="1">
            &nbsp;
            </td>
             <td rowspan="1" colspan="1">
            &nbsp;
            </td>
            </tr>
            <tr>
            <td rowspan="1" colspan="1">
            &nbsp;
            </td>
             <td rowspan="1" colspan="1">
            &nbsp;
            </td>
             <td rowspan="1" colspan="1">
            &nbsp;
            </td>
             <td rowspan="1" colspan="1">
            &nbsp;
            </td>
            </tr>
           <tr>
            <td rowspan="1" colspan="1">
            &nbsp;
            </td>
             <td rowspan="1" colspan="1">
            &nbsp;
            </td>
             <td rowspan="1" colspan="1">
            &nbsp;
            </td>
             <td rowspan="1" colspan="1">
            &nbsp;
            </td>
            </tr>
             </table>
            </FooterTemplate>--%>
             
             
               </asp:DataList>
       
        <br />
          <asp:Label runat="server" ID="lbl7" Visible="true" Font-Bold="True" Text="SCHEDULE O1 ARISING FOR THE MONTH OF JANUARY , 2011" Font-Size="14"></asp:Label>
        <asp:DataList runat="server" ID="gv4" RepeatColumns="3" RepeatDirection="Horizontal"
       Width="990" ShowFooter="false" CellPadding="0" CellSpacing="0" Font-Size="14">
            <ItemTemplate>
                <table border="1" cellpadding="1" cellspacing="0" width="100%">
                    <tr>
                          <td rowspan="1" colspan="1">
                            <asp:Label runat="server"  ID="lbl1" Text='<%#Eval("Locono")%>' Font-Size="14"></asp:Label>
                        </td>
                          <td rowspan="1" colspan="1">
                            <asp:Label runat="server"  ID="lbl2" Width="99" Text='<%#Eval("Schedule")%>' Font-Size="14"></asp:Label>
                        </td>
                          <td rowspan="1" colspan="1">
                            <asp:Label runat="server" ID="lbl3"  Text='<%#Eval("ScheduleDate")%>' Font-Size="14"></asp:Label>
                        </td>
                    </tr>
                </table>
            
            </ItemTemplate>
            <FooterTemplate>
            <table border="1" cellpadding="1" cellspacing="0"  width="990">
            <tr>
              <td rowspan="1" colspan="1">
            &nbsp;
            </td>
               <td rowspan="1" colspan="1">
            &nbsp;
            </td>
               <td rowspan="1" colspan="1">
            &nbsp;
            </td>
               <td rowspan="1" colspan="1">
            &nbsp;
            </td>
            </tr>
            <tr>
              <td rowspan="1" colspan="1">
            &nbsp;
            </td>
               <td rowspan="1" colspan="1">
            &nbsp;
            </td>
               <td rowspan="1" colspan="1">
            &nbsp;
            </td>
               <td rowspan="1" colspan="1">
            &nbsp;
            </td>
            </tr>
           <tr>
              <td rowspan="1" colspan="1">
            &nbsp;
            </td>
               <td rowspan="1" colspan="1">
            &nbsp;
            </td>
               <td rowspan="1" colspan="1">
            &nbsp;
            </td>
               <td rowspan="1" colspan="1">
            &nbsp;
            </td>
            </tr>
             </table>
            </FooterTemplate>
        </asp:DataList>
        <br />
        
      
        <br />
        
                    <br />            
        <table>
            <tr>
                <td>
                    
                    <asp:Label runat="server" ID="lbl4" Text="EMD LOCOS UNDER TEMPORARY REPAIR"
                        Font-Bold="True" Font-Size="15pt"></asp:Label>
                    <asp:GridView runat="server" ID="TempRepair"  AutoGenerateColumns="false"
                        ShowFooter="true" CellPadding="0" CellSpacing="0" Font-Size="14" Width="990px" >
                        <Columns>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="SN." Font-Size="14"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                  <asp:Label runat="server" Text=' <%#Container.DataItemIndex + 1 %>' Font-Size="14"  ID="ww1"></asp:Label> 
                                </ItemTemplate>
                                <FooterTemplate>
                                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
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
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="LOCO NO" Font-Bold="true" Font-Size="14"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" Text='<%#Eval("locono")%>' ID="Label6" Font-Size="14"></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
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
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="SITE" Font-Size="14"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label1" runat="server" Text='<%#Eval("site")%>' Font-Size="14"></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
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
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="SECTION" Font-Size="14"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label2" runat="server" Text='<%#Eval("section")%>' Font-Size="14"></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
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
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="REASON" Font-Size="14"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label3" runat="server" Text='<%#Eval("reason")%>' Font-Size="14"></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
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
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="REMARKS" Font-Size="14"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label4" runat="server" Text='<%#Eval("remarks")%>' Font-Size="14"></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
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
                            <%--<asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label ID="Label5" runat="server" Text="ACTION" Font-Size="14"></asp:Label>
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
                            </asp:TemplateField>--%>
                        </Columns>
                    </asp:GridView>
                  
                    
                    &nbsp;</td>
            </tr>
            <tr>
            <td>
                &nbsp;</td>
            </tr>
        </table>
    </asp:Panel>
    
    
</asp:Content>
