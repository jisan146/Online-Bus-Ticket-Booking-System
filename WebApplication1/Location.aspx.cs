using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Timers;
namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
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
            if (Session["bus"] == null && Session["ID"] == null)
            { Response.Redirect("home.aspx"); }
                if (Session["bus"] != null)
                {

                    Class1 g = new Class1();
                    g.login_id = Session["bus"].ToString();
                    if (g.g()) { TextBox4.Text = g.admin_id; TextBox5.Text = g.s_no; TextBox6.Text = g.Road_name; }

                Button2.Visible = false;
                ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "CallMyFunction", "getLocation()", true);


                SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1 = new SqlDataAdapter("select *from gps where id='" + Session["bus"].ToString() + "' ", con1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);

               // rptMarkers.DataSource = dt1;
                //rptMarkers.DataBind();

            }
            if (Session["ID"] != null)
            {
                if (Session["bu"] != null) {
                
                Label1.Visible = false;
                TextBox3.Visible = false;
                Button3.Visible = false;
                Button1.Visible = false;
                Class1 g = new Class1();
                g.login_id = Session["bu"].ToString();
                if (g.g()) { TextBox4.Text = g.admin_id; TextBox5.Text = g.s_no; TextBox6.Text = g.Road_name; }
                Panel1.Visible = false;
                Label1.Visible = false;
                Label2.Visible = false;
                Label3.Visible = false;
                Label5.Visible = false;
                TextBox1.Visible = false;
                TextBox2.Visible = false;
                TextBox3.Visible = false;
                TextBox8.Visible = false;
                SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1 = new SqlDataAdapter("select *from gps where id='"+Session["bu"].ToString()+"' ", con1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                }
               // rptMarkers.DataSource = dt1;
                //rptMarkers.DataBind();
               
            }


            }



        protected void Timer1_Tick(object sender, EventArgs e)
        {
            if (Session["bus"] != null)
            {
               
                ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "CallMyFunction", "getLocation()", true);
                Class1 d = new Class1();
                d.Bus_License_no = Session["bus"].ToString();
                d.Start_location = TextBox1.Text;
                d.End_location = TextBox2.Text;
                d.DOB = Session["bus"].ToString();
                if (d.DataSaveIngps()) { } else { }
                SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda = new SqlDataAdapter("update GPS set Latitude='" + TextBox1.Text + "',Longitude='" + TextBox2.Text + "' where id='" + Session["bus"].ToString() + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (TextBox1.Text != "")
                {
                    SqlConnection cony = new SqlConnection(Properties.Settings.Default._ConnectionString);
                    SqlDataAdapter sday = new SqlDataAdapter("update L_approved set g='' where bus_license_no='" + Session["bus"].ToString() + "'", cony);
                    DataTable dty = new DataTable();
                    sday.Fill(dty);
                }
                else
                {
                    SqlConnection cony = new SqlConnection(Properties.Settings.Default._ConnectionString);
                    SqlDataAdapter sday = new SqlDataAdapter("update L_approved set g='off' where bus_license_no='" + Session["bus"].ToString() + "'", cony);
                    DataTable dty = new DataTable();
                    sday.Fill(dty);
                }


            }
            int zzz;
            zzz = int.Parse(TextBox7.Text);
            zzz = zzz + 1;
            TextBox7.Text = zzz.ToString();
            if (Session["bus"] != null)
            {
                if (zzz == 1)
                {
                    Class1 g = new Class1();
                    g.login_id = Session["bus"].ToString();
                    if (g.g()) { TextBox4.Text = g.admin_id; TextBox5.Text = g.s_no; TextBox6.Text = g.Road_name; }
                    ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "myScript", "myMap()", true);
                    TextBox7.Text = "2";

                }
                if (zzz == 6)
                {
                    Class1 g = new Class1();
                    g.login_id = Session["bus"].ToString();
                    if (g.g()) { TextBox4.Text = g.admin_id; TextBox5.Text = g.s_no; TextBox6.Text = g.Road_name; }
                    ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "myScript", "myMap()", true);
                    TextBox7.Text = "2";
                }
            }
            if (Session["bu"] != null)
            {
                if (zzz == 1)
                {
                    Class1 g = new Class1();
                    g.login_id = Session["bu"].ToString();
                    if (g.g()) { TextBox4.Text = g.admin_id; TextBox5.Text = g.s_no; TextBox6.Text = g.Road_name; }
                    ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "myScript", "myMap()", true);
                    TextBox7.Text = "2";

                }
                if (zzz == 6)
                {
                    Class1 g = new Class1();
                    g.login_id = Session["bu"].ToString();
                    if (g.g()) { TextBox4.Text = g.admin_id; TextBox5.Text = g.s_no; TextBox6.Text = g.Road_name; }
                    ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "myScript", "myMap()", true);
                    TextBox7.Text = "2";
                }
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            SqlConnection conr = new SqlConnection(Properties.Settings.Default._ConnectionString);
            conr.Close();
            Response.Redirect("home.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session["bu"] = "";
            Response.Redirect("ticket.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Page.ClientScript.RegisterStartupScript(
          this.GetType(), "OpenWindow", "window.open('navigation.aspx','_newtab');", true);
           // Response.Redirect("navigation.aspx");
        }
        private void msgbox(string msg) { ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "CallMyFunction", "alert('" + msg + "')", true); }
        protected void Button3_Click1(object sender, EventArgs e)
        {  Class1 dr = new Class1();
        dr.login_id = Session["gpp"].ToString() ;
            dr.log_password = TextBox8.Text;
            if (dr.QueryInlogin1())
            {
                SqlConnection con11 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda11 = new SqlDataAdapter("update gps set description='" + Session["bus"].ToString() + " " + TextBox3.Text + "' where id='" + Session["bus"].ToString() + "'", con11);
                DataTable dt11 = new DataTable();
                sda11.Fill(dt11);
                TextBox3.Text = "";

                Class1 g = new Class1();
                g.login_id = Session["bus"].ToString();
                if (g.g()) { TextBox4.Text = g.admin_id; TextBox5.Text = g.s_no; TextBox6.Text = g.Road_name; }
                TextBox7.Text = "0";
            }
            else { msgbox("password not match"); }
        }

        protected void Timer2_Tick(object sender, EventArgs e)
        {
           
        }

        protected void Timer2_Tick1(object sender, EventArgs e)
        {
           
        }

        protected void Timer2_Tick2(object sender, EventArgs e)
        {
            if (Session["ID"] != null)
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
}
 