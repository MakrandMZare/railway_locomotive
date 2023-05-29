﻿<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true"
    CodeFile="View_LocoIn.aspx.cs" Inherits="Loco_View_LocoIn" Title="Sabarmati Diesels : Report Loco In" EnableEventValidation="false"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table align="center">
        <tr>
            <td>
                LOCO IN
            </td>
        </tr>
        <tr>
        <td><asp:ImageButton runat="server" ID="btnPrint" 
                    ImageUrl="~/Images/printer_icon.jpg" Height="20px" Width="20px" Visible="false" 
                    onclick="btnPrint_Click"/></td>
        </tr>
        <tr><asp:Panel runat="server" ID="p1">
            <asp:GridView runat="server" ID="gvLocoIn" AutoGenerateColumns="false">
                <Columns>
                    <asp:TemplateField>
                        <HeaderTemplate>
                            <asp:Label ID="Label1" runat="server" Text="NO" Width="15px" Font-Size ="XX-Small"></asp:Label>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <%#Container.DataItemIndex  + 1 %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <HeaderTemplate>
                            <asp:Label ID="Label1" runat="server" Text="LOCO TYPE"></asp:Label>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <asp:Label runat="server" ID="l1" Text='<%#Eval("Class")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <HeaderTemplate>
                            <asp:Label ID="Label1" runat="server" Text="LOCO NO"></asp:Label>
                        </HeaderTemplate>
                        <ItemTemplate>
                       
                       <asp:Label runat="server" ID="l2" Text='<%#Eval("Loco No")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <HeaderTemplate>
                            <asp:Label ID="Label1" runat="server" Text="ARRIVAL DATE"></asp:Label>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <asp:Label runat="server" ID="l3" Text='<%#Eval("Arrival Date")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <HeaderTemplate>
                            <asp:Label ID="Label1" runat="server" Text="ARRIVAL TIME"></asp:Label>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <asp:Label runat="server" ID="l4" Text='<%#Eval("Arrival time")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <HeaderTemplate>
                            <asp:Label ID="Label1" runat="server" Text="DESCRIPTION"></asp:Label>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <asp:Label runat="server" ID="l5" Text='<%#Eval("Description")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <HeaderTemplate>
                            <asp:Label ID="Label1" runat="server" Text="SCHEDULE"></asp:Label>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <asp:Label runat="server" ID="l6" Text='<%#Eval("Schedule")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <HeaderTemplate>
                            <asp:Label ID="Label1" runat="server" Text="TRAIN NO."></asp:Label>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <asp:Label runat="server" ID="l7" Text='<%#Eval("Train No")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <HeaderTemplate>
                            <asp:Label ID="Label1" runat="server" Text="LAST OUT DATE"></asp:Label>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <asp:Label runat="server" ID="l8" Text='<%#Eval("Last Out Date")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <HeaderTemplate>
                            <asp:Label ID="Label1" runat="server" Text="LAST SCHEDULE"></asp:Label>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <asp:Label runat="server" ID="l9" Text='<%#Eval("Last Schedule")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <HeaderTemplate>
                            <asp:Label ID="Label1" runat="server" Text="HQ"></asp:Label>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <asp:Label runat="server" ID="l10" Text='<%#Eval("HQ")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <HeaderTemplate>
                            <asp:Label ID="Label1" runat="server" Text="DRIVER NAME"></asp:Label>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <asp:Label runat="server" ID="l11" Text='<%#Eval("Driver name")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <HeaderTemplate>
                            <asp:Label ID="Label1" runat="server" Text="LUBE OIL LEVEL"></asp:Label>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <asp:Label runat="server" ID="l12" Text='<%#Eval("Oil Level")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <HeaderTemplate>
                            <asp:Label ID="Label1" runat="server" Text="FULE LEVEL"></asp:Label>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <asp:Label runat="server" ID="l13" Text='<%#Eval("Fule Level")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <HeaderTemplate>
                            <asp:Label ID="Label1" runat="server" Text="DRIVER BOOK"></asp:Label>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <asp:Label runat="server" ID="l14" Text='<%#Eval("Driver book")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <HeaderTemplate>
                            <asp:Label ID="Label1" runat="server" Text="REVERSER KEY"></asp:Label>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <asp:Label runat="server" ID="l15" Text='<%#Eval("Reverser Key")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <HeaderTemplate>
                            <asp:Label ID="Label1" runat="server" Text="PCP SET"></asp:Label>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <asp:Label runat="server" ID="l16" Text='<%#Eval("Dep Set")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <HeaderTemplate>
                            <asp:Label ID="Label1" runat="server" Text="FIRE EXTINGUSHER"></asp:Label>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <asp:Label runat="server" ID="l17" Text='<%#Eval("Fire Ext")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <HeaderTemplate>
                            <asp:Label ID="Label1" runat="server" Text="TNC NAME"></asp:Label>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <asp:Label runat="server" ID="l18" Text='<%#Eval("tncname")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <HeaderTemplate>
                            <asp:Label ID="Label1" runat="server" Text="SHIFT DATE"></asp:Label>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <asp:Label runat="server" ID="l19" Text='<%#Eval("Shift Date")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <HeaderTemplate>
                            <asp:Label ID="Label1" runat="server" Text="BOOKED REPAIR"></asp:Label>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <asp:Label runat="server" ID="l20" Text='<%#Eval("Booked Repairs")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <HeaderTemplate>
                            <asp:Label ID="Label1" runat="server" Text="ACTION TAKEN"></asp:Label>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <asp:Label runat="server" ID="l21" Text='<%#Eval("Action Taken")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <HeaderTemplate>
                            <asp:Label ID="Label1" runat="server" Text="ACTION"></asp:Label>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <table>
                                <tr>
                                    <td>
                                        <asp:ImageButton runat="server" ImageUrl="~/Images/Edit-icon.png" ID="lbtnUpdate"
                                            PostBackUrl='<%# "~/Loco/Loco_In.aspx?id=" + Eval("id_loco_in") %>' />
                                    </td>
                                    <td>
                                        <asp:ImageButton runat="server" ImageUrl="~/Images/Delete-icon.png" ID="lbtnDelete"
                                            PostBackUrl='<%# "~/Loco/View_LocoIn.aspx?id=" + Eval("id_loco_in") %>' />
                                    </td>
                                </tr>
                            </table>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            </asp:Panel>
        </tr>
    </table>
</asp:Content>
