<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true" CodeFile="View_EmployeeDetails.aspx.cs" Inherits="HR_View_EmployeeDetails" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table align="center" width="100%">
        <tr>
            <th>
                EMPLOYEE DETAILS
            </th>
        </tr>
        <tr>
            <td>
                <asp:DataList runat="server" ID="empDataList">
                    <ItemTemplate>
                        <table align="center">
                            <tr>
                                <td>
                                    FULL NAME
                                </td>
                                <td>
                                    :
                                </td>
                                <td>
                                    <asp:Label runat="server" ID="lblSurname" Text='<%#Eval("Surname")%>'></asp:Label>&nbsp;&nbsp;&nbsp;<asp:Label
                                        runat="server" ID="lblName" Text='<%#Eval("sName")%>'></asp:Label>&nbsp;&nbsp;&nbsp;<asp:Label
                                            runat="server" ID="lblFathername" Text='<%#Eval("FathersName")%>'></asp:Label>
                            </tr>
                            <tr>
                                <td>
                                    EMPLOYEE NO
                                </td>
                                <td>
                                    :
                                </td>
                                <td>
                                    <asp:Label runat="server" ID="lblEmployeeno" Text='<%#Eval("Employee No")%>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    SALARY CODE
                                </td>
                                <td>
                                    :
                                </td>
                                <td>
                                    <asp:Label runat="server" ID="lblSalaryCode" Text='<%#Eval("Salary Code")%>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    EDUCATIONAL QUALIFICATION
                                </td>
                                <td>
                                    :
                                </td>
                                <td>
                                    <asp:Label runat="server" ID="lblEducatinalQualification" Text='<%#Eval("Educatinal Qualification")%>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    TECHNICAL QUALIFICATION
                                </td>
                                <td>
                                    :
                                </td>
                                <asp:Label runat="server" ID="lblTechnicalQualification" Text='<%#Eval("Technical Qualification")%>'></asp:Label></td>
                            </tr>
                            <tr>
                                <td>
                                    MEDICAL CATEGORY
                                </td>
                                <td>
                                    :
                                </td>
                                <td>
                                    <asp:Label runat="server" ID="lblMedicalCategory" Text='<%#Eval("MedicalCategory")%>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    BLOOD GROUP
                                </td>
                                <td>
                                    :
                                </td>
                                <td>
                                    <asp:Label runat="server" ID="lblBloodGroup" Text='<%#Eval("BloodGroup")%>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    SECTION
                                </td>
                                <td>
                                    :
                                </td>
                                <td>
                                    <asp:Label runat="server" ID="lblSection" Text='<%#Eval("Section")%>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    PAN
                                </td>
                                <td>
                                    :
                                </td>
                                <td>
                                    <asp:Label runat="server" ID="lblPAN" Text='<%#Eval("PAN")%>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    POST
                                </td>
                                <td>
                                    :
                                </td>
                                <td>
                                    <asp:Label runat="server" ID="lblPost" Text='<%#Eval("Post")%>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    CASTE
                                </td>
                                <td>
                                    :
                                </td>
                                <td>
                                    <asp:Label runat="server" ID="lblCaste" Text='<%#Eval("Caste")%>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    SUB CASTE
                                </td>
                                <td>
                                    :
                                </td>
                                <td>
                                    <asp:Label runat="server" ID="lblSubCaste" Text='<%#Eval("Sub Caste")%>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    PERMANENT ADDRESS
                                </td>
                                <td>
                                    :
                                </td>
                                <td>
                                    <asp:Label runat="server" ID="lblPermanentAddress" Text='<%#Eval("Permanent Address")%>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    PRESENT ADDRESS
                                </td>
                                <td>
                                    :
                                </td>
                                <td>
                                    <asp:Label runat="server" ID="lblCurrentAddress" Text='<%#Eval("Current Address")%>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    GENDER
                                </td>
                                <td>
                                    :
                                </td>
                                <td>
                                    <asp:Label runat="server" ID="lblGender" Text='<%#Eval("Gender")%>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    D.O.B
                                </td>
                                <td>
                                    :
                                </td>
                                <td>
                                    <asp:Label runat="server" ID="lblDOB" Text='<%#Eval("DOB")%>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    RETIREMENT DATE
                                </td>
                                <td>
                                    :
                                </td>
                                <td>
                                    <asp:Label runat="server" ID="lblRetirementDate" Text='<%#Eval("Retirement Date")%>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    RECIDENT NO
                                </td>
                                <td>
                                    :
                                </td>
                                <td>
                                    <asp:Label runat="server" ID="lblRecidentNo" Text='<%#Eval("Recident No")%>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    MOBILE NO
                                </td>
                                <td>
                                    :
                                </td>
                                <td>
                                    <asp:Label runat="server" ID="lblMobileNo" Text='<%#Eval("Mobile No")%>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    EMAIL
                                </td>
                                <td>
                                    :
                                </td>
                                <td>
                                    <asp:Label runat="server" ID="lblEmailAddress" Text='<%#Eval("Email Address")%>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    STATE
                                </td>
                                <td>
                                    :
                                </td>
                                <td>
                                    <asp:Label runat="server" ID="lblState" Text='<%#Eval("State")%>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    CITY
                                </td>
                                <td>
                                    :
                                </td>
                                <td>
                                    <asp:Label runat="server" ID="lblCity" Text='<%#Eval("City")%>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    SERIOUS DIESEASE
                                </td>
                                <td>
                                    :
                                </td>
                                <td>
                                    <asp:Label runat="server" ID="lblSeriousDiesease" Text='<%#Eval("SeriousDiesease")%>'></asp:Label>
                                </td>
                            </tr>
                            <%--<tr><td>PHOTO</td><td> : </td><td><asp:FileUpload runat="server" ID="PhotoUpload" onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"   class="t1"/></td></tr>
<tr><td>SIGNATURE</td><td> : </td><td><asp:FileUpload runat="server" ID="SignatureUpload" onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"   class="t1"/></td></tr>
<tr><td>THUMB IMPRESSION</td><td> : </td><td><asp:FileUpload runat="server" ID="ThumbUpload" onfocus="ChangeStyle(this.id.toString());" onBlur="ChangeDefaultStyle(this.id.toString());"   class="t1"/></td></tr>--%>
                      <tfoot>
                          <tr>
                              <td align="center" colspan="7">
                                  <asp:LinkButton ID="btnEdit" runat="server" class="t2" 
                                      onBlur="ChangeDefaultStyle(this.id.toString());" onclick="btnEdit_Click" 
                                      onfocus="ChangeStyle(this.id.toString());" 
                                      PostBackUrl='<%# "~/HR/EmployeeDetails.aspx?id=" + Eval("id")%>' Text="EDIT"></asp:LinkButton>
                              </td>
                          </tr>
                    </tfoot>
    
                        </table>
                    </ItemTemplate>
                </asp:DataList>
            </td>
        </tr>
    </table>
</asp:Content>
