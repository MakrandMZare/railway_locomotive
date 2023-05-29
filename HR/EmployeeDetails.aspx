<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true" CodeFile="EmployeeDetails.aspx.cs" Inherits="HR_EmployeeDetails" Title="Untitled Page" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:ToolkitScriptManager runat="server" ID="ToolkitScriptManager1"></asp:ToolkitScriptManager>
<table align="center" width="100%">
<tr>
<%--<td rowspan="10"><img src="../img/emp.gif" height="200px" width="200px"/></td>--%><th colspan="10"> EMPLOYEE DETAILS </th>
</tr>
<tr>
<td>FULL NAME</td><td> : </td><td><asp:TextBox runat="server" ID="txtSurname" onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox><asp:TextBox runat="server" ID="txtName" onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox><asp:TextBox runat="server" ID="txtFathername" onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox></td><td><asp:TextBoxWatermarkExtender runat="server" ID="TextBoxWatermarkExtender1" TargetControlID="txtSurname" WatermarkText=" SURNAME "></asp:TextBoxWatermarkExtender>
                                </td><td><asp:TextBoxWatermarkExtender runat="server" ID="TextBoxWatermarkExtender2" TargetControlID="txtName" WatermarkText=" NAME "></asp:TextBoxWatermarkExtender>
                                </td><td><asp:TextBoxWatermarkExtender runat="server" ID="TextBoxWatermarkExtender3" TargetControlID="txtFathername" WatermarkText=" FATHER NAME "></asp:TextBoxWatermarkExtender>
</td>
</tr>
<tr>
<td> EMPLOYEE NO</td><td> : </td><td><asp:TextBox runat="server" ID="txtEmployeeno" 
        onfocus="ChangeStyle(this.id.toString());" 
        onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
    
                                </td>
</tr>
<tr>
<td>  SALARY CODE </td><td> : </td><td><asp:TextBox runat="server" ID="txtSalaryCode" 
        onfocus="ChangeStyle(this.id.toString());" 
        onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
    
                                </td>
</tr>
<tr>
<td> EDUCATIONAL QUALIFICATION </td><td> : </td><td><asp:TextBox runat="server" ID="txtEduQua" 
        onfocus="ChangeStyle(this.id.toString());" 
        onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
    
                                </td>
</tr>
<tr>
<td> TECHNICAL QUALIFICATION </td><td> : </td><td><asp:TextBox runat="server" ID="txtTechQua" 
        onfocus="ChangeStyle(this.id.toString());" 
        onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"></asp:TextBox>
    
                                </td>
</tr>
<tr>
<td> MEDICAL CATEGORY </td><td> : </td><td> <asp:DropDownList runat="server" ID="ddlMedical" onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"><asp:ListItem></asp:ListItem></asp:DropDownList></td>
</tr>
<tr>
<td> BLOOD GROUP </td><td> : </td><td> <asp:DropDownList runat="server" ID="ddlBloodGroup" onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1">
                            
                            <asp:ListItem Selected="True">O-</asp:ListItem>
                            <asp:ListItem>O+</asp:ListItem>
                            <asp:ListItem>A-</asp:ListItem>
                            <asp:ListItem>A+</asp:ListItem>
                            <asp:ListItem>B-</asp:ListItem>
                            <asp:ListItem>B+</asp:ListItem>
                            <asp:ListItem>AB-</asp:ListItem>
                            <asp:ListItem>AB+</asp:ListItem>
                            </asp:DropDownList></td>
</tr>
<tr>
<td> SECTION </td><td> : </td><td> <asp:DropDownList runat="server" ID="ddlSection" onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"><asp:ListItem></asp:ListItem></asp:DropDownList></td>
</tr>
<tr><td>PAN</td><td> : </td><td><asp:TextBox runat="server" ID="txtPan" onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"   class="t1"></asp:TextBox></td></tr>
<tr><td>POST</td><td> : </td><td><asp:TextBox runat="server" ID="txtPost" onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"   class="t1"></asp:TextBox></td></tr>
<tr>
<td> CASTE </td><td> : </td><td> <asp:DropDownList runat="server" ID="ddlCaste" 
                                onfocus="ChangeStyle(this.id.toString());" 
                                onBlur="ChangeDefaultStyle(this.id.toString());" class="t1" AutoPostBack="True" 
                                onselectedindexchanged="ddlCaste_SelectedIndexChanged"><asp:ListItem></asp:ListItem></asp:DropDownList></td>
