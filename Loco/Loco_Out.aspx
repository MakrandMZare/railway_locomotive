<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true" CodeFile="Loco_Out.aspx.cs" Inherits="Loco_Out" Title="Sabarmati Diesels : Loco Out" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
   <asp:ToolkitScriptManager runat="server" ID="ToolkitScriptManager1">
    </asp:ToolkitScriptManager>
    <script language="javascript" type="text/javascript">
    function CallValidation()
    {
       var n1 = document.getElementById('<%=ddlClass.ClientID%>').value;
       var n2 = document.getElementById('<%=ddlLocono.ClientID%>').value;
       var n3 = document.getElementById('<%=ddlSchedule.ClientID%>').value;
       
       var n5 = document.getElementById('<%=ddlHq.ClientID%>').value;
       var n6 = document.getElementById('<%=ddlTncName.ClientID%>').value;
       if(Validate_selectedIndex(n1,'Class') && Validate_selectedIndex(n2,'Loco') && Validate_selectedIndex(n3,'Schedule') && Validate_selectedIndex(n5,'HQ') && Validate_selectedIndex(n6,'TNC Name'))
       {return true;}
       
    if(document.getElementById('<%=txtArrivalDate.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter 0");
        document.getElementById('<%=txtArrivalDate.ClientID %>').focus();
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
        alert("IF you Have no Value then enter -");
        document.getElementById('<%=txtDescription.ClientID %>').focus();
        return false;
    }

if(document.getElementById('<%=txtTrainno.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter 0");
        document.getElementById('<%=txtTrainno.ClientID %>').focus();
        return false;
    }

if(document.getElementById('<%=txtDriverName.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter -");
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
    }

if(document.getElementById('<%=txtsr3.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter 0");
        document.getElementById('<%=txtsr3.ClientID %>').focus();
        return false;
    }

if(document.getElementById('<%=txtsr4.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter 0");
        document.getElementById('<%=txtsr4.ClientID %>').focus();
        return false;
    }

if(document.getElementById('<%=txtfire1.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter Date");
        document.getElementById('<%=txtfire1.ClientID %>').focus();
        return false;
    }

if(document.getElementById('<%=txtfire2.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter Date");
        document.getElementById('<%=txtfire2.ClientID %>').focus();
        return false;
    }

if(document.getElementById('<%=txtfire3.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter Date");
        document.getElementById('<%=txtfire3.ClientID %>').focus();
        return false;
    }

if(document.getElementById('<%=txtfire4.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter Date");
        document.getElementById('<%=txtfire4.ClientID %>').focus();
        return false;
    }

if(document.getElementById('<%=txtShiftDate.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter Date");
        document.getElementById('<%=txtShiftDate.ClientID %>').focus();
        return false;
    }

if(document.getElementById('<%=txtReason.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter -");
        document.getElementById('<%=txtReason.ClientID %>').focus();
        return false;
    }

if(document.getElementById('<%=txtRemarks.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter -");
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
        <table align="center">
        <tr>
            <th colspan="7">
                LOCO OUT
            </th>
        </tr>
        <tr>
            <th colspan="7">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
            </th>
        </tr>
        <tr>
            <td>
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
            <td>
                LOCO NO
            </td>
            <td>
                :
            </td>
            <td>
                <asp:DropDownList runat="server" ID="ddlLocono" onfocus="ChangeStyle(this.id.toString());"
                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" OnSelectedIndexChanged="ddlLocono_SelectedIndexChanged"
                    AutoPostBack="True">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                LOCO OUT DATE
            </td>
            <td>
                :
                    <b>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtArrivalDate" ErrorMessage="ENTER OUT DATE">*</asp:RequiredFieldValidator>
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
                LOCO OUT TIME
            </td>
            <td>
                :
            </td>
            <td>
                <asp:TextBox  ID="ddlArrivalTime1" runat="server"  
                        onfocus="ChangeStyle(this.id.toString());" 
                        onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Width="30px" AutoPostBack="true"
                        OnTextChanged="ddlArrivalTime1_OnSelectedIndexChanged" 
                        >
                        
                    </asp:TextBox>
                    &nbsp;:
                    <asp:TextBox ID="ddlArrivalTime2" runat="server" onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Width="30px">
                        
                    </asp:TextBox>
            </td>
            <td>
                <asp:Label runat="server" ID="lblShift"></asp:Label>
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
                :
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtDescription" onfocus="ChangeStyle(this.id.toString());"
                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                TRAIN
            </td>
            <td>
                :
                    <b>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="txtArrivalDate" ErrorMessage="ENTER TRAIN .">*</asp:RequiredFieldValidator>
                    </b>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtTrainno" onfocus="ChangeStyle(this.id.toString());"
                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                DRIVER'S NAME
            </td>
            <td>
                :
                    <b>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="txtDriverName" ErrorMessage="ENTER DRIVER'S NAME">*</asp:RequiredFieldValidator>
                    </b>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtDriverName" onfocus="ChangeStyle(this.id.toString());"
                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
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
                :
                    <b>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                        ControlToValidate="txtLubelevel" ErrorMessage="ENTER LUBE OIL LEVEL">*</asp:RequiredFieldValidator>
                    </b>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtLubelevel" onfocus="ChangeStyle(this.id.toString());"
                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                FULE LEVEL
            </td>
            <td>
                :
                    <b>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                        ControlToValidate="txtFulelevel" ErrorMessage="ENTER FULE LEVEL">*</asp:RequiredFieldValidator>
                    </b>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtFulelevel" onfocus="ChangeStyle(this.id.toString());"
                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
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
                    <b>
                    &nbsp;
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                        ControlToValidate="txtsr1" ErrorMessage="ENTER SRNO 1 .">*</asp:RequiredFieldValidator>
                    </b>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtsr1" onfocus="ChangeStyle(this.id.toString());"
                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
            </td>
            <td>
            </td>
            <td>
                    <b>
                    &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" 
                        ControlToValidate="txtfire1" ErrorMessage="ENTER EXPIRE DATE 1 .">*</asp:RequiredFieldValidator>
                    </b>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtfire1" onfocus="ChangeStyle(this.id.toString());"
                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox><asp:CalendarExtender
                        runat="server" ID="CalendarExtender2" TargetControlID="txtfire1" Format="dd/MM/yyyy">
                    </asp:CalendarExtender>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
                    <b>
                    &nbsp;
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                        ControlToValidate="txtsr2" ErrorMessage="ENTER SRNO 2 .">*</asp:RequiredFieldValidator>
                    </b>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtsr2" onfocus="ChangeStyle(this.id.toString());"
                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
            </td>
            <td>
            </td>
            <td>
                    <b>
                    &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" 
                        ControlToValidate="txtfire2" ErrorMessage="ENTER EXPIRE DATE 2 .">*</asp:RequiredFieldValidator>
                    </b>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtfire2" onfocus="ChangeStyle(this.id.toString());"
                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox><asp:CalendarExtender
                        runat="server" ID="CalendarExtender3" TargetControlID="txtfire2" Format="dd/MM/yyyy">
                    </asp:CalendarExtender>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
                    <b>
                    &nbsp;
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="txtsr3"
                            ErrorMessage="ENTER SRNO 1 ." Width="1px">*</asp:RequiredFieldValidator></b></td>
            <td>
                <asp:TextBox runat="server" ID="txtsr3" onfocus="ChangeStyle(this.id.toString());"
                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t1">0</asp:TextBox>
            </td>
            <td>
            </td>
            <td>
                    <b>
                    &nbsp;</b></td>
            <td>
                <asp:TextBox runat="server" ID="txtfire3" onfocus="ChangeStyle(this.id.toString());"
                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox><asp:CalendarExtender
                        runat="server" ID="CalendarExtender4" TargetControlID="txtfire3" Format="dd/MM/yyyy">
                    </asp:CalendarExtender>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
                    <b>
                    &nbsp;
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="txtsr4"
                            ErrorMessage="ENTER SRNO 1 .">*</asp:RequiredFieldValidator></b></td>
            <td>
                <asp:TextBox runat="server" ID="txtsr4" onfocus="ChangeStyle(this.id.toString());"
                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t1">0</asp:TextBox>
            </td>
            <td>
            </td>
            <td>
                    <b>
                    &nbsp;
                    </b>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtfire4" onfocus="ChangeStyle(this.id.toString());"
                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox><asp:CalendarExtender
                        runat="server" ID="CalendarExtender5" TargetControlID="txtfire4" Format="dd/MM/yyyy">
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
                <asp:DropDownList runat="server" ID="ddlTncName" onfocus="ChangeStyle(this.id.toString());"
                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Width="400px" 
                    AutoPostBack="false" onselectedindexchanged="ddlTncName_SelectedIndexChanged" >
                </asp:DropDownList>
            </td>
        </tr>
        <tr ><td colspan="10"><asp:Panel runat="server" ID="PanelTnc" Visible="false" BackColor="Azure" BorderColor="Blue" BorderWidth="1">
            <table>
            <tr><td>Surname</td><td> : </td><td><asp:TextBox runat="server" ID="txtsurname" onfocus="ChangeStyle(this.id.toString());" 
                            onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox></td><td>Name</td><td> : </td><td><asp:TextBox runat="server" ID="txtName" onfocus="ChangeStyle(this.id.toString());" 
                            onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox></td><td>Father Name</td><td> : </td><td><asp:TextBox runat="server" ID="txtfathername" onfocus="ChangeStyle(this.id.toString());" 
                            onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox></td><td>
                <asp:Button runat="server" ID="txtbtn" OnClick="txtbtn_OnClick" Text="ADD" 
                    onfocus="ChangeStyle(this.id.toString());" 
                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t2" 
                    ValidationGroup="tnc"/></td></tr>
            
            </table>
                  </asp:Panel></td><td></td></tr>
        <tr>
            <td>
                SHIFT DATE
            </td>
            <td>
                :
                    <b>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                        ControlToValidate="txtShiftDate" ErrorMessage="ENTER TRAIN .">*</asp:RequiredFieldValidator>
                    </b>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtShiftDate" onfocus="ChangeStyle(this.id.toString());"
                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox><asp:CalendarExtender
                        runat="server" ID="CalendarExtender6" TargetControlID="txtShiftDate" Format="dd/MM/yyyy">
                    </asp:CalendarExtender>
            </td>
        </tr>
        <tr>
            <td>
                WHETHER ISOLATED ON TRIAL
                <br />
                YES / NO. IF YES GIVE REASON
            </td>
            <td>
                :
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtReason" TextMode="MultiLine" onfocus="ChangeStyle(this.id.toString());"
                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Height="45px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                REMARKS
            </td>
            <td>
                :
                    <b>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                        ControlToValidate="txtRemarks" ErrorMessage="ENTER REMARKS .">*</asp:RequiredFieldValidator>
                    </b>
            </td>
            <td>
                <asp:TextBox ID="txtRemarks" runat="server" TextMode="MultiLine" onfocus="ChangeStyle(this.id.toString());"
                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Height="42px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="7" align="center">
                <asp:Button runat="server" ID="btnSave" Text="INSERT" onfocus="ChangeStyle(this.id.toString());"
                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t2"
                    OnClick="btnSave_OnClick" OnClientClick="return CallValidation();" />
            </td>
        </tr>
    </table>

    
</asp:Content>
