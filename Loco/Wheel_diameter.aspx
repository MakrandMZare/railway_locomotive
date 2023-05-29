<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true"
    CodeFile="Wheel_diameter.aspx.cs" Inherits="Loco_Wheel_diameter" Title="Untitled Page" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table width="888">
        <tr>
            <th colspan="8">
                WHEEL DIAMETER</th>
        </tr>
        <tr>
            <td>
                CLASS</td>
            <td>
                :</td>
            <td>
                <%--
                <asp:DropDownList ID="ddlClass" runat="server" AutoPostBack="True" CssClass="t1"
                    OnSelectedIndexChanged="ddlClass_SelectedIndexChanged">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList>--%>
                <asp:DropDownList ID="ddlClass" runat="server" AutoPostBack="True" CssClass="t1"
                    OnSelectedIndexChanged="ddlClass_SelectedIndexChanged">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                LOCO NO</td>
            <td>
                :</td>
            <td>
                <asp:DropDownList ID="ddlLocono" runat="server" AutoPostBack="True" CssClass="t1"
                    OnSelectedIndexChanged="ddlLocono_OnSelectedIndexChanged">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList></td>
            <td>
                DOC</td>
            <td>
                :</td>
            <td>
                <asp:TextBox ID="txtdoc" runat="server" CssClass="t1" Width="109px"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                SCHEDULE</td>
            <td>
                :</td>
            <td>
                <asp:DropDownList ID="ddlSchedule" runat="server" CssClass="t1">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td>
                DATE</td>
            <td>
                :</td>
            <td>
                <asp:TextBox ID="txtdate" runat="server" CssClass="t1" Width="109px"></asp:TextBox></td>
            <td>
                DIA</td>
            <td>
                :</td>
            <td>
                <asp:TextBox ID="txtdia" runat="server" CssClass="t1" Width="49px"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="3" rowspan="7">
                <asp:Panel ID="Panel1" runat="server" Width="125px">
                    <table style="width: 380px; height: 180px">
                        <tr>
                            <th colspan="5">
                                LEFT SIDE WHEEL</th>
                        </tr>
                        <tr>
                            <td>
                            </td>
                            <td>
                            </td>
                            <td>
                                ROOT</td>
                            <td>
                                PROFILE</td>
                            <td>
                                HOLLOWNESS</td>
                        </tr>
                        <tr>
                            <td>
                                WHEEL1</td>
                            <td>
                                :</td>
                            <td>
                                <asp:TextBox ID="lr1" runat="server" CssClass="t1" Width="49px"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="lp1" runat="server" CssClass="t1" Width="49px"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="ph1" runat="server" CssClass="t1" Width="49px"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>
                                WHEEL2</td>
                            <td>
                                :</td>
                            <td>
                                <asp:TextBox ID="lr2" runat="server" CssClass="t1" Width="49px"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="lp2" runat="server" CssClass="t1" Width="49px"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="ph2" runat="server" CssClass="t1" Width="49px"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>
                                WHEEL3</td>
                            <td>
                                :</td>
                            <td>
                                <asp:TextBox ID="lr3" runat="server" CssClass="t1" Width="49px"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="lp3" runat="server" CssClass="t1" Width="49px"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="ph3" runat="server" CssClass="t1" Width="49px"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>
                                WHEEL4</td>
                            <td>
                                :</td>
                            <td>
                                <asp:TextBox ID="lr4" runat="server" CssClass="t1" Width="49px"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="lp4" runat="server" CssClass="t1" Width="49px"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="ph4" runat="server" CssClass="t1" Width="49px"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>
                                WHEEL5</td>
                            <td>
                                :</td>
                            <td>
                                <asp:TextBox ID="lr5" runat="server" CssClass="t1" Width="49px"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="lp5" runat="server" CssClass="t1" Width="49px"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="ph5" runat="server" CssClass="t1" Width="49px"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>
                                WHEEL6</td>
                            <td>
                                :</td>
                            <td>
                                <asp:TextBox ID="lr6" runat="server" CssClass="t1" Width="49px"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="lp6" runat="server" CssClass="t1" Width="49px"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="ph6" runat="server" CssClass="t1" Width="49px"></asp:TextBox></td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
            <td colspan="4" rowspan="7">
                <asp:Panel ID="Panel2" runat="server" Width="125px">
                    <table style="width: 380px; height: 180px">
                        <tr>
                            <th colspan="5">
                                RIGHT SIDE WHEEL</th>
                        </tr>
                        <tr>
                            <td>
                            </td>
                            <td>
                            </td>
                            <td>
                                ROOT</td>
                            <td>
                                PROFILE</td>
                            <td>
                                HOLLOWNESS</td>
                        </tr>
                        <tr>
                            <td>
                                WHEEL1</td>
                            <td>
                                :</td>
                            <td>
                                <asp:TextBox ID="rr1" runat="server" CssClass="t1" Width="49px"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="rp1" runat="server" CssClass="t1" Width="49px"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="rh1" runat="server" CssClass="t1" Width="49px"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>
                                WHEEL2</td>
                            <td>
                                :</td>
                            <td>
                                <asp:TextBox ID="rr2" runat="server" CssClass="t1" Width="49px"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="rp2" runat="server" CssClass="t1" Width="49px"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="rh2" runat="server" CssClass="t1" Width="49px"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>
                                WHEEL3</td>
                            <td>
                                :</td>
                            <td>
                                <asp:TextBox ID="rr3" runat="server" CssClass="t1" Width="49px"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="rp3" runat="server" CssClass="t1" Width="49px"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="rh3" runat="server" CssClass="t1" Width="49px"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>
                                WHEEL4</td>
                            <td>
                                :</td>
                            <td>
                                <asp:TextBox ID="rr4" runat="server" CssClass="t1" Width="49px"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="rp4" runat="server" CssClass="t1" Width="49px"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="rh4" runat="server" CssClass="t1" Width="49px"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>
                                WHEEL5</td>
                            <td>
                                :</td>
                            <td>
                                <asp:TextBox ID="rr5" runat="server" CssClass="t1" Width="49px"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="rp5" runat="server" CssClass="t1" Width="49px"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="rh5" runat="server" CssClass="t1" Width="49px"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>
                                WHEEL6</td>
                            <td>
                                :</td>
                            <td>
                                <asp:TextBox ID="rr6" runat="server" CssClass="t1" Width="49px"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="rp6" runat="server" CssClass="t1" Width="49px"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="rh6" runat="server" CssClass="t1" Width="49px"></asp:TextBox></td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
        <tr>
        </tr>
        <tr>
        </tr>
        <tr>
        </tr>
        <tr>
        </tr>
        <tr>
        </tr>
        <tr>
        </tr>
        <tr>
            <td align="left" colspan="7" rowspan="1">
                <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
                </cc1:ToolkitScriptManager>
                <cc1:CalendarExtender ID="CalendarExtender1" runat="server" Format="dd/MM/yyyy" TargetControlID="txtdoc">
                </cc1:CalendarExtender>
                <cc1:CalendarExtender ID="CalendarExtender2" runat="server" Format="dd/MM/yyyy" TargetControlID="txtdate">
                </cc1:CalendarExtender>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="7" rowspan="1">
                <asp:Button ID="btnInsert" runat="server" CssClass="t1" Text="INSERT" OnClick="btnInsert_Click" />
                &nbsp;
                <asp:Button ID="btnCancel" runat="server" CssClass="t1" Text="CANCEL" /></td>
        </tr>
        <tr>
            <td align="left" colspan="7" rowspan="1">
                <%--<asp:GridView runat="Server" ID="GridView1" DataKeyNames="hsd_id" AutoGenerateColumns="false"
                    EmptyDataText="No Data Found...!" OnRowEditing="gv1_OnRowEditing" OnRowDeleting="gv1_OnRowDeleting">
                    <Columns>--%>
                <asp:DataList ID="gv1"  runat="server" Width="777">
                    <ItemTemplate>
                    <table>
                    <tr>
                           <td>
                           
                        <table width="555">
                            <tr>
                                <td>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    LOCO NO</td>
                                <td>
                                    :</td>
                                <td>
                                    <asp:Label ID="q1" runat="server" Text='<%#Eval("locono")%>' /></td>
                                <td>
                                    DOC
                                </td>
                                <td>
                                    :</td>
                                <td>
                                    <asp:Label ID="q2" runat="server" Text='<%#Eval("doc")%>' />
                                </td>
                                <td>
                                    SCHEDULE
                                </td>
                                <td>
                                    :</td>
                                <td>
                                    <asp:Label ID="Label1" runat="server" Text='<%#Eval("s_type")%>' />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    DATE</td>
                                <td>
                                    :</td>
                                <td>
                                    <asp:Label ID="q4" runat="server" Text='<%#Eval("w_date")%>' />
                                </td>
                                <td>
                                    DIA</td>
                                <td>
                                    :</td>
                                <td>
                                    <asp:Label ID="q5" runat="server" Text='<%#Eval("dia")%>' /></td>
                            </tr>
                        </table>
                        <table width="100%">
                            <tr>
                                <td>
                                    <table width="100%">
                                        <tr align="center" >
                                            <td colspan="6">
                                                LEFT SIDE WHEEL
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                            </td>
                                            <td>
                                            </td>
                                            <td>
                                                ROOT</td>
                                            <td>
                                                PROFILE</td>
                                            <td>
                                                HOLLOWNESS</td>
                                        </tr>
                                        <tr>
                                            <td>
                                                WHEEL1</td>
                                            <td>
                                                :</td>
                                            <td>
                                                <asp:Label ID="r1" runat="server" Text='<%#Eval("r1")%>' /></td>
                                            <td>
                                                <asp:Label ID="p1q" runat="server" Text='<%#Eval("p1")%>' /></td>
                                            <td>
                                                <asp:Label ID="h1q" Text='<%#Eval("h1")%>' runat="server" /></td>
                                        </tr>
                                        <tr>
                                            <td>
                                                WHEEL2</td>
                                            <td>
                                                :</td>
                                            <td>
                                                <asp:Label ID="r2q" runat="server" Text='<%#Eval("r2")%>' /></td>
                                            <td>
                                                <asp:Label ID="p2q" runat="server" Text='<%#Eval("p2")%>' /></td>
                                            <td>
                                                <asp:Label ID="h2q" Text='<%#Eval("h2")%>' runat="server" /></td>
                                        </tr>
                                        <tr>
                                            <td>WHEEL3
                                            </td>
                                            <td>:
                                            </td>
                                            <td>
                                                <asp:Label ID="r3q" runat="server" Text='<%#Eval("r3")%>' /></td>
                                            <td>
                                                <asp:Label ID="p3q" runat="server" Text='<%#Eval("p3")%>' /></td>
                                            <td>
                                                <asp:Label ID="h3q" Text='<%#Eval("h3")%>' runat="server" /></td>
                                        </tr>
                                        <tr>
                                            <td>WHEEL4
                                            </td>
                                            <td>:
                                            </td>
                                            <td>
                                                <asp:Label ID="r4q" runat="server" Text='<%#Eval("r4")%>' /></td>
                                            <td>
                                                <asp:Label ID="p5q" runat="server" Text='<%#Eval("p4")%>' /></td>
                                            <td>
                                                <asp:Label ID="h6q" Text='<%#Eval("h4")%>' runat="server" /></td>
                                        </tr>
                                        <tr>
                                            <td>WHEEL5
                                            </td>
                                            <td>:
                                            </td>
                                            <td>
                                                <asp:Label ID="Label4q" runat="server" Text='<%#Eval("r5")%>' /></td>
                                            <td>
                                                <asp:Label ID="Label5q" runat="server" Text='<%#Eval("p5")%>' /></td>
                                            <td>
                                                <asp:Label ID="Label6q" Text='<%#Eval("h5")%>' runat="server" /></td>
                                        </tr>
                                        <tr>
                                            <td>WHEEL6
                                            </td>
                                            <td>:
                                            </td>
                                            <td>
                                                <asp:Label ID="Label7q" runat="server" Text='<%#Eval("r6")%>' /></td>
                                            <td>
                                                <asp:Label ID="Label8q" runat="server" Text='<%#Eval("p6")%>' /></td>
                                            <td>
                                                <asp:Label ID="Label9q" Text='<%#Eval("h6")%>' runat="server" /></td>
                                        </tr>
                                    </table>
                                </td>
                                <td>
                                    <table width="100%">
                                      <tr align="center" >
                                            <td colspan="6">
                                                RIGHT SIDE WHEEL
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                            </td>
                                            <td>
                                            </td>
                                            <td>
                                                ROOT</td>
                                            <td>
                                                PROFILE</td>
                                            <td>
                                                HOLLOWNESS</td>
                                        </tr>
                                        <tr>
                                            <td>
                                                WHEEL1</td>
                                            <td>
                                                :</td>
                                            <td>
                                                <asp:Label ID="Label2" runat="server" Text='<%#Eval("r7")%>' /></td>
                                            <td>
                                                <asp:Label ID="p1" runat="server" Text='<%#Eval("p7")%>' /></td>
                                            <td>
                                                <asp:Label ID="h1" Text='<%#Eval("h7")%>' runat="server" /></td>
                                        </tr>
                                        <tr>
                                            <td>
                                                WHEEL2</td>
                                            <td>
                                                :</td>
                                            <td>
                                                <asp:Label ID="r2" runat="server" Text='<%#Eval("r8")%>' /></td>
                                            <td>
                                                <asp:Label ID="p2" runat="server" Text='<%#Eval("p8")%>' /></td>
                                            <td>
                                                <asp:Label ID="h2" Text='<%#Eval("h8")%>' runat="server" /></td>
                                        </tr>
                                        <tr>
                                            <td>WHEEL3
                                            </td>
                                            <td>:
                                            </td>
                                            <td>
                                                <asp:Label ID="r3" runat="server" Text='<%#Eval("r9")%>' /></td>
                                            <td>
                                                <asp:Label ID="p3" runat="server" Text='<%#Eval("p9")%>' /></td>
                                            <td>
                                                <asp:Label ID="h3" Text='<%#Eval("h9")%>' runat="server" /></td>
                                        </tr>
                                        <tr>
                                            <td>WHEEL4
                                            </td>
                                            <td>:
                                            </td>
                                            <td>
                                                <asp:Label ID="r4" runat="server" Text='<%#Eval("r10")%>' /></td>
                                            <td>
                                                <asp:Label ID="p5" runat="server" Text='<%#Eval("p10")%>' /></td>
                                            <td>
                                                <asp:Label ID="h6" Text='<%#Eval("h10")%>' runat="server" /></td>
                                        </tr>
                                        <tr>
                                            <td>WHEEL5
                                            </td>
                                            <td>:
                                            </td>
                                            <td>
                                                <asp:Label ID="Label4" runat="server" Text='<%#Eval("r11")%>' /></td>
                                            <td>
                                                <asp:Label ID="Label5" runat="server" Text='<%#Eval("p11")%>' /></td>
                                            <td>
                                                <asp:Label ID="Label6" Text='<%#Eval("h11")%>' runat="server" /></td>
                                        </tr>
                                        <tr>
                                            <td>WHEEL6
                                            </td>
                                            <td>:
                                            </td>
                                            <td>
                                                <asp:Label ID="Label7" runat="server" Text='<%#Eval("r12")%>' /></td>
                                            <td>
                                                <asp:Label ID="Label8" runat="server" Text='<%#Eval("p12")%>' /></td>
                                            <td>
                                                <asp:Label ID="Label9" Text='<%#Eval("h12")%>' runat="server" /></td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    
                               <%-- <table>
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
                                </table>--%>
                           
                           </td>
                           </tr> 
                            
                            </table>
                            </ItemTemplate>
                </asp:DataList>
                <br />
            </td>
        </tr>
    </table>
</asp:Content>
