<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sabarmati Diesels : Loco</title>
    <style type="text/css" media="print">
/*.a1:focus
{
background-color:Red;
}
.a1:blur
{
background-color:white;
}
.landScape
{
 width: 100%;
 height: 100%;
 margin: 0% 0% 0% 0%;
 filter: progid:DXImageTransform.Microsoft.BasicImage(Rotation=1);
 size:landscape;
.temp1:hover
{
background:red;
border:solid 1px black;
}*/
.temp1
{
	background:pink;
border:solid 1px gray;
}
.temp1:hover
{
	background:red;
border:solid 1px gray;
}
.div
{
	background:pink;
border:solid 1px black;
}
.div:hover
{
	background:red;
border:solid 1px gray;
}
</style>
    <script language="javascript" type="text/javascript">
    function PrintthisPage()
    {
    window.print();
    return false;
    }
    
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:TextBox runat="server" ID="t1"></asp:TextBox>
    <asp:TextBox runat="server" ID="t2"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click"/>
            <%--<asp:Button ID="Button2" runat="server" Text="Button" 
            OnClientClick="PrintthisPage();" onclick="Button1_Click"/>--%>
        <br />
        dasjdk askjhasdkj asdjkahsda<br />
        dasjdk askjhasdkj asdjkahsda<br />
        dasjdk askjhasdkj asdjkahsda<br />
        dasjdk askjhasdkj asdjkahsda<asp:Menu ID="Menu1" runat="server" 
            Orientation="Horizontal">
            <Items>
                <asp:MenuItem Text="New Item" Value="New Item">
                    <asp:MenuItem Text="New Item" Value="New Item">
                        <asp:MenuItem Text="New Item" Value="New Item"></asp:MenuItem>
                    </asp:MenuItem>
                </asp:MenuItem>
                <asp:MenuItem Text="New Item" Value="New Item">
                    <asp:MenuItem Text="New Item" Value="New Item">
                        <asp:MenuItem Text="New Item" Value="New Item">
                            <asp:MenuItem Text="New Item" Value="New Item"></asp:MenuItem>
                        </asp:MenuItem>
                    </asp:MenuItem>
                </asp:MenuItem>
            </Items>
        </asp:Menu>
        <br />
        dasjdk askjhasdkj asdjkahsda<br />
    </div>
    <div id="menudiv">
<asp:TextBox runat="server" ID="tt1" class="a1"></asp:TextBox>

<div style="clear:both">

    <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" 
        onpageindexchanging="DetailsView1_PageIndexChanging" Width="125px">
        
    </asp:DetailsView>
        <br />
    <asp:DataList ID="DataList1" runat="server" RepeatColumns="3" 
        RepeatDirection="Horizontal">
        <ItemTemplate>
            <table border="2">
            <tr>
            <td><asp:Label ID="Label1" runat="server"  Text='<%#Eval("Id_SiteSection")%>'></asp:Label></td>
            <td><asp:Label ID="Label2" runat="server"  Text='<%#Eval("SiteSectionName")%>'></asp:Label></td>
            </tr>
            </table>
            
            
        </ItemTemplate>
    </asp:DataList>
        </div>
<table>
<tr>
<td>
<asp:GridView runat="server" ID="gv1" AutoGenerateColumns="false" OnRowDataBound="gv1_OnRowDataBound" >
<Columns>
<asp:TemplateField>
<ItemTemplate>
<asp:Label runat="server" ID="l1" Text="t1"></asp:Label>
</ItemTemplate>
</asp:TemplateField>
</Columns>
</asp:GridView>
</td>
</tr>
<tr>
<td>asd asd asd </td>

</tr>
</table>
   </div>
    </form>
    <div>as asd asd asd asd </div>
    <div>as asd asd asd asd </div>
    <div>as asd asd asd asd </div>
    
</body>
</html>
