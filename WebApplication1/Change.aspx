<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Change.aspx.cs" Inherits="WebApplication1.Change" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Setting</title>
    <style type="text/css">
        .style3
        { background-color:#EFEFEF;
           
        }
       
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <table  align="center" style=" width:700px">
        <tr>
            <td>
               </td>
            <td >
               </td>
            <td>
                </td>
            <td>
                </td>
        </tr>
        <tr>
            <td style="text-align: left; width:150px ">
                <asp:Label ID="Label1" runat="server" Text="ID" Visible="False"></asp:Label>
            </td>
            <td style=" text-align: left; width:225px ;">
                <asp:TextBox ID="TextBox1" runat="server" Enabled="False" 
                    Visible="False" Width="100px"></asp:TextBox>
            </td>
            <td style=" text-align: left; width:190px ;">
                &nbsp;</td>
            <td style=" text-align: center; ">
                <asp:Label ID="Label6" runat="server" Text="Type" style="text-align: right" 
                    Visible="False"></asp:Label>
            </td>
        </tr>
        <tr >
            <td style="text-align: left; height:30px" class="style3">
                <asp:Label ID="Label7" runat="server" Text="Contact Number" Width="185px"></asp:Label>
            </td>
            <td class="style3" style="text-align: left">
                <asp:TextBox ID="TextBox2" runat="server" MaxLength="10" TextMode="Number"  
                    Width="220" BackColor="White" ForeColor="Black"
                    ></asp:TextBox>
                </td>
            <td class="style3" style="text-align: center">
                Verification Code
                <asp:TextBox ID="TextBox11" runat="server" Width="67px" Enabled="False"></asp:TextBox>
            </td>
            <td class="style3" style="text-align: center; width:70px">
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Apply"  Width="67px" />
            </td>
        </tr>
        <tr>
            <td style="text-align: left" class="style3">
                <asp:Label ID="Label8" runat="server" Text="Emargency Contact Number" 
                    Width="185px"></asp:Label>
            </td>
            <td class="style3" style="text-align: left">
                <asp:TextBox ID="TextBox3" runat="server" MaxLength="10" TextMode="Number" 
                    Width="220" BackColor="White" ForeColor="Black"
                    ></asp:TextBox>
                </td>
            <td class="style3" style="text-align: center">
                Verification Code
                <asp:TextBox ID="TextBox12" runat="server" Width="67px" Enabled="False"></asp:TextBox>
            </td>
            <td class="style3" style="text-align: center">
                <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Apply"  Width="67px"/>
            </td>
        </tr>
        <tr>
            <td style="text-align: left" class="style3">
                <asp:Label ID="Label9" runat="server" Text="Email" Width="185px"></asp:Label>
            </td>
            <td class="style3" style="text-align: left">
                <asp:TextBox ID="TextBox4" runat="server" TextMode="Email" Width="220" 
                    BackColor="White" ForeColor="Black" ></asp:TextBox>
            </td>
            <td class="style3" style="text-align: center">
                Verification Code 
                <asp:TextBox ID="TextBox13" runat="server" Width="67px" Enabled="False"></asp:TextBox>
            </td>
            <td class="style3" style="text-align: center">
                <asp:Button ID="Button3" runat="server" onclick="Button3_Click" Text="Apply"  Width="67px" />
            </td>
        </tr>
        <tr>
            <td style="text-align: left" class="style3">
                <asp:Label ID="Label10" runat="server" Text="Current Address" Width="185px"></asp:Label>
            </td>
            <td class="style3" style="text-align: left">
                <asp:TextBox ID="TextBox5" runat="server" Width="220px"></asp:TextBox>
            </td>
            <td class="style3" style="text-align: left">
                <asp:Button ID="Button8" runat="server" onclick="Button8_Click" 
                    Text="Active verification Code" Width="100%" />
            </td>
            <td class="style3" style="text-align: center">
                <asp:Button ID="Button4" runat="server" onclick="Button4_Click" Text="Change"  Width="67px" />
            </td>
        </tr>
        <tr>
            <td style="text-align: left" class="style3">
                <asp:Label ID="Label11" runat="server" Text="Image" Width="185px"></asp:Label>
            </td>
            <td class="style3" style="text-align: left">
                <asp:FileUpload ID="FileUpload1" runat="server" Width="220px" />
            </td>
            <td class="style3" style="text-align: left">
                <asp:Button ID="Button9" runat="server" onclick="Button9_Click" 
                    Text="Deactive verification Code" Width="100%" />
            </td>
            <td class="style3" style="text-align: center">
                <asp:Button ID="Button5" runat="server" onclick="Button5_Click" Text="Change"  Width="67px"/>
            </td>
        </tr>
        <tr>
            <td style="text-align: left" class="style3">
                <asp:Label ID="Label12" runat="server" Text="Current password" Width="185px"></asp:Label>
            </td>
            <td class="style3" style="text-align: left">
                <asp:TextBox ID="TextBox8" runat="server" TextMode="Password" Width="220px"></asp:TextBox>
            </td>
            <td class="style3" style="text-align: left">
                &nbsp;</td>
            <td class="style3" style="text-align: center">
                <asp:Button ID="Button7" runat="server" Text="Change"  Width="67px" 
                    onclick="Button7_Click"/>
            </td>
        </tr>
        <tr>
            <td style="text-align: left" class="style3">
                <asp:Label ID="Label13" runat="server" Text="New Password" Width="185px"></asp:Label>
            </td>
            <td class="style3" style="text-align: left">
                <asp:TextBox ID="TextBox9" runat="server" TextMode="Password" 
                    MaxLength="10" Width="220px"></asp:TextBox>
            </td>
            <td class="style3" style="text-align: left">
                &nbsp;</td>
            <td class="style3" style="text-align: center">
                <asp:Button ID="Button6" runat="server" onclick="Button6_Click" Text="Back" 
                    Width="67px" />
            </td>
        </tr>
        <tr>
            <td style="text-align: right" colspan="4">
                <div style="border: 10px solid #EFEFEF; height: 300px; overflow: auto; text-align: left; "> <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <div style=" margin: 5px;   height: 80px; overflow: auto; background-color: #EFEFEF;">
                          <%#Eval("date") %> </br>
                         
                           Device details:</br>
                           <%#Eval("des") %>   
                        </div>
                    </ItemTemplate>
                </asp:Repeater></div>
               
            </td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:TextBox ID="TextBox6" runat="server" Enabled="False" 
                    style="text-align: left" Visible="False"></asp:TextBox>
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <asp:Timer ID="Timer1" runat="server" Interval="5000" ontick="Timer1_Tick1">
                        </asp:Timer>
                    </ContentTemplate>
                </asp:UpdatePanel>
                <br />
                <asp:TextBox ID="TextBox7" runat="server" Visible="False"></asp:TextBox>
                <br />
                <asp:TextBox ID="TextBox10" runat="server" Visible="False"></asp:TextBox>
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
