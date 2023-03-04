<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="status.aspx.cs" Inherits="WebApplication1.status" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Status</title>
    <style type="text/css">
        .style3b
        { background-color:#EFEFEF;
           
        }
        .style1
        {
            text-align: left;
        }
        .auto-style1 {
            height: 23px;
        }
        .style4
        {
            height: 26px;
        }
        </style>
</head>
<body>

    <form id="form1" runat="server">   <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
      
    <asp:UpdatePanel ID="UpdatePanel10" runat="server">
        <ContentTemplate>
            <asp:Timer ID="Timer2" runat="server" Enabled="False" Interval="1000" 
                ontick="Timer2_Tick1">
            </asp:Timer>
            <asp:Timer ID="Timer3" runat="server" Interval="5000" ontick="Timer3_Tick">
            </asp:Timer>
            <asp:Timer ID="Timer4" runat="server" Enabled="False" Interval="1000" 
                ontick="Timer4_Tick">
            </asp:Timer>
        </ContentTemplate>
    </asp:UpdatePanel>
       <script  src="https://maps.googleapis.com/maps/api/js?key=AIzaSyA7ahws4ZDxBimvHaaihnIH12BPK7ysyCM&callback=initMap"
  type="text/javascript"></script>
  <script type="text/javascript">

      var markers = [ 
<asp:Repeater ID="rptMarkers" runat="server">
<ItemTemplate>
            {
            "title": '<%# Eval("id") %>',
            "lat": '<%# Eval("Latitude") %>',
            "lng": '<%# Eval("Longitude") %>',
            "description": '<%# Eval("Description") %>'
        }
</ItemTemplate>
<SeparatorTemplate>
    ,
</SeparatorTemplate>
</asp:Repeater> 

];
</script> 
<script type="text/javascript">
    window.onload = function () {
        var mapOptions = {
            center: new google.maps.LatLng(markers[0].lat, markers[0].lng),
            zoom: 16,
            mapTypeId: google.maps.MapTypeId.ROADMAP
        };
        var infoWindow = new google.maps.InfoWindow();
        var map = new google.maps.Map(document.getElementById("dvMap"), mapOptions);
        for (i = 0; i < markers.length; i++) {
            var data = markers[i]
            var myLatlng = new google.maps.LatLng(data.lat, data.lng);
            var marker = new google.maps.Marker({
                position: myLatlng,
                map: map,
                title: data.title
            });
            (function (marker, data) {
                google.maps.event.addListener(marker, "click", function (e) {
                    infoWindow.setContent(data.description);
                    infoWindow.open(map, marker);
                });
            })(marker, data);
        }
    }
