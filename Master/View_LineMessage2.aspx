<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true" CodeFile="View_LineMessage2.aspx.cs" Inherits="LocoShedPosition_View_LineMessage2" Title="Untitled Page" EnableEventValidation="false"%>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:ToolkitScriptManager runat="server" ID="ToolkitScriptManager1"></asp:ToolkitScriptManager>   
<table align="center">
        <tr>
            <th>
                LINE MESSAGES 2
            </th>
        </tr>
        <tr><td><asp:ImageButton runat="server" ID="btnPrint" 
                    ImageUrl="~/Images/printer_icon.jpg" Height="20px" Width="20px" Visible="false" 
                    onclick="btnPrint_Click"/></td>
            <td align="right">
                DATE
            </td>
            <td>
                :
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtDate" onfocus="ChangeStyle(this.id.toString());"
                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
                <asp:CalendarExtender runat="server" ID="CalendarExtender1" TargetControlID="txtDate"
                    Format="dd/MM/yyyy">
                </asp:CalendarExtender>
            </td>
            <td>
                <asp:Button runat="server" ID="btnShow" Text="SHOW" onfocus="ChangeStyle(this.id.toString());"
                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t2" OnClick="btnShow_OnClick" />
            </td>
        </tr>
        <tr>
            <td>
            <asp:Panel runat="server" ID="p1">
                <%--<asp:GridView runat="server" ID="gvTemporaryRepair" AutoGenerateColumns="false">
                    <Columns>
                        <asp:TemplateField>
                            <HeaderTemplate>
                                SN.
                            </HeaderTemplate>
                            <ItemTemplate>
                                <%#Container.DataItemIndex + 1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <HeaderTemplate>
                                LOCO NO
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label runat="server" Text='<%#Eval("LOCO NO") + "-" +  Eval("DATE")%>' ID="Label1"></asp:Label>
                            </ItemTemplate>
                            
                        </asp:TemplateField>
                        
                        <asp:TemplateField>
                            <HeaderTemplate>
                                D/W
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label2" runat="server" Text='<%#Eval("D/W")%>'></asp:Label>
                            </ItemTemplate>
                            
                        </asp:TemplateField>
                        
                        <asp:TemplateField>
                            <HeaderTemplate>
                                TRAINONO - LOAD
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Labe3" runat="server" Text='<%#Eval("TRNO") + " - " + Eval("LOAD")%>'></asp:Label>
                            </ItemTemplate>
                            
                        </asp:TemplateField>
                        
                        <asp:TemplateField>
                            <HeaderTemplate>
                               GRAD
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label4" runat="server" Text='<%#Eval("GRAD")%>'></asp:Label>
                            </ItemTemplate>
                            
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <HeaderTemplate>
                                REPOTED REASON
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label5" runat="server" Text='<%#Eval("REPOTED REASON")%>'></asp:Label>
                            </ItemTemplate>
                            
                        </asp:TemplateField>
                        
                        <asp:TemplateField>
                            <HeaderTemplate>
                                LAST SCHEDULE
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label6" runat="server" Text='<%#"DOC -" + Eval("DOC") + Eval("LAST") + Eval("LAST SCH") %>'></asp:Label>
                            </ItemTemplate>
                            
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <HeaderTemplate>
                                <asp:Label ID="Label7" runat="server" Text="ACTION"></asp:Label>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <table>
                                    <tr>
                                        <td>
                                            <asp:ImageButton runat="server" ImageUrl="~/Images/Edit-icon.png" ID="lbtnUpdate"
                                                PostBackUrl='<%# "~/LocoShedPosition/LineMessage2.aspx?id=" + Eval("rid") %>' />
                                        </td>
                                        <td>
                                            <asp:ImageButton runat="server" ImageUrl="~/Images/Delete-icon.png" ID="lbtnDelete"
                                                PostBackUrl='<%# "~/LocoShedPosition/View_LineMessage2.aspx?id=" + Eval("rid") %>' />
                                        </td>
                                    </tr>
                                </table>
                            </ItemTemplate>
                        </asp:TemplateField>
                        
                        
                        
                    </Columns>
                </asp:GridView>--%>
                <asp:GridView runat="server" ID="gvTemporaryRepair" AutoGenerateColumns="false">
                    <Columns>
                        <asp:TemplateField>
                            <HeaderTemplate>
                                
                                <asp:Label runat="server" ID="l1" Text="SN." Width="15" Font-Size ="XX-Small" ></asp:Label>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <%#Container.DataItemIndex + 1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <HeaderTemplate>
                                
                                <asp:Label runat="server" ID="l1" Text="LOCO NO" Width="50" Font-Size ="XX-Small" ></asp:Label>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label runat="server" Text='<%#Eval("LOCO NO") + "-" +  Eval("DATE")%>' ID="Label1"></asp:Label>
                            </ItemTemplate>
                            
                        </asp:TemplateField>
                        
                        <asp:TemplateField>
                            <HeaderTemplate>
                                
                                <asp:Label runat="server" ID="l1" Text="D/W" Width="30" Font-Size ="XX-Small" ></asp:Label>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label2" runat="server" Text='<%#Eval("D/W")%>'></asp:Label>
                            </ItemTemplate>
                            
                        </asp:TemplateField>
                        
                        <asp:TemplateField>
                            <HeaderTemplate>
                                
                                <asp:Label runat="server" ID="l1" Text="TRAINONO - LOAD" Width="100" Font-Size ="XX-Small" ></asp:Label>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Labe3" runat="server" Text='<%#Eval("TRNO") + " - " + Eval("LOAD")%>'></asp:Label>
                            </ItemTemplate>
                            
                        </asp:TemplateField>
                        
                        <asp:TemplateField>
                            <HeaderTemplate>
                               
                               <asp:Label runat="server" ID="l1" Text="GRAD" Width="40" Font-Size ="XX-Small" ></asp:Label>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label4" runat="server" Text='<%#Eval("GRAD")%>'></asp:Label>
                            </ItemTemplate>
                            
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <HeaderTemplate>
                                
                                <asp:Label runat="server" ID="l1" Text="REPOTED REASON" Width="100" Font-Size ="XX-Small" ></asp:Label>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label5" runat="server" Text='<%#Eval("REPOTED REASON")%>'></asp:Label>
                            </ItemTemplate>
                            
                        </asp:TemplateField>
                        
                        <asp:TemplateField>
                            <HeaderTemplate>
                                
                                <asp:Label runat="server" ID="l1" Text="LAST SCHEDULE" Width="100" Font-Size ="XX-Small" ></asp:Label>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label6" runat="server" Text='<%#"DOC -" + Eval("DOC") + Eval("LAST") + Eval("LAST SCH") %>'></asp:Label>
                            </ItemTemplate>
                            
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <HeaderTemplate>
                                <asp:Label ID="Label7" runat="server"  Width="40" Font-Size ="XX-Small" Text="ACTION"></asp:Label>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <table>
                                    <tr>
                                        <td>
                                            <asp:ImageButton runat="server" Width="10px" ImageUrl="~/Images/Edit-icon.png" ID="lbtnUpdate"
                                                PostBackUrl='<%# "~/LocoShedPosition/LineMessage2.aspx?id=" + Eval("rid") %>' />
                                        </td>
                                        <td>
                                            <asp:ImageButton runat="server" Width="10px" ImageUrl="~/Images/Delete-icon.png" ID="lbtnDelete"
                                                PostBackUrl='<%# "~/LocoShedPosition/View_LineMessage2.aspx?id=" + Eval("rid") %>' />
                                        </td>
                                    </tr>
                                </table>
                            </ItemTemplate>
                        </asp:TemplateField>
                        
                        
                        
                    </Columns>
                </asp:GridView>
                </asp:Panel>
                
            </td>
        </tr>
        
        
    </table>
</asp:Content>

