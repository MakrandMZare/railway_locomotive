<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true" CodeFile="printComponantFailure.aspx.cs" Inherits="TestingLab_printComponantFailure" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table align="center">
        <tr>
            <th>
                RETAILS OF FAILURE COMPONENT&nbsp; DURING SCHEDULE TESTING BY NDT&nbsp;</th>
        </tr>
        <tr>
            <td>
                <table align="left">
                    <tr>
                        <td align="right" colspan="2">
                            CLASS &nbsp; &nbsp; &nbsp;
                        </td>
                        <td>
                            :</td>
                        <td>
                            <asp:DropDownList runat="server" ID="ddlclass" onfocus="ChangeStyle(this.id.toString());"
                                onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Width="88px" AutoPostBack="True" OnSelectedIndexChanged="ddlclass_SelectedIndexChanged">
                            </asp:DropDownList></td>
                        <td>
                            </td>
                        <td>
                            STARTING DATE</td>
                        <td>
                            :</td>
                        <td>
                            <asp:TextBox ID="txtstartdate" runat="server" onfocus="ChangeStyle(this.id.toString());"
                                onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:ImageButton runat="server" ID="btnPrint" ImageUrl="~/Images/printer_icon.jpg"
                                Height="20px" Width="20px" OnClick="btnPrint_Click" />
                        </td>
                        <td>
                            LOCO NO&nbsp;</td>
                        <td>
                            :
                        </td>
                        <td>
                            <asp:DropDownList runat="server" ID="ddlloco" onfocus="ChangeStyle(this.id.toString());"
                                onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" Width="88px" AutoPostBack="True"></asp:DropDownList> 
                        </td>
                        <td>
                            <asp:Button runat="server" ID="btnShow" Text="SHOW" onfocus="ChangeStyle(this.id.toString());"
                                onBlur="ChangeDefaultStyle(this.id.toString());" class="t2" OnClick="btnShow_OnClick"
                                Height="16px" />
                        </td>
                        <td>
                            ENDING DATE</td>
                        <td>
                            :</td>
                        <td>
                            <asp:TextBox ID="txtenddate" runat="server" class="t1" onblur="ChangeDefaultStyle(this.id.toString());"
                                onfocus="ChangeStyle(this.id.toString());"></asp:TextBox></td>
                        
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Panel runat="server" ID="p1">
                    &nbsp;&nbsp;
                    <asp:GridView ID="gvFailureComp" runat="server" AutoGenerateColumns="False" class="t1"
                     EmptyDataText="no data found"   onblur="ChangeDefaultStyle(this.id.toString());" onfocus="ChangeStyle(this.id.toString());"
                        Width="900px">
                        <Columns>
                            <asp:TemplateField HeaderText="NO.">
                                <ItemTemplate>
                                    <%#Container.DataItemIndex + 1 %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="LOCO NO">
                                <ItemTemplate>
                                    <asp:Label ID="l11" runat="server" Text='<%#Eval("locono")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="DATE">
                                <ItemTemplate>
                                    <asp:Label ID="l1" runat="server" Text='<%#Eval("l_date")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="NAME OF COMPONENT">
                                <ItemTemplate>
                                    <asp:Label ID="l3" runat="server" Text='<%#Eval("comp_name")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="TYPE OF TEST">
                                <ItemTemplate>
                                    <asp:Label ID="l4" runat="server" Text='<%#Eval("test_type")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="SUITABLE">
                                <ItemTemplate>
                                    <asp:Label ID="l5" runat="server" Text='<%#Eval("suitable")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="REJECTED">
                                <ItemTemplate>
                                    <asp:Label ID="l6" runat="server" Text='<%#Eval("rejected")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="REMARKS">
                                <ItemTemplate>
                                    <asp:Label ID="l7" runat="server" Text='<%#Eval("remarks")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="TESTED BY">
                                <ItemTemplate>
                                    <asp:Label ID="l8" runat="server" Text='<%#Eval("testedby")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <%--<asp:TemplateField HeaderText="Update">
                                <HeaderTemplate>
                                    ACTION
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:ImageButton ID="lbtnupdate" runat="server" ImageUrl="~/Images/Edit-icon.png"
                                        PostBackUrl='<%# "~/TestingLab/ComponantFailure.aspx?id="+ Eval("comp_id") + "&action=update" %>'
                                        Text="Update" />
                                    <asp:ImageButton ID="lbtnDelete" runat="server" ImageUrl="~/Images/Delete-icon.png"
                                        PostBackUrl='<%# "~/TestingLab/ComponantFailure.aspx?id="+ Eval("comp_id") + "&action=delete" %>'
                                        Text="Delete" />
                                </ItemTemplate>
                            </asp:TemplateField>--%>
                        </Columns>
                    </asp:GridView>
                </asp:Panel>
            </td>
        </tr>
    </table>
</asp:Content>

