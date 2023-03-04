<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="reset.aspx.cs" Inherits="WebApplication1.reset" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Reset Page</title>
    <style type="text/css">
          .style3b
        { background-color:#EFEFEF;
           
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <table style="" align="center">
            <tr>
                <td class="style3b" style="width: 150px; text-align: right">
                    <asp:Label ID="Label1" runat="server" Text="Login ID" Width="128px" 
                        BackColor="White" style="text-align: left"></asp:Label>
                </td>
                <td class="style3b" style=" width:150px; text-align:left">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3b" style="width: 150px; text-align: right">
                    <asp:Label ID="Label2" runat="server" Text="New Password" Width="128px" 
                        BackColor="White" style="text-align: left"></asp:Label>
                </td>
                <td class="style3b" style="width: 150px; text-align: left">
                    <asp:TextBox ID="TextBox2" runat="server" MaxLength="10" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3b" style="width: 150px; text-align: right">
                    <asp:Label ID="Label3" runat="server" Text="Reset Code" Width="128px" 
                        BackColor="White" style="text-align: left"></asp:Label>
                </td>
                <td class="style3b" style="width: 150px; text-align: left">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3b" colspan="2" style="text-align: center">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Reset" 
                        Enabled="False" Width="200px" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
