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
    public partial class pessenger : System.Web.UI.Page
    {
        private SerialPort _serialPort;
        private void msgbox(string msg) { ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "CallMyFunction", "alert('" + msg + "')", true); }





        protected void Page_Load(object sender, EventArgs e)
        {
           

       
            if (Session["ID"] != null)
            {

                Class1 ssjk = new Class1();
                ssjk.login_id = Session["ID"].ToString();
                if (ssjk.QueryInlogin13()) { Session["f"] = ssjk.log_type; }
                if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }

                SqlConnection conjk = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sdajk = new SqlDataAdapter("update login_table set e_h='1',l='1' where login_id='" + Session["ID"].ToString() + "'", conjk);
                DataTable dtjk = new DataTable();
                sdajk.Fill(dtjk);
            }
            if (Session["ID"] != null)
            {
                Class1 ss = new Class1();
                ss.login_id = Session["ID"].ToString();
                if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
                if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
            }
            Repeater2.Visible = false;
            if (Session["ID"] != null)
            {
                Class1 s = new Class1();
                s.login_id = Session["ID"].ToString();
                if (s.QueryInem()) { Button18.Text = "Email"+" ( "+s.s_no+" ) "; }

                Session["vv"] = TextBox3.Text;
                TextBox1.Text = Session["ID"].ToString();
                TextBox10.Text = Session["t"].ToString();
                LinkButton1.Visible = true;
                Button15.Visible = true;
                //Button16.Visible = true;
                Repeater1.Visible = true;

                SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda = new SqlDataAdapter("update login_table set l='1',e_h='1' where login_id='"+TextBox1.Text+"'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);


            }
            else { Response.Redirect("home.aspx"); }
            if (TextBox10.Text == "owner")
            {
                Button6.Visible = true;
                Button5.Visible = true; Button5.Text = "Add Bus Driver";
                Button4.Visible = true; Button4.Text = "Add/View Bus Information"; Button1.Visible = true; Button2.Visible = true; ; Button9.Visible = true; Button8.Visible = true; Button12.Visible = true; Button13.Visible = true; Button14.Visible = true;
            }
            if (TextBox10.Text == "driver" || TextBox10.Text == "Helper")
            {
                Button4.Text = "No Duty";
                Class1 s = new Class1();
                s.Bus_License_no = TextBox1.Text;
                if (s.QueryInrate_())
                {
                    Button5.Text = "Active GPS"; Button5.Visible = true;
                    Button4.Text = "Duty on bus :" + s.s_no;
                    Button4.Text = Button4.Text + ". Comment: " + s.Road_no;
                    Session["bus"] = s.s_no;
                }
                Button4.Visible = true; Button1.Visible = true; Button2.Visible = true; ; Button9.Visible = true; Button8.Visible = true;
            }
            if (TextBox10.Text == "Counter_Stuff") { Button4.Visible = true; Button4.Text = "Counter"; Button1.Visible = true; Button2.Visible = true; ; Button9.Visible = true; Button8.Visible = true; }
            if (TextBox10.Text == "pessenger") { Button1.Visible = true; Button2.Visible = true; ; Button9.Visible = true; Button8.Visible = true; }
            if (TextBox10.Text == "Gov.Stuff") { Button4.Visible = true; Button4.Text = "Add/View Information"; Button1.Visible = true; Button2.Visible = true; ; Button9.Visible = true; Button8.Visible = true; Button5.Visible = true; Button5.Text = "Add/View Bus Stop"; }
            if (TextBox10.Text == "Administrator Head") { Button4.Visible = true; Button5.Visible = true; Button1.Visible = true; Button2.Visible = true; ; Button9.Visible = true; Button8.Visible = true; }
            if (TextBox10.Text == "Administrator") { Button4.Visible = true; Button4.Text = "Add Gov.Stuff"; Button5.Visible = false; Button1.Visible = true; Button2.Visible = true; ; Button9.Visible = true; Button8.Visible = true; }
            if (TextBox10.Text == "Administrator Head" || TextBox10.Text == "Administrator")
            {
                Button17.Visible = true;
              
                Repeater1.Visible = false;
                Repeater2.Visible = true;


                Class1 d = new Class1();
                d.admin_id = TextBox1.Text;
                if (d.QueryInadmin())
                {
                    TextBox2.Text = d.Name;
                    TextBox3.Text = d.Contact_number;
                    TextBox4.Text = d.Emargency_contact_No;
                    TextBox5.Text = d.Email_id;
                    TextBox6.Text = d.Current_address;
                    TextBox7.Text = d.Permanent_address;
                    TextBox8.Text = d.Country;
                    TextBox9.Text = d.DOB;
                    Image1.ImageUrl = d.picture;

                }

            }
            else if (TextBox10.Text == "pessenger")
            {

                Class1 d = new Class1();
                d.Pessenger_id = TextBox1.Text;
                if (d.QueryInpessenger())
                {
                    TextBox2.Text = d.Name;
                    TextBox3.Text = d.Contact_number;
                    TextBox4.Text = d.Emargency_contact_No;
                    TextBox5.Text = d.Email_id;
                    TextBox6.Text = d.Current_address;
                    TextBox7.Text = d.Permanent_address;
                    TextBox8.Text = d.Country;
                    TextBox9.Text = d.DOB;
                    Image1.ImageUrl = d.picture;

                }
            }
            else if (TextBox10.Text == "Gov.Stuff")
            {

                Class1 d = new Class1();
                d.Stuff_id = TextBox1.Text;
                if (d.QueryIngov())
                {
                    TextBox2.Text = d.Name;
                    TextBox3.Text = d.Contact_number;
                    TextBox4.Text = d.Emargency_contact_No;
                    TextBox5.Text = d.Email_id;
                    TextBox6.Text = d.Current_address;
                    TextBox7.Text = d.Permanent_address;
                    TextBox8.Text = d.Country;
                    TextBox9.Text = d.DOB;
                    Image1.ImageUrl = d.picture;

                }
            }
            else if (TextBox10.Text == "owner")
            {

                Class1 d = new Class1();
                d.Owner_id = TextBox1.Text;
                if (d.QueryInowner())
                {
                    TextBox2.Text = d.Name;
                    TextBox3.Text = d.Contact_number;
                    TextBox4.Text = d.Emargency_contact_No;
                    TextBox5.Text = d.Email_id;
                    TextBox6.Text = d.Current_address;
                    TextBox7.Text = d.Permanent_address;
                    TextBox8.Text = d.Country;
                    TextBox9.Text = d.DOB;
                    Image1.ImageUrl = d.picture;

                }
            }
            else if (TextBox10.Text == "driver" || TextBox10.Text == "Helper" || TextBox10.Text == "Counter_Stuff")
            {

                Class1 d = new Class1();
                d.Stuff_id = TextBox1.Text;
                if (d.QueryInstuff())
                {
                    TextBox2.Text = d.Name;
                    TextBox3.Text = d.Contact_number;
                    TextBox4.Text = d.Emargency_contact_No;
                    TextBox5.Text = d.Email_id;
                    TextBox6.Text = d.Current_address;
                    TextBox7.Text = d.Permanent_address;
                    TextBox8.Text = d.Country;
                    TextBox9.Text = d.DOB;
                    Image1.ImageUrl = d.picture;

                }
            }
            if (Session["not"] == "1") {
                SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda = new SqlDataAdapter("update login_table set t='1' where login_id='" + Session["ID"].ToString() + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
            using (MailMessage mm = new MailMessage("jisanrahman1996@gmail.com", TextBox5.Text))
            {
                try
                {
                    try
                    {
                        mm.Subject = "login notification of online bus counter";
                        mm.Body = "Some one login to yuor account.is it you? if not you contact us immediate.";

                        mm.IsBodyHtml = false;
                        SmtpClient smtp = new SmtpClient();
                        smtp.Host = "smtp.gmail.com";
                        smtp.EnableSsl = true;
                        NetworkCredential NetworkCred = new NetworkCredential("jisanrahman1996@gmail.com", "199601687602005");
                        smtp.UseDefaultCredentials = true;
                        smtp.Credentials = NetworkCred;
                        smtp.Port = 587;
                        smtp.Send(mm);
                    }
                    catch
                    {
                        SqlConnection cont = new SqlConnection(Properties.Settings.Default._ConnectionString);
                        SqlDataAdapter sdat = new SqlDataAdapter("update login_table set l='0',e_h='0',t='1' where login_id='" + TextBox1.Text + "'", cont);
                        DataTable dtt = new DataTable();
                        sdat.Fill(dtt);

                        Session.RemoveAll();
                        SqlConnection conr = new SqlConnection(Properties.Settings.Default._ConnectionString);
                        conr.Close();
                        msgbox("our system is updating. Please try again later");
                        Response.Redirect("Home.aspx");
                    }
                    try
                    {
                        string number = TextBox3.Text;
                        string message = "Some one login to your online bus counter's account.is it you? if not you contact us immediate.";
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
                    }
                    catch
                    {
                        SqlConnection cont = new SqlConnection(Properties.Settings.Default._ConnectionString);
                        SqlDataAdapter sdat = new SqlDataAdapter("update login_table set l='0',e_h='0',t='1' where login_id='" + TextBox1.Text + "'", cont);
                        DataTable dtt = new DataTable();
                        sdat.Fill(dtt);

                        Session.RemoveAll();
                        SqlConnection conr = new SqlConnection(Properties.Settings.Default._ConnectionString);
                        conr.Close();
                        msgbox("our system is updating. Please try again later");
                        Response.Redirect("Home.aspx");
                    }
                }
                catch
                {
                    SqlConnection cont = new SqlConnection(Properties.Settings.Default._ConnectionString);
                    SqlDataAdapter sdat = new SqlDataAdapter("update login_table set l='0',e_h='0',t='1' where login_id='" + TextBox1.Text + "'", cont);
                    DataTable dtt = new DataTable();
                    sdat.Fill(dtt);

                    Session.RemoveAll();
                    SqlConnection conr = new SqlConnection(Properties.Settings.Default._ConnectionString);
                    conr.Close();
                    msgbox("our system is updating. Please try again later");
                    Response.Redirect("Home.aspx");
                }
               

                    Session["not"] = "0";

            }
        }
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["ID"] != null)
            {
                Class1 ss = new Class1();
                ss.login_id = Session["ID"].ToString();
                if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
                if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
            }
            SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda = new SqlDataAdapter("update login_table set l='0',e_h='0',t='1' where login_id='" + TextBox1.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            Session.RemoveAll();
            SqlConnection conr = new SqlConnection(Properties.Settings.Default._ConnectionString);
            conr.Close();
            Response.Redirect("Home.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Session["ID"] != null)
            {
                Class1 ss = new Class1();
                ss.login_id = Session["ID"].ToString();
                if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
                if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
            }
            Session["ID1"] = TextBox1.Text;
            Session["wcn"]=TextBox3.Text;
            Session["wce"]=TextBox4.Text;
            Response.Redirect("Change.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
          
            SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda = new SqlDataAdapter("update pessenger_id set Contact_number='" + TextBox3.Text + "',Emargency_contact_No='" + TextBox4.Text + "',Email_id='" + TextBox5.Text + "',Current_address='" + TextBox6.Text + "',picture='" + Image1.ImageUrl + "' where pessenger_id='"+TextBox1.Text+"'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
          
         
            TextBox3.Enabled = false;
            TextBox4.Enabled = false;
            TextBox5.Enabled = false;
            TextBox6.Enabled = false;
           
           
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (Session["ID"] != null)
            {
                Class1 ss = new Class1();
                ss.login_id = Session["ID"].ToString();
                if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
                if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
            }
            if (Button4.Text == "Add Administrator")
            {
                Session["g"] = "A";
                Response.Redirect("Register.aspx");
            }
            if (Button4.Text == "Add/View")
            {
                Response.Redirect("add.aspx");
            }
            if (Button4.Text == "Add/View Information")
            {
                Response.Redirect("Information.aspx");
            }
            if (Button4.Text == "Add Gov.Stuff")
            {
                Session["g"] = "Gov.Stuff";
                Response.Redirect("Register.aspx");
            }
            //////
            if (Button4.Text == "Add/View Bus Information")
            {
                Response.Redirect("Mybus.aspx");
            }

            if (Button4.Text == "Counter")
            {
                Response.Redirect("status.aspx");
            }
            else { Response.Redirect("TC.aspx"); }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            if (Session["ID"] != null)
            {
                Class1 ss = new Class1();
                ss.login_id = Session["ID"].ToString();
                if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
                if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
            }

            if (Button5.Text == "Add Gov.Stuff")
            {
                Session["g"] = "Gov.Stuff";
                Response.Redirect("Register.aspx");
               
            }
           
            if (Button5.Text == "Add Bus Driver")
            {
                Response.Redirect("Register.aspx?" + "Driver");
            }
            if (Button5.Text == "Add/View Bus Stop")
            {
                Response.Redirect("Bus_Stop.aspx");
            }
            if (Button5.Text == "Active GPS")
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda = new SqlDataAdapter("update login_table set l='0',e_h='0',t='1' where login_id='" + TextBox1.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Session.RemoveAll();
               Session["gpp"]=TextBox1.Text;
                Class1 s = new Class1();
                s.Bus_License_no = TextBox1.Text;
                if (s.QueryInrate_())
                {
                   
                    Session["bus"] = s.s_no;
                }
               
                Response.Redirect("Location.aspx");
               
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            if (Session["ID"] != null)
            {
                Class1 ss = new Class1();
                ss.login_id = Session["ID"].ToString();
                if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
                if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
            }
            Response.Redirect("Bus_Stop.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            if (Session["ID"] != null)
            {
                Class1 ss = new Class1();
                ss.login_id = Session["ID"].ToString();
                if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
                if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
            }
            Response.Redirect("status.aspx");
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            if (Session["ID"] != null)
            {
                Class1 ss = new Class1();
                ss.login_id = Session["ID"].ToString();
                if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
                if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
            }
            Session["ty"] = Session["ID"].ToString();
            Response.Redirect("ticket.aspx");
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            if (Session["ID"] != null)
            {
                Class1 ss = new Class1();
                ss.login_id = Session["ID"].ToString();
                if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
                if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
            }
            Response.Redirect("balance.aspx");
        }

       

        
        protected void Button12_Click(object sender, EventArgs e)
        {
            if (Session["ID"] != null)
            {
                Class1 ss = new Class1();
                ss.login_id = Session["ID"].ToString();
                if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
                if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
            }
            Response.Redirect("Register.aspx?" + "Helper");
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            if (Session["ID"] != null)
            {
                Class1 ss = new Class1();
                ss.login_id = Session["ID"].ToString();
                if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
                if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
            }
            Response.Redirect("Register.aspx?" + "Counter_Stuff");
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            if (Session["ID"] != null)
            {
                Class1 ss = new Class1();
                ss.login_id = Session["ID"].ToString();
                if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
                if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
            }
            Response.Redirect("counter.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session["image"] = Image1.ImageUrl;
            
            Response.Redirect("myimage.aspx");
        }

        protected void Button16_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://www.facebook.com/ShyamoliParibahan");
        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            SqlConnection con111 = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda111 = new SqlDataAdapter("insert into Comment(login_id,Name,Comment,Date)values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox11.Text + "','" + DateTime.Now.ToString("dd-MMM-yyyy hh:mm tt") + "')", con111);
            DataTable dt111 = new DataTable();
            sda111.Fill(dt111);
          
            Response.Redirect("user.aspx");

        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
           
        }

        protected void Repeater2_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "6") 
            {
                int rowid = (e.Item.ItemIndex);
                TextBox t = (TextBox)Repeater2.Items[rowid].FindControl("TextBox12") as TextBox;
                SqlConnection con111 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda111 = new SqlDataAdapter("delete from comment where sl='"+t.Text+"'", con111);
                DataTable dt111 = new DataTable();
                sda111.Fill(dt111);
                Response.Redirect("user.aspx");
                
            }
            if (e.CommandName == "5")
            {
                int rowid = (e.Item.ItemIndex);
                TextBox t = (TextBox)Repeater2.Items[rowid].FindControl("TextBox12") as TextBox;
                SqlConnection con111 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda111 = new SqlDataAdapter("update Comment set s='Read' where SL='"+t.Text+"'", con111);
                DataTable dt111 = new DataTable();
                sda111.Fill(dt111);
                Response.Redirect("user.aspx");
                
                
            }
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            SqlConnection con111 = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda111 = new SqlDataAdapter("update login_table set v_code='"+TextBox5.Text+"' where login_id='"+TextBox1.Text+"'", con111);
            DataTable dt111 = new DataTable();
            sda111.Fill(dt111);

        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            SqlConnection con111 = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda111 = new SqlDataAdapter("update login_table set v_code='' where login_id='" + TextBox1.Text + "'", con111);
            DataTable dt111 = new DataTable();
            sda111.Fill(dt111);
        }

       

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("control_panel.aspx");
        }

        protected void Button17_Click(object sender, EventArgs e)
        {
            Session["image"] = Image1.ImageUrl;

            Response.Redirect("myimage.aspx");
        }

        protected void Button18_Click(object sender, EventArgs e)
        {
            SqlConnection con111 = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda111 = new SqlDataAdapter("update login_table set v_code='" + TextBox5.Text + "' where login_id='" + TextBox1.Text + "'", con111);
            DataTable dt111 = new DataTable();
            sda111.Fill(dt111);
        }

        protected void Button19_Click(object sender, EventArgs e)
        {
            SqlConnection con111 = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda111 = new SqlDataAdapter("update login_table set v_code='' where login_id='" + TextBox1.Text + "'", con111);
            DataTable dt111 = new DataTable();
            sda111.Fill(dt111);
        }

        protected void Button17_Click1(object sender, EventArgs e)
        {

        }

        protected void Button17_Click2(object sender, EventArgs e)
        {
            if (Session["ID"] != null)
            {
                Class1 ss = new Class1();
                ss.login_id = Session["ID"].ToString();
                if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
                if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
            }
            Response.Redirect("control_panel.aspx");
        }

        protected void Button18_Click1(object sender, EventArgs e)
        {
            if (Session["ID"] != null)
            {
                Class1 ss = new Class1();
                ss.login_id = Session["ID"].ToString();
                if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
                if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
            }
            Response.Redirect("email.aspx");
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
               
        }

        protected void Timer1_Tick1(object sender, EventArgs e)
        {
            if (Session["ID"] != null)
            {
                Class1 ssjk = new Class1();
                ssjk.login_id = Session["ID"].ToString();
                if (ssjk.QueryInlogin13()) { Session["f"] = ssjk.log_type; }
                if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }

                SqlConnection conjk = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sdajk = new SqlDataAdapter("update login_table set e_h='1',l='1' where login_id='" + Session["ID"].ToString() + "'", conjk);
                DataTable dtjk = new DataTable();
                sdajk.Fill(dtjk);
            }
        }
    }
}