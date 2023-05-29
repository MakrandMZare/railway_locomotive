<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true" CodeFile="View_Locooutlist.aspx.cs" Inherits="Loco_Locooutlist" Title="Sabarmati Diesels : Loco Out" Theme="SkinFile"  %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>
 <table >
     <tr>
        <th>
           LIST OF OUT LOCO                     
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
                            Out Date
                        </td>
                        <td>
                            :
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtoutdate" onfocus="ChangeStyle(this.id.toString());"
                                onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
                                <asp:CalendarExtender runat="server" ID="CalendarExtender1" TargetControlID="txtoutdate" format="dd/MM/yyyy"></asp:CalendarExtender>
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
            <asp:GridView ID="gvLocolist" runat="server" 
                onselectedindexchanged="gvLocolist_SelectedIndexChanged" 
                AutoGenerateColumns="False" >
                <Columns>
                     <asp:TemplateField>
                        <HeaderTemplate>
                            <asp:Label ID="Label1" runat="server" Text="SN." Width="100px" Font-Size ="XX-Small"></asp:Label>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <%#Container.DataItemIndex + 1 %>
                        </ItemTemplate>
                     </asp:TemplateField> 
                     <asp:TemplateField>
                        <HeaderTemplate>
                            <asp:Label ID="Label2" runat="server" Text="LOCO TYPE" Width="100px" Font-Size ="XX-Small"></asp:Label>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lbllocotype" runat="server" Text='<%#Eval("Class")%>'>
                            </asp:Label>
                        </ItemTemplate>
                     </asp:TemplateField>
                     <asp:TemplateField>
                        <HeaderTemplate>
                            <asp:Label ID="Label3" runat="server" Text="LOCO NO." Width="100px" Font-Size ="XX-Small"></asp:Label>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lbllocono" runat="server" Text='<%#Eval("Loco No") %>'>
                            </asp:Label>
                        </ItemTemplate>
                     </asp:TemplateField>  
                     
                     <asp:TemplateField>
                        <HeaderTemplate>
                            <asp:Label ID="Label4" runat="server" Text="OUT DATE" Width="100px" Font-Size ="XX-Small"></asp:Label>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lbladate" runat="server" Text='<%#Eval("Out Date") %>'>
                            </asp:Label>
                        </ItemTemplate>
                     </asp:TemplateField>           
                     <asp:TemplateField>
                        <HeaderTemplate>
                            <asp:Label ID="Label5" runat="server" Text="OUT TIME" Width="100px" Font-Size ="XX-Small"></asp:Label>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lbloutdate" runat="server" Text='<%#Eval("Out time")%>'>'
                            </asp:Label>
                        </ItemTemplate>
                     </asp:TemplateField>   
                      <asp:TemplateField ItemStyle-HorizontalAlign="Center" ItemStyle-VerticalAlign="Middle">
                            <HeaderTemplate>
                            VIEW
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:ImageButton ImageUrl="~/Images/84.jpg" runat="server" ID="viewimage"  PostBackUrl='<%#"~/Loco/View_Locooutdetails.aspx?id=" + Eval("id") %>'
                                    Height="20px" Width="20px" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField>
                        <HeaderTemplate>
                            ACTION
                        </HeaderTemplate >
                        <ItemTemplate>
                            <table>
                                <tr>
                                    <td>
                                        <asp:ImageButton runat="server" ImageUrl="~/Images/Edit-icon.png" ID="lbtnUpdate"
                                            PostBackUrl='<%# "~/Loco/Loco_Out.aspx?id=" + Eval("id") %>' />
                                    </td>
                                    <td>
                                        <asp:ImageButton runat="server" ImageUrl="~/Images/Delete-icon.png" ID="lbtnDelete"
                                            PostBackUrl='<%# "~/Loco/Loco_Out.aspx?id=" + Eval("id") %>' />
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

