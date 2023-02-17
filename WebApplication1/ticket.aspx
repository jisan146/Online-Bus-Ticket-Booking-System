<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ticket.aspx.cs" Inherits="WebApplication1.ticket" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tickets</title>

    <style type="text/css">
      .style3b
        { background-color:#EFEFEF;
           
        }
    </style>

    </head>
<body>
    <form id="form1" runat="server">
    <table  align="center"  >
                
        <tr>
            <td style="border-left: 10px solid #FFFFFF; border-right: 0px solid #FFFFFF; border-top: 0px solid #FFFFFF; border-bottom: 10px solid #FFFFFF; text-align: center;">
                &nbsp;</td>
        </tr>
        
        <tr>
            <td >
            <div style="border: 10px solid #EFEFEF;  width: 960px; height: auto">
                <div style="width: auto; height: auto;">
                    <table style=" width:960px" align="center">
                        <tr>
                            <td class="style3b" 
                                
                                
                                style="width: 480px;">
                                &nbsp;</td>
                            <td 
                                class="style3b" style="text-align: left"  >
                                <asp:TextBox ID="TextBox37" runat="server" Visible="False" Width="150px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style3b" 
                                
                                
                                style="text-align: right;">
    <asp:Label ID="Label8" runat="server" Text="My ID" style="text-align: left" Width="160px" BackColor="White"></asp:Label>
                            </td>
                            <td style="text-align: left;" 
                                class="style3b">
    <asp:TextBox ID="TextBox9" runat="server" Enabled="False" Width="150px" style="text-align: left" 
                                    BackColor="White" ForeColor="Black"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style3b" 
                                
                                
                                style="text-align: right;">
    <asp:Label ID="Label9" runat="server" Text="Balance" style="text-align: left" Width="160px" 
                                    BackColor="White"></asp:Label>
                            </td>
                            <td style="text-align: left;" 
                                class="style3b">
    <asp:TextBox ID="TextBox10" runat="server" Enabled="False" BackColor="White" 
                    ForeColor="Black" Width="150px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style3b" 
                                
                                
                                style="text-align: right;">
    <asp:Label ID="Label10" runat="server" Text="From" style="text-align: left" Width="160px" BackColor="White"></asp:Label>
                            </td>
                            <td style="text-align: left;" 
                                class="style3b">
    <asp:DropDownList ID="DropDownList1" runat="server" 
        DataSourceID="SqlDataSource1" DataTextField="Location" 
        DataValueField="Location" BackColor="White" ForeColor="Black" Width="155px">
    </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td class="style3b" 
                                
                                
                                style="text-align: right;">
    <asp:Label ID="Label11" runat="server" Text="To" style="text-align: left" Width="160px" BackColor="White"></asp:Label>
                            </td>
                            <td style="text-align: left;" 
                                class="style3b">
    <asp:DropDownList ID="DropDownList2" runat="server" 
        DataSourceID="SqlDataSource1" DataTextField="Location" 
        DataValueField="Location" BackColor="White" ForeColor="Black" Width="155px">
    </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td class="style3b" 
                                
                                
                                style="text-align: right;">
    <asp:Label ID="Label12" runat="server" Text="Travel Date" style="text-align: left" Width="160px" 
                                    BackColor="White"></asp:Label>
                            </td>
                            <td style="text-align: left;" 
                                class="style3b">
        <asp:TextBox ID="TextBox21" runat="server" TextMode="Number" MaxLength="2" 
                    BackColor="White" ForeColor="Black" Width="40px" style="text-align: center"></asp:TextBox>
                                <asp:TextBox ID="TextBox40" runat="server" BackColor="White" Enabled="False" 
                                    ForeColor="Black" style="text-align: center" Width="43px"></asp:TextBox>
                                <asp:TextBox ID="TextBox41" runat="server" BackColor="White" Enabled="False" 
                                    ForeColor="Black" style="text-align: center" Width="43px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style3b" 
                                
                                
                                style="text-align: right;">
                                &nbsp;</td>
                            <td style="text-align: left;" 
                                class="style3b">
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Search" 
        Enabled="False" Width="155px" />
                            </td>
                        </tr>
                        <tr>
                            <td class="style3b" 
                                
                                
                                style="text-align: right;">
        <asp:Label ID="Label6" runat="server" Text="Available sit" style="text-align: left" Width="160px" 
                                    BackColor="White"></asp:Label>
                            </td>
                            <td style="text-align: left;" 
                                class="style3b">
        <asp:TextBox ID="TextBox19" runat="server" Enabled="False" BackColor="White" 
                    ForeColor="Black" Width="150px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style3b" 
                                
                                
                                
                                style="text-align: right;">
        <asp:Label ID="Label7" runat="server" Text="Available stand Capacity" Width="160px" 
                                    style="text-align: left" BackColor="White"></asp:Label>
                            </td>
                            <td style="text-align: left;" 
                                class="style3b">
        <asp:TextBox ID="TextBox20" runat="server" Enabled="False" BackColor="White" 
                    ForeColor="Black" Width="150px" ></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style3b" 
                                
                                
                                style="text-align: right;">
        <asp:Label ID="Label1" runat="server" Text="KM" style="text-align: left" Width="160px" 
                                    BackColor="White"></asp:Label>
                            </td>
                            <td style="text-align: left;" 
                                class="style3b">
        <asp:TextBox ID="TextBox6" runat="server" Enabled="False" BackColor="White" 
                    ForeColor="Black" Width="150px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style3b" 
                                
                                
                                style="text-align: right;">
        <asp:Label ID="Label2" runat="server" Text="Per KM rate for this bus" Width="160px" BackColor="White" 
                                    style="text-align: left"></asp:Label>
                            </td>
                            <td style="text-align: left;" 
                                class="style3b">
        <asp:TextBox ID="TextBox7" runat="server" Enabled="False" BackColor="White" 
                    ForeColor="Black" Width="150px" style="text-align: left"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style3b" 
                                
                                
                                style="text-align: right;">
        <asp:Label ID="Label3" runat="server" Text="Total Tk" style="text-align: left" Width="160px" 
                                    BackColor="White"></asp:Label>
                            </td>
                            <td style="text-align: left;" 
                                class="style3b">
        <asp:TextBox ID="TextBox8" runat="server" Enabled="False" BackColor="White" 
                    ForeColor="Black" Width="150px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style3b" 
                                
                                
                                style="text-align: right;">
                                &nbsp;</td>
                            <td style="text-align: left;" 
                                class="style3b">
        <asp:Button ID="Button2" runat="server" Enabled="False" Text="Confirm" 
            onclick="Button2_Click" Width="155px" />
                            </td>
                        </tr>
                        <tr>
                            <td class="style3b" 
                                
                                
                                style="text-align: right;">
                                &nbsp;</td>
                            <td style="text-align: left;" 
                                class="style3b">
                                <asp:Button ID="Button7" runat="server" onclick="Button7_Click" Text="Refresh" 
                                    Width="155px" />
                            </td>
                        </tr>
                        <tr>
                            <td class="style3b" 
                                
                                
                                style="text-align: right;">
                                &nbsp;</td>
                            <td style="text-align: left;" 
                                class="style3b">
        <asp:Button ID="Button3" runat="server" Text="Back" 
            onclick="Button3_Click" Width="155px" />
                            </td>
                        </tr>
                        <tr>
                            <td class="style3b" 
                                
                                
                                
                                style="text-align: right;">
        <asp:Label ID="Label14" runat="server" Text="Ticket No" style="text-align: left" Width="160px" 
                                    BackColor="White"></asp:Label>
                            </td>
                            <td style="text-align: left;" 
                                class="style3b">
                                <asp:TextBox ID="TextBox34" runat="server" Width="150px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style3b" 
                                
                                
                                
                                style="text-align: right;">
        <asp:Label ID="Label16" runat="server" Text="Left Location" style="text-align: left" Width="160px" 
                                    BackColor="White"></asp:Label>
                            </td>
                            <td style="text-align: left;" 
                                class="style3b">
                                <asp:TextBox ID="TextBox36" runat="server" Width="150px" BackColor="White" 
                                    Enabled="False" ForeColor="Black"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style3b" 
                                
                                
                                
                                style="text-align: right;">
        <asp:Label ID="Label15" runat="server" Text="Delay" style="text-align: left" Width="160px" 
                                    BackColor="White"></asp:Label>
                            </td>
                            <td style="text-align: left;" 
                                class="style3b">
                                <asp:TextBox ID="TextBox35" runat="server" Width="150px" BackColor="White" 
                                    Enabled="False" ForeColor="Black"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style3b" 
                                
                                
                                style="text-align: right;">
                                &nbsp;</td>
                            <td style="text-align: left;" 
                                class="style3b">
                                <asp:Button ID="Button5" runat="server" Text="Search" Width="155px" 
                                    onclick="Button5_Click" />
                            </td>
                        </tr>
                        <tr>
                            <td class="style3b" 
                                
                                
                                style="text-align: right;">
                                &nbsp;</td>
                            <td style="text-align: left;" 
                                class="style3b">
                                <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Location &amp; notification" 
                                    Enabled="False" Width="155px" />
                            </td>
                        </tr>
                    </table>
                </div>
                </div>
            </td>
        </tr>
        
        <tr>
            <td>
            <div style="border: 10px solid #EFEFEF; margin: auto; width: 960px; height: 320px">
                <div style="border-left: 10px solid #CCCCCC; border-right: 0px solid #CCCCCC; border-top: 10px solid #CCCCCC; border-bottom: 10px solid #CCCCCC; margin: auto; width: 630px; height: 300px; overflow: auto; text-align: center; border-color: #FFFFFF; border-width: 10px; float: left;">
                    <asp:Label ID="Label13" runat="server" Text="  " style="text-align: center"></asp:Label>
                    Result
                    <br />
                    [If no result show then search again]<br />
                   <asp:Repeater ID="Repeater1" runat="server" 
                        onitemcommand="Repeater1_ItemCommand">
                    <ItemTemplate>
                    <div style="border: 2.5px solid #FFFFFF; width: 600px; height:32px; text-align: center; margin: auto auto auto auto; background-color: #EFEFEF;">
                    <div style="margin: 0px;  width: auto; height: auto; float: left; text-align: left;"><asp:TextBox ID="TextBox28" runat="server" Text='<%#Eval("Bus_License_no") %>' Visible="False" Width="0"></asp:TextBox></div>
                       <div style="margin: 0px;  width: auto; height: auto; float: left; text-align: left;"> <asp:TextBox ID="TextBox32" runat="server" Text='<%#Eval("Location") %>' Visible="False" Width="0"></asp:TextBox></div>
                       
                        <div style="margin: 5px; width: auto; height: auto; float: left; text-align: left;">  <asp:Button ID="Button4" runat="server" CommandName="5" Text="Select" /></div>
                   <div style="margin: 5px; width: auto; height: auto; float: left; text-align: left;">Travel Name <asp:TextBox ID="TextBox29" runat="server" Text='<%#Eval("Bus_Name") %>'  Enabled="False" BackColor="White" ForeColor="Black"></asp:TextBox></div>
                     <div style="margin: 5px; width: auto; height: auto; float: left; text-align: left;">Type <asp:TextBox ID="TextBox30" runat="server" Text='<%#Eval("Bus_Type") %>' Enabled="False" BackColor="White" ForeColor="Black" Width="65px"></asp:TextBox></div>
                   
                    
                   <div style="margin: 5px; width: auto; height: auto; float: left; text-align: left;">Time <asp:TextBox ID="TextBox33" runat="server" Text='<%#Eval("Stop_time") %>'  Width="40" Enabled="False" BackColor="White" ForeColor="Black"></asp:TextBox></div>
                      <div style="margin: 5px; float: left; text-align: left;"><asp:TextBox ID="TextBox27" runat="server" Text='<%#Eval("TT") %>' Width="30" Enabled="False" BackColor="White" ForeColor="Black"></asp:TextBox></div>
                       <div style="margin: 0px;  width: auto; height: auto; float: left; text-align: left;"> <asp:TextBox ID="TextBox31" runat="server" Text='<%#Eval("Stop_point") %>' Visible="False" Width="0"></asp:TextBox></div>
                     
                    </div>
                    </ItemTemplate>
                    </asp:Repeater>
                </div>
                <div style="border-width: 10px 10px 10px 0px; border-color: #FFFFFF; border-style: solid; vertical-align: middle; text-align: center; margin: auto 0px auto auto; width: 300px; height: 300px; overflow: auto; float: left;">
            &nbsp;<div style="margin: auto 3px auto 3px; float: left; ">
                Time Scedule<br />
                <div style=" float:left;width: 140px;">
                    <asp:Label ID="Label17" runat="server" BackColor="#EFEFEF" BorderStyle="None" 
                          Enabled="False" ForeColor="Black" Height="20px" Text="Start" Visible="False" 
                          Width="35px"></asp:Label>
                    <asp:TextBox ID="TextBox38" runat="server" BackColor="#EFEFEF" 
                          BorderStyle="None" Enabled="False" ForeColor="Black" Height="20px" 
                          Visible="False" Width="80px"></asp:TextBox>
                </div>
                <div style=" float:right;width: 140px;">
                    <asp:Label ID="Label18" runat="server" BackColor="#EFEFEF" BorderStyle="None" 
                           Enabled="False" ForeColor="Black" Height="20px" Text="End" Visible="False" 
                           Width="35px"></asp:Label>
                    <asp:TextBox ID="TextBox39" runat="server" BackColor="#EFEFEF" 
                           BorderStyle="None" Enabled="False" ForeColor="Black" Height="20px" 
                           Visible="False" Width="80px"></asp:TextBox>
                </div>
                <asp:GridView ID="GridView8" runat="server" Width="100%" Visible="False">
                </asp:GridView>
            </div>
            <div style="float: left; margin-left: 1px; margin-top: auto; margin-bottom: auto;">
                <br />
                <asp:GridView ID="GridView6" runat="server" Width="100%" Visible="False">
                </asp:GridView>
            </div>
        </div>
                </div>
            </td>
        </tr>
        <tr>
            <td>
                <div style="margin: 10px auto auto auto; border: 10px solid #EFEFEF; height: 300px; width: 960px; overflow: auto; text-align: center;">
              
                    <asp:Repeater ID="Repeater2" runat="server">
                     <ItemTemplate>
                    <div style="border: 2.5px solid #FFFFFF; width: 230px; height:200px; text-align: center; margin: auto  auto auto auto; background-color: #EFEFEF; float: left;">
                  
                       <table align="left" style="margin: 5px">
                     
                       <tr><td style="width:100px; text-align: left;">Ticket No</td><td style="text-align: left"><%# Eval("Ticket_No") %></td></tr>
                         <tr><td style="width:70px; text-align: left;">Ticket Type</td><td style="text-align: left"><%# Eval("Ticket_type")%></td></tr>
                        <tr><td style="width:70px; text-align: left;">Travle Date</td><td style="text-align: left"><%# Eval("Travel_Date") %></td></tr>
                       
                          <tr><td style="width:70px; text-align: left;">Journey Time</td><td style="text-align: left"><%# Eval("Time")%></td></tr>
                           <tr><td style="width:70px; text-align: left;">Bus ID</td><td style="text-align: left"><%# Eval("Bus_license_no")%></td></tr>
                            <tr><td style="width:70px; text-align: left;">From</td><td style="text-align: left"><%# Eval("Start_location")%></td></tr>
                             <tr><td style="width:70px; text-align: left;">To</td><td style="text-align: left"><%# Eval("End_Location") %></td></tr>
                              <tr><td style="width:70px; text-align: left;">Taka</td><td style="text-align: left"><%# Eval("Taka") %></td></tr>
                     
                       </table>
                       
                       
                  
                   </div>
                    </ItemTemplate>
                    </asp:Repeater>
                </div>
            </td>
        </tr>
    </table>
    <br />
    <br />
    <br />
    <asp:GridView ID="GridView9" runat="server" Visible="False">
    </asp:GridView>
    <br />
    <div>
       
        <br />
        <br />
        <asp:GridView ID="GridView3" runat="server" 
            onselectedindexchanged="GridView3_SelectedIndexChanged" Width="100%" 
                        style="text-align: center" Visible="False">
            <Columns>
                <asp:CommandField ButtonType="Button" HeaderText="Select" 
                    ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
        <br />
        <br />
        <asp:GridView ID="GridView7" runat="server" Width="100%" style="text-align: center" 
                       
                        onselectedindexchanged="GridView7_SelectedIndexChanged" 
            Visible="False">
        </asp:GridView>
        <br />
        <asp:TextBox ID="TextBox25" runat="server" Visible="False"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox26" runat="server" Visible="False"></asp:TextBox>
        <br />
    <asp:TextBox ID="TextBox11" runat="server" Visible="False"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox24" runat="server" Visible="False"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox3" runat="server" Visible="False"></asp:TextBox>
        <asp:TextBox ID="TextBox4" runat="server" Visible="False"></asp:TextBox>
        <asp:TextBox ID="TextBox5" runat="server" Enabled="False" Visible="False">1</asp:TextBox>
        <asp:TextBox ID="TextBox12" runat="server" Visible="False"></asp:TextBox>
        <asp:TextBox ID="TextBox13" runat="server" Visible="False"></asp:TextBox>
        <asp:TextBox ID="TextBox14" runat="server" Enabled="False" Visible="False"></asp:TextBox>
        <asp:TextBox ID="TextBox15" runat="server" Visible="False">1</asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Total sit" Visible="False"></asp:Label>
        <asp:TextBox ID="TextBox16" runat="server" Visible="False"></asp:TextBox>
        <asp:Label ID="Label4" runat="server" Text="total stand" Visible="False"></asp:Label>
        <asp:TextBox ID="TextBox17" runat="server" Height="22px" Visible="False"></asp:TextBox>
        <asp:TextBox ID="TextBox18" runat="server" TextMode="Number" Enabled="False" 
            Visible="False">0</asp:TextBox>
        <asp:TextBox ID="TextBox22" runat="server" Enabled="False" Visible="False"></asp:TextBox>
        <asp:TextBox ID="TextBox23" runat="server" Enabled="False" Visible="False"></asp:TextBox>
        <br />
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:WebApplication1.Properties.Settings._ConnectionString %>" 
        SelectCommand="(SELECT Location FROM time_schedule,stop_office WHERE time_schedule.Bus_Stop_point=stop_office.Bus_Stop_point)INTERSECT (SELECT Location FROM time_schedule,stop_office WHERE time_schedule.Bus_Stop_point=stop_office.Bus_Stop_point)">
    </asp:SqlDataSource>
    <asp:TextBox ID="TextBox1" runat="server" Visible="False"></asp:TextBox>
    <asp:TextBox ID="TextBox2" runat="server" Visible="False"></asp:TextBox>
        <br />
        <asp:GridView ID="GridView2" runat="server" Visible="False">
        </asp:GridView>
        <asp:GridView ID="GridView4" runat="server" Visible="False">
        </asp:GridView>
        <asp:GridView ID="GridView5" runat="server" Visible="False">
        </asp:GridView>
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" 
            onselectedindexchanged="GridView1_SelectedIndexChanged" Visible="False">
            <Columns>
                <asp:CommandField ButtonType="Button" HeaderText="Booking" SelectText="Booking" 
                    ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Timer ID="Timer1" runat="server" Interval="5000" ontick="Timer1_Tick1">
                </asp:Timer>
            </ContentTemplate>
        </asp:UpdatePanel>
        <br />
     
    </div>
    </form>
</body>
</html>
