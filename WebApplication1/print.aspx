<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="print.aspx.cs" Inherits="WebApplication1.print" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ticket Print</title>
    <style type="text/css">
         .style33
        { background-color:#EFEFEF;
           
        }
        .auto-style1 {
            text-align: left;
        }
        .auto-style3 {
            height: 120px;
            text-align: center;
        }
    </style>
    <script type="text/javascript">
        function printing() {
            window.print();


        }
</script>
</head>
<body>
    <form id="form1" runat="server">
    <table align="center" >
        <tr>
            <td style="" class="style33">Ticket No</td>
            <td style="" class="style33">
                <asp:TextBox ID="TextBox1" runat="server" BackColor="White" BorderStyle="None" 
                    Enabled="False" ForeColor="Black"></asp:TextBox>
            </td>
           
        </tr>
        <tr>
            <td style="" class="style33">Bus ID</td>
            <td style="" class="style33">
                <asp:TextBox ID="TextBox5" runat="server" BackColor="White" BorderStyle="None" 
                    Enabled="False" ForeColor="Black"></asp:TextBox>
            </td>
           
        </tr>
        <tr>
            <td class="style33" style="">Ticket Type</td>
            <td style="" class="style33">
                <asp:TextBox ID="TextBox2" runat="server" BackColor="White" BorderStyle="None" 
                    Enabled="False" ForeColor="Black"></asp:TextBox>
            </td>
           
        </tr>
        <tr>
            <td class="style33" style="">Travel Date</td>
            <td style="" class="style33">
                <asp:TextBox ID="TextBox3" runat="server" BackColor="White" BorderStyle="None" 
                    Enabled="False" ForeColor="Black"></asp:TextBox>
            </td>
           
        </tr>
        <tr>
            <td class="style33" style="">Journey Time</td>
            <td style="" class="style33">
                <asp:TextBox ID="TextBox4" runat="server" BackColor="White" BorderStyle="None" 
                    Enabled="False" ForeColor="Black"></asp:TextBox>
            </td>
           
        </tr>
        <tr>
            <td class="style33" style="">From</td>
            <td style="" class="style33">
                <asp:TextBox ID="TextBox6" runat="server" BackColor="White" BorderStyle="None" 
                    Enabled="False" ForeColor="Black"></asp:TextBox>
            </td>
           
        </tr>
        <tr>
            <td class="style33" style="">To</td>
            <td style="" class="style33">
                <asp:TextBox ID="TextBox7" runat="server" BackColor="White" BorderStyle="None" 
                    Enabled="False" ForeColor="Black"></asp:TextBox>
            </td>
          
        </tr>
        <tr>
            <td class="style33" style="">Taka</td>
            <td style="" class="style33">
                <asp:TextBox ID="TextBox8" runat="server" BackColor="White" BorderStyle="None" 
                    Enabled="False" ForeColor="Black"></asp:TextBox>
            </td>
          
        </tr>
        <tr>
            <td class="auto-style3" colspan="2" style="border: 1px solid #999999">Safety integrity level</td>
          
        </tr>
        </table>
        <asp:GridView ID="GridView1" runat="server" Visible="False">
        </asp:GridView>
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Timer ID="Timer1" runat="server" Interval="5000" ontick="Timer1_Tick1">
            </asp:Timer>
        </ContentTemplate>
    </asp:UpdatePanel>
    </form>
</body>
</html>
