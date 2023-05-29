<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true"
    CodeFile="LocoAssemblyEntry.aspx.cs" Inherits="Loco_LocoAssemblyEntry" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <script language="javascript">
 function CallValidation()
    {
       var n1 = document.getElementById('<%=ddlClass.ClientID%>').value;
       var n2 = document.getElementById('<%=ddlLocono.ClientID%>').value;
       var n3 = document.getElementById('<%=ddlRdso1.ClientID%>').value;
       var n4 = document.getElementById('<%=ddlRdso2.ClientID%>').value;
       var n5 = document.getElementById('<%=ddlRdso3.ClientID%>').value;
       //var n6 = document.getElementById('<%=ddlRdso4.ClientID%>').value;
       var n7 = document.getElementById('<%=txtAssemblyNo.ClientID%>').value;
       if(Validate_selectedIndex(n1,'Class') && Validate_selectedIndex(n2,'Loco') && Validate_selectedIndex(n3,'1 digit RDSO Code') && Vali10date_selectedIndex(n4,'2 digit RDSO Code') && Validate_selectedIndex(n5,'3 digit RDSO Code') && IsNull(n7,'Assembly No (Unique)'))
       {return true;}
       return false;
       }
    </script>

    <table align="center">
        <tr>
            <th align="center" colspan="10">
                LOCO ASSEMBLY
            </th>
        </tr>
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
                <asp:DropDownList runat="server" ID="ddlLocono" AutoPostBack="True" OnSelectedIndexChanged="ddlLoco_SelectedIndexChanged"
                    onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"
                    class="t1">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="height: 20px">
                RDSO 1
            </td>
            <td style="height: 20px">
                :
            </td>
            <td style="height: 20px">
                <asp:DropDownList runat="server" ID="ddlRdso1" AutoPostBack="True" OnSelectedIndexChanged="ddlRdso1_SelectedIndexChanged"
                    onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"
                    class="t1">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList>
                &nbsp;&nbsp;SUPPLIER&nbsp;&nbsp;:&nbsp;&nbsp;<asp:DropDownList ID="ddlSupplier1"
                    AutoPostBack="True" onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"
                    class="t1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <%--<asp:Panel runat="server" ID="RdsoPanel1" Visible="false">
                    <table>
                        <tr>
                            <td>
                                Enter 1 Digit Code No.
                            </td>
                            <td>
                                :
                            </td>
                            <td>
                                <asp:TextBox runat="server" ID="txtRdso1" onfocus="ChangeStyle(this.id.toString());"
                                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
            <td>
                <asp:Button runat="server" ID="btnSave1digit" Text="ADD NEW" onfocus="ChangeStyle(this.id.toString());"
                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t2" OnClick="btnSave1digit_OnClick"
                    OnClientClick="return CallValidation();" />
            </td>--%>
        </tr>
        <tr>
            <td>
                RDSO 2
            </td>
            <td>
                :
            </td>
            <td>
                <asp:DropDownList runat="server" ID="ddlRdso2" AutoPostBack="True" OnSelectedIndexChanged="ddlRdso2_SelectedIndexChanged"
                    onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"
                    class="t1">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList>
                &nbsp;&nbsp;SUPPLIER&nbsp;&nbsp;:&nbsp;&nbsp;<asp:DropDownList ID="ddlSupplier2"
                    AutoPostBack="True" onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"
                    class="t1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <%-- <td>
                <asp:Panel runat="server" ID="RdsoPanel2" Visible="false">
                    <table>
                        <tr>
                            <td>
                                Enter 2 Digit Code No.
                            </td>
                            <td>
                                :
                            </td>
                            <td>
                                <asp:TextBox runat="server" ID="txtrdso2" onfocus="ChangeStyle(this.id.toString());"
                                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
            <td>
                <asp:Button runat="server" ID="btnSave2digit" Text="ADD NEW" onfocus="ChangeStyle(this.id.toString());"
                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t2" OnClick="btnSave2digit_OnClick"
                    OnClientClick="return CallValidation();" />
            </td>--%>
        </tr>
        <tr>
            <td>
                RDSO 3
            </td>
            <td>
                :
            </td>
            <td>
                <asp:DropDownList runat="server" ID="ddlRdso3" AutoPostBack="True" OnSelectedIndexChanged="ddlRdso3_SelectedIndexChanged"
                    onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"
                    class="t1">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList>
                &nbsp;&nbsp;SUPPLIER&nbsp;&nbsp;:&nbsp;&nbsp;<asp:DropDownList ID="ddlSupplier3"
                    AutoPostBack="True" onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"
                    class="t1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <%-- <td>
                <asp:Panel runat="server" ID="RdsoPanel3" Visible="false">
                    <table>
                        <tr>
                            <td>
                                Enter 3 Digit Code No.
                            </td>
                            <td>
                                :
                            </td>
                            <td>
                                <asp:TextBox runat="server" ID="txtrdso3" onfocus="ChangeStyle(this.id.toString());"
                                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
            <td>
                <asp:Button runat="server" ID="btnSave3digit" Text="ADD NEW" onfocus="ChangeStyle(this.id.toString());"
                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t2" OnClick="btnSave3digit_OnClick"
                    OnClientClick="return CallValidation();" />
            </td>--%>
        </tr>
        <tr>
            <td>
                RDSO 4
            </td>
            <td>
                :
            </td>
            <td>
                <asp:DropDownList runat="server" ID="ddlRdso4" AutoPostBack="True" OnSelectedIndexChanged="ddlRdso4_SelectedIndexChanged"
                    onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"
                    class="t1">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <%--<asp:Panel runat="server" ID="Panel1" Visible="false">
                    <table>
                        <tr>
                            <td>
                                Enter 4 Digit Code No.
                            </td>
                            <td>
                                :
                            </td>
                            <td>
                                <asp:TextBox runat="server" ID="txtRdso4" onfocus="ChangeStyle(this.id.toString());"
                                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
            <td>
                <asp:Button runat="server" ID="Button1" Text="ADD NEW" onfocus="ChangeStyle(this.id.toString());"
                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t2" OnClick="btnSave3digit_OnClick"
                    OnClientClick="return CallValidation();" />
            </td>--%>
        </tr>
        <tr>
            <td>
                ASSEMBLY NO.(Unique)
            </td>
            <td>
                :
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtAssemblyNo" onfocus="ChangeStyle(this.id.toString());"
                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="10">
                <asp:Label runat="Server" ID="lblError" Text="Assembly No already Exists..Please Choose Another name..!"
                    Visible="false"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button runat="server" ID="btnSave" Text="INSERT" onfocus="ChangeStyle(this.id.toString());"
                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t2" OnClick="btnSave_OnClick"
                    OnClientClick="return CallValidation();" />
            </td>
        </tr>
        <tr>
            <td>
                Material Date
            </td>
            <td>
                :
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtMaterialDate" onfocus="ChangeStyle(this.id.toString());"
                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="height: 20px">
                Quantity</td>
            <td style="height: 20px">
                :
            </td>
            <td style="height: 20px">
                <asp:TextBox runat="server" ID="txtQuantity" onfocus="ChangeStyle(this.id.toString());"
                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Purchase Date</td>
            <td>
                :
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtPurchaseDate" onfocus="ChangeStyle(this.id.toString());"
                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Warrenty Period
            </td>
            <td>
                :
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtWarrentPeriod" onfocus="ChangeStyle(this.id.toString());"
                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                PLNo
            </td>
            <td>
                :
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtPlNo" onfocus="ChangeStyle(this.id.toString());"
                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Product No
            </td>
            <td>
                :
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtProductNo" onfocus="ChangeStyle(this.id.toString());"
                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
            </td>
        </tr>
    </table>
    <table>
        <tr>
            <td colspan="20">
                <asp:GridView runat="server" ID="gv1" AllowPaging="True" AutoGenerateColumns="false"
                    PageSize="20" DataKeyNames="Id_LocoHistory,LocoNo,RdsoCode" EmptyDataText="No Assembly Found...!"
                    OnSelectedIndexChanging="gv1_OnSelectedIndexChanging" OnRowDeleting="gv1_OnRowDeleting"
                    OnPageIndexChanging="gv1_OnPageIndexChanging">
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <%#Container.DataItemIndex + 1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Action">
                            <ItemTemplate>
                                <asp:ImageButton runat="server" ImageUrl="~/Images/Edit-icon.png" ID="lbtnUpdate"
                                    Width="10px" Style="height: 10px" CommandName="SELECT" />
                                <asp:ImageButton runat="server" ImageUrl="~/Images/Delete-icon.png" ID="lbtnDelete"
                                    Width="10px" Style="height: 10px" CommandName="Delete" OnClientClick="return Confirm('Are you wants to Delete...?');" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField HeaderText="Date" DataField="GenerationDate" />
                        <%-- <asp:BoundField HeaderText="Assembly No." DataField="AssemblyNo" />
                        <asp:BoundField HeaderText="RDSO 1 DIGIT CODE" DataField="Rdso1" />
                        <asp:BoundField HeaderText="RDSO 2 DIGIT CODE" DataField="Rdso2" />
                        <asp:BoundField HeaderText="RDSO 3 DIGIT CODE" DataField="Rdso3" />
                        <asp:BoundField HeaderText="RDSO 4 DIGIT CODE" DataField="Rdso4" />--%>
                        <asp:TemplateField HeaderText="ASSEMBLY NO.">
                            <ItemTemplate>
                                <asp:LinkButton ID="lbtnAssNo" runat="server" Text='<%#Eval("AssemblyNo") %>'></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="RDSO1">
                            <ItemTemplate>
                                <asp:LinkButton ID="RDSO1" runat="server" Text='<%#Eval("Rdso1") %>'></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="RDSO2">
                            <ItemTemplate>
                                <asp:LinkButton ID="RDSO2" runat="server" Text='<%#Eval("Rdso2") %>'></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="RDSO3">
                            <ItemTemplate>
                                <asp:LinkButton ID="RDSO3" runat="server" Text='<%#Eval("Rdso3") %>'></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="RDSO4">
                            <ItemTemplate>
                                <asp:LinkButton ID="RDSO4" runat="server" Text='<%#Eval("Rdso4") %>'></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
