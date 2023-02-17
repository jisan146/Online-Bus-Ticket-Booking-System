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
    public partial class Bus_stop : System.Web.UI.Page
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
            SqlConnection con11 = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda11 = new SqlDataAdapter("Select *from b_has order by s_no", con11);
            DataTable dt11 = new DataTable();
            sda11.Fill(dt11);
            Repeater2.DataSource = dt11;
            Repeater2.DataBind();
            Button1.Visible = false; Button9.Visible = false; Button17.Visible = false; Button18.Visible = false; Button19.Visible = false;
            Button2.Visible = false;
            Button6.Visible = false;
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;
            UpdatePanel12.Visible = false;
            UpdatePanel13.Visible = false;

            if (Session["ID"] != null)
            {
                Button1.Visible = true; Button9.Visible = true; Button17.Visible = true; Button18.Visible = true; Button19.Visible = true;
                UpdatePanel12.Visible = true;
                UpdatePanel13.Visible = true;
                SqlConnection con1w = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1w = new SqlDataAdapter("select select_.Bus_Stop_point,Location,Road_no,Road_name,l1,l2,l3,l4, Stuff_id as Approved_by,Date from select_ ,stop_office where stop_office.Bus_Stop_point=select_.Bus_Stop_point", con1w);
                DataTable dt1w = new DataTable();
                sda1w.Fill(dt1w);
                Repeater1.DataSource = dt1w;
                Repeater1.DataBind();
                Panel3.Visible = true;
                Button9.Enabled = true;
                Class1 d = new Class1();
                if (d.QueryInstop()) { TextBox1.Text = d.s_no; }
                TextBox6.Text = Session["ID"].ToString();
                TextBox7.Text = Session["t"].ToString();
                Button1.Enabled = true;
                if (TextBox1.Text == "") { TextBox1.Text = "0"; }
                int a;
                a = int.Parse(TextBox1.Text);
                a = a + 1;
                TextBox2.Text = a.ToString();
                if (TextBox7.Text == "Gov.Stuff")
                {
                    Label15.Visible = true;
                    Label35.Visible = true;
                    Label37.Visible = true;
                    Panel1.Visible = true;
                    Panel2.Visible = true;
                    Panel3.Visible = true;
                    Panel4.Visible = true;
                    Panel5.Visible = true;
                    Button2.Visible = true;
                    Button3.Enabled = true;
                    Button6.Visible = true;
                   Panel6.Visible = true;
                    //
                  /*  Label38.Visible = true;
                    Label39.Visible = true;
                    Label40.Visible = true;
                    Label41.Visible = true;
                    Label42.Visible = true;
                    TextBox33.Visible = true;
                    TextBox34.Visible = true;
                    TextBox35.Visible = true;
                    TextBox36.Visible = true;
                    TextBox37.Visible = true;*/
                    //
                    
                   // Button4.Enabled = true;
                    Button6.Enabled = true;
                    SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                    SqlDataAdapter sda = new SqlDataAdapter("select Bus_Stop_point,Location,Road_no,Road_name,login_id as Request_id from stop_office where Approved='' and Bus_Stop_point!=''", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    Repeater3.DataSource = dt;
                    Repeater3.DataBind();
                    SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                    SqlDataAdapter sda1 = new SqlDataAdapter("select select_.Bus_Stop_point,Location,Road_no,Road_name,l1,l2,l3,l4, Stuff_id as Approved_by,Date from select_ ,stop_office where stop_office.Bus_Stop_point=select_.Bus_Stop_point", con1);
                    DataTable dt1 = new DataTable();
                    sda1.Fill(dt1);
                    Repeater1.DataSource = dt1;
                    Repeater1.DataBind();
                    
                                 
                }

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
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
              
            SqlConnection cons = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sdas = new SqlDataAdapter("select *from stop_office where location='" + TextBox3.Text + "'", cons);
            DataTable dts = new DataTable();
            sdas.Fill(dts);
            GridView1.DataSource = dts;
            GridView1.DataBind();
            TextBox17.Text = (GridView1.Rows.Count.ToString());
            if (TextBox17.Text != "0") { msgbox("Change location name"); }
            if (TextBox3.Text != "" && TextBox4.Text != "" && TextBox5.Text != "" && TextBox6.Text != ""&&TextBox17.Text=="0")
            {
                
                Class1 d = new Class1();
                d.Bus_Stop_point = TextBox2.Text;
                d.Location = TextBox3.Text;
                d.Road_no = TextBox4.Text;
                d.Road_name = TextBox5.Text;
                d.login_id = TextBox6.Text;
                d.Approved = "";
                if (d.DataSaveInbs()) { msgbox("sucessfull"); TextBox3.Text = ""; TextBox4.Text = ""; TextBox5.Text = ""; } else { msgbox("fail"); }
            }
            else { msgbox("Complete all filed"); } TextBox17.Text = "";
           
          // if (TextBox7.Text == "Gov.Stuff") { Response.Redirect("Bus_stop.aspx"); }
            SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda = new SqlDataAdapter("select Bus_Stop_point,Location,Road_no,Road_name,login_id as Request_id from stop_office where Approved='' and Bus_Stop_point!=''", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Repeater3.DataSource = dt;
            Repeater3.DataBind();
            UpdatePanel3.Update();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
              
            SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda = new SqlDataAdapter("delete from stop_office where approved=''", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Response.Redirect("Bus_stop.aspx");
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TextBox8.Text != "")
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda = new SqlDataAdapter("select Bus_Stop_point,Location,Road_no,Road_name,login_id as Request_id from stop_office where Approved='' and Bus_Stop_point!='' and login_id='" + TextBox8.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Repeater3.DataSource = dt;
                Repeater3.DataBind();
                SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1 = new SqlDataAdapter("select Bus_Stop_point,approved,Location,Road_no,Road_name,l1,l2,l3,l4 from stop_office where  Bus_Stop_point!='' and login_id='" + TextBox8.Text + "'", con1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();



               // GridViewRow row = GridView2.SelectedRow;
                //TextBox10.Text = row.Cells[1].Text;
            }
            else { Button3.Enabled = false; }

             
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
              
            Class1 dd = new Class1();
            dd.Bus_License_no = TextBox9.Text;
            dd.Bus_Stop_point = TextBox10.Text;
            if (dd.QueryInbhas())
            {
               
                msgbox("Already insert"); 
                
            }
            else
            {
                Class1 d = new Class1();
                d.Stuff_id = TextBox6.Text;
                d.Bus_License_no = TextBox9.Text;
                d.Bus_Stop_point = TextBox10.Text;
                d.s_no = TextBox11.Text;
                d.KM = TextBox12.Text;
                if (d.DataSaveInbhas()) { msgbox("Save"); TextBox10.Text = ""; } else { TextBox10.Text = ""; msgbox("fail"); }
            }
           
            SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda = new SqlDataAdapter("select Bus_Stop_point,Location,Road_no,Road_name,login_id as Request_id from stop_office where Approved='' and Bus_Stop_point!='' and login_id='" + TextBox8.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Repeater3.DataSource = dt;
            Repeater3.DataBind();
           
            TextBox14.Text = TextBox9.Text;
            SqlConnection con11 = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda11 = new SqlDataAdapter("Select *from b_has where bus_license_no='" + TextBox14.Text + "' order by s_no", con11);
            DataTable dt11 = new DataTable();
            sda11.Fill(dt11);
            Repeater2.DataSource = dt11;
            Repeater2.DataBind();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (TextBox8.Text != "")
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda = new SqlDataAdapter("select Bus_Stop_point,Location,Road_no,Road_name,login_id as Request_id from stop_office where Approved='' and Bus_Stop_point!='' and login_id='" + TextBox8.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Repeater3.DataSource = dt;
                Repeater3.DataBind();
                SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1 = new SqlDataAdapter("select Bus_Stop_point,approved,Location,Road_no,Road_name,l1,l2,l3,l4 from stop_office where  Bus_Stop_point!='' and login_id='" + TextBox8.Text + "'", con1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                Repeater1.DataSource = dt1;
                Repeater1.DataBind(); Button3.Enabled = true;
            }
            else { Button3.Enabled = false; }
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
            SqlDataAdapter sda = new SqlDataAdapter("select Bus_Stop_point,Location,Road_no,Road_name,login_id as Request_id from stop_office where Approved='' and Bus_Stop_point!=''", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Repeater3.DataSource = dt;
            Repeater3.DataBind();
            SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda1 = new SqlDataAdapter("select select_.Bus_Stop_point,Location,Road_no,Road_name,l1,l2,l3,l4, Stuff_id as Approved_by,Date from select_ ,stop_office where stop_office.Bus_Stop_point=select_.Bus_Stop_point", con1);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            Repeater1.DataSource = dt1;
            Repeater1.DataBind();
            UpdatePanel3.Update();
        }

        protected void Button9_Click(object sender, EventArgs e)
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

        protected void Button12_Click(object sender, EventArgs e)
        {
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
              
            SqlConnection con11 = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda11 = new SqlDataAdapter("Select *from b_has where bus_license_no='"+TextBox14.Text+"' order by s_no", con11);
            DataTable dt11 = new DataTable();
            sda11.Fill(dt11);
            Repeater2.DataSource = dt11;
            Repeater2.DataBind();
            UpdatePanel7.Update();
        }

        protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
        {
             // GridViewRow row = GridView3.SelectedRow;
               /* TextBox14.Text = row.Cells[2].Text;
                TextBox15.Text = row.Cells[3].Text;
                TextBox16.Text = row.Cells[4].Text;
                TextBox17.Text = row.Cells[5].Text;
                TextBox18.Text = row.Cells[1].Text;*/
               
          

        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
              
            if (TextBox18.Text == TextBox6.Text)
            {
                SqlConnection con11 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda11 = new SqlDataAdapter("update b_has set s_no='" + TextBox16.Text + "' , km='" + TextBox17.Text + "' where Bus_License_no='" + TextBox14.Text + "' and Bus_Stop_point='" + TextBox15.Text + "' ", con11);
                DataTable dt11 = new DataTable();
                sda11.Fill(dt11);
                SqlConnection con111 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda111 = new SqlDataAdapter("Select *from b_has where bus_license_no='" + TextBox14.Text + "' order by s_no", con111);
                DataTable dt111 = new DataTable();
                sda111.Fill(dt111);
                Repeater2.DataSource = dt111;
                Repeater2.DataBind();
            }
            else { msgbox("no permission"); }
            UpdatePanel7.Update();
        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
              
            if (TextBox18.Text == TextBox6.Text)
            {
                SqlConnection con11 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda11 = new SqlDataAdapter("delete from b_has where Bus_License_no='" + TextBox14.Text + "' and Bus_Stop_point='" + TextBox15.Text + "' ", con11);
                DataTable dt11 = new DataTable();
                sda11.Fill(dt11);
                SqlConnection con111 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda111 = new SqlDataAdapter("Select *from b_has where bus_license_no='" + TextBox14.Text + "' order by s_no", con111);
                DataTable dt111 = new DataTable();
                sda111.Fill(dt111);
                Repeater2.DataSource = dt111;
                Repeater2.DataBind();
            }
            else { msgbox("No permission"); }
            UpdatePanel7.Update();
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (TextBox20.Text != "") { 
            SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda1 = new SqlDataAdapter("select select_.Bus_Stop_point,Location,Road_no,Road_name,l1,l2,l3,l4, Stuff_id as Approved_by,Date from select_ ,stop_office where stop_office.Bus_Stop_point=select_.Bus_Stop_point and Road_no='" + TextBox20.Text + "'", con1);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            Repeater1.DataSource = dt1;
            Repeater1.DataBind(); }
            if (TextBox23.Text != "")
            {
                SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1 = new SqlDataAdapter("select select_.Bus_Stop_point,Location,Road_no,Road_name, Stuff_id as Approved_by,Date from select_ ,stop_office where stop_office.Bus_Stop_point=select_.Bus_Stop_point and (Location like'%" + TextBox23.Text + "' or Location like'%" + TextBox23.Text + "%' or Location like'" + TextBox23.Text + "%')", con1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }

                int rowid = (e.Item.ItemIndex);
            TextBox t = (TextBox)Repeater1.Items[rowid].FindControl("TextBox19") as TextBox;
          

            TextBox10.Text = t.Text;
            UpdatePanel1.Update();
        }

        protected void Button17_Click(object sender, EventArgs e)
        {
            TextBox23.Text = "";
            SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda1 = new SqlDataAdapter("select select_.Bus_Stop_point,Location,Road_no,Road_name,l1,l2,l3,l4, Stuff_id as Approved_by,Date from select_ ,stop_office where stop_office.Bus_Stop_point=select_.Bus_Stop_point and Road_no='"+TextBox20.Text+"'", con1);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            Repeater1.DataSource = dt1;
            Repeater1.DataBind();
            UpdatePanel3.Update();
        }

        protected void Button18_Click(object sender, EventArgs e)
        {
            TextBox20.Text = "";
            SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda1 = new SqlDataAdapter("select select_.Bus_Stop_point,Location,Road_no,Road_name,l1,l2,l3,l4, Stuff_id as Approved_by,Date from select_ ,stop_office where stop_office.Bus_Stop_point=select_.Bus_Stop_point and (Location like'%" + TextBox23.Text + "' or Location like'%" + TextBox23.Text + "%' or Location like'" + TextBox23.Text + "%')", con1);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            Repeater1.DataSource = dt1;
            Repeater1.DataBind();
            UpdatePanel3.Update();
        }

        protected void Button19_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda1 = new SqlDataAdapter("select select_.Bus_Stop_point,Location,Road_no,Road_name,l1,l2,l3,l4, Stuff_id as Approved_by,Date from select_ ,stop_office where stop_office.Bus_Stop_point=select_.Bus_Stop_point", con1);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            Repeater1.DataSource = dt1;
            Repeater1.DataBind();
            UpdatePanel3.Update();
        }

        protected void Repeater2_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            int rowid = (e.Item.ItemIndex);
            TextBox t1 = (TextBox)Repeater2.Items[rowid].FindControl("TextBox24") as TextBox;
            TextBox t2 = (TextBox)Repeater2.Items[rowid].FindControl("TextBox13") as TextBox;
            TextBox t3 = (TextBox)Repeater2.Items[rowid].FindControl("TextBox25") as TextBox;
            TextBox t4 = (TextBox)Repeater2.Items[rowid].FindControl("TextBox26") as TextBox;
            TextBox t5= (TextBox)Repeater2.Items[rowid].FindControl("TextBox27") as TextBox;

            TextBox18.Text = t1.Text;
            TextBox14.Text = t2.Text;
            TextBox15.Text = t3.Text;
            TextBox16.Text =t4.Text;
            TextBox17.Text = t5.Text;
            UpdatePanel12.Update();
            UpdatePanel11.Update();
            UpdatePanel13.Update();
            UpdatePanel14.Update();
            
           
        }

        protected void Repeater3_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
           
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
              
            string s = "";

            int rowid = (e.Item.ItemIndex);
            TextBox t1 = (TextBox)Repeater3.Items[rowid].FindControl("TextBox28") as TextBox;
            s = t1.Text;
            SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda = new SqlDataAdapter("update stop_office set approved='approved' where Bus_Stop_point='"+s+"' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Class1 d = new Class1();
            d.Bus_Stop_point = s;
            d.Stuff_id = TextBox6.Text;
            d.Date = DateTime.Now.ToString("hh:mm tt dd MMM yyyy");
            if (d.DataSaveInselect()) { }
            SqlConnection conf = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sdaf = new SqlDataAdapter("select Bus_Stop_point,Location,Road_no,Road_name,login_id as Request_id from stop_office where Approved='' and Bus_Stop_point!=''", conf);
            DataTable dtf = new DataTable();
            sdaf.Fill(dtf);
            Repeater3.DataSource = dtf;
            Repeater3.DataBind();
            SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda1 = new SqlDataAdapter("select select_.Bus_Stop_point,Location,Road_no,Road_name,l1,l2,l3,l4, Stuff_id as Approved_by,Date from select_ ,stop_office where stop_office.Bus_Stop_point=select_.Bus_Stop_point", con1);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            Repeater1.DataSource = dt1;
            Repeater1.DataBind();
           
        }

        protected void Button22_Click(object sender, EventArgs e)
        {
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
              
            SqlConnection con11 = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda11 = new SqlDataAdapter("Select *from b_has order by s_no", con11);
            DataTable dt11 = new DataTable();
            sda11.Fill(dt11);
            Repeater2.DataSource = dt11;
            Repeater2.DataBind();
            UpdatePanel7.Update();
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
           
        }

        protected void Button23_Click(object sender, EventArgs e)
        {
            SqlConnection convbb = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sdavbb = new SqlDataAdapter("update login_table set e_h='1' where login_id='" + Session["ID"].ToString() + "'", convbb);
            DataTable dtvbb = new DataTable();
            sdavbb.Fill(dtvbb);
            if (TextBox33.Text == "" || TextBox34.Text == "" || TextBox35.Text == "" || TextBox36.Text == "" || TextBox37.Text == "")
            {
                msgbox("Complete all field");
                
            }
            else
            {
                SqlConnection con11 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda11 = new SqlDataAdapter("update stop_office set l1='" + TextBox34.Text + "',l2='" + TextBox35.Text + "',l3='" + TextBox36.Text + "',l4='" + TextBox37.Text + "' where Bus_Stop_point='" + TextBox33.Text + "' ", con11);
                DataTable dt11 = new DataTable();
                sda11.Fill(dt11);


                SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1 = new SqlDataAdapter("select select_.Bus_Stop_point,Location,Road_no,Road_name,l1,l2,l3,l4, Stuff_id as Approved_by,Date from select_ ,stop_office where stop_office.Bus_Stop_point=select_.Bus_Stop_point and stop_office.bus_stop_point='" + TextBox33.Text + "'", con1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
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