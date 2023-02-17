<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="forgott.aspx.cs" Inherits="WebApplication1.forgott" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Forgot</title>
     <style type="text/css">
        .style3
        { background-color:#EFEFEF;
            
        }
        
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table align="center" width="450px">
        <tr>
            <td colspan="2" 
                style="text-align: center; font-family: 'times New Roman', Times, serif; font-size: 18px; font-weight: bold;">
                If You Forgot your password try here</td>
        </tr>
        <tr>
            <td class="style3" style="text-align: right">
               <asp:Label ID="Label1" runat="server" Text="User ID" 
                        Width="215px" style="text-align: left"></asp:Label>
                </td>
            <td class="style3" style="text-align: left">
                    <asp:TextBox ID="TextBox1" runat="server" Width="200px" ></asp:TextBox>
               
            </td>
        </tr>
        <tr>
            <td class="style3" style="text-align: right">
              
                    <asp:Label ID="Label2" runat="server" Text="Select Media" 
                        Width="215px" style="text-align: left"></asp:Label>
            </td>
            <td class="style3" style="text-align: left">
                    <asp:CheckBox ID="CheckBox5" runat="server" Text="By Email" Width="85px" />
                    <asp:CheckBox ID="CheckBox6" runat="server" Text="By Contact No." 
                        Width="120px" />
            </td>
        </tr>
        <tr>
            <td class="style3" colspan="2" style="text-align: center">
               
                    <asp:Button ID="Button1" runat="server" Text="Send Link" 
                        OnClick="Button1_Click" Width="300px" />
            </td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: center">
               
                    &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2" 
                style="text-align: center; font-family: 'times New Roman', Times, serif; font-size: 18px; font-weight: bold;">
                If you Forgot your User ID try here</td>
        </tr>
        <tr>
            <td class="style3" style="text-align: right">
                <asp:Label ID="Label4" runat="server" 
                    Text="I am" Width="225px" style="text-align: left"></asp:Label>
            </td>
            <td class="style3">
                    <asp:DropDownList ID="DropDownList1" runat="server" 
                        DataSourceID="SqlDataSource1" DataTextField="log_type" 
                        DataValueField="log_type" Width="148px">
                    </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style3" style="text-align: right">
                <asp:Label ID="Label5" runat="server" 
                    Text="My Email" Width="225px" style="text-align: left"></asp:Label>
            </td>
            <td class="style3" style="text-align: left" >
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    <asp:CheckBox ID="CheckBox4" runat="server" Text="Try this " />
            </td>
        </tr>
        <tr>
            <td class="style3" style="text-align: right">
                <asp:Label ID="Label6" runat="server" 
                    Text="Contact Number" Width="225px" style="text-align: left"></asp:Label>
            </td>
            <td class="style3" style="text-align: left">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    <asp:CheckBox ID="CheckBox3" runat="server" Text="Try this " />
            </td>
        </tr>
        <tr>
            <td class="style3" style="text-align: right">
                <asp:Label ID="Label7" runat="server" 
                    Text="Relative's Contact Number" Width="225px" style="text-align: left"></asp:Label>
            </td>
            <td class="style3" style="text-align: left">
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    <asp:CheckBox ID="CheckBox2" runat="server" Text="Try this " />
            </td>
        </tr>
        <tr>
            <td class="style3" style="text-align: right">
                <asp:Label ID="Label3" runat="server" 
                    Text="Any Ticket number&nbsp;you remember" Width="225px" 
                    style="text-align: left"></asp:Label>
            </td>
            <td class="style3" style="text-align: left">
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    <asp:CheckBox ID="CheckBox1" runat="server" Text="Try this " />
            </td>
        </tr>
        <tr>
            <td class="style3" style="text-align: center" colspan="2">
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Find" 
                    Width="300px" />
            </td>
        </tr>
        <tr>
            <td class="style3" style="text-align: center" colspan="2">
                    <asp:Button ID="Button4" runat="server" onclick="Button4_Click1" Text="Back" 
                        Width="300px" />
            </td>
        </tr>
        <tr>
            <td colspan="2" 
                style="text-align: center; font-family: 'times New Roman', Times, serif; color: #FF0000; font-weight: bold;">
                If you forgott all. 
                Contact our administrator office</td>
        </tr>
        <tr>
            <td colspan="2" 
                style="font-family: 'times New Roman', Times, serif; font-size: 14px; font-weight: bold; text-align: center;">
                Result</td>
        </tr>
        <tr>
            <td colspan="2">
                <div style="border: 10px solid #EFEFEF; width: 450px; height: 260px; overflow: auto;">
                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <div>
                                <table align="center">
                                    <tr><td colspan="2" style="text-align: center; vertical-align: middle">
                                        <asp:Image ID="Image1" runat="server" Height="200" Width="200" ImageUrl='<%#Eval("picture") %>' /></td></tr>
                                      <tr><td>UserID</td><td><%#Eval("Pessenger_id") %></td></tr>
                                      <tr><td>Name</td><td><%#Eval("name") %></td></tr>
                                </table>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>


   <table align="center">
            <tr>
                <td>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:WebApplication1.Properties.Settings._ConnectionString %>" 
                        SelectCommand="(SELECT log_type FROM login_table where log_type!='')INTERSECT(SELECT log_type FROM login_table where log_type!='') order by log_type"></asp:SqlDataSource>
                    <asp:TextBox ID="TextBox6" runat="server" Visible="False">u drop</asp:TextBox>
                    <asp:TextBox ID="TextBox7" runat="server" Visible="False"></asp:TextBox>
                    <asp:TextBox ID="TextBox8" runat="server" Visible="False">u data</asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:GridView ID="GridView1" runat="server" Visible="False">
                    </asp:GridView>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
