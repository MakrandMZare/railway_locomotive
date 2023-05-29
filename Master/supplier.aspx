<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true"
    CodeFile="supplier.aspx.cs" Inherits="supplier" Title="Untitled Page" EnableEventValidation="false"
    Theme="SkinFile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <script language="javascript" type="text/javascript">
    function ShowPanel()
    {
        //alert(document.getElementById('insertDiv').style.visibility);
        if(document.getElementById('insertDiv').style.display == 'block')
        {
        document.getElementById('insertDiv').style.display = "none";
        //alert(document.getElementById('insertDiv').style.visibility);
        }
        else
        {
        document.getElementById('insertDiv').style.display = "block";
        //alert(document.getElementById('insertDiv').style.visibility);
        }
        return false;
    }
    </script>

    <table>
        <tr>
            <th>
                SUPPLIER</th>
        </tr>
        <tr>
            <td>
                <asp:ImageButton onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"
                    class="t1" ID="ImageButton1" runat="server" OnClientClick="return ShowPanel();"
                    ImageUrl="~/Images/Add-icon.png" />
                <div id="insertDiv" style="display: block;">
                    <table>
                        <tr>
                            <td>
                                Supplier Name</td>
                            <td>
                                :
                            </td>
                            <td>
                                <asp:TextBox runat="server" ID="txtSname" CssClass="t1"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>
                                Supplier Address</td>
                            <td>
                                :
                            </td>
                            <td>
                                <asp:TextBox runat="server" ID="txtAddress" CssClass="t1"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>
                                Supplier Pincode</td>
                            <td>
                                :
                            </td>
                            <td>
                                <asp:TextBox runat="server" ID="txtPincode" CssClass="t1"></asp:TextBox></td>
                        </tr>
                          <tr>
                            <td>
                                Supplier State</td>
                            <td>
                                :
                            </td>
                            <td>
                                <asp:TextBox runat="server" ID="txtState" CssClass="t1"></asp:TextBox></td>
                        </tr>
                          <tr>
                            <td>
                                Supplier District</td>
                            <td>
                                :
                            </td>
                            <td>
                                <asp:TextBox runat="server" ID="txtDistrict" CssClass="t1"></asp:TextBox></td>
                        </tr>
                          <tr>
                            <td>
                                Supplier Phone no</td>
                            <td>
                                :
                            </td>
                            <td>
                                <asp:TextBox runat="server" ID="txtPhone" CssClass="t1"></asp:TextBox></td>
                        </tr>
                          <tr>
                            <td>
                                Supplier Mobile No</td>
                            <td>
                                :
                            </td>
                            <td>
                                <asp:TextBox runat="server" ID="txtMobile" CssClass="t1"></asp:TextBox></td>
                        </tr>
                          <tr>
                            <td>
                                Supplier LandLine</td>
                            <td>
                                :
                            </td>
                            <td>
                                <asp:TextBox runat="server" ID="txtLandline" CssClass="t1"></asp:TextBox></td>
                        </tr>
                          <tr>
                            <td>
                                 Contact Person</td>
                            <td>
                                :
                            </td>
                            <td>
                                <asp:TextBox runat="server" ID="txtContactPerson" CssClass="t1"></asp:TextBox></td>
                        </tr>
                          <tr>
                            <td>
                                Supplier WebSite</td>
                            <td>
                                :
                            </td>
                            <td>
                                <asp:TextBox runat="server" ID="txtWebSite" CssClass="t1"></asp:TextBox></td>
                        </tr>
                          <tr>
                            <td>
                                Supplier Emailid</td>
                            <td>
                                :
                            </td>
                            <td>
                                <asp:TextBox runat="server" ID="txtEmailId" CssClass="t1"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"
                                    class="t1" ID="btnadd" runat="server" OnClick="btnadd_Click" Text="Add" Width="92px"
                                    ValidationGroup="a" />
                                <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Master/Assembly_Supplier.aspx">Assign Assembly</asp:LinkButton></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblerro" runat="server" ForeColor="Red" Text="Data Already Exists...!"
                                    Visible="false"></asp:Label></td>
                        </tr>
                    </table>
                </div>
            </td>
        </tr>
        <tr>
            <td>
                <asp:GridView onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"
                    class="t1" ID="gv1" runat="server" AutoGenerateColumns="False">
                    <Columns>
                        <asp:TemplateField HeaderText="NO.">
                            <ItemTemplate>
                                <%#Container.DataItemIndex + 1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="NAME">
                            <ItemTemplate>
                                <asp:Label ID="l1" runat="server" Text='<%#Eval("s_name")%>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="ADDRESS">
                            <ItemTemplate>
                                <asp:Label ID="l2" runat="server" Text='<%#Eval("s_address")%>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="PINCODE">
                            <ItemTemplate>
                                <asp:Label ID="l3" runat="server" Text='<%#Eval("s_pincode")%>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="DISTRICT">
                            <ItemTemplate>
                                <asp:Label ID="l4" runat="server" Text='<%#Eval("dist")%>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="PHONE NO">
                            <ItemTemplate>
                                <asp:Label ID="l5" runat="server" Text='<%#Eval("Phone")%>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="LANDLINE">
                            <ItemTemplate>
                                <asp:Label ID="l6" runat="server" Text='<%#Eval("Landline")%>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="MOIBILE NO">
                            <ItemTemplate>
                                <asp:Label ID="l7" runat="server" Text='<%#Eval("mobilen")%>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="CONTACT PERSON">
                            <ItemTemplate>
                                <asp:Label ID="l8" runat="server" Text='<%#Eval("contactperson")%>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="WEB SITE">
                            <ItemTemplate>
                                <asp:Label ID="l9" runat="server" Text='<%#Eval("webaddress")%>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                         <asp:TemplateField HeaderText="EMAIL ID">
                            <ItemTemplate>
                                <asp:Label ID="l10" runat="server" Text='<%#Eval("emailid")%>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Update">
                            <HeaderTemplate>
                                ACTION
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:ImageButton ID="lbtnupdate" runat="server" Text="Update" ImageUrl="~/Images/Edit-icon.png"
                                    PostBackUrl='<%# "~/Master/supplier.aspx?id="+ Eval("id_supp") + "&action=update" %>' />
                                <asp:ImageButton ID="lbtnDelete" runat="server" Text="Delete" ImageUrl="~/Images/Delete-icon.png"
                                    PostBackUrl='<%# "~/Master/supplier.aspx?id="+ Eval("id_supp") + "&action=delete" %>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
            </td>
        </tr>
    </table>
</asp:Content>
