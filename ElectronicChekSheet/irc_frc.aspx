<%@ Page Language="C#" MasterPageFile="~/Loco/MasterPage.master" AutoEventWireup="true"
    CodeFile="irc_frc.aspx.cs" Inherits="ElectronicChekSheet_irc_frc" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table>
        <tr>
            <th colspan="11">
                IRC / FRC SHEET
            </th>
        </tr>
        <tr>
            <td style="height: 34px;" colspan="4">
                CLASS :
                <asp:DropDownList ID="ddlClass" runat="server" AutoPostBack="True" CssClass="t1"
                    OnSelectedIndexChanged="ddlClass_SelectedIndexChanged">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList></td>
            <td style="height: 34px;" colspan="4">
                LOCO NO :
                <asp:DropDownList ID="ddlLocono" runat="server" AutoPostBack="True" CssClass="t1"
                    >
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList></td>
            <td style="height: 34px;" colspan="3">
                SCHEDULE:
                <asp:DropDownList ID="ddlSchedule" runat="server" CssClass="t1" OnSelectedIndexChanged="ddlSchedule_SelectedIndexChanged" AutoPostBack="True">
                    <asp:ListItem>SELECT</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td colspan="11">
                <span style="font-size: 11pt; font-family: 'Arial Narrow'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial"><strong>Name of Technician</strong></span><span
                        style="font-size: 11pt; font-family: 'Arial Narrow'; mso-fareast-font-family: 'Times New Roman';
                        mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                        mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial"><strong>:&nbsp;<asp:DropDownList
                            ID="ddlTech" runat="server" CssClass="t1">
                            <asp:ListItem>SELECT</asp:ListItem>
                        </asp:DropDownList></strong></span> &nbsp; &nbsp; &nbsp; <span style="font-size: 11pt;
                            font-family: 'Arial Narrow'; mso-fareast-font-family: 'Times New Roman'; mso-ansi-language: EN-US;
                            mso-fareast-language: EN-US; mso-bidi-language: AR-SA; mso-bidi-font-size: 12.0pt;
                            mso-bidi-font-family: Arial"></span><strong><span style="font-size: 11pt; font-family: 'Arial Narrow';
                                mso-fareast-font-family: 'Times New Roman'; mso-ansi-language: EN-US; mso-fareast-language: EN-US;
                                mso-bidi-language: AR-SA; mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial">
                                Timing : Work start <span style="font-size: 11pt; font-family: 'Arial Narrow'; mso-fareast-font-family: 'Times New Roman';
                                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                                    mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial"><strong>: &nbsp;</strong></span><asp:TextBox
                                        ID="txtstart" runat="server" CssClass="t1" Width="43px"></asp:TextBox>
                                &nbsp; &nbsp; &nbsp; </span></strong><strong><span style="font-size: 11pt"><span
                                    style="font-family: Arial Narrow">Finish</span><span style="font-family: 'Arial Narrow';
                                        mso-fareast-font-family: 'Times New Roman'; mso-ansi-language: EN-US; mso-fareast-language: EN-US;
                                        mso-bidi-language: AR-SA; mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial">:
                                        &nbsp;</span></span></strong><asp:TextBox ID="txtfinish" runat="server" CssClass="t1"
                                            Width="43px"></asp:TextBox>
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; <strong><span style="font-size: 11pt;
                    font-family: Arial Narrow">Date :&nbsp;
                    <asp:TextBox ID="txtdate" runat="server" CssClass="t1" Width="91px"></asp:TextBox></span></strong></td>
        </tr>
        <tr>
            <td colspan="6">
                <span style="font-size: 11pt; font-family: 'Arial Narrow'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial"><strong>Name of Supervisor
                    </strong></span><span style="font-size: 11pt; font-family: 'Arial Narrow'; mso-fareast-font-family: 'Times New Roman';
                        mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                        mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial"><strong>:
                            <asp:DropDownList ID="ddlSuper" runat="server" CssClass="t1">
                                <asp:ListItem>SELECT</asp:ListItem>
                            </asp:DropDownList>
                            &nbsp;
                            <asp:DropDownList
                            ID="ddlSection" runat="server" CssClass="t1">
                                <asp:ListItem>SELECT</asp:ListItem>
                            </asp:DropDownList>
                            <asp:TextBox ID="TextBox437" runat="server" CssClass="t1" Width="43px"></asp:TextBox></strong></span></td>
        </tr>
        <tr>
            <td colspan="8">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>CHECK WORKING AND INTACTNESS OF FOLLOWING ITEMS</strong></span></td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td colspan="6" rowspan="2">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 8.0pt"><strong>ITEM DESCRIPTION</strong></span></td>
            <td colspan="2">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 8.0pt"><strong>LONGHOOD</strong></span></td>
            <td colspan="2">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 8.0pt"><strong>SHORTHOOD</strong></span></td>
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 8.0pt"><strong>REMARKS</strong></span></td>
        </tr>
        <tr>
            <td style="width: 100px">
                <span style="font-size: 8pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    <strong>WKG</strong></span></td>
            <td style="width: 100px">
                <span style="font-size: 8pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    <strong>NW</strong></span></td>
            <td style="width: 100px">
                <span style="font-size: 8pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    <strong>WKG</strong></span></td>
            <td style="width: 100px">
                <span style="font-size: 8pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    <strong>NW</strong></span></td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td colspan="6">
                <span style="font-size: 8pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt">FLASHER LAMP</span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox1" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox2" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox3" runat="server" CssClass="t1" Width="43px"></asp:TextBox>3</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox4" runat="server" CssClass="t1" Width="43px"></asp:TextBox>4</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox5" runat="server" CssClass="t1" Width="244px"></asp:TextBox>5</td>
        </tr>
        <tr>
            <td colspan="6">
                <span style="font-size: 8pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt">HEAD LIGHT</span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox6" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox7" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox8" runat="server" CssClass="t1" Width="43px"></asp:TextBox>8</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox9" runat="server" CssClass="t1" Width="43px"></asp:TextBox>9</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox10" runat="server" CssClass="t1" Width="244px"></asp:TextBox>10</td>
        </tr>
        <tr>
            <td colspan="6">
                <span style="font-size: 8pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt">CLASSIFICATION LAMP</span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox11" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox12" runat="server" CssClass="t1" Width="43px"></asp:TextBox>12</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox13" runat="server" CssClass="t1" Width="43px"></asp:TextBox>13</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox14" runat="server" CssClass="t1" Width="43px"></asp:TextBox>14</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox15" runat="server" CssClass="t1" Width="244px"></asp:TextBox>15</td>
        </tr>
        <tr>
            <td colspan="6">
                <span style="font-size: 8pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt">HORNS</span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox16" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox17" runat="server" CssClass="t1" Width="43px"></asp:TextBox>17</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox18" runat="server" CssClass="t1" Width="43px"></asp:TextBox>18</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox19" runat="server" CssClass="t1" Width="43px"></asp:TextBox>19</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox20" runat="server" CssClass="t1" Width="244px"></asp:TextBox>20</td>
        </tr>
        <tr>
            <td colspan="6">
                <span style="font-size: 8pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt">SANDERS &amp; DIRECTION</span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox21" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox22" runat="server" CssClass="t1" Width="43px"></asp:TextBox>22</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox23" runat="server" CssClass="t1" Width="43px"></asp:TextBox>23</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox24" runat="server" CssClass="t1" Width="43px"></asp:TextBox>24</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox25" runat="server" CssClass="t1" Width="244px"></asp:TextBox>25</td>
        </tr>
        <tr>
            <td colspan="6">
                <span style="font-size: 8pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt">CAB LIGHT&amp; EXTERIOR LIGHTS</span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox33" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox34" runat="server" CssClass="t1" Width="43px"></asp:TextBox>34</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox35" runat="server" CssClass="t1" Width="43px"></asp:TextBox>35</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox36" runat="server" CssClass="t1" Width="43px"></asp:TextBox>36</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox37" runat="server" CssClass="t1" Width="244px"></asp:TextBox>37</td>
        </tr>
        <tr>
            <td colspan="6">
                <span style="font-size: 8pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt">OPEN CONTROLLER<span style="mso-spacerun: yes">&nbsp; </span>
                    BEZEL &amp; CHECK</span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox38" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox39" runat="server" CssClass="t1" Width="43px"></asp:TextBox>39</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox40" runat="server" CssClass="t1" Width="43px"></asp:TextBox>40</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox41" runat="server" CssClass="t1" Width="43px"></asp:TextBox>41</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox42" runat="server" CssClass="t1" Width="244px"></asp:TextBox>42</td>
        </tr>
        <tr>
            <td colspan="6">
                <span style="font-size: 8pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt">ALERTER, LAMP, ALARM &amp; RESET</span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox43" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox44" runat="server" CssClass="t1" Width="43px"></asp:TextBox>44</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox45" runat="server" CssClass="t1" Width="43px"></asp:TextBox>45</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox46" runat="server" CssClass="t1" Width="43px"></asp:TextBox>46</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox47" runat="server" CssClass="t1" Width="244px"></asp:TextBox>47</td>
        </tr>
        <tr>
            <td colspan="6">
                <span style="font-size: 8pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt">FLASHER LIGHT SWITCH PANEL</span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox48" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox49" runat="server" CssClass="t1" Width="43px"></asp:TextBox>49</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox50" runat="server" CssClass="t1" Width="43px"></asp:TextBox>50</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox51" runat="server" CssClass="t1" Width="43px"></asp:TextBox>51</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox52" runat="server" CssClass="t1" Width="244px"></asp:TextBox>52</td>
        </tr>
        <tr>
            <td colspan="6">
                <span style="font-size: 8pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt">GR , DB CUTOUT &amp; B/B CUTOUT SEALS</span></td>
            <td colspan="4">
                <asp:TextBox ID="TextBox26" runat="server" CssClass="t1" Width="244px"></asp:TextBox>26</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox53" runat="server" CssClass="t1" Width="244px"></asp:TextBox>53</td>
        </tr>
        <tr>
            <td colspan="6">
                <span style="font-size: 8pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt">INDICATION PANELS</span></td>
            <td colspan="2">
                <asp:TextBox ID="TextBox27" runat="server" CssClass="t1" Width="131px"></asp:TextBox>27</td>
            <td colspan="2">
                <asp:TextBox ID="TextBox28" runat="server" CssClass="t1" Width="131px"></asp:TextBox>28</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox54" runat="server" CssClass="t1" Width="244px"></asp:TextBox>54</td>
        </tr>
        <tr>
            <td colspan="6">
                <span style="font-size: 8pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt">ATTENDANT CALL
                    <?xml namespace="" ns="urn:schemas-microsoft-com:office:smarttags" prefix="st1" ?><st1:place w:st="on"><st1:City w:st="on">BELL</st1:City></st1:place>
                </span>
            </td>
            <td colspan="2">
                <asp:TextBox ID="TextBox29" runat="server" CssClass="t1" Width="131px"></asp:TextBox>29</td>
            <td colspan="2">
                <asp:TextBox ID="TextBox30" runat="server" CssClass="t1" Width="131px"></asp:TextBox>30</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox55" runat="server" CssClass="t1" Width="244px"></asp:TextBox>55</td>
        </tr>
        <tr>
            <td colspan="6">
                <span style="font-size: 8pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt">CAB FANS</span></td>
            <td colspan="2">
                <asp:TextBox ID="TextBox31" runat="server" CssClass="t1" Width="131px"></asp:TextBox>31</td>
            <td colspan="2">
                <asp:TextBox ID="TextBox32" runat="server" CssClass="t1" Width="131px"></asp:TextBox>32</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox56" runat="server" CssClass="t1" Width="244px"></asp:TextBox>56</td>
        </tr>
        <tr>
            <td colspan="11">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>CONDUCT THE FOLLOWING SELF TESTS</strong></span></td>
        </tr>
        <tr>
            <td colspan="11">
                &nbsp;<asp:GridView ID="gv1" runat="server" AutoGenerateColumns="False" Height="139px"
                     Width="705px">
                    <Columns>
                        <asp:TemplateField HeaderText="SNO.">
                            <ItemTemplate>
                                <%#Container.DataItemIndex +1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="sub_head_details" HeaderText="detail" />
                        <asp:TemplateField HeaderText="status">
                            <ItemTemplate>
                                <asp:TextBox ID="txt1" runat="server" CssClass="t1"></asp:TextBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="action_taken">
                            <ItemTemplate>
                                <asp:TextBox ID="txt2" runat="server" CssClass="t1"></asp:TextBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td colspan="7">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 8.0pt"><strong>RECORD THE CURRENTS OF THE FOLLOWING </strong>
                </span>
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 8.0pt"><strong>TCC ELECTRONIC MOTOR</strong></span></td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 8.0pt"><strong>FILTER BLOWER MOTOR</strong></span></td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 8.0pt"><strong>TCC # 1 BLOWER MOTOR </strong></span>
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 8.0pt"><strong>TCC # 2 BLOWER MOTOR</strong></span></td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 8.0pt"><strong>FUEL PUMP MOTOR</strong></span></td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 8.0pt"><strong>IDLE</strong></span></td>
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 8.0pt"><strong><span style="font-size: 9pt; font-family: Arial;
                        mso-fareast-font-family: 'Times New Roman'; mso-ansi-language: EN-US; mso-fareast-language: EN-US;
                        mso-bidi-language: AR-SA; mso-bidi-font-size: 8.0pt">8TH</span></strong></span></td>
            <td style="width: 100px">
                <strong><span style="font-family: Arial">IDLE</span></strong></td>
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 8.0pt"><strong>8TH</strong></span></td>
            <td style="width: 100px">
                <strong><span style="font-family: Arial">IDLE</span></strong></td>
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 8.0pt"><strong>8TH</strong></span></td>
            <td style="width: 100px">
                <strong><span style="font-family: Arial">IDLE</span></strong></td>
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 8.0pt"><strong>8TH</strong></span></td>
            <td style="width: 100px">
                <strong><span style="font-family: Arial">IDLE</span></strong></td>
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 8.0pt"><strong>8TH</strong></span></td>
        </tr>
        <tr>
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 8.0pt"><strong>R</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox57" runat="server" CssClass="t1" Width="43px"></asp:TextBox>57</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox62" runat="server" CssClass="t1" Width="43px"></asp:TextBox>62</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox63" runat="server" CssClass="t1" Width="43px"></asp:TextBox>63</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox66" runat="server" CssClass="t1" Width="43px"></asp:TextBox>66</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox69" runat="server" CssClass="t1" Width="43px"></asp:TextBox>69</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox72" runat="server" CssClass="t1" Width="43px"></asp:TextBox>72</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox75" runat="server" CssClass="t1" Width="43px"></asp:TextBox>75</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox78" runat="server" CssClass="t1" Width="43px"></asp:TextBox>78</td>
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 8.0pt">
                    <asp:TextBox ID="TextBox81" runat="server" CssClass="t1" Width="43px"></asp:TextBox>81&nbsp;</span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox82" runat="server" CssClass="t1" Width="43px"></asp:TextBox>82</td>
        </tr>
        <tr>
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 8.0pt"><strong>S</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox58" runat="server" CssClass="t1" Width="43px"></asp:TextBox>58</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox61" runat="server" CssClass="t1" Width="43px"></asp:TextBox>61</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox64" runat="server" CssClass="t1" Width="43px"></asp:TextBox>64</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox67" runat="server" CssClass="t1" Width="43px"></asp:TextBox>67</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox70" runat="server" CssClass="t1" Width="43px"></asp:TextBox>70</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox73" runat="server" CssClass="t1" Width="43px"></asp:TextBox>73</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox76" runat="server" CssClass="t1" Width="43px"></asp:TextBox>74</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox79" runat="server" CssClass="t1" Width="43px"></asp:TextBox>79</td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 8.0pt"><strong>T</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox59" runat="server" CssClass="t1" Width="43px"></asp:TextBox>59</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox60" runat="server" CssClass="t1" Width="43px"></asp:TextBox>60</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox65" runat="server" CssClass="t1" Width="43px"></asp:TextBox>65</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox68" runat="server" CssClass="t1" Width="43px"></asp:TextBox>68</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox71" runat="server" CssClass="t1" Width="43px"></asp:TextBox>71</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox74" runat="server" CssClass="t1" Width="43px"></asp:TextBox>74</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox77" runat="server" CssClass="t1" Width="43px"></asp:TextBox>77</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox80" runat="server" CssClass="t1" Width="43px"></asp:TextBox>80</td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td colspan="7">
                <p class="MsoNormal" style="margin: 0in 0in 0pt">
                    <b><span style="font-size: 9pt; font-family: Arial; mso-bidi-font-size: 12.0pt">RECORD
                        THE VOLTAGES OF THE FOLLOWING:<?xml namespace="" ns="urn:schemas-microsoft-com:office:office"
                            prefix="o" ?><o:p></o:p></span></b></p>
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>PRG</strong></span></td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>PSM 300</strong></span></td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>PSM 310</strong></span></td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>PSM 320</strong></span></td>
            <td style="width: 100px">
            </td>
            <td colspan="2">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>HEAD LIGHTS</strong></span></td>
        </tr>
        <tr>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
                <span style="font-size: 12pt; font-family: 'Times New Roman'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    <span style="font-size: 12pt; font-family: 'Times New Roman'; mso-fareast-font-family: 'Times New Roman';
                        mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                        <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                            mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                            mso-bidi-font-size: 8.0pt"><strong>IDLE</strong></span></span></span></td>
            <td style="width: 100px; font-size: 9pt;">
                <span style="font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 8.0pt"><strong>8TH</strong></span></td>
            <td style="width: 100px; font-size: 9pt;">
                <strong><span style="font-family: Arial">IDLE</span></strong></td>
            <td style="width: 100px; font-size: 9pt;">
                <strong><span style="font-family: Arial">8TH</span></strong></td>
            <td style="width: 100px; font-size: 9pt;">
                <strong><span style="font-family: Arial">IDLE</span></strong></td>
            <td style="width: 100px; font-size: 9pt;">
                <strong><span style="font-family: Arial">8TH</span></strong></td>
            <td style="width: 100px; font-size: 9pt;">
                <strong><span style="font-family: Arial">IDLE</span></strong></td>
            <td style="width: 100px; font-size: 9pt;">
                <strong><span style="font-family: Arial">8TH</span></strong></td>
            <td style="width: 100px; font-size: 9pt;">
                <span style="mso-fareast-font-family: 'Times New Roman'; mso-ansi-language: EN-US;
                    mso-fareast-language: EN-US; mso-bidi-language: AR-SA"><span style="font-family: Arial;
                        mso-fareast-font-family: 'Times New Roman'; mso-ansi-language: EN-US; mso-fareast-language: EN-US;
                        mso-bidi-language: AR-SA"><strong>S/H</strong></span></span></td>
            <td style="width: 100px; font-size: 9pt;">
                <span style="font-family: Arial; mso-fareast-font-family: 'Times New Roman'; mso-ansi-language: EN-US;
                    mso-fareast-language: EN-US; mso-bidi-language: AR-SA; mso-bidi-font-size: 12.0pt">
                    <strong>L/H</strong></span></td>
        </tr>
        <tr style="font-size: 9pt">
            <td style="width: 100px">
                <span style="font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>I/P</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox83" runat="server" CssClass="t1" Width="43px"></asp:TextBox>83</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox86" runat="server" CssClass="t1" Width="43px"></asp:TextBox>86</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox87" runat="server" CssClass="t1" Width="43px"></asp:TextBox>87</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox90" runat="server" CssClass="t1" Width="43px"></asp:TextBox>90</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox91" runat="server" CssClass="t1" Width="43px"></asp:TextBox>91</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox94" runat="server" CssClass="t1" Width="43px"></asp:TextBox>94</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox95" runat="server" CssClass="t1" Width="43px"></asp:TextBox>95</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox98" runat="server" CssClass="t1" Width="43px"></asp:TextBox>98</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox99" runat="server" CssClass="t1" Width="43px"></asp:TextBox>99</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox100" runat="server" CssClass="t1" Width="43px"></asp:TextBox>100</td>
        </tr>
        <tr style="font-size: 9pt">
            <td style="width: 100px">
                <span style="font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>O/P</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox84" runat="server" CssClass="t1" Width="43px"></asp:TextBox>84</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox85" runat="server" CssClass="t1" Width="43px"></asp:TextBox>85</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox88" runat="server" CssClass="t1" Width="43px"></asp:TextBox>88</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox89" runat="server" CssClass="t1" Width="43px"></asp:TextBox>89</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox92" runat="server" CssClass="t1" Width="43px"></asp:TextBox>92</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox93" runat="server" CssClass="t1" Width="43px"></asp:TextBox>93</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox96" runat="server" CssClass="t1" Width="43px"></asp:TextBox>96</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox97" runat="server" CssClass="t1" Width="43px"></asp:TextBox>97</td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr style="font-size: 9pt">
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox101" runat="server" CssClass="t1" Width="43px"></asp:TextBox>101</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox102" runat="server" CssClass="t1" Width="43px"></asp:TextBox>102</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox103" runat="server" CssClass="t1" Width="43px"></asp:TextBox>103</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox104" runat="server" CssClass="t1" Width="43px"></asp:TextBox>104</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox105" runat="server" CssClass="t1" Width="43px"></asp:TextBox>105</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox106" runat="server" CssClass="t1" Width="43px"></asp:TextBox>106</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox107" runat="server" CssClass="t1" Width="43px"></asp:TextBox>107</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox108" runat="server" CssClass="t1" Width="43px"></asp:TextBox>108</td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr style="font-size: 9pt">
            <td colspan="4">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>LOAD TEST
                        <?xml namespace="" ns="urn:schemas-microsoft-com:office:smarttags" prefix="st1" ?><st1:place w:st="on"><st1:City w:st="on">READINGS</st1:City></st1:place>
                    </strong></span>
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr style="font-size: 9pt">
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>THR POS.</strong></span></td>
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>IDLE</strong></span></td>
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt">1</span>
            </td>
            <td style="width: 100px">
                2</td>
            <td style="width: 100px">
                3</td>
            <td style="width: 100px">
                4</td>
            <td style="width: 100px">
                5</td>
            <td style="width: 100px">
                6</td>
            <td style="width: 100px">
                7</td>
            <td style="width: 100px">
                8</td>
            <td style="width: 100px">
                LT2</td>
        </tr>
        <tr style="font-size: 9pt">
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>ENG RPM</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox109" runat="server" CssClass="t1" Width="43px"></asp:TextBox>109</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox131" runat="server" CssClass="t1" Width="43px"></asp:TextBox>131</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox174" runat="server" CssClass="t1" Width="43px"></asp:TextBox>174</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox175" runat="server" CssClass="t1" Width="43px"></asp:TextBox>175</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox197" runat="server" CssClass="t1" Width="43px"></asp:TextBox>197</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox240" runat="server" CssClass="t1" Width="43px"></asp:TextBox>240</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox262" runat="server" CssClass="t1" Width="43px"></asp:TextBox>262</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox263" runat="server" CssClass="t1" Width="43px"></asp:TextBox>263</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox306" runat="server" CssClass="t1" Width="43px"></asp:TextBox>306</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox307" runat="server" CssClass="t1" Width="43px"></asp:TextBox>307</td>
        </tr>
        <tr style="font-size: 9pt">
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>L.R.%</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox110" runat="server" CssClass="t1" Width="43px"></asp:TextBox>110</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox132" runat="server" CssClass="t1" Width="43px"></asp:TextBox>132</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox173" runat="server" CssClass="t1" Width="43px"></asp:TextBox>173</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox176" runat="server" CssClass="t1" Width="43px"></asp:TextBox>176</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox198" runat="server" CssClass="t1" Width="43px"></asp:TextBox>198</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox239" runat="server" CssClass="t1" Width="43px"></asp:TextBox>239</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox261" runat="server" CssClass="t1" Width="43px"></asp:TextBox>261</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox264" runat="server" CssClass="t1" Width="43px"></asp:TextBox>264</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox305" runat="server" CssClass="t1" Width="43px"></asp:TextBox>305</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox308" runat="server" CssClass="t1" Width="43px"></asp:TextBox>308</td>
        </tr>
        <tr style="font-size: 9pt">
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>ENG HP</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox111" runat="server" CssClass="t1" Width="43px"></asp:TextBox>111</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox133" runat="server" CssClass="t1" Width="43px"></asp:TextBox>133</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox172" runat="server" CssClass="t1" Width="43px"></asp:TextBox>172</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox177" runat="server" CssClass="t1" Width="43px"></asp:TextBox>177</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox199" runat="server" CssClass="t1" Width="43px"></asp:TextBox>199</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox238" runat="server" CssClass="t1" Width="43px"></asp:TextBox>238</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox260" runat="server" CssClass="t1" Width="43px"></asp:TextBox>260</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox265" runat="server" CssClass="t1" Width="43px"></asp:TextBox>265</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox304" runat="server" CssClass="t1" Width="43px"></asp:TextBox>304</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox309" runat="server" CssClass="t1" Width="43px"></asp:TextBox>309</td>
        </tr>
        <tr style="font-size: 9pt">
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>TPU</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox112" runat="server" CssClass="t1" Width="43px"></asp:TextBox>112</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox134" runat="server" CssClass="t1" Width="43px"></asp:TextBox>134</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox171" runat="server" CssClass="t1" Width="43px"></asp:TextBox>171</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox178" runat="server" CssClass="t1" Width="43px"></asp:TextBox>178</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox200" runat="server" CssClass="t1" Width="43px"></asp:TextBox>200</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox237" runat="server" CssClass="t1" Width="43px"></asp:TextBox>237</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox259" runat="server" CssClass="t1" Width="43px"></asp:TextBox>259</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox266" runat="server" CssClass="t1" Width="43px"></asp:TextBox>266</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox303" runat="server" CssClass="t1" Width="43px"></asp:TextBox>303</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox310" runat="server" CssClass="t1" Width="43px"></asp:TextBox>310</td>
        </tr>
        <tr style="font-size: 9pt">
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>KW Ref</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox113" runat="server" CssClass="t1" Width="43px"></asp:TextBox>113</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox135" runat="server" CssClass="t1" Width="43px"></asp:TextBox>135</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox170" runat="server" CssClass="t1" Width="43px"></asp:TextBox>170</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox179" runat="server" CssClass="t1" Width="43px"></asp:TextBox>179</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox201" runat="server" CssClass="t1" Width="43px"></asp:TextBox>201</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox236" runat="server" CssClass="t1" Width="43px"></asp:TextBox>236</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox258" runat="server" CssClass="t1" Width="43px"></asp:TextBox>258</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox267" runat="server" CssClass="t1" Width="43px"></asp:TextBox>267</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox302" runat="server" CssClass="t1" Width="43px"></asp:TextBox>302</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox311" runat="server" CssClass="t1" Width="43px"></asp:TextBox>311</td>
        </tr>
        <tr style="font-size: 9pt">
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>KW Fbk</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox114" runat="server" CssClass="t1" Width="43px"></asp:TextBox>114</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox136" runat="server" CssClass="t1" Width="43px"></asp:TextBox>136</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox169" runat="server" CssClass="t1" Width="43px"></asp:TextBox>169</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox180" runat="server" CssClass="t1" Width="43px"></asp:TextBox>180</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox202" runat="server" CssClass="t1" Width="43px"></asp:TextBox>202</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox235" runat="server" CssClass="t1" Width="43px"></asp:TextBox>235</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox257" runat="server" CssClass="t1" Width="43px"></asp:TextBox>257</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox268" runat="server" CssClass="t1" Width="43px"></asp:TextBox>268</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox301" runat="server" CssClass="t1" Width="43px"></asp:TextBox>301</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox312" runat="server" CssClass="t1" Width="43px"></asp:TextBox>312</td>
        </tr>
        <tr style="font-size: 9pt">
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>MGA</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox115" runat="server" CssClass="t1" Width="43px"></asp:TextBox>115</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox137" runat="server" CssClass="t1" Width="43px"></asp:TextBox>137</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox168" runat="server" CssClass="t1" Width="43px"></asp:TextBox>168</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox181" runat="server" CssClass="t1" Width="43px"></asp:TextBox>181</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox203" runat="server" CssClass="t1" Width="43px"></asp:TextBox>203</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox234" runat="server" CssClass="t1" Width="43px"></asp:TextBox>234</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox256" runat="server" CssClass="t1" Width="43px"></asp:TextBox>256</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox269" runat="server" CssClass="t1" Width="43px"></asp:TextBox>269</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox300" runat="server" CssClass="t1" Width="43px"></asp:TextBox>300</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox313" runat="server" CssClass="t1" Width="43px"></asp:TextBox>313</td>
        </tr>
        
          <tr style="font-size: 9pt">
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>MGV</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox116" runat="server" CssClass="t1" Width="43px"></asp:TextBox>116</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox138" runat="server" CssClass="t1" Width="43px"></asp:TextBox>138</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox167" runat="server" CssClass="t1" Width="43px"></asp:TextBox>167</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox182" runat="server" CssClass="t1" Width="43px"></asp:TextBox>182</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox204" runat="server" CssClass="t1" Width="43px"></asp:TextBox>204</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox233" runat="server" CssClass="t1" Width="43px"></asp:TextBox>233</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox255" runat="server" CssClass="t1" Width="43px"></asp:TextBox>255</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox270" runat="server" CssClass="t1" Width="43px"></asp:TextBox>270</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox299" runat="server" CssClass="t1" Width="43px"></asp:TextBox>299</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox314" runat="server" CssClass="t1" Width="43px"></asp:TextBox>314</td>
        </tr>
        <tr style="font-size: 9pt">
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>BAR PRES</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox117" runat="server" CssClass="t1" Width="43px"></asp:TextBox>117</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox139" runat="server" CssClass="t1" Width="43px"></asp:TextBox>139</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox166" runat="server" CssClass="t1" Width="43px"></asp:TextBox>166</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox183" runat="server" CssClass="t1" Width="43px"></asp:TextBox>183</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox205" runat="server" CssClass="t1" Width="43px"></asp:TextBox>205</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox232" runat="server" CssClass="t1" Width="43px"></asp:TextBox>232</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox254" runat="server" CssClass="t1" Width="43px"></asp:TextBox>254</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox271" runat="server" CssClass="t1" Width="43px"></asp:TextBox>271</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox298" runat="server" CssClass="t1" Width="43px"></asp:TextBox>298</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox315" runat="server" CssClass="t1" Width="43px"></asp:TextBox>315</td>
        </tr>
        <tr style="font-size: 9pt">
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>TM AIR</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox118" runat="server" CssClass="t1" Width="43px"></asp:TextBox>118</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox140" runat="server" CssClass="t1" Width="43px"></asp:TextBox>140</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox165" runat="server" CssClass="t1" Width="43px"></asp:TextBox>165</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox184" runat="server" CssClass="t1" Width="43px"></asp:TextBox>184</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox206" runat="server" CssClass="t1" Width="43px"></asp:TextBox>206</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox231" runat="server" CssClass="t1" Width="43px"></asp:TextBox>231</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox253" runat="server" CssClass="t1" Width="43px"></asp:TextBox>253</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox272" runat="server" CssClass="t1" Width="43px"></asp:TextBox>272</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox297" runat="server" CssClass="t1" Width="43px"></asp:TextBox>297</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox316" runat="server" CssClass="t1" Width="43px"></asp:TextBox>3161</td>
        </tr>
        <tr style="font-size: 9pt">
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>MG Field A</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox119" runat="server" CssClass="t1" Width="43px"></asp:TextBox>119</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox141" runat="server" CssClass="t1" Width="43px"></asp:TextBox>141</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox164" runat="server" CssClass="t1" Width="43px"></asp:TextBox>164</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox185" runat="server" CssClass="t1" Width="43px"></asp:TextBox>185</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox207" runat="server" CssClass="t1" Width="43px"></asp:TextBox>207</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox230" runat="server" CssClass="t1" Width="43px"></asp:TextBox>230</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox252" runat="server" CssClass="t1" Width="43px"></asp:TextBox>252</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox273" runat="server" CssClass="t1" Width="43px"></asp:TextBox>273</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox296" runat="server" CssClass="t1" Width="43px"></asp:TextBox>296</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox317" runat="server" CssClass="t1" Width="43px"></asp:TextBox>317</td>
        </tr>
        <tr style="font-size: 9pt">
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>MG CTA</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox120" runat="server" CssClass="t1" Width="43px"></asp:TextBox>120</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox142" runat="server" CssClass="t1" Width="43px"></asp:TextBox>142</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox163" runat="server" CssClass="t1" Width="43px"></asp:TextBox>163</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox186" runat="server" CssClass="t1" Width="43px"></asp:TextBox>186</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox208" runat="server" CssClass="t1" Width="43px"></asp:TextBox>208</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox229" runat="server" CssClass="t1" Width="43px"></asp:TextBox>229</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox251" runat="server" CssClass="t1" Width="43px"></asp:TextBox>251</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox274" runat="server" CssClass="t1" Width="43px"></asp:TextBox>274</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox295" runat="server" CssClass="t1" Width="43px"></asp:TextBox>295</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox318" runat="server" CssClass="t1" Width="43px"></asp:TextBox>318</td>
        </tr>
        <tr style="font-size: 9pt">
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>Grid 1 A</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox130" runat="server" CssClass="t1" Width="43px"></asp:TextBox>130</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox143" runat="server" CssClass="t1" Width="43px"></asp:TextBox>143</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox162" runat="server" CssClass="t1" Width="43px"></asp:TextBox>162</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox187" runat="server" CssClass="t1" Width="43px"></asp:TextBox>187</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox209" runat="server" CssClass="t1" Width="43px"></asp:TextBox>209</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox228" runat="server" CssClass="t1" Width="43px"></asp:TextBox>228</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox250" runat="server" CssClass="t1" Width="43px"></asp:TextBox>250</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox275" runat="server" CssClass="t1" Width="43px"></asp:TextBox>275</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox294" runat="server" CssClass="t1" Width="43px"></asp:TextBox>294</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox319" runat="server" CssClass="t1" Width="43px"></asp:TextBox>319</td>
        </tr>
        <tr style="font-size: 9pt">
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>Grid 2 A</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox129" runat="server" CssClass="t1" Width="43px"></asp:TextBox>129</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox144" runat="server" CssClass="t1" Width="43px"></asp:TextBox>144</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox161" runat="server" CssClass="t1" Width="43px"></asp:TextBox>161</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox188" runat="server" CssClass="t1" Width="43px"></asp:TextBox>188</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox210" runat="server" CssClass="t1" Width="43px"></asp:TextBox>210</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox227" runat="server" CssClass="t1" Width="43px"></asp:TextBox>227</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox249" runat="server" CssClass="t1" Width="43px"></asp:TextBox>249</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox276" runat="server" CssClass="t1" Width="43px"></asp:TextBox>276</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox293" runat="server" CssClass="t1" Width="43px"></asp:TextBox>293</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox320" runat="server" CssClass="t1" Width="43px"></asp:TextBox>320</td>
        </tr>
          <tr style="font-size: 9pt">
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>Grid Blw1 A</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox128" runat="server" CssClass="t1" Width="43px"></asp:TextBox>128</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox145" runat="server" CssClass="t1" Width="43px"></asp:TextBox>145</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox160" runat="server" CssClass="t1" Width="43px"></asp:TextBox>160</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox189" runat="server" CssClass="t1" Width="43px"></asp:TextBox>189</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox211" runat="server" CssClass="t1" Width="43px"></asp:TextBox>211</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox226" runat="server" CssClass="t1" Width="43px"></asp:TextBox>226</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox248" runat="server" CssClass="t1" Width="43px"></asp:TextBox>248</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox277" runat="server" CssClass="t1" Width="43px"></asp:TextBox>277</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox292" runat="server" CssClass="t1" Width="43px"></asp:TextBox>292</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox321" runat="server" CssClass="t1" Width="43px"></asp:TextBox>321</td>
        </tr>
        <tr style="font-size: 9pt">
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>Grid Blw 2 A</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox127" runat="server" CssClass="t1" Width="43px"></asp:TextBox>127</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox146" runat="server" CssClass="t1" Width="43px"></asp:TextBox>146</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox159" runat="server" CssClass="t1" Width="43px"></asp:TextBox>159</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox190" runat="server" CssClass="t1" Width="43px"></asp:TextBox>190</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox212" runat="server" CssClass="t1" Width="43px"></asp:TextBox>212</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox225" runat="server" CssClass="t1" Width="43px"></asp:TextBox>225</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox247" runat="server" CssClass="t1" Width="43px"></asp:TextBox>247</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox278" runat="server" CssClass="t1" Width="43px"></asp:TextBox>278</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox291" runat="server" CssClass="t1" Width="43px"></asp:TextBox>291</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox322" runat="server" CssClass="t1" Width="43px"></asp:TextBox>322</td>
        </tr>
        <tr style="font-size: 9pt">
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>CAV</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox126" runat="server" CssClass="t1" Width="43px"></asp:TextBox>126</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox147" runat="server" CssClass="t1" Width="43px"></asp:TextBox>147</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox158" runat="server" CssClass="t1" Width="43px"></asp:TextBox>158</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox191" runat="server" CssClass="t1" Width="43px"></asp:TextBox>191</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox213" runat="server" CssClass="t1" Width="43px"></asp:TextBox>213</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox224" runat="server" CssClass="t1" Width="43px"></asp:TextBox>224</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox246" runat="server" CssClass="t1" Width="43px"></asp:TextBox>246</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox279" runat="server" CssClass="t1" Width="43px"></asp:TextBox>279</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox290" runat="server" CssClass="t1" Width="43px"></asp:TextBox>290</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox323" runat="server" CssClass="t1" Width="43px"></asp:TextBox>323</td>
        </tr>
        <tr style="font-size: 9pt">
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>ETP 1 Temp</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox125" runat="server" CssClass="t1" Width="43px"></asp:TextBox>125</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox148" runat="server" CssClass="t1" Width="43px"></asp:TextBox>148</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox157" runat="server" CssClass="t1" Width="43px"></asp:TextBox>157</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox192" runat="server" CssClass="t1" Width="43px"></asp:TextBox>192</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox214" runat="server" CssClass="t1" Width="43px"></asp:TextBox>214</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox223" runat="server" CssClass="t1" Width="43px"></asp:TextBox>223</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox245" runat="server" CssClass="t1" Width="43px"></asp:TextBox>245</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox280" runat="server" CssClass="t1" Width="43px"></asp:TextBox>280</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox289" runat="server" CssClass="t1" Width="43px"></asp:TextBox>289</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox324" runat="server" CssClass="t1" Width="43px"></asp:TextBox>324</td>
        </tr>
        <tr style="font-size: 9pt">
            <td style="width: 100px">
                <p class="MsoNormal" style="margin: 0in 0in 0pt">
                    <b><span style="font-size: 9pt; font-family: Arial; mso-bidi-font-size: 12.0pt">ETP
                        2 </span></b><b><span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                            mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                            mso-bidi-font-size: 12.0pt">Temp</span></b></p>
            </td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox124" runat="server" CssClass="t1" Width="43px"></asp:TextBox>124</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox149" runat="server" CssClass="t1" Width="43px"></asp:TextBox>149</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox156" runat="server" CssClass="t1" Width="43px"></asp:TextBox>156</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox193" runat="server" CssClass="t1" Width="43px"></asp:TextBox>193</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox215" runat="server" CssClass="t1" Width="43px"></asp:TextBox>215</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox222" runat="server" CssClass="t1" Width="43px"></asp:TextBox>222</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox244" runat="server" CssClass="t1" Width="43px"></asp:TextBox>244</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox281" runat="server" CssClass="t1" Width="43px"></asp:TextBox>281</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox288" runat="server" CssClass="t1" Width="43px"></asp:TextBox>288</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox325" runat="server" CssClass="t1" Width="43px"></asp:TextBox>325</td>
        </tr>
        <tr style="font-size: 9pt">
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>Rad F#1</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox123" runat="server" CssClass="t1" Width="43px"></asp:TextBox>123</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox150" runat="server" CssClass="t1" Width="43px"></asp:TextBox>150</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox155" runat="server" CssClass="t1" Width="43px"></asp:TextBox>155</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox194" runat="server" CssClass="t1" Width="43px"></asp:TextBox>194</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox216" runat="server" CssClass="t1" Width="43px"></asp:TextBox>216</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox221" runat="server" CssClass="t1" Width="43px"></asp:TextBox>221</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox243" runat="server" CssClass="t1" Width="43px"></asp:TextBox>243</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox282" runat="server" CssClass="t1" Width="43px"></asp:TextBox>282</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox287" runat="server" CssClass="t1" Width="43px"></asp:TextBox>287</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox326" runat="server" CssClass="t1" Width="43px"></asp:TextBox>326</td>
        </tr>
        <tr style="font-size: 9pt">
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>Rad F#2</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox122" runat="server" CssClass="t1" Width="43px"></asp:TextBox>122</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox151" runat="server" CssClass="t1" Width="43px"></asp:TextBox>151</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox154" runat="server" CssClass="t1" Width="43px"></asp:TextBox>154</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox195" runat="server" CssClass="t1" Width="43px"></asp:TextBox>195</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox217" runat="server" CssClass="t1" Width="43px"></asp:TextBox>217</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox220" runat="server" CssClass="t1" Width="43px"></asp:TextBox>220</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox242" runat="server" CssClass="t1" Width="43px"></asp:TextBox>242</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox283" runat="server" CssClass="t1" Width="43px"></asp:TextBox>283</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox286" runat="server" CssClass="t1" Width="43px"></asp:TextBox>286</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox327" runat="server" CssClass="t1" Width="43px"></asp:TextBox>327</td>
        </tr>  <tr style="font-size: 9pt">
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>ECC1 PRESSURE</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox121" runat="server" CssClass="t1" Width="43px"></asp:TextBox>121</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox152" runat="server" CssClass="t1" Width="43px"></asp:TextBox>152</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox153" runat="server" CssClass="t1" Width="43px"></asp:TextBox>153</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox196" runat="server" CssClass="t1" Width="43px"></asp:TextBox>196</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox218" runat="server" CssClass="t1" Width="43px"></asp:TextBox>218</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox219" runat="server" CssClass="t1" Width="43px"></asp:TextBox>219</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox241" runat="server" CssClass="t1" Width="43px"></asp:TextBox>241</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox284" runat="server" CssClass="t1" Width="43px"></asp:TextBox>284</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox285" runat="server" CssClass="t1" Width="43px"></asp:TextBox>285</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox328" runat="server" CssClass="t1" Width="43px"></asp:TextBox>328</td>
        </tr>
        <tr style="font-size: 9pt">
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr style="font-size: 9pt">
            <td colspan="3">
                <p class="MsoNormal" style="margin: 0in 0in 0pt">
                    <b><span style="font-size: 9pt; font-family: Arial; mso-bidi-font-size: 12.0pt">DYNAMIC
                        BRAKE: DB POSITION 8<?xml namespace="" ns="urn:schemas-microsoft-com:office:office"
                            prefix="o" ?><o:p></o:p></span></b></p>
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr style="font-size: 9pt">
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>OP MODE</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox329" runat="server" CssClass="t1" Width="43px"></asp:TextBox>329</td>
            <td style="width: 100px">
                <span style="font-size: 12pt; font-family: 'Times New Roman'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    <span style="font-size: 12pt; font-family: 'Times New Roman'; mso-fareast-font-family: 'Times New Roman';
                        mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                        <strong>TL 24 T Ref Volts</strong></span></span></td>
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>S/H</strong></span></td>
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>L/H</strong></span></td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr style="font-size: 9pt">
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>DCLV</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox330" runat="server" CssClass="t1" Width="43px"></asp:TextBox>330</td>
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>DB POS 1</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox338" runat="server" CssClass="t1" Width="43px"></asp:TextBox>338</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox339" runat="server" CssClass="t1" Width="43px"></asp:TextBox>339</td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr style="font-size: 9pt">
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>DCLA</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox331" runat="server" CssClass="t1" Width="43px"></asp:TextBox>331</td>
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>DB POS 2</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox340" runat="server" CssClass="t1" Width="43px"></asp:TextBox>340</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox352" runat="server" CssClass="t1" Width="43px"></asp:TextBox>352</td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr style="font-size: 9pt">
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>GRIDS KW</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox332" runat="server" CssClass="t1" Width="43px"></asp:TextBox>332</td>
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>DB POS 3</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox341" runat="server" CssClass="t1" Width="43px"></asp:TextBox>341</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox433" runat="server" CssClass="t1" Width="43px"></asp:TextBox>433</td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
        </tr>  <tr style="font-size: 9pt">
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>GRID 1 A</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox333" runat="server" CssClass="t1" Width="43px"></asp:TextBox>333</td>
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>DB POS 4</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox342" runat="server" CssClass="t1" Width="43px"></asp:TextBox>342</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox351" runat="server" CssClass="t1" Width="43px"></asp:TextBox>351</td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr style="font-size: 9pt">
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>GRID 2 A</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox334" runat="server" CssClass="t1" Width="43px"></asp:TextBox>334</td>
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>DB POS 5</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox343" runat="server" CssClass="t1" Width="43px"></asp:TextBox>343</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox350" runat="server" CssClass="t1" Width="43px"></asp:TextBox>350</td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr style="font-size: 9pt">
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>GRID BLW 1 A</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox335" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>DB POS 6</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox344" runat="server" CssClass="t1" Width="43px"></asp:TextBox>344</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox349" runat="server" CssClass="t1" Width="43px"></asp:TextBox>349</td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr style="font-size: 9pt">
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>GRID BLW 2A</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox336" runat="server" CssClass="t1" Width="43px"></asp:TextBox></td>
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>DB POS 7</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox345" runat="server" CssClass="t1" Width="43px"></asp:TextBox>345</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox348" runat="server" CssClass="t1" Width="43px"></asp:TextBox>348</td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr style="font-size: 9pt">
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>ENG RPM</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox337" runat="server" CssClass="t1" Width="43px"></asp:TextBox>337</td>
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>DB POS 8</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox346" runat="server" CssClass="t1" Width="43px"></asp:TextBox>346</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox347" runat="server" CssClass="t1" Width="43px"></asp:TextBox>347</td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr style="font-size: 9pt">
            <td colspan="10">
                <p class="MsoNormal" style="margin: 0in 0in 0pt; tab-stops: .25in">
                    <b><span style="font-size: 9pt; font-family: Arial; mso-bidi-font-size: 12.0pt">NOTE:
                        FOLLOWING INPUT SIGNALS TO BE PROGRAMMED IN EM 2000 WHILE CHECKING CONTROLLER<?xml
                            namespace="" ns="urn:schemas-microsoft-com:office:office" prefix="o" ?><o:p></o:p></span></b></p>
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr style="font-size: 9pt">
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>TH POS</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox353" runat="server" CssClass="t1" Width="43px"></asp:TextBox>353</td>
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>TH IDL&lt;</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox358" runat="server" CssClass="t1" Width="43px"></asp:TextBox>358</td>
            <td style="width: 100px">
                <p class="MsoNormal" style="margin: 0in 0in 0pt; tab-stops: .25in">
                    <b><span style="font-size: 9pt; font-family: Arial; mso-bidi-font-size: 12.0pt">DBNTCO<o:p></o:p></span></b></p>
            </td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox434" runat="server" CssClass="t1" Width="43px"></asp:TextBox>434</td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
        </tr>  <tr style="font-size: 9pt">
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>DB 17T</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox354" runat="server" CssClass="t1" Width="43px"></asp:TextBox>354</td>
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>DB 21T</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox357" runat="server" CssClass="t1" Width="43px"></asp:TextBox>357</td>
            <td style="width: 100px">
                <p class="MsoNormal" style="margin: 0in 0in 0pt; tab-stops: .25in">
                    <b><span style="font-size: 9pt; font-family: Arial; mso-bidi-font-size: 12.0pt">TL 24T<o:p></o:p></span></b></p>
            </td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox435" runat="server" CssClass="t1" Width="43px"></asp:TextBox>435</td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr style="font-size: 9pt">
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>RHS F&lt;</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox355" runat="server" CssClass="t1" Width="43px"></asp:TextBox>35</td>
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>RHS R&lt;</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox356" runat="server" CssClass="t1" Width="43px"></asp:TextBox>356</td>
            <td style="width: 100px">
                <p class="MsoNormal" style="margin: 0in 0in 0pt; tab-stops: .25in">
                    <b><span style="font-size: 9pt; font-family: Arial; mso-bidi-font-size: 12.0pt">LD UNIT<o:p></o:p></span></b></p>
            </td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox436" runat="server" CssClass="t1" Width="43px"></asp:TextBox>436</td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr style="font-size: 9pt">
            <td colspan="5">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>RECORD THE
                        <?xml namespace="" ns="urn:schemas-microsoft-com:office:smarttags" prefix="st1" ?><st1:place w:st="on"><st1:City w:st="on">READINGS</st1:City></st1:place>
                        OF FOLLOWING</strong></span></td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr style="font-size: 9pt">
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                        mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                        mso-bidi-font-size: 12.0pt">
                        <st1:place w:st="on"><st1:City w:st="on"><strong>DVR READINGS</strong></st1:City></st1:place>
                    </span></span>
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>RADIATOR FAN # 1</strong></span></td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>RADIATOR FAN # 2</strong></span></td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr style="font-size: 9pt">
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>IDLE </strong></span>
            </td>
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>8TH</strong></span></td>
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>SLOW</strong></span></td>
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>FAST</strong></span></td>
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>SLOW</strong></span></td>
            <td style="width: 100px">
                <strong><span style="font-family: Arial">FAST</span></strong></td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr style="font-size: 9pt">
            <td style="width: 100px">
                <span style="font-size: 8pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>BCP</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox359" runat="server" CssClass="t1" Width="43px"></asp:TextBox>359</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox370" runat="server" CssClass="t1" Width="43px"></asp:TextBox>370</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox371" runat="server" CssClass="t1" Width="43px"></asp:TextBox>371</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox382" runat="server" CssClass="t1" Width="43px"></asp:TextBox>382</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox383" runat="server" CssClass="t1" Width="43px"></asp:TextBox>383</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox394" runat="server" CssClass="t1" Width="43px"></asp:TextBox>394</td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr style="font-size: 9pt">
            <td style="width: 100px">
                <span style="font-size: 8pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>BP</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox360" runat="server" CssClass="t1" Width="43px"></asp:TextBox>360</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox369" runat="server" CssClass="t1" Width="43px"></asp:TextBox>369</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox372" runat="server" CssClass="t1" Width="43px"></asp:TextBox>372</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox381" runat="server" CssClass="t1" Width="43px"></asp:TextBox>381</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox384" runat="server" CssClass="t1" Width="43px"></asp:TextBox>384</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox393" runat="server" CssClass="t1" Width="43px"></asp:TextBox>393</td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
        </tr>  <tr style="font-size: 9pt">
            <td style="width: 100px">
                <span style="font-size: 8pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><span style="font-size: 8pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                        mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                        mso-bidi-font-size: 12.0pt"><strong>AUX-C</strong></span></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox361" runat="server" CssClass="t1" Width="43px"></asp:TextBox>361</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox368" runat="server" CssClass="t1" Width="43px"></asp:TextBox>368</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox373" runat="server" CssClass="t1" Width="43px"></asp:TextBox>373</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox380" runat="server" CssClass="t1" Width="43px"></asp:TextBox>380</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox385" runat="server" CssClass="t1" Width="43px"></asp:TextBox>385</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox392" runat="server" CssClass="t1" Width="43px"></asp:TextBox>392</td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr style="font-size: 9pt">
            <td style="width: 100px">
                <span style="font-size: 8pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>Ph A-B</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox362" runat="server" CssClass="t1" Width="43px"></asp:TextBox>362</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox367" runat="server" CssClass="t1" Width="43px"></asp:TextBox>367</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox374" runat="server" CssClass="t1" Width="43px"></asp:TextBox>374</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox379" runat="server" CssClass="t1" Width="43px"></asp:TextBox>379</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox386" runat="server" CssClass="t1" Width="43px"></asp:TextBox>386</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox391" runat="server" CssClass="t1" Width="43px"></asp:TextBox>391</td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr style="font-size: 9pt">
            <td style="width: 100px">
                <span style="font-size: 8pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>Ph B-C</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox363" runat="server" CssClass="t1" Width="43px"></asp:TextBox>363</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox366" runat="server" CssClass="t1" Width="43px"></asp:TextBox>366</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox375" runat="server" CssClass="t1" Width="43px"></asp:TextBox>375</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox378" runat="server" CssClass="t1" Width="43px"></asp:TextBox>378</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox387" runat="server" CssClass="t1" Width="43px"></asp:TextBox>387</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox390" runat="server" CssClass="t1" Width="43px"></asp:TextBox>390</td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr style="font-size: 9pt">
            <td style="width: 100px">
                <span style="font-size: 8pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>Ph C-A</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox364" runat="server" CssClass="t1" Width="43px"></asp:TextBox>364</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox365" runat="server" CssClass="t1" Width="43px"></asp:TextBox>365</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox376" runat="server" CssClass="t1" Width="43px"></asp:TextBox>376</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox377" runat="server" CssClass="t1" Width="43px"></asp:TextBox>377</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox388" runat="server" CssClass="t1" Width="43px"></asp:TextBox>388</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox389" runat="server" CssClass="t1" Width="43px"></asp:TextBox>389</td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr style="font-size: 9pt">
            <td colspan="7">
                <p class="MsoNormal" style="margin: 0in 0in 0pt -9pt">
                    <b><span style="font-size: 9pt; font-family: Arial; mso-bidi-font-size: 12.0pt">TEST
                        MU TRAINLINE SIGNALS AND RECORD [YEARLY]<?xml namespace="" ns="urn:schemas-microsoft-com:office:office"
                            prefix="o" ?><o:p></o:p></span></b></p>
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr style="font-size: 9pt">
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
                <strong><span style="font-family: Arial">S/H</span></strong></td>
            <td style="width: 100px">
                <strong><span style="font-family: Arial">L/H</span></strong></td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
                <strong><span style="font-family: Arial">S/H</span></strong></td>
            <td style="width: 100px">
                <strong><span style="font-family: Arial">L/H</span></strong></td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
                <strong><span style="font-family: Arial">S/H</span></strong></td>
            <td style="width: 100px">
                <strong><span style="font-family: Arial">L/H</span></strong></td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr style="font-size: 9pt">
            <td style="width: 100px">
                <span style="font-size: 8pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>ALARM ‘ 2T’</strong></span></td>
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt">
                    <asp:TextBox ID="TextBox395" runat="server" CssClass="t1" Width="43px"></asp:TextBox>395</span></td>
            <td style="width: 100px">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt">
                    <asp:TextBox ID="TextBox396" runat="server" CssClass="t1" Width="43px"></asp:TextBox>396</span></td>
            <td style="width: 100px">
                <span style="font-size: 8pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>WHEEL SLIP ‘ 10T’</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox409" runat="server" CssClass="t1" Width="43px"></asp:TextBox>409</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox416" runat="server" CssClass="t1" Width="43px"></asp:TextBox>416</td>
            <td style="width: 100px">
                <span style="font-size: 8pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>BRAKE WARN ‘ 20T’</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox423" runat="server" CssClass="t1" Width="43px"></asp:TextBox>423</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox428" runat="server" CssClass="t1" Width="43px"></asp:TextBox>428</td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr style="font-size: 9pt">
            <td style="width: 100px">
                <span style="font-size: 8pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>D. VALVE ‘ 3T’</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox397" runat="server" CssClass="t1" Width="43px"></asp:TextBox>397</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox408" runat="server" CssClass="t1" Width="43px"></asp:TextBox>408</td>
            <td style="width: 100px">
                <span style="font-size: 8pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>B. VALVE ‘ 12T’</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox410" runat="server" CssClass="t1" Width="43px"></asp:TextBox>410</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox417" runat="server" CssClass="t1" Width="43px"></asp:TextBox>417</td>
            <td style="width: 100px">
                <span style="font-size: 8pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>DB EXCITE<span style="mso-spacerun: yes">&nbsp;
                    </span>‘21T’</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox424" runat="server" CssClass="t1" Width="43px"></asp:TextBox>424</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox429" runat="server" CssClass="t1" Width="43px"></asp:TextBox>429</td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
        </tr>  <tr style="font-size: 9pt">
            <td style="width: 100px">
                <span style="font-size: 8pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>NEG CONTROL ‘4T’</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox398" runat="server" CssClass="t1" Width="43px"></asp:TextBox>398</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox407" runat="server" CssClass="t1" Width="43px"></asp:TextBox>407</td>
            <td style="width: 100px">
                <span style="font-size: 8pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>POS CONTROL<span style="mso-spacerun: yes">&nbsp;
                    </span>‘13T’</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox411" runat="server" CssClass="t1" Width="43px"></asp:TextBox>411</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox418" runat="server" CssClass="t1" Width="43px"></asp:TextBox>418</td>
            <td style="width: 100px">
                <span style="font-size: 8pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>MAN SAND<span style="mso-spacerun: yes">&nbsp; </span>
                        ‘23T’ </strong></span>
            </td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox425" runat="server" CssClass="t1" Width="43px"></asp:TextBox>425</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox430" runat="server" CssClass="t1" Width="43px"></asp:TextBox>430</td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr style="font-size: 9pt">
            <td style="width: 100px">
                <span style="font-size: 8pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>GF REQ ‘ 6T’</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox399" runat="server" CssClass="t1" Width="43px"></asp:TextBox>399</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox406" runat="server" CssClass="t1" Width="43px"></asp:TextBox>406</td>
            <td style="width: 100px">
                <span style="font-size: 8pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>T.E. LIMIT ‘ 14T’</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox412" runat="server" CssClass="t1" Width="43px"></asp:TextBox>412</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox419" runat="server" CssClass="t1" Width="43px"></asp:TextBox>419</td>
            <td style="width: 100px">
                <span style="font-size: 8pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>DB REF ‘ 24T’</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox426" runat="server" CssClass="t1" Width="43px"></asp:TextBox>426</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox431" runat="server" CssClass="t1" Width="43px"></asp:TextBox>431</td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr style="font-size: 9pt">
            <td style="width: 100px">
                <span style="font-size: 8pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>C. VALVE<span style="mso-spacerun: yes">&nbsp; </span>
                        ‘7T’</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox400" runat="server" CssClass="t1" Width="43px"></asp:TextBox>400</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox405" runat="server" CssClass="t1" Width="43px"></asp:TextBox>405</td>
            <td style="width: 100px">
                <span style="font-size: 8pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>A. VALVE ‘ 15T’</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox413" runat="server" CssClass="t1" Width="43px"></asp:TextBox>413</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox420" runat="server" CssClass="t1" Width="43px"></asp:TextBox>420</td>
            <td style="width: 100px">
                <span style="font-size: 8pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>COMP SYNC<span style="mso-spacerun: yes">&nbsp;
                    </span>‘25T’</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox427" runat="server" CssClass="t1" Width="43px"></asp:TextBox>427</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox432" runat="server" CssClass="t1" Width="43px"></asp:TextBox>432</td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr style="font-size: 9pt">
            <td style="width: 100px">
                <span style="font-size: 8pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>DIRECTION FOR ‘ 8T’</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox401" runat="server" CssClass="t1" Width="43px"></asp:TextBox>401</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox404" runat="server" CssClass="t1" Width="43px"></asp:TextBox>404</td>
            <td style="width: 100px">
                <span style="font-size: 8pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>ENG RUN ‘ 16T’</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox414" runat="server" CssClass="t1" Width="43px"></asp:TextBox>414</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox421" runat="server" CssClass="t1" Width="43px"></asp:TextBox>421</td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr style="font-size: 9pt">
            <td style="width: 100px">
                <span style="mso-fareast-font-family: 'Times New Roman'; mso-ansi-language: EN-US;
                    mso-fareast-language: EN-US; mso-bidi-language: AR-SA"><span style="font-size: 8pt;
                        font-family: Arial; mso-fareast-font-family: 'Times New Roman'; mso-ansi-language: EN-US;
                        mso-fareast-language: EN-US; mso-bidi-language: AR-SA"><strong>DIRECTION FOR ‘ 9T’</strong></span></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox402" runat="server" CssClass="t1" Width="43px"></asp:TextBox>402</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox403" runat="server" CssClass="t1" Width="43px"></asp:TextBox>403</td>
            <td style="width: 100px">
                <span style="font-size: 8pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>DB SETUP ‘ 17T’</strong></span></td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox415" runat="server" CssClass="t1" Width="43px"></asp:TextBox>415</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox422" runat="server" CssClass="t1" Width="43px"></asp:TextBox>422</td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr style="font-size: 9pt">
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr style="font-size: 9pt">
            <td colspan="7">
                <span style="font-size: 9pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA;
                    mso-bidi-font-size: 12.0pt"><strong>CHECK &amp; ENSURE THE FOLLOWING ITEMS</strong></span></td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
        </tr>  <tr style="font-size: 9pt">
            <td colspan="11">
                &nbsp;<asp:GridView ID="gv2" runat="server" AutoGenerateColumns="False" Height="139px"
                    Width="705px">
                    <Columns>
                        <asp:TemplateField HeaderText="SNO.">
                            <ItemTemplate>
                                <%#Container.DataItemIndex +1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="sub_head_details" HeaderText="detail" />
                        <asp:TemplateField HeaderText="status">
                            <ItemTemplate>
                                <asp:TextBox ID="txt1" runat="server" CssClass="t1"></asp:TextBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="action_taken">
                            <ItemTemplate>
                                <asp:TextBox ID="txt2" runat="server" CssClass="t1"></asp:TextBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr style="font-size: 9pt">
            <td align="center" colspan="11">
                <asp:Button ID="btnInsert" runat="server" CssClass="t1" OnClick="btnInsert_Click"
                    Text="INSERT" /></td>
        </tr>
    </table>
</asp:Content>