</script>     
    <table style="" align="center">
        <tr>
            <td style=" text-align: center;">
                <asp:UpdatePanel ID="UpdatePanel9" runat="server">
                    <ContentTemplate>
                        <asp:TextBox ID="TextBox5" runat="server" Width="50px" Visible="False"></asp:TextBox>
                        <asp:TextBox ID="TextBox6" runat="server" Width="50px" Visible="False"></asp:TextBox>
                        <asp:TextBox ID="TextBox7" runat="server" Width="50px" Visible="False"></asp:TextBox>
                    </ContentTemplate>
                </asp:UpdatePanel>
             
            </td>
        </tr>
        <tr>
            <td style=" text-align: center;">
                <asp:UpdatePanel ID="UpdatePanel7" runat="server">
                    <ContentTemplate>
                        <asp:TextBox ID="TextBox28" runat="server" Visible="False"></asp:TextBox>
                    </ContentTemplate>
                </asp:UpdatePanel>
                <asp:TextBox ID="TextBox2" runat="server" Visible="False"></asp:TextBox>
                <asp:TextBox ID="TextBox3" runat="server" Visible="False"></asp:TextBox>
                <asp:UpdatePanel ID="UpdatePanel8" runat="server">
                    <ContentTemplate>
                        <asp:Timer ID="Timer1" runat="server" Interval="10000" ontick="Timer1_Tick">
                        </asp:Timer>
                        <asp:Button ID="Button3" runat="server" onclick="Button3_Click" 
                            Text="Start new Schedule" Visible="False" Width="61px" />
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td style=" text-align: center;" class="style4">
                <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                    <ContentTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Width="128px" Visible="False"></asp:TextBox>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td style="text-align: center" class="style3b">
                <strong>Bus Status</strong></td>
        </tr>
        <tr>
            <td style="text-align: center" class="style3b">
                <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                    <ContentTemplate>
                        <asp:Label ID="Label4" runat="server" BackColor="White" 
                            style="text-align: left" Text="Bus ID" Width="128px"></asp:Label>
                        &nbsp;&nbsp;
                        <asp:TextBox ID="TextBox4" runat="server" Enabled="False" Width="128px" 
                            BackColor="White" ForeColor="Black"></asp:TextBox>
                    </ContentTemplate>
                </asp:UpdatePanel>
                </td>
        </tr>
        <tr>
            <td style="text-align: center" class="style3b">
                <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                    <ContentTemplate>
                        <asp:Label ID="Label5" runat="server" BackColor="White" 
                            style="text-align: left" Text="Time" Width="128px"></asp:Label>
                        &nbsp;&nbsp;
                        <asp:TextBox ID="TextBox8" runat="server" Enabled="False" Width="128px" 
                            BackColor="White" ForeColor="Black"></asp:TextBox>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td style="text-align: center" class="style3b">
                <asp:UpdatePanel ID="UpdatePanel11" runat="server">
                    <ContentTemplate>
                        <asp:Label ID="Label10" runat="server" BackColor="White" 
                            style="text-align: left" Text="Latitude" Width="128px"></asp:Label>
                        &nbsp;&nbsp;
                        <asp:TextBox ID="TextBox37" runat="server" 
    Enabled="False" Width="128px" 
                            BackColor="White" ForeColor="Black"></asp:TextBox>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td style="text-align: center" class="style3b">
                <asp:UpdatePanel ID="UpdatePanel12" runat="server">
                    <ContentTemplate>
                        <asp:Label ID="Label11" runat="server" BackColor="White" 
                            style="text-align: left" Text="Longitude" Width="128px"></asp:Label>
                        &nbsp;&nbsp;
                        <asp:TextBox ID="TextBox38" runat="server" BackColor="White" Enabled="False" 
                            ForeColor="Black" Width="128px"></asp:TextBox>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td style="text-align: center" class="style3b">
                <asp:UpdatePanel ID="UpdatePanel14" runat="server">
                    <ContentTemplate>
                        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Pass" 
                            Width="150px" />
                    </ContentTemplate>
                </asp:UpdatePanel>
                <asp:UpdatePanel ID="UpdatePanel13" runat="server">
                    <ContentTemplate>
                        <asp:Label ID="Label12" runat="server" Text="10" Visible="False"></asp:Label>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td style="text-align: center" class="style3b">
                <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
                    Text="Refresh" Width="150px" />
            </td>
        </tr>
        <tr>
            <td style="text-align: center" class="style3b">
                <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" 
                    Text="Sell Ticket" Width="150px" />
            </td>
        </tr>
        <tr>
            <td style="text-align: center" class="style3b">
                <asp:Button ID="Button4" runat="server" onclick="Button4_Click" 
                    Text="Back" Width="150px" />
            </td>
        </tr>
        <tr>
            <td style="text-align: center" class="style3b">
                Bus ID 
                <asp:TextBox ID="TextBox9" runat="server" BackColor="White" ForeColor="Black"></asp:TextBox>
