<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebApplication1.Home" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
   
<head runat="server">
    <title>Home</title>
   
     
    <style type="text/css">
        .style1
        {
            text-align: center;
        }
    </style>
   
     
    </head>
<body>
   

   
    <div style=" margin-bottom: auto; margin-top: auto;  margin-top:10px">
     <form id="form1" runat="server" style="">
          <asp:ScriptManager ID="ScriptManager1" runat="server">
                        </asp:ScriptManager>
    <table align="center" style=" width:800px" >
        <tr >
            <td style="  background-color: #EFEFEF;text-align: center; font-family: 'times New Roman', Times, serif; font-size: 24px; font-weight: bold; font-style: normal;" 
                colspan="3">
                Welcome 
                To 
                Our Online Bus counter<br />
            </td>
        </tr>
        <tr >
            <td style="text-align: center; background-color: #EFEFEF" colspan="3">
                &nbsp;&nbsp;&nbsp;<strong>Now 
                Time is our.</strong></td>
        </tr>
        <tr>
            <td style="text-align: center; vertical-align: top; background-color: #EFEFEF;" rowspan="14">
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                       
                        
                        <asp:Image ID="Image1" runat="server" Height="400px" Width="100%" 
                            ImageUrl="~/image/1.jpg"  />
                           
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
            <td style="  height:25px;text-align: center; background-color: #EFEFEF; " 
                colspan="2">
                No more waiting for bus</td>
        </tr>
        <tr>
            <td style="  height:25px;background-color: #EFEFEF; " class="style1" 
                colspan="2">
                No More wasting Time</td>
        </tr>
        <tr>
            <td style="  height:25px;background-color: #EFEFEF; " class="style1" 
                colspan="2">
                No more fight for bus</td>
        </tr>
        <tr>
            <td style="  height:25px;text-align: center; background-color: #EFEFEF; " 
                colspan="2">
                No more create Traffic Jam</td>
        </tr>
        <tr>
            <td style="  height:25px;text-align: center; background-color: #EFEFEF; " 
                colspan="2">
                No more travel on bus with risk</td>
        </tr>
        <tr>
            <td style="  height:25px;text-align: center; background-color: #EFEFEF; font-size: 15px;" 
                colspan="2">
                Help Govt. to make Digital Bangladesh</td>
        </tr>
        <tr>
            <td style="  height:25px;text-align: center; background-color: #EFEFEF; " 
                colspan="2">
                Be Digital Make Digital </td>
        </tr>
        <tr>
            <td style="  height:25px;text-align: center; font-family: 'times New Roman', Times, serif; font-size: 16px; font-weight: bold;" 
                colspan="2">
                Login Panel</td>
        </tr>
        <tr>
            <td style="  height:25px;text-align: right; background-color: #EFEFEF; width:110px">
                <asp:Label ID="Label1" runat="server" Text="User ID" 
                    Width="115px" style="text-align: left"></asp:Label>
            </td>
            <td style="text-align: left;background-color: #EFEFEF ; width:130px">
                <asp:TextBox ID="TextBox2" runat="server" Width="96%" 
                                   ></asp:TextBox>
            </td>
        </tr>
        <tr >
            <td style="height:25px ;text-align: right;background-color: #EFEFEF; ">
                <asp:Label ID="Label2" runat="server" Text="Password" 
                    Width="115px" style="text-align: left"></asp:Label>
            </td>
            <td style="text-align: left;background-color: #EFEFEF; ">
                <asp:TextBox ID="TextBox3" runat="server"  TextMode="Password" Width="96%"></asp:TextBox>
            </td>
        </tr>
        <tr >
            <td style="height:25px ;text-align: right;background-color: #EFEFEF; ">
                <asp:Label ID="Label3" runat="server" 
                    Text="Verification Code" Width="115px" style="text-align: left"></asp:Label>
            </td>
            <td style="text-align: left;background-color: #EFEFEF; ">
                <asp:TextBox ID="TextBox4" runat="server" Enabled="False" Width="96%"></asp:TextBox>
            </td>
        </tr>
        <tr >
            <td style="height:25px ;text-align: center;background-color: #EFEFEF; " colspan="2">
                <asp:Button ID="Button1" runat="server" Text="Login" Width="100%" 
                                onclick="Button1_Click"  />
            </td>
        </tr>
        <tr >
            <td style="height:25px ;text-align: center;background-color: #EFEFEF; " colspan="2">
                <asp:Button ID="Button2" runat="server" Text="Register" Width="100%" 
                                onclick="Button2_Click" />
            </td>
        </tr>
        <tr >
            <td style="height:25px ;text-align: center; background-color: #EFEFEF;" colspan="2">
                <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Forgott?</asp:LinkButton>
            </td>
        </tr>
        <tr >
            <td style="text-align: center; background-color: #EFEFEF" colspan="3">
                @Copyright Jisan Rahman 2016.All rights reserved.<br />
                Contact us by Email: <a href="mailto:jisan146@gmail.com">jisan146@gmail.com</a> 
                Or Moble No: +880 1687602005</td>
        </tr>
        </table>
    <asp:TextBox ID="TextBox13" runat="server" BackColor="White" BorderStyle="None" 
         Enabled="False" ForeColor="Black" style="text-align: center" 
         TextMode="MultiLine" Width="100px" Font-Names="Times New Roman" Visible="False"></asp:TextBox>
             <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                 <ContentTemplate>
                     <asp:TextBox ID="TextBox1" runat="server" Visible="False">0</asp:TextBox>
                     <asp:Timer ID="Timer1" runat="server" Interval="2000" ontick="Timer1_Tick">
                     </asp:Timer>
                 </ContentTemplate>
          </asp:UpdatePanel>
    </form>
    </div>
    </body>
</html>
