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



namespace WebApplication1
{
    public partial class Register : System.Web.UI.Page
    {
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
            if (Session["ID"] != null )
            { Button3.Visible = true; }
           // else { Response.Redirect("home.aspx"); }
            TextBox15.Text = DateTime.Now.ToString("hh:mm:ss tt");
            TextBox13.Text = Request.QueryString.ToString();
            if (Session["t"] != null)
            { TextBox12.Text = Session["t"].ToString();
            TextBox14.Text = Session["ID"].ToString();
          
            }
            if (Session["g"] != null) { TextBox13.Text = Session["g"].ToString(); }
            if (TextBox12.Text == "Administrator Head" || TextBox12.Text == "Administrator" || TextBox12.Text == "owner") { DropDownList1.Visible = false; CheckBox1.Enabled = false; CheckBox2.Enabled = false; }
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
           string s="";
            string f = System.IO.Path.GetExtension(FileUpload1.FileName);

            if (f.ToLower() != ".jpg") { msgbox("Select .jpg file first"); }
            else
            {

                if (FileUpload1.FileName == "") {  }
                else
                {
                    Class1 d = new Class1();

                    if (d.QueryInlogin()) { s = d.s_no + "-"; }

                    FileUpload1.SaveAs(Server.MapPath("~/upload/" +s+ FileUpload1.FileName));
                    Image1.ImageUrl = "~/upload/" + s + FileUpload1.FileName;
                }

            }
        }
        private SerialPort _serialPort;
            protected void Button2_Click(object sender, EventArgs e)
        {
            if (Session["ID"] != null)
            {
                Class1 ss = new Class1();
                ss.login_id = Session["ID"].ToString();
                if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
                if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
            }
            

            if (TextBox3.Text.Length == 11 && TextBox4.Text.Length == 11&& Button2.Text == "Apply" && TextBox3.Text != "" && TextBox4.Text != "" && TextBox5.Text != "" && TextBox3.Text!=TextBox4.Text)
            {
               Session["a"] = TextBox3.Text;
               Session["b"] = TextBox5.Text;
                int a, b, c;
                a = int.Parse(DateTime.Now.ToString("sshhmm"));
                b = int.Parse(DateTime.Now.ToString("hhmmss"));
                c = a + b;

                Session["c"] = c.ToString();
               // TextBox18.Text = Session["c"].ToString();
                using (MailMessage mm = new MailMessage("jisanrahman1996@gmail.com", TextBox5.Text))
                {
                    try
                    {
                        mm.Subject = "Online Bus counter";
                        mm.Body = "Hi I am your administrator. Welcome to our Digital World and your Email Verification code is: " + c.ToString() + " .Please do no share this code with other";

                        mm.IsBodyHtml = false;
                        SmtpClient smtp = new SmtpClient();
                        smtp.Host = "smtp.gmail.com";
                        smtp.EnableSsl = true;
                        NetworkCredential NetworkCred = new NetworkCredential("jisanrahman1996@gmail.com", "199601687602005");
                        smtp.UseDefaultCredentials = true;
                        smtp.Credentials = NetworkCred;
                        smtp.Port = 587;
                        smtp.Send(mm);
                        int aa, ba, ca;
                        aa = int.Parse(DateTime.Now.ToString("sshhmm"));
                        ba = int.Parse(DateTime.Now.ToString("ssssmm"));
                        ca = aa + ba;
                        Session["d"] = ca.ToString();
                 

                  
                   

                  
                  //  TextBox19.Text = Session["d"].ToString();
                  //  TextBox2.Text = Session["c"].ToString() + " " + Session["d"].ToString() + " " + Session["e"].ToString();
                    /********************************************/
                    try
                    {
                        string number = TextBox3.Text;
                        string message = "Hi I am your administrator. Welcome to our Digital World and your Contact number Verification code is: " + ca.ToString() + " .Please do no share this code with other" ;
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
                     Timer2.Enabled = true;
                    }
                    catch { msgbox("our system is updating. Please try again later"); Button2.Text = "Apply"; }
                    }
                    catch { msgbox("our system is updating. Please try again later"); }
                   
                 
                 
                    //"Hi I am administrator from online bus counter.Some one try to use your contact number as relative's contact number and Verification code is: " +
                  
                    /************************************************/
                   // msgbox(TextBox3.Text+"    "   +TextBox4.Text);
                  
                }
            }

            if (Button2.Text == "verify" && TextBox20.Text == Session["c"].ToString() && TextBox21.Text == Session["d"].ToString() && Session["a"].ToString() == TextBox3.Text.ToString() && Session["b"].ToString() == TextBox5.Text&&Session["e"].ToString() == TextBox22.Text)
            { Button2.Text = "Submit";
        
            }

            if (Button2.Text == "Submit" && TextBox20.Text == Session["c"].ToString() && TextBox21.Text == Session["d"].ToString() && Session["a"].ToString() == TextBox3.Text && Session["b"].ToString() == TextBox5.Text && TextBox10.Text.Length > 5 && Session["e"].ToString() == TextBox22.Text)
            { 
            
            if (TextBox3.Text.Length == 11 && TextBox4.Text.Length == 11)
            {
               /* TextBox3.Text = "0"+TextBox3.Text;
                TextBox4.Text = "0" + TextBox4.Text;*/


                if (TextBox12.Text == "Administrator Head" && TextBox13.Text == "A")
                {
                    if (TextBox11.Text == "" || TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "" || TextBox4.Text == "" || TextBox5.Text == "" || TextBox6.Text == "" || TextBox7.Text == "" || TextBox8.Text == "" || TextBox10.Text == "" || Image1.ImageUrl == "") { msgbox("Complete all field"); }
                    else
                    {
                        if (TextBox10.Text.Length < 6) { msgbox("Password minimum lenght 6"); }
                        else
                        {
                            Class1 d = new Class1();

                            if (d.QueryInlogin()) { TextBox1.Text = "a-" + d.s_no; }
                            Class1 dd = new Class1();
                            dd.login_id = TextBox1.Text;
                            dd.log_type = "Administrator";
                            dd.log_password = TextBox10.Text;
                            if (dd.DataSaveInlogin_table()) { } else { }
                            Class1 ddd = new Class1();
                            ddd.admin_id = TextBox1.Text;
                            ddd.Name = TextBox2.Text;
                            ddd.picture = Image1.ImageUrl;
                            ddd.Contact_number = TextBox3.Text;
                            ddd.Emargency_contact_No = TextBox4.Text;
                            ddd.Email_id = TextBox5.Text;
                            ddd.Current_address = TextBox6.Text;
                            ddd.Permanent_address = TextBox7.Text;
                            ddd.Country = TextBox8.Text;
                            ddd.DOB = TextBox9.Text;
                            if (ddd.DataSaveInadmin()) { msgbox("Please Note  Login_id: " + TextBox1.Text); SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                            SqlDataAdapter sda1 = new SqlDataAdapter("update login_table set l='0',history='" + "create " + DateTime.Now.ToString("dd-MMM-yy hh.mm tt") + "' where login_id='" + TextBox1.Text + "' insert into balance (Owner_id,Taka)values('" + TextBox1.Text + "','0')", con1);
                                    DataTable dt1 = new DataTable();
                                    sda1.Fill(dt1);
                                } else { msgbox("Fail"); }
                        }
                    }

                }
                if (CheckBox1.Checked) { TextBox13.Text = "pessenger"; }
                if (CheckBox2.Checked) { TextBox13.Text = "owner"; }
                if (CheckBox1.Checked && CheckBox2.Checked) { TextBox13.Text = ""; msgbox("Please select any one type"); }
                if (TextBox13.Text == "pessenger")
                {

                    if (TextBox13.Text == "" || TextBox11.Text == "" || TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "" || TextBox4.Text == "" || TextBox5.Text == "" || TextBox6.Text == "" || TextBox7.Text == "" || TextBox8.Text == "" || TextBox10.Text == "" || Image1.ImageUrl == "") { msgbox("Complete all field"); }
                    else
                    {
                        if (TextBox10.Text.Length < 6) { msgbox("Password minimum lenght 6"); }
                        else
                        {

                            Class1 d = new Class1();

                            if (d.QueryInlogin()) { TextBox1.Text = "P-" + d.s_no; }
                            Class1 dd = new Class1();
                            dd.login_id = TextBox1.Text;
                            dd.log_type = TextBox13.Text;
                            dd.log_password = TextBox10.Text;
                            if (dd.DataSaveInlogin_table()) { } else { }
                            Class1 ddd = new Class1();
                            ddd.Pessenger_id = TextBox1.Text;
                            ddd.Name = TextBox2.Text;
                            ddd.picture = Image1.ImageUrl;
                            ddd.Contact_number = TextBox3.Text;
                            ddd.Emargency_contact_No = TextBox4.Text;
                            ddd.Email_id = TextBox5.Text;
                            ddd.Current_address = TextBox6.Text;
                            ddd.Permanent_address = TextBox7.Text;
                            ddd.Country = TextBox8.Text;
                            ddd.DOB = TextBox11.Text;
                            if (ddd.DataSaveInpassenger()) { msgbox("Please Note your Login_id: " + TextBox1.Text); Session["ID"] = TextBox1.Text; Session["t"] = "pessenger"; SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                            SqlDataAdapter sda1 = new SqlDataAdapter("update login_table set l='0', history='" + "create " + DateTime.Now.ToString("dd-MMM-yy hh.mm tt") + "' where login_id='" + TextBox1.Text + "' insert into balance (Owner_id,Taka)values('" + TextBox1.Text + "','0')", con1);
                                    DataTable dt1 = new DataTable();
                                    sda1.Fill(dt1); Response.Redirect("user.aspx"); } else { msgbox("Fail"); }
                        }
                    }
                }
                if (TextBox13.Text == "Gov.Stuff" && (TextBox12.Text == "Administrator Head" || TextBox12.Text == "Administrator"))
                {

                    if (TextBox13.Text == "" || TextBox11.Text == "" || TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "" || TextBox4.Text == "" || TextBox5.Text == "" || TextBox6.Text == "" || TextBox7.Text == "" || TextBox8.Text == "" || TextBox10.Text == "" || Image1.ImageUrl == "") { msgbox("Complete all field"); }
                    else
                    {
                        if (TextBox10.Text.Length < 6) { msgbox("Password minimum lenght 6"); }
                        else
                        {

                            Class1 d = new Class1();

                            if (d.QueryInlogin()) { TextBox1.Text = "g-" + d.s_no; }
                            Class1 dd = new Class1();
                            dd.login_id = TextBox1.Text;
                            dd.log_type = TextBox13.Text;
                            dd.log_password = TextBox10.Text;
                            if (dd.DataSaveInlogin_table()) { } else { }
                            Class1 ddd = new Class1();
                            ddd.Stuff_id = TextBox1.Text;
                            ddd.Name = TextBox2.Text;
                            ddd.picture = Image1.ImageUrl;
                            ddd.Contact_number = TextBox3.Text;
                            ddd.Emargency_contact_No = TextBox4.Text;
                            ddd.Email_id = TextBox5.Text;
                            ddd.Current_address = TextBox6.Text;
                            ddd.Permanent_address = TextBox7.Text;
                            ddd.Country = TextBox8.Text;
                            ddd.DOB = TextBox11.Text;
                            if (ddd.DataSaveInGov())
                                {
                                    msgbox("Please Note  Login_id: " + TextBox1.Text);
                                    SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                                    SqlDataAdapter sda1 = new SqlDataAdapter("update login_table set l='0',history='" + "create " + DateTime.Now.ToString("dd-MMM-yy hh.mm tt") + "' where login_id='" + TextBox1.Text + "'", con1);
                                    DataTable dt1 = new DataTable();
                                    sda1.Fill(dt1);
                                    SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                                    SqlDataAdapter sda = new SqlDataAdapter("update Gov set add_by='" + Session["id"].ToString() + DateTime.Now.ToString(" dd-MMM-yy hh:mm tt") + "' where Stuff_id='" + TextBox1.Text + "' insert into balance (Owner_id,Taka)values('" + TextBox1.Text + "','0')", con);
                                    DataTable dt = new DataTable();
                                    sda.Fill(dt);
                                } else { msgbox("Fail"); }
                        }
                    }
                }
                //  else { msgbox("not permission"); }

                if (TextBox13.Text == "owner")
                {

                    if (TextBox13.Text == "" || TextBox11.Text == "" || TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "" || TextBox4.Text == "" || TextBox5.Text == "" || TextBox6.Text == "" || TextBox7.Text == "" || TextBox8.Text == "" || TextBox10.Text == "" || Image1.ImageUrl == "") { msgbox("Complete all field"); }
                    else
                    {
                        if (TextBox10.Text.Length < 6) { msgbox("Password minimum lenght 6"); }
                        else
                        {

                            Class1 d = new Class1();

                            if (d.QueryInlogin()) { TextBox1.Text = "w-" + d.s_no; }

                            Class1 dd = new Class1();
                            dd.login_id = TextBox1.Text;
                            dd.log_type = TextBox13.Text;
                            dd.log_password = TextBox10.Text;
                            if (dd.DataSaveInlogin_table()) { } else { }
                            Class1 ddd = new Class1();
                            ddd.Owner_id = TextBox1.Text;
                            ddd.Name = TextBox2.Text;
                            ddd.picture = Image1.ImageUrl;
                            ddd.Contact_number = TextBox3.Text;
                            ddd.Emargency_contact_No = TextBox4.Text;
                            ddd.Email_id = TextBox5.Text;
                            ddd.Current_address = TextBox6.Text;
                            ddd.Permanent_address = TextBox7.Text;
                            ddd.Country = TextBox8.Text;
                            ddd.DOB = TextBox11.Text;
                            if (ddd.DataSaveInowner()) { msgbox("Please Note your Login_id: " + TextBox1.Text); Session["ID"] = TextBox1.Text; Session["t"] = "owner"; SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                            SqlDataAdapter sda1 = new SqlDataAdapter("update login_table set l='0',history='" + "create " + DateTime.Now.ToString("dd-MMM-yy hh.mm tt") + "' where login_id='" + TextBox1.Text + "' insert into balance (Owner_id,Taka)values('" + TextBox1.Text + "','0')", con1);
                                    DataTable dt1 = new DataTable();
                                    sda1.Fill(dt1); Response.Redirect("user.aspx"); } else { msgbox("Fail"); }
                        }
                    }
                }
                if (TextBox12.Text == "owner" && Request.QueryString.ToString() == "Driver")
                {
                    CheckBox1.Enabled = false; CheckBox2.Enabled = false;
                    if (TextBox13.Text == "" || TextBox11.Text == "" || TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "" || TextBox4.Text == "" || TextBox5.Text == "" || TextBox6.Text == "" || TextBox7.Text == "" || TextBox8.Text == "" || TextBox10.Text == "" || Image1.ImageUrl == "") { msgbox("Complete all field"); }
                    else
                    {
                        if (TextBox10.Text.Length < 6) { msgbox("Password minimum lenght 6"); }
                        else
                        {

                            Class1 d = new Class1();

                            if (d.QueryInlogin()) { TextBox1.Text = "d-" + d.s_no; }

                            Class1 dd = new Class1();
                            dd.login_id = TextBox1.Text;
                            dd.log_type = "driver";
                            dd.log_password = TextBox10.Text;
                            if (dd.DataSaveInlogin_table()) { } else { }

                            Class1 ddd = new Class1();
                            ddd.Stuff_id = TextBox1.Text;
                            ddd.Name = TextBox2.Text;
                            ddd.picture = Image1.ImageUrl;
                            ddd.Contact_number = TextBox3.Text;
                            ddd.Emargency_contact_No = TextBox4.Text;
                            ddd.Email_id = TextBox5.Text;
                            ddd.Current_address = TextBox6.Text;
                            ddd.Permanent_address = TextBox7.Text;
                            ddd.Country = TextBox8.Text;
                            ddd.DOB = TextBox11.Text;
                            ddd.Stuff_Type = "driver";
                            if (ddd.DataSaveInstuff()) { }
                            Class1 dddd = new Class1();
                            dddd.Owner_id = TextBox14.Text;
                            dddd.Stuff_id = TextBox1.Text;
                            dddd.Register_date = TextBox15.Text;
                            if (dddd.DataSaveInappoint()) { msgbox("Please Note  Login_id: " + TextBox1.Text); SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                            SqlDataAdapter sda1 = new SqlDataAdapter("update login_table set l='0',history='" + "create " + DateTime.Now.ToString("dd-MMM-yy hh.mm tt") + "' where login_id='" + TextBox1.Text + "' insert into balance (Owner_id,Taka)values('" + TextBox1.Text + "','0')", con1);
                                    DataTable dt1 = new DataTable();
                                    sda1.Fill(dt1);
                                } else { msgbox("Fail"); }
                        }
                    }
                }
                if (TextBox12.Text == "owner" && Request.QueryString.ToString() == "Helper")
                {
                    CheckBox1.Enabled = false; CheckBox2.Enabled = false;
                    if (TextBox13.Text == "" || TextBox11.Text == "" || TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "" || TextBox4.Text == "" || TextBox5.Text == "" || TextBox6.Text == "" || TextBox7.Text == "" || TextBox8.Text == "" || TextBox10.Text == "" || Image1.ImageUrl == "") { msgbox("Complete all field"); }
                    else
                    {
                        if (TextBox10.Text.Length < 6) { msgbox("Password minimum lenght 6"); }
                        else
                        {

                            Class1 d = new Class1();

                            if (d.QueryInlogin()) { TextBox1.Text = "h-" + d.s_no; }

                            Class1 dd = new Class1();
                            dd.login_id = TextBox1.Text;
                            dd.log_type = "Helper";
                            dd.log_password = TextBox10.Text;
                            if (dd.DataSaveInlogin_table()) { } else { }

                            Class1 ddd = new Class1();
                            ddd.Stuff_id = TextBox1.Text;
                            ddd.Name = TextBox2.Text;
                            ddd.picture = Image1.ImageUrl;
                            ddd.Contact_number = TextBox3.Text;
                            ddd.Emargency_contact_No = TextBox4.Text;
                            ddd.Email_id = TextBox5.Text;
                            ddd.Current_address = TextBox6.Text;
                            ddd.Permanent_address = TextBox7.Text;
                            ddd.Country = TextBox8.Text;
                            ddd.DOB = TextBox11.Text;
                            ddd.Stuff_Type = "Helper";
                            if (ddd.DataSaveInstuff()) { }
                            Class1 dddd = new Class1();
                            dddd.Owner_id = TextBox14.Text;
                            dddd.Stuff_id = TextBox1.Text;
                            dddd.Register_date = TextBox15.Text;
                            if (dddd.DataSaveInappoint()) { msgbox("Please Note  Login_id: " + TextBox1.Text); SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                            SqlDataAdapter sda1 = new SqlDataAdapter("update login_table set l='0',history='" + "create " + DateTime.Now.ToString("dd-MMM-yy hh.mm tt") + "' where login_id='" + TextBox1.Text + "' insert into balance (Owner_id,Taka)values('" + TextBox1.Text + "','0')", con1);
                                    DataTable dt1 = new DataTable();
                                    sda1.Fill(dt1);
                                } else { msgbox("Fail"); }
                        }
                    }
                }
                if (TextBox12.Text == "owner" && Request.QueryString.ToString() == "Counter_Stuff")
                {
                    CheckBox1.Enabled = false; CheckBox2.Enabled = false;
                    if (TextBox13.Text == "" || TextBox11.Text == "" || TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "" || TextBox4.Text == "" || TextBox5.Text == "" || TextBox6.Text == "" || TextBox7.Text == "" || TextBox8.Text == "" || TextBox10.Text == "" || Image1.ImageUrl == "") { msgbox("Complete all field"); }
                    else
                    {
                        if (TextBox10.Text.Length < 6) { msgbox("Password minimum lenght 6"); }
                        else
                        {

                            Class1 d = new Class1();

                            if (d.QueryInlogin()) { TextBox1.Text = "c-" + d.s_no; }

                            Class1 dd = new Class1();
                            dd.login_id = TextBox1.Text;
                            dd.log_type = "Counter_Stuff";
                            dd.log_password = TextBox10.Text;
                            if (dd.DataSaveInlogin_table()) { } else { }

                            Class1 ddd = new Class1();
                            ddd.Stuff_id = TextBox1.Text;
                            ddd.Name = TextBox2.Text;
                            ddd.picture = Image1.ImageUrl;
                            ddd.Contact_number = TextBox3.Text;
                            ddd.Emargency_contact_No = TextBox4.Text;
                            ddd.Email_id = TextBox5.Text;
                            ddd.Current_address = TextBox6.Text;
                            ddd.Permanent_address = TextBox7.Text;
                            ddd.Country = TextBox8.Text;
                            ddd.DOB = TextBox11.Text;
                            ddd.Stuff_Type = "Counter_Stuff";
                            if (ddd.DataSaveInstuff()) { }
                            Class1 dddd = new Class1();
                            dddd.Owner_id = TextBox14.Text;
                            dddd.Stuff_id = TextBox1.Text;
                            dddd.Register_date = TextBox15.Text;
                            if (dddd.DataSaveInappoint()) { msgbox("Please Note  Login_id: " + TextBox1.Text); SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                            SqlDataAdapter sda1 = new SqlDataAdapter("update login_table set l='0',history='" + "create " + DateTime.Now.ToString("dd-MMM-yy hh.mm tt") + "' where login_id='" + TextBox1.Text + "' insert into balance (Owner_id,Taka)values('" + TextBox1.Text + "','0')", con1);
                                    DataTable dt1 = new DataTable();
                                    sda1.Fill(dt1);
                                } else { msgbox("Fail"); }
                        }
                    }
                }
            }
            else { msgbox("check contact number"); }
            }
            else { msgbox("Complete all filed properly and  after apply Collect verification code from email and SMS"); }
          
        }

