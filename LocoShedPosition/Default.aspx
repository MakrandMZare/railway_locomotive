<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="LocoShedPosition_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gvlinemsg1" runat="server" Font-Size="Small" Font-Bold="true" AutoGenerateColumns="false">
                <Columns>
                    <asp:TemplateField>
                        <HeaderTemplate>
                            <asp:Label runat="server" ID="l1" Text="LINE MESSAGE" Width="80" Font-Size="medium"></asp:Label>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("LINE MESSAGE") %>' ID="Label3"></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <FooterTemplate>
                            <table>
                                <tr>
                                    <td>
                                        fdsfsd
                                    </td>
                                    <td>
                                        fsdfsdf
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                            </table>
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                    <FooterTemplate>
                    <table>
                    <tr>
                    <td>fsddf</td>
                    <td>fsdf</td>
                    <td>dfsd</td>
                    <td>dfs</td>
                    
                    </tr>
                    </table>
                    </FooterTemplate>
                    </asp:TemplateField>
                </Columns>
                <EmptyDataTemplate>
                    <table>
                        <tr>
                            <td>ytryr
                            </td>
                            <td>hfhg
                            </td>
                            <td>
                            </td>
                            <td>
                            </td>
                        </tr>
                    </table>
                </EmptyDataTemplate>
                
            </asp:GridView>
        </div>
    </form>
</body>
</html>
