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
using System.Data.Sql;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class Change : System.Web.UI.Page
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
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
              
            if (Session["ID"] != null)
            {
                TextBox1.Text = Session["ID1"].ToString();
                SqlConnection con1111 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1111 = new SqlDataAdapter("select * from log_his where id='"+TextBox1.Text+"' order by s_no desc", con1111);
                DataTable dt1111 = new DataTable();
                sda1111.Fill(dt1111);
                Repeater1.DataSource = dt1111;
                Repeater1.DataBind();
            }
            else { Response.Redirect("home.aspx"); }
            Class1 d = new Class1();
            d.login_id = TextBox1.Text;
            if (d.QueryInlogin01()) { TextBox6.Text = d.log_type; }
        }
        private SerialPort _serialPort;
        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox12.Text = "";
            TextBox13.Text = "";
            TextBox3.Enabled = true;
            TextBox4.Enabled = true;
            TextBox12.Enabled = false;
            TextBox13.Enabled = false;
            Class1 dr = new Class1();
            dr.login_id = TextBox1.Text;
            dr.log_password = TextBox8.Text;
            if (dr.QueryInlogin1())
            {
                //Session["wcn"] = TextBox3.Text;
                //Session["wce"] = TextBox4.Text;
                if (TextBox2.Text != Session["wce"].ToString())
                {
                    Class1 ss = new Class1();
                    ss.login_id = Session["ID"].ToString();
                    if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
                    if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }

                    if (TextBox2.Text.Length != 11) { msgbox("check number"); }
                    if (Button1.Text == "Apply")
                    {
                        int a, b, c;
                        a = int.Parse(DateTime.Now.ToString("mmssss"));
                        b = int.Parse(DateTime.Now.ToString("ssmmss"));
                        c = a + b;
                        try
                        {
                            string number = TextBox2.Text;
                            string message = "Hi! we are from online bus counter and your contact number verification code: " + c.ToString();
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
                            TextBox2.Enabled = false;
                            TextBox11.Enabled = true;
                        }
                        catch { msgbox("our system is updating. Please try again later"); }

                        Session["con"] = c.ToString();
                        Button1.Text = "Change";
                    }

                    if (TextBox11.Text == Session["con"].ToString() && Button1.Text == "Change" && TextBox2.Text.Length == 11)
                    {
                        Button1.Text = "Apply";
                        TextBox2.Enabled = true;
                        TextBox11.Enabled = false;
                        TextBox11.Text = "";

                        if (TextBox6.Text == "pessenger")
                        {
                            SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                            SqlDataAdapter sda = new SqlDataAdapter("update pessenger_id set Contact_number='" + TextBox2.Text + "' where pessenger_id='" + TextBox1.Text + "'", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            TextBox2.Text = "";
                        }
                        if (TextBox6.Text == "Administrator Head" || TextBox6.Text == "Administrator")
                        {
                            SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                            SqlDataAdapter sda = new SqlDataAdapter("update administrator set Contact_number='" + TextBox2.Text + "' where admin_id='" + TextBox1.Text + "'", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            TextBox2.Text = "";
                        }
                        if (TextBox6.Text == "Gov.Stuff")
                        {
                            SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                            SqlDataAdapter sda = new SqlDataAdapter("update gov set Contact_number='" + TextBox2.Text + "' where Stuff_id='" + TextBox1.Text + "'", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            TextBox2.Text = "";
                        }
                        if (TextBox6.Text == "owner")
                        {
                            SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                            SqlDataAdapter sda = new SqlDataAdapter("update b_owner set Contact_number='" + TextBox2.Text + "' where Owner_id='" + TextBox1.Text + "'", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            TextBox2.Text = "";
                        }
                        if (TextBox6.Text == "driver" || TextBox6.Text == "Counter_Stuff" || TextBox6.Text == "Helper")
                        {
                            SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                            SqlDataAdapter sda = new SqlDataAdapter("update stuff_ set Contact_number='" + TextBox2.Text + "' where Stuff_id='" + TextBox1.Text + "'", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            TextBox2.Text = "";
                        }
                        Session["wcn"] = TextBox2.Text;
                    }
                    else { msgbox("Please check code to your mobile"); }
                }
                else { msgbox("This number use as Emergency Contact Number"); }
            }
            else { msgbox("password not match"); }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox2.Text = "";
            TextBox4.Text = "";
            TextBox11.Text = "";
            TextBox13.Text = "";
            TextBox2.Enabled = true;
            TextBox4.Enabled = true;
            TextBox11.Enabled = false;
            TextBox13.Enabled = false;
            //Session["wcn"] = TextBox3.Text;
            //Session["wce"] = TextBox4.Text;
             Class1 dr = new Class1();
            dr.login_id = TextBox1.Text;
            dr.log_password = TextBox8.Text;
            if (dr.QueryInlogin1())
            {
                if (TextBox3.Text != Session["wcn"].ToString())
                {
                    Class1 ss = new Class1();
                    ss.login_id = Session["ID"].ToString();
                    if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
                    if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }

                    if (TextBox3.Text.Length != 11) { msgbox("check number"); }
                    if (Button2.Text == "Apply")
                    {
                        int a, b, c;
                        a = int.Parse(DateTime.Now.ToString("mmssss"));
                        b = int.Parse(DateTime.Now.ToString("ssmmss"));
                        c = a + b;
                        try
                        {
                            string number = TextBox3.Text;
                            string message = "Hi! we are from online bus counter.Some one try to use your contact number as relative's contact number verification code: " + c.ToString();
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
                            TextBox3.Enabled = false;
                            TextBox12.Enabled = true;
                        }
                        catch { msgbox("our system is updating. Please try again later"); }

                        Session["em"] = c.ToString();
                        Button2.Text = "Change";
                    }

                    if (TextBox12.Text == Session["em"].ToString() && Button2.Text == "Change" && TextBox3.Text.Length == 11)
                    {
                        Button2.Text = "Apply";
                        TextBox3.Enabled = true;
                        TextBox12.Enabled = false;
                        TextBox12.Text = "";

                        if (TextBox6.Text == "pessenger")
                        {
                            SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                            SqlDataAdapter sda = new SqlDataAdapter("update pessenger_id set Emargency_contact_No='" + TextBox3.Text + "'where pessenger_id='" + TextBox1.Text + "'", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            TextBox3.Text = "";
                        }
                        if (TextBox6.Text == "Administrator Head" || TextBox6.Text == "Administrator")
                        {
                            SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                            SqlDataAdapter sda = new SqlDataAdapter("update administrator set Emargency_contact_No='" + TextBox3.Text + "'where admin_id='" + TextBox1.Text + "'", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            TextBox3.Text = "";
                        }
                        if (TextBox6.Text == "Gov.Stuff")
                        {
                            SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                            SqlDataAdapter sda = new SqlDataAdapter("update gov set Emargency_contact_No='" + TextBox3.Text + "'where Stuff_id='" + TextBox1.Text + "'", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            TextBox3.Text = "";
                        }
                        if (TextBox6.Text == "owner")
                        {
                            SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                            SqlDataAdapter sda = new SqlDataAdapter("update b_owner set Emargency_contact_No='" + TextBox3.Text + "'where Owner_id='" + TextBox1.Text + "'", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            TextBox3.Text = "";
                        }
                        if (TextBox6.Text == "driver" || TextBox6.Text == "Counter_Stuff" || TextBox6.Text == "Helper")
                        {
                            SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                            SqlDataAdapter sda = new SqlDataAdapter("update stuff_ set Emargency_contact_No='" + TextBox3.Text + "'where Stuff_id='" + TextBox1.Text + "'", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            TextBox3.Text = "";
                        }
                        Session["wce"] = TextBox3.Text;
                    }
                    else { msgbox("collect code from your relative number"); }
                }
                else { msgbox("This number use as Contact Number"); }
            }
            else { msgbox("password not match"); }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox11.Text = "";
            TextBox12.Text = "";
            TextBox2.Enabled = true;
            TextBox3.Enabled = true;
            TextBox11.Enabled = false;
            TextBox12.Enabled = false;
            Class1 dr = new Class1();
            dr.login_id = TextBox1.Text;
            dr.log_password = TextBox8.Text;
            if (dr.QueryInlogin1())
            {
                Class1 ss = new Class1();
                ss.login_id = Session["ID"].ToString();
                if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
                if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }

                if (Button3.Text == "Apply")
                {
                    int a, b, c;
                    a = int.Parse(DateTime.Now.ToString("mmssss"));
                    b = int.Parse(DateTime.Now.ToString("ssmmss"));
                    c = a + b;

                    using (MailMessage mm = new MailMessage("jisanrahman1996@gmail.com", TextBox4.Text))
                    {
                        mm.Subject = "change email";
                        mm.Body = "your code is: " + c.ToString(); ;

                        mm.IsBodyHtml = false;
                        SmtpClient smtp = new SmtpClient();
                        smtp.Host = "smtp.gmail.com";
                        smtp.EnableSsl = true;
                        NetworkCredential NetworkCred = new NetworkCredential("jisanrahman1996@gmail.com", "199601687602005");
                        smtp.UseDefaultCredentials = true;
                        smtp.Credentials = NetworkCred;
                        smtp.Port = 587;
                        smtp.Send(mm);
                        TextBox4.Enabled = false;
                        TextBox13.Enabled = true;
                    }
                    Session["e"] = c.ToString();
                    Button3.Text = "Change";
                }

                if (TextBox13.Text == Session["e"].ToString() && Button3.Text == "Change")
                {
                    Button3.Text = "Apply";
                    TextBox4.Enabled = true;
                    TextBox13.Enabled = false;
                    TextBox13.Text = "";
                    if (TextBox6.Text == "pessenger")
                    {
                        SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                        SqlDataAdapter sda = new SqlDataAdapter("update pessenger_id set Email_id='" + TextBox4.Text + "' where pessenger_id='" + TextBox1.Text + "'", con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        TextBox4.Text = "";
                    }
                    if (TextBox6.Text == "Administrator Head" || TextBox6.Text == "Administrator")
                    {
                        SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                        SqlDataAdapter sda = new SqlDataAdapter("update administrator  set Email_id='" + TextBox4.Text + "' where admin_id='" + TextBox1.Text + "'", con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        TextBox4.Text = "";
                    }
                    if (TextBox6.Text == "Gov.Stuff")
                    {
                        SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                        SqlDataAdapter sda = new SqlDataAdapter("update gov set Email_id='" + TextBox4.Text + "' where Stuff_id='" + TextBox1.Text + "'", con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        TextBox4.Text = "";
                    }
                    if (TextBox6.Text == "owner")
                    {
                        SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                        SqlDataAdapter sda = new SqlDataAdapter("update b_owner set Email_id='" + TextBox4.Text + "' where Owner_id='" + TextBox1.Text + "'", con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        TextBox4.Text = "";
                    }
                    if (TextBox6.Text == "driver" || TextBox6.Text == "Counter_Stuff" || TextBox6.Text == "Helper")
                    {
                        SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                        SqlDataAdapter sda = new SqlDataAdapter("update stuff_ set Email_id='" + TextBox4.Text + "' where Stuff_id='" + TextBox1.Text + "'", con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        TextBox4.Text = "";
                    }
                }
                else { msgbox("check code in email"); }
            }
            else { msgbox("password not match"); }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
              
            if (TextBox6.Text == "pessenger")
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda = new SqlDataAdapter("update pessenger_id  set Current_address='" + TextBox5.Text + "' where pessenger_id='" + TextBox1.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                TextBox5.Text = "";
            }
            if (TextBox6.Text == "Administrator Head" || TextBox6.Text == "Administrator")
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda = new SqlDataAdapter("update administrator  set Current_address='" + TextBox5.Text + "' where admin_id='" + TextBox1.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                TextBox5.Text = "";
            }
            if (TextBox6.Text == "Gov.Stuff")
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda = new SqlDataAdapter("update gov  set Current_address='" + TextBox5.Text + "' where Stuff_id='" + TextBox1.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                TextBox5.Text = "";
            }
            if (TextBox6.Text == "owner")
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda = new SqlDataAdapter("update b_owner  set Current_address='" + TextBox5.Text + "' where Owner_id='" + TextBox1.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                TextBox5.Text = "";
            }
            if (TextBox6.Text == "driver" || TextBox6.Text == "Counter_Stuff" || TextBox6.Text == "Helper")
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda = new SqlDataAdapter("update stuff_  set Current_address='" + TextBox5.Text + "' where Stuff_id='" + TextBox1.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                TextBox5.Text = "";
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
              
            string s = "";
            string f = System.IO.Path.GetExtension(FileUpload1.FileName);

            if (f.ToLower() != ".jpg") { msgbox("Select .jpg file first"); }
            else
            {

                if (FileUpload1.FileName == "") { }
                else
                {
                    Class1 d = new Class1();

                    if (d.QueryInlogin()) { s = d.s_no + "-"; }

                    FileUpload1.SaveAs(Server.MapPath("~/upload/" + s + FileUpload1.FileName));
                    TextBox7.Text = "~/upload/" + s + FileUpload1.FileName;
                }


                if (TextBox6.Text == "pessenger")
                {
                    SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                    SqlDataAdapter sda = new SqlDataAdapter("update pessenger_id set picture='" + TextBox7.Text + "' where pessenger_id='" + TextBox1.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                }
                if (TextBox6.Text == "Administrator Head" || TextBox6.Text == "Administrator")
                {
                    SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                    SqlDataAdapter sda = new SqlDataAdapter("update administrator  set picture='" + TextBox7.Text + "' where admin_id='" + TextBox1.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                }
                if (TextBox6.Text == "Gov.Stuff")
                {
                    SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                    SqlDataAdapter sda = new SqlDataAdapter("update gov set picture='" + TextBox7.Text + "' where Stuff_id='" + TextBox1.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                }
                if (TextBox6.Text == "owner")
                {
                    SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                    SqlDataAdapter sda = new SqlDataAdapter("update b_owner set picture='" + TextBox7.Text + "' where Owner_id='" + TextBox1.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                }
                if (TextBox6.Text == "driver" || TextBox6.Text == "Counter_Stuff" || TextBox6.Text == "Helper")
                {
                    SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                    SqlDataAdapter sda = new SqlDataAdapter("update stuff_ set picture='" + TextBox7.Text + "' where Stuff_id='" + TextBox1.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                }
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
              
            Session["ID1"] = "";
                Response.Redirect("user.aspx");
            
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
              
            if (TextBox9.Text.Length >5)
            {
                Class1 d = new Class1();
                d.login_id = TextBox1.Text;
                d.log_password = TextBox8.Text;
                if (d.QueryInlogin1())
                {
                    TextBox10.Text = d.log_type;
                    SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                    SqlDataAdapter sda = new SqlDataAdapter("update login_table set log_password='" + TextBox9.Text + "' where login_id='" + TextBox1.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                }
                else { msgbox("Current password do not match"); }
            }
            else { msgbox("Password length minimum 6 require"); }
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
              
            SqlConnection con111 = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda111 = new SqlDataAdapter("update login_table set v_code='" + Session["vv"].ToString() + "' where login_id='" + Session["ID"].ToString() + "'", con111);
            DataTable dt111 = new DataTable();
            sda111.Fill(dt111);
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }

            Class1 dr = new Class1();
            dr.login_id = TextBox1.Text;
            dr.log_password = TextBox8.Text;
            if (dr.QueryInlogin1())
            {

                SqlConnection con111 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda111 = new SqlDataAdapter("update login_table set v_code='' where login_id='" + Session["ID"].ToString() + "'", con111);
                DataTable dt111 = new DataTable();
                sda111.Fill(dt111);
            }
            else { msgbox("Password not match"); }
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
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }

            SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda = new SqlDataAdapter("update login_table set e_h='1',l='1' where login_id='" + Session["ID"].ToString() + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
        }
    }
}