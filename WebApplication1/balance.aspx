<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="balance.aspx.cs" Inherits="WebApplication1.balance" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Balance</title>
    <style type="text/css">
        .style2
        {
            background-color: #EFEFEF;
            text-align: left;
        }
        
       
        
    </style>
   
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager2" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel3" runat="server">
        <ContentTemplate>
            <asp:TextBox ID="TextBox5" runat="server" Visible="False"></asp:TextBox>
            <asp:TextBox ID="TextBox7" runat="server" Visible="False"></asp:TextBox>
        </ContentTemplate>
    </asp:UpdatePanel>
    <br />
    <br />
    <table style="width:550px" align="center">
        <tr>
            <td style=" width:275px ;text-align: right;" class="style2">
    <asp:Label ID="Label1" runat="server" Text="My ID" BackColor="White" 
                    style="text-align: left" Width="150px"></asp:Label>
            </td>
            <td style=" width:275px ;" class="style2">
                <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                    <ContentTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" BackColor="White" Enabled="False" 
                            ForeColor="Black" Width="150px"></asp:TextBox>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td class="style2" style="text-align: right">
    <asp:Label ID="Label2" runat="server" Text="Balance" BackColor="White" 
                    style="text-align: left" Width="150px"></asp:Label>
            </td>
            <td class="style2">
                <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                    <ContentTemplate>
                        <asp:TextBox ID="TextBox2" runat="server" BackColor="White" Enabled="False" 
                            ForeColor="Black" Width="150px"></asp:TextBox>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td class="style2" style="text-align: right">
    <asp:Label ID="Label3" runat="server" Text="Transfer To" BackColor="White" 
                    style="text-align: left" Width="150px"></asp:Label>
            </td>
            <td class="style2">
                <asp:UpdatePanel ID="UpdatePanel6" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                        <asp:TextBox ID="TextBox3" runat="server" BackColor="White" ForeColor="Black" 
                            Width="150px"></asp:TextBox>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td class="style2" style="text-align: right">
    <asp:Label ID="Label4" runat="server" Text="Amount" BackColor="White" 
                    style="text-align: left" Width="150px"></asp:Label>
            </td>
            <td class="style2">
                <asp:UpdatePanel ID="UpdatePanel7" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                        <asp:TextBox ID="TextBox4" runat="server" BackColor="White" ForeColor="Black" 
                            step="any" TextMode="Number" Width="150px"></asp:TextBox>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td class="style2" style="text-align: right">
    <asp:Label ID="Label5" runat="server" Text="Password" BackColor="White" 
                    style="text-align: left" Width="150px"></asp:Label>
            </td>
            <td class="style2">
                <asp:UpdatePanel ID="UpdatePanel8" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                        <asp:TextBox ID="TextBox6" runat="server" BackColor="White" ForeColor="Black" 
                            TextMode="Password" Width="150px"></asp:TextBox>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td class="style2" style="text-align: center" colspan="2">
                <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                    <ContentTemplate>
                        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Transfer" 
                            Width="310px" />
                        <asp:Button ID="Button5" runat="server" onclick="Button5_Click" Text="Cash Out" 
                            Visible="False" Width="310px" />
                        <asp:Label ID="Label9" runat="server" Text="10" Visible="False"></asp:Label>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td class="style2" style="text-align: right">
    <asp:Label ID="Label6" runat="server" Text="Date" BackColor="White" 
                    style="text-align: left" Width="150px"></asp:Label>
            </td>
            <td class="style2">
    <asp:TextBox ID="TextBox10" runat="server" Width="150px" BackColor="White" 
                    ForeColor="Black"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2" style="text-align: right">
    <asp:Label ID="Label7" runat="server" Text="Total Transfer" BackColor="White" 
                    style="text-align: left" Width="150px"></asp:Label>
            </td>
            <td class="style2">
    <asp:TextBox ID="TextBox8" runat="server" Enabled="False" Width="150px" BackColor="White" 
                    ForeColor="Black"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2" style="text-align: right">
    <asp:Label ID="Label8" runat="server" Text="Total Received" BackColor="White" 
                    style="text-align: left" Width="150px"></asp:Label>
            </td>
            <td class="style2">
    <asp:TextBox ID="TextBox9" runat="server" Enabled="False" Width="150px" BackColor="White" 
                    ForeColor="Black"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2" colspan="2" style="text-align: center">
    <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Search" 
                    Width="310px" />
            </td>
        </tr>
        <tr>
            <td class="style2" colspan="2" style="text-align: center">
     
                <asp:Button ID="Button3" runat="server" Text="Refresh" onclick="Button3_Click" 
                    Width="310px" />     
          
            </td>
        </tr>
        <tr>
            <td class="style2" colspan="2" style="text-align: center">
     
                <asp:UpdatePanel ID="UpdatePanel9" runat="server">
                    <ContentTemplate>
                        <asp:Button ID="Button6" runat="server" Text="Active Balance Transfer Time" 
                            onclick="Button6_Click" Width="310px" />
                    </ContentTemplate>
                </asp:UpdatePanel>
          
            </td>
        </tr>
        <tr>
            <td class="style2" colspan="2" style="text-align: center">
     
                <asp:UpdatePanel ID="UpdatePanel10" runat="server">
                    <ContentTemplate>
                        <asp:Button ID="Button7" runat="server" Text="Deactive Balance Transfer Time" 
                            onclick="Button7_Click" Width="310px" />
                    </ContentTemplate>
                </asp:UpdatePanel>
          
            </td>
        </tr>
        <tr>
            <td colspan="2" class="style2" style="text-align: center">
                <asp:Button ID="Button4" runat="server" onclick="Button4_Click" Text="Back" 
                    Width="310px" />
            </td>
        </tr>
        <tr>
            <td colspan="2" class="style2" style="text-align: center">
     
                Receive Balance</td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: center">
     
     <div style="  border: 10px solid #EFEFEF; margin: auto; height:150px; width:550px; overflow:auto; float: none; vertical-align: top; text-align: left; ">
                 <asp:Repeater ID="Repeater1" runat="server">
                     <ItemTemplate>
                         <div style="  margin: 1px auto 1px auto; width: 533px; height: 24px; ">

                             <div style="margin: 1px; text-align: left; background-color: #EFEFEF; float: left; width: 90px; height: 22px; vertical-align: middle">Transfer By:</div>
                             <div style="margin: 1px; text-align: left; background-color: #EFEFEF; float: left; width: 100px; height: 22px; vertical-align: middle"><%#Eval("Transfer_By") %></div>
                             <div style="margin: 1px; text-align: left; background-color: #EFEFEF; float: left; width: 80px; height: 22px; vertical-align: middle">Ammount:</div>
                              <div style="margin: 1px; text-align: left; background-color: #EFEFEF; float: left; width: 100px; height: 22px; vertical-align: middle"><%#Eval("Taka") %></div>
                             <div style="margin: 1px; text-align: left; background-color: #EFEFEF; float: left; width: 50px; height: 22px; vertical-align: middle">Date:</div>
                             <div style="margin: 1px; text-align: left; background-color: #EFEFEF; float: left; width: 100px; height: 22px; vertical-align: middle"><%#Eval("Date") %></div>


                         </div>
                     </ItemTemplate>
                 </asp:Repeater>
    </div>
              
            </td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: center" class="style2">
     
                Transfer Balance</td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: center">
     
     <div style="  border: 10px solid #EFEFEF; margin: auto; height:150px; width:550px; overflow:auto; float: none; vertical-align: top; text-align: left; ">
                 <asp:Repeater ID="Repeater2" runat="server">
                     <ItemTemplate>
                         <div style="  margin: 1px auto 1px auto; width: 533px; height: 24px;">

                             <div style="margin: 1px; text-align: left; background-color: #EFEFEF; float: left; width: 90px; height: 22px; vertical-align: middle">Transfer To:</div>
                             <div style="margin: 1px; text-align: left; background-color: #EFEFEF; float: left; width: 100px; height: 22px; vertical-align: middle"><%#Eval("Transfer_To") %></div>
                             <div style="margin: 1px; text-align: left; background-color: #EFEFEF; float: left; width: 80px; height: 22px; vertical-align: middle">Ammount:</div>
                              <div style="margin: 1px; text-align: left; background-color: #EFEFEF; float: left; width: 100px; height: 22px; vertical-align: middle"><%#Eval("Taka") %></div>
                             <div style="margin: 1px; text-align: left; background-color: #EFEFEF; float: left; width: 50px; height: 22px; vertical-align: middle">Date:</div>
                             <div style="margin: 1px; text-align: left; background-color: #EFEFEF; float: left; width: 100px; height: 22px; vertical-align: middle"><%#Eval("Date") %></div>


                         </div>
                     </ItemTemplate>
                 </asp:Repeater>
    </div>
              
            </td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: center">
     
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <asp:Timer ID="Timer1" runat="server" Enabled="False" Interval="10" 
                            ontick="Timer1_Tick">
                        </asp:Timer>
                        <asp:Timer ID="Timer2" runat="server" Enabled="False" Interval="1000" 
                            ontick="Timer2_Tick">
                        </asp:Timer>
                        <asp:Timer ID="Timer3" runat="server" Enabled="False" Interval="1000" 
                            ontick="Timer3_Tick">
                        </asp:Timer>
                        <asp:Timer ID="Timer4" runat="server" Interval="5000" ontick="Timer4_Tick1">
                        </asp:Timer>
                    </ContentTemplate>
                </asp:UpdatePanel>
              
            </td>
        </tr>
    </table>
    <br />
    </form>
</body>
</html>
