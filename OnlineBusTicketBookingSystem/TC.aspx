<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TC.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ticket checker</title>
    <style type="text/css">
          .style3b
        { background-color:#EFEFEF;
           
        }
        </style>
       </head>
<body>
    <form id="form1" runat="server">
        <table style="width:100%;">
            <tr>
                <td style="text-align: center" class="style3b">
                        <asp:Label ID="Label1" runat="server" BackColor="White" Text="Pessenger ID" 
                            Width="90px" style="text-align: left"></asp:Label>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                       
                </td>
            </tr>
            <tr>
                <td style="text-align: center" class="style3b">
                        <asp:Label ID="Label2" runat="server" BackColor="White" Text="Ticket No" 
                            Width="90px" style="text-align: left"></asp:Label>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="text-align: center" class="style3b">
                    <asp:Button ID="Button1" runat="server" Text="Search" OnClick="Button1_Click" 
                        Visible="False" Width="230px" />
                    <br />
                    <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Back" 
                        Width="233px" />
                </td>
            </tr>
            <tr>
                <td>
                <asp:Repeater ID="Repeater1" runat="server" 
                    onitemcommand="Repeater1_ItemCommand">
                   <ItemTemplate>
                   <div style="margin: auto; ">
                   <table style=" width:200px" border="1" align="center">
                   <tr><td colspan="2" style=" text-align:center">
                       <asp:Image ID="Image1" runat="server" ImageUrl='<%#Eval("picture") %>' Height="200px" Width="200px" />
                  
                       
                       </td></tr>

                      <tr><td>Ticket No</td><td><%#Eval("SL") %></td></tr>
                       <tr><td>Pessenger ID</td><td><%#Eval("pessenger_id")%></td></tr>
                     <tr><td>Bus ID</td><td><%#Eval("Bus_license_no") %></td></tr>
                        <tr><td>Travel Date</td><td><%#Eval("Travel_date") %></td></tr>
                        <tr><td>Time</td><td><%#Eval("Stop_time") %></td></tr>
                        <tr><td>Start Location</td><td><%#Eval("Start_location") %></td></tr>
                        <tr><td>End Location</td><td><%#Eval("End_location") %></td></tr>
                        <tr><td>Sit No</td><td><%#Eval("Sit_no") %></td></tr>
                        <tr><td>KM</td><td><%#Eval("KM") %></td></tr>
                        <tr><td>Taka</td><td><%#Eval("Taka") %></td></tr>
                      
                        

                        
                  
                   
                 
                  
                   </table>
                     
                       </div>
                   </ItemTemplate>
                </asp:Repeater>
                        </td>
            </tr>
            <tr>
                <td>
                    <asp:ScriptManager ID="ScriptManager1" runat="server">
                    </asp:ScriptManager>
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
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
