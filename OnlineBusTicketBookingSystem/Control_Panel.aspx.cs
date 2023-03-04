using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class Control_Panel : System.Web.UI.Page
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
            if (Session["id"] != null)
            {
                if (Session["t"].ToString() == "Administrator Head") { Button9.Visible = true; }
                if (Session["t"].ToString() == "Administrator" || Session["t"].ToString() == "Administrator Head") { } else { Response.Redirect("home.aspx"); }
            }
            else { Response.Redirect("home.aspx"); }
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
              
            GridView2.Visible = false;
            GridView1.Visible = false;
            Class1 d = new Class1();
            d.login_id = TextBox1.Text;
            if (d.QueryInlogin2()) { msgbox(d.log_password); }

            try
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda = new SqlDataAdapter("insert into email (s,r,i,d,st)values('" + Session["ID"].ToString() + "','" + TextBox1.Text + "','Your password shown by Administrator Head.Change your password immediate','" + DateTime.Now.ToString("MMM-dd-yy hh:mm tt") + "','not read')", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
              
              
            }
            catch { msgbox("fail"); }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
              
            GridView2.Visible = false;
            GridView1.Visible = false;
            if (TextBox1.Text != "administrator" || TextBox1.Text != "Administrator")
            {
               
            SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda = new SqlDataAdapter("select history from login_table where login_id='"+TextBox1.Text+"'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            this.GridView1.SelectedIndex = 0;
            string s ;
            s = this.GridView1.Rows[this.GridView1.SelectedIndex].Cells[0].Text;
            SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda1 = new SqlDataAdapter("update login_table set log_type='c',history='"+s+"; "+"close by "+Session["id"].ToString()+" "+DateTime.Now.ToString("dd-MMM-yy hh.mm tt")+ "' where login_id='" + TextBox1.Text + "'", con1);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            }
            else { msgbox("no permission"); }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
              
            GridView2.Visible = false;
            GridView1.Visible = false;
            if (TextBox1.Text != "administrator"|| TextBox1.Text != "Administrator") { 
            string g="";
                SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda = new SqlDataAdapter("select history from login_table where login_id='" + TextBox1.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
                this.GridView1.SelectedIndex = 0;
                string s;
                s = this.GridView1.Rows[this.GridView1.SelectedIndex].Cells[0].Text;
                if (TextBox1.Text.StartsWith("a") || TextBox1.Text.StartsWith("A")) { g = "Administrator"; }
            if (TextBox1.Text.StartsWith("g") || TextBox1.Text.StartsWith("G")) { g = "Gov.Stuff"; }
            if (TextBox1.Text.StartsWith("w") || TextBox1.Text.StartsWith("W")) { g = "owner"; }
            if (TextBox1.Text.StartsWith("c") || TextBox1.Text.StartsWith("C")) { g = "Counter_Stuff"; }
            if (TextBox1.Text.StartsWith("d") || TextBox1.Text.StartsWith("D")) { g = "driver"; }
            if (TextBox1.Text.StartsWith("h") || TextBox1.Text.StartsWith("H")) { g = "Helper"; }
            if (TextBox1.Text.StartsWith("p") || TextBox1.Text.StartsWith("P")) { g = "pessenger"; }
                SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1 = new SqlDataAdapter("update login_table set log_type='" + g + "',history='" + s + "; " + "open by " + Session["id"].ToString() + " " + DateTime.Now.ToString("dd-MMM-yy hh.mm tt") + "' where login_id='" + TextBox1.Text + "'", con1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
            }
            else { msgbox("no permission"); }

        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
              
            GridView2.Visible = false;
            GridView1.Visible = false;
            if (TextBox1.Text != "administrator" || TextBox1.Text != "Administrator")
            {
                if (TextBox13.Text == "all")
                {
                    GridView2.Visible = false;
                    SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                    SqlDataAdapter sda = new SqlDataAdapter("select Date,des as 'Device details' from log_his  where id='" + TextBox1.Text + "'order by s_no", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                    GridView1.Visible = true;
                }else
                {
                    GridView2.Visible = false;
                    SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                    SqlDataAdapter sda = new SqlDataAdapter("select Date,des as 'Devaice details' from log_his  where id='" + TextBox1.Text + "' and date like '%" + TextBox13.Text + " %' order by s_no", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                    GridView1.Visible = true;
                }
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
              
            GridView2.Visible = false;
            GridView1.Visible = false;
            if (TextBox1.Text != "administrator" || TextBox1.Text != "Administrator")
            {
                GridView2.Visible = false;
                if (TextBox9.Text == "all")
                {
                    SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                    SqlDataAdapter sda = new SqlDataAdapter("select ID as Sender, transfer_To as Receiver,Taka,date  from history  where id='" + TextBox1.Text + "' or Transfer_To='" + TextBox1.Text + "' order by sl", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                    GridView1.Visible = true;
                }
                else
                {
                    Class1 m = new Class1();
                    m.ID = TextBox1.Text;
                    m.Date = TextBox9.Text;
                    if (m.QueryInhist()) { TextBox12.Text = m.Taka; }
                    Class1 m1 = new Class1();
                    m1.Transfer_To = TextBox1.Text;
                    m1.Date = TextBox9.Text;
                    if (m1.QueryInhist1()) { TextBox11.Text = m1.Taka; }
                    SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                    SqlDataAdapter sda = new SqlDataAdapter("select ID as Sender, transfer_To as Receiver,Taka,date  from history  where (id='" + TextBox1.Text + "' or Transfer_To='" + TextBox1.Text + "') and date='" + TextBox9.Text + "' order by sl", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                    GridView1.Visible = true;
                }
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
              
            GridView2.Visible = false;
            GridView1.Visible = false;
            if (TextBox1.Text != "administrator" || TextBox1.Text != "Administrator")
            {
                GridView2.Visible = false;
                if (TextBox9.Text == "all")
                {
                    SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                    SqlDataAdapter sda = new SqlDataAdapter("select Bus_License_no,Start_location,End_location,Sit_no,KM,Taka,Travel_date,Stop_time as Time from ticket where pessenger_id='" + TextBox1.Text + "' order by SL", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                    GridView1.Visible = true;
                }
                else
                {
                    SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                    SqlDataAdapter sda = new SqlDataAdapter("select Bus_License_no,Start_location,End_location,Sit_no,KM,Taka,Travel_date,Stop_time as Time from ticket where pessenger_id='" + TextBox1.Text + "' and Travel_date='" + TextBox9.Text + "'  order by SL", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                    GridView1.Visible = true;
                }
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
              
            GridView2.Visible = false;
            GridView1.Visible = false;
            if (TextBox1.Text.StartsWith("a") || TextBox1.Text.StartsWith("A"))
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda = new SqlDataAdapter("select Name,Contact_number,Emargency_contact_No,Email_id,Current_address,Permanent_address,picture from administrator where admin_id='" + TextBox1.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                GridView2.DataSource = dt;
                GridView2.DataBind();
                GridView2.Visible = true;
            }
            if (TextBox1.Text.StartsWith("g") || TextBox1.Text.StartsWith("G"))
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda = new SqlDataAdapter("select add_by ,Name,Contact_number,Emargency_contact_No,Email_id,Current_address,Permanent_address,picture from Gov where Stuff_id='" + TextBox1.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                GridView2.DataSource = dt;
                GridView2.DataBind();
                GridView2.Visible = true;
            }
            if (TextBox1.Text.StartsWith("w") || TextBox1.Text.StartsWith("W"))
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda = new SqlDataAdapter("select Name,Contact_number,Emargency_contact_No,Email_id,Current_address,Permanent_address,picture from b_owner where Owner_id='" + TextBox1.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                GridView2.DataSource = dt;
                GridView2.DataBind();
                GridView2.Visible = true;
            }
            if (TextBox1.Text.StartsWith("c") || TextBox1.Text.StartsWith("C")|| TextBox1.Text.StartsWith("d") || TextBox1.Text.StartsWith("D")|| TextBox1.Text.StartsWith("h") || TextBox1.Text.StartsWith("H"))
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda = new SqlDataAdapter("select Name,Contact_number,Emargency_contact_No,Email_id,Current_address,Permanent_address,picture from stuff_ where stuff_id='" + TextBox1.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                GridView2.DataSource = dt;
                GridView2.DataBind();
                GridView2.Visible = true;
            }
          
            if (TextBox1.Text.StartsWith("p") || TextBox1.Text.StartsWith("P"))
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda = new SqlDataAdapter("select Name,Contact_number,Emargency_contact_No,Email_id,Current_address,Permanent_address,picture from pessenger_id where pessenger_id='" + TextBox1.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                GridView2.DataSource = dt;
                GridView2.DataBind();
                GridView2.Visible = true;
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
              
            GridView2.Visible = false;
            GridView1.Visible = false;
            SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda = new SqlDataAdapter("select Stuff_id,history as Account_History from appoint,login_table where Stuff_id=login_id and Owner_id='" + TextBox2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            GridView1.Visible = true;
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
              
            GridView2.Visible = false;
            GridView1.Visible = false;
            if (TextBox10.Text == "all")
            {
                GridView2.Visible = false;
                SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda = new SqlDataAdapter("select pessenger_id,Travel_date,Stop_time as Time , Start_location,End_location,km,Taka from ticket where Bus_License_no='" + TextBox3.Text + "' order by sl ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
                GridView1.Visible = true;
            }
            else
            {
                GridView2.Visible = false;
                SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda = new SqlDataAdapter("select pessenger_id,Travel_date,Stop_time as Time , Start_location,End_location,km,Taka from ticket where Bus_License_no='" + TextBox3.Text + "' and Travel_date='"+TextBox10.Text+"' order by sl", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
                GridView1.Visible = true;
            }
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
              
            GridView2.Visible = false;
            GridView1.Visible = false;
            try
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda = new SqlDataAdapter("select pessenger_id,Travel_date,Stop_time as Time , Start_location,End_location,km,Taka from ticket where sl='" + TextBox3.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            catch { }
           
            GridView1.Visible = true;
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
         
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
              
            GridView2.Visible = false;
            GridView1.Visible = false;

            try
            {
                if (TextBox16.Text.ToLower() == "null")
                {
                    float hh = float.Parse(DateTime.Now.ToString("hh.mm"));
                    TextBox16.Text = DateTime.Now.ToString("tt");
                    TextBox15.Text = DateTime.Now.ToString("hh.mm");
                    if (TextBox16.Text.ToLower() == "null")
                    {
                        hh = hh + 12;
                        TextBox15.Text = hh.ToString();
                    }

                }
                if (TextBox16.Text.ToLower() == "pm")
                {
                    float hh = float.Parse(TextBox15.Text);
                    hh = hh + 12;
                    TextBox15.Text = hh.ToString();

                }
                SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda = new SqlDataAdapter("select sl 'Ticket No',Pessenger_ID, case when SUBSTRING(pessenger_id,1,1)='c' then (select Name+', Contact number: '+Contact_number+', Emargency Number: '+Emargency_contact_No+', Email: '+Email_id+', Present Address '+Current_address+', Permanent Address '+Permanent_address+', Owner: '+Owner_id+', Type: '+Stuff_Type from stuff_,appoint where stuff_.Stuff_id=pessenger_id and stuff_.Stuff_id=appoint.Stuff_id)when SUBSTRING(pessenger_id,1,1)='a' then (select Name+', Contact number: '+Contact_number+', Emargency Number: '+Emargency_contact_No+', Email: '+Email_id+', Present Address '+Current_address+', Permanent Address '+Permanent_address from administrator where admin_id=pessenger_id ) when SUBSTRING(pessenger_id,1,1)='g' then (select Name+', Contact number: '+Contact_number+', Emargency Number: '+Emargency_contact_No+', Email: '+Email_id+', Present Address '+Current_address+', Permanent Address '+Permanent_address from Gov where Stuff_id=pessenger_id ) when SUBSTRING(pessenger_id,1,1)='p' then (select Name+', Contact number: '+Contact_number+', Emargency Number: '+Emargency_contact_No+', Email: '+Email_id+', Present Address '+Current_address+', Permanent Address '+Permanent_address from pessenger_id where ticket.pessenger_id=pessenger_id.pessenger_id ) when SUBSTRING(pessenger_id,1,1)='w' then (select Name+', Contact number: '+Contact_number+', Emargency Number: '+Emargency_contact_No+', Email: '+Email_id+', Present Address '+Current_address+', Permanent Address '+Permanent_address from b_owner where Owner_id=pessenger_id ) end as 'Pessenger Details' from ticket where  Travel_date='" + DateTime.Now.ToString("dd-MMM-yyyy") + "' and case when SUBSTRING(Stop_time,charindex('m', Stop_time)-1,10)='pm' then CONVERT(float, SUBSTRING(Stop_time,1,charindex('m', Stop_time)-2))+12 else SUBSTRING(Stop_time,1,charindex('m', Stop_time)-2) end <='" + TextBox15.Text + "' and Bus_License_no='" + TextBox14.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
                GridView1.Visible = true;
            }
            catch
            {
                GridView2.Visible = false;
                GridView1.Visible = false;
            }
           
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
              
            Response.Redirect("user.aspx");
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
              
            GridView2.Visible = false;
            GridView1.Visible = false;
            SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda = new SqlDataAdapter("select time_schedule.Bus_Stop_point,Location,Stop_time as time,KM as tt,Pass,Stuff_id as counter_stuff from time_schedule,stop_office where time_schedule.Bus_Stop_point=stop_office.Bus_Stop_point and Bus_License_no='"+TextBox3.Text+"' order by Bus_Stop_point", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            GridView1.Visible = true;
        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
              
            GridView2.Visible = false;
            GridView1.Visible = false;
            SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda = new SqlDataAdapter("select history from login_table where login_id='"+TextBox1.Text+"'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            GridView1.Visible = true;
        }

        protected void Button16_Click(object sender, EventArgs e)
        {
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
              
            GridView2.Visible = false;
            GridView1.Visible = false;
            if (TextBox1.Text != "administrator" || TextBox1.Text != "Administrator")
            {

                SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda = new SqlDataAdapter("select history from login_table where login_id='" + TextBox1.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
                this.GridView1.SelectedIndex = 0;
                string s;
                s = this.GridView1.Rows[this.GridView1.SelectedIndex].Cells[0].Text;
                SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1 = new SqlDataAdapter("update login_table set l='0' where login_id='" + TextBox1.Text + "'", con1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
            }
            else { msgbox("no permission"); }
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
               
        }

        protected void Button17_Click(object sender, EventArgs e)
        {
            GridView2.Visible = false;
            GridView1.Visible = false;
            SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda = new SqlDataAdapter("select have.Bus_License_no as 'Bus License No',Bus_type,Total_Sit,Total_Stand_Capacity,Bus_Name as 'Service Name' from have,bus_information where have.Bus_License_no=bus_information.Bus_License_no and Owner_id='"+TextBox2.Text+"' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            GridView1.Visible = true;
        }

        protected void Timer1_Tick1(object sender, EventArgs e)
        {
            
            Timer1.Enabled = false;
        }

        protected void Button18_Click(object sender, EventArgs e)
        {
            GridView2.Visible = false;
            GridView1.Visible = false;
            SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda = new SqlDataAdapter("select Owner_id,have.Bus_License_no,description from have,L_approved,gps where have.Bus_License_no=L_approved.Bus_License_no and gps.ID =L_approved.Bus_License_no and g!=''", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            GridView1.Visible = true;
        }

        protected void Timer2_Tick(object sender, EventArgs e)
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