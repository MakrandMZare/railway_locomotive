<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true" CodeFile="View_ShedPostion1.aspx.cs" Inherits="LocoShedPosition_View_ShedPostion1" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<%--<asp:ToolkitScriptManager runat="server" ID="ToolkitScriptManager1"></asp:ToolkitScriptManager>   
--%>
    
<table align="center">
        <tr>
            <th>
                SHED POSITION
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
                <%--<asp:GridView runat="server" ID="gv" AutoGenerateColumns="false">
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
                                <asp:Label runat="server" Text='<%#Eval("LOCO NO")%>' ID="Label1"></asp:Label>
                            </ItemTemplate>
                            
                        </asp:TemplateField>
                        
                        <asp:TemplateField>
                            <HeaderTemplate>
                                LAST OUT DATE
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label2" runat="server" Text='<%#Eval("LAST OUT DATE")%>'></asp:Label>
                            </ItemTemplate>
                            
                        </asp:TemplateField>
                        
                        <asp:TemplateField>
                            <HeaderTemplate>
                                TRAIN
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Labe3" runat="server" Text='<%#Eval("TRAIN")%>'></asp:Label>
                            </ItemTemplate>
                            
                        </asp:TemplateField>
                        
                        <asp:TemplateField>
                            <HeaderTemplate>
                              DUE SCHEDULE
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label4" runat="server" Text='<%#Eval("DUE SCHEDULE")%>'></asp:Label>
                            </ItemTemplate>
                            
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <HeaderTemplate>
                                SHED-ARRIVAL TIME
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label5" runat="server" Text='<%#Eval("TIME")%>'></asp:Label>
                            </ItemTemplate>
                            
                        </asp:TemplateField>
                        
                        <asp:TemplateField>
                            <HeaderTemplate>
                                SHED ARRIVAL DATE
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label6" runat="server" Text='<%#Eval("DATE")%>'></asp:Label>
                            </ItemTemplate>
                            
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <HeaderTemplate>
                                LOC
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label7" runat="server" Text=''></asp:Label>
                            </ItemTemplate>
                            
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <HeaderTemplate>
                                LFR%
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label8" runat="server" Text=''></asp:Label>
                            </ItemTemplate>
                            
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <HeaderTemplate>
                                PDC
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label9" runat="server" Text=''></asp:Label>
                            </ItemTemplate>
                            
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <HeaderTemplate>
                                REL
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label10" runat="server" Text=''></asp:Label>
                            </ItemTemplate>
                            
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <HeaderTemplate>
                                REMARKS
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label9" runat="server" Text='<%#Eval("REMARKS")%>'></asp:Label>
                            </ItemTemplate>
                            
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>--%>
                <asp:GridView runat="server" ID="gv" AutoGenerateColumns="false">
                    <Columns>
                        <asp:TemplateField>
                            <HeaderTemplate>
                                <asp:Label runat="server" ID="l1" Text="SN." Width="15px" Font-Size ="XX-Small" ></asp:Label>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <%#Container.DataItemIndex + 1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <HeaderTemplate>
                                <asp:Label runat="server" ID="l1" Text="LOCO NO." Width="50px" Font-Size ="XX-Small"></asp:Label>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label runat="server" Text='<%#Eval("LOCO NO")%>' ID="Label1"></asp:Label>
                            </ItemTemplate>
                            
                        </asp:TemplateField>
                        
                        <asp:TemplateField>
                            <HeaderTemplate>
                                <asp:Label runat="server" ID="l1" Text="LAST OUT DATE" Width="80px" Font-Size ="XX-Small"></asp:Label>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label2" runat="server" Text='<%#Eval("LAST OUT DATE")%>'></asp:Label>
                            </ItemTemplate>
                            
                        </asp:TemplateField>
                        
                        <asp:TemplateField>
                            <HeaderTemplate>
                                <asp:Label runat="server" ID="l1" Text="TRAIN" Width="40px" Font-Size ="XX-Small"></asp:Label>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Labe3" runat="server" Text='<%#Eval("TRAIN")%>'></asp:Label>
                            </ItemTemplate>
                            
                        </asp:TemplateField>
                        
                        <asp:TemplateField>
                            <HeaderTemplate>
                             <asp:Label runat="server" ID="l1" Text="DUE SCHEDULE" Width="80px" Font-Size ="XX-Small" ></asp:Label>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label4" runat="server" Text='<%#Eval("DUE SCHEDULE")%>'></asp:Label>
                            </ItemTemplate>
                            
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <HeaderTemplate>
                                
                                <asp:Label runat="server" ID="l1" Text="SHED-ARRIVAL TIME" Width="120px" Font-Size ="XX-Small"></asp:Label>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label5" runat="server" Text='<%#Eval("TIME")%>'></asp:Label>
                            </ItemTemplate>
                            
                        </asp:TemplateField>
                        
                        <asp:TemplateField>
                            <HeaderTemplate>
                                
                                <asp:Label runat="server" ID="l1" Text="SHED ARRIVAL DATE" Width="120px" Font-Size ="XX-Small"></asp:Label>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label6" runat="server" Text='<%#Eval("DATE")%>'></asp:Label>
                            </ItemTemplate>
                            
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <HeaderTemplate>
                                
                                <asp:Label runat="server" ID="l1" Text="LOC" Width="30px" Font-Size ="XX-Small" ></asp:Label>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label7" runat="server" Text=''></asp:Label>
                            </ItemTemplate>
                            
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <HeaderTemplate>
                                
                                <asp:Label runat="server" ID="l1" Text="LFR%" Width="30px" Font-Size ="XX-Small" ></asp:Label>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label8" runat="server" Text=''></asp:Label>
                            </ItemTemplate>
                            
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <HeaderTemplate>
                                
                                <asp:Label runat="server" ID="l1" Text="PDC" Width="30px" Font-Size ="XX-Small" ></asp:Label>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label9" runat="server" Text=''></asp:Label>
                            </ItemTemplate>
                            
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <HeaderTemplate>
                                
                                <asp:Label runat="server" ID="l1" Text="REL" Width="30px" Font-Size ="XX-Small" ></asp:Label>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label10" runat="server" Text=''></asp:Label>
                            </ItemTemplate>
                            
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <HeaderTemplate>
                                
                                <asp:Label runat="server" ID="l1" Text="REMARKS" Width="180px" Font-Size ="XX-Small" ></asp:Label>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label9" runat="server" Text='<%#Eval("REMARKS")%>'></asp:Label>
                            </ItemTemplate>
                            
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                </asp:Panel>
            </td>
        </tr>
        
        
    </table>
</asp:Content>

