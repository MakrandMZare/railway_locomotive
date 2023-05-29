<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" EnableEventValidation="false"
    AutoEventWireup="true" CodeFile="ComponantFailure.aspx.cs" Inherits="TestingLab_ComponantFailure"
    Title="Untitled Page" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <script language="javascript" type="text/javascript">
    function CallValidation()
    {
       
    if(document.getElementById('<%=ddlLocono.ClientID%>').value == "SELECT")
   {
        alert("Please select value from dropdown");
        return false;
    }

   else
   {
   return true;
   }

  
    }

    </script>

    <table width="900">
        <tr>
            <th>
                RETAILS OF FAILURE COMPONENT&nbsp; DURING SCHEDULE TESTING BY NDT</th>
        </tr>
        <tr>
            <td>
                &nbsp;<div id="insertDiv" style="display: block;">
                    <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
                    </cc1:ToolkitScriptManager>
                    <asp:TextBox ID="txtTested" runat="server" class="t1" onblur="ChangeDefaultStyle(this.id.toString());"
                        onfocus="ChangeStyle(this.id.toString());" Visible="False"></asp:TextBox>
                    <cc1:CalendarExtender ID="CalendarExtender1" runat="server" Format="dd/MM/yyyy" TargetControlID="txtdate">
                    </cc1:CalendarExtender>
                    <table width="990">
                        <tr>
                            <td align="center">
                                CLASS</td>
                            <td align="center">
                                LOCO NO</td>
                            <td align="center">
                                DATE
                            </td>
                            <td align="center">
                                NAME OF COMPONENT</td>
                            <td align="center">
                                TYPE OF TEST
                            </td>
                            <td align="center" colspan="2" valign="bottom">
                                RESULT
                                <table border="1" style="width: 271px">
                                    <tr>
                                        <td style="width: 100px" align="left">
                                            SUITABLE</td>
                                        <td style="width: 100px">
                                            REJECTED</td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td align="center">
                                <asp:DropDownList ID="ddlclass" runat="server" AutoPostBack="True" CssClass="t1"
                                    OnSelectedIndexChanged="ddlClass_SelectedIndexChanged">
                                    <asp:ListItem>SELECT</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td align="center">
                                <asp:DropDownList ID="ddlLocono" runat="server" AutoPostBack="True" CssClass="t1"
                                    OnSelectedIndexChanged="ddlLocono_OnSelectedIndexChanged">
                                    <asp:ListItem>SELECT</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td align="center">
                                <asp:TextBox ID="txtdate" runat="server" class="t1" onblur="ChangeDefaultStyle(this.id.toString());"
                                    onfocus="ChangeStyle(this.id.toString());"></asp:TextBox></td>
                            <td align="center">
                                <asp:TextBox ID="txtCompName" runat="server" class="t1" onblur="ChangeDefaultStyle(this.id.toString());"
                                    onfocus="ChangeStyle(this.id.toString());"></asp:TextBox></td>
                            <td align="center">
                                <asp:TextBox ID="txtTypeTest" runat="server" class="t1" onblur="ChangeDefaultStyle(this.id.toString());"
                                    onfocus="ChangeStyle(this.id.toString());"></asp:TextBox></td>
                            <td align="center">
                                <asp:TextBox ID="txtSuitable" runat="server" class="t1" onblur="ChangeDefaultStyle(this.id.toString());"
                                    onfocus="ChangeStyle(this.id.toString());"></asp:TextBox></td>
                            <td align="center">
                                <asp:TextBox ID="txtRejected" runat="server" class="t1" onblur="ChangeDefaultStyle(this.id.toString());"
                                    onfocus="ChangeStyle(this.id.toString());"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td align="center" colspan="9">
                                <table width="100">
                                    <tr>
                                        <td style="width: 100px">
                                            REMARKS</td>
                                        <td style="width: 100px">
                                            :</td>
                                        <td style="width: 100px">
                                            <asp:TextBox ID="txtRemarks" runat="server" class="t1" onblur="ChangeDefaultStyle(this.id.toString());"
                                                onfocus="ChangeStyle(this.id.toString());" Height="85px" TextMode="MultiLine"
                                                Width="200px"></asp:TextBox></td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td align="center" colspan="9">
                                <asp:Button onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"
                                    class="t1" ID="btnadd" runat="server" OnClientClick="return CallValidation();"
                                    OnClick="btnadd_Click" Text="Insert" Width="78px" ValidationGroup="a" />&nbsp;
                                <asp:Button ID="btnCancel" runat="server" CssClass="t2" OnClick="btnCancel_OnClick"
                                    Text="Cancel" Width="69px" /></td>
                        </tr>
                        <tr>
                            <td align="center" colspan="9">
                                <asp:GridView runat="Server" ID="gv1" DataKeyNames="comp_id" AutoGenerateColumns="false"
                                    EmptyDataText="No Data Found...!" OnRowEditing="gv1_OnRowEditing" OnRowDeleting="gv1_OnRowDeleting">
                                    <Columns>
                                        <asp:TemplateField HeaderText="SNO.">
                                            <ItemTemplate>
                                                <%#Container.DataItemIndex  + 1 %>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:BoundField DataField="Locono" HeaderText="LOCO NO" />
                                        <asp:BoundField DataField="Loco_Date" HeaderText="DATE" />
                                        <asp:BoundField DataField="comp_name" HeaderText="NAME OF COMPONENT" />
                                        <asp:BoundField DataField="test_type" HeaderText="TYPE OF TEST" />
                                        
                                        <asp:BoundField DataField="suitable" HeaderText="SUITABLE" />
                                        <asp:BoundField DataField="rejected" HeaderText="REJECTED" />
                                        
                                        
                                        
                                        <%--<asp:TemplateField HeaderText="RESULT">
                        <ItemTemplate>
                        <asp:Label ID="l1" runat="server" Text='<%#Eval("suitable")%>'></asp:Label>
                        <asp:Label ID="Label1" runat="server" Text='<%#Eval("rejected")%>'></asp:Label>
                        </ItemTemplate>
                        </asp:TemplateField>--%>
                        
                        
                                        <asp:BoundField DataField="remarks" HeaderText="REMARK" />
                                        <%--<asp:BoundField DataField="testedby" HeaderText="TESTED BY" />--%>
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
                        <tr>
                            <td align="center" colspan="9">
                                <asp:Label ID="lblerro" runat="server" ForeColor="Red" Text="Data Already Exists...!"
                                    Visible="false"></asp:Label></td>
                        </tr>
                    </table>
                </div>
            </td>
        </tr>
    </table>
</asp:Content>
