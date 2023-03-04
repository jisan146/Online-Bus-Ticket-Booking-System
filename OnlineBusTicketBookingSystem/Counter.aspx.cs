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
    public partial class Counter : System.Web.UI.Page
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
           // TextBox17.Text = DateTime.Now.ToString("dd-MMM-yyy");
            if (Session["ID"] != null)
            {
                Button1.Visible = true;
                TextBox5.Text = Session["ID"].ToString();

            }
            else { Response.Redirect("home.aspx"); }
            SqlConnection con111 = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda111 = new SqlDataAdapter("select b_has.s_no, b_has.Bus_License_no,b_has.Bus_Stop_point,KM,Location,Road_no,Road_name,Stuff_id as Approved_by from b_has,have,stop_office where have.Bus_License_no=b_has.Bus_License_no and stop_office.Bus_Stop_point=b_has.Bus_Stop_point and Owner_id='" + TextBox5.Text + "' order by bus_stop_point", con111);
            DataTable dt111 = new DataTable();
            sda111.Fill(dt111);
            Repeater1.DataSource = dt111;
            Repeater1.DataBind();

            SqlConnection con11 = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda11 = new SqlDataAdapter("select stuff_.Stuff_id,Contact_number,Email_id,Current_address,Emargency_contact_No,Permanent_address,DOB,Country,Register_date,picture from appoint,stuff_ where stuff_.Stuff_id=appoint.Stuff_id and Owner_id='" + TextBox5.Text + "' and Stuff_Type='Counter_Stuff'", con11);
            DataTable dt11 = new DataTable();
            sda11.Fill(dt11);
            Repeater3.DataSource = dt11;
            Repeater3.DataBind();

            SqlConnection con1111 = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda1111 = new SqlDataAdapter("select time_schedule.Bus_License_no,Bus_Stop_point,Stop_time,KM as AM_or_PM,Stuff_id from time_schedule,have where time_schedule.Bus_License_no=have.Bus_License_no and Owner_id='" + TextBox5.Text + "' order by bus_stop_point", con1111);
            DataTable dt1111 = new DataTable();
            sda1111.Fill(dt1111);
            Repeater2.DataSource = dt1111;
            Repeater2.DataBind();

            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
              
        }
        private void msgbox1(string msg1) { ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "CallMyFunction", "alert('" + msg1 + "')", true); }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
              
            int xxx = -1, zzz = -1;
          
            try {
                xxx = int.Parse(TextBox6.Text);
                zzz = int.Parse(TextBox7.Text);
            }
            catch { msgbox1("insert correct time"); }
            if (xxx > 0 && zzz > -1)
            {
                TextBox8.Text = DropDownList1.Text;
                if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox4.Text == "" || TextBox6.Text == "" || TextBox7.Text == "" || TextBox8.Text == "") { msgbox("Complete all field"); } else { }
                TextBox3.Text = TextBox6.Text + "." + TextBox7.Text;

                Class1 d = new Class1();
                d.Bus_License_no = TextBox1.Text;
                d.Bus_Stop_point = TextBox2.Text;
                d.stop_time = TextBox3.Text;
                d.Stuff_id = TextBox4.Text;
                d.KM = TextBox8.Text;
                d.pass = "";
                if (d.DataSaveInst())
                {
                    msgbox1("sucessfull");
                    TextBox6.Text = "";
                    TextBox7.Text = "";
                   
                    Class1 d2 = new Class1();
                    d2.Bus_License_no = TextBox1.Text;
                    if (d2.QueryIncount()) { TextBox9.Text = d2.s_no; }
                    Class1 d1 = new Class1();
                    d1.Bus_License_no = TextBox1.Text;

                    if (d1.QueryIncount1()) { TextBox10.Text = d1.s_no; }
                    int a, b; float c;
                    a = int.Parse(TextBox9.Text);
                    b = int.Parse(TextBox10.Text);
                    c = b % a;
                    TextBox10.Text = c.ToString();
                    if (c != 0)
                    {
                        msgbox("Time schedule mismacth for this bus");
                        TextBox34.Visible = true;
                        SqlConnection con1111 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                        SqlDataAdapter sda1111 = new SqlDataAdapter("update L_approved set Time='miss' where Bus_License_no='" + TextBox1.Text + "'", con1111);
                        DataTable dt1111 = new DataTable();
                        sda1111.Fill(dt1111);

                    }
                    else
                    {
                        TextBox34.Visible = false;
                        SqlConnection con1111 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                        SqlDataAdapter sda1111 = new SqlDataAdapter("update L_approved set Time='' where Bus_License_no='" + TextBox1.Text + "'", con1111);
                        DataTable dt1111 = new DataTable();
                        sda1111.Fill(dt1111);
                    }
                }
                else { msgbox("Fail"); }
                SqlConnection con111 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda111 = new SqlDataAdapter("select b_has.s_no, b_has.Bus_License_no,b_has.Bus_Stop_point,KM,Location,Road_no,Road_name,Stuff_id as Approved_by from b_has,have,stop_office where have.Bus_License_no=b_has.Bus_License_no and stop_office.Bus_Stop_point=b_has.Bus_Stop_point and Owner_id='" + TextBox5.Text + "' order by bus_stop_point", con111);
                DataTable dt111 = new DataTable();
                sda111.Fill(dt111);
                Repeater1.DataSource = dt111;
                Repeater1.DataBind();

                SqlConnection con11 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda11 = new SqlDataAdapter("select stuff_.Stuff_id,Contact_number,Email_id,Current_address,Emargency_contact_No,Permanent_address,DOB,Country,Register_date,picture from appoint,stuff_ where stuff_.Stuff_id=appoint.Stuff_id and Owner_id='" + TextBox5.Text + "' and Stuff_Type='Counter_Stuff'", con11);
                DataTable dt11 = new DataTable();
                sda11.Fill(dt11);
                Repeater3.DataSource = dt11;
                Repeater3.DataBind();

                SqlConnection con1111g = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1111g = new SqlDataAdapter("select time_schedule.Bus_License_no,Bus_Stop_point,Stop_time,KM as AM_or_PM,Stuff_id from time_schedule,have where time_schedule.Bus_License_no=have.Bus_License_no and Owner_id='" + TextBox5.Text + "' order by bus_stop_point", con1111g);
                DataTable dt1111g = new DataTable();
                sda1111g.Fill(dt1111g);
                Repeater2.DataSource = dt1111g;
                Repeater2.DataBind();
            }
            else { msgbox1("Time Format  is not correct"); }

        }

        protected void GridView4_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* GridViewRow row = GridView4.SelectedRow;
            TextBox1.Text = row.Cells[2].Text;
            TextBox2.Text = row.Cells[3].Text;
            Class1 d2 = new Class1();
            d2.Bus_License_no = TextBox1.Text;
            if (d2.QueryIncount()) { TextBox9.Text = d2.s_no; }
            Class1 d1 = new Class1();
            d1.Bus_License_no = TextBox1.Text;

            if (d1.QueryIncount1()) { TextBox10.Text = d1.s_no; }
            int a, b; float c;
            a = int.Parse(TextBox9.Text);
            b = int.Parse(TextBox10.Text);
            c = b % a;
            TextBox10.Text = c.ToString();
            if (c != 0)
            {
                msgbox("Time schedule mismacth for this bus");
                SqlConnection con1111 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1111 = new SqlDataAdapter("update L_approved set Time='miss' where Bus_License_no='" + TextBox1.Text + "'", con1111);
                DataTable dt1111 = new DataTable();
                sda1111.Fill(dt1111);

            }
            else
            {
                SqlConnection con1111 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1111 = new SqlDataAdapter("update L_approved set Time='' where Bus_License_no='" + TextBox1.Text + "'", con1111);
                DataTable dt1111 = new DataTable();
                sda1111.Fill(dt1111);
            }*/
        }

        protected void GridView5_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* GridViewRow row = GridView5.SelectedRow;
            TextBox4.Text = row.Cells[2].Text;
            Class1 d = new Class1();
            d.Pessenger_id = TextBox4.Text+"-c";
            d.Travel_date = TextBox17.Text;
            if (d.QueryInsum()) { TextBox19.Text = d.s_no; }*/
        }

        protected void GridView6_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* string a, b, c, d, f;
            GridViewRow row = GridView6.SelectedRow;
            a = row.Cells[1].Text;
            b = row.Cells[2].Text;
            TextBox1.Text = row.Cells[1].Text;
            TextBox2.Text = row.Cells[2].Text;
            c = row.Cells[3].Text;
            d = row.Cells[4].Text;
            f = row.Cells[5].Text;
            SqlConnection con11111 = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda11111 = new SqlDataAdapter("delete from time_schedule where Bus_License_no='"+a+"' and Bus_Stop_point='"+b+"' and Stop_time='"+c+"' and KM='"+d+"' and Stuff_id='"+f+"'", con11111);
            DataTable dt11111 = new DataTable();
            sda11111.Fill(dt11111);
            SqlConnection con1111 = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda1111 = new SqlDataAdapter("select time_schedule.Bus_License_no,Bus_Stop_point,Stop_time,KM as AM_or_PM,Stuff_id from time_schedule,have where time_schedule.Bus_License_no=have.Bus_License_no and Owner_id='" + TextBox5.Text + "' order by bus_stop_point", con1111);
            DataTable dt1111 = new DataTable();
            sda1111.Fill(dt1111);
            Repeater2.DataSource = dt1111;
            Repeater2.DataBind();
            Class1 d2 = new Class1();
            d2.Bus_License_no = TextBox1.Text;
            if (d2.QueryIncount()) { TextBox9.Text = d2.s_no; }
            Class1 d1 = new Class1();
            d1.Bus_License_no = TextBox1.Text;

            if (d1.QueryIncount1()) { TextBox10.Text = d1.s_no; }
            int aa, ba; float ca;
            aa = int.Parse(TextBox9.Text);
            ba = int.Parse(TextBox10.Text);
            ca = ba % aa;
            TextBox10.Text = ca.ToString();
            if (ca != 0)
            {
                msgbox("Time schedule mismacth for this bus");
                SqlConnection con1111w = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1111w = new SqlDataAdapter("update L_approved set Time='miss' where Bus_License_no='" + TextBox1.Text + "'", con1111w);
                DataTable dt1111w = new DataTable();
                sda1111w.Fill(dt1111w);

            }
            else
            {
                SqlConnection con1111w = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1111w = new SqlDataAdapter("update L_approved set Time='' where Bus_License_no='" + TextBox1.Text + "'", con1111w);
                DataTable dt1111w = new DataTable();
                sda1111w.Fill(dt1111w);
            }*/
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("user.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection con111 = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda111 = new SqlDataAdapter("select b_has.s_no, b_has.Bus_License_no,b_has.Bus_Stop_point,KM,Location,Road_no,Road_name,Stuff_id as Approved_by from b_has,have,stop_office where have.Bus_License_no=b_has.Bus_License_no and stop_office.Bus_Stop_point=b_has.Bus_Stop_point and Owner_id='" + TextBox5.Text + "' and b_has.bus_license_no='"+TextBox11.Text+"' order by bus_stop_point", con111);
            DataTable dt111 = new DataTable();
            sda111.Fill(dt111);
            Repeater1.DataSource = dt111;
            Repeater1.DataBind();

            SqlConnection con1111 = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda1111 = new SqlDataAdapter("select time_schedule.Bus_License_no,Bus_Stop_point,Stop_time,KM as AM_or_PM,Stuff_id from time_schedule,have where time_schedule.Bus_License_no=have.Bus_License_no and Owner_id='" + TextBox5.Text + "' and time_schedule.bus_license_no='" + TextBox11.Text + "' order by bus_stop_point", con1111);
            DataTable dt1111 = new DataTable();
            sda1111.Fill(dt1111);
            Repeater2.DataSource = dt1111;
            Repeater2.DataBind();
            UpdatePanel1.Update();
            UpdatePanel5.Update();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            SqlConnection con111 = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda111 = new SqlDataAdapter("select b_has.s_no, b_has.Bus_License_no,b_has.Bus_Stop_point,KM,Location,Road_no,Road_name,Stuff_id as Approved_by from b_has,have,stop_office where have.Bus_License_no=b_has.Bus_License_no and stop_office.Bus_Stop_point=b_has.Bus_Stop_point and Owner_id='" + TextBox5.Text + "' order by bus_stop_point", con111);
            DataTable dt111 = new DataTable();
            sda111.Fill(dt111);
            Repeater1.DataSource = dt111;
            Repeater1.DataBind();
            UpdatePanel1.Update();
            UpdatePanel5.Update();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            SqlConnection con11 = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda11 = new SqlDataAdapter("select stuff_.Stuff_id,Contact_number,Email_id,Current_address,Emargency_contact_No,Permanent_address,DOB,Country,Register_date,picture from appoint,stuff_ where stuff_.Stuff_id=appoint.Stuff_id and Owner_id='" + TextBox5.Text + "' and Stuff_Type='Counter_Stuff' and appoint.stuff_id='"+TextBox12.Text+"'", con11);
            DataTable dt11 = new DataTable();
            sda11.Fill(dt11);
            Repeater3.DataSource = dt11;
            Repeater3.DataBind();
            UpdatePanel4.Update();
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            SqlConnection con11 = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda11 = new SqlDataAdapter("select stuff_.Stuff_id,Contact_number,Email_id,Current_address,Emargency_contact_No,Permanent_address,DOB,Country,Register_date,picture from appoint,stuff_ where stuff_.Stuff_id=appoint.Stuff_id and Owner_id='" + TextBox5.Text + "' and Stuff_Type='Counter_Stuff'", con11);
            DataTable dt11 = new DataTable();
            sda11.Fill(dt11);
            Repeater3.DataSource = dt11;
            Repeater3.DataBind();
            UpdatePanel4.Update();
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            SqlConnection con1111 = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda1111 = new SqlDataAdapter("select time_schedule.Bus_License_no,Bus_Stop_point,Stop_time,KM as AM_or_PM,Stuff_id from time_schedule,have where time_schedule.Bus_License_no=have.Bus_License_no and Owner_id='" + TextBox5.Text + "' order by bus_stop_point", con1111);
            DataTable dt1111 = new DataTable();
            sda1111.Fill(dt1111);
            Repeater2.DataSource = dt1111;
            Repeater2.DataBind();
            UpdatePanel1.Update();
            UpdatePanel5.Update();
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            SqlConnection con1111 = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda1111 = new SqlDataAdapter("select time_schedule.Bus_License_no,Bus_Stop_point,Stop_time,KM as AM_or_PM,Stuff_id from time_schedule,have where time_schedule.Bus_License_no=have.Bus_License_no and Owner_id='" + TextBox5.Text + "' and time_schedule.bus_stop_point='" + TextBox13.Text + "' and time_schedule.bus_license_no='" + TextBox11.Text + "' order by bus_stop_point", con1111);
            DataTable dt1111 = new DataTable();
            sda1111.Fill(dt1111);
            Repeater2.DataSource = dt1111;
            Repeater2.DataBind();
            UpdatePanel1.Update();
            UpdatePanel5.Update();
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            /*Class1 d = new Class1();
            d.Pessenger_id =TextBox15.Text;
            d.Travel_date = TextBox17.Text;
            if (d.QueryInsum()) { TextBox19.Text = d.s_no; }*/

        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (TextBox11.Text!="")
            {
                SqlConnection con111 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda111 = new SqlDataAdapter("select b_has.s_no, b_has.Bus_License_no,b_has.Bus_Stop_point,KM,Location,Road_no,Road_name,Stuff_id as Approved_by from b_has,have,stop_office where have.Bus_License_no=b_has.Bus_License_no and stop_office.Bus_Stop_point=b_has.Bus_Stop_point and Owner_id='" + TextBox5.Text + "' and b_has.bus_license_no='" + TextBox11.Text + "' order by bus_stop_point", con111);
                DataTable dt111 = new DataTable();
                sda111.Fill(dt111);
                Repeater1.DataSource = dt111;
                Repeater1.DataBind();

                SqlConnection con1111 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1111 = new SqlDataAdapter("select time_schedule.Bus_License_no,Bus_Stop_point,Stop_time,KM as AM_or_PM,Stuff_id from time_schedule,have where time_schedule.Bus_License_no=have.Bus_License_no and Owner_id='" + TextBox5.Text + "' and time_schedule.bus_license_no='" + TextBox11.Text + "' order by bus_stop_point", con1111);
                DataTable dt1111 = new DataTable();
                sda1111.Fill(dt1111);
                Repeater2.DataSource = dt1111;
                Repeater2.DataBind();
            }
            int rowid = (e.Item.ItemIndex);
            TextBox t = (TextBox)Repeater1.Items[rowid].FindControl("TextBox16") as TextBox;
            TextBox t1 = (TextBox)Repeater1.Items[rowid].FindControl("TextBox15") as TextBox;


            TextBox1.Text = t.Text;
            TextBox2.Text = t1.Text;
           
            Class1 d2 = new Class1();
            d2.Bus_License_no = TextBox1.Text;
            if (d2.QueryIncount()) { TextBox9.Text = d2.s_no; }
            Class1 d1 = new Class1();
            d1.Bus_License_no = TextBox1.Text;

            if (d1.QueryIncount1()) { TextBox10.Text = d1.s_no; }
            int a, b; float c;
            a = int.Parse(TextBox9.Text);
            b = int.Parse(TextBox10.Text);
            c = b % a;
            TextBox10.Text = c.ToString();
            if (c != 0)
            {
                msgbox("Time schedule mismacth for this bus");
                TextBox34.Visible = true;

                SqlConnection con1111 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1111 = new SqlDataAdapter("update L_approved set Time='miss' where Bus_License_no='" + TextBox1.Text + "'", con1111);
                DataTable dt1111 = new DataTable();
                sda1111.Fill(dt1111);

            }
            else
            {
                TextBox34.Visible = false;
                SqlConnection con1111 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1111 = new SqlDataAdapter("update L_approved set Time='' where Bus_License_no='" + TextBox1.Text + "'", con1111);
                DataTable dt1111 = new DataTable();
                sda1111.Fill(dt1111);
            }
        }

        protected void Repeater2_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (TextBox13.Text!="")
            {
                SqlConnection con111111 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda111111 = new SqlDataAdapter("select time_schedule.Bus_License_no,Bus_Stop_point,Stop_time,KM as AM_or_PM,Stuff_id from time_schedule,have where time_schedule.Bus_License_no=have.Bus_License_no and Owner_id='" + TextBox5.Text + "' and time_schedule.bus_stop_point='" + TextBox13.Text + "' and time_schedule.bus_license_no='" + TextBox11.Text + "' order by bus_stop_point", con111111);
                DataTable dt111111 = new DataTable();
                sda111111.Fill(dt111111);
                Repeater2.DataSource = dt111111;
                Repeater2.DataBind();
            }
            int rowid = (e.Item.ItemIndex);
            TextBox t = (TextBox)Repeater2.Items[rowid].FindControl("TextBox20") as TextBox;
            TextBox t1 = (TextBox)Repeater2.Items[rowid].FindControl("TextBox21") as TextBox;
            TextBox t2 = (TextBox)Repeater2.Items[rowid].FindControl("TextBox22") as TextBox;
            TextBox t3 = (TextBox)Repeater2.Items[rowid].FindControl("TextBox23") as TextBox;
            TextBox t4 = (TextBox)Repeater2.Items[rowid].FindControl("TextBox24") as TextBox;


          

            string a, b, c, d, f;
          
            a = t.Text;
            b = t1.Text;
            TextBox1.Text =t.Text;
            TextBox2.Text = t1.Text;
            c = t2.Text;
            d = t3.Text;
            f = t4.Text;
            SqlConnection con11111 = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda11111 = new SqlDataAdapter("delete from time_schedule where Bus_License_no='" + a + "' and Bus_Stop_point='" + b + "' and Stop_time='" + c + "' and KM='" + d + "' and Stuff_id='" + f + "'", con11111);
            DataTable dt11111 = new DataTable();
            sda11111.Fill(dt11111);
            SqlConnection con1111 = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda1111 = new SqlDataAdapter("select time_schedule.Bus_License_no,Bus_Stop_point,Stop_time,KM as AM_or_PM,Stuff_id from time_schedule,have where time_schedule.Bus_License_no=have.Bus_License_no and Owner_id='" + TextBox5.Text + "' order by bus_stop_point", con1111);
            DataTable dt1111 = new DataTable();
            sda1111.Fill(dt1111);
            Repeater2.DataSource = dt1111;
            Repeater2.DataBind();
            Class1 d2 = new Class1();
            d2.Bus_License_no = TextBox1.Text;
            if (d2.QueryIncount()) { TextBox9.Text = d2.s_no; }
            Class1 d1 = new Class1();
            d1.Bus_License_no = TextBox1.Text;

            if (d1.QueryIncount1()) { TextBox10.Text = d1.s_no; }
            int aa, ba; float ca;
            aa = int.Parse(TextBox9.Text);
            ba = int.Parse(TextBox10.Text);
            ca = ba % aa;
            TextBox10.Text = ca.ToString();
            if (ca != 0)
            {
                TextBox34.Visible = true;
                msgbox("Time schedule mismacth for this bus");
                SqlConnection con1111w = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1111w = new SqlDataAdapter("update L_approved set Time='miss' where Bus_License_no='" + TextBox1.Text + "'", con1111w);
                DataTable dt1111w = new DataTable();
                sda1111w.Fill(dt1111w);

            }
            else
            {
                TextBox34.Visible = false;
                SqlConnection con1111w = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1111w = new SqlDataAdapter("update L_approved set Time='' where Bus_License_no='" + TextBox1.Text + "'", con1111w);
                DataTable dt1111w = new DataTable();
                sda1111w.Fill(dt1111w);
            }
        }

        protected void Repeater3_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (TextBox12.Text!="") {
                SqlConnection con11 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda11 = new SqlDataAdapter("select stuff_.Stuff_id,Contact_number,Email_id,Current_address,Emargency_contact_No,Permanent_address,DOB,Country,Register_date,picture from appoint,stuff_ where stuff_.Stuff_id=appoint.Stuff_id and Owner_id='" + TextBox5.Text + "' and Stuff_Type='Counter_Stuff' and appoint.stuff_id='" + TextBox12.Text + "'", con11);
                DataTable dt11 = new DataTable();
                sda11.Fill(dt11);
                Repeater3.DataSource = dt11;
                Repeater3.DataBind();

            }

            int rowid = (e.Item.ItemIndex);
            TextBox t = (TextBox)Repeater3.Items[rowid].FindControl("TextBox25") as TextBox;
           


         

            TextBox4.Text = t.Text;
            Class1 d = new Class1();
            d.Pessenger_id = t.Text + "-c";
            d.Travel_date = TextBox17.Text;
            if (d.QueryInsum()) { TextBox19.Text = d.s_no; }
            UpdatePanel14.Update();
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