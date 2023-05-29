<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true" CodeFile="View_LocoMovements.aspx.cs" Inherits="LocoShedPosition_View_LocoMovements" Title="Untitled Page" EnableEventValidation="false"%>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:ToolkitScriptManager runat="server" ID="ToolkitScriptManager1"></asp:ToolkitScriptManager>   
<table align="center">
        <tr>
            <th>
                EMD LOCOS UNDER TEMPORARY REPAIR
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
            <td><asp:Panel runat="server" ID="p1">
                <%--<asp:GridView runat="server" ID="gvLocoMovements" AutoGenerateColumns="false">
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
                LOCO NO.
                </HeaderTemplate>
                <ItemTemplate>
                <asp:Label runat="server" ID="Label1" Text='<%#Eval("LOCO NO")%>'></asp:Label>
                </ItemTemplate>
                </asp:TemplateField>
                
                <asp:TemplateField>
                <HeaderTemplate>
                DATE OF ARRIVAL
                </HeaderTemplate>
                <ItemTemplate>
                <asp:Label runat="server" ID="Label2" Text='<%#Eval("DATE OF ARRIVAL")%>'></asp:Label>
                </ItemTemplate>
                </asp:TemplateField>
                
                <asp:TemplateField>
                <HeaderTemplate>
                DOC
                </HeaderTemplate>
                <ItemTemplate>
                <asp:Label runat="server" ID="Label3" Text='<%#Eval("DOC")%>'></asp:Label>
                </ItemTemplate>
                </asp:TemplateField>
                
                 <asp:TemplateField>
                <HeaderTemplate>
                 LAST OUT
                </HeaderTemplate>
                <ItemTemplate>
                <asp:Label runat="server" ID="Label11" Text='<%#Eval("LAST OUT")%>'></asp:Label>
                </ItemTemplate>
                </asp:TemplateField>
                
                 <asp:TemplateField>
                <HeaderTemplate>
                LAST SCHEDULE
                </HeaderTemplate>
                <ItemTemplate>
                <asp:Label runat="server" ID="Label4" Text='<%#Eval("LAST SCH")%>'></asp:Label>
                </ItemTemplate>
                </asp:TemplateField>
                
                  <asp:TemplateField>
                <HeaderTemplate>
               REPAIR ATTENDED
                </HeaderTemplate>
                <ItemTemplate>
                <asp:Label runat="server" ID="Label5" Text='<%#Eval("REPAIR ATTENDED")%>'></asp:Label>
                </ItemTemplate>
                </asp:TemplateField>
                
                  <asp:TemplateField>
                <HeaderTemplate>
               DIV
                </HeaderTemplate>
                <ItemTemplate>
                <asp:Label runat="server" ID="Label6" Text='<%#Eval("DIV")%>'></asp:Label>
                </ItemTemplate>
                </asp:TemplateField>
                
                  <asp:TemplateField>
                <HeaderTemplate>
               SITE
                </HeaderTemplate>
                <ItemTemplate>
                <asp:Label runat="server" ID="Label7" Text='<%#Eval("SITE")%>'></asp:Label>
                </ItemTemplate>
                </asp:TemplateField>
                
                  <asp:TemplateField>
                <HeaderTemplate>
               SECTION
                </HeaderTemplate>
                <ItemTemplate>
                <asp:Label runat="server" ID="Label8" Text='<%#Eval("SECTION")%>'></asp:Label>
                </ItemTemplate>
                </asp:TemplateField>
                
                  <asp:TemplateField>
                <HeaderTemplate>
               REMARKS
                </HeaderTemplate>
                <ItemTemplate>
                <asp:Label runat="server" ID="Label9" Text='<%#Eval("REMARKS")%>'></asp:Label>
                </ItemTemplate>
                </asp:TemplateField>
                    
                    <asp:TemplateField>
                        <HeaderTemplate>
                            <asp:Label ID="Label10" runat="server" Text="ACTION"></asp:Label>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <table>
                                <tr>
                                    <td>
                                        <asp:ImageButton runat="server" ImageUrl="~/Images/Edit-icon.png" ID="lbtnUpdate"
                                            PostBackUrl='<%# "~/LocoShedPosition/Loco_Movement.aspx?id=" + Eval("tid") %>' />
                                    </td>
                                    <td>
                                        <asp:ImageButton runat="server" ImageUrl="~/Images/Delete-icon.png" ID="lbtnDelete"
                                            PostBackUrl='<%# "~/LocoShedPosition/View_LocoMovements.aspx?id=" + Eval("tid") %>' />
                                    </td>
                                </tr>
                            </table>
                        </ItemTemplate>
                    </asp:TemplateField>          
                </Columns>
                </asp:GridView>--%>
                <asp:GridView runat="server" ID="gvLocoMovements" AutoGenerateColumns="false">
                <Columns>
                <asp:TemplateField>
                <HeaderTemplate>
                
                <asp:Label runat="server" ID="l1" Text="SN." Width="50" Font-Size ="XX-Small" ></asp:Label>
                </HeaderTemplate>
                <ItemTemplate>
                <%#Container.DataItemIndex + 1 %>
                </ItemTemplate>
                </asp:TemplateField>
                
                <asp:TemplateField>
                <HeaderTemplate>
                
                <asp:Label runat="server" ID="l1" Text="LOCO NO." Width="50" Font-Size ="XX-Small" ></asp:Label>
                </HeaderTemplate>
                <ItemTemplate>
                <asp:Label runat="server" ID="Label1" Text='<%#Eval("LOCO NO")%>'></asp:Label>
                </ItemTemplate>
                </asp:TemplateField>
                
                <asp:TemplateField>
                <HeaderTemplate>
                
                <asp:Label runat="server" ID="l1" Text="DATE OF ARRIVAL" Width="50" Font-Size ="XX-Small" ></asp:Label>
                </HeaderTemplate>
                <ItemTemplate>
                <asp:Label runat="server" ID="Label2" Text='<%#Eval("DATE OF ARRIVAL")%>'></asp:Label>
                </ItemTemplate>
                </asp:TemplateField>
                
                <asp:TemplateField>
                <HeaderTemplate>
                
                <asp:Label runat="server" ID="l1" Text="DOC" Width="50" Font-Size ="XX-Small" ></asp:Label>
                </HeaderTemplate>
                <ItemTemplate>
                <asp:Label runat="server" ID="Label3" Text='<%#Eval("DOC")%>'></asp:Label>
                </ItemTemplate>
                </asp:TemplateField>
                
                 <asp:TemplateField>
                <HeaderTemplate>
                 
                 <asp:Label runat="server" ID="l1" Text="LAST OUT" Width="50" Font-Size ="XX-Small" ></asp:Label>
                </HeaderTemplate>
                <ItemTemplate>
                <asp:Label runat="server" ID="Label11" Text='<%#Eval("LAST OUT")%>'></asp:Label>
                </ItemTemplate>
                </asp:TemplateField>
                
                 <asp:TemplateField>
                <HeaderTemplate>
                
                <asp:Label runat="server" ID="l1" Text="LAST SCHEDULE" Width="50" Font-Size ="XX-Small" ></asp:Label>
                </HeaderTemplate>
                <ItemTemplate>
                <asp:Label runat="server" ID="Label4" Text='<%#Eval("LAST SCH")%>'></asp:Label>
                </ItemTemplate>
                </asp:TemplateField>
                
                  <asp:TemplateField>
                <HeaderTemplate>
               
               <asp:Label runat="server" ID="l1" Text="REPAIR ATTENDED" Width="50" Font-Size ="XX-Small" ></asp:Label>
                </HeaderTemplate>
                <ItemTemplate>
                <asp:Label runat="server" ID="Label5" Text='<%#Eval("REPAIR ATTENDED")%>'></asp:Label>
                </ItemTemplate>
                </asp:TemplateField>
                
                  <asp:TemplateField>
                <HeaderTemplate>
               
               <asp:Label runat="server" ID="l1" Text="DIV" Width="50" Font-Size ="XX-Small" ></asp:Label>
                </HeaderTemplate>
                <ItemTemplate>
                <asp:Label runat="server" ID="Label6" Text='<%#Eval("DIV")%>'></asp:Label>
                </ItemTemplate>
                </asp:TemplateField>
                
                  <asp:TemplateField>
                <HeaderTemplate>
               
               <asp:Label runat="server" ID="l1" Text="SITE" Width="50" Font-Size ="XX-Small" ></asp:Label>
                </HeaderTemplate>
                <ItemTemplate>
                <asp:Label runat="server" ID="Label7" Text='<%#Eval("SITE")%>'></asp:Label>
                </ItemTemplate>
                </asp:TemplateField>
                
                  <asp:TemplateField>
                <HeaderTemplate>
               
               <asp:Label runat="server" ID="l1" Text="SECTION" Width="50" Font-Size ="XX-Small" ></asp:Label>
                </HeaderTemplate>
                <ItemTemplate>
                <asp:Label runat="server" ID="Label8" Text='<%#Eval("SECTION")%>'></asp:Label>
                </ItemTemplate>
                </asp:TemplateField>
                
                  <asp:TemplateField>
                <HeaderTemplate>
               
               <asp:Label runat="server" ID="l1" Text="REMARKS" Width="50" Font-Size ="XX-Small" ></asp:Label>
                </HeaderTemplate>
                <ItemTemplate>
                <asp:Label runat="server" ID="Label9" Text='<%#Eval("REMARKS")%>'></asp:Label>
                </ItemTemplate>
                </asp:TemplateField>
                    
                    <asp:TemplateField>
                        <HeaderTemplate>
                            <asp:Label ID="Label10" runat="server" Width ="40px" Font-Size="XX-Small" Text="ACTION"></asp:Label>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <table>
                                <tr>
                                    <td>
                                        <asp:ImageButton runat="server" Width="10px" ImageUrl="~/Images/Edit-icon.png" ID="lbtnUpdate"
                                            PostBackUrl='<%# "~/LocoShedPosition/Loco_Movement.aspx?id=" + Eval("tid") %>' />
                                    </td>
                                    <td>
                                        <asp:ImageButton runat="server" Width="10px" ImageUrl="~/Images/Delete-icon.png" ID="lbtnDelete"
                                            PostBackUrl='<%# "~/LocoShedPosition/View_LocoMovements.aspx?id=" + Eval("tid") %>' />
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

