<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Information.aspx.cs" Inherits="WebApplication1.Information" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Information</title>
    <style type="text/css">
         .style3
        { background-color:#EFEFEF;
           
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <table  align="center" style="">
        <tr>
            <td  style="text-align: right; width:180px" class="style3">
                <asp:Label ID="Label1" runat="server" Text="Bus_License_no" BackColor="White" 
                    Width="150px" style="text-align: left"></asp:Label>
            </td>
            <td  style="text-align: left; width:180px" class="style3">
                <asp:TextBox ID="TextBox1" runat="server" Width="150px"></asp:TextBox>
            </td>
            <td  style="text-align: right; width:180px" class="style3">
                <asp:Label ID="Label14" runat="server" Text="My ID" BackColor="White" 
                    Width="150px" style="text-align: left"></asp:Label>
            </td>
            <td  style="text-align: left; width:180px" class="style3">
                <asp:TextBox ID="TextBox14" runat="server" Enabled="False" Width="150px" 
                    BackColor="White" ForeColor="Black"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3" style="text-align: right">
                <asp:Label ID="Label2" runat="server" Text="Permit No" BackColor="White" 
                    Width="150px" style="text-align: left"></asp:Label>
            </td>
            <td class="style3" style="text-align: left">
                <asp:TextBox ID="TextBox2" runat="server" Width="150px"></asp:TextBox>
            </td>
            <td class="style3" style="text-align: right">
                <asp:Label ID="Label8" runat="server" Text="Bus_License_no" BackColor="White" 
                    Width="150px" style="text-align: left"></asp:Label>
            </td>
            <td class="style3" style="text-align: left">
                <asp:TextBox ID="TextBox8" runat="server" Width="150px" Enabled="False" 
                    BackColor="White" ForeColor="Black"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3" style="text-align: right">
                <asp:Label ID="Label3" runat="server" Text="Service Name" BackColor="White" 
                    Width="150px" style="text-align: left"></asp:Label>
            </td>
            <td class="style3" style="text-align: left">
                <asp:TextBox ID="TextBox3" runat="server" Width="150px"></asp:TextBox>
            </td>
            <td class="style3" style="text-align: right">
                <asp:Label ID="Label9" runat="server" Text="Approved" BackColor="White" 
                    Width="150px" style="text-align: left"></asp:Label>
            </td>
            <td class="style3" style="text-align: left">
                <asp:TextBox ID="TextBox9" runat="server" Width="150px" Enabled="False" 
                    BackColor="White" ForeColor="Black"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3" style="text-align: right">
                <asp:Label ID="Label4" runat="server" Text="Bus_type" BackColor="White" 
                    Width="150px" style="text-align: left"></asp:Label>
            </td>
            <td class="style3" style="text-align: left">
                <asp:TextBox ID="TextBox4" runat="server" Width="150px"></asp:TextBox>
            </td>
            <td class="style3" style="text-align: right">
                <asp:Label ID="Label10" runat="server" Text="Approved Date" BackColor="White" 
                    Width="150px" style="text-align: left"></asp:Label>
            </td>
            <td class="style3" style="text-align: left">
                <asp:TextBox ID="TextBox10" runat="server" Width="150px" Enabled="False" 
                    BackColor="White" ForeColor="Black"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3" style="text-align: right">
                <asp:Label ID="Label5" runat="server" Text="Total_Sit" BackColor="White" 
                    Width="150px" style="text-align: left"></asp:Label>
            </td>
            <td class="style3" style="text-align: left">
                <asp:TextBox ID="TextBox5" runat="server" Width="150px" TextMode="Number"></asp:TextBox>
            </td>
            <td class="style3" style="text-align: right">
                <asp:Label ID="Label11" runat="server" Text="Fitness" BackColor="White" 
                    Width="150px" style="text-align: left"></asp:Label>
            </td>
            <td class="style3" style="text-align: left">
                <asp:TextBox ID="TextBox11" runat="server" Width="150px" MaxLength="1" 
                    BackColor="White" ForeColor="Black"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3" style="text-align: right">
                <asp:Label ID="Label6" runat="server" Text="Total_Stand_Capacity" 
                    BackColor="White" Width="150px" style="text-align: left"></asp:Label>
            </td>
            <td class="style3" style="text-align: left">
                <asp:TextBox ID="TextBox6" runat="server" Width="150px" TextMode="Number"></asp:TextBox>
            </td>
            <td class="style3" style="text-align: right">
                <asp:Label ID="Label12" runat="server" Text="Tex_year" BackColor="White" 
                    Width="150px" style="text-align: left"></asp:Label>
            </td>
            <td class="style3" style="text-align: left">
                <asp:TextBox ID="TextBox12" runat="server" Width="150px" TextMode="Number" 
                    BackColor="White" ForeColor="Black"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3" style="text-align: right">
                <asp:Label ID="Label15" runat="server" BackColor="White" Text="Per KM Rate" 
                    Width="150px" style="text-align: left"></asp:Label>
            </td>
            <td class="style3" style="text-align: left">
                <asp:TextBox ID="TextBox34" runat="server" TextMode="Number" step="any" 
                    Width="150px"></asp:TextBox>
            </td>
            <td class="style3" style="text-align: right">
                &nbsp;</td>
            <td class="style3" style="text-align: left">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3" style="text-align: right">
                <asp:Label ID="Label7" runat="server" Text="Owner_id" BackColor="White" 
                    Width="150px" style="text-align: left"></asp:Label>
            </td>
            <td class="style3" style="text-align: left">
                <asp:TextBox ID="TextBox7" runat="server" Width="150px"></asp:TextBox>
            </td>
            <td class="style3" style="text-align: right">
                <asp:Label ID="Label13" runat="server" Text="Tex" BackColor="White" 
                    Width="150px" style="text-align: left"></asp:Label>
                </td>
            <td class="style3" style="text-align: left">
                <asp:TextBox ID="TextBox13" runat="server" Width="150px" TextMode="Number" 
                    BackColor="White" ForeColor="Black"></asp:TextBox>
                </td>
        </tr>
        <tr>
            <td class="style3" colspan="2" style="text-align: center">
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Save" 
                    Width="200px" Enabled="False" />
            </td>
            <td class="style3" colspan="2" style="text-align: center">
                <asp:Button ID="Button2" runat="server" style="text-align: center" 
                    Text="Approved" Width="96px" Enabled="False" onclick="Button2_Click" />
&nbsp;<asp:Button ID="Button3" runat="server" style="text-align: center" 
                    Text="Cencel all" Width="96px" Enabled="False" onclick="Button3_Click" />
            </td>
        </tr>
        <tr>
            <td class="style3" colspan="2" style="text-align: center">
                <asp:Button ID="Button4" runat="server" Text="Update" Enabled="False" 
                    Width="200px" onclick="Button4_Click"/>
            </td>
            <td class="style3" colspan="2" style="text-align: center">
                <asp:Button ID="Button5" runat="server" Text="Search" Width="200px" 
                    onclick="Button5_Click"/>
            </td>
        </tr>
        <tr>
            <td class="style3" colspan="2" style="text-align: center">
                <asp:Button ID="Button6" runat="server" Text="Load" Width="200px" 
                    onclick="Button6_Click"/>
            </td>
            <td class="style3" colspan="2" style="text-align: center">
                <asp:Button ID="Button7" runat="server" Text="Back" Width="200px" 
                    onclick="Button7_Click"/>
            </td>
        </tr>
        <tr>
            <td colspan="4" 
                style="text-align: center; font-family: 'times New Roman', Times, serif; font-size: 16px; font-weight: bold;" >
                All Bus</td>
        </tr>
        <tr>
            <td colspan="4">
     
     <div style="  border: 10px solid #EFEFEF; margin: auto; height:330px; width:720px; overflow:auto; vertical-align: top; text-align: left; ">
                 <asp:Repeater ID="Repeater3" runat="server" OnItemCommand="Repeater3_ItemCommand">
                     <ItemTemplate>
                         <div style="margin: 5px; float: left">
                             <table align="center"  style=" width:340px">
                                
                                 <tr>
                                     <td colspan="2" style=" text-align:center">
                                         <asp:Button ID="Button18" runat="server" CausesValidation="True" CommandName="5" Text="Select" UseSubmitBehavior="False" Width="100%" />
                                     </td>
                                 </tr>
                                 <tr>
                                     <td style=" width:160px; background-color:#EFEFEF">Stuff ID</td>
                                     <td style=" width:180px; background-color:#EFEFEF">
                                         <asp:TextBox ID="TextBox25" runat="server" Enabled="False" Text='<%#Eval("Stuff_id") %>' BackColor="#EFEFEF" ForeColor="Black" BorderStyle="None"></asp:TextBox>
                                     </td>
                                 </tr>
                                 <tr>
                                     <td style="; background-color:#EFEFEF ">Bus License No</td>
                                     <td style="; background-color:#EFEFEF ">
                                         <asp:TextBox ID="TextBox26" runat="server" Enabled="False" Text='<%#Eval("Bus_License_no") %>' BackColor="#EFEFEF" ForeColor="Black" BorderStyle="None"></asp:TextBox>
                                     </td>
                                 </tr>
                                 <tr>
                                     <td style=" ; background-color:#EFEFEF">License</td>
                                     <td style=" ; background-color:#EFEFEF">
                                         <asp:TextBox ID="TextBox27" runat="server" Enabled="False" Text='<%#Eval("Approved") %>' BackColor="#EFEFEF" ForeColor="Black" BorderStyle="None"></asp:TextBox>
                                     </td>
                                 </tr>
                                 <tr>
                                     <td style=" ; background-color:#EFEFEF">Date</td>
                                     <td style="; background-color:#EFEFEF">
                                         <asp:TextBox ID="TextBox28" runat="server" Enabled="False" Text='<%#Eval("Approved_Date") %>' BackColor="#EFEFEF" ForeColor="Black" BorderStyle="None"></asp:TextBox>
                                     </td>
                                 </tr>
                                 <tr>
                                     <td style="; background-color:#EFEFEF ">Fitness</td>
                                     <td style=" ; background-color:#EFEFEF">
                                         <asp:TextBox ID="TextBox29" runat="server" Enabled="False" Text='<%#Eval("Fitness") %>' BackColor="#EFEFEF" ForeColor="Black" BorderStyle="None"></asp:TextBox>
                                     </td>
                                 </tr>
                                  <tr>
                                     <td style="; background-color:#EFEFEF ">Tex Year</td>
                                     <td style=" ; background-color:#EFEFEF">
                                         <asp:TextBox ID="TextBox30" runat="server" Enabled="False" Text='<%#Eval("Tex_year") %>' BackColor="#EFEFEF" ForeColor="Black" BorderStyle="None"></asp:TextBox>
                                     </td>
                                 </tr>
                                 <tr>
                                     <td style="; background-color:#EFEFEF ">TEX</td>
                                     <td style="; background-color:#EFEFEF">
                                         <asp:TextBox ID="TextBox31" runat="server" Enabled="False" Text='<%#Eval("TEX") %>' BackColor="#EFEFEF" ForeColor="Black" BorderStyle="None"></asp:TextBox>
                                     </td>
                                 </tr>
                                 <tr>
                                     <td style="; background-color:#EFEFEF ">Service No</td>
                                     <td style="; background-color:#EFEFEF ">
                                         <asp:TextBox ID="TextBox32" runat="server" Enabled="False" Text='<%#Eval("Bus_no") %>' BackColor="#EFEFEF" ForeColor="Black" BorderStyle="None"></asp:TextBox>
                                     </td>
                                 </tr>
                                 <tr>
                                     <td style="; background-color:#EFEFEF ">Service Name</td>
                                     <td style="; background-color:#EFEFEF ">
                                         <asp:TextBox ID="TextBox33" runat="server" Enabled="False" Text='<%#Eval("Bus_Name") %>' BackColor="#EFEFEF" ForeColor="Black" BorderStyle="None"></asp:TextBox>
                                     </td>
                                 </tr>
                                    <tr>
                                     <td style="; background-color:#EFEFEF ">Bus Type</td>
                                     <td style="; background-color:#EFEFEF ">
                                         <asp:TextBox ID="TextBox15" runat="server" Enabled="False" Text='<%#Eval("Bus_type") %>' BackColor="#EFEFEF" ForeColor="Black" BorderStyle="None"></asp:TextBox>
                                     </td>
                                 </tr>
                                    <tr>
                                     <td style="; background-color:#EFEFEF ">Sit Capacity</td>
                                     <td style="; background-color:#EFEFEF ">
                                         <asp:TextBox ID="TextBox16" runat="server" Enabled="False" Text='<%#Eval("Total_Sit") %>' BackColor="#EFEFEF" ForeColor="Black" BorderStyle="None"></asp:TextBox>
                                     </td>
                                 </tr>
                                    <tr>
                                     <td style=" ; background-color:#EFEFEF">Stand Capacity</td>
                                     <td style="; background-color:#EFEFEF ">
                                         <asp:TextBox ID="TextBox17" runat="server" Enabled="False" Text='<%#Eval("Total_Stand_Capacity") %>' BackColor="#EFEFEF" ForeColor="Black" BorderStyle="None"></asp:TextBox>
                                     </td>
                                 </tr>
                                   
                             </table>
                         </div>
                     </ItemTemplate>
                 </asp:Repeater>
    </div>
            </td>
        </tr>
        <tr>
            <td colspan="4">
     
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
