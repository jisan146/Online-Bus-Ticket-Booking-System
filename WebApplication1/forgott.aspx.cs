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
    public partial class forgott : System.Web.UI.Page
    {
      
        protected void Page_Load(object sender, EventArgs e)
        {
          

        }
        private void msgbox(string msg) { ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "CallMyFunction", "alert('" + msg + "')", true); }
        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox6.Text = DropDownList1.Text;
            if (CheckBox1.Checked && (CheckBox2.Checked || CheckBox3.Checked || CheckBox4.Checked)) { msgbox("if you want to search by ticket please select only ticket"); }
            if (CheckBox1.Checked && TextBox5.Text!="")
            {
                SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1 = new SqlDataAdapter("select pessenger_id from ticket where sL='" + TextBox5.Text + "'", con1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                GridView1.DataSource = dt1;
                GridView1.DataBind();
                this.GridView1.SelectedIndex = 0;
                int a;
                a = int.Parse(GridView1.Rows.Count.ToString());
                if (a > 0) 
                {
                    TextBox8.Text = this.GridView1.Rows[this.GridView1.SelectedIndex].Cells[0].Text;
                }
            }
            if (CheckBox1.Checked && TextBox8.Text != "" && (TextBox6.Text.StartsWith("p") || TextBox6.Text.StartsWith("P")))
            {
                SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1 = new SqlDataAdapter("select * from pessenger_id where pessenger_id ='"+TextBox8.Text+"'", con1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
            if (CheckBox1.Checked && TextBox8.Text != "" && (TextBox6.Text.StartsWith("A") || TextBox6.Text.StartsWith("a")))
            {
                SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1 = new SqlDataAdapter("select admin_id as pessenger_id ,* from administrator where admin_id ='" + TextBox8.Text + "'", con1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
            if (CheckBox1.Checked && TextBox8.Text != "" && (TextBox6.Text.StartsWith("w") || TextBox6.Text.StartsWith("W")))
            {
                SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1 = new SqlDataAdapter("select owner_id as pessenger_id ,* from b_owner where owner_id ='" + TextBox8.Text + "'", con1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
            if (CheckBox1.Checked && TextBox8.Text != "" && (TextBox6.Text.StartsWith("g") || TextBox6.Text.StartsWith("G")))
            {
                SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1 = new SqlDataAdapter("select stuff_id as pessenger_id ,* from Gov where stuff_id ='" + TextBox8.Text + "'", con1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
            if (CheckBox1.Checked && TextBox8.Text != "" && (TextBox6.Text.StartsWith("h") || TextBox6.Text.StartsWith("H") || TextBox6.Text.StartsWith("d") || TextBox6.Text.StartsWith("D") || TextBox6.Text.StartsWith("c") || TextBox6.Text.StartsWith("C") ))
            {
                SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1 = new SqlDataAdapter("select stuff_id as pessenger_id ,* from stuff_ where stuff_id ='" + TextBox8.Text + "'", con1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }


          
            if (CheckBox1.Checked) { } else { 
            if (CheckBox4.Checked && TextBox2.Text != "" && (TextBox6.Text.StartsWith("p") || TextBox6.Text.StartsWith("P")))
            {
                SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1 = new SqlDataAdapter("select *from pessenger_id where Email_id='"+TextBox2.Text+"'", con1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
            if (CheckBox3.Checked && TextBox2.Text != "" && (TextBox6.Text.StartsWith("p") || TextBox6.Text.StartsWith("P")))
            {
                SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1 = new SqlDataAdapter("select *from pessenger_id where  Contact_number='" + TextBox3.Text + "'", con1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
            if (CheckBox2.Checked && TextBox2.Text != "" && (TextBox6.Text.StartsWith("p") || TextBox6.Text.StartsWith("P")))
            {
                SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1 = new SqlDataAdapter("select *from pessenger_id where Emargency_contact_No='" + TextBox4.Text + "'", con1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
            if (CheckBox4.Checked && CheckBox3.Checked && TextBox2.Text != "" && (TextBox6.Text.StartsWith("p") || TextBox6.Text.StartsWith("P")))
            {
                SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1 = new SqlDataAdapter("select *from pessenger_id where Email_id='" + TextBox2.Text + "' and Contact_number='" + TextBox3.Text + "'", con1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
            if (CheckBox4.Checked && CheckBox3.Checked && CheckBox2.Checked && TextBox2.Text != "" && (TextBox6.Text.StartsWith("p") || TextBox6.Text.StartsWith("P")))
            {
                SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1 = new SqlDataAdapter("select *from pessenger_id where Email_id='" + TextBox2.Text + "' and Contact_number='" + TextBox3.Text + "' and Emargency_contact_No='" + TextBox4.Text + "'", con1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
                
            if (CheckBox4.Checked && TextBox2.Text != "" && (TextBox6.Text.StartsWith("a") || TextBox6.Text.StartsWith("A")))
            {
                SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1 = new SqlDataAdapter("select admin_id as pessenger_id,*from administrator where Email_id='1'", con1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
            if (CheckBox3.Checked && TextBox2.Text != "" && (TextBox6.Text.StartsWith("A") || TextBox6.Text.StartsWith("a")))
            {
                SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1 = new SqlDataAdapter("select admin_id as pessenger_id,*from administrator where  Contact_number='" + TextBox3.Text + "'", con1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
            if (CheckBox2.Checked && TextBox2.Text != "" && (TextBox6.Text.StartsWith("A") || TextBox6.Text.StartsWith("a")))
            {
                SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1 = new SqlDataAdapter("select admin_id as pessenger_id,*from administrator where Emargency_contact_No='" + TextBox4.Text + "'", con1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
            if (CheckBox4.Checked && CheckBox3.Checked && TextBox2.Text != "" && (TextBox6.Text.StartsWith("a") || TextBox6.Text.StartsWith("A")))
            {
                SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1 = new SqlDataAdapter("select admin_id as pessenger_id,*from administrator where Email_id='" + TextBox2.Text + "' and Contact_number='" + TextBox3.Text + "'", con1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
            if (CheckBox4.Checked && CheckBox3.Checked && CheckBox2.Checked && TextBox2.Text != "" && (TextBox6.Text.StartsWith("a") || TextBox6.Text.StartsWith("a")))
            {
                SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1 = new SqlDataAdapter("select admin_id as pessenger_id,*from administrator where Email_id='" + TextBox2.Text + "' and Contact_number='" + TextBox3.Text + "' and Emargency_contact_No='" + TextBox4.Text + "'", con1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
               
            if (CheckBox4.Checked && TextBox2.Text != "" && (TextBox6.Text.StartsWith("g") || TextBox6.Text.StartsWith("G")))
            {
                SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1 = new SqlDataAdapter("select Stuff_id as pessenger_id,*from gov where Email_id='1'", con1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
            if (CheckBox3.Checked && TextBox2.Text != "" && (TextBox6.Text.StartsWith("g") || TextBox6.Text.StartsWith("G")))
            {
                SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1 = new SqlDataAdapter("select Stuff_id as pessenger_id,*from gov where  Contact_number='" + TextBox3.Text + "'", con1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
            if (CheckBox2.Checked && TextBox2.Text != "" && (TextBox6.Text.StartsWith("g") || TextBox6.Text.StartsWith("G")))
            {
                SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1 = new SqlDataAdapter("select Stuff_id as pessenger_id,*from gov where Emargency_contact_No='" + TextBox4.Text + "'", con1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
            if (CheckBox4.Checked && CheckBox3.Checked && TextBox2.Text != "" && (TextBox6.Text.StartsWith("g") || TextBox6.Text.StartsWith("G")))
            {
                SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1 = new SqlDataAdapter("select Stuff_id as pessenger_id,*from gov where Email_id='" + TextBox2.Text + "' and Contact_number='" + TextBox3.Text + "'", con1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
            if (CheckBox4.Checked && CheckBox3.Checked && CheckBox2.Checked && TextBox2.Text != "" && (TextBox6.Text.StartsWith("g") || TextBox6.Text.StartsWith("G")))
            {
                SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1 = new SqlDataAdapter("select Stuff_id as pessenger_id,*from gov where Email_id='" + TextBox2.Text + "' and Contact_number='" + TextBox3.Text + "' and Emargency_contact_No='" + TextBox4.Text + "'", con1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
               
            if (CheckBox4.Checked && TextBox2.Text != "" && (TextBox6.Text.StartsWith("w") || TextBox6.Text.StartsWith("W")))
            {
                SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1 = new SqlDataAdapter("select Owner_id as pessenger_id,*from b_owner where Email_id='1'", con1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
            if (CheckBox3.Checked && TextBox2.Text != "" && (TextBox6.Text.StartsWith("w") || TextBox6.Text.StartsWith("W")))
            {
                SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1 = new SqlDataAdapter("select Owner_id as pessenger_id,*from b_owner  where  Contact_number='" + TextBox3.Text + "'", con1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
            if (CheckBox2.Checked && TextBox2.Text != "" && (TextBox6.Text.StartsWith("w") || TextBox6.Text.StartsWith("W")))
            {
                SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1 = new SqlDataAdapter("select Owner_id as pessenger_id,*from b_owner  where Emargency_contact_No='" + TextBox4.Text + "'", con1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
            if (CheckBox4.Checked && CheckBox3.Checked && TextBox2.Text != "" && (TextBox6.Text.StartsWith("w") || TextBox6.Text.StartsWith("W")))
            {
                SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1 = new SqlDataAdapter("select Owner_id as pessenger_id,*from b_owner where Email_id='" + TextBox2.Text + "' and Contact_number='" + TextBox3.Text + "'", con1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
            if (CheckBox4.Checked && CheckBox3.Checked && CheckBox2.Checked && TextBox2.Text != "" && (TextBox6.Text.StartsWith("w") || TextBox6.Text.StartsWith("W")))
            {
                SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1 = new SqlDataAdapter("select Owner_id as pessenger_id,*from b_owner where Email_id='" + TextBox2.Text + "' and Contact_number='" + TextBox3.Text + "' and Emargency_contact_No='" + TextBox4.Text + "'", con1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
                /***************************************/
            if (CheckBox4.Checked && TextBox2.Text != "" && (TextBox6.Text.StartsWith("c") || TextBox6.Text.StartsWith("C") || TextBox6.Text.StartsWith("d") || TextBox6.Text.StartsWith("D") || TextBox6.Text.StartsWith("h") || TextBox6.Text.StartsWith("H")))
            {
                SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1 = new SqlDataAdapter("select Stuff_id as pessenger_id,*from stuff_  where Email_id='1'", con1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
            if (CheckBox3.Checked && TextBox2.Text != "" && (TextBox6.Text.StartsWith("c") || TextBox6.Text.StartsWith("C") || TextBox6.Text.StartsWith("d") || TextBox6.Text.StartsWith("D") || TextBox6.Text.StartsWith("h") || TextBox6.Text.StartsWith("H")))
            {
                SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1 = new SqlDataAdapter("select Stuff_id as pessenger_id,*from stuff_  where  Contact_number='" + TextBox3.Text + "'", con1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
            if (CheckBox2.Checked && TextBox2.Text != "" && (TextBox6.Text.StartsWith("c") || TextBox6.Text.StartsWith("C") || TextBox6.Text.StartsWith("d") || TextBox6.Text.StartsWith("D") || TextBox6.Text.StartsWith("h") || TextBox6.Text.StartsWith("H")))
            {
                SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1 = new SqlDataAdapter("select Stuff_id as pessenger_id,*from stuff_  where Emargency_contact_No='" + TextBox4.Text + "'", con1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
            if (CheckBox4.Checked && CheckBox3.Checked && TextBox2.Text != "" && (TextBox6.Text.StartsWith("c") || TextBox6.Text.StartsWith("C") || TextBox6.Text.StartsWith("d") || TextBox6.Text.StartsWith("D") || TextBox6.Text.StartsWith("h") || TextBox6.Text.StartsWith("H")))
            {
                SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1 = new SqlDataAdapter("select Stuff_id as pessenger_id,*from stuff_  where Email_id='" + TextBox2.Text + "' and Contact_number='" + TextBox3.Text + "'", con1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
            if (CheckBox4.Checked && CheckBox3.Checked && CheckBox2.Checked && TextBox2.Text != "" && (TextBox6.Text.StartsWith("c") || TextBox6.Text.StartsWith("C") || TextBox6.Text.StartsWith("d") || TextBox6.Text.StartsWith("D") || TextBox6.Text.StartsWith("h") || TextBox6.Text.StartsWith("H")))
            {
                SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1 = new SqlDataAdapter("select Stuff_id as pessenger_id,*from stuff_  where Email_id='" + TextBox2.Text + "' and Contact_number='" + TextBox3.Text + "' and Emargency_contact_No='" + TextBox4.Text + "'", con1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
                /****************************************/
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            if (CheckBox5.Checked && CheckBox6.Checked) { msgbox("select one"); }else{
            if ( TextBox1.Text != "" && (TextBox1.Text.StartsWith("p") || TextBox1.Text.StartsWith("P")))
            {
                SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1 = new SqlDataAdapter("select Contact_number,Email_id from pessenger_id where pessenger_id ='" + TextBox1.Text + "'", con1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                GridView1.DataSource = dt1;
                GridView1.DataBind();
                this.GridView1.SelectedIndex = 0;
                int a;
                a = int.Parse(GridView1.Rows.Count.ToString());
                if (a > 0)
                {
                    Session["con"] = this.GridView1.Rows[this.GridView1.SelectedIndex].Cells[0].Text;
                    Session["email"] = this.GridView1.Rows[this.GridView1.SelectedIndex].Cells[1].Text;
                }
            }
            if ( TextBox1.Text != "" && (TextBox1.Text.StartsWith("A") || TextBox1.Text.StartsWith("a")))
            {
                SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1 = new SqlDataAdapter("select Contact_number,Email_id from administrator where admin_id ='" + TextBox1.Text + "'", con1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                GridView1.DataSource = dt1;
                GridView1.DataBind();
                this.GridView1.SelectedIndex = 0;
                int a;
                a = int.Parse(GridView1.Rows.Count.ToString());
                if (a > 0)
                {
                    Session["con"] = this.GridView1.Rows[this.GridView1.SelectedIndex].Cells[0].Text;
                    Session["email"] = this.GridView1.Rows[this.GridView1.SelectedIndex].Cells[1].Text;
                }
            }
            if (TextBox1.Text != "" && (TextBox1.Text.StartsWith("w") || TextBox1.Text.StartsWith("W")))
            {
                SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1 = new SqlDataAdapter("select Contact_number,Email_id from b_owner where owner_id ='" + TextBox1.Text + "'", con1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                GridView1.DataSource = dt1;
                GridView1.DataBind();
                this.GridView1.SelectedIndex = 0;
                int a;
                a = int.Parse(GridView1.Rows.Count.ToString());
                if (a > 0)
                {
                    Session["con"] = this.GridView1.Rows[this.GridView1.SelectedIndex].Cells[0].Text;
                    Session["email"] = this.GridView1.Rows[this.GridView1.SelectedIndex].Cells[1].Text;
                }
            }
            if ( TextBox1.Text != "" && (TextBox1.Text.StartsWith("g") || TextBox1.Text.StartsWith("G")))
            {
                SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1 = new SqlDataAdapter("select Contact_number,Email_id from Gov where stuff_id ='" + TextBox1.Text + "'", con1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                GridView1.DataSource = dt1;
                GridView1.DataBind();
                this.GridView1.SelectedIndex = 0;
                int a;
                a = int.Parse(GridView1.Rows.Count.ToString());
                if (a > 0)
                {
                    Session["con"] = this.GridView1.Rows[this.GridView1.SelectedIndex].Cells[0].Text;
                    Session["email"] = this.GridView1.Rows[this.GridView1.SelectedIndex].Cells[1].Text;
                }
            }
            if ( TextBox1.Text != "" && (TextBox1.Text.StartsWith("h") || TextBox1.Text.StartsWith("H") || TextBox1.Text.StartsWith("d") || TextBox1.Text.StartsWith("D") || TextBox1.Text.StartsWith("c") || TextBox1.Text.StartsWith("C")))
            {
                SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1 = new SqlDataAdapter("select Contact_number,Email_id from stuff_ where stuff_id ='" + TextBox1.Text + "'", con1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                GridView1.DataSource = dt1;
                GridView1.DataBind();
                this.GridView1.SelectedIndex = 0;
                int a;
                a = int.Parse(GridView1.Rows.Count.ToString());
                if (a > 0)
                {
                    Session["con"] = this.GridView1.Rows[this.GridView1.SelectedIndex].Cells[0].Text;
                    Session["email"] = this.GridView1.Rows[this.GridView1.SelectedIndex].Cells[1].Text;
                }
            }
            int x, y, z;
            x = int.Parse(DateTime.Now.ToString("ssmmssmm"));
            y = int.Parse(DateTime.Now.ToString("mmssssmm"));
            z = (x + y );
            SqlConnection con1z = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda1z = new SqlDataAdapter("update login_table set reset_code='"+z.ToString()+"' where login_id='" + TextBox1.Text + "'", con1z);
            DataTable dt1z = new DataTable();
            sda1z.Fill(dt1z);
            if (TextBox1.Text != "" && CheckBox5.Checked) { /*Response.Redirect("reset.aspx?a=" + this.TextBox1.Text + "&b=" + z.ToString());*/ 
          /**********************/
                using (MailMessage mm = new MailMessage("jisanrahman1996@gmail.com", Session["email"].ToString()))
                 {
                     mm.Subject = "Online Bus Counter Reset Password";
                     mm.Body = "http://192.168.0.101/reset.aspx?"+"a="+TextBox1.Text+"&b="+z.ToString()+" you can Try menually by this code: "+z.ToString();

                     mm.IsBodyHtml = false;
                     SmtpClient smtp = new SmtpClient();
                     smtp.Host = "smtp.gmail.com";
                     smtp.EnableSsl = true;
                     NetworkCredential NetworkCred = new NetworkCredential("jisanrahman1996@gmail.com", "199601687602005");
                     smtp.UseDefaultCredentials = true;
                     smtp.Credentials = NetworkCred;
                     smtp.Port = 587;
                     smtp.Send(mm); Session["e"] = z.ToString(); Response.Redirect("reset.aspx");
                 }}
              if (TextBox1.Text != "" && CheckBox6.Checked) 
                 {
                      string number = Session["con"].ToString();
                      string message = "http://192.168.0.101/reset.aspx?" + "a=" + TextBox1.Text + "&b=" + z.ToString() + " you can Try menually by this code: " + z.ToString();
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
                        _serialPort.Close(); Session["e"] = z.ToString();
       Response.Redirect("reset.aspx");

                 }
                /***************/
          
            }
            Session["reset"] = "s";
        }
        private SerialPort _serialPort;
        protected void Button4_Click(object sender, EventArgs e)
        {
           
        }

        protected void Button4_Click1(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
        }
    }
}