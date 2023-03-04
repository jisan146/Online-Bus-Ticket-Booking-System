<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyBus.aspx.cs" Inherits="WebApplication1.MyBus"  %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Bus Information</title>
    <style type="text/css">
        .style33
        { background-color:#EFEFEF;
           
        }
        .style1
        {
            text-align: center;
        }
        .style3
        {
        }
        .style4
        {
        }
    </style>
    </head>
<body>
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
    <form id="form1" runat="server">
    <table style=" width:856px;" align="center">
        <tr>
            <td style=" width:286px;">
                &nbsp;</td>
             <td style=" background-color: #EFEFEF;  ">
                <asp:Label ID="Label1" runat="server" Text="My ID" style="text-align: justify" ></asp:Label>
            </td>
            <td style=" background-color: #EFEFEF;  ">
                <asp:TextBox ID="TextBox1" runat="server" Enabled="False" Width="212px" 
                    BackColor="White" ForeColor="Black"  ></asp:TextBox>
            </td>
             <td style="  width:286px;" >
                 &nbsp;</td>
        </tr>
        <tr>
            <td style="vertical-align: top; text-align: right;">
                &nbsp;</td>
            <td style="background-color: #EFEFEF;">
                <asp:Label ID="Label2" runat="server" Text="Stuff ID"></asp:Label>
            </td>
            <td style="background-color: #EFEFEF;">
                <asp:TextBox ID="TextBox2" runat="server"   
                    Enabled="False" Width="212px" BackColor="White" ForeColor="Black"></asp:TextBox>
            </td>
            <td style="vertical-align: top; ">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="vertical-align: top; text-align: right;">
                &nbsp;</td>
            <td style="background-color: #EFEFEF;">
                <asp:Label ID="Label3" runat="server" Text="Bus ID"></asp:Label>
            </td>
            <td style="background-color: #EFEFEF;">
                <asp:TextBox ID="TextBox3" runat="server" Enabled="False" Width="212px" 
                    BackColor="White" ForeColor="Black" ></asp:TextBox>
            </td>
            <td style="vertical-align: top; ">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="vertical-align: top; text-align: right;">
                &nbsp;</td>
            <td style="background-color: #EFEFEF;">
                Comment</td>
            <td style="background-color: #EFEFEF;">
                <asp:TextBox ID="TextBox10" runat="server" MaxLength="25" Width="212px" 
                    BackColor="White" ForeColor="Black"></asp:TextBox>
            </td>
            <td style="vertical-align: top; ">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="vertical-align: top">
                 &nbsp;</td>
            <td style="" colspan="2">
                <asp:Button ID="Button1" runat="server" Text="Save" width="100%" onclick="Button1_Click" 
                   />
            </td>
            <td style="vertical-align: top; ">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="vertical-align: top">
                 &nbsp;</td>
            <td style="" colspan="2">
                <asp:Button ID="Button2" runat="server" Text="Delete" width="100%" 
                    onclick="Button2_Click"  />
            </td>
            <td style="vertical-align: top; ">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="vertical-align: top; text-align: right;">
                &nbsp;</td>
            <td style="" colspan="2">
                <asp:Button ID="Button9" runat="server" Text="Back" width="100%" 
                    onclick="Button9_Click"  />
            </td>
            <td style="vertical-align: top">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="vertical-align: top; text-align: center;" colspan="4">
                Driver/Helper Information</td>
        </tr>
        <tr>
            <td style="vertical-align: top; text-align: right;" colspan="4">
                    <div style="margin: auto; width: 840px; height: 405px; border: 10px solid #EFEFEF; overflow: auto; text-align: left;">
                <asp:Repeater ID="Repeater1" runat="server" 
                    onitemcommand="Repeater1_ItemCommand">
                   <ItemTemplate>
                   <div style="margin: 5px; float: left">
                   <table style=" width:400px"  align="center">
                   <tr><td colspan="2" style=" text-align:center; background-color:#EFEFEF">
                       <asp:Image ID="Image1" runat="server" ImageUrl='<%#Eval("picture") %>' Height="150px" Width="150px" />
                  
                       
                       </td></tr>

                       <tr><td colspan="2" style=" text-align:center">
                       
                            <asp:Button ID="Button4" runat="server" Text="Select" Width="100%" CausesValidation="True" UseSubmitBehavior="False" CommandName="5" />
                       </td></tr>

                        
                   <tr><td style=" width:190px; background-color:#EFEFEF">Stuff ID</td><td style=" width:190px" class="style33">
                       <asp:TextBox ID="TextBox4" runat="server" Text='<%#Eval("Stuff_id") %>' Enabled="False" BackColor="#EFEFEF" BorderStyle="None" ForeColor="Black"></asp:TextBox></td></tr>
                   <tr><td class="style33">Name</td><td class="style33"><%#Eval("Name")%></td></tr>
                   <tr><td class="style33">Type</td><td class="style33"><%#Eval("Stuff_Type")%></td></tr>
                   <tr><td class="style33">Contact Number</td><td class="style33"><%#Eval("Contact_number")%></td></tr>
                   <tr><td class="style33">Emargency Contact Number</td><td class="style33"><%#Eval("Emargency_contact_No")%></td></tr>
                   <tr><td class="style33">Email</td><td class="style33"><%#Eval("Email_id")%></td></tr>
                   <tr><td class="style33">Current Address</td><td class="style33"><%#Eval("Current_address")%></td></tr>
                   <tr><td class="style33">Permanent Address</td><td class="style33"><%#Eval("Permanent_address")%></td></tr>
                   
                   <tr><td class="style33">Register Date</td><td class="style33"><%#Eval("Register_date")%></td></tr>
                  
                   </table>
                     
                       </div>
                   </ItemTemplate>
                </asp:Repeater>
                    </div>
                    </td>
        </tr>
        <tr>
            <td style="vertical-align: top; text-align: center;" colspan="4">
                Bus Information</td>
        </tr>
        <tr>
            <td style="vertical-align: top; text-align: right;" colspan="4">
                    <div style="margin: auto; width: 840px; height: 330px; border: 10px solid #EFEFEF; overflow: auto; text-align: left;">
                <asp:Repeater ID="Repeater2" runat="server" 
                    onitemcommand="Repeater2_ItemCommand">
                   <ItemTemplate>
                   <div style="margin: 5px; float: left">
                   <table style=" width:400px"  align="center">
                 

                       <tr><td colspan="2" style=" text-align:center">
                       
                            <asp:Button ID="Button5" runat="server" Text="Select" Width="100%" 
                                CausesValidation="True" UseSubmitBehavior="False" CommandName="6" />
                       </td></tr>

                        
                   <tr><td class="style33" style=" width:190px">Bus License No</td><td class="style33" style=" width:190px">
                       <asp:TextBox ID="TextBox5" runat="server" Text='<%#Eval("Bus_License_no") %>' 
                           Enabled="False" BorderStyle="None" ForeColor="Black" BackColor="#EFEFEF"></asp:TextBox></td></tr>
                   <tr><td class="style33">Permit No</td><td class="style33"><%#Eval("Bus_no")%></td></tr>
                   <tr><td class="style33">Service Name</td><td class="style33"><%#Eval("Bus_Name")%></td></tr>
                   <tr><td class="style33">Type</td><td class="style33"><%#Eval("Bus_type")%></td></tr>
                   <tr><td class="style33">Total Sit</td><td class="style33"><%#Eval("Total_Sit")%></td></tr>
                   <tr><td class="style33">Stand Capacity</td><td class="style33"><%#Eval("Total_Stand_Capacity")%></td></tr>
                   <tr><td class="style33">License</td><td class="style33"><%#Eval("License")%></td></tr>
                   <tr><td class="style33">Approved By</td><td class="style33"><%#Eval("Approved_By")%></td></tr>
                    <tr><td class="style33">Approved Date</td><td class="style33"><%#Eval("Approved_Date")%></td></tr>
                   <tr><td class="style33">Fitness</td><td class="style33"><%#Eval("Fitness")%></td></tr>
                   <tr><td class="style33">Tex Year</td><td class="style33"><%#Eval("Tex_year")%></td></tr>
                    <tr><td class="style33">Tex</td><td class="style33"><%#Eval("Tex")%></td></tr>
                  
                   </table>
                     
                       </div>
                   </ItemTemplate>
                </asp:Repeater>
                    </div>
                    </td>
        </tr>
        <tr>
            <td style="vertical-align: top; " class="style1" colspan="4">
                Control Information</td>
        </tr>
        <tr>
            <td style="vertical-align: top; text-align: right;" colspan="4">
                    <div style="margin: auto; width: 840px; height: 300px; border: 10px solid #EFEFEF; overflow: auto; text-align: left;">
                <asp:Repeater ID="Repeater3" runat="server" 
                    onitemcommand="Repeater3_ItemCommand">
                   <ItemTemplate>
                   <div style="margin: 5px; float: left">
                   <table style=" width:400px"  align="center">
                 

                       <tr><td colspan="2" style=" text-align:center">
                       
                            <asp:Button ID="Button6" runat="server" Text="Delete" Width="100%" 
                                CausesValidation="True" UseSubmitBehavior="False" CommandName="6" />
                       </td></tr>

                        
                   <tr><td class="style33" style=" width:190px">Bus License No</td><td class="style33" style=" width:190px">
                       <asp:TextBox ID="TextBox6" runat="server" Text='<%#Eval("Bus_License_no") %>' 
                           Enabled="False"  BorderStyle="None" ForeColor="Black" BackColor="#EFEFEF"></asp:TextBox></td></tr>

                           <tr><td class="style33" style=" width:190px">Stuff ID</td><td class="style33" style=" width:190px">
                       <asp:TextBox ID="TextBox7" runat="server" Text='<%#Eval("Stuff_id") %>' 
                           Enabled="False"  BorderStyle="None" ForeColor="Black" BackColor="#EFEFEF"></asp:TextBox></td></tr>
                 
                   <tr><td class="style33">Name</td><td class="style33"><%#Eval("Name")%></td></tr>
                    <tr><td class="style33">Type</td><td class="style33"><%#Eval("Stuff_type")%></td></tr>
                  
                   </table>
                     
                       </div>
                   </ItemTemplate>
                </asp:Repeater>
                    </div>
                    </td>
        </tr>
        <tr>
            <td style="vertical-align: top; text-align: center;" colspan="4">
                Status</td>
        </tr>
        <tr>
            <td style="vertical-align: top; text-align: center;" colspan="4">
                <asp:Label ID="Label4" runat="server" Text="Bus ID"></asp:Label>
                <asp:TextBox ID="TextBox12" runat="server" BackColor="White" Enabled="False" 
                    ForeColor="Black"></asp:TextBox>
                <asp:Label ID="Label5" runat="server" Text="Status"></asp:Label>
                <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
                <asp:Button ID="Button10" runat="server" onclick="Button10_Click" 
                    Text="Update" />
            </td>
        </tr>
        <tr>
            <td style="vertical-align: top; text-align: right;" colspan="4">
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <div style="margin: auto; width: 840px; height: 300px; border: 10px solid #EFEFEF; overflow: auto; text-align: left;">
                            <asp:Repeater ID="Repeater4" runat="server" 
                                onitemcommand="Repeater3_ItemCommand">
                                <ItemTemplate>
                                    <div style="margin: 5px; float: left">
                                        <table align="center"  style=" width:400px">
                                           
                                            <tr>
                                                <td class="style33" style=" width:190px">
                                                    Bus License No</td>
                                                <td class="style33" style=" width:190px">
                                                    <asp:TextBox ID="TextBox8" runat="server" Enabled="False" 
                                                        Text='<%#Eval("Bus_License_no") %>'  BorderStyle="None" ForeColor="Black" BackColor="#EFEFEF"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="style33" style=" width:190px">
                                                    Stop Point ID</td>
                                                <td class="style33" style=" width:190px">
                                                    <asp:TextBox ID="TextBox9" runat="server" Enabled="False" 
                                                        Text='<%#Eval("Bus_Stop_point") %>'  BorderStyle="None" ForeColor="Black" BackColor="#EFEFEF"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="style33">
                                                    Left Location</td>
                                                <td class="style33">
                                                    <%#Eval("left_location")%>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="style33">
                                                    Delay</td>
                                                <td class="style33">
                                                    <%#Eval("Delay")%>
                                                </td>
                                            </tr>
                                        </table>
                                    </div>
                                </ItemTemplate>
                            </asp:Repeater>
                        </div>
                        <asp:ScriptManager ID="ScriptManager1" runat="server">
                        </asp:ScriptManager>
                        <asp:Timer ID="Timer1" runat="server" Interval="1000" ontick="Timer1_Tick">
                        </asp:Timer>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td style="vertical-align: top; text-align: center;" class="style3" colspan="4">
                 <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Search" />
&nbsp;<asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="Refresh map" />
            </td>
        </tr>
        <tr>
            <td style="vertical-align: top; text-align: right;" class="style3" colspan="4">
                 <div id="dvMap" 
                     
                     style="border: 10px solid #EFEFEF; margin: auto; width: 840px; height: 500px"></div></td>
        </tr>
        <tr>
            <td style="vertical-align: top" class="style3" >
                &nbsp;</td>
            <td style="vertical-align: top" class="style4" >
                    &nbsp;</td>
            <td style="vertical-align: top" >
                    &nbsp;</td>
            <td style="vertical-align: top">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="vertical-align: top" class="style3" >
                &nbsp;</td>
            <td style="vertical-align: top" class="style4" >
                    &nbsp;</td>
            <td style="vertical-align: top" >
                    &nbsp;</td>
            <td style="vertical-align: top">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="vertical-align: top; text-align: center;" colspan="4" >
                    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                        <ContentTemplate>
                            <asp:Timer ID="Timer2" runat="server" Interval="5000" ontick="Timer2_Tick1">
                            </asp:Timer>
                        </ContentTemplate>
                    </asp:UpdatePanel>
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
