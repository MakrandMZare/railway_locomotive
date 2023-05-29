<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true" CodeFile="View_Locooutdetails.aspx.cs" Inherits="Loco_View_Logooutdetails" Title="Sabarmati Diesels : Report Loco Out" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table align="center" width="100%">
    <tr>
        <th>
            LOCO OUT DETAILS
        </th>
    </tr>
    
    <tr>
        <td>
            <asp:DataList runat="server" ID="LocooutDataList" 
                onselectedindexchanged="LocooutDataList_SelectedIndexChanged">
                <ItemTemplate>
                    <table align="center" >
                        <tr>
                            <td>
                                LOCO NO
                            </td>
                            <td>
                                :
                            </td>
                            <td>
                                <asp:Label runat="server" ID="lblLocono" Text='<%#("Loco No") %>'>
                                </asp:Label>
                            </td>
                        </tr>
                         <tr>
                                <td>
                                    LOCO TYPE
                                </td>
                                <td>
                                    :
                                </td>
                           
                            <td>
                                <asp:Label runat="server" ID="lbllocotype" Text='<%#Eval("Class") %>'>   
                                </asp:Label>
                            </td>
                           </tr> 
                            
                            <tr>
                                <td>
                                    OUT DATE
                                </td>
                                <td>
                                    :
                                </td>
                           
                            <td>
                                <asp:Label runat="server" ID="lbloutdate" Text='<%#Eval("Out Date") %>'>   
                                </asp:Label>
                            </td>
                           </tr> 
                           
                           <tr>
                                <td>
                                   OUT TIME
                                </td>
                                <td>
                                    :
                                </td>
                           
                            <td>
                                <asp:Label runat="server" ID="lblouttime" Text='<%#Eval("Out time") %>'>   
                                </asp:Label>
                            </td>
                           </tr> 
                           
                           <tr>
                                <td>
                                    SCHEDULE
                                </td>
                                <td>
                                    :
                                </td>
                           
                            <td>
                                <asp:Label runat="server" ID="lblschedule" Text='<%#Eval("Schedule") %>'>   
                                </asp:Label>
                            </td>
                           </tr> 
                           
                          <td>
                                <asp:Label runat="server" ID="Label1" Text='<%#Eval("Schedule") %>'>   
                                </asp:Label>
                            </td>
                           </tr> 
                           
                           <tr>
                                <td>
                                    DESCRIPTION
                                </td>
                                <td>
                                    :
                                </td>
                           
                            <td>
                                <asp:Label runat="server" ID="lbldescription" Text='<%#Eval("Description") %>'>   
                                </asp:Label>
                            </td>
                           </tr> 
                           
                           <tr>
                                <td>
                                    TRAIN NO.
                                </td>
                                <td>
                                    :
                                </td>
                           
                            <td>
                                <asp:Label runat="server" ID="lbltrainno" Text='<%#Eval("Train No") %>'>   
                                </asp:Label>
                            </td>
                           </tr> 
                           
                                                   
                           <tr>
                                <td>
                                    LAST SCHEDULE
                                </td>
                                <td>
                                    :
                                </td>
                           
                            <td>
                                <asp:Label runat="server" ID="lbllastschedule" Text='<%#Eval("Last Schedule") %>'>   
                                </asp:Label>
                            </td>
                           </tr> 
                           
                           <tr>
                                <td>
                                   HQ
                                </td>
                                <td>
                                    :
                                </td>
                           
                            <td>
                                <asp:Label runat="server" ID="lblhq" Text='<%#Eval("HQ") %>'>   
                                </asp:Label>
                            </td>
                           </tr> 
                           
                           <tr>
                                <td>
                                  DRIVER NAME
                                </td>
                                <td>
                                    :
                                </td>
                           
                            <td>
                                <asp:Label runat="server" ID="lbldrivername" Text='<%#Eval("Driver name") %>'>   
                                </asp:Label>
                            </td>
                           </tr> 
                           
                            <tr>
                                <td>
                                  OIL LEVEL
                                </td>
                                <td>
                                    :
                                </td>
                           
                            <td>
                                <asp:Label runat="server" ID="lbloillevel" Text='<%#Eval("Oil Level") %>'>   
                                </asp:Label>
                            </td>
                           </tr> 
                           
                             <tr>
                                <td>
                                 FULE LEVEL
                                </td>
                                <td>
                                    :
                                </td>
                           
                            <td>
                                <asp:Label runat="server" ID="lblfulelevel" Text='<%#Eval("Fule Level") %>'>   
                                </asp:Label>
                            </td>
                           </tr> 
                           
                            <tr>
                                <td>
                                 DRIVER BOOK
                                </td>
                                <td>
                                    :
                                </td>
                           
                            <td>
                                <asp:Label runat="server" ID="lbldriver" Text='<%#Eval("Driver book") %>'>   
                                </asp:Label>
                            </td>
                           </tr> 
                           
                           <tr>
                                <td>
                                REVERSER KEY
                                </td>
                                <td>
                                    :
                                </td>
                           
                            <td>
                                <asp:Label runat="server" ID="lblreverserkey" Text='<%#Eval("Reverser Key") %>'>   
                                </asp:Label>
                            </td>
                           </tr> 
                           
                           <tr>
                                <td>
                               DEP SET
                                </td>
                                <td>
                                    :
                                </td>
                           
                            <td>
                                <asp:Label runat="server" ID="lbldepset" Text='<%#Eval("Dep Set") %>'>   
                                </asp:Label>
                            </td>
                           </tr> 
                           
                           <tr>
                                <td>
                               FIRE EXT
                                </td>
                                <td>
                                    :
                                </td>
                           
                            <td>
                                <asp:Label runat="server" ID="lblfireext" Text='<%#Eval("Fire Ext") %>'>   
                                </asp:Label>
                            </td>
                           </tr> 
                           
                           <tr>
                                <td>
                                    TNCNAME
                                </td>
                                <td>
                                    :
                                </td>
                           
                            <td>
                                <asp:Label runat="server" ID="lbltncneme" Text='<%#Eval("tncname") %>'>   
                                </asp:Label>
                            </td>
                           </tr> 
                           
                           <tr>
                                <td>
                                    SHIFT DATE
                                </td>
                                <td>
                                    :
                                </td>
                           
                            <td>
                                <asp:Label runat="server" ID="lblshiftdate" Text='<%#Eval("Shift Date") %>'>   
                                </asp:Label>
                            </td>
                           </tr> 
                           
                           <tr>
                                <td>
                                    BOOKED REPAIRES
                                </td>
                                <td>
                                    :
                                </td>
                           
                            <td>
                                <asp:Label runat="server" ID="lblbookedrepairs" Text='<%#Eval("Booked Repairs") %>'>   
                                </asp:Label>
                            </td>
                           </tr> 
                           
                           <tr>
                                <td>
                                    ACTION TAKEN
                                </td>
                                <td>
                                    :
                                </td>
                           
                            <td>
                                <asp:Label runat="server" ID="lblactiontaken" Text='<%#Eval("Action Taken") %>'>   
                                </asp:Label>
                            </td>
                           </tr>
                    </table>
                </ItemTemplate>
            </asp:DataList>
            <asp:GridView ID="GridViewfire" runat="server" AutoGenerateColumns="false" 
                                onselectedindexchanged="GridViewfire_SelectedIndexChanged">
                                <Columns>
                                    <asp:TemplateField>
                                        <HeaderTemplate>
                                            SN
                                        </HeaderTemplate>
                                        <ItemTemplate>
                                             <asp:Label runat="server" ID="lblsn" Text='<%#Eval("srno") %>'>
                                             </asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField> 
                                  
                                    <asp:TemplateField>
                                        <HeaderTemplate>
                                          FIRE DATE
                                        </HeaderTemplate>
                                        <ItemTemplate>
                                            <asp:Label runat="server" ID="lblmid" Text='<%#Eval("fdate") %>'>
                                            </asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField> 
                                    
                                </Columns>
                                </asp:GridView>
        </td>
        
    </tr>
    <tfoot>
              <tr>
               <td  align="center">
                    <asp:ImageButton runat="server" ImageUrl="~/Images/Edit-icon.png" ID="lbtnUpdate"
                         OnClick="lbtnUpdate_OnClick" 
                        Width="24px" style="height: 24px" />
                    </td>
                    </tr>
              </tfoot>
    
</table>
</asp:Content>