</tr>
<tr>
<td> SUB CASTE </td><td> : </td><td> <asp:DropDownList runat="server" ID="ddlSubCaste" onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());" class="t1"><asp:ListItem></asp:ListItem></asp:DropDownList></td>
</tr>
<tr><td>PERMANENT ADDRESS </td><td> : </td><td><asp:TextBox runat="server" ID="txtPerAddress" 
                                onfocus="ChangeStyle(this.id.toString());" 
                                onBlur="ChangeDefaultStyle(this.id.toString());"   class="t1" 
                                TextMode="MultiLine" Rows="5" Columns="30"></asp:TextBox></td></tr>
<tr><td>PRESENT ADDRESS </td><td> : </td><td><asp:TextBox runat="server" ID="txtCurAddress" 
                                onfocus="ChangeStyle(this.id.toString());" 
                                onBlur="ChangeDefaultStyle(this.id.toString());"   class="t1" 
                                TextMode="MultiLine" Rows="5" Columns="30"></asp:TextBox></td></tr>
<tr><td>GENDER</td><td> : </td><td><asp:RadioButtonList runat="server" ID="rdoGender" 
                                RepeatDirection="Horizontal"><asp:ListItem Selected="True">MALE</asp:ListItem><asp:ListItem>FEMALE</asp:ListItem></asp:RadioButtonList></td></tr>
<tr><td>D.O.B</td><td> : </td><td>
<asp:TextBox runat="server" ID="txtDOB" onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"   class="t1"></asp:TextBox>
<asp:CalendarExtender runat="server" ID="CalendarExtender1" TargetControlID="txtDOB" Format="dd/MM/yyyy"></asp:CalendarExtender>
</td></tr>
<tr><td>RETIREMENT DATE</td><td> : </td><td>
<asp:TextBox runat="server" ID="txtRdate" onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"   class="t1"></asp:TextBox>
<asp:CalendarExtender runat="server" ID="CalendarExtender2" TargetControlID="txtRdate" Format="dd/MM/yyyy"></asp:CalendarExtender>
</td></tr>
<tr><td>RECIDENT NO</td><td> : </td><td><asp:TextBox runat="server" ID="txtRecno" onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"   class="t1"></asp:TextBox></td></tr>
<tr><td>MOBILE NO</td><td> : </td><td><asp:TextBox runat="server" ID="txtMobile" onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"   class="t1"></asp:TextBox></td></tr>
<tr><td>EMAIL</td><td> : </td><td><asp:TextBox runat="server" ID="txtEmail" onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"   class="t1"></asp:TextBox></td></tr>
<tr><td>STATE</td><td> : </td><td><asp:TextBox runat="server" ID="txtState" onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"   class="t1"></asp:TextBox></td></tr>
<tr><td>CITY</td><td> : </td><td><asp:TextBox runat="server" ID="txtCity" onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"   class="t1"></asp:TextBox></td></tr>
<tr><td>SERIOUS DIESEASE</td><td> : </td><td><asp:RadioButtonList RepeatDirection="Horizontal" runat="server" ID="rdoDiesease" OnSelectedIndexChanged="rdoDiesease_OnSelectedIndexChanged" AutoPostBack="true"><asp:ListItem>YES</asp:ListItem><asp:ListItem Selected="True">NO</asp:ListItem></asp:RadioButtonList></td></tr>
<tr><td></td><td></td><td><asp:TextBox runat="server" ID="txtDiesease" Visible="false" onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"   class="t1"></asp:TextBox><asp:TextBoxWatermarkExtender runat="server" ID="TextBoxWatermarkExtender4" TargetControlID="txtDiesease" WatermarkText="Diesease Name" ></asp:TextBoxWatermarkExtender></td></tr>
<tr><td>PHOTO</td><td> : </td><td><asp:FileUpload runat="server" ID="PhotoUpload" onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"   class="t1"/></td></tr>
<tr><td>SIGNATURE</td><td> : </td><td><asp:FileUpload runat="server" ID="SignatureUpload" onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"   class="t1"/></td></tr>
<tr><td>THUMB IMPRESSION</td><td> : </td><td><asp:FileUpload runat="server" ID="ThumbUpload" onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"   class="t1"/></td></tr>
<tfoot>
                    <td colspan="7" align="center"><asp:Button runat="server" ID="btnSave" 
                    Text="INSERT" onfocus="ChangeStyle(this.id.toString());" 
                    onBlur="ChangeDefaultStyle(this.id.toString());" class="t2" 
                    OnClick="btnSave_OnClick"/></td>
                    </tfoot>
</table>
</asp:Content>


