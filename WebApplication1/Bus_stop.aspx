<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bus_stop.aspx.cs" Inherits="WebApplication1.Bus_stop" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Bus Stop Point</title>
    <style type="text/css">
        .style3
        { background-color:#EFEFEF;
            text-align: right;
        }
        .style4
        {
            text-align: left;
        }
        </style>
    </head>
<body>
    <form id="form1" runat="server">
      <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
    <table style="" align="center" >
        <tr>
            <td style=" text-align: center; font-family: 'times New Roman', Times, serif; font-size: 18px; font-weight: bold;" 
                colspan="2" >
                Insert Bus Stop</td>
        </tr>
        <tr>
            <td class="style3" style=" width:357px" >
                <asp:Label ID="Label21" runat="server" BackColor="White" 
                    style="text-align: left" Text="Location" Width="133px"></asp:Label>
            </td>
            <td style="text-align: left; width:357px" class="style3" >
                <asp:TextBox ID="TextBox3" runat="server" BackColor="White" ForeColor="Black" 
                    Width="128px"></asp:TextBox>
                 </td>
        </tr>
        <tr>
            <td class="style3" >
                <asp:Label ID="Label22" runat="server" BackColor="White" 
                    style="text-align: left" Text="Road No" Width="133px"></asp:Label>
            </td>
            <td style="text-align: left;  " class="style3" >
                <asp:TextBox ID="TextBox4" runat="server" BackColor="White" ForeColor="Black" 
                    Width="128px"></asp:TextBox>
                 </td>
        </tr>
        <tr>
            <td class="style3" >
                <asp:Label ID="Label23" runat="server" BackColor="White" 
                    style="text-align: left" Text="Road Name" Width="133px"></asp:Label>
            </td>
            <td style="text-align: left; " class="style3" >
                <asp:TextBox ID="TextBox5" runat="server" BackColor="White" ForeColor="Black" 
                    Width="128px"></asp:TextBox>
                 </td>
        </tr>
        <tr>
            <td class="style3" >
                <asp:Label ID="Label24" runat="server" BackColor="White" 
                    style="text-align: left" Text="My ID" Width="133px"></asp:Label>
            </td>
            <td style="text-align: left;  " class="style3" >
                <asp:TextBox ID="TextBox6" runat="server" Enabled="False" BackColor="White" 
                    ForeColor="Black" Width="128px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: center;" class="style3" >
                <asp:Button ID="Button1" runat="server" Enabled="False" onclick="Button1_Click" 
                    Text="Save" Width="270px" />
            </td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: center;" class="style3" >
                <asp:Button ID="Button9" runat="server" Enabled="False" onclick="Button9_Click" 
                    Text="Back" Width="270px" />
            </td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: center;" class="style3" >
                <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
                    Text="Delete all Request" Width="270px" Visible="False" />
            </td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: center;" class="style3" >
                <asp:Button ID="Button6" runat="server" onclick="Button6_Click" 
                    Text="Load" Width="270px" Visible="False" />
                </td>
        </tr>
      
        <tr>
            <td colspan="2" style="text-align: center;" class="" >
                <asp:Panel ID="Panel6" runat="server" Visible="False">
                    <table  align="center" style="width:100%;">
                        <tr>
                            <td colspan="2">
                                <strong>Update GPS location for Bus stop point</strong></td>
                        </tr>
                        <tr>
                            <td style="text-align: right; background-color: #EFEFEF; width:50%">
                                <asp:Label ID="Label38" runat="server" Text="Bus Stop ID" BackColor="White" 
                                    Width="133px"></asp:Label>
                            </td>
                            <td style="background-color: #EFEFEF; text-align: left;">
                                <asp:TextBox ID="TextBox33" runat="server" style="text-align: left" 
                                    Width="128px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align: right; background-color: #EFEFEF;">
                                <asp:Label ID="Label39" runat="server" Text="Latitude-1" BackColor="White" 
                                    Width="133px"></asp:Label>
                            </td>
                            <td style="text-align: left; background-color: #EFEFEF;">
                                <asp:TextBox ID="TextBox34" runat="server" TextMode="Number" step="any" Width="128px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align: right; background-color: #EFEFEF;">
                                <asp:Label ID="Label40" runat="server" Text="Latitude-2" BackColor="White" 
                                    Width="133px"></asp:Label>
                            </td>
                            <td style="text-align: left; background-color: #EFEFEF;">
                                <asp:TextBox ID="TextBox35" runat="server" TextMode="Number" step="any"  Width="128px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align: right; background-color: #EFEFEF;">
                                <asp:Label ID="Label41" runat="server" Text="Longitude-1" BackColor="White" 
                                    Width="133px"></asp:Label>
                            </td>
                            <td style="text-align: left; background-color: #EFEFEF;">
                                <asp:TextBox ID="TextBox36" runat="server" TextMode="Number" step="any"  Width="128px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align: right; background-color: #EFEFEF;">
                                <asp:Label ID="Label42" runat="server" Text="Longitude-2" BackColor="White" 
                                    Width="133px"></asp:Label>
                            </td>
                            <td style="text-align: left; background-color: #EFEFEF;">
                                <asp:TextBox ID="TextBox37" runat="server" TextMode="Number"  step="any" Width="128px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" style="background-color: #EFEFEF;">
                                <asp:Button ID="Button23" runat="server" Text="Update" Width="270px" 
                                    onclick="Button23_Click" />
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
                </td>
        </tr>
      
        <tr>
            <td colspan="2" 
                style="text-align: center; font-family: 'times New Roman', Times, serif; font-size: 18px; font-weight: bold;" >

              
                All Bus Stop</td>
        </tr>
      
        <tr>
            <td style="text-align: center; background-color: #EFEFEF;" colspan="2" 
                class="style3" >

                 <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
                     <ContentTemplate>
                         <asp:Label ID="Label25" runat="server" BackColor="White" 
                             style="text-align: left" Text="Road No" Width="60px"></asp:Label>
                         <asp:TextBox ID="TextBox20" runat="server"></asp:TextBox>
                         <asp:Button ID="Button17" runat="server" OnClick="Button17_Click" Text="Search" />
                         <asp:Label ID="Label26" runat="server" BackColor="White" 
                             style="text-align: left" Text="Location" Width="60px"></asp:Label>
                         <asp:TextBox ID="TextBox23" runat="server"></asp:TextBox>
                         <asp:Button ID="Button18" runat="server" OnClick="Button18_Click" Text="Search" />
                         &nbsp;<asp:Button ID="Button19" runat="server" OnClick="Button19_Click" Text="View All" />
                     </ContentTemplate>
                 </asp:UpdatePanel>
            </td>
        </tr>
      
        <tr>
            <td style="text-align: right; " colspan="2" >

                    <div style="  border: 10px solid #EFEFEF; margin: auto; height:320px; width:714px; overflow:auto; vertical-align: top; text-align: left; ">
                      <asp:UpdatePanel ID="UpdatePanel3" runat="server" UpdateMode="Conditional">
                            <ContentTemplate>
                                <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
                                    <ItemTemplate>
                                        <div style="margin: 5px; float: left">
                                            <table align="center"  style=" width:337px">
                                                <tr>
                                                    <td colspan="2" style=" text-align:center">
                                                        <asp:Button ID="Button16" runat="server" CausesValidation="True" CommandName="5" Text="Select" UseSubmitBehavior="False" Width="100%" />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style=" background-color:#EFEFEF;width:102px">Stop Office ID</td>
                                                    <td style=" background-color:#EFEFEF;width:235px">
                                                        <asp:TextBox ID="TextBox19" runat="server" Enabled="False" Text='<%#Eval("Bus_Stop_point") %>' BackColor="#EFEFEF" ForeColor="Black" BorderStyle="None"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="background-color:#EFEFEF">Location</td>
                                                    <td style="background-color:#EFEFEF"><%#Eval("Location")%></td>
                                                </tr>
                                                <tr>
                                                    <td style="background-color:#EFEFEF">Road No</td>
                                                    <td style="background-color:#EFEFEF"><%#Eval("Road_no")%></td>
                                                </tr>
                                                <tr>
                                                    <td style="background-color:#EFEFEF">Road Name</td>
                                                    <td style="background-color:#EFEFEF"><%#Eval("Road_name")%></td>
                                                </tr>
                                                <tr>
                                                    <td style="background-color:#EFEFEF">Approved By</td>
                                                    <td style="background-color:#EFEFEF"><%#Eval("Approved_by")%></td>
                                                </tr>
                                                <tr>
                                                    <td style="background-color:#EFEFEF">Date</td>
                                                    <td style="background-color:#EFEFEF"><%#Eval("Date")%></td>
                                                </tr>
                                                  <tr>
                                                    <td style="background-color:#EFEFEF">latitude-1</td>
                                                    <td style="background-color:#EFEFEF"><%#Eval("l1")%></td>
                                                </tr>
                                                  <tr>
                                                    <td style="background-color:#EFEFEF">latitude-2</td>
                                                    <td style="background-color:#EFEFEF"><%#Eval("l2")%></td>
                                                </tr>
                                                  <tr>
                                                    <td style="background-color:#EFEFEF">longitude-1</td>
                                                    <td style="background-color:#EFEFEF"><%#Eval("l3")%></td>
                                                </tr>
                                                  <tr>
                                                    <td style="background-color:#EFEFEF">longitude-2</td>
                                                    <td style="background-color:#EFEFEF"><%#Eval("l4")%></td>
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
            <td colspan="2" 
                style="text-align: center; font-family: 'times New Roman', Times, serif; font-size: 18px; font-weight: bold;" >

              
                <asp:Label ID="Label37" runat="server" Text="Insert Bus's Data" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="text-align: right; " colspan="2" >

                 <asp:Panel ID="Panel1" runat="server">
               
                <div style="  border: 10px solid #EFEFEF; margin: auto; height:135px; width:714px; overflow:auto; vertical-align: top; text-align: center; ">
                  
                  
                   
                    <table style="width:100%;" align="center">
                        <tr>
                            <td style="text-align: right" class="style3">
                                <asp:Label ID="Label27" runat="server" BackColor="White" 
                                    style="text-align: left" Text="Bus License No" Width="133px"></asp:Label>
                            </td>
                            <td style="text-align: left" class="style3">
                                <asp:TextBox ID="TextBox9" runat="server" Width="128px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align: right" class="style3">
                                <asp:Label ID="Label28" runat="server" BackColor="White" 
                                    style="text-align: left" Text="Bus Stop Point" Width="133px"></asp:Label>
                            </td>
                            <td style="text-align: left" class="style3">
                                <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                                    <ContentTemplate>
                                        <asp:TextBox ID="TextBox10" runat="server" Width="128px"></asp:TextBox>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align: right" class="style3">
                                <asp:Label ID="Label29" runat="server" BackColor="White" 
                                    style="text-align: left" Text="SL" Width="133px"></asp:Label>
                            </td>
                            <td style="text-align: left" class="style3">
                                <asp:TextBox ID="TextBox11" runat="server" TextMode="Number" Width="128px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align: right" class="style3">
                                <asp:Label ID="Label30" runat="server" BackColor="White" 
                                    style="text-align: left" Text="KM" Width="133px"></asp:Label>
                            </td>
                            <td style="text-align: left" class="style3">

                                <asp:TextBox ID="TextBox12" runat="server" TextMode="Number" Width="128px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style3" style="text-align: center" colspan="2">
                                <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                                    <ContentTemplate>
                                        <asp:Button ID="Button3" runat="server" onclick="Button3_Click" Text="Save" 
                                            Width="270px" />
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </td>
                        </tr>
                    </table>
                  
                  
                   
                </div>
                </asp:Panel></td>
        </tr>
      
        <tr>
            <td style="text-align: right; " colspan="2" >
                <asp:Panel ID="Panel3" runat="server" style="text-align: center">
                    <asp:Label ID="Label15" runat="server" Font-Bold="True" 
                            style="text-align: center" Text="View Data" Visible="False"></asp:Label>
                </asp:Panel>
            </td>
        </tr>
      
        <tr>
            <td style="text-align: right; " colspan="2" >
                <asp:Panel ID="Panel4" runat="server" Visible="False">
                    <div style="  border-left: 10px solid #EFEFEF; border-top: 10px solid #EFEFEF; border-bottom: 10px solid #EFEFEF; height:242px; width:357px; overflow:auto; float: left; vertical-align: top; text-align: left; border-right-width: 0px;">
                        
                        <asp:UpdatePanel ID="UpdatePanel7" runat="server" UpdateMode="Conditional">
                            <ContentTemplate>
                                <asp:Repeater ID="Repeater2" runat="server" OnItemCommand="Repeater2_ItemCommand">
                                    <ItemTemplate>
                                        <div style="margin: 5px; float: left">
                                            <table align="center" border="1" style=" width:330px">
                                                <tr>
                                                    <td colspan="2" style=" text-align:center">
                                                        <asp:Button ID="Button20" runat="server" CausesValidation="True" CommandName="5" Text="Select" UseSubmitBehavior="False" Width="100%" />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style=" background-color:#EFEFEF ;width:110px">Add/Update By</td>
                                                    <td style=" background-color:#EFEFEF ;width:220px">
                                                        <asp:TextBox ID="TextBox24" runat="server" Enabled="False" Text='<%#Eval("Stuff_id") %>' Width="96%" BorderStyle="None" ForeColor="Black" BackColor="#EFEFEF"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                 <tr>
                                                    <td style="background-color:#EFEFEF ; width:100px">Bus License</td>
                                                    <td style="background-color:#EFEFEF ; width:230px">
                                                        <asp:TextBox ID="TextBox13" runat="server" Enabled="False" Text='<%#Eval("Bus_License_no") %>' Width="96%" BorderStyle="None" ForeColor="Black" BackColor="#EFEFEF"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                 <tr>
                                                    <td style=" background-color:#EFEFEF ;width:100px">Stop Office ID</td>
                                                    <td style="background-color:#EFEFEF ; width:230px">
                                                        <asp:TextBox ID="TextBox25" runat="server" Enabled="False" Text='<%#Eval("Bus_Stop_point") %>' Width="96%" BorderStyle="None" ForeColor="Black" BackColor="#EFEFEF"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                 <tr>
                                                    <td style="background-color:#EFEFEF ; width:100px">SL</td>
                                                    <td style="background-color:#EFEFEF ; width:230px">
                                                        <asp:TextBox ID="TextBox26" runat="server" Enabled="False" Text='<%#Eval("s_no") %>' Width="96%" BorderStyle="None" ForeColor="Black" BackColor="#EFEFEF"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                 <tr>
                                                    <td style=" background-color:#EFEFEF ;width:100px">KM</td>
                                                    <td style="background-color:#EFEFEF ; width:230px">
                                                        <asp:TextBox ID="TextBox27" runat="server" Enabled="False" Text='<%#Eval("KM") %>' Width="96%" BorderStyle="None" ForeColor="Black" BackColor="#EFEFEF"></asp:TextBox>
                                                    </td>
                                                </tr>
                                               
                                                
                                            </table>
                                        </div>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                        <br />
                        <br />
                    </div>
                </asp:Panel>
                 <asp:Panel ID="Panel5" runat="server" Visible="False">
                    <div style="  border-width: 10px 10px 10px 0px; height:242px; width:357px; overflow:auto; float: right; vertical-align: top; text-align: center; border-top-color: #EFEFEF; border-right-color: #EFEFEF; border-bottom-color: #EFEFEF; border-top-style: solid; border-right-style: solid; border-bottom-style: solid;">
                        <table style="width:100%;" align="center">
                            <tr>
                                <td style="width:50%; text-align: right;" class="style3">
                                    &nbsp;</td>
                                <td style="width:50%; text-align: left;" class="style3">
                                    <asp:UpdatePanel ID="UpdatePanel10" runat="server">
                                        <ContentTemplate>
                                            <asp:TextBox ID="TextBox18" runat="server" Visible="False"></asp:TextBox>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align: right" class="style3">
                                    <asp:Label ID="Label31" runat="server" BackColor="White" 
                                        style="text-align: left" Text="Bus License No" Width="133px"></asp:Label>
                                </td>
                                <td style="text-align: left" class="style3">
                                    <asp:UpdatePanel ID="UpdatePanel11" runat="server" UpdateMode="Conditional">
                                        <ContentTemplate>
                                            <asp:TextBox ID="TextBox14" runat="server" Width="128px"></asp:TextBox>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align: right" class="style3">
                                    <asp:Label ID="Label32" runat="server" BackColor="White" 
                                        style="text-align: left" Text="Bus Stop Point" Width="133px"></asp:Label>
                                </td>
                                <td style="text-align: left" class="style3">
                                    <asp:UpdatePanel ID="UpdatePanel12" runat="server" UpdateMode="Conditional">
                                        <ContentTemplate>
                                            <asp:TextBox ID="TextBox15" runat="server" Enabled="False" Width="128px" 
                                                BackColor="White" ForeColor="Black"></asp:TextBox>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align: right" class="style3">
                                    <asp:Label ID="Label33" runat="server" Text="SL" Width="133px" 
                                        BackColor="White" style="text-align: left"></asp:Label>
                                </td>
                                <td style="text-align: left" class="style3">
                                    <asp:UpdatePanel ID="UpdatePanel13" runat="server" UpdateMode="Conditional">
                                        <ContentTemplate>
                                            <asp:TextBox ID="TextBox16" runat="server" TextMode="Number" Width="128px"></asp:TextBox>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align: right" class="style3">
                                    <asp:Label ID="Label34" runat="server" Text="KM" Width="133px" 
                                        BackColor="White" style="text-align: left"></asp:Label>
                                </td>
                                <td style="text-align: left" class="style3">
                                    <asp:UpdatePanel ID="UpdatePanel14" runat="server" UpdateMode="Conditional">
                                        <ContentTemplate>
                                            <asp:TextBox ID="TextBox17" runat="server" TextMode="Number" Width="128px"></asp:TextBox>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </td>
                            </tr>
                            <tr>
                                <td class="style3" colspan="2" style="text-align: center">
                                    <asp:UpdatePanel ID="UpdatePanel8" runat="server">
                                        <ContentTemplate>
                                            <asp:Button ID="Button10" runat="server" onclick="Button10_Click" Text="Update" 
                                                Width="270px" />
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </td>
                            </tr>
                            <tr>
                                <td class="style3" colspan="2" style="text-align: center">
                                    <asp:UpdatePanel ID="UpdatePanel6" runat="server">
                                        <ContentTemplate>
                                            <asp:Button ID="Button15" runat="server" onclick="Button15_Click" Text="Delete" 
                                                Width="270px" />
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </td>
                            </tr>
                            <tr>
                                <td class="style3" colspan="2" style="text-align: center">
                                    <asp:UpdatePanel ID="UpdatePanel9" runat="server">
                                        <ContentTemplate>
                                            <asp:Button ID="Button14" runat="server" onclick="Button12_Click" Text="Search" 
                                                Width="270px" />
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </td>
                            </tr>
                            <tr>
                                <td class="style3" colspan="2" style="text-align: center">
                                    <asp:UpdatePanel ID="UpdatePanel16" runat="server">
                                        <ContentTemplate>
                                            <asp:Button ID="Button22" runat="server" onclick="Button22_Click" 
                                                Text="View All" Width="270px" />
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </td>
                            </tr>
                        </table>
                    </div>
                </asp:Panel>
            </td>
        </tr>
      
        <tr>
            <td style="text-align: center; font-family: 'times New Roman', Times, serif; font-size: 18px; font-weight: bold;" 
                colspan="2" >
                <asp:Label ID="Label35" runat="server" Text="Request" Visible="False"></asp:Label>
            </td>
        </tr>
      
        <tr>
            <td style="text-align: right; " colspan="2" >
                <asp:Panel ID="Panel2" runat="server">
                    <div style="  border: 10px solid #EFEFEF; margin: auto; height:320px; width:714px; overflow:auto; vertical-align: top; text-align: left; ">
                        <asp:UpdatePanel ID="UpdatePanel15" runat="server">
                            <ContentTemplate>
                                <asp:Repeater ID="Repeater3" runat="server" OnItemCommand="Repeater3_ItemCommand">
                                    <ItemTemplate>
                                        <div style="margin: 5px; float: left">
                                            <table align="center" border="1" style=" width:330px">
                                                <tr>
                                                    <td colspan="2" style=" text-align:center">
                                                        <asp:Button ID="Button21" runat="server" CausesValidation="True" CommandName="5" Text="Approved" UseSubmitBehavior="False" Width="100%" />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="background-color:#EFEFEF; width:110px">Stop Point</td>
                                                    <td style="background-color:#EFEFEF; width:220px">
                                                        <asp:TextBox ID="TextBox28" runat="server" Enabled="False" Text='<%#Eval("Bus_stop_point") %>' Width="96%" BorderStyle="None" ForeColor="Black" BackColor="#EFEFEF"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="background-color:#EFEFEF; width:100px">Location</td>
                                                    <td style="background-color:#EFEFEF; width:230px">
                                                        <asp:TextBox ID="TextBox29" runat="server" Enabled="False" Text='<%#Eval("Location") %>' Width="96%" BorderStyle="None" ForeColor="Black" BackColor="#EFEFEF"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="background-color:#EFEFEF; width:100px">Road Name</td>
                                                    <td style="background-color:#EFEFEF; width:230px">
                                                        <asp:TextBox ID="TextBox30" runat="server" Enabled="False" Text='<%#Eval("Road_no") %>' Width="96%" BorderStyle="None" ForeColor="Black" BackColor="#EFEFEF"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="background-color:#EFEFEF; width:100px">Road Name</td>
                                                    <td style="background-color:#EFEFEF; width:230px">
                                                        <asp:TextBox ID="TextBox31" runat="server" Enabled="False" Text='<%#Eval("Road_name") %>' Width="96%" BorderStyle="None" ForeColor="Black" BackColor="#EFEFEF"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style=" background-color:#EFEFEF;width:100px">Request By</td>
                                                    <td style="background-color:#EFEFEF; width:230px">
                                                        <asp:TextBox ID="TextBox32" runat="server" Enabled="False" Text='<%#Eval("Request_id") %>' Width="96%" BorderStyle="None" ForeColor="Black" BackColor="#EFEFEF"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </div>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>
                </asp:Panel>
            </td>
        </tr>
      
        <tr>
            <td style="text-align: right; " colspan="2" >
                &nbsp;</td>
        </tr>
      
        <tr>
            <td colspan="2" >
               
                <asp:GridView ID="GridView1" runat="server" Visible="False">
                </asp:GridView>
               
                </td>
        </tr>
          <tr>
            <td colspan="2" >
               
                <asp:Label ID="Label1" runat="server" Text="s_no" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox7" runat="server" Enabled="False" 
                    style="text-align: left" Visible="False"></asp:TextBox>
                                <asp:TextBox ID="TextBox8" runat="server" Width="128px" 
                    Visible="False">insert bus data</asp:TextBox>
                 <asp:UpdatePanel ID="UpdatePanel17" runat="server">
                     <ContentTemplate>
                         <asp:Timer ID="Timer1" runat="server" Interval="5000" ontick="Timer1_Tick1">
                         </asp:Timer>
                     </ContentTemplate>
                </asp:UpdatePanel>
                 <br />
                <asp:Label ID="Label7" runat="server" Text="Bus_Stop_point" Visible="False" 
                    Width="50%"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server" Enabled="False" Visible="False" 
                    Width="100%"></asp:TextBox>
                <asp:TextBox ID="TextBox1" runat="server" Visible="False" Width="100%" 
                    style="text-align: left"></asp:TextBox>
               
              </td>
        </tr>
        </table>
   
   
    </form>
    </body>
</html>
