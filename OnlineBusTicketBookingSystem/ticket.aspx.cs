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
    public partial class ticket : System.Web.UI.Page
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
            TextBox40.Text = DateTime.Now.ToString("MMM");
            TextBox41.Text = DateTime.Now.ToString("yyyy");
            if (Session["ID"] != null)
            {
                Class1 ss = new Class1();
                ss.login_id = Session["ID"].ToString();
                if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
                if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
            }
            if (Session["ty"] != null)
            { TextBox37.Text = Session["ty"].ToString();  }
          
            if (Session["ID"] != null)
            {
                TextBox9.Text = Session["ID"].ToString();
                //TextBox10.Text = Session["t"].ToString();
                Class1 d = new Class1();
                d.Owner_id = TextBox9.Text;
                if (d.QueryInbala()) { TextBox10.Text = d.Taka; } else { TextBox10.Text = "0"; }
                SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1 = new SqlDataAdapter("select sl as Ticket_No,Travel_date,Sit_no as Ticket_type,stop_time as Time,Bus_License_no,Start_location,End_location,KM,Taka from ticket where pessenger_id='" + TextBox9.Text + "' order by Sit_no desc,sl desc ", con1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                GridView7.DataSource = dt1;
                GridView7.DataBind();
                Repeater2.DataSource = dt1;
                Repeater2.DataBind();
                Button1.Enabled = true;
            }
            else { Response.Redirect("home.aspx"); }
            if (TextBox37.Text == "Counter_Stuff")
            {
                TextBox21.Enabled = false;
                TextBox21.Text = DateTime.Now.ToString("dd");
                Button2.Text = "Sell";
                Button1.Text = "Find Bus";
                TextBox9.Text = TextBox9.Text + "-c";
                SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1 = new SqlDataAdapter("select sl as Ticket_No,Travel_date,Sit_no as Ticket_type,stop_time as Time,Bus_License_no,Start_location,End_location,KM,Taka from ticket where pessenger_id='" + TextBox9.Text + "' order by Sit_no desc,sl desc ", con1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                GridView7.DataSource = dt1;
                GridView7.DataBind();
                Repeater2.DataSource = dt1;
                Repeater2.DataBind();
            }

        }




        private void msgbox(string msg) { ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "CallMyFunction", "alert('" + msg + "')", true); }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Button1.Text == "Find Bus")
            {
                if (TextBox21.Text != "")
                {
                    TextBox1.Text = DropDownList1.Text;
                    TextBox2.Text = DropDownList2.Text;
                    if (TextBox1.Text == TextBox2.Text)
                    {
                        SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                        SqlDataAdapter sda = new SqlDataAdapter("select *from b_has where Bus_Stop_point='d'", con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                    }
                    else
                    {

                        SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                        // SqlDataAdapter sda = new SqlDataAdapter("(select time_schedule.Bus_License_no,Bus_Name,Bus_type,time_schedule.Bus_Stop_point as Stop_point,Location,Stop_time,time_schedule.KM as TT,Pessenger_like,Pessenger_Unlike from b_has,time_schedule,stop_office,bus_information where b_has.Bus_Stop_point=time_schedule.Bus_Stop_point and time_schedule.Bus_License_no=bus_information.Bus_License_no and time_schedule.Bus_Stop_point=stop_office.Bus_Stop_point and Location='" + TextBox1.Text + "')intersect(select time_schedule.Bus_License_no,Bus_Name,Bus_type,time_schedule.Bus_Stop_point as Stop_point,Location,Stop_time,time_schedule.KM as TT,Pessenger_like,Pessenger_Unlike from b_has,time_schedule,stop_office,bus_information where b_has.Bus_Stop_point=time_schedule.Bus_Stop_point and time_schedule.Bus_License_no=bus_information.Bus_License_no and time_schedule.Bus_Stop_point=stop_office.Bus_Stop_point and Location='" + TextBox2.Text + "') order by Stop_time ", con);
                        SqlDataAdapter sda = new SqlDataAdapter("(select time_schedule.Bus_License_no from b_has,time_schedule,stop_office,bus_information where b_has.Bus_Stop_point=time_schedule.Bus_Stop_point and time_schedule.Bus_License_no=bus_information.Bus_License_no and time_schedule.Bus_Stop_point=stop_office.Bus_Stop_point and Location='" + TextBox1.Text + "')intersect(select time_schedule.Bus_License_no from b_has,time_schedule,stop_office,bus_information where b_has.Bus_Stop_point=time_schedule.Bus_Stop_point and time_schedule.Bus_License_no=bus_information.Bus_License_no and time_schedule.Bus_Stop_point=stop_office.Bus_Stop_point and Location='" + TextBox2.Text + "')  ", con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                        TextBox11.Text = GridView1.Rows.Count.ToString();
                        int co;
                        co = int.Parse(TextBox11.Text);
                        if (co > 0)
                        {
                            GridView3.Visible = false;
                            Repeater1.Visible = true;
                            //Repeater3.Visible = true;
                            //Repeater4.Visible = true;
                            SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                            SqlDataAdapter sda1 = new SqlDataAdapter("(select time_schedule.Bus_License_no,Bus_Name,Bus_type,time_schedule.Bus_Stop_point as Stop_point,Location,Stop_time,time_schedule.KM as TT from have,b_has,time_schedule,stop_office,bus_information,L_approved where have.Bus_License_no=time_schedule.Bus_License_no and Owner_id='" + Session["ow"].ToString() + "' and b_has.Bus_Stop_point=time_schedule.Bus_Stop_point and time_schedule.Bus_License_no=bus_information.Bus_License_no and time_schedule.Bus_Stop_point=stop_office.Bus_Stop_point and L_approved.Bus_License_no=time_schedule.Bus_License_no    and L_approved.Approved='Approved' and L_approved.Time='' and L_approved.g='' and Location='" + TextBox1.Text + "')union (select time_schedule.Bus_License_no,Bus_Name,Bus_type,time_schedule.Bus_Stop_point as Stop_point,Location,Stop_time,time_schedule.KM as TT from have,b_has,time_schedule,stop_office,bus_information,L_approved where have.Bus_License_no=time_schedule.Bus_License_no and Owner_id='" + Session["ow"].ToString() + "' and b_has.Bus_Stop_point=time_schedule.Bus_Stop_point and time_schedule.Bus_License_no=bus_information.Bus_License_no and time_schedule.Bus_Stop_point=stop_office.Bus_Stop_point and L_approved.Bus_License_no=time_schedule.Bus_License_no    and L_approved.Approved='Approved' and L_approved.Time='' and L_approved.g='' and Location='" + TextBox1.Text + "') order by time_schedule.KM ", con1);
                            DataTable dt1 = new DataTable();
                            sda1.Fill(dt1);
                            GridView3.DataSource = dt1;
                            GridView3.DataBind();
                            Repeater1.DataSource = dt1;
                            Repeater1.DataBind();


                        }
                        else { GridView3.Visible = false; Repeater1.Visible = false;  }
                    }
                    TextBox6.Text = "";
                    TextBox8.Text = "";
                }
                else { msgbox("Insert date"); }
            }

            if (Button1.Text == "Search")
            {
                if (TextBox21.Text != "")
                {
                    TextBox1.Text = DropDownList1.Text;
                    TextBox2.Text = DropDownList2.Text;
                    if (TextBox1.Text == TextBox2.Text)
                    {
                        SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                        SqlDataAdapter sda = new SqlDataAdapter("select *from b_has where Bus_Stop_point='d'", con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                    }
                    else
                    {

                        SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                        // SqlDataAdapter sda = new SqlDataAdapter("(select time_schedule.Bus_License_no,Bus_Name,Bus_type,time_schedule.Bus_Stop_point as Stop_point,Location,Stop_time,time_schedule.KM as TT,Pessenger_like,Pessenger_Unlike from b_has,time_schedule,stop_office,bus_information where b_has.Bus_Stop_point=time_schedule.Bus_Stop_point and time_schedule.Bus_License_no=bus_information.Bus_License_no and time_schedule.Bus_Stop_point=stop_office.Bus_Stop_point and Location='" + TextBox1.Text + "')intersect(select time_schedule.Bus_License_no,Bus_Name,Bus_type,time_schedule.Bus_Stop_point as Stop_point,Location,Stop_time,time_schedule.KM as TT,Pessenger_like,Pessenger_Unlike from b_has,time_schedule,stop_office,bus_information where b_has.Bus_Stop_point=time_schedule.Bus_Stop_point and time_schedule.Bus_License_no=bus_information.Bus_License_no and time_schedule.Bus_Stop_point=stop_office.Bus_Stop_point and Location='" + TextBox2.Text + "') order by Stop_time ", con);
                        SqlDataAdapter sda = new SqlDataAdapter("(select time_schedule.Bus_License_no from b_has,time_schedule,stop_office,bus_information where b_has.Bus_Stop_point=time_schedule.Bus_Stop_point and time_schedule.Bus_License_no=bus_information.Bus_License_no and time_schedule.Bus_Stop_point=stop_office.Bus_Stop_point and Location='" + TextBox1.Text + "')intersect(select time_schedule.Bus_License_no from b_has,time_schedule,stop_office,bus_information where b_has.Bus_Stop_point=time_schedule.Bus_Stop_point and time_schedule.Bus_License_no=bus_information.Bus_License_no and time_schedule.Bus_Stop_point=stop_office.Bus_Stop_point and Location='" + TextBox2.Text + "')  ", con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                        TextBox11.Text = GridView1.Rows.Count.ToString();
                        int co;
                        co = int.Parse(TextBox11.Text);
                        if (co > 0)
                        {
                            GridView3.Visible = false;
                            Repeater1.Visible = true;
                           // Repeater3.Visible = true;
                           // Repeater4.Visible = true;
                            SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                            SqlDataAdapter sda1 = new SqlDataAdapter("(select time_schedule.Bus_License_no,Bus_Name,Bus_type,time_schedule.Bus_Stop_point as Stop_point,Location,Stop_time,time_schedule.KM as TT from b_has,time_schedule,stop_office,bus_information,L_approved where b_has.Bus_Stop_point=time_schedule.Bus_Stop_point and time_schedule.Bus_License_no=bus_information.Bus_License_no and time_schedule.Bus_Stop_point=stop_office.Bus_Stop_point and L_approved.Bus_License_no=time_schedule.Bus_License_no and L_approved.Approved='Approved' and L_approved.Time='' and L_approved.g='' and Location='" + TextBox1.Text + "')union(select time_schedule.Bus_License_no,Bus_Name,Bus_type,time_schedule.Bus_Stop_point as Stop_point,Location,Stop_time,time_schedule.KM as TT from b_has,time_schedule,stop_office,bus_information,L_approved where b_has.Bus_Stop_point=time_schedule.Bus_Stop_point and time_schedule.Bus_License_no=bus_information.Bus_License_no and time_schedule.Bus_Stop_point=stop_office.Bus_Stop_point and L_approved.Bus_License_no=time_schedule.Bus_License_no and L_approved.Approved='Approved' and L_approved.Time='' and L_approved.g='' and Location='" + TextBox1.Text + "') order by time_schedule.KM ", con1);
                            DataTable dt1 = new DataTable();
                            sda1.Fill(dt1);
                            GridView3.DataSource = dt1;
                            GridView3.DataBind();
                            Repeater1.DataSource = dt1;
                            Repeater1.DataBind();


                        }
                        else { GridView3.Visible = false; Repeater1.Visible = false; }
                    }
                    TextBox6.Text = "";
                    TextBox8.Text = "";
                }
                else { msgbox("Insert date"); }
            }
            Label17.Visible = false; Label18.Visible = false; GridView6.Visible = false; TextBox38.Visible = false; TextBox39.Visible = false;
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        { 
        }

        protected void Button2_Click(object sender, EventArgs e)
        {  float p94 = float.Parse(DateTime.Now.ToString("dd")), p96 = float.Parse(TextBox21.Text);

              float  p90=float.Parse(TextBox12.Text),
                p93 = float.Parse(DateTime.Now.ToString("hh.mm"));
            
            string p91 = TextBox13.Text.ToLower(),
                p92 = DateTime.Now.ToString("tt").ToLower();
          
            if (p91 == p92 && p94 == p96 && p93>=p90) { msgbox("This service expire for today."); }else{
            if (Session["ID"] != null)
            {
                Class1 ss = new Class1();
                ss.login_id = Session["ID"].ToString();
                if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
                if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
            }
            Button2.Enabled = false;
            if (Button2.Text == "Sell")
            {
                int m1, m2, m3 = 0, m4 = 11, m5 = 500;
                if (TextBox21.Text != "")
                {

                    m1 = int.Parse(DateTime.Now.ToString("MM"));
                    m2 = int.Parse(DateTime.Now.ToString("yyyy"));
                    m3 = int.Parse(System.DateTime.DaysInMonth(m2, m1).ToString());
                    m4 = int.Parse(TextBox21.Text);
                    m5 = int.Parse(DateTime.Now.ToString("dd"));

                }

                if (m4 <= m3 && m4 > m5 - 1)
                {
                    TextBox24.Text = TextBox21.Text + DateTime.Now.ToString("-MMM-yyyy");
                    int ch1, ch2;
                    ch1 = int.Parse(TextBox14.Text);
                    ch2 = int.Parse(TextBox15.Text);
                    if (ch1 < ch2)
                    {
                        SqlConnection con11 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                        SqlDataAdapter sda11 = new SqlDataAdapter("select *from ticket where  stop_time='" + TextBox12.Text + TextBox13.Text + "' and Bus_License_no='" + TextBox3.Text + "' and Travel_date='" + TextBox24.Text + "' and (ss_n<='" + TextBox14.Text + "' or ss_n>='" + TextBox14.Text + "') and (es_n>='" + TextBox15.Text + "' or es_n<='" + TextBox15.Text + "' ) and Sit_no like'si%' and Start_location like'f%' and End_location like 'f%'-- and Sit_no='" + TextBox23.Text + "'", con11);
                        DataTable dt11 = new DataTable();
                        sda11.Fill(dt11);
                        GridView4.DataSource = dt11;
                        GridView4.DataBind();
                        int sc, te;
                        sc = int.Parse(GridView4.Rows.Count.ToString());
                        te = int.Parse(TextBox16.Text);
                        te = te - sc;
                        TextBox19.Text = te.ToString();
                        TextBox18.Text = (sc + 1).ToString();
                        SqlConnection con111 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                        SqlDataAdapter sda111 = new SqlDataAdapter("select *from ticket where stop_time='" + TextBox12.Text + TextBox13.Text + "' and Bus_License_no='" + TextBox3.Text + "' and Travel_date='" + TextBox24.Text + "' and (ss_n<='" + TextBox14.Text + "' or ss_n>='" + TextBox14.Text + "') and (es_n>='" + TextBox15.Text + "' or es_n<='" + TextBox15.Text + "') and Sit_no like'st%' and Start_location like'f%' and End_location like 'f%' --and Sit_no='" + TextBox23.Text + "'", con111);
                        DataTable dt111 = new DataTable();
                        sda111.Fill(dt111);
                        GridView5.DataSource = dt111;
                        GridView5.DataBind();
                        int sc1, te1;
                        sc1 = int.Parse(GridView5.Rows.Count.ToString());
                        te1 = int.Parse(TextBox17.Text);
                        te1 = te1 - sc1;
                        TextBox20.Text = te1.ToString();
                        TextBox22.Text = (sc1 + 1).ToString();

                    }
                    else
                    {
                        SqlConnection con11 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                        SqlDataAdapter sda11 = new SqlDataAdapter("select *from ticket where stop_time='" + TextBox12.Text + TextBox13.Text + "' and Bus_License_no='" + TextBox3.Text + "' and Travel_date='" + TextBox24.Text + "' and (ss_n<='" + TextBox14.Text + "' or ss_n>='" + TextBox14.Text + "') and (es_n>='" + TextBox15.Text + "' or es_n<='" + TextBox15.Text + "' ) and Sit_no like'si%' and Start_location like'l%' and End_location like 'l%'-- and Sit_no='" + TextBox23.Text + "'", con11);
                        DataTable dt11 = new DataTable();
                        sda11.Fill(dt11);
                        GridView4.DataSource = dt11;
                        GridView4.DataBind();
                        int sc, te;
                        sc = int.Parse(GridView4.Rows.Count.ToString());
                        te = int.Parse(TextBox16.Text);
                        te = te - sc;
                        TextBox19.Text = te.ToString();
                        TextBox18.Text = (sc + 1).ToString();
                        SqlConnection con111 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                        SqlDataAdapter sda111 = new SqlDataAdapter("select *from ticket where stop_time='" + TextBox12.Text + TextBox13.Text + "' and Bus_License_no='" + TextBox3.Text + "' and Travel_date='" + TextBox24.Text + "' and (ss_n<='" + TextBox14.Text + "' or ss_n>='" + TextBox14.Text + "') and (es_n>='" + TextBox15.Text + "' or es_n<='" + TextBox15.Text + "') and Sit_no like'st%' and Start_location like'l%' and End_location like 'l%' --and Sit_no='" + TextBox23.Text + "'", con111);
                        DataTable dt111 = new DataTable();
                        sda111.Fill(dt111);
                        GridView5.DataSource = dt111;
                        GridView5.DataBind();
                        int sc1, te1;
                        sc1 = int.Parse(GridView5.Rows.Count.ToString());
                        te1 = int.Parse(TextBox17.Text);
                        te1 = te1 - sc1;
                        TextBox20.Text = te1.ToString();
                        TextBox22.Text = (sc1 + 1).ToString();
                    }

                    //////////////
                    int kkl, kkl1;
                    kkl = int.Parse(TextBox19.Text);
                    kkl1 = int.Parse(TextBox20.Text);
                    if (kkl == 0) { TextBox23.Text = "stand-" + TextBox22.Text; }
                    if (kkl > 0) { TextBox23.Text = "sit-" + TextBox18.Text; }
                    if (ch1 > ch2)
                    {
                        TextBox1.Text = "l-" + TextBox1.Text;
                        TextBox2.Text = "l-" + TextBox2.Text;
                    }
                    if (ch1 < ch2)
                    {
                        TextBox1.Text = "f-" + TextBox1.Text;
                        TextBox2.Text = "f-" + TextBox2.Text;
                    }
                    SqlConnection con111q = new SqlConnection(Properties.Settings.Default._ConnectionString);
                    SqlDataAdapter sda111q = new SqlDataAdapter("select *from ticket where  bus_license_no='" + TextBox3.Text + "' and Travel_date='" + TextBox21.Text + DateTime.Now.ToString("-MMM-yyyy") + "' and Sit_no='" + TextBox23.Text + "'", con111q);
                    DataTable dt111q = new DataTable();
                    sda111q.Fill(dt111q);
                    GridView9.DataSource = dt111q;
                    GridView9.DataBind();
                    int ddf, llm, i, kkk = 1;

                    ddf = int.Parse(GridView9.Rows.Count.ToString());
                    if (ddf > 0 && TextBox23.Text.StartsWith("si"))
                    {
                        llm = int.Parse(TextBox16.Text);
                        for (i = 1; i <= llm; i++)
                        {
                            SqlConnection con111qs = new SqlConnection(Properties.Settings.Default._ConnectionString);
                            SqlDataAdapter sda111qs = new SqlDataAdapter("select *from ticket where  bus_license_no='" + TextBox3.Text + "' and Travel_date='" + TextBox21.Text + DateTime.Now.ToString("-MMM-yyyy") + "' and Sit_no='" + "sit-" + i + "'", con111qs);
                            DataTable dt111qs = new DataTable();
                            sda111qs.Fill(dt111qs);
                            GridView9.DataSource = dt111qs;
                            GridView9.DataBind();
                            int ddsf, llsm = 0;
                            ddsf = int.Parse(GridView9.Rows.Count.ToString());
                            if (ddsf == 0) { break; }
                            kkk = i + 1;


                        }
                        TextBox23.Text = "sit-" + kkk.ToString();
                    }

                    if (ddf > 0 && TextBox23.Text.StartsWith("st"))
                    {

                        llm = int.Parse(TextBox17.Text);
                        for (i = 1; i <= llm; i++)
                        {
                            SqlConnection con111qs = new SqlConnection(Properties.Settings.Default._ConnectionString);
                            SqlDataAdapter sda111qs = new SqlDataAdapter("select *from ticket where  bus_license_no='" + TextBox3.Text + "' and Travel_date='" + TextBox21.Text + DateTime.Now.ToString("-MMM-yyyy") + "' and Sit_no='" + "stand-" + i + "'", con111qs);
                            DataTable dt111qs = new DataTable();
                            sda111qs.Fill(dt111qs);
                            GridView9.DataSource = dt111qs;
                            GridView9.DataBind();
                            int ddsf, llsm = 0;
                            ddsf = int.Parse(GridView9.Rows.Count.ToString());
                            if (ddsf == 0) { break; }
                            kkk = i + 1;


                        }
                        TextBox23.Text = "stand-" + kkk.ToString();
                    }
                    if (TextBox19.Text == "0" && TextBox20.Text == "0") { TextBox1.Text = DropDownList1.Text; TextBox2.Text = DropDownList2.Text; msgbox("No capacity on this bus."); }

                    if (kkl > 0 || kkl1 > 0)
                    {


                        float aa, bb, cc;
                        aa = float.Parse(TextBox10.Text);
                        bb = float.Parse(TextBox8.Text);
                        if (aa >= bb || aa<=bb)
                        {
                            cc = aa - bb;
                            //TextBox10.Text = cc.ToString();
                            SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                            SqlDataAdapter sda = new SqlDataAdapter(" --update balance set Taka='" + TextBox10.Text + "' where owner_id=''", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            Class1 d = new Class1();


                            d.Bus_License_no = TextBox3.Text;
                            d.Pessenger_id = TextBox9.Text;
                            d.Travel_date = TextBox21.Text + DateTime.Now.ToString("-MMM-yyyy");
                            d.Start_location = TextBox1.Text;
                            d.End_location = TextBox2.Text;

                            d.Sit_no = TextBox23.Text;

                            d.KM = TextBox6.Text;
                            d.Taka = TextBox8.Text;
                            d.ss_n = TextBox14.Text;
                            d.es_n = TextBox15.Text;
                            d.stop_time = TextBox12.Text + TextBox13.Text;
                            if (d.DataSaveInticket())
                            {
                                SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                                SqlDataAdapter sda1 = new SqlDataAdapter("select sl as Ticket_No,Travel_date,Sit_no as Ticket_type,stop_time as Time,Bus_License_no,Start_location,End_location,KM,Taka from ticket where pessenger_id='" + TextBox9.Text + "' order by Sit_no desc,sl desc ", con1);
                                DataTable dt1 = new DataTable();
                                sda1.Fill(dt1);
                                GridView7.DataSource = dt1;
                                GridView7.DataBind();
                                Repeater2.DataSource = dt1;
                                Repeater2.DataBind();
                                Session["a"] = TextBox23.Text;
                                Session["b"] = TextBox21.Text + DateTime.Now.ToString("-MMM-yyyy");
                                Session["c"] = TextBox12.Text + TextBox13.Text;
                                Session["d"] = TextBox3.Text;
                                Session["e"] = TextBox1.Text;
                                Session["f"] = TextBox2.Text;
                                Session["g"] = TextBox8.Text;
                                msgbox("Confirm"); TextBox1.Text = DropDownList1.Text; TextBox2.Text = DropDownList2.Text;
                              
                                Class1 u = new Class1();
                                u.Owner_id = TextBox25.Text;
                                if (u.QueryInbala())
                                {
                                    TextBox26.Text = u.Taka;
                                    float t3, tt, tt1; tt = float.Parse(TextBox26.Text);
                                    tt1 = float.Parse(TextBox8.Text);
                                    t3 = tt + tt1;
                                    SqlConnection con11r = new SqlConnection(Properties.Settings.Default._ConnectionString);
                                    SqlDataAdapter sda11r = new SqlDataAdapter("--update balance set taka='" + t3.ToString() + "' where owner_id=''", con11r);
                                    DataTable dt11r = new DataTable();
                                    sda11r.Fill(dt11r);

                                }
                              
                              
                                Response.Redirect("print.aspx");

                            }

                        }
                        else { msgbox("No balance"); }
                    }
                    //Button2.Enabled = false;
                    int ch11, ch21;
                    ch11 = int.Parse(TextBox14.Text);
                    ch21 = int.Parse(TextBox15.Text);
                    if (ch11 < ch21)
                    {
                        SqlConnection con11 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                        SqlDataAdapter sda11 = new SqlDataAdapter("select *from ticket where stop_time='" + TextBox12.Text + TextBox13.Text + "' and Bus_License_no='" + TextBox3.Text + "' and Travel_date='" + TextBox24.Text + "' and (ss_n<='" + TextBox14.Text + "' or ss_n>='" + TextBox14.Text + "') and (es_n>='" + TextBox15.Text + "' or es_n<='" + TextBox15.Text + "' ) and Sit_no like'si%' and Start_location like'f%' and End_location like 'f%'-- and Sit_no='" + TextBox23.Text + "'", con11);
                        DataTable dt11 = new DataTable();
                        sda11.Fill(dt11);
                        GridView4.DataSource = dt11;
                        GridView4.DataBind();
                        int sc, te;
                        sc = int.Parse(GridView4.Rows.Count.ToString());
                        te = int.Parse(TextBox16.Text);
                        te = te - sc;
                        TextBox19.Text = te.ToString();
                        TextBox18.Text = (sc + 1).ToString();
                        SqlConnection con111 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                        SqlDataAdapter sda111 = new SqlDataAdapter("select *from ticket where stop_time='" + TextBox12.Text + TextBox13.Text + "' and Bus_License_no='" + TextBox3.Text + "' and Travel_date='" + TextBox24.Text + "' and (ss_n<='" + TextBox14.Text + "' or ss_n>='" + TextBox14.Text + "') and (es_n>='" + TextBox15.Text + "' or es_n<='" + TextBox15.Text + "') and Sit_no like'st%' and Start_location like'f%' and End_location like 'f%' --and Sit_no='" + TextBox23.Text + "'", con111);
                        DataTable dt111 = new DataTable();
                        sda111.Fill(dt111);
                        GridView5.DataSource = dt111;
                        GridView5.DataBind();
                        int sc1, te1;
                        sc1 = int.Parse(GridView5.Rows.Count.ToString());
                        te1 = int.Parse(TextBox17.Text);
                        te1 = te1 - sc1;
                        TextBox20.Text = te1.ToString();
                        TextBox22.Text = (sc1 + 1).ToString();

                    }
                    else
                    {
                        SqlConnection con11 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                        SqlDataAdapter sda11 = new SqlDataAdapter("select *from ticket where stop_time='" + TextBox12.Text + TextBox13.Text + "' and Bus_License_no='" + TextBox3.Text + "' and Travel_date='" + TextBox24.Text + "' and (ss_n<='" + TextBox14.Text + "' or ss_n>='" + TextBox14.Text + "') and (es_n>='" + TextBox15.Text + "' or es_n<='" + TextBox15.Text + "' ) and Sit_no like'si%' and Start_location like'l%' and End_location like 'l%'-- and Sit_no='" + TextBox23.Text + "'", con11);
                        DataTable dt11 = new DataTable();
                        sda11.Fill(dt11);
                        GridView4.DataSource = dt11;
                        GridView4.DataBind();
                        int sc, te;
                        sc = int.Parse(GridView4.Rows.Count.ToString());
                        te = int.Parse(TextBox16.Text);
                        te = te - sc;
                        TextBox19.Text = te.ToString();
                        TextBox18.Text = (sc + 1).ToString();
                        SqlConnection con111 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                        SqlDataAdapter sda111 = new SqlDataAdapter("select *from ticket where stop_time='" + TextBox12.Text + TextBox13.Text + "' and Bus_License_no='" + TextBox3.Text + "' and Travel_date='" + TextBox24.Text + "' and (ss_n<='" + TextBox14.Text + "' or ss_n>='" + TextBox14.Text + "') and (es_n>='" + TextBox15.Text + "' or es_n<='" + TextBox15.Text + "') and Sit_no like'st%' and Start_location like'l%' and End_location like 'l%' --and Sit_no='" + TextBox23.Text + "'", con111);
                        DataTable dt111 = new DataTable();
                        sda111.Fill(dt111);
                        GridView5.DataSource = dt111;
                        GridView5.DataBind();
                        int sc1, te1;
                        sc1 = int.Parse(GridView5.Rows.Count.ToString());
                        te1 = int.Parse(TextBox17.Text);
                        te1 = te1 - sc1;
                        TextBox20.Text = te1.ToString();
                        TextBox22.Text = (sc1 + 1).ToString();
                    }

                }
                else { msgbox("Not possible"); }
                SqlConnection con1zz7 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1z = new SqlDataAdapter("select sl as Ticket_No,Travel_date,Sit_no as Ticket_type,stop_time as Time,Bus_License_no,Start_location,End_location,KM,Taka from ticket where pessenger_id='" + TextBox9.Text + "' order by SL desc", con1zz7);
                DataTable dt1z = new DataTable();
                sda1z.Fill(dt1z);
                GridView7.DataSource = dt1z;
                GridView7.DataBind();
                
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (Button2.Text == "Confirm")
            {
                int m1, m2, m3 = 0, m4 = 11, m5 = 500;
                if (TextBox21.Text != "")
                {

                    m1 = int.Parse(DateTime.Now.ToString("MM"));
                    m2 = int.Parse(DateTime.Now.ToString("yyyy"));
                    m3 = int.Parse(System.DateTime.DaysInMonth(m2, m1).ToString());
                    m4 = int.Parse(TextBox21.Text);
                    m5 = int.Parse(DateTime.Now.ToString("dd"));

                }

                if (m4 <= m3 && m4 > m5 - 1)
                {
                    TextBox24.Text = TextBox21.Text + DateTime.Now.ToString("-MMM-yyyy");
                    int ch1, ch2;
                    ch1 = int.Parse(TextBox14.Text);
                    ch2 = int.Parse(TextBox15.Text);
                    if (ch1 < ch2)
                    {
                        SqlConnection con11 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                        SqlDataAdapter sda11 = new SqlDataAdapter("select *from ticket where stop_time='" + TextBox12.Text + TextBox13.Text + "' and Bus_License_no='" + TextBox3.Text + "' and Travel_date='" + TextBox24.Text + "' and (ss_n<='" + TextBox14.Text + "' or ss_n>='" + TextBox14.Text + "') and (es_n>='" + TextBox15.Text + "' or es_n<='" + TextBox15.Text + "' ) and Sit_no like'si%' and Start_location like'f%' and End_location like 'f%'-- and Sit_no='" + TextBox23.Text + "'", con11);
                        DataTable dt11 = new DataTable();
                        sda11.Fill(dt11);
                        GridView4.DataSource = dt11;
                        GridView4.DataBind();
                        int sc, te;
                        sc = int.Parse(GridView4.Rows.Count.ToString());
                        te = int.Parse(TextBox16.Text);
                        te = te - sc;
                        TextBox19.Text = te.ToString();
                        TextBox18.Text = (sc + 1).ToString();
                        SqlConnection con111 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                        SqlDataAdapter sda111 = new SqlDataAdapter("select *from ticket where stop_time='" + TextBox12.Text + TextBox13.Text + "' and Bus_License_no='" + TextBox3.Text + "' and Travel_date='" + TextBox24.Text + "' and (ss_n<='" + TextBox14.Text + "' or ss_n>='" + TextBox14.Text + "') and (es_n>='" + TextBox15.Text + "' or es_n<='" + TextBox15.Text + "') and Sit_no like'st%' and Start_location like'f%' and End_location like 'f%' --and Sit_no='" + TextBox23.Text + "'", con111);
                        DataTable dt111 = new DataTable();
                        sda111.Fill(dt111);
                        GridView5.DataSource = dt111;
                        GridView5.DataBind();
                        int sc1, te1;
                        sc1 = int.Parse(GridView5.Rows.Count.ToString());
                        te1 = int.Parse(TextBox17.Text);
                        te1 = te1 - sc1;
                        TextBox20.Text = te1.ToString();
                        TextBox22.Text = (sc1 + 1).ToString();

                    }
                    else
                    {
                        SqlConnection con11 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                        SqlDataAdapter sda11 = new SqlDataAdapter("select *from ticket where stop_time='" + TextBox12.Text + TextBox13.Text + "' and Bus_License_no='" + TextBox3.Text + "' and Travel_date='" + TextBox24.Text + "' and (ss_n<='" + TextBox14.Text + "' or ss_n>='" + TextBox14.Text + "') and (es_n>='" + TextBox15.Text + "' or es_n<='" + TextBox15.Text + "' ) and Sit_no like'si%' and Start_location like'l%' and End_location like 'l%'-- and Sit_no='" + TextBox23.Text + "'", con11);
                        DataTable dt11 = new DataTable();
                        sda11.Fill(dt11);
                        GridView4.DataSource = dt11;
                        GridView4.DataBind();
                        int sc, te;
                        sc = int.Parse(GridView4.Rows.Count.ToString());
                        te = int.Parse(TextBox16.Text);
                        te = te - sc;
                        TextBox19.Text = te.ToString();
                        TextBox18.Text = (sc + 1).ToString();
                        SqlConnection con111 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                        SqlDataAdapter sda111 = new SqlDataAdapter("select *from ticket where stop_time='" + TextBox12.Text + TextBox13.Text + "' and Bus_License_no='" + TextBox3.Text + "' and Travel_date='" + TextBox24.Text + "' and (ss_n<='" + TextBox14.Text + "' or ss_n>='" + TextBox14.Text + "') and (es_n>='" + TextBox15.Text + "' or es_n<='" + TextBox15.Text + "') and Sit_no like'st%' and Start_location like'l%' and End_location like 'l%' --and Sit_no='" + TextBox23.Text + "'", con111);
                        DataTable dt111 = new DataTable();
                        sda111.Fill(dt111);
                        GridView5.DataSource = dt111;
                        GridView5.DataBind();
                        int sc1, te1;
                        sc1 = int.Parse(GridView5.Rows.Count.ToString());
                        te1 = int.Parse(TextBox17.Text);
                        te1 = te1 - sc1;
                        TextBox20.Text = te1.ToString();
                        TextBox22.Text = (sc1 + 1).ToString();
                    }

                    //////////////
                    int kkl, kkl1;
                    kkl = int.Parse(TextBox19.Text);
                    kkl1 = int.Parse(TextBox20.Text);
                    if (kkl == 0) { TextBox23.Text = "stand-" + TextBox22.Text; }
                    if (kkl > 0) { TextBox23.Text = "sit-" + TextBox18.Text; }
                    if (ch1 > ch2)
                    {
                        TextBox1.Text = "l-" + TextBox1.Text;
                        TextBox2.Text = "l-" + TextBox2.Text;
                    }
                    if (ch1 < ch2)
                    {
                        TextBox1.Text = "f-" + TextBox1.Text;
                        TextBox2.Text = "f-" + TextBox2.Text;
                    }
                    SqlConnection con111q = new SqlConnection(Properties.Settings.Default._ConnectionString);
                    SqlDataAdapter sda111q = new SqlDataAdapter("select *from ticket where  bus_license_no='" + TextBox3.Text + "' and Travel_date='" + TextBox21.Text + DateTime.Now.ToString("-MMM-yyyy") + "' and Sit_no='" + TextBox23.Text + "'", con111q);
                    DataTable dt111q = new DataTable();
                    sda111q.Fill(dt111q);
                    GridView9.DataSource = dt111q;
                    GridView9.DataBind();
                    int ddf, llm, i, kkk = 1;

                    ddf = int.Parse(GridView9.Rows.Count.ToString());
                    if (ddf > 0 && TextBox23.Text.StartsWith("si"))
                    {
                        llm = int.Parse(TextBox16.Text);
                        for (i = 1; i <= llm; i++)
                        {
                            SqlConnection con111qs = new SqlConnection(Properties.Settings.Default._ConnectionString);
                            SqlDataAdapter sda111qs = new SqlDataAdapter("select *from ticket where  bus_license_no='" + TextBox3.Text + "' and Travel_date='" + TextBox21.Text + DateTime.Now.ToString("-MMM-yyyy") + "' and Sit_no='" + "sit-" + i + "'", con111qs);
                            DataTable dt111qs = new DataTable();
                            sda111qs.Fill(dt111qs);
                            GridView9.DataSource = dt111qs;
                            GridView9.DataBind();
                            int ddsf, llsm = 0;
                            ddsf = int.Parse(GridView9.Rows.Count.ToString());
                            if (ddsf == 0) { break; }
                            kkk = i + 1;


                        }
                        TextBox23.Text = "sit-" + kkk.ToString();
                    }

                    if (ddf > 0 && TextBox23.Text.StartsWith("st"))
                    {

                        llm = int.Parse(TextBox17.Text);
                        for (i = 1; i <= llm; i++)
                        {
                            SqlConnection con111qs = new SqlConnection(Properties.Settings.Default._ConnectionString);
                            SqlDataAdapter sda111qs = new SqlDataAdapter("select *from ticket where  bus_license_no='" + TextBox3.Text + "' and Travel_date='" + TextBox21.Text + DateTime.Now.ToString("-MMM-yyyy") + "' and Sit_no='" + "stand-" + i + "'", con111qs);
                            DataTable dt111qs = new DataTable();
                            sda111qs.Fill(dt111qs);
                            GridView9.DataSource = dt111qs;
                            GridView9.DataBind();
                            int ddsf, llsm = 0;
                            ddsf = int.Parse(GridView9.Rows.Count.ToString());
                            if (ddsf == 0) { break; }
                            kkk = i + 1;


                        }
                        TextBox23.Text = "stand-" + kkk.ToString();
                    }
                
                    if (TextBox19.Text == "0" && TextBox20.Text == "0") { TextBox1.Text = DropDownList1.Text; TextBox2.Text = DropDownList2.Text; msgbox("No capacity on this bus."); }

                    if (kkl > 0 || kkl1 > 0)
                    {


                        float aa, bb, cc;
                        aa = float.Parse(TextBox10.Text);
                        bb = float.Parse(TextBox8.Text);
                        if (aa >= bb)
                        {
                            cc = aa - bb;
                            TextBox10.Text = cc.ToString();
                            SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                            SqlDataAdapter sda = new SqlDataAdapter(" insert into balance values ('" + TextBox9.Text + "','-" + TextBox8.Text + "') insert into balance values ('" + TextBox25.Text + "','" + TextBox8.Text + "')--update balance set Taka='" + TextBox10.Text + "' where owner_id='" + TextBox9.Text + "'", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            Class1 d = new Class1();


                            d.Bus_License_no = TextBox3.Text;
                            d.Pessenger_id = TextBox9.Text;
                            d.Travel_date = TextBox21.Text + DateTime.Now.ToString("-MMM-yyyy");
                            d.Start_location = TextBox1.Text;
                            d.End_location = TextBox2.Text;

                            d.Sit_no = TextBox23.Text;

                            d.KM = TextBox6.Text;
                            d.Taka = TextBox8.Text;
                            d.ss_n = TextBox14.Text;
                            d.es_n = TextBox15.Text;
                            d.stop_time = TextBox12.Text + TextBox13.Text;
                            if (d.DataSaveInticket())
                            {
                                SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                                SqlDataAdapter sda1 = new SqlDataAdapter("select sl as Ticket_No,Travel_date,Sit_no as Ticket_type,stop_time as Time,Bus_License_no,Start_location,End_location,KM,Taka from ticket where pessenger_id='" + TextBox9.Text + "' order by Sit_no desc,sl desc ", con1);
                                DataTable dt1 = new DataTable();
                                sda1.Fill(dt1);
                                GridView7.DataSource = dt1;
                                GridView7.DataBind();
                                Repeater2.DataSource = dt1;
                                Repeater2.DataBind();
                                msgbox("Confirm"); TextBox1.Text = DropDownList1.Text; TextBox2.Text = DropDownList2.Text;

                                Class1 u = new Class1();
                                u.Owner_id = TextBox25.Text;
                                if (u.QueryInbala())
                                {
                                    TextBox26.Text = u.Taka;
                                    float t3, tt, tt1; tt = float.Parse(TextBox26.Text);
                                    tt1 = float.Parse(TextBox8.Text);
                                    t3 = tt + tt1;
                                    SqlConnection con11r = new SqlConnection(Properties.Settings.Default._ConnectionString);
                                    SqlDataAdapter sda11r = new SqlDataAdapter("--update balance set taka='" + t3.ToString() + "' where owner_id='" + TextBox25.Text + "'", con11r);
                                    DataTable dt11r = new DataTable();
                                    sda11r.Fill(dt11r);

                                }

                            }
                            

                        }
                        else { msgbox("No balance"); }
                    }
                    //Button2.Enabled = false;
                    int ch11, ch21;
                    ch11 = int.Parse(TextBox14.Text);
                    ch21 = int.Parse(TextBox15.Text);
                    if (ch11 < ch21)
                    {
                        SqlConnection con11 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                        SqlDataAdapter sda11 = new SqlDataAdapter("select *from ticket where stop_time='" + TextBox12.Text + TextBox13.Text + "' and Bus_License_no='" + TextBox3.Text + "' and Travel_date='" + TextBox24.Text + "' and (ss_n<='" + TextBox14.Text + "' or ss_n>='" + TextBox14.Text + "') and (es_n>='" + TextBox15.Text + "' or es_n<='" + TextBox15.Text + "' ) and Sit_no like'si%' and Start_location like'f%' and End_location like 'f%'-- and Sit_no='" + TextBox23.Text + "'", con11);
                        DataTable dt11 = new DataTable();
                        sda11.Fill(dt11);
                        GridView4.DataSource = dt11;
                        GridView4.DataBind();
                        int sc, te;
                        sc = int.Parse(GridView4.Rows.Count.ToString());
                        te = int.Parse(TextBox16.Text);
                        te = te - sc;
                        TextBox19.Text = te.ToString();
                        TextBox18.Text = (sc + 1).ToString();
                        SqlConnection con111 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                        SqlDataAdapter sda111 = new SqlDataAdapter("select *from ticket where stop_time='" + TextBox12.Text + TextBox13.Text + "' and Bus_License_no='" + TextBox3.Text + "' and Travel_date='" + TextBox24.Text + "' and (ss_n<='" + TextBox14.Text + "' or ss_n>='" + TextBox14.Text + "') and (es_n>='" + TextBox15.Text + "' or es_n<='" + TextBox15.Text + "') and Sit_no like'st%' and Start_location like'f%' and End_location like 'f%' --and Sit_no='" + TextBox23.Text + "'", con111);
                        DataTable dt111 = new DataTable();
                        sda111.Fill(dt111);
                        GridView5.DataSource = dt111;
                        GridView5.DataBind();
                        int sc1, te1;
                        sc1 = int.Parse(GridView5.Rows.Count.ToString());
                        te1 = int.Parse(TextBox17.Text);
                        te1 = te1 - sc1;
                        TextBox20.Text = te1.ToString();
                        TextBox22.Text = (sc1 + 1).ToString();

                    }
                    else
                    {
                        SqlConnection con11 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                        SqlDataAdapter sda11 = new SqlDataAdapter("select *from ticket where stop_time='" + TextBox12.Text + TextBox13.Text + "' and Bus_License_no='" + TextBox3.Text + "' and Travel_date='" + TextBox24.Text + "' and (ss_n<='" + TextBox14.Text + "' or ss_n>='" + TextBox14.Text + "') and (es_n>='" + TextBox15.Text + "' or es_n<='" + TextBox15.Text + "' ) and Sit_no like'si%' and Start_location like'l%' and End_location like 'l%'-- and Sit_no='" + TextBox23.Text + "'", con11);
                        DataTable dt11 = new DataTable();
                        sda11.Fill(dt11);
                        GridView4.DataSource = dt11;
                        GridView4.DataBind();
                        int sc, te;
                        sc = int.Parse(GridView4.Rows.Count.ToString());
                        te = int.Parse(TextBox16.Text);
                        te = te - sc;
                        TextBox19.Text = te.ToString();
                        TextBox18.Text = (sc + 1).ToString();
                        SqlConnection con111 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                        SqlDataAdapter sda111 = new SqlDataAdapter("select *from ticket where stop_time='" + TextBox12.Text + TextBox13.Text + "' and Bus_License_no='" + TextBox3.Text + "' and Travel_date='" + TextBox24.Text + "' and (ss_n<='" + TextBox14.Text + "' or ss_n>='" + TextBox14.Text + "') and (es_n>='" + TextBox15.Text + "' or es_n<='" + TextBox15.Text + "') and Sit_no like'st%' and Start_location like'l%' and End_location like 'l%' --and Sit_no='" + TextBox23.Text + "'", con111);
                        DataTable dt111 = new DataTable();
                        sda111.Fill(dt111);
                        GridView5.DataSource = dt111;
                        GridView5.DataBind();
                        int sc1, te1;
                        sc1 = int.Parse(GridView5.Rows.Count.ToString());
                        te1 = int.Parse(TextBox17.Text);
                        te1 = te1 - sc1;
                        TextBox20.Text = te1.ToString();
                        TextBox22.Text = (sc1 + 1).ToString();
                    }

                }
                else { msgbox("Not possible"); }
                SqlConnection con1z1= new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1z1 = new SqlDataAdapter("select sl as Ticket_No,Travel_date,Sit_no as Ticket_type,stop_time as Time,Bus_License_no,Start_location,End_location,KM,Taka from ticket where pessenger_id='" + TextBox9.Text + "' order by SL desc", con1z1);
                DataTable dt1z1 = new DataTable();
                sda1z1.Fill(dt1z1);
                GridView7.DataSource = dt1z1;
                GridView7.DataBind();
            }
        }
            /////
        }

        protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
        {  int m1, m2, m3=0, m4 = 11,m5=500 ;
            if (TextBox21.Text != "") 
            {
                
                m1 = int.Parse(DateTime.Now.ToString("MM"));
                m2 = int.Parse(DateTime.Now.ToString("yyyy"));
                m3 = int.Parse(System.DateTime.DaysInMonth(m2, m1).ToString());
                m4 = int.Parse(TextBox21.Text);
                m5 = int.Parse(DateTime.Now.ToString("dd"));
            }

            if (m4 <= m3 && m4 >= m5)
            {
                TextBox24.Text = TextBox21.Text + DateTime.Now.ToString("-MMM-yyyy");
            }
            GridViewRow row = GridView3.SelectedRow;


            TextBox3.Text = row.Cells[1].Text;
            TextBox12.Text = row.Cells[6].Text;
            TextBox13.Text = row.Cells[7].Text;
            SqlConnection con114 = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda114 = new SqlDataAdapter("(select Stop_time as Time,time_schedule.KM as TT from b_has,time_schedule,stop_office,bus_information where b_has.Bus_Stop_point=time_schedule.Bus_Stop_point and time_schedule.Bus_License_no=bus_information.Bus_License_no and time_schedule.Bus_Stop_point=stop_office.Bus_Stop_point and Location='" + TextBox2.Text + "' and time_schedule.Bus_License_no='" + TextBox3.Text + "')union(select Stop_time as Time,time_schedule.KM as TT from b_has,time_schedule,stop_office,bus_information where b_has.Bus_Stop_point=time_schedule.Bus_Stop_point and time_schedule.Bus_License_no=bus_information.Bus_License_no and time_schedule.Bus_Stop_point=stop_office.Bus_Stop_point and Location='" + TextBox2.Text + "' and time_schedule.Bus_License_no='" + TextBox3.Text + "') order by time_schedule.KM", con114);
            DataTable dt114 = new DataTable();
            sda114.Fill(dt114);
            GridView6.DataSource = dt114;
            GridView6.DataBind();
            SqlConnection con114g = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda114g = new SqlDataAdapter("(select Stop_time as Time,time_schedule.KM as TT from b_has,time_schedule,stop_office,bus_information where b_has.Bus_Stop_point=time_schedule.Bus_Stop_point and time_schedule.Bus_License_no=bus_information.Bus_License_no and time_schedule.Bus_Stop_point=stop_office.Bus_Stop_point and Location='" + TextBox1.Text + "' and time_schedule.Bus_License_no='" + TextBox3.Text + "')union(select Stop_time as Time,time_schedule.KM as TT from b_has,time_schedule,stop_office,bus_information where b_has.Bus_Stop_point=time_schedule.Bus_Stop_point and time_schedule.Bus_License_no=bus_information.Bus_License_no and time_schedule.Bus_Stop_point=stop_office.Bus_Stop_point and Location='" + TextBox1.Text + "' and time_schedule.Bus_License_no='" + TextBox3.Text + "') order by time_schedule.KM", con114g);
            DataTable dt114g = new DataTable();
            sda114g.Fill(dt114g);
            GridView8.DataSource = dt114g;
            GridView8.DataBind();
            

            SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda = new SqlDataAdapter("select km,b_has.s_no from b_has,stop_office where stop_office.Bus_Stop_point=b_has.Bus_Stop_point and Bus_License_no='" + TextBox3.Text + "' and Location='" + TextBox1.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            GridView2.DataSource = dt;
            GridView2.DataBind();
            this.GridView2.SelectedIndex = 0;

            TextBox4.Text = this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[0].Text;
            TextBox14.Text = this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[1].Text;
            SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda1 = new SqlDataAdapter("select km,b_has.s_no from b_has,stop_office where stop_office.Bus_Stop_point=b_has.Bus_Stop_point and Bus_License_no='" + TextBox3.Text + "' and Location=N'" + TextBox2.Text + "'", con1);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            GridView2.DataSource = dt1;
            GridView2.DataBind();
            this.GridView2.SelectedIndex = 0;

            TextBox5.Text = this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[0].Text;
            TextBox15.Text = this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[1].Text;
            float a, b, c, d;
            a = float.Parse(TextBox4.Text);
            b = float.Parse(TextBox5.Text);
            if (a > b) { c = a - b; } else { c = b - a; }
            TextBox6.Text = c.ToString();
            d = float.Parse(TextBox7.Text);
            TextBox8.Text = (d * c).ToString();

            Button2.Enabled = true;
            Class1 dd = new Class1();
            dd.Bus_License_no = TextBox3.Text;
            if (dd.QueryInbi()) { TextBox16.Text = dd.Total_Sit; TextBox17.Text = dd.Total_Stand_Capacity; }
            Class1 w = new Class1();
            w.Bus_License_no = TextBox3.Text;
            if (w.QueryInhave()) { TextBox25.Text = w.Owner_id; }
            int ch1, ch2;
            ch1 = int.Parse(TextBox14.Text);
            ch2 = int.Parse(TextBox15.Text);
            if (ch1 < ch2)
            {
                SqlConnection con11 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda11 = new SqlDataAdapter("select *from ticket  where stop_time='" + TextBox12.Text + TextBox13.Text + "' and Bus_License_no='" + TextBox3.Text + "' and Travel_date='" + TextBox24.Text + "' and (ss_n<='" + TextBox14.Text + "' or ss_n>='" + TextBox14.Text + "') and (es_n>='" + TextBox15.Text + "' or es_n<='" + TextBox15.Text + "' ) and Sit_no like'si%' and Start_location like'f%' and End_location like 'f%'-- and Sit_no='" + TextBox23.Text + "'", con11);
                DataTable dt11 = new DataTable();
                sda11.Fill(dt11);
                GridView4.DataSource = dt11;
                GridView4.DataBind();
                int sc, te;
                sc = int.Parse(GridView4.Rows.Count.ToString());
                te = int.Parse(TextBox16.Text);
                te = te - sc;
                TextBox19.Text = te.ToString();
                TextBox18.Text = (sc+1).ToString();
                SqlConnection con111 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda111 = new SqlDataAdapter("select *from ticket where stop_time='" + TextBox12.Text + TextBox13.Text + "' and Bus_License_no='" + TextBox3.Text + "' and Travel_date='" + TextBox24.Text + "' and (ss_n<='" + TextBox14.Text + "' or ss_n>='" + TextBox14.Text + "') and (es_n>='" + TextBox15.Text + "' or es_n<='" + TextBox15.Text + "') and Sit_no like'st%' and Start_location like'f%' and End_location like 'f%' --and Sit_no='" + TextBox23.Text + "'", con111);
                DataTable dt111 = new DataTable();
                sda111.Fill(dt111);
                GridView5.DataSource = dt111;
                GridView5.DataBind();
                int sc1, te1;
                sc1 = int.Parse(GridView5.Rows.Count.ToString());
                te1 = int.Parse(TextBox17.Text);
                te1 = te1 - sc1;
                TextBox20.Text = te1.ToString();
                TextBox22.Text = (sc1+1).ToString();

            }
            else
            {
                SqlConnection con11 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda11 = new SqlDataAdapter("select *from ticket where stop_time='" + TextBox12.Text + TextBox13.Text + "' and Bus_License_no='" + TextBox3.Text + "' and Travel_date='" + TextBox24.Text + "' and (ss_n<='" + TextBox14.Text + "' or ss_n>='" + TextBox14.Text + "') and (es_n>='" + TextBox15.Text + "' or es_n<='" + TextBox15.Text + "' ) and Sit_no like'si%' and Start_location like'l%' and End_location like 'l%'-- and Sit_no='" + TextBox23.Text + "'", con11);
                DataTable dt11 = new DataTable();
                sda11.Fill(dt11);
                GridView4.DataSource = dt11;
                GridView4.DataBind();
                int sc, te;
                sc = int.Parse(GridView4.Rows.Count.ToString());
                te = int.Parse(TextBox16.Text);
                te = te - sc;
                TextBox19.Text = te.ToString();
                TextBox18.Text = (sc+1).ToString();
                SqlConnection con111 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda111 = new SqlDataAdapter("select *from ticket where stop_time='" + TextBox12.Text + TextBox13.Text + "' and Bus_License_no='" + TextBox3.Text + "' and Travel_date='" + TextBox24.Text + "' and (ss_n<='" + TextBox14.Text + "' or ss_n>='" + TextBox14.Text + "') and (es_n>='" + TextBox15.Text + "' or es_n<='" + TextBox15.Text + "') and Sit_no like'st%' and Start_location like'l%' and End_location like 'l%' --and Sit_no='" + TextBox23.Text + "'", con111);
                DataTable dt111 = new DataTable();
                sda111.Fill(dt111);
                GridView5.DataSource = dt111;
                GridView5.DataBind();
                int sc1, te1;
                sc1 = int.Parse(GridView5.Rows.Count.ToString());
                te1 = int.Parse(TextBox17.Text);
                te1 = te1 - sc1;
                TextBox20.Text = te1.ToString();
                TextBox22.Text = (sc1+1).ToString();
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
           
            Response.Redirect("user.aspx");
        }

        protected void GridView7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            try
            {
                int rowid = (e.Item.ItemIndex);
                TextBox t = (TextBox)Repeater1.Items[rowid].FindControl("TextBox28") as TextBox;
                TextBox t1 = (TextBox)Repeater1.Items[rowid].FindControl("TextBox33") as TextBox;
                TextBox t2 = (TextBox)Repeater1.Items[rowid].FindControl("TextBox27") as TextBox;

                TextBox3.Text = t.Text;
                TextBox12.Text = t1.Text;
                TextBox13.Text = t2.Text;
                Class1 d1 = new Class1();
                d1.Bus_License_no = TextBox3.Text;
                if (d1.QueryInrate()) { TextBox7.Text = d1.s_no; }
                /***************************************/
                int m1, m2, m3 = 0, m4 = 11, m5 = 500;
                if (TextBox21.Text != "")
                {

                    m1 = int.Parse(DateTime.Now.ToString("MM"));
                    m2 = int.Parse(DateTime.Now.ToString("yyyy"));
                    m3 = int.Parse(System.DateTime.DaysInMonth(m2, m1).ToString());
                    m4 = int.Parse(TextBox21.Text);
                    m5 = int.Parse(DateTime.Now.ToString("dd"));
                }

                if (m4 <= m3 && m4 >= m5)
                {
                    TextBox24.Text = TextBox21.Text + DateTime.Now.ToString("-MMM-yyyy");
                }
                /*GridViewRow row = GridView3.SelectedRow;


                TextBox3.Text = row.Cells[1].Text;
                TextBox12.Text = row.Cells[6].Text;
                TextBox13.Text = row.Cells[7].Text;*/
                TextBox38.Text = TextBox12.Text + " " + TextBox13.Text;
                SqlConnection con114 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda114 = new SqlDataAdapter("select location,Stop_time,KM from time_schedule,stop_office where time_schedule.Bus_Stop_point=stop_office.Bus_Stop_point and Stop_time>'" + TextBox12.Text + "' and km='" + TextBox13.Text + "' and Location='" + TextBox2.Text + "' order by Stop_time", con114);
                DataTable dt114 = new DataTable();
                sda114.Fill(dt114);
                GridView6.DataSource = dt114;
                GridView6.DataBind();
                this.GridView6.SelectedIndex = 0;
                try { TextBox39.Text = this.GridView6.Rows[this.GridView6.SelectedIndex].Cells[1].Text + " " + this.GridView6.Rows[this.GridView6.SelectedIndex].Cells[2].Text; }
                catch
                {
                    if (TextBox13.Text == "AM")
                    {
                        SqlConnection con1145 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                        SqlDataAdapter sda1145 = new SqlDataAdapter("select location,Stop_time,KM from time_schedule,stop_office where time_schedule.Bus_Stop_point=stop_office.Bus_Stop_point and Stop_time<'" + TextBox12.Text + "' and km='pm' and Location='" + TextBox2.Text + "' order by Stop_time", con1145);
                        DataTable dt1145 = new DataTable();
                        sda1145.Fill(dt1145);
                        GridView6.DataSource = dt1145;
                        GridView6.DataBind();
                        this.GridView6.SelectedIndex = 0;
                        try { TextBox39.Text = this.GridView6.Rows[this.GridView6.SelectedIndex].Cells[1].Text + " " + this.GridView6.Rows[this.GridView6.SelectedIndex].Cells[2].Text; }
                        catch
                        {
                            if (TextBox13.Text == "PM")
                            {
                                SqlConnection con11451 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                                SqlDataAdapter sda11451 = new SqlDataAdapter("select location,Stop_time,KM from time_schedule,stop_office where time_schedule.Bus_Stop_point=stop_office.Bus_Stop_point and Stop_time>'" + TextBox12.Text + "' and km='am' and Location='" + TextBox2.Text + "' order by Stop_time", con11451);
                                DataTable dt11451 = new DataTable();
                                sda11451.Fill(dt11451);
                                GridView6.DataSource = dt11451;
                                GridView6.DataBind();
                                this.GridView6.SelectedIndex = 0;
                                try { TextBox39.Text = this.GridView6.Rows[this.GridView6.SelectedIndex].Cells[1].Text + " " + this.GridView6.Rows[this.GridView6.SelectedIndex].Cells[2].Text; }
                                catch
                                { TextBox39.Text = ""; msgbox("service not avalable only for this time"); Button2.Enabled = false; }
                            }
                        }
                    }
                }

                // Repeater4.DataSource = dt114;
                // Repeater4.DataBind();
                SqlConnection con114g = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda114g = new SqlDataAdapter("(select location,Stop_time as Time,time_schedule.KM as TT from b_has,time_schedule,stop_office,bus_information where b_has.Bus_Stop_point=time_schedule.Bus_Stop_point and time_schedule.Bus_License_no=bus_information.Bus_License_no and time_schedule.Bus_Stop_point=stop_office.Bus_Stop_point and Location='" + TextBox1.Text + "' and time_schedule.Bus_License_no='" + TextBox3.Text + "')union(select location,Stop_time as Time,time_schedule.KM as TT from b_has,time_schedule,stop_office,bus_information where b_has.Bus_Stop_point=time_schedule.Bus_Stop_point and time_schedule.Bus_License_no=bus_information.Bus_License_no and time_schedule.Bus_Stop_point=stop_office.Bus_Stop_point and Location='" + TextBox1.Text + "' and time_schedule.Bus_License_no='" + TextBox3.Text + "') order by time_schedule.KM", con114g);
                DataTable dt114g = new DataTable();
                sda114g.Fill(dt114g);
                GridView8.DataSource = dt114g;
                GridView8.DataBind();
                //Repeater3.DataSource = dt114g;
                // Repeater3.DataBind();


                SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda = new SqlDataAdapter("select km,b_has.s_no from b_has,stop_office where stop_office.Bus_Stop_point=b_has.Bus_Stop_point and Bus_License_no='" + TextBox3.Text + "' and Location='" + TextBox1.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                GridView2.DataSource = dt;
                GridView2.DataBind();
                this.GridView2.SelectedIndex = 0;

                TextBox4.Text = this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[0].Text;
                TextBox14.Text = this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[1].Text;
                SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1 = new SqlDataAdapter("select km,b_has.s_no from b_has,stop_office where stop_office.Bus_Stop_point=b_has.Bus_Stop_point and Bus_License_no='" + TextBox3.Text + "' and Location=N'" + TextBox2.Text + "'", con1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                GridView2.DataSource = dt1;
                GridView2.DataBind();
                this.GridView2.SelectedIndex = 0;

                TextBox5.Text = this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[0].Text;
                TextBox15.Text = this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[1].Text;
                float a, b, c, d;
                a = float.Parse(TextBox4.Text);
                b = float.Parse(TextBox5.Text);
                if (a > b) { c = a - b; } else { c = b - a; }
                TextBox6.Text = c.ToString();
                d = float.Parse(TextBox7.Text);
                TextBox8.Text = (d * c).ToString();

                Button2.Enabled = true;
                Class1 dd = new Class1();
                dd.Bus_License_no = TextBox3.Text;
                if (dd.QueryInbi()) { TextBox16.Text = dd.Total_Sit; TextBox17.Text = dd.Total_Stand_Capacity; }
                Class1 w = new Class1();
                w.Bus_License_no = TextBox3.Text;
                if (w.QueryInhave()) { TextBox25.Text = w.Owner_id; }
                int ch1, ch2;
                ch1 = int.Parse(TextBox14.Text);
                ch2 = int.Parse(TextBox15.Text);
                if (ch1 < ch2)
                {
                    SqlConnection con11 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                    SqlDataAdapter sda11 = new SqlDataAdapter("select *from ticket where stop_time='" + TextBox12.Text + TextBox13.Text + "' and Bus_License_no='" + TextBox3.Text + "' and Travel_date='" + TextBox24.Text + "' and (ss_n<='" + TextBox14.Text + "' or ss_n>='" + TextBox14.Text + "') and (es_n>='" + TextBox15.Text + "' or es_n<='" + TextBox15.Text + "' ) and Sit_no like'si%' and Start_location like'f%' and End_location like 'f%'-- and Sit_no='" + TextBox23.Text + "'", con11);
                    DataTable dt11 = new DataTable();
                    sda11.Fill(dt11);
                    GridView4.DataSource = dt11;
                    GridView4.DataBind();
                    int sc, te;
                    sc = int.Parse(GridView4.Rows.Count.ToString());
                    te = int.Parse(TextBox16.Text);
                    te = te - sc;
                    TextBox19.Text = te.ToString();
                    TextBox18.Text = (sc + 1).ToString();
                    SqlConnection con111 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                    SqlDataAdapter sda111 = new SqlDataAdapter("select *from ticket where stop_time='" + TextBox12.Text + TextBox13.Text + "' and Bus_License_no='" + TextBox3.Text + "' and Travel_date='" + TextBox24.Text + "' and (ss_n<='" + TextBox14.Text + "' or ss_n>='" + TextBox14.Text + "') and (es_n>='" + TextBox15.Text + "' or es_n<='" + TextBox15.Text + "') and Sit_no like'st%' and Start_location like'f%' and End_location like 'f%' --and Sit_no='" + TextBox23.Text + "'", con111);
                    DataTable dt111 = new DataTable();
                    sda111.Fill(dt111);
                    GridView5.DataSource = dt111;
                    GridView5.DataBind();
                    int sc1, te1;
                    sc1 = int.Parse(GridView5.Rows.Count.ToString());
                    te1 = int.Parse(TextBox17.Text);
                    te1 = te1 - sc1;
                    TextBox20.Text = te1.ToString();
                    TextBox22.Text = (sc1 + 1).ToString();

                }
                else
                {
                    SqlConnection con11 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                    SqlDataAdapter sda11 = new SqlDataAdapter("select *from ticket where stop_time='" + TextBox12.Text + TextBox13.Text + "' and Bus_License_no='" + TextBox3.Text + "' and Travel_date='" + TextBox24.Text + "' and (ss_n<='" + TextBox14.Text + "' or ss_n>='" + TextBox14.Text + "') and (es_n>='" + TextBox15.Text + "' or es_n<='" + TextBox15.Text + "' ) and Sit_no like'si%' and Start_location like'l%' and End_location like 'l%'-- and Sit_no='" + TextBox23.Text + "'", con11);
                    DataTable dt11 = new DataTable();
                    sda11.Fill(dt11);
                    GridView4.DataSource = dt11;
                    GridView4.DataBind();
                    int sc, te;
                    sc = int.Parse(GridView4.Rows.Count.ToString());
                    te = int.Parse(TextBox16.Text);
                    te = te - sc;
                    TextBox19.Text = te.ToString();
                    TextBox18.Text = (sc + 1).ToString();
                    SqlConnection con111 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                    SqlDataAdapter sda111 = new SqlDataAdapter("select *from ticket where stop_time='" + TextBox12.Text + TextBox13.Text + "' and Bus_License_no='" + TextBox3.Text + "' and Travel_date='" + TextBox24.Text + "' and (ss_n<='" + TextBox14.Text + "' or ss_n>='" + TextBox14.Text + "') and (es_n>='" + TextBox15.Text + "' or es_n<='" + TextBox15.Text + "') and Sit_no like'st%' and Start_location like'l%' and End_location like 'l%' --and Sit_no='" + TextBox23.Text + "'", con111);
                    DataTable dt111 = new DataTable();
                    sda111.Fill(dt111);
                    GridView5.DataSource = dt111;
                    GridView5.DataBind();
                    int sc1, te1;
                    sc1 = int.Parse(GridView5.Rows.Count.ToString());
                    te1 = int.Parse(TextBox17.Text);
                    te1 = te1 - sc1;
                    TextBox20.Text = te1.ToString();
                    TextBox22.Text = (sc1 + 1).ToString();
                }
                Label17.Visible = true; Label18.Visible = true; GridView6.Visible = false; TextBox38.Visible = true; TextBox39.Visible = true;
                int jkl;
                jkl = int.Parse(GridView6.Rows.Count.ToString());
                if (jkl == 0) { TextBox39.Text = "No Service"; TextBox38.Text = "No Service"; msgbox("service not avalable only for this time"); Button2.Enabled = false; }
            }
            catch { msgbox("This bus do not do "+TextBox2.Text); }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Class1 d = new Class1();
            d.SL = TextBox34.Text;
            d.Pessenger_id = TextBox9.Text;
            if (d.QueryInx()) { TextBox36.Text = d.s_no; TextBox35.Text = d.Sit_no; Session["bu"] = d.SL; Button6.Enabled = true; } 
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Button6.Enabled = true;
            Response.Redirect("location.aspx");
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
               
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("ticket.aspx");
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