&nbsp;<asp:Button ID="Button6" runat="server" Text="Search" OnClick="Button6_Click" />
            &nbsp;<asp:Button ID="Button21" runat="server" OnClick="Button21_Click" Text="Refresh Map" />
            </td>
        </tr>
        <tr>
            <td style="text-align: center">
                    <asp:Label ID="Label2" runat="server" Text="Status"></asp:Label>
                </td>
        </tr>
        <tr>
            <td style="text-align: center">
                <div style="margin: auto; border: 10px solid #EFEFEF; width: 750px; height: 300px; overflow: auto; text-align: left;">
                  
                    <asp:UpdatePanel ID="UpdatePanel5" runat="server" UpdateMode="Conditional">
                        <ContentTemplate>
                            <asp:Repeater ID="Repeater2" runat="server">
                                 <ItemTemplate>
                         <div style="  margin: 5px; width:740px; height: 24px;">

                             <div style="margin: 1px; text-align: left; background-color: #EFEFEF; float: left; width: 110px; height: 22px; vertical-align: middle">Bus License No</div>
                             <div style="margin: 1px; text-align: left; background-color: #EFEFEF; float: left; width: 110px; height: 22px; vertical-align: middle"><%#Eval("Bus_License_no") %></div>
                             <div style="margin: 1px; text-align: left; background-color: #EFEFEF; float: left; width: 80px; height: 22px; vertical-align: middle">Stop Point</div>
                              <div style="margin: 1px; text-align: left; background-color:#EFEFEF; float: left; width: 100px; height: 22px; vertical-align: middle"><%#Eval("Stop_point") %></div>
                             <div style="margin: 1px; text-align: left; background-color: #EFEFEF; float: left; width: 100px; height: 22px; vertical-align: middle">Left Location</div>
                             <div style="margin: 1px; text-align: left; background-color: #EFEFEF; float: left; width: 100px; height: 22px; vertical-align: middle"><%#Eval("Left_Location") %></div>
                               <div style="margin: 1px; text-align: left; background-color:#EFEFEF; float: left; width: 60px; height: 22px; vertical-align: middle">Delay</div>
                               <div style="margin: 1px; text-align: left; background-color: #EFEFEF; float: left; width: 60px; height: 22px; vertical-align: middle"><%#Eval("Delay ") %></div>


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
                <asp:Label ID="Label1" runat="server" Text="Upcoming"></asp:Label></td>
        </tr>
        <tr>
            <td style="text-align: center">
                <div class="style1" 
                    
                    
                    
                    
                    style="margin: auto; border: 10px solid #EFEFEF; width: 750px; height: 300px; overflow: auto;">
                 
                   
                   
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                        <ContentTemplate>
                            <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
                                 <ItemTemplate>
                                        <div style="margin: 5px 5px 5px 27px; float: left">
                                            <table align="center"  style=" width:330px">
                                                <tr>
                                                    <td colspan="2" style=" text-align:center">
                                                        <asp:Button ID="Button22" runat="server" CausesValidation="True" 
                                                            CommandName="5" Text="Select" UseSubmitBehavior="False" Width="100%" />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="style3b" style=" width:110px">Bus License No</td>
                                                    <td class="style3b" style=" width:220px">
                                                        <asp:TextBox ID="TextBox29" runat="server" Enabled="False" 
                                                            Text='<%#Eval("Bus_License_no") %>' BackColor="#EFEFEF" BorderStyle="None" ForeColor="Black"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                 <tr>
                                                    <td class="style3b" style=" width:100px">Stop Time</td>
                                                    <td class="style3b" style=" width:230px">
                                                        <asp:TextBox ID="TextBox30" runat="server" Enabled="False" 
                                                            Text='<%#Eval("Stop_time") %>' BackColor="#EFEFEF" BorderStyle="None" ForeColor="Black"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                 <tr>
                                                    <td class="style3b" style=" width:100px">TT</td>
                                                    <td class="style3b" style=" width:230px">
                                                        <asp:TextBox ID="TextBox31" runat="server" Enabled="False" 
                                                            Text='<%#Eval("TT") %>' BackColor="#EFEFEF" BorderStyle="None" ForeColor="Black"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                 <tr>
                                                    <td class="style3b" style=" width:100px">Stop office</td>
                                                    <td class="style3b" style=" width:230px">
                                                        <asp:TextBox ID="TextBox32" runat="server" Enabled="False" 
                                                            Text='<%#Eval("Bus_Stop_point") %>' BackColor="#EFEFEF" BorderStyle="None" ForeColor="Black"></asp:TextBox>
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
                    <asp:Label ID="Label3" runat="server" Text="All Bus"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="text-align: center">
                <div class="style1" 
                    
                    
                    
                    
                    style="margin: auto; border: 10px solid #EFEFEF; width: 750px; height: 300px; overflow: auto;">
                 
                    <asp:UpdatePanel ID="UpdatePanel6" runat="server" UpdateMode="Conditional">
                        <ContentTemplate>
                            <asp:Repeater ID="Repeater3" runat="server" OnItemCommand="Repeater3_ItemCommand">
                                  <ItemTemplate>
                                        <div style="margin: 5px 5px 5px 27px; float: left">
                                            <table align="center"  style=" width:330px">
                                                <tr>
                                                    <td colspan="2" style=" text-align:center">
                                                        <asp:Button ID="Button20" runat="server" CausesValidation="True" CommandName="5" Text="Select" UseSubmitBehavior="False" Width="100%" />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="style3b" style=" width:110px">Bus License No</td>
                                                    <td class="style3b" style=" width:220px">
                                                        <asp:TextBox ID="TextBox24" runat="server" Enabled="False" Text='<%#Eval("Bus_License_no") %>'  BackColor="#EFEFEF" BorderStyle="None" ForeColor="Black"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                 <tr>
                                                    <td class="style3b" style=" width:100px">Stop Time</td>
                                                    <td class="style3b" style=" width:230px">
                                                        <asp:TextBox ID="TextBox13" runat="server" Enabled="False" Text='<%#Eval("Stop_time") %>'  BackColor="#EFEFEF" BorderStyle="None" ForeColor="Black"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                 <tr>
                                                    <td class="style3b" style=" width:100px">TT</td>
                                                    <td class="style3b" style=" width:230px">
                                                        <asp:TextBox ID="TextBox25" runat="server" Enabled="False" Text='<%#Eval("TT") %>'  BackColor="#EFEFEF" BorderStyle="None" ForeColor="Black"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                 <tr>
                                                    <td class="style3b" style=" width:100px">Stop office</td>
                                                    <td class="style3b" style=" width:230px">
                                                        <asp:TextBox ID="TextBox26" runat="server" Enabled="False" Text='<%#Eval("Bus_Stop_point") %>'  BackColor="#EFEFEF" BorderStyle="None" ForeColor="Black"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                 <tr>
                                                    <td class="style3b" style=" width:100px">Pass</td>
                                                    <td class="style3b" style=" width:230px">
                                                        <asp:TextBox ID="TextBox27" runat="server" Enabled="False" Text='<%#Eval("pass") %>'  BackColor="#EFEFEF" BorderStyle="None" ForeColor="Black"></asp:TextBox>
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
                Maps</td>
        </tr>
        <tr>
            <td style="text-align: center">
                 <div id="dvMap" 
                     
                     style="border: 10px solid #EFEFEF; margin: auto; width: 750px; height: 500px"></div></td>
        </tr>
        <tr>
            <td style="text-align: center">
                <asp:TextBox ID="TextBox33" runat="server" BackColor="White" Enabled="False" 
                    ForeColor="Black" Width="128px" Visible="False"></asp:TextBox>
                <asp:TextBox ID="TextBox34" runat="server" BackColor="White" Enabled="False" 
                    ForeColor="Black" Width="128px" Visible="False"></asp:TextBox>
                <asp:TextBox ID="TextBox35" runat="server" BackColor="White" Enabled="False" 
                    ForeColor="Black" Width="128px" Visible="False"></asp:TextBox>
                <asp:TextBox ID="TextBox36" runat="server" BackColor="White" Enabled="False" 
                    ForeColor="Black" Width="128px" Visible="False"></asp:TextBox>
                </td>
        </tr>
         </tr>
        <tr>
            <td style="text-align: center">
               
                <asp:UpdatePanel ID="UpdatePanel15" runat="server">
                    <ContentTemplate>
                        <asp:TextBox ID="TextBox39" runat="server"></asp:TextBox>
                        <asp:TextBox ID="TextBox40" runat="server"></asp:TextBox>
                        <asp:TextBox ID="TextBox41" runat="server"></asp:TextBox>
                        <asp:GridView ID="GridView1" runat="server">
                        </asp:GridView>
                        <asp:GridView ID="GridView2" runat="server">
                        </asp:GridView>
                    </ContentTemplate>
                </asp:UpdatePanel>
               
                </td>
        </tr>
    </table>
    </form>

    </body>
</html>
