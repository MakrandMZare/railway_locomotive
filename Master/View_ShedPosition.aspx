<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true" CodeFile="View_ShedPosition.aspx.cs" Inherits="LocoShedPosition_View_ShedPosition" Title="Untitled Page" EnableEventValidation="false"%>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<%--<asp:ToolkitScriptManager runat="server" ID="ToolkitScriptManager1"></asp:ToolkitScriptManager>       
--%>
    <asp:ToolkitScriptManager runat="server">
    </asp:ToolkitScriptManager>
<table align="center">


        <tr>
            <th>
                LINE MESSAGES 1
            </th>
        </tr>
        <tr>
           <td><asp:ImageButton runat="server" ID="btnPrint" 
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
            <td><asp:Panel runat="server" ID="p1">
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
                                LOCO NO DATE
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label runat="server" Text='<%#Eval("LOCO NO") + "-" +  Eval("DATE")%>' ID="Label1"></asp:Label>
                            </ItemTemplate>
                            </asp:TemplateField>
                            
                             <asp:TemplateField>
                                                
                            <HeaderTemplate>
                                TRAIN NO - SITE - SECTION
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label runat="server" Text='<%#Eval("TRAIN NO") + "-" + Eval("SITE") + "-" +  Eval("SECTION")%>' ID="Label2"></asp:Label>
                            </ItemTemplate>
                            </asp:TemplateField>
                            
                            <asp:TemplateField>
                                                
                            <HeaderTemplate>
                                LINE MESSAGE
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label runat="server" Text='<%#Eval("LINE MESSAGE") %>' ID="Label3"></asp:Label>
                            </ItemTemplate>
                            </asp:TemplateField>
                            
                             <asp:TemplateField>
                                                
                            <HeaderTemplate>
                                LAST SCHEDULE
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label runat="server" Text='<%#"DOC" +"-" + Eval("DOC")+ "-" + Eval("LAST SCH")  + "-" + Eval("LAST") %>' ID="Label5"></asp:Label>
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
                                                PostBackUrl='<%# "~/LocoShedPosition/shedposition2.aspx?id=" + Eval("tid") %>' />
                                        </td>
                                        <td>
                                            <asp:ImageButton runat="server" ImageUrl="~/Images/Delete-icon.png" ID="lbtnDelete"
                                                PostBackUrl='<%# "~/LocoShedPosition/View_shedposition.aspx?id=" + Eval("tid") %>' />
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
                                
                                <asp:Label runat="server" ID="l1" Text="SN." Width="15px" Font-Size ="XX-Small" ></asp:Label>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <%#Container.DataItemIndex + 1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
                       
                         <asp:TemplateField>
                            <HeaderTemplate>
                            
                               <asp:Label runat="server" ID="l1" Text="LOCO NO DATE" Width="80px" Font-Size ="XX-Small" ></asp:Label>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label runat="server" Text='<%#Eval("LOCO NO") + "-" +  Eval("DATE")%>' ID="Label1"></asp:Label>
                            </ItemTemplate>
                            </asp:TemplateField>
                            
                             <asp:TemplateField>
                                                
                            <HeaderTemplate>
                               
                               <asp:Label runat="server" ID="l1" Text="TRAIN NO - SITE - SECTION" Width="140" Font-Size ="XX-Small" ></asp:Label>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label runat="server" Text='<%#Eval("TRAIN NO") + "-" + Eval("SITE") + "-" +  Eval("SECTION")%>' ID="Label2"></asp:Label>
                            </ItemTemplate>
                            </asp:TemplateField>
                            
                            <asp:TemplateField>
                                                
                            <HeaderTemplate>
                                
                                <asp:Label runat="server" ID="l1" Text="LINE MESSAGE" Width="80" Font-Size ="XX-Small" ></asp:Label>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label runat="server" Text='<%#Eval("LINE MESSAGE") %>' ID="Label3"></asp:Label>
                            </ItemTemplate>
                            </asp:TemplateField>
                            
                             <asp:TemplateField>
                                                
                            <HeaderTemplate>
                                
                                <asp:Label runat="server" ID="l1" Text="LAST SCHEDULE" Width="100" Font-Size ="XX-Small" ></asp:Label>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label runat="server" Text='<%#"DOC" +"-" + Eval("DOC")+ "-" + Eval("LAST SCH")  + "-" + Eval("LAST") %>' ID="Label5"></asp:Label>
                            </ItemTemplate>
                            </asp:TemplateField>
                                                    
                        
                        <asp:TemplateField>
                            <HeaderTemplate>
                            <asp:Label runat="server" ID="l1" Text="ACTION" Width="40" Font-Size ="XX-Small" ></asp:Label>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <table>
                                    <tr>
                                        <td>
                                            <asp:ImageButton Width="10px" runat="server" ImageUrl="~/Images/Edit-icon.png" ID="lbtnUpdate"
                                                PostBackUrl='<%# "~/LocoShedPosition/shedposition2.aspx?id=" + Eval("tid") %>' />
                                        </td>
                                        <td>
                                            <asp:ImageButton Width="10px" runat="server" ImageUrl="~/Images/Delete-icon.png" ID="lbtnDelete"
                                                PostBackUrl='<%# "~/LocoShedPosition/View_shedposition.aspx?id=" + Eval("tid") %>' />
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

