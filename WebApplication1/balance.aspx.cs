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
    public partial class balance : System.Web.UI.Page
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
                TextBox7.Text = Session["t"].ToString();
                if (TextBox1.Text.StartsWith("w") || TextBox1.Text.StartsWith("W")) { Button1.Visible = false; Button5.Visible = true; }
                Class1 u = new Class1();
                u.Owner_id = TextBox1.Text;
                if (u.QueryInbala())
                {
                    TextBox2.Text = u.Taka;


                }
                SqlConnection con11 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda11 = new SqlDataAdapter("select Transfer_To,Taka,Date from history where ID='" + TextBox1.Text + "' order by SL desc", con11);
                DataTable dt11 = new DataTable();
                sda11.Fill(dt11);
                Repeater2.DataSource = dt11;
                Repeater2.DataBind();
                SqlConnection con111 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda111 = new SqlDataAdapter("select ID as Transfer_By,Taka,Date  from history where Transfer_To='" + TextBox1.Text + "' order by SL desc", con111);
                DataTable dt111 = new DataTable();
                sda111.Fill(dt111);
                Repeater1.DataSource = dt111;
                Repeater1.DataBind();
            }
            else { Response.Redirect("home.aspx"); }
         
        }
        private void msgbox(string msg) { ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "CallMyFunction", "alert('" + msg + "')", true); }
        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection convbb = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sdavbb = new SqlDataAdapter("update login_table set e_h='1' where login_id='" + Session["ID"].ToString() + "'", convbb);
            DataTable dtvbb = new DataTable();
            sdavbb.Fill(dtvbb);
            float axc, bxc;
                    axc = float.Parse(TextBox2.Text);
                    bxc = float.Parse(TextBox4.Text);
                    if (TextBox7.Text == "Administrator Head") { axc = axc + bxc; }
                    if (axc >= bxc)
                    { 
            string w1 = TextBox1.Text.ToLower(), w2 = TextBox3.Text.ToLower();
            if (TextBox7.Text == "Administrator Head") { w1 = "Administrator Head"; w2 = TextBox3.Text.ToLower(); }
            if (w1 != w2)
            {
                Class1 ss = new Class1();
                ss.login_id = Session["ID"].ToString();
                if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
                if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }

                float xxx = 0;
                try { xxx = float.Parse(TextBox4.Text); }
                catch { msgbox("insert ammount"); }

                if (xxx > 0)
                {
                    Class1 dr = new Class1();
                    dr.login_id = TextBox1.Text;
                    dr.log_password = TextBox6.Text;
                    if (dr.QueryInlogin1())
                    {/*
                if (TextBox7.Text == "Administrator Head")
                {
                    float a, b, c, d1;
                    a = float.Parse(TextBox2.Text);
                    b = float.Parse(TextBox4.Text);
                    if (a >= 0)
                    {

                        c = a;
                        TextBox2.Text = c.ToString();
                        Class1 d = new Class1();
                        d.Owner_id = TextBox3.Text;
                        d.Taka = TextBox4.Text;
                        if (d.DataSaveInbala()) { } else { };
                        Class1 u = new Class1();
                        u.Owner_id = TextBox3.Text;
                        if (u.QueryInbala())
                        {
                            TextBox5.Text = u.Taka;


                        }
                        if (TextBox5.Text != "")
                        {
                            d1 = float.Parse(TextBox5.Text);
                            d1 = d1 + b;


                            SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                            SqlDataAdapter sda = new SqlDataAdapter("update balance set Taka='" + c.ToString() + "' where Owner_id='" + TextBox1.Text + "' update balance set Taka='" + d1.ToString() + "' where Owner_id='" + TextBox3.Text + "'", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            Class1 uu = new Class1();
                            uu.Owner_id = TextBox1.Text;
                            if (uu.QueryInbala())
                            {
                                TextBox2.Text = uu.Taka;


                            }
                            Class1 h = new Class1();
                            h.ID = TextBox1.Text;
                            h.Transfer_To = TextBox3.Text;
                            h.Taka = TextBox4.Text;
                            h.Date = DateTime.Now.ToString("dd-MMM-yyy");
                            if (h.DataSaveInhis()) { }
                            TextBox5.Text = "";
                            msgbox("Succesfull");
                        }
                        else { msgbox("Receiver ID not found"); }

                    }
                    else {  }
                }
                else
                {
                    float a, b, c, d1;
                    a = float.Parse(TextBox2.Text);
                    b = float.Parse(TextBox4.Text);
                    if (a >= b)
                    {

                        c = a - b;
                        TextBox2.Text = c.ToString();
                        Class1 d = new Class1();
                        d.Owner_id = TextBox3.Text;
                        d.Taka = TextBox4.Text;
                        if (d.DataSaveInbala()) { } else { };
                        Class1 u = new Class1();
                        u.Owner_id = TextBox3.Text;
                        if (u.QueryInbala())
                        {
                            TextBox5.Text = u.Taka;


                        }

                        if (TextBox5.Text != "") { 
                            d1 = float.Parse(TextBox5.Text);
                            d1 = d1 + b;
                      
                       
                      

                        SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                        SqlDataAdapter sda = new SqlDataAdapter("update balance set Taka='" + c.ToString() + "' where Owner_id='" + TextBox1.Text + "' update balance set Taka='" + d1.ToString() + "' where Owner_id='" + TextBox3.Text + "'", con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        Class1 uu = new Class1();
                        uu.Owner_id = TextBox1.Text;
                        if (uu.QueryInbala())
                        {
                            TextBox2.Text = uu.Taka;


                        }
                        Class1 h = new Class1();
                        h.ID=TextBox1.Text;
                        h.Transfer_To=TextBox3.Text;
                        h.Taka=TextBox4.Text;
                        h.Date=DateTime.Now.ToString("dd-MMM-yyy");
                        if(h.DataSaveInhis()){}
                        TextBox5.Text = "";
                        msgbox("Succesfull");
                        }
                        else { msgbox("Receiver ID not found"); }

                    }
                    else { msgbox("No balance"); }
                }
               
              
          */
                        //Timer1.Enabled = true;

                        Session["tm"] = dr.Bus_Name;
                        if (Session["tm"].ToString() == "0") { Timer1.Enabled = true; }
                        else
                        {
                            Timer2.Enabled = true;
                            Label9.Visible = true;
                            Button1.Visible = false;
                        }

                    }
                    else { msgbox("Password do not match"); }
                    SqlConnection con11 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                    SqlDataAdapter sda11 = new SqlDataAdapter("select Transfer_To,Taka,Date from history where ID='" + TextBox1.Text + "' order by SL desc", con11);
                    DataTable dt11 = new DataTable();
                    sda11.Fill(dt11);
                    Repeater2.DataSource = dt11;
                    Repeater2.DataBind();
                    SqlConnection con111 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                    SqlDataAdapter sda111 = new SqlDataAdapter("select ID as Transfer_By,Taka,Date  from history where Transfer_To='" + TextBox1.Text + "' order by SL desc", con111);
                    DataTable dt111 = new DataTable();
                    sda111.Fill(dt111);
                    Repeater1.DataSource = dt111;
                    Repeater1.DataBind();
                }
                else { msgbox("ammount should greater then zero"); }

            }
            else { msgbox("not possible"); }
                    }
                    else { msgbox("No balance"); } UpdatePanel8.Update();
                    Class1 u3 = new Class1();
                    u3.Owner_id = TextBox1.Text;
                    if (u3.QueryInbala())
                    {
                        TextBox2.Text = u3.Taka;


                    }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection convbb = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sdavbb = new SqlDataAdapter("update login_table set e_h='1' where login_id='" + Session["ID"].ToString() + "'", convbb);
            DataTable dtvbb = new DataTable();
            sdavbb.Fill(dtvbb);
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
              
            Class1 m = new Class1();
            m.ID = TextBox1.Text;
            m.Date = TextBox10.Text;
            if (m.QueryInhist()) { TextBox8.Text = m.Taka; } 
            Class1 m1 = new Class1();
            m1.Transfer_To = TextBox1.Text;
            m1.Date = TextBox10.Text;
            if (m1.QueryInhist1()) { TextBox9.Text = m1.Taka; }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection convbb = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sdavbb = new SqlDataAdapter("update login_table set e_h='1' where login_id='" + Session["ID"].ToString() + "'", convbb);
            DataTable dtvbb = new DataTable();
            sdavbb.Fill(dtvbb);
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
              
            Response.Redirect("balance.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            SqlConnection convbb = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sdavbb = new SqlDataAdapter("update login_table set e_h='1' where login_id='" + Session["ID"].ToString() + "'", convbb);
            DataTable dtvbb = new DataTable();
            sdavbb.Fill(dtvbb);
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
              
            Response.Redirect("user.aspx");

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            SqlConnection convbb = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sdavbb = new SqlDataAdapter("update login_table set e_h='1' where login_id='" + Session["ID"].ToString() + "'", convbb);
            DataTable dtvbb = new DataTable();
            sdavbb.Fill(dtvbb);
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
              
            float xxx = 0;
            try { xxx = float.Parse(TextBox4.Text); }
            catch { msgbox("insert ammount"); }
            if (xxx > 0)
            {
                if (TextBox3.Text.StartsWith("a") || TextBox3.Text.StartsWith("A"))
                {
                    Class1 dr = new Class1();
                    dr.login_id = TextBox1.Text;
                    dr.log_password = TextBox6.Text;
                    if (dr.QueryInlogin1())
                    {
                        if (TextBox7.Text == "Administrator Head")
                        {
                            float a, b, c, d1;
                            a = float.Parse(TextBox2.Text);
                            b = float.Parse(TextBox4.Text);
                            if (a >= 0)
                            {

                                c = a;
                                TextBox2.Text = c.ToString();
                             
                                Class1 u = new Class1();
                                u.Owner_id = TextBox3.Text;
                                if (u.QueryInbala())
                                {
                                    TextBox5.Text = u.Taka;


                                }
                                if (TextBox5.Text != "")
                                {
                                    d1 = float.Parse(TextBox5.Text);
                                    d1 = d1 + b;


                                    SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                                    SqlDataAdapter sda = new SqlDataAdapter("insert into balance values ('" + TextBox3.Text + "','" + TextBox4.Text + "')--update balance set Taka='" + c.ToString() + "' where Owner_id='" + TextBox1.Text + "' update balance set Taka='" + d1.ToString() + "' where Owner_id='" + TextBox3.Text + "'", con);
                                    DataTable dt = new DataTable();
                                    sda.Fill(dt);
                                    Class1 uu = new Class1();
                                    uu.Owner_id = TextBox1.Text;
                                    if (uu.QueryInbala())
                                    {
                                        TextBox2.Text = uu.Taka;


                                    }
                                    Class1 h = new Class1();
                                    h.ID = TextBox1.Text;
                                    h.Transfer_To = TextBox3.Text;
                                    h.Taka = TextBox4.Text;
                                    h.Date = DateTime.Now.ToString("dd-MMM-yyy");
                                    if (h.DataSaveInhis()) { }
                                    TextBox5.Text = "";
                                    msgbox("Succesfull");
                                }
                                else { msgbox("Receiver ID Not found"); }

                            }
                            else { }
                        }
                        else
                        {
                            float a, b, c, d1;
                            a = float.Parse(TextBox2.Text);
                            b = float.Parse(TextBox4.Text);
                            if (a >= b)
                            {

                                c = a - b;
                                TextBox2.Text = c.ToString();
                              
                                Class1 u = new Class1();
                                u.Owner_id = TextBox3.Text;
                                if (u.QueryInbala())
                                {
                                    TextBox5.Text = u.Taka;


                                }

                                if (TextBox5.Text != "")
                                {
                                    d1 = float.Parse(TextBox5.Text);
                                    d1 = d1 + b;




                                    SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                                    SqlDataAdapter sda = new SqlDataAdapter("insert into balance values ('" + TextBox1.Text + "','-" + TextBox4.Text + "') insert into balance values ('" + TextBox3.Text + "','" + TextBox4.Text + "')--update balance set Taka='" + c.ToString() + "' where Owner_id='" + TextBox1.Text + "' update balance set Taka='" + d1.ToString() + "' where Owner_id='" + TextBox3.Text + "'", con);
                                    DataTable dt = new DataTable();
                                    sda.Fill(dt);
                                    Class1 uu = new Class1();
                                    uu.Owner_id = TextBox1.Text;
                                    if (uu.QueryInbala())
                                    {
                                        TextBox2.Text = uu.Taka;


                                    }
                                    Class1 h = new Class1();
                                    h.ID = TextBox1.Text;
                                    h.Transfer_To = TextBox3.Text;
                                    h.Taka = TextBox4.Text;
                                    h.Date = DateTime.Now.ToString("dd-MMM-yyy");
                                    if (h.DataSaveInhis()) { }
                                    TextBox5.Text = "";
                                    msgbox("Succesfull");
                                }
                                else { msgbox("Receiver ID not found"); }

                            }
                            else { msgbox("No balance"); }
                        }



                    }
                    else { msgbox("Password do not match"); }
                    SqlConnection con11 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                    SqlDataAdapter sda11 = new SqlDataAdapter("select Transfer_To,Taka,Date from history where ID='" + TextBox1.Text + "' order by SL desc", con11);
                    DataTable dt11 = new DataTable();
                    sda11.Fill(dt11);
                    Repeater2.DataSource = dt11;
                    Repeater2.DataBind();
                    SqlConnection con111 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                    SqlDataAdapter sda111 = new SqlDataAdapter("select ID as Transfer_By,Taka,Date  from history where Transfer_To='" + TextBox1.Text + "' order by SL desc", con111);
                    DataTable dt111 = new DataTable();
                    sda111.Fill(dt111);
                    Repeater1.DataSource = dt111;
                    Repeater1.DataBind();
                   
                }
                else { msgbox("Administrator Only"); }
            }
            else { msgbox("ammount should greater than zero"); } UpdatePanel8.Update(); Class1 u3 = new Class1();
            u3.Owner_id = TextBox1.Text;
            if (u3.QueryInbala())
            {
                TextBox2.Text = u3.Taka;


            } TextBox3.Text = ""; TextBox4.Text = "";
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            string w1=TextBox1.Text.ToLower(),w2=TextBox3.Text.ToLower();
            if (TextBox7.Text == "Administrator Head") { w1 = "Administrator Head"; w2 = TextBox3.Text.ToLower(); }
         if (w1 != w2)
         {
             
                Class1 ss = new Class1();
                ss.login_id = Session["ID"].ToString();
                if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
                if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
                if (TextBox7.Text == "Administrator Head")
                {
                    float a, b, c, d1;
                    a = float.Parse(TextBox2.Text);
                    b = float.Parse(TextBox4.Text);
                    if (a >= 0)
                    {

                        c = a;
                        TextBox2.Text = c.ToString();
                      
                        Class1 u = new Class1();
                        u.Owner_id = TextBox3.Text;
                        if (u.QueryInbala())
                        {
                            TextBox5.Text = u.Taka;


                        }
                        if (TextBox5.Text != "")
                        {
                            d1 = float.Parse(TextBox5.Text);
                            d1 = d1 + b;


                            SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                            SqlDataAdapter sda = new SqlDataAdapter(" insert into balance values ('" + TextBox3.Text + "','" + TextBox4.Text + "')", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            Class1 uu = new Class1();
                            uu.Owner_id = TextBox1.Text;
                            if (uu.QueryInbala())
                            {
                                TextBox2.Text = uu.Taka;


                            }
                            Class1 h = new Class1();
                            h.ID = TextBox1.Text;
                            h.Transfer_To = TextBox3.Text;
                            h.Taka = TextBox4.Text;
                            h.Date = DateTime.Now.ToString("dd-MMM-yyy");
                            if (h.DataSaveInhis()) { }
                            TextBox5.Text = "";
                            msgbox("Succesfull");
                        }
                        else { msgbox("Receiver ID not found"); }

                    }
                    else { }
                }
                else
                {
                    float a, b, c, d1;
                    a = float.Parse(TextBox2.Text);
                    b = float.Parse(TextBox4.Text);
                    if (a >= b)
                    {

                        c = a - b;
                        TextBox2.Text = c.ToString();
                      
                        Class1 u = new Class1();
                        u.Owner_id = TextBox3.Text;
                        if (u.QueryInbala())
                        {
                            TextBox5.Text = u.Taka;


                        }

                        if (TextBox5.Text != "")
                        {
                            d1 = float.Parse(TextBox5.Text);
                            d1 = d1 + b;




                            SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                            SqlDataAdapter sda = new SqlDataAdapter("insert into balance values ('" + TextBox1.Text + "','-" + TextBox4.Text + "') insert into balance values ('" + TextBox3.Text + "','" + TextBox4.Text + "')--update balance set Taka='" + c.ToString() + "' where Owner_id='" + TextBox1.Text + "' update balance set Taka='" + d1.ToString() + "' where Owner_id='" + TextBox3.Text + "'", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            Class1 uu = new Class1();
                            uu.Owner_id = TextBox1.Text;
                            if (uu.QueryInbala())
                            {
                                TextBox2.Text = uu.Taka;


                            }
                            Class1 h = new Class1();
                            h.ID = TextBox1.Text;
                            h.Transfer_To = TextBox3.Text;
                            h.Taka = TextBox4.Text;
                            h.Date = DateTime.Now.ToString("dd-MMM-yyy");
                            if (h.DataSaveInhis()) { }
                            TextBox5.Text = "";
                            msgbox("Succesfull");
                        }
                        else { msgbox("Receiver ID not found"); }

                    }
                    else { msgbox("No balance"); }
                } Timer1.Enabled = false; Timer2.Enabled = false; Label9.Visible = false;
                Button1.Visible = true;
            }
         else
         {
             msgbox("not possible "); Timer1.Enabled = false; Timer2.Enabled = false; Label9.Visible = false;
             Button1.Visible = true;
         }
         SqlConnection con11 = new SqlConnection(Properties.Settings.Default._ConnectionString);
         SqlDataAdapter sda11 = new SqlDataAdapter("select Transfer_To,Taka,Date from history where ID='" + TextBox1.Text + "' order by SL desc", con11);
         DataTable dt11 = new DataTable();
         sda11.Fill(dt11);
         Repeater2.DataSource = dt11;
         Repeater2.DataBind();
         SqlConnection con111 = new SqlConnection(Properties.Settings.Default._ConnectionString);
         SqlDataAdapter sda111 = new SqlDataAdapter("select ID as Transfer_By,Taka,Date  from history where Transfer_To='" + TextBox1.Text + "' order by SL desc", con111);
         DataTable dt111 = new DataTable();
         sda111.Fill(dt111);
         Repeater1.DataSource = dt111;
         Repeater1.DataBind();
         Class1 u3 = new Class1();
         u3.Owner_id = TextBox1.Text;
         if (u3.QueryInbala())
         {
             TextBox2.Text = u3.Taka;


         } TextBox3.Text = ""; TextBox4.Text = "";
        }

        protected void Timer2_Tick(object sender, EventArgs e)
        {
            int r = int.Parse(Label9.Text);
            r = r - 1;
            Label9.Text = r.ToString();
            if (r == 0) { Timer2.Enabled = false; Timer1.Enabled = true; Label9.Text = "10"; }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            SqlConnection convbb = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sdavbb = new SqlDataAdapter("update login_table set e_h='1' where login_id='" + Session["ID"].ToString() + "'", convbb);
            DataTable dtvbb = new DataTable();
            sdavbb.Fill(dtvbb);
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
            Class1 dr = new Class1();
            dr.login_id = TextBox1.Text;
            dr.log_password = TextBox6.Text;
            if (dr.QueryInlogin1())
            {

                Timer3.Enabled = true;
            }
            else { msgbox("password not match"); } UpdatePanel8.Update();
        }

        protected void Timer3_Tick(object sender, EventArgs e)
        {
            Button1.Visible = false;
            Label9.Visible = true;

            int r = int.Parse(Label9.Text);
            r = r - 1;
            Label9.Text = r.ToString();
            if (r == 0)
            {
                Button1.Visible = true;
                Label9.Visible = false;
                Timer3.Enabled = false;  Label9.Text = "10";
                SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda = new SqlDataAdapter("update login_table set t='0' where login_id='"+Session["ID"].ToString()+"'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                msgbox("sucessfull");
            } Class1 u3 = new Class1();
            u3.Owner_id = TextBox1.Text;
            if (u3.QueryInbala())
            {
                TextBox2.Text = u3.Taka;


            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            SqlConnection convbb = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sdavbb = new SqlDataAdapter("update login_table set e_h='1' where login_id='" + Session["ID"].ToString() + "'", convbb);
            DataTable dtvbb = new DataTable();
            sdavbb.Fill(dtvbb);
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
              
            SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda = new SqlDataAdapter("update login_table set t='1' where login_id='" + Session["ID"].ToString() + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            msgbox("sucessfull"); UpdatePanel8.Update();
        }

        protected void Timer4_Tick(object sender, EventArgs e)
        {
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
                
        }

        protected void Timer4_Tick1(object sender, EventArgs e)
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
}