            protected void TextBox10_TextChanged(object sender, EventArgs e)
            {

            }

            protected void Button2_Click(object sender, CommandEventArgs e)
            {

            }

            protected void Button3_Click(object sender, EventArgs e)
            {
                if (Session["ID"] != null)
                {
                    Class1 ss = new Class1();
                    ss.login_id = Session["ID"].ToString();
                    if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
                    if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
                }
                Response.Redirect("user.aspx");
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
                if(Session["ID"]!=null)
                {
                    Class1 ss = new Class1();
                    ss.login_id = Session["ID"].ToString();
                    if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
                    if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }

                    SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                    SqlDataAdapter sda = new SqlDataAdapter("update login_table set e_h='1' ,l='1' where login_id='" + Session["ID"].ToString() + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                }
            }

            protected void Timer2_Tick(object sender, EventArgs e)
            {
               
              try
                {
                    int aae, bae, cae;
                    aae = int.Parse(DateTime.Now.ToString("ssmmss"));
                    bae = int.Parse(DateTime.Now.ToString("ssssmm"));
                    cae = aae + bae;
                    Session["e"] = cae.ToString(); string number = TextBox4.Text;
                 //string message = "Hi I am your administrator. Welcome to our Digital World and your Contact number Verification code is: " + ca.ToString() + " .Please do no share this code with other" ;
                   string message = "Hi I am administrator from online bus counter.Some one try to use your contact number as relative's contact number and Verification code is: " + cae.ToString() ;
                  
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
                    Timer2.Enabled = false;
                    Button2.Text = "verify";
                    TextBox10.Enabled = true;
                    TextBox20.Enabled = true;
                    TextBox21.Enabled = true;
                    TextBox22.Enabled = true;

                    TextBox2.Enabled = false;
                    TextBox3.Enabled = false;
                    TextBox4.Enabled = false;
                    TextBox5.Enabled = false;
                    TextBox6.Enabled = false;
                    TextBox7.Enabled = false;
                    CheckBox1.Enabled = false;
                    CheckBox2.Enabled = false;
                    Button1.Enabled = false;
                    FileUpload1.Enabled = false;
                  
                }
              catch { msgbox("our system is updating. Please try again later"); Button2.Text = "Apply"; Timer2.Enabled = false; }
            }
    }
}