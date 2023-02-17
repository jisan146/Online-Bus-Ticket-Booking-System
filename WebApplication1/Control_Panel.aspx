<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Control_Panel.aspx.cs" Inherits="WebApplication1.Control_Panel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Control Panel</title>
    <style type="text/css">
         .style3b
        { background-color:#EFEFEF;
           
        }
        .style1
        {
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:800px;" align="center">
            <tr>
                <td class="style3b" style="text-align: right; width:400px">
                    <asp:Label ID="Label1" runat="server" Text="User ID" BackColor="White" 
                        Width="128px" style="text-align: left"></asp:Label>
                </td>
                <td class="style3b" style="text-align: left; width:400px">
    
        <asp:TextBox ID="TextBox1" runat="server" Width="120px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3b" style="text-align: center" colspan="2">
        <asp:Button ID="Button1" runat="server" Text="Close" OnClick="Button1_Click" 
                        Width="128px" />
       
                    <asp:Button ID="Button2" runat="server" Text="Re Open" 
                        onclick="Button2_Click" Width="128px" />
       
                </td>
            </tr>
            <tr>
                <td class="style3b" style="text-align: center" colspan="2">
                    <asp:Button ID="Button3" runat="server" Text="Details" OnClick="Button3_Click" 
                        Width="128px" />
                    <asp:Button ID="Button5" runat="server" Text="Ticket" OnClick="Button5_Click" 
                        Width="128px" />
                </td>
            </tr>
            <tr>
                <td class="style3b" style="text-align: center" colspan="2">
                    <asp:Label ID="Label8" runat="server" Text="Date" BackColor="White" 
                        Width="128px" style="text-align: left"></asp:Label>
        <asp:TextBox ID="TextBox13" runat="server" Width="120px">all</asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3b" style="text-align: center" colspan="2">
                    <asp:Button ID="Button10" runat="server" Text="Login Histiory" 
                        OnClick="Button10_Click" Width="260px" />
                </td>
            </tr>
            <tr>
                <td class="style3b" style="text-align: center" colspan="2">
                    <asp:Button ID="Button9" runat="server" Text="View Paassword" 
                        OnClick="Button9_Click" Visible="False" Width="260px" />
                </td>
            </tr>
            <tr>
                <td class="style3b" style="text-align: right">
                    <asp:Label ID="Label2" runat="server" Text="Date" BackColor="White" 
                        Width="128px" style="text-align: left"></asp:Label>
                </td>
                <td class="style3b">
        <asp:TextBox ID="TextBox9" runat="server" Width="120px">all</asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3b" style="text-align: right">
                    <asp:Label ID="Label6" runat="server" Text="Total Received" BackColor="White" 
                        Width="128px" style="text-align: left"></asp:Label>
                </td>
                <td class="style3b">
        <asp:TextBox ID="TextBox11" runat="server" Width="120px" BackColor="White" 
                        ForeColor="Black"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3b" style="text-align: right">
                    <asp:Label ID="Label7" runat="server" Text="Total Transfer" BackColor="White" 
                        Width="128px" style="text-align: left"></asp:Label>
                </td>
                <td class="style3b">
        <asp:TextBox ID="TextBox12" runat="server" Width="120px" BackColor="White" 
                        ForeColor="Black"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3b" style="text-align: center" colspan="2">
        <asp:Button ID="Button4" runat="server" Text="Balance" OnClick="Button4_Click" 
                        Width="260px" />
                </td>
            </tr>
            <tr>
                <td class="style3b" style="text-align: center" colspan="2">
        <asp:Button ID="Button15" runat="server" Text="Account Histroy" OnClick="Button15_Click" 
                        Width="260px" />
                </td>
            </tr>
            <tr>
                <td class="style3b" style="text-align: right">
                    <asp:Label ID="Label3" runat="server" Text="Owner" BackColor="White" 
                        Width="128px" style="text-align: left"></asp:Label>
                </td>
                <td class="style3b">
                    <asp:TextBox ID="TextBox2" runat="server" Width="120px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3b" style="text-align: center" colspan="2">
        <asp:Button ID="Button7" runat="server" Text="All stuff" OnClick="Button7_Click" 
                        Width="260px" />
                </td>
            </tr>
            <tr>
                <td class="style3b" style="text-align: center" colspan="2">
                    <asp:Button ID="Button17" runat="server" onclick="Button17_Click" 
                        Text="All bus" Width="260px" />
                </td>
            </tr>
            <tr>
                <td class="style3b" style="text-align: right">
                    <asp:Label ID="Label4" runat="server" Text="Bus ID/Ticket No" BackColor="White" 
                        Width="128px" style="text-align: left"></asp:Label>
                </td>
                <td class="style3b">
        <asp:TextBox ID="TextBox3" runat="server" Width="120px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3b" style="text-align: right">
                    <asp:Label ID="Label5" runat="server" 
                        Text="Travel Date" BackColor="White" Width="128px" 
                        style="text-align: left"></asp:Label>
                </td>
                <td class="style3b">
                    <asp:TextBox ID="TextBox10" runat="server" Width="120px">all</asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3b" style="text-align: center" colspan="2">
                    <asp:Button ID="Button8" runat="server" Text="Search" OnClick="Button8_Click" 
                        Width="128px" />
    
        <asp:Button ID="Button14" runat="server" OnClick="Button14_Click" Text="Time" 
                        Width="128px" />
                   
    
                </td>
            </tr>
            <tr>
                <td class="style3b" style="text-align: center" colspan="2">
    
        <asp:Button ID="Button11" runat="server" OnClick="Button11_Click" Text="Ticket NO" 
                        Width="260px" />
    
                </td>
            </tr>
            <tr>
                <td class="style3b" style="text-align: center" colspan="2">
    
                    <asp:Label ID="Label9" runat="server" Text="Bus ID" BackColor="White" 
                        Width="128px" style="text-align: left"></asp:Label>
        <asp:TextBox ID="TextBox14" runat="server" Width="120px"></asp:TextBox>
    
                </td>
            </tr>
            <tr>
                <td class="style3b" style="text-align: center" colspan="2">
    
                    <asp:Label ID="Label10" runat="server" 
                        Text="Accident Time &amp;tt" BackColor="White" Width="128px" 
                        style="text-align: left"></asp:Label>
                    <asp:TextBox ID="TextBox15" runat="server" Width="55px">NULL</asp:TextBox>
                    <asp:TextBox ID="TextBox16" runat="server" Width="55px">NULL</asp:TextBox>
    
                </td>
            </tr>
            <tr>
                <td class="style3b" style="text-align: center" colspan="2">
        <asp:Button ID="Button12" runat="server" OnClick="Button12_Click" Text="Emargency" 
                        Width="260px" />
    
                </td>
            </tr>
            <tr>
                <td class="style3b" style="text-align: center" colspan="2">
                    <asp:Button ID="Button18" runat="server" onclick="Button18_Click" 
                        Text="See all Deactive GPS" Width="260px" />
    
                </td>
            </tr>
            <tr>
                <td class="style3b" style="text-align: center" colspan="2">
        <asp:Button ID="Button13" runat="server" OnClick="Button13_Click" Text="Back" 
                        Width="260px" />
    
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <div style="margin: auto; width: 800px; height: 333px; border: 10px solid #EFEFEF; overflow: auto; text-align: center;">
                        <div class="style1">
        <asp:GridView ID="GridView1" runat="server" Width="100%">
        </asp:GridView>
                        </div>
                        <div class="style1">
        <asp:GridView ID="GridView2" runat="server" Visible="False" Width="100%">
            <Columns>
                <asp:ImageField DataImageUrlField="picture" HeaderText="Image">
                    <ControlStyle Height="200px" Width="200px" />
                </asp:ImageField>
            </Columns>
        </asp:GridView>
                        </div>
                    </div>
                </td>
            </tr>
        </table>
        <br />
        <br />
        <br />
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:Timer ID="Timer1" runat="server" Enabled="False" Interval="2000" 
            ontick="Timer1_Tick1">
        </asp:Timer>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Timer ID="Timer2" runat="server" Interval="5000" ontick="Timer2_Tick">
                </asp:Timer>
            </ContentTemplate>
        </asp:UpdatePanel>
        <br />
        <br />
        <br />
        <br />
        &nbsp;&nbsp;</div>
    </form>
</body>
</html>
