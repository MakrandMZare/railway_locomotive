<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true" CodeFile="MG_ShedPositionReport.aspx.cs" Inherits="LocoShedPosition_MG_ShedPositionReport" Title="Untitled Page" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </asp:ToolkitScriptManager>
    <table align="center">
        <tr>
            <th>
                <asp:Label runat="server" ID="l1" Text="MG [METER GUAGE] SHED POSITION" Font-Size="XX-Small"></asp:Label>
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
                    <asp:Label runat="server" ID="lbl1" Visible="false" Text="MG LOCO SHED POSITION"
                        Font-Bold="true"></asp:Label>
                    <asp:GridView runat="server" ID="gvshed" AutoGenerateColumns="false" 
                        Width="800px" onselectedindexchanged="gvshed_SelectedIndexChanged">
                        <Columns>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="SN." Width="15px" Font-Size="XX-Small"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <%#Container.DataItemIndex + 1 %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="LOCO NO." Width="50px" Font-Size="XX-Small"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" Text='<%#Eval("LOCO NO")%>' ID="Label1"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="WHEEL DIAMETER" Width="80px" Font-Size="XX-Small"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label2" runat="server" Text='<%#Eval("WHEEL DIAMETER")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="PASS" Width="40px" Font-Size="XX-Small"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Labe3" runat="server" Text='<%#Eval("PASS")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="TRAIN" Width="40px" Font-Size="XX-Small"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Labe3" runat="server" Text='<%#Eval("TRAIN")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="DUE SCHEDULE" Width="80px" Font-Size="XX-Small"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label4" runat="server" Text='<%#Eval("DUE SCHEDULE")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="SHED ARRIVAL [DATE] - [TIME]" Width="100px"
                                        Font-Size="XX-Small"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label6" runat="server" Text='<%#Eval("DATE") + " : "%>'></asp:Label>
                                    <asp:Label ID="Label5" runat="server" Text='<%#Eval("TIME")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="PDC" Width="30px" Font-Size="XX-Small"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label9" runat="server" Text='<%#Eval("PDC") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="REL" Width="30px" Font-Size="XX-Small"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label10" runat="server" Text=''></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="REMARKS" Width="180px" Font-Size="XX-Small"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label9" runat="server" Text='<%#Eval("REMARKS")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                    <%--<asp:Label runat="server" ID="lbl2" Visible="false" Text="LINE MESSAGE" Font-Bold="true"></asp:Label><br />
                    <asp:GridView runat="server" ID="gvlinemsg1" AutoGenerateColumns="false" Width="800px">
                        <Columns>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="SN." Width="15px" Font-Size="XX-Small"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <%#Container.DataItemIndex + 1 %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="LOCO NO DATE" Width="80px" Font-Size="XX-Small"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" Text='<%#Eval("LOCO NO") + "-" +  Eval("DATE")%>' ID="Label1"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="TRAIN NO - SITE - SECTION" Width="140" Font-Size="XX-Small"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" Text='<%#Eval("TRAIN NO") + "-" + Eval("SITE") + "-" +  Eval("SECTION")%>'
                                        ID="Label2"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="LINE MESSAGE" Width="80" Font-Size="XX-Small"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" Text='<%#Eval("LINE MESSAGE") %>' ID="Label3"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="LAST SCHEDULE" Width="100" Font-Size="XX-Small"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" Text='<%#"DOC" +"-" + Eval("DOC")+ "-" + Eval("LAST SCH")  + "-" + Eval("LAST") %>'
                                        ID="Label5"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="ACTION" Width="40" Font-Size="XX-Small"></asp:Label>
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
                                                    ID="lbtnDelete" PostBackUrl='<%# "~/LocoShedPosition/View_shedposition.aspx?id=" + Eval("tid") %>' />
                                            </td>
                                        </tr>
                                    </table>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                    <asp:Label runat="server" ID="lbl3" Visible="false" Text="REPORTED REASON" Font-Bold="true"></asp:Label><br />
                    <asp:GridView runat="server" ID="gvlinemsg2" AutoGenerateColumns="false" Width="800px">
                        <Columns>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="SN." Width="15" Font-Size="XX-Small"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <%#Container.DataItemIndex + 1 %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="LOCO NO" Width="50" Font-Size="XX-Small"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" Text='<%#Eval("LOCO NO") + "-" +  Eval("DATE")%>' ID="Label1"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="D/W" Width="30" Font-Size="XX-Small"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label2" runat="server" Text='<%#Eval("D/W")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="TRAINONO - LOAD" Width="100" Font-Size="XX-Small"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Labe3" runat="server" Text='<%#Eval("TRNO") + " - " + Eval("LOAD")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="GRAD" Width="40" Font-Size="XX-Small"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label4" runat="server" Text='<%#Eval("GRAD")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="REPOTED REASON" Width="100" Font-Size="XX-Small"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label5" runat="server" Text='<%#Eval("REPOTED REASON")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="LAST SCHEDULE" Width="100" Font-Size="XX-Small"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label6" runat="server" Text='<%#"DOC -" + Eval("DOC") + Eval("LAST") + Eval("LAST SCH") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label ID="Label7" runat="server" Width="40" Font-Size="XX-Small" Text="ACTION"></asp:Label>
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
                                                    ID="lbtnDelete" PostBackUrl='<%# "~/LocoShedPosition/View_LineMessage2.aspx?id=" + Eval("rid") %>' />
                                            </td>
                                        </tr>
                                    </table>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                    <asp:Label runat="server" ID="lbl4" Visible="false" Text="EMD LOCOS UNDER TEMPORARY REPAIR"
                        Font-Bold="true"></asp:Label>
                    <asp:GridView runat="server" ID="TempRepair" AutoGenerateColumns="false" Width="800px">
                        <Columns>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="SN." Width="15" Font-Size="XX-Small"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <%#Container.DataItemIndex + 1 %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="LOCO NO" Width="50" Font-Size="XX-Small"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" Text='<%#Eval("locono")%>' ID="Label6"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="SITE" Width="50" Font-Size="XX-Small"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label1" runat="server" Text='<%#Eval("site")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="SECTION" Width="50" Font-Size="XX-Small"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label2" runat="server" Text='<%#Eval("section")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="REASON" Width="50" Font-Size="XX-Small"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label3" runat="server" Text='<%#Eval("reason")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="REMARKS" Width="50" Font-Size="XX-Small"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label4" runat="server" Text='<%#Eval("remarks")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label ID="Label5" runat="server" Text="ACTION" Width="40" Font-Size="XX-Small"></asp:Label>
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
                                                    ID="lbtnDelete" PostBackUrl='<%# "~/LocoShedPosition/View_TemporaryRepair.aspx?id=" + Eval("rid") %>' />
                                            </td>
                                        </tr>
                                    </table>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                    <asp:Label runat="server" ID="lbl5" Visible="false" Text="LOCO MOVEMENTS" Font-Bold="true"></asp:Label>
                    <asp:GridView runat="server" ID="gvLocoMovements" AutoGenerateColumns="false" Width="800px">
                        <Columns>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="SN." Width="50" Font-Size="XX-Small"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <%#Container.DataItemIndex + 1 %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="LOCO NO." Width="50" Font-Size="XX-Small"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="Label1" Text='<%#Eval("LOCO NO")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="DATE OF ARRIVAL" Width="50" Font-Size="XX-Small"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="Label2" Text='<%#Eval("DATE OF ARRIVAL")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="DOC" Width="50" Font-Size="XX-Small"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="Label3" Text='<%#Eval("DOC")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="LAST OUT" Width="50" Font-Size="XX-Small"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="Label11" Text='<%#Eval("LAST OUT")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="LAST SCHEDULE" Width="50" Font-Size="XX-Small"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="Label4" Text='<%#Eval("LAST SCH")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="REPAIR ATTENDED" Width="50" Font-Size="XX-Small"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="Label5" Text='<%#Eval("REPAIR ATTENDED")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="DIV" Width="50" Font-Size="XX-Small"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="Label6" Text='<%#Eval("DIV")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="SITE" Width="50" Font-Size="XX-Small"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="Label7" Text='<%#Eval("SITE")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="SECTION" Width="50" Font-Size="XX-Small"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="Label8" Text='<%#Eval("SECTION")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" ID="l1" Text="REMARKS" Width="50" Font-Size="XX-Small"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="Label9" Text='<%#Eval("REMARKS")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label ID="Label10" runat="server" Width="40px" Font-Size="XX-Small" Text="ACTION"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <table>
                                        <tr>
                                            <td>
                                                <asp:ImageButton runat="server" Width="10px" ImageUrl="~/Images/Edit-icon.png" ID="lbtnUpdate"
                                                    PostBackUrl='<%# "~/LocoShedPosition/Loco_Movement.aspx?id=" + Eval("tid") %>' />
                                            </td>
                                            <td>
                                                <asp:ImageButton runat="server" Width="10px" ImageUrl="~/Images/Delete-icon.png"
                                                    ID="lbtnDelete" PostBackUrl='<%# "~/LocoShedPosition/View_LocoMovements.aspx?id=" + Eval("tid") %>' />
                                            </td>
                                        </tr>
                                    </table>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                    <asp:Label runat="server" ID="lbl6" Visible="false" Text="" Font-Bold="true"></asp:Label>
                    <asp:GridView runat="server" ID="gv3" AutoGenerateColumns="false" Width="100%">
                        <Columns>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    LOCO
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="l1" Text='<%#Eval("Loco")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    SCHEDULE
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="l1" Text='<%#Eval("Schedule")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    DATE
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="l1" Text='<%#Eval("Date")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>--%>
                    <asp:Label runat="server" ID="lbl7" Visible="false" Text="" Font-Bold="true"></asp:Label>
                    <asp:Gridview runat="server" ID="gv4" AutoGenerateColumns="false" 
                        onselectedindexchanged="gv4_SelectedIndexChanged">
                    <Columns>
                    <asp:TemplateField>
                    <HeaderTemplate>No.</HeaderTemplate>
                    <ItemTemplate><%#Container.DataItemIndex + 1 %></ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                    <HeaderTemplate>LOCO</HeaderTemplate>
                    <ItemTemplate><asp:Label runat="server" ID="lbl1" Text='<%#Eval("Locono")%>'></asp:Label></ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                    <HeaderTemplate>SCHEDULE</HeaderTemplate>
                    <ItemTemplate><asp:Label runat="server" ID="lbl1" Text='<%#Eval("Schedule")%>'></asp:Label></ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                    <HeaderTemplate>DATE</HeaderTemplate>
                    <ItemTemplate><asp:Label runat="server" ID="lbl1" Text='<%#Eval("ScheduleDate")%>'></asp:Label></ItemTemplate>
                    </asp:TemplateField>
                    </Columns>
                    </asp:Gridview>
                    <asp:Label runat="server" ID="lbl8" Visible="false" Text="" Font-Bold="true"></asp:Label>
                    <asp:Gridview runat="server" ID="gv5" AutoGenerateColumns="false">
                    <Columns>
                    <asp:TemplateField>
                    <HeaderTemplate>No.</HeaderTemplate>
                    <ItemTemplate><%#Container.DataItemIndex + 1 %></ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                    <HeaderTemplate>LOCO</HeaderTemplate>
                    <ItemTemplate><asp:Label runat="server" ID="lbl1" Text='<%#Eval("Locono")%>'></asp:Label></ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                    <HeaderTemplate>SCHEDULE</HeaderTemplate>
                    <ItemTemplate><asp:Label runat="server" ID="lbl1" Text='<%#Eval("Schedule")%>'></asp:Label></ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                    <HeaderTemplate>DATE</HeaderTemplate>
                    <ItemTemplate><asp:Label runat="server" ID="lbl1" Text='<%#Eval("ScheduleDate")%>'></asp:Label></ItemTemplate>
                    </asp:TemplateField>
                    </Columns>
                    </asp:Gridview>
                    <br />
                </asp:Panel>
            </td>
        </tr>
        <tr>
        <td><asp:GridView runat="server" ID="gvPassangerLoco" AutoGenerateColumns="false">
        <Columns>
        <asp:TemplateField HeaderText="NO.">
        <ItemTemplate>
        <%#Container.DataItemIndex + 1 %>
        </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="INCOMING TRAIN NO">
        <ItemTemplate>
        <%--<asp:Label runat="server" ID="lblTrno" text='<%#Eval("")%>'></asp:Label>--%>
        </ItemTemplate>
        </asp:TemplateField>
        
        </Columns>
        </asp:GridView></td>
        </tr>
    </table>
</asp:Content>

