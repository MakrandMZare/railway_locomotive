<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true" Theme="SkinFile"
    CodeFile="View_Locolist.aspx.cs" Inherits="Loco_View_Locolist" Title="Sabarmati Diesels : Loco" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
<asp:ToolkitScriptManager runat="server" id="ToolkitScriptManager1"></asp:ToolkitScriptManager>
<script language="javascript" type="text/javascript">

function CallValidation()
    {
       var n1 = document.getElementById('<%=ddlClass.ClientID%>').value;
       var n2 = document.getElementById('<%=ddlLocono.ClientID%>').value;
       if(Validate_selectedIndex(n1,'Class') && Validate_selectedIndex(n2,'Loco'))
       {return true;}
       return false;
    }
    </script>
    <table>
        <tr>
            <th>
                List Of LOCO
            </th>
        </tr>
        <tr>
            <td>
                <table>
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
                                <asp:ListItem>SELECT</asp:ListItem>
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
                                onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" OnSelectedIndexChanged="ddlLocono_SelectedIndexChanged">
                                <asp:ListItem>SELECT</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Arrival Date
                        </td>
                        <td>
                            :
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtArrivalDate" onfocus="ChangeStyle(this.id.toString());"
                                onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
                                <asp:CalendarExtender runat="server" ID="CalendarExtender1" TargetControlID="txtArrivalDate" format="dd/MM/yyyy"></asp:CalendarExtender>
                        </td>
                    </tr>
                    <tr>
                        <td><asp:CheckBox runat="server" ID="CheckboxEdit" Text="Edit" Checked="false" AutoPostBack="true" OnCheckedChanged="CheckboxEdit_OnCheckedChanged"/></td><td></td>
                        <td>
                            <asp:Button runat="server" ID="btnSave" Text="SHOW" onfocus="ChangeStyle(this.id.toString());"
                                onBlur="ChangeDefaultStyle(this.id.toString());" class="t2" OnClick="btnShow_OnClick"
                                OnClientClick="return CallValidation();" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" Text="No Data Found" ID="lblerror" Visible="false">
                </asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="gvLocolist" runat="server" OnSelectedIndexChanged="gvLocolist_SelectedIndexChanged"
                    AutoGenerateColumns="False">
                    <Columns>
                        <asp:TemplateField>
                            <HeaderTemplate>
                                <asp:Label ID="Label1" runat="server" Text="SN." Width="15px" Font-Size="XX-Small"></asp:Label>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <%#Container.DataItemIndex + 1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <HeaderTemplate>
                                <asp:Label ID="Label2" runat="server" Text="LOCO TYPE" Width="100px" Font-Size="XX-Small"></asp:Label>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lbllocotype" runat="server" Text='<%#Eval("Class")%>'>
                                </asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <HeaderTemplate>
                                <asp:Label ID="Label3" runat="server" Text="LOCO NO." Width="100px" Font-Size="XX-Small"></asp:Label>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lbllocono" runat="server" Text='<%#Eval("Loco No") %>'>
                                </asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <HeaderTemplate>
                                <asp:Label ID="Label4" runat="server" Text="ARRIVAL DATE" Width="100px" Font-Size="XX-Small"></asp:Label>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lbladate" runat="server" Text='<%#Eval("Arrival Date") %>'>
                                </asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <HeaderTemplate>
                                <asp:Label ID="Label5" runat="server" Text="ARRIVAL TIME" Width="100px" Font-Size="XX-Small"></asp:Label>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lblatime" runat="server" Text='<%#Eval("Arrival time")%>'>'
                                </asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField ItemStyle-HorizontalAlign="Center" ItemStyle-VerticalAlign="Middle">
                        <HeaderTemplate>View</HeaderTemplate>
                            <ItemTemplate>
                                <asp:ImageButton ImageUrl="~/Images/84.jpg" runat="server" ID="viewimage" PostBackUrl='<%#"~/Loco/View_LocoDetails.aspx?id=" + Eval("id_loco_in") %>' AlternateText="View More"
                                    Height="20px" Width="20px" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField ItemStyle-HorizontalAlign="Center" ItemStyle-VerticalAlign="Middle" Visible="false">
                        <HeaderTemplate>
                        Action
                        </HeaderTemplate>
                        <ItemTemplate >
                         <table>
                                <tr>
                                    <td>
                                        <asp:ImageButton runat="server" ImageUrl="~/Images/Edit-icon.png" ID="lbtnUpdate"
                                            PostBackUrl='<%#"~/Loco/Loco_In.aspx?Id=" + Eval("id_loco_in") + "&action=update" %>' AlternateText="Update"/>
                                    </td>
                                    <td>
                                        <asp:ImageButton runat="server" ImageUrl="~/Images/Delete-icon.png" ID="lbtnDelete" PostBackUrl='<%#"~/Loco/View_Locolist.aspx?Id=" + Eval("id_loco_in")+"&action=delete" %>' AlternateText="Delete"/>
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
