<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="email.aspx.cs" Inherits="WebApplication1.email" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Email</title>
     <style type="text/css">
          .style3b
        { background-color:#EFEFEF;
           
        }
         .style4
         {
             text-align: center;
         }
        </style>
</head>
<body>
    <form id="form1" runat="server">
     <asp:ScriptManager ID="ScriptManager1" runat="server">
                        </asp:ScriptManager>
    <table style="width:800px;" align="center">
        <tr>
            <td style="width:400px; text-align: right;">
                &nbsp;</td>
            <td style="width:400px; text-align: left;">
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <asp:TextBox ID="TextBox4" runat="server" 
    TextMode="Email" Visible="False" Width="210px"></asp:TextBox>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td style="text-align: right; width: 400px;" class="style3b">
                <asp:Label ID="Label2" runat="server" Text="Receiver ID" Width="210px" 
                    BackColor="White"></asp:Label>
            </td>
            <td style="text-align: left; width: 400px" class="style3b">
                
                        <asp:TextBox ID="TextBox2" runat="server" Width="210px" BackColor="White" 
                            ForeColor="Black"></asp:TextBox>
                  
                        
                                <asp:TextBox ID="TextBox5" runat="server" TextMode="Email" Visible="False" 
                                    Width="210px"></asp:TextBox>
                          
                  
            </td>
        </tr>
        <tr>
            <td style="text-align: right; width: 400px; vertical-align: top;" 
                class="style3b">
                <asp:Label ID="Label3" runat="server" Text="Message" Width="210px" 
                    BackColor="White" Height="168px"></asp:Label>
            </td>
            <td style="text-align: left; width: 400px" class="style3b">
               
                        <asp:TextBox ID="TextBox3" runat="server" Height="164px" TextMode="MultiLine" 
                            Width="210px"></asp:TextBox>
                    
            </td>
        </tr>
        <tr>
            <td style="text-align: right; width: 400px; vertical-align: top;" 
                class="style3b">
                <asp:Label ID="Label4" runat="server" Text="Send By" Width="210px" 
                    BackColor="White"></asp:Label>
            </td>
            <td style="text-align: left; width: 400px" class="style3b">
              
                        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Internal" 
                            Width="70px" />
                        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="External" 
                            Width="70px" />
                  
                        <asp:Button ID="Button4" runat="server" onclick="Button4_Click" Text="Back" 
                            Width="70px" />
                  
            </td>
        </tr>
        <tr>
            <td style="vertical-align: top; font-family: 'times New Roman', Times, serif; font-size: 16px; font-weight: bold;" 
                class="style4" colspan="2">
                Inbox</td>
        </tr>
        <tr>
            <td style="text-align: right; vertical-align: top;" colspan="2">
                <div style="width: 800px; height: 300px; border: 10px solid #EFEFEF; overflow: auto;">
               
                    <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                        <ContentTemplate>
                            <asp:Repeater ID="Repeater1" runat="server" 
                                onitemcommand="Repeater1_ItemCommand">
                                <ItemTemplate>
                                    <div style="  margin:5px 5px 5px 30px; width: 750px; height: 100px; float: none;">
                                        <div style="margin: 1px; text-align: left; float: left; width: 70px; height: 100px; vertical-align: middle">
                                            <asp:Button ID="Button3" runat="server" Text='<%#Eval("st") %>'  CausesValidation="True" 
                                                            CommandName="5"  UseSubmitBehavior="False" Width="100%"  
                                 Height="100%" BorderStyle="NotSet" />
                                            <asp:TextBox
                             ID="TextBox1" runat="server" Text='<%#Eval("sl") %>' Width="5" Visible="False"></asp:TextBox>
                                        </div>
                                        <div style="margin: 1px; text-align: left; background-color: #EFEFEF; float: left; width: 50px; height: 100px; vertical-align: middle">
                                            Sender:</div>
                                        <div style="margin: 1px; text-align: left; background-color: #EFEFEF; float: left; width: 100px; height: 100px; vertical-align: middle">
                                            <%#Eval("s") %>
                                        </div>
                                        <div style="margin: 1px; text-align: left; background-color: #EFEFEF; float: left; width: 60px; height: 100px; vertical-align: middle">
                                            Message:</div>
                                        <div style="margin: 1px; text-align: left; background-color: #EFEFEF; float: left; width: 250px; height: 100px; vertical-align: middle; overflow: auto;">
                                            <%#Eval("i") %>
                                        </div>
                                        <div style="margin: 1px; text-align: left; background-color: #EFEFEF; float: left; width: 35px; height: 100px; vertical-align: middle">
                                            Date:</div>
                                        <div style="margin: 1px; text-align: left; background-color: #EFEFEF; float: left; width: 150px; height: 100px; vertical-align: middle; ">
                                            <%#Eval("d") %>
                                        </div>
                                    </div>
                                </ItemTemplate>
                            </asp:Repeater>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
            </td>
        </tr>
        <tr>
            <td style="text-align: center; vertical-align: top; font-family: 'times New Roman', Times, serif; font-size: 16px; font-weight: bold;" 
                colspan="2">
                Send Item</td>
        </tr>
        <tr>
            <td  colspan="2">
                 <div style="width: 800px; height: 300px; border: 10px solid #EFEFEF; overflow: auto;">
               
                     <asp:UpdatePanel ID="UpdatePanel6" runat="server">
                         <ContentTemplate>
                             <asp:Repeater ID="Repeater3" runat="server">
                                 <ItemTemplate>
                                     <div style="  margin:5px 5px 5px 15px; width: 750px; height: 100px; float: none;">
                                         <div style="margin: 1px; text-align: center; background-color: #EFEFEF; float: left; width: 80px; height: 100px; vertical-align: middle; overflow: auto;">
                                             <%#Eval("st") %>
                                         </div>
                                         <div style="margin: 1px; text-align: left; background-color: #EFEFEF; float: left; width: 60px; height: 100px; vertical-align: middle">
                                             Receiver:</div>
                                         <div style="margin: 1px; text-align: left; background-color: #EFEFEF; float: left; width: 100px; height: 100px; vertical-align: middle">
                                             <%#Eval("r") %>
                                         </div>
                                         <div style="margin: 1px; text-align: left; background-color: #EFEFEF; float: left; width: 60px; height: 100px; vertical-align: middle">
                                             Message:</div>
                                         <div style="margin: 1px; text-align: left; background-color: #EFEFEF; float: left; width: 250px; height: 100px; vertical-align: middle; overflow: auto;">
                                             <%#Eval("i") %>
                                         </div>
                                         <div style="margin: 1px; text-align: left; background-color: #EFEFEF; float: left; width: 35px; height: 100px; vertical-align: middle">
                                             Date:</div>
                                         <div style="margin: 1px; text-align: left; background-color: #EFEFEF; float: left; width: 150px; height: 100px; vertical-align: middle; ">
                                             <%#Eval("d") %>
                                         </div>
                                     </div>
                                 </ItemTemplate>
                             </asp:Repeater>
                         </ContentTemplate>
                     </asp:UpdatePanel>
                 </div></td>
        </tr>
        <tr>
            <td style="text-align: right; width: 400px; vertical-align: top;">
                <asp:UpdatePanel ID="UpdatePanel8" runat="server">
                </asp:UpdatePanel>
            </td>
            <td style="text-align: left; width: 400px">
                <asp:UpdatePanel ID="UpdatePanel7" runat="server">
                    <ContentTemplate>
                        <asp:Timer ID="Timer2" runat="server" Interval="5000" ontick="Timer2_Tick1">
                        </asp:Timer>
                        <asp:Timer ID="Timer1" runat="server" Interval="1000" ontick="Timer1_Tick">
                        </asp:Timer>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
