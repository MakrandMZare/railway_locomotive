<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true" CodeFile="spectro_anaylsis.aspx.cs" Inherits="TestingLab_spectro_anaylsis" Title="Untitled Page" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

   <script language="javascript" type="text/javascript">
    function CallValidation()
    {
     var n1 = document.getElementById('<%=ddlClass.ClientID%>').value;
       var n2 = document.getElementById('<%=ddlLocono.ClientID%>').value;
       var n3 = document.getElementById('<%=ddlSchedule.ClientID%>').value;
       if(Validate_selectedIndex(n1,'Class') && Validate_selectedIndex(n2,'Loco') && Validate_selectedIndex(n3,'Schedule'))
       {return true;}

 if(document.getElementById('<%=txtdateCollection.ClientID %>').value == "")
    {
        alert("Please enter Date of collection");
        document.getElementById('<%=txtdateCollection.ClientID %>').focus();
        return false;
    }
 if(document.getElementById('<%=txtdateof.ClientID %>').value == "")
    {
        alert("Please enter Date of ");
        document.getElementById('<%=txtdateof.ClientID %>').focus();
        return false;
    }
    
    
   else
   {
   return true;
   }

       return false;
    
    }
    }
    </script>

    <table align="center">
        <tr>
            <th colspan="7">
                SPECTROGRAPHIC ANALYSIS&nbsp;</th>
        </tr>
        <tr>
            <td align="center">
                CLASS
            </td>
            <td align="center">
                LOCO NO.
            </td>
            <td align="center">
                DATE OF COLLECTION</td>
            <td align="center">
                DATE OF TESTING</td>
            <td align="center">
                SCHEDULE
            </td>
        </tr>
        <tr>
            <td align="center">
                <asp:DropDownList runat="server" ID="ddlClass" CssClass="t1" AutoPostBack="True"
                    OnSelectedIndexChanged="ddlClass_SelectedIndexChanged">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td align="center">
                <asp:DropDownList runat="server" ID="ddlLocono" CssClass="t1" OnSelectedIndexChanged="ddlLocono_OnSelectedIndexChanged"
                    AutoPostBack="True">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td align="center">
                &nbsp;
                <asp:TextBox ID="txtdateCollection" runat="server" CssClass="t1" ValidationGroup="a"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtdateCollection"
                    ErrorMessage="*" ValidationGroup="a"></asp:RequiredFieldValidator>&nbsp;</td>
            <td align="center">
                &nbsp;
                <asp:TextBox runat="server" ID="txtdateof" CssClass="t1" ValidationGroup="a"></asp:TextBox>
            </td>
            <td align="center">
                <asp:DropDownList runat="server" ID="ddlSchedule" CssClass="t1">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="6">
                ELEMENTS<table  style="width: 704px">
                <tr>
                <td>
                    Al</td>
                <td>B</td>
                <td>Cr</td>
                <td>Cu</td>
                <td>Fe</td>
                <td>Na</td>
                <td>Pb</td>
                <td>Si</td>
                <td>Sn</td>
                </tr>
                <tr>
                <td>
                    0/5</td>
                <td>10/20</td>
                <td>
                    10/20</td>
                <td>
                    75/155</td>
                <td>
                    75/125</td>
                <td>
                    -</td>
                <td>
                    50/75</td>
                <td>15/20</td>
                <td>
                    20/40</td>
                </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="txta1" runat="server" CssClass="t1" Width="40px"></asp:TextBox></td>
                        <td>
                            <asp:TextBox ID="txtb" runat="server" CssClass="t1" Width="40px"></asp:TextBox></td>
                        <td>
                            <asp:TextBox ID="txtcr" runat="server" CssClass="t1" Width="40px"></asp:TextBox></td>
                        <td>
                            <asp:TextBox ID="txtcu" runat="server" CssClass="t1" Width="40px"></asp:TextBox></td>
                        <td>
                            <asp:TextBox ID="txtfe" runat="server" CssClass="t1" Width="40px"></asp:TextBox></td>
                        <td>
                            <asp:TextBox ID="txtna" runat="server" CssClass="t1" Width="40px"></asp:TextBox></td>
                        <td>
                            <asp:TextBox ID="txtpb" runat="server" CssClass="t1" Width="40px"></asp:TextBox></td>
                        <td>
                            <asp:TextBox ID="txtsi" runat="server" CssClass="t1" Width="40px"></asp:TextBox></td>
                        <td>
                            <asp:TextBox ID="txtsn" runat="server" CssClass="t1" Width="40px"></asp:TextBox></td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="6">
                <table width="100">
                    <tr>
                        <td style="width: 100px">
                REMARKS
                        </td>
                        <td style="width: 100px">
                            :</td>
                        <td style="width: 100px">
                <asp:TextBox runat="server" ID="txtResult_Remraks" CssClass="t1" Height="85px" TextMode="MultiLine" Width="200px"></asp:TextBox></td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="6">
                <cc1:toolkitscriptmanager id="ToolkitScriptManager1" runat="server"></cc1:toolkitscriptmanager>
                <cc1:calendarextender id="CalendarExtender1" runat="server" format="dd/MM/yyyy" targetcontrolid="txtdateCollection"></cc1:calendarextender>
                <cc1:calendarextender id="CalendarExtender2" runat="server" format="dd/MM/yyyy" targetcontrolid="txtdateof"></cc1:calendarextender>
                <asp:Button runat="server" ID="btnSave" CssClass="t2" OnClientClick="return CallValidation();" OnClick="btnSave_OnClick" Text="Insert" ValidationGroup="a"/>
                &nbsp;
                <asp:Button runat="server" ID="btnCancel" CssClass="t2" OnClick="btnCancel_OnClick"
                    Text="Cancel" /></td>
        </tr>
        <tr>
            <td colspan="47">
                <asp:GridView runat="Server" ID="gv1" DataKeyNames="spectro_id" AutoGenerateColumns="false"
                    EmptyDataText="No Data Found...!" OnRowEditing="gv1_OnRowEditing" OnRowDeleting="gv1_OnRowDeleting">
                    <Columns>
                        <asp:TemplateField HeaderText="SNO.">
                            <ItemTemplate>
                                <%#Container.DataItemIndex  + 1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="Locono" HeaderText="LOCO NO" />
                        <asp:BoundField DataField="date_of_collection" HeaderText="DATE OF COLLECTION" />
                        <asp:BoundField DataField="Loco_Date" HeaderText="DATE OF TESTING" />
                        <asp:BoundField DataField="Id_Schedule" HeaderText="SCHEDULE" />
                        <asp:BoundField DataField="A1" HeaderText="Al- 0/5" />
                        <asp:BoundField DataField="B" HeaderText="B- 10/20"/>
                        <asp:BoundField DataField="Cr" HeaderText="Cr- 10/20" />
                        <asp:BoundField DataField="Cu" HeaderText="Cu- 75/155" />
                        <asp:BoundField DataField="Fe" HeaderText="Fe- 75/125" />
                        
                           <asp:BoundField DataField="Na" HeaderText="Na -/-" />
                        <asp:BoundField DataField="Pb" HeaderText="Pb- 50/75" />
                        <asp:BoundField DataField="Si" HeaderText="Si- 15/20" />
                        <asp:BoundField DataField="Sn" HeaderText="Sn- 20/40" />
                        <asp:BoundField DataField="remarks" HeaderText="REMARK" />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <table>
                                    <tr>
                                        <td>
                                            <asp:ImageButton Width="10px" runat="server" ImageUrl="~/Images/Edit-icon.png" ID="lbtnUpdate"
                                                CommandName="Edit" />
                                        </td>
                                        <td>
                                            <asp:ImageButton Width="10px" runat="server" ImageUrl="~/Images/Delete-icon.png"
                                                ID="lbtnDelete" CommandName="Delete" />
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

</asp:Content>

