<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Counter.aspx.cs" Inherits="WebApplication1.Counter" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Time Schedule</title>
    <style type="text/css">
        .style3
        { background-color:#EFEFEF;
            text-align: center;
        }
        .style4
        {
            background-color: #EFEFEF;
            text-align: right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" align="center">
    <table  align="center" width="750px">
        <tr>
            <td style="width:375px;">
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
            </td>
            <td style="width:375px; ">
                <asp:UpdatePanel ID="UpdatePanel10" runat="server">
                    <ContentTemplate>
                        <asp:TextBox ID="TextBox5" runat="server" Enabled="False" style="width:33%;" 
                            Visible="False" Width="100%" BackColor="White" ForeColor="Black"></asp:TextBox>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td class="style4">
                <asp:Label ID="Label14" runat="server" BackColor="White" 
                    style="text-align: left" Text="Bus_License_no" Width="200px"></asp:Label>
            </td>
            <td class="style3" style="text-align: left">
                <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                    <ContentTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Enabled="False" Width="200px" 
                            BackColor="White" ForeColor="Black"></asp:TextBox>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
        </tr>
        <tr>
             <td class="style4" >
                 <asp:Label ID="Label15" runat="server" BackColor="White" 
                     style="text-align: left" Text="Bus_Stop_point" Width="200px"></asp:Label>
             </td>
              <td class="style3" style="text-align: left" >
                  <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                      <ContentTemplate>
                          <asp:TextBox ID="TextBox2" runat="server" Enabled="False" Width="200px" 
                              BackColor="White" ForeColor="Black"></asp:TextBox>
                      </ContentTemplate>
                  </asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td class="style4">
                <asp:Label ID="Label16" runat="server" BackColor="White" 
                    style="text-align: left" Text="Stop_time" Width="200px"></asp:Label>
            </td>
            <td class="style3" style="text-align: left">
                <asp:UpdatePanel ID="UpdatePanel6" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                        <asp:TextBox ID="TextBox6" runat="server" TabIndex="2" TextMode="Number" 
                            Width="59px" BackColor="White" ForeColor="Black"></asp:TextBox>
                        &nbsp;<asp:TextBox ID="TextBox7" runat="server" TabIndex="2" TextMode="Number" 
                            Width="59px" BackColor="White" ForeColor="Black"></asp:TextBox>
                        &nbsp;<asp:DropDownList ID="DropDownList1" runat="server" Width="59px" 
                            BackColor="White" ForeColor="Black">
                            <asp:ListItem>AM</asp:ListItem>
                            <asp:ListItem>PM</asp:ListItem>
                        </asp:DropDownList>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td class="style4">
                <asp:Label ID="Label17" runat="server" BackColor="White" 
                    style="text-align: left" Text="Stuff_id" Width="200px"></asp:Label>
            </td>
            <td class="style3" style="text-align: left">
                <asp:UpdatePanel ID="UpdatePanel7" runat="server">
                    <ContentTemplate>
                        <asp:TextBox ID="TextBox4" runat="server" Enabled="False" Width="200px" 
                            BackColor="White" ForeColor="Black"></asp:TextBox>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td class="style3" colspan="2">
                <asp:UpdatePanel ID="UpdatePanel18" runat="server">
                    <ContentTemplate>
                        <asp:TextBox ID="TextBox34" runat="server" BorderColor="Red" 
                            BorderStyle="Solid" ForeColor="Red" style="text-align: center" Visible="False" 
                            Width="161px" BackColor="White" Enabled="False">Time schedule missmatch</asp:TextBox>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td class="style3" colspan="2">
                <asp:UpdatePanel ID="UpdatePanel8" runat="server">
                    <ContentTemplate>
                        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Save" Visible="False" Width="200px" />
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td class="style3" colspan="2">
                <asp:UpdatePanel ID="UpdatePanel9" runat="server">
                    <ContentTemplate>
                        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Back" Width="200px" />
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td style="text-align: center; font-family: 'times New Roman', Times, serif; font-size: 18px; font-weight: bold;" 
                colspan="2">
                All Bus Information</td>
        </tr>
        <tr>
            <td style="text-align: center" class="style3" colspan="2">
                <asp:UpdatePanel ID="UpdatePanel15" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                        <asp:Label ID="Label18" runat="server" BackColor="White" 
                            style="text-align: left" Text="Bus_License_no" Width="100px"></asp:Label>
                        &nbsp;<asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
                        &nbsp;<asp:Button ID="Button3" runat="server" onclick="Button3_Click" Text="Search" />
                        &nbsp;<asp:Button ID="Button5" runat="server" onclick="Button5_Click" Text="View All" />
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td style="text-align: center" colspan="2">
     
     <div style="  border: 10px solid #EFEFEF; margin: auto; height:270px; width:750px; overflow:auto; vertical-align: top; text-align: left; ">
         <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
             <ContentTemplate>
              <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
                                    <ItemTemplate>
                                        <div style="margin: 5px 5px 5px 25px; float: left">
                                            <table align="center"  style=" width:330px; ">
                                                <tr>
                                                    <td colspan="2" style=" text-align:center">
                                                        <asp:Button ID="Button16" runat="server" CausesValidation="True" CommandName="5" Text="Select" UseSubmitBehavior="False" Width="100%" />
                                                    </td>
                                                </tr>
                                                
                                                <tr>
                                                    <td class="style3" style="text-align:left">SN</td>
                                                    <td class="style3" style=" text-align:left;"><%#Eval("s_no")%></td>
                                                </tr>
                                                 <tr>
                                                    <td class="style3" style=" text-align:left;width:110px">Bus License No</td>
                                                    <td class="style3" style=" text-align:left;width:220px">
                                                        <asp:TextBox ID="TextBox16" runat="server" Enabled="False" Text='<%#Eval("Bus_license_no") %>' BorderStyle="None" BackColor="#EFEFEF" ForeColor="Black"></asp:TextBox>
                                                    </td>
                                                </tr>
                                               <tr>
                                                    <td class="style3" style=" text-align:left;width:110px">Stop Point ID</td>
                                                    <td class="style3" style=" text-align:left;width:220px">
                                                        <asp:TextBox ID="TextBox15" runat="server" Enabled="False" Text='<%#Eval("Bus_Stop_point") %>' BorderStyle="None" BackColor="#EFEFEF" ForeColor="Black"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="style3"  style=" text-align:left;">KM</td>
                                                    <td class="style3" style=" text-align:left;" ><%#Eval("KM")%></td>
                                                </tr>
                                                <tr>
                                                    <td class="style3" style=" text-align:left;">Location</td>
                                                    <td class="style3" style=" text-align:left;"><%#Eval("Location")%></td>
                                                </tr>
                                                 <tr>
                                                    <td class="style3" style=" text-align:left;">Road No</td>
                                                    <td class="style3" style=" text-align:left;"><%#Eval("Road_no")%></td>
                                                </tr>
                                                 <tr>
                                                    <td class="style3" style=" text-align:left;">Road Name</td>
                                                    <td class="style3" style=" text-align:left;"><%#Eval("Road_name")%></td>
                                                </tr>
                                                 <tr>
                                                    <td class="style3" style=" text-align:left;">Approved By</td>
                                                    <td class="style3" style=" text-align:left;"><%#Eval("Approved_by")%></td>
                                                </tr>
                                            </table>
                                        </div>
                                    </ItemTemplate>
                                </asp:Repeater></ContentTemplate>
         </asp:UpdatePanel>
    </div>
            </td>
        </tr>
        <tr>
            <td style="text-align: center" colspan="2">
         <asp:Label ID="Label13" runat="server" Font-Bold="True" 
             style="text-align: center" Text="All Time Schedule"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="text-align: center" class="style3" colspan="2">
                <asp:UpdatePanel ID="UpdatePanel17" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                        <asp:Label ID="Label19" runat="server" BackColor="White" 
                            style="text-align: left" Text="Bus_Stop_point" Width="100px"></asp:Label>
                        &nbsp;<asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
                        <asp:Button ID="Button7" runat="server" onclick="Button7_Click" Text="Search" />
                        <asp:Button ID="Button8" runat="server" onclick="Button8_Click" Text="View all" />
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td style="text-align: center" colspan="2">
     
     <div style="  border: 10px solid #EFEFEF; margin: auto; height:300px; width:750px; overflow:auto; vertical-align: top; text-align: left; ">
                    
         <asp:UpdatePanel ID="UpdatePanel5" runat="server" UpdateMode="Conditional">
             <ContentTemplate>
                 <asp:Repeater ID="Repeater2" runat="server" OnItemCommand="Repeater2_ItemCommand">
                     <ItemTemplate>
                         <div style="margin: 5px 5px 5px 25px; float: left">
                             <table align="center" style=" width:330px">
                                 <tr>
                                     <td colspan="2" style=" text-align:center">
                                         <asp:Button ID="Button17" runat="server" CausesValidation="True" CommandName="5" Text="Delete" UseSubmitBehavior="False" Width="100%" />
                                     </td>
                                 </tr>
                               
                                 <tr>
                                     <td style=" width:110px; background-color:#EFEFEF">Bus License No</td>
                                     <td style=" width:220px;background-color:#EFEFEF"">
                                         <asp:TextBox ID="TextBox20" runat="server" Enabled="False" Text='<%#Eval("Bus_license_no") %>' ForeColor="Black" BackColor="#EFEFEF" BorderStyle="None"></asp:TextBox>
                                     </td>
                                 </tr>
                                 <tr>
                                     <td style=" width:110px;background-color:#EFEFEF"">Stop Point</td>
                                     <td style=" width:220px;background-color:#EFEFEF"">
                                         <asp:TextBox ID="TextBox21" runat="server" Enabled="False" Text='<%#Eval("Bus_Stop_point") %>' ForeColor="Black" BackColor="#EFEFEF" BorderStyle="None"></asp:TextBox>
                                     </td>
                                 </tr>
                                   <tr>
                                     <td style=" width:110px;background-color:#EFEFEF"">Stop Time</td>
                                     <td style=" width:220px;background-color:#EFEFEF"">
                                         <asp:TextBox ID="TextBox22" runat="server" Enabled="False" Text='<%#Eval("Stop_time") %>' ForeColor="Black" BackColor="#EFEFEF" BorderStyle="None"></asp:TextBox>
                                     </td>
                                 </tr>
                                   <tr>
                                     <td style=" width:110px;background-color:#EFEFEF"">TT</td>
                                     <td style=" width:220px;background-color:#EFEFEF"">
                                         <asp:TextBox ID="TextBox23" runat="server" Enabled="False" Text='<%#Eval("AM_or_PM") %>' ForeColor="Black" BackColor="#EFEFEF" BorderStyle="None"></asp:TextBox>
                                     </td>
                                 </tr>
                                   <tr>
                                     <td style=" width:110px;background-color:#EFEFEF"">Stuff_id</td>
                                     <td style=" width:220px;background-color:#EFEFEF"">
                                         <asp:TextBox ID="TextBox24" runat="server" Enabled="False" Text='<%#Eval("Stuff_id") %>' ForeColor="Black" BackColor="#EFEFEF" BorderStyle="None"></asp:TextBox>
                                     </td>
                                 </tr>
                             
                             </table>
                         </div>
                     </ItemTemplate>
                 </asp:Repeater>
             </ContentTemplate>
         </asp:UpdatePanel>
    </div>
            </td>
        </tr>
        <tr>
            <td style="text-align: center; font-family: 'times New Roman', Times, serif; font-size: 18px; font-weight: bold;" 
                colspan="2">
                All Stuff</td>
        </tr>
        <tr>
            <td style="text-align: center" class="style3" colspan="2">
                <asp:UpdatePanel ID="UpdatePanel16" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                        <asp:Label ID="Label20" runat="server" BackColor="White" 
                            style="text-align: left" Text="Stuff ID"></asp:Label>
                        &nbsp;<asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
                        &nbsp;<asp:Button ID="Button4" runat="server" onclick="Button4_Click" Text="Search" />
                        &nbsp;<asp:Button ID="Button6" runat="server" onclick="Button6_Click" Text="View all" />
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td style="text-align: center" class="style3" colspan="2">
                <asp:UpdatePanel ID="UpdatePanel14" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                        <asp:Label ID="Label21" runat="server" BackColor="White" 
                            style="text-align: left" Text="Date"></asp:Label>
                        &nbsp;<asp:TextBox ID="TextBox17" runat="server" Width="95px"></asp:TextBox>
                        <asp:Label ID="Label22" runat="server" BackColor="White" 
                            style="text-align: left" Text="Total TK"></asp:Label>
                        &nbsp;<asp:TextBox ID="TextBox19" runat="server"></asp:TextBox>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td style="text-align: center" colspan="2">
     
     <div style="  border: 10px solid #EFEFEF; margin: auto; height:490px; width:750px; overflow:auto; vertical-align: top; text-align: left; ">
         <asp:UpdatePanel ID="UpdatePanel4" runat="server" UpdateMode="Conditional">
             <ContentTemplate>
                 <asp:Repeater ID="Repeater3" runat="server" OnItemCommand="Repeater3_ItemCommand">
                     <ItemTemplate>
                         <div style="margin: 5px 5px 5px 16px; float: left">
                             <table align="center" style=" width:340px">
                                  <tr>
                                     <td style=" text-align:center" colspan="2"> <asp:Image ID="Image1" runat="server" ImageUrl='<%#Eval("picture") %>' Height="150" Width="150" BorderStyle="None" /></td>
                                    
                                        
                                     </td>
                                 </tr>
                                 <tr>
                                     <td colspan="2" style=" text-align:center">
                                         <asp:Button ID="Button18" runat="server" CausesValidation="True" CommandName="5" Text="Select" UseSubmitBehavior="False" Width="100%" />
                                     </td>
                                 </tr>
                                 <tr>
                                     <td style=" width:160px;background-color:#EFEFEF">Stuff ID</td>
                                     <td style=" width:180px;background-color:#EFEFEF">
                                         <asp:TextBox ID="TextBox25" runat="server" Enabled="False" Text='<%#Eval("Stuff_id") %>' ForeColor="Black" BackColor="#EFEFEF" BorderStyle="None"></asp:TextBox>
                                     </td>
                                 </tr>
                                 <tr>
                                     <td style=";background-color:#EFEFEF ">Contact Number</td>
                                     <td style=";background-color:#EFEFEF ">
                                         <asp:TextBox ID="TextBox26" runat="server" Enabled="False" Text='<%#Eval("Contact_number") %>' ForeColor="Black" BackColor="#EFEFEF" BorderStyle="None"></asp:TextBox>
                                     </td>
                                 </tr>
                                 <tr>
                                     <td style=" ;background-color:#EFEFEF">Email</td>
                                     <td style=";background-color:#EFEFEF">
                                         <asp:TextBox ID="TextBox27" runat="server" Enabled="False" Text='<%#Eval("Email_id") %>' ForeColor="Black" BackColor="#EFEFEF" BorderStyle="None"></asp:TextBox>
                                     </td>
                                 </tr>
                                 <tr>
                                     <td style=";background-color:#EFEFEF ">Current address</td>
                                     <td style=";background-color:#EFEFEF ">
                                         <asp:TextBox ID="TextBox28" runat="server" Enabled="False" Text='<%#Eval("Current_address") %>' ForeColor="Black" BackColor="#EFEFEF" BorderStyle="None"></asp:TextBox>
                                     </td>
                                 </tr>
                                 <tr>
                                     <td style=";background-color:#EFEFEF ">Emargency Contact No</td>
                                     <td style=";background-color:#EFEFEF ">
                                         <asp:TextBox ID="TextBox29" runat="server" Enabled="False" Text='<%#Eval("Emargency_contact_No") %>' ForeColor="Black" BackColor="#EFEFEF" BorderStyle="None"></asp:TextBox>
                                     </td>
                                 </tr>
                                  <tr>
                                     <td style=";background-color:#EFEFEF ">Permanent address</td>
                                     <td style=";background-color:#EFEFEF ">
                                         <asp:TextBox ID="TextBox30" runat="server" Enabled="False" Text='<%#Eval("Permanent_address") %>' ForeColor="Black" BackColor="#EFEFEF" BorderStyle="None"></asp:TextBox>
                                     </td>
                                 </tr>
                                
                                 <tr>
                                     <td style=";background-color:#EFEFEF ">Register Date</td>
                                     <td style=";background-color:#EFEFEF ">
                                         <asp:TextBox ID="TextBox33" runat="server" Enabled="False" Text='<%#Eval("Register_date") %>' ForeColor="Black" BackColor="#EFEFEF" BorderStyle="None"></asp:TextBox>
                                     </td>
                                 </tr>
                             </table>
                         </div>
                     </ItemTemplate>
                 </asp:Repeater>
             </ContentTemplate>
         </asp:UpdatePanel>
    </div>
            </td>
        </tr>
        <tr>
            <td style="text-align: center">
                <asp:UpdatePanel ID="UpdatePanel12" runat="server">
                    <ContentTemplate>
                        <asp:TextBox ID="TextBox3" runat="server" TextMode="DateTime" Visible="False"></asp:TextBox>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
            <td style="text-align: center">
                <asp:UpdatePanel ID="UpdatePanel13" runat="server">
                    <ContentTemplate>
                        <asp:TextBox ID="TextBox9" runat="server" Visible="False"></asp:TextBox>
                        <asp:TextBox ID="TextBox10" runat="server" Visible="False"></asp:TextBox>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td style="text-align: center">
                <asp:UpdatePanel ID="UpdatePanel11" runat="server">
                    <ContentTemplate>
                        <asp:TextBox ID="TextBox8" runat="server" MaxLength="2" Visible="False" Width="30%"></asp:TextBox>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
            <td style="text-align: center">
                <asp:UpdatePanel ID="UpdatePanel19" runat="server">
                    <ContentTemplate>
                        <asp:Timer ID="Timer1" runat="server" Interval="5000" ontick="Timer1_Tick1">
                        </asp:Timer>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
        </tr>
        </table>
    </form>
</body>
</html>
