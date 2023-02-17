<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebApplication1.Register" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration Page</title>
    <style type="text/css">
          .style3b
        { background-color:#EFEFEF;
            text-align: center;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <table align="center">
        <tr>
            <td >
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
            </td>
            <td >
                &nbsp;</td>
            <td >
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3b" colspan="3" >
                <strong>Any Filed Can&#39;t be empty.I</strong><span style="text-align: justify"><strong>nsert 
                Contact number(+880) and&nbsp; Emargency Contact Number(+880)&nbsp; with 11 
                digits.These 
                Number can&#39;t same.If we can&#39;t Contact by your contact number than We use your 
                emargency Contact Number who should be your relative.</strong></span></td>
        </tr>
        <tr>
            <td class="style3b" colspan="3" style="color: #FF0000" >
                <strong>Please insert correct data.Correct data will help you any accidental moment. <br />
                ****After submit please note your login ID****</strong></td>
        </tr>
        <tr>
            <td class="style3b" style=" width:206px; text-align: right;">
                <asp:Label ID="Label2" runat="server" Text="Name" 
                    Width="185px" style="text-align: left"></asp:Label>
            </td>
            <td class="style3b" style=" text-align: center; width:206px">
                <asp:TextBox ID="TextBox2" runat="server" Width="233px" BackColor="White" 
                    ForeColor="Black"></asp:TextBox>
            </td>
            <td rowspan="9" class="style3b" style=" width:206px; text-align: left;">
                <asp:Image ID="Image1" runat="server" BorderColor="Black" BorderStyle="Double" 
                    Height="181px" Width="206px" style="text-align: left" />
                <br />
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                    Text="Attach picture (max 3 MB)"  Width="100%" />
                <br />
                <asp:FileUpload ID="FileUpload1" runat="server"  Width="190px"/>
                <br />
            </td>
        </tr>
        <tr>
            <td class="style3b" style="text-align: right; width: 206px">
                <asp:Label ID="Label3" runat="server" Text="Contact Number " 
                    Width="185px" style="text-align: left"></asp:Label>
            </td>
            <td class="style3b" style="text-align: center">
                <asp:TextBox ID="TextBox3" runat="server" Width="233px" TextMode="Number" 
                    MaxLength="10" BackColor="White" ForeColor="Black"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3b" style="text-align: right; width: 206px">
              
                <asp:Label ID="Label16" runat="server" Text="Emargency Contact Number" 
                        Width="185px" style="text-align: left"></asp:Label>
                
            </td>
            <td class="style3b" style="text-align: center">
                <asp:TextBox ID="TextBox4" runat="server" Width="233px" TextMode="Number" 
                    MaxLength="10" BackColor="White" ForeColor="Black"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3b" style="text-align: right; width: 206px">
                <asp:Label ID="Label5" runat="server" Text="Email" 
                    Width="185px" style="text-align: left"></asp:Label>
            </td>
            <td class="style3b" style="text-align: center">
                <asp:TextBox ID="TextBox5" runat="server" Width="233px" TextMode="Email" 
                    BackColor="White" ForeColor="Black"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3b" style="text-align: right; width: 206px">
                <asp:Label ID="Label6" runat="server" Text="Current Address" 
                    Width="185px" style="text-align: left"></asp:Label>
            </td>
            <td class="style3b" style="text-align: center">
                <asp:TextBox ID="TextBox6" runat="server" Width="233px" BackColor="White" 
                    ForeColor="Black"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3b" style="text-align: right; width: 206px">
                <asp:Label ID="Label7" runat="server" Text="Permanent Address" Width="185px" 
                    style="text-align: left"></asp:Label>
            </td>
            <td class="style3b" style="text-align: center">
                <asp:TextBox ID="TextBox7" runat="server" Width="233px" BackColor="White" 
                    ForeColor="Black"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3b" style="text-align: right; width: 206px">
                <asp:Label ID="Label21" runat="server" Text="Type" 
                    Width="185px" style="text-align: left"></asp:Label>
            </td>
            <td style="text-align: center" class="style3b">
                <asp:CheckBox ID="CheckBox1" runat="server" Text="Pessenger" 
                    ForeColor="Black" />
                <asp:CheckBox ID="CheckBox2" runat="server" Text="Owner" ForeColor="Black" />
            </td>
        </tr>
        <tr>
            <td class="style3b" style="text-align: right; width: 206px">
                <asp:Label ID="Label10" runat="server" Text="Password (range 6-10)" 
                    Width="185px" style="text-align: left"></asp:Label>
            </td>
            <td class="style3b" style="text-align: center">
               
                <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                        <asp:TextBox ID="TextBox10" runat="server" Enabled="False" MaxLength="10" 
                            ontextchanged="TextBox10_TextChanged" TextMode="Password" Width="233px" 
                            ForeColor="Black"></asp:TextBox>
                    </ContentTemplate>
                </asp:UpdatePanel>
                
            </td>
        </tr>
        <tr>
            <td class="style3b" style="text-align: right; width: 206px">
                <asp:Label ID="Label19" runat="server" 
                    Text="Email Vairification Code" Width="185px" style="text-align: left"></asp:Label>
            </td>
            <td style="text-align: center" class="style3b">
                <asp:TextBox ID="TextBox20" runat="server" Enabled="False" Width="233px" 
                    ForeColor="Black"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3b" style="text-align: right; width: 206px">
                <asp:Label ID="Label18" runat="server" 
                    Text="Mobile Vairification Code" Width="185px" style="text-align: left"></asp:Label>
            </td>
            <td style="text-align: center" class="style3b">
               
                <asp:TextBox ID="TextBox21" runat="server" Enabled="False" Width="233px" 
                    ForeColor="Black"></asp:TextBox>
                
            </td>
            <td class="style3b">
                </td>
        </tr>
        <tr>
            <td class="style3b" style="text-align: right; width: 206px">
                &nbsp;<asp:Label ID="Label17" runat="server" 
                    Text="Emargency Contact Number" Width="185px" style="text-align: left"></asp:Label>
            </td>
            <td style="text-align: center" class="style3b">
               
                <asp:TextBox ID="TextBox22" runat="server" Enabled="False" Width="233px" 
                    ForeColor="Black"></asp:TextBox>
                
            </td>
            <td class="style3b">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3b">
                </td>
            <td class="style3b" style="text-align: center" >
                <asp:Button ID="Button2" runat="server" Text="Apply" Width="100%" 
                    onclick="Button2_Click" />
                <asp:Button ID="Button3" runat="server" onclick="Button3_Click" Text="Back" 
                    Width="100%" Visible="False" />
                </td>
            <td class="style3b">
                </td>
        </tr>
        <tr>
            <td>
               
                <asp:TextBox ID="TextBox9" runat="server" Width="141px" Visible="False"></asp:TextBox>
                <br />
                <asp:TextBox ID="TextBox13" runat="server" Height="22px" Visible="False"></asp:TextBox>
                </td>
            <td 
                
                
                style="font-family: 'times New Roman', Times, serif; font-size: 14px; color: #FF0000; text-align: center;">
                &nbsp;</td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server"  Width="67px" Height="16px" 
                    Visible="False">
                    <asp:ListItem>pessenger</asp:ListItem>
                    <asp:ListItem>Owner</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Login_ID" Visible="False"></asp:Label>
            </td>
            <td 
                
                style="font-family: 'times New Roman', Times, serif; font-size: 14px; color: #FF0000">
                <asp:TextBox ID="TextBox1" runat="server" Width="233px" Visible="False">00</asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="TextBox14" runat="server" Visible="False"></asp:TextBox>
                <br />
                <asp:TextBox ID="TextBox12" runat="server" Visible="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label9" runat="server" Text="Date of Birth" Visible="False"></asp:Label>
               
                <asp:TextBox ID="TextBox11" runat="server" TextMode="Date"  Width="20px" Visible="False">0-0-0</asp:TextBox>
                
            </td>
            <td 
                
                style="font-family: 'times New Roman', Times, serif; font-size: 14px; color: #FF0000">
                <asp:Label ID="Label8" runat="server" Text="Country" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox8" runat="server" Width="10px" 
                    style="text-align: left" Visible="False">BD</asp:TextBox>
                        <asp:Timer ID="Timer2" runat="server" Enabled="False" Interval="500" 
                            ontick="Timer2_Tick">
                        </asp:Timer>
                </td>
            <td>
                <asp:TextBox ID="TextBox15" runat="server" Visible="False"></asp:TextBox>
                <asp:UpdatePanel ID="UpdatePanel2" runat="server">
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
