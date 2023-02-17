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
    public partial class status : System.Web.UI.Page
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
            TextBox2.Text = DateTime.Now.ToString("hh.mm");
            TextBox3.Text = DateTime.Now.ToString("tt");
            if (Session["ID"] != null)
            {
                TextBox1.Text = Session["ID"].ToString();
                Class1 p = new Class1();
                p.login_id = TextBox1.Text;
                if (p.pos()) {
                    TextBox33.Text = p.s_no;
                    TextBox34.Text = p.Road_name;
                    TextBox35.Text = p.Road_no;
                    TextBox36.Text = p.Location;
                }


                SqlConnection con1g = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1g = new SqlDataAdapter("(select id,latitude,longitude,description from time_schedule,gps where Bus_License_no=ID and Stuff_id='" + TextBox1.Text + "')intersect(select id,latitude,longitude,description from time_schedule,gps where Bus_License_no=ID and Stuff_id='" + TextBox1.Text + "') ", con1g);
                DataTable dt1g = new DataTable();
                sda1g.Fill(dt1g);
                rptMarkers.DataSource = dt1g;
                rptMarkers.DataBind();

            }
            else { Response.Redirect("home.aspx"); }
            SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda = new SqlDataAdapter("select Bus_License_no,Stop_time,KM as TT,Bus_Stop_point,Pass from time_schedule where Stop_time>='" + TextBox2.Text + "' and km='" + TextBox3.Text + "' and pass='' and Stuff_id='" + TextBox1.Text + "' order by Stop_time ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Repeater1.DataSource = dt;
            Repeater1.DataBind();
          

            SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
          //  SqlDataAdapter sda1 = new SqlDataAdapter("(select b_status.Bus_License_no,Current_location as ID,Location ,Time_delay as Delay from b_status,time_schedule,stop_office where b_status.Current_location=stop_office.Bus_Stop_point and b_status.Current_location=time_schedule.Bus_Stop_point and Stuff_id='" + TextBox1.Text + "')intersect(select b_status.Bus_License_no,Current_location as ID,Location ,Time_delay as Delay_Min from b_status,time_schedule,stop_office where b_status.Current_location=stop_office.Bus_Stop_point and b_status.Current_location=time_schedule.Bus_Stop_point and Stuff_id='" + TextBox1.Text + "')", con1);
            SqlDataAdapter sda1 = new SqlDataAdapter("(select b_status.Bus_License_no,Current_location as Stop_point,Location as Left_Location ,Time_delay as Delay from b_status,time_schedule,stop_office where b_status.Bus_License_no=time_schedule.Bus_License_no and b_status.Current_location=stop_office.Bus_Stop_point and Stuff_id='"+TextBox1.Text+"')intersect(select b_status.Bus_License_no,Current_location as ID,Location ,Time_delay as Delay from b_status,time_schedule,stop_office where b_status.Bus_License_no=time_schedule.Bus_License_no and b_status.Current_location=stop_office.Bus_Stop_point and Stuff_id='"+TextBox1.Text+"')", con1);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            Repeater2.DataSource = dt1;
            Repeater2.DataBind();

            SqlConnection con11 = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda11 = new SqlDataAdapter("select Bus_License_no,Stop_time,KM as TT,Bus_Stop_point,Pass from time_schedule where  Stuff_id='" + TextBox1.Text + "' order by pass  ", con11);
            DataTable dt11 = new DataTable();
            sda11.Fill(dt11);
            Repeater3.DataSource = dt11;
            Repeater3.DataBind();
           
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
           
            if (TextBox28.Text != "p")
                        {
                            TextBox28.Text = "";
                            float a, b, c;
                            if (TextBox5.Text != "")
                            {
                                a = float.Parse(TextBox5.Text);
                                if (TextBox6.Text == "PM") { a = a + 12; }
                                b = float.Parse(DateTime.Now.ToString("hh.mm"));
                                if (TextBox3.Text == "PM") { b = b + 12; }
                                if (b >= a)
                                {
            float a_, b_, c_, d_, e_, f_;
        try
        {
            a_ = float.Parse(TextBox33.Text);
            b_ = float.Parse(TextBox34.Text);
            c_ = float.Parse(TextBox35.Text);
            d_ = float.Parse(TextBox36.Text);
            e_ = float.Parse(TextBox37.Text);
            f_ = float.Parse(TextBox38.Text);
            if ((e_ >= a_ && e_ <= b_) && (f_ >= c_ && f_ <= d_))
            {
                Timer2.Enabled = true;
                Label12.Visible = true;
                Button1.Visible = false;
            }
            else { msgbox("Stop bus in selected area"); }

                }
                catch { msgbox("gps reading missmatch"); }
                                }
                                else { msgbox("Time schedule not match"); }


                            }
                            else { msgbox("Time schedule not match"); }
                        }
        else { msgbox("already pass"); }
          /*  Class1 g = new Class1();
            g.login_id = TextBox4.Text;
            if (g.g()) { TextBox37.Text = g.s_no; TextBox38.Text = g.Road_name; }
            float a_, b_, c_, d_, e_, f_; 
            try 
            {
                a_ = float.Parse(TextBox33.Text);
                b_ = float.Parse(TextBox34.Text);
                c_ = float.Parse(TextBox35.Text);
                d_ = float.Parse(TextBox36.Text);
                e_ = float.Parse(TextBox37.Text);
                f_ = float.Parse(TextBox38.Text);
                if ((e_ >= a_ && e_ <= b_) && (f_ >= c_ && f_ <= d_))
                {
                    if (Session["ID"] != null)
                    {
                        Class1 ss = new Class1();
                        ss.login_id = Session["ID"].ToString();
                        if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
                        if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
                    }
                    if (TextBox28.Text != "p")
                    {
                        TextBox28.Text = "";
                        float a, b, c;
                        if (TextBox5.Text != "")
                        {
                            a = float.Parse(TextBox5.Text);
                            if (TextBox6.Text == "PM") { a = a + 12; }
                            b = float.Parse(DateTime.Now.ToString("hh.mm"));
                            if (TextBox3.Text == "PM") { b = b + 12; }
                            if (b >= a)
                            {
                                SqlConnection con11 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                                SqlDataAdapter sda11 = new SqlDataAdapter("update time_schedule set Pass='p' where Bus_License_no='" + TextBox4.Text + "' and Bus_Stop_point='" + TextBox7.Text + "' and Stuff_id='" + TextBox1.Text + "' and KM='" + TextBox6.Text + "' and Stop_time='" + TextBox5.Text + "'  ", con11);
                                DataTable dt11 = new DataTable();
                                sda11.Fill(dt11);
                                int z; float y, x;

                                c = b - a;
                                z = int.Parse(c.ToString("00"));
                                y = c - z;
                                y = (y * 60) / 60;
                                x = z + y;
                                Class1 d = new Class1();
                                d.Bus_License_no = TextBox4.Text;
                                d.Current_location = TextBox7.Text;
                                d.Time_delay = c.ToString();
                                if (d.DataSaveInb_status()) { } else { }
                                SqlConnection con111 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                                SqlDataAdapter sda111 = new SqlDataAdapter("update b_status  set Current_location='" + TextBox7.Text + "',time_delay='" + x.ToString("0.00") + "' where Bus_License_no='" + TextBox4.Text + "' update ticket set Sit_no='EXP' where Travel_date='" + DateTime.Now.ToString("d-MMM-yyyy") + "' and Stop_time='" + TextBox5.Text + TextBox6.Text + "' and Bus_License_no='" + TextBox4.Text + "' ", con111);
                                DataTable dt111 = new DataTable();
                                sda111.Fill(dt111);


                                // msgbox(c.ToString("0.00") + "  " + z.ToString() + "  " + y.ToString() + " x= " + x.ToString());



                                Response.Redirect("status.aspx");
                            }


                        }
                        else { msgbox("Please click current momment"); }
                    }
                    else { msgbox("already pass"); }

                } 

                else { msgbox("Stop bus in selected area"); }

            }
            catch { msgbox("gps reading missmatch"); }*////////////////////////////////////////////////////////////////////

          /*  if (Session["ID"] != null)
            {
                Class1 ss = new Class1();
                ss.login_id = Session["ID"].ToString();
                if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
                if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
            }
            if (TextBox28.Text != "p")
            {
                TextBox28.Text = "";
                float a, b, c;
                if (TextBox5.Text != "")
                {
                    a = float.Parse(TextBox5.Text);
                    if (TextBox6.Text == "PM") { a = a + 12; }
                    b = float.Parse(DateTime.Now.ToString("hh.mm"));
                    if (TextBox3.Text == "PM") { b = b + 12; }
                    if (b >= a)
                    {
                        SqlConnection con11 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                        SqlDataAdapter sda11 = new SqlDataAdapter("update time_schedule set Pass='p' where Bus_License_no='" + TextBox4.Text + "' and Bus_Stop_point='" + TextBox7.Text + "' and Stuff_id='" + TextBox1.Text + "' and KM='" + TextBox6.Text + "' and Stop_time='" + TextBox5.Text + "'  ", con11);
                        DataTable dt11 = new DataTable();
                        sda11.Fill(dt11);
                        int z; float y, x;

                        c = b - a;
                        z = int.Parse(c.ToString("00"));
                        y = c - z;
                        y = (y * 60) / 60;
                        x = z + y;
                        Class1 d = new Class1();
                        d.Bus_License_no = TextBox4.Text;
                        d.Current_location = TextBox7.Text;
                        d.Time_delay = c.ToString();
                        if (d.DataSaveInb_status()) { } else { }
                        SqlConnection con111 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                        SqlDataAdapter sda111 = new SqlDataAdapter("update b_status  set Current_location='" + TextBox7.Text + "',time_delay='" + x.ToString("0.00") + "' where Bus_License_no='" + TextBox4.Text + "' update ticket set Sit_no='EXP' where Travel_date='" + DateTime.Now.ToString("d-MMM-yyyy") + "' and Stop_time='" + TextBox5.Text + TextBox6.Text + "' and Bus_License_no='" + TextBox4.Text + "' ", con111);
                        DataTable dt111 = new DataTable();
                        sda111.Fill(dt111);


                        // msgbox(c.ToString("0.00") + "  " + z.ToString() + "  " + y.ToString() + " x= " + x.ToString());



                        Response.Redirect("status.aspx");
                    }


                }
                else { msgbox("Please click current momment"); }
            }
            else { msgbox("already pass"); }*/

            //DateTime.Now.ToString("dd-MMM-yyyy");
            //delete from ticket where Bus_License_no='' and Travel_date='' and Stop_time='' and End_location=''
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("status.aspx");
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda = new SqlDataAdapter("select Bus_License_no,Stop_time,KM as TT,Bus_Stop_point,Pass from time_schedule where Stop_time>='" + TextBox2.Text + "' and km='" + TextBox3.Text + "' and pass='' and Stuff_id='" + TextBox1.Text + "' order by Stop_time ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Repeater1.DataSource = dt;
            Repeater1.DataBind();


            SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
            //  SqlDataAdapter sda1 = new SqlDataAdapter("(select b_status.Bus_License_no,Current_location as ID,Location ,Time_delay as Delay from b_status,time_schedule,stop_office where b_status.Current_location=stop_office.Bus_Stop_point and b_status.Current_location=time_schedule.Bus_Stop_point and Stuff_id='" + TextBox1.Text + "')intersect(select b_status.Bus_License_no,Current_location as ID,Location ,Time_delay as Delay_Min from b_status,time_schedule,stop_office where b_status.Current_location=stop_office.Bus_Stop_point and b_status.Current_location=time_schedule.Bus_Stop_point and Stuff_id='" + TextBox1.Text + "')", con1);
            SqlDataAdapter sda1 = new SqlDataAdapter("(select b_status.Bus_License_no,Current_location as Stop_point,Location as Left_Location ,Time_delay as Delay from b_status,time_schedule,stop_office where b_status.Bus_License_no=time_schedule.Bus_License_no and b_status.Current_location=stop_office.Bus_Stop_point and Stuff_id='" + TextBox1.Text + "')intersect(select b_status.Bus_License_no,Current_location as ID,Location ,Time_delay as Delay from b_status,time_schedule,stop_office where b_status.Bus_License_no=time_schedule.Bus_License_no and b_status.Current_location=stop_office.Bus_Stop_point and Stuff_id='" + TextBox1.Text + "')", con1);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            Repeater2.DataSource = dt1;
            Repeater2.DataBind();

            SqlConnection con11 = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda11 = new SqlDataAdapter("select Bus_License_no,Stop_time,KM as TT,Bus_Stop_point,Pass from time_schedule where  Stuff_id='" + TextBox1.Text + "' order by pass  ", con11);
            DataTable dt11 = new DataTable();
            sda11.Fill(dt11);
            Repeater3.DataSource = dt11;
            Repeater3.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection con11 = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda11 = new SqlDataAdapter("update time_schedule set Pass='' where   Stuff_id='" + TextBox1.Text + "'   ", con11);
            DataTable dt11 = new DataTable();
            sda11.Fill(dt11);
            Response.Redirect("status.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("user.aspx");
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
            Class1 d = new Class1();
            d.Pessenger_id = TextBox1.Text;
            if (d.QueryInsumm()) { Session["ow"] = d.s_no; }
            Session["ty"] = Session["t"].ToString(); 
           Response.Redirect("Ticket.aspx");
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (TextBox9.Text != "")
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda = new SqlDataAdapter("select Bus_License_no,Stop_time,KM as TT,Bus_Stop_point,Pass from time_schedule where Stop_time>='" + TextBox2.Text + "' and km='" + TextBox3.Text + "' and pass='' and Stuff_id='" + TextBox1.Text + "' and bus_license_no='" + TextBox9.Text + "' order by Stop_time ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Repeater1.DataSource = dt;
                Repeater1.DataBind();
            }
            int rowid = (e.Item.ItemIndex);
            TextBox t1 = (TextBox)Repeater1.Items[rowid].FindControl("TextBox29") as TextBox;
                TextBox t2 = (TextBox)Repeater1.Items[rowid].FindControl("TextBox30") as TextBox;
            TextBox t3 = (TextBox)Repeater1.Items[rowid].FindControl("TextBox31") as TextBox;
            TextBox t4 = (TextBox)Repeater1.Items[rowid].FindControl("TextBox32") as TextBox;


            
         
            TextBox4.Text = t1.Text;
            TextBox5.Text = t2.Text;
            TextBox6.Text = t3.Text;
            TextBox7.Text =t4.Text;
            TextBox8.Text = TextBox5.Text + " " + TextBox6.Text;
            Class1 g = new Class1();
            g.login_id = TextBox4.Text;
            if (g.g()) { TextBox37.Text = g.s_no; TextBox38.Text = g.Road_name; }
        }

        protected void Repeater3_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (TextBox9.Text != "")
            {
                SqlConnection con11 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda11 = new SqlDataAdapter("select Bus_License_no,Stop_time,KM as TT,Bus_Stop_point,Pass from time_schedule where  Stuff_id='" + TextBox1.Text + "' and bus_license_no='" + TextBox9.Text + "' order by pass  ", con11);
                DataTable dt11 = new DataTable();
                sda11.Fill(dt11);
                Repeater3.DataSource = dt11;
                Repeater3.DataBind();
            }
            int rowid = (e.Item.ItemIndex);
            TextBox t1 = (TextBox)Repeater3.Items[rowid].FindControl("TextBox24") as TextBox;
            TextBox t2 = (TextBox)Repeater3.Items[rowid].FindControl("TextBox13") as TextBox;
            TextBox t3 = (TextBox)Repeater3.Items[rowid].FindControl("TextBox25") as TextBox;
            TextBox t4 = (TextBox)Repeater3.Items[rowid].FindControl("TextBox26") as TextBox;
            TextBox t5 = (TextBox)Repeater3.Items[rowid].FindControl("TextBox27") as TextBox;



            TextBox28.Text = t5.Text;
            TextBox4.Text = t1.Text;
            TextBox5.Text = t2.Text;
            TextBox6.Text = t3.Text;
            TextBox7.Text = t4.Text;
            TextBox8.Text = TextBox5.Text + " " + TextBox6.Text;
            Class1 g = new Class1();
            g.login_id = TextBox4.Text;
            if (g.g()) { TextBox37.Text = g.s_no; TextBox38.Text = g.Road_name; }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda = new SqlDataAdapter("select Bus_License_no,Stop_time,KM as TT,Bus_Stop_point,Pass from time_schedule where Stop_time>='" + TextBox2.Text + "' and km='" + TextBox3.Text + "' and pass='' and Stuff_id='" + TextBox1.Text + "' and bus_license_no='" + TextBox9.Text + "' order by Stop_time ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Repeater1.DataSource = dt;
            Repeater1.DataBind();


            SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
            //  SqlDataAdapter sda1 = new SqlDataAdapter("(select b_status.Bus_License_no,Current_location as ID,Location ,Time_delay as Delay from b_status,time_schedule,stop_office where b_status.Current_location=stop_office.Bus_Stop_point and b_status.Current_location=time_schedule.Bus_Stop_point and Stuff_id='" + TextBox1.Text + "')intersect(select b_status.Bus_License_no,Current_location as ID,Location ,Time_delay as Delay_Min from b_status,time_schedule,stop_office where b_status.Current_location=stop_office.Bus_Stop_point and b_status.Current_location=time_schedule.Bus_Stop_point and Stuff_id='" + TextBox1.Text + "')", con1);
            SqlDataAdapter sda1 = new SqlDataAdapter("(select b_status.Bus_License_no,Current_location as Stop_point,Location as Left_Location ,Time_delay as Delay from b_status,time_schedule,stop_office where b_status.Bus_License_no=time_schedule.Bus_License_no and b_status.Current_location=stop_office.Bus_Stop_point and Stuff_id='" + TextBox1.Text + "' and b_status.Bus_License_no='" + TextBox9.Text + "')intersect(select b_status.Bus_License_no,Current_location as ID,Location ,Time_delay as Delay from b_status,time_schedule,stop_office where b_status.Bus_License_no=time_schedule.Bus_License_no and b_status.Current_location=stop_office.Bus_Stop_point and Stuff_id='" + TextBox1.Text + "' and b_status.Bus_License_no='" + TextBox9.Text + "')", con1);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            Repeater2.DataSource = dt1;
            Repeater2.DataBind();

            SqlConnection con11 = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda11 = new SqlDataAdapter("select Bus_License_no,Stop_time,KM as TT,Bus_Stop_point,Pass from time_schedule where  Stuff_id='" + TextBox1.Text + "' and bus_license_no='" + TextBox9.Text + "' order by pass  ", con11);
            DataTable dt11 = new DataTable();
            sda11.Fill(dt11);
            Repeater3.DataSource = dt11;
            Repeater3.DataBind();
            SqlConnection con1g = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda1g = new SqlDataAdapter(" (select id,latitude,longitude,description from time_schedule,gps where Bus_License_no=ID and Stuff_id='" + TextBox1.Text + "' and ID='" + TextBox9.Text + "')intersect(select id,latitude,longitude,description from time_schedule,gps where Bus_License_no=ID and Stuff_id='" + TextBox1.Text + "' and ID='" + TextBox9.Text + "') ", con1g);
            DataTable dt1g = new DataTable();
            sda1g.Fill(dt1g);
            rptMarkers.DataSource = dt1g;
            rptMarkers.DataBind();
            UpdatePanel1.Update();
            UpdatePanel6.Update();
            UpdatePanel5.Update();

        }

        protected void Button21_Click(object sender, EventArgs e)
        {
            Response.Redirect("status.aspx");
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
            int aw;
            aw = int.Parse(Label12.Text);
            aw = aw - 1;
            Label12.Text = aw.ToString();
            if (aw < 0) 
            { 
                Label12.Text = "10"; Timer2.Enabled = false; Button1.Visible = true; Label12.Visible = false;
                Class1 g = new Class1();
                g.login_id = TextBox4.Text;
                if (g.g()) { TextBox37.Text = g.s_no; TextBox38.Text = g.Road_name; }
                float a_, b_, c_, d_, e_, f_;
                try
                {
                    a_ = float.Parse(TextBox33.Text);
                    b_ = float.Parse(TextBox34.Text);
                    c_ = float.Parse(TextBox35.Text);
                    d_ = float.Parse(TextBox36.Text);
                    e_ = float.Parse(TextBox37.Text);
                    f_ = float.Parse(TextBox38.Text);
                    if ((e_ >= a_ && e_ <= b_) && (f_ >= c_ && f_ <= d_))
                    {
                        if (Session["ID"] != null)
                        {
                            Class1 ss = new Class1();
                            ss.login_id = Session["ID"].ToString();
                            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
                            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
                        }
                        if (TextBox28.Text != "p")
                        {
                            TextBox28.Text = "";
                            float a, b, c;
                            if (TextBox5.Text != "")
                            {
                                a = float.Parse(TextBox5.Text);
                                if (TextBox6.Text == "PM") { a = a + 12; }
                                b = float.Parse(DateTime.Now.ToString("hh.mm"));
                                if (TextBox3.Text == "PM") { b = b + 12; }
                                if (b >= a)
                                {
                                    SqlConnection con11 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                                    SqlDataAdapter sda11 = new SqlDataAdapter("update time_schedule set Pass='p' where Bus_License_no='" + TextBox4.Text + "' and Bus_Stop_point='" + TextBox7.Text + "' and Stuff_id='" + TextBox1.Text + "' and KM='" + TextBox6.Text + "' and Stop_time='" + TextBox5.Text + "'  ", con11);
                                    DataTable dt11 = new DataTable();
                                    sda11.Fill(dt11);
                                    int z; float y, x;

                                    c = b - a;
                                    z = int.Parse(c.ToString("00"));
                                    y = c - z;
                                    y = (y * 60) / 60;
                                    x = z + y;
                                    Class1 d = new Class1();
                                    d.Bus_License_no = TextBox4.Text;
                                    d.Current_location = TextBox7.Text;
                                    d.Time_delay = c.ToString();
                                    if (d.DataSaveInb_status()) { } else { }
                                    SqlConnection con111 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                                    SqlDataAdapter sda111 = new SqlDataAdapter("update b_status  set Current_location='" + TextBox7.Text + "',time_delay='" + x.ToString("0.00") + "' where Bus_License_no='" + TextBox4.Text + "' update ticket set Sit_no='EXP' where Travel_date='" + DateTime.Now.ToString("d-MMM-yyyy") + "' and Stop_time='" + TextBox5.Text + TextBox6.Text + "' and Bus_License_no='" + TextBox4.Text + "' ", con111);
                                    DataTable dt111 = new DataTable();
                                    sda111.Fill(dt111);


                                    // msgbox(c.ToString("0.00") + "  " + z.ToString() + "  " + y.ToString() + " x= " + x.ToString());

                                    Timer4.Enabled = true;
                                    msgbox("success");
                                    /////////////////////////////////
                                    SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                                    SqlDataAdapter sda = new SqlDataAdapter("select Bus_License_no,Stop_time,KM as TT,Bus_Stop_point,Pass from time_schedule where Stop_time>='" + TextBox2.Text + "' and km='" + TextBox3.Text + "' and pass='' and Stuff_id='" + TextBox1.Text + "' order by Stop_time ", con);
                                    DataTable dt = new DataTable();
                                    sda.Fill(dt);
                                    Repeater1.DataSource = dt;
                                    Repeater1.DataBind();


                                    SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                                    //  SqlDataAdapter sda1 = new SqlDataAdapter("(select b_status.Bus_License_no,Current_location as ID,Location ,Time_delay as Delay from b_status,time_schedule,stop_office where b_status.Current_location=stop_office.Bus_Stop_point and b_status.Current_location=time_schedule.Bus_Stop_point and Stuff_id='" + TextBox1.Text + "')intersect(select b_status.Bus_License_no,Current_location as ID,Location ,Time_delay as Delay_Min from b_status,time_schedule,stop_office where b_status.Current_location=stop_office.Bus_Stop_point and b_status.Current_location=time_schedule.Bus_Stop_point and Stuff_id='" + TextBox1.Text + "')", con1);
                                    SqlDataAdapter sda1 = new SqlDataAdapter("(select b_status.Bus_License_no,Current_location as Stop_point,Location as Left_Location ,Time_delay as Delay from b_status,time_schedule,stop_office where b_status.Bus_License_no=time_schedule.Bus_License_no and b_status.Current_location=stop_office.Bus_Stop_point and Stuff_id='" + TextBox1.Text + "')intersect(select b_status.Bus_License_no,Current_location as ID,Location ,Time_delay as Delay from b_status,time_schedule,stop_office where b_status.Bus_License_no=time_schedule.Bus_License_no and b_status.Current_location=stop_office.Bus_Stop_point and Stuff_id='" + TextBox1.Text + "')", con1);
                                    DataTable dt1 = new DataTable();
                                    sda1.Fill(dt1);
                                    Repeater2.DataSource = dt1;
                                    Repeater2.DataBind();

                                    SqlConnection con11w = new SqlConnection(Properties.Settings.Default._ConnectionString);
                                    SqlDataAdapter sda11w = new SqlDataAdapter("select Bus_License_no,Stop_time,KM as TT,Bus_Stop_point,Pass from time_schedule where  Stuff_id='" + TextBox1.Text + "' order by pass  ", con11w);
                                    DataTable dt11w = new DataTable();
                                    sda11w.Fill(dt11w);
                                    Repeater3.DataSource = dt11w;
                                    Repeater3.DataBind();
                                    ////////////////////////////////
                                   // Response.Redirect("status.aspx");
                                }
                                else { msgbox("Time schedule not match"); }


                            }
                            else { msgbox("Time schedule not match"); }
                        }
                        else { msgbox("already pass"); }

                    }

                    else { msgbox("Stop bus in selected area"); }

                }
                catch { msgbox("gps reading missmatch"); }
            }
        }

        protected void Timer3_Tick(object sender, EventArgs e)
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

        protected void Timer4_Tick(object sender, EventArgs e)
        {
            int blank_sit, total_stand, c, d, k = 1, i; string g = "";
            SqlConnection con111qs = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda111qs = new SqlDataAdapter("select Total_Sit -(select COUNT(Sit_no)from ticket where bus_license_no='" + TextBox4.Text + "' and Sit_no like'sit%' and Travel_date='" + DateTime.Now.ToString("dd-MMM-yyyy") + "')from bus_information where bus_license_no='" + TextBox4.Text + "'", con111qs);
            DataTable dt111qs = new DataTable();
            sda111qs.Fill(dt111qs);
            GridView1.DataSource = dt111qs;
            GridView1.DataBind();
            this.GridView1.SelectedIndex = 0;
            blank_sit = int.Parse(this.GridView1.Rows[this.GridView1.SelectedIndex].Cells[0].Text);


            SqlConnection con111z = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda111z = new SqlDataAdapter("select sl,sit_no from ticket where bus_license_no='" + TextBox4.Text + "' and Sit_no like'st%' and Travel_date='" + DateTime.Now.ToString("dd-MMM-yyyy") + "' order by Sit_no", con111z);
            DataTable dt111z = new DataTable();
            sda111z.Fill(dt111z);
            GridView1.DataSource = dt111z;
            GridView1.DataBind();
            total_stand = int.Parse(GridView1.Rows.Count.ToString());
            TextBox39.Text = blank_sit.ToString();
            TextBox40.Text = total_stand.ToString();


            if (blank_sit > 0)
            {
                for (c = 0; c < blank_sit; c++)
                {
                    if (c == total_stand) { break; }


                    this.GridView1.SelectedIndex = c;
                    TextBox41.Text = this.GridView1.Rows[this.GridView1.SelectedIndex].Cells[0].Text;
                    for (i = 1; i <= 3; i++)
                    {
                        SqlConnection conu = new SqlConnection(Properties.Settings.Default._ConnectionString);
                        SqlDataAdapter sdau = new SqlDataAdapter("select *from ticket where bus_license_no='" + TextBox4.Text + "' and Travel_date='" + DateTime.Now.ToString("dd-MMM-yyyy") + "' and Sit_no='" + "sit-" + i + "'", conu);
                        DataTable dtu = new DataTable();
                        sdau.Fill(dtu);
                        GridView2.DataSource = dtu;
                        GridView2.DataBind();
                        int ddsf, llsm = 0;
                        ddsf = int.Parse(GridView2.Rows.Count.ToString());
                        if (ddsf == 0) { break; }
                        k = i + 1;


                    }

                    if (c <= blank_sit)
                    {
                        g = "sit-" + k.ToString();
                        SqlConnection conuk = new SqlConnection(Properties.Settings.Default._ConnectionString);
                        SqlDataAdapter sdauk = new SqlDataAdapter("update ticket set sit_no='" + "sit-" + k + "' where sl='" + TextBox41.Text + "'and Travel_date='" + DateTime.Now.ToString("dd-MMM-yyyy") + "'", conuk);
                        DataTable dtuk = new DataTable();
                        sdauk.Fill(dtuk);
                    }

                }
            } Timer4.Enabled = false;
        }

       
    }
}