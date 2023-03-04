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


namespace WebApplication1
{
    public partial class email : System.Web.UI.Page
    {
        public void b()
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda = new SqlDataAdapter("select *from email where r='" + Session["ID"].ToString() + "' or r='Admin' order by st desc", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Repeater1.DataSource = dt;
            Repeater1.DataBind();
            SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda1 = new SqlDataAdapter("select *from email where s='" + Session["ID"].ToString() + "' order by st desc ", con1);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            Repeater3.DataSource = dt1;
            Repeater3.DataBind();
        }
        public void a()
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda = new SqlDataAdapter("select *from email where r='" + Session["ID"].ToString() + "' order by st desc", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Repeater1.DataSource = dt;
            Repeater1.DataBind();

            SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda1 = new SqlDataAdapter("select *from email where s='" + Session["ID"].ToString() + "' order by st desc", con1);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            Repeater3.DataSource = dt1;
            Repeater3.DataBind();
        }

        private void msgbox(string msg) { ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "CallMyFunction", "alert('"+msg+"')", true); }
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
                TextBox4.Text = Session["t"].ToString();

                if (TextBox4.Text.StartsWith("a") || TextBox4.Text.StartsWith("A"))
                {
                   
                    TextBox2.Enabled = true;
                    b();
                    
                }
                else
                {
                    Label2.Visible = false;
                    TextBox2.Visible = false; TextBox2.Enabled = false; TextBox2.Text = "Admin"; a();
                }
               
              
            }
            else { Response.Redirect("home.aspx"); }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
              
            if (TextBox4.Text.StartsWith("a") || TextBox4.Text.StartsWith("A"))
            {
               
              
              
                try
                {
                    using (MailMessage mm = new MailMessage("jisanrahman1996@gmail.com", TextBox2.Text))
                    {
                        mm.Subject = "External Email of Online Bus Counter";
                        mm.Body = "Sender ID : " + Session["ID"].ToString() + ". " + TextBox3.Text;

                        mm.IsBodyHtml = false;
                        SmtpClient smtp = new SmtpClient();
                        smtp.Host = "smtp.gmail.com";
                        smtp.EnableSsl = true;
                        NetworkCredential NetworkCred = new NetworkCredential("jisanrahman1996@gmail.com", "199601687602005");
                        smtp.UseDefaultCredentials = true;
                        smtp.Credentials = NetworkCred;
                        smtp.Port = 587;
                        smtp.Send(mm);
                        msgbox("success");

                    }
                }
                catch { msgbox("insert valid email"); }
                
             
                TextBox5.Text = "";
                TextBox2.Text = "";
                TextBox2.Visible = true;
                TextBox5.Visible = false;
            }
            else { msgbox("No permission"); }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
              
            if (TextBox4.Text.StartsWith("a") || TextBox4.Text.StartsWith("A"))
            {
               
                    try
                    {
                        SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                        SqlDataAdapter sda = new SqlDataAdapter("insert into email (s,r,i,d,st)values('" + Session["ID"].ToString() + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + DateTime.Now.ToString("MMM-dd-yy hh:mm tt") + "','not read')", con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                       b();
                        msgbox("Send");
                    }
                    catch {  b(); msgbox("Fail"); }
              
            }
          else
            {
                if (TextBox2.Text.StartsWith("a") || TextBox2.Text.StartsWith("A"))
                {

                    try
                    {
                        SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                        SqlDataAdapter sda = new SqlDataAdapter("insert into email (s,r,i,d,st)values('" + Session["ID"].ToString() + "','Admin','" + TextBox3.Text + "','" + DateTime.Now.ToString("MMM-dd-yy hh:mm tt") + "','not read')", con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        a();
                        msgbox("Send");
                    }
                    catch { a(); msgbox("Fail"); }
                }
                else { msgbox("You can send mail only to administrator"); }
                
            }
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            a(); if (TextBox4.Text.StartsWith("a") || TextBox4.Text.StartsWith("A"))
            {
               
                b();

            }
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            int rowid = (e.Item.ItemIndex);
            TextBox t1 = (TextBox)Repeater1.Items[rowid].FindControl("TextBox1") as TextBox;





            SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda = new SqlDataAdapter("update email set st='"+DateTime.Now.ToString("hh:mm tt dd-mm-yy ")+Session["ID"].ToString()+" "+"' where sl='"+t1.Text+"'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            a(); if (TextBox4.Text.StartsWith("a") || TextBox4.Text.StartsWith("A"))
            {

                b();

            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
              
            Response.Redirect("user.aspx");
        }

        protected void Timer2_Tick(object sender, EventArgs e)
        {
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
               
        }

        protected void Timer2_Tick1(object sender, EventArgs e)
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