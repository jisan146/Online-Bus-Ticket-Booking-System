<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Location.aspx.cs" Inherits="WebApplication1.WebForm2" %>

<!DOCTYPE html>
 
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Location</title>
    <style type="text/css">
        #form1 {
            text-align: center;
        }
    </style>
  
   
</head>
<body >
<script type="text/javascript">
    function myMap() {
        var a = document.getElementById('<%= TextBox5.ClientID %>').value;
        var b = document.getElementById('<%= TextBox6.ClientID %>').value;
        var c = document.getElementById('<%= TextBox4.ClientID %>').value;

        var myCenter = new google.maps.LatLng(a, b);
        var mapCanvas = document.getElementById("dvMap");
        var mapOptions = { center: myCenter, zoom: 16 };
        var map = new google.maps.Map(mapCanvas, mapOptions);
        var marker = new google.maps.Marker({ position: myCenter });
        marker.setMap(map);

        var infowindow = new google.maps.InfoWindow({
            content: c
        });
        infowindow.open(map, marker);
        google.maps.event.addListener(marker, 'click', function () {
            var infowindow = new google.maps.InfoWindow({
                content: c
            });
            infowindow.open(map, marker);
        });
    }
</script>
   <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">

       </asp:ScriptManager>
       <div id="dvMap" 
            style="border: 2px solid #CCCCCC; margin: auto; width: 100%; height: 500px"></div>
 <script  src="https://maps.googleapis.com/maps/api/js?key=AIzaSyA7ahws4ZDxBimvHaaihnIH12BPK7ysyCM&callback=initMap"
  type="text/javascript"></script>
      


      



<script type="text/javascript">
    
     var x = document.getElementById("demo");

        function getLocation() {
            if (navigator.geolocation) {
                navigator.geolocation.getCurrentPosition(showPosition); 
                startTime();
            } else {
                x.innerHTML = "Geolocation is not supported by this browser.";
            }
        }
      
        function showPosition(position) {
            // x.innerHTML = "Latitude: " + position.coords.latitude +
            // "<br>Longitude: " + position.coords.longitude; window.location = "WebForm1.aspx";
            var latlondata = position.coords.latitude + "," + position.coords.longitude;
          
            document.getElementById('<%=TextBox1.ClientID %>').value = position.coords.latitude;
            document.getElementById('<%=TextBox2.ClientID %>').value = position.coords.longitude; 
         
          

           
                
          
          
        }
   
          
         
       


   
</script>
       
               <table align="center" >
                   <tr>
                       <td colspan="2" style="text-align: center">
       
               <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" 
            Text="Back" Width="200px" />
       
                       </td>
                   </tr>
                   <tr>
                       <td style="text-align: left;">
                           <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                               <ContentTemplate>
                                   <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1_Tick">
                                   </asp:Timer>
                               </ContentTemplate>
                           </asp:UpdatePanel>
                       </td>
                       <td style="text-align: left;">
                           &nbsp;</td>
                   </tr>
                   <tr>
                       <td style="text-align: left">
                           <asp:Label ID="Label2" runat="server" Text="Latitude"></asp:Label>
                       </td>
                       <td style="text-align: left">
                           <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                               <ContentTemplate>
                                   <asp:TextBox ID="TextBox1" runat="server" BackColor="White" Enabled="False" 
                                       ForeColor="Black" Width="128px"></asp:TextBox>
                               </ContentTemplate>
                           </asp:UpdatePanel>
                       </td>
                   </tr>
                   <tr>
                       <td style="text-align: left">
                           <asp:Label ID="Label3" runat="server" Text="Longitude"></asp:Label>
                       </td>
                       <td style="text-align: left">
                           <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                               <ContentTemplate>
                                   <asp:TextBox ID="TextBox2" runat="server" BackColor="White" Enabled="False" 
                                       ForeColor="Black" Width="128px"></asp:TextBox>
                               </ContentTemplate>
                           </asp:UpdatePanel>
                       </td>
                   </tr>
                   <tr>
                       <td style="text-align: left">
         <asp:Label ID="Label1" runat="server" Text="Update Status"></asp:Label>
                       </td>
                       <td style="text-align: left">
                   <asp:TextBox ID="TextBox3" runat="server" Width="128px"></asp:TextBox>
                       </td>
                   </tr>
                   <tr>
                       <td style="text-align: left">
                           <asp:Label ID="Label5" runat="server" Text="Password"></asp:Label>
                       </td>
                       <td style="text-align: left">
        <asp:TextBox ID="TextBox8" runat="server" TextMode="Password" Width="128px"></asp:TextBox>
                       </td>
                   </tr>
                   <tr>
                       <td style="text-align: left">
                           &nbsp;</td>
                       <td style="text-align: left">
                   <asp:Button ID="Button3" runat="server" onclick="Button3_Click1" Text="Update" 
                       Width="136px" />
         
                       </td>
                   </tr>
                   <tr>
                       <td>
                           <asp:UpdatePanel ID="UpdatePanel6" runat="server">
                               <ContentTemplate>
                                   <asp:Timer ID="Timer2" runat="server" Interval="5000" ontick="Timer2_Tick2">
                                   </asp:Timer>
                               </ContentTemplate>
                           </asp:UpdatePanel>
                       </td>
                       <td style="text-align: left">
                           <asp:UpdatePanel ID="UpdatePanel7" runat="server">
                               <ContentTemplate>
                                   <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Sign Out" 
                                       Width="136px" />
                               </ContentTemplate>
                           </asp:UpdatePanel>
                       </td>
                   </tr>
        </table>
       
               <br />
      
       <asp:UpdatePanel ID="UpdatePanel1" runat="server">
           <ContentTemplate>
             
               <asp:Panel ID="Panel1" runat="server">
                 
               </asp:Panel>
            
           </ContentTemplate>
       </asp:UpdatePanel>
                   <br />
                   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            
                   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:UpdatePanel ID="UpdatePanel2" runat="server">
       <ContentTemplate>
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <br />
           <asp:TextBox ID="TextBox4" runat="server" BackColor="White" BorderColor="White" 
               BorderStyle="None" Enabled="False" ForeColor="White"></asp:TextBox>
           <asp:TextBox ID="TextBox5" runat="server" BackColor="White" BorderColor="White" 
               BorderStyle="None" Enabled="False" ForeColor="White"></asp:TextBox>
           <asp:TextBox ID="TextBox6" runat="server" BackColor="White" BorderColor="White" 
               BorderStyle="None" Enabled="False" ForeColor="White"></asp:TextBox>
           <asp:TextBox ID="TextBox7" runat="server" BackColor="White" BorderColor="White" 
               BorderStyle="None" Enabled="False" ForeColor="White">0</asp:TextBox>
       </ContentTemplate>
   </asp:UpdatePanel>
    </form>
</body>
</html>
