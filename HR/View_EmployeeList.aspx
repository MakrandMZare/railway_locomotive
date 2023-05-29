<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true"
    CodeFile="View_EmployeeList.aspx.cs" Inherits="HR_View_EmployeeList" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table>
        <tr>
            <th>
                LIST OF EMPLOYEE
            </th>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="lblerror" ForeColor="Red" Text="No Data Found ...!"
                    Visible="false"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:GridView runat="server" ID="gvEmployeeList" AutoGenerateColumns="false" 
                    onselectedindexchanged="gvEmployeeList_SelectedIndexChanged">
                    <Columns>
                    <asp:TemplateField>
                    <HeaderTemplate>
                    SN
                    </HeaderTemplate>
                    <ItemTemplate>
                    <%#Container.DataItemIndex + 1 %>
                    </ItemTemplate>
                    </asp:TemplateField>
                        <asp:TemplateField>
                            <HeaderTemplate>
                        PHOTO
                        </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Image runat="server" ID="EmpImage" Height="100px" Width="100px" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField>
                        <HeaderTemplate>
                        SURNAME -  EMPLOYEE'S NAME -  FATHER'S NAME
                        </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lbtnEmployeename" Text='<%#Eval("Sname")%>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField>
                        <HeaderTemplate>
                        SECTION
                        </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lblSection" Text='<%#Eval("Section")%>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:ImageButton ImageUrl="~/Images/84.jpg" runat="server" ID="viewimage" PostBackUrl='<%#"~/HR/View_EmployeeDetails.aspx?id=" + Eval("id") %>'
                                    Height="20px" Width="20px" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
