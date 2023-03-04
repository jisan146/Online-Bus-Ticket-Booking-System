<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Myimage.aspx.cs" Inherits="WebApplication1.Myimage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Full Size Image</title>
     <style type="text/css">
        .style1
        { margin:auto;
            width: 98vw;
            height: 98vh;
        }
          .style2
        {margin:auto;
             width: 100vh;
            height: 47vw;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <asp:Panel ID="Panel1" runat="server">
    <asp:Image ID="Image1" runat="server"  Width="100%" Height="100%"/>
    </asp:Panel>
    <asp:TextBox ID="TextBox1" runat="server" Visible="False"></asp:TextBox><asp:TextBox ID="TextBox2"
        runat="server" Visible="False"></asp:TextBox>
                
            
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Timer ID="Timer1" runat="server" Interval="5000" ontick="Timer1_Tick">
            </asp:Timer>
        </ContentTemplate>
    </asp:UpdatePanel>
                
            
    </form>
</body>
</html>
