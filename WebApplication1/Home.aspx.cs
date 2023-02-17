using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;
using System.IO.Ports;
using System.Threading;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Globalization;
using System.Net.NetworkInformation;



namespace WebApplication1
{
    public partial class Home : System.Web.UI.Page
    {
        public void IpAddress()
        {
           
            string strIpAddress;
            strIpAddress = Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
            if (strIpAddress == null)
            {
                strIpAddress = Request.ServerVariables["REMOTE_ADDR"];
            }
            TextBox13.Text =   "Device IP: " + strIpAddress;
           
        }
      

        protected void Page_Load(object sender, EventArgs e)
        {
           

            



           
           // Session.RemoveAll();
            if (Session["ID"] != null) { Response.Redirect("user.aspx"); }
           // Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "getLocation()", true);
           TextBox13.Text = "";
          
            IpAddress();
            UTF8Encoding u = new UTF8Encoding();
            WebClient w = new WebClient();
            string p = w.DownloadString("https://api.ipify.org/");
            TextBox13.Text = TextBox13.Text + "; Public IP: " + p;

            string strUserAgent = Request.UserAgent.ToString().ToLower();
            TextBox13.Text = TextBox13.Text + "; Device & Browser Details: " + strUserAgent;
        }
        private void msgbox(string msg) { ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "CallMyFunction", "alert('" + msg + "')", true); }
        protected void Timer1_Tick(object sender, EventArgs e)
        {
            int a;
            a = int.Parse(TextBox1.Text);
            a = a + 1;
            if (a == 7) { a = 1; }
            TextBox1.Text = a.ToString();
           Image1.ImageUrl = "~/image/" + a.ToString() + ".jpg";
            int b=0;
            if (a == 1) { b = 11; }
            if (a == 2) { b = 11; }
            if (a == 3) { b = 11; }
            if (a == 4) { b = 22; }
            if (a == 5) { b = 22; }
            if (a == 6) { b = 22; } 
          
          
          //  Image2.ImageUrl = "~/image/" + b.ToString() + ".jpg";
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
           
            Response.Redirect("Register.aspx");
        }
        private SerialPort _serialPort;
        protected void Button1_Click(object sender, EventArgs e)
        {
          
            TextBox13.Text = "";//DateTime.Now.ToString("dd-MMM-yyy hh:mm tt; ")
          

            IpAddress();
            UTF8Encoding u = new UTF8Encoding();
            WebClient w = new WebClient();
            string p = w.DownloadString("https://api.ipify.org/");
            TextBox13.Text = TextBox13.Text + "; Public IP: " + p;

            string strUserAgent = Request.UserAgent.ToString().ToLower();
            TextBox13.Text = TextBox13.Text + "; Device & Browser Details: " + strUserAgent;
            string t ,v;
            int a, b, c;
           
            Class1 d = new Class1();
            d.login_id = TextBox2.Text;
            d.log_password = TextBox3.Text;
            if (d.QueryInlogin1())
            {
                t = d.log_type;
                v = d.vcode;
                Session["l"] = d.Bus_no;
                if (Session["l"].ToString() == "0")
                {
                    if (Button1.Text == "Login")
                    {
                        if (v == "")
                        {
                            Session["v"] = "";
                            Button1.Text = "Login";
                            TextBox4.Enabled = false;
                            TextBox4.Text = "";

                        }
                        else
                        {
                            Button1.Text = "Verify";

                        }
                        if (Button1.Text == "Verify")
                        {
                            a = int.Parse(DateTime.Now.ToString("mmssmm"));
                            b = int.Parse(DateTime.Now.ToString("mmmmss"));
                            c = a + b; Session["v"] = c.ToString();

                            TextBox4.Enabled = true;
                            Button1.Text = "Check";
                            try
                            {
                                string number = v;
                                string message = " Online bus counter Login verification Code: " + c.ToString();
                                _serialPort = new SerialPort("COM7", 115200);
                                Thread.Sleep(1000);
                                _serialPort.Open();
                                Thread.Sleep(1000);
                                _serialPort.Write("AT+CMGF=1\r");
                                Thread.Sleep(1000);
                                _serialPort.Write("AT+CMGS=\"" + number + "\"\r\n");
                                Thread.Sleep(1000);
                                _serialPort.Write(message + "\x1A");
                                Thread.Sleep(1000);
                                _serialPort.Close();
                               /* using (MailMessage mm = new MailMessage("jisanrahman1996@gmail.com", v))
                                {
                                    mm.Subject = "Login verification Code";
                                    mm.Body = "Login verification Code: " + c.ToString();

                                    mm.IsBodyHtml = false;
                                    SmtpClient smtp = new SmtpClient();
                                    smtp.Host = "smtp.gmail.com";
                                    smtp.EnableSsl = true;
                                    NetworkCredential NetworkCred = new NetworkCredential("jisanrahman1996@gmail.com", "199601687602005");
                                    smtp.UseDefaultCredentials = true;
                                    smtp.Credentials = NetworkCred;
                                    smtp.Port = 587;
                                    smtp.Send(mm);
                                }*/
                            }
                            catch { msgbox("Our system is updating. PLease try again later."); }
                        }
                    }
                    if (Button1.Text == "Login" || Button1.Text == "Check")
                    {
                        Session["not"] = "1";
                       


                        if (TextBox4.Text != Session["v"].ToString()) { msgbox("check verification Code "); }
                        if (t == "pessenger" && TextBox4.Text == Session["v"].ToString())
                        {
                            TextBox4.Enabled = false;
                            SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                            SqlDataAdapter sda = new SqlDataAdapter("insert into log_his(id,des,date)values('" + TextBox2.Text + "','" + TextBox13.Text + "','" + DateTime.Now.ToString(" dd-MMM-yyy hh:mm tt ") + "') ", con);
                          
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            Session["t"] = t; 
                            Session["ID"] = TextBox2.Text; 
                           
                            Response.Redirect("user.aspx"); 
                        }
                        if (t == "Administrator Head" && TextBox4.Text == Session["v"].ToString())
                        {
                            TextBox4.Enabled = false;
                            SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                            SqlDataAdapter sda = new SqlDataAdapter("insert into log_his(id,des,date)values('" + TextBox2.Text + "','" + TextBox13.Text + "','" + DateTime.Now.ToString(" dd-MMM-yyy hh:mm tt ") + "') ", con);
                        
                            
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            Session["ID"] = TextBox2.Text;
                            Session["t"] = t;
                            Response.Redirect("user.aspx");
                        }
                        if (t == "Administrator" && TextBox4.Text == Session["v"].ToString())
                        {
                            TextBox4.Enabled = false;
                            SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                            SqlDataAdapter sda = new SqlDataAdapter("insert into log_his(id,des,date)values('" + TextBox2.Text + "','" + TextBox13.Text + "','" + DateTime.Now.ToString(" dd-MMM-yyy hh:mm tt ") + "') ", con);
                          
                            
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            Session["ID"] = TextBox2.Text;
                            Session["t"] = t;
                            Response.Redirect("user.aspx");
                        }
                        if (t == "Gov.Stuff" && TextBox4.Text == Session["v"].ToString())
                        {
                            TextBox4.Enabled = false;
                            SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                            SqlDataAdapter sda = new SqlDataAdapter("insert into log_his(id,des,date)values('" + TextBox2.Text + "','" + TextBox13.Text + "','" + DateTime.Now.ToString(" dd-MMM-yyy hh:mm tt ") + "') ", con);
                          
                            
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            Session["ID"] = TextBox2.Text;
                            Session["t"] = t;
                            Response.Redirect("user.aspx");
                        }
                        if (t == "owner" && TextBox4.Text == Session["v"].ToString())
                        {
                            TextBox4.Enabled = false;
                            SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                            SqlDataAdapter sda = new SqlDataAdapter("insert into log_his(id,des,date)values('" + TextBox2.Text + "','" + TextBox13.Text + "','" + DateTime.Now.ToString(" dd-MMM-yyy hh:mm tt ") + "') ", con);
                          
                            
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            Session["ID"] = TextBox2.Text;
                            Session["t"] = t;
                            Response.Redirect("user.aspx");
                        }
                        if ((t == "driver" || t == "Counter_Stuff" || t == "Helper") && TextBox4.Text == Session["v"].ToString())
                        {
                            TextBox4.Enabled = false;
                            SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                            SqlDataAdapter sda = new SqlDataAdapter("insert into log_his(id,des,date)values('" + TextBox2.Text + "','" + TextBox13.Text + "','" + DateTime.Now.ToString(" dd-MMM-yyy hh:mm tt ") + "') ", con);
                         
                            
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            Session["ID"] = TextBox2.Text;
                            Session["t"] = t;
                            Response.Redirect("user.aspx");
                        }

                    }
                }
                else { msgbox("Already Login"); }
            }
            else { msgbox("ID or password wrong"); }
            msgbox("your id temporary close by administator");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("forgott.aspx");
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {

        }

        

        
    }
}