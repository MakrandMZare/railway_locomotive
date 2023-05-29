<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true" CodeFile="failure.aspx.cs" Inherits="failure" Title="Sabarmati Diesels : Loco : Failure" EnableEventValidation ="false" Theme="SkinFile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
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
            if(document.getElementById('<%=TextBox1.ClientID %>').value == "")
    {
        alert("IF you Have no Value then enter -");
        document.getElementById('<%=TextBox1.ClientID %>').focus();
        return false;
    }
     
    else
    {
        return true;
    }

        return false;
        
    }
        </script>
           <table id = "tbl1" >
        <tr>
            <th>     
                FAILURE</th>
        </tr>
        <tr>
            <td >
                            <asp:ImageButton ID="ImageButton1"  onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"
 runat="server" OnClientClick="return ShowPanel();" ImageUrl="~/Images/Add-icon.png"/>
            <div ID="insertDiv" style="display:block;">

                    <table>
                        <tr>
                            <td >
                                <asp:TextBox ID="TextBox1"  onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"
 runat="server"></asp:TextBox>
                              <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
                                    ErrorMessage="*" ValidationGroup="a"></asp:RequiredFieldValidator></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblerro" runat="server" ForeColor="Red" Text="Data Already Exists...!"
                                    Visible="false"></asp:Label></td>
                        </tr>
                        <tr>
                            <td >
                                <asp:Button ID="btnfailure" OnClientClick="return ShowPanel();" onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"
 runat="server" Text="Add" OnClick="btnfailure_Click"  /></td>
                        </tr>
                    </table>
                </div>
            </td>
        </tr>
        <tr>
            <td >
                <asp:GridView ID="GridView1"  onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"
 runat="server" AutoGenerateColumns="False" >
                <Columns>
                     <asp:TemplateField headertext="No.">
                     
                    <ItemTemplate>
                    <%#Container.DataItemIndex + 1 %>
                    </ItemTemplate>
                    </asp:TemplateField>
    <asp:TemplateField headertext="FAILURE">
    
    <ItemTemplate>
    <asp:Label runat="server" ID="l1" Text='<%#Eval("failure")%>'></asp:Label>
    </ItemTemplate>
    </asp:TemplateField>
   
    
    <asp:TemplateField HeaderText="Update">

    <HeaderTemplate>
    ACTION
    </HeaderTemplate>
    <ItemTemplate>
    <asp:ImageButton ID="lbtnupdate" runat="server" Text="Update" ImageUrl="~/Images/Edit-icon.png" PostBackUrl='<%# "~/Master/failure.aspx?id="+ Eval("id_m_fail") + "&action=update" %>' />
    <asp:ImageButton ID="lbtnDelete" runat="server" Text="Delete" ImageUrl="~/Images/Delete-icon.png" PostBackUrl='<%# "~/Master/failure.aspx?id="+ Eval("id_m_fail") + "&action=delete" %>'/>
    </ItemTemplate>
    </asp:TemplateField>
                        
                    </Columns>
                
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td >
            </td>
            <td >
            </td>
        </tr>
    </table>
</asp:Content>

