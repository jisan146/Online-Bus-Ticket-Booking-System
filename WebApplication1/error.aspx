<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="error.aspx.cs" Inherits="WebApplication1.add" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Something Error</title>
</head>
<body>
    <form id="form1" runat="server">
    <h1>
    Opps! Something errors.</h1>
    <p>
        <asp:TextBox ID="TextBox1" runat="server" BackColor="White" BorderStyle="None" 
            Enabled="False" ForeColor="Black" Height="174px" TextMode="MultiLine" 
            Width="358px">Check your Network Connection.
Or,
Insert Data Correctly.
Or,
Refresh Page.
Or,
Try Again later.</asp:TextBox>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    </p>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Timer ID="Timer1" runat="server" Interval="5000" ontick="Timer1_Tick">
            </asp:Timer>
        </ContentTemplate>
    </asp:UpdatePanel>
    </form>
</body>
</html>
