<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true" CodeFile="ViewShedPositionReport.aspx.cs" Inherits="LocoShedPosition_ViewShedPositionReport" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:ToolkitScriptManager runat="server">
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
                    <asp:Label runat="server" ID="lbl1" Text="EMD LOCOS WDG4 SHED POSITION"
                        Font-Bold="True" Font-Size="Large"></asp:Label><br />
                    <br />
    <asp:GridView ID="gvShed" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:TemplateField>
                <HeaderTemplate>
                    <asp:Label ID="Label1" runat="server" Text="Sn."></asp:Label>
                </HeaderTemplate>
                <ItemTemplate>
                    <%#Container.DataItemIndex +1 %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <HeaderTemplate>
                    <asp:Label ID="Label2" runat="server" Text="LocoNo"></asp:Label>
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:Label ID="Labell2" runat="server" Text='<%#Eval("LocoNo") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <HeaderTemplate>
                    <asp:Label ID="Label3" runat="server" Text="LODate"></asp:Label>
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:Label ID="Labell3" runat="server" Text='<%#Eval("LODate") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <HeaderTemplate>
                    <asp:Label ID="Label4" runat="server" Text="Train"></asp:Label>
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:Label ID="Labell4" runat="server" Text='<%#Eval("Train") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <HeaderTemplate>
                    <asp:Label ID="Label5" runat="server" Text="DueSchedule"></asp:Label>
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:Label ID="Labell5" runat="server" Text='<%#Eval("DueSchedule") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <HeaderTemplate>
                    <asp:Label ID="Label6" runat="server" Text="ShedArrival"></asp:Label>
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:Label ID="Labell6" runat="server" Text='<%#Eval("ADate") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <HeaderTemplate>
                    <asp:Label ID="LabelTime" runat="server" Text="ShedArrival"></asp:Label>
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:Label ID="LabellTime" runat="server" Text='<%#Eval("ATime") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <HeaderTemplate>
                    <asp:Label ID="Label7" runat="server" Text="LOC"></asp:Label>
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:Label ID="Labell7" runat="server" Text='<%#Eval("LOC") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
             <asp:TemplateField>
                <HeaderTemplate>
                    <asp:Label ID="Label8" runat="server" Text="LFR"></asp:Label>
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:Label ID="Labell8" runat="server" Text='<%#Eval("LFR") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
              <asp:TemplateField>
                <HeaderTemplate>
                    <asp:Label ID="Label9" runat="server" Text="PDC"></asp:Label>
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:Label ID="Labell9" runat="server" Text='<%#Eval("PDC") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
              <asp:TemplateField>
                <HeaderTemplate>
                    <asp:Label ID="Label10" runat="server" Text="REL"></asp:Label>
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:Label ID="Labell10" runat="server" Text='<%#Eval("REL") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
              <asp:TemplateField>
                <HeaderTemplate>
                    <asp:Label ID="Label11" runat="server" Text="Remarks"></asp:Label>
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:Label ID="Labell11" runat="server" Text='<%#Eval("Remarks") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
              <asp:TemplateField>
                <HeaderTemplate>
                    <asp:Label ID="Label12" runat="server" Text="Id_ShedPosition_rpt"></asp:Label>
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:Label ID="Labell12" runat="server" Text='<%#Eval("Id_ShedPosition_rpt") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
                    <br />
                    <br />
                    &nbsp;
                    <asp:Label runat="server" ID="lbl2" Text="LINE MESSAGE" Font-Bold="True"
                        Font-Size="Large"></asp:Label><br />
                    <br />
                    <br />
                    <br />
                    <br />
                    &nbsp;<asp:Label runat="server" ID="lbl3" Text="DEAD ON LINE" Font-Bold="True"
        Font-Size="Large"></asp:Label><br />
                    &nbsp;<br />
                    <br /><asp:GridView ID="gvDeadOnLine" runat="server" AutoGenerateColumns="false">
                        <Columns>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label ID="Label1" runat="server" Text="Sn."></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <%#Container.DataItemIndex +1 %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label ID="Label2" runat="server" Text="LocoNo"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Labell2" runat="server" Text='<%#Eval("LocoNo") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label ID="Label3" runat="server" Text="Date"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Labell3" runat="server" Text='<%#Eval("LDate") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label ID="Label4" runat="server" Text="d_or_W"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Labell4" runat="server" Text='<%#Eval("d_or_W") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label ID="Label5" runat="server" Text="TrnoLoad"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Labell5" runat="server" Text='<%#Eval("TrnoLoad") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label ID="Label6" runat="server" Text="Grad"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Labell6" runat="server" Text='<%#Eval("Grad") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label ID="Label7" runat="server" Text="ReportedReason"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Labell7" runat="server" Text='<%#Eval("ReportedReason") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label ID="Label8" runat="server" Text="LastSchedule"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Labell8" runat="server" Text='<%#Eval("LastSchedule") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                    <br />
    <asp:Label runat="server" ID="lbl4" Text="EMD LOCOS UNDER TEMPORARY REPAIR"
        Font-Bold="True" Font-Size="Large"></asp:Label><br />
                    <br />
    

    <asp:GridView ID="gvLineMessage" runat="server" AutoGenerateColumns="false">
    <Columns>
    <asp:TemplateField>
    <HeaderTemplate>
    <asp:Label ID="Label1" runat="server" Text="Sn."  ></asp:Label>
    </HeaderTemplate>
    <ItemTemplate>
    <%#Container.DataItemIndex +1 %>
    </ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField>
    <HeaderTemplate>
    <asp:Label ID="Label2" runat="server" Text="LocoNo"  ></asp:Label>
    </HeaderTemplate>
    <ItemTemplate>
    <asp:Label ID="Labell2" runat="server" Text ='<%#Eval("LocoNo") %>' ></asp:Label>
    </ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField>
    <HeaderTemplate>
    <asp:Label ID="Label3" runat="server" Text="Site"  ></asp:Label>
    </HeaderTemplate>
    <ItemTemplate>
    <asp:Label ID="Labell3" runat="server" Text ='<%#Eval("Site") %>' ></asp:Label>
    </ItemTemplate>
    </asp:TemplateField>
     <asp:TemplateField>
    <HeaderTemplate>
    <asp:Label ID="Label4" runat="server" Text="Section"  ></asp:Label>
    </HeaderTemplate>
    <ItemTemplate>
    <asp:Label ID="Labell4" runat="server" Text ='<%#Eval("Section") %>' ></asp:Label>
    </ItemTemplate>
    </asp:TemplateField>
     <asp:TemplateField>
    <HeaderTemplate>
    <asp:Label ID="Label5" runat="server" Text="Reason"  ></asp:Label>
    </HeaderTemplate>
    <ItemTemplate>
    <asp:Label ID="Labell5" runat="server" Text ='<%#Eval("Reason") %>' ></asp:Label>
    </ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField>
    <HeaderTemplate>
    <asp:Label ID="Label6" runat="server" Text="Remarks"  ></asp:Label>
    </HeaderTemplate>
    <ItemTemplate>
    <asp:Label ID="Labell6" runat="server" Text ='<%#Eval("Remarks") %>' ></asp:Label>
    </ItemTemplate>
    </asp:TemplateField>
    </Columns>
    
    </asp:GridView>
                    <br />
                    &nbsp;
                    <table cellspacing="0" cellpadding="0" width="100%">
                        <tr>
                            <th>
                                &nbsp;
                            </th>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" ID="lbl9" Font-Bold="True" Font-Size="Large"></asp:Label>
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
                                <asp:Label runat="server" ID="lbl10" Font-Bold="True" Font-Size="Large"></asp:Label>
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
                <asp:Panel runat="server" id="Page2">
                <table>
                <tr>
                <td><asp:ImageButton runat="server" ID="ImageButton1" ImageUrl="~/Images/printer_icon.jpg"
                                Height="20px" Width="20px" OnClick="ImageButton1_Click" /></td>
                </tr>
                <tr>
                <td>
                <table width="100%" border="1">
                    <tr>
                        <th colspan="50" align="center">
                            OUTAGE
                        </th>
                    </tr>
                    <tr>
                        <td>
                            <table border="1" style="font-size: medium; width: 593px; border-top-style: solid; border-right-style: solid; border-left-style: solid; border-bottom-style: solid;" cellpadding="0" cellspacing="0">
                                <tr>
                                    <td  border-top-style: double; border-right-style: double; border-left-style: double; border-bottom-style: double">
                                    </td>
                                    <td colspan="3" align="center"  border-top-style: double; border-right-style: double; border-left-style: double; border-bottom-style: double;">
                                        HOLDING
                                    </td>
                                    <td rowspan="2"  border-top-style: double; border-right-style: double; border-left-style: double; border-bottom-style: double;">
                                        TAR
                                    </td>
                                    <td rowspan="2"  border-top-style: double; border-right-style: double; border-left-style: double; border-bottom-style: double;">
                                        NET
                                    </td>
                                    <td colspan="2"  border-top-style: double; border-right-style: double; border-left-style: double; border-bottom-style: double;">
                                        CUM
                                    </td>
                                    <td  border-top-style: double; border-right-style: double; border-left-style: double; border-bottom-style: double;">
                                        DEAD
                                    </td>
                                </tr>
                                <tr>
                                    <td  border-top-style: double; border-right-style: double; border-left-style: double; border-bottom-style: double">
                                    </td>
                                    <td  border-top-style: double; border-right-style: double; border-left-style: double; border-bottom-style: double;">
                                        BOOK
                                    </td>
                                    <td  border-top-style: double; border-right-style: double; border-left-style: double; border-bottom-style: double;">
                                        EFF
                                    </td>
                                    <td  border-top-style: double; border-right-style: double; border-left-style: double; border-bottom-style: double;">
                                        TAR
                                    </td>
                                    <td  border-top-style: double; border-right-style: double; border-left-style: double; border-bottom-style: double;">
                                        ACT
                                    </td>
                                </tr>
                                <tr>
                                    <td  border-top-style: double; border-right-style: double; border-left-style: double; border-bottom-style: double;">
                                        BG
                                    </td>
                                    <td  border-top-style: double; border-right-style: double; border-left-style: double; border-bottom-style: double">
                                        <asp:Label runat="server" ID="txtBGHoldingBook" onfocus="ChangeStyle(this.id.toString());"
                                            onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Text="0"
                                            Font-Size="Large"></asp:Label>
                                    </td>
                                    <td style="font-weight: bold; border-top-style: double; border-right-style: double; border-left-style: double; border-bottom-style: double">
                                        <asp:Label runat="server" Text="0" ID="txtBGHoldingEff" onfocus="ChangeStyle(this.id.toString());"
                                            onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Font-Size="Large"></asp:Label>
                                    </td>
                                    <td style="font-weight: bold; border-top-style: double; border-right-style: double; border-left-style: double; border-bottom-style: double">
                                        <asp:Label runat="server" ID="txtTar1" onfocus="ChangeStyle(this.id.toString());"
                                            onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Text="0"
                                            Font-Size="Large"></asp:Label>
                                    </td>
                                    <td style="font-weight: bold; border-top-style: double; border-right-style: double; border-left-style: double; border-bottom-style: double">
                                        <asp:Label runat="server" ID="txtNet" onfocus="ChangeStyle(this.id.toString());"
                                            Text="0" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Font-Size="Large"></asp:Label>
                                    </td>
                                    <td style="font-weight: bold; border-top-style: double; border-right-style: double; border-left-style: double; border-bottom-style: double">
                                        <asp:Label runat="server" ID="txtTar" onfocus="ChangeStyle(this.id.toString());"
                                            Text="0" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Font-Size="Large"></asp:Label>
                                    </td>
                                    <td style="font-weight: bold; border-top-style: double; border-right-style: double; border-left-style: double; border-bottom-style: double">
                                        <asp:Label runat="server" ID="txtAct" onfocus="ChangeStyle(this.id.toString());"
                                            Text="0" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Font-Size="Large"></asp:Label>
                                    </td>
                                    <td style="font-weight: bold; border-top-style: double; border-right-style: double; border-left-style: double; border-bottom-style: double">
                                        <asp:Label runat="server" ID="txtDead1" onfocus="ChangeStyle(this.id.toString());"
                                            Text="0" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Font-Size="Large"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="font-weight: bold; border-top-style: double; border-right-style: double; border-left-style: double; border-bottom-style: double;">
                                        MG
                                    </td>
                                    <td style="font-weight: bold; border-top-style: double; border-right-style: double; border-left-style: double; border-bottom-style: double">
                                        <asp:Label runat="server" Text="0" ID="txtMGHoldingBook" onfocus="ChangeStyle(this.id.toString());"
                                            onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Font-Size="Large"></asp:Label>
                                    </td>
                                    <td style="font-weight: bold; border-top-style: double; border-right-style: double; border-left-style: double; border-bottom-style: double">
                                        <asp:Label runat="server" Text="0" ID="txtMGHoldingEff" onfocus="ChangeStyle(this.id.toString());"
                                            onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Font-Size="Large"></asp:Label>
                                    </td>
                                    <td style="font-weight: bold; border-top-style: double; border-right-style: double; border-left-style: double; border-bottom-style: double">
                                        <asp:Label runat="server" ID="txtMGTar1" onfocus="ChangeStyle(this.id.toString());"
                                            onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Text="0" Font-Size="Large"></asp:Label>
                                    </td>
                                    <td style="font-weight: bold; border-top-style: double; border-right-style: double; border-left-style: double; border-bottom-style: double">
                                        <asp:Label runat="server" ID="txtMGNet1" onfocus="ChangeStyle(this.id.toString());"
                                            Text="0" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Font-Size="Large"></asp:Label>
                                    </td>
                                    <td style="font-weight: bold; border-top-style: double; border-right-style: double; border-left-style: double; border-bottom-style: double">
                                        <asp:Label runat="server" ID="txtTar2" onfocus="ChangeStyle(this.id.toString());"
                                            Text="0" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Font-Size="Large"></asp:Label>
                                    </td>
                                    <td style="font-weight: bold; border-top-style: double; border-right-style: double; border-left-style: double; border-bottom-style: double">
                                        <asp:Label runat="server" ID="txtact2" onfocus="ChangeStyle(this.id.toString());"
                                            Text="0" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Font-Size="Large"></asp:Label>
                                    </td>
                                    <td style="font-weight: bold; border-top-style: double; border-right-style: double; border-left-style: double; border-bottom-style: double">
                                        <asp:Label runat="server" ID="txtDead2" onfocus="ChangeStyle(this.id.toString());"
                                            Text="0" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Font-Size="Large"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="font-weight: bold; border-top-style: double; border-right-style: double; border-left-style: double; border-bottom-style: double;">
                                        FOIS
                                    </td>
                                    <td style="font-weight: bold; border-top-style: double; border-right-style: double; border-left-style: double; border-bottom-style: double">
                                        <asp:Label runat="server" ID="txtFois" onfocus="ChangeStyle(this.id.toString());"
                                            Text="0" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Font-Size="Large"></asp:Label>
                                    </td>
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
                            <td style="font-size: large; border-top-style: solid; border-right-style: solid; border-left-style: solid; border-bottom-style: solid;">
                            </td>
                            <td style="font-size: large; border-top-style: solid; border-right-style: solid; border-left-style: solid; border-bottom-style: solid">
                            </td>
                            <td align="center" style="font-size: large; border-top-style: solid; border-right-style: solid; border-left-style: solid; border-bottom-style: solid">
                                <b>MG</b>
                            </td>
                            <td align="center" style="font-size: large; border-top-style: solid; border-right-style: solid; border-left-style: solid; border-bottom-style: solid">
                                <b>BG </b>
                            </td>
                        </tr>
                        <tr>
                            <td style="font-size: large; border-top-style: solid; border-right-style: solid; border-left-style: solid; border-bottom-style: solid;">
                                SBI HR
                            </td>
                            <td style="font-size: large; border-top-style: solid; border-right-style: solid; border-left-style: solid; border-bottom-style: solid">
                                :
                            </td>
                            <td align="left" style="font-size: large; border-top-style: solid; border-right-style: solid; border-left-style: solid; border-bottom-style: solid">
                                <asp:Label ID="txtsbihrMG" runat="server" class="t1" Font-Size="Large" onBlur="ChangeDefaultStyle(this.id.toString());"
                                    onfocus="ChangeStyle(this.id.toString());" Text="48.00"></asp:Label>
                            </td>
                            <td style="font-size: large; border-top-style: solid; border-right-style: solid; border-left-style: solid; border-bottom-style: solid">
                                <asp:Label ID="txtsbihrBG" runat="server" class="t1" Font-Size="Large" onBlur="ChangeDefaultStyle(this.id.toString());"
                                    onfocus="ChangeStyle(this.id.toString());" Text="48.00"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td style="font-size: large; border-top-style: solid; border-right-style: solid; border-left-style: solid; border-bottom-style: solid;">
                                SBI LR
                            </td>
                            <td style="font-size: large; border-top-style: solid; border-right-style: solid; border-left-style: solid; border-bottom-style: solid">
                                :
                            </td>
                            <td align="left" style="font-size: large; border-top-style: solid; border-right-style: solid; border-left-style: solid; border-bottom-style: solid">
                                <asp:Label ID="txtsbilrMG" runat="server" class="t1" Font-Size="Large" onBlur="ChangeDefaultStyle(this.id.toString());"
                                    onfocus="ChangeStyle(this.id.toString());" Text="6.30"></asp:Label>
                            </td>
                            <td style="font-size: large; border-top-style: solid; border-right-style: solid; border-left-style: solid; border-bottom-style: solid">
                                <asp:Label ID="txtsbilrBG" runat="server" class="t1" Font-Size="Large" onBlur="ChangeDefaultStyle(this.id.toString());"
                                    onfocus="ChangeStyle(this.id.toString());" Text="22.00"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td style="font-size: large; border-top-style: solid; border-right-style: solid; border-left-style: solid; border-bottom-style: solid;">
                                SBI UR
                            </td>
                            <td style="font-size: large; border-top-style: solid; border-right-style: solid; border-left-style: solid; border-bottom-style: solid;">
                                :
                            </td>
                            <td align="left" style="font-size: large; border-top-style: solid; border-right-style: solid; border-left-style: solid; border-bottom-style: solid;">
                                <asp:Label ID="txtsbiurMG" runat="server" class="t1" Font-Size="Large" onBlur="ChangeDefaultStyle(this.id.toString());"
                                    onfocus="ChangeStyle(this.id.toString());" Text="48.10"></asp:Label>
                            </td>
                            <td style="font-size: large; border-top-style: solid; border-right-style: solid; border-left-style: solid; border-bottom-style: solid;">
                                <asp:Label ID="txtsbiurBG" runat="server" class="t1" Font-Size="Large" onBlur="ChangeDefaultStyle(this.id.toString());"
                                    onfocus="ChangeStyle(this.id.toString());" Text="0.0"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td style="font-size: large; border-top-style: solid; border-right-style: solid; border-left-style: solid; border-bottom-style: solid;">
                                DEAD
                            </td>
                            <td style="font-size: large; border-top-style: solid; border-right-style: solid; border-left-style: solid; border-bottom-style: solid">
                                :
                            </td>
                            <td align="left" style="font-size: large; border-top-style: solid; border-right-style: solid; border-left-style: solid; border-bottom-style: solid">
                                <asp:Label ID="txtDeadMG" runat="server" class="t1" Font-Size="Large" onBlur="ChangeDefaultStyle(this.id.toString());"
                                    onfocus="ChangeStyle(this.id.toString());" Text="5.05"></asp:Label>
                            </td>
                            <td style="font-size: large; border-top-style: solid; border-right-style: solid; border-left-style: solid; border-bottom-style: solid">
                                <asp:Label ID="txtDeadBG" runat="server" class="t1" Font-Size="Large" onBlur="ChangeDefaultStyle(this.id.toString());"
                                    onfocus="ChangeStyle(this.id.toString());" Text="6.5"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td style="font-size: large; border-top-style: solid; border-right-style: solid; border-left-style: solid; border-bottom-style: solid;">
                                Other Div
                            </td>
                            <td style="font-size: large; border-top-style: solid; border-right-style: solid; border-left-style: solid; border-bottom-style: solid">
                                :
                            </td>
                            <td align="left" style="font-size: large; border-top-style: solid; border-right-style: solid; border-left-style: solid; border-bottom-style: solid">
                                <asp:Label ID="txtOtherDivMG" runat="server" class="t1" Font-Size="Large" onBlur="ChangeDefaultStyle(this.id.toString());"
                                    onfocus="ChangeStyle(this.id.toString());" Text="45.10"></asp:Label>
                            </td>
                            <td style="font-size: large; border-top-style: solid; border-right-style: solid; border-left-style: solid; border-bottom-style: solid">
                                <asp:Label ID="txtOtherDivBG" runat="server" class="t1" Font-Size="Large" onBlur="ChangeDefaultStyle(this.id.toString());"
                                    onfocus="ChangeStyle(this.id.toString());" Text="0.0"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td style="font-size: large; border-top-style: solid; border-right-style: solid; border-left-style: solid; border-bottom-style: solid;">
                                (-) Lie Over
                            </td>
                            <td style="font-size: large; border-top-style: solid; border-right-style: solid; border-left-style: solid; border-bottom-style: solid">
                                :
                            </td>
                            <td align="left" style="font-size: large; border-top-style: solid; border-right-style: solid; border-left-style: solid; border-bottom-style: solid">
                                <asp:Label ID="txtLieOverMG" runat="server" class="t1" Font-Size="Large" onBlur="ChangeDefaultStyle(this.id.toString());"
                                    onfocus="ChangeStyle(this.id.toString());" Text="45.30"></asp:Label>
                            </td>
                            <td style="font-size: large; border-top-style: solid; border-right-style: solid; border-left-style: solid; border-bottom-style: solid">
                                <asp:Label ID="txtLieOverBG" runat="server" class="t1" Font-Size="Large" onBlur="ChangeDefaultStyle(this.id.toString());"
                                    onfocus="ChangeStyle(this.id.toString());" Text="65.30"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td style="font-size: large; border-top-style: solid; border-right-style: solid; border-left-style: solid; border-bottom-style: solid;">
                                NET
                            </td>
                            <td style="font-size: large; border-top-style: solid; border-right-style: solid; border-left-style: solid; border-bottom-style: solid">
                                :
                            </td>
                            <td align="left" style="font-size: large; border-top-style: solid; border-right-style: solid; border-left-style: solid; border-bottom-style: solid">
                                <asp:Label ID="lblNetMG" runat="server" Font-Size="Large" Text="..."></asp:Label>
                            </td>
                            <td style="font-size: large; border-top-style: solid; border-right-style: solid; border-left-style: solid; border-bottom-style: solid">
                                <asp:Label ID="lblNetBG" runat="server" Font-Size="Large" Text="..."></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td style="font-size: large; border-top-style: solid; border-right-style: solid; border-left-style: solid; border-bottom-style: solid;">
                                <img alt="arrow" height="10" src="../Images/Next-icon.png" width="10" />
                                SR / 100 LOCO HOLDING
                            </td>
                            <td style="font-size: large; border-top-style: solid; border-right-style: solid; border-left-style: solid; border-bottom-style: solid">
                                :
                            </td>
                            <td style="font-size: large; border-top-style: solid; border-right-style: solid; border-left-style: solid; border-bottom-style: solid">
                                <asp:Label ID="txt1" runat="server" class="t1" Font-Size="Large" onBlur="ChangeDefaultStyle(this.id.toString());"
                                    onfocus="ChangeStyle(this.id.toString());" Text="41.27"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td style="font-size: large; border-top-style: solid; border-right-style: solid; border-left-style: solid; border-bottom-style: solid;">
                                <img alt="arrow" height="10" src="../Images/Next-icon.png" width="10" />
                                AVERAGE LOC / 100 EKM
                            </td>
                            <td style="font-size: large; border-top-style: solid; border-right-style: solid; border-left-style: solid; border-bottom-style: solid">
                                :
                            </td>
                            <td style="font-size: large; border-top-style: solid; border-right-style: solid; border-left-style: solid; border-bottom-style: solid">
                                <asp:Label ID="txt2" runat="server" class="t1" Font-Size="Large" onBlur="ChangeDefaultStyle(this.id.toString());"
                                    onfocus="ChangeStyle(this.id.toString());" Text="3.36"></asp:Label>
                                <asp:Label ID="Label11" runat="server" class="t1" Font-Size="Large" onblur="ChangeDefaultStyle(this.id.toString());"
                                    onfocus="ChangeStyle(this.id.toString());" Text="Ltr"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td style="font-size: large; border-top-style: solid; border-right-style: solid; border-left-style: solid; border-bottom-style: solid;">
                                <img alt="arrow" height="10" src="../Images/Next-icon.png" width="10" />AVERAGE
                                GEAR CASE OIL
                            </td>
                            <td style="font-size: large; border-top-style: solid; border-right-style: solid; border-left-style: solid; border-bottom-style: solid">
                                :
                            </td>
                            <td style="font-size: large; border-top-style: solid; border-right-style: solid; border-left-style: solid; border-bottom-style: solid">
                                <asp:Label ID="txt3" runat="server" class="t1" Font-Size="Large" onBlur="ChangeDefaultStyle(this.id.toString());"
                                    onfocus="ChangeStyle(this.id.toString());" Text="4.86"></asp:Label>
                                <asp:Label ID="Label12" runat="server" Font-Size="Large" onblur="ChangeDefaultStyle(this.id.toString());"
                                    onfocus="ChangeStyle(this.id.toString());" Text="Litters/Loco/month"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td style="font-size: large; border-top-style: solid; border-right-style: solid; border-left-style: solid; border-bottom-style: solid;">
                                <img alt="arrow" height="10" src="../Images/Next-icon.png" width="10" />AVERAGE
                                COMPRESSOR OIL
                            </td>
                            <td style="font-size: large; border-top-style: solid; border-right-style: solid; border-left-style: solid; border-bottom-style: solid">
                                :
                            </td>
                            <td style="font-size: large; border-top-style: solid; border-right-style: solid; border-left-style: solid; border-bottom-style: solid">
                                <asp:Label ID="txt4" runat="server" class="t1" Font-Size="Large" onBlur="ChangeDefaultStyle(this.id.toString());"
                                    onfocus="ChangeStyle(this.id.toString());" Text="0.559"></asp:Label>
                                <asp:Label ID="Label13" runat="server" Font-Size="Large" onblur="ChangeDefaultStyle(this.id.toString());"
                                    onfocus="ChangeStyle(this.id.toString());" Text="Litters/Loco/month"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td style="font-size: large; border-top-style: solid; border-right-style: solid; border-left-style: solid; border-bottom-style: solid;">
                                <img alt="arrow" height="10" src="../Images/Next-icon.png" width="10" />AVERAGE
                                SPECIFIC FUEL CONSUMPTION
                            </td>
                            <td style="font-size: large; border-top-style: solid; border-right-style: solid; border-left-style: solid; border-bottom-style: solid">
                                :
                            </td>
                            <td style="font-size: large; border-top-style: solid; border-right-style: solid; border-left-style: solid; border-bottom-style: solid">
                                <asp:Label ID="txt5" runat="server" class="t1" Font-Size="Large" onBlur="ChangeDefaultStyle(this.id.toString());"
                                    onfocus="ChangeStyle(this.id.toString());" Text="2.07"></asp:Label>
                                <asp:Label ID="Label14" runat="server" Font-Size="Large" onblur="ChangeDefaultStyle(this.id.toString());"
                                    onfocus="ChangeStyle(this.id.toString());" Text="Liters/1000 GTKM"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td style="font-size: large; border-top-style: solid; border-right-style: solid; border-left-style: solid; border-bottom-style: solid;">
                                <img alt="arrow" height="10" src="../Images/Next-icon.png" width="10" />AVERAGE
                                RUNNING
                            </td>
                            <td style="font-size: large; border-top-style: solid; border-right-style: solid; border-left-style: solid; border-bottom-style: solid">
                                :
                            </td>
                            <td style="font-size: large; border-top-style: solid; border-right-style: solid; border-left-style: solid; border-bottom-style: solid">
                                <asp:Label ID="txt6" runat="server" class="t1" Font-Size="Large" onBlur="ChangeDefaultStyle(this.id.toString());"
                                    onfocus="ChangeStyle(this.id.toString());" Text="373"></asp:Label>
                                <asp:Label ID="Label15" runat="server" Font-Size="Large" onblur="ChangeDefaultStyle(this.id.toString());"
                                    onfocus="ChangeStyle(this.id.toString());" Text="Km/Loco/day"></asp:Label>
                            </td>
                        </tr>
                    </table>
                    
        </tr>
    </table>
    <table>
        <tr>
            <th style="font-size: large">
                MONTHLY OUTAGE OF WDG4
            </th>
        </tr>
        <tr>
            <td>
                <asp:GridView runat="server" ID="gvMonthlyOutage" AutoGenerateColumns="false" Font-Size="Large">
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
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
    </table>
    
    <asp:Label runat="server" ID="lbl5" Text="LOCO MOVEMENTS" Font-Bold="True"
        Font-Size="Large"></asp:Label>
    <asp:Label runat="server" ID="lbl6" Font-Bold="True" Font-Size="Large"></asp:Label>
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
    <asp:Label runat="server" ID="lbl7" Font-Bold="True" Font-Size="Large"></asp:Label>
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
    <asp:Label runat="server" ID="lbl8" Font-Bold="True" Font-Size="Large"></asp:Label>
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
    </asp:Panel>
    &nbsp;&nbsp;<br />
    <br />
    
    <br />
    <br />
</asp:Content>

