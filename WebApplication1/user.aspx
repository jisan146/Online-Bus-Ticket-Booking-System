<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="user.aspx.cs" Inherits="WebApplication1.pessenger" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Panel</title>
    <style type="text/css">
         .style1
        {
            background-color: #EFEFEF;
            }
    </style>
    </head>
<body>
<div id="fb-root"></div>
<script>    (function (d, s, id) {
        var js, fjs = d.getElementsByTagName(s)[0];
        if (d.getElementById(id)) return;
        js = d.createElement(s); js.id = id;
        js.src = "//connect.facebook.net/en_GB/sdk.js#xfbml=1&version=v2.8";
        fjs.parentNode.insertBefore(js, fjs);
    } (document, 'script', 'facebook-jssdk'));</script>
    <form id="form1" runat="server" >
        
   
    <table style=" " align="center" >
        <tr>
            <td style="width:200px;">
                &nbsp;</td>
            <td style="text-align: center; width:425px;">
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <asp:Timer ID="Timer1" runat="server" Interval="5000" ontick="Timer1_Tick1">
                        </asp:Timer>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
            <td style="width:200px;">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: right; background-color: #EFEFEF;" class="style1">
                <asp:Label ID="Label18" runat="server" Text="Type" style="text-align: left" 
                    Width="185px"></asp:Label>
                </td>
            <td style="text-align: center" class="style1">
                <asp:TextBox ID="TextBox10" runat="server" Enabled="False" Width="425px" 
                    BackColor="White" ForeColor="Black" Font-Bold="False"></asp:TextBox>
            </td>
            <td rowspan="8" style="text-align: center; vertical-align: middle;" 
                class="style1">
                <asp:Image ID="Image1" runat="server" 
                    Height="200px" Width="200px" BorderStyle="None"  />
                <br />
            </td>
        </tr>
        <tr>
            <td style="text-align: right; background-color: #EFEFEF;" class="style1">
                <div style="float: right; width: 185px; height: auto; top: auto; right: auto; bottom: auto; left: auto; text-align: right;">
                <asp:Label ID="Label1" runat="server" Text="ID" style="text-align: left" 
                        Width="185px"></asp:Label>
                </div>
            </td>
            <td style="text-align: center" class="style1">
    <asp:TextBox ID="TextBox1" runat="server" Enabled="False" Width="425px" BackColor="White" 
                    ForeColor="#333333"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="text-align: right; background-color: #EFEFEF;" class="style1">
                <div style="float: right; width: 185px; height: auto; top: auto; right: auto; bottom: auto; left: auto; text-align: right;">
                <asp:Label ID="Label2" runat="server" Text="Name" style="text-align: left" 
                        Width="185px"></asp:Label>
                </div>
            </td>
            <td style="text-align: center" class="style1">
                <asp:TextBox ID="TextBox2" runat="server" Enabled="False" 
                    Width="425px" BackColor="White" ForeColor="#333333"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="text-align: right; background-color: #EFEFEF;" class="style1">
                <div style="float: right; width: 185px; height: auto; top: auto; right: auto; bottom: auto; left: auto; text-align: right;">
                <asp:Label ID="Label3" runat="server" Text="Contact Number" 
                        style="text-align: left" Width="185px"></asp:Label>
                </div>
            </td>
            <td style="text-align: center" class="style1">
                <asp:TextBox ID="TextBox3" runat="server" Enabled="False" 
                    Width="425px" BackColor="White" ForeColor="#333333"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="text-align: right; background-color: #EFEFEF;" class="style1">
                <div style="float: right; width: 185px; height: auto; top: auto; right: auto; bottom: auto; left: auto; text-align: right;">
                <asp:Label ID="Label16" runat="server" Text="Emargency Contact Number" 
                        style="text-align: left" Width="185px"></asp:Label>
                </div>
            </td>
            <td style="text-align: center" class="style1">
                <asp:TextBox ID="TextBox4" runat="server" Enabled="False" 
                    Width="425px" BackColor="White" ForeColor="#333333"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="text-align: right; background-color: #EFEFEF;" class="style1">
                <div style="float: right; width: 185px; height: auto; top: auto; right: auto; bottom: auto; left: auto; text-align: right;">
                <asp:Label ID="Label5" runat="server" Text="Email" style="text-align: left" 
                        Width="185px"></asp:Label>
                </div>
            </td>
            <td style="text-align: center" class="style1">
                <asp:TextBox ID="TextBox5" runat="server" Enabled="False" 
                    Width="425px" BackColor="White" ForeColor="#333333"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="text-align: right; background-color: #EFEFEF;" class="style1">
                <div style="float: right; width: 185px; height: auto; top: auto; right: auto; bottom: auto; left: auto; text-align: right;">
                <asp:Label ID="Label6" runat="server" Text="Current Address" 
                        style="text-align: left" Width="185px"></asp:Label>
                </div>
            </td>
            <td style="text-align: center" class="style1">
                <asp:TextBox ID="TextBox6" runat="server" Enabled="False" 
                    Width="425px" BackColor="White" ForeColor="#333333"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="text-align: right; background-color: #EFEFEF;" class="style1">
                <div style="float: right; width: 185px; height: auto; top: auto; right: auto; bottom: auto; left: auto; text-align: right;">
                <asp:Label ID="Label7" runat="server" Text="Pemanent Address" 
                        style="text-align: left" Width="185px"></asp:Label>
                </div>
            </td>
            <td style="text-align: center" class="style1">
                <asp:TextBox ID="TextBox7" runat="server" Enabled="False" 
                    Width="425px" BackColor="White" ForeColor="#333333"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button3" runat="server" Text="Updat" Width="76px" 
                    Visible="False" onclick="Button3_Click" />
                <br />
                <asp:Label ID="Label8" runat="server" Text="Country" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox8" runat="server" Enabled="False" 
                    Width="10px" Visible="False"></asp:TextBox>
                <br />
                <asp:Label ID="Label9" runat="server" Text="Date of Birth" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox9" runat="server" Enabled="False" 
                    Width="10px" Visible="False"></asp:TextBox>
            </td>
            <td style="text-align: center; vertical-align: top; height: auto;">
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Sign Out" 
                    Width="100%" Visible="False" />
              
             
              
                <asp:Button ID="Button2" runat="server" Text="Setting" Width="100%"
                    onclick="Button2_Click" Visible="False" />
              
                <asp:Button ID="Button9" runat="server" onclick="Button9_Click" 
                    Text="Balance" Width="100%" Visible="False" />
              
                <asp:Button ID="Button8" runat="server" onclick="Button8_Click" 
                    Text="Tickets" Width="100%" Visible="False" />
               
                <asp:Button ID="Button4" runat="server" Text="Add Administrator" 
                    Visible="False" onclick="Button4_Click" Width="100%" />
               
                <asp:Button ID="Button5" runat="server" Text="Add Gov.Stuff" Width="100%" 
                    onclick="Button5_Click" Visible="False"/>
               
                <asp:Button ID="Button12" runat="server" onclick="Button12_Click" 
                    Text="Add Helper" Visible="False" Width="100%" />
              
                <asp:Button ID="Button13" runat="server" onclick="Button13_Click" 
                    Text="Add Counter Stuff" Visible="False" Width="100%" />
               
                <asp:Button ID="Button14" runat="server" onclick="Button14_Click" 
                    Text="Add/View Time Schedule" Visible="False" Width="100%" />
                
    <asp:Button ID="Button6" runat="server" onclick="Button6_Click" Text="Need Bus Stop Point" 
                    Width="100%" Visible="False" />
               
                <asp:Button ID="Button7" runat="server" Text="Counter"
                    onclick="Button7_Click" style="text-align: center" Visible="False" 
                    Width="100%"/>
             
              
                <asp:Button ID="Button17" runat="server" onclick="Button17_Click2" 
                    Text="Control Panel" Width="100%" Visible="False" />
             
          
                <asp:Button ID="Button18" runat="server" Text="Email" Width="100%" 
                    onclick="Button18_Click1" />
             
            </td>
            <td style="text-align: center; vertical-align: top;">
                <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click" 
                    Visible="False">View Full size</asp:LinkButton>
                <br />
                <br />
                <br />
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td style="text-align: center; vertical-align: top; height: auto;" class="style1">
               <div class="fb-page" data-href="https://www.facebook.com/BusesCoaches/" data-width="425" data-height="220" data-small-header="false" data-adapt-container-width="true" data-hide-cover="false" data-show-facepile="true"><blockquote cite="https://www.facebook.com/BusesCoaches/" class="fb-xfbml-parse-ignore"><a href="https://www.facebook.com/BusesCoaches/">Buses &amp; Coaches</a></blockquote></div></td>
            <td style="text-align: center; vertical-align: top;">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td style="text-align: center" class="style1">
                <asp:Label ID="Label17" runat="server" Text="Comment Us"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox11" runat="server" Height="85px" TextMode="MultiLine" 
                    Width="425px"></asp:TextBox>
                <br />
            </td>
            <td style="text-align: center">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td style="text-align: center" class="style1">
                <asp:Button ID="Button15" runat="server" onclick="Button15_Click" 
                    Text="Submit" Visible="False" Width="128px" />
                &nbsp;
                <asp:Button ID="Button16" runat="server" onclick="Button16_Click" 
                    Text="Like Us" Visible="False" />
            </td>
            <td style="text-align: center">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td style="text-align: center">
              
                <br />
               
               <div style="border: 10px solid #EFEFEF; margin: auto; width: 435px; height: 400px; overflow: auto;">
                <asp:Repeater ID="Repeater2" runat="server" DataSourceID="SqlDataSource1" 
                    Visible="False" onitemcommand="Repeater2_ItemCommand">
                <ItemTemplate>
                <div style="margin: 5px; width: 400px; height: 227px; float: left;">
                 

                 
               <div style="margin: 5px auto 5px auto; text-align: center; overflow: auto; width: 400px; height: 27px; background-color: #EFEFEF;">
                   <asp:TextBox ID="TextBox12" runat="server" Text='<%#Eval("SL") %>' BorderStyle="NotSet" BackColor=" #EFEFEF" Enabled="False" Width="50px" ForeColor="Black" Visible="False"></asp:TextBox> <asp:Button
                       ID="Button10" runat="server" Text="Read" Width="50px" CommandName="5"/> <asp:Button ID="Button11" runat="server" CommandName="6"
                           Text="Delete" Width="50px" />
                </div>
               <div style="margin: 5px auto 5px auto; text-align: Center;  overflow: auto; width: 400px; height: 20px; background-color: #EFEFEF;">
                <%#Eval("Login_id") %>
                </div>
               
         <div style="margin: 5px auto 5px auto; text-align: justify;  overflow: auto; width: 400px; height: 140px; background-color:  #EFEFEF;">
                <%#Eval("Comment") %>
                </div>

                 <div style="margin: 5px auto 5px auto; text-align: center;  overflow: auto; width: 400px; height: 20px; background-color: #EFEFEF;">
                <%#Eval("Date") %> [<%#Eval("s") %>]
                </div>
                </div>
                </ItemTemplate>
                </asp:Repeater>
                <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1" 
                    Visible="False" onitemcommand="Repeater1_ItemCommand">
                <ItemTemplate>
                <div style="margin: 10px; width: 400px; height: 200px; ">
                 

                 
               <div style="margin: 5px auto 5px auto; text-align: center; overflow: auto; width: 400px; height: 20px; background-color: #EFEFEF;">
                <%#Eval("Name") %>
                </div>
              
         <div style="margin: 5px auto 5px auto; text-align: justify;  overflow: auto; width: 400px; height: 140px; background-color:  #EFEFEF;">
                <%#Eval("Comment") %>
                </div>

                 <div style="margin: 5px auto 5px auto; text-align: center;  overflow: auto; width: 400px; height: 20px; background-color:  #EFEFEF;">
                <%#Eval("Date") %>
                </div>
                </div>
                </ItemTemplate>
                </asp:Repeater>
               </div>
              
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:WebApplication1.Properties.Settings._ConnectionString %>" 
                    
                    SelectCommand="SELECT SL, login_id, Name, Comment, Date,s FROM Comment ORDER BY SL DESC"></asp:SqlDataSource>
            </td>
            <td style="text-align: center">
                &nbsp;</td>
        </tr>
    </table>
    </form>
</body>
</html>
