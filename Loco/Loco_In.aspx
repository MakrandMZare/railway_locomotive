<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true"
    CodeFile="Loco_In.aspx.cs" Inherits="Loco_Loco_In" Title="Sabarmati Diesels : Loco In" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:ToolkitScriptManager runat="server" ID="ToolkitScriptManager1">
    </asp:ToolkitScriptManager>

    <script language="javascript" type="text/javascript">
    function CallValidation()
    {
       var n1 = document.getElementById('<%=ddlClass.ClientID%>').value;
       var n2 = document.getElementById('<%=ddlLocono.ClientID%>').value;
       var n3 = document.getElementById('<%=ddlSchedule.ClientID%>').value;
       var n4 = document.getElementById('<%=ddlLastSchedule.ClientID%>').value;
       var n5 = document.getElementById('<%=ddlHq.ClientID%>').value;
       var n6 = document.getElementById('<%=ddlTncName.ClientID%>').value;
       if(Validate_selectedIndex(n1,'Class') && Validate_selectedIndex(n2,'Loco') && Validate_selectedIndex(n3,'Schedule') && Validate_selectedIndex(n4,'Last Schedule') && Validate_selectedIndex(n5,'HQ') && Validate_selectedIndex(n6,'TNC Name'))
       {return true;}
       
    if(document.getElementById('<%=ddlClass.ClientID%>').value == "SELECT")
   {
        alert("Please select value from dropdown");
        return false;
    }
     if(document.getElementById('<%=ddlLocono.ClientID%>').value == "SELECT")
   {
        alert("Please select value from dropdown");
        return false;
    }

 if(document.getElementById('<%=ddlSchedule.ClientID%>').value == "SELECT")
   {
        alert("Please select value from dropdown");
        return false;
    }
     if(document.getElementById('<%=ddlLastSchedule.ClientID%>').value == "SELECT")
   {
        alert("Please select value from dropdown");
        return false;
    }
      if(document.getElementById('<%=ddlTncName.ClientID%>').value == "SELECT")
   {
        alert("Please select value from dropdown");
        return false;
    }

if(document.getElementById('<%=ddlHq.ClientID%>').value == "SELECT")
   {
        alert("Please select value from dropdown");
        return false;
    }

 if(document.getElementById('<%=txtArrivalDate.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter Date");
        document.getElementById('<%=txtArrivalDate.ClientID %>').focus();
        return false;
    }
    if(document.getElementById('<%=txtTrainno.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter 0");
        document.getElementById('<%=txtTrainno.ClientID %>').focus();
        return false;
    }
    if(document.getElementById('<%=txtLastOutDate.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter Date");
        document.getElementById('<%=txtLastOutDate.ClientID %>').focus();
        return false;
    }
    
    
    if(document.getElementById('<%=ddlArrivalTime1.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter 0");
        document.getElementById('<%=ddlArrivalTime1.ClientID %>').focus();
        return false;
    }
    if(document.getElementById('<%=ddlArrivalTime2.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter 0");
        document.getElementById('<%=ddlArrivalTime2.ClientID %>').focus();
        return false;
    }
    if(document.getElementById('<%=txtDescription.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter 0");
        document.getElementById('<%=txtDescription.ClientID %>').focus();
        return false;
    }
    if(document.getElementById('<%=txtDriverName.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter 0");
        document.getElementById('<%=txtDriverName.ClientID %>').focus();
        return false;
    }
    if(document.getElementById('<%=txtLubelevel.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter 0");
        document.getElementById('<%=txtLubelevel.ClientID %>').focus();
        return false;
    }
    if(document.getElementById('<%=txtFulelevel.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter 0");
        document.getElementById('<%=txtFulelevel.ClientID %>').focus();
        return false;
    }
    if(document.getElementById('<%=txtsr1.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter 0");
        document.getElementById('<%=txtsr1.ClientID %>').focus();
        return false;
    }
    if(document.getElementById('<%=txtsr2.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter 0");
        document.getElementById('<%=txtsr2.ClientID %>').focus();
        return false;
    }if(document.getElementById('<%=txtsr3.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter 0");
        document.getElementById('<%=txtsr3.ClientID %>').focus();
        return false;
    }if(document.getElementById('<%=txtsr4.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter 0");
        document.getElementById('<%=txtsr4.ClientID %>').focus();
        return false;
    }if(document.getElementById('<%=txtfire1.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter 0");
        document.getElementById('<%=txtfire1.ClientID %>').focus();
        return false;
    }if(document.getElementById('<%=txtfire2.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter 0");
        document.getElementById('<%=txtfire2.ClientID %>').focus();
        return false;
    }if(document.getElementById('<%=txtfire3.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter 0");
        document.getElementById('<%=txtfire3.ClientID %>').focus();
        return false;
    }if(document.getElementById('<%=txtfire4.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter 0");
        document.getElementById('<%=txtfire4.ClientID %>').focus();
        return false;
    }if(document.getElementById('<%=txtShiftDate.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter 0");
        document.getElementById('<%=txtShiftDate.ClientID %>').focus();
        return false;
    }if(document.getElementById('<%=txtBookedRepair.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter 0");
        document.getElementById('<%=txtBookedRepair.ClientID %>').focus();
        return false;
    }if(document.getElementById('<%=txtRemarks.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter 0");
        document.getElementById('<%=txtRemarks.ClientID %>').focus();
        return false;
    }

   else
   {
   return true;
   }

       return false;
    
    }

    </script>

    <div>
        <table align="center" width="100%">
            <tr>
                <th colspan="7">
                    LOCO IN
                </th>
            </tr>
            <tr>
                <th colspan="7">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True" />
                </th>
            </tr>
            <tr>
                <td>
                    CLASS
                </td>
                <td>
                    :
                </td>
                <td colspan="50">
                    <asp:DropDownList runat="server" ID="ddlClass" AutoPostBack="True" OnSelectedIndexChanged="ddlClass_SelectedIndexChanged"
                        onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"
                        class="t1">
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                    <asp:Label runat="server" ID="lblguage" Visible="false"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    LOCO NO
                </td>
                <td>
                    :
                </td>
                <td colspan="50">
                    <asp:DropDownList runat="server" ID="ddlLocono" onfocus="ChangeStyle(this.id.toString());"
                        AutoPostBack="true" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"
                        OnSelectedIndexChanged="ddlLocono_SelectedIndexChanged">
                        <asp:ListItem>SELECT</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td colspan="50">
                    <asp:Panel runat="server" ID="p1" Visible="false">
                        <table>
                            <tr>
                                <th>
                                    <asp:Label runat="server" ID="lblHeader" Text="..."></asp:Label>
                                </th>
                            </tr>
                            <tr>
                                <td>
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
                                            <%--<asp:TemplateField>
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
                                                    ID="lbtnDelete" PostBackUrl='<%# "~/LocoShedPosition/ShedPositionReport.aspx?TemporaryId=" + Eval("rid") + "&action=delete" %>' />
                                            </td>
                                        </tr>
                                    </table>
                                </ItemTemplate>
                            </asp:TemplateField>--%>
                                        </Columns>
                                    </asp:GridView>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:GridView runat="server" ID="gvDeadOnline" AutoGenerateColumns="false" Width="800px">
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
                                                    <asp:Label ID="Label6" runat="server" Text='<%#"DOC -" + Eval("DOC") + Eval("LAST") + Eval("LAST SCHEDULE") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <%--<asp:TemplateField>
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
                                                    ID="lbtnDelete" PostBackUrl='<%# "~/LocoShedPosition/ShedPositionReport.aspx?LineMessage2Id=" + Eval("rid")+"&action=delete" %>' />
                                            </td>
                                        </tr>
                                    </table>
                                </ItemTemplate>
                            </asp:TemplateField>--%>
                                        </Columns>
                                    </asp:GridView>
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td>
                    ARRIVAL DATE
                </td>
                <td>
                    : <b>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtArrivalDate"
                            ErrorMessage="ENTER ARRIVAL DATE">*</asp:RequiredFieldValidator>
                    </b>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtArrivalDate" onfocus="ChangeStyle(this.id.toString());"
                        onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
                    <asp:CalendarExtender runat="server" ID="CalendarExtender1" TargetControlID="txtArrivalDate"
                        Format="dd/MM/yyyy">
                    </asp:CalendarExtender>
                </td>
                <td>
                    ARRIVAL TIME
                </td>
                <td>
                    :
                </td>
                <td>
                    <asp:TextBox ID="ddlArrivalTime1" runat="server" onfocus="ChangeStyle(this.id.toString());"
                        onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Width="30px" AutoPostBack="true"
                        OnTextChanged="ddlArrivalTime1_OnSelectedIndexChanged">
                        
                    </asp:TextBox>
                    &nbsp;:
                    <asp:TextBox ID="ddlArrivalTime2" runat="server" onfocus="ChangeStyle(this.id.toString());"
                        onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Width="30px">
                        
                    </asp:TextBox>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    SCHEDULE
                </td>
                <td>
                    :
                </td>
                <td>
                    <asp:DropDownList runat="server" ID="ddlSchedule" onfocus="ChangeStyle(this.id.toString());"
                        onBlur="ChangeDefaultStyle(this.id.toString());" class="t1">
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    DESCRIPTION
                </td>
                <td>
                    :<b><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtDescription"
                        ErrorMessage="ENTER DESCRIPTION">*</asp:RequiredFieldValidator>
                    </b>&nbsp;
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtDescription" onfocus="ChangeStyle(this.id.toString());"
                        onBlur="ChangeDefaultStyle(this.id.toString());" class="t1">-</asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    TRAIN NO
                </td>
                <td>
                    :<b>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtTrainno"
                            ErrorMessage="ENTER TRAIN ">*</asp:RequiredFieldValidator>
                    </b>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtTrainno" onfocus="ChangeStyle(this.id.toString());"
                        onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    LAST OUT DATE
                </td>
                <td>
                    :
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtLastOutDate" onfocus="ChangeStyle(this.id.toString());"
                        onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox><asp:CalendarExtender
                            runat="server" ID="CalendarExtender2" TargetControlID="txtLastOutDate" Format="dd/MM/yyyy">
                        </asp:CalendarExtender>
                </td>
            </tr>
            <tr>
                <td>
                    LAST SCHEDULE
                </td>
                <td>
                    :
                </td>
                <td>
                    <asp:DropDownList runat="server" ID="ddlLastSchedule" onfocus="ChangeStyle(this.id.toString());"
                        onBlur="ChangeDefaultStyle(this.id.toString());" class="t1">
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    DRIVER'S NAME
                </td>
                <td>
                    : <b>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="rdoDriverBook"
                            ErrorMessage="ENTER DRIVER'S NAEM">*</asp:RequiredFieldValidator>
                    </b>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtDriverName" onfocus="ChangeStyle(this.id.toString());"
                        onBlur="ChangeDefaultStyle(this.id.toString());" class="t1">-</asp:TextBox>
                </td>
                <td>
                    HQ
                </td>
                <td>
                    :
                </td>
                <td>
                    <asp:DropDownList runat="server" ID="ddlHq" onfocus="ChangeStyle(this.id.toString());"
                        onBlur="ChangeDefaultStyle(this.id.toString());" class="t1">
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    LUBE OIL LEVEL
                </td>
                <td>
                    : <b>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtLubelevel"
                            ErrorMessage="ENTER LUBE OIL LEVEL">*</asp:RequiredFieldValidator>
                    </b>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtLubelevel" onfocus="ChangeStyle(this.id.toString());"
                        onBlur="ChangeDefaultStyle(this.id.toString());" class="t1">0</asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    FULE LEVEL
                </td>
                <td>
                    : <b>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtFulelevel"
                            ErrorMessage="ENTER FULE LEVEL">*</asp:RequiredFieldValidator>
                    </b>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtFulelevel" onfocus="ChangeStyle(this.id.toString());"
                        onBlur="ChangeDefaultStyle(this.id.toString());" class="t1">0</asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <b>WHETHER HANDED OVER </b>
                </td>
            </tr>
            <tr>
                <td>
                    DRIVER BOOK
                </td>
                <td>
                    :
                </td>
                <td>
                    <asp:RadioButtonList runat="server" ID="rdoDriverBook" RepeatDirection="Horizontal"
                        onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"
                        class="t1">
                        <asp:ListItem Selected="True">YES</asp:ListItem>
                        <asp:ListItem>NO</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td>
                    REVERSER KEY
                </td>
                <td>
                    :
                </td>
                <td>
                    <asp:RadioButtonList ID="rdoReverserKey" runat="server" RepeatDirection="Horizontal"
                        onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"
                        class="t1">
                        <asp:ListItem Selected="True">YES</asp:ListItem>
                        <asp:ListItem>NO</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td>
                    PCP SET
                </td>
                <td>
                    :
                </td>
                <td>
                    <asp:RadioButtonList ID="rdpPcpset" runat="server" RepeatDirection="Horizontal" onfocus="ChangeStyle(this.id.toString());"
                        onBlur="ChangeDefaultStyle(this.id.toString());" class="t1">
                        <asp:ListItem Selected="True">YES</asp:ListItem>
                        <asp:ListItem>NO</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td>
                    FIRE EXTINGUSHER
                </td>
                <td>
                    :
                </td>
                <td>
                    <asp:RadioButtonList ID="rdoFireExtingusher" runat="server" RepeatDirection="Horizontal"
                        onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"
                        class="t1">
                        <asp:ListItem Selected="True">YES</asp:ListItem>
                        <asp:ListItem>NO</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                </td>
                <td>
                    SRNO
                </td>
                <td>
                </td>
                <td>
                </td>
                <td>
                    EXPIRE DATE
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                    <b>&nbsp;
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtsr1"
                            ErrorMessage="ENTER SRNO 1.">*</asp:RequiredFieldValidator>
                    </b>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtsr1" onfocus="ChangeStyle(this.id.toString());"
                        onBlur="ChangeDefaultStyle(this.id.toString());" class="t1">0</asp:TextBox>
                </td>
                <td>
                </td>
                <td>
                    <b>&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server"
                        ControlToValidate="txtfire1" ErrorMessage="ENTER EXPRIRE DATE 1.">*</asp:RequiredFieldValidator>
                    </b>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtfire1" onfocus="ChangeStyle(this.id.toString());"
                        onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox><asp:CalendarExtender
                            runat="server" ID="CalendarExtender3" TargetControlID="txtfire1" Format="dd/MM/yyyy">
                        </asp:CalendarExtender>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                    <b>&nbsp;
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="txtsr2"
                            ErrorMessage="ENTER SRNO 2.">*</asp:RequiredFieldValidator>
                    </b>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtsr2" onfocus="ChangeStyle(this.id.toString());"
                        onBlur="ChangeDefaultStyle(this.id.toString());" class="t1">0</asp:TextBox>
                </td>
                <td>
                </td>
                <td>
                    <b>&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server"
                        ControlToValidate="txtfire2" ErrorMessage="ENTER EXPRIRE DATE 1.">*</asp:RequiredFieldValidator>
                    </b>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtfire2" onfocus="ChangeStyle(this.id.toString());"
                        onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox><asp:CalendarExtender
                            runat="server" ID="CalendarExtender4" TargetControlID="txtfire2" Format="dd/MM/yyyy">
                        </asp:CalendarExtender>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                    <b>&nbsp; </b>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtsr3" onfocus="ChangeStyle(this.id.toString());"
                        onBlur="ChangeDefaultStyle(this.id.toString());" class="t1">0</asp:TextBox>
                </td>
                <td>
                </td>
                <td>
                    <b>&nbsp;</b>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtfire3" onfocus="ChangeStyle(this.id.toString());"
                        onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox><asp:CalendarExtender
                            runat="server" ID="CalendarExtender5" TargetControlID="txtfire3" Format="dd/MM/yyyy">
                        </asp:CalendarExtender>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                    <b>&nbsp; </b>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtsr4" onfocus="ChangeStyle(this.id.toString());"
                        onBlur="ChangeDefaultStyle(this.id.toString());" class="t1">0</asp:TextBox>
                </td>
                <td>
                </td>
                <td>
                    <b>&nbsp;</b>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtfire4" onfocus="ChangeStyle(this.id.toString());"
                        onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox><asp:CalendarExtender
                            runat="server" ID="CalendarExtender6" TargetControlID="txtfire4" Format="dd/MM/yyyy">
                        </asp:CalendarExtender>
                </td>
            </tr>
            <tr>
                <td>
                    TNC NAME
                </td>
                <td>
                    :
                </td>
                <td colspan="5">
                    <asp:DropDownList runat="server" AutoPostBack="false" ID="ddlTncName" onfocus="ChangeStyle(this.id.toString());"
                        onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Width="400px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    SHIFT DATE
                </td>
                <td>
                    : <b>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" ControlToValidate="txtShiftDate"
                            ErrorMessage="ENTER SHIFT DATE">*</asp:RequiredFieldValidator>
                    </b>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtShiftDate" onfocus="ChangeStyle(this.id.toString());"
                        onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox><asp:CalendarExtender
                            runat="server" ID="CalendarExtender7" TargetControlID="txtShiftDate" Format="dd/MM/yyyy">
                        </asp:CalendarExtender>
                    <asp:Label runat="server" ID="lblShift"></asp:Label>
                </td>
            </tr>
            <tr>
                <td valign="top">
                    BOOKED REPAIR
                </td>
                <td valign="top">
                    : <b>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator17" runat="server" ControlToValidate="txtBookedRepair"
                            ErrorMessage="ENTER BOOKED REPAIR">*</asp:RequiredFieldValidator>
                    </b>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtBookedRepair" TextMode="MultiLine" onfocus="ChangeStyle(this.id.toString());"
                        onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Rows="10" Columns="70">-</asp:TextBox>
                </td>
            </tr>
            <tr>
                <td valign="top">
                    REMARKS
                </td>
                <td valign="top">
                    : <b>
                        <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator18" runat="server" ControlToValidate="txtActionTaken"
                            ErrorMessage="ENTER ACTION TAKEN.">*</asp:RequiredFieldValidator>--%>
                    </b>
                </td>
                <td>
                    <asp:TextBox ID="txtRemarks" runat="server" TextMode="MultiLine" onfocus="ChangeStyle(this.id.toString());"
                        onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Rows="10" Columns="70">-</asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:PlaceHolder runat="server" ID="MeterguagePh" Visible="false">
                        <table width="65%" border="0">
                            <tr>
                                <td>
                                    WHEEL DIAMETER
                                </td>
                                <td>
                                    :
                                </td>
                                <td>
                                    <asp:TextBox runat="server" ID="txtMGWheelDia" onfocus="ChangeStyle(this.id.toString());"
                                        onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    PASS [F / U / O]
                                </td>
                                <td>
                                    :
                                </td>
                                <td>
                                    <asp:DropDownList runat="server" AutoPostBack="true" ID="ddlMGPass" onfocus="ChangeStyle(this.id.toString());"
                                        onBlur="ChangeDefaultStyle(this.id.toString());" class="t1">
                                        <asp:ListItem Text="F" Value="F" Selected="True"></asp:ListItem>
                                        <asp:ListItem Text="U" Value="U"></asp:ListItem>
                                        <asp:ListItem Text="O" Value="O"></asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    PDC
                                </td>
                                <td>
                                    :
                                </td>
                                <td>
                                    <asp:TextBox runat="server" ID="txtMGPDC" onfocus="ChangeStyle(this.id.toString());"
                                        onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
                                    <asp:CalendarExtender runat="server" ID="CalendarExtender8" TargetControlID="txtMGPDC"
                                        Format="dd/MM/yyyy">
                                    </asp:CalendarExtender>
                                </td>
                            </tr>
                        </table>
                    </asp:PlaceHolder>
                </td>
            </tr>
            <tfoot>
                <td colspan="7" align="center">
                    <asp:Button runat="server" ID="btnSave" Text="INSERT" onfocus="ChangeStyle(this.id.toString());"
                        onBlur="ChangeDefaultStyle(this.id.toString());" class="t2" OnClick="btnSave_OnClick"
                        OnClientClick="return CallValidation();" />
                </td>
            </tfoot>
        </table>
    </div>
</asp:Content>
