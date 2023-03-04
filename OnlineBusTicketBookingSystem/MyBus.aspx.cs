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
    public partial class MyBus : System.Web.UI.Page
    {
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
                TextBox1.Text = Session["ID"].ToString();
                SqlConnection con1g = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1g = new SqlDataAdapter("select ID,latitude,longitude,description  from have,gps where Bus_License_no=ID and Owner_id='" + TextBox1.Text + "' ", con1g);
                DataTable dt1g = new DataTable();
                sda1g.Fill(dt1g);
                rptMarkers.DataSource = dt1g;
                rptMarkers.DataBind();

            }
            else { Response.Redirect("home.aspx"); }
            SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda = new SqlDataAdapter("select stuff_.Stuff_id,Name,Stuff_Type,Contact_number,Email_id,Current_address,Emargency_contact_No,Permanent_address,DOB,Country,Register_date,picture from appoint,stuff_ where stuff_.Stuff_id=appoint.Stuff_id and Owner_id='" + TextBox1.Text + "' and (Stuff_Type='driver'or Stuff_Type='Helper' )", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
          
            Repeater1.DataSource = dt;
            Repeater1.DataBind();

            SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda1 = new SqlDataAdapter("select bus_information.Bus_License_no,Bus_no,Bus_Name,Bus_type,Total_Sit,Total_Stand_Capacity,Approved as License,Stuff_id as Approved_By,A_Date as Approved_Date,Fitness,Tex_year,Tex  from have,bus_information,L_approved where have.Bus_License_no=bus_information.Bus_License_no  and L_approved.Bus_License_no=bus_information.Bus_License_no and Owner_id='"+TextBox1.Text+"'", con1);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            Repeater2.DataSource = dt1;
            Repeater2.DataBind();

            SqlConnection con11 = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda11 = new SqlDataAdapter("select Bus_License_no,control_.Stuff_id,Name,Stuff_Type from control_,appoint,stuff_ where control_.Stuff_id=appoint.Stuff_id and stuff_.Stuff_id=control_.Stuff_id and Owner_id='" + TextBox1.Text + "'", con11);
            DataTable dt11 = new DataTable();
            sda11.Fill(dt11);
            Repeater3.DataSource = dt11;
            Repeater3.DataBind();

            SqlConnection con111 = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda111 = new SqlDataAdapter("(select b_status.Bus_License_no,Bus_Stop_point,Location as left_location,time_delay as Delay from b_status,have,stop_office where  stop_office.Bus_Stop_point=b_status.Current_location and have.Bus_License_no=b_status.Bus_License_no and Owner_id='" + TextBox1.Text + "')intersect(select b_status.Bus_License_no,Bus_Stop_point,Location as left_location,time_delay as Delay from b_status,have,stop_office where  stop_office.Bus_Stop_point=b_status.Current_location and have.Bus_License_no=b_status.Bus_License_no and Owner_id='" + TextBox1.Text + "')", con111);
            DataTable dt111 = new DataTable();
            sda111.Fill(dt111);
            Repeater4.DataSource = dt111;
            Repeater4.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  GridViewRow row = GridView1.SelectedRow;
            //TextBox2.Text = row.Cells[2].Text;
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //GridViewRow row = GridView2.SelectedRow;
            //TextBox3.Text = row.Cells[1].Text;
        }
        private void msgbox(string msg) { ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "CallMyFunction", "alert('" + msg + "')", true); }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
              
            Class1 d = new Class1();
            d.Stuff_id=TextBox2.Text;
            d.Bus_License_no=TextBox3.Text;
            d.s_no = TextBox10.Text;
            if (d.DataSaveIncon()) 
            { 
                msgbox("Sucessfull"); TextBox2.Text = ""; TextBox3.Text = "";
                SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda = new SqlDataAdapter("select stuff_.Stuff_id,Name,Stuff_Type,Contact_number,Email_id,Current_address,Emargency_contact_No,Permanent_address,DOB,Country,Register_date,picture from appoint,stuff_ where stuff_.Stuff_id=appoint.Stuff_id and Owner_id='" + TextBox1.Text + "' and (Stuff_Type='driver'or Stuff_Type='Helper' )", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                Repeater1.DataSource = dt;
                Repeater1.DataBind();

                SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1 = new SqlDataAdapter("select bus_information.Bus_License_no,Bus_no,Bus_Name,Bus_type,Total_Sit,Total_Stand_Capacity,Approved as License,Stuff_id as Approved_By,A_Date as Approved_Date,Fitness,Tex_year,Tex  from have,bus_information,L_approved where have.Bus_License_no=bus_information.Bus_License_no  and L_approved.Bus_License_no=bus_information.Bus_License_no and Owner_id='" + TextBox1.Text + "'", con1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                Repeater2.DataSource = dt1;
                Repeater2.DataBind();

                SqlConnection con11 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda11 = new SqlDataAdapter("select Bus_License_no,control_.Stuff_id,Name,Stuff_Type from control_,appoint,stuff_ where control_.Stuff_id=appoint.Stuff_id and stuff_.Stuff_id=control_.Stuff_id and Owner_id='" + TextBox1.Text + "'", con11);
                DataTable dt11 = new DataTable();
                sda11.Fill(dt11);
                Repeater3.DataSource = dt11;
                Repeater3.DataBind();

                SqlConnection con111 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda111 = new SqlDataAdapter("(select b_status.Bus_License_no,Bus_Stop_point,Location as left_location,time_delay as Delay from b_status,have,stop_office where  stop_office.Bus_Stop_point=b_status.Current_location and have.Bus_License_no=b_status.Bus_License_no and Owner_id='" + TextBox1.Text + "')intersect(select b_status.Bus_License_no,Bus_Stop_point,Location as left_location,time_delay as Delay from b_status,have,stop_office where  stop_office.Bus_Stop_point=b_status.Current_location and have.Bus_License_no=b_status.Bus_License_no and Owner_id='" + TextBox1.Text + "')", con111);
                DataTable dt111 = new DataTable();
                sda111.Fill(dt111);
                Repeater4.DataSource = dt111;
                Repeater4.DataBind();
            } 
            else { msgbox("fail"); }
            
        }

        protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
        {
           // GridViewRow row = GridView3.SelectedRow;
            //TextBox2.Text = row.Cells[2].Text;
            //TextBox3.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
              
            SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda = new SqlDataAdapter("delete from control_ where Stuff_id='"+TextBox2.Text+"'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Response.Redirect("Mybus.aspx");
        }
        string b, s;
        protected void GridView4_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }

            float a, b; string s;
            a = float.Parse(DateTime.Now.ToString("hh.mm"));
            b = float.Parse(DateTime.Now.ToString("hh.mm"));
            s = DateTime.Now.ToString("tt");
            if (a > 12.05 && b < 12.30 && s=="AM")
            {

                SqlConnection con11 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda11 = new SqlDataAdapter("update time_schedule set Pass=''  from have,time_schedule where time_schedule.Bus_License_no=have.Bus_License_no and Owner_id='" + TextBox1.Text + "' delete b_status from have,b_status where b_status.Bus_License_no=have.Bus_License_no and Owner_id='" + TextBox1.Text + "' update gps set latitude='',longitude='',description='' from gps,have where have.Bus_License_no=gps.ID and Owner_id='" + TextBox1.Text + "'  ", con11);
                DataTable dt11 = new DataTable();
                sda11.Fill(dt11);
            }
            else { msgbox("Try again after 12.05 AM"); }
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            SqlConnection con111 = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda111 = new SqlDataAdapter("(select b_status.Bus_License_no,Bus_Stop_point,Location as left_location,time_delay as Delay from b_status,have,stop_office where  stop_office.Bus_Stop_point=b_status.Current_location and have.Bus_License_no=b_status.Bus_License_no and Owner_id='" + TextBox1.Text + "')intersect(select b_status.Bus_License_no,Bus_Stop_point,Location as left_location,time_delay as Delay from b_status,have,stop_office where  stop_office.Bus_Stop_point=b_status.Current_location and have.Bus_License_no=b_status.Bus_License_no and Owner_id='" + TextBox1.Text + "')", con111);
            DataTable dt111 = new DataTable();
            sda111.Fill(dt111);
            Repeater4.DataSource = dt111;
            Repeater4.DataBind();
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "5")
            {
                int rowid = (e.Item.ItemIndex);
                TextBox t = (TextBox)Repeater1.Items[rowid].FindControl("TextBox4") as TextBox;

                TextBox2.Text = t.Text;

            }
        }

        protected void Repeater2_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "6")
            {
                int rowid1 = (e.Item.ItemIndex);
                TextBox t1 = (TextBox)Repeater2.Items[rowid1].FindControl("TextBox5") as TextBox;

                TextBox3.Text = t1.Text;
                TextBox12.Text = t1.Text;

            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            SqlConnection con1g = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda1g = new SqlDataAdapter("select ID,latitude,longitude,description  from have,gps where Bus_License_no=ID and Owner_id='" + TextBox1.Text + "' and id='"+TextBox11.Text+"' ", con1g);
            DataTable dt1g = new DataTable();
            sda1g.Fill(dt1g);
            rptMarkers.DataSource = dt1g;
            rptMarkers.DataBind();
        }

        protected void Button8_Click(object sender, EventArgs e)
        {

            SqlConnection con1g = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda1g = new SqlDataAdapter("select ID,latitude,longitude,description  from have,gps where Bus_License_no=ID and Owner_id='" + TextBox1.Text + "' ", con1g);
            DataTable dt1g = new DataTable();
            sda1g.Fill(dt1g);
            rptMarkers.DataSource = dt1g;
            rptMarkers.DataBind();
        }

        protected void Repeater3_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            int rowid1 = (e.Item.ItemIndex);
            TextBox t1 = (TextBox)Repeater3.Items[rowid1].FindControl("TextBox6") as TextBox;
            TextBox t2 = (TextBox)Repeater3.Items[rowid1].FindControl("TextBox7") as TextBox;

            SqlConnection con111 = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda111 = new SqlDataAdapter("delete from control_ where Bus_License_no='"+t1.Text+"' and Stuff_id='"+t2.Text+"'", con111);
            DataTable dt111 = new DataTable();
            sda111.Fill(dt111);

            SqlConnection con11 = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda11 = new SqlDataAdapter("select Bus_License_no,control_.Stuff_id,Name,Stuff_Type from control_,appoint,stuff_ where control_.Stuff_id=appoint.Stuff_id and stuff_.Stuff_id=control_.Stuff_id and Owner_id='" + TextBox1.Text + "'", con11);
            DataTable dt11 = new DataTable();
            sda11.Fill(dt11);
            Repeater3.DataSource = dt11;
            Repeater3.DataBind();
        }

        protected void Button9_Click(object sender, EventArgs e)
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

        protected void Button10_Click(object sender, EventArgs e)
        {
            SqlConnection con11 = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda11 = new SqlDataAdapter("update gps set description='" + TextBox12.Text + " " + TextBox13.Text + "' where id='"+TextBox12.Text+"'", con11);
            DataTable dt11 = new DataTable();
            sda11.Fill(dt11);
            TextBox12.Text = "";
            TextBox13.Text = "";
            SqlConnection con1g = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda1g = new SqlDataAdapter("select ID,latitude,longitude,description  from have,gps where Bus_License_no=ID and Owner_id='" + TextBox1.Text + "' ", con1g);
            DataTable dt1g = new DataTable();
            sda1g.Fill(dt1g);
            rptMarkers.DataSource = dt1g;
            rptMarkers.DataBind();
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